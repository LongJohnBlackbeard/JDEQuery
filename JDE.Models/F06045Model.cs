using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F06045 - .
/// </summary>
public class F06045Model
{
    /// <summary>
    /// BBDTAI (Primary Key).
    /// </summary>
    public string BBDTAI { get; set; }

    /// <summary>
    /// BBPHSD.
    /// </summary>
    public string? BBPHSD { get; set; }

    /// <summary>
    /// BBEFDO.
    /// </summary>
    public decimal? BBEFDO { get; set; }

    /// <summary>
    /// BBTRS.
    /// </summary>
    public string? BBTRS { get; set; }

    /// <summary>
    /// BBMETOW.
    /// </summary>
    public string? BBMETOW { get; set; }

    /// <summary>
    /// BBPID.
    /// </summary>
    public string? BBPID { get; set; }

    /// <summary>
    /// BBUSER.
    /// </summary>
    public string? BBUSER { get; set; }

    /// <summary>
    /// BBJOBN.
    /// </summary>
    public string? BBJOBN { get; set; }

    /// <summary>
    /// BBUPMJ.
    /// </summary>
    public decimal? BBUPMJ { get; set; }

    /// <summary>
    /// BBRCD#.
    /// </summary>
    [Column("BBRCD#")]
    public decimal? BBRCD_ { get; set; }

    /// <summary>
    /// BBUSTT.
    /// </summary>
    public string? BBUSTT { get; set; }

    /// <summary>
    /// BBHSTD.
    /// </summary>
    public string? BBHSTD { get; set; }
}
