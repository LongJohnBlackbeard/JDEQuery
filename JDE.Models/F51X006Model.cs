namespace JDE.Models;

/// <summary>
/// F51X006 - .
/// </summary>
public class F51X006Model
{
    /// <summary>
    /// JLUSER (Primary Key).
    /// </summary>
    public string JLUSER { get; set; }

    /// <summary>
    /// JLJOBS (Primary Key).
    /// </summary>
    public decimal JLJOBS { get; set; }

    /// <summary>
    /// JLMCU (Primary Key).
    /// </summary>
    public string JLMCU { get; set; }

    /// <summary>
    /// JLCO.
    /// </summary>
    public string? JLCO { get; set; }
}
