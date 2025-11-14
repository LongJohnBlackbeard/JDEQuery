using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F081163 - .
/// </summary>
public class F081163Model
{
    /// <summary>
    /// ASAN8 (Primary Key).
    /// </summary>
    public decimal ASAN8 { get; set; }

    /// <summary>
    /// ASACAD (Primary Key).
    /// </summary>
    public string ASACAD { get; set; }

    /// <summary>
    /// ASACA# (Primary Key).
    /// </summary>
    [Column("ASACA#")]
    public decimal ASACA_ { get; set; }

    /// <summary>
    /// ASHMCO (Primary Key).
    /// </summary>
    public string ASHMCO { get; set; }

    /// <summary>
    /// ASACTH.
    /// </summary>
    public decimal? ASACTH { get; set; }

    /// <summary>
    /// ASSPADUSE1.
    /// </summary>
    public decimal? ASSPADUSE1 { get; set; }

    /// <summary>
    /// ASSPADUSE2.
    /// </summary>
    public decimal? ASSPADUSE2 { get; set; }

    /// <summary>
    /// ASSPASUSE1.
    /// </summary>
    public string? ASSPASUSE1 { get; set; }

    /// <summary>
    /// ASSPASUSE2.
    /// </summary>
    public string? ASSPASUSE2 { get; set; }

    /// <summary>
    /// ASSPANUSE1.
    /// </summary>
    public decimal? ASSPANUSE1 { get; set; }

    /// <summary>
    /// ASSPANUSE2.
    /// </summary>
    public decimal? ASSPANUSE2 { get; set; }

    /// <summary>
    /// ASSPACUSE1.
    /// </summary>
    public string? ASSPACUSE1 { get; set; }

    /// <summary>
    /// ASSPACUSE2.
    /// </summary>
    public string? ASSPACUSE2 { get; set; }

    /// <summary>
    /// ASUSER.
    /// </summary>
    public string? ASUSER { get; set; }

    /// <summary>
    /// ASPID.
    /// </summary>
    public string? ASPID { get; set; }

    /// <summary>
    /// ASJOBN.
    /// </summary>
    public string? ASJOBN { get; set; }

    /// <summary>
    /// ASUPMJ.
    /// </summary>
    public decimal? ASUPMJ { get; set; }

    /// <summary>
    /// ASUPMT.
    /// </summary>
    public decimal? ASUPMT { get; set; }
}
