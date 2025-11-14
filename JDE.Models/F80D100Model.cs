namespace JDE.Models;

/// <summary>
/// F80D100 - .
/// </summary>
public class F80D100Model
{
    /// <summary>
    /// DDDDDAY (Primary Key).
    /// </summary>
    public decimal DDDDDAY { get; set; }

    /// <summary>
    /// DDDDWEEK.
    /// </summary>
    public decimal? DDDDWEEK { get; set; }

    /// <summary>
    /// DDDDMON.
    /// </summary>
    public string? DDDDMON { get; set; }

    /// <summary>
    /// DDDDQTR.
    /// </summary>
    public string? DDDDQTR { get; set; }

    /// <summary>
    /// DDDDYEAR.
    /// </summary>
    public string? DDDDYEAR { get; set; }

    /// <summary>
    /// DDUSER.
    /// </summary>
    public string? DDUSER { get; set; }

    /// <summary>
    /// DDPID.
    /// </summary>
    public string? DDPID { get; set; }

    /// <summary>
    /// DDMKEY.
    /// </summary>
    public string? DDMKEY { get; set; }

    /// <summary>
    /// DDUTIME.
    /// </summary>
    public DateTime? DDUTIME { get; set; }

    /// <summary>
    /// DDURCD.
    /// </summary>
    public string? DDURCD { get; set; }

    /// <summary>
    /// DDURDT.
    /// </summary>
    public decimal? DDURDT { get; set; }

    /// <summary>
    /// DDURAT.
    /// </summary>
    public decimal? DDURAT { get; set; }

    /// <summary>
    /// DDURAB.
    /// </summary>
    public decimal? DDURAB { get; set; }

    /// <summary>
    /// DDURRF.
    /// </summary>
    public string? DDURRF { get; set; }
}
