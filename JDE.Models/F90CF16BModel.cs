namespace JDE.Models;

/// <summary>
/// F90CF16B - .
/// </summary>
public class F90CF16BModel
{
    /// <summary>
    /// ISSCRPTID (Primary Key).
    /// </summary>
    public decimal ISSCRPTID { get; set; }

    /// <summary>
    /// ISITM (Primary Key).
    /// </summary>
    public decimal ISITM { get; set; }

    /// <summary>
    /// ISUDTTM.
    /// </summary>
    public DateTime? ISUDTTM { get; set; }

    /// <summary>
    /// ISUSER.
    /// </summary>
    public string? ISUSER { get; set; }

    /// <summary>
    /// ISJOBN.
    /// </summary>
    public string? ISJOBN { get; set; }

    /// <summary>
    /// ISMKEY.
    /// </summary>
    public string? ISMKEY { get; set; }
}
