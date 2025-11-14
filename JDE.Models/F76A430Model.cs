using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F76A430 - .
/// </summary>
public class F76A430Model
{
    /// <summary>
    /// PDCO (Primary Key).
    /// </summary>
    public string PDCO { get; set; }

    /// <summary>
    /// PDAN8 (Primary Key).
    /// </summary>
    public decimal PDAN8 { get; set; }

    /// <summary>
    /// PDDG# (Primary Key).
    /// </summary>
    [Column("PDDG#")]
    public decimal PDDG_ { get; set; }

    /// <summary>
    /// PDDGY (Primary Key).
    /// </summary>
    public decimal PDDGY { get; set; }

    /// <summary>
    /// PDA007 (Primary Key).
    /// </summary>
    public string PDA007 { get; set; }

    /// <summary>
    /// PDATXA.
    /// </summary>
    public decimal? PDATXA { get; set; }

    /// <summary>
    /// PDAG1.
    /// </summary>
    public decimal? PDAG1 { get; set; }

    /// <summary>
    /// PDUSER.
    /// </summary>
    public string? PDUSER { get; set; }

    /// <summary>
    /// PDPID.
    /// </summary>
    public string? PDPID { get; set; }

    /// <summary>
    /// PDJOBN.
    /// </summary>
    public string? PDJOBN { get; set; }

    /// <summary>
    /// PDUPMJ.
    /// </summary>
    public decimal? PDUPMJ { get; set; }

    /// <summary>
    /// PDUPMT.
    /// </summary>
    public decimal? PDUPMT { get; set; }
}
