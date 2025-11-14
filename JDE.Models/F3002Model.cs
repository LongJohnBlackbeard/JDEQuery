using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F3002 - .
/// </summary>
public class F3002Model
{
    /// <summary>
    /// IXTBM (Primary Key).
    /// </summary>
    public string IXTBM { get; set; }

    /// <summary>
    /// IXKIT (Primary Key).
    /// </summary>
    public decimal IXKIT { get; set; }

    /// <summary>
    /// IXKITL.
    /// </summary>
    public string? IXKITL { get; set; }

    /// <summary>
    /// IXKITA.
    /// </summary>
    public string? IXKITA { get; set; }

    /// <summary>
    /// IXMMCU (Primary Key).
    /// </summary>
    public string IXMMCU { get; set; }

    /// <summary>
    /// IXITM.
    /// </summary>
    public decimal? IXITM { get; set; }

    /// <summary>
    /// IXLITM.
    /// </summary>
    public string? IXLITM { get; set; }

    /// <summary>
    /// IXAITM.
    /// </summary>
    public string? IXAITM { get; set; }

    /// <summary>
    /// IXCMCU.
    /// </summary>
    public string? IXCMCU { get; set; }

    /// <summary>
    /// IXCPNT.
    /// </summary>
    public decimal? IXCPNT { get; set; }

    /// <summary>
    /// IXSBNT (Primary Key).
    /// </summary>
    public decimal IXSBNT { get; set; }

    /// <summary>
    /// IXPRTA.
    /// </summary>
    public string? IXPRTA { get; set; }

    /// <summary>
    /// IXQNTY.
    /// </summary>
    public decimal? IXQNTY { get; set; }

    /// <summary>
    /// IXUM.
    /// </summary>
    public string? IXUM { get; set; }

    /// <summary>
    /// IXBQTY (Primary Key).
    /// </summary>
    public decimal IXBQTY { get; set; }

    /// <summary>
    /// IXUOM.
    /// </summary>
    public string? IXUOM { get; set; }

    /// <summary>
    /// IXFVBT.
    /// </summary>
    public string? IXFVBT { get; set; }

    /// <summary>
    /// IXEFFF.
    /// </summary>
    public decimal? IXEFFF { get; set; }

    /// <summary>
    /// IXEFFT.
    /// </summary>
    public decimal? IXEFFT { get; set; }

    /// <summary>
    /// IXFSER.
    /// </summary>
    public string? IXFSER { get; set; }

    /// <summary>
    /// IXTSER.
    /// </summary>
    public string? IXTSER { get; set; }

    /// <summary>
    /// IXITC.
    /// </summary>
    public string? IXITC { get; set; }

    /// <summary>
    /// IXFTRC.
    /// </summary>
    public string? IXFTRC { get; set; }

    /// <summary>
    /// IXOPTK.
    /// </summary>
    public string? IXOPTK { get; set; }

    /// <summary>
    /// IXFORV.
    /// </summary>
    public string? IXFORV { get; set; }

    /// <summary>
    /// IXCSTM.
    /// </summary>
    public string? IXCSTM { get; set; }

    /// <summary>
    /// IXCSMP.
    /// </summary>
    public string? IXCSMP { get; set; }

    /// <summary>
    /// IXORDW.
    /// </summary>
    public string? IXORDW { get; set; }

    /// <summary>
    /// IXFORQ.
    /// </summary>
    public string? IXFORQ { get; set; }

    /// <summary>
    /// IXCOBY (Primary Key).
    /// </summary>
    public string IXCOBY { get; set; }

    /// <summary>
    /// IXCOTY.
    /// </summary>
    public string? IXCOTY { get; set; }

    /// <summary>
    /// IXFRMP.
    /// </summary>
    public decimal? IXFRMP { get; set; }

    /// <summary>
    /// IXTHRP.
    /// </summary>
    public decimal? IXTHRP { get; set; }

    /// <summary>
    /// IXFRGD.
    /// </summary>
    public string? IXFRGD { get; set; }

    /// <summary>
    /// IXTHGD.
    /// </summary>
    public string? IXTHGD { get; set; }

    /// <summary>
    /// IXOPSQ.
    /// </summary>
    public decimal? IXOPSQ { get; set; }

    /// <summary>
    /// IXBSEQ.
    /// </summary>
    public decimal? IXBSEQ { get; set; }

    /// <summary>
    /// IXFTRP.
    /// </summary>
    public decimal? IXFTRP { get; set; }

    /// <summary>
    /// IXF$RP.
    /// </summary>
    [Column("IXF$RP")]
    public decimal? IXF_RP { get; set; }

