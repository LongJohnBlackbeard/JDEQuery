using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7409FOW - .
/// </summary>
public class F7409FOW : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ETUSER.
        /// </summary>
        public const string ETUSER = "ETUSER";

        /// <summary>
        /// ETMID.
        /// </summary>
        public const string ETMID = "ETMID";

        /// <summary>
        /// ETLNID.
        /// </summary>
        public const string ETLNID = "ETLNID";

        /// <summary>
        /// ETETAFI.
        /// </summary>
        public const string ETETAFI = "ETETAFI";
    }

    /// <inheritdoc />
    public override string TableName => "F7409FOW";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ETUSER", "ETUSER", JdeDataType.String, 20, true, true),
        new JdeField("ETMID", "ETMID", JdeDataType.String, 20, true, true),
        new JdeField("ETLNID", "ETLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ETETAFI", "ETETAFI", JdeDataType.String, 320)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7409FOW_0", "Primary Key on ETUSER, ETMID, ETLNID", new[] { "ETUSER", "ETMID", "ETLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
