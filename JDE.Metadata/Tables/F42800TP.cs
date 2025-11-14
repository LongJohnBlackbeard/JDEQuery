using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42800TP - .
/// </summary>
public class F42800TP : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TPBDID.
        /// </summary>
        public const string TPBDID = "TPBDID";

        /// <summary>
        /// TPGBJN.
        /// </summary>
        public const string TPGBJN = "TPGBJN";
    }

    /// <inheritdoc />
    public override string TableName => "F42800TP";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TPBDID", "TPBDID", JdeDataType.Numeric, null, true, true),
        new JdeField("TPGBJN", "TPGBJN", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42800TP_0", "Primary Key on TPBDID, TPGBJN", new[] { "TPBDID", "TPGBJN" }, isUnique: true, isPrimaryKey: true)
    };
}
