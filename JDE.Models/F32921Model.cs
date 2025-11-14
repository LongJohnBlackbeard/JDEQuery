using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F32921 - .
/// </summary>
public class F32921Model
{
    /// <summary>
    /// KXFCOD (Primary Key).
    /// </summary>
    public string KXFCOD { get; set; }

    /// <summary>
    /// KXKIT (Primary Key).
    /// </summary>
    public decimal KXKIT { get; set; }

    /// <summary>
    /// KXMCU (Primary Key).
    /// </summary>
    public string KXMCU { get; set; }

    /// <summary>
    /// KXATO# (Primary Key).
    /// </summary>
    [Column("KXATO#")]
    public decimal KXATO_ { get; set; }

    /// <summary>
    /// KXATOS (Primary Key).
    /// </summary>
    public decimal KXATOS { get; set; }

    /// <summary>
    /// KXSGVL (Primary Key).
    /// </summary>
    public string KXSGVL { get; set; }

    /// <summary>
    /// KXEFFF.
    /// </summary>
    public decimal? KXEFFF { get; set; }

    /// <summary>
    /// KXEFFT.
    /// </summary>
    public decimal? KXEFFT { get; set; }

    /// <summary>
    /// KXURCD.
    /// </summary>
    public string? KXURCD { get; set; }

    /// <summary>
    /// KXURDT.
    /// </summary>
    public decimal? KXURDT { get; set; }

    /// <summary>
    /// KXURAT.
    /// </summary>
    public decimal? KXURAT { get; set; }

    /// <summary>
    /// KXURAB.
    /// </summary>
    public decimal? KXURAB { get; set; }

    /// <summary>
    /// KXURRF.
    /// </summary>
    public string? KXURRF { get; set; }

    /// <summary>
    /// KXUSER.
    /// </summary>
    public string? KXUSER { get; set; }

    /// <summary>
    /// KXPID.
    /// </summary>
    public string? KXPID { get; set; }

    /// <summary>
    /// KXJOBN.
    /// </summary>
    public string? KXJOBN { get; set; }

    /// <summary>
    /// KXUPMJ.
    /// </summary>
    public decimal? KXUPMJ { get; set; }

    /// <summary>
    /// KXTDAY.
    /// </summary>
    public decimal? KXTDAY { get; set; }
}
