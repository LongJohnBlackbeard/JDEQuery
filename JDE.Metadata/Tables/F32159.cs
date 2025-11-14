using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F32159 - .
/// </summary>
public class F32159 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHCFGID.
        /// </summary>
        public const string CHCFGID = "CHCFGID";

        /// <summary>
        /// CHCFGCID.
        /// </summary>
        public const string CHCFGCID = "CHCFGCID";

        /// <summary>
        /// CHCFGPID.
        /// </summary>
        public const string CHCFGPID = "CHCFGPID";

        /// <summary>
        /// CHITM.
        /// </summary>
        public const string CHITM = "CHITM";

        /// <summary>
        /// CHMCU.
        /// </summary>
        public const string CHMCU = "CHMCU";

        /// <summary>
        /// CHDSC1.
        /// </summary>
        public const string CHDSC1 = "CHDSC1";

        /// <summary>
        /// CHQNTY.
        /// </summary>
        public const string CHQNTY = "CHQNTY";

        /// <summary>
        /// CHUOM.
        /// </summary>
        public const string CHUOM = "CHUOM";

        /// <summary>
        /// CHFOVQ.
        /// </summary>
        public const string CHFOVQ = "CHFOVQ";

        /// <summary>
        /// CHATMU.
        /// </summary>
        public const string CHATMU = "CHATMU";

        /// <summary>
        /// CHSO03.
        /// </summary>
        public const string CHSO03 = "CHSO03";

        /// <summary>
        /// CHLNTY.
        /// </summary>
        public const string CHLNTY = "CHLNTY";

        /// <summary>
        /// CHKIT.
        /// </summary>
        public const string CHKIT = "CHKIT";

        /// <summary>
        /// CHUITM.
        /// </summary>
        public const string CHUITM = "CHUITM";

        /// <summary>
        /// CHCFGSID.
        /// </summary>
        public const string CHCFGSID = "CHCFGSID";

        /// <summary>
        /// CHCOMM.
        /// </summary>
        public const string CHCOMM = "CHCOMM";

        /// <summary>
        /// CHLOCN.
        /// </summary>
        public const string CHLOCN = "CHLOCN";

        /// <summary>
        /// CHLOTN.
        /// </summary>
        public const string CHLOTN = "CHLOTN";

        /// <summary>
        /// CHSY.
        /// </summary>
        public const string CHSY = "CHSY";

        /// <summary>
        /// CHECST.
        /// </summary>
        public const string CHECST = "CHECST";

        /// <summary>
        /// CHFEC.
        /// </summary>
        public const string CHFEC = "CHFEC";

        /// <summary>
        /// CHAEXP.
        /// </summary>
        public const string CHAEXP = "CHAEXP";

        /// <summary>
        /// CHFEA.
        /// </summary>
        public const string CHFEA = "CHFEA";

        /// <summary>
        /// CHSOCF.
        /// </summary>
        public const string CHSOCF = "CHSOCF";

        /// <summary>
        /// CHWADL.
        /// </summary>
        public const string CHWADL = "CHWADL";

        /// <summary>
        /// CHITC.
        /// </summary>
        public const string CHITC = "CHITC";

        /// <summary>
        /// CHOPSQ.
        /// </summary>
        public const string CHOPSQ = "CHOPSQ";

        /// <summary>
        /// CHATOT.
        /// </summary>
        public const string CHATOT = "CHATOT";

        /// <summary>
        /// CHATO#.
        /// </summary>
        public const string CHATO_ = "CHATO#";

        /// <summary>
        /// CHATOS.
        /// </summary>
        public const string CHATOS = "CHATOS";

        /// <summary>
        /// CHPDDJ.
        /// </summary>
        public const string CHPDDJ = "CHPDDJ";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHTDAY.
        /// </summary>
        public const string CHTDAY = "CHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F32159";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHCFGID", "CHCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHCFGCID", "CHCFGCID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHCFGPID", "CHCFGPID", JdeDataType.Numeric),
        new JdeField("CHITM", "CHITM", JdeDataType.Numeric),
        new JdeField("CHMCU", "CHMCU", JdeDataType.String, 24),
        new JdeField("CHDSC1", "CHDSC1", JdeDataType.String, 60),
        new JdeField("CHQNTY", "CHQNTY", JdeDataType.Numeric),
        new JdeField("CHUOM", "CHUOM", JdeDataType.String, 4),
        new JdeField("CHFOVQ", "CHFOVQ", JdeDataType.String, 2),
        new JdeField("CHATMU", "CHATMU", JdeDataType.Numeric),
        new JdeField("CHSO03", "CHSO03", JdeDataType.String, 2),
        new JdeField("CHLNTY", "CHLNTY", JdeDataType.String, 4),
        new JdeField("CHKIT", "CHKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("CHUITM", "CHUITM", JdeDataType.String, 52),
        new JdeField("CHCFGSID", "CHCFGSID", JdeDataType.String, 64, true, true),
        new JdeField("CHCOMM", "CHCOMM", JdeDataType.String, 2),
        new JdeField("CHLOCN", "CHLOCN", JdeDataType.String, 40),
        new JdeField("CHLOTN", "CHLOTN", JdeDataType.String, 60),
        new JdeField("CHSY", "CHSY", JdeDataType.String, 8),
        new JdeField("CHECST", "CHECST", JdeDataType.Numeric),
        new JdeField("CHFEC", "CHFEC", JdeDataType.Numeric),
        new JdeField("CHAEXP", "CHAEXP", JdeDataType.Numeric),
        new JdeField("CHFEA", "CHFEA", JdeDataType.Numeric),
        new JdeField("CHSOCF", "CHSOCF", JdeDataType.String, 2),
        new JdeField("CHWADL", "CHWADL", JdeDataType.String, 2),
        new JdeField("CHITC", "CHITC", JdeDataType.String, 2),
        new JdeField("CHOPSQ", "CHOPSQ", JdeDataType.Numeric),
        new JdeField("CHATOT", "CHATOT", JdeDataType.String, 2),
        new JdeField("CHATO#", "CHATO#", JdeDataType.Numeric),
        new JdeField("CHATOS", "CHATOS", JdeDataType.Numeric),
        new JdeField("CHPDDJ", "CHPDDJ", JdeDataType.Numeric),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHTDAY", "CHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F32159_0", "Primary Key on CHCFGID, CHCFGCID, CHKIT, CHCFGSID", new[] { "CHCFGID", "CHCFGCID", "CHKIT", "CHCFGSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F32159_2", "Index on CHCFGID, CHCFGPID, CHCFGCID", new[] { "CHCFGID", "CHCFGPID", "CHCFGCID" })
    };
}
