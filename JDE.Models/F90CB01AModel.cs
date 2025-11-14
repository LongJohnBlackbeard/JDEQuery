namespace JDE.Models;

/// <summary>
/// F90CB01A - .
/// </summary>
public class F90CB01AModel
{
    /// <summary>
    /// LAADRSID (Primary Key).
    /// </summary>
    public decimal LAADRSID { get; set; }

    /// <summary>
    /// LALEADID (Primary Key).
    /// </summary>
    public decimal LALEADID { get; set; }

    /// <summary>
    /// LASTSUDT.
    /// </summary>
    public DateTime? LASTSUDT { get; set; }

    /// <summary>
    /// LAACTIND.
    /// </summary>
    public string? LAACTIND { get; set; }

    /// <summary>
    /// LAUSER.
    /// </summary>
    public string? LAUSER { get; set; }

    /// <summary>
    /// LAPID.
    /// </summary>
    public string? LAPID { get; set; }

    /// <summary>
    /// LAVID.
    /// </summary>
    public string? LAVID { get; set; }

    /// <summary>
    /// LAMKEY.
    /// </summary>
    public string? LAMKEY { get; set; }

    /// <summary>
    /// LAUDTTM.
    /// </summary>
    public DateTime? LAUDTTM { get; set; }
}
