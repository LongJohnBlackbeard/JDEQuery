namespace JDE.Models;

/// <summary>
/// F0087 - .
/// </summary>
public class F0087Model
{
    /// <summary>
    /// EUENVN (Primary Key).
    /// </summary>
    public string EUENVN { get; set; }

    /// <summary>
    /// EUEDCO (Primary Key).
    /// </summary>
    public string EUEDCO { get; set; }

    /// <summary>
    /// EUBCO (Primary Key).
    /// </summary>
    public string EUBCO { get; set; }

    /// <summary>
    /// EUEFT.
    /// </summary>
    public decimal? EUEFT { get; set; }

    /// <summary>
    /// EUCRR.
    /// </summary>
    public decimal? EUCRR { get; set; }

    /// <summary>
    /// EUCRCM.
    /// </summary>
    public string? EUCRCM { get; set; }

    /// <summary>
    /// EUCRDC (Primary Key).
    /// </summary>
    public string EUCRDC { get; set; }
}
