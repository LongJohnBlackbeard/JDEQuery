using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1002Z1 - .
/// </summary>
public class F1002Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZRC5.
        /// </summary>
        public const string SZRC5 = "SZRC5";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZSERK.
        /// </summary>
        public const string SZSERK = "SZSERK";

        /// <summary>
        /// SZTRFG.
        /// </summary>
        public const string SZTRFG = "SZTRFG";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZOBJ.
        /// </summary>
        public const string SZOBJ = "SZOBJ";

        /// <summary>
        /// SZSUB.
        /// </summary>
        public const string SZSUB = "SZSUB";

        /// <summary>
        /// SZDL01.
        /// </summary>
        public const string SZDL01 = "SZDL01";

        /// <summary>
        /// SZSBL.
        /// </summary>
        public const string SZSBL = "SZSBL";

        /// <summary>
        /// SZSBLT.
        /// </summary>
        public const string SZSBLT = "SZSBLT";

        /// <summary>
        /// SZCRCD.
        /// </summary>
        public const string SZCRCD = "SZCRCD";

        /// <summary>
        /// SZCRCX.
        /// </summary>
        public const string SZCRCX = "SZCRCX";

        /// <summary>
        /// SZAPYC.
        /// </summary>
        public const string SZAPYC = "SZAPYC";

        /// <summary>
        /// SZAN01.
        /// </summary>
        public const string SZAN01 = "SZAN01";

        /// <summary>
        /// SZAN02.
        /// </summary>
        public const string SZAN02 = "SZAN02";

        /// <summary>
        /// SZAN03.
        /// </summary>
        public const string SZAN03 = "SZAN03";

        /// <summary>
        /// SZAN04.
        /// </summary>
        public const string SZAN04 = "SZAN04";

        /// <summary>
        /// SZAN05.
        /// </summary>
        public const string SZAN05 = "SZAN05";

        /// <summary>
        /// SZAN06.
        /// </summary>
        public const string SZAN06 = "SZAN06";

        /// <summary>
        /// SZAN07.
        /// </summary>
        public const string SZAN07 = "SZAN07";

        /// <summary>
        /// SZAN08.
        /// </summary>
        public const string SZAN08 = "SZAN08";

        /// <summary>
        /// SZAN09.
        /// </summary>
        public const string SZAN09 = "SZAN09";

        /// <summary>
        /// SZAN10.
        /// </summary>
        public const string SZAN10 = "SZAN10";

        /// <summary>
        /// SZAN11.
        /// </summary>
        public const string SZAN11 = "SZAN11";

        /// <summary>
        /// SZAN12.
        /// </summary>
        public const string SZAN12 = "SZAN12";

        /// <summary>
        /// SZAN13.
        /// </summary>
        public const string SZAN13 = "SZAN13";

        /// <summary>
        /// SZAN14.
        /// </summary>
        public const string SZAN14 = "SZAN14";

        /// <summary>
        /// SZAPYN.
        /// </summary>
        public const string SZAPYN = "SZAPYN";

        /// <summary>
        /// SZAWTD.
        /// </summary>
        public const string SZAWTD = "SZAWTD";

        /// <summary>
        /// SZBORG.
        /// </summary>
        public const string SZBORG = "SZBORG";

        /// <summary>
        /// SZBREQ.
        /// </summary>
        public const string SZBREQ = "SZBREQ";

        /// <summary>
        /// SZBAPR.
        /// </summary>
        public const string SZBAPR = "SZBAPR";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURC1.
        /// </summary>
        public const string SZURC1 = "SZURC1";

        /// <summary>
        /// SZURC2.
        /// </summary>
        public const string SZURC2 = "SZURC2";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZVERS.
        /// </summary>
        public const string SZVERS = "SZVERS";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1002Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZRC5", "SZRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZSERK", "SZSERK", JdeDataType.Numeric),
        new JdeField("SZTRFG", "SZTRFG", JdeDataType.String, 2),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZOBJ", "SZOBJ", JdeDataType.String, 12),
        new JdeField("SZSUB", "SZSUB", JdeDataType.String, 16),
        new JdeField("SZDL01", "SZDL01", JdeDataType.String, 60),
        new JdeField("SZSBL", "SZSBL", JdeDataType.String, 16),
        new JdeField("SZSBLT", "SZSBLT", JdeDataType.String, 2),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRCX", "SZCRCX", JdeDataType.String, 6),
        new JdeField("SZAPYC", "SZAPYC", JdeDataType.Numeric),
        new JdeField("SZAN01", "SZAN01", JdeDataType.Numeric),
        new JdeField("SZAN02", "SZAN02", JdeDataType.Numeric),
        new JdeField("SZAN03", "SZAN03", JdeDataType.Numeric),
        new JdeField("SZAN04", "SZAN04", JdeDataType.Numeric),
        new JdeField("SZAN05", "SZAN05", JdeDataType.Numeric),
        new JdeField("SZAN06", "SZAN06", JdeDataType.Numeric),
        new JdeField("SZAN07", "SZAN07", JdeDataType.Numeric),
        new JdeField("SZAN08", "SZAN08", JdeDataType.Numeric),
        new JdeField("SZAN09", "SZAN09", JdeDataType.Numeric),
        new JdeField("SZAN10", "SZAN10", JdeDataType.Numeric),
        new JdeField("SZAN11", "SZAN11", JdeDataType.Numeric),
        new JdeField("SZAN12", "SZAN12", JdeDataType.Numeric),
        new JdeField("SZAN13", "SZAN13", JdeDataType.Numeric),
        new JdeField("SZAN14", "SZAN14", JdeDataType.Numeric),
        new JdeField("SZAPYN", "SZAPYN", JdeDataType.Numeric),
        new JdeField("SZAWTD", "SZAWTD", JdeDataType.Numeric),
        new JdeField("SZBORG", "SZBORG", JdeDataType.Numeric),
        new JdeField("SZBREQ", "SZBREQ", JdeDataType.Numeric),
        new JdeField("SZBAPR", "SZBAPR", JdeDataType.Numeric),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURC1", "SZURC1", JdeDataType.String, 6),
        new JdeField("SZURC2", "SZURC2", JdeDataType.String, 20),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZVERS", "SZVERS", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1002Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZRC5", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZRC5" }, isUnique: true, isPrimaryKey: true)
    };
}
