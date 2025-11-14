namespace JDE.Models;

/// <summary>
/// F70UI006 - .
/// </summary>
public class F70UI006Model
{
    /// <summary>
    /// MTJOBS (Primary Key).
    /// </summary>
    public decimal MTJOBS { get; set; }

    /// <summary>
    /// MTSPHD (Primary Key).
    /// </summary>
    public string MTSPHD { get; set; }

    /// <summary>
    /// MTDL01.
    /// </summary>
    public string? MTDL01 { get; set; }

    /// <summary>
    /// MTUSER (Primary Key).
    /// </summary>
    public string MTUSER { get; set; }

    /// <summary>
    /// MTPID.
    /// </summary>
    public string? MTPID { get; set; }

    /// <summary>
    /// MTJOBN.
    /// </summary>
    public string? MTJOBN { get; set; }

    /// <summary>
    /// MTUPMJ.
    /// </summary>
    public decimal? MTUPMJ { get; set; }

    /// <summary>
    /// MTUPMT.
    /// </summary>
    public decimal? MTUPMT { get; set; }
}
