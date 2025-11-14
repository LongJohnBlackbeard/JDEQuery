using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F76A0456 - .
/// </summary>
public class F76A0456Model
{
    /// <summary>
    /// X1AN8 (Primary Key).
    /// </summary>
    public decimal X1AN8 { get; set; }

    /// <summary>
    /// X1A011 (Primary Key).
    /// </summary>
    public string X1A011 { get; set; }

    /// <summary>
    /// X1DG# (Primary Key).
    /// </summary>
    [Column("X1DG#")]
    public decimal X1DG_ { get; set; }

    /// <summary>
    /// X1DGY (Primary Key).
    /// </summary>
    public decimal X1DGY { get; set; }

    /// <summary>
    /// X1DGM (Primary Key).
    /// </summary>
    public decimal X1DGM { get; set; }

    /// <summary>
    /// X1CO (Primary Key).
    /// </summary>
    public string X1CO { get; set; }

    /// <summary>
    /// X1ATXA.
    /// </summary>
    public decimal? X1ATXA { get; set; }

    /// <summary>
    /// X1AG1.
    /// </summary>
    public decimal? X1AG1 { get; set; }
}
