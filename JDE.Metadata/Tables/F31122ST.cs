using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31122ST - .
/// </summary>
public class F31122ST : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WTUKID.
        /// </summary>
        public const string WTUKID = "WTUKID";

        /// <summary>
        /// WTSTH.
        /// </summary>
        public const string WTSTH = "WTSTH";

        /// <summary>
        /// WTLINE.
        /// </summary>
        public const string WTLINE = "WTLINE";

        /// <summary>
        /// WTRCD.
        /// </summary>
        public const string WTRCD = "WTRCD";
    }

    /// <inheritdoc />
    public override string TableName => "F31122ST";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WTUKID", "WTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WTSTH", "WTSTH", JdeDataType.Numeric),
        new JdeField("WTLINE", "WTLINE", JdeDataType.String, 24),
        new JdeField("WTRCD", "WTRCD", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31122ST_0", "Primary Key on WTUKID", new[] { "WTUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
