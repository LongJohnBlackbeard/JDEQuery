using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F76B62 - .
/// </summary>
public class F76B62Model
{
    /// <summary>
    /// BICO (Primary Key).
    /// </summary>
    public string BICO { get; set; }

    /// <summary>
    /// BIUPMJ (Primary Key).
    /// </summary>
    public decimal BIUPMJ { get; set; }

    /// <summary>
    /// BIBRNCB (Primary Key).
    /// </summary>
    public string BIBRNCB { get; set; }

    /// <summary>
    /// BIBRDSB.
    /// </summary>
    public string? BIBRDSB { get; set; }

    /// <summary>
    /// BIBRNBP (Primary Key).
    /// </summary>
    public string BIBRNBP { get; set; }

    /// <summary>
    /// BIMCU.
    /// </summary>
    public string? BIMCU { get; set; }

    /// <summary>
    /// BIBRCD#.
    /// </summary>
    [Column("BIBRCD#")]
    public string? BIBRCD_ { get; set; }

    /// <summary>
    /// BIDAJ.
    /// </summary>
    public decimal? BIDAJ { get; set; }

    /// <summary>
    /// BIBRTPD.
    /// </summary>
    public string? BIBRTPD { get; set; }

    /// <summary>
    /// BIBRNDA.
    /// </summary>
    public string? BIBRNDA { get; set; }

    /// <summary>
    /// BIBRNSR.
    /// </summary>
    public string? BIBRNSR { get; set; }

    /// <summary>
    /// BIBRCSB.
    /// </summary>
    public string? BIBRCSB { get; set; }

    /// <summary>
    /// BIBRVAB.
    /// </summary>
    public decimal? BIBRVAB { get; set; }

    /// <summary>
    /// BIBRQTI.
    /// </summary>
    public decimal? BIBRQTI { get; set; }

    /// <summary>
    /// BIBRSIG.
    /// </summary>
    public string? BIBRSIG { get; set; }

    /// <summary>
    /// BIBRNAL.
    /// </summary>
    public string? BIBRNAL { get; set; }

    /// <summary>
    /// BIBRTDA.
    /// </summary>
    public decimal? BIBRTDA { get; set; }

    /// <summary>
    /// BIBRDIC.
    /// </summary>
    public decimal? BIBRDIC { get; set; }

    /// <summary>
    /// BIBRDID.
    /// </summary>
    public decimal? BIBRDID { get; set; }

    /// <summary>
    /// BIBRDBX.
    /// </summary>
    public decimal? BIBRDBX { get; set; }

    /// <summary>
    /// BIAMCU.
    /// </summary>
    public string? BIAMCU { get; set; }

    /// <summary>
    /// BIAOBJ.
    /// </summary>
    public string? BIAOBJ { get; set; }

    /// <summary>
    /// BIASUB.
    /// </summary>
    public string? BIASUB { get; set; }

    /// <summary>
    /// BIASBL.
    /// </summary>
    public string? BIASBL { get; set; }

    /// <summary>
    /// BIDMCU.
    /// </summary>
    public string? BIDMCU { get; set; }

    /// <summary>
    /// BIDOBJ.
    /// </summary>
    public string? BIDOBJ { get; set; }

    /// <summary>
    /// BIDSUB.
    /// </summary>
    public string? BIDSUB { get; set; }

    /// <summary>
    /// BITSBL.
    /// </summary>
    public string? BITSBL { get; set; }

    /// <summary>
    /// BIUSER.
    /// </summary>
    public string? BIUSER { get; set; }

    /// <summary>
    /// BIPID.
    /// </summary>
    public string? BIPID { get; set; }

    /// <summary>
    /// BIJOBN.
    /// </summary>
    public string? BIJOBN { get; set; }

    /// <summary>
    /// BIBRUPMJ.
    /// </summary>
    public decimal? BIBRUPMJ { get; set; }

    /// <summary>
    /// BIUPMT.
    /// </summary>
    public decimal? BIUPMT { get; set; }
}
