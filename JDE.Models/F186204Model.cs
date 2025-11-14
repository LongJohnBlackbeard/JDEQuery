namespace JDE.Models;

/// <summary>
/// F186204 - .
/// </summary>
public class F186204Model
{
    /// <summary>
    /// CGLRSEGID (Primary Key).
    /// </summary>
    public decimal CGLRSEGID { get; set; }

    /// <summary>
    /// CGLRSEGCID (Primary Key).
    /// </summary>
    public decimal CGLRSEGCID { get; set; }

    /// <summary>
    /// CGUSER.
    /// </summary>
    public string? CGUSER { get; set; }

    /// <summary>
    /// CGPID.
    /// </summary>
    public string? CGPID { get; set; }

    /// <summary>
    /// CGJOBN.
    /// </summary>
    public string? CGJOBN { get; set; }

    /// <summary>
    /// CGUPMJ.
    /// </summary>
    public decimal? CGUPMJ { get; set; }

    /// <summary>
    /// CGTDAY.
    /// </summary>
    public decimal? CGTDAY { get; set; }
}
