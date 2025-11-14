using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F1503 - .
/// </summary>
public class F1503Model
{
    /// <summary>
    /// NBDOCO (Primary Key).
    /// </summary>
    public decimal NBDOCO { get; set; }

    /// <summary>
    /// NBLSET.
    /// </summary>
    public string? NBLSET { get; set; }

    /// <summary>
    /// NBMCU (Primary Key).
    /// </summary>
    public string NBMCU { get; set; }

    /// <summary>
    /// NBSTYL.
    /// </summary>
    public string? NBSTYL { get; set; }

    /// <summary>
    /// NBUNIT (Primary Key).
    /// </summary>
    public string NBUNIT { get; set; }

    /// <summary>
    /// NBUTTY.
    /// </summary>
    public string? NBUTTY { get; set; }

    /// <summary>
    /// NBLGCL.
    /// </summary>
    public string? NBLGCL { get; set; }

    /// <summary>
    /// NBLGNO (Primary Key).
    /// </summary>
    public decimal NBLGNO { get; set; }

    /// <summary>
    /// NBDL01.
    /// </summary>
    public string? NBDL01 { get; set; }

    /// <summary>
    /// NBEXR.
    /// </summary>
    public string? NBEXR { get; set; }

    /// <summary>
    /// NBSTSC.
    /// </summary>
    public string? NBSTSC { get; set; }

    /// <summary>
    /// NBEFTB.
    /// </summary>
    public decimal? NBEFTB { get; set; }

    /// <summary>
    /// NBEXPR.
    /// </summary>
    public decimal? NBEXPR { get; set; }

    /// <summary>
    /// NBTKDT.
    /// </summary>
    public decimal? NBTKDT { get; set; }

    /// <summary>
    /// NBEPCD.
    /// </summary>
    public string? NBEPCD { get; set; }

    /// <summary>
    /// NBAMID.
    /// </summary>
    public string? NBAMID { get; set; }

    /// <summary>
    /// NBPMU1.
    /// </summary>
    public decimal? NBPMU1 { get; set; }

    /// <summary>
    /// NBUM.
    /// </summary>
    public string? NBUM { get; set; }

    /// <summary>
    /// NBRO01.
    /// </summary>
    public string? NBRO01 { get; set; }

    /// <summary>
    /// NBRO02.
    /// </summary>
    public string? NBRO02 { get; set; }

    /// <summary>
    /// NBRQ.
    /// </summary>
    public string? NBRQ { get; set; }

    /// <summary>
    /// NBJOB#.
    /// </summary>
    [Column("NBJOB#")]
    public decimal? NBJOB_ { get; set; }

    /// <summary>
    /// NBSUSC.
    /// </summary>
    public string? NBSUSC { get; set; }

    /// <summary>
    /// NBUSER.
    /// </summary>
    public string? NBUSER { get; set; }

    /// <summary>
    /// NBUPMJ.
    /// </summary>
    public decimal? NBUPMJ { get; set; }

    /// <summary>
    /// NBPID.
    /// </summary>
    public string? NBPID { get; set; }

    /// <summary>
    /// NBJOBN.
    /// </summary>
    public string? NBJOBN { get; set; }

    /// <summary>
    /// NBAN8.
    /// </summary>
    public decimal? NBAN8 { get; set; }

    /// <summary>
    /// NBANP.
    /// </summary>
    public decimal? NBANP { get; set; }

    /// <summary>
    /// NBFLOR (Primary Key).
    /// </summary>
    public string NBFLOR { get; set; }

    /// <summary>
    /// NBFOTY.
    /// </summary>
    public string? NBFOTY { get; set; }

    /// <summary>
    /// NBARGC (Primary Key).
    /// </summary>
    public string NBARGC { get; set; }

    /// <summary>
    /// NBARGV (Primary Key).
    /// </summary>
    public string NBARGV { get; set; }

    /// <summary>
    /// NBUPMT.
    /// </summary>
    public decimal? NBUPMT { get; set; }
}
