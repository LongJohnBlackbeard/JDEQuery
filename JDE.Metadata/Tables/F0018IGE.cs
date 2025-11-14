using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0018IGE - .
/// </summary>
public class F0018IGE : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QWRTXT.
        /// </summary>
        public const string QWRTXT = "QWRTXT";

        /// <summary>
        /// QWUKID.
        /// </summary>
        public const string QWUKID = "QWUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F0018IGE";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QWRTXT", "QWRTXT", JdeDataType.String, 258),
        new JdeField("QWUKID", "QWUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0018IGE_0", "Primary Key on QWUKID", new[] { "QWUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
