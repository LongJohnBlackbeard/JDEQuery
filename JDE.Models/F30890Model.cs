namespace JDE.Models;

/// <summary>
/// F30890 - .
/// </summary>
public class F30890Model
{
    /// <summary>
    /// CCUKID (Primary Key).
    /// </summary>
    public decimal CCUKID { get; set; }

    /// <summary>
    /// CCMCUFRM (Primary Key).
    /// </summary>
    public string CCMCUFRM { get; set; }

    /// <summary>
    /// CCMCUTO (Primary Key).
    /// </summary>
    public string CCMCUTO { get; set; }

    /// <summary>
    /// CCUSER.
    /// </summary>
    public string? CCUSER { get; set; }

    /// <summary>
    /// CCPID.
    /// </summary>
    public string? CCPID { get; set; }

    /// <summary>
    /// CCUPMJ.
    /// </summary>
    public decimal? CCUPMJ { get; set; }

    /// <summary>
    /// CCJOBN.
    /// </summary>
    public string? CCJOBN { get; set; }

    /// <summary>
    /// CCUPMT.
    /// </summary>
    public decimal? CCUPMT { get; set; }
}
