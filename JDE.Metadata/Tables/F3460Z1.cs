using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3460Z1 - .
/// </summary>
public class F3460Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FTEDUS.
        /// </summary>
        public const string FTEDUS = "FTEDUS";

        /// <summary>
        /// FTEDBT.
        /// </summary>
        public const string FTEDBT = "FTEDBT";

        /// <summary>
        /// FTEDTN.
        /// </summary>
        public const string FTEDTN = "FTEDTN";

        /// <summary>
        /// FTEDLN.
        /// </summary>
        public const string FTEDLN = "FTEDLN";

        /// <summary>
        /// FTEDCT.
        /// </summary>
        public const string FTEDCT = "FTEDCT";

        /// <summary>
        /// FTTYTN.
        /// </summary>
        public const string FTTYTN = "FTTYTN";

        /// <summary>
        /// FTEDFT.
        /// </summary>
        public const string FTEDFT = "FTEDFT";

        /// <summary>
        /// FTEDDT.
        /// </summary>
        public const string FTEDDT = "FTEDDT";

        /// <summary>
        /// FTDRIN.
        /// </summary>
        public const string FTDRIN = "FTDRIN";

        /// <summary>
        /// FTEDDL.
        /// </summary>
        public const string FTEDDL = "FTEDDL";

        /// <summary>
        /// FTEDSP.
        /// </summary>
        public const string FTEDSP = "FTEDSP";

        /// <summary>
        /// FTPNID.
        /// </summary>
        public const string FTPNID = "FTPNID";

        /// <summary>
        /// FTTNAC.
        /// </summary>
        public const string FTTNAC = "FTTNAC";

        /// <summary>
        /// FTITM.
        /// </summary>
        public const string FTITM = "FTITM";

        /// <summary>
        /// FTLITM.
        /// </summary>
        public const string FTLITM = "FTLITM";

        /// <summary>
        /// FTAITM.
        /// </summary>
        public const string FTAITM = "FTAITM";

        /// <summary>
        /// FTMCU.
        /// </summary>
        public const string FTMCU = "FTMCU";

        /// <summary>
        /// FTDRQJ.
        /// </summary>
        public const string FTDRQJ = "FTDRQJ";

        /// <summary>
        /// FTAN8.
        /// </summary>
        public const string FTAN8 = "FTAN8";

        /// <summary>
        /// FTUORG.
        /// </summary>
        public const string FTUORG = "FTUORG";

        /// <summary>
        /// FTAEXP.
        /// </summary>
        public const string FTAEXP = "FTAEXP";

        /// <summary>
        /// FTFAM.
        /// </summary>
        public const string FTFAM = "FTFAM";

        /// <summary>
        /// FTFQT.
        /// </summary>
        public const string FTFQT = "FTFQT";

        /// <summary>
        /// FTTYPF.
        /// </summary>
        public const string FTTYPF = "FTTYPF";

        /// <summary>
        /// FTDCTO.
        /// </summary>
        public const string FTDCTO = "FTDCTO";

        /// <summary>
        /// FTBPFC.
        /// </summary>
        public const string FTBPFC = "FTBPFC";

        /// <summary>
        /// FTRVIS.
        /// </summary>
        public const string FTRVIS = "FTRVIS";

        /// <summary>
        /// FTURCD.
        /// </summary>
        public const string FTURCD = "FTURCD";

        /// <summary>
        /// FTURDT.
        /// </summary>
        public const string FTURDT = "FTURDT";

        /// <summary>
        /// FTURAT.
        /// </summary>
        public const string FTURAT = "FTURAT";

        /// <summary>
        /// FTURAB.
        /// </summary>
        public const string FTURAB = "FTURAB";

        /// <summary>
        /// FTURRF.
        /// </summary>
        public const string FTURRF = "FTURRF";

        /// <summary>
        /// FTTORG.
        /// </summary>
        public const string FTTORG = "FTTORG";

        /// <summary>
        /// FTUSER.
        /// </summary>
        public const string FTUSER = "FTUSER";

        /// <summary>
        /// FTPID.
        /// </summary>
        public const string FTPID = "FTPID";

        /// <summary>
        /// FTJOBN.
        /// </summary>
        public const string FTJOBN = "FTJOBN";

        /// <summary>
        /// FTUPMJ.
        /// </summary>
        public const string FTUPMJ = "FTUPMJ";

        /// <summary>
        /// FTTDAY.
        /// </summary>
        public const string FTTDAY = "FTTDAY";

        /// <summary>
        /// FTPMPN.
        /// </summary>
        public const string FTPMPN = "FTPMPN";

        /// <summary>
        /// FTPNS.
        /// </summary>
        public const string FTPNS = "FTPNS";
    }

    /// <inheritdoc />
    public override string TableName => "F3460Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FTEDUS", "FTEDUS", JdeDataType.String, 20, true, true),
        new JdeField("FTEDBT", "FTEDBT", JdeDataType.String, 30, true, true),
        new JdeField("FTEDTN", "FTEDTN", JdeDataType.String, 44, true, true),
        new JdeField("FTEDLN", "FTEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("FTEDCT", "FTEDCT", JdeDataType.String, 4),
        new JdeField("FTTYTN", "FTTYTN", JdeDataType.String, 16),
        new JdeField("FTEDFT", "FTEDFT", JdeDataType.String, 20),
        new JdeField("FTEDDT", "FTEDDT", JdeDataType.Numeric),
        new JdeField("FTDRIN", "FTDRIN", JdeDataType.String, 2),
        new JdeField("FTEDDL", "FTEDDL", JdeDataType.Numeric),
        new JdeField("FTEDSP", "FTEDSP", JdeDataType.String, 2),
        new JdeField("FTPNID", "FTPNID", JdeDataType.String, 30),
        new JdeField("FTTNAC", "FTTNAC", JdeDataType.String, 4),
        new JdeField("FTITM", "FTITM", JdeDataType.Numeric),
        new JdeField("FTLITM", "FTLITM", JdeDataType.String, 50),
        new JdeField("FTAITM", "FTAITM", JdeDataType.String, 50),
        new JdeField("FTMCU", "FTMCU", JdeDataType.String, 24),
        new JdeField("FTDRQJ", "FTDRQJ", JdeDataType.Numeric),
        new JdeField("FTAN8", "FTAN8", JdeDataType.Numeric),
        new JdeField("FTUORG", "FTUORG", JdeDataType.Numeric),
        new JdeField("FTAEXP", "FTAEXP", JdeDataType.Numeric),
        new JdeField("FTFAM", "FTFAM", JdeDataType.Numeric),
        new JdeField("FTFQT", "FTFQT", JdeDataType.Numeric),
        new JdeField("FTTYPF", "FTTYPF", JdeDataType.String, 4),
        new JdeField("FTDCTO", "FTDCTO", JdeDataType.String, 4),
        new JdeField("FTBPFC", "FTBPFC", JdeDataType.String, 2),
        new JdeField("FTRVIS", "FTRVIS", JdeDataType.String, 2),
        new JdeField("FTURCD", "FTURCD", JdeDataType.String, 4),
        new JdeField("FTURDT", "FTURDT", JdeDataType.Numeric),
        new JdeField("FTURAT", "FTURAT", JdeDataType.Numeric),
        new JdeField("FTURAB", "FTURAB", JdeDataType.Numeric),
        new JdeField("FTURRF", "FTURRF", JdeDataType.String, 30),
        new JdeField("FTTORG", "FTTORG", JdeDataType.String, 20),
        new JdeField("FTUSER", "FTUSER", JdeDataType.String, 20),
        new JdeField("FTPID", "FTPID", JdeDataType.String, 20),
        new JdeField("FTJOBN", "FTJOBN", JdeDataType.String, 20),
        new JdeField("FTUPMJ", "FTUPMJ", JdeDataType.Numeric),
        new JdeField("FTTDAY", "FTTDAY", JdeDataType.Numeric),
        new JdeField("FTPMPN", "FTPMPN", JdeDataType.String, 60),
        new JdeField("FTPNS", "FTPNS", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3460Z1_0", "Primary Key on FTEDUS, FTEDBT, FTEDTN, FTEDLN", new[] { "FTEDUS", "FTEDBT", "FTEDTN", "FTEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3460Z1_4", "Index on FTEDUS, FTEDBT, FTEDTN, FTEDSP", new[] { "FTEDUS", "FTEDBT", "FTEDTN", "FTEDSP" }),
        new JdeIndex("F3460Z1_5", "Index on FTEDUS, FTEDBT, FTEDSP", new[] { "FTEDUS", "FTEDBT", "FTEDSP" }),
        new JdeIndex("F3460Z1_7", "Index on FTEDUS, FTEDBT, FTEDTN", new[] { "FTEDUS", "FTEDBT", "FTEDTN" }),
        new JdeIndex("F3460Z1_8", "Index on FTEDUS, FTEDBT, FTEDTN, SYS_NC00041$", new[] { "FTEDUS", "FTEDBT", "FTEDTN", "SYS_NC00041$" })
    };
}
