namespace JDE.Models;

/// <summary>
/// F98311 - .
/// </summary>
public class F98311Model
{
    /// <summary>
    /// DHPID (Primary Key).
    /// </summary>
    public string DHPID { get; set; }

    /// <summary>
    /// DHVERS (Primary Key).
    /// </summary>
    public string DHVERS { get; set; }

    /// <summary>
    /// DHSQN (Primary Key).
    /// </summary>
    public decimal DHSQN { get; set; }

    /// <summary>
    /// DHTXT1.
    /// </summary>
    public string? DHTXT1 { get; set; }
}
