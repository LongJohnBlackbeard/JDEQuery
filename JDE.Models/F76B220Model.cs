namespace JDE.Models;

/// <summary>
/// F76B220 - .
/// </summary>
public class F76B220Model
{
    /// <summary>
    /// DWB76COID (Primary Key).
    /// </summary>
    public string DWB76COID { get; set; }

    /// <summary>
    /// DWBRG (Primary Key).
    /// </summary>
    public string DWBRG { get; set; }

    /// <summary>
    /// DWB76DWC.
    /// </summary>
    public string? DWB76DWC { get; set; }

    /// <summary>
    /// DWJOBN.
    /// </summary>
    public string? DWJOBN { get; set; }

    /// <summary>
    /// DWUSER.
    /// </summary>
    public string? DWUSER { get; set; }

    /// <summary>
    /// DWPID.
    /// </summary>
    public string? DWPID { get; set; }

    /// <summary>
    /// DWUPMJ.
    /// </summary>
    public decimal? DWUPMJ { get; set; }

    /// <summary>
    /// DWUPMT.
    /// </summary>
    public decimal? DWUPMT { get; set; }
}
