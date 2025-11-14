namespace JDE.Models;

/// <summary>
/// F51006M - .
/// </summary>
public class F51006MModel
{
    /// <summary>
    /// VMCRCD (Primary Key).
    /// </summary>
    public string VMCRCD { get; set; }

    /// <summary>
    /// VMEXSYSINS (Primary Key).
    /// </summary>
    public string VMEXSYSINS { get; set; }

    /// <summary>
    /// VMCRDC.
    /// </summary>
    public string? VMCRDC { get; set; }

    /// <summary>
    /// VMUSER.
    /// </summary>
    public string? VMUSER { get; set; }

    /// <summary>
    /// VMPID.
    /// </summary>
    public string? VMPID { get; set; }

    /// <summary>
    /// VMMKEY.
    /// </summary>
    public string? VMMKEY { get; set; }

    /// <summary>
    /// VMUPMJ.
    /// </summary>
    public decimal? VMUPMJ { get; set; }

    /// <summary>
    /// VMUPMT.
    /// </summary>
    public decimal? VMUPMT { get; set; }
}
