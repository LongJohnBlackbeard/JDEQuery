namespace JDE.Models;

/// <summary>
/// F42003 - .
/// </summary>
public class F42003Model
{
    /// <summary>
    /// RESLS (Primary Key).
    /// </summary>
    public decimal RESLS { get; set; }

    /// <summary>
    /// RESLSP (Primary Key).
    /// </summary>
    public decimal RESLSP { get; set; }

    /// <summary>
    /// RERPCT.
    /// </summary>
    public decimal? RERPCT { get; set; }

    /// <summary>
    /// RECEFJ.
    /// </summary>
    public decimal? RECEFJ { get; set; }

    /// <summary>
    /// RECXPJ (Primary Key).
    /// </summary>
    public decimal RECXPJ { get; set; }

    /// <summary>
    /// RECOMB.
    /// </summary>
    public string? RECOMB { get; set; }

    /// <summary>
    /// RELNOR.
    /// </summary>
    public string? RELNOR { get; set; }

    /// <summary>
    /// REDESC.
    /// </summary>
    public string? REDESC { get; set; }
}
