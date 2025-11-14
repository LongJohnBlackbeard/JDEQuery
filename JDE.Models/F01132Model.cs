namespace JDE.Models;

/// <summary>
/// F01132 - .
/// </summary>
public class F01132Model
{
    /// <summary>
    /// CYSERK (Primary Key).
    /// </summary>
    public decimal CYSERK { get; set; }

    /// <summary>
    /// CYLIN (Primary Key).
    /// </summary>
    public decimal CYLIN { get; set; }

    /// <summary>
    /// CYWTXT.
    /// </summary>
    public string? CYWTXT { get; set; }

    /// <summary>
    /// CYCMDF (Primary Key).
    /// </summary>
    public string CYCMDF { get; set; }

    /// <summary>
    /// CYUPMJ.
    /// </summary>
    public decimal? CYUPMJ { get; set; }

    /// <summary>
    /// CYENTT.
    /// </summary>
    public decimal? CYENTT { get; set; }
}
