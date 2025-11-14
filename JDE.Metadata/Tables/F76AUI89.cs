using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76AUI89 - .
/// </summary>
public class F76AUI89 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFSEQ.
        /// </summary>
        public const string WFSEQ = "WFSEQ";

        /// <summary>
        /// WFCO.
        /// </summary>
        public const string WFCO = "WFCO";

        /// <summary>
        /// WFKCO.
        /// </summary>
        public const string WFKCO = "WFKCO";

        /// <summary>
        /// WFDCT.
        /// </summary>
        public const string WFDCT = "WFDCT";

        /// <summary>
        /// WFDOC.
        /// </summary>
        public const string WFDOC = "WFDOC";

        /// <summary>
        /// WFSFX.
        /// </summary>
        public const string WFSFX = "WFSFX";

        /// <summary>
        /// WFAN8.
        /// </summary>
        public const string WFAN8 = "WFAN8";

        /// <summary>
        /// WFVR01.
        /// </summary>
        public const string WFVR01 = "WFVR01";

        /// <summary>
        /// WFAG.
        /// </summary>
        public const string WFAG = "WFAG";

        /// <summary>
        /// WFATXA.
        /// </summary>
        public const string WFATXA = "WFATXA";

        /// <summary>
        /// WFRMK.
        /// </summary>
        public const string WFRMK = "WFRMK";

        /// <summary>
        /// WFVINV.
        /// </summary>
        public const string WFVINV = "WFVINV";

        /// <summary>
        /// WFCKAM.
        /// </summary>
        public const string WFCKAM = "WFCKAM";

        /// <summary>
        /// WFFCAM.
        /// </summary>
        public const string WFFCAM = "WFFCAM";

        /// <summary>
        /// WFCRR.
        /// </summary>
        public const string WFCRR = "WFCRR";

        /// <summary>
        /// WFRREF.
        /// </summary>
        public const string WFRREF = "WFRREF";

        /// <summary>
        /// WFDMTJ.
        /// </summary>
        public const string WFDMTJ = "WFDMTJ";

        /// <summary>
        /// WFPAAP.
        /// </summary>
        public const string WFPAAP = "WFPAAP";

        /// <summary>
        /// WFPFAP.
        /// </summary>
        public const string WFPFAP = "WFPFAP";

        /// <summary>
        /// WFTXA1.
        /// </summary>
        public const string WFTXA1 = "WFTXA1";

        /// <summary>
        /// WFEXR1.
        /// </summary>
        public const string WFEXR1 = "WFEXR1";

        /// <summary>
        /// WFTXR1.
        /// </summary>
        public const string WFTXR1 = "WFTXR1";
    }

    /// <inheritdoc />
    public override string TableName => "F76AUI89";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30, true, true),
        new JdeField("WFSEQ", "WFSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCO", "WFCO", JdeDataType.String, 10),
        new JdeField("WFKCO", "WFKCO", JdeDataType.String, 10),
        new JdeField("WFDCT", "WFDCT", JdeDataType.String, 4),
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric),
        new JdeField("WFSFX", "WFSFX", JdeDataType.String, 6),
        new JdeField("WFAN8", "WFAN8", JdeDataType.Numeric),
        new JdeField("WFVR01", "WFVR01", JdeDataType.String, 50),
        new JdeField("WFAG", "WFAG", JdeDataType.Numeric),
        new JdeField("WFATXA", "WFATXA", JdeDataType.Numeric),
        new JdeField("WFRMK", "WFRMK", JdeDataType.String, 60),
        new JdeField("WFVINV", "WFVINV", JdeDataType.String, 50),
        new JdeField("WFCKAM", "WFCKAM", JdeDataType.Numeric),
        new JdeField("WFFCAM", "WFFCAM", JdeDataType.Numeric),
        new JdeField("WFCRR", "WFCRR", JdeDataType.Numeric),
        new JdeField("WFRREF", "WFRREF", JdeDataType.String, 50),
        new JdeField("WFDMTJ", "WFDMTJ", JdeDataType.Numeric),
        new JdeField("WFPAAP", "WFPAAP", JdeDataType.Numeric),
        new JdeField("WFPFAP", "WFPFAP", JdeDataType.Numeric),
        new JdeField("WFTXA1", "WFTXA1", JdeDataType.String, 20),
        new JdeField("WFEXR1", "WFEXR1", JdeDataType.String, 4),
        new JdeField("WFTXR1", "WFTXR1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76AUI89_0", "Primary Key on WFJOBS, WFCTID, WFSEQ", new[] { "WFJOBS", "WFCTID", "WFSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76AUI89_2", "Index on WFKCO, WFDCT, WFDOC, WFSFX", new[] { "WFKCO", "WFDCT", "WFDOC", "WFSFX" }),
        new JdeIndex("F76AUI89_3", "Index on WFKCO, WFAN8", new[] { "WFKCO", "WFAN8" }),
        new JdeIndex("F76AUI89_4", "Index on WFKCO, WFDCT, WFDOC, WFTXA1, WFEXR1", new[] { "WFKCO", "WFDCT", "WFDOC", "WFTXA1", "WFEXR1" })
    };
}
