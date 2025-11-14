namespace JDE.Models;

/// <summary>
/// F75IUI13 - .
/// </summary>
public class F75IUI13Model
{
    /// <summary>
    /// TCPYID.
    /// </summary>
    public decimal? TCPYID { get; set; }

    /// <summary>
    /// TCI75TSCT.
    /// </summary>
    public string? TCI75TSCT { get; set; }

    /// <summary>
    /// TCI75TSAPF.
    /// </summary>
    public string? TCI75TSAPF { get; set; }

    /// <summary>
    /// TCJOBS (Primary Key).
    /// </summary>
    public decimal TCJOBS { get; set; }

    /// <summary>
    /// TCUSER (Primary Key).
    /// </summary>
    public string TCUSER { get; set; }

    /// <summary>
    /// TCPID.
    /// </summary>
    public string? TCPID { get; set; }

    /// <summary>
    /// TCJOBN.
    /// </summary>
    public string? TCJOBN { get; set; }

    /// <summary>
    /// TCUPMJ.
    /// </summary>
    public decimal? TCUPMJ { get; set; }

    /// <summary>
    /// TCUPMT.
    /// </summary>
    public decimal? TCUPMT { get; set; }
}
