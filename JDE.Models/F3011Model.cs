using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F3011 - .
/// </summary>
public class F3011Model
{
    /// <summary>
    /// IZTBM (Primary Key).
    /// </summary>
    public string IZTBM { get; set; }

    /// <summary>
    /// IZKIT (Primary Key).
    /// </summary>
    public decimal IZKIT { get; set; }

    /// <summary>
    /// IZKITL.
    /// </summary>
    public string? IZKITL { get; set; }

    /// <summary>
    /// IZKITA.
    /// </summary>
    public string? IZKITA { get; set; }

    /// <summary>
    /// IZMMCU (Primary Key).
    /// </summary>
    public string IZMMCU { get; set; }

    /// <summary>
    /// IZITM.
    /// </summary>
    public decimal? IZITM { get; set; }

    /// <summary>
    /// IZLITM.
    /// </summary>
    public string? IZLITM { get; set; }

    /// <summary>
    /// IZAITM.
    /// </summary>
    public string? IZAITM { get; set; }

    /// <summary>
    /// IZCMCU.
    /// </summary>
    public string? IZCMCU { get; set; }

    /// <summary>
    /// IZCPNT.
    /// </summary>
    public decimal? IZCPNT { get; set; }

    /// <summary>
    /// IZSBNT (Primary Key).
    /// </summary>
    public decimal IZSBNT { get; set; }

    /// <summary>
    /// IZPRTA.
    /// </summary>
    public string? IZPRTA { get; set; }

    /// <summary>
    /// IZQNTY.
    /// </summary>
    public decimal? IZQNTY { get; set; }

    /// <summary>
    /// IZUM.
    /// </summary>
    public string? IZUM { get; set; }

    /// <summary>
    /// IZBQTY (Primary Key).
    /// </summary>
    public decimal IZBQTY { get; set; }

    /// <summary>
    /// IZUOM.
    /// </summary>
    public string? IZUOM { get; set; }

    /// <summary>
    /// IZFVBT.
    /// </summary>
    public string? IZFVBT { get; set; }

    /// <summary>
    /// IZEFFF.
    /// </summary>
    public decimal? IZEFFF { get; set; }

    /// <summary>
    /// IZEFFT.
    /// </summary>
    public decimal? IZEFFT { get; set; }

    /// <summary>
    /// IZFSER.
    /// </summary>
    public string? IZFSER { get; set; }

    /// <summary>
    /// IZTSER.
    /// </summary>
    public string? IZTSER { get; set; }

    /// <summary>
    /// IZITC.
    /// </summary>
    public string? IZITC { get; set; }

    /// <summary>
    /// IZFTRC.
    /// </summary>
    public string? IZFTRC { get; set; }

    /// <summary>
    /// IZOPTK.
    /// </summary>
    public string? IZOPTK { get; set; }

    /// <summary>
    /// IZFORV.
    /// </summary>
    public string? IZFORV { get; set; }

    /// <summary>
    /// IZCSTM.
    /// </summary>
    public string? IZCSTM { get; set; }

    /// <summary>
    /// IZCSMP.
    /// </summary>
    public string? IZCSMP { get; set; }

    /// <summary>
    /// IZORDW.
    /// </summary>
    public string? IZORDW { get; set; }

    /// <summary>
    /// IZFORQ.
    /// </summary>
    public string? IZFORQ { get; set; }

    /// <summary>
    /// IZCOBY.
    /// </summary>
    public string? IZCOBY { get; set; }

    /// <summary>
    /// IZCOTY.
    /// </summary>
    public string? IZCOTY { get; set; }

    /// <summary>
    /// IZFRMP.
    /// </summary>
    public decimal? IZFRMP { get; set; }

    /// <summary>
    /// IZTHRP.
    /// </summary>
    public decimal? IZTHRP { get; set; }

    /// <summary>
    /// IZFRGD.
    /// </summary>
    public string? IZFRGD { get; set; }

    /// <summary>
    /// IZTHGD.
    /// </summary>
    public string? IZTHGD { get; set; }

    /// <summary>
    /// IZOPSQ.
    /// </summary>
    public decimal? IZOPSQ { get; set; }

    /// <summary>
    /// IZBSEQ.
    /// </summary>
    public decimal? IZBSEQ { get; set; }

    /// <summary>
    /// IZFTRP.
    /// </summary>
    public decimal? IZFTRP { get; set; }

    /// <summary>
    /// IZF$RP.
    /// </summary>
    [Column("IZF$RP")]
    public decimal? IZF_RP { get; set; }

    /// <summary>
    /// IZRSCP.
    /// </summary>
    public decimal? IZRSCP { get; set; }

