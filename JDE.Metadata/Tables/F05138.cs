using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05138 - .
/// </summary>
public class F05138 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCPAYBN.
        /// </summary>
        public const string PCPAYBN = "PCPAYBN";

        /// <summary>
        /// PCDL01.
        /// </summary>
        public const string PCDL01 = "PCDL01";

        /// <summary>
        /// PCPPED.
        /// </summary>
        public const string PCPPED = "PCPPED";

        /// <summary>
        /// PCEFTB.
        /// </summary>
        public const string PCEFTB = "PCEFTB";

        /// <summary>
        /// PCEFTE.
        /// </summary>
        public const string PCEFTE = "PCEFTE";

        /// <summary>
        /// PCCKDT.
        /// </summary>
        public const string PCCKDT = "PCCKDT";

        /// <summary>
        /// PCPYDT.
        /// </summary>
        public const string PCPYDT = "PCPYDT";

        /// <summary>
        /// PCADPPC.
        /// </summary>
        public const string PCADPPC = "PCADPPC";

        /// <summary>
        /// PCNTRN.
        /// </summary>
        public const string PCNTRN = "PCNTRN";

        /// <summary>
        /// PCOWYSNO.
        /// </summary>
        public const string PCOWYSNO = "PCOWYSNO";

        /// <summary>
        /// PCVER1.
        /// </summary>
        public const string PCVER1 = "PCVER1";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F05138";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCPAYBN", "PCPAYBN", JdeDataType.Numeric, null, true, true),
        new JdeField("PCDL01", "PCDL01", JdeDataType.String, 60),
        new JdeField("PCPPED", "PCPPED", JdeDataType.Numeric),
        new JdeField("PCEFTB", "PCEFTB", JdeDataType.Numeric),
        new JdeField("PCEFTE", "PCEFTE", JdeDataType.Numeric),
        new JdeField("PCCKDT", "PCCKDT", JdeDataType.Numeric),
        new JdeField("PCPYDT", "PCPYDT", JdeDataType.Numeric),
        new JdeField("PCADPPC", "PCADPPC", JdeDataType.String, 2),
        new JdeField("PCNTRN", "PCNTRN", JdeDataType.Numeric),
        new JdeField("PCOWYSNO", "PCOWYSNO", JdeDataType.String, 2),
        new JdeField("PCVER1", "PCVER1", JdeDataType.String, 20),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05138_0", "Primary Key on PCPAYBN", new[] { "PCPAYBN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F05138_2", "Index on SYS_NC00017$, SYS_NC00018$, PCVER1", new[] { "SYS_NC00017$", "SYS_NC00018$", "PCVER1" }),
        new JdeIndex("F05138_3", "Index on SYS_NC00019$, PCVER1, SYS_NC00017$, SYS_NC00018$", new[] { "SYS_NC00019$", "PCVER1", "SYS_NC00017$", "SYS_NC00018$" })
    };
}
