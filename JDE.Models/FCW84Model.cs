namespace JDE.Models;

/// <summary>
/// FCW84 - .
/// </summary>
public class FCW84Model
{
    /// <summary>
    /// TRCRCD (Primary Key).
    /// </summary>
    public string TRCRCD { get; set; }

    /// <summary>
    /// TREFT (Primary Key).
    /// </summary>
    public decimal TREFT { get; set; }

    /// <summary>
    /// TRCRDC (Primary Key).
    /// </summary>
    public string TRCRDC { get; set; }

    /// <summary>
    /// TRCRR.
    /// </summary>
    public decimal? TRCRR { get; set; }

    /// <summary>
    /// TRCRRD.
    /// </summary>
    public decimal? TRCRRD { get; set; }
}
