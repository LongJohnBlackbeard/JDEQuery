using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0018IGI - .
/// </summary>
public class F0018IGI : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XYRTXT.
        /// </summary>
        public const string XYRTXT = "XYRTXT";

        /// <summary>
        /// XYUKID.
        /// </summary>
        public const string XYUKID = "XYUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F0018IGI";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XYRTXT", "XYRTXT", JdeDataType.String, 258),
        new JdeField("XYUKID", "XYUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0018IGI_0", "Primary Key on XYUKID", new[] { "XYUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
