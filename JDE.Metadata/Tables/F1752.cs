using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1752 - .
/// </summary>
public class F1752 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTCALLQ.
        /// </summary>
        public const string CTCALLQ = "CTCALLQ";

        /// <summary>
        /// CTCT01.
        /// </summary>
        public const string CTCT01 = "CTCT01";

        /// <summary>
        /// CTCT02.
        /// </summary>
        public const string CTCT02 = "CTCT02";

        /// <summary>
        /// CTLNTY.
        /// </summary>
        public const string CTLNTY = "CTLNTY";

        /// <summary>
        /// CTRSTM.
        /// </summary>
        public const string CTRSTM = "CTRSTM";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";
    }

    /// <inheritdoc />
    public override string TableName => "F1752";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTCALLQ", "CTCALLQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CTCT01", "CTCT01", JdeDataType.String, 2, true, true),
        new JdeField("CTCT02", "CTCT02", JdeDataType.String, 2),
        new JdeField("CTLNTY", "CTLNTY", JdeDataType.String, 4),
        new JdeField("CTRSTM", "CTRSTM", JdeDataType.Numeric),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1752_0", "Primary Key on CTCALLQ, CTCT01", new[] { "CTCALLQ", "CTCT01" }, isUnique: true, isPrimaryKey: true)
    };
}
