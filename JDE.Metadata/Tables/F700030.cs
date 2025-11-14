using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700030 - .
/// </summary>
public class F700030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IBUKID.
        /// </summary>
        public const string IBUKID = "IBUKID";

        /// <summary>
        /// IBIBAN.
        /// </summary>
        public const string IBIBAN = "IBIBAN";

        /// <summary>
        /// IBCTR.
        /// </summary>
        public const string IBCTR = "IBCTR";

        /// <summary>
        /// IBAN8BK.
        /// </summary>
        public const string IBAN8BK = "IBAN8BK";

        /// <summary>
        /// IBUSER.
        /// </summary>
        public const string IBUSER = "IBUSER";

        /// <summary>
        /// IBPID.
        /// </summary>
        public const string IBPID = "IBPID";

        /// <summary>
        /// IBJOBN.
        /// </summary>
        public const string IBJOBN = "IBJOBN";

        /// <summary>
        /// IBUPMJ.
        /// </summary>
        public const string IBUPMJ = "IBUPMJ";

        /// <summary>
        /// IBUPMT.
        /// </summary>
        public const string IBUPMT = "IBUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F700030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IBUKID", "IBUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IBIBAN", "IBIBAN", JdeDataType.String, 68),
        new JdeField("IBCTR", "IBCTR", JdeDataType.String, 6),
        new JdeField("IBAN8BK", "IBAN8BK", JdeDataType.Numeric),
        new JdeField("IBUSER", "IBUSER", JdeDataType.String, 20),
        new JdeField("IBPID", "IBPID", JdeDataType.String, 20),
        new JdeField("IBJOBN", "IBJOBN", JdeDataType.String, 20),
        new JdeField("IBUPMJ", "IBUPMJ", JdeDataType.Numeric),
        new JdeField("IBUPMT", "IBUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700030_0", "Primary Key on IBUKID", new[] { "IBUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
