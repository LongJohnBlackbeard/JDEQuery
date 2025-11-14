using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08338 - .
/// </summary>
public class F08338Model
{
    /// <summary>
    /// E7AN8 (Primary Key).
    /// </summary>
    public decimal E7AN8 { get; set; }

    /// <summary>
    /// E7PLAN (Primary Key).
    /// </summary>
    public string E7PLAN { get; set; }

    /// <summary>
    /// E7AOPT (Primary Key).
    /// </summary>
    public string E7AOPT { get; set; }

    /// <summary>
    /// E7EFT (Primary Key).
    /// </summary>
    public decimal E7EFT { get; set; }

    /// <summary>
    /// E7EFTE.
    /// </summary>
    public decimal? E7EFTE { get; set; }

    /// <summary>
    /// E7PCP#.
    /// </summary>
    [Column("E7PCP#")]
    public string? E7PCP_ { get; set; }

    /// <summary>
    /// E7GEN1.
    /// </summary>
    public string? E7GEN1 { get; set; }

    /// <summary>
    /// E7GEN2.
    /// </summary>
    public string? E7GEN2 { get; set; }

    /// <summary>
    /// E7GEN3.
    /// </summary>
    public string? E7GEN3 { get; set; }

    /// <summary>
    /// E7EECD.
    /// </summary>
    public string? E7EECD { get; set; }

    /// <summary>
    /// E7EDTE.
    /// </summary>
    public decimal? E7EDTE { get; set; }

    /// <summary>
    /// E7USER.
    /// </summary>
    public string? E7USER { get; set; }

    /// <summary>
    /// E7PID.
    /// </summary>
    public string? E7PID { get; set; }

    /// <summary>
    /// E7JOBN.
    /// </summary>
    public string? E7JOBN { get; set; }

    /// <summary>
    /// E7UPMJ.
    /// </summary>
    public decimal? E7UPMJ { get; set; }

    /// <summary>
    /// E7UPMT.
    /// </summary>
    public decimal? E7UPMT { get; set; }
}
