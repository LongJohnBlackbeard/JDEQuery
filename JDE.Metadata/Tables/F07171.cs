using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07171 - .
/// </summary>
public class F07171 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JPAN8.
        /// </summary>
        public const string JPAN8 = "JPAN8";

        /// <summary>
        /// JPROEN.
        /// </summary>
        public const string JPROEN = "JPROEN";

        /// <summary>
        /// JPLINS.
        /// </summary>
        public const string JPLINS = "JPLINS";

        /// <summary>
        /// JPDSCA.
        /// </summary>
        public const string JPDSCA = "JPDSCA";
    }

    /// <inheritdoc />
    public override string TableName => "F07171";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JPAN8", "JPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JPROEN", "JPROEN", JdeDataType.String, 22, true, true),
        new JdeField("JPLINS", "JPLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("JPDSCA", "JPDSCA", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07171_0", "Primary Key on JPAN8, JPROEN, JPLINS", new[] { "JPAN8", "JPROEN", "JPLINS" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07171_2", "Index on JPAN8", new[] { "JPAN8" })
    };
}
