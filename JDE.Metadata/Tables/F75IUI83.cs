using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI83 - .
/// </summary>
public class F75IUI83 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SDUKID.
        /// </summary>
        public const string SDUKID = "SDUKID";

        /// <summary>
        /// SDI75GSTU.
        /// </summary>
        public const string SDI75GSTU = "SDI75GSTU";

        /// <summary>
        /// SDLNID.
        /// </summary>
        public const string SDLNID = "SDLNID";

        /// <summary>
        /// SDI75GSTNP.
        /// </summary>
        public const string SDI75GSTNP = "SDI75GSTNP";

        /// <summary>
        /// SDI75GSTNO.
        /// </summary>
        public const string SDI75GSTNO = "SDI75GSTNO";

        /// <summary>
        /// SDYINVDT.
        /// </summary>
        public const string SDYINVDT = "SDYINVDT";

        /// <summary>
        /// SDI75INVNO.
        /// </summary>
        public const string SDI75INVNO = "SDI75INVNO";

        /// <summary>
        /// SDI75CATVL.
        /// </summary>
        public const string SDI75CATVL = "SDI75CATVL";

        /// <summary>
        /// SDI75CATTY.
        /// </summary>
        public const string SDI75CATTY = "SDI75CATTY";

        /// <summary>
        /// SDI75IGSTR.
        /// </summary>
        public const string SDI75IGSTR = "SDI75IGSTR";

        /// <summary>
        /// SDI75IGSTA.
        /// </summary>
        public const string SDI75IGSTA = "SDI75IGSTA";

        /// <summary>
        /// SDI75CGSTR.
        /// </summary>
        public const string SDI75CGSTR = "SDI75CGSTR";

        /// <summary>
        /// SDI75CGSTA.
        /// </summary>
        public const string SDI75CGSTA = "SDI75CGSTA";

        /// <summary>
        /// SDI75SGSTR.
        /// </summary>
        public const string SDI75SGSTR = "SDI75SGSTR";

        /// <summary>
        /// SDI75SGSTA.
        /// </summary>
        public const string SDI75SGSTA = "SDI75SGSTA";

        /// <summary>
        /// SDATXA.
        /// </summary>
        public const string SDATXA = "SDATXA";

        /// <summary>
        /// SDAG.
        /// </summary>
        public const string SDAG = "SDAG";

        /// <summary>
        /// SDI75FRC.
        /// </summary>
        public const string SDI75FRC = "SDI75FRC";

        /// <summary>
        /// SDI75MCHFD.
        /// </summary>
        public const string SDI75MCHFD = "SDI75MCHFD";

        /// <summary>
        /// SDI75CLMFD.
        /// </summary>
        public const string SDI75CLMFD = "SDI75CLMFD";

        /// <summary>
        /// SDI75RCGST.
        /// </summary>
        public const string SDI75RCGST = "SDI75RCGST";

        /// <summary>
        /// SDI75RSGST.
        /// </summary>
        public const string SDI75RSGST = "SDI75RSGST";

        /// <summary>
        /// SDI75RIGST.
        /// </summary>
        public const string SDI75RIGST = "SDI75RIGST";

        /// <summary>
        /// SDI75RCITC.
        /// </summary>
        public const string SDI75RCITC = "SDI75RCITC";

        /// <summary>
        /// SDREM1.
        /// </summary>
        public const string SDREM1 = "SDREM1";

        /// <summary>
        /// SDUSER.
        /// </summary>
        public const string SDUSER = "SDUSER";

        /// <summary>
        /// SDPID.
        /// </summary>
        public const string SDPID = "SDPID";

        /// <summary>
        /// SDJOBN.
        /// </summary>
        public const string SDJOBN = "SDJOBN";

        /// <summary>
        /// SDUPMJ.
        /// </summary>
        public const string SDUPMJ = "SDUPMJ";

        /// <summary>
        /// SDUPMT.
        /// </summary>
        public const string SDUPMT = "SDUPMT";

        /// <summary>
        /// SDYFUTDT1.
        /// </summary>
        public const string SDYFUTDT1 = "SDYFUTDT1";

        /// <summary>
        /// SDFUT6.
        /// </summary>
        public const string SDFUT6 = "SDFUT6";

        /// <summary>
        /// SDYT04.
        /// </summary>
        public const string SDYT04 = "SDYT04";

        /// <summary>
        /// SDYFLAG.
        /// </summary>
        public const string SDYFLAG = "SDYFLAG";

        /// <summary>
        /// SDYNUM1.
        /// </summary>
        public const string SDYNUM1 = "SDYNUM1";

        /// <summary>
        /// SDI75CESSR.
        /// </summary>
        public const string SDI75CESSR = "SDI75CESSR";

        /// <summary>
        /// SDI75CESSA.
        /// </summary>
        public const string SDI75CESSA = "SDI75CESSA";

        /// <summary>
        /// SDI75ATX1R.
        /// </summary>
        public const string SDI75ATX1R = "SDI75ATX1R";

        /// <summary>
        /// SDI75ATX1A.
        /// </summary>
        public const string SDI75ATX1A = "SDI75ATX1A";

        /// <summary>
        /// SDI75ATX2R.
        /// </summary>
        public const string SDI75ATX2R = "SDI75ATX2R";

        /// <summary>
        /// SDI75ATX2A.
        /// </summary>
        public const string SDI75ATX2A = "SDI75ATX2A";

        /// <summary>
        /// SDI75ATX3R.
        /// </summary>
        public const string SDI75ATX3R = "SDI75ATX3R";

        /// <summary>
        /// SDI75ATX3A.
        /// </summary>
        public const string SDI75ATX3A = "SDI75ATX3A";

        /// <summary>
        /// SDI75AT4R.
        /// </summary>
        public const string SDI75AT4R = "SDI75AT4R";

        /// <summary>
        /// SDI75AT4A.
        /// </summary>
        public const string SDI75AT4A = "SDI75AT4A";

        /// <summary>
        /// SDI75RCESS.
        /// </summary>
        public const string SDI75RCESS = "SDI75RCESS";

        /// <summary>
        /// SDI75RATX1.
        /// </summary>
        public const string SDI75RATX1 = "SDI75RATX1";

        /// <summary>
        /// SDI75RATX3.
        /// </summary>
        public const string SDI75RATX3 = "SDI75RATX3";

        /// <summary>
        /// SDI75RATX2.
        /// </summary>
        public const string SDI75RATX2 = "SDI75RATX2";

        /// <summary>
        /// SDI75RATX4.
        /// </summary>
        public const string SDI75RATX4 = "SDI75RATX4";

        /// <summary>
        /// SDI75GSTRA.
        /// </summary>
        public const string SDI75GSTRA = "SDI75GSTRA";

        /// <summary>
        /// SDI75GSTR.
        /// </summary>
        public const string SDI75GSTR = "SDI75GSTR";

        /// <summary>
        /// SDI75IPOS.
        /// </summary>
        public const string SDI75IPOS = "SDI75IPOS";

        /// <summary>
        /// SDI75INVON.
        /// </summary>
        public const string SDI75INVON = "SDI75INVON";

        /// <summary>
        /// SDI75INVOD.
        /// </summary>
        public const string SDI75INVOD = "SDI75INVOD";

        /// <summary>
        /// SDDCT.
        /// </summary>
        public const string SDDCT = "SDDCT";

        /// <summary>
        /// SDKCO.
        /// </summary>
        public const string SDKCO = "SDKCO";

        /// <summary>
        /// SDAN8.
        /// </summary>
        public const string SDAN8 = "SDAN8";

        /// <summary>
        /// SDDOCO.
        /// </summary>
        public const string SDDOCO = "SDDOCO";

        /// <summary>
        /// SDDCTO.
        /// </summary>
        public const string SDDCTO = "SDDCTO";

        /// <summary>
        /// SDKCOO.
        /// </summary>
        public const string SDKCOO = "SDKCOO";

        /// <summary>
        /// SDDOC.
        /// </summary>
        public const string SDDOC = "SDDOC";

        /// <summary>
        /// SDI75RECU.
        /// </summary>
        public const string SDI75RECU = "SDI75RECU";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI83";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SDUKID", "SDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDI75GSTU", "SDI75GSTU", JdeDataType.Numeric, null, true, true),
        new JdeField("SDLNID", "SDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("SDI75GSTNP", "SDI75GSTNP", JdeDataType.String, 50),
        new JdeField("SDI75GSTNO", "SDI75GSTNO", JdeDataType.String, 50),
        new JdeField("SDYINVDT", "SDYINVDT", JdeDataType.Numeric),
        new JdeField("SDI75INVNO", "SDI75INVNO", JdeDataType.String, 50),
        new JdeField("SDI75CATVL", "SDI75CATVL", JdeDataType.String, 40),
        new JdeField("SDI75CATTY", "SDI75CATTY", JdeDataType.String, 6),
        new JdeField("SDI75IGSTR", "SDI75IGSTR", JdeDataType.Numeric),
        new JdeField("SDI75IGSTA", "SDI75IGSTA", JdeDataType.Numeric),
        new JdeField("SDI75CGSTR", "SDI75CGSTR", JdeDataType.Numeric),
        new JdeField("SDI75CGSTA", "SDI75CGSTA", JdeDataType.Numeric),
        new JdeField("SDI75SGSTR", "SDI75SGSTR", JdeDataType.Numeric),
        new JdeField("SDI75SGSTA", "SDI75SGSTA", JdeDataType.Numeric),
        new JdeField("SDATXA", "SDATXA", JdeDataType.Numeric),
        new JdeField("SDAG", "SDAG", JdeDataType.Numeric),
        new JdeField("SDI75FRC", "SDI75FRC", JdeDataType.String, 2),
        new JdeField("SDI75MCHFD", "SDI75MCHFD", JdeDataType.String, 2),
        new JdeField("SDI75CLMFD", "SDI75CLMFD", JdeDataType.String, 2),
        new JdeField("SDI75RCGST", "SDI75RCGST", JdeDataType.Numeric),
        new JdeField("SDI75RSGST", "SDI75RSGST", JdeDataType.Numeric),
        new JdeField("SDI75RIGST", "SDI75RIGST", JdeDataType.Numeric),
        new JdeField("SDI75RCITC", "SDI75RCITC", JdeDataType.Numeric),
        new JdeField("SDREM1", "SDREM1", JdeDataType.String, 80),
        new JdeField("SDUSER", "SDUSER", JdeDataType.String, 20),
        new JdeField("SDPID", "SDPID", JdeDataType.String, 20),
        new JdeField("SDJOBN", "SDJOBN", JdeDataType.String, 20),
        new JdeField("SDUPMJ", "SDUPMJ", JdeDataType.Numeric),
        new JdeField("SDUPMT", "SDUPMT", JdeDataType.Numeric),
        new JdeField("SDYFUTDT1", "SDYFUTDT1", JdeDataType.Numeric),
        new JdeField("SDFUT6", "SDFUT6", JdeDataType.String, 60),
        new JdeField("SDYT04", "SDYT04", JdeDataType.String, 2),
        new JdeField("SDYFLAG", "SDYFLAG", JdeDataType.String, 2),
        new JdeField("SDYNUM1", "SDYNUM1", JdeDataType.Numeric),
        new JdeField("SDI75CESSR", "SDI75CESSR", JdeDataType.Numeric),
        new JdeField("SDI75CESSA", "SDI75CESSA", JdeDataType.Numeric),
        new JdeField("SDI75ATX1R", "SDI75ATX1R", JdeDataType.Numeric),
        new JdeField("SDI75ATX1A", "SDI75ATX1A", JdeDataType.Numeric),
        new JdeField("SDI75ATX2R", "SDI75ATX2R", JdeDataType.Numeric),
        new JdeField("SDI75ATX2A", "SDI75ATX2A", JdeDataType.Numeric),
        new JdeField("SDI75ATX3R", "SDI75ATX3R", JdeDataType.Numeric),
        new JdeField("SDI75ATX3A", "SDI75ATX3A", JdeDataType.Numeric),
        new JdeField("SDI75AT4R", "SDI75AT4R", JdeDataType.Numeric),
        new JdeField("SDI75AT4A", "SDI75AT4A", JdeDataType.Numeric),
        new JdeField("SDI75RCESS", "SDI75RCESS", JdeDataType.Numeric),
        new JdeField("SDI75RATX1", "SDI75RATX1", JdeDataType.Numeric),
        new JdeField("SDI75RATX3", "SDI75RATX3", JdeDataType.Numeric),
        new JdeField("SDI75RATX2", "SDI75RATX2", JdeDataType.Numeric),
        new JdeField("SDI75RATX4", "SDI75RATX4", JdeDataType.Numeric),
        new JdeField("SDI75GSTRA", "SDI75GSTRA", JdeDataType.String, 4),
        new JdeField("SDI75GSTR", "SDI75GSTR", JdeDataType.Numeric),
        new JdeField("SDI75IPOS", "SDI75IPOS", JdeDataType.String, 4),
        new JdeField("SDI75INVON", "SDI75INVON", JdeDataType.String, 50),
        new JdeField("SDI75INVOD", "SDI75INVOD", JdeDataType.Numeric),
        new JdeField("SDDCT", "SDDCT", JdeDataType.String, 4),
        new JdeField("SDKCO", "SDKCO", JdeDataType.String, 10),
        new JdeField("SDAN8", "SDAN8", JdeDataType.Numeric),
        new JdeField("SDDOCO", "SDDOCO", JdeDataType.Numeric),
        new JdeField("SDDCTO", "SDDCTO", JdeDataType.String, 4),
        new JdeField("SDKCOO", "SDKCOO", JdeDataType.String, 10),
        new JdeField("SDDOC", "SDDOC", JdeDataType.Numeric),
        new JdeField("SDI75RECU", "SDI75RECU", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI83_0", "Primary Key on SDUKID, SDI75GSTU, SDLNID", new[] { "SDUKID", "SDI75GSTU", "SDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
