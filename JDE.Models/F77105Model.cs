namespace JDE.Models;

/// <summary>
/// F77105 - .
/// </summary>
public class F77105Model
{
    /// <summary>
    /// LSYEID (Primary Key).
    /// </summary>
    public string LSYEID { get; set; }

    /// <summary>
    /// LSTAXYR (Primary Key).
    /// </summary>
    public decimal LSTAXYR { get; set; }

    /// <summary>
    /// LSEIER.
    /// </summary>
    public decimal? LSEIER { get; set; }

    /// <summary>
    /// LSCPPE.
    /// </summary>
    public decimal? LSCPPE { get; set; }
}
