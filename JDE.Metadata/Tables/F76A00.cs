using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A00 - .
/// </summary>
public class F76A00 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T0SY.
        /// </summary>
        public const string T0SY = "T0SY";

        /// <summary>
        /// T0ANAT.
        /// </summary>
        public const string T0ANAT = "T0ANAT";

        /// <summary>
        /// T0AOTT.
        /// </summary>
        public const string T0AOTT = "T0AOTT";
    }

    /// <inheritdoc />
    public override string TableName => "F76A00";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T0SY", "T0SY", JdeDataType.String, 8, true, true),
        new JdeField("T0ANAT", "T0ANAT", JdeDataType.String, 2),
        new JdeField("T0AOTT", "T0AOTT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A00_0", "Primary Key on T0SY", new[] { "T0SY" }, isUnique: true, isPrimaryKey: true)
    };
}
