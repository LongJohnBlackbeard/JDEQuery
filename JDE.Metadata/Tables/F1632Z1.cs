using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1632Z1 - .
/// </summary>
public class F1632Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CYEDUS.
        /// </summary>
        public const string CYEDUS = "CYEDUS";

        /// <summary>
        /// CYEDBT.
        /// </summary>
        public const string CYEDBT = "CYEDBT";

        /// <summary>
        /// CYEDTN.
        /// </summary>
        public const string CYEDTN = "CYEDTN";

        /// <summary>
        /// CYEDLN.
        /// </summary>
        public const string CYEDLN = "CYEDLN";

        /// <summary>
        /// CYEDCT.
        /// </summary>
        public const string CYEDCT = "CYEDCT";

        /// <summary>
        /// CYTYTN.
        /// </summary>
        public const string CYTYTN = "CYTYTN";

        /// <summary>
        /// CYEDFT.
        /// </summary>
        public const string CYEDFT = "CYEDFT";

        /// <summary>
        /// CYEDDT.
        /// </summary>
        public const string CYEDDT = "CYEDDT";

        /// <summary>
        /// CYDRIN.
        /// </summary>
        public const string CYDRIN = "CYDRIN";

        /// <summary>
        /// CYEDDL.
        /// </summary>
        public const string CYEDDL = "CYEDDL";

        /// <summary>
        /// CYEDSP.
        /// </summary>
        public const string CYEDSP = "CYEDSP";

        /// <summary>
        /// CYPNID.
        /// </summary>
        public const string CYPNID = "CYPNID";

        /// <summary>
        /// CYTNAC.
        /// </summary>
        public const string CYTNAC = "CYTNAC";

        /// <summary>
        /// CYEDTY.
        /// </summary>
        public const string CYEDTY = "CYEDTY";

        /// <summary>
        /// CYEDSQ.
        /// </summary>
        public const string CYEDSQ = "CYEDSQ";

        /// <summary>
        /// CYEDTS.
        /// </summary>
        public const string CYEDTS = "CYEDTS";

        /// <summary>
        /// CYEDER.
        /// </summary>
        public const string CYEDER = "CYEDER";

        /// <summary>
        /// CYEDTC.
        /// </summary>
        public const string CYEDTC = "CYEDTC";

        /// <summary>
        /// CYEDTR.
        /// </summary>
        public const string CYEDTR = "CYEDTR";

        /// <summary>
        /// CYEDGL.
        /// </summary>
        public const string CYEDGL = "CYEDGL";

        /// <summary>
        /// CYEDDH.
        /// </summary>
        public const string CYEDDH = "CYEDDH";

        /// <summary>
        /// CYEDAN.
        /// </summary>
        public const string CYEDAN = "CYEDAN";

        /// <summary>
        /// CYDRCD.
        /// </summary>
        public const string CYDRCD = "CYDRCD";

        /// <summary>
        /// CYMCU.
        /// </summary>
        public const string CYMCU = "CYMCU";

        /// <summary>
        /// CYCFY.
        /// </summary>
        public const string CYCFY = "CYCFY";

        /// <summary>
        /// CYLT.
        /// </summary>
        public const string CYLT = "CYLT";

        /// <summary>
        /// CYACTB.
        /// </summary>
        public const string CYACTB = "CYACTB";

        /// <summary>
        /// CYSBL.
        /// </summary>
        public const string CYSBL = "CYSBL";

        /// <summary>
        /// CYSBLT.
        /// </summary>
        public const string CYSBLT = "CYSBLT";

        /// <summary>
        /// CYABR1.
        /// </summary>
        public const string CYABR1 = "CYABR1";

        /// <summary>
        /// CYABT1.
        /// </summary>
        public const string CYABT1 = "CYABT1";

        /// <summary>
        /// CYABR2.
        /// </summary>
        public const string CYABR2 = "CYABR2";

        /// <summary>
        /// CYABT2.
        /// </summary>
        public const string CYABT2 = "CYABT2";

        /// <summary>
        /// CYABR3.
        /// </summary>
        public const string CYABR3 = "CYABR3";

        /// <summary>
        /// CYABT3.
        /// </summary>
        public const string CYABT3 = "CYABT3";

        /// <summary>
        /// CYABR4.
        /// </summary>
        public const string CYABR4 = "CYABR4";

        /// <summary>
        /// CYABT4.
        /// </summary>
        public const string CYABT4 = "CYABT4";

        /// <summary>
        /// CYITM.
        /// </summary>
        public const string CYITM = "CYITM";

        /// <summary>
        /// CYCRCX.
        /// </summary>
        public const string CYCRCX = "CYCRCX";

        /// <summary>
        /// CYUOM.
        /// </summary>
        public const string CYUOM = "CYUOM";

        /// <summary>
        /// CYCO.
        /// </summary>
        public const string CYCO = "CYCO";

        /// <summary>
        /// CYAN01.
        /// </summary>
        public const string CYAN01 = "CYAN01";

        /// <summary>
        /// CYAN02.
        /// </summary>
        public const string CYAN02 = "CYAN02";

        /// <summary>
        /// CYAN03.
        /// </summary>
        public const string CYAN03 = "CYAN03";

        /// <summary>
        /// CYAN04.
        /// </summary>
        public const string CYAN04 = "CYAN04";

        /// <summary>
        /// CYAN05.
        /// </summary>
        public const string CYAN05 = "CYAN05";

        /// <summary>
        /// CYAN06.
        /// </summary>
        public const string CYAN06 = "CYAN06";

        /// <summary>
        /// CYAN07.
        /// </summary>
        public const string CYAN07 = "CYAN07";

        /// <summary>
        /// CYAN08.
        /// </summary>
        public const string CYAN08 = "CYAN08";

        /// <summary>
        /// CYAN09.
        /// </summary>
        public const string CYAN09 = "CYAN09";

        /// <summary>
        /// CYAN10.
        /// </summary>
        public const string CYAN10 = "CYAN10";

        /// <summary>
        /// CYAN11.
        /// </summary>
        public const string CYAN11 = "CYAN11";

        /// <summary>
        /// CYAN12.
        /// </summary>
        public const string CYAN12 = "CYAN12";

        /// <summary>
        /// CYAN13.
        /// </summary>
        public const string CYAN13 = "CYAN13";

        /// <summary>
        /// CYAN14.
        /// </summary>
        public const string CYAN14 = "CYAN14";

        /// <summary>
        /// CYUSER.
        /// </summary>
        public const string CYUSER = "CYUSER";

        /// <summary>
        /// CYPID.
        /// </summary>
        public const string CYPID = "CYPID";

        /// <summary>
        /// CYUPMJ.
        /// </summary>
        public const string CYUPMJ = "CYUPMJ";

        /// <summary>
        /// CYUPMT.
        /// </summary>
        public const string CYUPMT = "CYUPMT";

        /// <summary>
        /// CYJOBN.
        /// </summary>
        public const string CYJOBN = "CYJOBN";

        /// <summary>
        /// CYWGHF.
        /// </summary>
        public const string CYWGHF = "CYWGHF";
    }

    /// <inheritdoc />
    public override string TableName => "F1632Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CYEDUS", "CYEDUS", JdeDataType.String, 20, true, true),
        new JdeField("CYEDBT", "CYEDBT", JdeDataType.String, 30, true, true),
        new JdeField("CYEDTN", "CYEDTN", JdeDataType.String, 44, true, true),
        new JdeField("CYEDLN", "CYEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CYEDCT", "CYEDCT", JdeDataType.String, 4),
        new JdeField("CYTYTN", "CYTYTN", JdeDataType.String, 16),
        new JdeField("CYEDFT", "CYEDFT", JdeDataType.String, 20),
        new JdeField("CYEDDT", "CYEDDT", JdeDataType.Numeric),
        new JdeField("CYDRIN", "CYDRIN", JdeDataType.String, 2),
        new JdeField("CYEDDL", "CYEDDL", JdeDataType.Numeric),
        new JdeField("CYEDSP", "CYEDSP", JdeDataType.String, 2),
        new JdeField("CYPNID", "CYPNID", JdeDataType.String, 30),
        new JdeField("CYTNAC", "CYTNAC", JdeDataType.String, 4),
        new JdeField("CYEDTY", "CYEDTY", JdeDataType.String, 2),
        new JdeField("CYEDSQ", "CYEDSQ", JdeDataType.Numeric),
        new JdeField("CYEDTS", "CYEDTS", JdeDataType.String, 12),
        new JdeField("CYEDER", "CYEDER", JdeDataType.String, 2),
        new JdeField("CYEDTC", "CYEDTC", JdeDataType.String, 2),
        new JdeField("CYEDTR", "CYEDTR", JdeDataType.String, 2),
        new JdeField("CYEDGL", "CYEDGL", JdeDataType.String, 2),
        new JdeField("CYEDDH", "CYEDDH", JdeDataType.String, 2),
        new JdeField("CYEDAN", "CYEDAN", JdeDataType.Numeric),
        new JdeField("CYDRCD", "CYDRCD", JdeDataType.String, 20),
        new JdeField("CYMCU", "CYMCU", JdeDataType.String, 24),
        new JdeField("CYCFY", "CYCFY", JdeDataType.Numeric),
        new JdeField("CYLT", "CYLT", JdeDataType.String, 4),
        new JdeField("CYACTB", "CYACTB", JdeDataType.String, 20),
        new JdeField("CYSBL", "CYSBL", JdeDataType.String, 16),
        new JdeField("CYSBLT", "CYSBLT", JdeDataType.String, 2),
        new JdeField("CYABR1", "CYABR1", JdeDataType.String, 24),
        new JdeField("CYABT1", "CYABT1", JdeDataType.String, 2),
        new JdeField("CYABR2", "CYABR2", JdeDataType.String, 24),
        new JdeField("CYABT2", "CYABT2", JdeDataType.String, 2),
        new JdeField("CYABR3", "CYABR3", JdeDataType.String, 24),
        new JdeField("CYABT3", "CYABT3", JdeDataType.String, 2),
        new JdeField("CYABR4", "CYABR4", JdeDataType.String, 24),
        new JdeField("CYABT4", "CYABT4", JdeDataType.String, 2),
        new JdeField("CYITM", "CYITM", JdeDataType.Numeric),
        new JdeField("CYCRCX", "CYCRCX", JdeDataType.String, 6),
        new JdeField("CYUOM", "CYUOM", JdeDataType.String, 4),
        new JdeField("CYCO", "CYCO", JdeDataType.String, 10),
        new JdeField("CYAN01", "CYAN01", JdeDataType.Numeric),
        new JdeField("CYAN02", "CYAN02", JdeDataType.Numeric),
        new JdeField("CYAN03", "CYAN03", JdeDataType.Numeric),
        new JdeField("CYAN04", "CYAN04", JdeDataType.Numeric),
        new JdeField("CYAN05", "CYAN05", JdeDataType.Numeric),
        new JdeField("CYAN06", "CYAN06", JdeDataType.Numeric),
        new JdeField("CYAN07", "CYAN07", JdeDataType.Numeric),
        new JdeField("CYAN08", "CYAN08", JdeDataType.Numeric),
        new JdeField("CYAN09", "CYAN09", JdeDataType.Numeric),
        new JdeField("CYAN10", "CYAN10", JdeDataType.Numeric),
        new JdeField("CYAN11", "CYAN11", JdeDataType.Numeric),
        new JdeField("CYAN12", "CYAN12", JdeDataType.Numeric),
        new JdeField("CYAN13", "CYAN13", JdeDataType.Numeric),
        new JdeField("CYAN14", "CYAN14", JdeDataType.Numeric),
        new JdeField("CYUSER", "CYUSER", JdeDataType.String, 20),
        new JdeField("CYPID", "CYPID", JdeDataType.String, 20),
        new JdeField("CYUPMJ", "CYUPMJ", JdeDataType.Numeric),
        new JdeField("CYUPMT", "CYUPMT", JdeDataType.Numeric),
        new JdeField("CYJOBN", "CYJOBN", JdeDataType.String, 20),
        new JdeField("CYWGHF", "CYWGHF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1632Z1_0", "Primary Key on CYEDUS, CYEDBT, CYEDTN, CYEDLN", new[] { "CYEDUS", "CYEDBT", "CYEDTN", "CYEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
