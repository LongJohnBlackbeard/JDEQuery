using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03BUI05 - .
/// </summary>
public class F03BUI05 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R5CTID.
        /// </summary>
        public const string R5CTID = "R5CTID";

        /// <summary>
        /// R5JOBS.
        /// </summary>
        public const string R5JOBS = "R5JOBS";

        /// <summary>
        /// R5ICUT.
        /// </summary>
        public const string R5ICUT = "R5ICUT";

        /// <summary>
        /// R5ICU.
        /// </summary>
        public const string R5ICU = "R5ICU";
    }

    /// <inheritdoc />
    public override string TableName => "F03BUI05";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R5CTID", "R5CTID", JdeDataType.String, 30, true, true),
        new JdeField("R5JOBS", "R5JOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("R5ICUT", "R5ICUT", JdeDataType.String, 4, true, true),
        new JdeField("R5ICU", "R5ICU", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03BUI05_0", "Primary Key on R5CTID, R5JOBS, R5ICUT, R5ICU", new[] { "R5CTID", "R5JOBS", "R5ICUT", "R5ICU" }, isUnique: true, isPrimaryKey: true)
    };
}
