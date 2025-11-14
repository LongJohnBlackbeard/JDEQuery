namespace JDE.Models;

/// <summary>
/// F15L202 - .
/// </summary>
public class F15L202Model
{
    /// <summary>
    /// ASMCU (Primary Key).
    /// </summary>
    public string ASMCU { get; set; }

    /// <summary>
    /// ASRVNB (Primary Key).
    /// </summary>
    public decimal ASRVNB { get; set; }

    /// <summary>
    /// ASPLTYP (Primary Key).
    /// </summary>
    public string ASPLTYP { get; set; }

    /// <summary>
    /// ASARVNB (Primary Key).
    /// </summary>
    public string ASARVNB { get; set; }

    /// <summary>
    /// ASPLNME.
    /// </summary>
    public string? ASPLNME { get; set; }

    /// <summary>
    /// ASUSER.
    /// </summary>
    public string? ASUSER { get; set; }

    /// <summary>
    /// ASPID.
    /// </summary>
    public string? ASPID { get; set; }

    /// <summary>
    /// ASMKEY.
    /// </summary>
    public string? ASMKEY { get; set; }

    /// <summary>
    /// ASUPMJ.
    /// </summary>
    public decimal? ASUPMJ { get; set; }

    /// <summary>
    /// ASUPMT.
    /// </summary>
    public decimal? ASUPMT { get; set; }
}
