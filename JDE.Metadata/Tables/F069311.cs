using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069311 - .
/// </summary>
public class F069311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J3WAMS.
        /// </summary>
        public const string J3WAMS = "J3WAMS";

        /// <summary>
        /// J3WADF.
        /// </summary>
        public const string J3WADF = "J3WADF";

        /// <summary>
        /// J3PFRQ.
        /// </summary>
        public const string J3PFRQ = "J3PFRQ";

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
    }

    /// <inheritdoc />
    public override string TableName => "F069311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J3WAMS", "J3WAMS", JdeDataType.String, 2, true, true),
        new JdeField("J3WADF", "J3WADF", JdeDataType.String, 2, true, true),
        new JdeField("J3PFRQ", "J3PFRQ", JdeDataType.String, 2, true, true),
        new JdeField("J3EFTB", "J3EFTB", JdeDataType.Numeric),
        new JdeField("J3EFTE", "J3EFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("J3STEX", "J3STEX", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069311_0", "Primary Key on J3WAMS, J3WADF, J3PFRQ, J3EFTE", new[] { "J3WAMS", "J3WADF", "J3PFRQ", "J3EFTE" }, isUnique: true, isPrimaryKey: true)
    };
}
