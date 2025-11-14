namespace JDE.Models;

/// <summary>
/// F75T011 - .
/// </summary>
public class F75T011Model
{
    /// <summary>
    /// GDEAP (Primary Key).
    /// </summary>
    public string GDEAP { get; set; }

    /// <summary>
    /// GDVER (Primary Key).
    /// </summary>
    public string GDVER { get; set; }

    /// <summary>
    /// GD75TDCT.
    /// </summary>
    public string? GD75TDCT { get; set; }

    /// <summary>
    /// GD75TGFC.
    /// </summary>
    public string? GD75TGFC { get; set; }

    /// <summary>
    /// GDUSER.
    /// </summary>
    public string? GDUSER { get; set; }

    /// <summary>
    /// GDJOBN.
    /// </summary>
    public string? GDJOBN { get; set; }

    /// <summary>
    /// GDPID.
    /// </summary>
    public string? GDPID { get; set; }

    /// <summary>
    /// GDUPMJ.
    /// </summary>
    public decimal? GDUPMJ { get; set; }

    /// <summary>
    /// GDTDAY.
    /// </summary>
    public decimal? GDTDAY { get; set; }
}
