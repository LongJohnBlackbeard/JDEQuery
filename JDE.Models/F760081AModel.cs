using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F760081A - .
/// </summary>
public class F760081AModel
{
    /// <summary>
    /// V6DGM (Primary Key).
    /// </summary>
    public decimal V6DGM { get; set; }

    /// <summary>
    /// V6DGD (Primary Key).
    /// </summary>
    public decimal V6DGD { get; set; }

    /// <summary>
    /// V6DI# (Primary Key).
    /// </summary>
    [Column("V6DI#")]
    public decimal V6DI_ { get; set; }

    /// <summary>
    /// V6DGY (Primary Key).
    /// </summary>
    public decimal V6DGY { get; set; }

    /// <summary>
    /// V6ALGC (Primary Key).
    /// </summary>
    public string V6ALGC { get; set; }

    /// <summary>
    /// V6ADCT (Primary Key).
    /// </summary>
    public string V6ADCT { get; set; }

    /// <summary>
    /// V6TAX (Primary Key).
    /// </summary>
    public string V6TAX { get; set; }

    /// <summary>
    /// V6AG.
    /// </summary>
    public decimal? V6AG { get; set; }

    /// <summary>
    /// V6RP1.
    /// </summary>
    public string? V6RP1 { get; set; }
}
