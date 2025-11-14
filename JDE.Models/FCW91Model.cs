namespace JDE.Models;

/// <summary>
/// FCW91 - .
/// </summary>
public class FCW91Model
{
    /// <summary>
    /// C9JOBS (Primary Key).
    /// </summary>
    public decimal C9JOBS { get; set; }

    /// <summary>
    /// C9DOCO (Primary Key).
    /// </summary>
    public decimal C9DOCO { get; set; }

    /// <summary>
    /// C9DCTO (Primary Key).
    /// </summary>
    public string C9DCTO { get; set; }

    /// <summary>
    /// C9LNID (Primary Key).
    /// </summary>
    public decimal C9LNID { get; set; }

    /// <summary>
    /// C9KCOO (Primary Key).
    /// </summary>
    public string C9KCOO { get; set; }

    /// <summary>
    /// C9LTTR.
    /// </summary>
    public string? C9LTTR { get; set; }

    /// <summary>
    /// C9NXTR.
    /// </summary>
    public string? C9NXTR { get; set; }

    /// <summary>
    /// C9WRTH.
    /// </summary>
    public string? C9WRTH { get; set; }
}
