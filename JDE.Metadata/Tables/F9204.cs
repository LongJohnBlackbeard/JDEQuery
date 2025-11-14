using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F9204 - .
/// </summary>
public class F9204 : JdeTable
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
        /// FRALIS.
        /// </summary>
        public const string FRALIS = "FRALIS";

        /// <summary>
        /// FRALST.
        /// </summary>
        public const string FRALST = "FRALST";
    }

    /// <inheritdoc />
    public override string TableName => "F9204";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FRDTAI", "FRDTAI", JdeDataType.String, 20, true, true),
        new JdeField("FRALIS", "FRALIS", JdeDataType.String, 60, true, true),
        new JdeField("FRALST", "FRALST", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F9204_0", "Primary Key on FRDTAI, FRALST, FRALIS", new[] { "FRDTAI", "FRALST", "FRALIS" }, isUnique: true, isPrimaryKey: true)
    };
}
