namespace JDE.Abstractions.Exceptions;

/// <summary>
/// Base exception for all JDE Query Library exceptions.
/// </summary>
public class JdeException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JdeException"/> class.
    /// </summary>
    public JdeException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The error message.</param>
    public JdeException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeException"/> class with a specified error message and inner exception.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="innerException">The inner exception.</param>
    public JdeException(string message, Exception innerException) : base(message, innerException)
    {
    }
}

/// <summary>
/// Exception thrown when a database operation fails.
/// </summary>
public class JdeDataException : JdeException
{
    /// <summary>
    /// Gets the SQL that caused the exception.
    /// </summary>
    public string? Sql { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeDataException"/> class.
    /// </summary>
    public JdeDataException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeDataException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The error message.</param>
    public JdeDataException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeDataException"/> class with a specified error message and SQL.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="sql">The SQL that caused the exception.</param>
    public JdeDataException(string message, string sql) : base(message)
    {
        Sql = sql;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeDataException"/> class with a specified error message and inner exception.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="innerException">The inner exception.</param>
    public JdeDataException(string message, Exception innerException) : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeDataException"/> class with a specified error message, SQL, and inner exception.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="sql">The SQL that caused the exception.</param>
    /// <param name="innerException">The inner exception.</param>
    public JdeDataException(string message, string sql, Exception innerException) : base(message, innerException)
    {
        Sql = sql;
    }
}

/// <summary>
/// Exception thrown when configuration is invalid.
/// </summary>
public class JdeConfigurationException : JdeException
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JdeConfigurationException"/> class.
    /// </summary>
    public JdeConfigurationException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeConfigurationException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The error message.</param>
    public JdeConfigurationException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeConfigurationException"/> class with a specified error message and inner exception.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="innerException">The inner exception.</param>
    public JdeConfigurationException(string message, Exception innerException) : base(message, innerException)
    {
    }
}

/// <summary>
/// Exception thrown when metadata is not found or invalid.
/// </summary>
public class JdeMetadataException : JdeException
{
    /// <summary>
    /// Gets the table name related to the exception.
    /// </summary>
    public string? TableName { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeMetadataException"/> class.
    /// </summary>
    public JdeMetadataException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeMetadataException"/> class with a specified error message.
    /// </summary>
    /// <param name="message">The error message.</param>
    public JdeMetadataException(string message) : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeMetadataException"/> class with a specified error message and table name.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="tableName">The table name related to the exception.</param>
    public JdeMetadataException(string message, string tableName) : base(message)
    {
        TableName = tableName;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="JdeMetadataException"/> class with a specified error message and inner exception.
    /// </summary>
    /// <param name="message">The error message.</param>
    /// <param name="innerException">The inner exception.</param>
    public JdeMetadataException(string message, Exception innerException) : base(message, innerException)
    {
    }
}
