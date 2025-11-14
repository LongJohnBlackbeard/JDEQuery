namespace JDE.Models;

/// <summary>
/// F90CA086 - .
/// </summary>
public class F90CA086Model
{
    /// <summary>
    /// CRCUAN8 (Primary Key).
    /// </summary>
    public decimal CRCUAN8 { get; set; }

    /// <summary>
    /// CRCRAN8 (Primary Key).
    /// </summary>
    public decimal CRCRAN8 { get; set; }

    /// <summary>
    /// CRVCRA.
    /// </summary>
    public decimal? CRVCRA { get; set; }

    /// <summary>
    /// CREDATE.
    /// </summary>
    public DateTime? CREDATE { get; set; }

    /// <summary>
    /// CRUSER.
    /// </summary>
    public string? CRUSER { get; set; }

    /// <summary>
    /// CRUDTTM.
    /// </summary>
    public DateTime? CRUDTTM { get; set; }

    /// <summary>
    /// CRMKEY.
    /// </summary>
    public string? CRMKEY { get; set; }

    /// <summary>
    /// CRENTDBY.
    /// </summary>
    public decimal? CRENTDBY { get; set; }
}
