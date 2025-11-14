using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F07100 - .
/// </summary>
public class F07100Model
{
    /// <summary>
    /// F7CO (Primary Key).
    /// </summary>
    public string F7CO { get; set; }

    /// <summary>
    /// F7SSN (Primary Key).
    /// </summary>
    public string F7SSN { get; set; }

    /// <summary>
    /// F7AN8.
    /// </summary>
    public decimal? F7AN8 { get; set; }

    /// <summary>
    /// F7JBCD (Primary Key).
    /// </summary>
    public string F7JBCD { get; set; }

    /// <summary>
    /// F7JBST (Primary Key).
    /// </summary>
    public string F7JBST { get; set; }

    /// <summary>
    /// F7MCU.
    /// </summary>
    public string? F7MCU { get; set; }

    /// <summary>
    /// F7IND$ (Primary Key).
    /// </summary>
    [Column("F7IND$")]
    public string F7IND_ { get; set; }

    /// <summary>
    /// F7RGN$ (Primary Key).
    /// </summary>
    [Column("F7RGN$")]
    public string F7RGN_ { get; set; }

    /// <summary>
    /// F7UN (Primary Key).
    /// </summary>
    public string F7UN { get; set; }

    /// <summary>
    /// F7WKS.
    /// </summary>
    public decimal? F7WKS { get; set; }

    /// <summary>
    /// F7HRWR.
    /// </summary>
    public decimal? F7HRWR { get; set; }

    /// <summary>
    /// F7HRWT.
    /// </summary>
    public decimal? F7HRWT { get; set; }

    /// <summary>
    /// F7HRWO.
    /// </summary>
    public decimal? F7HRWO { get; set; }

    /// <summary>
    /// F7GPA.
    /// </summary>
    public decimal? F7GPA { get; set; }

    /// <summary>
    /// F7VCGP.
    /// </summary>
    public decimal? F7VCGP { get; set; }

    /// <summary>
    /// F7UDC$.
    /// </summary>
    [Column("F7UDC$")]
    public decimal? F7UDC_ { get; set; }

    /// <summary>
    /// F7CPPE.
    /// </summary>
    public decimal? F7CPPE { get; set; }
}
