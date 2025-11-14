namespace JDE.Models;

/// <summary>
/// FCW54 - .
/// </summary>
public class FCW54Model
{
    /// <summary>
    /// WBJOBS (Primary Key).
    /// </summary>
    public decimal WBJOBS { get; set; }

    /// <summary>
    /// WBUSER (Primary Key).
    /// </summary>
    public string WBUSER { get; set; }

    /// <summary>
    /// WBITM (Primary Key).
    /// </summary>
    public decimal WBITM { get; set; }

    /// <summary>
    /// WBQTFN.
    /// </summary>
    public decimal? WBQTFN { get; set; }
}
