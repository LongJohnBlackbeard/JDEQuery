using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI85 - .
/// </summary>
public class F75IUI85 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APJOBS.
        /// </summary>
        public const string APJOBS = "APJOBS";

        /// <summary>
        /// APPYID.
        /// </summary>
        public const string APPYID = "APPYID";

        /// <summary>
        /// APRC5.
        /// </summary>
        public const string APRC5 = "APRC5";

        /// <summary>
        /// APITM.
        /// </summary>
        public const string APITM = "APITM";

        /// <summary>
        /// APCO.
        /// </summary>
        public const string APCO = "APCO";

        /// <summary>
        /// APAN8.
        /// </summary>
        public const string APAN8 = "APAN8";

        /// <summary>
        /// APCKNU.
        /// </summary>
        public const string APCKNU = "APCKNU";

        /// <summary>
        /// APLITM.
        /// </summary>
        public const string APLITM = "APLITM";

        /// <summary>
        /// API75CATTY.
        /// </summary>
        public const string API75CATTY = "API75CATTY";

        /// <summary>
        /// API75CATVL.
        /// </summary>
        public const string API75CATVL = "API75CATVL";

        /// <summary>
        /// APAG.
        /// </summary>
        public const string APAG = "APAG";

        /// <summary>
        /// APATXA.
        /// </summary>
        public const string APATXA = "APATXA";

        /// <summary>
        /// APSTAM.
        /// </summary>
        public const string APSTAM = "APSTAM";

        /// <summary>
        /// API75IGSTA.
        /// </summary>
        public const string API75IGSTA = "API75IGSTA";

        /// <summary>
        /// API75IGSTO.
        /// </summary>
        public const string API75IGSTO = "API75IGSTO";

        /// <summary>
        /// API75CGSTA.
        /// </summary>
        public const string API75CGSTA = "API75CGSTA";

        /// <summary>
        /// API75CGSTO.
        /// </summary>
        public const string API75CGSTO = "API75CGSTO";

        /// <summary>
        /// API75SGSTA.
        /// </summary>
        public const string API75SGSTA = "API75SGSTA";

        /// <summary>
        /// API75SGSTO.
        /// </summary>
        public const string API75SGSTO = "API75SGSTO";

        /// <summary>
        /// APYFUTDT1.
        /// </summary>
        public const string APYFUTDT1 = "APYFUTDT1";

        /// <summary>
        /// APFUT6.
        /// </summary>
        public const string APFUT6 = "APFUT6";

        /// <summary>
        /// APYT04.
        /// </summary>
        public const string APYT04 = "APYT04";

        /// <summary>
        /// APYFLAG.
        /// </summary>
        public const string APYFLAG = "APYFLAG";

        /// <summary>
        /// APYNUM1.
        /// </summary>
        public const string APYNUM1 = "APYNUM1";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";

        /// <summary>
        /// API75CESSA.
        /// </summary>
        public const string API75CESSA = "API75CESSA";

        /// <summary>
        /// API75CESSO.
        /// </summary>
        public const string API75CESSO = "API75CESSO";

        /// <summary>
        /// API75ATX1A.
        /// </summary>
        public const string API75ATX1A = "API75ATX1A";

        /// <summary>
        /// API75ATX1O.
        /// </summary>
        public const string API75ATX1O = "API75ATX1O";

        /// <summary>
        /// API75ATX2A.
        /// </summary>
        public const string API75ATX2A = "API75ATX2A";

        /// <summary>
        /// API75ATX2O.
        /// </summary>
        public const string API75ATX2O = "API75ATX2O";

        /// <summary>
        /// API75ATX3A.
        /// </summary>
        public const string API75ATX3A = "API75ATX3A";

        /// <summary>
        /// API75ATX3O.
        /// </summary>
        public const string API75ATX3O = "API75ATX3O";

        /// <summary>
        /// API75AT4A.
        /// </summary>
        public const string API75AT4A = "API75AT4A";

        /// <summary>
        /// API75AT4O.
        /// </summary>
        public const string API75AT4O = "API75AT4O";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI85";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APJOBS", "APJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("APPYID", "APPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("APRC5", "APRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("APITM", "APITM", JdeDataType.Numeric, null, true, true),
        new JdeField("APCO", "APCO", JdeDataType.String, 10),
        new JdeField("APAN8", "APAN8", JdeDataType.Numeric),
        new JdeField("APCKNU", "APCKNU", JdeDataType.String, 50),
        new JdeField("APLITM", "APLITM", JdeDataType.String, 50),
        new JdeField("API75CATTY", "API75CATTY", JdeDataType.String, 6),
        new JdeField("API75CATVL", "API75CATVL", JdeDataType.String, 40),
        new JdeField("APAG", "APAG", JdeDataType.Numeric),
        new JdeField("APATXA", "APATXA", JdeDataType.Numeric),
        new JdeField("APSTAM", "APSTAM", JdeDataType.Numeric),
        new JdeField("API75IGSTA", "API75IGSTA", JdeDataType.Numeric),
        new JdeField("API75IGSTO", "API75IGSTO", JdeDataType.Numeric),
        new JdeField("API75CGSTA", "API75CGSTA", JdeDataType.Numeric),
        new JdeField("API75CGSTO", "API75CGSTO", JdeDataType.Numeric),
        new JdeField("API75SGSTA", "API75SGSTA", JdeDataType.Numeric),
        new JdeField("API75SGSTO", "API75SGSTO", JdeDataType.Numeric),
        new JdeField("APYFUTDT1", "APYFUTDT1", JdeDataType.Numeric),
        new JdeField("APFUT6", "APFUT6", JdeDataType.String, 60),
        new JdeField("APYT04", "APYT04", JdeDataType.String, 2),
        new JdeField("APYFLAG", "APYFLAG", JdeDataType.String, 2),
        new JdeField("APYNUM1", "APYNUM1", JdeDataType.Numeric),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20, true, true),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric),
        new JdeField("API75CESSA", "API75CESSA", JdeDataType.Numeric),
        new JdeField("API75CESSO", "API75CESSO", JdeDataType.Numeric),
        new JdeField("API75ATX1A", "API75ATX1A", JdeDataType.Numeric),
        new JdeField("API75ATX1O", "API75ATX1O", JdeDataType.Numeric),
        new JdeField("API75ATX2A", "API75ATX2A", JdeDataType.Numeric),
        new JdeField("API75ATX2O", "API75ATX2O", JdeDataType.Numeric),
        new JdeField("API75ATX3A", "API75ATX3A", JdeDataType.Numeric),
        new JdeField("API75ATX3O", "API75ATX3O", JdeDataType.Numeric),
        new JdeField("API75AT4A", "API75AT4A", JdeDataType.Numeric),
        new JdeField("API75AT4O", "API75AT4O", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI85_0", "Primary Key on APPYID, APRC5, APITM, APJOBS, APUSER", new[] { "APPYID", "APRC5", "APITM", "APJOBS", "APUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
