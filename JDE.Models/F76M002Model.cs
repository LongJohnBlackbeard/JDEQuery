namespace JDE.Models;

/// <summary>
/// F76M002 - .
/// </summary>
public class F76M002Model
{
    /// <summary>
    /// WCM76WCON (Primary Key).
    /// </summary>
    public string WCM76WCON { get; set; }

    /// <summary>
    /// WCDESC.
    /// </summary>
    public string? WCDESC { get; set; }

    /// <summary>
    /// WCM76LCON.
    /// </summary>
    public string? WCM76LCON { get; set; }

    /// <summary>
    /// WCM76WHTP (Primary Key).
    /// </summary>
    public string WCM76WHTP { get; set; }

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
    /// WCUPMT.
    /// </summary>
    public decimal? WCUPMT { get; set; }
}
