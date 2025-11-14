namespace JDE.Models;

/// <summary>
/// F90CE999 - .
/// </summary>
public class F90CE999Model
{
    /// <summary>
    /// AUSLTNID (Primary Key).
    /// </summary>
    public decimal AUSLTNID { get; set; }

    /// <summary>
    /// AULIBNAME.
    /// </summary>
    public string? AULIBNAME { get; set; }

    /// <summary>
    /// AUEDATE.
    /// </summary>
    public DateTime? AUEDATE { get; set; }

    /// <summary>
    /// AUUDTTM.
    /// </summary>
    public DateTime? AUUDTTM { get; set; }

    /// <summary>
    /// AUMKEY.
    /// </summary>
    public string? AUMKEY { get; set; }

    /// <summary>
    /// AUUSER.
    /// </summary>
    public string? AUUSER { get; set; }

    /// <summary>
    /// AUENTDBY.
    /// </summary>
    public decimal? AUENTDBY { get; set; }
}
