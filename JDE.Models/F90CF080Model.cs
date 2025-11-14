namespace JDE.Models;

/// <summary>
/// F90CF080 - .
/// </summary>
public class F90CF080Model
{
    /// <summary>
    /// SVVARLID (Primary Key).
    /// </summary>
    public decimal SVVARLID { get; set; }

    /// <summary>
    /// SVVARNAM.
    /// </summary>
    public string? SVVARNAM { get; set; }

    /// <summary>
    /// SVVARLTYPE.
    /// </summary>
    public string? SVVARLTYPE { get; set; }

    /// <summary>
    /// SVVARATT.
    /// </summary>
    public string? SVVARATT { get; set; }

    /// <summary>
    /// SVVARLDESC.
    /// </summary>
    public string? SVVARLDESC { get; set; }

    /// <summary>
    /// SVUSER.
    /// </summary>
    public string? SVUSER { get; set; }

    /// <summary>
    /// SVJOBN.
    /// </summary>
    public string? SVJOBN { get; set; }

    /// <summary>
    /// SVMKEY.
    /// </summary>
    public string? SVMKEY { get; set; }

    /// <summary>
    /// SVUDTTM.
    /// </summary>
    public DateTime? SVUDTTM { get; set; }
}
