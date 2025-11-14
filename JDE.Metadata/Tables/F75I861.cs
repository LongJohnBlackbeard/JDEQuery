using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I861 - .
/// </summary>
public class F75I861 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RHUKID.
        /// </summary>
        public const string RHUKID = "RHUKID";

        /// <summary>
        /// RHI75GSTU.
        /// </summary>
        public const string RHI75GSTU = "RHI75GSTU";

        /// <summary>
        /// RHI75GSTIN.
        /// </summary>
        public const string RHI75GSTIN = "RHI75GSTIN";

        /// <summary>
        /// RHYMNTH.
        /// </summary>
        public const string RHYMNTH = "RHYMNTH";

        /// <summary>
        /// RHYMNTH1.
        /// </summary>
        public const string RHYMNTH1 = "RHYMNTH1";

        /// <summary>
        /// RHYLYR.
        /// </summary>
        public const string RHYLYR = "RHYLYR";

        /// <summary>
        /// RHI75CLPDT.
        /// </summary>
        public const string RHI75CLPDT = "RHI75CLPDT";

        /// <summary>
        /// RHUSER.
        /// </summary>
        public const string RHUSER = "RHUSER";

        /// <summary>
        /// RHPID.
        /// </summary>
        public const string RHPID = "RHPID";

        /// <summary>
        /// RHJOBN.
        /// </summary>
        public const string RHJOBN = "RHJOBN";

        /// <summary>
        /// RHUPMJ.
        /// </summary>
        public const string RHUPMJ = "RHUPMJ";

        /// <summary>
        /// RHUPMT.
        /// </summary>
        public const string RHUPMT = "RHUPMT";

        /// <summary>
        /// RHYFUTDT.
        /// </summary>
        public const string RHYFUTDT = "RHYFUTDT";

        /// <summary>
        /// RHFFU4.
        /// </summary>
        public const string RHFFU4 = "RHFFU4";

        /// <summary>
        /// RHFUT3.
        /// </summary>
        public const string RHFUT3 = "RHFUT3";

        /// <summary>
        /// RHX2.
        /// </summary>
        public const string RHX2 = "RHX2";

        /// <summary>
        /// RHFUTCH1.
        /// </summary>
        public const string RHFUTCH1 = "RHFUTCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I861";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RHUKID", "RHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RHI75GSTU", "RHI75GSTU", JdeDataType.Numeric),
        new JdeField("RHI75GSTIN", "RHI75GSTIN", JdeDataType.String, 80),
        new JdeField("RHYMNTH", "RHYMNTH", JdeDataType.String, 4),
        new JdeField("RHYMNTH1", "RHYMNTH1", JdeDataType.String, 4),
        new JdeField("RHYLYR", "RHYLYR", JdeDataType.Numeric),
        new JdeField("RHI75CLPDT", "RHI75CLPDT", JdeDataType.Numeric),
        new JdeField("RHUSER", "RHUSER", JdeDataType.String, 20),
        new JdeField("RHPID", "RHPID", JdeDataType.String, 20),
        new JdeField("RHJOBN", "RHJOBN", JdeDataType.String, 20),
        new JdeField("RHUPMJ", "RHUPMJ", JdeDataType.Numeric),
        new JdeField("RHUPMT", "RHUPMT", JdeDataType.Numeric),
        new JdeField("RHYFUTDT", "RHYFUTDT", JdeDataType.Numeric),
        new JdeField("RHFFU4", "RHFFU4", JdeDataType.Numeric),
        new JdeField("RHFUT3", "RHFUT3", JdeDataType.String, 60),
        new JdeField("RHX2", "RHX2", JdeDataType.String, 2),
        new JdeField("RHFUTCH1", "RHFUTCH1", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I861_0", "Primary Key on RHUKID", new[] { "RHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I861_2", "Unique Index on RHI75GSTU, RHYMNTH, RHYLYR", new[] { "RHI75GSTU", "RHYMNTH", "RHYLYR" }, isUnique: true)
    };
}
