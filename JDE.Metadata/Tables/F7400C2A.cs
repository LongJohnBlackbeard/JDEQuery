using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7400C2A - .
/// </summary>
public class F7400C2A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FCPYID.
        /// </summary>
        public const string FCPYID = "FCPYID";

        /// <summary>
        /// FCRC5.
        /// </summary>
        public const string FCRC5 = "FCRC5";

        /// <summary>
        /// FCEV01.
        /// </summary>
        public const string FCEV01 = "FCEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F7400C2A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FCPYID", "FCPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("FCRC5", "FCRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("FCEV01", "FCEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7400C2A_0", "Primary Key on FCPYID, FCRC5", new[] { "FCPYID", "FCRC5" }, isUnique: true, isPrimaryKey: true)
    };
}
