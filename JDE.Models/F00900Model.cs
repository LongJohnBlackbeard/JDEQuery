using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F00900 - .
/// </summary>
public class F00900Model
{
    /// <summary>
    /// IRCO (Primary Key).
    /// </summary>
    public string IRCO { get; set; }

    /// <summary>
    /// IRIITY (Primary Key).
    /// </summary>
    public string IRIITY { get; set; }

    /// <summary>
    /// IRAN8 (Primary Key).
    /// </summary>
    public decimal IRAN8 { get; set; }

    /// <summary>
    /// IRTAX.
    /// </summary>
    public string? IRTAX { get; set; }

    /// <summary>
    /// IRDI# (Primary Key).
    /// </summary>
    [Column("IRDI#")]
    public decimal IRDI_ { get; set; }

    /// <summary>
    /// IRDIY (Primary Key).
    /// </summary>
    public decimal IRDIY { get; set; }

    /// <summary>
    /// IRIID1.
    /// </summary>
    public decimal? IRIID1 { get; set; }

    /// <summary>
    /// IRATXA.
    /// </summary>
    public decimal? IRATXA { get; set; }

    /// <summary>
    /// IRSTAM.
    /// </summary>
    public decimal? IRSTAM { get; set; }

    /// <summary>
    /// IRATXN.
    /// </summary>
    public decimal? IRATXN { get; set; }

    /// <summary>
    /// IRIID2.
    /// </summary>
    public decimal? IRIID2 { get; set; }

    /// <summary>
    /// IRIINA.
    /// </summary>
    public decimal? IRIINA { get; set; }

    /// <summary>
    /// IRIIX8.
    /// </summary>
    public decimal? IRIIX8 { get; set; }
}
