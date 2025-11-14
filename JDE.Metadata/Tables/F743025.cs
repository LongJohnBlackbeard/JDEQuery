using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F743025 - .
/// </summary>
public class F743025 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D1K74IDFR.
        /// </summary>
        public const string D1K74IDFR = "D1K74IDFR";

        /// <summary>
        /// D1K74DFNR.
        /// </summary>
        public const string D1K74DFNR = "D1K74DFNR";

        /// <summary>
        /// D1K74DMNR.
        /// </summary>
        public const string D1K74DMNR = "D1K74DMNR";

        /// <summary>
        /// D1K74DLNR.
        /// </summary>
        public const string D1K74DLNR = "D1K74DLNR";
    }

    /// <inheritdoc />
    public override string TableName => "F743025";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D1K74IDFR", "D1K74IDFR", JdeDataType.String, 6, true, true),
        new JdeField("D1K74DFNR", "D1K74DFNR", JdeDataType.Numeric),
        new JdeField("D1K74DMNR", "D1K74DMNR", JdeDataType.Numeric),
        new JdeField("D1K74DLNR", "D1K74DLNR", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F743025_0", "Primary Key on D1K74IDFR", new[] { "D1K74IDFR" }, isUnique: true, isPrimaryKey: true)
    };
}
