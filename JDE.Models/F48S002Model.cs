namespace JDE.Models;

/// <summary>
/// F48S002 - .
/// </summary>
public class F48S002Model
{
    /// <summary>
    /// WMICU (Primary Key).
    /// </summary>
    public decimal WMICU { get; set; }

    /// <summary>
    /// WMDOCZ (Primary Key).
    /// </summary>
    public decimal WMDOCZ { get; set; }

    /// <summary>
    /// WMDCTI (Primary Key).
    /// </summary>
    public string WMDCTI { get; set; }

    /// <summary>
    /// WMKCO (Primary Key).
    /// </summary>
    public string WMKCO { get; set; }

    /// <summary>
    /// WMDOC.
    /// </summary>
    public decimal? WMDOC { get; set; }

    /// <summary>
    /// WMDCT.
    /// </summary>
    public string? WMDCT { get; set; }
}
