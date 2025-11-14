namespace JDE.Models;

/// <summary>
/// F90CG507 - .
/// </summary>
public class F90CG507Model
{
    /// <summary>
    /// CCDOCO (Primary Key).
    /// </summary>
    public decimal CCDOCO { get; set; }

    /// <summary>
    /// CCSTAW (Primary Key).
    /// </summary>
    public string CCSTAW { get; set; }

    /// <summary>
    /// CCWFTYPE (Primary Key).
    /// </summary>
    public string CCWFTYPE { get; set; }

    /// <summary>
    /// CCWFLINEID (Primary Key).
    /// </summary>
    public decimal CCWFLINEID { get; set; }

    /// <summary>
    /// CCENTDBY.
    /// </summary>
    public decimal? CCENTDBY { get; set; }

    /// <summary>
    /// CCEDATE.
    /// </summary>
    public DateTime? CCEDATE { get; set; }

    /// <summary>
    /// CCUDTTM.
    /// </summary>
    public DateTime? CCUDTTM { get; set; }

    /// <summary>
    /// CCMKEY.
    /// </summary>
    public string? CCMKEY { get; set; }
}
