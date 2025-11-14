namespace JDE.Models;

/// <summary>
/// FCW62 - .
/// </summary>
public class FCW62Model
{
    /// <summary>
    /// WFC9ITM (Primary Key).
    /// </summary>
    public decimal WFC9ITM { get; set; }

    /// <summary>
    /// WFEV01 (Primary Key).
    /// </summary>
    public string WFEV01 { get; set; }

    /// <summary>
    /// WFC9CMP (Primary Key).
    /// </summary>
    public string WFC9CMP { get; set; }

    /// <summary>
    /// WFC9SEQ (Primary Key).
    /// </summary>
    public decimal WFC9SEQ { get; set; }

    /// <summary>
    /// WFC9PERC.
    /// </summary>
    public decimal? WFC9PERC { get; set; }

    /// <summary>
    /// WFC9MAT.
    /// </summary>
    public string? WFC9MAT { get; set; }
}
