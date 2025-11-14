namespace JDE.Models;

/// <summary>
/// F13907P - .
/// </summary>
public class F13907PModel
{
    /// <summary>
    /// FCNUMB (Primary Key).
    /// </summary>
    public decimal FCNUMB { get; set; }

    /// <summary>
    /// FCSHNO (Primary Key).
    /// </summary>
    public string FCSHNO { get; set; }

    /// <summary>
    /// FCSRVT (Primary Key).
    /// </summary>
    public string FCSRVT { get; set; }

    /// <summary>
    /// FCTHPC.
    /// </summary>
    public decimal? FCTHPC { get; set; }

    /// <summary>
    /// FCTHD.
    /// </summary>
    public decimal? FCTHD { get; set; }

    /// <summary>
    /// FCSWO.
    /// </summary>
    public string? FCSWO { get; set; }

    /// <summary>
    /// FCSRST.
    /// </summary>
    public string? FCSRST { get; set; }
}
