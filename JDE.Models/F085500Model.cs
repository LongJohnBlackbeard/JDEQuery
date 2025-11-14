namespace JDE.Models;

/// <summary>
/// F085500 - .
/// </summary>
public class F085500Model
{
    /// <summary>
    /// ADPLAN (Primary Key).
    /// </summary>
    public string ADPLAN { get; set; }

    /// <summary>
    /// ADAOPT (Primary Key).
    /// </summary>
    public string ADAOPT { get; set; }

    /// <summary>
    /// ADRELA (Primary Key).
    /// </summary>
    public string ADRELA { get; set; }

    /// <summary>
    /// ADUSER.
    /// </summary>
    public string? ADUSER { get; set; }

    /// <summary>
    /// ADPID.
    /// </summary>
    public string? ADPID { get; set; }

    /// <summary>
    /// ADJOBN.
    /// </summary>
    public string? ADJOBN { get; set; }

    /// <summary>
    /// ADUPMJ.
    /// </summary>
    public decimal? ADUPMJ { get; set; }

    /// <summary>
    /// ADUPMT.
    /// </summary>
    public decimal? ADUPMT { get; set; }
}
