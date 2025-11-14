using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F06904 - .
/// </summary>
public class F06904Model
{
    /// <summary>
    /// Y#CO.
    /// </summary>
    [Column("Y#CO")]
    public string? Y_CO { get; set; }

    /// <summary>
    /// Y#MCUH.
    /// </summary>
    [Column("Y#MCUH")]
    public string? Y_MCUH { get; set; }

    /// <summary>
    /// Y#LBOB.
    /// </summary>
    [Column("Y#LBOB")]
    public string? Y_LBOB { get; set; }

    /// <summary>
    /// Y#LSUB.
    /// </summary>
    [Column("Y#LSUB")]
    public string? Y_LSUB { get; set; }

    /// <summary>
    /// Y#PDBA.
    /// </summary>
    [Column("Y#PDBA")]
    public decimal? Y_PDBA { get; set; }

    /// <summary>
    /// Y#FRTY.
    /// </summary>
    [Column("Y#FRTY")]
    public string? Y_FRTY { get; set; }

    /// <summary>
    /// Y#MCU.
    /// </summary>
    [Column("Y#MCU")]
    public string? Y_MCU { get; set; }

    /// <summary>
    /// Y#OBJ.
    /// </summary>
    [Column("Y#OBJ")]
    public string? Y_OBJ { get; set; }

    /// <summary>
    /// Y#SUB.
    /// </summary>
    [Column("Y#SUB")]
    public string? Y_SUB { get; set; }

    /// <summary>
    /// Y#HMT.
    /// </summary>
    [Column("Y#HMT")]
    public string? Y_HMT { get; set; }

    /// <summary>
    /// Y#HFLG.
    /// </summary>
    [Column("Y#HFLG")]
    public string? Y_HFLG { get; set; }

    /// <summary>
    /// Y#JNLF.
    /// </summary>
    [Column("Y#JNLF")]
    public string? Y_JNLF { get; set; }

    /// <summary>
    /// Y#PRJC.
    /// </summary>
    [Column("Y#PRJC")]
    public string? Y_PRJC { get; set; }

    /// <summary>
    /// Y#SBL.
    /// </summary>
    [Column("Y#SBL")]
    public string? Y_SBL { get; set; }

    /// <summary>
    /// Y#SBLT.
    /// </summary>
    [Column("Y#SBLT")]
    public string? Y_SBLT { get; set; }

    /// <summary>
    /// Y#DL01.
    /// </summary>
    [Column("Y#DL01")]
    public string? Y_DL01 { get; set; }

    /// <summary>
    /// Y#MCUO.
    /// </summary>
    [Column("Y#MCUO")]
    public string? Y_MCUO { get; set; }

    /// <summary>
    /// Y#UN.
    /// </summary>
    [Column("Y#UN")]
    public string? Y_UN { get; set; }

    /// <summary>
    /// Y#JBCD.
    /// </summary>
    [Column("Y#JBCD")]
    public string? Y_JBCD { get; set; }

    /// <summary>
    /// Y#JBST.
    /// </summary>
    [Column("Y#JBST")]
    public string? Y_JBST { get; set; }

    /// <summary>
    /// Y#UKID (Primary Key).
    /// </summary>
    [Column("Y#UKID")]
    public decimal Y_UKID { get; set; }
}
