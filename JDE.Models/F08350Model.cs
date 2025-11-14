using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08350 - .
/// </summary>
public class F08350Model
{
    /// <summary>
    /// BKDIVC (Primary Key).
    /// </summary>
    public string BKDIVC { get; set; }

    /// <summary>
    /// BKUNRU.
    /// </summary>
    public string? BKUNRU { get; set; }

    /// <summary>
    /// BKSBGR (Primary Key).
    /// </summary>
    public string BKSBGR { get; set; }

    /// <summary>
    /// BKSEQ#.
    /// </summary>
    [Column("BKSEQ#")]
    public decimal? BKSEQ_ { get; set; }

    /// <summary>
    /// BKSGRU.
    /// </summary>
    public string? BKSGRU { get; set; }
}
