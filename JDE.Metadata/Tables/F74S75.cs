using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S75 - .
/// </summary>
public class F74S75 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Q5STID.
        /// </summary>
        public const string Q5STID = "Q5STID";

        /// <summary>
        /// Q5SYEA.
        /// </summary>
        public const string Q5SYEA = "Q5SYEA";

        /// <summary>
        /// Q5SCVT.
        /// </summary>
        public const string Q5SCVT = "Q5SCVT";
    }

    /// <inheritdoc />
    public override string TableName => "F74S75";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Q5STID", "Q5STID", JdeDataType.String, 18, true, true),
        new JdeField("Q5SYEA", "Q5SYEA", JdeDataType.Numeric, null, true, true),
        new JdeField("Q5SCVT", "Q5SCVT", JdeDataType.String, 18, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S75_0", "Primary Key on Q5STID, Q5SYEA, Q5SCVT", new[] { "Q5STID", "Q5SYEA", "Q5SCVT" }, isUnique: true, isPrimaryKey: true)
    };
}
