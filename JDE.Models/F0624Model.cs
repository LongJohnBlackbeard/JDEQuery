using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F0624 - .
/// </summary>
public class F0624Model
{
    /// <summary>
    /// J#PRTR (Primary Key).
    /// </summary>
    [Column("J#PRTR")]
    public decimal J_PRTR { get; set; }

    /// <summary>
    /// J#RCBT.
    /// </summary>
    [Column("J#RCBT")]
    public string? J_RCBT { get; set; }

    /// <summary>
    /// J#PDBA.
    /// </summary>
    [Column("J#PDBA")]
    public decimal? J_PDBA { get; set; }

    /// <summary>
    /// J#PTAX.
    /// </summary>
    [Column("J#PTAX")]
    public string? J_PTAX { get; set; }

    /// <summary>
    /// J#FRTY.
    /// </summary>
    [Column("J#FRTY")]
    public string? J_FRTY { get; set; }

    /// <summary>
    /// J#B2RT.
    /// </summary>
    [Column("J#B2RT")]
    public decimal? J_B2RT { get; set; }

    /// <summary>
    /// J#BDA.
    /// </summary>
    [Column("J#BDA")]
    public decimal? J_BDA { get; set; }

    /// <summary>
    /// J#MCU.
    /// </summary>
    [Column("J#MCU")]
    public string? J_MCU { get; set; }

    /// <summary>
    /// J#OBJ.
    /// </summary>
    [Column("J#OBJ")]
    public string? J_OBJ { get; set; }

    /// <summary>
    /// J#SUB.
    /// </summary>
    [Column("J#SUB")]
    public string? J_SUB { get; set; }

    /// <summary>
    /// J#SBL.
    /// </summary>
    [Column("J#SBL")]
    public string? J_SBL { get; set; }

    /// <summary>
    /// J#SBLT.
    /// </summary>
    [Column("J#SBLT")]
    public string? J_SBLT { get; set; }

    /// <summary>
    /// J#BRDS.
    /// </summary>
    [Column("J#BRDS")]
    public string? J_BRDS { get; set; }

    /// <summary>
    /// J#WR01.
    /// </summary>
    [Column("J#WR01")]
    public string? J_WR01 { get; set; }

    /// <summary>
    /// J#PHRW.
    /// </summary>
    [Column("J#PHRW")]
    public decimal? J_PHRW { get; set; }

    /// <summary>
    /// J#DEDM.
    /// </summary>
    [Column("J#DEDM")]
    public string? J_DEDM { get; set; }

    /// <summary>
    /// J#AID.
    /// </summary>
    [Column("J#AID")]
    public string? J_AID { get; set; }
}
