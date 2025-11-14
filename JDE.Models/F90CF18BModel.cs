namespace JDE.Models;

/// <summary>
/// F90CF18B - .
/// </summary>
public class F90CF18BModel
{
    /// <summary>
    /// ICSCRINSID (Primary Key).
    /// </summary>
    public decimal ICSCRINSID { get; set; }

    /// <summary>
    /// ICEFFSEQ (Primary Key).
    /// </summary>
    public decimal ICEFFSEQ { get; set; }

    /// <summary>
    /// ICQSTPTHID.
    /// </summary>
    public decimal? ICQSTPTHID { get; set; }

    /// <summary>
    /// ICPARPTHID.
    /// </summary>
    public decimal? ICPARPTHID { get; set; }

    /// <summary>
    /// ICQUSTID.
    /// </summary>
    public decimal? ICQUSTID { get; set; }

    /// <summary>
    /// ICCMMNT.
    /// </summary>
    public string? ICCMMNT { get; set; }

    /// <summary>
    /// ICUSER.
    /// </summary>
    public string? ICUSER { get; set; }

    /// <summary>
    /// ICJOBN.
    /// </summary>
    public string? ICJOBN { get; set; }

    /// <summary>
    /// ICMKEY.
    /// </summary>
    public string? ICMKEY { get; set; }

    /// <summary>
    /// ICUDTTM.
    /// </summary>
    public DateTime? ICUDTTM { get; set; }
}
