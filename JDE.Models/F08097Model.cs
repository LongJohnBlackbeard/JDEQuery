using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08097 - .
/// </summary>
public class F08097Model
{
    /// <summary>
    /// H#TBLN (Primary Key).
    /// </summary>
    [Column("H#TBLN")]
    public decimal H_TBLN { get; set; }

    /// <summary>
    /// H#LOWR.
    /// </summary>
    [Column("H#LOWR")]
    public decimal? H_LOWR { get; set; }

    /// <summary>
    /// H#UPPR (Primary Key).
    /// </summary>
    [Column("H#UPPR")]
    public decimal H_UPPR { get; set; }

    /// <summary>
    /// H#ARES.
    /// </summary>
    [Column("H#ARES")]
    public decimal? H_ARES { get; set; }

    /// <summary>
    /// H#CRES.
    /// </summary>
    [Column("H#CRES")]
    public string? H_CRES { get; set; }

    /// <summary>
    /// H#TRES.
    /// </summary>
    [Column("H#TRES")]
    public decimal? H_TRES { get; set; }

    /// <summary>
    /// H#RMK.
    /// </summary>
    [Column("H#RMK")]
    public string? H_RMK { get; set; }
}
