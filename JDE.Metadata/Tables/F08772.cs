using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08772 - .
/// </summary>
public class F08772 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XHORMCU.
        /// </summary>
        public const string XHORMCU = "XHORMCU";

        /// <summary>
        /// XHPACM.
        /// </summary>
        public const string XHPACM = "XHPACM";

        /// <summary>
        /// XHSCLES.
        /// </summary>
        public const string XHSCLES = "XHSCLES";

        /// <summary>
        /// XHREQLS.
        /// </summary>
        public const string XHREQLS = "XHREQLS";

        /// <summary>
        /// XHESARQ.
        /// </summary>
        public const string XHESARQ = "XHESARQ";

        /// <summary>
        /// XHPABM.
        /// </summary>
        public const string XHPABM = "XHPABM";

        /// <summary>
        /// XHSCLEE.
        /// </summary>
        public const string XHSCLEE = "XHSCLEE";

        /// <summary>
        /// XHREQLE.
        /// </summary>
        public const string XHREQLE = "XHREQLE";

        /// <summary>
        /// XHUSER.
        /// </summary>
        public const string XHUSER = "XHUSER";

        /// <summary>
        /// XHPID.
        /// </summary>
        public const string XHPID = "XHPID";

        /// <summary>
        /// XHJOBN.
        /// </summary>
        public const string XHJOBN = "XHJOBN";

        /// <summary>
        /// XHUPMJ.
        /// </summary>
        public const string XHUPMJ = "XHUPMJ";

        /// <summary>
        /// XHUPMT.
        /// </summary>
        public const string XHUPMT = "XHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F08772";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XHORMCU", "XHORMCU", JdeDataType.String, 24, true, true),
        new JdeField("XHPACM", "XHPACM", JdeDataType.String, 2),
        new JdeField("XHSCLES", "XHSCLES", JdeDataType.String, 20),
        new JdeField("XHREQLS", "XHREQLS", JdeDataType.Numeric),
        new JdeField("XHESARQ", "XHESARQ", JdeDataType.String, 2),
        new JdeField("XHPABM", "XHPABM", JdeDataType.String, 2),
        new JdeField("XHSCLEE", "XHSCLEE", JdeDataType.String, 20),
        new JdeField("XHREQLE", "XHREQLE", JdeDataType.Numeric),
        new JdeField("XHUSER", "XHUSER", JdeDataType.String, 20),
        new JdeField("XHPID", "XHPID", JdeDataType.String, 20),
        new JdeField("XHJOBN", "XHJOBN", JdeDataType.String, 20),
        new JdeField("XHUPMJ", "XHUPMJ", JdeDataType.Numeric),
        new JdeField("XHUPMT", "XHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08772_0", "Primary Key on XHORMCU", new[] { "XHORMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
