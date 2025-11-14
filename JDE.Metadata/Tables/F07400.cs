using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07400 - .
/// </summary>
public class F07400 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NHJNHR.
        /// </summary>
        public const string NHJNHR = "NHJNHR";

        /// <summary>
        /// NHVERS.
        /// </summary>
        public const string NHVERS = "NHVERS";

        /// <summary>
        /// NHUKID.
        /// </summary>
        public const string NHUKID = "NHUKID";

        /// <summary>
        /// NHUPMJ.
        /// </summary>
        public const string NHUPMJ = "NHUPMJ";

        /// <summary>
        /// NHUPMT.
        /// </summary>
        public const string NHUPMT = "NHUPMT";

        /// <summary>
        /// NHPID.
        /// </summary>
        public const string NHPID = "NHPID";

        /// <summary>
        /// NHJOBN.
        /// </summary>
        public const string NHJOBN = "NHJOBN";

        /// <summary>
        /// NHUSER.
        /// </summary>
        public const string NHUSER = "NHUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07400";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NHJNHR", "NHJNHR", JdeDataType.String, 2264),
        new JdeField("NHVERS", "NHVERS", JdeDataType.String, 20),
        new JdeField("NHUKID", "NHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("NHUPMJ", "NHUPMJ", JdeDataType.Numeric),
        new JdeField("NHUPMT", "NHUPMT", JdeDataType.Numeric),
        new JdeField("NHPID", "NHPID", JdeDataType.String, 20),
        new JdeField("NHJOBN", "NHJOBN", JdeDataType.String, 20),
        new JdeField("NHUSER", "NHUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07400_0", "Primary Key on NHUKID", new[] { "NHUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
