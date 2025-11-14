namespace JDE.Models;

/// <summary>
/// F90CF18C - .
/// </summary>
public class F90CF18CModel
{
    /// <summary>
    /// ITSCRINSID (Primary Key).
    /// </summary>
    public decimal ITSCRINSID { get; set; }

    /// <summary>
    /// ITEFFSEQ (Primary Key).
    /// </summary>
    public decimal ITEFFSEQ { get; set; }

    /// <summary>
    /// ITTKNNAM.
    /// </summary>
    public string? ITTKNNAM { get; set; }

    /// <summary>
    /// ITANSVAL.
    /// </summary>
    public string? ITANSVAL { get; set; }

    /// <summary>
    /// ITUSER.
    /// </summary>
    public string? ITUSER { get; set; }

    /// <summary>
    /// ITJOBN.
    /// </summary>
    public string? ITJOBN { get; set; }

    /// <summary>
    /// ITMKEY.
    /// </summary>
    public string? ITMKEY { get; set; }

    /// <summary>
    /// ITUDTTM.
    /// </summary>
    public DateTime? ITUDTTM { get; set; }
}
