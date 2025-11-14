using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08330WF - .
/// </summary>
public class F08330WFModel
{
    /// <summary>
    /// BRAN8 (Primary Key).
    /// </summary>
    public decimal BRAN8 { get; set; }

    /// <summary>
    /// BRSEQ# (Primary Key).
    /// </summary>
    [Column("BRSEQ#")]
    public decimal BRSEQ_ { get; set; }

    /// <summary>
    /// BRSBGR (Primary Key).
    /// </summary>
    public string BRSBGR { get; set; }

    /// <summary>
    /// BRDL01.
    /// </summary>
    public string? BRDL01 { get; set; }

    /// <summary>
    /// BRPLAN (Primary Key).
    /// </summary>
    public string BRPLAN { get; set; }

    /// <summary>
    /// BRAOPT (Primary Key).
    /// </summary>
    public string BRAOPT { get; set; }

    /// <summary>
    /// BRDS50.
    /// </summary>
    public string? BRDS50 { get; set; }

    /// <summary>
    /// BREFT (Primary Key).
    /// </summary>
    public decimal BREFT { get; set; }

    /// <summary>
    /// BRPCOS.
    /// </summary>
    public decimal? BRPCOS { get; set; }

    /// <summary>
    /// BRPCRE.
    /// </summary>
    public decimal? BRPCRE { get; set; }

    /// <summary>
    /// BREEFC.
    /// </summary>
    public decimal? BREEFC { get; set; }

    /// <summary>
    /// BRDBEN.
    /// </summary>
    public string? BRDBEN { get; set; }

    /// <summary>
    /// BRPCPF.
    /// </summary>
    public decimal? BRPCPF { get; set; }

    /// <summary>
    /// BRCATY.
    /// </summary>
    public string? BRCATY { get; set; }

    /// <summary>
    /// BRPID.
    /// </summary>
    public string? BRPID { get; set; }

    /// <summary>
    /// BRUPMJ.
    /// </summary>
    public decimal? BRUPMJ { get; set; }

    /// <summary>
    /// BRUPMT.
    /// </summary>
    public decimal? BRUPMT { get; set; }

    /// <summary>
    /// BRUSER.
    /// </summary>
    public string? BRUSER { get; set; }

    /// <summary>
    /// BRJOBN.
    /// </summary>
    public string? BRJOBN { get; set; }
}
