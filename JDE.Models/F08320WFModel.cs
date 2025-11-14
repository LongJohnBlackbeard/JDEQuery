using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08320WF - .
/// </summary>
public class F08320WFModel
{
    /// <summary>
    /// BVEVET (Primary Key).
    /// </summary>
    public decimal BVEVET { get; set; }

    /// <summary>
    /// BVAN8 (Primary Key).
    /// </summary>
    public decimal BVAN8 { get; set; }

    /// <summary>
    /// BVSBGR (Primary Key).
    /// </summary>
    public string BVSBGR { get; set; }

    /// <summary>
    /// BVDL01.
    /// </summary>
    public string? BVDL01 { get; set; }

    /// <summary>
    /// BVSEQ# (Primary Key).
    /// </summary>
    [Column("BVSEQ#")]
    public decimal BVSEQ_ { get; set; }

    /// <summary>
    /// BVPLAN (Primary Key).
    /// </summary>
    public string BVPLAN { get; set; }

    /// <summary>
    /// BVAOPT (Primary Key).
    /// </summary>
    public string BVAOPT { get; set; }

    /// <summary>
    /// BVDS50.
    /// </summary>
    public string? BVDS50 { get; set; }

    /// <summary>
    /// BVDBEN.
    /// </summary>
    public string? BVDBEN { get; set; }

    /// <summary>
    /// BVPCPF.
    /// </summary>
    public decimal? BVPCPF { get; set; }

    /// <summary>
    /// BVEAOR.
    /// </summary>
    public string? BVEAOR { get; set; }

    /// <summary>
    /// BVFDBA.
    /// </summary>
    public decimal? BVFDBA { get; set; }

    /// <summary>
    /// BVSDBA.
    /// </summary>
    public decimal? BVSDBA { get; set; }

    /// <summary>
    /// BVPDDP.
    /// </summary>
    public decimal? BVPDDP { get; set; }

    /// <summary>
    /// BVPDCP.
    /// </summary>
    public decimal? BVPDCP { get; set; }

    /// <summary>
    /// BVPCOS.
    /// </summary>
    public decimal? BVPCOS { get; set; }

    /// <summary>
    /// BVPCRE.
    /// </summary>
    public decimal? BVPCRE { get; set; }

    /// <summary>
    /// BVDRTM.
    /// </summary>
    public decimal? BVDRTM { get; set; }

    /// <summary>
    /// BVBRTM.
    /// </summary>
    public decimal? BVBRTM { get; set; }

    /// <summary>
    /// BVEFT.
    /// </summary>
    public decimal? BVEFT { get; set; }

    /// <summary>
    /// BVMANP.
    /// </summary>
    public string? BVMANP { get; set; }

    /// <summary>
    /// BVXDFP.
    /// </summary>
    public string? BVXDFP { get; set; }

    /// <summary>
    /// BVEFTE.
    /// </summary>
    public decimal? BVEFTE { get; set; }

    /// <summary>
    /// BVEECD.
    /// </summary>
    public string? BVEECD { get; set; }

    /// <summary>
    /// BVSL01.
    /// </summary>
    public string? BVSL01 { get; set; }

    /// <summary>
    /// BVPID.
    /// </summary>
    public string? BVPID { get; set; }

    /// <summary>
    /// BVUPMJ.
    /// </summary>
    public decimal? BVUPMJ { get; set; }

    /// <summary>
    /// BVUPMT.
    /// </summary>
    public decimal? BVUPMT { get; set; }

    /// <summary>
    /// BVUSER.
    /// </summary>
    public string? BVUSER { get; set; }

    /// <summary>
    /// BVJOBN.
    /// </summary>
    public string? BVJOBN { get; set; }

    /// <summary>
    /// BVCATY.
    /// </summary>
    public string? BVCATY { get; set; }

    /// <summary>
    /// BVEEFC.
    /// </summary>
    public decimal? BVEEFC { get; set; }
}
