namespace JDE.Models;

/// <summary>
/// F01RS12W - .
/// </summary>
public class F01RS12WModel
{
    /// <summary>
    /// TRSESSID (Primary Key).
    /// </summary>
    public string TRSESSID { get; set; }

    /// <summary>
    /// TRUSER (Primary Key).
    /// </summary>
    public string TRUSER { get; set; }

    /// <summary>
    /// TRROLEDESC.
    /// </summary>
    public string? TRROLEDESC { get; set; }

    /// <summary>
    /// TREV01.
    /// </summary>
    public string? TREV01 { get; set; }
}
