using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069312 - .
/// </summary>
public class F069312 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J3TARA.
        /// </summary>
        public const string J3TARA = "J3TARA";

        /// <summary>
        /// J3EFTB.
        /// </summary>
        public const string J3EFTB = "J3EFTB";

        /// <summary>
        /// J3EFTE.
        /// </summary>
        public const string J3EFTE = "J3EFTE";

        /// <summary>
        /// J3STEX.
        /// </summary>
        public const string J3STEX = "J3STEX";

        /// <summary>
        /// J3SDS.
        /// </summary>
        public const string J3SDS = "J3SDS";

        /// <summary>
        /// J3SDHH.
        /// </summary>
        public const string J3SDHH = "J3SDHH";

        /// <summary>
        /// J3SDMS.
        /// </summary>
        public const string J3SDMS = "J3SDMS";

        /// <summary>
        /// J3SDMJ.
        /// </summary>
        public const string J3SDMJ = "J3SDMJ";

        /// <summary>
        /// J3SDSS.
        /// </summary>
        public const string J3SDSS = "J3SDSS";
    }

    /// <inheritdoc />
    public override string TableName => "F069312";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J3TARA", "J3TARA", JdeDataType.String, 20, true, true),
        new JdeField("J3EFTB", "J3EFTB", JdeDataType.Numeric),
        new JdeField("J3EFTE", "J3EFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("J3STEX", "J3STEX", JdeDataType.Numeric),
        new JdeField("J3SDS", "J3SDS", JdeDataType.Numeric),
        new JdeField("J3SDHH", "J3SDHH", JdeDataType.Numeric),
        new JdeField("J3SDMS", "J3SDMS", JdeDataType.Numeric),
        new JdeField("J3SDMJ", "J3SDMJ", JdeDataType.Numeric),
        new JdeField("J3SDSS", "J3SDSS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069312_0", "Primary Key on J3TARA, J3EFTE", new[] { "J3TARA", "J3EFTE" }, isUnique: true, isPrimaryKey: true)
    };
}
