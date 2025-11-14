namespace JDE.Models;

/// <summary>
/// F46025 - .
/// </summary>
public class F46025Model
{
    /// <summary>
    /// MQMCU (Primary Key).
    /// </summary>
    public string MQMCU { get; set; }

    /// <summary>
    /// MQPZON (Primary Key).
    /// </summary>
    public string MQPZON { get; set; }

    /// <summary>
    /// MQITM (Primary Key).
    /// </summary>
    public decimal MQITM { get; set; }

    /// <summary>
    /// MQUOM (Primary Key).
    /// </summary>
    public string MQUOM { get; set; }

    /// <summary>
    /// MQMXPT.
    /// </summary>
    public decimal? MQMXPT { get; set; }

    /// <summary>
    /// MQUSER.
    /// </summary>
    public string? MQUSER { get; set; }

    /// <summary>
    /// MQUPMJ.
    /// </summary>
    public decimal? MQUPMJ { get; set; }

    /// <summary>
    /// MQTDAY.
    /// </summary>
    public decimal? MQTDAY { get; set; }
}
