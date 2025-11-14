namespace JDE.Models;

/// <summary>
/// F76B4321 - .
/// </summary>
public class F76B4321Model
{
    /// <summary>
    /// PCBNOP (Primary Key).
    /// </summary>
    public decimal PCBNOP { get; set; }

    /// <summary>
    /// PCBSOP (Primary Key).
    /// </summary>
    public string PCBSOP { get; set; }

    /// <summary>
    /// PCBCFC.
    /// </summary>
    public string? PCBCFC { get; set; }

    /// <summary>
    /// PCUSER.
    /// </summary>
    public string? PCUSER { get; set; }

    /// <summary>
    /// PCPID.
    /// </summary>
    public string? PCPID { get; set; }

    /// <summary>
    /// PCJOBN.
    /// </summary>
    public string? PCJOBN { get; set; }

    /// <summary>
    /// PCUPMJ.
    /// </summary>
    public decimal? PCUPMJ { get; set; }

    /// <summary>
    /// PCTDAY.
    /// </summary>
    public decimal? PCTDAY { get; set; }
}
