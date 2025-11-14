namespace JDE.Models;

/// <summary>
/// F90CF050 - .
/// </summary>
public class F90CF050Model
{
    /// <summary>
    /// CCQSTGRPID (Primary Key).
    /// </summary>
    public decimal CCQSTGRPID { get; set; }

    /// <summary>
    /// CCQSTGRPNM.
    /// </summary>
    public string? CCQSTGRPNM { get; set; }

    /// <summary>
    /// CCQSTGRSTS.
    /// </summary>
    public string? CCQSTGRSTS { get; set; }

    /// <summary>
    /// CCMKEY.
    /// </summary>
    public string? CCMKEY { get; set; }

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
    /// CCQGRPDESC.
    /// </summary>
    public string? CCQGRPDESC { get; set; }
}
