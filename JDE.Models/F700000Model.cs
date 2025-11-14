namespace JDE.Models;

/// <summary>
/// F700000 - .
/// </summary>
public class F700000Model
{
    /// <summary>
    /// FCLCTR (Primary Key).
    /// </summary>
    public string FCLCTR { get; set; }

    /// <summary>
    /// FCK70FCTR (Primary Key).
    /// </summary>
    public string FCK70FCTR { get; set; }

    /// <summary>
    /// FCUSER.
    /// </summary>
    public string? FCUSER { get; set; }

    /// <summary>
    /// FCUPMJ.
    /// </summary>
    public decimal? FCUPMJ { get; set; }

    /// <summary>
    /// FCUPMT.
    /// </summary>
    public decimal? FCUPMT { get; set; }

    /// <summary>
    /// FCJOBN.
    /// </summary>
    public string? FCJOBN { get; set; }

    /// <summary>
    /// FCPID.
    /// </summary>
    public string? FCPID { get; set; }
}
