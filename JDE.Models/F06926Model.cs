using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F06926 - .
/// </summary>
public class F06926Model
{
    /// <summary>
    /// Y#TARA (Primary Key).
    /// </summary>
    [Column("Y#TARA")]
    public string Y_TARA { get; set; }

    /// <summary>
    /// Y#PTAX (Primary Key).
    /// </summary>
    [Column("Y#PTAX")]
    public string Y_PTAX { get; set; }

    /// <summary>
    /// Y#HMCO (Primary Key).
    /// </summary>
    [Column("Y#HMCO")]
    public string Y_HMCO { get; set; }

    /// <summary>
    /// Y#ANN8.
    /// </summary>
    [Column("Y#ANN8")]
    public decimal? Y_ANN8 { get; set; }
}
