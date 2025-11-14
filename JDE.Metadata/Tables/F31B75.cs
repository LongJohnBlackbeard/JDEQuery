using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B75 - .
/// </summary>
public class F31B75 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OCWCFGID.
        /// </summary>
        public const string OCWCFGID = "OCWCFGID";

        /// <summary>
        /// OCWCOPCD.
        /// </summary>
        public const string OCWCOPCD = "OCWCOPCD";

        /// <summary>
        /// OCWCDL01.
        /// </summary>
        public const string OCWCDL01 = "OCWCDL01";

        /// <summary>
        /// OCWBOPID.
        /// </summary>
        public const string OCWBOPID = "OCWBOPID";

        /// <summary>
        /// OCWBOPCD.
        /// </summary>
        public const string OCWBOPCD = "OCWBOPCD";

        /// <summary>
        /// OCWHAR.
        /// </summary>
        public const string OCWHAR = "OCWHAR";

        /// <summary>
        /// OCWMVOPF.
        /// </summary>
        public const string OCWMVOPF = "OCWMVOPF";

        /// <summary>
        /// OCWFVTY.
        /// </summary>
        public const string OCWFVTY = "OCWFVTY";

        /// <summary>
        /// OCWTVTY.
        /// </summary>
        public const string OCWTVTY = "OCWTVTY";

        /// <summary>
        /// OCWBEXTF.
        /// </summary>
        public const string OCWBEXTF = "OCWBEXTF";

        /// <summary>
        /// OCINSTMET.
        /// </summary>
        public const string OCINSTMET = "OCINSTMET";

        /// <summary>
        /// OCDISTMET.
        /// </summary>
        public const string OCDISTMET = "OCDISTMET";

        /// <summary>
        /// OCWPSD.
        /// </summary>
        public const string OCWPSD = "OCWPSD";

        /// <summary>
        /// OCWPAD.
        /// </summary>
        public const string OCWPAD = "OCWPAD";

        /// <summary>
        /// OCWSBDV.
        /// </summary>
        public const string OCWSBDV = "OCWSBDV";

        /// <summary>
        /// OCWOPTTL.
        /// </summary>
        public const string OCWOPTTL = "OCWOPTTL";

        /// <summary>
        /// OCWVCH.
        /// </summary>
        public const string OCWVCH = "OCWVCH";

        /// <summary>
        /// OCWVTCH.
        /// </summary>
        public const string OCWVTCH = "OCWVTCH";

        /// <summary>
        /// OCWFRMAT.
        /// </summary>
        public const string OCWFRMAT = "OCWFRMAT";

        /// <summary>
        /// OCFMTUOM.
        /// </summary>
        public const string OCFMTUOM = "OCFMTUOM";

        /// <summary>
        /// OCWTRMAT.
        /// </summary>
        public const string OCWTRMAT = "OCWTRMAT";

        /// <summary>
        /// OCTMTUOM.
        /// </summary>
        public const string OCTMTUOM = "OCTMTUOM";

        /// <summary>
        /// OCWFAWS.
        /// </summary>
        public const string OCWFAWS = "OCWFAWS";

        /// <summary>
        /// OCWTAWS.
        /// </summary>
        public const string OCWTAWS = "OCWTAWS";

        /// <summary>
        /// OCWDBMET.
        /// </summary>
        public const string OCWDBMET = "OCWDBMET";

        /// <summary>
        /// OCWTBMET.
        /// </summary>
        public const string OCWTBMET = "OCWTBMET";

        /// <summary>
        /// OCWFINA1.
        /// </summary>
        public const string OCWFINA1 = "OCWFINA1";

        /// <summary>
        /// OCWFINA2.
        /// </summary>
        public const string OCWFINA2 = "OCWFINA2";

        /// <summary>
        /// OCWFINA3.
        /// </summary>
        public const string OCWFINA3 = "OCWFINA3";

        /// <summary>
        /// OCWFINA4.
        /// </summary>
        public const string OCWFINA4 = "OCWFINA4";

        /// <summary>
        /// OCWFINA5.
        /// </summary>
        public const string OCWFINA5 = "OCWFINA5";

        /// <summary>
        /// OCWFINA6.
        /// </summary>
        public const string OCWFINA6 = "OCWFINA6";

        /// <summary>
        /// OCWFINA7.
        /// </summary>
        public const string OCWFINA7 = "OCWFINA7";

        /// <summary>
        /// OCWFINA8.
        /// </summary>
        public const string OCWFINA8 = "OCWFINA8";

        /// <summary>
        /// OCWFINA9.
        /// </summary>
        public const string OCWFINA9 = "OCWFINA9";

        /// <summary>
        /// OCWFINA10.
        /// </summary>
        public const string OCWFINA10 = "OCWFINA10";

        /// <summary>
        /// OCWFINA11.
        /// </summary>
        public const string OCWFINA11 = "OCWFINA11";

        /// <summary>
        /// OCWFINA12.
        /// </summary>
        public const string OCWFINA12 = "OCWFINA12";

        /// <summary>
        /// OCWTINA1.
        /// </summary>
        public const string OCWTINA1 = "OCWTINA1";

        /// <summary>
        /// OCWTINA2.
        /// </summary>
        public const string OCWTINA2 = "OCWTINA2";

        /// <summary>
        /// OCWTINA3.
        /// </summary>
        public const string OCWTINA3 = "OCWTINA3";

        /// <summary>
        /// OCWTINA4.
        /// </summary>
        public const string OCWTINA4 = "OCWTINA4";

        /// <summary>
        /// OCWTINA5.
        /// </summary>
        public const string OCWTINA5 = "OCWTINA5";

        /// <summary>
        /// OCWTINA6.
        /// </summary>
        public const string OCWTINA6 = "OCWTINA6";

        /// <summary>
        /// OCWTINA7.
        /// </summary>
        public const string OCWTINA7 = "OCWTINA7";

        /// <summary>
        /// OCWTINA8.
        /// </summary>
        public const string OCWTINA8 = "OCWTINA8";

        /// <summary>
        /// OCWTINA9.
        /// </summary>
        public const string OCWTINA9 = "OCWTINA9";

        /// <summary>
        /// OCWTINA10.
        /// </summary>
        public const string OCWTINA10 = "OCWTINA10";

        /// <summary>
        /// OCWTINA11.
        /// </summary>
        public const string OCWTINA11 = "OCWTINA11";

        /// <summary>
        /// OCWTINA12.
        /// </summary>
        public const string OCWTINA12 = "OCWTINA12";

        /// <summary>
        /// OCWPOPGL.
        /// </summary>
        public const string OCWPOPGL = "OCWPOPGL";

        /// <summary>
        /// OCWAOPGL.
        /// </summary>
        public const string OCWAOPGL = "OCWAOPGL";

        /// <summary>
        /// OCWTLCAM.
        /// </summary>
        public const string OCWTLCAM = "OCWTLCAM";

        /// <summary>
        /// OCWCOC01.
        /// </summary>
        public const string OCWCOC01 = "OCWCOC01";

        /// <summary>
        /// OCWCOC02.
        /// </summary>
        public const string OCWCOC02 = "OCWCOC02";

        /// <summary>
        /// OCWCOC03.
        /// </summary>
        public const string OCWCOC03 = "OCWCOC03";

        /// <summary>
        /// OCWCOC04.
        /// </summary>
        public const string OCWCOC04 = "OCWCOC04";

        /// <summary>
        /// OCWCOC05.
        /// </summary>
        public const string OCWCOC05 = "OCWCOC05";

        /// <summary>
        /// OCWLVAL.
        /// </summary>
        public const string OCWLVAL = "OCWLVAL";

        /// <summary>
        /// OCWSVAL.
        /// </summary>
        public const string OCWSVAL = "OCWSVAL";

        /// <summary>
        /// OCMTVAL.
        /// </summary>
        public const string OCMTVAL = "OCMTVAL";

        /// <summary>
        /// OCEQVAL.
        /// </summary>
        public const string OCEQVAL = "OCEQVAL";

        /// <summary>
        /// OCVTVAL.
        /// </summary>
        public const string OCVTVAL = "OCVTVAL";

        /// <summary>
        /// OCWEURF.
        /// </summary>
        public const string OCWEURF = "OCWEURF";

        /// <summary>
        /// OCWOWNF.
        /// </summary>
        public const string OCWOWNF = "OCWOWNF";

        /// <summary>
        /// OCWMTTYF.
        /// </summary>
        public const string OCWMTTYF = "OCWMTTYF";

        /// <summary>
        /// OCWWISTF.
        /// </summary>
        public const string OCWWISTF = "OCWWISTF";

        /// <summary>
        /// OCWBIDF.
        /// </summary>
        public const string OCWBIDF = "OCWBIDF";

        /// <summary>
        /// OCWSTYF.
        /// </summary>
        public const string OCWSTYF = "OCWSTYF";

        /// <summary>
        /// OCWVSTYF.
        /// </summary>
        public const string OCWVSTYF = "OCWVSTYF";

        /// <summary>
        /// OCWLOTCF.
        /// </summary>
        public const string OCWLOTCF = "OCWLOTCF";

        /// <summary>
        /// OCWLOTAF.
        /// </summary>
        public const string OCWLOTAF = "OCWLOTAF";

        /// <summary>
        /// OCWCOMPF.
        /// </summary>
        public const string OCWCOMPF = "OCWCOMPF";

        /// <summary>
        /// OCWACADF.
        /// </summary>
        public const string OCWACADF = "OCWACADF";

        /// <summary>
        /// OCBOSNR.
        /// </summary>
        public const string OCBOSNR = "OCBOSNR";

        /// <summary>
        /// OCSTSPTM.
        /// </summary>
        public const string OCSTSPTM = "OCSTSPTM";

        /// <summary>
        /// OCWQTYTHD.
        /// </summary>
        public const string OCWQTYTHD = "OCWQTYTHD";

        /// <summary>
        /// OCWRLOPF.
        /// </summary>
        public const string OCWRLOPF = "OCWRLOPF";

        /// <summary>
        /// OCQSPC.
        /// </summary>
        public const string OCQSPC = "OCQSPC";

        /// <summary>
        /// OCQTST.
        /// </summary>
        public const string OCQTST = "OCQTST";

        /// <summary>
        /// OCDCT.
        /// </summary>
        public const string OCDCT = "OCDCT";

        /// <summary>
        /// OCURCD.
        /// </summary>
        public const string OCURCD = "OCURCD";

        /// <summary>
        /// OCURDT.
        /// </summary>
        public const string OCURDT = "OCURDT";

        /// <summary>
        /// OCURAT.
        /// </summary>
        public const string OCURAT = "OCURAT";

        /// <summary>
        /// OCURAB.
        /// </summary>
        public const string OCURAB = "OCURAB";

        /// <summary>
        /// OCURRF.
        /// </summary>
        public const string OCURRF = "OCURRF";

        /// <summary>
        /// OCWNUM.
        /// </summary>
        public const string OCWNUM = "OCWNUM";

        /// <summary>
        /// OCWMDT.
        /// </summary>
        public const string OCWMDT = "OCWMDT";

        /// <summary>
        /// OCWAB.
        /// </summary>
        public const string OCWAB = "OCWAB";

        /// <summary>
        /// OCWCD.
        /// </summary>
        public const string OCWCD = "OCWCD";

        /// <summary>
        /// OCWRF.
        /// </summary>
        public const string OCWRF = "OCWRF";

        /// <summary>
        /// OCUSER.
        /// </summary>
        public const string OCUSER = "OCUSER";

        /// <summary>
        /// OCPID.
        /// </summary>
        public const string OCPID = "OCPID";

        /// <summary>
        /// OCJOBN.
        /// </summary>
        public const string OCJOBN = "OCJOBN";

        /// <summary>
        /// OCUPMJ.
        /// </summary>
        public const string OCUPMJ = "OCUPMJ";

        /// <summary>
        /// OCTDAY.
        /// </summary>
        public const string OCTDAY = "OCTDAY";

        /// <summary>
        /// OCWCG.
        /// </summary>
        public const string OCWCG = "OCWCG";

        /// <summary>
        /// OCWSGLF.
        /// </summary>
        public const string OCWSGLF = "OCWSGLF";

        /// <summary>
        /// OCWOGLF.
        /// </summary>
        public const string OCWOGLF = "OCWOGLF";

        /// <summary>
        /// OCWAOTC.
        /// </summary>
        public const string OCWAOTC = "OCWAOTC";

        /// <summary>
        /// OCWSCOST.
        /// </summary>
        public const string OCWSCOST = "OCWSCOST";

        /// <summary>
        /// OCWOCOST.
        /// </summary>
        public const string OCWOCOST = "OCWOCOST";

        /// <summary>
        /// OCWLNB.
        /// </summary>
        public const string OCWLNB = "OCWLNB";

        /// <summary>
        /// OCWLNA.
        /// </summary>
        public const string OCWLNA = "OCWLNA";

        /// <summary>
        /// OCWLNS.
        /// </summary>
        public const string OCWLNS = "OCWLNS";

        /// <summary>
        /// OCWLNO.
        /// </summary>
        public const string OCWLNO = "OCWLNO";

        /// <summary>
        /// OCINSZERO1.
        /// </summary>
        public const string OCINSZERO1 = "OCINSZERO1";

        /// <summary>
        /// OCINSZERO2.
        /// </summary>
        public const string OCINSZERO2 = "OCINSZERO2";

        /// <summary>
        /// OCINSZERO3.
        /// </summary>
        public const string OCINSZERO3 = "OCINSZERO3";

        /// <summary>
        /// OCINSZERO4.
        /// </summary>
        public const string OCINSZERO4 = "OCINSZERO4";

        /// <summary>
        /// OCTASKTYPE.
        /// </summary>
        public const string OCTASKTYPE = "OCTASKTYPE";

        /// <summary>
        /// OCWFRTFLG.
        /// </summary>
        public const string OCWFRTFLG = "OCWFRTFLG";

        /// <summary>
        /// OCFVBTUSE.
        /// </summary>
        public const string OCFVBTUSE = "OCFVBTUSE";

        /// <summary>
        /// OCTVBTUSE.
        /// </summary>
        public const string OCTVBTUSE = "OCTVBTUSE";

        /// <summary>
        /// OCFCNTTYP.
        /// </summary>
        public const string OCFCNTTYP = "OCFCNTTYP";

        /// <summary>
        /// OCTCNTTYP.
        /// </summary>
        public const string OCTCNTTYP = "OCTCNTTYP";

        /// <summary>
        /// OCVALHAR.
        /// </summary>
        public const string OCVALHAR = "OCVALHAR";

        /// <summary>
        /// OCVALPRR.
        /// </summary>
        public const string OCVALPRR = "OCVALPRR";

        /// <summary>
        /// OCVALREN.
        /// </summary>
        public const string OCVALREN = "OCVALREN";

        /// <summary>
        /// OCVALSUB.
        /// </summary>
        public const string OCVALSUB = "OCVALSUB";

        /// <summary>
        /// OCWHRSF.
        /// </summary>
        public const string OCWHRSF = "OCWHRSF";

        /// <summary>
        /// OCWEQPF.
        /// </summary>
        public const string OCWEQPF = "OCWEQPF";

        /// <summary>
        /// OCWCONF.
        /// </summary>
        public const string OCWCONF = "OCWCONF";

        /// <summary>
        /// OCPRMSNTYP.
        /// </summary>
        public const string OCPRMSNTYP = "OCPRMSNTYP";

        /// <summary>
        /// OCWCF.
        /// </summary>
        public const string OCWCF = "OCWCF";

        /// <summary>
        /// OCTINSZRO1.
        /// </summary>
        public const string OCTINSZRO1 = "OCTINSZRO1";

        /// <summary>
        /// OCTINSZRO2.
        /// </summary>
        public const string OCTINSZRO2 = "OCTINSZRO2";

        /// <summary>
        /// OCTINSZRO3.
        /// </summary>
        public const string OCTINSZRO3 = "OCTINSZRO3";

        /// <summary>
        /// OCTINSZRO4.
        /// </summary>
        public const string OCTINSZRO4 = "OCTINSZRO4";

        /// <summary>
        /// OCPRCPTF.
        /// </summary>
        public const string OCPRCPTF = "OCPRCPTF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B75";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OCWCFGID", "OCWCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("OCWCOPCD", "OCWCOPCD", JdeDataType.String, 20),
        new JdeField("OCWCDL01", "OCWCDL01", JdeDataType.String, 60),
        new JdeField("OCWBOPID", "OCWBOPID", JdeDataType.Numeric),
        new JdeField("OCWBOPCD", "OCWBOPCD", JdeDataType.String, 20),
        new JdeField("OCWHAR", "OCWHAR", JdeDataType.String, 2),
        new JdeField("OCWMVOPF", "OCWMVOPF", JdeDataType.String, 2),
        new JdeField("OCWFVTY", "OCWFVTY", JdeDataType.String, 2),
        new JdeField("OCWTVTY", "OCWTVTY", JdeDataType.String, 2),
        new JdeField("OCWBEXTF", "OCWBEXTF", JdeDataType.String, 2),
        new JdeField("OCINSTMET", "OCINSTMET", JdeDataType.String, 2),
        new JdeField("OCDISTMET", "OCDISTMET", JdeDataType.String, 2),
        new JdeField("OCWPSD", "OCWPSD", JdeDataType.String, 2),
        new JdeField("OCWPAD", "OCWPAD", JdeDataType.String, 2),
        new JdeField("OCWSBDV", "OCWSBDV", JdeDataType.String, 2),
        new JdeField("OCWOPTTL", "OCWOPTTL", JdeDataType.String, 100),
        new JdeField("OCWVCH", "OCWVCH", JdeDataType.String, 40),
        new JdeField("OCWVTCH", "OCWVTCH", JdeDataType.String, 40),
        new JdeField("OCWFRMAT", "OCWFRMAT", JdeDataType.String, 8),
        new JdeField("OCFMTUOM", "OCFMTUOM", JdeDataType.String, 4),
        new JdeField("OCWTRMAT", "OCWTRMAT", JdeDataType.String, 8),
        new JdeField("OCTMTUOM", "OCTMTUOM", JdeDataType.String, 4),
        new JdeField("OCWFAWS", "OCWFAWS", JdeDataType.String, 12),
        new JdeField("OCWTAWS", "OCWTAWS", JdeDataType.String, 12),
        new JdeField("OCWDBMET", "OCWDBMET", JdeDataType.String, 20),
        new JdeField("OCWTBMET", "OCWTBMET", JdeDataType.String, 20),
        new JdeField("OCWFINA1", "OCWFINA1", JdeDataType.Numeric),
        new JdeField("OCWFINA2", "OCWFINA2", JdeDataType.Numeric),
        new JdeField("OCWFINA3", "OCWFINA3", JdeDataType.Numeric),
        new JdeField("OCWFINA4", "OCWFINA4", JdeDataType.Numeric),
        new JdeField("OCWFINA5", "OCWFINA5", JdeDataType.String, 40),
        new JdeField("OCWFINA6", "OCWFINA6", JdeDataType.String, 40),
        new JdeField("OCWFINA7", "OCWFINA7", JdeDataType.String, 40),
        new JdeField("OCWFINA8", "OCWFINA8", JdeDataType.String, 40),
        new JdeField("OCWFINA9", "OCWFINA9", JdeDataType.Numeric),
        new JdeField("OCWFINA10", "OCWFINA10", JdeDataType.Numeric),
        new JdeField("OCWFINA11", "OCWFINA11", JdeDataType.Numeric),
        new JdeField("OCWFINA12", "OCWFINA12", JdeDataType.Numeric),
        new JdeField("OCWTINA1", "OCWTINA1", JdeDataType.Numeric),
        new JdeField("OCWTINA2", "OCWTINA2", JdeDataType.Numeric),
        new JdeField("OCWTINA3", "OCWTINA3", JdeDataType.Numeric),
        new JdeField("OCWTINA4", "OCWTINA4", JdeDataType.Numeric),
        new JdeField("OCWTINA5", "OCWTINA5", JdeDataType.String, 40),
        new JdeField("OCWTINA6", "OCWTINA6", JdeDataType.String, 40),
        new JdeField("OCWTINA7", "OCWTINA7", JdeDataType.String, 40),
        new JdeField("OCWTINA8", "OCWTINA8", JdeDataType.String, 40),
        new JdeField("OCWTINA9", "OCWTINA9", JdeDataType.Numeric),
        new JdeField("OCWTINA10", "OCWTINA10", JdeDataType.Numeric),
        new JdeField("OCWTINA11", "OCWTINA11", JdeDataType.Numeric),
        new JdeField("OCWTINA12", "OCWTINA12", JdeDataType.Numeric),
        new JdeField("OCWPOPGL", "OCWPOPGL", JdeDataType.Numeric),
        new JdeField("OCWAOPGL", "OCWAOPGL", JdeDataType.Numeric),
        new JdeField("OCWTLCAM", "OCWTLCAM", JdeDataType.String, 20),
        new JdeField("OCWCOC01", "OCWCOC01", JdeDataType.String, 20),
        new JdeField("OCWCOC02", "OCWCOC02", JdeDataType.String, 20),
        new JdeField("OCWCOC03", "OCWCOC03", JdeDataType.String, 20),
        new JdeField("OCWCOC04", "OCWCOC04", JdeDataType.String, 20),
        new JdeField("OCWCOC05", "OCWCOC05", JdeDataType.String, 20),
        new JdeField("OCWLVAL", "OCWLVAL", JdeDataType.String, 2),
        new JdeField("OCWSVAL", "OCWSVAL", JdeDataType.String, 2),
        new JdeField("OCMTVAL", "OCMTVAL", JdeDataType.String, 2),
        new JdeField("OCEQVAL", "OCEQVAL", JdeDataType.String, 2),
        new JdeField("OCVTVAL", "OCVTVAL", JdeDataType.String, 2),
        new JdeField("OCWEURF", "OCWEURF", JdeDataType.String, 2),
        new JdeField("OCWOWNF", "OCWOWNF", JdeDataType.String, 2),
        new JdeField("OCWMTTYF", "OCWMTTYF", JdeDataType.String, 2),
        new JdeField("OCWWISTF", "OCWWISTF", JdeDataType.String, 2),
        new JdeField("OCWBIDF", "OCWBIDF", JdeDataType.String, 2),
        new JdeField("OCWSTYF", "OCWSTYF", JdeDataType.String, 2),
        new JdeField("OCWVSTYF", "OCWVSTYF", JdeDataType.String, 2),
        new JdeField("OCWLOTCF", "OCWLOTCF", JdeDataType.String, 2),
        new JdeField("OCWLOTAF", "OCWLOTAF", JdeDataType.String, 2),
        new JdeField("OCWCOMPF", "OCWCOMPF", JdeDataType.String, 2),
        new JdeField("OCWACADF", "OCWACADF", JdeDataType.String, 2),
        new JdeField("OCBOSNR", "OCBOSNR", JdeDataType.String, 2),
        new JdeField("OCSTSPTM", "OCSTSPTM", JdeDataType.String, 2),
        new JdeField("OCWQTYTHD", "OCWQTYTHD", JdeDataType.Numeric),
        new JdeField("OCWRLOPF", "OCWRLOPF", JdeDataType.String, 2),
        new JdeField("OCQSPC", "OCQSPC", JdeDataType.String, 50),
        new JdeField("OCQTST", "OCQTST", JdeDataType.String, 50),
        new JdeField("OCDCT", "OCDCT", JdeDataType.String, 4),
        new JdeField("OCURCD", "OCURCD", JdeDataType.String, 4),
        new JdeField("OCURDT", "OCURDT", JdeDataType.Numeric),
        new JdeField("OCURAT", "OCURAT", JdeDataType.Numeric),
        new JdeField("OCURAB", "OCURAB", JdeDataType.Numeric),
        new JdeField("OCURRF", "OCURRF", JdeDataType.String, 30),
        new JdeField("OCWNUM", "OCWNUM", JdeDataType.Numeric),
        new JdeField("OCWMDT", "OCWMDT", JdeDataType.Numeric),
        new JdeField("OCWAB", "OCWAB", JdeDataType.Numeric),
        new JdeField("OCWCD", "OCWCD", JdeDataType.String, 6),
        new JdeField("OCWRF", "OCWRF", JdeDataType.String, 60),
        new JdeField("OCUSER", "OCUSER", JdeDataType.String, 20),
        new JdeField("OCPID", "OCPID", JdeDataType.String, 20),
        new JdeField("OCJOBN", "OCJOBN", JdeDataType.String, 20),
        new JdeField("OCUPMJ", "OCUPMJ", JdeDataType.Numeric),
        new JdeField("OCTDAY", "OCTDAY", JdeDataType.Numeric),
        new JdeField("OCWCG", "OCWCG", JdeDataType.String, 24),
        new JdeField("OCWSGLF", "OCWSGLF", JdeDataType.String, 2),
        new JdeField("OCWOGLF", "OCWOGLF", JdeDataType.String, 2),
        new JdeField("OCWAOTC", "OCWAOTC", JdeDataType.String, 2),
        new JdeField("OCWSCOST", "OCWSCOST", JdeDataType.String, 24),
        new JdeField("OCWOCOST", "OCWOCOST", JdeDataType.String, 24),
        new JdeField("OCWLNB", "OCWLNB", JdeDataType.Numeric),
        new JdeField("OCWLNA", "OCWLNA", JdeDataType.Numeric),
        new JdeField("OCWLNS", "OCWLNS", JdeDataType.Numeric),
        new JdeField("OCWLNO", "OCWLNO", JdeDataType.Numeric),
        new JdeField("OCINSZERO1", "OCINSZERO1", JdeDataType.String, 2),
        new JdeField("OCINSZERO2", "OCINSZERO2", JdeDataType.String, 2),
        new JdeField("OCINSZERO3", "OCINSZERO3", JdeDataType.String, 2),
        new JdeField("OCINSZERO4", "OCINSZERO4", JdeDataType.String, 2),
        new JdeField("OCTASKTYPE", "OCTASKTYPE", JdeDataType.String, 4),
        new JdeField("OCWFRTFLG", "OCWFRTFLG", JdeDataType.String, 2),
        new JdeField("OCFVBTUSE", "OCFVBTUSE", JdeDataType.String, 2),
        new JdeField("OCTVBTUSE", "OCTVBTUSE", JdeDataType.String, 2),
        new JdeField("OCFCNTTYP", "OCFCNTTYP", JdeDataType.String, 8),
        new JdeField("OCTCNTTYP", "OCTCNTTYP", JdeDataType.String, 8),
        new JdeField("OCVALHAR", "OCVALHAR", JdeDataType.String, 2),
        new JdeField("OCVALPRR", "OCVALPRR", JdeDataType.String, 2),
        new JdeField("OCVALREN", "OCVALREN", JdeDataType.String, 2),
        new JdeField("OCVALSUB", "OCVALSUB", JdeDataType.String, 2),
        new JdeField("OCWHRSF", "OCWHRSF", JdeDataType.String, 2),
        new JdeField("OCWEQPF", "OCWEQPF", JdeDataType.String, 2),
        new JdeField("OCWCONF", "OCWCONF", JdeDataType.String, 2),
        new JdeField("OCPRMSNTYP", "OCPRMSNTYP", JdeDataType.String, 8),
        new JdeField("OCWCF", "OCWCF", JdeDataType.String, 2),
        new JdeField("OCTINSZRO1", "OCTINSZRO1", JdeDataType.String, 2),
        new JdeField("OCTINSZRO2", "OCTINSZRO2", JdeDataType.String, 2),
        new JdeField("OCTINSZRO3", "OCTINSZRO3", JdeDataType.String, 2),
        new JdeField("OCTINSZRO4", "OCTINSZRO4", JdeDataType.String, 2),
        new JdeField("OCPRCPTF", "OCPRCPTF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B75_0", "Primary Key on OCWCFGID", new[] { "OCWCFGID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B75_2", "Index on OCWCOPCD", new[] { "OCWCOPCD" })
    };
}
