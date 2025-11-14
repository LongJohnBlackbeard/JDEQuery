using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F09UI004 - .
/// </summary>
public class F09UI004Model
{
    /// <summary>
    /// R#ICU (Primary Key).
    /// </summary>
    [Column("R#ICU")]
    public decimal R_ICU { get; set; }

    /// <summary>
    /// R#ICUT (Primary Key).
    /// </summary>
    [Column("R#ICUT")]
    public string R_ICUT { get; set; }

    /// <summary>
    /// R#RTAL (Primary Key).
    /// </summary>
    [Column("R#RTAL")]
    public string R_RTAL { get; set; }

    /// <summary>
    /// R#RCK9 (Primary Key).
    /// </summary>
    [Column("R#RCK9")]
    public decimal R_RCK9 { get; set; }

    /// <summary>
    /// R#DOC.
    /// </summary>
    [Column("R#DOC")]
    public decimal? R_DOC { get; set; }

    /// <summary>
    /// R#DCT.
    /// </summary>
    [Column("R#DCT")]
    public string? R_DCT { get; set; }

    /// <summary>
    /// R#KCO.
    /// </summary>
    [Column("R#KCO")]
    public string? R_KCO { get; set; }

    /// <summary>
    /// R#AID.
    /// </summary>
    [Column("R#AID")]
    public string? R_AID { get; set; }

    /// <summary>
    /// R#MCU.
    /// </summary>
    [Column("R#MCU")]
    public string? R_MCU { get; set; }

    /// <summary>
    /// R#OBJ.
    /// </summary>
    [Column("R#OBJ")]
    public string? R_OBJ { get; set; }

    /// <summary>
    /// R#SUB.
    /// </summary>
    [Column("R#SUB")]
    public string? R_SUB { get; set; }

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
    /// R#LT.
    /// </summary>
    [Column("R#LT")]
    public string? R_LT { get; set; }

    /// <summary>
    /// R#CTRY.
    /// </summary>
    [Column("R#CTRY")]
    public decimal? R_CTRY { get; set; }

    /// <summary>
    /// R#FY.
    /// </summary>
    [Column("R#FY")]
    public decimal? R_FY { get; set; }

    /// <summary>
    /// R#PNC.
    /// </summary>
    [Column("R#PNC")]
    public decimal? R_PNC { get; set; }

    /// <summary>
    /// R#APYC.
    /// </summary>
    [Column("R#APYC")]
    public decimal? R_APYC { get; set; }

    /// <summary>
    /// R#CRCX.
    /// </summary>
    [Column("R#CRCX")]
    public string? R_CRCX { get; set; }
}
