namespace JDE.Models;

/// <summary>
/// F76C0005 - .
/// </summary>
public class F76C0005Model
{
    /// <summary>
    /// TXTXA1 (Primary Key).
    /// </summary>
    public string TXTXA1 { get; set; }

    /// <summary>
    /// TX76CTX1 (Primary Key).
    /// </summary>
    public string TX76CTX1 { get; set; }

    /// <summary>
    /// TX76CTX2.
    /// </summary>
    public string? TX76CTX2 { get; set; }

    /// <summary>
    /// TXUSER.
    /// </summary>
    public string? TXUSER { get; set; }

    /// <summary>
    /// TXPID.
    /// </summary>
    public string? TXPID { get; set; }

    /// <summary>
    /// TXJOBN.
    /// </summary>
    public string? TXJOBN { get; set; }

    /// <summary>
    /// TXUPMJ.
    /// </summary>
    public decimal? TXUPMJ { get; set; }

    /// <summary>
    /// TXUPMT.
    /// </summary>
    public decimal? TXUPMT { get; set; }
}
