namespace JDE.Models;

/// <summary>
/// F90CG001 - .
/// </summary>
public class F90CG001Model
{
    /// <summary>
    /// APPARMID (Primary Key).
    /// </summary>
    public decimal APPARMID { get; set; }

    /// <summary>
    /// APPARMNAME.
    /// </summary>
    public string? APPARMNAME { get; set; }

    /// <summary>
    /// APPARMNUM.
    /// </summary>
    public decimal? APPARMNUM { get; set; }

    /// <summary>
    /// APPARMTITLE.
    /// </summary>
    public string? APPARMTITLE { get; set; }

    /// <summary>
    /// APURLID.
    /// </summary>
    public decimal? APURLID { get; set; }

    /// <summary>
    /// APJOBN.
    /// </summary>
    public string? APJOBN { get; set; }

    /// <summary>
    /// APUSER.
    /// </summary>
    public string? APUSER { get; set; }

    /// <summary>
    /// APUDTTM.
    /// </summary>
    public DateTime? APUDTTM { get; set; }

    /// <summary>
    /// APMKEY.
    /// </summary>
    public string? APMKEY { get; set; }
}
