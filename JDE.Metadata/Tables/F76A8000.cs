using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8000 - .
/// </summary>
public class F76A8000 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFASMV.
        /// </summary>
        public const string TFASMV = "TFASMV";

        /// <summary>
        /// TFDOC.
        /// </summary>
        public const string TFDOC = "TFDOC";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8000";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFASMV", "TFASMV", JdeDataType.String, 440),
        new JdeField("TFDOC", "TFDOC", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8000_0", "Primary Key on TFDOC", new[] { "TFDOC" }, isUnique: true, isPrimaryKey: true)
    };
}
