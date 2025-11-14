namespace JDE.Models;

/// <summary>
/// F77190 - .
/// </summary>
public class F77190Model
{
    /// <summary>
    /// J2TAXYR (Primary Key).
    /// </summary>
    public decimal J2TAXYR { get; set; }

    /// <summary>
    /// J2FORMSID (Primary Key).
    /// </summary>
    public decimal J2FORMSID { get; set; }

    /// <summary>
    /// J2BOXN (Primary Key).
    /// </summary>
    public string J2BOXN { get; set; }

    /// <summary>
    /// J2CQ (Primary Key).
    /// </summary>
    public string J2CQ { get; set; }

    /// <summary>
    /// J2CASEO (Primary Key).
    /// </summary>
    public string J2CASEO { get; set; }

    /// <summary>
    /// J2PDBA (Primary Key).
    /// </summary>
    public decimal J2PDBA { get; set; }

    /// <summary>
    /// J2UPMJ.
    /// </summary>
    public decimal? J2UPMJ { get; set; }

    /// <summary>
    /// J2UPMT.
    /// </summary>
    public decimal? J2UPMT { get; set; }

    /// <summary>
    /// J2PID.
    /// </summary>
    public string? J2PID { get; set; }

    /// <summary>
    /// J2JOBN.
    /// </summary>
    public string? J2JOBN { get; set; }

    /// <summary>
    /// J2USER.
    /// </summary>
    public string? J2USER { get; set; }
}
