namespace JDE.Models;

/// <summary>
/// F08472 - .
/// </summary>
public class F08472Model
{
    /// <summary>
    /// JTPSTNO (Primary Key).
    /// </summary>
    public decimal JTPSTNO { get; set; }

    /// <summary>
    /// JTLANG (Primary Key).
    /// </summary>
    public string JTLANG { get; set; }

    /// <summary>
    /// JTPSTDSC.
    /// </summary>
    public string? JTPSTDSC { get; set; }

    /// <summary>
    /// JTKEYWRD.
    /// </summary>
    public string? JTKEYWRD { get; set; }

    /// <summary>
    /// JTPID.
    /// </summary>
    public string? JTPID { get; set; }

    /// <summary>
    /// JTUSER.
    /// </summary>
    public string? JTUSER { get; set; }

    /// <summary>
    /// JTMKEY.
    /// </summary>
    public string? JTMKEY { get; set; }

    /// <summary>
    /// JTUPMJ.
    /// </summary>
    public decimal? JTUPMJ { get; set; }

    /// <summary>
    /// JTUPMT.
    /// </summary>
    public decimal? JTUPMT { get; set; }
}
