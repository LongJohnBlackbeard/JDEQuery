using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F085536 - .
/// </summary>
public class F085536Model
{
    /// <summary>
    /// DHEVET (Primary Key).
    /// </summary>
    public decimal DHEVET { get; set; }

    /// <summary>
    /// DHAN8 (Primary Key).
    /// </summary>
    public decimal DHAN8 { get; set; }

    /// <summary>
    /// DHPAN8 (Primary Key).
    /// </summary>
    public decimal DHPAN8 { get; set; }

    /// <summary>
    /// DHMLNM.
    /// </summary>
    public string? DHMLNM { get; set; }

    /// <summary>
    /// DHDBEN (Primary Key).
    /// </summary>
    public string DHDBEN { get; set; }

    /// <summary>
    /// DHRELA.
    /// </summary>
    public string? DHRELA { get; set; }

    /// <summary>
    /// DHPLAN (Primary Key).
    /// </summary>
    public string DHPLAN { get; set; }

    /// <summary>
    /// DHAOPT (Primary Key).
    /// </summary>
    public string DHAOPT { get; set; }

    /// <summary>
    /// DHEFT.
    /// </summary>
    public decimal? DHEFT { get; set; }

    /// <summary>
    /// DHEFTE.
    /// </summary>
    public decimal? DHEFTE { get; set; }

    /// <summary>
    /// DHEECD.
    /// </summary>
    public string? DHEECD { get; set; }

    /// <summary>
    /// DHEDTE.
    /// </summary>
    public decimal? DHEDTE { get; set; }

    /// <summary>
    /// DHPERC.
    /// </summary>
    public decimal? DHPERC { get; set; }

    /// <summary>
    /// DHSECPERC.
    /// </summary>
    public decimal? DHSECPERC { get; set; }

    /// <summary>
    /// DHNEWPERC.
    /// </summary>
    public decimal? DHNEWPERC { get; set; }

    /// <summary>
    /// DHNSECPERC.
    /// </summary>
    public decimal? DHNSECPERC { get; set; }

    /// <summary>
    /// DHPCP#.
    /// </summary>
    [Column("DHPCP#")]
    public string? DHPCP_ { get; set; }

    /// <summary>
    /// DHPCPVST.
    /// </summary>
    public string? DHPCPVST { get; set; }

    /// <summary>
    /// DHACFL.
    /// </summary>
    public string? DHACFL { get; set; }

    /// <summary>
    /// DHUSER.
    /// </summary>
    public string? DHUSER { get; set; }

    /// <summary>
    /// DHPID.
    /// </summary>
    public string? DHPID { get; set; }

    /// <summary>
    /// DHJOBN.
    /// </summary>
    public string? DHJOBN { get; set; }

    /// <summary>
    /// DHUPMJ.
    /// </summary>
    public decimal? DHUPMJ { get; set; }

    /// <summary>
    /// DHUPMT.
    /// </summary>
    public decimal? DHUPMT { get; set; }

    /// <summary>
    /// DHESIGN (Primary Key).
    /// </summary>
    public string DHESIGN { get; set; }

    /// <summary>
    /// DHMUMJ.
    /// </summary>
    public decimal? DHMUMJ { get; set; }

    /// <summary>
    /// DHMUMT.
    /// </summary>
    public decimal? DHMUMT { get; set; }

    /// <summary>
    /// DHUPID.
    /// </summary>
    public string? DHUPID { get; set; }
}
