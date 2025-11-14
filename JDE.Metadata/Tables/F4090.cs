using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4090 - .
/// </summary>
public class F4090 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MKANUM.
        /// </summary>
        public const string MKANUM = "MKANUM";

        /// <summary>
        /// MKDL01.
        /// </summary>
        public const string MKDL01 = "MKDL01";

        /// <summary>
        /// MKDL02.
        /// </summary>
        public const string MKDL02 = "MKDL02";

        /// <summary>
        /// MKTEXO.
        /// </summary>
        public const string MKTEXO = "MKTEXO";
    }

    /// <inheritdoc />
    public override string TableName => "F4090";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MKANUM", "MKANUM", JdeDataType.Numeric, null, true, true),
        new JdeField("MKDL01", "MKDL01", JdeDataType.String, 60),
        new JdeField("MKDL02", "MKDL02", JdeDataType.String, 60),
        new JdeField("MKTEXO", "MKTEXO", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4090_0", "Primary Key on MKANUM", new[] { "MKANUM" }, isUnique: true, isPrimaryKey: true)
    };
}
