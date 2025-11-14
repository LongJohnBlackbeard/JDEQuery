using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B18Z1 - .
/// </summary>
public class F31B18Z1 : JdeTable
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
        /// SZWAPRN.
        /// </summary>
        public const string SZWAPRN = "SZWAPRN";

        /// <summary>
        /// SZBARID.
        /// </summary>
        public const string SZBARID = "SZBARID";

        /// <summary>
        /// SZWVID.
        /// </summary>
        public const string SZWVID = "SZWVID";

        /// <summary>
        /// SZWCFTF.
        /// </summary>
        public const string SZWCFTF = "SZWCFTF";

        /// <summary>
        /// SZWV2VLNID.
        /// </summary>
        public const string SZWV2VLNID = "SZWV2VLNID";

        /// <summary>
        /// SZBVST.
        /// </summary>
        public const string SZBVST = "SZBVST";

        /// <summary>
        /// SZRKNMR.
        /// </summary>
        public const string SZRKNMR = "SZRKNMR";

        /// <summary>
        /// SZBRLC.
        /// </summary>
        public const string SZBRLC = "SZBRLC";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURTIME.
        /// </summary>
        public const string SZURTIME = "SZURTIME";

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
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZQTRC.
        /// </summary>
        public const string SZQTRC = "SZQTRC";

        /// <summary>
        /// SZVBTUSEF.
        /// </summary>
        public const string SZVBTUSEF = "SZVBTUSEF";

        /// <summary>
        /// SZCSRLNO.
        /// </summary>
        public const string SZCSRLNO = "SZCSRLNO";

        /// <summary>
        /// SZSNBR.
        /// </summary>
        public const string SZSNBR = "SZSNBR";

        /// <summary>
        /// SZSMPYN.
        /// </summary>
        public const string SZSMPYN = "SZSMPYN";

        /// <summary>
        /// SZSMPSEQ.
        /// </summary>
        public const string SZSMPSEQ = "SZSMPSEQ";
    }

    /// <inheritdoc />
    public override string TableName => "F31B18Z1";

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
        new JdeField("SZWAPRN", "SZWAPRN", JdeDataType.String, 40),
        new JdeField("SZBARID", "SZBARID", JdeDataType.String, 60),
        new JdeField("SZWVID", "SZWVID", JdeDataType.Numeric),
        new JdeField("SZWCFTF", "SZWCFTF", JdeDataType.String, 2),
        new JdeField("SZWV2VLNID", "SZWV2VLNID", JdeDataType.Numeric),
        new JdeField("SZBVST", "SZBVST", JdeDataType.String, 6),
        new JdeField("SZRKNMR", "SZRKNMR", JdeDataType.String, 40),
        new JdeField("SZBRLC", "SZBRLC", JdeDataType.String, 40),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURTIME", "SZURTIME", JdeDataType.Date),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZQTRC", "SZQTRC", JdeDataType.Numeric),
        new JdeField("SZVBTUSEF", "SZVBTUSEF", JdeDataType.String, 2),
        new JdeField("SZCSRLNO", "SZCSRLNO", JdeDataType.String, 30),
        new JdeField("SZSNBR", "SZSNBR", JdeDataType.Numeric),
        new JdeField("SZSMPYN", "SZSMPYN", JdeDataType.String, 2),
        new JdeField("SZSMPSEQ", "SZSMPSEQ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B18Z1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B18Z1_2", "Index on SZWAPRN, SZWV2VLNID, SZEDLN", new[] { "SZWAPRN", "SZWV2VLNID", "SZEDLN" })
    };
}
