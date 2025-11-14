namespace JDE.Models;

/// <summary>
/// F90CF140 - .
/// </summary>
public class F90CF140Model
{
    /// <summary>
    /// CCRTSTID (Primary Key).
    /// </summary>
    public decimal CCRTSTID { get; set; }

    /// <summary>
    /// CCRATENAM.
    /// </summary>
    public string? CCRATENAM { get; set; }

    /// <summary>
    /// CCRTSTDESC.
    /// </summary>
    public string? CCRTSTDESC { get; set; }

    /// <summary>
    /// CCUSER.
    /// </summary>
    public string? CCUSER { get; set; }

    /// <summary>
    /// CCUDTTM.
    /// </summary>
    public DateTime? CCUDTTM { get; set; }

    /// <summary>
    /// CCJOBN.
    /// </summary>
    public string? CCJOBN { get; set; }

    /// <summary>
    /// CCMKEY.
    /// </summary>
    public string? CCMKEY { get; set; }
}
