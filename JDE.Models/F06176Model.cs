using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F06176 - .
/// </summary>
public class F06176Model
{
    /// <summary>
    /// YSAN8 (Primary Key).
    /// </summary>
    public decimal YSAN8 { get; set; }

    /// <summary>
    /// YSPCT#.
    /// </summary>
    [Column("YSPCT#")]
    public decimal? YSPCT_ { get; set; }

    /// <summary>
    /// YSCKCN (Primary Key).
    /// </summary>
    public decimal YSCKCN { get; set; }

    /// <summary>
    /// YSPPED (Primary Key).
    /// </summary>
    public decimal YSPPED { get; set; }

    /// <summary>
    /// YSQLWK.
    /// </summary>
    public decimal? YSQLWK { get; set; }

    /// <summary>
    /// YSGPAY.
    /// </summary>
    public decimal? YSGPAY { get; set; }

    /// <summary>
    /// YSPHRW.
    /// </summary>
    public decimal? YSPHRW { get; set; }

    /// <summary>
    /// YSIHRW.
    /// </summary>
    public decimal? YSIHRW { get; set; }

    /// <summary>
    /// YSIPAY.
    /// </summary>
    public decimal? YSIPAY { get; set; }

    /// <summary>
    /// YSIPRM.
    /// </summary>
    public decimal? YSIPRM { get; set; }

    /// <summary>
    /// YSTARA (Primary Key).
    /// </summary>
    public string YSTARA { get; set; }

    /// <summary>
    /// YSPTAX (Primary Key).
    /// </summary>
    public string YSPTAX { get; set; }

    /// <summary>
    /// YSHMCO.
    /// </summary>
    public string? YSHMCO { get; set; }

    /// <summary>
    /// YSPFRQ.
    /// </summary>
    public string? YSPFRQ { get; set; }

    /// <summary>
    /// YSYST1.
    /// </summary>
    public string? YSYST1 { get; set; }

    /// <summary>
    /// YSDTM.
    /// </summary>
    public decimal? YSDTM { get; set; }

    /// <summary>
    /// YSYST2.
    /// </summary>
    public string? YSYST2 { get; set; }

    /// <summary>
    /// YSUSER.
    /// </summary>
    public string? YSUSER { get; set; }

    /// <summary>
    /// YSPID.
    /// </summary>
    public string? YSPID { get; set; }

    /// <summary>
    /// YSUPMJ.
    /// </summary>
    public decimal? YSUPMJ { get; set; }

    /// <summary>
    /// YSDTSP.
    /// </summary>
    public decimal? YSDTSP { get; set; }

    /// <summary>
    /// YSCCPR.
    /// </summary>
    public string? YSCCPR { get; set; }

    /// <summary>
    /// YSSSN.
    /// </summary>
    public string? YSSSN { get; set; }

    /// <summary>
    /// YSROEN (Primary Key).
    /// </summary>
    public string YSROEN { get; set; }

    /// <summary>
    /// YSTAXX.
    /// </summary>
    public string? YSTAXX { get; set; }

    /// <summary>
    /// YSUIMT.
    /// </summary>
    public string? YSUIMT { get; set; }

    /// <summary>
    /// YSUPIF.
    /// </summary>
    public string? YSUPIF { get; set; }

    /// <summary>
    /// YSCKDT.
    /// </summary>
    public decimal? YSCKDT { get; set; }
}
