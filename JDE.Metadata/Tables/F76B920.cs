using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B920 - .
/// </summary>
public class F76B920 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RCB76ACIR.
        /// </summary>
        public const string RCB76ACIR = "RCB76ACIR";

        /// <summary>
        /// RCB76REFA.
        /// </summary>
        public const string RCB76REFA = "RCB76REFA";

        /// <summary>
        /// RCB76READ.
        /// </summary>
        public const string RCB76READ = "RCB76READ";

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
        /// RCUPMT.
        /// </summary>
        public const string RCUPMT = "RCUPMT";

        /// <summary>
        /// RCUPMJ.
        /// </summary>
        public const string RCUPMJ = "RCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76B920";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RCB76ACIR", "RCB76ACIR", JdeDataType.String, 4, true, true),
        new JdeField("RCB76REFA", "RCB76REFA", JdeDataType.String, 60, true, true),
        new JdeField("RCB76READ", "RCB76READ", JdeDataType.String, 160),
        new JdeField("RCUSER", "RCUSER", JdeDataType.String, 20),
        new JdeField("RCPID", "RCPID", JdeDataType.String, 20),
        new JdeField("RCJOBN", "RCJOBN", JdeDataType.String, 20),
        new JdeField("RCUPMT", "RCUPMT", JdeDataType.Numeric),
        new JdeField("RCUPMJ", "RCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B920_0", "Primary Key on RCB76ACIR, RCB76REFA", new[] { "RCB76ACIR", "RCB76REFA" }, isUnique: true, isPrimaryKey: true)
    };
}
