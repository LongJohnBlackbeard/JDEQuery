using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F073911 - .
/// </summary>
public class F073911Model
{
    /// <summary>
    /// Y8PAYD (Primary Key).
    /// </summary>
    public string Y8PAYD { get; set; }

    /// <summary>
    /// Y8AN8 (Primary Key).
    /// </summary>
    public decimal Y8AN8 { get; set; }

    /// <summary>
    /// Y8HMCO (Primary Key).
    /// </summary>
    public string Y8HMCO { get; set; }

    /// <summary>
    /// Y8DTE (Primary Key).
    /// </summary>
    public decimal Y8DTE { get; set; }

    /// <summary>
    /// Y8PDBA (Primary Key).
    /// </summary>
    public decimal Y8PDBA { get; set; }

    /// <summary>
    /// Y8AA12.
    /// </summary>
    public string? Y8AA12 { get; set; }

    /// <summary>
    /// Y8BHBB.
    /// </summary>
    public decimal? Y8BHBB { get; set; }

    /// <summary>
    /// Y8BWBB.
    /// </summary>
    public decimal? Y8BWBB { get; set; }

    /// <summary>
    /// Y8FYH.
    /// </summary>
    public decimal? Y8FYH { get; set; }

    /// <summary>
    /// Y8FY$.
    /// </summary>
    [Column("Y8FY$")]
    public decimal? Y8FY_ { get; set; }

    /// <summary>
    /// Y8PPYF (Primary Key).
    /// </summary>
    public decimal Y8PPYF { get; set; }

    /// <summary>
    /// Y8BH01.
    /// </summary>
    public decimal? Y8BH01 { get; set; }

    /// <summary>
    /// Y8BW01.
    /// </summary>
    public decimal? Y8BW01 { get; set; }

    /// <summary>
    /// Y8PPYT.
    /// </summary>
    public decimal? Y8PPYT { get; set; }

    /// <summary>
    /// Y8BH02.
    /// </summary>
    public decimal? Y8BH02 { get; set; }

    /// <summary>
    /// Y8BW02.
    /// </summary>
    public decimal? Y8BW02 { get; set; }

    /// <summary>
    /// Y8URNUM09.
    /// </summary>
    public decimal? Y8URNUM09 { get; set; }
}
