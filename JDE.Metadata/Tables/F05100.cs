using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05100 - .
/// </summary>
public class F05100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMRRTY.
        /// </summary>
        public const string CMRRTY = "CMRRTY";

        /// <summary>
        /// CMAN8.
        /// </summary>
        public const string CMAN8 = "CMAN8";

        /// <summary>
        /// CMCMPE.
        /// </summary>
        public const string CMCMPE = "CMCMPE";

        /// <summary>
        /// CMCMPC.
        /// </summary>
        public const string CMCMPC = "CMCMPC";

        /// <summary>
        /// CMCMPV.
        /// </summary>
        public const string CMCMPV = "CMCMPV";

        /// <summary>
        /// CMCMPX.
        /// </summary>
        public const string CMCMPX = "CMCMPX";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMJOBN.
        /// </summary>
        public const string CMJOBN = "CMJOBN";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMRRTY", "CMRRTY", JdeDataType.String, 4, true, true),
        new JdeField("CMAN8", "CMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CMCMPE", "CMCMPE", JdeDataType.String, 6, true, true),
        new JdeField("CMCMPC", "CMCMPC", JdeDataType.String, 20, true, true),
        new JdeField("CMCMPV", "CMCMPV", JdeDataType.Numeric),
        new JdeField("CMCMPX", "CMCMPX", JdeDataType.Numeric),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05100_0", "Primary Key on CMRRTY, CMAN8, CMCMPE, CMCMPC", new[] { "CMRRTY", "CMAN8", "CMCMPE", "CMCMPC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05100_2", "Index on CMCMPE, CMCMPC, CMRRTY, CMAN8", new[] { "CMCMPE", "CMCMPC", "CMRRTY", "CMAN8" })
    };
}
