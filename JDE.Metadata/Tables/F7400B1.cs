using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7400B1 - .
/// </summary>
public class F7400B1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QAAN8.
        /// </summary>
        public const string QAAN8 = "QAAN8";

        /// <summary>
        /// QATAX.
        /// </summary>
        public const string QATAX = "QATAX";
    }

    /// <inheritdoc />
    public override string TableName => "F7400B1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QAAN8", "QAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("QATAX", "QATAX", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7400B1_0", "Primary Key on QAAN8", new[] { "QAAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7400B1_2", "Index on QATAX", new[] { "QATAX" })
    };
}
