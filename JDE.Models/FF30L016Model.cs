namespace JDE.Models;

/// <summary>
/// FF30L016 - .
/// </summary>
public class FF30L016Model
{
    /// <summary>
    /// DBTERM (Primary Key).
    /// </summary>
    public string DBTERM { get; set; }

    /// <summary>
    /// DBFSCID.
    /// </summary>
    public decimal? DBFSCID { get; set; }

    /// <summary>
    /// DBDFMCU.
    /// </summary>
    public string? DBDFMCU { get; set; }

    /// <summary>
    /// DBUSER.
    /// </summary>
    public string? DBUSER { get; set; }

    /// <summary>
    /// DBPID.
    /// </summary>
    public string? DBPID { get; set; }

    /// <summary>
    /// DBMKEY.
    /// </summary>
    public string? DBMKEY { get; set; }

    /// <summary>
    /// DBUUPMJ.
    /// </summary>
    public DateTime? DBUUPMJ { get; set; }
}
