using System.ComponentModel.DataAnnotations.Schema;

namespace JDE.Models;

/// <summary>
/// F15L38 - .
/// </summary>
public class F15L38Model
{
    /// <summary>
    /// NZMCU (Primary Key).
    /// </summary>
    public string NZMCU { get; set; }

    /// <summary>
    /// NZRVNB (Primary Key).
    /// </summary>
    public decimal NZRVNB { get; set; }

    /// <summary>
    /// NZUNIT (Primary Key).
    /// </summary>
    public string NZUNIT { get; set; }

    /// <summary>
    /// NZDOCO (Primary Key).
    /// </summary>
    public decimal NZDOCO { get; set; }

    /// <summary>
    /// NZLSVR (Primary Key).
    /// </summary>
    public decimal NZLSVR { get; set; }

    /// <summary>
    /// NZEPCL (Primary Key).
    /// </summary>
    public string NZEPCL { get; set; }

    /// <summary>
    /// NZBCI (Primary Key).
    /// </summary>
    public decimal NZBCI { get; set; }

    /// <summary>
    /// NZCTRY (Primary Key).
    /// </summary>
    public decimal NZCTRY { get; set; }

    /// <summary>
    /// NZFY (Primary Key).
    /// </summary>
    public decimal NZFY { get; set; }

    /// <summary>
    /// NZPN (Primary Key).
    /// </summary>
    public decimal NZPN { get; set; }

    /// <summary>
    /// NZPOFE (Primary Key).
    /// </summary>
    public string NZPOFE { get; set; }

    /// <summary>
    /// NZEPGR.
    /// </summary>
    public string? NZEPGR { get; set; }

    /// <summary>
    /// NZEPSG.
    /// </summary>
    public string? NZEPSG { get; set; }

    /// <summary>
    /// NZTRBM.
    /// </summary>
    public decimal? NZTRBM { get; set; }

    /// <summary>
    /// NZTRBY.
    /// </summary>
    public decimal? NZTRBY { get; set; }

    /// <summary>
    /// NZTRB#.
    /// </summary>
    [Column("NZTRB#")]
    public decimal? NZTRB_ { get; set; }

    /// <summary>
    /// NZTREJ.
    /// </summary>
    public decimal? NZTREJ { get; set; }

    /// <summary>
    /// NZPTBM.
    /// </summary>
    public decimal? NZPTBM { get; set; }

    /// <summary>
    /// NZPTBY.
    /// </summary>
    public decimal? NZPTBY { get; set; }

    /// <summary>
    /// NZPTB#.
    /// </summary>
    [Column("NZPTB#")]
    public decimal? NZPTB_ { get; set; }

    /// <summary>
    /// NZPTEM.
    /// </summary>
    public decimal? NZPTEM { get; set; }

    /// <summary>
    /// NZPTEY.
    /// </summary>
    public decimal? NZPTEY { get; set; }

    /// <summary>
    /// NZPTE#.
    /// </summary>
    [Column("NZPTE#")]
    public decimal? NZPTE_ { get; set; }

    /// <summary>
    /// NZCLSX.
    /// </summary>
    public decimal? NZCLSX { get; set; }

    /// <summary>
    /// NZACTX.
    /// </summary>
    public decimal? NZACTX { get; set; }

    /// <summary>
    /// NZTRNX.
    /// </summary>
    public decimal? NZTRNX { get; set; }

    /// <summary>
    /// NZEPCP.
    /// </summary>
    public decimal? NZEPCP { get; set; }

    /// <summary>
    /// NZADEX.
    /// </summary>
    public decimal? NZADEX { get; set; }

    /// <summary>
    /// NZBSEX.
    /// </summary>
    public decimal? NZBSEX { get; set; }

    /// <summary>
    /// NZBPSM.
    /// </summary>
    public decimal? NZBPSM { get; set; }

    /// <summary>
    /// NZBPSY.
    /// </summary>
    public decimal? NZBPSY { get; set; }

    /// <summary>
    /// NZBPS#.
    /// </summary>
    [Column("NZBPS#")]
    public decimal? NZBPS_ { get; set; }

    /// <summary>
    /// NZCPFC.
    /// </summary>
    public decimal? NZCPFC { get; set; }

