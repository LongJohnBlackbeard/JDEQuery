namespace JDE.Models;

/// <summary>
/// F460151 - .
/// </summary>
public class F460151Model
{
    /// <summary>
    /// MSITM (Primary Key).
    /// </summary>
    public decimal MSITM { get; set; }

    /// <summary>
    /// MSMCU (Primary Key).
    /// </summary>
    public string MSMCU { get; set; }

    /// <summary>
    /// MSMPGP.
    /// </summary>
    public string? MSMPGP { get; set; }

    /// <summary>
    /// MSUSER.
    /// </summary>
    public string? MSUSER { get; set; }

    /// <summary>
    /// MSPID.
    /// </summary>
    public string? MSPID { get; set; }

    /// <summary>
    /// MSJOBN.
    /// </summary>
    public string? MSJOBN { get; set; }

    /// <summary>
    /// MSUTIME.
    /// </summary>
    public DateTime? MSUTIME { get; set; }
}
