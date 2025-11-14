namespace JDE.Models;

/// <summary>
/// F90CF06A - .
/// </summary>
public class F90CF06AModel
{
    /// <summary>
    /// CCQUSTID (Primary Key).
    /// </summary>
    public decimal CCQUSTID { get; set; }

    /// <summary>
    /// CCLANG (Primary Key).
    /// </summary>
    public string CCLANG { get; set; }

    /// <summary>
    /// CCQUSTGUD.
    /// </summary>
    public string? CCQUSTGUD { get; set; }

    /// <summary>
    /// CCMKEY.
    /// </summary>
    public string? CCMKEY { get; set; }

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
    /// CCQUSDESC.
    /// </summary>
    public string? CCQUSDESC { get; set; }
}
