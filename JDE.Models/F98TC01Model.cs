namespace JDE.Models;

/// <summary>
/// F98TC01 - .
/// </summary>
public class F98TC01Model
{
    /// <summary>
    /// TCMCU (Primary Key).
    /// </summary>
    public string TCMCU { get; set; }

    /// <summary>
    /// TCITM (Primary Key).
    /// </summary>
    public decimal TCITM { get; set; }

    /// <summary>
    /// TCLOCN (Primary Key).
    /// </summary>
    public string TCLOCN { get; set; }

    /// <summary>
    /// TCLOTN (Primary Key).
    /// </summary>
    public string TCLOTN { get; set; }

    /// <summary>
    /// TCTX.
    /// </summary>
    public string? TCTX { get; set; }

    /// <summary>
    /// TCSRCE.
    /// </summary>
    public string? TCSRCE { get; set; }

    /// <summary>
    /// TCANBY.
    /// </summary>
    public decimal? TCANBY { get; set; }

    /// <summary>
    /// TCCSDJ.
    /// </summary>
    public decimal? TCCSDJ { get; set; }

    /// <summary>
    /// TCDLR.
    /// </summary>
    public decimal? TCDLR { get; set; }

    /// <summary>
    /// TCSTKT.
    /// </summary>
    public string? TCSTKT { get; set; }

    /// <summary>
    /// TCCMGL.
    /// </summary>
    public string? TCCMGL { get; set; }
}
