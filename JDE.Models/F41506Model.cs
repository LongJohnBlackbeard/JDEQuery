using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F41506 - .
/// </summary>
public class F41506Model
{
    /// <summary>
    /// PMMCU (Primary Key).
    /// </summary>
    public string PMMCU { get; set; }

    /// <summary>
    /// PMMETN (Primary Key).
    /// </summary>
    public string PMMETN { get; set; }

    /// <summary>
    /// PMMETS.
    /// </summary>
    public string? PMMETS { get; set; }

    /// <summary>
    /// PMSER#.
    /// </summary>
    [Column("PMSER#")]
    public string? PMSER_ { get; set; }

    /// <summary>
    /// PMDL01.
    /// </summary>
    public string? PMDL01 { get; set; }

    /// <summary>
    /// PMITM.
    /// </summary>
    public decimal? PMITM { get; set; }

    /// <summary>
    /// PMITML.
    /// </summary>
    public decimal? PMITML { get; set; }

    /// <summary>
    /// PMMXRD.
    /// </summary>
    public decimal? PMMXRD { get; set; }

    /// <summary>
    /// PMMTUN.
    /// </summary>
    public decimal? PMMTUN { get; set; }

    /// <summary>
    /// PMBUM1.
    /// </summary>
    public string? PMBUM1 { get; set; }

    /// <summary>
    /// PMTMCP.
    /// </summary>
    public string? PMTMCP { get; set; }

    /// <summary>
    /// PMPCSI.
    /// </summary>
    public string? PMPCSI { get; set; }

    /// <summary>
    /// PMTTHR.
    /// </summary>
    public decimal? PMTTHR { get; set; }

    /// <summary>
    /// PMBUM0.
    /// </summary>
    public string? PMBUM0 { get; set; }

    /// <summary>
    /// PMDLCA.
    /// </summary>
    public decimal? PMDLCA { get; set; }

    /// <summary>
    /// PMNDTE.
    /// </summary>
    public decimal? PMNDTE { get; set; }

    /// <summary>
    /// PMYN01.
    /// </summary>
    public string? PMYN01 { get; set; }

    /// <summary>
    /// PMURDT.
    /// </summary>
    public decimal? PMURDT { get; set; }

    /// <summary>
    /// PMURCD.
    /// </summary>
    public string? PMURCD { get; set; }

    /// <summary>
    /// PMURAT.
    /// </summary>
    public decimal? PMURAT { get; set; }

    /// <summary>
    /// PMURAB.
    /// </summary>
    public decimal? PMURAB { get; set; }

    /// <summary>
    /// PMURRF.
    /// </summary>
    public string? PMURRF { get; set; }

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
}
