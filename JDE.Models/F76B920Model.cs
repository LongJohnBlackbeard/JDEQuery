namespace JDE.Models;

/// <summary>
/// F76B920 - .
/// </summary>
public class F76B920Model
{
    /// <summary>
    /// RCB76ACIR (Primary Key).
    /// </summary>
    public string RCB76ACIR { get; set; }

    /// <summary>
    /// RCB76REFA (Primary Key).
    /// </summary>
    public string RCB76REFA { get; set; }

    /// <summary>
    /// RCB76READ.
    /// </summary>
    public string? RCB76READ { get; set; }

    /// <summary>
    /// RCUSER.
    /// </summary>
    public string? RCUSER { get; set; }

    /// <summary>
    /// RCPID.
    /// </summary>
    public string? RCPID { get; set; }

    /// <summary>
    /// RCJOBN.
    /// </summary>
    public string? RCJOBN { get; set; }

    /// <summary>
    /// RCUPMT.
    /// </summary>
    public decimal? RCUPMT { get; set; }

    /// <summary>
    /// RCUPMJ.
    /// </summary>
    public decimal? RCUPMJ { get; set; }
}
