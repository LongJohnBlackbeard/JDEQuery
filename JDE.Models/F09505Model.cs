namespace JDE.Models;

/// <summary>
/// F09505 - .
/// </summary>
public class F09505Model
{
    /// <summary>
    /// GNAID (Primary Key).
    /// </summary>
    public string GNAID { get; set; }

    /// <summary>
    /// GNCN (Primary Key).
    /// </summary>
    public string GNCN { get; set; }

    /// <summary>
    /// GNEXA.
    /// </summary>
    public string? GNEXA { get; set; }

    /// <summary>
    /// GNAA.
    /// </summary>
    public decimal? GNAA { get; set; }

    /// <summary>
    /// GNDKC.
    /// </summary>
    public decimal? GNDKC { get; set; }
}
