namespace JDE.Models;

/// <summary>
/// F75T013 - .
/// </summary>
public class F75T013Model
{
    /// <summary>
    /// EACO (Primary Key).
    /// </summary>
    public string EACO { get; set; }

    /// <summary>
    /// EA75TDSI (Primary Key).
    /// </summary>
    public string EA75TDSI { get; set; }

    /// <summary>
    /// EAAID (Primary Key).
    /// </summary>
    public string EAAID { get; set; }

    /// <summary>
    /// EAUSER.
    /// </summary>
    public string? EAUSER { get; set; }

    /// <summary>
    /// EAPID.
    /// </summary>
    public string? EAPID { get; set; }

    /// <summary>
    /// EAJOBN.
    /// </summary>
    public string? EAJOBN { get; set; }

    /// <summary>
    /// EATDAY.
    /// </summary>
    public decimal? EATDAY { get; set; }

    /// <summary>
    /// EAUPMJ.
    /// </summary>
    public decimal? EAUPMJ { get; set; }
}
