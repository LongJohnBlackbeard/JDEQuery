namespace JDE.Models;

/// <summary>
/// F90CA142 - .
/// </summary>
public class F90CA142Model
{
    /// <summary>
    /// TYTERRID (Primary Key).
    /// </summary>
    public decimal TYTERRID { get; set; }

    /// <summary>
    /// TYBLGID.
    /// </summary>
    public decimal? TYBLGID { get; set; }

    /// <summary>
    /// TYCFGSID (Primary Key).
    /// </summary>
    public string TYCFGSID { get; set; }

    /// <summary>
    /// TYDESC.
    /// </summary>
    public string? TYDESC { get; set; }

    /// <summary>
    /// TYACTIND.
    /// </summary>
    public string? TYACTIND { get; set; }

    /// <summary>
    /// TYUDTTM.
    /// </summary>
    public DateTime? TYUDTTM { get; set; }

    /// <summary>
    /// TYUSER.
    /// </summary>
    public string? TYUSER { get; set; }

    /// <summary>
    /// TYENTDBY.
    /// </summary>
    public decimal? TYENTDBY { get; set; }

    /// <summary>
    /// TYEDATE.
    /// </summary>
    public DateTime? TYEDATE { get; set; }

    /// <summary>
    /// TYSTSUDT.
    /// </summary>
    public DateTime? TYSTSUDT { get; set; }

    /// <summary>
    /// TYPID.
    /// </summary>
    public string? TYPID { get; set; }

    /// <summary>
    /// TYVID.
    /// </summary>
    public string? TYVID { get; set; }

    /// <summary>
    /// TYMKEY.
    /// </summary>
    public string? TYMKEY { get; set; }
}
