namespace JDE.Models;

/// <summary>
/// F75I103 - .
/// </summary>
public class F75I103Model
{
    /// <summary>
    /// TACO (Primary Key).
    /// </summary>
    public string TACO { get; set; }

    /// <summary>
    /// TAI75QNO (Primary Key).
    /// </summary>
    public string TAI75QNO { get; set; }

    /// <summary>
    /// TAFYR (Primary Key).
    /// </summary>
    public decimal TAFYR { get; set; }

    /// <summary>
    /// TAI75TXRG (Primary Key).
    /// </summary>
    public string TAI75TXRG { get; set; }

    /// <summary>
    /// TAI75ACK.
    /// </summary>
    public string? TAI75ACK { get; set; }

    /// <summary>
    /// TAI75TOFF.
    /// </summary>
    public string? TAI75TOFF { get; set; }

    /// <summary>
    /// TAPID.
    /// </summary>
    public string? TAPID { get; set; }

    /// <summary>
    /// TAUSER.
    /// </summary>
    public string? TAUSER { get; set; }

    /// <summary>
    /// TAUPMJ.
    /// </summary>
    public decimal? TAUPMJ { get; set; }

    /// <summary>
    /// TAJOBN.
    /// </summary>
    public string? TAJOBN { get; set; }

    /// <summary>
    /// TAUPMT.
    /// </summary>
    public decimal? TAUPMT { get; set; }
}
