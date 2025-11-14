namespace JDE.Models;

/// <summary>
/// F98TCDTL - .
/// </summary>
public class F98TCDTLModel
{
    /// <summary>
    /// CDDOCO (Primary Key).
    /// </summary>
    public decimal CDDOCO { get; set; }

    /// <summary>
    /// CDDCTO (Primary Key).
    /// </summary>
    public string CDDCTO { get; set; }

    /// <summary>
    /// CDKCO (Primary Key).
    /// </summary>
    public string CDKCO { get; set; }

    /// <summary>
    /// CDLNID (Primary Key).
    /// </summary>
    public decimal CDLNID { get; set; }

    /// <summary>
    /// CDITM.
    /// </summary>
    public decimal? CDITM { get; set; }

    /// <summary>
    /// CDMCU.
    /// </summary>
    public string? CDMCU { get; set; }

    /// <summary>
    /// CDTRQT.
    /// </summary>
    public decimal? CDTRQT { get; set; }

    /// <summary>
    /// CDPRRC.
    /// </summary>
    public decimal? CDPRRC { get; set; }

    /// <summary>
    /// CDAEXP.
    /// </summary>
    public decimal? CDAEXP { get; set; }
}
