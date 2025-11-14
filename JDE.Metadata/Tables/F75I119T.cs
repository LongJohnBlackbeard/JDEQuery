using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I119T - .
/// </summary>
public class F75I119T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CNI75CHNO.
        /// </summary>
        public const string CNI75CHNO = "CNI75CHNO";

        /// <summary>
        /// CNAA.
        /// </summary>
        public const string CNAA = "CNAA";

        /// <summary>
        /// CNLNID.
        /// </summary>
        public const string CNLNID = "CNLNID";

        /// <summary>
        /// CNAG.
        /// </summary>
        public const string CNAG = "CNAG";

        /// <summary>
        /// CNDTE.
        /// </summary>
        public const string CNDTE = "CNDTE";
    }

    /// <inheritdoc />
    public override string TableName => "F75I119T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CNI75CHNO", "CNI75CHNO", JdeDataType.String, 120, true, true),
        new JdeField("CNAA", "CNAA", JdeDataType.Numeric),
        new JdeField("CNLNID", "CNLNID", JdeDataType.Numeric),
        new JdeField("CNAG", "CNAG", JdeDataType.Numeric),
        new JdeField("CNDTE", "CNDTE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I119T_0", "Primary Key on CNI75CHNO", new[] { "CNI75CHNO" }, isUnique: true, isPrimaryKey: true)
    };
}
