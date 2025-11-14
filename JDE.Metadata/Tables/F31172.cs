using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31172 - .
/// </summary>
public class F31172 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSDOCO.
        /// </summary>
        public const string WSDOCO = "WSDOCO";

        /// <summary>
        /// WSOPSQ.
        /// </summary>
        public const string WSOPSQ = "WSOPSQ";

        /// <summary>
        /// WSOPSC.
        /// </summary>
        public const string WSOPSC = "WSOPSC";

        /// <summary>
        /// WSMCU.
        /// </summary>
        public const string WSMCU = "WSMCU";

        /// <summary>
        /// WSPAYAB.
        /// </summary>
        public const string WSPAYAB = "WSPAYAB";

        /// <summary>
        /// WSBILL.
        /// </summary>
        public const string WSBILL = "WSBILL";

        /// <summary>
        /// WSACRTB.
        /// </summary>
        public const string WSACRTB = "WSACRTB";

        /// <summary>
        /// WSACRTP.
        /// </summary>
        public const string WSACRTP = "WSACRTP";

        /// <summary>
        /// WSEBILL.
        /// </summary>
        public const string WSEBILL = "WSEBILL";

        /// <summary>
        /// WSAMTA.
        /// </summary>
        public const string WSAMTA = "WSAMTA";

        /// <summary>
        /// WSAMTO.
        /// </summary>
        public const string WSAMTO = "WSAMTO";

        /// <summary>
        /// WSESRTB.
        /// </summary>
        public const string WSESRTB = "WSESRTB";

        /// <summary>
        /// WSESRTP.
        /// </summary>
        public const string WSESRTP = "WSESRTP";

        /// <summary>
        /// WSEPAAP.
        /// </summary>
        public const string WSEPAAP = "WSEPAAP";

        /// <summary>
        /// WSTOTB.
        /// </summary>
        public const string WSTOTB = "WSTOTB";

        /// <summary>
        /// WSCLAMT.
        /// </summary>
        public const string WSCLAMT = "WSCLAMT";

        /// <summary>
        /// WSDTBIL.
        /// </summary>
        public const string WSDTBIL = "WSDTBIL";

        /// <summary>
        /// WSDTPAY.
        /// </summary>
        public const string WSDTPAY = "WSDTPAY";

        /// <summary>
        /// WSPAAP.
        /// </summary>
        public const string WSPAAP = "WSPAAP";

        /// <summary>
        /// WSLBR1.
        /// </summary>
        public const string WSLBR1 = "WSLBR1";

        /// <summary>
        /// WSD2J.
        /// </summary>
        public const string WSD2J = "WSD2J";

        /// <summary>
        /// WSSTTI.
        /// </summary>
        public const string WSSTTI = "WSSTTI";

        /// <summary>
        /// WSEPETM.
        /// </summary>
        public const string WSEPETM = "WSEPETM";

        /// <summary>
        /// WSCOST.
        /// </summary>
        public const string WSCOST = "WSCOST";

        /// <summary>
        /// WSENTCK.
        /// </summary>
        public const string WSENTCK = "WSENTCK";

        /// <summary>
        /// WSGLCNC.
        /// </summary>
        public const string WSGLCNC = "WSGLCNC";

        /// <summary>
        /// WSGLCCV.
        /// </summary>
        public const string WSGLCCV = "WSGLCCV";

        /// <summary>
        /// WSUSER.
        /// </summary>
        public const string WSUSER = "WSUSER";

        /// <summary>
        /// WSPID.
        /// </summary>
        public const string WSPID = "WSPID";

        /// <summary>
        /// WSJOBN.
        /// </summary>
        public const string WSJOBN = "WSJOBN";

        /// <summary>
        /// WSUPMJ.
        /// </summary>
        public const string WSUPMJ = "WSUPMJ";

        /// <summary>
        /// WSTDAY.
        /// </summary>
        public const string WSTDAY = "WSTDAY";

        /// <summary>
        /// WSASN4.
        /// </summary>
        public const string WSASN4 = "WSASN4";

        /// <summary>
        /// WSASN2.
        /// </summary>
        public const string WSASN2 = "WSASN2";

        /// <summary>
        /// WSPCOVR.
        /// </summary>
        public const string WSPCOVR = "WSPCOVR";

        /// <summary>
        /// WSMTHPR.
        /// </summary>
        public const string WSMTHPR = "WSMTHPR";

        /// <summary>
        /// WSSAID.
        /// </summary>
        public const string WSSAID = "WSSAID";

        /// <summary>
        /// WSPRODF.
        /// </summary>
        public const string WSPRODF = "WSPRODF";

        /// <summary>
        /// WSPRODM.
        /// </summary>
        public const string WSPRODM = "WSPRODM";

        /// <summary>
        /// WSCOVGR.
        /// </summary>
        public const string WSCOVGR = "WSCOVGR";

        /// <summary>
        /// WSPMTHP.
        /// </summary>
        public const string WSPMTHP = "WSPMTHP";

        /// <summary>
        /// WSPYPRT.
        /// </summary>
        public const string WSPYPRT = "WSPYPRT";

        /// <summary>
        /// WSCRDC.
        /// </summary>
        public const string WSCRDC = "WSCRDC";

        /// <summary>
        /// WSBCRCD.
        /// </summary>
        public const string WSBCRCD = "WSBCRCD";

        /// <summary>
        /// WSBCRR.
        /// </summary>
        public const string WSBCRR = "WSBCRR";

        /// <summary>
        /// WSBCRRM.
        /// </summary>
        public const string WSBCRRM = "WSBCRRM";

        /// <summary>
        /// WSFESUNB.
        /// </summary>
        public const string WSFESUNB = "WSFESUNB";

        /// <summary>
        /// WSFEBILL.
        /// </summary>
        public const string WSFEBILL = "WSFEBILL";

        /// <summary>
        /// WSFACUNB.
        /// </summary>
        public const string WSFACUNB = "WSFACUNB";

        /// <summary>
        /// WSFTOTB.
        /// </summary>
        public const string WSFTOTB = "WSFTOTB";

        /// <summary>
        /// WSPCRCD.
        /// </summary>
        public const string WSPCRCD = "WSPCRCD";

        /// <summary>
        /// WSPCRR.
        /// </summary>
        public const string WSPCRR = "WSPCRR";

        /// <summary>
        /// WSPCRRM.
        /// </summary>
        public const string WSPCRRM = "WSPCRRM";

        /// <summary>
        /// WSFESUNP.
        /// </summary>
        public const string WSFESUNP = "WSFESUNP";

        /// <summary>
        /// WSFEPAAP.
        /// </summary>
        public const string WSFEPAAP = "WSFEPAAP";

        /// <summary>
        /// WSFACUNP.
        /// </summary>
        public const string WSFACUNP = "WSFACUNP";

        /// <summary>
        /// WSFPAAP.
        /// </summary>
        public const string WSFPAAP = "WSFPAAP";

        /// <summary>
        /// WSDTSUB.
        /// </summary>
        public const string WSDTSUB = "WSDTSUB";

        /// <summary>
        /// WSTMSUB.
        /// </summary>
        public const string WSTMSUB = "WSTMSUB";

        /// <summary>
        /// WSCSLPRT.
        /// </summary>
        public const string WSCSLPRT = "WSCSLPRT";

        /// <summary>
        /// WSINVREQ.
        /// </summary>
        public const string WSINVREQ = "WSINVREQ";

        /// <summary>
        /// WSINVREC.
        /// </summary>
        public const string WSINVREC = "WSINVREC";

        /// <summary>
        /// WSVMRS32.
        /// </summary>
        public const string WSVMRS32 = "WSVMRS32";

        /// <summary>
        /// WSMCUCSL.
        /// </summary>
        public const string WSMCUCSL = "WSMCUCSL";

        /// <summary>
        /// WSRLOT.
        /// </summary>
        public const string WSRLOT = "WSRLOT";

        /// <summary>
        /// WSSRVEND.
        /// </summary>
        public const string WSSRVEND = "WSSRVEND";

        /// <summary>
        /// WSUKIDP.
        /// </summary>
        public const string WSUKIDP = "WSUKIDP";

        /// <summary>
        /// WSFAILCD.
        /// </summary>
        public const string WSFAILCD = "WSFAILCD";

        /// <summary>
        /// WSVMRS31.
        /// </summary>
        public const string WSVMRS31 = "WSVMRS31";

        /// <summary>
        /// WSVMRS33.
        /// </summary>
        public const string WSVMRS33 = "WSVMRS33";

        /// <summary>
        /// WSLSRCE.
        /// </summary>
        public const string WSLSRCE = "WSLSRCE";
    }

    /// <inheritdoc />
    public override string TableName => "F31172";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSDOCO", "WSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WSOPSQ", "WSOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("WSOPSC", "WSOPSC", JdeDataType.String, 4, true, true),
        new JdeField("WSMCU", "WSMCU", JdeDataType.String, 24, true, true),
        new JdeField("WSPAYAB", "WSPAYAB", JdeDataType.String, 2),
        new JdeField("WSBILL", "WSBILL", JdeDataType.String, 2),
        new JdeField("WSACRTB", "WSACRTB", JdeDataType.Numeric),
        new JdeField("WSACRTP", "WSACRTP", JdeDataType.Numeric),
        new JdeField("WSEBILL", "WSEBILL", JdeDataType.Numeric),
        new JdeField("WSAMTA", "WSAMTA", JdeDataType.Numeric),
        new JdeField("WSAMTO", "WSAMTO", JdeDataType.Numeric),
        new JdeField("WSESRTB", "WSESRTB", JdeDataType.Numeric),
        new JdeField("WSESRTP", "WSESRTP", JdeDataType.Numeric),
        new JdeField("WSEPAAP", "WSEPAAP", JdeDataType.Numeric),
        new JdeField("WSTOTB", "WSTOTB", JdeDataType.Numeric),
        new JdeField("WSCLAMT", "WSCLAMT", JdeDataType.Numeric),
        new JdeField("WSDTBIL", "WSDTBIL", JdeDataType.Numeric),
        new JdeField("WSDTPAY", "WSDTPAY", JdeDataType.Numeric),
        new JdeField("WSPAAP", "WSPAAP", JdeDataType.Numeric),
        new JdeField("WSLBR1", "WSLBR1", JdeDataType.Numeric),
        new JdeField("WSD2J", "WSD2J", JdeDataType.Numeric),
        new JdeField("WSSTTI", "WSSTTI", JdeDataType.Numeric),
        new JdeField("WSEPETM", "WSEPETM", JdeDataType.Numeric),
        new JdeField("WSCOST", "WSCOST", JdeDataType.String, 6),
        new JdeField("WSENTCK", "WSENTCK", JdeDataType.String, 6),
        new JdeField("WSGLCNC", "WSGLCNC", JdeDataType.String, 8),
        new JdeField("WSGLCCV", "WSGLCCV", JdeDataType.String, 8),
        new JdeField("WSUSER", "WSUSER", JdeDataType.String, 20),
        new JdeField("WSPID", "WSPID", JdeDataType.String, 20),
        new JdeField("WSJOBN", "WSJOBN", JdeDataType.String, 20),
        new JdeField("WSUPMJ", "WSUPMJ", JdeDataType.Numeric),
        new JdeField("WSTDAY", "WSTDAY", JdeDataType.Numeric),
        new JdeField("WSASN4", "WSASN4", JdeDataType.String, 16),
        new JdeField("WSASN2", "WSASN2", JdeDataType.String, 16),
        new JdeField("WSPCOVR", "WSPCOVR", JdeDataType.Numeric),
        new JdeField("WSMTHPR", "WSMTHPR", JdeDataType.String, 2),
        new JdeField("WSSAID", "WSSAID", JdeDataType.Numeric),
        new JdeField("WSPRODF", "WSPRODF", JdeDataType.String, 16),
        new JdeField("WSPRODM", "WSPRODM", JdeDataType.String, 16),
        new JdeField("WSCOVGR", "WSCOVGR", JdeDataType.String, 16),
        new JdeField("WSPMTHP", "WSPMTHP", JdeDataType.String, 2),
        new JdeField("WSPYPRT", "WSPYPRT", JdeDataType.String, 2),
        new JdeField("WSCRDC", "WSCRDC", JdeDataType.String, 6),
        new JdeField("WSBCRCD", "WSBCRCD", JdeDataType.String, 6),
        new JdeField("WSBCRR", "WSBCRR", JdeDataType.Numeric),
        new JdeField("WSBCRRM", "WSBCRRM", JdeDataType.String, 2),
        new JdeField("WSFESUNB", "WSFESUNB", JdeDataType.Numeric),
        new JdeField("WSFEBILL", "WSFEBILL", JdeDataType.Numeric),
        new JdeField("WSFACUNB", "WSFACUNB", JdeDataType.Numeric),
        new JdeField("WSFTOTB", "WSFTOTB", JdeDataType.Numeric),
        new JdeField("WSPCRCD", "WSPCRCD", JdeDataType.String, 6),
        new JdeField("WSPCRR", "WSPCRR", JdeDataType.Numeric),
        new JdeField("WSPCRRM", "WSPCRRM", JdeDataType.String, 2),
        new JdeField("WSFESUNP", "WSFESUNP", JdeDataType.Numeric),
        new JdeField("WSFEPAAP", "WSFEPAAP", JdeDataType.Numeric),
        new JdeField("WSFACUNP", "WSFACUNP", JdeDataType.Numeric),
        new JdeField("WSFPAAP", "WSFPAAP", JdeDataType.Numeric),
        new JdeField("WSDTSUB", "WSDTSUB", JdeDataType.Numeric),
        new JdeField("WSTMSUB", "WSTMSUB", JdeDataType.Numeric),
        new JdeField("WSCSLPRT", "WSCSLPRT", JdeDataType.Numeric),
        new JdeField("WSINVREQ", "WSINVREQ", JdeDataType.String, 2),
        new JdeField("WSINVREC", "WSINVREC", JdeDataType.String, 2),
        new JdeField("WSVMRS32", "WSVMRS32", JdeDataType.String, 16),
        new JdeField("WSMCUCSL", "WSMCUCSL", JdeDataType.String, 24),
        new JdeField("WSRLOT", "WSRLOT", JdeDataType.String, 60),
        new JdeField("WSSRVEND", "WSSRVEND", JdeDataType.Numeric),
        new JdeField("WSUKIDP", "WSUKIDP", JdeDataType.Numeric),
        new JdeField("WSFAILCD", "WSFAILCD", JdeDataType.String, 16),
        new JdeField("WSVMRS31", "WSVMRS31", JdeDataType.String, 4),
        new JdeField("WSVMRS33", "WSVMRS33", JdeDataType.String, 20),
        new JdeField("WSLSRCE", "WSLSRCE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31172_0", "Primary Key on WSDOCO, WSOPSQ, WSOPSC, WSMCU", new[] { "WSDOCO", "WSOPSQ", "WSOPSC", "WSMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
