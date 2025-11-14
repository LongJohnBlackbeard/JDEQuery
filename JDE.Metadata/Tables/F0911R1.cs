using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0911R1 - .
/// </summary>
public class F0911R1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GLAID.
        /// </summary>
        public const string GLAID = "GLAID";

        /// <summary>
        /// GLAA1.
        /// </summary>
        public const string GLAA1 = "GLAA1";

        /// <summary>
        /// GLAA2.
        /// </summary>
        public const string GLAA2 = "GLAA2";

        /// <summary>
        /// GLAA.
        /// </summary>
        public const string GLAA = "GLAA";

        /// <summary>
        /// GLDTE.
        /// </summary>
        public const string GLDTE = "GLDTE";

        /// <summary>
        /// GLBSEB.
        /// </summary>
        public const string GLBSEB = "GLBSEB";

        /// <summary>
        /// GLCO.
        /// </summary>
        public const string GLCO = "GLCO";

        /// <summary>
        /// GLLT.
        /// </summary>
        public const string GLLT = "GLLT";

        /// <summary>
        /// GLCRCD.
        /// </summary>
        public const string GLCRCD = "GLCRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F0911R1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GLAID", "GLAID", JdeDataType.String, 16, true, true),
        new JdeField("GLAA1", "GLAA1", JdeDataType.Numeric),
        new JdeField("GLAA2", "GLAA2", JdeDataType.Numeric),
        new JdeField("GLAA", "GLAA", JdeDataType.Numeric),
        new JdeField("GLDTE", "GLDTE", JdeDataType.Numeric),
        new JdeField("GLBSEB", "GLBSEB", JdeDataType.Numeric),
        new JdeField("GLCO", "GLCO", JdeDataType.String, 10),
        new JdeField("GLLT", "GLLT", JdeDataType.String, 4, true, true),
        new JdeField("GLCRCD", "GLCRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0911R1_0", "Primary Key on GLAID, GLLT", new[] { "GLAID", "GLLT" }, isUnique: true, isPrimaryKey: true)
    };
}
