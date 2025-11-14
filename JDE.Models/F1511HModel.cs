using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F1511H - .
/// </summary>
public class F1511HModel
{
    /// <summary>
    /// N#GENT (Primary Key).
    /// </summary>
    [Column("N#GENT")]
    public string N_GENT { get; set; }

    /// <summary>
    /// N#ICU (Primary Key).
    /// </summary>
    [Column("N#ICU")]
    public decimal N_ICU { get; set; }

    /// <summary>
    /// N#DOC (Primary Key).
    /// </summary>
    [Column("N#DOC")]
    public decimal N_DOC { get; set; }

    /// <summary>
    /// N#SFX (Primary Key).
    /// </summary>
    [Column("N#SFX")]
    public string N_SFX { get; set; }

    /// <summary>
    /// N#DOCO (Primary Key).
    /// </summary>
    [Column("N#DOCO")]
    public decimal N_DOCO { get; set; }

    /// <summary>
    /// N#DCTO.
    /// </summary>
    [Column("N#DCTO")]
    public string? N_DCTO { get; set; }

    /// <summary>
    /// N#SOSQ.
    /// </summary>
    [Column("N#SOSQ")]
    public decimal? N_SOSQ { get; set; }

    /// <summary>
    /// N#MCUS.
    /// </summary>
    [Column("N#MCUS")]
    public string? N_MCUS { get; set; }

    /// <summary>
    /// N#AN8.
    /// </summary>
    [Column("N#AN8")]
    public decimal? N_AN8 { get; set; }

    /// <summary>
    /// N#AN8J.
    /// </summary>
    [Column("N#AN8J")]
    public decimal? N_AN8J { get; set; }

    /// <summary>
    /// N#DL01.
    /// </summary>
    [Column("N#DL01")]
    public string? N_DL01 { get; set; }

    /// <summary>
    /// N#MCU.
    /// </summary>
    [Column("N#MCU")]
    public string? N_MCU { get; set; }

    /// <summary>
    /// N#OBJ.
    /// </summary>
    [Column("N#OBJ")]
    public string? N_OBJ { get; set; }

    /// <summary>
    /// N#SUB.
    /// </summary>
    [Column("N#SUB")]
    public string? N_SUB { get; set; }

    /// <summary>
    /// N#SBL.
    /// </summary>
    [Column("N#SBL")]
    public string? N_SBL { get; set; }

    /// <summary>
    /// N#AID.
    /// </summary>
    [Column("N#AID")]
    public string? N_AID { get; set; }

    /// <summary>
    /// N#CO.
    /// </summary>
    [Column("N#CO")]
    public string? N_CO { get; set; }

    /// <summary>
    /// N#DG.
    /// </summary>
    [Column("N#DG")]
    public decimal? N_DG { get; set; }

    /// <summary>
    /// N#DSV.
    /// </summary>
    [Column("N#DSV")]
    public decimal? N_DSV { get; set; }

    /// <summary>
    /// N#GLC.
    /// </summary>
    [Column("N#GLC")]
    public string? N_GLC { get; set; }

    /// <summary>
    /// N#BPN (Primary Key).
    /// </summary>
    [Column("N#BPN")]
    public decimal N_BPN { get; set; }

    /// <summary>
    /// N#YR (Primary Key).
    /// </summary>
    [Column("N#YR")]
    public decimal N_YR { get; set; }

    /// <summary>
    /// N#AG.
    /// </summary>
    [Column("N#AG")]
    public decimal? N_AG { get; set; }

    /// <summary>
    /// N#AN01.
    /// </summary>
    [Column("N#AN01")]
    public decimal? N_AN01 { get; set; }

    /// <summary>
    /// N#DI.
    /// </summary>
    [Column("N#DI")]
    public decimal? N_DI { get; set; }

    /// <summary>
    /// N#DD.
    /// </summary>
    [Column("N#DD")]
    public decimal? N_DD { get; set; }

    /// <summary>
    /// N#PTC.
    /// </summary>
    [Column("N#PTC")]
    public string? N_PTC { get; set; }

    /// <summary>
    /// N#TRAN.
    /// </summary>
    [Column("N#TRAN")]
    public string? N_TRAN { get; set; }

