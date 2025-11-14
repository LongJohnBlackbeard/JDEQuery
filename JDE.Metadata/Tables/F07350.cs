using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07350 - .
/// </summary>
public class F07350 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y0PAYD.
        /// </summary>
        public const string Y0PAYD = "Y0PAYD";

        /// <summary>
        /// Y0CKCN.
        /// </summary>
        public const string Y0CKCN = "Y0CKCN";

        /// <summary>
        /// Y0AN8.
        /// </summary>
        public const string Y0AN8 = "Y0AN8";

        /// <summary>
        /// Y0ALPH.
        /// </summary>
        public const string Y0ALPH = "Y0ALPH";

        /// <summary>
        /// Y0CO.
        /// </summary>
        public const string Y0CO = "Y0CO";

        /// <summary>
        /// Y0PPED.
        /// </summary>
        public const string Y0PPED = "Y0PPED";

        /// <summary>
        /// Y0ICC.
        /// </summary>
        public const string Y0ICC = "Y0ICC";

        /// <summary>
        /// Y0ICS.
        /// </summary>
        public const string Y0ICS = "Y0ICS";

        /// <summary>
        /// Y0ADF.
        /// </summary>
        public const string Y0ADF = "Y0ADF";

        /// <summary>
        /// Y0HMCO.
        /// </summary>
        public const string Y0HMCO = "Y0HMCO";

        /// <summary>
        /// Y0TAXX.
        /// </summary>
        public const string Y0TAXX = "Y0TAXX";

        /// <summary>
        /// Y0HMCU.
        /// </summary>
        public const string Y0HMCU = "Y0HMCU";

        /// <summary>
        /// Y0GLBA.
        /// </summary>
        public const string Y0GLBA = "Y0GLBA";

        /// <summary>
        /// Y0GLBACK.
        /// </summary>
        public const string Y0GLBACK = "Y0GLBACK";

        /// <summary>
        /// Y0THTY.
        /// </summary>
        public const string Y0THTY = "Y0THTY";

        /// <summary>
        /// Y0P001.
        /// </summary>
        public const string Y0P001 = "Y0P001";

        /// <summary>
        /// Y0P002.
        /// </summary>
        public const string Y0P002 = "Y0P002";

        /// <summary>
        /// Y0P003.
        /// </summary>
        public const string Y0P003 = "Y0P003";

        /// <summary>
        /// Y0P004.
        /// </summary>
        public const string Y0P004 = "Y0P004";

        /// <summary>
        /// Y0GPAY.
        /// </summary>
        public const string Y0GPAY = "Y0GPAY";

        /// <summary>
        /// Y0NPAY.
        /// </summary>
        public const string Y0NPAY = "Y0NPAY";

        /// <summary>
        /// Y0GDED.
        /// </summary>
        public const string Y0GDED = "Y0GDED";

        /// <summary>
        /// Y0GBEN.
        /// </summary>
        public const string Y0GBEN = "Y0GBEN";

        /// <summary>
        /// Y0GTXW.
        /// </summary>
        public const string Y0GTXW = "Y0GTXW";

        /// <summary>
        /// Y0PHRW.
        /// </summary>
        public const string Y0PHRW = "Y0PHRW";

        /// <summary>
        /// Y0SG.
        /// </summary>
        public const string Y0SG = "Y0SG";

        /// <summary>
        /// Y0CBAC.
        /// </summary>
        public const string Y0CBAC = "Y0CBAC";

        /// <summary>
        /// Y0MAIL.
        /// </summary>
        public const string Y0MAIL = "Y0MAIL";

        /// <summary>
        /// Y0ORPI.
        /// </summary>
        public const string Y0ORPI = "Y0ORPI";

        /// <summary>
        /// Y0FUST.
        /// </summary>
        public const string Y0FUST = "Y0FUST";

        /// <summary>
        /// Y0AAF.
        /// </summary>
        public const string Y0AAF = "Y0AAF";

        /// <summary>
        /// Y0DAAF.
        /// </summary>
        public const string Y0DAAF = "Y0DAAF";

        /// <summary>
        /// Y0TFCT.
        /// </summary>
        public const string Y0TFCT = "Y0TFCT";

        /// <summary>
        /// Y0ADV.
        /// </summary>
        public const string Y0ADV = "Y0ADV";

        /// <summary>
        /// Y0PCKN.
        /// </summary>
        public const string Y0PCKN = "Y0PCKN";

        /// <summary>
        /// Y0TXLF.
        /// </summary>
        public const string Y0TXLF = "Y0TXLF";

        /// <summary>
        /// Y0DBLF.
        /// </summary>
        public const string Y0DBLF = "Y0DBLF";

        /// <summary>
        /// Y0MGDF.
        /// </summary>
        public const string Y0MGDF = "Y0MGDF";

        /// <summary>
        /// Y0GTNE.
        /// </summary>
        public const string Y0GTNE = "Y0GTNE";

        /// <summary>
        /// Y0BCB.
        /// </summary>
        public const string Y0BCB = "Y0BCB";

        /// <summary>
        /// Y0PYCB.
        /// </summary>
        public const string Y0PYCB = "Y0PYCB";

        /// <summary>
        /// Y0YST.
        /// </summary>
        public const string Y0YST = "Y0YST";

        /// <summary>
        /// Y0DOCM.
        /// </summary>
        public const string Y0DOCM = "Y0DOCM";

        /// <summary>
        /// Y0CKDT.
        /// </summary>
        public const string Y0CKDT = "Y0CKDT";

        /// <summary>
        /// Y0PACO.
        /// </summary>
        public const string Y0PACO = "Y0PACO";

        /// <summary>
        /// Y0PCK.
        /// </summary>
        public const string Y0PCK = "Y0PCK";

        /// <summary>
        /// Y0UPMJ.
        /// </summary>
        public const string Y0UPMJ = "Y0UPMJ";

        /// <summary>
        /// Y0UPMT.
        /// </summary>
        public const string Y0UPMT = "Y0UPMT";

        /// <summary>
        /// Y0PID.
        /// </summary>
        public const string Y0PID = "Y0PID";

        /// <summary>
        /// Y0JOBN.
        /// </summary>
        public const string Y0JOBN = "Y0JOBN";

        /// <summary>
        /// Y0USER.
        /// </summary>
        public const string Y0USER = "Y0USER";

        /// <summary>
        /// Y0AUBP.
        /// </summary>
        public const string Y0AUBP = "Y0AUBP";
    }

    /// <inheritdoc />
    public override string TableName => "F07350";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y0PAYD", "Y0PAYD", JdeDataType.String, 20, true, true),
        new JdeField("Y0CKCN", "Y0CKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("Y0AN8", "Y0AN8", JdeDataType.Numeric),
        new JdeField("Y0ALPH", "Y0ALPH", JdeDataType.String, 80),
        new JdeField("Y0CO", "Y0CO", JdeDataType.String, 10),
        new JdeField("Y0PPED", "Y0PPED", JdeDataType.Numeric),
        new JdeField("Y0ICC", "Y0ICC", JdeDataType.String, 2),
        new JdeField("Y0ICS", "Y0ICS", JdeDataType.String, 2),
        new JdeField("Y0ADF", "Y0ADF", JdeDataType.String, 2),
        new JdeField("Y0HMCO", "Y0HMCO", JdeDataType.String, 10),
        new JdeField("Y0TAXX", "Y0TAXX", JdeDataType.String, 40),
        new JdeField("Y0HMCU", "Y0HMCU", JdeDataType.String, 24),
        new JdeField("Y0GLBA", "Y0GLBA", JdeDataType.String, 16),
        new JdeField("Y0GLBACK", "Y0GLBACK", JdeDataType.String, 2),
        new JdeField("Y0THTY", "Y0THTY", JdeDataType.String, 2),
        new JdeField("Y0P001", "Y0P001", JdeDataType.String, 6),
        new JdeField("Y0P002", "Y0P002", JdeDataType.String, 6),
        new JdeField("Y0P003", "Y0P003", JdeDataType.String, 6),
        new JdeField("Y0P004", "Y0P004", JdeDataType.String, 6),
        new JdeField("Y0GPAY", "Y0GPAY", JdeDataType.Numeric),
        new JdeField("Y0NPAY", "Y0NPAY", JdeDataType.Numeric),
        new JdeField("Y0GDED", "Y0GDED", JdeDataType.Numeric),
        new JdeField("Y0GBEN", "Y0GBEN", JdeDataType.Numeric),
        new JdeField("Y0GTXW", "Y0GTXW", JdeDataType.Numeric),
        new JdeField("Y0PHRW", "Y0PHRW", JdeDataType.Numeric),
        new JdeField("Y0SG", "Y0SG", JdeDataType.String, 24),
        new JdeField("Y0CBAC", "Y0CBAC", JdeDataType.Numeric),
        new JdeField("Y0MAIL", "Y0MAIL", JdeDataType.String, 20),
        new JdeField("Y0ORPI", "Y0ORPI", JdeDataType.String, 20),
        new JdeField("Y0FUST", "Y0FUST", JdeDataType.String, 2),
        new JdeField("Y0AAF", "Y0AAF", JdeDataType.String, 2),
        new JdeField("Y0DAAF", "Y0DAAF", JdeDataType.String, 2),
        new JdeField("Y0TFCT", "Y0TFCT", JdeDataType.Numeric),
        new JdeField("Y0ADV", "Y0ADV", JdeDataType.String, 2),
        new JdeField("Y0PCKN", "Y0PCKN", JdeDataType.Numeric),
        new JdeField("Y0TXLF", "Y0TXLF", JdeDataType.String, 2),
        new JdeField("Y0DBLF", "Y0DBLF", JdeDataType.String, 2),
        new JdeField("Y0MGDF", "Y0MGDF", JdeDataType.String, 2),
        new JdeField("Y0GTNE", "Y0GTNE", JdeDataType.String, 2),
        new JdeField("Y0BCB", "Y0BCB", JdeDataType.Numeric),
        new JdeField("Y0PYCB", "Y0PYCB", JdeDataType.Numeric),
        new JdeField("Y0YST", "Y0YST", JdeDataType.String, 2),
        new JdeField("Y0DOCM", "Y0DOCM", JdeDataType.Numeric),
        new JdeField("Y0CKDT", "Y0CKDT", JdeDataType.Numeric),
        new JdeField("Y0PACO", "Y0PACO", JdeDataType.String, 2),
        new JdeField("Y0PCK", "Y0PCK", JdeDataType.String, 2),
        new JdeField("Y0UPMJ", "Y0UPMJ", JdeDataType.Numeric),
        new JdeField("Y0UPMT", "Y0UPMT", JdeDataType.Numeric),
        new JdeField("Y0PID", "Y0PID", JdeDataType.String, 20),
        new JdeField("Y0JOBN", "Y0JOBN", JdeDataType.String, 20),
        new JdeField("Y0USER", "Y0USER", JdeDataType.String, 20),
        new JdeField("Y0AUBP", "Y0AUBP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07350_0", "Primary Key on Y0PAYD, Y0CKCN", new[] { "Y0PAYD", "Y0CKCN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07350_3", "Index on Y0AN8", new[] { "Y0AN8" }),
        new JdeIndex("F07350_4", "Index on Y0AN8, Y0CKCN", new[] { "Y0AN8", "Y0CKCN" }),
        new JdeIndex("F07350_5", "Index on Y0PAYD, Y0AN8, Y0PCK, Y0GLBA, Y0TAXX, Y0ICC, Y0ICS", new[] { "Y0PAYD", "Y0AN8", "Y0PCK", "Y0GLBA", "Y0TAXX", "Y0ICC", "Y0ICS" }),
        new JdeIndex("F07350_6", "Index on Y0PAYD, Y0AN8", new[] { "Y0PAYD", "Y0AN8" })
    };
}
