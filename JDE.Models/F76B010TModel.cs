namespace JDE.Models;

/// <summary>
/// F76B010T - .
/// </summary>
public class F76B010TModel
{
    /// <summary>
    /// EDB76LECO (Primary Key).
    /// </summary>
    public string EDB76LECO { get; set; }

    /// <summary>
    /// EDB76BECD.
    /// </summary>
    public string? EDB76BECD { get; set; }

    /// <summary>
    /// EDUSER.
    /// </summary>
    public string? EDUSER { get; set; }

    /// <summary>
    /// EDPID.
    /// </summary>
    public string? EDPID { get; set; }

    /// <summary>
    /// EDJOBN.
    /// </summary>
    public string? EDJOBN { get; set; }

    /// <summary>
    /// EDUPMJ.
    /// </summary>
    public decimal? EDUPMJ { get; set; }

    /// <summary>
    /// EDUPMT.
    /// </summary>
    public decimal? EDUPMT { get; set; }
}
