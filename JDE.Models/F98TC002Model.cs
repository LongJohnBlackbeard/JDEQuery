namespace JDE.Models;

/// <summary>
/// F98TC002 - .
/// </summary>
public class F98TC002Model
{
    /// <summary>
    /// TNMCU (Primary Key).
    /// </summary>
    public string TNMCU { get; set; }

    /// <summary>
    /// TNITM (Primary Key).
    /// </summary>
    public decimal TNITM { get; set; }

    /// <summary>
    /// TNTX.
    /// </summary>
    public string? TNTX { get; set; }

    /// <summary>
    /// TNSRCE.
    /// </summary>
    public string? TNSRCE { get; set; }

    /// <summary>
    /// TNANBY.
    /// </summary>
    public decimal? TNANBY { get; set; }

    /// <summary>
    /// TNSTKT.
    /// </summary>
    public string? TNSTKT { get; set; }

    /// <summary>
    /// TNCMGL.
    /// </summary>
    public string? TNCMGL { get; set; }
}
