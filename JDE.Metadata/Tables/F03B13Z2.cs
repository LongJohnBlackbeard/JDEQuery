using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B13Z2 - .
/// </summary>
public class F03B13Z2 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SYEDUS.
        /// </summary>
        public const string SYEDUS = "SYEDUS";

        /// <summary>
        /// SYEDBT.
        /// </summary>
        public const string SYEDBT = "SYEDBT";

        /// <summary>
        /// SYEDTN.
        /// </summary>
        public const string SYEDTN = "SYEDTN";

        /// <summary>
        /// SYEDLN.
        /// </summary>
        public const string SYEDLN = "SYEDLN";

        /// <summary>
        /// SYEDCT.
        /// </summary>
        public const string SYEDCT = "SYEDCT";

        /// <summary>
        /// SYTYTN.
        /// </summary>
        public const string SYTYTN = "SYTYTN";

        /// <summary>
        /// SYEDFT.
        /// </summary>
        public const string SYEDFT = "SYEDFT";

        /// <summary>
        /// SYEDDT.
        /// </summary>
        public const string SYEDDT = "SYEDDT";

        /// <summary>
        /// SYDRIN.
        /// </summary>
        public const string SYDRIN = "SYDRIN";

        /// <summary>
        /// SYEDDL.
        /// </summary>
        public const string SYEDDL = "SYEDDL";

        /// <summary>
        /// SYEDSP.
        /// </summary>
        public const string SYEDSP = "SYEDSP";

        /// <summary>
        /// SYPNID.
        /// </summary>
        public const string SYPNID = "SYPNID";

        /// <summary>
        /// SYTNAC.
        /// </summary>
        public const string SYTNAC = "SYTNAC";

        /// <summary>
        /// SYPYID.
        /// </summary>
        public const string SYPYID = "SYPYID";

        /// <summary>
        /// SYCKNU.
        /// </summary>
        public const string SYCKNU = "SYCKNU";

        /// <summary>
        /// SYAN8.
        /// </summary>
        public const string SYAN8 = "SYAN8";

        /// <summary>
        /// SYPYR.
        /// </summary>
        public const string SYPYR = "SYPYR";

        /// <summary>
        /// SYDMTJ.
        /// </summary>
        public const string SYDMTJ = "SYDMTJ";

        /// <summary>
        /// SYDGJ.
        /// </summary>
        public const string SYDGJ = "SYDGJ";

        /// <summary>
        /// SYVLDT.
        /// </summary>
        public const string SYVLDT = "SYVLDT";

        /// <summary>
        /// SYPOST.
        /// </summary>
        public const string SYPOST = "SYPOST";

        /// <summary>
        /// SYISTR.
        /// </summary>
        public const string SYISTR = "SYISTR";

        /// <summary>
        /// SYISTC.
        /// </summary>
        public const string SYISTC = "SYISTC";

        /// <summary>
        /// SYEULP.
        /// </summary>
        public const string SYEULP = "SYEULP";

        /// <summary>
        /// SYGLC.
        /// </summary>
        public const string SYGLC = "SYGLC";

        /// <summary>
        /// SYAID.
        /// </summary>
        public const string SYAID = "SYAID";

        /// <summary>
        /// SYCTRY.
        /// </summary>
        public const string SYCTRY = "SYCTRY";

        /// <summary>
        /// SYFY.
        /// </summary>
        public const string SYFY = "SYFY";

        /// <summary>
        /// SYPN.
        /// </summary>
        public const string SYPN = "SYPN";

        /// <summary>
        /// SYCO.
        /// </summary>
        public const string SYCO = "SYCO";

        /// <summary>
        /// SYICUT.
        /// </summary>
        public const string SYICUT = "SYICUT";

        /// <summary>
        /// SYICU.
        /// </summary>
        public const string SYICU = "SYICU";

        /// <summary>
        /// SYDICJ.
        /// </summary>
        public const string SYDICJ = "SYDICJ";

        /// <summary>
        /// SYPA8.
        /// </summary>
        public const string SYPA8 = "SYPA8";

        /// <summary>
        /// SYCKAM.
        /// </summary>
        public const string SYCKAM = "SYCKAM";

        /// <summary>
        /// SYAAP.
        /// </summary>
        public const string SYAAP = "SYAAP";

        /// <summary>
        /// SYBCRC.
        /// </summary>
        public const string SYBCRC = "SYBCRC";

        /// <summary>
        /// SYCRRM.
        /// </summary>
        public const string SYCRRM = "SYCRRM";

        /// <summary>
        /// SYCRCD.
        /// </summary>
        public const string SYCRCD = "SYCRCD";

        /// <summary>
        /// SYCRR.
        /// </summary>
        public const string SYCRR = "SYCRR";

        /// <summary>
        /// SYERDJ.
        /// </summary>
        public const string SYERDJ = "SYERDJ";

        /// <summary>
        /// SYCRCM.
        /// </summary>
        public const string SYCRCM = "SYCRCM";

        /// <summary>
        /// SYCRR1.
        /// </summary>
        public const string SYCRR1 = "SYCRR1";

        /// <summary>
        /// SYCRR2.
        /// </summary>
        public const string SYCRR2 = "SYCRR2";

        /// <summary>
        /// SYFCAM.
        /// </summary>
        public const string SYFCAM = "SYFCAM";

        /// <summary>
        /// SYFAP.
        /// </summary>
        public const string SYFAP = "SYFAP";

        /// <summary>
        /// SYGLBA.
        /// </summary>
        public const string SYGLBA = "SYGLBA";

        /// <summary>
        /// SYAM.
        /// </summary>
        public const string SYAM = "SYAM";

        /// <summary>
        /// SYTYIN.
        /// </summary>
        public const string SYTYIN = "SYTYIN";

        /// <summary>
        /// SYEXR.
        /// </summary>
        public const string SYEXR = "SYEXR";

        /// <summary>
        /// SYALT6.
        /// </summary>
        public const string SYALT6 = "SYALT6";

        /// <summary>
        /// SYRYIN.
        /// </summary>
        public const string SYRYIN = "SYRYIN";

        /// <summary>
        /// SYBKTR.
        /// </summary>
        public const string SYBKTR = "SYBKTR";

        /// <summary>
        /// SYALPH.
        /// </summary>
        public const string SYALPH = "SYALPH";

        /// <summary>
        /// SYDOCG.
        /// </summary>
        public const string SYDOCG = "SYDOCG";

        /// <summary>
        /// SYDCTG.
        /// </summary>
        public const string SYDCTG = "SYDCTG";

        /// <summary>
        /// SYKCOG.
        /// </summary>
        public const string SYKCOG = "SYKCOG";

        /// <summary>
        /// SYVDGJ.
        /// </summary>
        public const string SYVDGJ = "SYVDGJ";

        /// <summary>
        /// SYVRE.
        /// </summary>
        public const string SYVRE = "SYVRE";

        /// <summary>
        /// SYNFVD.
        /// </summary>
        public const string SYNFVD = "SYNFVD";

        /// <summary>
        /// SYDOCQ.
        /// </summary>
        public const string SYDOCQ = "SYDOCQ";

        /// <summary>
        /// SYDCTQ.
        /// </summary>
        public const string SYDCTQ = "SYDCTQ";

        /// <summary>
        /// SYKCOQ.
        /// </summary>
        public const string SYKCOQ = "SYKCOQ";

        /// <summary>
        /// SYICTQ.
        /// </summary>
        public const string SYICTQ = "SYICTQ";

        /// <summary>
        /// SYICUQ.
        /// </summary>
        public const string SYICUQ = "SYICUQ";

        /// <summary>
        /// SYDIQJ.
        /// </summary>
        public const string SYDIQJ = "SYDIQJ";

        /// <summary>
        /// SYPSTQ.
        /// </summary>
        public const string SYPSTQ = "SYPSTQ";

        /// <summary>
        /// SYCBNK.
        /// </summary>
        public const string SYCBNK = "SYCBNK";

        /// <summary>
        /// SYTNST.
        /// </summary>
        public const string SYTNST = "SYTNST";

        /// <summary>
        /// SYDKC.
        /// </summary>
        public const string SYDKC = "SYDKC";

        /// <summary>
        /// SYATCS.
        /// </summary>
        public const string SYATCS = "SYATCS";

        /// <summary>
        /// SYEAAC.
        /// </summary>
        public const string SYEAAC = "SYEAAC";

        /// <summary>
        /// SYEUFB.
        /// </summary>
        public const string SYEUFB = "SYEUFB";

        /// <summary>
        /// SYECLK.
        /// </summary>
        public const string SYECLK = "SYECLK";

        /// <summary>
        /// SYARL.
        /// </summary>
        public const string SYARL = "SYARL";

        /// <summary>
        /// SYARS.
        /// </summary>
        public const string SYARS = "SYARS";

        /// <summary>
        /// SYALGO.
        /// </summary>
        public const string SYALGO = "SYALGO";

        /// <summary>
        /// SYVERS.
        /// </summary>
        public const string SYVERS = "SYVERS";

        /// <summary>
        /// SYASTA.
        /// </summary>
        public const string SYASTA = "SYASTA";

        /// <summary>
        /// SYDDST.
        /// </summary>
        public const string SYDDST = "SYDDST";

        /// <summary>
        /// SYRREF.
        /// </summary>
        public const string SYRREF = "SYRREF";

        /// <summary>
        /// SYRRID.
        /// </summary>
        public const string SYRRID = "SYRRID";

        /// <summary>
        /// SYDCDS.
        /// </summary>
        public const string SYDCDS = "SYDCDS";

        /// <summary>
        /// SYDREG.
        /// </summary>
        public const string SYDREG = "SYDREG";

        /// <summary>
        /// SYGFL1.
        /// </summary>
        public const string SYGFL1 = "SYGFL1";

        /// <summary>
        /// SYPRGF.
        /// </summary>
        public const string SYPRGF = "SYPRGF";

        /// <summary>
        /// SYRNID.
        /// </summary>
        public const string SYRNID = "SYRNID";

        /// <summary>
        /// SYCUID.
        /// </summary>
        public const string SYCUID = "SYCUID";

        /// <summary>
        /// SYURCD.
        /// </summary>
        public const string SYURCD = "SYURCD";

        /// <summary>
        /// SYURDT.
        /// </summary>
        public const string SYURDT = "SYURDT";

        /// <summary>
        /// SYURAT.
        /// </summary>
        public const string SYURAT = "SYURAT";

        /// <summary>
        /// SYURAB.
        /// </summary>
        public const string SYURAB = "SYURAB";

        /// <summary>
        /// SYURRF.
        /// </summary>
        public const string SYURRF = "SYURRF";

        /// <summary>
        /// SYTORG.
        /// </summary>
        public const string SYTORG = "SYTORG";

        /// <summary>
        /// SYUSER.
        /// </summary>
        public const string SYUSER = "SYUSER";

        /// <summary>
        /// SYPID.
        /// </summary>
        public const string SYPID = "SYPID";

        /// <summary>
        /// SYJOBN.
        /// </summary>
        public const string SYJOBN = "SYJOBN";

        /// <summary>
        /// SYUPMJ.
        /// </summary>
        public const string SYUPMJ = "SYUPMJ";

        /// <summary>
        /// SYTDAY.
        /// </summary>
        public const string SYTDAY = "SYTDAY";

        /// <summary>
        /// SYVFY.
        /// </summary>
        public const string SYVFY = "SYVFY";

        /// <summary>
        /// SYVFP.
        /// </summary>
        public const string SYVFP = "SYVFP";

        /// <summary>
        /// SYVFC.
        /// </summary>
        public const string SYVFC = "SYVFC";

        /// <summary>
        /// SYGFL2.
        /// </summary>
        public const string SYGFL2 = "SYGFL2";

        /// <summary>
        /// SYOMOD.
        /// </summary>
        public const string SYOMOD = "SYOMOD";

        /// <summary>
        /// SYLRFL.
        /// </summary>
        public const string SYLRFL = "SYLRFL";

        /// <summary>
        /// SYMIP.
        /// </summary>
        public const string SYMIP = "SYMIP";

        /// <summary>
        /// SYNETTCID.
        /// </summary>
        public const string SYNETTCID = "SYNETTCID";

        /// <summary>
        /// SYNETDOC.
        /// </summary>
        public const string SYNETDOC = "SYNETDOC";

        /// <summary>
        /// SYRCND.
        /// </summary>
        public const string SYRCND = "SYRCND";

        /// <summary>
        /// SYR3.
        /// </summary>
        public const string SYR3 = "SYR3";
    }

    /// <inheritdoc />
    public override string TableName => "F03B13Z2";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SYEDUS", "SYEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SYEDBT", "SYEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SYEDTN", "SYEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SYEDLN", "SYEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SYEDCT", "SYEDCT", JdeDataType.String, 4),
        new JdeField("SYTYTN", "SYTYTN", JdeDataType.String, 16),
        new JdeField("SYEDFT", "SYEDFT", JdeDataType.String, 20),
        new JdeField("SYEDDT", "SYEDDT", JdeDataType.Numeric),
        new JdeField("SYDRIN", "SYDRIN", JdeDataType.String, 2),
        new JdeField("SYEDDL", "SYEDDL", JdeDataType.Numeric),
        new JdeField("SYEDSP", "SYEDSP", JdeDataType.String, 2),
        new JdeField("SYPNID", "SYPNID", JdeDataType.String, 30),
        new JdeField("SYTNAC", "SYTNAC", JdeDataType.String, 4),
        new JdeField("SYPYID", "SYPYID", JdeDataType.Numeric),
        new JdeField("SYCKNU", "SYCKNU", JdeDataType.String, 50),
        new JdeField("SYAN8", "SYAN8", JdeDataType.Numeric),
        new JdeField("SYPYR", "SYPYR", JdeDataType.Numeric),
        new JdeField("SYDMTJ", "SYDMTJ", JdeDataType.Numeric),
        new JdeField("SYDGJ", "SYDGJ", JdeDataType.Numeric),
        new JdeField("SYVLDT", "SYVLDT", JdeDataType.Numeric),
        new JdeField("SYPOST", "SYPOST", JdeDataType.String, 2),
        new JdeField("SYISTR", "SYISTR", JdeDataType.String, 2),
        new JdeField("SYISTC", "SYISTC", JdeDataType.String, 2),
        new JdeField("SYEULP", "SYEULP", JdeDataType.String, 2),
        new JdeField("SYGLC", "SYGLC", JdeDataType.String, 8),
        new JdeField("SYAID", "SYAID", JdeDataType.String, 16),
        new JdeField("SYCTRY", "SYCTRY", JdeDataType.Numeric),
        new JdeField("SYFY", "SYFY", JdeDataType.Numeric),
        new JdeField("SYPN", "SYPN", JdeDataType.Numeric),
        new JdeField("SYCO", "SYCO", JdeDataType.String, 10),
        new JdeField("SYICUT", "SYICUT", JdeDataType.String, 4),
        new JdeField("SYICU", "SYICU", JdeDataType.Numeric),
        new JdeField("SYDICJ", "SYDICJ", JdeDataType.Numeric),
        new JdeField("SYPA8", "SYPA8", JdeDataType.Numeric),
        new JdeField("SYCKAM", "SYCKAM", JdeDataType.Numeric),
        new JdeField("SYAAP", "SYAAP", JdeDataType.Numeric),
        new JdeField("SYBCRC", "SYBCRC", JdeDataType.String, 6),
        new JdeField("SYCRRM", "SYCRRM", JdeDataType.String, 2),
        new JdeField("SYCRCD", "SYCRCD", JdeDataType.String, 6),
        new JdeField("SYCRR", "SYCRR", JdeDataType.Numeric),
        new JdeField("SYERDJ", "SYERDJ", JdeDataType.Numeric),
        new JdeField("SYCRCM", "SYCRCM", JdeDataType.String, 2),
        new JdeField("SYCRR1", "SYCRR1", JdeDataType.Numeric),
        new JdeField("SYCRR2", "SYCRR2", JdeDataType.Numeric),
        new JdeField("SYFCAM", "SYFCAM", JdeDataType.Numeric),
        new JdeField("SYFAP", "SYFAP", JdeDataType.Numeric),
        new JdeField("SYGLBA", "SYGLBA", JdeDataType.String, 16),
        new JdeField("SYAM", "SYAM", JdeDataType.String, 2),
        new JdeField("SYTYIN", "SYTYIN", JdeDataType.String, 2),
        new JdeField("SYEXR", "SYEXR", JdeDataType.String, 60),
        new JdeField("SYALT6", "SYALT6", JdeDataType.String, 2),
        new JdeField("SYRYIN", "SYRYIN", JdeDataType.String, 2),
        new JdeField("SYBKTR", "SYBKTR", JdeDataType.String, 16),
        new JdeField("SYALPH", "SYALPH", JdeDataType.String, 80),
        new JdeField("SYDOCG", "SYDOCG", JdeDataType.Numeric),
        new JdeField("SYDCTG", "SYDCTG", JdeDataType.String, 4),
        new JdeField("SYKCOG", "SYKCOG", JdeDataType.String, 10),
        new JdeField("SYVDGJ", "SYVDGJ", JdeDataType.Numeric),
        new JdeField("SYVRE", "SYVRE", JdeDataType.String, 6),
        new JdeField("SYNFVD", "SYNFVD", JdeDataType.String, 2),
        new JdeField("SYDOCQ", "SYDOCQ", JdeDataType.Numeric),
        new JdeField("SYDCTQ", "SYDCTQ", JdeDataType.String, 4),
        new JdeField("SYKCOQ", "SYKCOQ", JdeDataType.String, 10),
        new JdeField("SYICTQ", "SYICTQ", JdeDataType.String, 4),
        new JdeField("SYICUQ", "SYICUQ", JdeDataType.Numeric),
        new JdeField("SYDIQJ", "SYDIQJ", JdeDataType.Numeric),
        new JdeField("SYPSTQ", "SYPSTQ", JdeDataType.String, 2),
        new JdeField("SYCBNK", "SYCBNK", JdeDataType.String, 40),
        new JdeField("SYTNST", "SYTNST", JdeDataType.String, 40),
        new JdeField("SYDKC", "SYDKC", JdeDataType.Numeric),
        new JdeField("SYATCS", "SYATCS", JdeDataType.String, 2),
        new JdeField("SYEAAC", "SYEAAC", JdeDataType.String, 2),
        new JdeField("SYEUFB", "SYEUFB", JdeDataType.String, 2),
        new JdeField("SYECLK", "SYECLK", JdeDataType.String, 20),
        new JdeField("SYARL", "SYARL", JdeDataType.String, 20),
        new JdeField("SYARS", "SYARS", JdeDataType.Numeric),
        new JdeField("SYALGO", "SYALGO", JdeDataType.String, 20),
        new JdeField("SYVERS", "SYVERS", JdeDataType.String, 20),
        new JdeField("SYASTA", "SYASTA", JdeDataType.String, 2),
        new JdeField("SYDDST", "SYDDST", JdeDataType.String, 2),
        new JdeField("SYRREF", "SYRREF", JdeDataType.String, 50),
        new JdeField("SYRRID", "SYRRID", JdeDataType.Numeric),
        new JdeField("SYDCDS", "SYDCDS", JdeDataType.String, 2),
        new JdeField("SYDREG", "SYDREG", JdeDataType.String, 26),
        new JdeField("SYGFL1", "SYGFL1", JdeDataType.String, 2),
        new JdeField("SYPRGF", "SYPRGF", JdeDataType.String, 2),
        new JdeField("SYRNID", "SYRNID", JdeDataType.Numeric),
        new JdeField("SYCUID", "SYCUID", JdeDataType.String, 20),
        new JdeField("SYURCD", "SYURCD", JdeDataType.String, 4),
        new JdeField("SYURDT", "SYURDT", JdeDataType.Numeric),
        new JdeField("SYURAT", "SYURAT", JdeDataType.Numeric),
        new JdeField("SYURAB", "SYURAB", JdeDataType.Numeric),
        new JdeField("SYURRF", "SYURRF", JdeDataType.String, 30),
        new JdeField("SYTORG", "SYTORG", JdeDataType.String, 20),
        new JdeField("SYUSER", "SYUSER", JdeDataType.String, 20),
        new JdeField("SYPID", "SYPID", JdeDataType.String, 20),
        new JdeField("SYJOBN", "SYJOBN", JdeDataType.String, 20),
        new JdeField("SYUPMJ", "SYUPMJ", JdeDataType.Numeric),
        new JdeField("SYTDAY", "SYTDAY", JdeDataType.Numeric),
        new JdeField("SYVFY", "SYVFY", JdeDataType.Numeric),
        new JdeField("SYVFP", "SYVFP", JdeDataType.Numeric),
        new JdeField("SYVFC", "SYVFC", JdeDataType.Numeric),
        new JdeField("SYGFL2", "SYGFL2", JdeDataType.String, 2),
        new JdeField("SYOMOD", "SYOMOD", JdeDataType.String, 2),
        new JdeField("SYLRFL", "SYLRFL", JdeDataType.String, 2),
        new JdeField("SYMIP", "SYMIP", JdeDataType.String, 2),
        new JdeField("SYNETTCID", "SYNETTCID", JdeDataType.Numeric),
        new JdeField("SYNETDOC", "SYNETDOC", JdeDataType.Numeric),
        new JdeField("SYRCND", "SYRCND", JdeDataType.String, 2),
        new JdeField("SYR3", "SYR3", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B13Z2_0", "Primary Key on SYEDUS, SYEDBT, SYEDTN, SYEDLN", new[] { "SYEDUS", "SYEDBT", "SYEDTN", "SYEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B13Z2_2", "Index on SYPYID", new[] { "SYPYID" })
    };
}
