namespace JDE.Models;

/// <summary>
/// F90CB012 - .
/// </summary>
public class F90CB012Model
{
    /// <summary>
    /// LALEADID (Primary Key).
    /// </summary>
    public decimal LALEADID { get; set; }

    /// <summary>
    /// LAACTVID (Primary Key).
    /// </summary>
    public decimal LAACTVID { get; set; }

    /// <summary>
    /// LASTSUDT.
    /// </summary>
    public DateTime? LASTSUDT { get; set; }

    /// <summary>
    /// LAACTIND.
    /// </summary>
    public string? LAACTIND { get; set; }
}
