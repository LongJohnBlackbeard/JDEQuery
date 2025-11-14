using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F99WFITM - .
/// </summary>
public class F99WFITM : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WIITM.
        /// </summary>
        public const string WIITM = "WIITM";

        /// <summary>
        /// WIDESC.
        /// </summary>
        public const string WIDESC = "WIDESC";

        /// <summary>
        /// WIUNCS.
        /// </summary>
        public const string WIUNCS = "WIUNCS";

        /// <summary>
        /// WIUPRC.
        /// </summary>
        public const string WIUPRC = "WIUPRC";
    }

    /// <inheritdoc />
    public override string TableName => "F99WFITM";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WIITM", "WIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WIDESC", "WIDESC", JdeDataType.String, 60),
        new JdeField("WIUNCS", "WIUNCS", JdeDataType.Numeric),
        new JdeField("WIUPRC", "WIUPRC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F99WFITM_0", "Primary Key on WIITM", new[] { "WIITM" }, isUnique: true, isPrimaryKey: true)
    };
}
