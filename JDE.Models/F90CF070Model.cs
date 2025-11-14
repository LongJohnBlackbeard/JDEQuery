namespace JDE.Models;

/// <summary>
/// F90CF070 - .
/// </summary>
public class F90CF070Model
{
    /// <summary>
    /// CCTKNID (Primary Key).
    /// </summary>
    public decimal CCTKNID { get; set; }

    /// <summary>
    /// CCTKNNAM.
    /// </summary>
    public string? CCTKNNAM { get; set; }

    /// <summary>
    /// CCTOKNDESC.
    /// </summary>
    public string? CCTOKNDESC { get; set; }

    /// <summary>
    /// CCTKNTYP.
    /// </summary>
    public string? CCTKNTYP { get; set; }

    /// <summary>
    /// CCUSER.
    /// </summary>
    public string? CCUSER { get; set; }

    /// <summary>
    /// CCUDTTM.
    /// </summary>
    public DateTime? CCUDTTM { get; set; }

    /// <summary>
    /// CCJOBN.
    /// </summary>
    public string? CCJOBN { get; set; }

    /// <summary>
    /// CCMKEY.
    /// </summary>
    public string? CCMKEY { get; set; }

    /// <summary>
    /// CCTKNFLD.
    /// </summary>
    public decimal? CCTKNFLD { get; set; }
}
