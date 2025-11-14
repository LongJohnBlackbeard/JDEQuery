using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A09 - .
/// </summary>
public class F76A09 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTKCO.
        /// </summary>
        public const string TTKCO = "TTKCO";

        /// <summary>
        /// TTDCT.
        /// </summary>
        public const string TTDCT = "TTDCT";

        /// <summary>
        /// TTDOC.
        /// </summary>
        public const string TTDOC = "TTDOC";

        /// <summary>
        /// TTDCTM.
        /// </summary>
        public const string TTDCTM = "TTDCTM";

        /// <summary>
        /// TTDOCM.
        /// </summary>
        public const string TTDOCM = "TTDOCM";

        /// <summary>
        /// TTCO.
        /// </summary>
        public const string TTCO = "TTCO";

        /// <summary>
        /// TTKCOO.
        /// </summary>
        public const string TTKCOO = "TTKCOO";

        /// <summary>
        /// TTDCTO.
        /// </summary>
        public const string TTDCTO = "TTDCTO";

        /// <summary>
        /// TTDOCO.
        /// </summary>
        public const string TTDOCO = "TTDOCO";

        /// <summary>
        /// TTVINV.
        /// </summary>
        public const string TTVINV = "TTVINV";

        /// <summary>
        /// TTATXA.
        /// </summary>
        public const string TTATXA = "TTATXA";

        /// <summary>
        /// TTATXN.
        /// </summary>
        public const string TTATXN = "TTATXN";

        /// <summary>
        /// TTAG.
        /// </summary>
        public const string TTAG = "TTAG";

        /// <summary>
        /// TTCTXA.
        /// </summary>
        public const string TTCTXA = "TTCTXA";

        /// <summary>
        /// TTCTXN.
        /// </summary>
        public const string TTCTXN = "TTCTXN";

        /// <summary>
        /// TTACR.
        /// </summary>
        public const string TTACR = "TTACR";

        /// <summary>
        /// TTAN8.
        /// </summary>
        public const string TTAN8 = "TTAN8";

        /// <summary>
        /// TTAN8J.
        /// </summary>
        public const string TTAN8J = "TTAN8J";

        /// <summary>
        /// TTADCT.
        /// </summary>
        public const string TTADCT = "TTADCT";

        /// <summary>
        /// TTTAX.
        /// </summary>
        public const string TTTAX = "TTTAX";

        /// <summary>
        /// TTDI#.
        /// </summary>
        public const string TTDI_ = "TTDI#";

        /// <summary>
        /// TTDIY.
        /// </summary>
        public const string TTDIY = "TTDIY";

        /// <summary>
        /// TTDIM.
        /// </summary>
        public const string TTDIM = "TTDIM";

        /// <summary>
        /// TTDID.
        /// </summary>
        public const string TTDID = "TTDID";

        /// <summary>
        /// TTDSV#.
        /// </summary>
        public const string TTDSV_ = "TTDSV#";

        /// <summary>
        /// TTDSVY.
        /// </summary>
        public const string TTDSVY = "TTDSVY";

        /// <summary>
        /// TTDSVM.
        /// </summary>
        public const string TTDSVM = "TTDSVM";

        /// <summary>
        /// TTDSVD.
        /// </summary>
        public const string TTDSVD = "TTDSVD";

        /// <summary>
        /// TTDIVJ.
        /// </summary>
        public const string TTDIVJ = "TTDIVJ";

        /// <summary>
        /// TTDSVJ.
        /// </summary>
        public const string TTDSVJ = "TTDSVJ";

        /// <summary>
        /// TTDGJ.
        /// </summary>
        public const string TTDGJ = "TTDGJ";

        /// <summary>
        /// TTRP1.
        /// </summary>
        public const string TTRP1 = "TTRP1";

        /// <summary>
        /// TTAPIT.
        /// </summary>
        public const string TTAPIT = "TTAPIT";

        /// <summary>
        /// TTAAPI.
        /// </summary>
        public const string TTAAPI = "TTAAPI";

        /// <summary>
        /// TTAPTI.
        /// </summary>
        public const string TTAPTI = "TTAPTI";

        /// <summary>
        /// TTNUMR.
        /// </summary>
        public const string TTNUMR = "TTNUMR";

        /// <summary>
        /// TTAMRY.
        /// </summary>
        public const string TTAMRY = "TTAMRY";

        /// <summary>
        /// TTAC18.
        /// </summary>
        public const string TTAC18 = "TTAC18";

        /// <summary>
        /// TTURRF.
        /// </summary>
        public const string TTURRF = "TTURRF";

        /// <summary>
        /// TTURCD.
        /// </summary>
        public const string TTURCD = "TTURCD";

        /// <summary>
        /// TTURDT.
        /// </summary>
        public const string TTURDT = "TTURDT";

        /// <summary>
        /// TTURAT.
        /// </summary>
        public const string TTURAT = "TTURAT";

        /// <summary>
        /// TTURAB.
        /// </summary>
        public const string TTURAB = "TTURAB";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTJOBN.
        /// </summary>
        public const string TTJOBN = "TTJOBN";

        /// <summary>
        /// TTPRCS.
        /// </summary>
        public const string TTPRCS = "TTPRCS";

        /// <summary>
        /// TTUPMJ.
        /// </summary>
        public const string TTUPMJ = "TTUPMJ";

        /// <summary>
        /// TTTDAY.
        /// </summary>
        public const string TTTDAY = "TTTDAY";

        /// <summary>
        /// TTPFLG.
        /// </summary>
        public const string TTPFLG = "TTPFLG";

        /// <summary>
        /// TTINTY.
        /// </summary>
        public const string TTINTY = "TTINTY";

        /// <summary>
        /// TTDDJ.
        /// </summary>
        public const string TTDDJ = "TTDDJ";

        /// <summary>
        /// TTDD#.
        /// </summary>
        public const string TTDD_ = "TTDD#";

        /// <summary>
        /// TTDDY.
        /// </summary>
        public const string TTDDY = "TTDDY";

        /// <summary>
        /// TTDDM.
        /// </summary>
        public const string TTDDM = "TTDDM";

        /// <summary>
        /// TTDDD.
        /// </summary>
        public const string TTDDD = "TTDDD";

        /// <summary>
        /// TTD4#.
        /// </summary>
        public const string TTD4_ = "TTD4#";

        /// <summary>
        /// TTD4J.
        /// </summary>
        public const string TTD4J = "TTD4J";

        /// <summary>
        /// TTD4Y.
        /// </summary>
        public const string TTD4Y = "TTD4Y";

        /// <summary>
        /// TTD4M.
        /// </summary>
        public const string TTD4M = "TTD4M";

        /// <summary>
        /// TTD4D.
        /// </summary>
        public const string TTD4D = "TTD4D";

        /// <summary>
        /// TTORIG.
        /// </summary>
        public const string TTORIG = "TTORIG";
    }

    /// <inheritdoc />
    public override string TableName => "F76A09";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTKCO", "TTKCO", JdeDataType.String, 10, true, true),
        new JdeField("TTDCT", "TTDCT", JdeDataType.String, 4, true, true),
        new JdeField("TTDOC", "TTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TTDCTM", "TTDCTM", JdeDataType.String, 4, true, true),
        new JdeField("TTDOCM", "TTDOCM", JdeDataType.Numeric, null, true, true),
        new JdeField("TTCO", "TTCO", JdeDataType.String, 10),
        new JdeField("TTKCOO", "TTKCOO", JdeDataType.String, 10),
        new JdeField("TTDCTO", "TTDCTO", JdeDataType.String, 4),
        new JdeField("TTDOCO", "TTDOCO", JdeDataType.Numeric),
        new JdeField("TTVINV", "TTVINV", JdeDataType.String, 50),
        new JdeField("TTATXA", "TTATXA", JdeDataType.Numeric),
        new JdeField("TTATXN", "TTATXN", JdeDataType.Numeric),
        new JdeField("TTAG", "TTAG", JdeDataType.Numeric),
        new JdeField("TTCTXA", "TTCTXA", JdeDataType.Numeric),
        new JdeField("TTCTXN", "TTCTXN", JdeDataType.Numeric),
        new JdeField("TTACR", "TTACR", JdeDataType.Numeric),
        new JdeField("TTAN8", "TTAN8", JdeDataType.Numeric),
        new JdeField("TTAN8J", "TTAN8J", JdeDataType.Numeric),
        new JdeField("TTADCT", "TTADCT", JdeDataType.String, 6),
        new JdeField("TTTAX", "TTTAX", JdeDataType.String, 40),
        new JdeField("TTDI#", "TTDI#", JdeDataType.Numeric),
        new JdeField("TTDIY", "TTDIY", JdeDataType.Numeric),
        new JdeField("TTDIM", "TTDIM", JdeDataType.Numeric),
        new JdeField("TTDID", "TTDID", JdeDataType.Numeric),
        new JdeField("TTDSV#", "TTDSV#", JdeDataType.Numeric),
        new JdeField("TTDSVY", "TTDSVY", JdeDataType.Numeric),
        new JdeField("TTDSVM", "TTDSVM", JdeDataType.Numeric),
        new JdeField("TTDSVD", "TTDSVD", JdeDataType.Numeric),
        new JdeField("TTDIVJ", "TTDIVJ", JdeDataType.Numeric),
        new JdeField("TTDSVJ", "TTDSVJ", JdeDataType.Numeric),
        new JdeField("TTDGJ", "TTDGJ", JdeDataType.Numeric),
        new JdeField("TTRP1", "TTRP1", JdeDataType.String, 2),
        new JdeField("TTAPIT", "TTAPIT", JdeDataType.Numeric),
        new JdeField("TTAAPI", "TTAAPI", JdeDataType.Numeric),
        new JdeField("TTAPTI", "TTAPTI", JdeDataType.String, 4),
        new JdeField("TTNUMR", "TTNUMR", JdeDataType.Numeric),
        new JdeField("TTAMRY", "TTAMRY", JdeDataType.String, 2),
        new JdeField("TTAC18", "TTAC18", JdeDataType.String, 6),
        new JdeField("TTURRF", "TTURRF", JdeDataType.String, 30),
        new JdeField("TTURCD", "TTURCD", JdeDataType.String, 4),
        new JdeField("TTURDT", "TTURDT", JdeDataType.Numeric),
        new JdeField("TTURAT", "TTURAT", JdeDataType.Numeric),
        new JdeField("TTURAB", "TTURAB", JdeDataType.Numeric),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20),
        new JdeField("TTPRCS", "TTPRCS", JdeDataType.String, 2),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTTDAY", "TTTDAY", JdeDataType.Numeric),
        new JdeField("TTPFLG", "TTPFLG", JdeDataType.String, 2),
        new JdeField("TTINTY", "TTINTY", JdeDataType.String, 2),
        new JdeField("TTDDJ", "TTDDJ", JdeDataType.Numeric),
        new JdeField("TTDD#", "TTDD#", JdeDataType.Numeric),
        new JdeField("TTDDY", "TTDDY", JdeDataType.Numeric),
        new JdeField("TTDDM", "TTDDM", JdeDataType.Numeric),
        new JdeField("TTDDD", "TTDDD", JdeDataType.Numeric),
        new JdeField("TTD4#", "TTD4#", JdeDataType.Numeric),
        new JdeField("TTD4J", "TTD4J", JdeDataType.Numeric),
        new JdeField("TTD4Y", "TTD4Y", JdeDataType.Numeric),
        new JdeField("TTD4M", "TTD4M", JdeDataType.Numeric),
        new JdeField("TTD4D", "TTD4D", JdeDataType.Numeric),
        new JdeField("TTORIG", "TTORIG", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A09_0", "Primary Key on TTDOC, TTDCT, TTKCO, TTDCTM, TTDOCM", new[] { "TTDOC", "TTDCT", "TTKCO", "TTDCTM", "TTDOCM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A09_2", "Index on TTDI#, TTDIY, TTDIM, TTDID, TTKCO, TTDCT, TTDOC, TTDCTM, TTDOCM", new[] { "TTDI#", "TTDIY", "TTDIM", "TTDID", "TTKCO", "TTDCT", "TTDOC", "TTDCTM", "TTDOCM" }),
        new JdeIndex("F76A09_3", "Index on TTVINV, TTKCO", new[] { "TTVINV", "TTKCO" })
    };
}
