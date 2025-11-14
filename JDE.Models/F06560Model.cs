using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F06560 - .
/// </summary>
public class F06560Model
{
    /// <summary>
    /// Y8FOA# (Primary Key).
    /// </summary>
    [Column("Y8FOA#")]
    public string Y8FOA_ { get; set; }

    /// <summary>
    /// Y8DOCM (Primary Key).
    /// </summary>
    public decimal Y8DOCM { get; set; }

    /// <summary>
    /// Y8NPAY.
    /// </summary>
    public decimal? Y8NPAY { get; set; }

    /// <summary>
    /// Y8CKD.
    /// </summary>
    public decimal? Y8CKD { get; set; }

    /// <summary>
    /// Y8ALPH.
    /// </summary>
    public string? Y8ALPH { get; set; }

    /// <summary>
    /// Y8ICC (Primary Key).
    /// </summary>
    public string Y8ICC { get; set; }
}
