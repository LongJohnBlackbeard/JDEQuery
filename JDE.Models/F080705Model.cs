namespace JDE.Models;

/// <summary>
/// F080705 - .
/// </summary>
public class F080705Model
{
    /// <summary>
    /// FTCONFID (Primary Key).
    /// </summary>
    public decimal FTCONFID { get; set; }

    /// <summary>
    /// FTTRNTY (Primary Key).
    /// </summary>
    public string FTTRNTY { get; set; }

    /// <summary>
    /// FTTRNST.
    /// </summary>
    public string? FTTRNST { get; set; }

    /// <summary>
    /// FTZIPFN.
    /// </summary>
    public string? FTZIPFN { get; set; }

    /// <summary>
    /// FTUSER.
    /// </summary>
    public string? FTUSER { get; set; }

    /// <summary>
    /// FTUPMJ.
    /// </summary>
    public decimal? FTUPMJ { get; set; }

    /// <summary>
    /// FTUPMT.
    /// </summary>
    public decimal? FTUPMT { get; set; }

    /// <summary>
    /// FTJOBN.
    /// </summary>
    public string? FTJOBN { get; set; }

    /// <summary>
    /// FTPID.
    /// </summary>
    public string? FTPID { get; set; }

    /// <summary>
    /// FTLINENUM (Primary Key).
    /// </summary>
    public decimal FTLINENUM { get; set; }
}
