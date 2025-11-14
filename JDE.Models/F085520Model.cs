using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F085520 - .
/// </summary>
public class F085520Model
{
    /// <summary>
    /// PHEVET (Primary Key).
    /// </summary>
    public decimal PHEVET { get; set; }

    /// <summary>
    /// PHAN8 (Primary Key).
    /// </summary>
    public decimal PHAN8 { get; set; }

    /// <summary>
    /// PHSBGR (Primary Key).
    /// </summary>
    public string PHSBGR { get; set; }

    /// <summary>
    /// PHDL01.
    /// </summary>
    public string? PHDL01 { get; set; }

    /// <summary>
    /// PHPCP#.
    /// </summary>
    [Column("PHPCP#")]
    public string? PHPCP_ { get; set; }

    /// <summary>
    /// PHPLAN (Primary Key).
    /// </summary>
    public string PHPLAN { get; set; }

    /// <summary>
    /// PHSEQ# (Primary Key).
    /// </summary>
    [Column("PHSEQ#")]
    public decimal PHSEQ_ { get; set; }

    /// <summary>
    /// PHAOPT (Primary Key).
    /// </summary>
    public string PHAOPT { get; set; }

    /// <summary>
    /// PHDL02.
    /// </summary>
    public string? PHDL02 { get; set; }

    /// <summary>
    /// PHEFT.
    /// </summary>
    public decimal? PHEFT { get; set; }

    /// <summary>
    /// PHEFTE.
    /// </summary>
    public decimal? PHEFTE { get; set; }

    /// <summary>
    /// PHEECD.
    /// </summary>
    public string? PHEECD { get; set; }

    /// <summary>
    /// PHDBEN.
    /// </summary>
    public string? PHDBEN { get; set; }

    /// <summary>
    /// PHPCPVST.
    /// </summary>
    public string? PHPCPVST { get; set; }

    /// <summary>
    /// PHPCOS.
    /// </summary>
    public decimal? PHPCOS { get; set; }

    /// <summary>
    /// PHMRTOW.
    /// </summary>
    public decimal? PHMRTOW { get; set; }

    /// <summary>
    /// PHEEFC.
    /// </summary>
    public decimal? PHEEFC { get; set; }

    /// <summary>
    /// PHPCRE.
    /// </summary>
    public decimal? PHPCRE { get; set; }

    /// <summary>
    /// PHDRTM.
    /// </summary>
    public decimal? PHDRTM { get; set; }

    /// <summary>
    /// PHBRTM.
    /// </summary>
    public decimal? PHBRTM { get; set; }

    /// <summary>
    /// PHPID.
    /// </summary>
    public string? PHPID { get; set; }

    /// <summary>
    /// PHUPMJ.
    /// </summary>
    public decimal? PHUPMJ { get; set; }

    /// <summary>
    /// PHUPMT.
    /// </summary>
    public decimal? PHUPMT { get; set; }

    /// <summary>
    /// PHUSER.
    /// </summary>
    public string? PHUSER { get; set; }

    /// <summary>
    /// PHJOBN.
    /// </summary>
    public string? PHJOBN { get; set; }

    /// <summary>
    /// PHESIGN (Primary Key).
    /// </summary>
    public string PHESIGN { get; set; }

    /// <summary>
    /// PHMUMJ.
    /// </summary>
    public decimal? PHMUMJ { get; set; }

    /// <summary>
    /// PHMUMT.
    /// </summary>
    public decimal? PHMUMT { get; set; }

    /// <summary>
    /// PHUPID.
    /// </summary>
    public string? PHUPID { get; set; }
}
