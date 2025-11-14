namespace JDE.Models;

/// <summary>
/// F90CE01A - .
/// </summary>
public class F90CE01AModel
{
    /// <summary>
    /// WOSLTNID (Primary Key).
    /// </summary>
    public decimal WOSLTNID { get; set; }

    /// <summary>
    /// WODOCO (Primary Key).
    /// </summary>
    public decimal WODOCO { get; set; }

    /// <summary>
    /// WOENTDBY.
    /// </summary>
    public decimal? WOENTDBY { get; set; }

    /// <summary>
    /// WOEDATE.
    /// </summary>
    public DateTime? WOEDATE { get; set; }

    /// <summary>
    /// WOUSER.
    /// </summary>
    public string? WOUSER { get; set; }

    /// <summary>
    /// WOUDTTM.
    /// </summary>
    public DateTime? WOUDTTM { get; set; }

    /// <summary>
    /// WOMKEY.
    /// </summary>
    public string? WOMKEY { get; set; }

    /// <summary>
    /// WOSLLKST.
    /// </summary>
    public string? WOSLLKST { get; set; }
}
