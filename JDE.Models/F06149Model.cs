using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F06149 - .
/// </summary>
public class F06149Model
{
    /// <summary>
    /// Y7AN8 (Primary Key).
    /// </summary>
    public decimal Y7AN8 { get; set; }

    /// <summary>
    /// Y7PDBA (Primary Key).
    /// </summary>
    public decimal Y7PDBA { get; set; }

    /// <summary>
    /// Y7DTE (Primary Key).
    /// </summary>
    public decimal Y7DTE { get; set; }

    /// <summary>
    /// Y7TAXX (Primary Key).
    /// </summary>
    public string Y7TAXX { get; set; }

    /// <summary>
    /// Y7HMCO (Primary Key).
    /// </summary>
    public string Y7HMCO { get; set; }

    /// <summary>
    /// Y7BWPY.
    /// </summary>
    public decimal? Y7BWPY { get; set; }

    /// <summary>
    /// Y7BWBB.
    /// </summary>
    public decimal? Y7BWBB { get; set; }

    /// <summary>
    /// Y7FY$.
    /// </summary>
    [Column("Y7FY$")]
    public decimal? Y7FY_ { get; set; }

    /// <summary>
    /// Y7BHPY.
    /// </summary>
    public decimal? Y7BHPY { get; set; }

    /// <summary>
    /// Y7BHBB.
    /// </summary>
    public decimal? Y7BHBB { get; set; }

    /// <summary>
    /// Y7FYH.
    /// </summary>
    public decimal? Y7FYH { get; set; }

    /// <summary>
    /// Y7BIPY.
    /// </summary>
    public decimal? Y7BIPY { get; set; }

    /// <summary>
    /// Y7BIBB.
    /// </summary>
    public decimal? Y7BIBB { get; set; }

    /// <summary>
    /// Y7FYP.
    /// </summary>
    public decimal? Y7FYP { get; set; }
}
