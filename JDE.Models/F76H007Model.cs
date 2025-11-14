namespace JDE.Models;

/// <summary>
/// F76H007 - .
/// </summary>
public class F76H007Model
{
    /// <summary>
    /// LIH76LECO (Primary Key).
    /// </summary>
    public string LIH76LECO { get; set; }

    /// <summary>
    /// LIH76LEDT (Primary Key).
    /// </summary>
    public string LIH76LEDT { get; set; }

    /// <summary>
    /// LIH76IDFR.
    /// </summary>
    public string? LIH76IDFR { get; set; }

    /// <summary>
    /// LIUSER.
    /// </summary>
    public string? LIUSER { get; set; }

    /// <summary>
    /// LIPID.
    /// </summary>
    public string? LIPID { get; set; }

    /// <summary>
    /// LIJOBN.
    /// </summary>
    public string? LIJOBN { get; set; }

    /// <summary>
    /// LIUPMJ.
    /// </summary>
    public decimal? LIUPMJ { get; set; }

    /// <summary>
    /// LIUPMT.
    /// </summary>
    public decimal? LIUPMT { get; set; }
}
