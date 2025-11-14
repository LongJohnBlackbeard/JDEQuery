using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F81A01 - .
/// </summary>
public class F81A01Model
{
    /// <summary>
    /// M1PID (Primary Key).
    /// </summary>
    public string M1PID { get; set; }

    /// <summary>
    /// M1OPT# (Primary Key).
    /// </summary>
    [Column("M1OPT#")]
    public decimal M1OPT_ { get; set; }

    /// <summary>
    /// M1SQN.
    /// </summary>
    public decimal? M1SQN { get; set; }

    /// <summary>
    /// M1JD.
    /// </summary>
    public string? M1JD { get; set; }

    /// <summary>
    /// M1FPID (Primary Key).
    /// </summary>
    public string M1FPID { get; set; }

    /// <summary>
    /// M1OBNM.
    /// </summary>
    public string? M1OBNM { get; set; }

    /// <summary>
    /// M1LITN (Primary Key).
    /// </summary>
    public decimal M1LITN { get; set; }

    /// <summary>
    /// M1BSQN (Primary Key).
    /// </summary>
    public decimal M1BSQN { get; set; }

    /// <summary>
    /// M1BCNT.
    /// </summary>
    public decimal? M1BCNT { get; set; }

    /// <summary>
    /// M1LTBN.
    /// </summary>
    public string? M1LTBN { get; set; }

    /// <summary>
    /// M1TXT1.
    /// </summary>
    public string? M1TXT1 { get; set; }

    /// <summary>
    /// M1LPOD.
    /// </summary>
    public string? M1LPOD { get; set; }

    /// <summary>
    /// M1LDSN.
    /// </summary>
    public string? M1LDSN { get; set; }

    /// <summary>
    /// M1DS01.
    /// </summary>
    public string? M1DS01 { get; set; }

    /// <summary>
    /// M1OWTP.
    /// </summary>
    public string? M1OWTP { get; set; }

    /// <summary>
    /// M1DTAI.
    /// </summary>
    public string? M1DTAI { get; set; }

    /// <summary>
    /// M1LUS.
    /// </summary>
    public string? M1LUS { get; set; }

    /// <summary>
    /// M1FPD.
    /// </summary>
    public string? M1FPD { get; set; }

    /// <summary>
    /// M1UPMJ.
    /// </summary>
    public decimal? M1UPMJ { get; set; }

    /// <summary>
    /// M1JOBN.
    /// </summary>
    public string? M1JOBN { get; set; }

    /// <summary>
    /// M1UPMT.
    /// </summary>
    public decimal? M1UPMT { get; set; }

    /// <summary>
    /// M1GSTS.
    /// </summary>
    public decimal? M1GSTS { get; set; }
}
