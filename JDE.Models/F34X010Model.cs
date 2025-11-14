namespace JDE.Models;

/// <summary>
/// F34X010 - .
/// </summary>
public class F34X010Model
{
    /// <summary>
    /// CCMCU (Primary Key).
    /// </summary>
    public string CCMCU { get; set; }

    /// <summary>
    /// CCITM (Primary Key).
    /// </summary>
    public decimal CCITM { get; set; }

    /// <summary>
    /// CCLITM.
    /// </summary>
    public string? CCLITM { get; set; }

    /// <summary>
    /// CCAITM.
    /// </summary>
    public string? CCAITM { get; set; }

    /// <summary>
    /// CCUSER.
    /// </summary>
    public string? CCUSER { get; set; }

    /// <summary>
    /// CCPID.
    /// </summary>
    public string? CCPID { get; set; }

    /// <summary>
    /// CCJOBN.
    /// </summary>
    public string? CCJOBN { get; set; }

    /// <summary>
    /// CCUPMJ.
    /// </summary>
    public decimal? CCUPMJ { get; set; }

    /// <summary>
    /// CCUPMT.
    /// </summary>
    public decimal? CCUPMT { get; set; }
}
