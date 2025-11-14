namespace JDE.Models;

/// <summary>
/// F90CF05A - .
/// </summary>
public class F90CF05AModel
{
    /// <summary>
    /// CCQSTGRPID (Primary Key).
    /// </summary>
    public decimal CCQSTGRPID { get; set; }

    /// <summary>
    /// CCQUSTID (Primary Key).
    /// </summary>
    public decimal CCQUSTID { get; set; }

    /// <summary>
    /// CCQSTGRODR.
    /// </summary>
    public decimal? CCQSTGRODR { get; set; }

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
}
