namespace JDE.Models;

/// <summary>
/// F46092 - .
/// </summary>
public class F46092Model
{
    /// <summary>
    /// OZMCU (Primary Key).
    /// </summary>
    public string OZMCU { get; set; }

    /// <summary>
    /// OZOGRP (Primary Key).
    /// </summary>
    public string OZOGRP { get; set; }

    /// <summary>
    /// OZDCTO (Primary Key).
    /// </summary>
    public string OZDCTO { get; set; }

    /// <summary>
    /// OZUSER.
    /// </summary>
    public string? OZUSER { get; set; }

    /// <summary>
    /// OZUPMJ.
    /// </summary>
    public decimal? OZUPMJ { get; set; }

    /// <summary>
    /// OZTDAY.
    /// </summary>
    public decimal? OZTDAY { get; set; }
}
