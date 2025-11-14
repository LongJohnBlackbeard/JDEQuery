using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0451401 - .
/// </summary>
public class F0451401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A1TAX.
        /// </summary>
        public const string A1TAX = "A1TAX";

        /// <summary>
        /// A1FFI.
        /// </summary>
        public const string A1FFI = "A1FFI";

        /// <summary>
        /// A1MN0401.
        /// </summary>
        public const string A1MN0401 = "A1MN0401";

        /// <summary>
        /// A1CH0401.
        /// </summary>
        public const string A1CH0401 = "A1CH0401";

        /// <summary>
        /// A1SZ0401.
        /// </summary>
        public const string A1SZ0401 = "A1SZ0401";

        /// <summary>
        /// A1D0401.
        /// </summary>
        public const string A1D0401 = "A1D0401";
    }

    /// <inheritdoc />
    public override string TableName => "F0451401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A1TAX", "A1TAX", JdeDataType.String, 40, true, true),
        new JdeField("A1FFI", "A1FFI", JdeDataType.String, 2),
        new JdeField("A1MN0401", "A1MN0401", JdeDataType.Numeric),
        new JdeField("A1CH0401", "A1CH0401", JdeDataType.String, 2),
        new JdeField("A1SZ0401", "A1SZ0401", JdeDataType.String, 60),
        new JdeField("A1D0401", "A1D0401", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0451401_0", "Primary Key on A1TAX", new[] { "A1TAX" }, isUnique: true, isPrimaryKey: true)
    };
}
