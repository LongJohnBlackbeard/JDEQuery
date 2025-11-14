namespace JDE.Models;

/// <summary>
/// F3413 - .
/// </summary>
public class F3413Model
{
    /// <summary>
    /// MRITM (Primary Key).
    /// </summary>
    public decimal MRITM { get; set; }

    /// <summary>
    /// MRMCU (Primary Key).
    /// </summary>
    public string MRMCU { get; set; }

    /// <summary>
    /// MRQT (Primary Key).
    /// </summary>
    public string MRQT { get; set; }

    /// <summary>
    /// MRSTRT (Primary Key).
    /// </summary>
    public decimal MRSTRT { get; set; }

    /// <summary>
    /// MRTRQT.
    /// </summary>
    public decimal? MRTRQT { get; set; }
}
