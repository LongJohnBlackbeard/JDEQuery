using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4351 - .
/// </summary>
public class F4351 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// H2AN8.
        /// </summary>
        public const string H2AN8 = "H2AN8";

        /// <summary>
        /// H2ITM.
        /// </summary>
        public const string H2ITM = "H2ITM";

        /// <summary>
        /// H2HLNK.
        /// </summary>
        public const string H2HLNK = "H2HLNK";
    }

    /// <inheritdoc />
    public override string TableName => "F4351";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("H2AN8", "H2AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("H2ITM", "H2ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("H2HLNK", "H2HLNK", JdeDataType.String, 512)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4351_0", "Primary Key on H2AN8, H2ITM", new[] { "H2AN8", "H2ITM" }, isUnique: true, isPrimaryKey: true)
    };
}
