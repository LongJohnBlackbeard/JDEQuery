namespace JDE.Models;

/// <summary>
/// F74Y010 - .
/// </summary>
public class F74Y010Model
{
    /// <summary>
    /// BLCTR (Primary Key).
    /// </summary>
    public string BLCTR { get; set; }

    /// <summary>
    /// BLTXA1 (Primary Key).
    /// </summary>
    public string BLTXA1 { get; set; }

    /// <summary>
    /// BLUSER.
    /// </summary>
    public string? BLUSER { get; set; }

    /// <summary>
    /// BLPID.
    /// </summary>
    public string? BLPID { get; set; }

    /// <summary>
    /// BLJOBN.
    /// </summary>
    public string? BLJOBN { get; set; }

    /// <summary>
    /// BLUPMJ.
    /// </summary>
    public decimal? BLUPMJ { get; set; }

    /// <summary>
    /// BLUPMT.
    /// </summary>
    public decimal? BLUPMT { get; set; }
}
