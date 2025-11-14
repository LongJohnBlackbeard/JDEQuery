namespace JDE.Models;

/// <summary>
/// F75T015 - .
/// </summary>
public class F75T015Model
{
    /// <summary>
    /// SL75TUIP (Primary Key).
    /// </summary>
    public string SL75TUIP { get; set; }

    /// <summary>
    /// SL75TGRF (Primary Key).
    /// </summary>
    public decimal SL75TGRF { get; set; }

    /// <summary>
    /// SL75TGSF (Primary Key).
    /// </summary>
    public decimal SL75TGSF { get; set; }

    /// <summary>
    /// SLUSER.
    /// </summary>
    public string? SLUSER { get; set; }

    /// <summary>
    /// SLPID.
    /// </summary>
    public string? SLPID { get; set; }

    /// <summary>
    /// SLJOBN.
    /// </summary>
    public string? SLJOBN { get; set; }

    /// <summary>
    /// SLUPMJ.
    /// </summary>
    public decimal? SLUPMJ { get; set; }

    /// <summary>
    /// SLTDAY.
    /// </summary>
    public decimal? SLTDAY { get; set; }
}
