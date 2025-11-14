namespace JDE.Models;

/// <summary>
/// F08721 - .
/// </summary>
public class F08721Model
{
    /// <summary>
    /// SDSTCI (Primary Key).
    /// </summary>
    public decimal SDSTCI { get; set; }

    /// <summary>
    /// SDDTAI (Primary Key).
    /// </summary>
    public string SDDTAI { get; set; }

    /// <summary>
    /// SDOLDVAL.
    /// </summary>
    public string? SDOLDVAL { get; set; }

    /// <summary>
    /// SDNEWVAL.
    /// </summary>
    public string? SDNEWVAL { get; set; }

    /// <summary>
    /// SDUPMJ.
    /// </summary>
    public decimal? SDUPMJ { get; set; }

    /// <summary>
    /// SDUPMT.
    /// </summary>
    public decimal? SDUPMT { get; set; }

    /// <summary>
    /// SDUSER.
    /// </summary>
    public string? SDUSER { get; set; }

    /// <summary>
    /// SDPID.
    /// </summary>
    public string? SDPID { get; set; }

    /// <summary>
    /// SDJOBN.
    /// </summary>
    public string? SDJOBN { get; set; }

    /// <summary>
    /// SDSTCTY (Primary Key).
    /// </summary>
    public string SDSTCTY { get; set; }
}
