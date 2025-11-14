using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F760406A - .
/// </summary>
public class F760406AModel
{
    /// <summary>
    /// K6AN8 (Primary Key).
    /// </summary>
    public decimal K6AN8 { get; set; }

    /// <summary>
    /// K6A004 (Primary Key).
    /// </summary>
    public string K6A004 { get; set; }

    /// <summary>
    /// K6DG# (Primary Key).
    /// </summary>
    [Column("K6DG#")]
    public decimal K6DG_ { get; set; }

    /// <summary>
    /// K6DGY (Primary Key).
    /// </summary>
    public decimal K6DGY { get; set; }

    /// <summary>
    /// K6DGM (Primary Key).
    /// </summary>
    public decimal K6DGM { get; set; }

    /// <summary>
    /// K6CO (Primary Key).
    /// </summary>
    public string K6CO { get; set; }

    /// <summary>
    /// K6ATXA.
    /// </summary>
    public decimal? K6ATXA { get; set; }

    /// <summary>
    /// K6AG1.
    /// </summary>
    public decimal? K6AG1 { get; set; }
}
