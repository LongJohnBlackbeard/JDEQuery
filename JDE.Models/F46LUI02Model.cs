namespace JDE.Models;

/// <summary>
/// F46LUI02 - .
/// </summary>
public class F46LUI02Model
{
    /// <summary>
    /// LPJOBS (Primary Key).
    /// </summary>
    public decimal LPJOBS { get; set; }

    /// <summary>
    /// LPLPNU (Primary Key).
    /// </summary>
    public string LPLPNU { get; set; }

    /// <summary>
    /// LPPLPNU.
    /// </summary>
    public string? LPPLPNU { get; set; }

    /// <summary>
    /// LPPQOH.
    /// </summary>
    public decimal? LPPQOH { get; set; }

    /// <summary>
    /// LPUOM.
    /// </summary>
    public string? LPUOM { get; set; }

    /// <summary>
    /// LPEQTY.
    /// </summary>
    public string? LPEQTY { get; set; }
}
