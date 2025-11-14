using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0414Z1 - .
/// </summary>
public class F0414Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZPYID.
        /// </summary>
        public const string SZPYID = "SZPYID";

        /// <summary>
        /// SZRC5.
        /// </summary>
        public const string SZRC5 = "SZRC5";

        /// <summary>
        /// SZDCTM.
        /// </summary>
        public const string SZDCTM = "SZDCTM";

        /// <summary>
        /// SZKCO.
        /// </summary>
        public const string SZKCO = "SZKCO";

        /// <summary>
        /// SZDCT.
        /// </summary>
        public const string SZDCT = "SZDCT";

        /// <summary>
        /// SZDOC.
        /// </summary>
        public const string SZDOC = "SZDOC";

        /// <summary>
        /// SZSFX.
        /// </summary>
        public const string SZSFX = "SZSFX";

        /// <summary>
        /// SZSFXE.
        /// </summary>
        public const string SZSFXE = "SZSFXE";

        /// <summary>
        /// SZPAAP.
        /// </summary>
        public const string SZPAAP = "SZPAAP";

        /// <summary>
        /// SZADSC.
        /// </summary>
        public const string SZADSC = "SZADSC";

        /// <summary>
        /// SZADSA.
        /// </summary>
        public const string SZADSA = "SZADSA";

        /// <summary>
        /// SZPFAP.
        /// </summary>
        public const string SZPFAP = "SZPFAP";

        /// <summary>
        /// SZCDS.
        /// </summary>
        public const string SZCDS = "SZCDS";

        /// <summary>
        /// SZCDSA.
        /// </summary>
        public const string SZCDSA = "SZCDSA";

        /// <summary>
        /// SZCRRM.
        /// </summary>
        public const string SZCRRM = "SZCRRM";

        /// <summary>
        /// SZCRCD.
        /// </summary>
        public const string SZCRCD = "SZCRCD";

        /// <summary>
        /// SZCRR.
        /// </summary>
        public const string SZCRR = "SZCRR";

        /// <summary>
        /// SZGLC.
        /// </summary>
        public const string SZGLC = "SZGLC";

        /// <summary>
        /// SZPOST.
        /// </summary>
        public const string SZPOST = "SZPOST";

        /// <summary>
        /// SZALT6.
        /// </summary>
        public const string SZALT6 = "SZALT6";

        /// <summary>
        /// SZPN.
        /// </summary>
        public const string SZPN = "SZPN";

        /// <summary>
        /// SZFY.
        /// </summary>
        public const string SZFY = "SZFY";

        /// <summary>
        /// SZCTRY.
        /// </summary>
        public const string SZCTRY = "SZCTRY";

        /// <summary>
        /// SZFNLP.
        /// </summary>
        public const string SZFNLP = "SZFNLP";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZCO.
        /// </summary>
        public const string SZCO = "SZCO";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZPO.
        /// </summary>
        public const string SZPO = "SZPO";

        /// <summary>
        /// SZRMK.
        /// </summary>
        public const string SZRMK = "SZRMK";

        /// <summary>
        /// SZHCRR.
        /// </summary>
        public const string SZHCRR = "SZHCRR";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZBCRC.
        /// </summary>
        public const string SZBCRC = "SZBCRC";

        /// <summary>
        /// SZLRFL.
        /// </summary>
        public const string SZLRFL = "SZLRFL";

        /// <summary>
        /// SZGFL7.
        /// </summary>
        public const string SZGFL7 = "SZGFL7";

        /// <summary>
        /// SZGFL8.
        /// </summary>
        public const string SZGFL8 = "SZGFL8";

        /// <summary>
        /// SZGAM3.
        /// </summary>
        public const string SZGAM3 = "SZGAM3";

        /// <summary>
        /// SZGAM4.
        /// </summary>
        public const string SZGAM4 = "SZGAM4";

        /// <summary>
        /// SZGEN6.
        /// </summary>
        public const string SZGEN6 = "SZGEN6";

        /// <summary>
        /// SZGEN7.
        /// </summary>
        public const string SZGEN7 = "SZGEN7";

        /// <summary>
        /// SZDRCO.
        /// </summary>
        public const string SZDRCO = "SZDRCO";

        /// <summary>
        /// SZNETTCID.
        /// </summary>
        public const string SZNETTCID = "SZNETTCID";

        /// <summary>
        /// SZNETDOC.
        /// </summary>
        public const string SZNETDOC = "SZNETDOC";

        /// <summary>
        /// SZNETRC5.
        /// </summary>
        public const string SZNETRC5 = "SZNETRC5";

        /// <summary>
        /// SZCNTRTID.
        /// </summary>
        public const string SZCNTRTID = "SZCNTRTID";

        /// <summary>
        /// SZCNTRTCD.
        /// </summary>
        public const string SZCNTRTCD = "SZCNTRTCD";

        /// <summary>
        /// SZWVID.
        /// </summary>
        public const string SZWVID = "SZWVID";

        /// <summary>
        /// SZBLSCD2.
        /// </summary>
        public const string SZBLSCD2 = "SZBLSCD2";

        /// <summary>
        /// SZHARPER.
        /// </summary>
        public const string SZHARPER = "SZHARPER";

        /// <summary>
        /// SZHARSFX.
        /// </summary>
        public const string SZHARSFX = "SZHARSFX";
    }

    /// <inheritdoc />
    public override string TableName => "F0414Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZPYID", "SZPYID", JdeDataType.Numeric),
        new JdeField("SZRC5", "SZRC5", JdeDataType.Numeric),
        new JdeField("SZDCTM", "SZDCTM", JdeDataType.String, 4),
        new JdeField("SZKCO", "SZKCO", JdeDataType.String, 10),
        new JdeField("SZDCT", "SZDCT", JdeDataType.String, 4),
        new JdeField("SZDOC", "SZDOC", JdeDataType.Numeric),
        new JdeField("SZSFX", "SZSFX", JdeDataType.String, 6),
        new JdeField("SZSFXE", "SZSFXE", JdeDataType.Numeric),
        new JdeField("SZPAAP", "SZPAAP", JdeDataType.Numeric),
        new JdeField("SZADSC", "SZADSC", JdeDataType.Numeric),
        new JdeField("SZADSA", "SZADSA", JdeDataType.Numeric),
        new JdeField("SZPFAP", "SZPFAP", JdeDataType.Numeric),
        new JdeField("SZCDS", "SZCDS", JdeDataType.Numeric),
        new JdeField("SZCDSA", "SZCDSA", JdeDataType.Numeric),
        new JdeField("SZCRRM", "SZCRRM", JdeDataType.String, 2),
        new JdeField("SZCRCD", "SZCRCD", JdeDataType.String, 6),
        new JdeField("SZCRR", "SZCRR", JdeDataType.Numeric),
        new JdeField("SZGLC", "SZGLC", JdeDataType.String, 8),
        new JdeField("SZPOST", "SZPOST", JdeDataType.String, 2),
        new JdeField("SZALT6", "SZALT6", JdeDataType.String, 2),
        new JdeField("SZPN", "SZPN", JdeDataType.Numeric),
        new JdeField("SZFY", "SZFY", JdeDataType.Numeric),
        new JdeField("SZCTRY", "SZCTRY", JdeDataType.Numeric),
        new JdeField("SZFNLP", "SZFNLP", JdeDataType.String, 2),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZCO", "SZCO", JdeDataType.String, 10),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZPO", "SZPO", JdeDataType.String, 16),
        new JdeField("SZRMK", "SZRMK", JdeDataType.String, 60),
        new JdeField("SZHCRR", "SZHCRR", JdeDataType.Numeric),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZBCRC", "SZBCRC", JdeDataType.String, 6),
        new JdeField("SZLRFL", "SZLRFL", JdeDataType.String, 2),
        new JdeField("SZGFL7", "SZGFL7", JdeDataType.String, 2),
        new JdeField("SZGFL8", "SZGFL8", JdeDataType.String, 2),
        new JdeField("SZGAM3", "SZGAM3", JdeDataType.Numeric),
        new JdeField("SZGAM4", "SZGAM4", JdeDataType.Numeric),
        new JdeField("SZGEN6", "SZGEN6", JdeDataType.String, 50),
        new JdeField("SZGEN7", "SZGEN7", JdeDataType.String, 50),
        new JdeField("SZDRCO", "SZDRCO", JdeDataType.String, 6),
        new JdeField("SZNETTCID", "SZNETTCID", JdeDataType.Numeric),
        new JdeField("SZNETDOC", "SZNETDOC", JdeDataType.Numeric),
        new JdeField("SZNETRC5", "SZNETRC5", JdeDataType.Numeric),
        new JdeField("SZCNTRTID", "SZCNTRTID", JdeDataType.Numeric),
        new JdeField("SZCNTRTCD", "SZCNTRTCD", JdeDataType.String, 24),
        new JdeField("SZWVID", "SZWVID", JdeDataType.Numeric),
        new JdeField("SZBLSCD2", "SZBLSCD2", JdeDataType.String, 20),
        new JdeField("SZHARPER", "SZHARPER", JdeDataType.String, 12),
        new JdeField("SZHARSFX", "SZHARSFX", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0414Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0414Z1_2", "Index on SZPYID, SZRC5, SZTNAC, SZDCTM", new[] { "SZPYID", "SZRC5", "SZTNAC", "SZDCTM" })
    };
}
