using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3111T - .
/// </summary>
public class F3111T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WMUKID.
        /// </summary>
        public const string WMUKID = "WMUKID";

        /// <summary>
        /// WMPOC.
        /// </summary>
        public const string WMPOC = "WMPOC";

        /// <summary>
        /// WMVEND.
        /// </summary>
        public const string WMVEND = "WMVEND";

        /// <summary>
        /// WMCTS4.
        /// </summary>
        public const string WMCTS4 = "WMCTS4";

        /// <summary>
        /// WMCTS7.
        /// </summary>
        public const string WMCTS7 = "WMCTS7";

        /// <summary>
        /// WMCTS8.
        /// </summary>
        public const string WMCTS8 = "WMCTS8";

        /// <summary>
        /// WMQNTY.
        /// </summary>
        public const string WMQNTY = "WMQNTY";
    }

    /// <inheritdoc />
    public override string TableName => "F3111T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WMUKID", "WMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WMPOC", "WMPOC", JdeDataType.String, 2),
        new JdeField("WMVEND", "WMVEND", JdeDataType.Numeric),
        new JdeField("WMCTS4", "WMCTS4", JdeDataType.Numeric),
        new JdeField("WMCTS7", "WMCTS7", JdeDataType.Numeric),
        new JdeField("WMCTS8", "WMCTS8", JdeDataType.Numeric),
        new JdeField("WMQNTY", "WMQNTY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3111T_0", "Primary Key on WMUKID", new[] { "WMUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
