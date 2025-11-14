using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F085537W - .
/// </summary>
public class F085537WModel
{
    /// <summary>
    /// XBAN8 (Primary Key).
    /// </summary>
    public decimal XBAN8 { get; set; }

    /// <summary>
    /// XBPAN8 (Primary Key).
    /// </summary>
    public decimal XBPAN8 { get; set; }

    /// <summary>
    /// XBMLNM.
    /// </summary>
    public string? XBMLNM { get; set; }

    /// <summary>
    /// XBDBEN (Primary Key).
    /// </summary>
    public string XBDBEN { get; set; }

    /// <summary>
    /// XBRELA.
    /// </summary>
    public string? XBRELA { get; set; }

    /// <summary>
    /// XBPLAN (Primary Key).
    /// </summary>
    public string XBPLAN { get; set; }

    /// <summary>
    /// XBAOPT (Primary Key).
    /// </summary>
    public string XBAOPT { get; set; }

    /// <summary>
    /// XBEFT.
    /// </summary>
    public decimal? XBEFT { get; set; }

    /// <summary>
    /// XBEFTE.
    /// </summary>
    public decimal? XBEFTE { get; set; }

    /// <summary>
    /// XBPCP#.
    /// </summary>
    [Column("XBPCP#")]
    public string? XBPCP_ { get; set; }

    /// <summary>
    /// XBPERC.
    /// </summary>
    public decimal? XBPERC { get; set; }

    /// <summary>
    /// XBSECPERC.
    /// </summary>
    public decimal? XBSECPERC { get; set; }

    /// <summary>
    /// XBNEWPERC.
    /// </summary>
    public decimal? XBNEWPERC { get; set; }

    /// <summary>
    /// XBNSECPERC.
    /// </summary>
    public decimal? XBNSECPERC { get; set; }

    /// <summary>
    /// XBPCPVST.
    /// </summary>
    public string? XBPCPVST { get; set; }

    /// <summary>
    /// XBUSER.
    /// </summary>
    public string? XBUSER { get; set; }

    /// <summary>
    /// XBPID.
    /// </summary>
    public string? XBPID { get; set; }

    /// <summary>
    /// XBJOBN.
    /// </summary>
    public string? XBJOBN { get; set; }

    /// <summary>
    /// XBUPMJ.
    /// </summary>
    public decimal? XBUPMJ { get; set; }

    /// <summary>
    /// XBUPMT.
    /// </summary>
    public decimal? XBUPMT { get; set; }

    /// <summary>
    /// XBCCAI.
    /// </summary>
    public string? XBCCAI { get; set; }
}
