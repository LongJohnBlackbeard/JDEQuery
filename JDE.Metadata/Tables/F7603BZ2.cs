using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7603BZ2 - .
/// </summary>
public class F7603BZ2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BRBDS4.
        /// </summary>
        public const string BRBDS4 = "BRBDS4";

        /// <summary>
        /// BRUKID.
        /// </summary>
        public const string BRUKID = "BRUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F7603BZ2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BRBDS4", "BRBDS4", JdeDataType.String, 800),
        new JdeField("BRUKID", "BRUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7603BZ2_0", "Primary Key on BRUKID", new[] { "BRUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
