using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08320X - .
/// </summary>
public class F08320X : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PXPLAN.
        /// </summary>
        public const string PXPLAN = "PXPLAN";

        /// <summary>
        /// PXDL01.
        /// </summary>
        public const string PXDL01 = "PXDL01";

        /// <summary>
        /// PXEV01.
        /// </summary>
        public const string PXEV01 = "PXEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F08320X";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PXPLAN", "PXPLAN", JdeDataType.String, 16, true, true),
        new JdeField("PXDL01", "PXDL01", JdeDataType.String, 60),
        new JdeField("PXEV01", "PXEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08320X_0", "Primary Key on PXPLAN", new[] { "PXPLAN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08320X_2", "Index on PXDL01", new[] { "PXDL01" })
    };
}
