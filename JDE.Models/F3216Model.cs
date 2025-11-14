using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F3216 - .
/// </summary>
public class F3216Model
{
    /// <summary>
    /// PCCFGID (Primary Key).
    /// </summary>
    public decimal PCCFGID { get; set; }

    /// <summary>
    /// PCCFGCID (Primary Key).
    /// </summary>
    public decimal PCCFGCID { get; set; }

    /// <summary>
    /// PCSEQN (Primary Key).
    /// </summary>
    public decimal PCSEQN { get; set; }

    /// <summary>
    /// PCDSC1.
    /// </summary>
    public string? PCDSC1 { get; set; }

    /// <summary>
    /// PCLNTY (Primary Key).
    /// </summary>
    public string PCLNTY { get; set; }

    /// <summary>
    /// PCPRU (Primary Key).
    /// </summary>
    public string PCPRU { get; set; }

    /// <summary>
    /// PCSOCF.
    /// </summary>
    public string? PCSOCF { get; set; }

    /// <summary>
    /// PCFOVQ.
    /// </summary>
    public string? PCFOVQ { get; set; }

    /// <summary>
    /// PCATMU.
    /// </summary>
    public decimal? PCATMU { get; set; }

    /// <summary>
    /// PCECST.
    /// </summary>
    public decimal? PCECST { get; set; }

    /// <summary>
    /// PCFEC.
    /// </summary>
    public decimal? PCFEC { get; set; }

    /// <summary>
    /// PCAEXP.
    /// </summary>
    public decimal? PCAEXP { get; set; }

    /// <summary>
    /// PCFEA.
    /// </summary>
    public decimal? PCFEA { get; set; }

    /// <summary>
    /// PCATOT.
    /// </summary>
    public string? PCATOT { get; set; }

    /// <summary>
    /// PCATO#.
    /// </summary>
    [Column("PCATO#")]
    public decimal? PCATO_ { get; set; }

    /// <summary>
    /// PCATOS.
    /// </summary>
    public decimal? PCATOS { get; set; }

    /// <summary>
    /// PCLNID.
    /// </summary>
    public decimal? PCLNID { get; set; }

    /// <summary>
    /// PCAKID.
    /// </summary>
    public decimal? PCAKID { get; set; }

    /// <summary>
    /// PCURCD.
    /// </summary>
    public string? PCURCD { get; set; }

    /// <summary>
    /// PCURDT.
    /// </summary>
    public decimal? PCURDT { get; set; }

    /// <summary>
    /// PCURAT.
    /// </summary>
    public decimal? PCURAT { get; set; }

    /// <summary>
    /// PCURAB.
    /// </summary>
    public decimal? PCURAB { get; set; }

    /// <summary>
    /// PCURRF.
    /// </summary>
    public string? PCURRF { get; set; }

    /// <summary>
    /// PCUSER.
    /// </summary>
    public string? PCUSER { get; set; }

    /// <summary>
    /// PCPID.
    /// </summary>
    public string? PCPID { get; set; }

    /// <summary>
    /// PCJOBN.
    /// </summary>
    public string? PCJOBN { get; set; }

    /// <summary>
    /// PCUPMJ.
    /// </summary>
    public decimal? PCUPMJ { get; set; }

    /// <summary>
    /// PCTDAY.
    /// </summary>
    public decimal? PCTDAY { get; set; }
}
