using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31171S - .
/// </summary>
public class F31171S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WSUKID.
        /// </summary>
        public const string WSUKID = "WSUKID";

        /// <summary>
        /// WSESUNC.
        /// </summary>
        public const string WSESUNC = "WSESUNC";

        /// <summary>
        /// WSESUNB.
        /// </summary>
        public const string WSESUNB = "WSESUNB";

        /// <summary>
        /// WSESUNP.
        /// </summary>
        public const string WSESUNP = "WSESUNP";

        /// <summary>
        /// WSEPAAP.
        /// </summary>
        public const string WSEPAAP = "WSEPAAP";

        /// <summary>
        /// WSAMTO.
        /// </summary>
        public const string WSAMTO = "WSAMTO";

        /// <summary>
        /// WSEBILL.
        /// </summary>
        public const string WSEBILL = "WSEBILL";

        /// <summary>
        /// WSACUNC.
        /// </summary>
        public const string WSACUNC = "WSACUNC";

        /// <summary>
        /// WSACUNB.
        /// </summary>
        public const string WSACUNB = "WSACUNB";

        /// <summary>
        /// WSACUNP.
        /// </summary>
        public const string WSACUNP = "WSACUNP";

        /// <summary>
        /// WSAMTA.
        /// </summary>
        public const string WSAMTA = "WSAMTA";

        /// <summary>
        /// WSTOTB.
        /// </summary>
        public const string WSTOTB = "WSTOTB";

        /// <summary>
        /// WSPAAP.
        /// </summary>
        public const string WSPAAP = "WSPAAP";

        /// <summary>
        /// WSCLAMT.
        /// </summary>
        public const string WSCLAMT = "WSCLAMT";

        /// <summary>
        /// WSVEND.
        /// </summary>
        public const string WSVEND = "WSVEND";

        /// <summary>
        /// WSPAYAB.
        /// </summary>
        public const string WSPAYAB = "WSPAYAB";

        /// <summary>
        /// WSBILL.
        /// </summary>
        public const string WSBILL = "WSBILL";

        /// <summary>
        /// WSDTPAY.
        /// </summary>
        public const string WSDTPAY = "WSDTPAY";

        /// <summary>
        /// WSDTBIL.
        /// </summary>
        public const string WSDTBIL = "WSDTBIL";

        /// <summary>
        /// WSCOST.
        /// </summary>
        public const string WSCOST = "WSCOST";

        /// <summary>
        /// WSGLCNC.
        /// </summary>
        public const string WSGLCNC = "WSGLCNC";

        /// <summary>
        /// WSGLCCV.
        /// </summary>
        public const string WSGLCCV = "WSGLCCV";

        /// <summary>
        /// WSENTCK.
        /// </summary>
        public const string WSENTCK = "WSENTCK";

        /// <summary>
        /// WSVR02.
        /// </summary>
        public const string WSVR02 = "WSVR02";

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
        /// WSFAILCD.
        /// </summary>
        public const string WSFAILCD = "WSFAILCD";

        /// <summary>
        /// WSRETPOL.
        /// </summary>
        public const string WSRETPOL = "WSRETPOL";

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
        /// WSVMRS33.
        /// </summary>
        public const string WSVMRS33 = "WSVMRS33";

        /// <summary>
        /// WSSRVEND.
        /// </summary>
        public const string WSSRVEND = "WSSRVEND";

        /// <summary>
        /// WSRLOT.
        /// </summary>
        public const string WSRLOT = "WSRLOT";

        /// <summary>
        /// WSMCUCSL.
        /// </summary>
        public const string WSMCUCSL = "WSMCUCSL";

        /// <summary>
        /// WSTAX1.
        /// </summary>
        public const string WSTAX1 = "WSTAX1";

        /// <summary>
        /// WSUKIDP.
        /// </summary>
        public const string WSUKIDP = "WSUKIDP";

        /// <summary>
        /// WSVMRS31.
        /// </summary>
        public const string WSVMRS31 = "WSVMRS31";

        /// <summary>
        /// WSVMRS32.
        /// </summary>
        public const string WSVMRS32 = "WSVMRS32";
    }

    /// <inheritdoc />
    public override string TableName => "F31171S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WSUKID", "WSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WSESUNC", "WSESUNC", JdeDataType.Numeric),
        new JdeField("WSESUNB", "WSESUNB", JdeDataType.Numeric),
        new JdeField("WSESUNP", "WSESUNP", JdeDataType.Numeric),
        new JdeField("WSEPAAP", "WSEPAAP", JdeDataType.Numeric),
        new JdeField("WSAMTO", "WSAMTO", JdeDataType.Numeric),
        new JdeField("WSEBILL", "WSEBILL", JdeDataType.Numeric),
        new JdeField("WSACUNC", "WSACUNC", JdeDataType.Numeric),
        new JdeField("WSACUNB", "WSACUNB", JdeDataType.Numeric),
        new JdeField("WSACUNP", "WSACUNP", JdeDataType.Numeric),
        new JdeField("WSAMTA", "WSAMTA", JdeDataType.Numeric),
        new JdeField("WSTOTB", "WSTOTB", JdeDataType.Numeric),
        new JdeField("WSPAAP", "WSPAAP", JdeDataType.Numeric),
        new JdeField("WSCLAMT", "WSCLAMT", JdeDataType.Numeric),
        new JdeField("WSVEND", "WSVEND", JdeDataType.Numeric),
        new JdeField("WSPAYAB", "WSPAYAB", JdeDataType.String, 2),
        new JdeField("WSBILL", "WSBILL", JdeDataType.String, 2),
        new JdeField("WSDTPAY", "WSDTPAY", JdeDataType.Numeric),
        new JdeField("WSDTBIL", "WSDTBIL", JdeDataType.Numeric),
        new JdeField("WSCOST", "WSCOST", JdeDataType.String, 6),
        new JdeField("WSGLCNC", "WSGLCNC", JdeDataType.String, 8),
        new JdeField("WSGLCCV", "WSGLCCV", JdeDataType.String, 8),
        new JdeField("WSENTCK", "WSENTCK", JdeDataType.String, 6),
        new JdeField("WSVR02", "WSVR02", JdeDataType.String, 50),
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
        new JdeField("WSFAILCD", "WSFAILCD", JdeDataType.String, 16),
        new JdeField("WSRETPOL", "WSRETPOL", JdeDataType.String, 2),
        new JdeField("WSDTSUB", "WSDTSUB", JdeDataType.Numeric),
        new JdeField("WSTMSUB", "WSTMSUB", JdeDataType.Numeric),
        new JdeField("WSCSLPRT", "WSCSLPRT", JdeDataType.Numeric),
        new JdeField("WSVMRS33", "WSVMRS33", JdeDataType.String, 20),
        new JdeField("WSSRVEND", "WSSRVEND", JdeDataType.Numeric),
        new JdeField("WSRLOT", "WSRLOT", JdeDataType.String, 60),
        new JdeField("WSMCUCSL", "WSMCUCSL", JdeDataType.String, 24),
        new JdeField("WSTAX1", "WSTAX1", JdeDataType.String, 2),
        new JdeField("WSUKIDP", "WSUKIDP", JdeDataType.Numeric),
        new JdeField("WSVMRS31", "WSVMRS31", JdeDataType.String, 4),
        new JdeField("WSVMRS32", "WSVMRS32", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31171S_0", "Primary Key on WSUKID", new[] { "WSUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
