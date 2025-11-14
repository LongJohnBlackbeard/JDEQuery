namespace JDE.Models;

/// <summary>
/// F051428 - .
/// </summary>
public class F051428Model
{
    /// <summary>
    /// RWGRPNAME (Primary Key).
    /// </summary>
    public string RWGRPNAME { get; set; }

    /// <summary>
    /// RWWORDID (Primary Key).
    /// </summary>
    public decimal RWWORDID { get; set; }

    /// <summary>
    /// RWUSER.
    /// </summary>
    public string? RWUSER { get; set; }

    /// <summary>
    /// RWPID.
    /// </summary>
    public string? RWPID { get; set; }

    /// <summary>
    /// RWMKEY.
    /// </summary>
    public string? RWMKEY { get; set; }

    /// <summary>
    /// RWUPMJ.
    /// </summary>
    public decimal? RWUPMJ { get; set; }

    /// <summary>
    /// RWUPMT.
    /// </summary>
    public decimal? RWUPMT { get; set; }
}
