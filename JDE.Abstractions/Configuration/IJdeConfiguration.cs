namespace JDE.Abstractions.Configuration;

/// <summary>
/// Represents configuration settings for connecting to a JDE database.
/// </summary>
public interface IJdeConfiguration
{
    /// <summary>
    /// Gets the database connection string.
    /// </summary>
    string ConnectionString { get; }

    /// <summary>
    /// Gets the database schema name (e.g., "JDEPROD", "JDETEST").
    /// </summary>
    string Schema { get; }

    /// <summary>
    /// Gets the database provider name (e.g., "Oracle", "SqlServer").
    /// </summary>
    string Provider { get; }

    /// <summary>
    /// Gets the environment name (e.g., "DEV", "TEST", "PROD").
    /// </summary>
    string? Environment { get; }

    /// <summary>
    /// Gets the command timeout in seconds.
    /// </summary>
    int CommandTimeout { get; }

    /// <summary>
    /// Gets whether to enable retry logic for transient failures.
    /// </summary>
    bool EnableRetry { get; }

    /// <summary>
    /// Gets the maximum number of retry attempts.
    /// </summary>
    int MaxRetryAttempts { get; }
}
