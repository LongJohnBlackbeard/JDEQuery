using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI99 - .
/// </summary>
public class F75IUI99 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GSJOBS.
        /// </summary>
        public const string GSJOBS = "GSJOBS";

        /// <summary>
        /// GSUKID.
        /// </summary>
        public const string GSUKID = "GSUKID";

        /// <summary>
        /// GSKCOO.
        /// </summary>
        public const string GSKCOO = "GSKCOO";

        /// <summary>
        /// GSDCTO.
        /// </summary>
        public const string GSDCTO = "GSDCTO";

        /// <summary>
        /// GSDOCO.
        /// </summary>
        public const string GSDOCO = "GSDOCO";

        /// <summary>
        /// GSLNID.
        /// </summary>
        public const string GSLNID = "GSLNID";

        /// <summary>
        /// GSKCO.
        /// </summary>
        public const string GSKCO = "GSKCO";

        /// <summary>
        /// GSDCT.
        /// </summary>
        public const string GSDCT = "GSDCT";

        /// <summary>
        /// GSDOC.
        /// </summary>
        public const string GSDOC = "GSDOC";

        /// <summary>
        /// GSSFX.
        /// </summary>
        public const string GSSFX = "GSSFX";

        /// <summary>
        /// GSI75INVNO.
        /// </summary>
        public const string GSI75INVNO = "GSI75INVNO";

        /// <summary>
        /// GSI75GSTRA.
        /// </summary>
        public const string GSI75GSTRA = "GSI75GSTRA";

        /// <summary>
        /// GSI75HSNC.
        /// </summary>
        public const string GSI75HSNC = "GSI75HSNC";

        /// <summary>
        /// GSI75GSTNP.
        /// </summary>
        public const string GSI75GSTNP = "GSI75GSTNP";

        /// <summary>
        /// GSI75FRC.
        /// </summary>
        public const string GSI75FRC = "GSI75FRC";

        /// <summary>
        /// GSI75IPOS.
        /// </summary>
        public const string GSI75IPOS = "GSI75IPOS";

        /// <summary>
        /// GSI75TRCAT.
        /// </summary>
        public const string GSI75TRCAT = "GSI75TRCAT";

        /// <summary>
        /// GSI75EXCAT.
        /// </summary>
        public const string GSI75EXCAT = "GSI75EXCAT";

        /// <summary>
        /// GSI75INVVL.
        /// </summary>
        public const string GSI75INVVL = "GSI75INVVL";

        /// <summary>
        /// GSAPGM.
        /// </summary>
        public const string GSAPGM = "GSAPGM";

        /// <summary>
        /// GSUSER.
        /// </summary>
        public const string GSUSER = "GSUSER";

        /// <summary>
        /// GSPID.
        /// </summary>
        public const string GSPID = "GSPID";

        /// <summary>
        /// GSJOBN.
        /// </summary>
        public const string GSJOBN = "GSJOBN";

        /// <summary>
        /// GSUPMJ.
        /// </summary>
        public const string GSUPMJ = "GSUPMJ";

        /// <summary>
        /// GSUPMT.
        /// </summary>
        public const string GSUPMT = "GSUPMT";

        /// <summary>
        /// GSYFUTDT1.
        /// </summary>
        public const string GSYFUTDT1 = "GSYFUTDT1";

        /// <summary>
        /// GSFUT6.
        /// </summary>
        public const string GSFUT6 = "GSFUT6";

        /// <summary>
        /// GSYT04.
        /// </summary>
        public const string GSYT04 = "GSYT04";

        /// <summary>
        /// GSYFLAG.
        /// </summary>
        public const string GSYFLAG = "GSYFLAG";

        /// <summary>
        /// GSATXA.
        /// </summary>
        public const string GSATXA = "GSATXA";

        /// <summary>
        /// GSI75CGSTA.
        /// </summary>
        public const string GSI75CGSTA = "GSI75CGSTA";

        /// <summary>
        /// GSI75SGSTA.
        /// </summary>
        public const string GSI75SGSTA = "GSI75SGSTA";

        /// <summary>
        /// GSI75IGSTA.
        /// </summary>
        public const string GSI75IGSTA = "GSI75IGSTA";

        /// <summary>
        /// GSI75CESSA.
        /// </summary>
        public const string GSI75CESSA = "GSI75CESSA";

        /// <summary>
        /// GSDGL.
        /// </summary>
        public const string GSDGL = "GSDGL";

        /// <summary>
        /// GSQTYT.
        /// </summary>
        public const string GSQTYT = "GSQTYT";

        /// <summary>
        /// GSUOM.
        /// </summary>
        public const string GSUOM = "GSUOM";

        /// <summary>
        /// GSODOC.
        /// </summary>
        public const string GSODOC = "GSODOC";

        /// <summary>
        /// GSODCT.
        /// </summary>
        public const string GSODCT = "GSODCT";

        /// <summary>
        /// GSOKCO.
        /// </summary>
        public const string GSOKCO = "GSOKCO";

        /// <summary>
        /// GSI75OINVN.
        /// </summary>
        public const string GSI75OINVN = "GSI75OINVN";

        /// <summary>
        /// GSI75OINVD.
        /// </summary>
        public const string GSI75OINVD = "GSI75OINVD";

        /// <summary>
        /// GSI75OINVVL.
        /// </summary>
        public const string GSI75OINVVL = "GSI75OINVVL";

        /// <summary>
        /// GSI75OMODD.
        /// </summary>
        public const string GSI75OMODD = "GSI75OMODD";

        /// <summary>
        /// GSI75RMODD.
        /// </summary>
        public const string GSI75RMODD = "GSI75RMODD";

        /// <summary>
        /// GSI75OGSTP.
        /// </summary>
        public const string GSI75OGSTP = "GSI75OGSTP";

        /// <summary>
        /// GSMT.
        /// </summary>
        public const string GSMT = "GSMT";

        /// <summary>
        /// GSYRM.
        /// </summary>
        public const string GSYRM = "GSYRM";

        /// <summary>
        /// GSVOD.
        /// </summary>
        public const string GSVOD = "GSVOD";

        /// <summary>
        /// GSK74ISPL.
        /// </summary>
        public const string GSK74ISPL = "GSK74ISPL";

        /// <summary>
        /// GSI75RSMT.
        /// </summary>
        public const string GSI75RSMT = "GSI75RSMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI99";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GSJOBS", "GSJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GSUKID", "GSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GSKCOO", "GSKCOO", JdeDataType.String, 10),
        new JdeField("GSDCTO", "GSDCTO", JdeDataType.String, 4),
        new JdeField("GSDOCO", "GSDOCO", JdeDataType.Numeric),
        new JdeField("GSLNID", "GSLNID", JdeDataType.Numeric),
        new JdeField("GSKCO", "GSKCO", JdeDataType.String, 10),
        new JdeField("GSDCT", "GSDCT", JdeDataType.String, 4),
        new JdeField("GSDOC", "GSDOC", JdeDataType.Numeric),
        new JdeField("GSSFX", "GSSFX", JdeDataType.String, 6),
        new JdeField("GSI75INVNO", "GSI75INVNO", JdeDataType.String, 50),
        new JdeField("GSI75GSTRA", "GSI75GSTRA", JdeDataType.String, 4),
        new JdeField("GSI75HSNC", "GSI75HSNC", JdeDataType.String, 40),
        new JdeField("GSI75GSTNP", "GSI75GSTNP", JdeDataType.String, 50),
        new JdeField("GSI75FRC", "GSI75FRC", JdeDataType.String, 2),
        new JdeField("GSI75IPOS", "GSI75IPOS", JdeDataType.String, 4),
        new JdeField("GSI75TRCAT", "GSI75TRCAT", JdeDataType.String, 4),
        new JdeField("GSI75EXCAT", "GSI75EXCAT", JdeDataType.String, 4),
        new JdeField("GSI75INVVL", "GSI75INVVL", JdeDataType.Numeric),
        new JdeField("GSAPGM", "GSAPGM", JdeDataType.String, 20),
        new JdeField("GSUSER", "GSUSER", JdeDataType.String, 20),
        new JdeField("GSPID", "GSPID", JdeDataType.String, 20),
        new JdeField("GSJOBN", "GSJOBN", JdeDataType.String, 20),
        new JdeField("GSUPMJ", "GSUPMJ", JdeDataType.Numeric),
        new JdeField("GSUPMT", "GSUPMT", JdeDataType.Numeric),
        new JdeField("GSYFUTDT1", "GSYFUTDT1", JdeDataType.Numeric),
        new JdeField("GSFUT6", "GSFUT6", JdeDataType.String, 60),
        new JdeField("GSYT04", "GSYT04", JdeDataType.String, 2),
        new JdeField("GSYFLAG", "GSYFLAG", JdeDataType.String, 2),
        new JdeField("GSATXA", "GSATXA", JdeDataType.Numeric),
        new JdeField("GSI75CGSTA", "GSI75CGSTA", JdeDataType.Numeric),
        new JdeField("GSI75SGSTA", "GSI75SGSTA", JdeDataType.Numeric),
        new JdeField("GSI75IGSTA", "GSI75IGSTA", JdeDataType.Numeric),
        new JdeField("GSI75CESSA", "GSI75CESSA", JdeDataType.Numeric),
        new JdeField("GSDGL", "GSDGL", JdeDataType.Numeric),
        new JdeField("GSQTYT", "GSQTYT", JdeDataType.Numeric),
        new JdeField("GSUOM", "GSUOM", JdeDataType.String, 4),
        new JdeField("GSODOC", "GSODOC", JdeDataType.Numeric),
        new JdeField("GSODCT", "GSODCT", JdeDataType.String, 4),
        new JdeField("GSOKCO", "GSOKCO", JdeDataType.String, 10),
        new JdeField("GSI75OINVN", "GSI75OINVN", JdeDataType.String, 50),
        new JdeField("GSI75OINVD", "GSI75OINVD", JdeDataType.Numeric),
        new JdeField("GSI75OINVVL", "GSI75OINVVL", JdeDataType.Numeric),
        new JdeField("GSI75OMODD", "GSI75OMODD", JdeDataType.String, 2),
        new JdeField("GSI75RMODD", "GSI75RMODD", JdeDataType.String, 2),
        new JdeField("GSI75OGSTP", "GSI75OGSTP", JdeDataType.String, 50),
        new JdeField("GSMT", "GSMT", JdeDataType.Numeric),
        new JdeField("GSYRM", "GSYRM", JdeDataType.Numeric),
        new JdeField("GSVOD", "GSVOD", JdeDataType.String, 2),
        new JdeField("GSK74ISPL", "GSK74ISPL", JdeDataType.String, 30),
        new JdeField("GSI75RSMT", "GSI75RSMT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI99_0", "Primary Key on GSJOBS, GSUKID", new[] { "GSJOBS", "GSUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75IUI99_2", "Index on GSKCOO, GSDCTO, GSDOCO, GSKCO, GSDCT, GSDOC", new[] { "GSKCOO", "GSDCTO", "GSDOCO", "GSKCO", "GSDCT", "GSDOC" })
    };
}