    /// <summary>
    /// IZSCRP.
    /// </summary>
    public decimal? IZSCRP { get; set; }

    /// <summary>
    /// IZREWP.
    /// </summary>
    public decimal? IZREWP { get; set; }

    /// <summary>
    /// IZASIP.
    /// </summary>
    public decimal? IZASIP { get; set; }

    /// <summary>
    /// IZCPYP.
    /// </summary>
    public decimal? IZCPYP { get; set; }

    /// <summary>
    /// IZSTPP.
    /// </summary>
    public decimal? IZSTPP { get; set; }

    /// <summary>
    /// IZLOVD.
    /// </summary>
    public decimal? IZLOVD { get; set; }

    /// <summary>
    /// IZECO.
    /// </summary>
    public string? IZECO { get; set; }

    /// <summary>
    /// IZECTY.
    /// </summary>
    public string? IZECTY { get; set; }

    /// <summary>
    /// IZECOD.
    /// </summary>
    public decimal? IZECOD { get; set; }

    /// <summary>
    /// IZDSC1.
    /// </summary>
    public string? IZDSC1 { get; set; }

    /// <summary>
    /// IZLNTY.
    /// </summary>
    public string? IZLNTY { get; set; }

    /// <summary>
    /// IZPRIC.
    /// </summary>
    public decimal? IZPRIC { get; set; }

    /// <summary>
    /// IZUNCS.
    /// </summary>
    public decimal? IZUNCS { get; set; }

    /// <summary>
    /// IZPCTK.
    /// </summary>
    public decimal? IZPCTK { get; set; }

    /// <summary>
    /// IZSHNO.
    /// </summary>
    public string? IZSHNO { get; set; }

    /// <summary>
    /// IZOMCU.
    /// </summary>
    public string? IZOMCU { get; set; }

    /// <summary>
    /// IZOBJ.
    /// </summary>
    public string? IZOBJ { get; set; }

    /// <summary>
    /// IZSUB.
    /// </summary>
    public string? IZSUB { get; set; }

    /// <summary>
    /// IZBREV.
    /// </summary>
    public string? IZBREV { get; set; }

    /// <summary>
    /// IZCMRV.
    /// </summary>
    public string? IZCMRV { get; set; }

    /// <summary>
    /// IZRVNO.
    /// </summary>
    public string? IZRVNO { get; set; }

    /// <summary>
    /// IZUUPG.
    /// </summary>
    public decimal? IZUUPG { get; set; }

    /// <summary>
    /// IZURCD.
    /// </summary>
    public string? IZURCD { get; set; }

    /// <summary>
    /// IZURDT.
    /// </summary>
    public decimal? IZURDT { get; set; }

    /// <summary>
    /// IZURAT.
    /// </summary>
    public decimal? IZURAT { get; set; }

    /// <summary>
    /// IZURRF.
    /// </summary>
    public string? IZURRF { get; set; }

    /// <summary>
    /// IZURAB.
    /// </summary>
    public decimal? IZURAB { get; set; }

    /// <summary>
    /// IZUSER.
    /// </summary>
    public string? IZUSER { get; set; }

    /// <summary>
    /// IZPID.
    /// </summary>
    public string? IZPID { get; set; }

    /// <summary>
    /// IZJOBN.
    /// </summary>
    public string? IZJOBN { get; set; }

    /// <summary>
    /// IZUPMJ (Primary Key).
    /// </summary>
    public decimal IZUPMJ { get; set; }

    /// <summary>
    /// IZTDAY (Primary Key).
    /// </summary>
    public decimal IZTDAY { get; set; }

    /// <summary>
    /// IZAING.
    /// </summary>
    public string? IZAING { get; set; }

    /// <summary>
    /// IZSUCO.
    /// </summary>
    public decimal? IZSUCO { get; set; }

    /// <summary>
    /// IZSTRC.
    /// </summary>
    public decimal? IZSTRC { get; set; }

    /// <summary>
    /// IZENDC.
    /// </summary>
    public decimal? IZENDC { get; set; }

    /// <summary>
    /// IZAPSC.
    /// </summary>
    public string? IZAPSC { get; set; }

    /// <summary>
    /// IZCPNB (Primary Key).
    /// </summary>
    public decimal IZCPNB { get; set; }

    /// <summary>
    /// IZBSEQAN.
    /// </summary>
    public string? IZBSEQAN { get; set; }

    /// <summary>
    /// IZBCHAR.
    /// </summary>
    public string? IZBCHAR { get; set; }

    /// <summary>
    /// IZBOSTR.
    /// </summary>
    public string? IZBOSTR { get; set; }

    /// <summary>
    /// IZACTN.
    /// </summary>
    public string? IZACTN { get; set; }
}
