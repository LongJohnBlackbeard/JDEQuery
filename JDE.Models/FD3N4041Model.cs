namespace JDE.Models;

/// <summary>
/// FD3N4041 - .
/// </summary>
public class FD3N4041Model
{
    /// <summary>
    /// CDCYNO (Primary Key).
    /// </summary>
    public decimal CDCYNO { get; set; }

    /// <summary>
    /// CDCNID (Primary Key).
    /// </summary>
    public string CDCNID { get; set; }

    /// <summary>
    /// CDITM (Primary Key).
    /// </summary>
    public decimal CDITM { get; set; }

    /// <summary>
    /// CDLOTN (Primary Key).
    /// </summary>
    public string CDLOTN { get; set; }

    /// <summary>
    /// CDLOCN.
    /// </summary>
    public string? CDLOCN { get; set; }

    /// <summary>
    /// CDTAOH.
    /// </summary>
    public decimal? CDTAOH { get; set; }

    /// <summary>
    /// CDTACT.
    /// </summary>
    public decimal? CDTACT { get; set; }

    /// <summary>
    /// CDUM.
    /// </summary>
    public string? CDUM { get; set; }

    /// <summary>
    /// CDPTUPUSER.
    /// </summary>
    public string? CDPTUPUSER { get; set; }

    /// <summary>
    /// CDPTUPDTTM.
    /// </summary>
    public string? CDPTUPDTTM { get; set; }
}
