using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09505 - .
/// </summary>
public class F09505 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GNAID.
        /// </summary>
        public const string GNAID = "GNAID";

        /// <summary>
        /// GNCN.
        /// </summary>
        public const string GNCN = "GNCN";

        /// <summary>
        /// GNEXA.
        /// </summary>
        public const string GNEXA = "GNEXA";

        /// <summary>
        /// GNAA.
        /// </summary>
        public const string GNAA = "GNAA";

        /// <summary>
        /// GNDKC.
        /// </summary>
        public const string GNDKC = "GNDKC";
    }

    /// <inheritdoc />
    public override string TableName => "F09505";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GNAID", "GNAID", JdeDataType.String, 16, true, true),
        new JdeField("GNCN", "GNCN", JdeDataType.String, 16, true, true),
        new JdeField("GNEXA", "GNEXA", JdeDataType.String, 60),
        new JdeField("GNAA", "GNAA", JdeDataType.Numeric),
        new JdeField("GNDKC", "GNDKC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09505_0", "Primary Key on GNAID, GNCN", new[] { "GNAID", "GNCN" }, isUnique: true, isPrimaryKey: true)
    };
}
