using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08290 - .
/// </summary>
public class F08290Model
{
    /// <summary>
    /// HGSALY (Primary Key).
    /// </summary>
    public string HGSALY { get; set; }

    /// <summary>
    /// HGSLOC (Primary Key).
    /// </summary>
    public string HGSLOC { get; set; }

    /// <summary>
    /// HGEFTB (Primary Key).
    /// </summary>
    public decimal HGEFTB { get; set; }

    /// <summary>
    /// HGJE$P.
    /// </summary>
    [Column("HGJE$P")]
    public decimal? HGJE_P { get; set; }

    /// <summary>
    /// HGBAA.
    /// </summary>
    public decimal? HGBAA { get; set; }

    /// <summary>
    /// HGSMNC.
    /// </summary>
    public decimal? HGSMNC { get; set; }

    /// <summary>
    /// HGSMXC.
    /// </summary>
    public decimal? HGSMXC { get; set; }

    /// <summary>
    /// HGGDF.
    /// </summary>
    public decimal? HGGDF { get; set; }

    /// <summary>
    /// HGRNDF.
    /// </summary>
    public decimal? HGRNDF { get; set; }
}
