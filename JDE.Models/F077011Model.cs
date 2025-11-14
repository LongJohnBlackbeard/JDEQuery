using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F077011 - .
/// </summary>
public class F077011Model
{
    /// <summary>
    /// Y$DTEY (Primary Key).
    /// </summary>
    [Column("Y$DTEY")]
    public decimal Y_DTEY { get; set; }

    /// <summary>
    /// Y$CO (Primary Key).
    /// </summary>
    [Column("Y$CO")]
    public string Y_CO { get; set; }

    /// <summary>
    /// Y$THTY (Primary Key).
    /// </summary>
    [Column("Y$THTY")]
    public string Y_THTY { get; set; }

    /// <summary>
    /// Y$EKEY (Primary Key).
    /// </summary>
    [Column("Y$EKEY")]
    public string Y_EKEY { get; set; }

    /// <summary>
    /// Y$AN8 (Primary Key).
    /// </summary>
    [Column("Y$AN8")]
    public decimal Y_AN8 { get; set; }

    /// <summary>
    /// Y$SSN.
    /// </summary>
    [Column("Y$SSN")]
    public string? Y_SSN { get; set; }

    /// <summary>
    /// Y$ALPH.
    /// </summary>
    [Column("Y$ALPH")]
    public string? Y_ALPH { get; set; }

    /// <summary>
    /// Y$TARA (Primary Key).
    /// </summary>
    [Column("Y$TARA")]
    public string Y_TARA { get; set; }

    /// <summary>
    /// Y$PTAX (Primary Key).
    /// </summary>
    [Column("Y$PTAX")]
    public string Y_PTAX { get; set; }

    /// <summary>
    /// Y$TAXX (Primary Key).
    /// </summary>
    [Column("Y$TAXX")]
    public string Y_TAXX { get; set; }

    /// <summary>
    /// Y$WAG.
    /// </summary>
    [Column("Y$WAG")]
    public decimal? Y_WAG { get; set; }

    /// <summary>
    /// Y$UFLG.
    /// </summary>
    [Column("Y$UFLG")]
    public string? Y_UFLG { get; set; }
}
