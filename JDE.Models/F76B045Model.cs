namespace JDE.Models;

/// <summary>
/// F76B045 - .
/// </summary>
public class F76B045Model
{
    /// <summary>
    /// SCB76LECO (Primary Key).
    /// </summary>
    public string SCB76LECO { get; set; }

    /// <summary>
    /// SCB76SCPI (Primary Key).
    /// </summary>
    public decimal SCB76SCPI { get; set; }

    /// <summary>
    /// SCB76SCPN.
    /// </summary>
    public string? SCB76SCPN { get; set; }

    /// <summary>
    /// SCUSER.
    /// </summary>
    public string? SCUSER { get; set; }

    /// <summary>
    /// SCPID.
    /// </summary>
    public string? SCPID { get; set; }

    /// <summary>
    /// SCJOBN.
    /// </summary>
    public string? SCJOBN { get; set; }

    /// <summary>
    /// SCUPMJ.
    /// </summary>
    public decimal? SCUPMJ { get; set; }

    /// <summary>
    /// SCUPMT.
    /// </summary>
    public decimal? SCUPMT { get; set; }
}
