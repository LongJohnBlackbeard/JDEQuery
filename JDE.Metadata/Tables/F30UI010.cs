using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI010 - .
/// </summary>
public class F30UI010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFITM.
        /// </summary>
        public const string WFITM = "WFITM";

        /// <summary>
        /// WFKIT.
        /// </summary>
        public const string WFKIT = "WFKIT";

        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFKIT", "WFKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI010_0", "Primary Key on WFKIT, WFITM", new[] { "WFKIT", "WFITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30UI010_2", "Index on WFITM, WFKIT", new[] { "WFITM", "WFKIT" })
    };
}
