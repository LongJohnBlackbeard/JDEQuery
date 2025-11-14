using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7603BZ1 - .
/// </summary>
public class F7603BZ1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSBDS4.
        /// </summary>
        public const string BSBDS4 = "BSBDS4";

        /// <summary>
        /// BSUKID.
        /// </summary>
        public const string BSUKID = "BSUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F7603BZ1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSBDS4", "BSBDS4", JdeDataType.String, 800),
        new JdeField("BSUKID", "BSUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7603BZ1_0", "Primary Key on BSUKID", new[] { "BSUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
