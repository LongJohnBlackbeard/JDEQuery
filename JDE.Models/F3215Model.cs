using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F3215 - .
/// </summary>
public class F3215Model
{
    /// <summary>
    /// CCCFGID (Primary Key).
    /// </summary>
    public decimal CCCFGID { get; set; }

    /// <summary>
    /// CCCFGCID (Primary Key).
    /// </summary>
    public decimal CCCFGCID { get; set; }

    /// <summary>
    /// CCCFGPID.
    /// </summary>
    public decimal? CCCFGPID { get; set; }

    /// <summary>
    /// CCITM.
    /// </summary>
    public decimal? CCITM { get; set; }

    /// <summary>
    /// CCMCU.
    /// </summary>
    public string? CCMCU { get; set; }

    /// <summary>
    /// CCDSC1.
    /// </summary>
    public string? CCDSC1 { get; set; }

    /// <summary>
    /// CCQNTY.
    /// </summary>
    public decimal? CCQNTY { get; set; }

    /// <summary>
    /// CCUOM.
    /// </summary>
    public string? CCUOM { get; set; }

    /// <summary>
    /// CCFOVQ.
    /// </summary>
    public string? CCFOVQ { get; set; }

    /// <summary>
    /// CCATMU.
    /// </summary>
    public decimal? CCATMU { get; set; }

    /// <summary>
    /// CCSO03.
    /// </summary>
    public string? CCSO03 { get; set; }

    /// <summary>
    /// CCLNTY.
    /// </summary>
    public string? CCLNTY { get; set; }

    /// <summary>
    /// CCKIT (Primary Key).
    /// </summary>
    public decimal CCKIT { get; set; }

    /// <summary>
    /// CCUITM.
    /// </summary>
    public string? CCUITM { get; set; }

    /// <summary>
    /// CCCFGSID (Primary Key).
    /// </summary>
    public string CCCFGSID { get; set; }

    /// <summary>
    /// CCCOMM.
    /// </summary>
    public string? CCCOMM { get; set; }

    /// <summary>
    /// CCLOCN.
    /// </summary>
    public string? CCLOCN { get; set; }

    /// <summary>
    /// CCLOTN.
    /// </summary>
    public string? CCLOTN { get; set; }

    /// <summary>
    /// CCSY.
    /// </summary>
    public string? CCSY { get; set; }

    /// <summary>
    /// CCECST.
    /// </summary>
    public decimal? CCECST { get; set; }

    /// <summary>
    /// CCFEC.
    /// </summary>
    public decimal? CCFEC { get; set; }

    /// <summary>
    /// CCAEXP.
    /// </summary>
    public decimal? CCAEXP { get; set; }

    /// <summary>
    /// CCFEA.
    /// </summary>
    public decimal? CCFEA { get; set; }

    /// <summary>
    /// CCSOCF.
    /// </summary>
    public string? CCSOCF { get; set; }

    /// <summary>
    /// CCWADL.
    /// </summary>
    public string? CCWADL { get; set; }

    /// <summary>
    /// CCCIDN.
    /// </summary>
    public string? CCCIDN { get; set; }

    /// <summary>
    /// CCITC.
    /// </summary>
    public string? CCITC { get; set; }

    /// <summary>
    /// CCOPSQ.
    /// </summary>
    public decimal? CCOPSQ { get; set; }

    /// <summary>
    /// CCATOT.
    /// </summary>
    public string? CCATOT { get; set; }

    /// <summary>
    /// CCATO#.
    /// </summary>
    [Column("CCATO#")]
    public decimal? CCATO_ { get; set; }

    /// <summary>
    /// CCATOS.
    /// </summary>
    public decimal? CCATOS { get; set; }

    /// <summary>
    /// CCPDDJ.
    /// </summary>
    public decimal? CCPDDJ { get; set; }

    /// <summary>
    /// CCURCD.
    /// </summary>
    public string? CCURCD { get; set; }

    /// <summary>
    /// CCURDT.
    /// </summary>
    public decimal? CCURDT { get; set; }

    /// <summary>
    /// CCURAT.
    /// </summary>
    public decimal? CCURAT { get; set; }

    /// <summary>
    /// CCURAB.
    /// </summary>
    public decimal? CCURAB { get; set; }

    /// <summary>
    /// CCURRF.
    /// </summary>
    public string? CCURRF { get; set; }

    /// <summary>
    /// CCUSER.
    /// </summary>
    public string? CCUSER { get; set; }

    /// <summary>
    /// CCPID.
    /// </summary>
    public string? CCPID { get; set; }

    /// <summary>
    /// CCJOBN.
    /// </summary>
    public string? CCJOBN { get; set; }

    /// <summary>
    /// CCUPMJ.
    /// </summary>
    public decimal? CCUPMJ { get; set; }

    /// <summary>
    /// CCTDAY.
    /// </summary>
    public decimal? CCTDAY { get; set; }

    /// <summary>
    /// CCRULUKID.
    /// </summary>
    public decimal? CCRULUKID { get; set; }

    /// <summary>
    /// CCRUKIDLIN.
    /// </summary>
    public string? CCRUKIDLIN { get; set; }
}
