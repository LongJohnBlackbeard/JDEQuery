using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F3404 - .
/// </summary>
public class F3404Model
{
    /// <summary>
    /// PMF$RP.
    /// </summary>
    [Column("PMF$RP")]
    public decimal? PMF_RP { get; set; }

    /// <summary>
    /// PMMMCU (Primary Key).
    /// </summary>
    public string PMMMCU { get; set; }

    /// <summary>
    /// PMITM (Primary Key).
    /// </summary>
    public decimal PMITM { get; set; }

    /// <summary>
    /// PMCMCU (Primary Key).
    /// </summary>
    public string PMCMCU { get; set; }

    /// <summary>
    /// PMEFFF.
    /// </summary>
    public decimal? PMEFFF { get; set; }

    /// <summary>
    /// PMEFFT (Primary Key).
    /// </summary>
    public decimal PMEFFT { get; set; }

    /// <summary>
    /// PMFTRP.
    /// </summary>
    public decimal? PMFTRP { get; set; }

    /// <summary>
    /// PMUSER.
    /// </summary>
    public string? PMUSER { get; set; }

    /// <summary>
    /// PMPID.
    /// </summary>
    public string? PMPID { get; set; }

    /// <summary>
    /// PMJOBN.
    /// </summary>
    public string? PMJOBN { get; set; }

    /// <summary>
    /// PMUPMJ.
    /// </summary>
    public decimal? PMUPMJ { get; set; }

    /// <summary>
    /// PMTDAY.
    /// </summary>
    public decimal? PMTDAY { get; set; }

    /// <summary>
    /// PMKIT (Primary Key).
    /// </summary>
    public decimal PMKIT { get; set; }
}
