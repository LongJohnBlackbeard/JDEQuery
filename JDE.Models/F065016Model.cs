using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F065016 - .
/// </summary>
public class F065016Model
{
    /// <summary>
    /// YGAN8 (Primary Key).
    /// </summary>
    public decimal YGAN8 { get; set; }

    /// <summary>
    /// YGSSN.
    /// </summary>
    public string? YGSSN { get; set; }

    /// <summary>
    /// YGALPH.
    /// </summary>
    public string? YGALPH { get; set; }

    /// <summary>
    /// YGHMCO.
    /// </summary>
    public string? YGHMCO { get; set; }

    /// <summary>
    /// YGTAX.
    /// </summary>
    public string? YGTAX { get; set; }

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
    /// YGOFO#.
    /// </summary>
    [Column("YGOFO#")]
    public string? YGOFO_ { get; set; }

    /// <summary>
    /// YGIFO#.
    /// </summary>
    [Column("YGIFO#")]
    public string? YGIFO_ { get; set; }

    /// <summary>
    /// YGSEC.
    /// </summary>
    public string? YGSEC { get; set; }

    /// <summary>
    /// YGSCC.
    /// </summary>
    public string? YGSCC { get; set; }

    /// <summary>
    /// YGTCOD.
    /// </summary>
    public string? YGTCOD { get; set; }

    /// <summary>
    /// YGPSDT.
    /// </summary>
    public decimal? YGPSDT { get; set; }

    /// <summary>
    /// YGPTDT.
    /// </summary>
    public decimal? YGPTDT { get; set; }

    /// <summary>
    /// YGBDM (Primary Key).
    /// </summary>
    public string YGBDM { get; set; }

    /// <summary>
    /// YGFPCD.
    /// </summary>
    public string? YGFPCD { get; set; }

    /// <summary>
    /// YGPREN.
    /// </summary>
    public string? YGPREN { get; set; }

    /// <summary>
    /// YGGPA.
    /// </summary>
    public decimal? YGGPA { get; set; }

    /// <summary>
    /// YGDEP1.
    /// </summary>
    public string? YGDEP1 { get; set; }

    /// <summary>
    /// YGDEP2.
    /// </summary>
    public string? YGDEP2 { get; set; }

    /// <summary>
    /// YGDEP3.
    /// </summary>
    public string? YGDEP3 { get; set; }

    /// <summary>
    /// YGDEP4.
    /// </summary>
    public string? YGDEP4 { get; set; }

    /// <summary>
    /// YGDEP5.
    /// </summary>
    public string? YGDEP5 { get; set; }

    /// <summary>
    /// YGDEP6.
    /// </summary>
    public string? YGDEP6 { get; set; }

    /// <summary>
    /// YGUSER.
    /// </summary>
    public string? YGUSER { get; set; }

    /// <summary>
    /// YGPID.
    /// </summary>
    public string? YGPID { get; set; }

    /// <summary>
    /// YGUPMJ.
    /// </summary>
    public decimal? YGUPMJ { get; set; }

    /// <summary>
    /// YGAUSPTWP.
    /// </summary>
    public string? YGAUSPTWP { get; set; }
}
