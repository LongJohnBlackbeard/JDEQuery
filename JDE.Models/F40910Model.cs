using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F40910 - .
/// </summary>
public class F40910Model
{
    /// <summary>
    /// P#JOB (Primary Key).
    /// </summary>
    [Column("P#JOB")]
    public string P_JOB { get; set; }

    /// <summary>
    /// P#CTID (Primary Key).
    /// </summary>
    [Column("P#CTID")]
    public string P_CTID { get; set; }

    /// <summary>
    /// P#AID (Primary Key).
    /// </summary>
    [Column("P#AID")]
    public string P_AID { get; set; }

    /// <summary>
    /// P#SBL (Primary Key).
    /// </summary>
    [Column("P#SBL")]
    public string P_SBL { get; set; }

    /// <summary>
    /// P#SBLT (Primary Key).
    /// </summary>
    [Column("P#SBLT")]
    public string P_SBLT { get; set; }

    /// <summary>
    /// P#AA.
    /// </summary>
    [Column("P#AA")]
    public decimal? P_AA { get; set; }

    /// <summary>
    /// P#AOPN.
    /// </summary>
    [Column("P#AOPN")]
    public decimal? P_AOPN { get; set; }

    /// <summary>
    /// P#AAP.
    /// </summary>
    [Column("P#AAP")]
    public decimal? P_AAP { get; set; }

    /// <summary>
    /// P#APYC.
    /// </summary>
    [Column("P#APYC")]
    public decimal? P_APYC { get; set; }

    /// <summary>
    /// P#MCU.
    /// </summary>
    [Column("P#MCU")]
    public string? P_MCU { get; set; }

    /// <summary>
    /// P#OBJ.
    /// </summary>
    [Column("P#OBJ")]
    public string? P_OBJ { get; set; }

    /// <summary>
    /// P#SUB.
    /// </summary>
    [Column("P#SUB")]
    public string? P_SUB { get; set; }

    /// <summary>
    /// P#CO.
    /// </summary>
    [Column("P#CO")]
    public string? P_CO { get; set; }

    /// <summary>
    /// P#DL01.
    /// </summary>
    [Column("P#DL01")]
    public string? P_DL01 { get; set; }
}
