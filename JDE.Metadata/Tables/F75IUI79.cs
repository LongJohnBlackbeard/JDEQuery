using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI79 - .
/// </summary>
public class F75IUI79 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GIJOBS.
        /// </summary>
        public const string GIJOBS = "GIJOBS";

        /// <summary>
        /// GIUKID.
        /// </summary>
        public const string GIUKID = "GIUKID";

        /// <summary>
        /// GIKCOO.
        /// </summary>
        public const string GIKCOO = "GIKCOO";

        /// <summary>
        /// GIDCTO.
        /// </summary>
        public const string GIDCTO = "GIDCTO";

        /// <summary>
        /// GIDOCO.
        /// </summary>
        public const string GIDOCO = "GIDOCO";

        /// <summary>
        /// GILNID.
        /// </summary>
        public const string GILNID = "GILNID";

        /// <summary>
        /// GIKCO.
        /// </summary>
        public const string GIKCO = "GIKCO";

        /// <summary>
        /// GIDCT.
        /// </summary>
        public const string GIDCT = "GIDCT";

        /// <summary>
        /// GIDOC.
        /// </summary>
        public const string GIDOC = "GIDOC";

        /// <summary>
        /// GISFX.
        /// </summary>
        public const string GISFX = "GISFX";

        /// <summary>
        /// GII75INVNO.
        /// </summary>
        public const string GII75INVNO = "GII75INVNO";

        /// <summary>
        /// GII75GSTRA.
        /// </summary>
        public const string GII75GSTRA = "GII75GSTRA";

        /// <summary>
        /// GII75HSNC.
        /// </summary>
        public const string GII75HSNC = "GII75HSNC";

        /// <summary>
        /// GII75GSTNO.
        /// </summary>
        public const string GII75GSTNO = "GII75GSTNO";

        /// <summary>
        /// GII75FRC.
        /// </summary>
        public const string GII75FRC = "GII75FRC";

        /// <summary>
        /// GII75IPOS.
        /// </summary>
        public const string GII75IPOS = "GII75IPOS";

        /// <summary>
        /// GII75INVVL.
        /// </summary>
        public const string GII75INVVL = "GII75INVVL";

        /// <summary>
        /// GIATXA.
        /// </summary>
        public const string GIATXA = "GIATXA";

        /// <summary>
        /// GII75TRCAT.
        /// </summary>
        public const string GII75TRCAT = "GII75TRCAT";

        /// <summary>
        /// GII75CGSTA.
        /// </summary>
        public const string GII75CGSTA = "GII75CGSTA";

        /// <summary>
        /// GII75SGSTA.
        /// </summary>
        public const string GII75SGSTA = "GII75SGSTA";

        /// <summary>
        /// GII75IGSTA.
        /// </summary>
        public const string GII75IGSTA = "GII75IGSTA";

        /// <summary>
        /// GII75CESSA.
        /// </summary>
        public const string GII75CESSA = "GII75CESSA";

        /// <summary>
        /// GII75AIGST.
        /// </summary>
        public const string GII75AIGST = "GII75AIGST";

        /// <summary>
        /// GII75ASGST.
        /// </summary>
        public const string GII75ASGST = "GII75ASGST";

        /// <summary>
        /// GII75ACGST.
        /// </summary>
        public const string GII75ACGST = "GII75ACGST";

        /// <summary>
        /// GII75ACESS.
        /// </summary>
        public const string GII75ACESS = "GII75ACESS";

        /// <summary>
        /// GII75ITCE.
        /// </summary>
        public const string GII75ITCE = "GII75ITCE";

        /// <summary>
        /// GIUOM.
        /// </summary>
        public const string GIUOM = "GIUOM";

        /// <summary>
        /// GIDGL.
        /// </summary>
        public const string GIDGL = "GIDGL";

        /// <summary>
        /// GIAPGM.
        /// </summary>
        public const string GIAPGM = "GIAPGM";

        /// <summary>
        /// GIUSER.
        /// </summary>
        public const string GIUSER = "GIUSER";

        /// <summary>
        /// GIPID.
        /// </summary>
        public const string GIPID = "GIPID";

        /// <summary>
        /// GIJOBN.
        /// </summary>
        public const string GIJOBN = "GIJOBN";

        /// <summary>
        /// GIUPMJ.
        /// </summary>
        public const string GIUPMJ = "GIUPMJ";

        /// <summary>
        /// GIUPMT.
        /// </summary>
        public const string GIUPMT = "GIUPMT";

        /// <summary>
        /// GIYFUTDT1.
        /// </summary>
        public const string GIYFUTDT1 = "GIYFUTDT1";

        /// <summary>
        /// GIFUT6.
        /// </summary>
        public const string GIFUT6 = "GIFUT6";

        /// <summary>
        /// GIYT04.
        /// </summary>
        public const string GIYT04 = "GIYT04";

        /// <summary>
        /// GIYFLAG.
        /// </summary>
        public const string GIYFLAG = "GIYFLAG";

        /// <summary>
        /// GIVINV.
        /// </summary>
        public const string GIVINV = "GIVINV";

        /// <summary>
        /// GIDIVJ.
        /// </summary>
        public const string GIDIVJ = "GIDIVJ";

        /// <summary>
        /// GII75MCHFD.
        /// </summary>
        public const string GII75MCHFD = "GII75MCHFD";

        /// <summary>
        /// GII75RECU.
        /// </summary>
        public const string GII75RECU = "GII75RECU";

        /// <summary>
        /// GII75RMODD.
        /// </summary>
        public const string GII75RMODD = "GII75RMODD";

        /// <summary>
        /// GII75OMODD.
        /// </summary>
        public const string GII75OMODD = "GII75OMODD";

        /// <summary>
        /// GII75GSTND.
        /// </summary>
        public const string GII75GSTND = "GII75GSTND";

        /// <summary>
        /// GII75INVON.
        /// </summary>
        public const string GII75INVON = "GII75INVON";

        /// <summary>
        /// GII75INVOD.
        /// </summary>
        public const string GII75INVOD = "GII75INVOD";

        /// <summary>
        /// GIUREC.
        /// </summary>
        public const string GIUREC = "GIUREC";

        /// <summary>
        /// GII75SERAC.
        /// </summary>
        public const string GII75SERAC = "GII75SERAC";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI79";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GIJOBS", "GIJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GIUKID", "GIUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GIKCOO", "GIKCOO", JdeDataType.String, 10),
        new JdeField("GIDCTO", "GIDCTO", JdeDataType.String, 4),
        new JdeField("GIDOCO", "GIDOCO", JdeDataType.Numeric),
        new JdeField("GILNID", "GILNID", JdeDataType.Numeric),
        new JdeField("GIKCO", "GIKCO", JdeDataType.String, 10),
        new JdeField("GIDCT", "GIDCT", JdeDataType.String, 4),
        new JdeField("GIDOC", "GIDOC", JdeDataType.Numeric),
        new JdeField("GISFX", "GISFX", JdeDataType.String, 6),
        new JdeField("GII75INVNO", "GII75INVNO", JdeDataType.String, 50),
        new JdeField("GII75GSTRA", "GII75GSTRA", JdeDataType.String, 4),
        new JdeField("GII75HSNC", "GII75HSNC", JdeDataType.String, 40),
        new JdeField("GII75GSTNO", "GII75GSTNO", JdeDataType.String, 50),
        new JdeField("GII75FRC", "GII75FRC", JdeDataType.String, 2),
        new JdeField("GII75IPOS", "GII75IPOS", JdeDataType.String, 4),
        new JdeField("GII75INVVL", "GII75INVVL", JdeDataType.Numeric),
        new JdeField("GIATXA", "GIATXA", JdeDataType.Numeric),
        new JdeField("GII75TRCAT", "GII75TRCAT", JdeDataType.String, 4),
        new JdeField("GII75CGSTA", "GII75CGSTA", JdeDataType.Numeric),
        new JdeField("GII75SGSTA", "GII75SGSTA", JdeDataType.Numeric),
        new JdeField("GII75IGSTA", "GII75IGSTA", JdeDataType.Numeric),
        new JdeField("GII75CESSA", "GII75CESSA", JdeDataType.Numeric),
        new JdeField("GII75AIGST", "GII75AIGST", JdeDataType.Numeric),
        new JdeField("GII75ASGST", "GII75ASGST", JdeDataType.Numeric),
        new JdeField("GII75ACGST", "GII75ACGST", JdeDataType.Numeric),
        new JdeField("GII75ACESS", "GII75ACESS", JdeDataType.Numeric),
        new JdeField("GII75ITCE", "GII75ITCE", JdeDataType.String, 50),
        new JdeField("GIUOM", "GIUOM", JdeDataType.String, 4),
        new JdeField("GIDGL", "GIDGL", JdeDataType.Numeric),
        new JdeField("GIAPGM", "GIAPGM", JdeDataType.String, 20),
        new JdeField("GIUSER", "GIUSER", JdeDataType.String, 20),
        new JdeField("GIPID", "GIPID", JdeDataType.String, 20),
        new JdeField("GIJOBN", "GIJOBN", JdeDataType.String, 20),
        new JdeField("GIUPMJ", "GIUPMJ", JdeDataType.Numeric),
        new JdeField("GIUPMT", "GIUPMT", JdeDataType.Numeric),
        new JdeField("GIYFUTDT1", "GIYFUTDT1", JdeDataType.Numeric),
        new JdeField("GIFUT6", "GIFUT6", JdeDataType.String, 60),
        new JdeField("GIYT04", "GIYT04", JdeDataType.String, 2),
        new JdeField("GIYFLAG", "GIYFLAG", JdeDataType.String, 2),
        new JdeField("GIVINV", "GIVINV", JdeDataType.String, 50),
        new JdeField("GIDIVJ", "GIDIVJ", JdeDataType.Numeric),
        new JdeField("GII75MCHFD", "GII75MCHFD", JdeDataType.String, 2),
        new JdeField("GII75RECU", "GII75RECU", JdeDataType.String, 2),
        new JdeField("GII75RMODD", "GII75RMODD", JdeDataType.String, 2),
        new JdeField("GII75OMODD", "GII75OMODD", JdeDataType.String, 2),
        new JdeField("GII75GSTND", "GII75GSTND", JdeDataType.String, 50),
        new JdeField("GII75INVON", "GII75INVON", JdeDataType.String, 50),
        new JdeField("GII75INVOD", "GII75INVOD", JdeDataType.Numeric),
        new JdeField("GIUREC", "GIUREC", JdeDataType.Numeric),
        new JdeField("GII75SERAC", "GII75SERAC", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI79_0", "Primary Key on GIJOBS, GIUKID", new[] { "GIJOBS", "GIUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75IUI79_2", "Index on GIDOC, GIDCT, GIKCO, GIDOCO, GIDCTO, GIKCOO", new[] { "GIDOC", "GIDCT", "GIKCO", "GIDOCO", "GIDCTO", "GIKCOO" })
    };
}
