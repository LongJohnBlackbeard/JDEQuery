using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F76B472 - .
/// </summary>
public class F76B472Model
{
    /// <summary>
    /// DDBDFLAY (Primary Key).
    /// </summary>
    public string DDBDFLAY { get; set; }

    /// <summary>
    /// DDDRIN (Primary Key).
    /// </summary>
    public string DDDRIN { get; set; }

    /// <summary>
    /// DDEDTY (Primary Key).
    /// </summary>
    public string DDEDTY { get; set; }

    /// <summary>
    /// DDSQ# (Primary Key).
    /// </summary>
    [Column("DDSQ#")]
    public string DDSQ_ { get; set; }

    /// <summary>
    /// DDBDFLBLT.
    /// </summary>
    public decimal? DDBDFLBLT { get; set; }

    /// <summary>
    /// DDPID.
    /// </summary>
    public string? DDPID { get; set; }

    /// <summary>
    /// DDJOBN.
    /// </summary>
    public string? DDJOBN { get; set; }

    /// <summary>
    /// DDUSER.
    /// </summary>
    public string? DDUSER { get; set; }

    /// <summary>
    /// DDUPMJ.
    /// </summary>
    public decimal? DDUPMJ { get; set; }

    /// <summary>
    /// DDUPMT.
    /// </summary>
    public decimal? DDUPMT { get; set; }
}
