using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F81A10 - .
/// </summary>
public class F81A10Model
{
    /// <summary>
    /// MEPID (Primary Key).
    /// </summary>
    public string MEPID { get; set; }

    /// <summary>
    /// MELDFR (Primary Key).
    /// </summary>
    public string MELDFR { get; set; }

    /// <summary>
    /// MEVERS (Primary Key).
    /// </summary>
    public string MEVERS { get; set; }

    /// <summary>
    /// MEFPID (Primary Key).
    /// </summary>
    public string MEFPID { get; set; }

    /// <summary>
    /// MEBVER (Primary Key).
    /// </summary>
    public string MEBVER { get; set; }

    /// <summary>
    /// MESQN.
    /// </summary>
    public decimal? MESQN { get; set; }

    /// <summary>
    /// MEOPT# (Primary Key).
    /// </summary>
    [Column("MEOPT#")]
    public decimal MEOPT_ { get; set; }

    /// <summary>
    /// MEOBNM.
    /// </summary>
    public string? MEOBNM { get; set; }

    /// <summary>
    /// MELPTP.
    /// </summary>
    public string? MELPTP { get; set; }

    /// <summary>
    /// MELITN (Primary Key).
    /// </summary>
    public decimal MELITN { get; set; }

    /// <summary>
    /// MEBSQN (Primary Key).
    /// </summary>
    public decimal MEBSQN { get; set; }

    /// <summary>
    /// MELNGP.
    /// </summary>
    public string? MELNGP { get; set; }

    /// <summary>
    /// MEQST.
    /// </summary>
    public string? MEQST { get; set; }

    /// <summary>
    /// MEDTAI (Primary Key).
    /// </summary>
    public string MEDTAI { get; set; }

    /// <summary>
    /// MEDS01.
    /// </summary>
    public string? MEDS01 { get; set; }

    /// <summary>
    /// MEJOB#.
    /// </summary>
    [Column("MEJOB#")]
    public decimal? MEJOB_ { get; set; }

    /// <summary>
    /// MELMBN (Primary Key).
    /// </summary>
    public decimal MELMBN { get; set; }

    /// <summary>
    /// MELUS.
    /// </summary>
    public string? MELUS { get; set; }

    /// <summary>
    /// MEFPD.
    /// </summary>
    public string? MEFPD { get; set; }

    /// <summary>
    /// MEUPMJ.
    /// </summary>
    public decimal? MEUPMJ { get; set; }

    /// <summary>
    /// MEUPMT.
    /// </summary>
    public decimal? MEUPMT { get; set; }

    /// <summary>
    /// MEJOBN.
    /// </summary>
    public string? MEJOBN { get; set; }
}
