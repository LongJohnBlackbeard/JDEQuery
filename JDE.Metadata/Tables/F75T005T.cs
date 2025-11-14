using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75T005T - .
/// </summary>
public class F75T005T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TD75TTNF.
        /// </summary>
        public const string TD75TTNF = "TD75TTNF";

        /// <summary>
        /// TD75TRAS.
        /// </summary>
        public const string TD75TRAS = "TD75TRAS";

        /// <summary>
        /// TD75TVTT.
        /// </summary>
        public const string TD75TVTT = "TD75TVTT";

        /// <summary>
        /// TD75TYMH.
        /// </summary>
        public const string TD75TYMH = "TD75TYMH";

        /// <summary>
        /// TD75TLID.
        /// </summary>
        public const string TD75TLID = "TD75TLID";

        /// <summary>
        /// TDITM.
        /// </summary>
        public const string TDITM = "TDITM";

        /// <summary>
        /// TDLITM.
        /// </summary>
        public const string TDLITM = "TDLITM";

        /// <summary>
        /// TDAITM.
        /// </summary>
        public const string TDAITM = "TDAITM";

        /// <summary>
        /// TDDSC1.
        /// </summary>
        public const string TDDSC1 = "TDDSC1";

        /// <summary>
        /// TDUOM.
        /// </summary>
        public const string TDUOM = "TDUOM";

        /// <summary>
        /// TDUORG.
        /// </summary>
        public const string TDUORG = "TDUORG";

        /// <summary>
        /// TDTAX1.
        /// </summary>
        public const string TDTAX1 = "TDTAX1";

        /// <summary>
        /// TDEXR1.
        /// </summary>
        public const string TDEXR1 = "TDEXR1";

        /// <summary>
        /// TDTXA1.
        /// </summary>
        public const string TDTXA1 = "TDTXA1";

        /// <summary>
        /// TDBCRC.
        /// </summary>
        public const string TDBCRC = "TDBCRC";

        /// <summary>
        /// TDUPRC.
        /// </summary>
        public const string TDUPRC = "TDUPRC";

        /// <summary>
        /// TDATXA.
        /// </summary>
        public const string TDATXA = "TDATXA";

        /// <summary>
        /// TDSTAM.
        /// </summary>
        public const string TDSTAM = "TDSTAM";

        /// <summary>
        /// TDAAP.
        /// </summary>
        public const string TDAAP = "TDAAP";

        /// <summary>
        /// TDT75ATXA.
        /// </summary>
        public const string TDT75ATXA = "TDT75ATXA";

        /// <summary>
        /// TDT75STAM.
        /// </summary>
        public const string TDT75STAM = "TDT75STAM";

        /// <summary>
        /// TDT75AAP.
        /// </summary>
        public const string TDT75AAP = "TDT75AAP";

        /// <summary>
        /// TDCRCD.
        /// </summary>
        public const string TDCRCD = "TDCRCD";

        /// <summary>
        /// TDCRR.
        /// </summary>
        public const string TDCRR = "TDCRR";

        /// <summary>
        /// TDT75ANTX.
        /// </summary>
        public const string TDT75ANTX = "TDT75ANTX";

        /// <summary>
        /// TDT75FONT.
        /// </summary>
        public const string TDT75FONT = "TDT75FONT";

        /// <summary>
        /// TDT75AONT.
        /// </summary>
        public const string TDT75AONT = "TDT75AONT";

        /// <summary>
        /// TDT75FNTX.
        /// </summary>
        public const string TDT75FNTX = "TDT75FNTX";

        /// <summary>
        /// TDFUP.
        /// </summary>
        public const string TDFUP = "TDFUP";

        /// <summary>
        /// TDCTXA.
        /// </summary>
        public const string TDCTXA = "TDCTXA";

        /// <summary>
        /// TDCTAM.
        /// </summary>
        public const string TDCTAM = "TDCTAM";

        /// <summary>
        /// TDFAP.
        /// </summary>
        public const string TDFAP = "TDFAP";

        /// <summary>
        /// TDT75FOTA.
        /// </summary>
        public const string TDT75FOTA = "TDT75FOTA";

        /// <summary>
        /// TDT75FOTX.
        /// </summary>
        public const string TDT75FOTX = "TDT75FOTX";

        /// <summary>
        /// TDT75FOAP.
        /// </summary>
        public const string TDT75FOAP = "TDT75FOAP";

        /// <summary>
        /// TDKCO.
        /// </summary>
        public const string TDKCO = "TDKCO";

        /// <summary>
        /// TDDCT.
        /// </summary>
        public const string TDDCT = "TDDCT";

        /// <summary>
        /// TDDOC.
        /// </summary>
        public const string TDDOC = "TDDOC";

        /// <summary>
        /// TDJELN.
        /// </summary>
        public const string TDJELN = "TDJELN";

        /// <summary>
        /// TDSFX.
        /// </summary>
        public const string TDSFX = "TDSFX";

        /// <summary>
        /// TDSFXE.
        /// </summary>
        public const string TDSFXE = "TDSFXE";

        /// <summary>
        /// TDKCOO.
        /// </summary>
        public const string TDKCOO = "TDKCOO";

        /// <summary>
        /// TDDCTO.
        /// </summary>
        public const string TDDCTO = "TDDCTO";

        /// <summary>
        /// TDDOCO.
        /// </summary>
        public const string TDDOCO = "TDDOCO";

        /// <summary>
        /// TDSFXO.
        /// </summary>
        public const string TDSFXO = "TDSFXO";

        /// <summary>
        /// TDLNID.
        /// </summary>
        public const string TDLNID = "TDLNID";

        /// <summary>
        /// TD75TTXT.
        /// </summary>
        public const string TD75TTXT = "TD75TTXT";

        /// <summary>
        /// TDURC1.
        /// </summary>
        public const string TDURC1 = "TDURC1";

        /// <summary>
        /// TDURDT.
        /// </summary>
        public const string TDURDT = "TDURDT";

        /// <summary>
        /// TDTDAY.
        /// </summary>
        public const string TDTDAY = "TDTDAY";

        /// <summary>
        /// TDURAT.
        /// </summary>
        public const string TDURAT = "TDURAT";

        /// <summary>
        /// TDURAB.
        /// </summary>
        public const string TDURAB = "TDURAB";

        /// <summary>
        /// TDURRF.
        /// </summary>
        public const string TDURRF = "TDURRF";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUKID.
        /// </summary>
        public const string TDUKID = "TDUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F75T005T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TD75TTNF", "TD75TTNF", JdeDataType.String, 40, true, true),
        new JdeField("TD75TRAS", "TD75TRAS", JdeDataType.Numeric, null, true, true),
        new JdeField("TD75TVTT", "TD75TVTT", JdeDataType.String, 6, true, true),
        new JdeField("TD75TYMH", "TD75TYMH", JdeDataType.Numeric, null, true, true),
        new JdeField("TD75TLID", "TD75TLID", JdeDataType.Numeric, null, true, true),
        new JdeField("TDITM", "TDITM", JdeDataType.Numeric),
        new JdeField("TDLITM", "TDLITM", JdeDataType.String, 50),
        new JdeField("TDAITM", "TDAITM", JdeDataType.String, 50),
        new JdeField("TDDSC1", "TDDSC1", JdeDataType.String, 60),
        new JdeField("TDUOM", "TDUOM", JdeDataType.String, 4),
        new JdeField("TDUORG", "TDUORG", JdeDataType.Numeric),
        new JdeField("TDTAX1", "TDTAX1", JdeDataType.String, 2),
        new JdeField("TDEXR1", "TDEXR1", JdeDataType.String, 4),
        new JdeField("TDTXA1", "TDTXA1", JdeDataType.String, 20),
        new JdeField("TDBCRC", "TDBCRC", JdeDataType.String, 6),
        new JdeField("TDUPRC", "TDUPRC", JdeDataType.Numeric),
        new JdeField("TDATXA", "TDATXA", JdeDataType.Numeric),
        new JdeField("TDSTAM", "TDSTAM", JdeDataType.Numeric),
        new JdeField("TDAAP", "TDAAP", JdeDataType.Numeric),
        new JdeField("TDT75ATXA", "TDT75ATXA", JdeDataType.Numeric),
        new JdeField("TDT75STAM", "TDT75STAM", JdeDataType.Numeric),
        new JdeField("TDT75AAP", "TDT75AAP", JdeDataType.Numeric),
        new JdeField("TDCRCD", "TDCRCD", JdeDataType.String, 6),
        new JdeField("TDCRR", "TDCRR", JdeDataType.Numeric),
        new JdeField("TDT75ANTX", "TDT75ANTX", JdeDataType.Numeric),
        new JdeField("TDT75FONT", "TDT75FONT", JdeDataType.Numeric),
        new JdeField("TDT75AONT", "TDT75AONT", JdeDataType.Numeric),
        new JdeField("TDT75FNTX", "TDT75FNTX", JdeDataType.Numeric),
        new JdeField("TDFUP", "TDFUP", JdeDataType.Numeric),
        new JdeField("TDCTXA", "TDCTXA", JdeDataType.Numeric),
        new JdeField("TDCTAM", "TDCTAM", JdeDataType.Numeric),
        new JdeField("TDFAP", "TDFAP", JdeDataType.Numeric),
        new JdeField("TDT75FOTA", "TDT75FOTA", JdeDataType.Numeric),
        new JdeField("TDT75FOTX", "TDT75FOTX", JdeDataType.Numeric),
        new JdeField("TDT75FOAP", "TDT75FOAP", JdeDataType.Numeric),
        new JdeField("TDKCO", "TDKCO", JdeDataType.String, 10),
        new JdeField("TDDCT", "TDDCT", JdeDataType.String, 4),
        new JdeField("TDDOC", "TDDOC", JdeDataType.Numeric),
        new JdeField("TDJELN", "TDJELN", JdeDataType.Numeric),
        new JdeField("TDSFX", "TDSFX", JdeDataType.String, 6),
        new JdeField("TDSFXE", "TDSFXE", JdeDataType.Numeric),
        new JdeField("TDKCOO", "TDKCOO", JdeDataType.String, 10),
        new JdeField("TDDCTO", "TDDCTO", JdeDataType.String, 4),
        new JdeField("TDDOCO", "TDDOCO", JdeDataType.Numeric),
        new JdeField("TDSFXO", "TDSFXO", JdeDataType.String, 6),
        new JdeField("TDLNID", "TDLNID", JdeDataType.Numeric),
        new JdeField("TD75TTXT", "TD75TTXT", JdeDataType.String, 2),
        new JdeField("TDURC1", "TDURC1", JdeDataType.String, 6),
        new JdeField("TDURDT", "TDURDT", JdeDataType.Numeric),
        new JdeField("TDTDAY", "TDTDAY", JdeDataType.Numeric),
        new JdeField("TDURAT", "TDURAT", JdeDataType.Numeric),
        new JdeField("TDURAB", "TDURAB", JdeDataType.Numeric),
        new JdeField("TDURRF", "TDURRF", JdeDataType.String, 30),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUKID", "TDUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75T005T_0", "Primary Key on TD75TTNF, TD75TRAS, TD75TYMH, TD75TVTT, TD75TLID, TDUKID", new[] { "TD75TTNF", "TD75TRAS", "TD75TYMH", "TD75TVTT", "TD75TLID", "TDUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75T005T_2", "Index on TDKCOO, TDDCTO, TDDOCO, TDLNID", new[] { "TDKCOO", "TDDCTO", "TDDOCO", "TDLNID" })
    };
}
