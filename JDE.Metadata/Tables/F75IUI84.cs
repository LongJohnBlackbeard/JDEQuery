using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI84 - .
/// </summary>
public class F75IUI84 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GSI75JNUM.
        /// </summary>
        public const string GSI75JNUM = "GSI75JNUM";

        /// <summary>
        /// GSKCOO.
        /// </summary>
        public const string GSKCOO = "GSKCOO";

        /// <summary>
        /// GSDOCO.
        /// </summary>
        public const string GSDOCO = "GSDOCO";

        /// <summary>
        /// GSDCTO.
        /// </summary>
        public const string GSDCTO = "GSDCTO";

        /// <summary>
        /// GSLNID.
        /// </summary>
        public const string GSLNID = "GSLNID";

        /// <summary>
        /// GSI75NINNO.
        /// </summary>
        public const string GSI75NINNO = "GSI75NINNO";

        /// <summary>
        /// GSI75PINNO.
        /// </summary>
        public const string GSI75PINNO = "GSI75PINNO";

        /// <summary>
        /// GSI75NDOC.
        /// </summary>
        public const string GSI75NDOC = "GSI75NDOC";

        /// <summary>
        /// GSI75PDOC.
        /// </summary>
        public const string GSI75PDOC = "GSI75PDOC";

        /// <summary>
        /// GSUITM.
        /// </summary>
        public const string GSUITM = "GSUITM";

        /// <summary>
        /// GSDSC1.
        /// </summary>
        public const string GSDSC1 = "GSDSC1";

        /// <summary>
        /// GSI75NINDT.
        /// </summary>
        public const string GSI75NINDT = "GSI75NINDT";

        /// <summary>
        /// GSI75PINDT.
        /// </summary>
        public const string GSI75PINDT = "GSI75PINDT";

        /// <summary>
        /// GSI75NATXA.
        /// </summary>
        public const string GSI75NATXA = "GSI75NATXA";

        /// <summary>
        /// GSI75PATXA.
        /// </summary>
        public const string GSI75PATXA = "GSI75PATXA";

        /// <summary>
        /// GSI75NSTAM.
        /// </summary>
        public const string GSI75NSTAM = "GSI75NSTAM";

        /// <summary>
        /// GSI75PSTAM.
        /// </summary>
        public const string GSI75PSTAM = "GSI75PSTAM";

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
        /// GSYNUM1.
        /// </summary>
        public const string GSYNUM1 = "GSYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI84";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GSI75JNUM", "GSI75JNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("GSKCOO", "GSKCOO", JdeDataType.String, 10, true, true),
        new JdeField("GSDOCO", "GSDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("GSDCTO", "GSDCTO", JdeDataType.String, 4, true, true),
        new JdeField("GSLNID", "GSLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("GSI75NINNO", "GSI75NINNO", JdeDataType.String, 50),
        new JdeField("GSI75PINNO", "GSI75PINNO", JdeDataType.String, 50),
        new JdeField("GSI75NDOC", "GSI75NDOC", JdeDataType.Numeric),
        new JdeField("GSI75PDOC", "GSI75PDOC", JdeDataType.Numeric),
        new JdeField("GSUITM", "GSUITM", JdeDataType.String, 52),
        new JdeField("GSDSC1", "GSDSC1", JdeDataType.String, 60),
        new JdeField("GSI75NINDT", "GSI75NINDT", JdeDataType.Numeric),
        new JdeField("GSI75PINDT", "GSI75PINDT", JdeDataType.Numeric),
        new JdeField("GSI75NATXA", "GSI75NATXA", JdeDataType.Numeric),
        new JdeField("GSI75PATXA", "GSI75PATXA", JdeDataType.Numeric),
        new JdeField("GSI75NSTAM", "GSI75NSTAM", JdeDataType.Numeric),
        new JdeField("GSI75PSTAM", "GSI75PSTAM", JdeDataType.Numeric),
        new JdeField("GSUSER", "GSUSER", JdeDataType.String, 20),
        new JdeField("GSPID", "GSPID", JdeDataType.String, 20),
        new JdeField("GSJOBN", "GSJOBN", JdeDataType.String, 20),
        new JdeField("GSUPMJ", "GSUPMJ", JdeDataType.Numeric),
        new JdeField("GSUPMT", "GSUPMT", JdeDataType.Numeric),
        new JdeField("GSYFUTDT1", "GSYFUTDT1", JdeDataType.Numeric),
        new JdeField("GSFUT6", "GSFUT6", JdeDataType.String, 60),
        new JdeField("GSYT04", "GSYT04", JdeDataType.String, 2),
        new JdeField("GSYFLAG", "GSYFLAG", JdeDataType.String, 2),
        new JdeField("GSYNUM1", "GSYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI84_0", "Primary Key on GSKCOO, GSDOCO, GSDCTO, GSLNID, GSI75JNUM", new[] { "GSKCOO", "GSDOCO", "GSDCTO", "GSLNID", "GSI75JNUM" }, isUnique: true, isPrimaryKey: true)
    };
}