    /// <summary>
    /// N#SEPI.
    /// </summary>
    [Column("N#SEPI")]
    public string? N_SEPI { get; set; }

    /// <summary>
    /// N#ITMG.
    /// </summary>
    [Column("N#ITMG")]
    public string? N_ITMG { get; set; }

    /// <summary>
    /// N#LNID.
    /// </summary>
    [Column("N#LNID")]
    public decimal? N_LNID { get; set; }

    /// <summary>
    /// N#DIC.
    /// </summary>
    [Column("N#DIC")]
    public decimal? N_DIC { get; set; }

    /// <summary>
    /// N#PDUE.
    /// </summary>
    [Column("N#PDUE")]
    public decimal? N_PDUE { get; set; }

    /// <summary>
    /// N#EPCL.
    /// </summary>
    [Column("N#EPCL")]
    public string? N_EPCL { get; set; }

    /// <summary>
    /// N#DPER.
    /// </summary>
    [Column("N#DPER")]
    public decimal? N_DPER { get; set; }

    /// <summary>
    /// N#DPAR.
    /// </summary>
    [Column("N#DPAR")]
    public decimal? N_DPAR { get; set; }

    /// <summary>
    /// N#EXCD.
    /// </summary>
    [Column("N#EXCD")]
    public string? N_EXCD { get; set; }

    /// <summary>
    /// N#BCI (Primary Key).
    /// </summary>
    [Column("N#BCI")]
    public decimal N_BCI { get; set; }

    /// <summary>
    /// N#PRDC.
    /// </summary>
    [Column("N#PRDC")]
    public string? N_PRDC { get; set; }

    /// <summary>
    /// N#YRO.
    /// </summary>
    [Column("N#YRO")]
    public decimal? N_YRO { get; set; }

    /// <summary>
    /// N#CTRY (Primary Key).
    /// </summary>
    [Column("N#CTRY")]
    public decimal N_CTRY { get; set; }

    /// <summary>
    /// N#RPRD.
    /// </summary>
    [Column("N#RPRD")]
    public decimal? N_RPRD { get; set; }

    /// <summary>
    /// N#CRCD.
    /// </summary>
    [Column("N#CRCD")]
    public string? N_CRCD { get; set; }

    /// <summary>
    /// N#CRR.
    /// </summary>
    [Column("N#CRR")]
    public decimal? N_CRR { get; set; }

    /// <summary>
    /// N#ACR.
    /// </summary>
    [Column("N#ACR")]
    public decimal? N_ACR { get; set; }

    /// <summary>
    /// N#TXA1.
    /// </summary>
    [Column("N#TXA1")]
    public string? N_TXA1 { get; set; }

    /// <summary>
    /// N#EXR1.
    /// </summary>
    [Column("N#EXR1")]
    public string? N_EXR1 { get; set; }

    /// <summary>
    /// N#STAM.
    /// </summary>
    [Column("N#STAM")]
    public decimal? N_STAM { get; set; }

    /// <summary>
    /// N#ATXN.
    /// </summary>
    [Column("N#ATXN")]
    public decimal? N_ATXN { get; set; }

    /// <summary>
    /// N#ATXA.
    /// </summary>
    [Column("N#ATXA")]
    public decimal? N_ATXA { get; set; }

    /// <summary>
    /// N#USER.
    /// </summary>
    [Column("N#USER")]
    public string? N_USER { get; set; }

    /// <summary>
    /// N#UPMJ.
    /// </summary>
    [Column("N#UPMJ")]
    public decimal? N_UPMJ { get; set; }

    /// <summary>
    /// N#PID.
    /// </summary>
    [Column("N#PID")]
    public string? N_PID { get; set; }

    /// <summary>
    /// N#JOBN.
    /// </summary>
    [Column("N#JOBN")]
    public string? N_JOBN { get; set; }

    /// <summary>
    /// N#SBLT.
    /// </summary>
    [Column("N#SBLT")]
    public string? N_SBLT { get; set; }

    /// <summary>
    /// N#CRRM.
    /// </summary>
    [Column("N#CRRM")]
    public string? N_CRRM { get; set; }

    /// <summary>
    /// N#FAP.
    /// </summary>
    [Column("N#FAP")]
    public decimal? N_FAP { get; set; }

