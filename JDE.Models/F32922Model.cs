using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F32922 - .
/// </summary>
public class F32922Model
{
    /// <summary>
    /// KVFCOD (Primary Key).
    /// </summary>
    public string KVFCOD { get; set; }

    /// <summary>
    /// KVKIT (Primary Key).
    /// </summary>
    public decimal KVKIT { get; set; }

    /// <summary>
    /// KVMCU (Primary Key).
    /// </summary>
    public string KVMCU { get; set; }

    /// <summary>
    /// KVATO# (Primary Key).
    /// </summary>
    [Column("KVATO#")]
    public decimal KVATO_ { get; set; }

    /// <summary>
    /// KVATOS (Primary Key).
    /// </summary>
    public decimal KVATOS { get; set; }

    /// <summary>
    /// KVSRFV (Primary Key).
    /// </summary>
    public string KVSRFV { get; set; }

    /// <summary>
    /// KVSRTV (Primary Key).
    /// </summary>
    public string KVSRTV { get; set; }

    /// <summary>
    /// KVEFFF.
    /// </summary>
    public decimal? KVEFFF { get; set; }

    /// <summary>
    /// KVEFFT.
    /// </summary>
    public decimal? KVEFFT { get; set; }

    /// <summary>
    /// KVURCD.
    /// </summary>
    public string? KVURCD { get; set; }

    /// <summary>
    /// KVURDT.
    /// </summary>
    public decimal? KVURDT { get; set; }

    /// <summary>
    /// KVURAT.
    /// </summary>
    public decimal? KVURAT { get; set; }

    /// <summary>
    /// KVURAB.
    /// </summary>
    public decimal? KVURAB { get; set; }

    /// <summary>
    /// KVURRF.
    /// </summary>
    public string? KVURRF { get; set; }

    /// <summary>
    /// KVUSER.
    /// </summary>
    public string? KVUSER { get; set; }

    /// <summary>
    /// KVPID.
    /// </summary>
    public string? KVPID { get; set; }

    /// <summary>
    /// KVJOBN.
    /// </summary>
    public string? KVJOBN { get; set; }

    /// <summary>
    /// KVUPMJ.
    /// </summary>
    public decimal? KVUPMJ { get; set; }

    /// <summary>
    /// KVTDAY.
    /// </summary>
    public decimal? KVTDAY { get; set; }
}
