namespace JDE.Models;

/// <summary>
/// F410211 - .
/// </summary>
public class F410211Model
{
    /// <summary>
    /// PCMCU (Primary Key).
    /// </summary>
    public string PCMCU { get; set; }

    /// <summary>
    /// PCPRJM (Primary Key).
    /// </summary>
    public decimal PCPRJM { get; set; }

    /// <summary>
    /// PCDOCO (Primary Key).
    /// </summary>
    public decimal PCDOCO { get; set; }

    /// <summary>
    /// PCITM (Primary Key).
    /// </summary>
    public decimal PCITM { get; set; }

    /// <summary>
    /// PCLOCN (Primary Key).
    /// </summary>
    public string PCLOCN { get; set; }

    /// <summary>
    /// PCLOTN (Primary Key).
    /// </summary>
    public string PCLOTN { get; set; }

    /// <summary>
    /// PCPJCM.
    /// </summary>
    public decimal? PCPJCM { get; set; }

    /// <summary>
    /// PCPJDM.
    /// </summary>
    public decimal? PCPJDM { get; set; }
}
