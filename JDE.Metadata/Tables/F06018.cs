using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06018 - .
/// </summary>
public class F06018 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YFAN8.
        /// </summary>
        public const string YFAN8 = "YFAN8";

        /// <summary>
        /// YFDTCD.
        /// </summary>
        public const string YFDTCD = "YFDTCD";

        /// <summary>
        /// YFPRLN.
        /// </summary>
        public const string YFPRLN = "YFPRLN";

        /// <summary>
        /// YFSEQ.
        /// </summary>
        public const string YFSEQ = "YFSEQ";

        /// <summary>
        /// YFEFTB.
        /// </summary>
        public const string YFEFTB = "YFEFTB";

        /// <summary>
        /// YFEFTE.
        /// </summary>
        public const string YFEFTE = "YFEFTE";

        /// <summary>
        /// YFTKDT.
        /// </summary>
        public const string YFTKDT = "YFTKDT";

        /// <summary>
        /// YFFT5.
        /// </summary>
        public const string YFFT5 = "YFFT5";

        /// <summary>
        /// YFFT2.
        /// </summary>
        public const string YFFT2 = "YFFT2";

        /// <summary>
        /// YFPRLT.
        /// </summary>
        public const string YFPRLT = "YFPRLT";
    }

    /// <inheritdoc />
    public override string TableName => "F06018";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YFAN8", "YFAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YFDTCD", "YFDTCD", JdeDataType.String, 8, true, true),
        new JdeField("YFPRLN", "YFPRLN", JdeDataType.Numeric, null, true, true),
        new JdeField("YFSEQ", "YFSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("YFEFTB", "YFEFTB", JdeDataType.Numeric),
        new JdeField("YFEFTE", "YFEFTE", JdeDataType.Numeric),
        new JdeField("YFTKDT", "YFTKDT", JdeDataType.Numeric),
        new JdeField("YFFT5", "YFFT5", JdeDataType.String, 60),
        new JdeField("YFFT2", "YFFT2", JdeDataType.Numeric),
        new JdeField("YFPRLT", "YFPRLT", JdeDataType.String, 120)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06018_0", "Primary Key on YFAN8, YFDTCD, YFPRLN, YFSEQ", new[] { "YFAN8", "YFDTCD", "YFPRLN", "YFSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
