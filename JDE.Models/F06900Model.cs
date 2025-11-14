using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F06900 - .
/// </summary>
public class F06900Model
{
    /// <summary>
    /// Y$HMCO (Primary Key).
    /// </summary>
    [Column("Y$HMCO")]
    public string Y_HMCO { get; set; }

    /// <summary>
    /// Y$DFY (Primary Key).
    /// </summary>
    [Column("Y$DFY")]
    public decimal Y_DFY { get; set; }

    /// <summary>
    /// Y$PNC.
    /// </summary>
    [Column("Y$PNC")]
    public decimal? Y_PNC { get; set; }

    /// <summary>
    /// Y$D01.
    /// </summary>
    [Column("Y$D01")]
    public decimal? Y_D01 { get; set; }

    /// <summary>
    /// Y$D02.
    /// </summary>
    [Column("Y$D02")]
    public decimal? Y_D02 { get; set; }

    /// <summary>
    /// Y$D03.
    /// </summary>
    [Column("Y$D03")]
    public decimal? Y_D03 { get; set; }

    /// <summary>
    /// Y$D04.
    /// </summary>
    [Column("Y$D04")]
    public decimal? Y_D04 { get; set; }

    /// <summary>
    /// Y$D05.
    /// </summary>
    [Column("Y$D05")]
    public decimal? Y_D05 { get; set; }

    /// <summary>
    /// Y$D06.
    /// </summary>
    [Column("Y$D06")]
    public decimal? Y_D06 { get; set; }

    /// <summary>
    /// Y$D07.
    /// </summary>
    [Column("Y$D07")]
    public decimal? Y_D07 { get; set; }

    /// <summary>
    /// Y$D08.
    /// </summary>
    [Column("Y$D08")]
    public decimal? Y_D08 { get; set; }

    /// <summary>
    /// Y$D09.
    /// </summary>
    [Column("Y$D09")]
    public decimal? Y_D09 { get; set; }

    /// <summary>
    /// Y$D10.
    /// </summary>
    [Column("Y$D10")]
    public decimal? Y_D10 { get; set; }

    /// <summary>
    /// Y$D11.
    /// </summary>
    [Column("Y$D11")]
    public decimal? Y_D11 { get; set; }

    /// <summary>
    /// Y$D12.
    /// </summary>
    [Column("Y$D12")]
    public decimal? Y_D12 { get; set; }
}
