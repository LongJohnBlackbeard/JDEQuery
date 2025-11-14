namespace JDE.Models;

/// <summary>
/// F15L201 - .
/// </summary>
public class F15L201Model
{
    /// <summary>
    /// PDPLNME (Primary Key).
    /// </summary>
    public string PDPLNME { get; set; }

    /// <summary>
    /// PDAN8 (Primary Key).
    /// </summary>
    public decimal PDAN8 { get; set; }

    /// <summary>
    /// PDALACT.
    /// </summary>
    public string? PDALACT { get; set; }

    /// <summary>
    /// PDUSER.
    /// </summary>
    public string? PDUSER { get; set; }

    /// <summary>
    /// PDPID.
    /// </summary>
    public string? PDPID { get; set; }

    /// <summary>
    /// PDMKEY.
    /// </summary>
    public string? PDMKEY { get; set; }

    /// <summary>
    /// PDUPMJ.
    /// </summary>
    public decimal? PDUPMJ { get; set; }

    /// <summary>
    /// PDUPMT.
    /// </summary>
    public decimal? PDUPMT { get; set; }
}