    /// <summary>
    /// NZCMPF.
    /// </summary>
    public decimal? NZCMPF { get; set; }

    /// <summary>
    /// NZTOTX.
    /// </summary>
    public decimal? NZTOTX { get; set; }

    /// <summary>
    /// NZNETX.
    /// </summary>
    public decimal? NZNETX { get; set; }

    /// <summary>
    /// NZEPOF.
    /// </summary>
    public decimal? NZEPOF { get; set; }

    /// <summary>
    /// NZEPCD.
    /// </summary>
    public string? NZEPCD { get; set; }

    /// <summary>
    /// NZECMP.
    /// </summary>
    public string? NZECMP { get; set; }

    /// <summary>
    /// NZDENM.
    /// </summary>
    public decimal? NZDENM { get; set; }

    /// <summary>
    /// NZSHFC.
    /// </summary>
    public decimal? NZSHFC { get; set; }

    /// <summary>
    /// NZGRSH.
    /// </summary>
    public decimal? NZGRSH { get; set; }

    /// <summary>
    /// NZGRPL.
    /// </summary>
    public decimal? NZGRPL { get; set; }

    /// <summary>
    /// NZSGRL.
    /// </summary>
    public decimal? NZSGRL { get; set; }

    /// <summary>
    /// NZSGAD.
    /// </summary>
    public decimal? NZSGAD { get; set; }

    /// <summary>
    /// NZGRAD.
    /// </summary>
    public decimal? NZGRAD { get; set; }

    /// <summary>
    /// NZOCRL.
    /// </summary>
    public string? NZOCRL { get; set; }

    /// <summary>
    /// NZOCPB.
    /// </summary>
    public decimal? NZOCPB { get; set; }

    /// <summary>
    /// NZOCPE.
    /// </summary>
    public decimal? NZOCPE { get; set; }

    /// <summary>
    /// NZOCAD.
    /// </summary>
    public decimal? NZOCAD { get; set; }

    /// <summary>
    /// NZEPLM.
    /// </summary>
    public decimal? NZEPLM { get; set; }

    /// <summary>
    /// NZNETS.
    /// </summary>
    public decimal? NZNETS { get; set; }

    /// <summary>
    /// NZAG.
    /// </summary>
    public decimal? NZAG { get; set; }

    /// <summary>
    /// NZCLSB.
    /// </summary>
    public decimal? NZCLSB { get; set; }

    /// <summary>
    /// NZFERT.
    /// </summary>
    public decimal? NZFERT { get; set; }

    /// <summary>
    /// NZFEEA.
    /// </summary>
    public decimal? NZFEEA { get; set; }

    /// <summary>
    /// NZGLC.
    /// </summary>
    public string? NZGLC { get; set; }

    /// <summary>
    /// NZDL01.
    /// </summary>
    public string? NZDL01 { get; set; }

    /// <summary>
    /// NZBRAD.
    /// </summary>
    public string? NZBRAD { get; set; }

    /// <summary>
    /// NZFEBS.
    /// </summary>
    public string? NZFEBS { get; set; }

    /// <summary>
    /// NZGPCT.
    /// </summary>
    public decimal? NZGPCT { get; set; }

    /// <summary>
    /// NZAAP.
    /// </summary>
    public decimal? NZAAP { get; set; }

    /// <summary>
    /// NZMSGF.
    /// </summary>
    public string? NZMSGF { get; set; }

    /// <summary>
    /// NZCLAF.
    /// </summary>
    public decimal? NZCLAF { get; set; }

    /// <summary>
    /// NZCLAA.
    /// </summary>
    public decimal? NZCLAA { get; set; }

    /// <summary>
    /// NZCAA2.
    /// </summary>
    public decimal? NZCAA2 { get; set; }

    /// <summary>
    /// NZEPCN.
    /// </summary>
    public decimal? NZEPCN { get; set; }

    /// <summary>
    /// NZEPLN.
    /// </summary>
    public decimal? NZEPLN { get; set; }

    /// <summary>
    /// NZBALN.
    /// </summary>
    public decimal? NZBALN { get; set; }

