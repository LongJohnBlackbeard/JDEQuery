using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08372 - .
/// </summary>
public class F08372Model
{
    /// <summary>
    /// BMAN8 (Primary Key).
    /// </summary>
    public decimal BMAN8 { get; set; }

    /// <summary>
    /// BMPLAN (Primary Key).
    /// </summary>
    public string BMPLAN { get; set; }

    /// <summary>
    /// BMSEQ.
    /// </summary>
    public decimal? BMSEQ { get; set; }

    /// <summary>
    /// BMFOA#.
    /// </summary>
    [Column("BMFOA#")]
    public string? BMFOA_ { get; set; }

    /// <summary>
    /// BMIFO#.
    /// </summary>
    [Column("BMIFO#")]
    public string? BMIFO_ { get; set; }

    /// <summary>
    /// BMPSDT.
    /// </summary>
    public decimal? BMPSDT { get; set; }

    /// <summary>
    /// BMPTDT.
    /// </summary>
    public decimal? BMPTDT { get; set; }

    /// <summary>
    /// BMTCOD.
    /// </summary>
    public string? BMTCOD { get; set; }

    /// <summary>
    /// BMBDM.
    /// </summary>
    public string? BMBDM { get; set; }

    /// <summary>
    /// BMADPN.
    /// </summary>
    public string? BMADPN { get; set; }

    /// <summary>
    /// BMPREN.
    /// </summary>
    public string? BMPREN { get; set; }

    /// <summary>
    /// BMFPCD.
    /// </summary>
    public string? BMFPCD { get; set; }

    /// <summary>
    /// BMGPA.
    /// </summary>
    public decimal? BMGPA { get; set; }

    /// <summary>
    /// BMPID.
    /// </summary>
    public string? BMPID { get; set; }

    /// <summary>
    /// BMPYCB.
    /// </summary>
    public decimal? BMPYCB { get; set; }

    /// <summary>
    /// BMUSER.
    /// </summary>
    public string? BMUSER { get; set; }

    /// <summary>
    /// BMJOBN.
    /// </summary>
    public string? BMJOBN { get; set; }

    /// <summary>
    /// BMUPMJ.
    /// </summary>
    public decimal? BMUPMJ { get; set; }
}
