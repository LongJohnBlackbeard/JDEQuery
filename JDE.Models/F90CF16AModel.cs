namespace JDE.Models;

/// <summary>
/// F90CF16A - .
/// </summary>
public class F90CF16AModel
{
    /// <summary>
    /// CCQUSTID (Primary Key).
    /// </summary>
    public decimal CCQUSTID { get; set; }

    /// <summary>
    /// CCSCRPTID (Primary Key).
    /// </summary>
    public decimal CCSCRPTID { get; set; }

    /// <summary>
    /// CCJOBN.
    /// </summary>
    public string? CCJOBN { get; set; }

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
}
