using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08772A - .
/// </summary>
public class F08772A : JdeTable
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
        /// XHMSEB.
        /// </summary>
        public const string XHMSEB = "XHMSEB";

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
    public override string TableName => "F08772A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XHORMCU", "XHORMCU", JdeDataType.String, 24, true, true),
        new JdeField("XHMSEB", "XHMSEB", JdeDataType.String, 2),
        new JdeField("XHUSER", "XHUSER", JdeDataType.String, 20),
        new JdeField("XHPID", "XHPID", JdeDataType.String, 20),
        new JdeField("XHJOBN", "XHJOBN", JdeDataType.String, 20),
        new JdeField("XHUPMJ", "XHUPMJ", JdeDataType.Numeric),
        new JdeField("XHUPMT", "XHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08772A_0", "Primary Key on XHORMCU", new[] { "XHORMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
