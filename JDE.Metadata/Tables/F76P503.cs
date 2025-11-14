using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P503 - .
/// </summary>
public class F76P503 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCNUMB.
        /// </summary>
        public const string RCNUMB = "RCNUMB";

        /// <summary>
        /// RCEFTE.
        /// </summary>
        public const string RCEFTE = "RCEFTE";

        /// <summary>
        /// RCP76RVLM.
        /// </summary>
        public const string RCP76RVLM = "RCP76RVLM";

        /// <summary>
        /// RCH76FUA.
        /// </summary>
        public const string RCH76FUA = "RCH76FUA";

        /// <summary>
        /// RCH76FUC.
        /// </summary>
        public const string RCH76FUC = "RCH76FUC";

        /// <summary>
        /// RCH76FUD.
        /// </summary>
        public const string RCH76FUD = "RCH76FUD";

        /// <summary>
        /// RCH76FUR.
        /// </summary>
        public const string RCH76FUR = "RCH76FUR";

        /// <summary>
        /// RCH76FUF.
        /// </summary>
        public const string RCH76FUF = "RCH76FUF";

        /// <summary>
        /// RCUSER.
        /// </summary>
        public const string RCUSER = "RCUSER";

        /// <summary>
        /// RCPID.
        /// </summary>
        public const string RCPID = "RCPID";

        /// <summary>
        /// RCJOBN.
        /// </summary>
        public const string RCJOBN = "RCJOBN";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";

        /// <summary>
        /// RCUPMT.
        /// </summary>
        public const string RCUPMT = "RCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76P503";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCNUMB", "RCNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("RCEFTE", "RCEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("RCP76RVLM", "RCP76RVLM", JdeDataType.Numeric),
        new JdeField("RCH76FUA", "RCH76FUA", JdeDataType.Numeric),
        new JdeField("RCH76FUC", "RCH76FUC", JdeDataType.String, 20),
        new JdeField("RCH76FUD", "RCH76FUD", JdeDataType.Numeric),
        new JdeField("RCH76FUR", "RCH76FUR", JdeDataType.String, 30),
        new JdeField("RCH76FUF", "RCH76FUF", JdeDataType.String, 2),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric),
        new JdeField("RCUPMT", "RCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P503_0", "Primary Key on RCNUMB, RCEFTE", new[] { "RCNUMB", "RCEFTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76P503_2", "Index on RCNUMB, SYS_NC00014$", new[] { "RCNUMB", "SYS_NC00014$" })
    };
}
