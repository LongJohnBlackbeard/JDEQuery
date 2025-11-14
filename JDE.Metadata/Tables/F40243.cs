using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40243 - .
/// </summary>
public class F40243 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRMCU.
        /// </summary>
        public const string CRMCU = "CRMCU";

        /// <summary>
        /// CROBJ.
        /// </summary>
        public const string CROBJ = "CROBJ";

        /// <summary>
        /// CRSUB.
        /// </summary>
        public const string CRSUB = "CRSUB";

        /// <summary>
        /// CRUNSPSC.
        /// </summary>
        public const string CRUNSPSC = "CRUNSPSC";
    }

    /// <inheritdoc />
    public override string TableName => "F40243";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRMCU", "CRMCU", JdeDataType.String, 24, true, true),
        new JdeField("CROBJ", "CROBJ", JdeDataType.String, 12, true, true),
        new JdeField("CRSUB", "CRSUB", JdeDataType.String, 16, true, true),
        new JdeField("CRUNSPSC", "CRUNSPSC", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40243_0", "Primary Key on CRMCU, CROBJ, CRSUB", new[] { "CRMCU", "CROBJ", "CRSUB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40243_2", "Index on CRUNSPSC", new[] { "CRUNSPSC" })
    };
}
