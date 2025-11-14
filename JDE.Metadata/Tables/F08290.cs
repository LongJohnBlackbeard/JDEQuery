using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08290 - .
/// </summary>
public class F08290 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HGSALY.
        /// </summary>
        public const string HGSALY = "HGSALY";

        /// <summary>
        /// HGSLOC.
        /// </summary>
        public const string HGSLOC = "HGSLOC";

        /// <summary>
        /// HGEFTB.
        /// </summary>
        public const string HGEFTB = "HGEFTB";

        /// <summary>
        /// HGJE$P.
        /// </summary>
        public const string HGJE_P = "HGJE$P";

        /// <summary>
        /// HGBAA.
        /// </summary>
        public const string HGBAA = "HGBAA";

        /// <summary>
        /// HGSMNC.
        /// </summary>
        public const string HGSMNC = "HGSMNC";

        /// <summary>
        /// HGSMXC.
        /// </summary>
        public const string HGSMXC = "HGSMXC";

        /// <summary>
        /// HGGDF.
        /// </summary>
        public const string HGGDF = "HGGDF";

        /// <summary>
        /// HGRNDF.
        /// </summary>
        public const string HGRNDF = "HGRNDF";
    }

    /// <inheritdoc />
    public override string TableName => "F08290";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HGSALY", "HGSALY", JdeDataType.String, 2, true, true),
        new JdeField("HGSLOC", "HGSLOC", JdeDataType.String, 16, true, true),
        new JdeField("HGEFTB", "HGEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("HGJE$P", "HGJE$P", JdeDataType.Numeric),
        new JdeField("HGBAA", "HGBAA", JdeDataType.Numeric),
        new JdeField("HGSMNC", "HGSMNC", JdeDataType.Numeric),
        new JdeField("HGSMXC", "HGSMXC", JdeDataType.Numeric),
        new JdeField("HGGDF", "HGGDF", JdeDataType.Numeric),
        new JdeField("HGRNDF", "HGRNDF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08290_0", "Primary Key on HGSALY, HGSLOC, HGEFTB", new[] { "HGSALY", "HGSLOC", "HGEFTB" }, isUnique: true, isPrimaryKey: true)
    };
}
