using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F32169 - .
/// </summary>
public class F32169Model
{
    /// <summary>
    /// KBCFGID (Primary Key).
    /// </summary>
    public decimal KBCFGID { get; set; }

    /// <summary>
    /// KBCFGCID (Primary Key).
    /// </summary>
    public decimal KBCFGCID { get; set; }

    /// <summary>
    /// KBSEQN (Primary Key).
    /// </summary>
    public decimal KBSEQN { get; set; }

    /// <summary>
    /// KBDSC1.
    /// </summary>
    public string? KBDSC1 { get; set; }

    /// <summary>
    /// KBLNTY (Primary Key).
    /// </summary>
    public string KBLNTY { get; set; }

    /// <summary>
    /// KBPRU (Primary Key).
    /// </summary>
    public string KBPRU { get; set; }

    /// <summary>
    /// KBSOCF.
    /// </summary>
    public string? KBSOCF { get; set; }

    /// <summary>
    /// KBFOVQ.
    /// </summary>
    public string? KBFOVQ { get; set; }

    /// <summary>
    /// KBATMU.
    /// </summary>
    public decimal? KBATMU { get; set; }

    /// <summary>
    /// KBECST.
    /// </summary>
    public decimal? KBECST { get; set; }

    /// <summary>
    /// KBFEC.
    /// </summary>
    public decimal? KBFEC { get; set; }

    /// <summary>
    /// KBAEXP.
    /// </summary>
    public decimal? KBAEXP { get; set; }

    /// <summary>
    /// KBFEA.
    /// </summary>
    public decimal? KBFEA { get; set; }

    /// <summary>
    /// KBATOT.
    /// </summary>
    public string? KBATOT { get; set; }

    /// <summary>
    /// KBATO#.
    /// </summary>
    [Column("KBATO#")]
    public decimal? KBATO_ { get; set; }

    /// <summary>
    /// KBATOS.
    /// </summary>
    public decimal? KBATOS { get; set; }

    /// <summary>
    /// KBLNID.
    /// </summary>
    public decimal? KBLNID { get; set; }

    /// <summary>
    /// KBAKID.
    /// </summary>
    public decimal? KBAKID { get; set; }

    /// <summary>
    /// KBURCD.
    /// </summary>
    public string? KBURCD { get; set; }

    /// <summary>
    /// KBURDT.
    /// </summary>
    public decimal? KBURDT { get; set; }

    /// <summary>
    /// KBURAT.
    /// </summary>
    public decimal? KBURAT { get; set; }

    /// <summary>
    /// KBURAB.
    /// </summary>
    public decimal? KBURAB { get; set; }

    /// <summary>
    /// KBURRF.
    /// </summary>
    public string? KBURRF { get; set; }

    /// <summary>
    /// KBUSER.
    /// </summary>
    public string? KBUSER { get; set; }

    /// <summary>
    /// KBPID.
    /// </summary>
    public string? KBPID { get; set; }

    /// <summary>
    /// KBJOBN.
    /// </summary>
    public string? KBJOBN { get; set; }

    /// <summary>
    /// KBUPMJ.
    /// </summary>
    public decimal? KBUPMJ { get; set; }

    /// <summary>
    /// KBTDAY.
    /// </summary>
    public decimal? KBTDAY { get; set; }
}
