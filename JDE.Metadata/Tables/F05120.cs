using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05120 - .
/// </summary>
public class F05120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MMRRTY.
        /// </summary>
        public const string MMRRTY = "MMRRTY";

        /// <summary>
        /// MMAN8.
        /// </summary>
        public const string MMAN8 = "MMAN8";

        /// <summary>
        /// MMCMPE.
        /// </summary>
        public const string MMCMPE = "MMCMPE";

        /// <summary>
        /// MMCMPC.
        /// </summary>
        public const string MMCMPC = "MMCMPC";

        /// <summary>
        /// MMCHDE.
        /// </summary>
        public const string MMCHDE = "MMCHDE";

        /// <summary>
        /// MMTMDY.
        /// </summary>
        public const string MMTMDY = "MMTMDY";

        /// <summary>
        /// MMCMPV.
        /// </summary>
        public const string MMCMPV = "MMCMPV";

        /// <summary>
        /// MMCMPX.
        /// </summary>
        public const string MMCMPX = "MMCMPX";

        /// <summary>
        /// MMUSER.
        /// </summary>
        public const string MMUSER = "MMUSER";

        /// <summary>
        /// MMPID.
        /// </summary>
        public const string MMPID = "MMPID";

        /// <summary>
        /// MMJOBN.
        /// </summary>
        public const string MMJOBN = "MMJOBN";

        /// <summary>
        /// MMUPMJ.
        /// </summary>
        public const string MMUPMJ = "MMUPMJ";

        /// <summary>
        /// MMUPMT.
        /// </summary>
        public const string MMUPMT = "MMUPMT";

        /// <summary>
        /// MMTPST.
        /// </summary>
        public const string MMTPST = "MMTPST";

        /// <summary>
        /// MMCMPDS.
        /// </summary>
        public const string MMCMPDS = "MMCMPDS";
    }

    /// <inheritdoc />
    public override string TableName => "F05120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MMRRTY", "MMRRTY", JdeDataType.String, 4, true, true),
        new JdeField("MMAN8", "MMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("MMCMPE", "MMCMPE", JdeDataType.String, 6, true, true),
        new JdeField("MMCMPC", "MMCMPC", JdeDataType.String, 20, true, true),
        new JdeField("MMCHDE", "MMCHDE", JdeDataType.Numeric, null, true, true),
        new JdeField("MMTMDY", "MMTMDY", JdeDataType.Numeric, null, true, true),
        new JdeField("MMCMPV", "MMCMPV", JdeDataType.Numeric),
        new JdeField("MMCMPX", "MMCMPX", JdeDataType.Numeric),
        new JdeField("MMUSER", "MMUSER", JdeDataType.String, 20),
        new JdeField("MMPID", "MMPID", JdeDataType.String, 20),
        new JdeField("MMJOBN", "MMJOBN", JdeDataType.String, 20),
        new JdeField("MMUPMJ", "MMUPMJ", JdeDataType.Numeric),
        new JdeField("MMUPMT", "MMUPMT", JdeDataType.Numeric),
        new JdeField("MMTPST", "MMTPST", JdeDataType.Numeric),
        new JdeField("MMCMPDS", "MMCMPDS", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05120_0", "Primary Key on MMRRTY, MMAN8, MMCMPE, MMCMPC, MMCHDE, MMTMDY", new[] { "MMRRTY", "MMAN8", "MMCMPE", "MMCMPC", "MMCHDE", "MMTMDY" }, isUnique: true, isPrimaryKey: true)
    };
}
