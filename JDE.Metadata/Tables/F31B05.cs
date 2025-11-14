using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B05 - .
/// </summary>
public class F31B05 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EMMCU.
        /// </summary>
        public const string EMMCU = "EMMCU";

        /// <summary>
        /// EMEQPID.
        /// </summary>
        public const string EMEQPID = "EMEQPID";

        /// <summary>
        /// EMEQPNUM.
        /// </summary>
        public const string EMEQPNUM = "EMEQPNUM";

        /// <summary>
        /// EMEQPDESC.
        /// </summary>
        public const string EMEQPDESC = "EMEQPDESC";

        /// <summary>
        /// EMASSETNUM.
        /// </summary>
        public const string EMASSETNUM = "EMASSETNUM";

        /// <summary>
        /// EMEQPTYP.
        /// </summary>
        public const string EMEQPTYP = "EMEQPTYP";

        /// <summary>
        /// EMEQPMDL.
        /// </summary>
        public const string EMEQPMDL = "EMEQPMDL";

        /// <summary>
        /// EMEQPCC1.
        /// </summary>
        public const string EMEQPCC1 = "EMEQPCC1";

        /// <summary>
        /// EMEQPCC2.
        /// </summary>
        public const string EMEQPCC2 = "EMEQPCC2";

        /// <summary>
        /// EMEQPCC3.
        /// </summary>
        public const string EMEQPCC3 = "EMEQPCC3";

        /// <summary>
        /// EMEQPCC4.
        /// </summary>
        public const string EMEQPCC4 = "EMEQPCC4";

        /// <summary>
        /// EMEQPLOC.
        /// </summary>
        public const string EMEQPLOC = "EMEQPLOC";

        /// <summary>
        /// EMWAID.
        /// </summary>
        public const string EMWAID = "EMWAID";

        /// <summary>
        /// EMEQPSTSCD.
        /// </summary>
        public const string EMEQPSTSCD = "EMEQPSTSCD";

        /// <summary>
        /// EMEQPRSNCD.
        /// </summary>
        public const string EMEQPRSNCD = "EMEQPRSNCD";

        /// <summary>
        /// EMEQPPRCST.
        /// </summary>
        public const string EMEQPPRCST = "EMEQPPRCST";

        /// <summary>
        /// EMEQPCAP1.
        /// </summary>
        public const string EMEQPCAP1 = "EMEQPCAP1";

        /// <summary>
        /// EMEQPCAP2.
        /// </summary>
        public const string EMEQPCAP2 = "EMEQPCAP2";

        /// <summary>
        /// EMEQPCAP3.
        /// </summary>
        public const string EMEQPCAP3 = "EMEQPCAP3";

        /// <summary>
        /// EMEQPCAP4.
        /// </summary>
        public const string EMEQPCAP4 = "EMEQPCAP4";

        /// <summary>
        /// EMEQPCAP5.
        /// </summary>
        public const string EMEQPCAP5 = "EMEQPCAP5";

        /// <summary>
        /// EMEQPCAP6.
        /// </summary>
        public const string EMEQPCAP6 = "EMEQPCAP6";

        /// <summary>
        /// EMEQPCAP7.
        /// </summary>
        public const string EMEQPCAP7 = "EMEQPCAP7";

        /// <summary>
        /// EMEQPCAP8.
        /// </summary>
        public const string EMEQPCAP8 = "EMEQPCAP8";

        /// <summary>
        /// EMEQPCAP9.
        /// </summary>
        public const string EMEQPCAP9 = "EMEQPCAP9";

        /// <summary>
        /// EMEQPCAP10.
        /// </summary>
        public const string EMEQPCAP10 = "EMEQPCAP10";

        /// <summary>
        /// EMEQPPT.
        /// </summary>
        public const string EMEQPPT = "EMEQPPT";

        /// <summary>
        /// EMUSER.
        /// </summary>
        public const string EMUSER = "EMUSER";

        /// <summary>
        /// EMPID.
        /// </summary>
        public const string EMPID = "EMPID";

        /// <summary>
        /// EMJOBN.
        /// </summary>
        public const string EMJOBN = "EMJOBN";

        /// <summary>
        /// EMUPMJ.
        /// </summary>
        public const string EMUPMJ = "EMUPMJ";

        /// <summary>
        /// EMUPMT.
        /// </summary>
        public const string EMUPMT = "EMUPMT";

        /// <summary>
        /// EMMFGNAME.
        /// </summary>
        public const string EMMFGNAME = "EMMFGNAME";

        /// <summary>
        /// EMEQPPRDT.
        /// </summary>
        public const string EMEQPPRDT = "EMEQPPRDT";

        /// <summary>
        /// EMURCD.
        /// </summary>
        public const string EMURCD = "EMURCD";

        /// <summary>
        /// EMURDT.
        /// </summary>
        public const string EMURDT = "EMURDT";

        /// <summary>
        /// EMURAT.
        /// </summary>
        public const string EMURAT = "EMURAT";

        /// <summary>
        /// EMURRF.
        /// </summary>
        public const string EMURRF = "EMURRF";

        /// <summary>
        /// EMURAB.
        /// </summary>
        public const string EMURAB = "EMURAB";

        /// <summary>
        /// EMEQPSTTM.
        /// </summary>
        public const string EMEQPSTTM = "EMEQPSTTM";

        /// <summary>
        /// EMEQPCLNTM.
        /// </summary>
        public const string EMEQPCLNTM = "EMEQPCLNTM";

        /// <summary>
        /// EMWCG.
        /// </summary>
        public const string EMWCG = "EMWCG";

        /// <summary>
        /// EMWRF.
        /// </summary>
        public const string EMWRF = "EMWRF";

        /// <summary>
        /// EMWCD.
        /// </summary>
        public const string EMWCD = "EMWCD";

        /// <summary>
        /// EMWAB.
        /// </summary>
        public const string EMWAB = "EMWAB";

        /// <summary>
        /// EMWNUM.
        /// </summary>
        public const string EMWNUM = "EMWNUM";

        /// <summary>
        /// EMWMDT.
        /// </summary>
        public const string EMWMDT = "EMWMDT";

        /// <summary>
        /// EMSETUPTM.
        /// </summary>
        public const string EMSETUPTM = "EMSETUPTM";

        /// <summary>
        /// EMCLNUPTM.
        /// </summary>
        public const string EMCLNUPTM = "EMCLNUPTM";
    }

    /// <inheritdoc />
    public override string TableName => "F31B05";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EMMCU", "EMMCU", JdeDataType.String, 24, true, true),
        new JdeField("EMEQPID", "EMEQPID", JdeDataType.Numeric, null, true, true),
        new JdeField("EMEQPNUM", "EMEQPNUM", JdeDataType.String, 40),
        new JdeField("EMEQPDESC", "EMEQPDESC", JdeDataType.String, 60),
        new JdeField("EMASSETNUM", "EMASSETNUM", JdeDataType.String, 40),
        new JdeField("EMEQPTYP", "EMEQPTYP", JdeDataType.String, 60),
        new JdeField("EMEQPMDL", "EMEQPMDL", JdeDataType.String, 40),
        new JdeField("EMEQPCC1", "EMEQPCC1", JdeDataType.String, 20),
        new JdeField("EMEQPCC2", "EMEQPCC2", JdeDataType.String, 20),
        new JdeField("EMEQPCC3", "EMEQPCC3", JdeDataType.String, 20),
        new JdeField("EMEQPCC4", "EMEQPCC4", JdeDataType.String, 20),
        new JdeField("EMEQPLOC", "EMEQPLOC", JdeDataType.String, 40),
        new JdeField("EMWAID", "EMWAID", JdeDataType.String, 16),
        new JdeField("EMEQPSTSCD", "EMEQPSTSCD", JdeDataType.String, 12),
        new JdeField("EMEQPRSNCD", "EMEQPRSNCD", JdeDataType.String, 60),
        new JdeField("EMEQPPRCST", "EMEQPPRCST", JdeDataType.Numeric),
        new JdeField("EMEQPCAP1", "EMEQPCAP1", JdeDataType.String, 20),
        new JdeField("EMEQPCAP2", "EMEQPCAP2", JdeDataType.String, 20),
        new JdeField("EMEQPCAP3", "EMEQPCAP3", JdeDataType.String, 20),
        new JdeField("EMEQPCAP4", "EMEQPCAP4", JdeDataType.String, 20),
        new JdeField("EMEQPCAP5", "EMEQPCAP5", JdeDataType.String, 20),
        new JdeField("EMEQPCAP6", "EMEQPCAP6", JdeDataType.String, 20),
        new JdeField("EMEQPCAP7", "EMEQPCAP7", JdeDataType.String, 20),
        new JdeField("EMEQPCAP8", "EMEQPCAP8", JdeDataType.String, 20),
        new JdeField("EMEQPCAP9", "EMEQPCAP9", JdeDataType.String, 20),
        new JdeField("EMEQPCAP10", "EMEQPCAP10", JdeDataType.String, 20),
        new JdeField("EMEQPPT", "EMEQPPT", JdeDataType.String, 120),
        new JdeField("EMUSER", "EMUSER", JdeDataType.String, 20),
        new JdeField("EMPID", "EMPID", JdeDataType.String, 20),
        new JdeField("EMJOBN", "EMJOBN", JdeDataType.String, 20),
        new JdeField("EMUPMJ", "EMUPMJ", JdeDataType.Numeric),
        new JdeField("EMUPMT", "EMUPMT", JdeDataType.Numeric),
        new JdeField("EMMFGNAME", "EMMFGNAME", JdeDataType.String, 60),
        new JdeField("EMEQPPRDT", "EMEQPPRDT", JdeDataType.Numeric),
        new JdeField("EMURCD", "EMURCD", JdeDataType.String, 4),
        new JdeField("EMURDT", "EMURDT", JdeDataType.Numeric),
        new JdeField("EMURAT", "EMURAT", JdeDataType.Numeric),
        new JdeField("EMURRF", "EMURRF", JdeDataType.String, 30),
        new JdeField("EMURAB", "EMURAB", JdeDataType.Numeric),
        new JdeField("EMEQPSTTM", "EMEQPSTTM", JdeDataType.String, 22),
        new JdeField("EMEQPCLNTM", "EMEQPCLNTM", JdeDataType.String, 30),
        new JdeField("EMWCG", "EMWCG", JdeDataType.String, 24),
        new JdeField("EMWRF", "EMWRF", JdeDataType.String, 60),
        new JdeField("EMWCD", "EMWCD", JdeDataType.String, 6),
        new JdeField("EMWAB", "EMWAB", JdeDataType.Numeric),
        new JdeField("EMWNUM", "EMWNUM", JdeDataType.Numeric),
        new JdeField("EMWMDT", "EMWMDT", JdeDataType.Numeric),
        new JdeField("EMSETUPTM", "EMSETUPTM", JdeDataType.Numeric),
        new JdeField("EMCLNUPTM", "EMCLNUPTM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B05_0", "Primary Key on EMMCU, EMEQPID", new[] { "EMMCU", "EMEQPID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B05_2", "Unique Index on EMMCU, EMEQPNUM", new[] { "EMMCU", "EMEQPNUM" }, isUnique: true),
        new JdeIndex("F31B05_3", "Index on EMASSETNUM, EMMCU", new[] { "EMASSETNUM", "EMMCU" })
    };
}
