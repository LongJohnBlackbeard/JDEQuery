using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08096 - .
/// </summary>
public class F08096Model
{
    /// <summary>
    /// H$TBLN (Primary Key).
    /// </summary>
    [Column("H$TBLN")]
    public decimal H_TBLN { get; set; }

    /// <summary>
    /// H$DL01.
    /// </summary>
    [Column("H$DL01")]
    public string? H_DL01 { get; set; }

    /// <summary>
    /// H$DC.
    /// </summary>
    [Column("H$DC")]
    public string? H_DC { get; set; }

    /// <summary>
    /// H$DL02.
    /// </summary>
    [Column("H$DL02")]
    public string? H_DL02 { get; set; }

    /// <summary>
    /// H$DL03.
    /// </summary>
    [Column("H$DL03")]
    public string? H_DL03 { get; set; }

    /// <summary>
    /// H$DL04.
    /// </summary>
    [Column("H$DL04")]
    public string? H_DL04 { get; set; }

    /// <summary>
    /// H$DL05.
    /// </summary>
    [Column("H$DL05")]
    public string? H_DL05 { get; set; }

    /// <summary>
    /// H$TBLT.
    /// </summary>
    [Column("H$TBLT")]
    public string? H_TBLT { get; set; }

    /// <summary>
    /// H$SY.
    /// </summary>
    [Column("H$SY")]
    public string? H_SY { get; set; }

    /// <summary>
    /// H$RT.
    /// </summary>
    [Column("H$RT")]
    public string? H_RT { get; set; }
}
