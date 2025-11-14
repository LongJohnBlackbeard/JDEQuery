namespace JDE.Models;

/// <summary>
/// F75I3061 - .
/// </summary>
public class F75I3061Model
{
    /// <summary>
    /// ECYEXU (Primary Key).
    /// </summary>
    public decimal ECYEXU { get; set; }

    /// <summary>
    /// ECI75TXTY (Primary Key).
    /// </summary>
    public string ECI75TXTY { get; set; }

    /// <summary>
    /// ECAID.
    /// </summary>
    public string? ECAID { get; set; }

    /// <summary>
    /// ECPID.
    /// </summary>
    public string? ECPID { get; set; }

    /// <summary>
    /// ECJOBN.
    /// </summary>
    public string? ECJOBN { get; set; }

    /// <summary>
    /// ECUPMJ.
    /// </summary>
    public decimal? ECUPMJ { get; set; }

    /// <summary>
    /// ECUPMT.
    /// </summary>
    public decimal? ECUPMT { get; set; }

    /// <summary>
    /// ECUSER.
    /// </summary>
    public string? ECUSER { get; set; }
}
