using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48315 - .
/// </summary>
public class F48315 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSDTSPN.
        /// </summary>
        public const string WSDTSPN = "WSDTSPN";

        /// <summary>
        /// WSDTFR.
        /// </summary>
        public const string WSDTFR = "WSDTFR";

        /// <summary>
        /// WSANSA.
        /// </summary>
        public const string WSANSA = "WSANSA";

        /// <summary>
        /// WSMCULT.
        /// </summary>
        public const string WSMCULT = "WSMCULT";

        /// <summary>
        /// WSANPA.
        /// </summary>
        public const string WSANPA = "WSANPA";

        /// <summary>
        /// WSDTTO.
        /// </summary>
        public const string WSDTTO = "WSDTTO";

        /// <summary>
        /// WSHRSACT.
        /// </summary>
        public const string WSHRSACT = "WSHRSACT";

        /// <summary>
        /// WSHRSAVL.
        /// </summary>
        public const string WSHRSAVL = "WSHRSAVL";

        /// <summary>
        /// WSHRSCMP.
        /// </summary>
        public const string WSHRSCMP = "WSHRSCMP";

        /// <summary>
        /// WSHRSNRM.
        /// </summary>
        public const string WSHRSNRM = "WSHRSNRM";

        /// <summary>
        /// WSHRSSCH.
        /// </summary>
        public const string WSHRSSCH = "WSHRSSCH";

        /// <summary>
        /// WSHRSSCHC.
        /// </summary>
        public const string WSHRSSCHC = "WSHRSSCHC";

        /// <summary>
        /// WSLDPC.
        /// </summary>
        public const string WSLDPC = "WSLDPC";

        /// <summary>
        /// WSURCD.
        /// </summary>
        public const string WSURCD = "WSURCD";

        /// <summary>
        /// WSURDT.
        /// </summary>
        public const string WSURDT = "WSURDT";

        /// <summary>
        /// WSURRF.
        /// </summary>
        public const string WSURRF = "WSURRF";

        /// <summary>
        /// WSURAB.
        /// </summary>
        public const string WSURAB = "WSURAB";

        /// <summary>
        /// WSURAT.
        /// </summary>
        public const string WSURAT = "WSURAT";

        /// <summary>
        /// WSUSER.
        /// </summary>
        public const string WSUSER = "WSUSER";

        /// <summary>
        /// WSMKEY.
        /// </summary>
        public const string WSMKEY = "WSMKEY";

        /// <summary>
        /// WSPID.
        /// </summary>
        public const string WSPID = "WSPID";

        /// <summary>
        /// WSUPMJ.
        /// </summary>
        public const string WSUPMJ = "WSUPMJ";

        /// <summary>
        /// WSUPMT.
        /// </summary>
        public const string WSUPMT = "WSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48315";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSDTSPN", "WSDTSPN", JdeDataType.String, 2, true, true),
        new JdeField("WSDTFR", "WSDTFR", JdeDataType.Numeric, null, true, true),
        new JdeField("WSANSA", "WSANSA", JdeDataType.Numeric, null, true, true),
        new JdeField("WSMCULT", "WSMCULT", JdeDataType.String, 24, true, true),
        new JdeField("WSANPA", "WSANPA", JdeDataType.Numeric),
        new JdeField("WSDTTO", "WSDTTO", JdeDataType.Numeric),
        new JdeField("WSHRSACT", "WSHRSACT", JdeDataType.Numeric),
        new JdeField("WSHRSAVL", "WSHRSAVL", JdeDataType.Numeric),
        new JdeField("WSHRSCMP", "WSHRSCMP", JdeDataType.Numeric),
        new JdeField("WSHRSNRM", "WSHRSNRM", JdeDataType.Numeric),
        new JdeField("WSHRSSCH", "WSHRSSCH", JdeDataType.Numeric),
        new JdeField("WSHRSSCHC", "WSHRSSCHC", JdeDataType.Numeric),
        new JdeField("WSLDPC", "WSLDPC", JdeDataType.Numeric),
        new JdeField("WSURCD", "WSURCD", JdeDataType.String, 4),
        new JdeField("WSURDT", "WSURDT", JdeDataType.Numeric),
        new JdeField("WSURRF", "WSURRF", JdeDataType.String, 30),
        new JdeField("WSURAB", "WSURAB", JdeDataType.Numeric),
        new JdeField("WSURAT", "WSURAT", JdeDataType.Numeric),
        new JdeField("WSUSER", "WSUSER", JdeDataType.String, 20),
        new JdeField("WSMKEY", "WSMKEY", JdeDataType.String, 30),
        new JdeField("WSPID", "WSPID", JdeDataType.String, 20),
        new JdeField("WSUPMJ", "WSUPMJ", JdeDataType.Numeric),
        new JdeField("WSUPMT", "WSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48315_0", "Primary Key on WSDTSPN, WSANSA, WSDTFR, WSMCULT", new[] { "WSDTSPN", "WSANSA", "WSDTFR", "WSMCULT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48315_2", "Index on WSDTSPN, WSANSA, SYS_NC00024$", new[] { "WSDTSPN", "WSANSA", "SYS_NC00024$" }),
        new JdeIndex("F48315_3", "Index on WSDTSPN, WSDTFR", new[] { "WSDTSPN", "WSDTFR" })
    };
}
