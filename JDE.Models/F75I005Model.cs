namespace JDE.Models;

/// <summary>
/// F75I005 - .
/// </summary>
public class F75I005Model
{
    /// <summary>
    /// TGI75TXTY (Primary Key).
    /// </summary>
    public string TGI75TXTY { get; set; }

    /// <summary>
    /// TGI75TXRG (Primary Key).
    /// </summary>
    public string TGI75TXRG { get; set; }

    /// <summary>
    /// TGI75TXR.
    /// </summary>
    public decimal? TGI75TXR { get; set; }

    /// <summary>
    /// TGUSER.
    /// </summary>
    public string? TGUSER { get; set; }

    /// <summary>
    /// TGPID.
    /// </summary>
    public string? TGPID { get; set; }

    /// <summary>
    /// TGUPMJ.
    /// </summary>
    public decimal? TGUPMJ { get; set; }

    /// <summary>
    /// TGUPMT.
    /// </summary>
    public decimal? TGUPMT { get; set; }

    /// <summary>
    /// TGJOBN.
    /// </summary>
    public string? TGJOBN { get; set; }
}
