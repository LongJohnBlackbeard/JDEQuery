using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F81A122 - .
/// </summary>
public class F81A122Model
{
    /// <summary>
    /// M4LDFR (Primary Key).
    /// </summary>
    public string M4LDFR { get; set; }

    /// <summary>
    /// M4PID (Primary Key).
    /// </summary>
    public string M4PID { get; set; }

    /// <summary>
    /// M4VERS (Primary Key).
    /// </summary>
    public string M4VERS { get; set; }

    /// <summary>
    /// M4OPT# (Primary Key).
    /// </summary>
    [Column("M4OPT#")]
    public decimal M4OPT_ { get; set; }

    /// <summary>
    /// M4SVL.
    /// </summary>
    public string? M4SVL { get; set; }

    /// <summary>
    /// M4FPID (Primary Key).
    /// </summary>
    public string M4FPID { get; set; }

    /// <summary>
    /// M4BVER (Primary Key).
    /// </summary>
    public string M4BVER { get; set; }

    /// <summary>
    /// M4OBNM.
    /// </summary>
    public string? M4OBNM { get; set; }

    /// <summary>
    /// M4LITN.
    /// </summary>
    public decimal? M4LITN { get; set; }

    /// <summary>
    /// M4BSQN.
    /// </summary>
    public decimal? M4BSQN { get; set; }

    /// <summary>
    /// M4BCNT (Primary Key).
    /// </summary>
    public decimal M4BCNT { get; set; }

    /// <summary>
    /// M4LNGP.
    /// </summary>
    public string? M4LNGP { get; set; }

    /// <summary>
    /// M4OWTP.
    /// </summary>
    public string? M4OWTP { get; set; }

    /// <summary>
    /// M4DTAI.
    /// </summary>
    public string? M4DTAI { get; set; }

    /// <summary>
    /// M4VL01.
    /// </summary>
    public string? M4VL01 { get; set; }

    /// <summary>
    /// M4BNUM.
    /// </summary>
    public decimal? M4BNUM { get; set; }

    /// <summary>
    /// M4LUS.
    /// </summary>
    public string? M4LUS { get; set; }

    /// <summary>
    /// M4FPD.
    /// </summary>
    public string? M4FPD { get; set; }

    /// <summary>
    /// M4UPMJ.
    /// </summary>
    public decimal? M4UPMJ { get; set; }

    /// <summary>
    /// M4JOBN.
    /// </summary>
    public string? M4JOBN { get; set; }

    /// <summary>
    /// M4UPMT.
    /// </summary>
    public decimal? M4UPMT { get; set; }
}
