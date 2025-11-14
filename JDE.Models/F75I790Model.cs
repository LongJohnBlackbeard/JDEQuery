namespace JDE.Models;

/// <summary>
/// F75I790 - .
/// </summary>
public class F75I790Model
{
    /// <summary>
    /// WTJOBS (Primary Key).
    /// </summary>
    public decimal WTJOBS { get; set; }

    /// <summary>
    /// WTCTID (Primary Key).
    /// </summary>
    public string WTCTID { get; set; }

    /// <summary>
    /// WTI75SRCT (Primary Key).
    /// </summary>
    public string WTI75SRCT { get; set; }

    /// <summary>
    /// WTDL01.
    /// </summary>
    public string? WTDL01 { get; set; }

    /// <summary>
    /// WTYS01.
    /// </summary>
    public string? WTYS01 { get; set; }

    /// <summary>
    /// WTYS02.
    /// </summary>
    public string? WTYS02 { get; set; }
}
