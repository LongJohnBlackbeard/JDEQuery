namespace JDE.Models;

/// <summary>
/// F90CE01D - .
/// </summary>
public class F90CE01DModel
{
    /// <summary>
    /// SPSLTNID (Primary Key).
    /// </summary>
    public decimal SPSLTNID { get; set; }

    /// <summary>
    /// SPITM (Primary Key).
    /// </summary>
    public decimal SPITM { get; set; }

    /// <summary>
    /// SPSETID.
    /// </summary>
    public string? SPSETID { get; set; }

    /// <summary>
    /// SPENTDBY.
    /// </summary>
    public decimal? SPENTDBY { get; set; }

    /// <summary>
    /// SPEDATE.
    /// </summary>
    public DateTime? SPEDATE { get; set; }

    /// <summary>
    /// SPUSER.
    /// </summary>
    public string? SPUSER { get; set; }

    /// <summary>
    /// SPUDTTM.
    /// </summary>
    public DateTime? SPUDTTM { get; set; }

    /// <summary>
    /// SPMKEY.
    /// </summary>
    public string? SPMKEY { get; set; }
}
