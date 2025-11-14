using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06176 - .
/// </summary>
public class F06176 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YSAN8.
        /// </summary>
        public const string YSAN8 = "YSAN8";

        /// <summary>
        /// YSPCT#.
        /// </summary>
        public const string YSPCT_ = "YSPCT#";

        /// <summary>
        /// YSCKCN.
        /// </summary>
        public const string YSCKCN = "YSCKCN";

        /// <summary>
        /// YSPPED.
        /// </summary>
        public const string YSPPED = "YSPPED";

        /// <summary>
        /// YSQLWK.
        /// </summary>
        public const string YSQLWK = "YSQLWK";

        /// <summary>
        /// YSGPAY.
        /// </summary>
        public const string YSGPAY = "YSGPAY";

        /// <summary>
        /// YSPHRW.
        /// </summary>
        public const string YSPHRW = "YSPHRW";

        /// <summary>
        /// YSIHRW.
        /// </summary>
        public const string YSIHRW = "YSIHRW";

        /// <summary>
        /// YSIPAY.
        /// </summary>
        public const string YSIPAY = "YSIPAY";

        /// <summary>
        /// YSIPRM.
        /// </summary>
        public const string YSIPRM = "YSIPRM";

        /// <summary>
        /// YSTARA.
        /// </summary>
        public const string YSTARA = "YSTARA";

        /// <summary>
        /// YSPTAX.
        /// </summary>
        public const string YSPTAX = "YSPTAX";

        /// <summary>
        /// YSHMCO.
        /// </summary>
        public const string YSHMCO = "YSHMCO";

        /// <summary>
        /// YSPFRQ.
        /// </summary>
        public const string YSPFRQ = "YSPFRQ";

        /// <summary>
        /// YSYST1.
        /// </summary>
        public const string YSYST1 = "YSYST1";

        /// <summary>
        /// YSDTM.
        /// </summary>
        public const string YSDTM = "YSDTM";

        /// <summary>
        /// YSYST2.
        /// </summary>
        public const string YSYST2 = "YSYST2";

        /// <summary>
        /// YSUSER.
        /// </summary>
        public const string YSUSER = "YSUSER";

        /// <summary>
        /// YSPID.
        /// </summary>
        public const string YSPID = "YSPID";

        /// <summary>
        /// YSUPMJ.
        /// </summary>
        public const string YSUPMJ = "YSUPMJ";

        /// <summary>
        /// YSDTSP.
        /// </summary>
        public const string YSDTSP = "YSDTSP";

        /// <summary>
        /// YSCCPR.
        /// </summary>
        public const string YSCCPR = "YSCCPR";

        /// <summary>
        /// YSSSN.
        /// </summary>
        public const string YSSSN = "YSSSN";

        /// <summary>
        /// YSROEN.
        /// </summary>
        public const string YSROEN = "YSROEN";

        /// <summary>
        /// YSTAXX.
        /// </summary>
        public const string YSTAXX = "YSTAXX";

        /// <summary>
        /// YSUIMT.
        /// </summary>
        public const string YSUIMT = "YSUIMT";

        /// <summary>
        /// YSUPIF.
        /// </summary>
        public const string YSUPIF = "YSUPIF";

        /// <summary>
        /// YSCKDT.
        /// </summary>
        public const string YSCKDT = "YSCKDT";
    }

    /// <inheritdoc />
    public override string TableName => "F06176";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YSAN8", "YSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YSPCT#", "YSPCT#", JdeDataType.Numeric),
        new JdeField("YSCKCN", "YSCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("YSPPED", "YSPPED", JdeDataType.Numeric, null, true, true),
        new JdeField("YSQLWK", "YSQLWK", JdeDataType.Numeric),
        new JdeField("YSGPAY", "YSGPAY", JdeDataType.Numeric),
        new JdeField("YSPHRW", "YSPHRW", JdeDataType.Numeric),
        new JdeField("YSIHRW", "YSIHRW", JdeDataType.Numeric),
        new JdeField("YSIPAY", "YSIPAY", JdeDataType.Numeric),
        new JdeField("YSIPRM", "YSIPRM", JdeDataType.Numeric),
        new JdeField("YSTARA", "YSTARA", JdeDataType.String, 20, true, true),
        new JdeField("YSPTAX", "YSPTAX", JdeDataType.String, 4, true, true),
        new JdeField("YSHMCO", "YSHMCO", JdeDataType.String, 10),
        new JdeField("YSPFRQ", "YSPFRQ", JdeDataType.String, 2),
        new JdeField("YSYST1", "YSYST1", JdeDataType.String, 2),
        new JdeField("YSDTM", "YSDTM", JdeDataType.Numeric),
        new JdeField("YSYST2", "YSYST2", JdeDataType.String, 2),
        new JdeField("YSUSER", "YSUSER", JdeDataType.String, 20),
        new JdeField("YSPID", "YSPID", JdeDataType.String, 20),
        new JdeField("YSUPMJ", "YSUPMJ", JdeDataType.Numeric),
        new JdeField("YSDTSP", "YSDTSP", JdeDataType.Numeric),
        new JdeField("YSCCPR", "YSCCPR", JdeDataType.String, 6),
        new JdeField("YSSSN", "YSSSN", JdeDataType.String, 40),
        new JdeField("YSROEN", "YSROEN", JdeDataType.String, 22, true, true),
        new JdeField("YSTAXX", "YSTAXX", JdeDataType.String, 40),
        new JdeField("YSUIMT", "YSUIMT", JdeDataType.String, 2),
        new JdeField("YSUPIF", "YSUPIF", JdeDataType.String, 2),
        new JdeField("YSCKDT", "YSCKDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06176_0", "Primary Key on YSAN8, YSTARA, YSPTAX, YSPPED, YSCKCN, YSROEN", new[] { "YSAN8", "YSTARA", "YSPTAX", "YSPPED", "YSCKCN", "YSROEN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06176_10", "Index on YSAN8, SYS_NC00030$", new[] { "YSAN8", "SYS_NC00030$" }),
        new JdeIndex("F06176_11", "Index on YSAN8, YSCKCN, YSPID", new[] { "YSAN8", "YSCKCN", "YSPID" }),
        new JdeIndex("F06176_12", "Index on YSAN8, YSCKCN, SYS_NC00029$, YSDTM", new[] { "YSAN8", "YSCKCN", "SYS_NC00029$", "YSDTM" }),
        new JdeIndex("F06176_13", "Index on YSAN8, YSROEN, YSPCT#, YSPID", new[] { "YSAN8", "YSROEN", "YSPCT#", "YSPID" }),
        new JdeIndex("F06176_14", "Index on YSAN8, YSPCT#, YSCKCN", new[] { "YSAN8", "YSPCT#", "YSCKCN" }),
        new JdeIndex("F06176_15", "Index on YSAN8, YSROEN", new[] { "YSAN8", "YSROEN" }),
        new JdeIndex("F06176_3", "Index on YSAN8, YSPCT#, SYS_NC00029$", new[] { "YSAN8", "YSPCT#", "SYS_NC00029$" }),
        new JdeIndex("F06176_4", "Index on YSROEN", new[] { "YSROEN" }),
        new JdeIndex("F06176_5", "Index on YSAN8, YSCKCN, SYS_NC00029$", new[] { "YSAN8", "YSCKCN", "SYS_NC00029$" }),
        new JdeIndex("F06176_6", "Index on YSPPED", new[] { "YSPPED" }),
        new JdeIndex("F06176_7", "Index on YSTARA, YSPTAX, YSPPED", new[] { "YSTARA", "YSPTAX", "YSPPED" }),
        new JdeIndex("F06176_8", "Index on YSAN8, YSPPED", new[] { "YSAN8", "YSPPED" }),
        new JdeIndex("F06176_9", "Index on YSAN8, YSCKCN, YSTARA, YSPTAX, SYS_NC00029$, YSROEN", new[] { "YSAN8", "YSCKCN", "YSTARA", "YSPTAX", "SYS_NC00029$", "YSROEN" })
    };
}
