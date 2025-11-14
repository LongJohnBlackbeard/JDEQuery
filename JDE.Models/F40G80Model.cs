namespace JDE.Models;

/// <summary>
/// F40G80 - .
/// </summary>
public class F40G80Model
{
    /// <summary>
    /// CVWOPID (Primary Key).
    /// </summary>
    public decimal CVWOPID { get; set; }

    /// <summary>
    /// CVWVID (Primary Key).
    /// </summary>
    public decimal CVWVID { get; set; }

    /// <summary>
    /// CVFARMCDE (Primary Key).
    /// </summary>
    public string CVFARMCDE { get; set; }

    /// <summary>
    /// CVFARMDSC.
    /// </summary>
    public string? CVFARMDSC { get; set; }

    /// <summary>
    /// CVFARMVAL.
    /// </summary>
    public decimal? CVFARMVAL { get; set; }

    /// <summary>
    /// CVFARMUOM.
    /// </summary>
    public string? CVFARMUOM { get; set; }

    /// <summary>
    /// CVURCD.
    /// </summary>
    public string? CVURCD { get; set; }

    /// <summary>
    /// CVURDT.
    /// </summary>
    public decimal? CVURDT { get; set; }

    /// <summary>
    /// CVURRF.
    /// </summary>
    public string? CVURRF { get; set; }

    /// <summary>
    /// CVURAT.
    /// </summary>
    public decimal? CVURAT { get; set; }

    /// <summary>
    /// CVURAB.
    /// </summary>
    public decimal? CVURAB { get; set; }

    /// <summary>
    /// CVPID.
    /// </summary>
    public string? CVPID { get; set; }

    /// <summary>
    /// CVTORG.
    /// </summary>
    public string? CVTORG { get; set; }

    /// <summary>
    /// CVUSER.
    /// </summary>
    public string? CVUSER { get; set; }

    /// <summary>
    /// CVJOBN.
    /// </summary>
    public string? CVJOBN { get; set; }

    /// <summary>
    /// CVUUPMJ.
    /// </summary>
    public DateTime? CVUUPMJ { get; set; }
}
