using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F085536W - .
/// </summary>
public class F085536WModel
{
    /// <summary>
    /// DBEVET (Primary Key).
    /// </summary>
    public decimal DBEVET { get; set; }

    /// <summary>
    /// DBAN8 (Primary Key).
    /// </summary>
    public decimal DBAN8 { get; set; }

    /// <summary>
    /// DBPAN8 (Primary Key).
    /// </summary>
    public decimal DBPAN8 { get; set; }

    /// <summary>
    /// DBMLNM.
    /// </summary>
    public string? DBMLNM { get; set; }

    /// <summary>
    /// DBDBEN (Primary Key).
    /// </summary>
    public string DBDBEN { get; set; }

    /// <summary>
    /// DBRELA.
    /// </summary>
    public string? DBRELA { get; set; }

    /// <summary>
    /// DBPLAN (Primary Key).
    /// </summary>
    public string DBPLAN { get; set; }

    /// <summary>
    /// DBAOPT (Primary Key).
    /// </summary>
    public string DBAOPT { get; set; }

    /// <summary>
    /// DBEFT.
    /// </summary>
    public decimal? DBEFT { get; set; }

    /// <summary>
    /// DBEFTE.
    /// </summary>
    public decimal? DBEFTE { get; set; }

    /// <summary>
    /// DBEECD.
    /// </summary>
    public string? DBEECD { get; set; }

    /// <summary>
    /// DBEDTE.
    /// </summary>
    public decimal? DBEDTE { get; set; }

    /// <summary>
    /// DBPCP#.
    /// </summary>
    [Column("DBPCP#")]
    public string? DBPCP_ { get; set; }

    /// <summary>
    /// DBPERC.
    /// </summary>
    public decimal? DBPERC { get; set; }

    /// <summary>
    /// DBSECPERC.
    /// </summary>
    public decimal? DBSECPERC { get; set; }

    /// <summary>
    /// DBNEWPERC.
    /// </summary>
    public decimal? DBNEWPERC { get; set; }

    /// <summary>
    /// DBNSECPERC.
    /// </summary>
    public decimal? DBNSECPERC { get; set; }

    /// <summary>
    /// DBPCPVST.
    /// </summary>
    public string? DBPCPVST { get; set; }

    /// <summary>
    /// DBACFL.
    /// </summary>
    public string? DBACFL { get; set; }

    /// <summary>
    /// DBUSER.
    /// </summary>
    public string? DBUSER { get; set; }

    /// <summary>
    /// DBPID.
    /// </summary>
    public string? DBPID { get; set; }

    /// <summary>
    /// DBJOBN.
    /// </summary>
    public string? DBJOBN { get; set; }

    /// <summary>
    /// DBUPMJ.
    /// </summary>
    public decimal? DBUPMJ { get; set; }

    /// <summary>
    /// DBUPMT.
    /// </summary>
    public decimal? DBUPMT { get; set; }

    /// <summary>
    /// DBESIGN.
    /// </summary>
    public string? DBESIGN { get; set; }

    /// <summary>
    /// DBMUMJ.
    /// </summary>
    public decimal? DBMUMJ { get; set; }

    /// <summary>
    /// DBMUMT.
    /// </summary>
    public decimal? DBMUMT { get; set; }

    /// <summary>
    /// DBUPID.
    /// </summary>
    public string? DBUPID { get; set; }

    /// <summary>
    /// DBCCAI.
    /// </summary>
    public string? DBCCAI { get; set; }
}
