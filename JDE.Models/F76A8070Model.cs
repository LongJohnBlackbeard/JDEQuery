using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F76A8070 - .
/// </summary>
public class F76A8070Model
{
    /// <summary>
    /// K7AN8 (Primary Key).
    /// </summary>
    public decimal K7AN8 { get; set; }

    /// <summary>
    /// K7A004 (Primary Key).
    /// </summary>
    public string K7A004 { get; set; }

    /// <summary>
    /// K7DG# (Primary Key).
    /// </summary>
    [Column("K7DG#")]
    public decimal K7DG_ { get; set; }

    /// <summary>
    /// K7DGY (Primary Key).
    /// </summary>
    public decimal K7DGY { get; set; }

    /// <summary>
    /// K7DGM (Primary Key).
    /// </summary>
    public decimal K7DGM { get; set; }

    /// <summary>
    /// K7CO (Primary Key).
    /// </summary>
    public string K7CO { get; set; }

    /// <summary>
    /// K7ATXA.
    /// </summary>
    public decimal? K7ATXA { get; set; }

    /// <summary>
    /// K7AG1.
    /// </summary>
    public decimal? K7AG1 { get; set; }

    /// <summary>
    /// K7USER.
    /// </summary>
    public string? K7USER { get; set; }

    /// <summary>
    /// K7PID.
    /// </summary>
    public string? K7PID { get; set; }

    /// <summary>
    /// K7UPMJ.
    /// </summary>
    public decimal? K7UPMJ { get; set; }

    /// <summary>
    /// K7UPMT.
    /// </summary>
    public decimal? K7UPMT { get; set; }

    /// <summary>
    /// K7JOBN.
    /// </summary>
    public string? K7JOBN { get; set; }
}
