using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW25 - .
/// </summary>
public class FCW25 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WOJOBS.
        /// </summary>
        public const string WOJOBS = "WOJOBS";

        /// <summary>
        /// WOUSER.
        /// </summary>
        public const string WOUSER = "WOUSER";

        /// <summary>
        /// WOKCOO.
        /// </summary>
        public const string WOKCOO = "WOKCOO";

        /// <summary>
        /// WODOCO.
        /// </summary>
        public const string WODOCO = "WODOCO";

        /// <summary>
        /// WODCTO.
        /// </summary>
        public const string WODCTO = "WODCTO";

        /// <summary>
        /// WOITM.
        /// </summary>
        public const string WOITM = "WOITM";

        /// <summary>
        /// WOUORG.
        /// </summary>
        public const string WOUORG = "WOUORG";
    }

    /// <inheritdoc />
    public override string TableName => "FCW25";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WOJOBS", "WOJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WOUSER", "WOUSER", JdeDataType.String, 20, true, true),
        new JdeField("WOKCOO", "WOKCOO", JdeDataType.String, 10, true, true),
        new JdeField("WODOCO", "WODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WODCTO", "WODCTO", JdeDataType.String, 4, true, true),
        new JdeField("WOITM", "WOITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WOUORG", "WOUORG", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW25_0", "Primary Key on WOJOBS, WOUSER, WOKCOO, WODOCO, WODCTO, WOITM", new[] { "WOJOBS", "WOUSER", "WOKCOO", "WODOCO", "WODCTO", "WOITM" }, isUnique: true, isPrimaryKey: true)
    };
}
