using Dapper;
using JDE.Abstractions;
using JDE.Abstractions.Configuration;
using JDE.Abstractions.Exceptions;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace JDE.Providers.Oracle;

/// <summary>
/// Oracle database provider implementation using Dapper.
/// </summary>
public class OracleDbProvider : IDbProvider
{
    private readonly string _connectionString;
    private readonly int _commandTimeout;
    private bool _disposed;

    /// <summary>
    /// Initializes a new instance of the <see cref="OracleDbProvider"/> class.
    /// </summary>
    /// <param name="connectionString">The Oracle connection string.</param>
    /// <param name="commandTimeout">The command timeout in seconds.</param>
    public OracleDbProvider(string connectionString, int commandTimeout = 30)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            throw new ArgumentException("Connection string cannot be null or whitespace.", nameof(connectionString));
        }

        if (commandTimeout <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(commandTimeout), "Command timeout must be greater than 0.");
        }

        _connectionString = connectionString;
        _commandTimeout = commandTimeout;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="OracleDbProvider"/> class from configuration.
    /// </summary>
    /// <param name="configuration">The JDE configuration.</param>
    public OracleDbProvider(IJdeConfiguration configuration)
    {
        if (configuration == null)
        {
            throw new ArgumentNullException(nameof(configuration));
        }

        _connectionString = configuration.ConnectionString;
        _commandTimeout = configuration.CommandTimeout;
    }

    /// <inheritdoc />
    public string ProviderName => "Oracle";

    /// <inheritdoc />
    public async Task<T?> QuerySingleOrDefaultAsync<T>(
        string sql,
        object? param = null,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sql))
        {
            throw new ArgumentException("SQL cannot be null or whitespace.", nameof(sql));
        }

        try
        {
            using var connection = CreateConnection();
            await connection.OpenAsync(cancellationToken);

            var command = new CommandDefinition(
                sql,
                param,
                commandTimeout: _commandTimeout,
                cancellationToken: cancellationToken);

            return await connection.QuerySingleOrDefaultAsync<T>(command);
        }
        catch (OracleException ex)
        {
            throw new JdeDataException(
                $"Oracle query failed: {ex.Message}",
                sql,
                ex);
        }
        catch (Exception ex) when (ex is not JdeException)
        {
            throw new JdeDataException(
                $"Failed to execute query: {ex.Message}",
                sql,
                ex);
        }
    }

    /// <inheritdoc />
    public async Task<IEnumerable<T>> QueryAsync<T>(
        string sql,
        object? param = null,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sql))
        {
            throw new ArgumentException("SQL cannot be null or whitespace.", nameof(sql));
        }

        try
        {
            using var connection = CreateConnection();
            await connection.OpenAsync(cancellationToken);

            var command = new CommandDefinition(
                sql,
                param,
                commandTimeout: _commandTimeout,
                cancellationToken: cancellationToken);

            return await connection.QueryAsync<T>(command);
        }
        catch (OracleException ex)
        {
            throw new JdeDataException(
                $"Oracle query failed: {ex.Message}",
                sql,
                ex);
        }
        catch (Exception ex) when (ex is not JdeException)
        {
            throw new JdeDataException(
                $"Failed to execute query: {ex.Message}",
                sql,
                ex);
        }
    }

    /// <inheritdoc />
    public async Task<bool> TestConnectionAsync(CancellationToken cancellationToken = default)
    {
        try
        {
            using var connection = CreateConnection();
            await connection.OpenAsync(cancellationToken);

            // Execute simple query to test connection
            var command = new CommandDefinition(
                "SELECT 1 FROM DUAL",
                commandTimeout: _commandTimeout,
                cancellationToken: cancellationToken);

            var result = await connection.ExecuteScalarAsync<int>(command);
            return result == 1;
        }
        catch (OracleException)
        {
            return false;
        }
        catch (Exception)
        {
            return false;
        }
    }

    /// <summary>
    /// Creates a new Oracle connection.
    /// </summary>
    /// <returns>A new Oracle connection instance.</returns>
    protected virtual OracleConnection CreateConnection()
    {
        return new OracleConnection(_connectionString);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Releases resources used by the provider.
    /// </summary>
    /// <param name="disposing">True if disposing managed resources.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (!_disposed)
        {
            if (disposing)
            {
                // Cleanup managed resources if needed
            }

            _disposed = true;
        }
    }
}
