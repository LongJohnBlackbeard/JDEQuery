using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I866 - .
/// </summary>
public class F75I866 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTDOCO.
        /// </summary>
        public const string RTDOCO = "RTDOCO";

        /// <summary>
        /// RTDCTO.
        /// </summary>
        public const string RTDCTO = "RTDCTO";

        /// <summary>
        /// RTKCOO.
        /// </summary>
        public const string RTKCOO = "RTKCOO";

        /// <summary>
        /// RTLNID.
        /// </summary>
        public const string RTLNID = "RTLNID";

        /// <summary>
        /// RTUITM.
        /// </summary>
        public const string RTUITM = "RTUITM";

        /// <summary>
        /// RTI75CATTY.
        /// </summary>
        public const string RTI75CATTY = "RTI75CATTY";

        /// <summary>
        /// RTI75CATVL.
        /// </summary>
        public const string RTI75CATVL = "RTI75CATVL";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";

        /// <summary>
        /// RTYFUTDT1.
        /// </summary>
        public const string RTYFUTDT1 = "RTYFUTDT1";

        /// <summary>
        /// RTFUT6.
        /// </summary>
        public const string RTFUT6 = "RTFUT6";

        /// <summary>
        /// RTYT04.
        /// </summary>
        public const string RTYT04 = "RTYT04";

        /// <summary>
        /// RTYFLAG.
        /// </summary>
        public const string RTYFLAG = "RTYFLAG";

        /// <summary>
        /// RTYNUM1.
        /// </summary>
        public const string RTYNUM1 = "RTYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I866";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTDOCO", "RTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RTDCTO", "RTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RTKCOO", "RTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RTLNID", "RTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RTUITM", "RTUITM", JdeDataType.String, 52),
        new JdeField("RTI75CATTY", "RTI75CATTY", JdeDataType.String, 6),
        new JdeField("RTI75CATVL", "RTI75CATVL", JdeDataType.String, 40),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric),
        new JdeField("RTYFUTDT1", "RTYFUTDT1", JdeDataType.Numeric),
        new JdeField("RTFUT6", "RTFUT6", JdeDataType.String, 60),
        new JdeField("RTYT04", "RTYT04", JdeDataType.String, 2),
        new JdeField("RTYFLAG", "RTYFLAG", JdeDataType.String, 2),
        new JdeField("RTYNUM1", "RTYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I866_0", "Primary Key on RTDOCO, RTDCTO, RTKCOO, RTLNID", new[] { "RTDOCO", "RTDCTO", "RTKCOO", "RTLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
