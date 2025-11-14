using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08338B - .
/// </summary>
public class F08338BModel
{
    /// <summary>
    /// PTAN8 (Primary Key).
    /// </summary>
    public decimal PTAN8 { get; set; }

    /// <summary>
    /// PTPLAN (Primary Key).
    /// </summary>
    public string PTPLAN { get; set; }

    /// <summary>
    /// PTAOPT (Primary Key).
    /// </summary>
    public string PTAOPT { get; set; }

    /// <summary>
    /// PTEFT (Primary Key).
    /// </summary>
    public decimal PTEFT { get; set; }

    /// <summary>
    /// PTPCP#.
    /// </summary>
    [Column("PTPCP#")]
    public string? PTPCP_ { get; set; }

    /// <summary>
    /// PTPCPVST.
    /// </summary>
    public string? PTPCPVST { get; set; }

    /// <summary>
    /// PTUSER.
    /// </summary>
    public string? PTUSER { get; set; }

    /// <summary>
    /// PTPID.
    /// </summary>
    public string? PTPID { get; set; }

    /// <summary>
    /// PTJOBN.
    /// </summary>
    public string? PTJOBN { get; set; }

    /// <summary>
    /// PTUPMJ.
    /// </summary>
    public decimal? PTUPMJ { get; set; }

    /// <summary>
    /// PTUPMT.
    /// </summary>
    public decimal? PTUPMT { get; set; }
}
