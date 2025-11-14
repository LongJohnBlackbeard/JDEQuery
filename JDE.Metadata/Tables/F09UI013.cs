using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI013 - .
/// </summary>
public class F09UI013 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLICUT.
        /// </summary>
        public const string GLICUT = "GLICUT";

        /// <summary>
        /// GLICU.
        /// </summary>
        public const string GLICU = "GLICU";

        /// <summary>
        /// GLCO.
        /// </summary>
        public const string GLCO = "GLCO";

        /// <summary>
        /// GLLT.
        /// </summary>
        public const string GLLT = "GLLT";

        /// <summary>
        /// GLAA.
        /// </summary>
        public const string GLAA = "GLAA";
    }

    /// <inheritdoc />
    public override string TableName => "F09UI013";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLICUT", "GLICUT", JdeDataType.String, 4, true, true),
        new JdeField("GLICU", "GLICU", JdeDataType.Numeric, null, true, true),
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10, true, true),
        new JdeField("GLLT", "GLLT", JdeDataType.String, 4, true, true),
        new JdeField("GLAA", "GLAA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI013_0", "Primary Key on GLICUT, GLICU, GLCO, GLLT", new[] { "GLICUT", "GLICU", "GLCO", "GLLT" }, isUnique: true, isPrimaryKey: true)
    };
}
