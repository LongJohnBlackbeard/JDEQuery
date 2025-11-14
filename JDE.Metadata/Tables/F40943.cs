using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40943 - .
/// </summary>
public class F40943 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OKSDGR.
        /// </summary>
        public const string OKSDGR = "OKSDGR";

        /// <summary>
        /// OKSDV1.
        /// </summary>
        public const string OKSDV1 = "OKSDV1";

        /// <summary>
        /// OKSDV2.
        /// </summary>
        public const string OKSDV2 = "OKSDV2";

        /// <summary>
        /// OKSDV3.
        /// </summary>
        public const string OKSDV3 = "OKSDV3";

        /// <summary>
        /// OKSDV4.
        /// </summary>
        public const string OKSDV4 = "OKSDV4";

        /// <summary>
        /// OKSDV5.
        /// </summary>
        public const string OKSDV5 = "OKSDV5";

        /// <summary>
        /// OKSDV6.
        /// </summary>
        public const string OKSDV6 = "OKSDV6";

        /// <summary>
        /// OKSDV7.
        /// </summary>
        public const string OKSDV7 = "OKSDV7";

        /// <summary>
        /// OKSDV8.
        /// </summary>
        public const string OKSDV8 = "OKSDV8";

        /// <summary>
        /// OKOGID.
        /// </summary>
        public const string OKOGID = "OKOGID";
    }

    /// <inheritdoc />
    public override string TableName => "F40943";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OKSDGR", "OKSDGR", JdeDataType.String, 16, true, true),
        new JdeField("OKSDV1", "OKSDV1", JdeDataType.String, 24, true, true),
        new JdeField("OKSDV2", "OKSDV2", JdeDataType.String, 24, true, true),
        new JdeField("OKSDV3", "OKSDV3", JdeDataType.String, 24, true, true),
        new JdeField("OKSDV4", "OKSDV4", JdeDataType.String, 24, true, true),
        new JdeField("OKSDV5", "OKSDV5", JdeDataType.String, 24, true, true),
        new JdeField("OKSDV6", "OKSDV6", JdeDataType.String, 24, true, true),
        new JdeField("OKSDV7", "OKSDV7", JdeDataType.String, 24, true, true),
        new JdeField("OKSDV8", "OKSDV8", JdeDataType.String, 24, true, true),
        new JdeField("OKOGID", "OKOGID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40943_0", "Primary Key on OKSDGR, OKSDV1, OKSDV2, OKSDV3, OKSDV4, OKSDV5, OKSDV6, OKSDV7, OKSDV8", new[] { "OKSDGR", "OKSDV1", "OKSDV2", "OKSDV3", "OKSDV4", "OKSDV5", "OKSDV6", "OKSDV7", "OKSDV8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40943_2", "Index on OKOGID", new[] { "OKOGID" })
    };
}
