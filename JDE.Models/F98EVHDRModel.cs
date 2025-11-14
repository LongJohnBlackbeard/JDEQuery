namespace JDE.Models;

/// <summary>
/// F98EVHDR - .
/// </summary>
public class F98EVHDRModel
{
    /// <summary>
    /// EHPRODID (Primary Key).
    /// </summary>
    public decimal EHPRODID { get; set; }

    /// <summary>
    /// EHOBJTYPE (Primary Key).
    /// </summary>
    public decimal EHOBJTYPE { get; set; }

    /// <summary>
    /// EHDSC2.
    /// </summary>
    public string? EHDSC2 { get; set; }

    /// <summary>
    /// EHEVENT1 (Primary Key).
    /// </summary>
    public decimal EHEVENT1 { get; set; }

    /// <summary>
    /// EHEVTYPE.
    /// </summary>
    public decimal? EHEVTYPE { get; set; }

    /// <summary>
    /// EHEVDSC1.
    /// </summary>
    public decimal? EHEVDSC1 { get; set; }

    /// <summary>
    /// EHDSC1.
    /// </summary>
    public string? EHDSC1 { get; set; }

    /// <summary>
    /// EHEVDEFNM.
    /// </summary>
    public string? EHEVDEFNM { get; set; }

    /// <summary>
    /// EHEVPARENT.
    /// </summary>
    public decimal? EHEVPARENT { get; set; }

    /// <summary>
    /// EHHELPID1.
    /// </summary>
    public decimal? EHHELPID1 { get; set; }
}
