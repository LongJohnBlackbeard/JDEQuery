using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F9205 - .
/// </summary>
public class F9205 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FRDTAI.
        /// </summary>
        public const string FRDTAI = "FRDTAI";

        /// <summary>
        /// FRPGM.
        /// </summary>
        public const string FRPGM = "FRPGM";
    }

    /// <inheritdoc />
    public override string TableName => "F9205";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FRDTAI", "FRDTAI", JdeDataType.String, 20, true, true),
        new JdeField("FRPGM", "FRPGM", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F9205_0", "Primary Key on FRDTAI", new[] { "FRDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
