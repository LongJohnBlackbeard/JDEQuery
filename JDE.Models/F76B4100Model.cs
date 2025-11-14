namespace JDE.Models;

/// <summary>
/// F76B4100 - .
/// </summary>
public class F76B4100Model
{
    /// <summary>
    /// PSPID (Primary Key).
    /// </summary>
    public string PSPID { get; set; }

    /// <summary>
    /// PSEV01.
    /// </summary>
    public string? PSEV01 { get; set; }

    /// <summary>
    /// PSUSER.
    /// </summary>
    public string? PSUSER { get; set; }

    /// <summary>
    /// PSJOBN.
    /// </summary>
    public string? PSJOBN { get; set; }

    /// <summary>
    /// PSUPMJ.
    /// </summary>
    public decimal? PSUPMJ { get; set; }

    /// <summary>
    /// PSUPMT.
    /// </summary>
    public decimal? PSUPMT { get; set; }
}
