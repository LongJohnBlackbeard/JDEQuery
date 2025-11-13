namespace JDE.Abstractions.Configuration;

/// <summary>
/// Configuration options for JDE Query Library.
/// </summary>
public class JdeOptions : IJdeConfiguration
{
    /// <summary>
    /// Gets or sets the database connection string.
    /// </summary>
    public string ConnectionString { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the database schema name (e.g., "JDEPROD", "JDETEST").
    /// </summary>
    public string Schema { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the database provider name (e.g., "Oracle", "SqlServer").
    /// </summary>
    public string Provider { get; set; } = "Oracle";

    /// <summary>
    /// Gets or sets the environment name (e.g., "DEV", "TEST", "PROD").
    /// </summary>
    public string? Environment { get; set; }

    /// <summary>
    /// Gets or sets the command timeout in seconds. Default is 30 seconds.
    /// </summary>
    public int CommandTimeout { get; set; } = 30;

    /// <summary>
    /// Gets or sets whether to enable retry logic for transient failures. Default is true.
    /// </summary>
    public bool EnableRetry { get; set; } = true;

    /// <summary>
    /// Gets or sets the maximum number of retry attempts. Default is 3.
    /// </summary>
    public int MaxRetryAttempts { get; set; } = 3;

    /// <summary>
    /// Validates the configuration options.
    /// </summary>
    /// <exception cref="InvalidOperationException">Thrown when configuration is invalid.</exception>
    public void Validate()
    {
        if (string.IsNullOrWhiteSpace(ConnectionString))
        {
            throw new InvalidOperationException("ConnectionString is required.");
        }

        if (string.IsNullOrWhiteSpace(Schema))
        {
            throw new InvalidOperationException("Schema is required.");
        }

        if (string.IsNullOrWhiteSpace(Provider))
        {
            throw new InvalidOperationException("Provider is required.");
        }

        if (CommandTimeout <= 0)
        {
            throw new InvalidOperationException("CommandTimeout must be greater than 0.");
        }

        if (MaxRetryAttempts < 0)
        {
            throw new InvalidOperationException("MaxRetryAttempts cannot be negative.");
        }
    }
}
