namespace JDE.Models;

/// <summary>
/// F74R5010 - .
/// </summary>
public class F74R5010Model
{
    /// <summary>
    /// RCCO (Primary Key).
    /// </summary>
    public string RCCO { get; set; }

    /// <summary>
    /// RCACL1 (Primary Key).
    /// </summary>
    public string RCACL1 { get; set; }

    /// <summary>
    /// RCACL2 (Primary Key).
    /// </summary>
    public string RCACL2 { get; set; }

    /// <summary>
    /// RCRVCD.
    /// </summary>
    public string? RCRVCD { get; set; }

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
    /// RCUPMT.
    /// </summary>
    public decimal? RCUPMT { get; set; }
}
