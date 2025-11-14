using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F986030 - .
/// </summary>
public class F986030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMOBNM.
        /// </summary>
        public const string PMOBNM = "PMOBNM";

        /// <summary>
        /// PMSBFATNM.
        /// </summary>
        public const string PMSBFATNM = "PMSBFATNM";

        /// <summary>
        /// PMSBFMDNM.
        /// </summary>
        public const string PMSBFMDNM = "PMSBFMDNM";
    }

    /// <inheritdoc />
    public override string TableName => "F986030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMOBNM", "PMOBNM", JdeDataType.String, 20, true, true),
        new JdeField("PMSBFATNM", "PMSBFATNM", JdeDataType.String, 254, true, true),
        new JdeField("PMSBFMDNM", "PMSBFMDNM", JdeDataType.String, 240, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F986030_0", "Primary Key on PMOBNM, PMSBFATNM, PMSBFMDNM", new[] { "PMOBNM", "PMSBFATNM", "PMSBFMDNM" }, isUnique: true, isPrimaryKey: true)
    };
}
