namespace JDE.Models;

/// <summary>
/// F74UI94 - .
/// </summary>
public class F74UI94Model
{
    /// <summary>
    /// CCJOBS (Primary Key).
    /// </summary>
    public decimal CCJOBS { get; set; }

    /// <summary>
    /// CCCO (Primary Key).
    /// </summary>
    public string CCCO { get; set; }

    /// <summary>
    /// CCE74MCUG (Primary Key).
    /// </summary>
    public string CCE74MCUG { get; set; }

    /// <summary>
    /// CCE74CSEQ (Primary Key).
    /// </summary>
    public decimal CCE74CSEQ { get; set; }

    /// <summary>
    /// CCMCU.
    /// </summary>
    public string? CCMCU { get; set; }
}
