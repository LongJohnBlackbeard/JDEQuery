using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F065016T - .
/// </summary>
public class F065016TModel
{
    /// <summary>
    /// YGAN8 (Primary Key).
    /// </summary>
    public decimal YGAN8 { get; set; }

    /// <summary>
    /// YGSEQ (Primary Key).
    /// </summary>
    public decimal YGSEQ { get; set; }

    /// <summary>
    /// YGFOA# (Primary Key).
    /// </summary>
    [Column("YGFOA#")]
    public string YGFOA_ { get; set; }

    /// <summary>
    /// YGBDM (Primary Key).
    /// </summary>
    public string YGBDM { get; set; }

    /// <summary>
    /// YGNQUAL.
    /// </summary>
    public string? YGNQUAL { get; set; }

    /// <summary>
    /// YGFDFI.
    /// </summary>
    public string? YGFDFI { get; set; }

    /// <summary>
    /// YGIDCC.
    /// </summary>
    public string? YGIDCC { get; set; }

    /// <summary>
    /// YGIAT01.
    /// </summary>
    public decimal? YGIAT01 { get; set; }

    /// <summary>
    /// YGIAT02.
    /// </summary>
    public decimal? YGIAT02 { get; set; }

    /// <summary>
    /// YGIAT03.
    /// </summary>
    public decimal? YGIAT03 { get; set; }

    /// <summary>
    /// YGIAT04.
    /// </summary>
    public string? YGIAT04 { get; set; }

    /// <summary>
    /// YGIAT05.
    /// </summary>
    public string? YGIAT05 { get; set; }

    /// <summary>
    /// YGIAT06.
    /// </summary>
    public string? YGIAT06 { get; set; }

    /// <summary>
    /// YGIAT07.
    /// </summary>
    public decimal? YGIAT07 { get; set; }

    /// <summary>
    /// YGIAT08.
    /// </summary>
    public decimal? YGIAT08 { get; set; }

    /// <summary>
    /// YGIAT09.
    /// </summary>
    public decimal? YGIAT09 { get; set; }

    /// <summary>
    /// YGIAT10.
    /// </summary>
    public string? YGIAT10 { get; set; }

    /// <summary>
    /// YGIAT11.
    /// </summary>
    public string? YGIAT11 { get; set; }

    /// <summary>
    /// YGIAT12.
    /// </summary>
    public string? YGIAT12 { get; set; }

    /// <summary>
    /// YGUPMJ.
    /// </summary>
    public decimal? YGUPMJ { get; set; }

    /// <summary>
    /// YGUPMT.
    /// </summary>
    public decimal? YGUPMT { get; set; }

    /// <summary>
    /// YGPID.
    /// </summary>
    public string? YGPID { get; set; }

    /// <summary>
    /// YGJOBN.
    /// </summary>
    public string? YGJOBN { get; set; }

    /// <summary>
    /// YGUSER.
    /// </summary>
    public string? YGUSER { get; set; }
}
