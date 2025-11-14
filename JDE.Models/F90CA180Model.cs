namespace JDE.Models;

/// <summary>
/// F90CA180 - .
/// </summary>
public class F90CA180Model
{
    /// <summary>
    /// TAUKID (Primary Key).
    /// </summary>
    public decimal TAUKID { get; set; }

    /// <summary>
    /// TATERRID (Primary Key).
    /// </summary>
    public decimal TATERRID { get; set; }

    /// <summary>
    /// TACOMDATE.
    /// </summary>
    public DateTime? TACOMDATE { get; set; }

    /// <summary>
    /// TAEDATE.
    /// </summary>
    public DateTime? TAEDATE { get; set; }

    /// <summary>
    /// TASTSUDT.
    /// </summary>
    public DateTime? TASTSUDT { get; set; }

    /// <summary>
    /// TAACTIND.
    /// </summary>
    public string? TAACTIND { get; set; }

    /// <summary>
    /// TAUSER.
    /// </summary>
    public string? TAUSER { get; set; }

    /// <summary>
    /// TAPID.
    /// </summary>
    public string? TAPID { get; set; }

    /// <summary>
    /// TAVID.
    /// </summary>
    public string? TAVID { get; set; }

    /// <summary>
    /// TAMKEY.
    /// </summary>
    public string? TAMKEY { get; set; }

    /// <summary>
    /// TAUDTTM.
    /// </summary>
    public DateTime? TAUDTTM { get; set; }

    /// <summary>
    /// TAENTDBY.
    /// </summary>
    public decimal? TAENTDBY { get; set; }
}
