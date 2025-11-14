namespace JDE.Models;

/// <summary>
/// F080704 - .
/// </summary>
public class F080704Model
{
    /// <summary>
    /// FERCTLID (Primary Key).
    /// </summary>
    public string FERCTLID { get; set; }

    /// <summary>
    /// FEZIPFN.
    /// </summary>
    public string? FEZIPFN { get; set; }

    /// <summary>
    /// FEFILOC.
    /// </summary>
    public string? FEFILOC { get; set; }

    /// <summary>
    /// FETMSP.
    /// </summary>
    public DateTime? FETMSP { get; set; }

    /// <summary>
    /// FELBON (Primary Key).
    /// </summary>
    public string FELBON { get; set; }

    /// <summary>
    /// FEENTPID (Primary Key).
    /// </summary>
    public string FEENTPID { get; set; }

    /// <summary>
    /// FEUPMJ.
    /// </summary>
    public decimal? FEUPMJ { get; set; }

    /// <summary>
    /// FEUPMT.
    /// </summary>
    public decimal? FEUPMT { get; set; }

    /// <summary>
    /// FEUSER.
    /// </summary>
    public string? FEUSER { get; set; }

    /// <summary>
    /// FEJOBN.
    /// </summary>
    public string? FEJOBN { get; set; }

    /// <summary>
    /// FEPID.
    /// </summary>
    public string? FEPID { get; set; }

    /// <summary>
    /// FEPRINST (Primary Key).
    /// </summary>
    public decimal FEPRINST { get; set; }
}
