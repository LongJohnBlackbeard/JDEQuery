using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F186206 - .
/// </summary>
public class F186206 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LGAN8.
        /// </summary>
        public const string LGAN8 = "LGAN8";

        /// <summary>
        /// LGLRSEGN.
        /// </summary>
        public const string LGLRSEGN = "LGLRSEGN";

        /// <summary>
        /// LGLRSEGID.
        /// </summary>
        public const string LGLRSEGID = "LGLRSEGID";
    }

    /// <inheritdoc />
    public override string TableName => "F186206";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LGAN8", "LGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("LGLRSEGN", "LGLRSEGN", JdeDataType.String, 60),
        new JdeField("LGLRSEGID", "LGLRSEGID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F186206_0", "Primary Key on LGAN8", new[] { "LGAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F186206_2", "Index on LGLRSEGID", new[] { "LGLRSEGID" })
    };
}
