using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F1205P - .
/// </summary>
public class F1205PModel
{
    /// <summary>
    /// FTNUMB (Primary Key).
    /// </summary>
    public decimal FTNUMB { get; set; }

    /// <summary>
    /// FTALPH.
    /// </summary>
    public string? FTALPH { get; set; }

    /// <summary>
    /// FTEXPL.
    /// </summary>
    public string? FTEXPL { get; set; }

    /// <summary>
    /// FTDTE.
    /// </summary>
    public decimal? FTDTE { get; set; }

    /// <summary>
    /// FTDTE#.
    /// </summary>
    [Column("FTDTE#")]
    public decimal? FTDTE_ { get; set; }

    /// <summary>
    /// FTTDAY (Primary Key).
    /// </summary>
    public decimal FTTDAY { get; set; }

    /// <summary>
    /// FTTDT.
    /// </summary>
    public decimal? FTTDT { get; set; }

    /// <summary>
    /// FTMOH.
    /// </summary>
    public decimal? FTMOH { get; set; }

    /// <summary>
    /// FTEMT.
    /// </summary>
    public string? FTEMT { get; set; }

    /// <summary>
    /// FTITST.
    /// </summary>
    public string? FTITST { get; set; }

    /// <summary>
    /// FTUSER.
    /// </summary>
    public string? FTUSER { get; set; }

    /// <summary>
    /// FTLCT.
    /// </summary>
    public decimal? FTLCT { get; set; }

    /// <summary>
    /// FTPID.
    /// </summary>
    public string? FTPID { get; set; }

    /// <summary>
    /// FTDSVJ.
    /// </summary>
    public decimal? FTDSVJ { get; set; }

    /// <summary>
    /// FTASPU.
    /// </summary>
    public decimal? FTASPU { get; set; }

    /// <summary>
    /// FTASSU.
    /// </summary>
    public decimal? FTASSU { get; set; }

    /// <summary>
    /// FTASD.
    /// </summary>
    public decimal? FTASD { get; set; }

    /// <summary>
    /// FTAALM.
    /// </summary>
    public decimal? FTAALM { get; set; }

    /// <summary>
    /// FTAALP.
    /// </summary>
    public decimal? FTAALP { get; set; }

    /// <summary>
    /// FTAALS.
    /// </summary>
    public decimal? FTAALS { get; set; }

    /// <summary>
    /// FTAALD.
    /// </summary>
    public decimal? FTAALD { get; set; }

    /// <summary>
    /// FTCMM.
    /// </summary>
    public string? FTCMM { get; set; }

    /// <summary>
    /// FTCMPU.
    /// </summary>
    public string? FTCMPU { get; set; }

    /// <summary>
    /// FTCMSU.
    /// </summary>
    public string? FTCMSU { get; set; }

    /// <summary>
    /// FTCMDY.
    /// </summary>
    public string? FTCMDY { get; set; }

    /// <summary>
    /// FTDTEJ (Primary Key).
    /// </summary>
    public decimal FTDTEJ { get; set; }

    /// <summary>
    /// FTJOBN.
    /// </summary>
    public string? FTJOBN { get; set; }

    /// <summary>
    /// FTUPMT.
    /// </summary>
    public decimal? FTUPMT { get; set; }
}
