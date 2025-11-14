namespace JDE.Models;

/// <summary>
/// F08351 - .
/// </summary>
public class F08351Model
{
    /// <summary>
    /// BUDIVC (Primary Key).
    /// </summary>
    public string BUDIVC { get; set; }

    /// <summary>
    /// BUSBGR (Primary Key).
    /// </summary>
    public string BUSBGR { get; set; }

    /// <summary>
    /// BUPLAN (Primary Key).
    /// </summary>
    public string BUPLAN { get; set; }

    /// <summary>
    /// BUMANP.
    /// </summary>
    public string? BUMANP { get; set; }

    /// <summary>
    /// BUEFT (Primary Key).
    /// </summary>
    public decimal BUEFT { get; set; }

    /// <summary>
    /// BUEFTE.
    /// </summary>
    public decimal? BUEFTE { get; set; }

    /// <summary>
    /// BUXDFP.
    /// </summary>
    public string? BUXDFP { get; set; }
}
