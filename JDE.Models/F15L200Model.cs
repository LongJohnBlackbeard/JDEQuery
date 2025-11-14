namespace JDE.Models;

/// <summary>
/// F15L200 - .
/// </summary>
public class F15L200Model
{
    /// <summary>
    /// PLPLNME (Primary Key).
    /// </summary>
    public string PLPLNME { get; set; }

    /// <summary>
    /// PLPLDSC.
    /// </summary>
    public string? PLPLDSC { get; set; }

    /// <summary>
    /// PLUSER.
    /// </summary>
    public string? PLUSER { get; set; }

    /// <summary>
    /// PLPID.
    /// </summary>
    public string? PLPID { get; set; }

    /// <summary>
    /// PLMKEY.
    /// </summary>
    public string? PLMKEY { get; set; }

    /// <summary>
    /// PLUPMJ.
    /// </summary>
    public decimal? PLUPMJ { get; set; }

    /// <summary>
    /// PLUPMT.
    /// </summary>
    public decimal? PLUPMT { get; set; }
}
