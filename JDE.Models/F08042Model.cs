using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08042 - .
/// </summary>
public class F08042Model
{
    /// <summary>
    /// JWFILE (Primary Key).
    /// </summary>
    public string JWFILE { get; set; }

    /// <summary>
    /// JWAN8 (Primary Key).
    /// </summary>
    public decimal JWAN8 { get; set; }

    /// <summary>
    /// JWDTAI (Primary Key).
    /// </summary>
    public string JWDTAI { get; set; }

    /// <summary>
    /// JWHSTD.
    /// </summary>
    public string? JWHSTD { get; set; }

    /// <summary>
    /// JWUSER.
    /// </summary>
    public string? JWUSER { get; set; }

    /// <summary>
    /// JWEFTO (Primary Key).
    /// </summary>
    public decimal JWEFTO { get; set; }

    /// <summary>
    /// JWUPMJ.
    /// </summary>
    public decimal? JWUPMJ { get; set; }

    /// <summary>
    /// JWPID.
    /// </summary>
    public string? JWPID { get; set; }

    /// <summary>
    /// JWTRS.
    /// </summary>
    public string? JWTRS { get; set; }

    /// <summary>
    /// JWSEQ# (Primary Key).
    /// </summary>
    [Column("JWSEQ#")]
    public decimal JWSEQ_ { get; set; }

    /// <summary>
    /// JWJOBN.
    /// </summary>
    public string? JWJOBN { get; set; }

    /// <summary>
    /// JWHSTN.
    /// </summary>
    public decimal? JWHSTN { get; set; }
}
