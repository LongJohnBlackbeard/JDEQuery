namespace JDE.Models;

/// <summary>
/// F90CA14C - .
/// </summary>
public class F90CA14CModel
{
    /// <summary>
    /// TCTERRID (Primary Key).
    /// </summary>
    public decimal TCTERRID { get; set; }

    /// <summary>
    /// TCSTDRKY (Primary Key).
    /// </summary>
    public string TCSTDRKY { get; set; }

    /// <summary>
    /// TCCNDRKY.
    /// </summary>
    public string? TCCNDRKY { get; set; }

    /// <summary>
    /// TCSTSUDT.
    /// </summary>
    public DateTime? TCSTSUDT { get; set; }

    /// <summary>
    /// TCACTIND.
    /// </summary>
    public string? TCACTIND { get; set; }

    /// <summary>
    /// TCUSER.
    /// </summary>
    public string? TCUSER { get; set; }

    /// <summary>
    /// TCPID.
    /// </summary>
    public string? TCPID { get; set; }

    /// <summary>
    /// TCVID.
    /// </summary>
    public string? TCVID { get; set; }

    /// <summary>
    /// TCMKEY.
    /// </summary>
    public string? TCMKEY { get; set; }

    /// <summary>
    /// TCUDTTM.
    /// </summary>
    public DateTime? TCUDTTM { get; set; }

    /// <summary>
    /// TCENTDBY.
    /// </summary>
    public decimal? TCENTDBY { get; set; }

    /// <summary>
    /// TCEDATE.
    /// </summary>
    public DateTime? TCEDATE { get; set; }
}
