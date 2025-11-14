using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F30UI012 - .
/// </summary>
public class F30UI012Model
{
    /// <summary>
    /// PCUSER (Primary Key).
    /// </summary>
    public string PCUSER { get; set; }

    /// <summary>
    /// PCPEID (Primary Key).
    /// </summary>
    public decimal PCPEID { get; set; }

    /// <summary>
    /// PCJOBS (Primary Key).
    /// </summary>
    public decimal PCJOBS { get; set; }

    /// <summary>
    /// PCCMCU (Primary Key).
    /// </summary>
    public string PCCMCU { get; set; }

    /// <summary>
    /// PCITM (Primary Key).
    /// </summary>
    public decimal PCITM { get; set; }

    /// <summary>
    /// PCMMCU (Primary Key).
    /// </summary>
    public string PCMMCU { get; set; }

    /// <summary>
    /// PCKIT (Primary Key).
    /// </summary>
    public decimal PCKIT { get; set; }

    /// <summary>
    /// PCOPSQ (Primary Key).
    /// </summary>
    public decimal PCOPSQ { get; set; }

    /// <summary>
    /// PCCPNB (Primary Key).
    /// </summary>
    public decimal PCCPNB { get; set; }

    /// <summary>
    /// PCBQTY (Primary Key).
    /// </summary>
    public decimal PCBQTY { get; set; }

    /// <summary>
    /// PCQNTY.
    /// </summary>
    public decimal? PCQNTY { get; set; }

    /// <summary>
    /// PCUOM.
    /// </summary>
    public string? PCUOM { get; set; }

    /// <summary>
    /// PCUOM1.
    /// </summary>
    public string? PCUOM1 { get; set; }

    /// <summary>
    /// PCFORQ.
    /// </summary>
    public string? PCFORQ { get; set; }

    /// <summary>
    /// PCSCRP.
    /// </summary>
    public decimal? PCSCRP { get; set; }

    /// <summary>
    /// PCSTPP.
    /// </summary>
    public decimal? PCSTPP { get; set; }

    /// <summary>
    /// PCKITL.
    /// </summary>
    public string? PCKITL { get; set; }

    /// <summary>
    /// PCKITA.
    /// </summary>
    public string? PCKITA { get; set; }

    /// <summary>
    /// PCF$RP.
    /// </summary>
    [Column("PCF$RP")]
    public decimal? PCF_RP { get; set; }

    /// <summary>
    /// PCMCU.
    /// </summary>
    public string? PCMCU { get; set; }

    /// <summary>
    /// PCCWC.
    /// </summary>
    public string? PCCWC { get; set; }

    /// <summary>
    /// PCQNTY9.
    /// </summary>
    public decimal? PCQNTY9 { get; set; }
}
