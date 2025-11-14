namespace JDE.Models;

/// <summary>
/// F76B020 - .
/// </summary>
public class F76B020Model
{
    /// <summary>
    /// DBB76LECO (Primary Key).
    /// </summary>
    public string DBB76LECO { get; set; }

    /// <summary>
    /// DBAN8 (Primary Key).
    /// </summary>
    public decimal DBAN8 { get; set; }

    /// <summary>
    /// DBB76DETY.
    /// </summary>
    public string? DBB76DETY { get; set; }

    /// <summary>
    /// DBUSER.
    /// </summary>
    public string? DBUSER { get; set; }

    /// <summary>
    /// DBPID.
    /// </summary>
    public string? DBPID { get; set; }

    /// <summary>
    /// DBJOBN.
    /// </summary>
    public string? DBJOBN { get; set; }

    /// <summary>
    /// DBUPMJ.
    /// </summary>
    public decimal? DBUPMJ { get; set; }

    /// <summary>
    /// DBUPMT.
    /// </summary>
    public decimal? DBUPMT { get; set; }
}
