using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08330 - .
/// </summary>
public class F08330Model
{
    /// <summary>
    /// BGAN8 (Primary Key).
    /// </summary>
    public decimal BGAN8 { get; set; }

    /// <summary>
    /// BGPLAN (Primary Key).
    /// </summary>
    public string BGPLAN { get; set; }

    /// <summary>
    /// BGEFT (Primary Key).
    /// </summary>
    public decimal BGEFT { get; set; }

    /// <summary>
    /// BGEFTE.
    /// </summary>
    public decimal? BGEFTE { get; set; }

    /// <summary>
    /// BGXDFS.
    /// </summary>
    public string? BGXDFS { get; set; }

    /// <summary>
    /// BGXEST.
    /// </summary>
    public string? BGXEST { get; set; }

    /// <summary>
    /// BGDELG.
    /// </summary>
    public decimal? BGDELG { get; set; }

    /// <summary>
    /// BGDPTC.
    /// </summary>
    public decimal? BGDPTC { get; set; }

    /// <summary>
    /// BGDUSR.
    /// </summary>
    public decimal? BGDUSR { get; set; }

    /// <summary>
    /// BGAOPT (Primary Key).
    /// </summary>
    public string BGAOPT { get; set; }

    /// <summary>
    /// BGFCTR.
    /// </summary>
    public decimal? BGFCTR { get; set; }

    /// <summary>
    /// BGDTDB.
    /// </summary>
    public decimal? BGDTDB { get; set; }

    /// <summary>
    /// BGDTDE.
    /// </summary>
    public decimal? BGDTDE { get; set; }

    /// <summary>
    /// BGSEQ#.
    /// </summary>
    [Column("BGSEQ#")]
    public decimal? BGSEQ_ { get; set; }

    /// <summary>
    /// BGUSER.
    /// </summary>
    public string? BGUSER { get; set; }

    /// <summary>
    /// BGPID.
    /// </summary>
    public string? BGPID { get; set; }

    /// <summary>
    /// BGJOBN.
    /// </summary>
    public string? BGJOBN { get; set; }

    /// <summary>
    /// BGUPMJ.
    /// </summary>
    public decimal? BGUPMJ { get; set; }
}
