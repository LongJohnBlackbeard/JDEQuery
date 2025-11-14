using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31BQAZ1 - .
/// </summary>
public class F31BQAZ1 : JdeTable
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
        /// SZWVID.
        /// </summary>
        public const string SZWVID = "SZWVID";

        /// <summary>
        /// SZWFTF.
        /// </summary>
        public const string SZWFTF = "SZWFTF";

        /// <summary>
        /// SZWV2VLNID.
        /// </summary>
        public const string SZWV2VLNID = "SZWV2VLNID";

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
        /// SZWOPID.
        /// </summary>
        public const string SZWOPID = "SZWOPID";

        /// <summary>
        /// SZWOPN.
        /// </summary>
        public const string SZWOPN = "SZWOPN";

        /// <summary>
        /// SZMMCU.
        /// </summary>
        public const string SZMMCU = "SZMMCU";

        /// <summary>
        /// SZQTST.
        /// </summary>
        public const string SZQTST = "SZQTST";

        /// <summary>
        /// SZWQATJDT.
        /// </summary>
        public const string SZWQATJDT = "SZWQATJDT";

        /// <summary>
        /// SZQVAL.
        /// </summary>
        public const string SZQVAL = "SZQVAL";

        /// <summary>
        /// SZWTSTR.
        /// </summary>
        public const string SZWTSTR = "SZWTSTR";

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
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

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
        /// SZSMPCNSL.
        /// </summary>
        public const string SZSMPCNSL = "SZSMPCNSL";

        /// <summary>
        /// SZDLAB.
        /// </summary>
        public const string SZDLAB = "SZDLAB";

        /// <summary>
        /// SZASNBR.
        /// </summary>
        public const string SZASNBR = "SZASNBR";
    }

    /// <inheritdoc />
    public override string TableName => "F31BQAZ1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZWVID", "SZWVID", JdeDataType.Numeric),
        new JdeField("SZWFTF", "SZWFTF", JdeDataType.String, 2),
        new JdeField("SZWV2VLNID", "SZWV2VLNID", JdeDataType.Numeric),
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
        new JdeField("SZWOPID", "SZWOPID", JdeDataType.Numeric),
        new JdeField("SZWOPN", "SZWOPN", JdeDataType.Numeric),
        new JdeField("SZMMCU", "SZMMCU", JdeDataType.String, 24),
        new JdeField("SZQTST", "SZQTST", JdeDataType.String, 50),
        new JdeField("SZWQATJDT", "SZWQATJDT", JdeDataType.Numeric),
        new JdeField("SZQVAL", "SZQVAL", JdeDataType.String, 30),
        new JdeField("SZWTSTR", "SZWTSTR", JdeDataType.String, 60),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZSMPCNSL", "SZSMPCNSL", JdeDataType.String, 4),
        new JdeField("SZDLAB", "SZDLAB", JdeDataType.Numeric),
        new JdeField("SZASNBR", "SZASNBR", JdeDataType.String, 40)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31BQAZ1_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31BQAZ1_11", "Index on SZEDUS, SZEDBT, SZEDTN", new[] { "SZEDUS", "SZEDBT", "SZEDTN" }),
        new JdeIndex("F31BQAZ1_13", "Index on SZEDBT, SZEDTN, SZWAPRN, SZQTST", new[] { "SZEDBT", "SZEDTN", "SZWAPRN", "SZQTST" }),
        new JdeIndex("F31BQAZ1_14", "Index on SZEDUS, SZEDBT, SZEDTN, SYS_NC00038$", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SYS_NC00038$" }),
        new JdeIndex("F31BQAZ1_15", "Index on SZWAPRN, SZEDLN", new[] { "SZWAPRN", "SZEDLN" }),
        new JdeIndex("F31BQAZ1_8", "Index on SZEDUS, SZEDBT, SZEDTN, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDSP" }),
        new JdeIndex("F31BQAZ1_9", "Index on SZEDUS, SZEDBT, SZEDSP", new[] { "SZEDUS", "SZEDBT", "SZEDSP" })
    };
}
