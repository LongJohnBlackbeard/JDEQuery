namespace JDE.Models;

/// <summary>
/// F1113 - .
/// </summary>
public class F1113Model
{
    /// <summary>
    /// C1RTTY (Primary Key).
    /// </summary>
    public string C1RTTY { get; set; }

    /// <summary>
    /// C1CRDC (Primary Key).
    /// </summary>
    public string C1CRDC { get; set; }

    /// <summary>
    /// C1CRCD (Primary Key).
    /// </summary>
    public string C1CRCD { get; set; }

    /// <summary>
    /// C1EFT (Primary Key).
    /// </summary>
    public decimal C1EFT { get; set; }

    /// <summary>
    /// C1CRR.
    /// </summary>
    public decimal? C1CRR { get; set; }

    /// <summary>
    /// C1CRRD.
    /// </summary>
    public decimal? C1CRRD { get; set; }
}
