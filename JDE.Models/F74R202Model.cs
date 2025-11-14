namespace JDE.Models;

/// <summary>
/// F74R202 - .
/// </summary>
public class F74R202Model
{
    /// <summary>
    /// TAGLC (Primary Key).
    /// </summary>
    public string TAGLC { get; set; }

    /// <summary>
    /// TAR74GLC2 (Primary Key).
    /// </summary>
    public string TAR74GLC2 { get; set; }

    /// <summary>
    /// TAUSER.
    /// </summary>
    public string? TAUSER { get; set; }

    /// <summary>
    /// TAPID.
    /// </summary>
    public string? TAPID { get; set; }

    /// <summary>
    /// TAJOBN.
    /// </summary>
    public string? TAJOBN { get; set; }

    /// <summary>
    /// TAUPMJ.
    /// </summary>
    public decimal? TAUPMJ { get; set; }

    /// <summary>
    /// TAUPMT.
    /// </summary>
    public decimal? TAUPMT { get; set; }
}
