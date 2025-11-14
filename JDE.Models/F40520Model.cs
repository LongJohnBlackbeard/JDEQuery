namespace JDE.Models;

/// <summary>
/// F40520 - .
/// </summary>
public class F40520Model
{
    /// <summary>
    /// SCAN8V (Primary Key).
    /// </summary>
    public decimal SCAN8V { get; set; }

    /// <summary>
    /// SCMCU (Primary Key).
    /// </summary>
    public string SCMCU { get; set; }

    /// <summary>
    /// SCCMDCDE (Primary Key).
    /// </summary>
    public string SCCMDCDE { get; set; }

    /// <summary>
    /// SCCMDDFT.
    /// </summary>
    public string? SCCMDDFT { get; set; }

    /// <summary>
    /// SCUSER.
    /// </summary>
    public string? SCUSER { get; set; }

    /// <summary>
    /// SCPID.
    /// </summary>
    public string? SCPID { get; set; }

    /// <summary>
    /// SCJOBN.
    /// </summary>
    public string? SCJOBN { get; set; }

    /// <summary>
    /// SCUPMT.
    /// </summary>
    public decimal? SCUPMT { get; set; }

    /// <summary>
    /// SCUPMJ.
    /// </summary>
    public decimal? SCUPMJ { get; set; }
}
