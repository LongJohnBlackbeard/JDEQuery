using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F051373 - .
/// </summary>
public class F051373Model
{
    /// <summary>
    /// ADCHGF.
    /// </summary>
    public string? ADCHGF { get; set; }

    /// <summary>
    /// ADPAYBN (Primary Key).
    /// </summary>
    public decimal ADPAYBN { get; set; }

    /// <summary>
    /// ADAN8 (Primary Key).
    /// </summary>
    public decimal ADAN8 { get; set; }

    /// <summary>
    /// ADEST.
    /// </summary>
    public string? ADEST { get; set; }

    /// <summary>
    /// ADHMCU.
    /// </summary>
    public string? ADHMCU { get; set; }

    /// <summary>
    /// ADPFRQ.
    /// </summary>
    public string? ADPFRQ { get; set; }

    /// <summary>
    /// ADSEQ (Primary Key).
    /// </summary>
    public decimal ADSEQ { get; set; }

    /// <summary>
    /// ADPSDT.
    /// </summary>
    public decimal? ADPSDT { get; set; }

    /// <summary>
    /// ADPTDT.
    /// </summary>
    public decimal? ADPTDT { get; set; }

    /// <summary>
    /// ADFOA# (Primary Key).
    /// </summary>
    [Column("ADFOA#")]
    public string ADFOA_ { get; set; }

    /// <summary>
    /// ADIFO#.
    /// </summary>
    [Column("ADIFO#")]
    public string? ADIFO_ { get; set; }

    /// <summary>
    /// ADBDM (Primary Key).
    /// </summary>
    public string ADBDM { get; set; }

    /// <summary>
    /// ADTCOD.
    /// </summary>
    public string? ADTCOD { get; set; }

    /// <summary>
    /// ADGPA.
    /// </summary>
    public decimal? ADGPA { get; set; }

    /// <summary>
    /// ADFPCD.
    /// </summary>
    public string? ADFPCD { get; set; }
}
