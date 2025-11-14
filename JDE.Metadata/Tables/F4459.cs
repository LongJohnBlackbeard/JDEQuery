using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4459 - .
/// </summary>
public class F4459 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JLLITM.
        /// </summary>
        public const string JLLITM = "JLLITM";

        /// <summary>
        /// JLITM.
        /// </summary>
        public const string JLITM = "JLITM";

        /// <summary>
        /// JLAN8.
        /// </summary>
        public const string JLAN8 = "JLAN8";

        /// <summary>
        /// JLSDS1.
        /// </summary>
        public const string JLSDS1 = "JLSDS1";

        /// <summary>
        /// JLCTYC.
        /// </summary>
        public const string JLCTYC = "JLCTYC";

        /// <summary>
        /// JLUPRC.
        /// </summary>
        public const string JLUPRC = "JLUPRC";

        /// <summary>
        /// JLPOA.
        /// </summary>
        public const string JLPOA = "JLPOA";

        /// <summary>
        /// JLEFFF.
        /// </summary>
        public const string JLEFFF = "JLEFFF";

        /// <summary>
        /// JLLDT.
        /// </summary>
        public const string JLLDT = "JLLDT";

        /// <summary>
        /// JLLTN.
        /// </summary>
        public const string JLLTN = "JLLTN";

        /// <summary>
        /// JLDSCT.
        /// </summary>
        public const string JLDSCT = "JLDSCT";

        /// <summary>
        /// JLMCU.
        /// </summary>
        public const string JLMCU = "JLMCU";

        /// <summary>
        /// JLDSPC.
        /// </summary>
        public const string JLDSPC = "JLDSPC";

        /// <summary>
        /// JLDSQT.
        /// </summary>
        public const string JLDSQT = "JLDSQT";

        /// <summary>
        /// JLMDA.
        /// </summary>
        public const string JLMDA = "JLMDA";

        /// <summary>
        /// JLMDP.
        /// </summary>
        public const string JLMDP = "JLMDP";

        /// <summary>
        /// JLMDQ.
        /// </summary>
        public const string JLMDQ = "JLMDQ";

        /// <summary>
        /// JLEXPR.
        /// </summary>
        public const string JLEXPR = "JLEXPR";

        /// <summary>
        /// JLDDC.
        /// </summary>
        public const string JLDDC = "JLDDC";

        /// <summary>
        /// JLELT.
        /// </summary>
        public const string JLELT = "JLELT";

        /// <summary>
        /// JLONR.
        /// </summary>
        public const string JLONR = "JLONR";

        /// <summary>
        /// JLPRN.
        /// </summary>
        public const string JLPRN = "JLPRN";

        /// <summary>
        /// JLBDS.
        /// </summary>
        public const string JLBDS = "JLBDS";

        /// <summary>
        /// JLPRS.
        /// </summary>
        public const string JLPRS = "JLPRS";

        /// <summary>
        /// JLBDF.
        /// </summary>
        public const string JLBDF = "JLBDF";

        /// <summary>
        /// JLXSQ.
        /// </summary>
        public const string JLXSQ = "JLXSQ";

        /// <summary>
        /// JLESQ.
        /// </summary>
        public const string JLESQ = "JLESQ";

        /// <summary>
        /// JLMDF.
        /// </summary>
        public const string JLMDF = "JLMDF";

        /// <summary>
        /// JLPCRT.
        /// </summary>
        public const string JLPCRT = "JLPCRT";

        /// <summary>
        /// JLPFR.
        /// </summary>
        public const string JLPFR = "JLPFR";

        /// <summary>
        /// JLCTN.
        /// </summary>
        public const string JLCTN = "JLCTN";

        /// <summary>
        /// JLUPMJ.
        /// </summary>
        public const string JLUPMJ = "JLUPMJ";

        /// <summary>
        /// JLUSER.
        /// </summary>
        public const string JLUSER = "JLUSER";

        /// <summary>
        /// JLPID.
        /// </summary>
        public const string JLPID = "JLPID";

        /// <summary>
        /// JLJOBN.
        /// </summary>
        public const string JLJOBN = "JLJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F4459";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JLLITM", "JLLITM", JdeDataType.String, 50, true, true),
        new JdeField("JLITM", "JLITM", JdeDataType.Numeric),
        new JdeField("JLAN8", "JLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JLSDS1", "JLSDS1", JdeDataType.String, 100),
        new JdeField("JLCTYC", "JLCTYC", JdeDataType.String, 6, true, true),
        new JdeField("JLUPRC", "JLUPRC", JdeDataType.Numeric),
        new JdeField("JLPOA", "JLPOA", JdeDataType.Numeric),
        new JdeField("JLEFFF", "JLEFFF", JdeDataType.Numeric),
        new JdeField("JLLDT", "JLLDT", JdeDataType.Numeric),
        new JdeField("JLLTN", "JLLTN", JdeDataType.String, 50),
        new JdeField("JLDSCT", "JLDSCT", JdeDataType.Numeric),
        new JdeField("JLMCU", "JLMCU", JdeDataType.String, 24, true, true),
        new JdeField("JLDSPC", "JLDSPC", JdeDataType.Numeric),
        new JdeField("JLDSQT", "JLDSQT", JdeDataType.Numeric),
        new JdeField("JLMDA", "JLMDA", JdeDataType.Numeric),
        new JdeField("JLMDP", "JLMDP", JdeDataType.Numeric),
        new JdeField("JLMDQ", "JLMDQ", JdeDataType.Numeric),
        new JdeField("JLEXPR", "JLEXPR", JdeDataType.Numeric),
        new JdeField("JLDDC", "JLDDC", JdeDataType.String, 50),
        new JdeField("JLELT", "JLELT", JdeDataType.Numeric),
        new JdeField("JLONR", "JLONR", JdeDataType.String, 2),
        new JdeField("JLPRN", "JLPRN", JdeDataType.Numeric, null, true, true),
        new JdeField("JLBDS", "JLBDS", JdeDataType.String, 2),
        new JdeField("JLPRS", "JLPRS", JdeDataType.String, 2),
        new JdeField("JLBDF", "JLBDF", JdeDataType.String, 2),
        new JdeField("JLXSQ", "JLXSQ", JdeDataType.String, 6),
        new JdeField("JLESQ", "JLESQ", JdeDataType.String, 6),
        new JdeField("JLMDF", "JLMDF", JdeDataType.String, 2),
        new JdeField("JLPCRT", "JLPCRT", JdeDataType.Numeric),
        new JdeField("JLPFR", "JLPFR", JdeDataType.Numeric),
        new JdeField("JLCTN", "JLCTN", JdeDataType.String, 30),
        new JdeField("JLUPMJ", "JLUPMJ", JdeDataType.Numeric),
        new JdeField("JLUSER", "JLUSER", JdeDataType.String, 20),
        new JdeField("JLPID", "JLPID", JdeDataType.String, 20),
        new JdeField("JLJOBN", "JLJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4459_0", "Primary Key on JLCTYC, JLLITM, JLAN8, JLMCU, JLPRN", new[] { "JLCTYC", "JLLITM", "JLAN8", "JLMCU", "JLPRN" }, isUnique: true, isPrimaryKey: true)
    };
}
