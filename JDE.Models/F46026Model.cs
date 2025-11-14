namespace JDE.Models;

/// <summary>
/// F46026 - .
/// </summary>
public class F46026Model
{
    /// <summary>
    /// ACMCU (Primary Key).
    /// </summary>
    public string ACMCU { get; set; }

    /// <summary>
    /// ACLOCN (Primary Key).
    /// </summary>
    public string ACLOCN { get; set; }

    /// <summary>
    /// ACEQTY (Primary Key).
    /// </summary>
    public string ACEQTY { get; set; }

    /// <summary>
    /// ACUSER.
    /// </summary>
    public string? ACUSER { get; set; }

    /// <summary>
    /// ACUPMJ.
    /// </summary>
    public decimal? ACUPMJ { get; set; }

    /// <summary>
    /// ACTDAY.
    /// </summary>
    public decimal? ACTDAY { get; set; }
}
