namespace JDE.Models;

/// <summary>
/// F76H006 - .
/// </summary>
public class F76H006Model
{
    /// <summary>
    /// LRDCT (Primary Key).
    /// </summary>
    public string LRDCT { get; set; }

    /// <summary>
    /// LRH76CC02 (Primary Key).
    /// </summary>
    public string LRH76CC02 { get; set; }

    /// <summary>
    /// LRH76LEDT.
    /// </summary>
    public string? LRH76LEDT { get; set; }

    /// <summary>
    /// LRUSER.
    /// </summary>
    public string? LRUSER { get; set; }

    /// <summary>
    /// LRPID.
    /// </summary>
    public string? LRPID { get; set; }

    /// <summary>
    /// LRJOBN.
    /// </summary>
    public string? LRJOBN { get; set; }

    /// <summary>
    /// LRUPMJ.
    /// </summary>
    public decimal? LRUPMJ { get; set; }

    /// <summary>
    /// LRUPMT.
    /// </summary>
    public decimal? LRUPMT { get; set; }
}
