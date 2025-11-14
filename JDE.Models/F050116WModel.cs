using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F050116W - .
/// </summary>
public class F050116WModel
{
    /// <summary>
    /// EMASMTGUID.
    /// </summary>
    public string? EMASMTGUID { get; set; }

    /// <summary>
    /// EMAN8 (Primary Key).
    /// </summary>
    public decimal EMAN8 { get; set; }

    /// <summary>
    /// EMHMCU (Primary Key).
    /// </summary>
    public string EMHMCU { get; set; }

    /// <summary>
    /// EMEFTO (Primary Key).
    /// </summary>
    public decimal EMEFTO { get; set; }

    /// <summary>
    /// EMSEQ# (Primary Key).
    /// </summary>
    [Column("EMSEQ#")]
    public decimal EMSEQ_ { get; set; }

    /// <summary>
    /// EMTRS (Primary Key).
    /// </summary>
    public string EMTRS { get; set; }

    /// <summary>
    /// EMJBCD (Primary Key).
    /// </summary>
    public string EMJBCD { get; set; }

    /// <summary>
    /// EMJBST (Primary Key).
    /// </summary>
    public string EMJBST { get; set; }

    /// <summary>
    /// EMPFRQ.
    /// </summary>
    public string? EMPFRQ { get; set; }

    /// <summary>
    /// EMCO.
    /// </summary>
    public string? EMCO { get; set; }

    /// <summary>
    /// EMPOS.
    /// </summary>
    public string? EMPOS { get; set; }

    /// <summary>
    /// EMPGRD.
    /// </summary>
    public string? EMPGRD { get; set; }

    /// <summary>
    /// EMUN.
    /// </summary>
    public string? EMUN { get; set; }

    /// <summary>
    /// EMSALY.
    /// </summary>
    public string? EMSALY { get; set; }

    /// <summary>
    /// EMSLOC.
    /// </summary>
    public string? EMSLOC { get; set; }

    /// <summary>
    /// EMPHRT.
    /// </summary>
    public decimal? EMPHRT { get; set; }

    /// <summary>
    /// EMSAL.
    /// </summary>
    public decimal? EMSAL { get; set; }

    /// <summary>
    /// EMPSDT.
    /// </summary>
    public decimal? EMPSDT { get; set; }

    /// <summary>
    /// EMPTDT.
    /// </summary>
    public decimal? EMPTDT { get; set; }

    /// <summary>
    /// EMNRVW.
    /// </summary>
    public decimal? EMNRVW { get; set; }

    /// <summary>
    /// EMSALAPP.
    /// </summary>
    public string? EMSALAPP { get; set; }

    /// <summary>
    /// EMUPMJ.
    /// </summary>
    public decimal? EMUPMJ { get; set; }

    /// <summary>
    /// EMUPMT.
    /// </summary>
    public decimal? EMUPMT { get; set; }

    /// <summary>
    /// EMUSER.
    /// </summary>
    public string? EMUSER { get; set; }

    /// <summary>
    /// EMMKEY.
    /// </summary>
    public string? EMMKEY { get; set; }

    /// <summary>
    /// EMPID.
    /// </summary>
    public string? EMPID { get; set; }

    /// <summary>
    /// EMRCPRC.
    /// </summary>
    public string? EMRCPRC { get; set; }
}