    /// <summary>
    /// IXRSCP.
    /// </summary>
    public decimal? IXRSCP { get; set; }

    /// <summary>
    /// IXSCRP.
    /// </summary>
    public decimal? IXSCRP { get; set; }

    /// <summary>
    /// IXREWP.
    /// </summary>
    public decimal? IXREWP { get; set; }

    /// <summary>
    /// IXASIP.
    /// </summary>
    public decimal? IXASIP { get; set; }

    /// <summary>
    /// IXCPYP.
    /// </summary>
    public decimal? IXCPYP { get; set; }

    /// <summary>
    /// IXSTPP.
    /// </summary>
    public decimal? IXSTPP { get; set; }

    /// <summary>
    /// IXLOVD.
    /// </summary>
    public decimal? IXLOVD { get; set; }

    /// <summary>
    /// IXECO.
    /// </summary>
    public string? IXECO { get; set; }

    /// <summary>
    /// IXECTY.
    /// </summary>
    public string? IXECTY { get; set; }

    /// <summary>
    /// IXECOD.
    /// </summary>
    public decimal? IXECOD { get; set; }

    /// <summary>
    /// IXDSC1.
    /// </summary>
    public string? IXDSC1 { get; set; }

    /// <summary>
    /// IXLNTY.
    /// </summary>
    public string? IXLNTY { get; set; }

    /// <summary>
    /// IXPRIC.
    /// </summary>
    public decimal? IXPRIC { get; set; }

    /// <summary>
    /// IXUNCS.
    /// </summary>
    public decimal? IXUNCS { get; set; }

    /// <summary>
    /// IXPCTK.
    /// </summary>
    public decimal? IXPCTK { get; set; }

    /// <summary>
    /// IXSHNO.
    /// </summary>
    public string? IXSHNO { get; set; }

    /// <summary>
    /// IXOMCU.
    /// </summary>
    public string? IXOMCU { get; set; }

    /// <summary>
    /// IXOBJ.
    /// </summary>
    public string? IXOBJ { get; set; }

    /// <summary>
    /// IXSUB.
    /// </summary>
    public string? IXSUB { get; set; }

    /// <summary>
    /// IXBREV.
    /// </summary>
    public string? IXBREV { get; set; }

    /// <summary>
    /// IXCMRV.
    /// </summary>
    public string? IXCMRV { get; set; }

    /// <summary>
    /// IXRVNO.
    /// </summary>
    public string? IXRVNO { get; set; }

    /// <summary>
    /// IXUUPG.
    /// </summary>
    public decimal? IXUUPG { get; set; }

    /// <summary>
    /// IXURCD.
    /// </summary>
    public string? IXURCD { get; set; }

    /// <summary>
    /// IXURDT.
    /// </summary>
    public decimal? IXURDT { get; set; }

    /// <summary>
    /// IXURAT.
    /// </summary>
    public decimal? IXURAT { get; set; }

    /// <summary>
    /// IXURRF.
    /// </summary>
    public string? IXURRF { get; set; }

    /// <summary>
    /// IXURAB.
    /// </summary>
    public decimal? IXURAB { get; set; }

    /// <summary>
    /// IXUSER.
    /// </summary>
    public string? IXUSER { get; set; }

    /// <summary>
    /// IXPID.
    /// </summary>
    public string? IXPID { get; set; }

    /// <summary>
    /// IXJOBN.
    /// </summary>
    public string? IXJOBN { get; set; }

    /// <summary>
    /// IXUPMJ.
    /// </summary>
    public decimal? IXUPMJ { get; set; }

    /// <summary>
    /// IXTDAY.
    /// </summary>
    public decimal? IXTDAY { get; set; }

    /// <summary>
    /// IXAING.
    /// </summary>
    public string? IXAING { get; set; }

    /// <summary>
    /// IXSUCO.
    /// </summary>
    public decimal? IXSUCO { get; set; }

    /// <summary>
    /// IXSTRC.
    /// </summary>
    public decimal? IXSTRC { get; set; }

    /// <summary>
    /// IXENDC.
    /// </summary>
    public decimal? IXENDC { get; set; }

    /// <summary>
    /// IXAPSC.
    /// </summary>
    public string? IXAPSC { get; set; }

    /// <summary>
    /// IXCPNB (Primary Key).
    /// </summary>
    public decimal IXCPNB { get; set; }

    /// <summary>
    /// IXBSEQAN.
    /// </summary>
    public string? IXBSEQAN { get; set; }

    /// <summary>
    /// IXBCHAR.
    /// </summary>
    public string? IXBCHAR { get; set; }

    /// <summary>
    /// IXBOSTR.
    /// </summary>
    public string? IXBOSTR { get; set; }
}
