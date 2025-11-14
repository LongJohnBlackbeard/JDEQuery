using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01136 - .
/// </summary>
public class F01136 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZPPA8.
        /// </summary>
        public const string ZPPA8 = "ZPPA8";

        /// <summary>
        /// ZPAN8.
        /// </summary>
        public const string ZPAN8 = "ZPAN8";

        /// <summary>
        /// ZPMBDS.
        /// </summary>
        public const string ZPMBDS = "ZPMBDS";
    }

    /// <inheritdoc />
    public override string TableName => "F01136";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZPPA8", "ZPPA8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZPAN8", "ZPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZPMBDS", "ZPMBDS", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01136_0", "Primary Key on ZPPA8, ZPAN8", new[] { "ZPPA8", "ZPAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
