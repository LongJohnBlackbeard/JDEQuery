using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7404S1 - .
/// </summary>
public class F7404S1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SWMT.
        /// </summary>
        public const string SWMT = "SWMT";

        /// <summary>
        /// SWCENTYR.
        /// </summary>
        public const string SWCENTYR = "SWCENTYR";

        /// <summary>
        /// SWMN3D0.
        /// </summary>
        public const string SWMN3D0 = "SWMN3D0";
    }

    /// <inheritdoc />
    public override string TableName => "F7404S1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SWMT", "SWMT", JdeDataType.Numeric, null, true, true),
        new JdeField("SWCENTYR", "SWCENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("SWMN3D0", "SWMN3D0", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7404S1_0", "Primary Key on SWMT, SWCENTYR", new[] { "SWMT", "SWCENTYR" }, isUnique: true, isPrimaryKey: true)
    };
}
