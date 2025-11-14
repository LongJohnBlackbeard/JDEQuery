using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F08336WF - .
/// </summary>
public class F08336WFModel
{
    /// <summary>
    /// BDEVET (Primary Key).
    /// </summary>
    public decimal BDEVET { get; set; }

    /// <summary>
    /// BDAN8 (Primary Key).
    /// </summary>
    public decimal BDAN8 { get; set; }

    /// <summary>
    /// BDPAN8 (Primary Key).
    /// </summary>
    public decimal BDPAN8 { get; set; }

    /// <summary>
    /// BDMLNM.
    /// </summary>
    public string? BDMLNM { get; set; }

    /// <summary>
    /// BDDBEN (Primary Key).
    /// </summary>
    public string BDDBEN { get; set; }

    /// <summary>
    /// BDRELA.
    /// </summary>
    public string? BDRELA { get; set; }

    /// <summary>
    /// BDPLAN (Primary Key).
    /// </summary>
    public string BDPLAN { get; set; }

    /// <summary>
    /// BDAOPT (Primary Key).
    /// </summary>
    public string BDAOPT { get; set; }

    /// <summary>
    /// BDEFT.
    /// </summary>
    public decimal? BDEFT { get; set; }

    /// <summary>
    /// BDPCP#.
    /// </summary>
    [Column("BDPCP#")]
    public string? BDPCP_ { get; set; }

    /// <summary>
    /// BDEFTE.
    /// </summary>
    public decimal? BDEFTE { get; set; }

    /// <summary>
    /// BDEECD.
    /// </summary>
    public string? BDEECD { get; set; }

    /// <summary>
    /// BDEDTE.
    /// </summary>
    public decimal? BDEDTE { get; set; }

    /// <summary>
    /// BDPERC.
    /// </summary>
    public decimal? BDPERC { get; set; }

    /// <summary>
    /// BDSECPERC.
    /// </summary>
    public decimal? BDSECPERC { get; set; }

    /// <summary>
    /// BDNEWPERC.
    /// </summary>
    public decimal? BDNEWPERC { get; set; }

    /// <summary>
    /// BDNSECPERC.
    /// </summary>
    public decimal? BDNSECPERC { get; set; }

    /// <summary>
    /// BDACFL.
    /// </summary>
    public string? BDACFL { get; set; }

    /// <summary>
    /// BDUSER.
    /// </summary>
    public string? BDUSER { get; set; }

    /// <summary>
    /// BDPID.
    /// </summary>
    public string? BDPID { get; set; }

    /// <summary>
    /// BDJOBN.
    /// </summary>
    public string? BDJOBN { get; set; }

    /// <summary>
    /// BDUPMJ.
    /// </summary>
    public decimal? BDUPMJ { get; set; }

    /// <summary>
    /// BDUPMT.
    /// </summary>
    public decimal? BDUPMT { get; set; }
}
