namespace JDE.Models;

/// <summary>
/// F98TC03 - .
/// </summary>
public class F98TC03Model
{
    /// <summary>
    /// TNMCU (Primary Key).
    /// </summary>
    public string TNMCU { get; set; }

    /// <summary>
    /// TNITM (Primary Key).
    /// </summary>
    public decimal TNITM { get; set; }

    /// <summary>
    /// TNLOCN (Primary Key).
    /// </summary>
    public string TNLOCN { get; set; }

    /// <summary>
    /// TNLOTN (Primary Key).
    /// </summary>
    public string TNLOTN { get; set; }

    /// <summary>
    /// TNCSDJ.
    /// </summary>
    public decimal? TNCSDJ { get; set; }

    /// <summary>
    /// TNDLR.
    /// </summary>
    public decimal? TNDLR { get; set; }
}
