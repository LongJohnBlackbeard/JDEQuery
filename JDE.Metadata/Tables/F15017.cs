using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15017 - .
/// </summary>
public class F15017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NWDOCO.
        /// </summary>
        public const string NWDOCO = "NWDOCO";

        /// <summary>
        /// NWLSVR.
        /// </summary>
        public const string NWLSVR = "NWLSVR";

        /// <summary>
        /// NWMCU.
        /// </summary>
        public const string NWMCU = "NWMCU";

        /// <summary>
        /// NWUNIT.
        /// </summary>
        public const string NWUNIT = "NWUNIT";

        /// <summary>
        /// NWAN8A.
        /// </summary>
        public const string NWAN8A = "NWAN8A";

        /// <summary>
        /// NWAN8S.
        /// </summary>
        public const string NWAN8S = "NWAN8S";

        /// <summary>
        /// NWMCUS.
        /// </summary>
        public const string NWMCUS = "NWMCUS";

        /// <summary>
        /// NWSIC2.
        /// </summary>
        public const string NWSIC2 = "NWSIC2";

        /// <summary>
        /// NWMIDT.
        /// </summary>
        public const string NWMIDT = "NWMIDT";

        /// <summary>
        /// NWSPAD.
        /// </summary>
        public const string NWSPAD = "NWSPAD";

        /// <summary>
        /// NWMODT.
        /// </summary>
        public const string NWMODT = "NWMODT";

        /// <summary>
        /// NWSBDT.
        /// </summary>
        public const string NWSBDT = "NWSBDT";

        /// <summary>
        /// NWRNTA.
        /// </summary>
        public const string NWRNTA = "NWRNTA";

        /// <summary>
        /// NWUSEA.
        /// </summary>
        public const string NWUSEA = "NWUSEA";

        /// <summary>
        /// NWRM01.
        /// </summary>
        public const string NWRM01 = "NWRM01";

        /// <summary>
        /// NWRM02.
        /// </summary>
        public const string NWRM02 = "NWRM02";

        /// <summary>
        /// NWRM03.
        /// </summary>
        public const string NWRM03 = "NWRM03";

        /// <summary>
        /// NWRM04.
        /// </summary>
        public const string NWRM04 = "NWRM04";

        /// <summary>
        /// NWRM05.
        /// </summary>
        public const string NWRM05 = "NWRM05";

        /// <summary>
        /// NWRM06.
        /// </summary>
        public const string NWRM06 = "NWRM06";

        /// <summary>
        /// NWRM07.
        /// </summary>
        public const string NWRM07 = "NWRM07";

        /// <summary>
        /// NWRM08.
        /// </summary>
        public const string NWRM08 = "NWRM08";

        /// <summary>
        /// NWRM09.
        /// </summary>
        public const string NWRM09 = "NWRM09";

        /// <summary>
        /// NWRM10.
        /// </summary>
        public const string NWRM10 = "NWRM10";

        /// <summary>
        /// NWUNGP.
        /// </summary>
        public const string NWUNGP = "NWUNGP";

        /// <summary>
        /// NWUTTY.
        /// </summary>
        public const string NWUTTY = "NWUTTY";

        /// <summary>
        /// NWUTUS.
        /// </summary>
        public const string NWUTUS = "NWUTUS";

        /// <summary>
        /// NWWTDL.
        /// </summary>
        public const string NWWTDL = "NWWTDL";

        /// <summary>
        /// NWCO.
        /// </summary>
        public const string NWCO = "NWCO";

        /// <summary>
        /// NWSMCU.
        /// </summary>
        public const string NWSMCU = "NWSMCU";

        /// <summary>
        /// NWDBUI.
        /// </summary>
        public const string NWDBUI = "NWDBUI";

        /// <summary>
        /// NWSPND.
        /// </summary>
        public const string NWSPND = "NWSPND";

        /// <summary>
        /// NWDBAN.
        /// </summary>
        public const string NWDBAN = "NWDBAN";

        /// <summary>
        /// NWARA1.
        /// </summary>
        public const string NWARA1 = "NWARA1";

        /// <summary>
        /// NWAAT1.
        /// </summary>
        public const string NWAAT1 = "NWAAT1";

        /// <summary>
        /// NWARA2.
        /// </summary>
        public const string NWARA2 = "NWARA2";

        /// <summary>
        /// NWAAT2.
        /// </summary>
        public const string NWAAT2 = "NWAAT2";

        /// <summary>
        /// NWARA3.
        /// </summary>
        public const string NWARA3 = "NWARA3";

        /// <summary>
        /// NWAAT3.
        /// </summary>
        public const string NWAAT3 = "NWAAT3";

        /// <summary>
        /// NWCMTB.
        /// </summary>
        public const string NWCMTB = "NWCMTB";

        /// <summary>
        /// NWCMTE.
        /// </summary>
        public const string NWCMTE = "NWCMTE";

        /// <summary>
        /// NWDEAL.
        /// </summary>
        public const string NWDEAL = "NWDEAL";

        /// <summary>
        /// NWURCD.
        /// </summary>
        public const string NWURCD = "NWURCD";

        /// <summary>
        /// NWURDT.
        /// </summary>
        public const string NWURDT = "NWURDT";

        /// <summary>
        /// NWURAT.
        /// </summary>
        public const string NWURAT = "NWURAT";

        /// <summary>
        /// NWURAB.
        /// </summary>
        public const string NWURAB = "NWURAB";

        /// <summary>
        /// NWURRF.
        /// </summary>
        public const string NWURRF = "NWURRF";

        /// <summary>
        /// NWUSER.
        /// </summary>
        public const string NWUSER = "NWUSER";

        /// <summary>
        /// NWPID.
        /// </summary>
        public const string NWPID = "NWPID";

        /// <summary>
        /// NWUPMJ.
        /// </summary>
        public const string NWUPMJ = "NWUPMJ";

        /// <summary>
        /// NWUPMT.
        /// </summary>
        public const string NWUPMT = "NWUPMT";

        /// <summary>
        /// NWJOBN.
        /// </summary>
        public const string NWJOBN = "NWJOBN";

        /// <summary>
        /// NWENTJ.
        /// </summary>
        public const string NWENTJ = "NWENTJ";

        /// <summary>
        /// NWTORG.
        /// </summary>
        public const string NWTORG = "NWTORG";

        /// <summary>
        /// NWCRR.
        /// </summary>
        public const string NWCRR = "NWCRR";

        /// <summary>
        /// NWCRCD.
        /// </summary>
        public const string NWCRCD = "NWCRCD";

        /// <summary>
        /// NWCRRM.
        /// </summary>
        public const string NWCRRM = "NWCRRM";

        /// <summary>
        /// NWLELC.
        /// </summary>
        public const string NWLELC = "NWLELC";

        /// <summary>
        /// NWLERCEO.
        /// </summary>
        public const string NWLERCEO = "NWLERCEO";

        /// <summary>
        /// NWLESPA.
        /// </summary>
        public const string NWLESPA = "NWLESPA";

        /// <summary>
        /// NWLETO.
        /// </summary>
        public const string NWLETO = "NWLETO";

        /// <summary>
        /// NWLEFVBD.
        /// </summary>
        public const string NWLEFVBD = "NWLEFVBD";

        /// <summary>
        /// NWLEFVED.
        /// </summary>
        public const string NWLEFVED = "NWLEFVED";

        /// <summary>
        /// NWLEPGRV.
        /// </summary>
        public const string NWLEPGRV = "NWLEPGRV";

        /// <summary>
        /// NWLEFGRV.
        /// </summary>
        public const string NWLEFGRV = "NWLEFGRV";

        /// <summary>
        /// NWLEGRP.
        /// </summary>
        public const string NWLEGRP = "NWLEGRP";

        /// <summary>
        /// NWLEPOA.
        /// </summary>
        public const string NWLEPOA = "NWLEPOA";

        /// <summary>
        /// NWLEOP.
        /// </summary>
        public const string NWLEOP = "NWLEOP";

        /// <summary>
        /// NWLERLL.
        /// </summary>
        public const string NWLERLL = "NWLERLL";

        /// <summary>
        /// NWLEDC11.
        /// </summary>
        public const string NWLEDC11 = "NWLEDC11";

        /// <summary>
        /// NWLEDC12.
        /// </summary>
        public const string NWLEDC12 = "NWLEDC12";

        /// <summary>
        /// NWLEDC13.
        /// </summary>
        public const string NWLEDC13 = "NWLEDC13";

        /// <summary>
        /// NWLEDC14.
        /// </summary>
        public const string NWLEDC14 = "NWLEDC14";

        /// <summary>
        /// NWLEDC15.
        /// </summary>
        public const string NWLEDC15 = "NWLEDC15";

        /// <summary>
        /// NWICU.
        /// </summary>
        public const string NWICU = "NWICU";

        /// <summary>
        /// NWLELLS.
        /// </summary>
        public const string NWLELLS = "NWLELLS";

        /// <summary>
        /// NWLELCD.
        /// </summary>
        public const string NWLELCD = "NWLELCD";

        /// <summary>
        /// NWLESIR.
        /// </summary>
        public const string NWLESIR = "NWLESIR";

        /// <summary>
        /// NWLEJTD.
        /// </summary>
        public const string NWLEJTD = "NWLEJTD";

        /// <summary>
        /// NWLZNPA.
        /// </summary>
        public const string NWLZNPA = "NWLZNPA";

        /// <summary>
        /// NWNUMB.
        /// </summary>
        public const string NWNUMB = "NWNUMB";

        /// <summary>
        /// NWLEBR.
        /// </summary>
        public const string NWLEBR = "NWLEBR";

        /// <summary>
        /// NWLZRED.
        /// </summary>
        public const string NWLZRED = "NWLZRED";
    }

    /// <inheritdoc />
    public override string TableName => "F15017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NWDOCO", "NWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NWLSVR", "NWLSVR", JdeDataType.Numeric, null, true, true),
        new JdeField("NWMCU", "NWMCU", JdeDataType.String, 24, true, true),
        new JdeField("NWUNIT", "NWUNIT", JdeDataType.String, 16, true, true),
        new JdeField("NWAN8A", "NWAN8A", JdeDataType.Numeric),
        new JdeField("NWAN8S", "NWAN8S", JdeDataType.Numeric),
        new JdeField("NWMCUS", "NWMCUS", JdeDataType.String, 24),
        new JdeField("NWSIC2", "NWSIC2", JdeDataType.String, 20),
        new JdeField("NWMIDT", "NWMIDT", JdeDataType.Numeric),
        new JdeField("NWSPAD", "NWSPAD", JdeDataType.Numeric),
        new JdeField("NWMODT", "NWMODT", JdeDataType.Numeric),
        new JdeField("NWSBDT", "NWSBDT", JdeDataType.Numeric),
        new JdeField("NWRNTA", "NWRNTA", JdeDataType.Numeric),
        new JdeField("NWUSEA", "NWUSEA", JdeDataType.Numeric),
        new JdeField("NWRM01", "NWRM01", JdeDataType.String, 6),
        new JdeField("NWRM02", "NWRM02", JdeDataType.String, 6),
        new JdeField("NWRM03", "NWRM03", JdeDataType.String, 6),
        new JdeField("NWRM04", "NWRM04", JdeDataType.String, 6),
        new JdeField("NWRM05", "NWRM05", JdeDataType.String, 6),
        new JdeField("NWRM06", "NWRM06", JdeDataType.String, 6),
        new JdeField("NWRM07", "NWRM07", JdeDataType.String, 6),
        new JdeField("NWRM08", "NWRM08", JdeDataType.String, 6),
        new JdeField("NWRM09", "NWRM09", JdeDataType.String, 6),
        new JdeField("NWRM10", "NWRM10", JdeDataType.String, 6),
        new JdeField("NWUNGP", "NWUNGP", JdeDataType.String, 6),
        new JdeField("NWUTTY", "NWUTTY", JdeDataType.String, 10),
        new JdeField("NWUTUS", "NWUTUS", JdeDataType.String, 2),
        new JdeField("NWWTDL", "NWWTDL", JdeDataType.Numeric),
        new JdeField("NWCO", "NWCO", JdeDataType.String, 10),
        new JdeField("NWSMCU", "NWSMCU", JdeDataType.String, 24),
        new JdeField("NWDBUI", "NWDBUI", JdeDataType.String, 2),
        new JdeField("NWSPND", "NWSPND", JdeDataType.Numeric),
        new JdeField("NWDBAN", "NWDBAN", JdeDataType.Numeric),
        new JdeField("NWARA1", "NWARA1", JdeDataType.Numeric),
        new JdeField("NWAAT1", "NWAAT1", JdeDataType.String, 6),
        new JdeField("NWARA2", "NWARA2", JdeDataType.Numeric),
        new JdeField("NWAAT2", "NWAAT2", JdeDataType.String, 6),
        new JdeField("NWARA3", "NWARA3", JdeDataType.Numeric),
        new JdeField("NWAAT3", "NWAAT3", JdeDataType.String, 6),
        new JdeField("NWCMTB", "NWCMTB", JdeDataType.Numeric),
        new JdeField("NWCMTE", "NWCMTE", JdeDataType.Numeric),
        new JdeField("NWDEAL", "NWDEAL", JdeDataType.String, 16),
        new JdeField("NWURCD", "NWURCD", JdeDataType.String, 4),
        new JdeField("NWURDT", "NWURDT", JdeDataType.Numeric),
        new JdeField("NWURAT", "NWURAT", JdeDataType.Numeric),
        new JdeField("NWURAB", "NWURAB", JdeDataType.Numeric),
        new JdeField("NWURRF", "NWURRF", JdeDataType.String, 30),
        new JdeField("NWUSER", "NWUSER", JdeDataType.String, 20),
        new JdeField("NWPID", "NWPID", JdeDataType.String, 20),
        new JdeField("NWUPMJ", "NWUPMJ", JdeDataType.Numeric),
        new JdeField("NWUPMT", "NWUPMT", JdeDataType.Numeric),
        new JdeField("NWJOBN", "NWJOBN", JdeDataType.String, 20),
        new JdeField("NWENTJ", "NWENTJ", JdeDataType.Numeric),
        new JdeField("NWTORG", "NWTORG", JdeDataType.String, 20),
        new JdeField("NWCRR", "NWCRR", JdeDataType.Numeric),
        new JdeField("NWCRCD", "NWCRCD", JdeDataType.String, 6),
        new JdeField("NWCRRM", "NWCRRM", JdeDataType.String, 2),
        new JdeField("NWLELC", "NWLELC", JdeDataType.String, 2),
        new JdeField("NWLERCEO", "NWLERCEO", JdeDataType.String, 2),
        new JdeField("NWLESPA", "NWLESPA", JdeDataType.String, 2),
        new JdeField("NWLETO", "NWLETO", JdeDataType.String, 2),
        new JdeField("NWLEFVBD", "NWLEFVBD", JdeDataType.Numeric),
        new JdeField("NWLEFVED", "NWLEFVED", JdeDataType.Numeric),
        new JdeField("NWLEPGRV", "NWLEPGRV", JdeDataType.Numeric),
        new JdeField("NWLEFGRV", "NWLEFGRV", JdeDataType.Numeric),
        new JdeField("NWLEGRP", "NWLEGRP", JdeDataType.Numeric),
        new JdeField("NWLEPOA", "NWLEPOA", JdeDataType.Numeric),
        new JdeField("NWLEOP", "NWLEOP", JdeDataType.Numeric),
        new JdeField("NWLERLL", "NWLERLL", JdeDataType.String, 2),
        new JdeField("NWLEDC11", "NWLEDC11", JdeDataType.String, 20),
        new JdeField("NWLEDC12", "NWLEDC12", JdeDataType.String, 20),
        new JdeField("NWLEDC13", "NWLEDC13", JdeDataType.String, 20),
        new JdeField("NWLEDC14", "NWLEDC14", JdeDataType.String, 20),
        new JdeField("NWLEDC15", "NWLEDC15", JdeDataType.String, 20),
        new JdeField("NWICU", "NWICU", JdeDataType.Numeric),
        new JdeField("NWLELLS", "NWLELLS", JdeDataType.String, 4),
        new JdeField("NWLELCD", "NWLELCD", JdeDataType.Numeric),
        new JdeField("NWLESIR", "NWLESIR", JdeDataType.String, 2),
        new JdeField("NWLEJTD", "NWLEJTD", JdeDataType.Numeric),
        new JdeField("NWLZNPA", "NWLZNPA", JdeDataType.String, 2),
        new JdeField("NWNUMB", "NWNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("NWLEBR", "NWLEBR", JdeDataType.Numeric),
        new JdeField("NWLZRED", "NWLZRED", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15017_0", "Primary Key on NWDOCO, NWLSVR, NWMCU, NWUNIT, NWNUMB", new[] { "NWDOCO", "NWLSVR", "NWMCU", "NWUNIT", "NWNUMB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15017_10", "Index on NWDOCO, NWLSVR, NWMCU, NWNUMB", new[] { "NWDOCO", "NWLSVR", "NWMCU", "NWNUMB" }),
        new JdeIndex("F15017_2", "Index on NWMCUS, NWMCU, NWUNIT, NWMIDT, NWDOCO", new[] { "NWMCUS", "NWMCU", "NWUNIT", "NWMIDT", "NWDOCO" }),
        new JdeIndex("F15017_3", "Index on NWMCU, NWUNIT, NWMODT", new[] { "NWMCU", "NWUNIT", "NWMODT" }),
        new JdeIndex("F15017_4", "Index on NWMCU, NWUNIT, NWMIDT", new[] { "NWMCU", "NWUNIT", "NWMIDT" }),
        new JdeIndex("F15017_5", "Index on NWAN8A, NWDOCO", new[] { "NWAN8A", "NWDOCO" }),
        new JdeIndex("F15017_6", "Index on NWDOCO, NWLSVR", new[] { "NWDOCO", "NWLSVR" }),
        new JdeIndex("F15017_7", "Index on NWDOCO, NWLSVR, NWNUMB", new[] { "NWDOCO", "NWLSVR", "NWNUMB" }),
        new JdeIndex("F15017_8", "Index on NWDOCO, NWLSVR, NWMCU, NWUNIT", new[] { "NWDOCO", "NWLSVR", "NWMCU", "NWUNIT" }),
        new JdeIndex("F15017_9", "Index on NWDOCO, NWLSVR, NWMCU, NWUNIT, NWLZNPA", new[] { "NWDOCO", "NWLSVR", "NWMCU", "NWUNIT", "NWLZNPA" })
    };
}
