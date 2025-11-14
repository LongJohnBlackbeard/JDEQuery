namespace JDE.Models;

/// <summary>
/// F90CE01B - .
/// </summary>
public class F90CE01BModel
{
    /// <summary>
    /// SCSLTNID (Primary Key).
    /// </summary>
    public decimal SCSLTNID { get; set; }

    /// <summary>
    /// SCDOCO (Primary Key).
    /// </summary>
    public decimal SCDOCO { get; set; }

    /// <summary>
    /// SCSETID.
    /// </summary>
    public string? SCSETID { get; set; }

    /// <summary>
    /// SCENTDBY.
    /// </summary>
    public decimal? SCENTDBY { get; set; }

    /// <summary>
    /// SCEDATE.
    /// </summary>
    public DateTime? SCEDATE { get; set; }

    /// <summary>
    /// SCUSER.
    /// </summary>
    public string? SCUSER { get; set; }

    /// <summary>
    /// SCUDTTM.
    /// </summary>
    public DateTime? SCUDTTM { get; set; }

    /// <summary>
    /// SCMKEY.
    /// </summary>
    public string? SCMKEY { get; set; }

    /// <summary>
    /// SCSLLKST.
    /// </summary>
    public string? SCSLLKST { get; set; }
}
