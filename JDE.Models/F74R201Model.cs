namespace JDE.Models;

/// <summary>
/// F74R201 - .
/// </summary>
public class F74R201Model
{
    /// <summary>
    /// VMDCTO (Primary Key).
    /// </summary>
    public string VMDCTO { get; set; }

    /// <summary>
    /// VMLNTY (Primary Key).
    /// </summary>
    public string VMLNTY { get; set; }

    /// <summary>
    /// VMR74VATM.
    /// </summary>
    public string? VMR74VATM { get; set; }

    /// <summary>
    /// VMUSER.
    /// </summary>
    public string? VMUSER { get; set; }

    /// <summary>
    /// VMPID.
    /// </summary>
    public string? VMPID { get; set; }

    /// <summary>
    /// VMJOBN.
    /// </summary>
    public string? VMJOBN { get; set; }

    /// <summary>
    /// VMUPMJ.
    /// </summary>
    public decimal? VMUPMJ { get; set; }

    /// <summary>
    /// VMUPMT.
    /// </summary>
    public decimal? VMUPMT { get; set; }
}
