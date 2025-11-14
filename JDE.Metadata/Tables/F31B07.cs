using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B07 - .
/// </summary>
public class F31B07 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EUEURSCD.
        /// </summary>
        public const string EUEURSCD = "EUEURSCD";

        /// <summary>
        /// EUEURID.
        /// </summary>
        public const string EUEURID = "EUEURID";

        /// <summary>
        /// EUEURDSC.
        /// </summary>
        public const string EUEURDSC = "EUEURDSC";

        /// <summary>
        /// EUVINTAG.
        /// </summary>
        public const string EUVINTAG = "EUVINTAG";

        /// <summary>
        /// EUHARPER.
        /// </summary>
        public const string EUHARPER = "EUHARPER";

        /// <summary>
        /// EUPEURID.
        /// </summary>
        public const string EUPEURID = "EUPEURID";

        /// <summary>
        /// EUEURPAR.
        /// </summary>
        public const string EUEURPAR = "EUEURPAR";

        /// <summary>
        /// EUEURPDSC.
        /// </summary>
        public const string EUEURPDSC = "EUEURPDSC";

        /// <summary>
        /// EUEURCAT1.
        /// </summary>
        public const string EUEURCAT1 = "EUEURCAT1";

        /// <summary>
        /// EUEURCAT2.
        /// </summary>
        public const string EUEURCAT2 = "EUEURCAT2";

        /// <summary>
        /// EUEURCAT3.
        /// </summary>
        public const string EUEURCAT3 = "EUEURCAT3";

        /// <summary>
        /// EUEURCAT4.
        /// </summary>
        public const string EUEURCAT4 = "EUEURCAT4";

        /// <summary>
        /// EUEURCAT5.
        /// </summary>
        public const string EUEURCAT5 = "EUEURCAT5";

        /// <summary>
        /// EUEURCAT6.
        /// </summary>
        public const string EUEURCAT6 = "EUEURCAT6";

        /// <summary>
        /// EUEURCAT7.
        /// </summary>
        public const string EUEURCAT7 = "EUEURCAT7";

        /// <summary>
        /// EUEURCAT8.
        /// </summary>
        public const string EUEURCAT8 = "EUEURCAT8";

        /// <summary>
        /// EUEURCAT9.
        /// </summary>
        public const string EUEURCAT9 = "EUEURCAT9";

        /// <summary>
        /// EUEURCAT10.
        /// </summary>
        public const string EUEURCAT10 = "EUEURCAT10";

        /// <summary>
        /// EUBRAND.
        /// </summary>
        public const string EUBRAND = "EUBRAND";

        /// <summary>
        /// EUBRDSC.
        /// </summary>
        public const string EUBRDSC = "EUBRDSC";

        /// <summary>
        /// EUSUBEUR.
        /// </summary>
        public const string EUSUBEUR = "EUSUBEUR";

        /// <summary>
        /// EUEURST.
        /// </summary>
        public const string EUEURST = "EUEURST";

        /// <summary>
        /// EUURCD.
        /// </summary>
        public const string EUURCD = "EUURCD";

        /// <summary>
        /// EUURDT.
        /// </summary>
        public const string EUURDT = "EUURDT";

        /// <summary>
        /// EUURRF.
        /// </summary>
        public const string EUURRF = "EUURRF";

        /// <summary>
        /// EUURAB.
        /// </summary>
        public const string EUURAB = "EUURAB";

        /// <summary>
        /// EUPID.
        /// </summary>
        public const string EUPID = "EUPID";

        /// <summary>
        /// EUUSER.
        /// </summary>
        public const string EUUSER = "EUUSER";

        /// <summary>
        /// EUTDAY.
        /// </summary>
        public const string EUTDAY = "EUTDAY";

        /// <summary>
        /// EUUPMJ.
        /// </summary>
        public const string EUUPMJ = "EUUPMJ";

        /// <summary>
        /// EUJOBN.
        /// </summary>
        public const string EUJOBN = "EUJOBN";

        /// <summary>
        /// EUASTCLS.
        /// </summary>
        public const string EUASTCLS = "EUASTCLS";

        /// <summary>
        /// EUWEURAG.
        /// </summary>
        public const string EUWEURAG = "EUWEURAG";

        /// <summary>
        /// EUWRF.
        /// </summary>
        public const string EUWRF = "EUWRF";

        /// <summary>
        /// EUWCD.
        /// </summary>
        public const string EUWCD = "EUWCD";

        /// <summary>
        /// EUWAB.
        /// </summary>
        public const string EUWAB = "EUWAB";

        /// <summary>
        /// EUWNUM.
        /// </summary>
        public const string EUWNUM = "EUWNUM";

        /// <summary>
        /// EUWMDT.
        /// </summary>
        public const string EUWMDT = "EUWMDT";

        /// <summary>
        /// EUITM.
        /// </summary>
        public const string EUITM = "EUITM";

        /// <summary>
        /// EUMMCU.
        /// </summary>
        public const string EUMMCU = "EUMMCU";

        /// <summary>
        /// EULOCN.
        /// </summary>
        public const string EULOCN = "EULOCN";

        /// <summary>
        /// EULOTN.
        /// </summary>
        public const string EULOTN = "EULOTN";

        /// <summary>
        /// EUPRDNM.
        /// </summary>
        public const string EUPRDNM = "EUPRDNM";

        /// <summary>
        /// EUEURVIN.
        /// </summary>
        public const string EUEURVIN = "EUEURVIN";

        /// <summary>
        /// EUEURPVR.
        /// </summary>
        public const string EUEURPVR = "EUEURPVR";

        /// <summary>
        /// EUEURPAP.
        /// </summary>
        public const string EUEURPAP = "EUEURPAP";

        /// <summary>
        /// EUEURPVI.
        /// </summary>
        public const string EUEURPVI = "EUEURPVI";

        /// <summary>
        /// EUEURPWF.
        /// </summary>
        public const string EUEURPWF = "EUEURPWF";

        /// <summary>
        /// EUEURWT.
        /// </summary>
        public const string EUEURWT = "EUEURWT";

        /// <summary>
        /// EUEURQA.
        /// </summary>
        public const string EUEURQA = "EUEURQA";

        /// <summary>
        /// EUEURSAL.
        /// </summary>
        public const string EUEURSAL = "EUEURSAL";

        /// <summary>
        /// EUEURVER.
        /// </summary>
        public const string EUEURVER = "EUEURVER";

        /// <summary>
        /// EUBMID.
        /// </summary>
        public const string EUBMID = "EUBMID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B07";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EUEURSCD", "EUEURSCD", JdeDataType.String, 20),
        new JdeField("EUEURID", "EUEURID", JdeDataType.Numeric, null, true, true),
        new JdeField("EUEURDSC", "EUEURDSC", JdeDataType.String, 60),
        new JdeField("EUVINTAG", "EUVINTAG", JdeDataType.Numeric),
        new JdeField("EUHARPER", "EUHARPER", JdeDataType.String, 12),
        new JdeField("EUPEURID", "EUPEURID", JdeDataType.Numeric),
        new JdeField("EUEURPAR", "EUEURPAR", JdeDataType.String, 20),
        new JdeField("EUEURPDSC", "EUEURPDSC", JdeDataType.String, 60),
        new JdeField("EUEURCAT1", "EUEURCAT1", JdeDataType.String, 24),
        new JdeField("EUEURCAT2", "EUEURCAT2", JdeDataType.String, 24),
        new JdeField("EUEURCAT3", "EUEURCAT3", JdeDataType.String, 24),
        new JdeField("EUEURCAT4", "EUEURCAT4", JdeDataType.String, 24),
        new JdeField("EUEURCAT5", "EUEURCAT5", JdeDataType.String, 24),
        new JdeField("EUEURCAT6", "EUEURCAT6", JdeDataType.String, 24),
        new JdeField("EUEURCAT7", "EUEURCAT7", JdeDataType.String, 24),
        new JdeField("EUEURCAT8", "EUEURCAT8", JdeDataType.String, 24),
        new JdeField("EUEURCAT9", "EUEURCAT9", JdeDataType.String, 24),
        new JdeField("EUEURCAT10", "EUEURCAT10", JdeDataType.String, 24),
        new JdeField("EUBRAND", "EUBRAND", JdeDataType.String, 20),
        new JdeField("EUBRDSC", "EUBRDSC", JdeDataType.String, 60),
        new JdeField("EUSUBEUR", "EUSUBEUR", JdeDataType.String, 2),
        new JdeField("EUEURST", "EUEURST", JdeDataType.String, 2),
        new JdeField("EUURCD", "EUURCD", JdeDataType.String, 4),
        new JdeField("EUURDT", "EUURDT", JdeDataType.Numeric),
        new JdeField("EUURRF", "EUURRF", JdeDataType.String, 30),
        new JdeField("EUURAB", "EUURAB", JdeDataType.Numeric),
        new JdeField("EUPID", "EUPID", JdeDataType.String, 20),
        new JdeField("EUUSER", "EUUSER", JdeDataType.String, 20),
        new JdeField("EUTDAY", "EUTDAY", JdeDataType.Numeric),
        new JdeField("EUUPMJ", "EUUPMJ", JdeDataType.Numeric),
        new JdeField("EUJOBN", "EUJOBN", JdeDataType.String, 20),
        new JdeField("EUASTCLS", "EUASTCLS", JdeDataType.String, 20),
        new JdeField("EUWEURAG", "EUWEURAG", JdeDataType.String, 24),
        new JdeField("EUWRF", "EUWRF", JdeDataType.String, 60),
        new JdeField("EUWCD", "EUWCD", JdeDataType.String, 6),
        new JdeField("EUWAB", "EUWAB", JdeDataType.Numeric),
        new JdeField("EUWNUM", "EUWNUM", JdeDataType.Numeric),
        new JdeField("EUWMDT", "EUWMDT", JdeDataType.Numeric),
        new JdeField("EUITM", "EUITM", JdeDataType.Numeric),
        new JdeField("EUMMCU", "EUMMCU", JdeDataType.String, 24),
        new JdeField("EULOCN", "EULOCN", JdeDataType.String, 40),
        new JdeField("EULOTN", "EULOTN", JdeDataType.String, 60),
        new JdeField("EUPRDNM", "EUPRDNM", JdeDataType.String, 40),
        new JdeField("EUEURVIN", "EUEURVIN", JdeDataType.String, 2),
        new JdeField("EUEURPVR", "EUEURPVR", JdeDataType.Numeric),
        new JdeField("EUEURPAP", "EUEURPAP", JdeDataType.Numeric),
        new JdeField("EUEURPVI", "EUEURPVI", JdeDataType.Numeric),
        new JdeField("EUEURPWF", "EUEURPWF", JdeDataType.String, 16),
        new JdeField("EUEURWT", "EUEURWT", JdeDataType.String, 6),
        new JdeField("EUEURQA", "EUEURQA", JdeDataType.String, 6),
        new JdeField("EUEURSAL", "EUEURSAL", JdeDataType.String, 2),
        new JdeField("EUEURVER", "EUEURVER", JdeDataType.String, 16),
        new JdeField("EUBMID", "EUBMID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B07_0", "Primary Key on EUEURID", new[] { "EUEURID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B07_2", "Index on EUEURSCD", new[] { "EUEURSCD" }),
        new JdeIndex("F31B07_3", "Index on EUEURPAR", new[] { "EUEURPAR" }),
        new JdeIndex("F31B07_4", "Index on EUEURSCD, EUEURVER", new[] { "EUEURSCD", "EUEURVER" })
    };
}
