using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B13 - .
/// </summary>
public class F03B13 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RYPYID.
        /// </summary>
        public const string RYPYID = "RYPYID";

        /// <summary>
        /// RYCKNU.
        /// </summary>
        public const string RYCKNU = "RYCKNU";

        /// <summary>
        /// RYAN8.
        /// </summary>
        public const string RYAN8 = "RYAN8";

        /// <summary>
        /// RYPYR.
        /// </summary>
        public const string RYPYR = "RYPYR";

        /// <summary>
        /// RYDMTJ.
        /// </summary>
        public const string RYDMTJ = "RYDMTJ";

        /// <summary>
        /// RYDGJ.
        /// </summary>
        public const string RYDGJ = "RYDGJ";

        /// <summary>
        /// RYVLDT.
        /// </summary>
        public const string RYVLDT = "RYVLDT";

        /// <summary>
        /// RYPOST.
        /// </summary>
        public const string RYPOST = "RYPOST";

        /// <summary>
        /// RYISTR.
        /// </summary>
        public const string RYISTR = "RYISTR";

        /// <summary>
        /// RYISTC.
        /// </summary>
        public const string RYISTC = "RYISTC";

        /// <summary>
        /// RYEULP.
        /// </summary>
        public const string RYEULP = "RYEULP";

        /// <summary>
        /// RYGLC.
        /// </summary>
        public const string RYGLC = "RYGLC";

        /// <summary>
        /// RYAID.
        /// </summary>
        public const string RYAID = "RYAID";

        /// <summary>
        /// RYCTRY.
        /// </summary>
        public const string RYCTRY = "RYCTRY";

        /// <summary>
        /// RYFY.
        /// </summary>
        public const string RYFY = "RYFY";

        /// <summary>
        /// RYPN.
        /// </summary>
        public const string RYPN = "RYPN";

        /// <summary>
        /// RYCO.
        /// </summary>
        public const string RYCO = "RYCO";

        /// <summary>
        /// RYICUT.
        /// </summary>
        public const string RYICUT = "RYICUT";

        /// <summary>
        /// RYICU.
        /// </summary>
        public const string RYICU = "RYICU";

        /// <summary>
        /// RYDICJ.
        /// </summary>
        public const string RYDICJ = "RYDICJ";

        /// <summary>
        /// RYPA8.
        /// </summary>
        public const string RYPA8 = "RYPA8";

        /// <summary>
        /// RYCKAM.
        /// </summary>
        public const string RYCKAM = "RYCKAM";

        /// <summary>
        /// RYAAP.
        /// </summary>
        public const string RYAAP = "RYAAP";

        /// <summary>
        /// RYBCRC.
        /// </summary>
        public const string RYBCRC = "RYBCRC";

        /// <summary>
        /// RYCRRM.
        /// </summary>
        public const string RYCRRM = "RYCRRM";

        /// <summary>
        /// RYCRCD.
        /// </summary>
        public const string RYCRCD = "RYCRCD";

        /// <summary>
        /// RYCRR.
        /// </summary>
        public const string RYCRR = "RYCRR";

        /// <summary>
        /// RYERDJ.
        /// </summary>
        public const string RYERDJ = "RYERDJ";

        /// <summary>
        /// RYCRCM.
        /// </summary>
        public const string RYCRCM = "RYCRCM";

        /// <summary>
        /// RYCRR1.
        /// </summary>
        public const string RYCRR1 = "RYCRR1";

        /// <summary>
        /// RYCRR2.
        /// </summary>
        public const string RYCRR2 = "RYCRR2";

        /// <summary>
        /// RYFCAM.
        /// </summary>
        public const string RYFCAM = "RYFCAM";

        /// <summary>
        /// RYFAP.
        /// </summary>
        public const string RYFAP = "RYFAP";

        /// <summary>
        /// RYGLBA.
        /// </summary>
        public const string RYGLBA = "RYGLBA";

        /// <summary>
        /// RYAM.
        /// </summary>
        public const string RYAM = "RYAM";

        /// <summary>
        /// RYTYIN.
        /// </summary>
        public const string RYTYIN = "RYTYIN";

        /// <summary>
        /// RYEXR.
        /// </summary>
        public const string RYEXR = "RYEXR";

        /// <summary>
        /// RYALT6.
        /// </summary>
        public const string RYALT6 = "RYALT6";

        /// <summary>
        /// RYRYIN.
        /// </summary>
        public const string RYRYIN = "RYRYIN";

        /// <summary>
        /// RYBKTR.
        /// </summary>
        public const string RYBKTR = "RYBKTR";

        /// <summary>
        /// RYALPH.
        /// </summary>
        public const string RYALPH = "RYALPH";

        /// <summary>
        /// RYDOCG.
        /// </summary>
        public const string RYDOCG = "RYDOCG";

        /// <summary>
        /// RYDCTG.
        /// </summary>
        public const string RYDCTG = "RYDCTG";

        /// <summary>
        /// RYKCOG.
        /// </summary>
        public const string RYKCOG = "RYKCOG";

        /// <summary>
        /// RYVDGJ.
        /// </summary>
        public const string RYVDGJ = "RYVDGJ";

        /// <summary>
        /// RYVRE.
        /// </summary>
        public const string RYVRE = "RYVRE";

        /// <summary>
        /// RYNFVD.
        /// </summary>
        public const string RYNFVD = "RYNFVD";

        /// <summary>
        /// RYDOCQ.
        /// </summary>
        public const string RYDOCQ = "RYDOCQ";

        /// <summary>
        /// RYDCTQ.
        /// </summary>
        public const string RYDCTQ = "RYDCTQ";

        /// <summary>
        /// RYKCOQ.
        /// </summary>
        public const string RYKCOQ = "RYKCOQ";

        /// <summary>
        /// RYICTQ.
        /// </summary>
        public const string RYICTQ = "RYICTQ";

        /// <summary>
        /// RYICUQ.
        /// </summary>
        public const string RYICUQ = "RYICUQ";

        /// <summary>
        /// RYDIQJ.
        /// </summary>
        public const string RYDIQJ = "RYDIQJ";

        /// <summary>
        /// RYPSTQ.
        /// </summary>
        public const string RYPSTQ = "RYPSTQ";

        /// <summary>
        /// RYCBNK.
        /// </summary>
        public const string RYCBNK = "RYCBNK";

        /// <summary>
        /// RYTNST.
        /// </summary>
        public const string RYTNST = "RYTNST";

        /// <summary>
        /// RYDKC.
        /// </summary>
        public const string RYDKC = "RYDKC";

        /// <summary>
        /// RYATCS.
        /// </summary>
        public const string RYATCS = "RYATCS";

        /// <summary>
        /// RYEAAC.
        /// </summary>
        public const string RYEAAC = "RYEAAC";

        /// <summary>
        /// RYEUFB.
        /// </summary>
        public const string RYEUFB = "RYEUFB";

        /// <summary>
        /// RYECLK.
        /// </summary>
        public const string RYECLK = "RYECLK";

        /// <summary>
        /// RYARL.
        /// </summary>
        public const string RYARL = "RYARL";

        /// <summary>
        /// RYARS.
        /// </summary>
        public const string RYARS = "RYARS";

        /// <summary>
        /// RYALGO.
        /// </summary>
        public const string RYALGO = "RYALGO";

        /// <summary>
        /// RYVERS.
        /// </summary>
        public const string RYVERS = "RYVERS";

        /// <summary>
        /// RYASTA.
        /// </summary>
        public const string RYASTA = "RYASTA";

        /// <summary>
        /// RYDDST.
        /// </summary>
        public const string RYDDST = "RYDDST";

        /// <summary>
        /// RYRREF.
        /// </summary>
        public const string RYRREF = "RYRREF";

        /// <summary>
        /// RYRRID.
        /// </summary>
        public const string RYRRID = "RYRRID";

        /// <summary>
        /// RYDCDS.
        /// </summary>
        public const string RYDCDS = "RYDCDS";

        /// <summary>
        /// RYDREG.
        /// </summary>
        public const string RYDREG = "RYDREG";

        /// <summary>
        /// RYURC1.
        /// </summary>
        public const string RYURC1 = "RYURC1";

        /// <summary>
        /// RYURDT.
        /// </summary>
        public const string RYURDT = "RYURDT";

        /// <summary>
        /// RYURAT.
        /// </summary>
        public const string RYURAT = "RYURAT";

        /// <summary>
        /// RYURAB.
        /// </summary>
        public const string RYURAB = "RYURAB";

        /// <summary>
        /// RYURRF.
        /// </summary>
        public const string RYURRF = "RYURRF";

        /// <summary>
        /// RYGFL1.
        /// </summary>
        public const string RYGFL1 = "RYGFL1";

        /// <summary>
        /// RYPRGF.
        /// </summary>
        public const string RYPRGF = "RYPRGF";

        /// <summary>
        /// RYRNID.
        /// </summary>
        public const string RYRNID = "RYRNID";

        /// <summary>
        /// RYCUID.
        /// </summary>
        public const string RYCUID = "RYCUID";

        /// <summary>
        /// RYTORG.
        /// </summary>
        public const string RYTORG = "RYTORG";

        /// <summary>
        /// RYUSER.
        /// </summary>
        public const string RYUSER = "RYUSER";

        /// <summary>
        /// RYPID.
        /// </summary>
        public const string RYPID = "RYPID";

        /// <summary>
        /// RYUPMJ.
        /// </summary>
        public const string RYUPMJ = "RYUPMJ";

        /// <summary>
        /// RYUPMT.
        /// </summary>
        public const string RYUPMT = "RYUPMT";

        /// <summary>
        /// RYJOBN.
        /// </summary>
        public const string RYJOBN = "RYJOBN";

        /// <summary>
        /// RYVFY.
        /// </summary>
        public const string RYVFY = "RYVFY";

        /// <summary>
        /// RYVFP.
        /// </summary>
        public const string RYVFP = "RYVFP";

        /// <summary>
        /// RYVFC.
        /// </summary>
        public const string RYVFC = "RYVFC";

        /// <summary>
        /// RYOMOD.
        /// </summary>
        public const string RYOMOD = "RYOMOD";

        /// <summary>
        /// RYMIP.
        /// </summary>
        public const string RYMIP = "RYMIP";

        /// <summary>
        /// RYLRFL.
        /// </summary>
        public const string RYLRFL = "RYLRFL";

        /// <summary>
        /// RYGFL2.
        /// </summary>
        public const string RYGFL2 = "RYGFL2";

        /// <summary>
        /// RYNETTCID.
        /// </summary>
        public const string RYNETTCID = "RYNETTCID";

        /// <summary>
        /// RYNETDOC.
        /// </summary>
        public const string RYNETDOC = "RYNETDOC";

        /// <summary>
        /// RYRCND.
        /// </summary>
        public const string RYRCND = "RYRCND";

        /// <summary>
        /// RYR3.
        /// </summary>
        public const string RYR3 = "RYR3";
    }

    /// <inheritdoc />
    public override string TableName => "F03B13";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RYPYID", "RYPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RYCKNU", "RYCKNU", JdeDataType.String, 50),
        new JdeField("RYAN8", "RYAN8", JdeDataType.Numeric),
        new JdeField("RYPYR", "RYPYR", JdeDataType.Numeric),
        new JdeField("RYDMTJ", "RYDMTJ", JdeDataType.Numeric),
        new JdeField("RYDGJ", "RYDGJ", JdeDataType.Numeric),
        new JdeField("RYVLDT", "RYVLDT", JdeDataType.Numeric),
        new JdeField("RYPOST", "RYPOST", JdeDataType.String, 2),
        new JdeField("RYISTR", "RYISTR", JdeDataType.String, 2),
        new JdeField("RYISTC", "RYISTC", JdeDataType.String, 2),
        new JdeField("RYEULP", "RYEULP", JdeDataType.String, 2),
        new JdeField("RYGLC", "RYGLC", JdeDataType.String, 8),
        new JdeField("RYAID", "RYAID", JdeDataType.String, 16),
        new JdeField("RYCTRY", "RYCTRY", JdeDataType.Numeric),
        new JdeField("RYFY", "RYFY", JdeDataType.Numeric),
        new JdeField("RYPN", "RYPN", JdeDataType.Numeric),
        new JdeField("RYCO", "RYCO", JdeDataType.String, 10),
        new JdeField("RYICUT", "RYICUT", JdeDataType.String, 4),
        new JdeField("RYICU", "RYICU", JdeDataType.Numeric),
        new JdeField("RYDICJ", "RYDICJ", JdeDataType.Numeric),
        new JdeField("RYPA8", "RYPA8", JdeDataType.Numeric),
        new JdeField("RYCKAM", "RYCKAM", JdeDataType.Numeric),
        new JdeField("RYAAP", "RYAAP", JdeDataType.Numeric),
        new JdeField("RYBCRC", "RYBCRC", JdeDataType.String, 6),
        new JdeField("RYCRRM", "RYCRRM", JdeDataType.String, 2),
        new JdeField("RYCRCD", "RYCRCD", JdeDataType.String, 6),
        new JdeField("RYCRR", "RYCRR", JdeDataType.Numeric),
        new JdeField("RYERDJ", "RYERDJ", JdeDataType.Numeric),
        new JdeField("RYCRCM", "RYCRCM", JdeDataType.String, 2),
        new JdeField("RYCRR1", "RYCRR1", JdeDataType.Numeric),
        new JdeField("RYCRR2", "RYCRR2", JdeDataType.Numeric),
        new JdeField("RYFCAM", "RYFCAM", JdeDataType.Numeric),
        new JdeField("RYFAP", "RYFAP", JdeDataType.Numeric),
        new JdeField("RYGLBA", "RYGLBA", JdeDataType.String, 16),
        new JdeField("RYAM", "RYAM", JdeDataType.String, 2),
        new JdeField("RYTYIN", "RYTYIN", JdeDataType.String, 2),
        new JdeField("RYEXR", "RYEXR", JdeDataType.String, 60),
        new JdeField("RYALT6", "RYALT6", JdeDataType.String, 2),
        new JdeField("RYRYIN", "RYRYIN", JdeDataType.String, 2),
        new JdeField("RYBKTR", "RYBKTR", JdeDataType.String, 16),
        new JdeField("RYALPH", "RYALPH", JdeDataType.String, 80),
        new JdeField("RYDOCG", "RYDOCG", JdeDataType.Numeric),
        new JdeField("RYDCTG", "RYDCTG", JdeDataType.String, 4),
        new JdeField("RYKCOG", "RYKCOG", JdeDataType.String, 10),
        new JdeField("RYVDGJ", "RYVDGJ", JdeDataType.Numeric),
        new JdeField("RYVRE", "RYVRE", JdeDataType.String, 6),
        new JdeField("RYNFVD", "RYNFVD", JdeDataType.String, 2),
        new JdeField("RYDOCQ", "RYDOCQ", JdeDataType.Numeric),
        new JdeField("RYDCTQ", "RYDCTQ", JdeDataType.String, 4),
        new JdeField("RYKCOQ", "RYKCOQ", JdeDataType.String, 10),
        new JdeField("RYICTQ", "RYICTQ", JdeDataType.String, 4),
        new JdeField("RYICUQ", "RYICUQ", JdeDataType.Numeric),
        new JdeField("RYDIQJ", "RYDIQJ", JdeDataType.Numeric),
        new JdeField("RYPSTQ", "RYPSTQ", JdeDataType.String, 2),
        new JdeField("RYCBNK", "RYCBNK", JdeDataType.String, 40),
        new JdeField("RYTNST", "RYTNST", JdeDataType.String, 40),
        new JdeField("RYDKC", "RYDKC", JdeDataType.Numeric),
        new JdeField("RYATCS", "RYATCS", JdeDataType.String, 2),
        new JdeField("RYEAAC", "RYEAAC", JdeDataType.String, 2),
        new JdeField("RYEUFB", "RYEUFB", JdeDataType.String, 2),
        new JdeField("RYECLK", "RYECLK", JdeDataType.String, 20),
        new JdeField("RYARL", "RYARL", JdeDataType.String, 20),
        new JdeField("RYARS", "RYARS", JdeDataType.Numeric),
        new JdeField("RYALGO", "RYALGO", JdeDataType.String, 20),
        new JdeField("RYVERS", "RYVERS", JdeDataType.String, 20),
        new JdeField("RYASTA", "RYASTA", JdeDataType.String, 2),
        new JdeField("RYDDST", "RYDDST", JdeDataType.String, 2),
        new JdeField("RYRREF", "RYRREF", JdeDataType.String, 50),
        new JdeField("RYRRID", "RYRRID", JdeDataType.Numeric),
        new JdeField("RYDCDS", "RYDCDS", JdeDataType.String, 2),
        new JdeField("RYDREG", "RYDREG", JdeDataType.String, 26),
        new JdeField("RYURC1", "RYURC1", JdeDataType.String, 6),
        new JdeField("RYURDT", "RYURDT", JdeDataType.Numeric),
        new JdeField("RYURAT", "RYURAT", JdeDataType.Numeric),
        new JdeField("RYURAB", "RYURAB", JdeDataType.Numeric),
        new JdeField("RYURRF", "RYURRF", JdeDataType.String, 30),
        new JdeField("RYGFL1", "RYGFL1", JdeDataType.String, 2),
        new JdeField("RYPRGF", "RYPRGF", JdeDataType.String, 2),
        new JdeField("RYRNID", "RYRNID", JdeDataType.Numeric),
        new JdeField("RYCUID", "RYCUID", JdeDataType.String, 20),
        new JdeField("RYTORG", "RYTORG", JdeDataType.String, 20),
        new JdeField("RYUSER", "RYUSER", JdeDataType.String, 20),
        new JdeField("RYPID", "RYPID", JdeDataType.String, 20),
        new JdeField("RYUPMJ", "RYUPMJ", JdeDataType.Numeric),
        new JdeField("RYUPMT", "RYUPMT", JdeDataType.Numeric),
        new JdeField("RYJOBN", "RYJOBN", JdeDataType.String, 20),
        new JdeField("RYVFY", "RYVFY", JdeDataType.Numeric),
        new JdeField("RYVFP", "RYVFP", JdeDataType.Numeric),
        new JdeField("RYVFC", "RYVFC", JdeDataType.Numeric),
        new JdeField("RYOMOD", "RYOMOD", JdeDataType.String, 2),
        new JdeField("RYMIP", "RYMIP", JdeDataType.String, 2),
        new JdeField("RYLRFL", "RYLRFL", JdeDataType.String, 2),
        new JdeField("RYGFL2", "RYGFL2", JdeDataType.String, 2),
        new JdeField("RYNETTCID", "RYNETTCID", JdeDataType.Numeric),
        new JdeField("RYNETDOC", "RYNETDOC", JdeDataType.Numeric),
        new JdeField("RYRCND", "RYRCND", JdeDataType.String, 2),
        new JdeField("RYR3", "RYR3", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B13_0", "Primary Key on RYPYID", new[] { "RYPYID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B13_10", "Index on RYNETTCID, RYNETDOC", new[] { "RYNETTCID", "RYNETDOC" }),
        new JdeIndex("F03B13_11", "Index on RYAN8, RYCO, RYDGJ", new[] { "RYAN8", "RYCO", "RYDGJ" }),
        new JdeIndex("F03B13_3", "Index on RYICUT, RYICU, RYPOST, RYPYID", new[] { "RYICUT", "RYICU", "RYPOST", "RYPYID" }),
        new JdeIndex("F03B13_4", "Index on RYDREG, RYDDST, RYPYID", new[] { "RYDREG", "RYDDST", "RYPYID" }),
        new JdeIndex("F03B13_5", "Index on RYPYR, SYS_NC00098$, RYCKNU", new[] { "RYPYR", "SYS_NC00098$", "RYCKNU" }),
        new JdeIndex("F03B13_6", "Index on RYCKNU", new[] { "RYCKNU" }),
        new JdeIndex("F03B13_7", "Index on RYICU, RYCKNU", new[] { "RYICU", "RYCKNU" }),
        new JdeIndex("F03B13_8", "Index on RYAN8, RYCO", new[] { "RYAN8", "RYCO" }),
        new JdeIndex("F03B13_9", "Index on RYAN8, RYCO, RYVDGJ, RYDGJ", new[] { "RYAN8", "RYCO", "RYVDGJ", "RYDGJ" })
    };
}
