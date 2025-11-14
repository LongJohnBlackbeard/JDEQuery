namespace JDE.Models;

/// <summary>
/// F08462 - .
/// </summary>
public class F08462Model
{
    /// <summary>
    /// VPPSTCAT (Primary Key).
    /// </summary>
    public string VPPSTCAT { get; set; }

    /// <summary>
    /// VPAPPLACT (Primary Key).
    /// </summary>
    public string VPAPPLACT { get; set; }

    /// <summary>
    /// VPINEXB.
    /// </summary>
    public string? VPINEXB { get; set; }

    /// <summary>
    /// VPPID.
    /// </summary>
    public string? VPPID { get; set; }

    /// <summary>
    /// VPUSER.
    /// </summary>
    public string? VPUSER { get; set; }

    /// <summary>
    /// VPMKEY.
    /// </summary>
    public string? VPMKEY { get; set; }

    /// <summary>
    /// VPUPMJ.
    /// </summary>
    public decimal? VPUPMJ { get; set; }

    /// <summary>
    /// VPUPMT.
    /// </summary>
    public decimal? VPUPMT { get; set; }
}
