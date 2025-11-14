using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A401 - .
/// </summary>
public class F76A401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UTA76UTET.
        /// </summary>
        public const string UTA76UTET = "UTA76UTET";

        /// <summary>
        /// UTAN8.
        /// </summary>
        public const string UTAN8 = "UTAN8";

        /// <summary>
        /// UTAN8J.
        /// </summary>
        public const string UTAN8J = "UTAN8J";

        /// <summary>
        /// UTAMPE.
        /// </summary>
        public const string UTAMPE = "UTAMPE";

        /// <summary>
        /// UTUSER.
        /// </summary>
        public const string UTUSER = "UTUSER";

        /// <summary>
        /// UTPID.
        /// </summary>
        public const string UTPID = "UTPID";

        /// <summary>
        /// UTJOBN.
        /// </summary>
        public const string UTJOBN = "UTJOBN";

        /// <summary>
        /// UTUPMT.
        /// </summary>
        public const string UTUPMT = "UTUPMT";

        /// <summary>
        /// UTUPMJ.
        /// </summary>
        public const string UTUPMJ = "UTUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F76A401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UTA76UTET", "UTA76UTET", JdeDataType.String, 2, true, true),
        new JdeField("UTAN8", "UTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("UTAN8J", "UTAN8J", JdeDataType.Numeric, null, true, true),
        new JdeField("UTAMPE", "UTAMPE", JdeDataType.Numeric),
        new JdeField("UTUSER", "UTUSER", JdeDataType.String, 20),
        new JdeField("UTPID", "UTPID", JdeDataType.String, 20),
        new JdeField("UTJOBN", "UTJOBN", JdeDataType.String, 20),
        new JdeField("UTUPMT", "UTUPMT", JdeDataType.Numeric),
        new JdeField("UTUPMJ", "UTUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A401_0", "Primary Key on UTA76UTET, UTAN8, UTAN8J", new[] { "UTA76UTET", "UTAN8", "UTAN8J" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A401_2", "Index on UTA76UTET, UTAN8J", new[] { "UTA76UTET", "UTAN8J" })
    };
}
