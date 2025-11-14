namespace JDE.Models;

/// <summary>
/// F49T90 - .
/// </summary>
public class F49T90Model
{
    /// <summary>
    /// ITDATETIME (Primary Key).
    /// </summary>
    public string ITDATETIME { get; set; }

    /// <summary>
    /// ITTRMNUM (Primary Key).
    /// </summary>
    public string ITTRMNUM { get; set; }

    /// <summary>
    /// ITDOCBLOB.
    /// </summary>
    public string? ITDOCBLOB { get; set; }

    /// <summary>
    /// ITERRC.
    /// </summary>
    public string? ITERRC { get; set; }

    /// <summary>
    /// ITOTXMLTYP.
    /// </summary>
    public string? ITOTXMLTYP { get; set; }
}