    /// <summary>
    /// NZBALX.
    /// </summary>
    public decimal? NZBALX { get; set; }

    /// <summary>
    /// NZBANC.
    /// </summary>
    public decimal? NZBANC { get; set; }

    /// <summary>
    /// NZBAXC.
    /// </summary>
    public decimal? NZBAXC { get; set; }

    /// <summary>
    /// NZBYCN.
    /// </summary>
    public decimal? NZBYCN { get; set; }

    /// <summary>
    /// NZBYCX.
    /// </summary>
    public decimal? NZBYCX { get; set; }

    /// <summary>
    /// NZBYLN.
    /// </summary>
    public decimal? NZBYLN { get; set; }

    /// <summary>
    /// NZBYLX.
    /// </summary>
    public decimal? NZBYLX { get; set; }

    /// <summary>
    /// NZEPCC.
    /// </summary>
    public string? NZEPCC { get; set; }

    /// <summary>
    /// NZCTCN.
    /// </summary>
    public string? NZCTCN { get; set; }

    /// <summary>
    /// NZCTCX.
    /// </summary>
    public string? NZCTCX { get; set; }

    /// <summary>
    /// NZCTLN.
    /// </summary>
    public string? NZCTLN { get; set; }

    /// <summary>
    /// NZCTLX.
    /// </summary>
    public string? NZCTLX { get; set; }

    /// <summary>
    /// NZEACN.
    /// </summary>
    public decimal? NZEACN { get; set; }

    /// <summary>
    /// NZEACM.
    /// </summary>
    public decimal? NZEACM { get; set; }

    /// <summary>
    /// NZEALN.
    /// </summary>
    public decimal? NZEALN { get; set; }

    /// <summary>
    /// NZEALM.
    /// </summary>
    public decimal? NZEALM { get; set; }

    /// <summary>
    /// NZTEXR.
    /// </summary>
    public string? NZTEXR { get; set; }

    /// <summary>
    /// NZCPVA.
    /// </summary>
    public decimal? NZCPVA { get; set; }

    /// <summary>
    /// NZSFDN.
    /// </summary>
    public string? NZSFDN { get; set; }

    /// <summary>
    /// NZEXCV.
    /// </summary>
    public decimal? NZEXCV { get; set; }

    /// <summary>
    /// NZCAPA.
    /// </summary>
    public decimal? NZCAPA { get; set; }

    /// <summary>
    /// NZAEPA.
    /// </summary>
    public decimal? NZAEPA { get; set; }

    /// <summary>
    /// NZPRORAT.
    /// </summary>
    public decimal? NZPRORAT { get; set; }

    /// <summary>
    /// NZAID.
    /// </summary>
    public string? NZAID { get; set; }

    /// <summary>
    /// NZURCD.
    /// </summary>
    public string? NZURCD { get; set; }

    /// <summary>
    /// NZURDT.
    /// </summary>
    public decimal? NZURDT { get; set; }

    /// <summary>
    /// NZURAT.
    /// </summary>
    public decimal? NZURAT { get; set; }

    /// <summary>
    /// NZURAB.
    /// </summary>
    public decimal? NZURAB { get; set; }

    /// <summary>
    /// NZURRF.
    /// </summary>
    public string? NZURRF { get; set; }

    /// <summary>
    /// NZUSER.
    /// </summary>
    public string? NZUSER { get; set; }

    /// <summary>
    /// NZPID.
    /// </summary>
    public string? NZPID { get; set; }

    /// <summary>
    /// NZUPMJ.
    /// </summary>
    public decimal? NZUPMJ { get; set; }

    /// <summary>
    /// NZUPMT.
    /// </summary>
    public decimal? NZUPMT { get; set; }

    /// <summary>
    /// NZJOBN.
    /// </summary>
    public string? NZJOBN { get; set; }

    /// <summary>
    /// NZCLEST.
    /// </summary>
    public decimal? NZCLEST { get; set; }

    /// <summary>
    /// NZCLEAID.
    /// </summary>
    public string? NZCLEAID { get; set; }

    /// <summary>
    /// NZCLACC.
    /// </summary>
    public decimal? NZCLACC { get; set; }

