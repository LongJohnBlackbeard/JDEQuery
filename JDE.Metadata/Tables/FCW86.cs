using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW86 - .
/// </summary>
public class FCW86 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFKIT.
        /// </summary>
        public const string WFKIT = "WFKIT";

        /// <summary>
        /// WFMMCU.
        /// </summary>
        public const string WFMMCU = "WFMMCU";

        /// <summary>
        /// WFTBM.
        /// </summary>
        public const string WFTBM = "WFTBM";

        /// <summary>
        /// WFBQTY.
        /// </summary>
        public const string WFBQTY = "WFBQTY";

        /// <summary>
        /// WFCPNT.
        /// </summary>
        public const string WFCPNT = "WFCPNT";

        /// <summary>
        /// WFSBNT.
        /// </summary>
        public const string WFSBNT = "WFSBNT";

        /// <summary>
        /// WFCOBY.
        /// </summary>
        public const string WFCOBY = "WFCOBY";

        /// <summary>
        /// WFQNTY.
        /// </summary>
        public const string WFQNTY = "WFQNTY";

        /// <summary>
        /// WFCPNB.
        /// </summary>
        public const string WFCPNB = "WFCPNB";
    }

    /// <inheritdoc />
    public override string TableName => "FCW86";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2, true, true),
        new JdeField("WFKIT", "WFKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("WFMMCU", "WFMMCU", JdeDataType.String, 24, true, true),
        new JdeField("WFTBM", "WFTBM", JdeDataType.String, 6, true, true),
        new JdeField("WFBQTY", "WFBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCPNT", "WFCPNT", JdeDataType.Numeric),
        new JdeField("WFSBNT", "WFSBNT", JdeDataType.Numeric, null, true, true),
        new JdeField("WFCOBY", "WFCOBY", JdeDataType.String, 2, true, true),
        new JdeField("WFQNTY", "WFQNTY", JdeDataType.Numeric),
        new JdeField("WFCPNB", "WFCPNB", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW86_0", "Primary Key on WFEV01, WFKIT, WFMMCU, WFTBM, WFBQTY, WFCPNB, WFSBNT, WFCOBY", new[] { "WFEV01", "WFKIT", "WFMMCU", "WFTBM", "WFBQTY", "WFCPNB", "WFSBNT", "WFCOBY" }, isUnique: true, isPrimaryKey: true)
    };
}
