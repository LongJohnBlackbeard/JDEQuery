using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F04257W2 - .
/// </summary>
public class F04257W2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KEPSEL.
        /// </summary>
        public const string KEPSEL = "KEPSEL";

        /// <summary>
        /// KEGLBA.
        /// </summary>
        public const string KEGLBA = "KEGLBA";

        /// <summary>
        /// KEMCU.
        /// </summary>
        public const string KEMCU = "KEMCU";

        /// <summary>
        /// KEHDC.
        /// </summary>
        public const string KEHDC = "KEHDC";
    }

    /// <inheritdoc />
    public override string TableName => "F04257W2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KEPSEL", "KEPSEL", JdeDataType.Numeric, null, true, true),
        new JdeField("KEGLBA", "KEGLBA", JdeDataType.String, 16, true, true),
        new JdeField("KEMCU", "KEMCU", JdeDataType.String, 24, true, true),
        new JdeField("KEHDC", "KEHDC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F04257W2_0", "Primary Key on KEPSEL, KEGLBA, KEMCU, KEHDC", new[] { "KEPSEL", "KEGLBA", "KEMCU", "KEHDC" }, isUnique: true, isPrimaryKey: true)
    };
}
