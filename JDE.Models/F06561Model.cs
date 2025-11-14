using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F06561 - .
/// </summary>
public class F06561Model
{
    /// <summary>
    /// Y9FOA# (Primary Key).
    /// </summary>
    [Column("Y9FOA#")]
    public string Y9FOA_ { get; set; }

    /// <summary>
    /// Y9DOCM (Primary Key).
    /// </summary>
    public decimal Y9DOCM { get; set; }

    /// <summary>
    /// Y9NPAY.
    /// </summary>
    public decimal? Y9NPAY { get; set; }

    /// <summary>
    /// Y9CKD.
    /// </summary>
    public decimal? Y9CKD { get; set; }

    /// <summary>
    /// Y9ALPH.
    /// </summary>
    public string? Y9ALPH { get; set; }

    /// <summary>
    /// Y9ICC (Primary Key).
    /// </summary>
    public string Y9ICC { get; set; }
}
