namespace JDE.Models;

/// <summary>
/// F52G84 - .
/// </summary>
public class F52G84Model
{
    /// <summary>
    /// CSPCTN (Primary Key).
    /// </summary>
    public decimal CSPCTN { get; set; }

    /// <summary>
    /// CSSTLSEQ.
    /// </summary>
    public decimal? CSSTLSEQ { get; set; }

    /// <summary>
    /// CSIPSTYLE (Primary Key).
    /// </summary>
    public string CSIPSTYLE { get; set; }

    /// <summary>
    /// CSUSER.
    /// </summary>
    public string? CSUSER { get; set; }

    /// <summary>
    /// CSPID.
    /// </summary>
    public string? CSPID { get; set; }

    /// <summary>
    /// CSMKEY.
    /// </summary>
    public string? CSMKEY { get; set; }

    /// <summary>
    /// CSUPMJ.
    /// </summary>
    public decimal? CSUPMJ { get; set; }

    /// <summary>
    /// CSUPMT.
    /// </summary>
    public decimal? CSUPMT { get; set; }
}
