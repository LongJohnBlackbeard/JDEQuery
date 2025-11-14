namespace JDE.Models;

/// <summary>
/// F90CA22B - .
/// </summary>
public class F90CA22BModel
{
    /// <summary>
    /// DTDTID (Primary Key).
    /// </summary>
    public decimal DTDTID { get; set; }

    /// <summary>
    /// DTDTTNAME.
    /// </summary>
    public string? DTDTTNAME { get; set; }

    /// <summary>
    /// DTDTDESC.
    /// </summary>
    public string? DTDTDESC { get; set; }

    /// <summary>
    /// DTDTTCFLG.
    /// </summary>
    public string? DTDTTCFLG { get; set; }

    /// <summary>
    /// DTDTAFLG.
    /// </summary>
    public string? DTDTAFLG { get; set; }

    /// <summary>
    /// DTDTSUPDDT.
    /// </summary>
    public decimal? DTDTSUPDDT { get; set; }

    /// <summary>
    /// DTDTACIND.
    /// </summary>
    public string? DTDTACIND { get; set; }
}
