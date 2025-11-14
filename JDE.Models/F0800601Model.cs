namespace JDE.Models;

/// <summary>
/// F0800601 - .
/// </summary>
public class F0800601Model
{
    /// <summary>
    /// JCORMCU (Primary Key).
    /// </summary>
    public string JCORMCU { get; set; }

    /// <summary>
    /// JCJBCD (Primary Key).
    /// </summary>
    public string JCJBCD { get; set; }

    /// <summary>
    /// JCJBST (Primary Key).
    /// </summary>
    public string JCJBST { get; set; }

    /// <summary>
    /// JCEFTB (Primary Key).
    /// </summary>
    public decimal JCEFTB { get; set; }

    /// <summary>
    /// JCEFTE (Primary Key).
    /// </summary>
    public decimal JCEFTE { get; set; }

    /// <summary>
    /// JCOTPS (Primary Key).
    /// </summary>
    public string JCOTPS { get; set; }

    /// <summary>
    /// JCUSER.
    /// </summary>
    public string? JCUSER { get; set; }

    /// <summary>
    /// JCPID.
    /// </summary>
    public string? JCPID { get; set; }

    /// <summary>
    /// JCJOBN.
    /// </summary>
    public string? JCJOBN { get; set; }

    /// <summary>
    /// JCUPMJ.
    /// </summary>
    public decimal? JCUPMJ { get; set; }

    /// <summary>
    /// JCUPMT.
    /// </summary>
    public decimal? JCUPMT { get; set; }
}
