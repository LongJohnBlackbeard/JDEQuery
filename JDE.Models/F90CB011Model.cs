namespace JDE.Models;

/// <summary>
/// F90CB011 - .
/// </summary>
public class F90CB011Model
{
    /// <summary>
    /// LAADRSID (Primary Key).
    /// </summary>
    public decimal LAADRSID { get; set; }

    /// <summary>
    /// LALEADID (Primary Key).
    /// </summary>
    public decimal LALEADID { get; set; }

    /// <summary>
    /// LASTSUDT.
    /// </summary>
    public DateTime? LASTSUDT { get; set; }

    /// <summary>
    /// LAACTIND.
    /// </summary>
    public string? LAACTIND { get; set; }
}
