namespace JDE.Models;

/// <summary>
/// F09525 - .
/// </summary>
public class F09525Model
{
    /// <summary>
    /// FBBNKAID (Primary Key).
    /// </summary>
    public string FBBNKAID { get; set; }

    /// <summary>
    /// FBSRCSYS (Primary Key).
    /// </summary>
    public string FBSRCSYS { get; set; }

    /// <summary>
    /// FBMCU.
    /// </summary>
    public string? FBMCU { get; set; }

    /// <summary>
    /// FBOBJ.
    /// </summary>
    public string? FBOBJ { get; set; }

    /// <summary>
    /// FBSUB.
    /// </summary>
    public string? FBSUB { get; set; }
}
