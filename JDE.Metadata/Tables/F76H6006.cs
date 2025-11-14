using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H6006 - .
/// </summary>
public class F76H6006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WODCTO.
        /// </summary>
        public const string WODCTO = "WODCTO";

        /// <summary>
        /// WOTYPS.
        /// </summary>
        public const string WOTYPS = "WOTYPS";

        /// <summary>
        /// WOTORG.
        /// </summary>
        public const string WOTORG = "WOTORG";

        /// <summary>
        /// WOUSER.
        /// </summary>
        public const string WOUSER = "WOUSER";

        /// <summary>
        /// WOPID.
        /// </summary>
        public const string WOPID = "WOPID";

        /// <summary>
        /// WOJOBN.
        /// </summary>
        public const string WOJOBN = "WOJOBN";

        /// <summary>
        /// WOUPMJ.
        /// </summary>
        public const string WOUPMJ = "WOUPMJ";

        /// <summary>
        /// WOUPMT.
        /// </summary>
        public const string WOUPMT = "WOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H6006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WODCTO", "WODCTO", JdeDataType.String, 4, true, true),
        new JdeField("WOTYPS", "WOTYPS", JdeDataType.String, 2, true, true),
        new JdeField("WOTORG", "WOTORG", JdeDataType.String, 20),
        new JdeField("WOUSER", "WOUSER", JdeDataType.String, 20),
        new JdeField("WOPID", "WOPID", JdeDataType.String, 20),
        new JdeField("WOJOBN", "WOJOBN", JdeDataType.String, 20),
        new JdeField("WOUPMJ", "WOUPMJ", JdeDataType.Numeric),
        new JdeField("WOUPMT", "WOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H6006_0", "Primary Key on WODCTO, WOTYPS", new[] { "WODCTO", "WOTYPS" }, isUnique: true, isPrimaryKey: true)
    };
}
