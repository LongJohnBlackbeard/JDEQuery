using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41829 - .
/// </summary>
public class F41829 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IWSRWD.
        /// </summary>
        public const string IWSRWD = "IWSRWD";

        /// <summary>
        /// IWITM.
        /// </summary>
        public const string IWITM = "IWITM";
    }

    /// <inheritdoc />
    public override string TableName => "F41829";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IWSRWD", "IWSRWD", JdeDataType.String, 40, true, true),
        new JdeField("IWITM", "IWITM", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41829_0", "Primary Key on IWSRWD, IWITM", new[] { "IWSRWD", "IWITM" }, isUnique: true, isPrimaryKey: true)
    };
}
