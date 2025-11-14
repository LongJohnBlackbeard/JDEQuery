namespace JDE.Models;

/// <summary>
/// FCW60 - .
/// </summary>
public class FCW60Model
{
    /// <summary>
    /// CMC9ITM (Primary Key).
    /// </summary>
    public decimal CMC9ITM { get; set; }

    /// <summary>
    /// CMC9CMP (Primary Key).
    /// </summary>
    public string CMC9CMP { get; set; }

    /// <summary>
    /// CMC9SEQ (Primary Key).
    /// </summary>
    public decimal CMC9SEQ { get; set; }

    /// <summary>
    /// CMC9PERC.
    /// </summary>
    public decimal? CMC9PERC { get; set; }

    /// <summary>
    /// CMC9MAT.
    /// </summary>
    public string? CMC9MAT { get; set; }
}
