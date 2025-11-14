namespace JDE.Models;

/// <summary>
/// F90CB01B - .
/// </summary>
public class F90CB01BModel
{
    /// <summary>
    /// LTLEADID (Primary Key).
    /// </summary>
    public decimal LTLEADID { get; set; }

    /// <summary>
    /// LTACTVID (Primary Key).
    /// </summary>
    public decimal LTACTVID { get; set; }

    /// <summary>
    /// LTSTSUDT.
    /// </summary>
    public DateTime? LTSTSUDT { get; set; }

    /// <summary>
    /// LTACTIND.
    /// </summary>
    public string? LTACTIND { get; set; }

    /// <summary>
    /// LTUSER.
    /// </summary>
    public string? LTUSER { get; set; }

    /// <summary>
    /// LTPID.
    /// </summary>
    public string? LTPID { get; set; }

    /// <summary>
    /// LTVID.
    /// </summary>
    public string? LTVID { get; set; }

    /// <summary>
    /// LTMKEY.
    /// </summary>
    public string? LTMKEY { get; set; }

    /// <summary>
    /// LTUDTTM.
    /// </summary>
    public DateTime? LTUDTTM { get; set; }
}
