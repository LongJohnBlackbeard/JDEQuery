namespace JDE.Models;

/// <summary>
/// F90CA121 - .
/// </summary>
public class F90CA121Model
{
    /// <summary>
    /// IGCIG (Primary Key).
    /// </summary>
    public decimal IGCIG { get; set; }

    /// <summary>
    /// IGBLGID.
    /// </summary>
    public decimal? IGBLGID { get; set; }

    /// <summary>
    /// IGCFGSID (Primary Key).
    /// </summary>
    public string IGCFGSID { get; set; }

    /// <summary>
    /// IGCIGNAME.
    /// </summary>
    public string? IGCIGNAME { get; set; }

    /// <summary>
    /// IGACTIND.
    /// </summary>
    public string? IGACTIND { get; set; }

    /// <summary>
    /// IGUDTTM.
    /// </summary>
    public DateTime? IGUDTTM { get; set; }

    /// <summary>
    /// IGUSER.
    /// </summary>
    public string? IGUSER { get; set; }

    /// <summary>
    /// IGENTDBY.
    /// </summary>
    public decimal? IGENTDBY { get; set; }

    /// <summary>
    /// IGEDATE.
    /// </summary>
    public DateTime? IGEDATE { get; set; }

    /// <summary>
    /// IGSTSUDT.
    /// </summary>
    public DateTime? IGSTSUDT { get; set; }

    /// <summary>
    /// IGPID.
    /// </summary>
    public string? IGPID { get; set; }

    /// <summary>
    /// IGVID.
    /// </summary>
    public string? IGVID { get; set; }

    /// <summary>
    /// IGMKEY.
    /// </summary>
    public string? IGMKEY { get; set; }
}
