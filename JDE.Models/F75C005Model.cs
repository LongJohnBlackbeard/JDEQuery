namespace JDE.Models;

/// <summary>
/// F75C005 - .
/// </summary>
public class F75C005Model
{
    /// <summary>
    /// RFC75RID (Primary Key).
    /// </summary>
    public string RFC75RID { get; set; }

    /// <summary>
    /// RFC75SEQN (Primary Key).
    /// </summary>
    public decimal RFC75SEQN { get; set; }

    /// <summary>
    /// RFC75FSEQN (Primary Key).
    /// </summary>
    public decimal RFC75FSEQN { get; set; }

    /// <summary>
    /// RFC75OPN.
    /// </summary>
    public string? RFC75OPN { get; set; }

    /// <summary>
    /// RFUSER.
    /// </summary>
    public string? RFUSER { get; set; }

    /// <summary>
    /// RFPID.
    /// </summary>
    public string? RFPID { get; set; }

    /// <summary>
    /// RFJOBN.
    /// </summary>
    public string? RFJOBN { get; set; }

    /// <summary>
    /// RFUPMJ.
    /// </summary>
    public decimal? RFUPMJ { get; set; }

    /// <summary>
    /// RFUPMT.
    /// </summary>
    public decimal? RFUPMT { get; set; }
}
