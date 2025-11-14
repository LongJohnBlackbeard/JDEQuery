using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F0912B - .
/// </summary>
public class F0912BModel
{
    /// <summary>
    /// R#HST.
    /// </summary>
    [Column("R#HST")]
    public string? R_HST { get; set; }

    /// <summary>
    /// R#REVR.
    /// </summary>
    [Column("R#REVR")]
    public string? R_REVR { get; set; }

    /// <summary>
    /// R#DCT (Primary Key).
    /// </summary>
    [Column("R#DCT")]
    public string R_DCT { get; set; }

    /// <summary>
    /// R#DOC (Primary Key).
    /// </summary>
    [Column("R#DOC")]
    public decimal R_DOC { get; set; }

    /// <summary>
    /// R#SEN.
    /// </summary>
    [Column("R#SEN")]
    public decimal? R_SEN { get; set; }

    /// <summary>
    /// R#DGJ.
    /// </summary>
    [Column("R#DGJ")]
    public decimal? R_DGJ { get; set; }

    /// <summary>
    /// R#CTRY.
    /// </summary>
    [Column("R#CTRY")]
    public decimal? R_CTRY { get; set; }

    /// <summary>
    /// R#RFAC.
    /// </summary>
    [Column("R#RFAC")]
    public decimal? R_RFAC { get; set; }

    /// <summary>
    /// R#EXA.
    /// </summary>
    [Column("R#EXA")]
    public string? R_EXA { get; set; }

    /// <summary>
    /// R#CO (Primary Key).
    /// </summary>
    [Column("R#CO")]
    public string R_CO { get; set; }

    /// <summary>
    /// R#RF.
    /// </summary>
    [Column("R#RF")]
    public string? R_RF { get; set; }

    /// <summary>
    /// R#ANI.
    /// </summary>
    [Column("R#ANI")]
    public string? R_ANI { get; set; }

    /// <summary>
    /// R#AID.
    /// </summary>
    [Column("R#AID")]
    public string? R_AID { get; set; }

    /// <summary>
    /// R#AM.
    /// </summary>
    [Column("R#AM")]
    public string? R_AM { get; set; }

    /// <summary>
    /// R#SBL.
    /// </summary>
    [Column("R#SBL")]
    public string? R_SBL { get; set; }

    /// <summary>
    /// R#SBLT.
    /// </summary>
    [Column("R#SBLT")]
    public string? R_SBLT { get; set; }

    /// <summary>
    /// R#FCC.
    /// </summary>
    [Column("R#FCC")]
    public string? R_FCC { get; set; }

    /// <summary>
    /// R#FCCN.
    /// </summary>
    [Column("R#FCCN")]
    public string? R_FCCN { get; set; }

    /// <summary>
    /// R#FCCC.
    /// </summary>
    [Column("R#FCCC")]
    public string? R_FCCC { get; set; }

    /// <summary>
    /// R#FROM.
    /// </summary>
    [Column("R#FROM")]
    public string? R_FROM { get; set; }

    /// <summary>
    /// R#OBJF.
    /// </summary>
    [Column("R#OBJF")]
    public string? R_OBJF { get; set; }

    /// <summary>
    /// R#FSUB.
    /// </summary>
    [Column("R#FSUB")]
    public string? R_FSUB { get; set; }

    /// <summary>
    /// R#FSBL.
    /// </summary>
    [Column("R#FSBL")]
    public string? R_FSBL { get; set; }

    /// <summary>
    /// R#SLK.
    /// </summary>
    [Column("R#SLK")]
    public string? R_SLK { get; set; }

    /// <summary>
    /// R#FLT.
    /// </summary>
    [Column("R#FLT")]
    public string? R_FLT { get; set; }

    /// <summary>
    /// R#FMYI.
    /// </summary>
    [Column("R#FMYI")]
    public string? R_FMYI { get; set; }

    /// <summary>
    /// R#FPN.
    /// </summary>
    [Column("R#FPN")]
    public decimal? R_FPN { get; set; }

    /// <summary>
    /// R#FFY.
    /// </summary>
    [Column("R#FFY")]
    public decimal? R_FFY { get; set; }

    /// <summary>
    /// R#FCTY.
    /// </summary>
    [Column("R#FCTY")]
    public decimal? R_FCTY { get; set; }

