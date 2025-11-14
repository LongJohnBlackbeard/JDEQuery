namespace JDE.Models;

/// <summary>
/// F4802H - .
/// </summary>
public class F4802HModel
{
    /// <summary>
    /// WCDOCO (Primary Key).
    /// </summary>
    public decimal WCDOCO { get; set; }

    /// <summary>
    /// WCDCTO (Primary Key).
    /// </summary>
    public string WCDCTO { get; set; }

    /// <summary>
    /// WCSFXO (Primary Key).
    /// </summary>
    public string WCSFXO { get; set; }

    /// <summary>
    /// WCTYPR (Primary Key).
    /// </summary>
    public string WCTYPR { get; set; }

    /// <summary>
    /// WCUSER.
    /// </summary>
    public string? WCUSER { get; set; }

    /// <summary>
    /// WCPID.
    /// </summary>
    public string? WCPID { get; set; }

    /// <summary>
    /// WCJOBN.
    /// </summary>
    public string? WCJOBN { get; set; }

    /// <summary>
    /// WCUPMJ.
    /// </summary>
    public decimal? WCUPMJ { get; set; }

    /// <summary>
    /// WCTDAY.
    /// </summary>
    public decimal? WCTDAY { get; set; }
}
