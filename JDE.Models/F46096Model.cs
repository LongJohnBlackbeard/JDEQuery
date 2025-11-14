namespace JDE.Models;

/// <summary>
/// F46096 - .
/// </summary>
public class F46096Model
{
    /// <summary>
    /// OUMCU (Primary Key).
    /// </summary>
    public string OUMCU { get; set; }

    /// <summary>
    /// OUUOM (Primary Key).
    /// </summary>
    public string OUUOM { get; set; }

    /// <summary>
    /// OUUMGP.
    /// </summary>
    public string? OUUMGP { get; set; }

    /// <summary>
    /// OUUSER.
    /// </summary>
    public string? OUUSER { get; set; }

    /// <summary>
    /// OUUPMJ.
    /// </summary>
    public decimal? OUUPMJ { get; set; }

    /// <summary>
    /// OUTDAY.
    /// </summary>
    public decimal? OUTDAY { get; set; }
}