    /// <summary>
    /// R#THRU.
    /// </summary>
    [Column("R#THRU")]
    public string? R_THRU { get; set; }

    /// <summary>
    /// R#OBJT.
    /// </summary>
    [Column("R#OBJT")]
    public string? R_OBJT { get; set; }

    /// <summary>
    /// R#SUBT.
    /// </summary>
    [Column("R#SUBT")]
    public string? R_SUBT { get; set; }

    /// <summary>
    /// R#TSBL.
    /// </summary>
    [Column("R#TSBL")]
    public string? R_TSBL { get; set; }

    /// <summary>
    /// R#BCCN.
    /// </summary>
    [Column("R#BCCN")]
    public string? R_BCCN { get; set; }

    /// <summary>
    /// R#BCCC.
    /// </summary>
    [Column("R#BCCC")]
    public string? R_BCCC { get; set; }

    /// <summary>
    /// R#BFOB.
    /// </summary>
    [Column("R#BFOB")]
    public string? R_BFOB { get; set; }

    /// <summary>
    /// R#BFSU.
    /// </summary>
    [Column("R#BFSU")]
    public string? R_BFSU { get; set; }

    /// <summary>
    /// R#BFSL.
    /// </summary>
    [Column("R#BFSL")]
    public string? R_BFSL { get; set; }

    /// <summary>
    /// R#BSLT.
    /// </summary>
    [Column("R#BSLT")]
    public string? R_BSLT { get; set; }

    /// <summary>
    /// R#BLT.
    /// </summary>
    [Column("R#BLT")]
    public string? R_BLT { get; set; }

    /// <summary>
    /// R#BMYI.
    /// </summary>
    [Column("R#BMYI")]
    public string? R_BMYI { get; set; }

    /// <summary>
    /// R#BPNO.
    /// </summary>
    [Column("R#BPNO")]
    public decimal? R_BPNO { get; set; }

    /// <summary>
    /// R#BFY.
    /// </summary>
    [Column("R#BFY")]
    public decimal? R_BFY { get; set; }

    /// <summary>
    /// R#BCTR.
    /// </summary>
    [Column("R#BCTR")]
    public decimal? R_BCTR { get; set; }

    /// <summary>
    /// R#BTOB.
    /// </summary>
    [Column("R#BTOB")]
    public string? R_BTOB { get; set; }

    /// <summary>
    /// R#BTSU.
    /// </summary>
    [Column("R#BTSU")]
    public string? R_BTSU { get; set; }

    /// <summary>
    /// R#BTSL.
    /// </summary>
    [Column("R#BTSL")]
    public string? R_BTSL { get; set; }

    /// <summary>
    /// R#AOBA.
    /// </summary>
    [Column("R#AOBA")]
    public string? R_AOBA { get; set; }

    /// <summary>
    /// R#ASBA.
    /// </summary>
    [Column("R#ASBA")]
    public string? R_ASBA { get; set; }

    /// <summary>
    /// R#ASBL.
    /// </summary>
    [Column("R#ASBL")]
    public string? R_ASBL { get; set; }

    /// <summary>
    /// R#ALTA.
    /// </summary>
    [Column("R#ALTA")]
    public string? R_ALTA { get; set; }

    /// <summary>
    /// R#USER.
    /// </summary>
    [Column("R#USER")]
    public string? R_USER { get; set; }

    /// <summary>
    /// R#LCT.
    /// </summary>
    [Column("R#LCT")]
    public decimal? R_LCT { get; set; }

    /// <summary>
    /// R#SDTE.
    /// </summary>
    [Column("R#SDTE")]
    public decimal? R_SDTE { get; set; }

    /// <summary>
    /// R#ASBT.
    /// </summary>
    [Column("R#ASBT")]
    public string? R_ASBT { get; set; }

    /// <summary>
    /// R#PID.
    /// </summary>
    [Column("R#PID")]
    public string? R_PID { get; set; }

    /// <summary>
    /// R#UPMJ.
    /// </summary>
    [Column("R#UPMJ")]
    public decimal? R_UPMJ { get; set; }

    /// <summary>
    /// R#JOBN.
    /// </summary>
    [Column("R#JOBN")]
    public string? R_JOBN { get; set; }

    /// <summary>
    /// R#UPMT.
    /// </summary>
    [Column("R#UPMT")]
    public decimal? R_UPMT { get; set; }
}
