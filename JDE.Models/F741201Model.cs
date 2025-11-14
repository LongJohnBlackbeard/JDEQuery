namespace JDE.Models;

/// <summary>
/// F741201 - .
/// </summary>
public class F741201Model
{
    /// <summary>
    /// CSCO (Primary Key).
    /// </summary>
    public string CSCO { get; set; }

    /// <summary>
    /// CSC74SC (Primary Key).
    /// </summary>
    public string CSC74SC { get; set; }

    /// <summary>
    /// CSC74CN (Primary Key).
    /// </summary>
    public string CSC74CN { get; set; }

    /// <summary>
    /// CSDCT (Primary Key).
    /// </summary>
    public string CSDCT { get; set; }

    /// <summary>
    /// CSUSER.
    /// </summary>
    public string? CSUSER { get; set; }

    /// <summary>
    /// CSPID.
    /// </summary>
    public string? CSPID { get; set; }

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
