namespace JDE.Models;

/// <summary>
/// F20106 - .
/// </summary>
public class F20106Model
{
    /// <summary>
    /// EMEXPTYPE (Primary Key).
    /// </summary>
    public string EMEXPTYPE { get; set; }

    /// <summary>
    /// EMSTYL (Primary Key).
    /// </summary>
    public string EMSTYL { get; set; }

    /// <summary>
    /// EMOBJ.
    /// </summary>
    public string? EMOBJ { get; set; }

    /// <summary>
    /// EMSUB.
    /// </summary>
    public string? EMSUB { get; set; }

    /// <summary>
    /// EMUNALOBJ.
    /// </summary>
    public string? EMUNALOBJ { get; set; }

    /// <summary>
    /// EMUNALSUB.
    /// </summary>
    public string? EMUNALSUB { get; set; }
}
