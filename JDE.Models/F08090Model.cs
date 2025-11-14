using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08090 - .
/// </summary>
public class F08090Model
{
    /// <summary>
    /// JXRCOD (Primary Key).
    /// </summary>
    public string JXRCOD { get; set; }

    /// <summary>
    /// JXTYRC (Primary Key).
    /// </summary>
    public string JXTYRC { get; set; }

    /// <summary>
    /// JXDSPM.
    /// </summary>
    public string? JXDSPM { get; set; }

    /// <summary>
    /// JXSEQ#.
    /// </summary>
    [Column("JXSEQ#")]
    public decimal? JXSEQ_ { get; set; }

    /// <summary>
    /// JXDL01.
    /// </summary>
    public string? JXDL01 { get; set; }

    /// <summary>
    /// JXSY.
    /// </summary>
    public string? JXSY { get; set; }

    /// <summary>
    /// JXRT.
    /// </summary>
    public string? JXRT { get; set; }

    /// <summary>
    /// JXGDC1.
    /// </summary>
    public string? JXGDC1 { get; set; }

    /// <summary>
    /// JXGDC2.
    /// </summary>
    public string? JXGDC2 { get; set; }

    /// <summary>
    /// JXGDC3.
    /// </summary>
    public string? JXGDC3 { get; set; }

    /// <summary>
    /// JXGDC4.
    /// </summary>
    public string? JXGDC4 { get; set; }

    /// <summary>
    /// JXGDC5.
    /// </summary>
    public string? JXGDC5 { get; set; }

    /// <summary>
    /// JXGDC6.
    /// </summary>
    public string? JXGDC6 { get; set; }

    /// <summary>
    /// JXGDC7.
    /// </summary>
    public string? JXGDC7 { get; set; }

    /// <summary>
    /// JXSY1.
    /// </summary>
    public string? JXSY1 { get; set; }

    /// <summary>
    /// JXRT1.
    /// </summary>
    public string? JXRT1 { get; set; }

    /// <summary>
    /// JXSY2.
    /// </summary>
    public string? JXSY2 { get; set; }

    /// <summary>
    /// JXRT2.
    /// </summary>
    public string? JXRT2 { get; set; }

    /// <summary>
    /// JXTYRG.
    /// </summary>
    public string? JXTYRG { get; set; }

    /// <summary>
    /// JXDATD.
    /// </summary>
    public string? JXDATD { get; set; }

    /// <summary>
    /// JXAT1.
    /// </summary>
    public string? JXAT1 { get; set; }

    /// <summary>
    /// JXCLS.
    /// </summary>
    public string? JXCLS { get; set; }

    /// <summary>
    /// JXPGM.
    /// </summary>
    public string? JXPGM { get; set; }

    /// <summary>
    /// JXVERS.
    /// </summary>
    public string? JXVERS { get; set; }

    /// <summary>
    /// JXPGMG.
    /// </summary>
    public string? JXPGMG { get; set; }

    /// <summary>
    /// JXFILE.
    /// </summary>
    public string? JXFILE { get; set; }

    /// <summary>
    /// JXDSS5.
    /// </summary>
    public decimal? JXDSS5 { get; set; }

    /// <summary>
    /// JXCF.
    /// </summary>
    public string? JXCF { get; set; }

    /// <summary>
    /// JXUSER.
    /// </summary>
    public string? JXUSER { get; set; }

    /// <summary>
    /// JXJOBN.
    /// </summary>
    public string? JXJOBN { get; set; }

    /// <summary>
    /// JXUPMJ.
    /// </summary>
    public decimal? JXUPMJ { get; set; }
}
