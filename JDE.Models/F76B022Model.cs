namespace JDE.Models;

/// <summary>
/// F76B022 - .
/// </summary>
public class F76B022Model
{
    /// <summary>
    /// IDB76IDOC (Primary Key).
    /// </summary>
    public string IDB76IDOC { get; set; }

    /// <summary>
    /// IDB76IDCT (Primary Key).
    /// </summary>
    public string IDB76IDCT { get; set; }

    /// <summary>
    /// IDB76IDLN.
    /// </summary>
    public string? IDB76IDLN { get; set; }

    /// <summary>
    /// IDUSER.
    /// </summary>
    public string? IDUSER { get; set; }

    /// <summary>
    /// IDPID.
    /// </summary>
    public string? IDPID { get; set; }

    /// <summary>
    /// IDJOBN.
    /// </summary>
    public string? IDJOBN { get; set; }

    /// <summary>
    /// IDUPMJ.
    /// </summary>
    public decimal? IDUPMJ { get; set; }

    /// <summary>
    /// IDUPMT.
    /// </summary>
    public decimal? IDUPMT { get; set; }
}
