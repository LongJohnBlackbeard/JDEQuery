using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI76 - .
/// </summary>
public class F75IUI76 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GBJOBS.
        /// </summary>
        public const string GBJOBS = "GBJOBS";

        /// <summary>
        /// GBUKID.
        /// </summary>
        public const string GBUKID = "GBUKID";

        /// <summary>
        /// GBKCOO.
        /// </summary>
        public const string GBKCOO = "GBKCOO";

        /// <summary>
        /// GBDCTO.
        /// </summary>
        public const string GBDCTO = "GBDCTO";

        /// <summary>
        /// GBDOCO.
        /// </summary>
        public const string GBDOCO = "GBDOCO";

        /// <summary>
        /// GBLNID.
        /// </summary>
        public const string GBLNID = "GBLNID";

        /// <summary>
        /// GBKCO.
        /// </summary>
        public const string GBKCO = "GBKCO";

        /// <summary>
        /// GBDCT.
        /// </summary>
        public const string GBDCT = "GBDCT";

        /// <summary>
        /// GBDOC.
        /// </summary>
        public const string GBDOC = "GBDOC";

        /// <summary>
        /// GBSFX.
        /// </summary>
        public const string GBSFX = "GBSFX";

        /// <summary>
        /// GBI75GSTRA.
        /// </summary>
        public const string GBI75GSTRA = "GBI75GSTRA";

        /// <summary>
        /// GBI75SERAC.
        /// </summary>
        public const string GBI75SERAC = "GBI75SERAC";

        /// <summary>
        /// GBI75HSNC.
        /// </summary>
        public const string GBI75HSNC = "GBI75HSNC";

        /// <summary>
        /// GBI75RECU.
        /// </summary>
        public const string GBI75RECU = "GBI75RECU";

        /// <summary>
        /// GBI75GSTNP.
        /// </summary>
        public const string GBI75GSTNP = "GBI75GSTNP";

        /// <summary>
        /// GBI75FRC.
        /// </summary>
        public const string GBI75FRC = "GBI75FRC";

        /// <summary>
        /// GBI75IPOS.
        /// </summary>
        public const string GBI75IPOS = "GBI75IPOS";

        /// <summary>
        /// GBI75TRCAT.
        /// </summary>
        public const string GBI75TRCAT = "GBI75TRCAT";

        /// <summary>
        /// GBDGL.
        /// </summary>
        public const string GBDGL = "GBDGL";

        /// <summary>
        /// GBI75CGSTA.
        /// </summary>
        public const string GBI75CGSTA = "GBI75CGSTA";

        /// <summary>
        /// GBI75SGSTA.
        /// </summary>
        public const string GBI75SGSTA = "GBI75SGSTA";

        /// <summary>
        /// GBI75IGSTA.
        /// </summary>
        public const string GBI75IGSTA = "GBI75IGSTA";

        /// <summary>
        /// GBI75CESSA.
        /// </summary>
        public const string GBI75CESSA = "GBI75CESSA";

        /// <summary>
        /// GBATXA.
        /// </summary>
        public const string GBATXA = "GBATXA";

        /// <summary>
        /// GBAPGM.
        /// </summary>
        public const string GBAPGM = "GBAPGM";

        /// <summary>
        /// GBUSER.
        /// </summary>
        public const string GBUSER = "GBUSER";

        /// <summary>
        /// GBPID.
        /// </summary>
        public const string GBPID = "GBPID";

        /// <summary>
        /// GBJOBN.
        /// </summary>
        public const string GBJOBN = "GBJOBN";

        /// <summary>
        /// GBUPMJ.
        /// </summary>
        public const string GBUPMJ = "GBUPMJ";

        /// <summary>
        /// GBUPMT.
        /// </summary>
        public const string GBUPMT = "GBUPMT";

        /// <summary>
        /// GBYFUTDT1.
        /// </summary>
        public const string GBYFUTDT1 = "GBYFUTDT1";

        /// <summary>
        /// GBFUT6.
        /// </summary>
        public const string GBFUT6 = "GBFUT6";

        /// <summary>
        /// GBYT04.
        /// </summary>
        public const string GBYT04 = "GBYT04";

        /// <summary>
        /// GBYFLAG.
        /// </summary>
        public const string GBYFLAG = "GBYFLAG";

        /// <summary>
        /// GBI75REVBN.
        /// </summary>
        public const string GBI75REVBN = "GBI75REVBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI76";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GBJOBS", "GBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("GBUKID", "GBUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("GBKCOO", "GBKCOO", JdeDataType.String, 10),
        new JdeField("GBDCTO", "GBDCTO", JdeDataType.String, 4),
        new JdeField("GBDOCO", "GBDOCO", JdeDataType.Numeric),
        new JdeField("GBLNID", "GBLNID", JdeDataType.Numeric),
        new JdeField("GBKCO", "GBKCO", JdeDataType.String, 10),
        new JdeField("GBDCT", "GBDCT", JdeDataType.String, 4),
        new JdeField("GBDOC", "GBDOC", JdeDataType.Numeric),
        new JdeField("GBSFX", "GBSFX", JdeDataType.String, 6),
        new JdeField("GBI75GSTRA", "GBI75GSTRA", JdeDataType.String, 4),
        new JdeField("GBI75SERAC", "GBI75SERAC", JdeDataType.String, 40),
        new JdeField("GBI75HSNC", "GBI75HSNC", JdeDataType.String, 40),
        new JdeField("GBI75RECU", "GBI75RECU", JdeDataType.String, 2),
        new JdeField("GBI75GSTNP", "GBI75GSTNP", JdeDataType.String, 50),
        new JdeField("GBI75FRC", "GBI75FRC", JdeDataType.String, 2),
        new JdeField("GBI75IPOS", "GBI75IPOS", JdeDataType.String, 4),
        new JdeField("GBI75TRCAT", "GBI75TRCAT", JdeDataType.String, 4),
        new JdeField("GBDGL", "GBDGL", JdeDataType.Numeric),
        new JdeField("GBI75CGSTA", "GBI75CGSTA", JdeDataType.Numeric),
        new JdeField("GBI75SGSTA", "GBI75SGSTA", JdeDataType.Numeric),
        new JdeField("GBI75IGSTA", "GBI75IGSTA", JdeDataType.Numeric),
        new JdeField("GBI75CESSA", "GBI75CESSA", JdeDataType.Numeric),
        new JdeField("GBATXA", "GBATXA", JdeDataType.Numeric),
        new JdeField("GBAPGM", "GBAPGM", JdeDataType.String, 20),
        new JdeField("GBUSER", "GBUSER", JdeDataType.String, 20),
        new JdeField("GBPID", "GBPID", JdeDataType.String, 20),
        new JdeField("GBJOBN", "GBJOBN", JdeDataType.String, 20),
        new JdeField("GBUPMJ", "GBUPMJ", JdeDataType.Numeric),
        new JdeField("GBUPMT", "GBUPMT", JdeDataType.Numeric),
        new JdeField("GBYFUTDT1", "GBYFUTDT1", JdeDataType.Numeric),
        new JdeField("GBFUT6", "GBFUT6", JdeDataType.String, 60),
        new JdeField("GBYT04", "GBYT04", JdeDataType.String, 2),
        new JdeField("GBYFLAG", "GBYFLAG", JdeDataType.String, 2),
        new JdeField("GBI75REVBN", "GBI75REVBN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI76_0", "Primary Key on GBJOBS, GBUKID", new[] { "GBJOBS", "GBUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
