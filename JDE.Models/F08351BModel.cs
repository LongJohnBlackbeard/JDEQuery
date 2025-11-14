using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08351B - .
/// </summary>
public class F08351BModel
{
    /// <summary>
    /// PCDIVC (Primary Key).
    /// </summary>
    public string PCDIVC { get; set; }

    /// <summary>
    /// PCSBGR (Primary Key).
    /// </summary>
    public string PCSBGR { get; set; }

    /// <summary>
    /// PCSEQ#.
    /// </summary>
    [Column("PCSEQ#")]
    public decimal? PCSEQ_ { get; set; }

    /// <summary>
    /// PCPLAN (Primary Key).
    /// </summary>
    public string PCPLAN { get; set; }

    /// <summary>
    /// PCEFT (Primary Key).
    /// </summary>
    public decimal PCEFT { get; set; }
}
