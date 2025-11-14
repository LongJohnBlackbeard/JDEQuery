namespace JDE.Models;

/// <summary>
/// F7000100 - .
/// </summary>
public class F7000100Model
{
    /// <summary>
    /// AFLCTR (Primary Key).
    /// </summary>
    public string AFLCTR { get; set; }

    /// <summary>
    /// AFK70ADSTR (Primary Key).
    /// </summary>
    public string AFK70ADSTR { get; set; }

    /// <summary>
    /// AFK70ADOBN (Primary Key).
    /// </summary>
    public string AFK70ADOBN { get; set; }

    /// <summary>
    /// AFK70ADOBR.
    /// </summary>
    public string? AFK70ADOBR { get; set; }

    /// <summary>
    /// AFUSER.
    /// </summary>
    public string? AFUSER { get; set; }

    /// <summary>
    /// AFPID.
    /// </summary>
    public string? AFPID { get; set; }

    /// <summary>
    /// AFJOBN.
    /// </summary>
    public string? AFJOBN { get; set; }

    /// <summary>
    /// AFUPMT.
    /// </summary>
    public decimal? AFUPMT { get; set; }

    /// <summary>
    /// AFUPMJ.
    /// </summary>
    public decimal? AFUPMJ { get; set; }
}
