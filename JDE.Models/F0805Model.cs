namespace JDE.Models;

/// <summary>
/// F0805 - .
/// </summary>
public class F0805Model
{
    /// <summary>
    /// EREXTSYS (Primary Key).
    /// </summary>
    public string EREXTSYS { get; set; }

    /// <summary>
    /// ERENTROLE (Primary Key).
    /// </summary>
    public string ERENTROLE { get; set; }

    /// <summary>
    /// ERDL01.
    /// </summary>
    public string? ERDL01 { get; set; }

    /// <summary>
    /// ERUSER.
    /// </summary>
    public string? ERUSER { get; set; }

    /// <summary>
    /// ERPID.
    /// </summary>
    public string? ERPID { get; set; }

    /// <summary>
    /// ERJOBN.
    /// </summary>
    public string? ERJOBN { get; set; }

    /// <summary>
    /// ERUPMJ.
    /// </summary>
    public decimal? ERUPMJ { get; set; }

    /// <summary>
    /// ERUPMT.
    /// </summary>
    public decimal? ERUPMT { get; set; }
}
