using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05112 - .
/// </summary>
public class F05112 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STRRTY.
        /// </summary>
        public const string STRRTY = "STRRTY";

        /// <summary>
        /// STAN8.
        /// </summary>
        public const string STAN8 = "STAN8";

        /// <summary>
        /// STCMPC.
        /// </summary>
        public const string STCMPC = "STCMPC";

        /// <summary>
        /// STSEQ.
        /// </summary>
        public const string STSEQ = "STSEQ";

        /// <summary>
        /// STDL01.
        /// </summary>
        public const string STDL01 = "STDL01";

        /// <summary>
        /// STDACQ.
        /// </summary>
        public const string STDACQ = "STDACQ";

        /// <summary>
        /// STVRBY.
        /// </summary>
        public const string STVRBY = "STVRBY";

        /// <summary>
        /// STSTA.
        /// </summary>
        public const string STSTA = "STSTA";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F05112";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STRRTY", "STRRTY", JdeDataType.String, 4, true, true),
        new JdeField("STAN8", "STAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("STCMPC", "STCMPC", JdeDataType.String, 20, true, true),
        new JdeField("STSEQ", "STSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("STDL01", "STDL01", JdeDataType.String, 60),
        new JdeField("STDACQ", "STDACQ", JdeDataType.Numeric),
        new JdeField("STVRBY", "STVRBY", JdeDataType.String, 16),
        new JdeField("STSTA", "STSTA", JdeDataType.String, 2),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05112_0", "Primary Key on STRRTY, STAN8, STCMPC, STSEQ", new[] { "STRRTY", "STAN8", "STCMPC", "STSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
