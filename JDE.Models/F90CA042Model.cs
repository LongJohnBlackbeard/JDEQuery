namespace JDE.Models;

/// <summary>
/// F90CA042 - .
/// </summary>
public class F90CA042Model
{
    /// <summary>
    /// EMAN8 (Primary Key).
    /// </summary>
    public decimal EMAN8 { get; set; }

    /// <summary>
    /// EMPA8 (Primary Key).
    /// </summary>
    public decimal EMPA8 { get; set; }

    /// <summary>
    /// EMEMH.
    /// </summary>
    public decimal? EMEMH { get; set; }

    /// <summary>
    /// EMEDATE.
    /// </summary>
    public DateTime? EMEDATE { get; set; }

    /// <summary>
    /// EMUSER.
    /// </summary>
    public string? EMUSER { get; set; }

    /// <summary>
    /// EMUDTTM.
    /// </summary>
    public DateTime? EMUDTTM { get; set; }

    /// <summary>
    /// EMMKEY.
    /// </summary>
    public string? EMMKEY { get; set; }

    /// <summary>
    /// EMENTDBY.
    /// </summary>
    public decimal? EMENTDBY { get; set; }
}
