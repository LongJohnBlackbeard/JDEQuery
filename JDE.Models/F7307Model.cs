namespace JDE.Models;

/// <summary>
/// F7307 - .
/// </summary>
public class F7307Model
{
    /// <summary>
    /// VXDCTO (Primary Key).
    /// </summary>
    public string VXDCTO { get; set; }

    /// <summary>
    /// VXLNTY (Primary Key).
    /// </summary>
    public string VXLNTY { get; set; }

    /// <summary>
    /// VXVVTC.
    /// </summary>
    public string? VXVVTC { get; set; }

    /// <summary>
    /// VXVVTY.
    /// </summary>
    public string? VXVVTY { get; set; }

    /// <summary>
    /// VXUSER.
    /// </summary>
    public string? VXUSER { get; set; }

    /// <summary>
    /// VXPID.
    /// </summary>
    public string? VXPID { get; set; }

    /// <summary>
    /// VXJOBN.
    /// </summary>
    public string? VXJOBN { get; set; }

    /// <summary>
    /// VXUPMJ.
    /// </summary>
    public decimal? VXUPMJ { get; set; }

    /// <summary>
    /// VXTDAY.
    /// </summary>
    public decimal? VXTDAY { get; set; }
}