    /// <summary>
    /// NZCLAAID.
    /// </summary>
    public string? NZCLAAID { get; set; }

    /// <summary>
    /// NZCAPID.
    /// </summary>
    public string? NZCAPID { get; set; }

    /// <summary>
    /// NZCAPIDC.
    /// </summary>
    public string? NZCAPIDC { get; set; }

    /// <summary>
    /// NZCAPPCT.
    /// </summary>
    public decimal? NZCAPPCT { get; set; }

    /// <summary>
    /// NZCAPPCTC.
    /// </summary>
    public decimal? NZCAPPCTC { get; set; }

    /// <summary>
    /// NZCAPAMT.
    /// </summary>
    public decimal? NZCAPAMT { get; set; }

    /// <summary>
    /// NZCAPAMTC.
    /// </summary>
    public decimal? NZCAPAMTC { get; set; }

    /// <summary>
    /// NZACTAMT.
    /// </summary>
    public decimal? NZACTAMT { get; set; }

    /// <summary>
    /// NZACTAMTC.
    /// </summary>
    public decimal? NZACTAMTC { get; set; }

    /// <summary>
    /// NZEXSTCAP.
    /// </summary>
    public decimal? NZEXSTCAP { get; set; }

    /// <summary>
    /// NZEXSTCAPC.
    /// </summary>
    public decimal? NZEXSTCAPC { get; set; }

    /// <summary>
    /// NZEXNOCAP.
    /// </summary>
    public decimal? NZEXNOCAP { get; set; }

    /// <summary>
    /// NZEXNOCAPC.
    /// </summary>
    public decimal? NZEXNOCAPC { get; set; }

    /// <summary>
    /// NZCAPADJ.
    /// </summary>
    public decimal? NZCAPADJ { get; set; }

    /// <summary>
    /// NZCAPADJC.
    /// </summary>
    public decimal? NZCAPADJC { get; set; }

    /// <summary>
    /// NZOCGUA.
    /// </summary>
    public decimal? NZOCGUA { get; set; }

    /// <summary>
    /// NZEXREDST.
    /// </summary>
    public decimal? NZEXREDST { get; set; }

    /// <summary>
    /// NZBILLRAT.
    /// </summary>
    public decimal? NZBILLRAT { get; set; }

    /// <summary>
    /// NZBSEXG.
    /// </summary>
    public string? NZBSEXG { get; set; }

    /// <summary>
    /// NZCOMADJ.
    /// </summary>
    public decimal? NZCOMADJ { get; set; }

    /// <summary>
    /// NZCLAFAMT.
    /// </summary>
    public decimal? NZCLAFAMT { get; set; }

    /// <summary>
    /// NZRFREC.
    /// </summary>
    public decimal? NZRFREC { get; set; }

    /// <summary>
    /// NZRFRECC.
    /// </summary>
    public decimal? NZRFRECC { get; set; }

    /// <summary>
    /// NZGLMD.
    /// </summary>
    public string? NZGLMD { get; set; }

    /// <summary>
    /// NZPOCPCT.
    /// </summary>
    public decimal? NZPOCPCT { get; set; }

    /// <summary>
    /// NZEOCPCT.
    /// </summary>
    public decimal? NZEOCPCT { get; set; }

    /// <summary>
    /// NZFEEA2.
    /// </summary>
    public decimal? NZFEEA2 { get; set; }

    /// <summary>
    /// NZFEEA3.
    /// </summary>
    public decimal? NZFEEA3 { get; set; }

    /// <summary>
    /// NZBEXUOM.
    /// </summary>
    public decimal? NZBEXUOM { get; set; }

    /// <summary>
    /// NZORDNUM.
    /// </summary>
    public decimal? NZORDNUM { get; set; }

    /// <summary>
    /// NZLTGRP.
    /// </summary>
    public string? NZLTGRP { get; set; }

    /// <summary>
    /// NZAECBF.
    /// </summary>
    public string? NZAECBF { get; set; }

    /// <summary>
    /// NZALCBF.
    /// </summary>
    public string? NZALCBF { get; set; }

    /// <summary>
    /// NZACTADJ.
    /// </summary>
    public decimal? NZACTADJ { get; set; }
}
