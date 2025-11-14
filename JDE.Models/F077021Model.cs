using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F077021 - .
/// </summary>
public class F077021Model
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
    /// Y$PDBA (Primary Key).
    /// </summary>
    [Column("Y$PDBA")]
    public decimal Y_PDBA { get; set; }

    /// <summary>
    /// Y$TAXX.
    /// </summary>
    [Column("Y$TAXX")]
    public string? Y_TAXX { get; set; }

    /// <summary>
    /// Y$DISO.
    /// </summary>
    [Column("Y$DISO")]
    public string? Y_DISO { get; set; }

    /// <summary>
    /// Y$PAYG.
    /// </summary>
    [Column("Y$PAYG")]
    public string? Y_PAYG { get; set; }

    /// <summary>
    /// Y$PAYN.
    /// </summary>
    [Column("Y$PAYN")]
    public string? Y_PAYN { get; set; }

    /// <summary>
    /// Y$NP.
    /// </summary>
    [Column("Y$NP")]
    public decimal? Y_NP { get; set; }

    /// <summary>
    /// Y$AD.
    /// </summary>
    [Column("Y$AD")]
    public decimal? Y_AD { get; set; }

    /// <summary>
    /// Y$UFLG.
    /// </summary>
    [Column("Y$UFLG")]
    public string? Y_UFLG { get; set; }
}
