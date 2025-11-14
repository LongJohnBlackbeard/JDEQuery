using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74GH20T - .
/// </summary>
public class F74GH20T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DKRTXT.
        /// </summary>
        public const string DKRTXT = "DKRTXT";

        /// <summary>
        /// DKUKID.
        /// </summary>
        public const string DKUKID = "DKUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F74GH20T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DKRTXT", "DKRTXT", JdeDataType.String, 258),
        new JdeField("DKUKID", "DKUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74GH20T_0", "Primary Key on DKUKID", new[] { "DKUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
