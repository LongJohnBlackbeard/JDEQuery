namespace JDE.Models;

/// <summary>
/// F46821 - .
/// </summary>
public class F46821Model
{
    /// <summary>
    /// LXMCU (Primary Key).
    /// </summary>
    public string LXMCU { get; set; }

    /// <summary>
    /// LXSRUL (Primary Key).
    /// </summary>
    public string LXSRUL { get; set; }

    /// <summary>
    /// LXLOCN (Primary Key).
    /// </summary>
    public string LXLOCN { get; set; }

    /// <summary>
    /// LXSEQ (Primary Key).
    /// </summary>
    public decimal LXSEQ { get; set; }

    /// <summary>
    /// LXUSER.
    /// </summary>
    public string? LXUSER { get; set; }

    /// <summary>
    /// LXUPMJ.
    /// </summary>
    public decimal? LXUPMJ { get; set; }

    /// <summary>
    /// LXTDAY.
    /// </summary>
    public decimal? LXTDAY { get; set; }
}
