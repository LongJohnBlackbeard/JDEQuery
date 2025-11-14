using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I3451 - .
/// </summary>
public class F75I3451 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QDYEXU.
        /// </summary>
        public const string QDYEXU = "QDYEXU";

        /// <summary>
        /// QDYAR3N.
        /// </summary>
        public const string QDYAR3N = "QDYAR3N";

        /// <summary>
        /// QDYSUF.
        /// </summary>
        public const string QDYSUF = "QDYSUF";

        /// <summary>
        /// QDYARD.
        /// </summary>
        public const string QDYARD = "QDYARD";

        /// <summary>
        /// QDYAR3D.
        /// </summary>
        public const string QDYAR3D = "QDYAR3D";

        /// <summary>
        /// QDLNID.
        /// </summary>
        public const string QDLNID = "QDLNID";

        /// <summary>
        /// QDMCU.
        /// </summary>
        public const string QDMCU = "QDMCU";

        /// <summary>
        /// QDITM.
        /// </summary>
        public const string QDITM = "QDITM";

        /// <summary>
        /// QDLITM.
        /// </summary>
        public const string QDLITM = "QDLITM";

        /// <summary>
        /// QDAITM.
        /// </summary>
        public const string QDAITM = "QDAITM";

        /// <summary>
        /// QDLOCN.
        /// </summary>
        public const string QDLOCN = "QDLOCN";

        /// <summary>
        /// QDQTY.
        /// </summary>
        public const string QDQTY = "QDQTY";

        /// <summary>
        /// QDLOTN.
        /// </summary>
        public const string QDLOTN = "QDLOTN";

        /// <summary>
        /// QDUPRC.
        /// </summary>
        public const string QDUPRC = "QDUPRC";

        /// <summary>
        /// QDLPRC.
        /// </summary>
        public const string QDLPRC = "QDLPRC";

        /// <summary>
        /// QDSOQS.
        /// </summary>
        public const string QDSOQS = "QDSOQS";

        /// <summary>
        /// QDYWRE.
        /// </summary>
        public const string QDYWRE = "QDYWRE";

        /// <summary>
        /// QDYWRD.
        /// </summary>
        public const string QDYWRD = "QDYWRD";

        /// <summary>
        /// QDTORG.
        /// </summary>
        public const string QDTORG = "QDTORG";

        /// <summary>
        /// QDUSER.
        /// </summary>
        public const string QDUSER = "QDUSER";

        /// <summary>
        /// QDPID.
        /// </summary>
        public const string QDPID = "QDPID";

        /// <summary>
        /// QDJOBN.
        /// </summary>
        public const string QDJOBN = "QDJOBN";

        /// <summary>
        /// QDUPMJ.
        /// </summary>
        public const string QDUPMJ = "QDUPMJ";

        /// <summary>
        /// QDUPMT.
        /// </summary>
        public const string QDUPMT = "QDUPMT";

        /// <summary>
        /// QDTDAY.
        /// </summary>
        public const string QDTDAY = "QDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F75I3451";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QDYEXU", "QDYEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("QDYAR3N", "QDYAR3N", JdeDataType.Numeric, null, true, true),
        new JdeField("QDYSUF", "QDYSUF", JdeDataType.String, 4, true, true),
        new JdeField("QDYARD", "QDYARD", JdeDataType.Numeric, null, true, true),
        new JdeField("QDYAR3D", "QDYAR3D", JdeDataType.Numeric),
        new JdeField("QDLNID", "QDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("QDMCU", "QDMCU", JdeDataType.String, 24),
        new JdeField("QDITM", "QDITM", JdeDataType.Numeric),
        new JdeField("QDLITM", "QDLITM", JdeDataType.String, 50),
        new JdeField("QDAITM", "QDAITM", JdeDataType.String, 50),
        new JdeField("QDLOCN", "QDLOCN", JdeDataType.String, 40),
        new JdeField("QDQTY", "QDQTY", JdeDataType.Numeric),
        new JdeField("QDLOTN", "QDLOTN", JdeDataType.String, 60),
        new JdeField("QDUPRC", "QDUPRC", JdeDataType.Numeric),
        new JdeField("QDLPRC", "QDLPRC", JdeDataType.Numeric),
        new JdeField("QDSOQS", "QDSOQS", JdeDataType.Numeric),
        new JdeField("QDYWRE", "QDYWRE", JdeDataType.Numeric),
        new JdeField("QDYWRD", "QDYWRD", JdeDataType.Numeric),
        new JdeField("QDTORG", "QDTORG", JdeDataType.String, 20),
        new JdeField("QDUSER", "QDUSER", JdeDataType.String, 20),
        new JdeField("QDPID", "QDPID", JdeDataType.String, 20),
        new JdeField("QDJOBN", "QDJOBN", JdeDataType.String, 20),
        new JdeField("QDUPMJ", "QDUPMJ", JdeDataType.Numeric),
        new JdeField("QDUPMT", "QDUPMT", JdeDataType.Numeric),
        new JdeField("QDTDAY", "QDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I3451_0", "Primary Key on QDYEXU, QDYAR3N, QDYSUF, QDLNID, QDYARD", new[] { "QDYEXU", "QDYAR3N", "QDYSUF", "QDLNID", "QDYARD" }, isUnique: true, isPrimaryKey: true)
    };
}
