namespace JDE.Models;

/// <summary>
/// F46021 - .
/// </summary>
public class F46021Model
{
    /// <summary>
    /// LQMCU (Primary Key).
    /// </summary>
    public string LQMCU { get; set; }

    /// <summary>
    /// LQCGRP (Primary Key).
    /// </summary>
    public string LQCGRP { get; set; }

    /// <summary>
    /// LQLOCN (Primary Key).
    /// </summary>
    public string LQLOCN { get; set; }

    /// <summary>
    /// LQDEFI (Primary Key).
    /// </summary>
    public string LQDEFI { get; set; }

    /// <summary>
    /// LQUSER.
    /// </summary>
    public string? LQUSER { get; set; }

    /// <summary>
    /// LQUPMJ.
    /// </summary>
    public decimal? LQUPMJ { get; set; }

    /// <summary>
    /// LQTDAY.
    /// </summary>
    public decimal? LQTDAY { get; set; }
}
