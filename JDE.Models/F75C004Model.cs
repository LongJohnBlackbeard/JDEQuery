namespace JDE.Models;

/// <summary>
/// F75C004 - .
/// </summary>
public class F75C004Model
{
    /// <summary>
    /// RNC75RID (Primary Key).
    /// </summary>
    public string RNC75RID { get; set; }

    /// <summary>
    /// RNC75SEQN (Primary Key).
    /// </summary>
    public decimal RNC75SEQN { get; set; }

    /// <summary>
    /// RNC75NAC (Primary Key).
    /// </summary>
    public string RNC75NAC { get; set; }

    /// <summary>
    /// RNCO (Primary Key).
    /// </summary>
    public string RNCO { get; set; }

    /// <summary>
    /// RNC75OPN.
    /// </summary>
    public string? RNC75OPN { get; set; }

    /// <summary>
    /// RNUSER.
    /// </summary>
    public string? RNUSER { get; set; }

    /// <summary>
    /// RNPID.
    /// </summary>
    public string? RNPID { get; set; }

    /// <summary>
    /// RNJOBN.
    /// </summary>
    public string? RNJOBN { get; set; }

    /// <summary>
    /// RNUPMJ.
    /// </summary>
    public decimal? RNUPMJ { get; set; }

    /// <summary>
    /// RNUPMT.
    /// </summary>
    public decimal? RNUPMT { get; set; }
}
