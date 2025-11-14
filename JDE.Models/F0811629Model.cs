using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F0811629 - .
/// </summary>
public class F0811629Model
{
    /// <summary>
    /// APACAD (Primary Key).
    /// </summary>
    public string APACAD { get; set; }

    /// <summary>
    /// APACA# (Primary Key).
    /// </summary>
    [Column("APACA#")]
    public decimal APACA_ { get; set; }

    /// <summary>
    /// APVERS.
    /// </summary>
    public string? APVERS { get; set; }

    /// <summary>
    /// APALE.
    /// </summary>
    public string? APALE { get; set; }

    /// <summary>
    /// APACAM.
    /// </summary>
    public string? APACAM { get; set; }

    /// <summary>
    /// APLBSD.
    /// </summary>
    public decimal? APLBSD { get; set; }

    /// <summary>
    /// APLBED.
    /// </summary>
    public decimal? APLBED { get; set; }

    /// <summary>
    /// APADMS.
    /// </summary>
    public decimal? APADMS { get; set; }

    /// <summary>
    /// APADME.
    /// </summary>
    public decimal? APADME { get; set; }

    /// <summary>
    /// APSPSD.
    /// </summary>
    public decimal? APSPSD { get; set; }

    /// <summary>
    /// APSPED.
    /// </summary>
    public decimal? APSPED { get; set; }

    /// <summary>
    /// APACWK.
    /// </summary>
    public decimal? APACWK { get; set; }

    /// <summary>
    /// APACMO.
    /// </summary>
    public decimal? APACMO { get; set; }

    /// <summary>
    /// APDLS.
    /// </summary>
    public decimal? APDLS { get; set; }

    /// <summary>
    /// APTLS.
    /// </summary>
    public decimal? APTLS { get; set; }

    /// <summary>
    /// APACES.
    /// </summary>
    public string? APACES { get; set; }

    /// <summary>
    /// APESEDF.
    /// </summary>
    public decimal? APESEDF { get; set; }

    /// <summary>
    /// APSPADUSC1.
    /// </summary>
    public decimal? APSPADUSC1 { get; set; }

    /// <summary>
    /// APSPADUSC2.
    /// </summary>
    public decimal? APSPADUSC2 { get; set; }

    /// <summary>
    /// APSPASUSC1.
    /// </summary>
    public string? APSPASUSC1 { get; set; }

    /// <summary>
    /// APSPASUSC2.
    /// </summary>
    public string? APSPASUSC2 { get; set; }

    /// <summary>
    /// APSPANUSC1.
    /// </summary>
    public decimal? APSPANUSC1 { get; set; }

    /// <summary>
    /// APSPANUSC2.
    /// </summary>
    public decimal? APSPANUSC2 { get; set; }

    /// <summary>
    /// APSPACUSC1.
    /// </summary>
    public string? APSPACUSC1 { get; set; }

    /// <summary>
    /// APSPACUSC2.
    /// </summary>
    public string? APSPACUSC2 { get; set; }

    /// <summary>
    /// APUSER.
    /// </summary>
    public string? APUSER { get; set; }

    /// <summary>
    /// APPID.
    /// </summary>
    public string? APPID { get; set; }

    /// <summary>
    /// APJOBN.
    /// </summary>
    public string? APJOBN { get; set; }

    /// <summary>
    /// APUPMJ.
    /// </summary>
    public decimal? APUPMJ { get; set; }

    /// <summary>
    /// APUPMT.
    /// </summary>
    public decimal? APUPMT { get; set; }
}
