namespace JDE.Models;

/// <summary>
/// F90CC01A - .
/// </summary>
public class F90CC01AModel
{
    /// <summary>
    /// CACAMPEVTID (Primary Key).
    /// </summary>
    public decimal CACAMPEVTID { get; set; }

    /// <summary>
    /// CACLLACTID (Primary Key).
    /// </summary>
    public decimal CACLLACTID { get; set; }

    /// <summary>
    /// CASTSUDT.
    /// </summary>
    public DateTime? CASTSUDT { get; set; }

    /// <summary>
    /// CAACTIND.
    /// </summary>
    public string? CAACTIND { get; set; }
}
