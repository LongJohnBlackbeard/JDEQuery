using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1512Z1 - .
/// </summary>
public class F1512Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCEDUS.
        /// </summary>
        public const string BCEDUS = "BCEDUS";

        /// <summary>
        /// BCEDBT.
        /// </summary>
        public const string BCEDBT = "BCEDBT";

        /// <summary>
        /// BCEDTN.
        /// </summary>
        public const string BCEDTN = "BCEDTN";

        /// <summary>
        /// BCEDLN.
        /// </summary>
        public const string BCEDLN = "BCEDLN";

        /// <summary>
        /// BCEDCT.
        /// </summary>
        public const string BCEDCT = "BCEDCT";

        /// <summary>
        /// BCTYTN.
        /// </summary>
        public const string BCTYTN = "BCTYTN";

        /// <summary>
        /// BCEDFT.
        /// </summary>
        public const string BCEDFT = "BCEDFT";

        /// <summary>
        /// BCEDDT.
        /// </summary>
        public const string BCEDDT = "BCEDDT";

        /// <summary>
        /// BCDRIN.
        /// </summary>
        public const string BCDRIN = "BCDRIN";

        /// <summary>
        /// BCEDDL.
        /// </summary>
        public const string BCEDDL = "BCEDDL";

        /// <summary>
        /// BCEDSP.
        /// </summary>
        public const string BCEDSP = "BCEDSP";

        /// <summary>
        /// BCPNID.
        /// </summary>
        public const string BCPNID = "BCPNID";

        /// <summary>
        /// BCTNAC.
        /// </summary>
        public const string BCTNAC = "BCTNAC";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCPID.
        /// </summary>
        public const string BCPID = "BCPID";

        /// <summary>
        /// BCJOBN.
        /// </summary>
        public const string BCJOBN = "BCJOBN";

        /// <summary>
        /// BCUPMJ.
        /// </summary>
        public const string BCUPMJ = "BCUPMJ";

        /// <summary>
        /// BCTDAY.
        /// </summary>
        public const string BCTDAY = "BCTDAY";

        /// <summary>
        /// BCGLC.
        /// </summary>
        public const string BCGLC = "BCGLC";

        /// <summary>
        /// BCMCU.
        /// </summary>
        public const string BCMCU = "BCMCU";

        /// <summary>
        /// BCDL01.
        /// </summary>
        public const string BCDL01 = "BCDL01";

        /// <summary>
        /// BCGRPC.
        /// </summary>
        public const string BCGRPC = "BCGRPC";

        /// <summary>
        /// BCTNAR.
        /// </summary>
        public const string BCTNAR = "BCTNAR";

        /// <summary>
        /// BCLTFE.
        /// </summary>
        public const string BCLTFE = "BCLTFE";

        /// <summary>
        /// BCMGFE.
        /// </summary>
        public const string BCMGFE = "BCMGFE";

        /// <summary>
        /// BCPRAP.
        /// </summary>
        public const string BCPRAP = "BCPRAP";

        /// <summary>
        /// BCAPPC.
        /// </summary>
        public const string BCAPPC = "BCAPPC";

        /// <summary>
        /// BCALLW.
        /// </summary>
        public const string BCALLW = "BCALLW";

        /// <summary>
        /// BCCONS.
        /// </summary>
        public const string BCCONS = "BCCONS";

        /// <summary>
        /// BCAUTS.
        /// </summary>
        public const string BCAUTS = "BCAUTS";

        /// <summary>
        /// BCSPCD.
        /// </summary>
        public const string BCSPCD = "BCSPCD";

        /// <summary>
        /// BCSECG.
        /// </summary>
        public const string BCSECG = "BCSECG";

        /// <summary>
        /// BCGRPU.
        /// </summary>
        public const string BCGRPU = "BCGRPU";

        /// <summary>
        /// BCBRAJ.
        /// </summary>
        public const string BCBRAJ = "BCBRAJ";

        /// <summary>
        /// BCSTAX.
        /// </summary>
        public const string BCSTAX = "BCSTAX";

        /// <summary>
        /// BCAPLY.
        /// </summary>
        public const string BCAPLY = "BCAPLY";

        /// <summary>
        /// BCCMNT.
        /// </summary>
        public const string BCCMNT = "BCCMNT";

        /// <summary>
        /// BCADEP.
        /// </summary>
        public const string BCADEP = "BCADEP";

        /// <summary>
        /// BCCLSS.
        /// </summary>
        public const string BCCLSS = "BCCLSS";

        /// <summary>
        /// BCADJR.
        /// </summary>
        public const string BCADJR = "BCADJR";

        /// <summary>
        /// BCTBL.
        /// </summary>
        public const string BCTBL = "BCTBL";

        /// <summary>
        /// BCMGTF.
        /// </summary>
        public const string BCMGTF = "BCMGTF";

        /// <summary>
        /// BCICST.
        /// </summary>
        public const string BCICST = "BCICST";

        /// <summary>
        /// BCRNTC.
        /// </summary>
        public const string BCRNTC = "BCRNTC";

        /// <summary>
        /// BCPJCC.
        /// </summary>
        public const string BCPJCC = "BCPJCC";

        /// <summary>
        /// BCLAFF.
        /// </summary>
        public const string BCLAFF = "BCLAFF";

        /// <summary>
        /// BCLELL.
        /// </summary>
        public const string BCLELL = "BCLELL";

        /// <summary>
        /// BCLEROUA.
        /// </summary>
        public const string BCLEROUA = "BCLEROUA";
    }

    /// <inheritdoc />
    public override string TableName => "F1512Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCEDUS", "BCEDUS", JdeDataType.String, 20, true, true),
        new JdeField("BCEDBT", "BCEDBT", JdeDataType.String, 30, true, true),
        new JdeField("BCEDTN", "BCEDTN", JdeDataType.String, 44, true, true),
        new JdeField("BCEDLN", "BCEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("BCEDCT", "BCEDCT", JdeDataType.String, 4),
        new JdeField("BCTYTN", "BCTYTN", JdeDataType.String, 16),
        new JdeField("BCEDFT", "BCEDFT", JdeDataType.String, 20),
        new JdeField("BCEDDT", "BCEDDT", JdeDataType.Numeric),
        new JdeField("BCDRIN", "BCDRIN", JdeDataType.String, 2),
        new JdeField("BCEDDL", "BCEDDL", JdeDataType.Numeric),
        new JdeField("BCEDSP", "BCEDSP", JdeDataType.String, 2),
        new JdeField("BCPNID", "BCPNID", JdeDataType.String, 30),
        new JdeField("BCTNAC", "BCTNAC", JdeDataType.String, 4),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20),
        new JdeField("BCPID", "BCPID", JdeDataType.String, 20),
        new JdeField("BCJOBN", "BCJOBN", JdeDataType.String, 20),
        new JdeField("BCUPMJ", "BCUPMJ", JdeDataType.Numeric),
        new JdeField("BCTDAY", "BCTDAY", JdeDataType.Numeric),
        new JdeField("BCGLC", "BCGLC", JdeDataType.String, 8),
        new JdeField("BCMCU", "BCMCU", JdeDataType.String, 24),
        new JdeField("BCDL01", "BCDL01", JdeDataType.String, 60),
        new JdeField("BCGRPC", "BCGRPC", JdeDataType.String, 2),
        new JdeField("BCTNAR", "BCTNAR", JdeDataType.String, 2),
        new JdeField("BCLTFE", "BCLTFE", JdeDataType.String, 2),
        new JdeField("BCMGFE", "BCMGFE", JdeDataType.String, 2),
        new JdeField("BCPRAP", "BCPRAP", JdeDataType.Numeric),
        new JdeField("BCAPPC", "BCAPPC", JdeDataType.String, 2),
        new JdeField("BCALLW", "BCALLW", JdeDataType.String, 2),
        new JdeField("BCCONS", "BCCONS", JdeDataType.String, 2),
        new JdeField("BCAUTS", "BCAUTS", JdeDataType.String, 2),
        new JdeField("BCSPCD", "BCSPCD", JdeDataType.String, 2),
        new JdeField("BCSECG", "BCSECG", JdeDataType.String, 2),
        new JdeField("BCGRPU", "BCGRPU", JdeDataType.String, 2),
        new JdeField("BCBRAJ", "BCBRAJ", JdeDataType.String, 2),
        new JdeField("BCSTAX", "BCSTAX", JdeDataType.String, 2),
        new JdeField("BCAPLY", "BCAPLY", JdeDataType.String, 8),
        new JdeField("BCCMNT", "BCCMNT", JdeDataType.String, 2),
        new JdeField("BCADEP", "BCADEP", JdeDataType.String, 2),
        new JdeField("BCCLSS", "BCCLSS", JdeDataType.String, 6),
        new JdeField("BCADJR", "BCADJR", JdeDataType.String, 4),
        new JdeField("BCTBL", "BCTBL", JdeDataType.String, 6),
        new JdeField("BCMGTF", "BCMGTF", JdeDataType.String, 2),
        new JdeField("BCICST", "BCICST", JdeDataType.String, 2),
        new JdeField("BCRNTC", "BCRNTC", JdeDataType.String, 2),
        new JdeField("BCPJCC", "BCPJCC", JdeDataType.Numeric),
        new JdeField("BCLAFF", "BCLAFF", JdeDataType.String, 2),
        new JdeField("BCLELL", "BCLELL", JdeDataType.String, 2),
        new JdeField("BCLEROUA", "BCLEROUA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1512Z1_0", "Primary Key on BCEDUS, BCEDBT, BCEDTN, BCEDLN", new[] { "BCEDUS", "BCEDBT", "BCEDTN", "BCEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
