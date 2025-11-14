namespace JDE.Models;

/// <summary>
/// F74B150 - .
/// </summary>
public class F74B150Model
{
    /// <summary>
    /// YTMID (Primary Key).
    /// </summary>
    public string YTMID { get; set; }

    /// <summary>
    /// YTLMEM (Primary Key).
    /// </summary>
    public string YTLMEM { get; set; }

    /// <summary>
    /// YTYR.
    /// </summary>
    public decimal? YTYR { get; set; }

    /// <summary>
    /// YTPQTR.
    /// </summary>
    public string? YTPQTR { get; set; }

    /// <summary>
    /// YTAPTA.
    /// </summary>
    public string? YTAPTA { get; set; }
}
