namespace JDE.Models;

/// <summary>
/// F75IUI14 - .
/// </summary>
public class F75IUI14Model
{
    /// <summary>
    /// TPPYID (Primary Key).
    /// </summary>
    public decimal TPPYID { get; set; }

    /// <summary>
    /// TPJOBS (Primary Key).
    /// </summary>
    public decimal TPJOBS { get; set; }

    /// <summary>
    /// TPUSER (Primary Key).
    /// </summary>
    public string TPUSER { get; set; }

    /// <summary>
    /// TPPID.
    /// </summary>
    public string? TPPID { get; set; }

    /// <summary>
    /// TPJOBN.
    /// </summary>
    public string? TPJOBN { get; set; }

    /// <summary>
    /// TPUPMJ.
    /// </summary>
    public decimal? TPUPMJ { get; set; }

    /// <summary>
    /// TPUPMT.
    /// </summary>
    public decimal? TPUPMT { get; set; }
}
