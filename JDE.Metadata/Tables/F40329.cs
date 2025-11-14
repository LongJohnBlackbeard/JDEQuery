using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40329 - .
/// </summary>
public class F40329 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DDAN8.
        /// </summary>
        public const string DDAN8 = "DDAN8";

        /// <summary>
        /// DDCS29.
        /// </summary>
        public const string DDCS29 = "DDCS29";

        /// <summary>
        /// DDITM.
        /// </summary>
        public const string DDITM = "DDITM";

        /// <summary>
        /// DDIT79.
        /// </summary>
        public const string DDIT79 = "DDIT79";

        /// <summary>
        /// DDEFTJ.
        /// </summary>
        public const string DDEFTJ = "DDEFTJ";

        /// <summary>
        /// DDEXDJ.
        /// </summary>
        public const string DDEXDJ = "DDEXDJ";

        /// <summary>
        /// DDMNQ.
        /// </summary>
        public const string DDMNQ = "DDMNQ";

        /// <summary>
        /// DDMXQ.
        /// </summary>
        public const string DDMXQ = "DDMXQ";

        /// <summary>
        /// DDUOM.
        /// </summary>
        public const string DDUOM = "DDUOM";

        /// <summary>
        /// DDTXID.
        /// </summary>
        public const string DDTXID = "DDTXID";

        /// <summary>
        /// DDSTPR.
        /// </summary>
        public const string DDSTPR = "DDSTPR";

        /// <summary>
        /// DDOSEQ.
        /// </summary>
        public const string DDOSEQ = "DDOSEQ";

        /// <summary>
        /// DDMCU.
        /// </summary>
        public const string DDMCU = "DDMCU";

        /// <summary>
        /// DDMOT.
        /// </summary>
        public const string DDMOT = "DDMOT";

        /// <summary>
        /// DDDCCD.
        /// </summary>
        public const string DDDCCD = "DDDCCD";

        /// <summary>
        /// DDAN81.
        /// </summary>
        public const string DDAN81 = "DDAN81";

        /// <summary>
        /// DDOUTQ.
        /// </summary>
        public const string DDOUTQ = "DDOUTQ";

        /// <summary>
        /// DDCPY#.
        /// </summary>
        public const string DDCPY_ = "DDCPY#";

        /// <summary>
        /// DDURCD.
        /// </summary>
        public const string DDURCD = "DDURCD";

        /// <summary>
        /// DDURDT.
        /// </summary>
        public const string DDURDT = "DDURDT";

        /// <summary>
        /// DDURAT.
        /// </summary>
        public const string DDURAT = "DDURAT";

        /// <summary>
        /// DDURAB.
        /// </summary>
        public const string DDURAB = "DDURAB";

        /// <summary>
        /// DDURRF.
        /// </summary>
        public const string DDURRF = "DDURRF";

        /// <summary>
        /// DDUSER.
        /// </summary>
        public const string DDUSER = "DDUSER";

        /// <summary>
        /// DDPID.
        /// </summary>
        public const string DDPID = "DDPID";

        /// <summary>
        /// DDJOBN.
        /// </summary>
        public const string DDJOBN = "DDJOBN";

        /// <summary>
        /// DDUPMJ.
        /// </summary>
        public const string DDUPMJ = "DDUPMJ";

        /// <summary>
        /// DDTDAY.
        /// </summary>
        public const string DDTDAY = "DDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40329";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DDAN8", "DDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DDCS29", "DDCS29", JdeDataType.String, 16, true, true),
        new JdeField("DDITM", "DDITM", JdeDataType.Numeric, null, true, true),
        new JdeField("DDIT79", "DDIT79", JdeDataType.String, 16, true, true),
        new JdeField("DDEFTJ", "DDEFTJ", JdeDataType.Numeric),
        new JdeField("DDEXDJ", "DDEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("DDMNQ", "DDMNQ", JdeDataType.Numeric),
        new JdeField("DDMXQ", "DDMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DDUOM", "DDUOM", JdeDataType.String, 4, true, true),
        new JdeField("DDTXID", "DDTXID", JdeDataType.Numeric),
        new JdeField("DDSTPR", "DDSTPR", JdeDataType.String, 2),
        new JdeField("DDOSEQ", "DDOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("DDMCU", "DDMCU", JdeDataType.String, 24),
        new JdeField("DDMOT", "DDMOT", JdeDataType.String, 6),
        new JdeField("DDDCCD", "DDDCCD", JdeDataType.String, 8),
        new JdeField("DDAN81", "DDAN81", JdeDataType.Numeric),
        new JdeField("DDOUTQ", "DDOUTQ", JdeDataType.String, 20),
        new JdeField("DDCPY#", "DDCPY#", JdeDataType.String, 6),
        new JdeField("DDURCD", "DDURCD", JdeDataType.String, 4),
        new JdeField("DDURDT", "DDURDT", JdeDataType.Numeric),
        new JdeField("DDURAT", "DDURAT", JdeDataType.Numeric),
        new JdeField("DDURAB", "DDURAB", JdeDataType.Numeric),
        new JdeField("DDURRF", "DDURRF", JdeDataType.String, 30),
        new JdeField("DDUSER", "DDUSER", JdeDataType.String, 20),
        new JdeField("DDPID", "DDPID", JdeDataType.String, 20),
        new JdeField("DDJOBN", "DDJOBN", JdeDataType.String, 20),
        new JdeField("DDUPMJ", "DDUPMJ", JdeDataType.Numeric),
        new JdeField("DDTDAY", "DDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40329_0", "Primary Key on DDAN8, DDCS29, DDITM, DDIT79, DDEXDJ, DDUOM, DDMXQ, DDOSEQ", new[] { "DDAN8", "DDCS29", "DDITM", "DDIT79", "DDEXDJ", "DDUOM", "DDMXQ", "DDOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
