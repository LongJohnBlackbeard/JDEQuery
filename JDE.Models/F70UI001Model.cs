using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F70UI001 - .
/// </summary>
public class F70UI001Model
{
    /// <summary>
    /// WACO.
    /// </summary>
    public string? WACO { get; set; }

    /// <summary>
    /// WAFY.
    /// </summary>
    public decimal? WAFY { get; set; }

    /// <summary>
    /// WAPN.
    /// </summary>
    public decimal? WAPN { get; set; }

    /// <summary>
    /// WADOC.
    /// </summary>
    public decimal? WADOC { get; set; }

    /// <summary>
    /// WADCT.
    /// </summary>
    public string? WADCT { get; set; }

    /// <summary>
    /// WADGJ.
    /// </summary>
    public decimal? WADGJ { get; set; }

    /// <summary>
    /// WAEXA.
    /// </summary>
    public string? WAEXA { get; set; }

    /// <summary>
    /// WAEXR.
    /// </summary>
    public string? WAEXR { get; set; }

    /// <summary>
    /// WASBL.
    /// </summary>
    public string? WASBL { get; set; }

    /// <summary>
    /// WASBLT.
    /// </summary>
    public string? WASBLT { get; set; }

    /// <summary>
    /// WALT.
    /// </summary>
    public string? WALT { get; set; }

    /// <summary>
    /// WAPOST.
    /// </summary>
    public string? WAPOST { get; set; }

    /// <summary>
    /// WABGBL.
    /// </summary>
    public decimal? WABGBL { get; set; }

    /// <summary>
    /// WACREE.
    /// </summary>
    public decimal? WACREE { get; set; }

    /// <summary>
    /// WADEBE.
    /// </summary>
    public decimal? WADEBE { get; set; }

    /// <summary>
    /// WAOBJ.
    /// </summary>
    public string? WAOBJ { get; set; }

    /// <summary>
    /// WASUB.
    /// </summary>
    public string? WASUB { get; set; }

    /// <summary>
    /// WAR2.
    /// </summary>
    public string? WAR2 { get; set; }

    /// <summary>
    /// WARCND.
    /// </summary>
    public string? WARCND { get; set; }

    /// <summary>
    /// WARE.
    /// </summary>
    public string? WARE { get; set; }

    /// <summary>
    /// WAICU.
    /// </summary>
    public decimal? WAICU { get; set; }

    /// <summary>
    /// WAICUT.
    /// </summary>
    public string? WAICUT { get; set; }

    /// <summary>
    /// WAMCU.
    /// </summary>
    public string? WAMCU { get; set; }

    /// <summary>
    /// WAREG#.
    /// </summary>
    [Column("WAREG#")]
    public decimal? WAREG_ { get; set; }

    /// <summary>
    /// WACRCD.
    /// </summary>
    public string? WACRCD { get; set; }

    /// <summary>
    /// WANNBR (Primary Key).
    /// </summary>
    public decimal WANNBR { get; set; }

    /// <summary>
    /// WAWCCV.
    /// </summary>
    public string? WAWCCV { get; set; }

    /// <summary>
    /// WAUSER (Primary Key).
    /// </summary>
    public string WAUSER { get; set; }

    /// <summary>
    /// WAMACH (Primary Key).
    /// </summary>
    public string WAMACH { get; set; }

    /// <summary>
    /// WAJOBS (Primary Key).
    /// </summary>
    public decimal WAJOBS { get; set; }
}
