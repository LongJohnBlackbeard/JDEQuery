using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F3292 - .
/// </summary>
public class F3292Model
{
    /// <summary>
    /// KUKIT (Primary Key).
    /// </summary>
    public decimal KUKIT { get; set; }

    /// <summary>
    /// KULITM.
    /// </summary>
    public string? KULITM { get; set; }

    /// <summary>
    /// KUAITM.
    /// </summary>
    public string? KUAITM { get; set; }

    /// <summary>
    /// KUMCU (Primary Key).
    /// </summary>
    public string KUMCU { get; set; }

    /// <summary>
    /// KUATO# (Primary Key).
    /// </summary>
    [Column("KUATO#")]
    public decimal KUATO_ { get; set; }

    /// <summary>
    /// KUATOS (Primary Key).
    /// </summary>
    public decimal KUATOS { get; set; }

    /// <summary>
    /// KUEFFF.
    /// </summary>
    public decimal? KUEFFF { get; set; }

    /// <summary>
    /// KUEFFT.
    /// </summary>
    public decimal? KUEFFT { get; set; }

    /// <summary>
    /// KUPEL.
    /// </summary>
    public decimal? KUPEL { get; set; }

    /// <summary>
    /// KUPSIN.
    /// </summary>
    public decimal? KUPSIN { get; set; }

    /// <summary>
    /// KUEMCU.
    /// </summary>
    public string? KUEMCU { get; set; }

    /// <summary>
    /// KUVALR.
    /// </summary>
    public string? KUVALR { get; set; }

    /// <summary>
    /// KUATIV.
    /// </summary>
    public string? KUATIV { get; set; }

    /// <summary>
    /// KUCEL.
    /// </summary>
    public decimal? KUCEL { get; set; }

    /// <summary>
    /// KUAO.
    /// </summary>
    public string? KUAO { get; set; }

    /// <summary>
    /// KUAO5B.
    /// </summary>
    public string? KUAO5B { get; set; }

    /// <summary>
    /// KUAO5E.
    /// </summary>
    public string? KUAO5E { get; set; }

    /// <summary>
    /// KUATRQ.
    /// </summary>
    public string? KUATRQ { get; set; }

    /// <summary>
    /// KUCSMG.
    /// </summary>
    public string? KUCSMG { get; set; }

    /// <summary>
    /// KUEPGM.
    /// </summary>
    public string? KUEPGM { get; set; }

    /// <summary>
    /// KUURCD.
    /// </summary>
    public string? KUURCD { get; set; }

    /// <summary>
    /// KUURDT.
    /// </summary>
    public decimal? KUURDT { get; set; }

    /// <summary>
    /// KUURAT.
    /// </summary>
    public decimal? KUURAT { get; set; }

    /// <summary>
    /// KUURAB.
    /// </summary>
    public decimal? KUURAB { get; set; }

    /// <summary>
    /// KUURRF.
    /// </summary>
    public string? KUURRF { get; set; }

    /// <summary>
    /// KUPID.
    /// </summary>
    public string? KUPID { get; set; }

    /// <summary>
    /// KUJOBN.
    /// </summary>
    public string? KUJOBN { get; set; }

    /// <summary>
    /// KUUSER.
    /// </summary>
    public string? KUUSER { get; set; }

    /// <summary>
    /// KUUPMJ.
    /// </summary>
    public decimal? KUUPMJ { get; set; }

    /// <summary>
    /// KUTDAY.
    /// </summary>
    public decimal? KUTDAY { get; set; }

    /// <summary>
    /// KUCIALEFT.
    /// </summary>
    public string? KUCIALEFT { get; set; }

    /// <summary>
    /// KUITMRIGHT.
    /// </summary>
    public decimal? KUITMRIGHT { get; set; }

    /// <summary>
    /// KUMCURIGHT.
    /// </summary>
    public string? KUMCURIGHT { get; set; }

    /// <summary>
    /// KUCIARIGHT.
    /// </summary>
    public string? KUCIARIGHT { get; set; }
}
