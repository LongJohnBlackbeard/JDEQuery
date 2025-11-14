namespace JDE.Models;

/// <summary>
/// F05121 - .
/// </summary>
public class F05121Model
{
    /// <summary>
    /// CRCUCD (Primary Key).
    /// </summary>
    public string CRCUCD { get; set; }

    /// <summary>
    /// CRINEC (Primary Key).
    /// </summary>
    public string CRINEC { get; set; }

    /// <summary>
    /// CRCMPE (Primary Key).
    /// </summary>
    public string CRCMPE { get; set; }

    /// <summary>
    /// CRCMPC (Primary Key).
    /// </summary>
    public string CRCMPC { get; set; }

    /// <summary>
    /// CRUSER.
    /// </summary>
    public string? CRUSER { get; set; }

    /// <summary>
    /// CRPID.
    /// </summary>
    public string? CRPID { get; set; }

    /// <summary>
    /// CRJOBN.
    /// </summary>
    public string? CRJOBN { get; set; }

    /// <summary>
    /// CRUPMJ.
    /// </summary>
    public decimal? CRUPMJ { get; set; }

    /// <summary>
    /// CRUPMT.
    /// </summary>
    public decimal? CRUPMT { get; set; }
}
