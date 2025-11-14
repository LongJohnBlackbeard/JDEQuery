namespace JDE.Models;

/// <summary>
/// F77180 - .
/// </summary>
public class F77180Model
{
    /// <summary>
    /// J1FORMSID (Primary Key).
    /// </summary>
    public decimal J1FORMSID { get; set; }

    /// <summary>
    /// J1FORMD.
    /// </summary>
    public string? J1FORMD { get; set; }

    /// <summary>
    /// J1BOXN (Primary Key).
    /// </summary>
    public string J1BOXN { get; set; }

    /// <summary>
    /// J1BOXD.
    /// </summary>
    public string? J1BOXD { get; set; }

    /// <summary>
    /// J1UPMJ.
    /// </summary>
    public decimal? J1UPMJ { get; set; }

    /// <summary>
    /// J1UPMT.
    /// </summary>
    public decimal? J1UPMT { get; set; }

    /// <summary>
    /// J1PID.
    /// </summary>
    public string? J1PID { get; set; }

    /// <summary>
    /// J1JOBN.
    /// </summary>
    public string? J1JOBN { get; set; }

    /// <summary>
    /// J1USER.
    /// </summary>
    public string? J1USER { get; set; }
}
