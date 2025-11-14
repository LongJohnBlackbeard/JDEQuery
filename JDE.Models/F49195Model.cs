namespace JDE.Models;

/// <summary>
/// F49195 - .
/// </summary>
public class F49195Model
{
    /// <summary>
    /// DUDSET (Primary Key).
    /// </summary>
    public string DUDSET { get; set; }

    /// <summary>
    /// DUDCCD (Primary Key).
    /// </summary>
    public string DUDCCD { get; set; }

    /// <summary>
    /// DUUSER.
    /// </summary>
    public string? DUUSER { get; set; }

    /// <summary>
    /// DUPID.
    /// </summary>
    public string? DUPID { get; set; }

    /// <summary>
    /// DUJOBN.
    /// </summary>
    public string? DUJOBN { get; set; }

    /// <summary>
    /// DUUPMJ.
    /// </summary>
    public decimal? DUUPMJ { get; set; }

    /// <summary>
    /// DUTDAY.
    /// </summary>
    public decimal? DUTDAY { get; set; }
}
