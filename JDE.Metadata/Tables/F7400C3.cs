using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7400C3 - .
/// </summary>
public class F7400C3 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TGPYID.
        /// </summary>
        public const string TGPYID = "TGPYID";

        /// <summary>
        /// TGRC5.
        /// </summary>
        public const string TGRC5 = "TGRC5";

        /// <summary>
        /// TGEV01.
        /// </summary>
        public const string TGEV01 = "TGEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F7400C3";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TGPYID", "TGPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("TGRC5", "TGRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("TGEV01", "TGEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7400C3_0", "Primary Key on TGPYID, TGRC5", new[] { "TGPYID", "TGRC5" }, isUnique: true, isPrimaryKey: true)
    };
}
