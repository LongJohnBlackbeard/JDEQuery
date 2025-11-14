namespace JDE.Models;

/// <summary>
/// F01RS01W - .
/// </summary>
public class F01RS01WModel
{
    /// <summary>
    /// THSESSID (Primary Key).
    /// </summary>
    public string THSESSID { get; set; }

    /// <summary>
    /// THRLTYPE (Primary Key).
    /// </summary>
    public string THRLTYPE { get; set; }

    /// <summary>
    /// THTASKID.
    /// </summary>
    public string? THTASKID { get; set; }

    /// <summary>
    /// THTASKNM.
    /// </summary>
    public string? THTASKNM { get; set; }

    /// <summary>
    /// THLNGTASK.
    /// </summary>
    public string? THLNGTASK { get; set; }

    /// <summary>
    /// THTASKTYPE.
    /// </summary>
    public string? THTASKTYPE { get; set; }
}
