namespace JDE.Models;

/// <summary>
/// F79A81 - .
/// </summary>
public class F79A81Model
{
    /// <summary>
    /// CS79ACPID (Primary Key).
    /// </summary>
    public decimal CS79ACPID { get; set; }

    /// <summary>
    /// CS79AEMSC (Primary Key).
    /// </summary>
    public string CS79AEMSC { get; set; }

    /// <summary>
    /// CSPID.
    /// </summary>
    public string? CSPID { get; set; }

    /// <summary>
    /// CSUSER.
    /// </summary>
    public string? CSUSER { get; set; }

    /// <summary>
    /// CSJOBN.
    /// </summary>
    public string? CSJOBN { get; set; }

    /// <summary>
    /// CSUPMJ.
    /// </summary>
    public decimal? CSUPMJ { get; set; }

    /// <summary>
    /// CSUPMT.
    /// </summary>
    public decimal? CSUPMT { get; set; }
}
