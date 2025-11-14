namespace JDE.Models;

/// <summary>
/// F90CF16C - .
/// </summary>
public class F90CF16CModel
{
    /// <summary>
    /// CCEXTMSG.
    /// </summary>
    public string? CCEXTMSG { get; set; }

    /// <summary>
    /// CCUSER.
    /// </summary>
    public string? CCUSER { get; set; }

    /// <summary>
    /// CCUDTTM.
    /// </summary>
    public DateTime? CCUDTTM { get; set; }

    /// <summary>
    /// CCMKEY.
    /// </summary>
    public string? CCMKEY { get; set; }

    /// <summary>
    /// CCLANG (Primary Key).
    /// </summary>
    public string CCLANG { get; set; }

    /// <summary>
    /// CCSCRPTID (Primary Key).
    /// </summary>
    public decimal CCSCRPTID { get; set; }

    /// <summary>
    /// CCJOBN.
    /// </summary>
    public string? CCJOBN { get; set; }

    /// <summary>
    /// CCSTEXTMSG.
    /// </summary>
    public string? CCSTEXTMSG { get; set; }
}
