namespace JDE.Models;

/// <summary>
/// F99RDDS - .
/// </summary>
public class F99RDDSModel
{
    /// <summary>
    /// DSOBNM (Primary Key).
    /// </summary>
    public string DSOBNM { get; set; }

    /// <summary>
    /// DSTMPLTYP.
    /// </summary>
    public decimal? DSTMPLTYP { get; set; }

    /// <summary>
    /// DSTMPLNM.
    /// </summary>
    public string? DSTMPLNM { get; set; }

    /// <summary>
    /// DSDTAI (Primary Key).
    /// </summary>
    public string DSDTAI { get; set; }

    /// <summary>
    /// DSMD.
    /// </summary>
    public string? DSMD { get; set; }
}