    /// <summary>
    /// N#CDS.
    /// </summary>
    [Column("N#CDS")]
    public decimal? N_CDS { get; set; }

    /// <summary>
    /// N#CDSA.
    /// </summary>
    [Column("N#CDSA")]
    public decimal? N_CDSA { get; set; }

    /// <summary>
    /// N#CTAM.
    /// </summary>
    [Column("N#CTAM")]
    public decimal? N_CTAM { get; set; }

    /// <summary>
    /// N#CTXA.
    /// </summary>
    [Column("N#CTXA")]
    public decimal? N_CTXA { get; set; }

    /// <summary>
    /// N#CTXN.
    /// </summary>
    [Column("N#CTXN")]
    public decimal? N_CTXN { get; set; }

    /// <summary>
    /// N#MI.
    /// </summary>
    [Column("N#MI")]
    public string? N_MI { get; set; }

    /// <summary>
    /// N#DBAN.
    /// </summary>
    [Column("N#DBAN")]
    public decimal? N_DBAN { get; set; }

    /// <summary>
    /// N#UNIT.
    /// </summary>
    [Column("N#UNIT")]
    public string? N_UNIT { get; set; }

    /// <summary>
    /// N#BLMR.
    /// </summary>
    [Column("N#BLMR")]
    public string? N_BLMR { get; set; }

    /// <summary>
    /// N#EFFC.
    /// </summary>
    [Column("N#EFFC")]
    public string? N_EFFC { get; set; }

    /// <summary>
    /// N#SOBT (Primary Key).
    /// </summary>
    [Column("N#SOBT")]
    public string N_SOBT { get; set; }

    /// <summary>
    /// N#SBJR.
    /// </summary>
    [Column("N#SBJR")]
    public string? N_SBJR { get; set; }

    /// <summary>
    /// N#ICB1.
    /// </summary>
    [Column("N#ICB1")]
    public string? N_ICB1 { get; set; }

    /// <summary>
    /// N#ICB2.
    /// </summary>
    [Column("N#ICB2")]
    public string? N_ICB2 { get; set; }

    /// <summary>
    /// N#ICB3.
    /// </summary>
    [Column("N#ICB3")]
    public string? N_ICB3 { get; set; }

    /// <summary>
    /// N#ICB4.
    /// </summary>
    [Column("N#ICB4")]
    public string? N_ICB4 { get; set; }

    /// <summary>
    /// N#ICB5.
    /// </summary>
    [Column("N#ICB5")]
    public string? N_ICB5 { get; set; }

    /// <summary>
    /// N#INVP.
    /// </summary>
    [Column("N#INVP")]
    public string? N_INVP { get; set; }

    /// <summary>
    /// N#PRRB.
    /// </summary>
    [Column("N#PRRB")]
    public string? N_PRRB { get; set; }

    /// <summary>
    /// N#BCIR.
    /// </summary>
    [Column("N#BCIR")]
    public decimal? N_BCIR { get; set; }

    /// <summary>
    /// N#ICBC.
    /// </summary>
    [Column("N#ICBC")]
    public string? N_ICBC { get; set; }

    /// <summary>
    /// N#IST.
    /// </summary>
    [Column("N#IST")]
    public string? N_IST { get; set; }

    /// <summary>
    /// N#SOTY.
    /// </summary>
    [Column("N#SOTY")]
    public string? N_SOTY { get; set; }

    /// <summary>
    /// N#ODOC.
    /// </summary>
    [Column("N#ODOC")]
    public decimal? N_ODOC { get; set; }

    /// <summary>
    /// N#ODCT.
    /// </summary>
    [Column("N#ODCT")]
    public string? N_ODCT { get; set; }

    /// <summary>
    /// N#OSFX.
    /// </summary>
    [Column("N#OSFX")]
    public string? N_OSFX { get; set; }

    /// <summary>
    /// N#UPMT.
    /// </summary>
    [Column("N#UPMT")]
    public decimal? N_UPMT { get; set; }

    /// <summary>
    /// N#KCO.
    /// </summary>
    [Column("N#KCO")]
    public string? N_KCO { get; set; }

    /// <summary>
    /// N#OKCO.
    /// </summary>
    [Column("N#OKCO")]
    public string? N_OKCO { get; set; }
}
