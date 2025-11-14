using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H902W - .
/// </summary>
public class F44H902W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFAID.
        /// </summary>
        public const string WFAID = "WFAID";

        /// <summary>
        /// WFSBL.
        /// </summary>
        public const string WFSBL = "WFSBL";
    }

    /// <inheritdoc />
    public override string TableName => "F44H902W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFAID", "WFAID", JdeDataType.String, 16, true, true),
        new JdeField("WFSBL", "WFSBL", JdeDataType.String, 16, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H902W_0", "Primary Key on WFJOBS, WFAID, WFSBL", new[] { "WFJOBS", "WFAID", "WFSBL" }, isUnique: true, isPrimaryKey: true)
    };
}
