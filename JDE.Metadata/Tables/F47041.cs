using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47041 - .
/// </summary>
public class F47041 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SYEDTY.
        /// </summary>
        public const string SYEDTY = "SYEDTY";

        /// <summary>
        /// SYEDSQ.
        /// </summary>
        public const string SYEDSQ = "SYEDSQ";

        /// <summary>
        /// SYEKCO.
        /// </summary>
        public const string SYEKCO = "SYEKCO";

        /// <summary>
        /// SYEDOC.
        /// </summary>
        public const string SYEDOC = "SYEDOC";

        /// <summary>
        /// SYEDCT.
        /// </summary>
        public const string SYEDCT = "SYEDCT";

        /// <summary>
        /// SYEDLN.
        /// </summary>
        public const string SYEDLN = "SYEDLN";

        /// <summary>
        /// SYEDST.
        /// </summary>
        public const string SYEDST = "SYEDST";

        /// <summary>
        /// SYEDFT.
        /// </summary>
        public const string SYEDFT = "SYEDFT";

        /// <summary>
        /// SYEDDT.
        /// </summary>
        public const string SYEDDT = "SYEDDT";

        /// <summary>
        /// SYEDER.
        /// </summary>
        public const string SYEDER = "SYEDER";

        /// <summary>
        /// SYEDDL.
        /// </summary>
        public const string SYEDDL = "SYEDDL";

        /// <summary>
        /// SYEDSP.
        /// </summary>
        public const string SYEDSP = "SYEDSP";

        /// <summary>
        /// SYEDBT.
        /// </summary>
        public const string SYEDBT = "SYEDBT";

        /// <summary>
        /// SYPNID.
        /// </summary>
        public const string SYPNID = "SYPNID";

        /// <summary>
        /// SYCO.
        /// </summary>
        public const string SYCO = "SYCO";

        /// <summary>
        /// SYKCOO.
        /// </summary>
        public const string SYKCOO = "SYKCOO";

        /// <summary>
        /// SYDOCO.
        /// </summary>
        public const string SYDOCO = "SYDOCO";

        /// <summary>
        /// SYDCTO.
        /// </summary>
        public const string SYDCTO = "SYDCTO";

        /// <summary>
        /// SYSFXO.
        /// </summary>
        public const string SYSFXO = "SYSFXO";

        /// <summary>
        /// SYKCO.
        /// </summary>
        public const string SYKCO = "SYKCO";

        /// <summary>
        /// SYDOC.
        /// </summary>
        public const string SYDOC = "SYDOC";

        /// <summary>
        /// SYDCTV.
        /// </summary>
        public const string SYDCTV = "SYDCTV";

        /// <summary>
        /// SYAN8.
        /// </summary>
        public const string SYAN8 = "SYAN8";

        /// <summary>
        /// SYVINV.
        /// </summary>
        public const string SYVINV = "SYVINV";

        /// <summary>
        /// SYDGJ.
        /// </summary>
        public const string SYDGJ = "SYDGJ";

        /// <summary>
        /// SYDIVJ.
        /// </summary>
        public const string SYDIVJ = "SYDIVJ";

        /// <summary>
        /// SYSHAN.
        /// </summary>
        public const string SYSHAN = "SYSHAN";

        /// <summary>
        /// SYPA8.
        /// </summary>
        public const string SYPA8 = "SYPA8";

        /// <summary>
        /// SYAN8J.
        /// </summary>
        public const string SYAN8J = "SYAN8J";

        /// <summary>
        /// SYSNTO.
        /// </summary>
        public const string SYSNTO = "SYSNTO";

        /// <summary>
        /// SYCRRM.
        /// </summary>
        public const string SYCRRM = "SYCRRM";

        /// <summary>
        /// SYCRCD.
        /// </summary>
        public const string SYCRCD = "SYCRCD";

        /// <summary>
        /// SYCRR.
        /// </summary>
        public const string SYCRR = "SYCRR";

        /// <summary>
        /// SYEXR1.
        /// </summary>
        public const string SYEXR1 = "SYEXR1";

        /// <summary>
        /// SYTXA1.
        /// </summary>
        public const string SYTXA1 = "SYTXA1";

        /// <summary>
        /// SYPCR.
        /// </summary>
        public const string SYPCR = "SYPCR";

        /// <summary>
        /// SYPTC.
        /// </summary>
        public const string SYPTC = "SYPTC";

        /// <summary>
        /// SYPYIN.
        /// </summary>
        public const string SYPYIN = "SYPYIN";

        /// <summary>
        /// SYPTD.
        /// </summary>
        public const string SYPTD = "SYPTD";

        /// <summary>
        /// SYPEFJ.
        /// </summary>
        public const string SYPEFJ = "SYPEFJ";

        /// <summary>
        /// SYASN.
        /// </summary>
        public const string SYASN = "SYASN";

        /// <summary>
        /// SYATXT.
        /// </summary>
        public const string SYATXT = "SYATXT";

        /// <summary>
        /// SYAVCH.
        /// </summary>
        public const string SYAVCH = "SYAVCH";

        /// <summary>
        /// SYCRMD.
        /// </summary>
        public const string SYCRMD = "SYCRMD";

        /// <summary>
        /// SYCORD.
        /// </summary>
        public const string SYCORD = "SYCORD";

        /// <summary>
        /// SYDCP.
        /// </summary>
        public const string SYDCP = "SYDCP";

        /// <summary>
        /// SYDCD.
        /// </summary>
        public const string SYDCD = "SYDCD";

        /// <summary>
        /// SYNDTP.
        /// </summary>
        public const string SYNDTP = "SYNDTP";

        /// <summary>
        /// SYDDU.
        /// </summary>
        public const string SYDDU = "SYDDU";

        /// <summary>
        /// SYDDJ.
        /// </summary>
        public const string SYDDJ = "SYDDJ";

        /// <summary>
        /// SYRMK.
        /// </summary>
        public const string SYRMK = "SYRMK";

        /// <summary>
        /// SYVRMK.
        /// </summary>
        public const string SYVRMK = "SYVRMK";

        /// <summary>
        /// SYVR01.
        /// </summary>
        public const string SYVR01 = "SYVR01";

        /// <summary>
        /// SYVR02.
        /// </summary>
        public const string SYVR02 = "SYVR02";

        /// <summary>
        /// SYURCD.
        /// </summary>
        public const string SYURCD = "SYURCD";

        /// <summary>
        /// SYURDT.
        /// </summary>
        public const string SYURDT = "SYURDT";

        /// <summary>
        /// SYURAT.
        /// </summary>
        public const string SYURAT = "SYURAT";

        /// <summary>
        /// SYURAB.
        /// </summary>
        public const string SYURAB = "SYURAB";

        /// <summary>
        /// SYURRF.
        /// </summary>
        public const string SYURRF = "SYURRF";

        /// <summary>
        /// SYTORG.
        /// </summary>
        public const string SYTORG = "SYTORG";

        /// <summary>
        /// SYUSER.
        /// </summary>
        public const string SYUSER = "SYUSER";

        /// <summary>
        /// SYPID.
        /// </summary>
        public const string SYPID = "SYPID";

        /// <summary>
        /// SYJOBN.
        /// </summary>
        public const string SYJOBN = "SYJOBN";

        /// <summary>
        /// SYUPMJ.
        /// </summary>
        public const string SYUPMJ = "SYUPMJ";

        /// <summary>
        /// SYTDAY.
        /// </summary>
        public const string SYTDAY = "SYTDAY";

        /// <summary>
        /// SYGAN8.
        /// </summary>
        public const string SYGAN8 = "SYGAN8";

        /// <summary>
        /// SYGSHAN.
        /// </summary>
        public const string SYGSHAN = "SYGSHAN";

        /// <summary>
        /// SYGPA8.
        /// </summary>
        public const string SYGPA8 = "SYGPA8";

        /// <summary>
        /// SYGAN8J.
        /// </summary>
        public const string SYGAN8J = "SYGAN8J";
    }

    /// <inheritdoc />
    public override string TableName => "F47041";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SYEDTY", "SYEDTY", JdeDataType.String, 2),
        new JdeField("SYEDSQ", "SYEDSQ", JdeDataType.Numeric),
        new JdeField("SYEKCO", "SYEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SYEDOC", "SYEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SYEDCT", "SYEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SYEDLN", "SYEDLN", JdeDataType.Numeric),
        new JdeField("SYEDST", "SYEDST", JdeDataType.String, 12),
        new JdeField("SYEDFT", "SYEDFT", JdeDataType.String, 20),
        new JdeField("SYEDDT", "SYEDDT", JdeDataType.Numeric),
        new JdeField("SYEDER", "SYEDER", JdeDataType.String, 2),
        new JdeField("SYEDDL", "SYEDDL", JdeDataType.Numeric),
        new JdeField("SYEDSP", "SYEDSP", JdeDataType.String, 2),
        new JdeField("SYEDBT", "SYEDBT", JdeDataType.String, 30),
        new JdeField("SYPNID", "SYPNID", JdeDataType.String, 30),
        new JdeField("SYCO", "SYCO", JdeDataType.String, 10),
        new JdeField("SYKCOO", "SYKCOO", JdeDataType.String, 10),
        new JdeField("SYDOCO", "SYDOCO", JdeDataType.Numeric),
        new JdeField("SYDCTO", "SYDCTO", JdeDataType.String, 4),
        new JdeField("SYSFXO", "SYSFXO", JdeDataType.String, 6),
        new JdeField("SYKCO", "SYKCO", JdeDataType.String, 10),
        new JdeField("SYDOC", "SYDOC", JdeDataType.Numeric),
        new JdeField("SYDCTV", "SYDCTV", JdeDataType.String, 4),
        new JdeField("SYAN8", "SYAN8", JdeDataType.Numeric),
        new JdeField("SYVINV", "SYVINV", JdeDataType.String, 50),
        new JdeField("SYDGJ", "SYDGJ", JdeDataType.Numeric),
        new JdeField("SYDIVJ", "SYDIVJ", JdeDataType.Numeric),
        new JdeField("SYSHAN", "SYSHAN", JdeDataType.Numeric),
        new JdeField("SYPA8", "SYPA8", JdeDataType.Numeric),
        new JdeField("SYAN8J", "SYAN8J", JdeDataType.Numeric),
        new JdeField("SYSNTO", "SYSNTO", JdeDataType.Numeric),
        new JdeField("SYCRRM", "SYCRRM", JdeDataType.String, 2),
        new JdeField("SYCRCD", "SYCRCD", JdeDataType.String, 6),
        new JdeField("SYCRR", "SYCRR", JdeDataType.Numeric),
        new JdeField("SYEXR1", "SYEXR1", JdeDataType.String, 4),
        new JdeField("SYTXA1", "SYTXA1", JdeDataType.String, 20),
        new JdeField("SYPCR", "SYPCR", JdeDataType.Numeric),
        new JdeField("SYPTC", "SYPTC", JdeDataType.String, 6),
        new JdeField("SYPYIN", "SYPYIN", JdeDataType.String, 2),
        new JdeField("SYPTD", "SYPTD", JdeDataType.String, 60),
        new JdeField("SYPEFJ", "SYPEFJ", JdeDataType.Numeric),
        new JdeField("SYASN", "SYASN", JdeDataType.String, 16),
        new JdeField("SYATXT", "SYATXT", JdeDataType.String, 2),
        new JdeField("SYAVCH", "SYAVCH", JdeDataType.String, 2),
        new JdeField("SYCRMD", "SYCRMD", JdeDataType.String, 2),
        new JdeField("SYCORD", "SYCORD", JdeDataType.Numeric),
        new JdeField("SYDCP", "SYDCP", JdeDataType.Numeric),
        new JdeField("SYDCD", "SYDCD", JdeDataType.Numeric),
        new JdeField("SYNDTP", "SYNDTP", JdeDataType.Numeric),
        new JdeField("SYDDU", "SYDDU", JdeDataType.Numeric),
        new JdeField("SYDDJ", "SYDDJ", JdeDataType.Numeric),
        new JdeField("SYRMK", "SYRMK", JdeDataType.String, 60),
        new JdeField("SYVRMK", "SYVRMK", JdeDataType.String, 60),
        new JdeField("SYVR01", "SYVR01", JdeDataType.String, 50),
        new JdeField("SYVR02", "SYVR02", JdeDataType.String, 50),
        new JdeField("SYURCD", "SYURCD", JdeDataType.String, 4),
        new JdeField("SYURDT", "SYURDT", JdeDataType.Numeric),
        new JdeField("SYURAT", "SYURAT", JdeDataType.Numeric),
        new JdeField("SYURAB", "SYURAB", JdeDataType.Numeric),
        new JdeField("SYURRF", "SYURRF", JdeDataType.String, 30),
        new JdeField("SYTORG", "SYTORG", JdeDataType.String, 20),
        new JdeField("SYUSER", "SYUSER", JdeDataType.String, 20),
        new JdeField("SYPID", "SYPID", JdeDataType.String, 20),
        new JdeField("SYJOBN", "SYJOBN", JdeDataType.String, 20),
        new JdeField("SYUPMJ", "SYUPMJ", JdeDataType.Numeric),
        new JdeField("SYTDAY", "SYTDAY", JdeDataType.Numeric),
        new JdeField("SYGAN8", "SYGAN8", JdeDataType.Numeric),
        new JdeField("SYGSHAN", "SYGSHAN", JdeDataType.Numeric),
        new JdeField("SYGPA8", "SYGPA8", JdeDataType.Numeric),
        new JdeField("SYGAN8J", "SYGAN8J", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47041_0", "Primary Key on SYEDOC, SYEDCT, SYEKCO", new[] { "SYEDOC", "SYEDCT", "SYEKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
