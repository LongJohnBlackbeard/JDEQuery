using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F40329 - .
/// </summary>
public class F40329Model
{
    /// <summary>
    /// DDAN8 (Primary Key).
    /// </summary>
    public decimal DDAN8 { get; set; }

    /// <summary>
    /// DDCS29 (Primary Key).
    /// </summary>
    public string DDCS29 { get; set; }

    /// <summary>
    /// DDITM (Primary Key).
    /// </summary>
    public decimal DDITM { get; set; }

    /// <summary>
    /// DDIT79 (Primary Key).
    /// </summary>
    public string DDIT79 { get; set; }

    /// <summary>
    /// DDEFTJ.
    /// </summary>
    public decimal? DDEFTJ { get; set; }

    /// <summary>
    /// DDEXDJ (Primary Key).
    /// </summary>
    public decimal DDEXDJ { get; set; }

    /// <summary>
    /// DDMNQ.
    /// </summary>
    public decimal? DDMNQ { get; set; }

    /// <summary>
    /// DDMXQ (Primary Key).
    /// </summary>
    public decimal DDMXQ { get; set; }

    /// <summary>
    /// DDUOM (Primary Key).
    /// </summary>
    public string DDUOM { get; set; }

    /// <summary>
    /// DDTXID.
    /// </summary>
    public decimal? DDTXID { get; set; }

    /// <summary>
    /// DDSTPR.
    /// </summary>
    public string? DDSTPR { get; set; }

    /// <summary>
    /// DDOSEQ (Primary Key).
    /// </summary>
    public decimal DDOSEQ { get; set; }

    /// <summary>
    /// DDMCU.
    /// </summary>
    public string? DDMCU { get; set; }

    /// <summary>
    /// DDMOT.
    /// </summary>
    public string? DDMOT { get; set; }

    /// <summary>
    /// DDDCCD.
    /// </summary>
    public string? DDDCCD { get; set; }

    /// <summary>
    /// DDAN81.
    /// </summary>
    public decimal? DDAN81 { get; set; }

    /// <summary>
    /// DDOUTQ.
    /// </summary>
    public string? DDOUTQ { get; set; }

    /// <summary>
    /// DDCPY#.
    /// </summary>
    [Column("DDCPY#")]
    public string? DDCPY_ { get; set; }

    /// <summary>
    /// DDURCD.
    /// </summary>
    public string? DDURCD { get; set; }

    /// <summary>
    /// DDURDT.
    /// </summary>
    public decimal? DDURDT { get; set; }

    /// <summary>
    /// DDURAT.
    /// </summary>
    public decimal? DDURAT { get; set; }

    /// <summary>
    /// DDURAB.
    /// </summary>
    public decimal? DDURAB { get; set; }

    /// <summary>
    /// DDURRF.
    /// </summary>
    public string? DDURRF { get; set; }

    /// <summary>
    /// DDUSER.
    /// </summary>
    public string? DDUSER { get; set; }

    /// <summary>
    /// DDPID.
    /// </summary>
    public string? DDPID { get; set; }

    /// <summary>
    /// DDJOBN.
    /// </summary>
    public string? DDJOBN { get; set; }

    /// <summary>
    /// DDUPMJ.
    /// </summary>
    public decimal? DDUPMJ { get; set; }

    /// <summary>
    /// DDTDAY.
    /// </summary>
    public decimal? DDTDAY { get; set; }
}
