using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06927 - .
/// </summary>
public class F06927 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J5ANN8.
        /// </summary>
        public const string J5ANN8 = "J5ANN8";

        /// <summary>
        /// J5VCHR.
        /// </summary>
        public const string J5VCHR = "J5VCHR";

        /// <summary>
        /// J5VCH1.
        /// </summary>
        public const string J5VCH1 = "J5VCH1";
    }

    /// <inheritdoc />
    public override string TableName => "F06927";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J5ANN8", "J5ANN8", JdeDataType.Numeric, null, true, true),
        new JdeField("J5VCHR", "J5VCHR", JdeDataType.String, 4),
        new JdeField("J5VCH1", "J5VCH1", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06927_0", "Primary Key on J5ANN8", new[] { "J5ANN8" }, isUnique: true, isPrimaryKey: true)
    };
}
