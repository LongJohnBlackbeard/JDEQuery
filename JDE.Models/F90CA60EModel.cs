namespace JDE.Models;

/// <summary>
/// F90CA60E - .
/// </summary>
public class F90CA60EModel
{
    /// <summary>
    /// ACACTIVID (Primary Key).
    /// </summary>
    public string ACACTIVID { get; set; }

    /// <summary>
    /// ACLEADID (Primary Key).
    /// </summary>
    public decimal ACLEADID { get; set; }

    /// <summary>
    /// ACUDTTM.
    /// </summary>
    public DateTime? ACUDTTM { get; set; }

    /// <summary>
    /// ACUSER.
    /// </summary>
    public string? ACUSER { get; set; }

    /// <summary>
    /// ACEDATE.
    /// </summary>
    public DateTime? ACEDATE { get; set; }

    /// <summary>
    /// ACMKEY.
    /// </summary>
    public string? ACMKEY { get; set; }

    /// <summary>
    /// ACENTDBY.
    /// </summary>
    public decimal? ACENTDBY { get; set; }
}
