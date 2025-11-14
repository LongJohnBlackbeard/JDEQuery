using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I812 - .
/// </summary>
public class F75I812 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTUKID.
        /// </summary>
        public const string RTUKID = "RTUKID";

        /// <summary>
        /// RTYLYR.
        /// </summary>
        public const string RTYLYR = "RTYLYR";

        /// <summary>
        /// RTYMNTH.
        /// </summary>
        public const string RTYMNTH = "RTYMNTH";

        /// <summary>
        /// RTI75GSTU.
        /// </summary>
        public const string RTI75GSTU = "RTI75GSTU";

        /// <summary>
        /// RTLNID.
        /// </summary>
        public const string RTLNID = "RTLNID";

        /// <summary>
        /// RTI75GSTNP.
        /// </summary>
        public const string RTI75GSTNP = "RTI75GSTNP";

        /// <summary>
        /// RTI75GSTDN.
        /// </summary>
        public const string RTI75GSTDN = "RTI75GSTDN";

        /// <summary>
        /// RTI75GSTNO.
        /// </summary>
        public const string RTI75GSTNO = "RTI75GSTNO";

        /// <summary>
        /// RTI75INVNO.
        /// </summary>
        public const string RTI75INVNO = "RTI75INVNO";

        /// <summary>
        /// RTYINVDT.
        /// </summary>
        public const string RTYINVDT = "RTYINVDT";

        /// <summary>
        /// RTI75CATTY.
        /// </summary>
        public const string RTI75CATTY = "RTI75CATTY";

        /// <summary>
        /// RTI75CATVL.
        /// </summary>
        public const string RTI75CATVL = "RTI75CATVL";

        /// <summary>
        /// RTI75INVVL.
        /// </summary>
        public const string RTI75INVVL = "RTI75INVVL";

        /// <summary>
        /// RTSTAM.
        /// </summary>
        public const string RTSTAM = "RTSTAM";

        /// <summary>
        /// RTI75IGSTR.
        /// </summary>
        public const string RTI75IGSTR = "RTI75IGSTR";

        /// <summary>
        /// RTI75IGSTA.
        /// </summary>
        public const string RTI75IGSTA = "RTI75IGSTA";

        /// <summary>
        /// RTI75CGSTR.
        /// </summary>
        public const string RTI75CGSTR = "RTI75CGSTR";

        /// <summary>
        /// RTI75CGSTA.
        /// </summary>
        public const string RTI75CGSTA = "RTI75CGSTA";

        /// <summary>
        /// RTI75SGSTR.
        /// </summary>
        public const string RTI75SGSTR = "RTI75SGSTR";

        /// <summary>
        /// RTI75SGSTA.
        /// </summary>
        public const string RTI75SGSTA = "RTI75SGSTA";

        /// <summary>
        /// RTI75ITCE.
        /// </summary>
        public const string RTI75ITCE = "RTI75ITCE";

        /// <summary>
        /// RTI75ITCTT.
        /// </summary>
        public const string RTI75ITCTT = "RTI75ITCTT";

        /// <summary>
        /// RTI75ITCM.
        /// </summary>
        public const string RTI75ITCM = "RTI75ITCM";

        /// <summary>
        /// RTI75FRC.
        /// </summary>
        public const string RTI75FRC = "RTI75FRC";

        /// <summary>
        /// RTI75MCHFD.
        /// </summary>
        public const string RTI75MCHFD = "RTI75MCHFD";

        /// <summary>
        /// RTI75CLMFD.
        /// </summary>
        public const string RTI75CLMFD = "RTI75CLMFD";

        /// <summary>
        /// RTI75RCITC.
        /// </summary>
        public const string RTI75RCITC = "RTI75RCITC";

        /// <summary>
        /// RTI75RCGST.
        /// </summary>
        public const string RTI75RCGST = "RTI75RCGST";

        /// <summary>
        /// RTI75RIGST.
        /// </summary>
        public const string RTI75RIGST = "RTI75RIGST";

        /// <summary>
        /// RTI75RSGST.
        /// </summary>
        public const string RTI75RSGST = "RTI75RSGST";

        /// <summary>
        /// RTREM1.
        /// </summary>
        public const string RTREM1 = "RTREM1";

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

        /// <summary>
        /// RTICU.
        /// </summary>
        public const string RTICU = "RTICU";

        /// <summary>
        /// RTICUT.
        /// </summary>
        public const string RTICUT = "RTICUT";

        /// <summary>
        /// RTI75CESSR.
        /// </summary>
        public const string RTI75CESSR = "RTI75CESSR";

        /// <summary>
        /// RTI75CESSA.
        /// </summary>
        public const string RTI75CESSA = "RTI75CESSA";

        /// <summary>
        /// RTI75ATX1R.
        /// </summary>
        public const string RTI75ATX1R = "RTI75ATX1R";

        /// <summary>
        /// RTI75ATX1A.
        /// </summary>
        public const string RTI75ATX1A = "RTI75ATX1A";

        /// <summary>
        /// RTI75ATX2R.
        /// </summary>
        public const string RTI75ATX2R = "RTI75ATX2R";

        /// <summary>
        /// RTI75ATX2A.
        /// </summary>
        public const string RTI75ATX2A = "RTI75ATX2A";

        /// <summary>
        /// RTI75ATX3R.
        /// </summary>
        public const string RTI75ATX3R = "RTI75ATX3R";

        /// <summary>
        /// RTI75ATX3A.
        /// </summary>
        public const string RTI75ATX3A = "RTI75ATX3A";

        /// <summary>
        /// RTI75AT4R.
        /// </summary>
        public const string RTI75AT4R = "RTI75AT4R";

        /// <summary>
        /// RTI75AT4A.
        /// </summary>
        public const string RTI75AT4A = "RTI75AT4A";

        /// <summary>
        /// RTI75RCESS.
        /// </summary>
        public const string RTI75RCESS = "RTI75RCESS";

        /// <summary>
        /// RTI75RATX1.
        /// </summary>
        public const string RTI75RATX1 = "RTI75RATX1";

        /// <summary>
        /// RTI75RATX2.
        /// </summary>
        public const string RTI75RATX2 = "RTI75RATX2";

        /// <summary>
        /// RTI75RATX3.
        /// </summary>
        public const string RTI75RATX3 = "RTI75RATX3";

        /// <summary>
        /// RTI75RATX4.
        /// </summary>
        public const string RTI75RATX4 = "RTI75RATX4";

        /// <summary>
        /// RTI75GSTR.
        /// </summary>
        public const string RTI75GSTR = "RTI75GSTR";

        /// <summary>
        /// RTI75IPOS.
        /// </summary>
        public const string RTI75IPOS = "RTI75IPOS";

        /// <summary>
        /// RTI75GSTRA.
        /// </summary>
        public const string RTI75GSTRA = "RTI75GSTRA";

        /// <summary>
        /// RTI75GSTND.
        /// </summary>
        public const string RTI75GSTND = "RTI75GSTND";

        /// <summary>
        /// RTI75INVON.
        /// </summary>
        public const string RTI75INVON = "RTI75INVON";

        /// <summary>
        /// RTI75INVOD.
        /// </summary>
        public const string RTI75INVOD = "RTI75INVOD";

        /// <summary>
        /// RTI75SECNO.
        /// </summary>
        public const string RTI75SECNO = "RTI75SECNO";
    }

    /// <inheritdoc />
    public override string TableName => "F75I812";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTUKID", "RTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RTYLYR", "RTYLYR", JdeDataType.Numeric, null, true, true),
        new JdeField("RTYMNTH", "RTYMNTH", JdeDataType.String, 4, true, true),
        new JdeField("RTI75GSTU", "RTI75GSTU", JdeDataType.Numeric, null, true, true),
        new JdeField("RTLNID", "RTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RTI75GSTNP", "RTI75GSTNP", JdeDataType.String, 50),
        new JdeField("RTI75GSTDN", "RTI75GSTDN", JdeDataType.String, 30),
        new JdeField("RTI75GSTNO", "RTI75GSTNO", JdeDataType.String, 50),
        new JdeField("RTI75INVNO", "RTI75INVNO", JdeDataType.String, 50),
        new JdeField("RTYINVDT", "RTYINVDT", JdeDataType.Numeric),
        new JdeField("RTI75CATTY", "RTI75CATTY", JdeDataType.String, 6),
        new JdeField("RTI75CATVL", "RTI75CATVL", JdeDataType.String, 40),
        new JdeField("RTI75INVVL", "RTI75INVVL", JdeDataType.Numeric),
        new JdeField("RTSTAM", "RTSTAM", JdeDataType.Numeric),
        new JdeField("RTI75IGSTR", "RTI75IGSTR", JdeDataType.Numeric),
        new JdeField("RTI75IGSTA", "RTI75IGSTA", JdeDataType.Numeric),
        new JdeField("RTI75CGSTR", "RTI75CGSTR", JdeDataType.Numeric),
        new JdeField("RTI75CGSTA", "RTI75CGSTA", JdeDataType.Numeric),
        new JdeField("RTI75SGSTR", "RTI75SGSTR", JdeDataType.Numeric),
        new JdeField("RTI75SGSTA", "RTI75SGSTA", JdeDataType.Numeric),
        new JdeField("RTI75ITCE", "RTI75ITCE", JdeDataType.String, 50),
        new JdeField("RTI75ITCTT", "RTI75ITCTT", JdeDataType.Numeric),
        new JdeField("RTI75ITCM", "RTI75ITCM", JdeDataType.Numeric),
        new JdeField("RTI75FRC", "RTI75FRC", JdeDataType.String, 2),
        new JdeField("RTI75MCHFD", "RTI75MCHFD", JdeDataType.String, 2),
        new JdeField("RTI75CLMFD", "RTI75CLMFD", JdeDataType.String, 2),
        new JdeField("RTI75RCITC", "RTI75RCITC", JdeDataType.Numeric),
        new JdeField("RTI75RCGST", "RTI75RCGST", JdeDataType.Numeric),
        new JdeField("RTI75RIGST", "RTI75RIGST", JdeDataType.Numeric),
        new JdeField("RTI75RSGST", "RTI75RSGST", JdeDataType.Numeric),
        new JdeField("RTREM1", "RTREM1", JdeDataType.String, 80),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric),
        new JdeField("RTYFUTDT1", "RTYFUTDT1", JdeDataType.Numeric),
        new JdeField("RTFUT6", "RTFUT6", JdeDataType.String, 60),
        new JdeField("RTYT04", "RTYT04", JdeDataType.String, 2),
        new JdeField("RTYFLAG", "RTYFLAG", JdeDataType.String, 2),
        new JdeField("RTYNUM1", "RTYNUM1", JdeDataType.Numeric),
        new JdeField("RTICU", "RTICU", JdeDataType.Numeric),
        new JdeField("RTICUT", "RTICUT", JdeDataType.String, 4),
        new JdeField("RTI75CESSR", "RTI75CESSR", JdeDataType.Numeric),
        new JdeField("RTI75CESSA", "RTI75CESSA", JdeDataType.Numeric),
        new JdeField("RTI75ATX1R", "RTI75ATX1R", JdeDataType.Numeric),
        new JdeField("RTI75ATX1A", "RTI75ATX1A", JdeDataType.Numeric),
        new JdeField("RTI75ATX2R", "RTI75ATX2R", JdeDataType.Numeric),
        new JdeField("RTI75ATX2A", "RTI75ATX2A", JdeDataType.Numeric),
        new JdeField("RTI75ATX3R", "RTI75ATX3R", JdeDataType.Numeric),
        new JdeField("RTI75ATX3A", "RTI75ATX3A", JdeDataType.Numeric),
        new JdeField("RTI75AT4R", "RTI75AT4R", JdeDataType.Numeric),
        new JdeField("RTI75AT4A", "RTI75AT4A", JdeDataType.Numeric),
        new JdeField("RTI75RCESS", "RTI75RCESS", JdeDataType.Numeric),
        new JdeField("RTI75RATX1", "RTI75RATX1", JdeDataType.Numeric),
        new JdeField("RTI75RATX2", "RTI75RATX2", JdeDataType.Numeric),
        new JdeField("RTI75RATX3", "RTI75RATX3", JdeDataType.Numeric),
        new JdeField("RTI75RATX4", "RTI75RATX4", JdeDataType.Numeric),
        new JdeField("RTI75GSTR", "RTI75GSTR", JdeDataType.Numeric),
        new JdeField("RTI75IPOS", "RTI75IPOS", JdeDataType.String, 4),
        new JdeField("RTI75GSTRA", "RTI75GSTRA", JdeDataType.String, 4),
        new JdeField("RTI75GSTND", "RTI75GSTND", JdeDataType.String, 50),
        new JdeField("RTI75INVON", "RTI75INVON", JdeDataType.String, 50),
        new JdeField("RTI75INVOD", "RTI75INVOD", JdeDataType.Numeric),
        new JdeField("RTI75SECNO", "RTI75SECNO", JdeDataType.String, 8)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I812_0", "Primary Key on RTYLYR, RTYMNTH, RTLNID, RTUKID, RTI75GSTU", new[] { "RTYLYR", "RTYMNTH", "RTLNID", "RTUKID", "RTI75GSTU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I812_2", "Index on SYS_NC00066$, RTUKID, RTYLYR, RTYMNTH, RTI75GSTU", new[] { "SYS_NC00066$", "RTUKID", "RTYLYR", "RTYMNTH", "RTI75GSTU" }),
        new JdeIndex("F75I812_3", "Index on RTYLYR, RTYMNTH, RTI75GSTU, RTLNID", new[] { "RTYLYR", "RTYMNTH", "RTI75GSTU", "RTLNID" })
    };
}
