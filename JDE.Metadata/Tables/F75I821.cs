using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I821 - .
/// </summary>
public class F75I821 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OTUKID.
        /// </summary>
        public const string OTUKID = "OTUKID";

        /// <summary>
        /// OTYLYR.
        /// </summary>
        public const string OTYLYR = "OTYLYR";

        /// <summary>
        /// OTYMNTH.
        /// </summary>
        public const string OTYMNTH = "OTYMNTH";

        /// <summary>
        /// OTI75GSTU.
        /// </summary>
        public const string OTI75GSTU = "OTI75GSTU";

        /// <summary>
        /// OTI75JNUM.
        /// </summary>
        public const string OTI75JNUM = "OTI75JNUM";

        /// <summary>
        /// OTLNID.
        /// </summary>
        public const string OTLNID = "OTLNID";

        /// <summary>
        /// OTI75GSTNP.
        /// </summary>
        public const string OTI75GSTNP = "OTI75GSTNP";

        /// <summary>
        /// OTI75GSTNO.
        /// </summary>
        public const string OTI75GSTNO = "OTI75GSTNO";

        /// <summary>
        /// OTI75INVNO.
        /// </summary>
        public const string OTI75INVNO = "OTI75INVNO";

        /// <summary>
        /// OTYINVDT.
        /// </summary>
        public const string OTYINVDT = "OTYINVDT";

        /// <summary>
        /// OTI75CATTY.
        /// </summary>
        public const string OTI75CATTY = "OTI75CATTY";

        /// <summary>
        /// OTI75CATVL.
        /// </summary>
        public const string OTI75CATVL = "OTI75CATVL";

        /// <summary>
        /// OTAG.
        /// </summary>
        public const string OTAG = "OTAG";

        /// <summary>
        /// OTI75IGSTR.
        /// </summary>
        public const string OTI75IGSTR = "OTI75IGSTR";

        /// <summary>
        /// OTI75IGSTA.
        /// </summary>
        public const string OTI75IGSTA = "OTI75IGSTA";

        /// <summary>
        /// OTI75CGSTR.
        /// </summary>
        public const string OTI75CGSTR = "OTI75CGSTR";

        /// <summary>
        /// OTI75CGSTA.
        /// </summary>
        public const string OTI75CGSTA = "OTI75CGSTA";

        /// <summary>
        /// OTI75SGSTR.
        /// </summary>
        public const string OTI75SGSTR = "OTI75SGSTR";

        /// <summary>
        /// OTI75SGSTA.
        /// </summary>
        public const string OTI75SGSTA = "OTI75SGSTA";

        /// <summary>
        /// OTI75FRC.
        /// </summary>
        public const string OTI75FRC = "OTI75FRC";

        /// <summary>
        /// OTATXA.
        /// </summary>
        public const string OTATXA = "OTATXA";

        /// <summary>
        /// OTUSER.
        /// </summary>
        public const string OTUSER = "OTUSER";

        /// <summary>
        /// OTPID.
        /// </summary>
        public const string OTPID = "OTPID";

        /// <summary>
        /// OTJOBN.
        /// </summary>
        public const string OTJOBN = "OTJOBN";

        /// <summary>
        /// OTUPMJ.
        /// </summary>
        public const string OTUPMJ = "OTUPMJ";

        /// <summary>
        /// OTUPMT.
        /// </summary>
        public const string OTUPMT = "OTUPMT";

        /// <summary>
        /// OTYFUTDT1.
        /// </summary>
        public const string OTYFUTDT1 = "OTYFUTDT1";

        /// <summary>
        /// OTFUT6.
        /// </summary>
        public const string OTFUT6 = "OTFUT6";

        /// <summary>
        /// OTYT04.
        /// </summary>
        public const string OTYT04 = "OTYT04";

        /// <summary>
        /// OTYFLAG.
        /// </summary>
        public const string OTYFLAG = "OTYFLAG";

        /// <summary>
        /// OTYNUM1.
        /// </summary>
        public const string OTYNUM1 = "OTYNUM1";

        /// <summary>
        /// OTI75CESSR.
        /// </summary>
        public const string OTI75CESSR = "OTI75CESSR";

        /// <summary>
        /// OTI75CESSA.
        /// </summary>
        public const string OTI75CESSA = "OTI75CESSA";

        /// <summary>
        /// OTI75ATX1R.
        /// </summary>
        public const string OTI75ATX1R = "OTI75ATX1R";

        /// <summary>
        /// OTI75ATX1A.
        /// </summary>
        public const string OTI75ATX1A = "OTI75ATX1A";

        /// <summary>
        /// OTI75ATX2R.
        /// </summary>
        public const string OTI75ATX2R = "OTI75ATX2R";

        /// <summary>
        /// OTI75ATX2A.
        /// </summary>
        public const string OTI75ATX2A = "OTI75ATX2A";

        /// <summary>
        /// OTI75ATX3R.
        /// </summary>
        public const string OTI75ATX3R = "OTI75ATX3R";

        /// <summary>
        /// OTI75ATX3A.
        /// </summary>
        public const string OTI75ATX3A = "OTI75ATX3A";

        /// <summary>
        /// OTI75AT4R.
        /// </summary>
        public const string OTI75AT4R = "OTI75AT4R";

        /// <summary>
        /// OTI75AT4A.
        /// </summary>
        public const string OTI75AT4A = "OTI75AT4A";
    }

    /// <inheritdoc />
    public override string TableName => "F75I821";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OTUKID", "OTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("OTYLYR", "OTYLYR", JdeDataType.Numeric, null, true, true),
        new JdeField("OTYMNTH", "OTYMNTH", JdeDataType.String, 4, true, true),
        new JdeField("OTI75GSTU", "OTI75GSTU", JdeDataType.Numeric, null, true, true),
        new JdeField("OTI75JNUM", "OTI75JNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("OTLNID", "OTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("OTI75GSTNP", "OTI75GSTNP", JdeDataType.String, 50),
        new JdeField("OTI75GSTNO", "OTI75GSTNO", JdeDataType.String, 50),
        new JdeField("OTI75INVNO", "OTI75INVNO", JdeDataType.String, 50),
        new JdeField("OTYINVDT", "OTYINVDT", JdeDataType.Numeric),
        new JdeField("OTI75CATTY", "OTI75CATTY", JdeDataType.String, 6),
        new JdeField("OTI75CATVL", "OTI75CATVL", JdeDataType.String, 40),
        new JdeField("OTAG", "OTAG", JdeDataType.Numeric),
        new JdeField("OTI75IGSTR", "OTI75IGSTR", JdeDataType.Numeric),
        new JdeField("OTI75IGSTA", "OTI75IGSTA", JdeDataType.Numeric),
        new JdeField("OTI75CGSTR", "OTI75CGSTR", JdeDataType.Numeric),
        new JdeField("OTI75CGSTA", "OTI75CGSTA", JdeDataType.Numeric),
        new JdeField("OTI75SGSTR", "OTI75SGSTR", JdeDataType.Numeric),
        new JdeField("OTI75SGSTA", "OTI75SGSTA", JdeDataType.Numeric),
        new JdeField("OTI75FRC", "OTI75FRC", JdeDataType.String, 2),
        new JdeField("OTATXA", "OTATXA", JdeDataType.Numeric),
        new JdeField("OTUSER", "OTUSER", JdeDataType.String, 20),
        new JdeField("OTPID", "OTPID", JdeDataType.String, 20),
        new JdeField("OTJOBN", "OTJOBN", JdeDataType.String, 20),
        new JdeField("OTUPMJ", "OTUPMJ", JdeDataType.Numeric),
        new JdeField("OTUPMT", "OTUPMT", JdeDataType.Numeric),
        new JdeField("OTYFUTDT1", "OTYFUTDT1", JdeDataType.Numeric),
        new JdeField("OTFUT6", "OTFUT6", JdeDataType.String, 60),
        new JdeField("OTYT04", "OTYT04", JdeDataType.String, 2),
        new JdeField("OTYFLAG", "OTYFLAG", JdeDataType.String, 2),
        new JdeField("OTYNUM1", "OTYNUM1", JdeDataType.Numeric),
        new JdeField("OTI75CESSR", "OTI75CESSR", JdeDataType.Numeric),
        new JdeField("OTI75CESSA", "OTI75CESSA", JdeDataType.Numeric),
        new JdeField("OTI75ATX1R", "OTI75ATX1R", JdeDataType.Numeric),
        new JdeField("OTI75ATX1A", "OTI75ATX1A", JdeDataType.Numeric),
        new JdeField("OTI75ATX2R", "OTI75ATX2R", JdeDataType.Numeric),
        new JdeField("OTI75ATX2A", "OTI75ATX2A", JdeDataType.Numeric),
        new JdeField("OTI75ATX3R", "OTI75ATX3R", JdeDataType.Numeric),
        new JdeField("OTI75ATX3A", "OTI75ATX3A", JdeDataType.Numeric),
        new JdeField("OTI75AT4R", "OTI75AT4R", JdeDataType.Numeric),
        new JdeField("OTI75AT4A", "OTI75AT4A", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I821_0", "Primary Key on OTUKID, OTYLYR, OTI75GSTU, OTYMNTH, OTLNID, OTI75JNUM", new[] { "OTUKID", "OTYLYR", "OTI75GSTU", "OTYMNTH", "OTLNID", "OTI75JNUM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I821_2", "Index on OTUKID, OTYLYR, OTYMNTH, OTI75GSTU", new[] { "OTUKID", "OTYLYR", "OTYMNTH", "OTI75GSTU" })
    };
}
