using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F06147 - .
/// </summary>
public class F06147Model
{
    /// <summary>
    /// YDAN8 (Primary Key).
    /// </summary>
    public decimal YDAN8 { get; set; }

    /// <summary>
    /// YDPDBA (Primary Key).
    /// </summary>
    public decimal YDPDBA { get; set; }

    /// <summary>
    /// YDDTE (Primary Key).
    /// </summary>
    public decimal YDDTE { get; set; }

    /// <summary>
    /// YDTAXX (Primary Key).
    /// </summary>
    public string YDTAXX { get; set; }

    /// <summary>
    /// YDHMCO (Primary Key).
    /// </summary>
    public string YDHMCO { get; set; }

    /// <summary>
    /// YDBWPY.
    /// </summary>
    public decimal? YDBWPY { get; set; }

    /// <summary>
    /// YDBWBB.
    /// </summary>
    public decimal? YDBWBB { get; set; }

    /// <summary>
    /// YDFY$.
    /// </summary>
    [Column("YDFY$")]
    public decimal? YDFY_ { get; set; }

    /// <summary>
    /// YDBHPY.
    /// </summary>
    public decimal? YDBHPY { get; set; }

    /// <summary>
    /// YDBHBB.
    /// </summary>
    public decimal? YDBHBB { get; set; }

    /// <summary>
    /// YDFYH.
    /// </summary>
    public decimal? YDFYH { get; set; }

    /// <summary>
    /// YDBIPY.
    /// </summary>
    public decimal? YDBIPY { get; set; }

    /// <summary>
    /// YDBIBB.
    /// </summary>
    public decimal? YDBIBB { get; set; }

    /// <summary>
    /// YDFYP.
    /// </summary>
    public decimal? YDFYP { get; set; }

    /// <summary>
    /// YDUSER.
    /// </summary>
    public string? YDUSER { get; set; }

    /// <summary>
    /// YDUPMJ.
    /// </summary>
    public decimal? YDUPMJ { get; set; }

    /// <summary>
    /// YDPID.
    /// </summary>
    public string? YDPID { get; set; }
}
