using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46821WF - .
/// </summary>
public class F46821WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFUKID.
        /// </summary>
        public const string WFUKID = "WFUKID";

        /// <summary>
        /// WFMCU.
        /// </summary>
        public const string WFMCU = "WFMCU";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFTDAY.
        /// </summary>
        public const string WFTDAY = "WFTDAY";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFJOBN.
        /// </summary>
        public const string WFJOBN = "WFJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F46821WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFUKID", "WFUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24, true, true),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFTDAY", "WFTDAY", JdeDataType.Numeric),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46821WF_0", "Primary Key on WFUKID, WFMCU", new[] { "WFUKID", "WFMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
