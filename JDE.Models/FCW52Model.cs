namespace JDE.Models;

/// <summary>
/// FCW52 - .
/// </summary>
public class FCW52Model
{
    /// <summary>
    /// RCKIT (Primary Key).
    /// </summary>
    public decimal RCKIT { get; set; }

    /// <summary>
    /// RCMMCU (Primary Key).
    /// </summary>
    public string RCMMCU { get; set; }

    /// <summary>
    /// RCTRT (Primary Key).
    /// </summary>
    public string RCTRT { get; set; }

    /// <summary>
    /// RCBQTY (Primary Key).
    /// </summary>
    public decimal RCBQTY { get; set; }

    /// <summary>
    /// RCITM (Primary Key).
    /// </summary>
    public decimal RCITM { get; set; }

    /// <summary>
    /// RCUSER.
    /// </summary>
    public string? RCUSER { get; set; }

    /// <summary>
    /// RCPID.
    /// </summary>
    public string? RCPID { get; set; }

    /// <summary>
    /// RCJOBN.
    /// </summary>
    public string? RCJOBN { get; set; }

    /// <summary>
    /// RCUPMJ.
    /// </summary>
    public decimal? RCUPMJ { get; set; }

    /// <summary>
    /// RCTDAY.
    /// </summary>
    public decimal? RCTDAY { get; set; }

    /// <summary>
    /// RCC9STS.
    /// </summary>
    public string? RCC9STS { get; set; }
}
