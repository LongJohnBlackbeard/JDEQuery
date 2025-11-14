using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F07149 - .
/// </summary>
public class F07149Model
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
    /// Y8PDBA (Primary Key).
    /// </summary>
    public decimal Y8PDBA { get; set; }

    /// <summary>
    /// Y8TAXX (Primary Key).
    /// </summary>
    public string Y8TAXX { get; set; }

    /// <summary>
    /// Y8HMCO (Primary Key).
    /// </summary>
    public string Y8HMCO { get; set; }

    /// <summary>
    /// Y8ANNIVDT (Primary Key).
    /// </summary>
    public decimal Y8ANNIVDT { get; set; }

    /// <summary>
    /// Y8RECC.
    /// </summary>
    public string? Y8RECC { get; set; }

    /// <summary>
    /// Y8BWPY.
    /// </summary>
    public decimal? Y8BWPY { get; set; }

    /// <summary>
    /// Y8BWBB.
    /// </summary>
    public decimal? Y8BWBB { get; set; }

    /// <summary>
    /// Y8FY$.
    /// </summary>
    [Column("Y8FY$")]
    public decimal? Y8FY_ { get; set; }

    /// <summary>
    /// Y8BHPY.
    /// </summary>
    public decimal? Y8BHPY { get; set; }

    /// <summary>
    /// Y8BHBB.
    /// </summary>
    public decimal? Y8BHBB { get; set; }

    /// <summary>
    /// Y8FYH.
    /// </summary>
    public decimal? Y8FYH { get; set; }

    /// <summary>
    /// Y8USER.
    /// </summary>
    public string? Y8USER { get; set; }

    /// <summary>
    /// Y8PID.
    /// </summary>
    public string? Y8PID { get; set; }

    /// <summary>
    /// Y8JOBN.
    /// </summary>
    public string? Y8JOBN { get; set; }

    /// <summary>
    /// Y8UPMJ.
    /// </summary>
    public decimal? Y8UPMJ { get; set; }

    /// <summary>
    /// Y8UPMT.
    /// </summary>
    public decimal? Y8UPMT { get; set; }

    /// <summary>
    /// Y8PGRP.
    /// </summary>
    public string? Y8PGRP { get; set; }

    /// <summary>
    /// Y8CKCN (Primary Key).
    /// </summary>
    public decimal Y8CKCN { get; set; }
}
