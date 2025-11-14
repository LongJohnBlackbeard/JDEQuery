using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI89 - .
/// </summary>
public class F75IUI89 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OIJOBS.
        /// </summary>
        public const string OIJOBS = "OIJOBS";

        /// <summary>
        /// OIUKID.
        /// </summary>
        public const string OIUKID = "OIUKID";

        /// <summary>
        /// OIDOC.
        /// </summary>
        public const string OIDOC = "OIDOC";

        /// <summary>
        /// OIDCT.
        /// </summary>
        public const string OIDCT = "OIDCT";

        /// <summary>
        /// OIKCO.
        /// </summary>
        public const string OIKCO = "OIKCO";

        /// <summary>
        /// OISFX.
        /// </summary>
        public const string OISFX = "OISFX";

        /// <summary>
        /// OIDOCO.
        /// </summary>
        public const string OIDOCO = "OIDOCO";

        /// <summary>
        /// OIDCTO.
        /// </summary>
        public const string OIDCTO = "OIDCTO";

        /// <summary>
        /// OIKCOO.
        /// </summary>
        public const string OIKCOO = "OIKCOO";

        /// <summary>
        /// OILNID.
        /// </summary>
        public const string OILNID = "OILNID";

        /// <summary>
        /// OII75GSTNP.
        /// </summary>
        public const string OII75GSTNP = "OII75GSTNP";

        /// <summary>
        /// OII75GSTNO.
        /// </summary>
        public const string OII75GSTNO = "OII75GSTNO";

        /// <summary>
        /// OII75INVNO.
        /// </summary>
        public const string OII75INVNO = "OII75INVNO";

        /// <summary>
        /// OIDIVJ.
        /// </summary>
        public const string OIDIVJ = "OIDIVJ";

        /// <summary>
        /// OIDGL.
        /// </summary>
        public const string OIDGL = "OIDGL";

        /// <summary>
        /// OII75INVVL.
        /// </summary>
        public const string OII75INVVL = "OII75INVVL";

        /// <summary>
        /// OII75GSTR.
        /// </summary>
        public const string OII75GSTR = "OII75GSTR";

        /// <summary>
        /// OII75GSTRA.
        /// </summary>
        public const string OII75GSTRA = "OII75GSTRA";

        /// <summary>
        /// OIATXA.
        /// </summary>
        public const string OIATXA = "OIATXA";

        /// <summary>
        /// OII75IGSTA.
        /// </summary>
        public const string OII75IGSTA = "OII75IGSTA";

        /// <summary>
        /// OII75CGSTA.
        /// </summary>
        public const string OII75CGSTA = "OII75CGSTA";

        /// <summary>
        /// OII75SGSTA.
        /// </summary>
        public const string OII75SGSTA = "OII75SGSTA";

        /// <summary>
        /// OII75CESSA.
        /// </summary>
        public const string OII75CESSA = "OII75CESSA";

        /// <summary>
        /// OII75AIGST.
        /// </summary>
        public const string OII75AIGST = "OII75AIGST";

        /// <summary>
        /// OII75ACGST.
        /// </summary>
        public const string OII75ACGST = "OII75ACGST";

        /// <summary>
        /// OII75ASGST.
        /// </summary>
        public const string OII75ASGST = "OII75ASGST";

        /// <summary>
        /// OII75ACESS.
        /// </summary>
        public const string OII75ACESS = "OII75ACESS";

        /// <summary>
        /// OII75EXTYP.
        /// </summary>
        public const string OII75EXTYP = "OII75EXTYP";

        /// <summary>
        /// OII75ITCE.
        /// </summary>
        public const string OII75ITCE = "OII75ITCE";

        /// <summary>
        /// OII75CATTY.
        /// </summary>
        public const string OII75CATTY = "OII75CATTY";

        /// <summary>
        /// OII75CATVL.
        /// </summary>
        public const string OII75CATVL = "OII75CATVL";

        /// <summary>
        /// OII75FRC.
        /// </summary>
        public const string OII75FRC = "OII75FRC";

        /// <summary>
        /// OIAN8.
        /// </summary>
        public const string OIAN8 = "OIAN8";

        /// <summary>
        /// OII75IPOS.
        /// </summary>
        public const string OII75IPOS = "OII75IPOS";

        /// <summary>
        /// OII75TRCAT.
        /// </summary>
        public const string OII75TRCAT = "OII75TRCAT";

        /// <summary>
        /// OII75EXCAT.
        /// </summary>
        public const string OII75EXCAT = "OII75EXCAT";

        /// <summary>
        /// OII75MCHFD.
        /// </summary>
        public const string OII75MCHFD = "OII75MCHFD";

        /// <summary>
        /// OII75RECU.
        /// </summary>
        public const string OII75RECU = "OII75RECU";

        /// <summary>
        /// OIAPGM.
        /// </summary>
        public const string OIAPGM = "OIAPGM";

        /// <summary>
        /// OIYFUTDT.
        /// </summary>
        public const string OIYFUTDT = "OIYFUTDT";

        /// <summary>
        /// OIFFU4.
        /// </summary>
        public const string OIFFU4 = "OIFFU4";

        /// <summary>
        /// OIFUT3.
        /// </summary>
        public const string OIFUT3 = "OIFUT3";

        /// <summary>
        /// OIX2.
        /// </summary>
        public const string OIX2 = "OIX2";

        /// <summary>
        /// OIFUTCH1.
        /// </summary>
        public const string OIFUTCH1 = "OIFUTCH1";

        /// <summary>
        /// OIUSER.
        /// </summary>
        public const string OIUSER = "OIUSER";

        /// <summary>
        /// OIPID.
        /// </summary>
        public const string OIPID = "OIPID";

        /// <summary>
        /// OIJOBN.
        /// </summary>
        public const string OIJOBN = "OIJOBN";

        /// <summary>
        /// OIUPMJ.
        /// </summary>
        public const string OIUPMJ = "OIUPMJ";

        /// <summary>
        /// OIUPMT.
        /// </summary>
        public const string OIUPMT = "OIUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI89";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OIJOBS", "OIJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("OIUKID", "OIUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("OIDOC", "OIDOC", JdeDataType.Numeric),
        new JdeField("OIDCT", "OIDCT", JdeDataType.String, 4),
        new JdeField("OIKCO", "OIKCO", JdeDataType.String, 10),
        new JdeField("OISFX", "OISFX", JdeDataType.String, 6),
        new JdeField("OIDOCO", "OIDOCO", JdeDataType.Numeric),
        new JdeField("OIDCTO", "OIDCTO", JdeDataType.String, 4),
        new JdeField("OIKCOO", "OIKCOO", JdeDataType.String, 10),
        new JdeField("OILNID", "OILNID", JdeDataType.Numeric),
        new JdeField("OII75GSTNP", "OII75GSTNP", JdeDataType.String, 50),
        new JdeField("OII75GSTNO", "OII75GSTNO", JdeDataType.String, 50),
        new JdeField("OII75INVNO", "OII75INVNO", JdeDataType.String, 50),
        new JdeField("OIDIVJ", "OIDIVJ", JdeDataType.Numeric),
        new JdeField("OIDGL", "OIDGL", JdeDataType.Numeric),
        new JdeField("OII75INVVL", "OII75INVVL", JdeDataType.Numeric),
        new JdeField("OII75GSTR", "OII75GSTR", JdeDataType.Numeric),
        new JdeField("OII75GSTRA", "OII75GSTRA", JdeDataType.String, 4),
        new JdeField("OIATXA", "OIATXA", JdeDataType.Numeric),
        new JdeField("OII75IGSTA", "OII75IGSTA", JdeDataType.Numeric),
        new JdeField("OII75CGSTA", "OII75CGSTA", JdeDataType.Numeric),
        new JdeField("OII75SGSTA", "OII75SGSTA", JdeDataType.Numeric),
        new JdeField("OII75CESSA", "OII75CESSA", JdeDataType.Numeric),
        new JdeField("OII75AIGST", "OII75AIGST", JdeDataType.Numeric),
        new JdeField("OII75ACGST", "OII75ACGST", JdeDataType.Numeric),
        new JdeField("OII75ASGST", "OII75ASGST", JdeDataType.Numeric),
        new JdeField("OII75ACESS", "OII75ACESS", JdeDataType.Numeric),
        new JdeField("OII75EXTYP", "OII75EXTYP", JdeDataType.String, 10),
        new JdeField("OII75ITCE", "OII75ITCE", JdeDataType.String, 50),
        new JdeField("OII75CATTY", "OII75CATTY", JdeDataType.String, 6),
        new JdeField("OII75CATVL", "OII75CATVL", JdeDataType.String, 40),
        new JdeField("OII75FRC", "OII75FRC", JdeDataType.String, 2),
        new JdeField("OIAN8", "OIAN8", JdeDataType.Numeric),
        new JdeField("OII75IPOS", "OII75IPOS", JdeDataType.String, 4),
        new JdeField("OII75TRCAT", "OII75TRCAT", JdeDataType.String, 4),
        new JdeField("OII75EXCAT", "OII75EXCAT", JdeDataType.String, 4),
        new JdeField("OII75MCHFD", "OII75MCHFD", JdeDataType.String, 2),
        new JdeField("OII75RECU", "OII75RECU", JdeDataType.String, 2),
        new JdeField("OIAPGM", "OIAPGM", JdeDataType.String, 20),
        new JdeField("OIYFUTDT", "OIYFUTDT", JdeDataType.Numeric),
        new JdeField("OIFFU4", "OIFFU4", JdeDataType.Numeric),
        new JdeField("OIFUT3", "OIFUT3", JdeDataType.String, 60),
        new JdeField("OIX2", "OIX2", JdeDataType.String, 2),
        new JdeField("OIFUTCH1", "OIFUTCH1", JdeDataType.String, 2),
        new JdeField("OIUSER", "OIUSER", JdeDataType.String, 20),
        new JdeField("OIPID", "OIPID", JdeDataType.String, 20),
        new JdeField("OIJOBN", "OIJOBN", JdeDataType.String, 20),
        new JdeField("OIUPMJ", "OIUPMJ", JdeDataType.Numeric),
        new JdeField("OIUPMT", "OIUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI89_0", "Primary Key on OIJOBS, OIUKID", new[] { "OIJOBS", "OIUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
