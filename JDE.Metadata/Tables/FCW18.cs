using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW18 - .
/// </summary>
public class FCW18 : JdeTable
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
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFITMM.
        /// </summary>
        public const string WFITMM = "WFITMM";

        /// <summary>
        /// WFTYPI.
        /// </summary>
        public const string WFTYPI = "WFTYPI";
    }

    /// <inheritdoc />
    public override string TableName => "FCW18";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2, true, true),
        new JdeField("WFITMM", "WFITMM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFTYPI", "WFTYPI", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW18_0", "Primary Key on WFITM, WFEV01, WFITMM, WFTYPI", new[] { "WFITM", "WFEV01", "WFITMM", "WFTYPI" }, isUnique: true, isPrimaryKey: true)
    };
}
