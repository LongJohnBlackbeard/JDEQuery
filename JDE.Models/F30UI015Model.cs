using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F30UI015 - .
/// </summary>
public class F30UI015Model
{
    /// <summary>
    /// BDBOML.
    /// </summary>
    public decimal? BDBOML { get; set; }

    /// <summary>
    /// BDKIT (Primary Key).
    /// </summary>
    public decimal BDKIT { get; set; }

    /// <summary>
    /// BDMMCU (Primary Key).
    /// </summary>
    public string BDMMCU { get; set; }

    /// <summary>
    /// BDTBM (Primary Key).
    /// </summary>
    public string BDTBM { get; set; }

    /// <summary>
    /// BDBQTY (Primary Key).
    /// </summary>
    public decimal BDBQTY { get; set; }

    /// <summary>
    /// BDUOM.
    /// </summary>
    public string? BDUOM { get; set; }

    /// <summary>
    /// BDITM.
    /// </summary>
    public decimal? BDITM { get; set; }

    /// <summary>
    /// BDCMCU.
    /// </summary>
    public string? BDCMCU { get; set; }

    /// <summary>
    /// BDQNTY.
    /// </summary>
    public decimal? BDQNTY { get; set; }

    /// <summary>
    /// BDEXQTY.
    /// </summary>
    public decimal? BDEXQTY { get; set; }

    /// <summary>
    /// BDUM.
    /// </summary>
    public string? BDUM { get; set; }

    /// <summary>
    /// BDEFFF.
    /// </summary>
    public decimal? BDEFFF { get; set; }

    /// <summary>
    /// BDEFFT.
    /// </summary>
    public decimal? BDEFFT { get; set; }

    /// <summary>
    /// BDBREV (Primary Key).
    /// </summary>
    public string BDBREV { get; set; }

    /// <summary>
    /// BDCMRV.
    /// </summary>
    public string? BDCMRV { get; set; }

    /// <summary>
    /// BDF$RP.
    /// </summary>
    [Column("BDF$RP")]
    public decimal? BDF_RP { get; set; }

    /// <summary>
    /// BDCPNB.
    /// </summary>
    public decimal? BDCPNB { get; set; }

    /// <summary>
    /// BDOPSQ.
    /// </summary>
    public decimal? BDOPSQ { get; set; }

    /// <summary>
    /// BDSCRP.
    /// </summary>
    public decimal? BDSCRP { get; set; }

    /// <summary>
    /// BDSTPP.
    /// </summary>
    public decimal? BDSTPP { get; set; }

    /// <summary>
    /// BDLBND (Primary Key).
    /// </summary>
    public decimal BDLBND { get; set; }

    /// <summary>
    /// BDRBND.
    /// </summary>
    public decimal? BDRBND { get; set; }

    /// <summary>
    /// BDL1PITM.
    /// </summary>
    public decimal? BDL1PITM { get; set; }

    /// <summary>
    /// BDL2PITM.
    /// </summary>
    public decimal? BDL2PITM { get; set; }

    /// <summary>
    /// BDL3PITM.
    /// </summary>
    public decimal? BDL3PITM { get; set; }

    /// <summary>
    /// BDL4PITM.
    /// </summary>
    public decimal? BDL4PITM { get; set; }

    /// <summary>
    /// BDL5PITM.
    /// </summary>
    public decimal? BDL5PITM { get; set; }

    /// <summary>
    /// BDL6PITM.
    /// </summary>
    public decimal? BDL6PITM { get; set; }

    /// <summary>
    /// BDL7PITM.
    /// </summary>
    public decimal? BDL7PITM { get; set; }

    /// <summary>
    /// BDL8PITM.
    /// </summary>
    public decimal? BDL8PITM { get; set; }

    /// <summary>
    /// BDL9PITM.
    /// </summary>
    public decimal? BDL9PITM { get; set; }

    /// <summary>
    /// BDL10PITM.
    /// </summary>
    public decimal? BDL10PITM { get; set; }

    /// <summary>
    /// BDUKID.
    /// </summary>
    public decimal? BDUKID { get; set; }

    /// <summary>
    /// BDURCD.
    /// </summary>
    public string? BDURCD { get; set; }

    /// <summary>
    /// BDURDT.
    /// </summary>
    public decimal? BDURDT { get; set; }

    /// <summary>
    /// BDURAT.
    /// </summary>
    public decimal? BDURAT { get; set; }

    /// <summary>
    /// BDURAB.
    /// </summary>
    public decimal? BDURAB { get; set; }

    /// <summary>
    /// BDURRF.
    /// </summary>
    public string? BDURRF { get; set; }

    /// <summary>
    /// BDUSER.
    /// </summary>
    public string? BDUSER { get; set; }

    /// <summary>
    /// BDPID.
    /// </summary>
    public string? BDPID { get; set; }

    /// <summary>
    /// BDUPMJ.
    /// </summary>
    public decimal? BDUPMJ { get; set; }

    /// <summary>
    /// BDTDAY.
    /// </summary>
    public decimal? BDTDAY { get; set; }

    /// <summary>
    /// BDMKEY.
    /// </summary>
    public string? BDMKEY { get; set; }
}
