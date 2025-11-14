namespace JDE.Models;

/// <summary>
/// F09UI014 - .
/// </summary>
public class F09UI014Model
{
    /// <summary>
    /// GBAID (Primary Key).
    /// </summary>
    public string GBAID { get; set; }

    /// <summary>
    /// GBMCU.
    /// </summary>
    public string? GBMCU { get; set; }

    /// <summary>
    /// GBOBJ.
    /// </summary>
    public string? GBOBJ { get; set; }

    /// <summary>
    /// GBSUB.
    /// </summary>
    public string? GBSUB { get; set; }

    /// <summary>
    /// GBCO.
    /// </summary>
    public string? GBCO { get; set; }

    /// <summary>
    /// GBCTRY (Primary Key).
    /// </summary>
    public decimal GBCTRY { get; set; }

    /// <summary>
    /// GBFY (Primary Key).
    /// </summary>
    public decimal GBFY { get; set; }

    /// <summary>
    /// GBLT (Primary Key).
    /// </summary>
    public string GBLT { get; set; }

    /// <summary>
    /// GBCRCX.
    /// </summary>
    public string? GBCRCX { get; set; }

    /// <summary>
    /// GBAPYN.
    /// </summary>
    public decimal? GBAPYN { get; set; }

    /// <summary>
    /// GBUSER.
    /// </summary>
    public string? GBUSER { get; set; }
}
