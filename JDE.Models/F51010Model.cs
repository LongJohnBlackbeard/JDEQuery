namespace JDE.Models;

/// <summary>
/// F51010 - .
/// </summary>
public class F51010Model
{
    /// <summary>
    /// CSEXSYSINS (Primary Key).
    /// </summary>
    public string CSEXSYSINS { get; set; }

    /// <summary>
    /// CSCMXMLF (Primary Key).
    /// </summary>
    public string CSCMXMLF { get; set; }

    /// <summary>
    /// CSCMFLOW.
    /// </summary>
    public string? CSCMFLOW { get; set; }

    /// <summary>
    /// CSCMXFER.
    /// </summary>
    public string? CSCMXFER { get; set; }

    /// <summary>
    /// CSCXUTIME.
    /// </summary>
    public DateTime? CSCXUTIME { get; set; }

    /// <summary>
    /// CSCMPROC.
    /// </summary>
    public string? CSCMPROC { get; set; }

    /// <summary>
    /// CSCPUTIME.
    /// </summary>
    public DateTime? CSCPUTIME { get; set; }

    /// <summary>
    /// CSUSER.
    /// </summary>
    public string? CSUSER { get; set; }

    /// <summary>
    /// CSPID.
    /// </summary>
    public string? CSPID { get; set; }

    /// <summary>
    /// CSMKEY.
    /// </summary>
    public string? CSMKEY { get; set; }

    /// <summary>
    /// CSUPMJ.
    /// </summary>
    public decimal? CSUPMJ { get; set; }

    /// <summary>
    /// CSUPMT.
    /// </summary>
    public decimal? CSUPMT { get; set; }
}
