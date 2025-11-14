namespace JDE.Models;

/// <summary>
/// F75I035 - .
/// </summary>
public class F75I035Model
{
    /// <summary>
    /// DGKCO (Primary Key).
    /// </summary>
    public string DGKCO { get; set; }

    /// <summary>
    /// DGDCT (Primary Key).
    /// </summary>
    public string DGDCT { get; set; }

    /// <summary>
    /// DGDOC (Primary Key).
    /// </summary>
    public decimal DGDOC { get; set; }

    /// <summary>
    /// DGSEQ (Primary Key).
    /// </summary>
    public decimal DGSEQ { get; set; }

    /// <summary>
    /// DGLNID (Primary Key).
    /// </summary>
    public decimal DGLNID { get; set; }

    /// <summary>
    /// DGCRCD.
    /// </summary>
    public string? DGCRCD { get; set; }

    /// <summary>
    /// DGRAMT.
    /// </summary>
    public decimal? DGRAMT { get; set; }
}
