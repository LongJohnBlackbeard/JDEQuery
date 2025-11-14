using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B672 - .
/// </summary>
public class F03B672 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDVERS.
        /// </summary>
        public const string RDVERS = "RDVERS";

        /// <summary>
        /// RDPYID.
        /// </summary>
        public const string RDPYID = "RDPYID";

        /// <summary>
        /// RDCKNU.
        /// </summary>
        public const string RDCKNU = "RDCKNU";

        /// <summary>
        /// RDAN8.
        /// </summary>
        public const string RDAN8 = "RDAN8";

        /// <summary>
        /// RDPYR.
        /// </summary>
        public const string RDPYR = "RDPYR";

        /// <summary>
        /// RDDMTJ.
        /// </summary>
        public const string RDDMTJ = "RDDMTJ";

        /// <summary>
        /// RDDGJ.
        /// </summary>
        public const string RDDGJ = "RDDGJ";

        /// <summary>
        /// RDVLDT.
        /// </summary>
        public const string RDVLDT = "RDVLDT";

        /// <summary>
        /// RDPOST.
        /// </summary>
        public const string RDPOST = "RDPOST";

        /// <summary>
        /// RDISTR.
        /// </summary>
        public const string RDISTR = "RDISTR";

        /// <summary>
        /// RDISTC.
        /// </summary>
        public const string RDISTC = "RDISTC";

        /// <summary>
        /// RDEULP.
        /// </summary>
        public const string RDEULP = "RDEULP";

        /// <summary>
        /// RDGLC.
        /// </summary>
        public const string RDGLC = "RDGLC";

        /// <summary>
        /// RDAID.
        /// </summary>
        public const string RDAID = "RDAID";

        /// <summary>
        /// RDCTRY.
        /// </summary>
        public const string RDCTRY = "RDCTRY";

        /// <summary>
        /// RDFY.
        /// </summary>
        public const string RDFY = "RDFY";

        /// <summary>
        /// RDPN.
        /// </summary>
        public const string RDPN = "RDPN";

        /// <summary>
        /// RDCO.
        /// </summary>
        public const string RDCO = "RDCO";

        /// <summary>
        /// RDICUT.
        /// </summary>
        public const string RDICUT = "RDICUT";

        /// <summary>
        /// RDICU.
        /// </summary>
        public const string RDICU = "RDICU";

        /// <summary>
        /// RDDICJ.
        /// </summary>
        public const string RDDICJ = "RDDICJ";

        /// <summary>
        /// RDPA8.
        /// </summary>
        public const string RDPA8 = "RDPA8";

        /// <summary>
        /// RDCKAM.
        /// </summary>
        public const string RDCKAM = "RDCKAM";

        /// <summary>
        /// RDAAP.
        /// </summary>
        public const string RDAAP = "RDAAP";

        /// <summary>
        /// RDBCRC.
        /// </summary>
        public const string RDBCRC = "RDBCRC";

        /// <summary>
        /// RDCRRM.
        /// </summary>
        public const string RDCRRM = "RDCRRM";

        /// <summary>
        /// RDCRCD.
        /// </summary>
        public const string RDCRCD = "RDCRCD";

        /// <summary>
        /// RDCRR.
        /// </summary>
        public const string RDCRR = "RDCRR";

        /// <summary>
        /// RDFCAM.
        /// </summary>
        public const string RDFCAM = "RDFCAM";

        /// <summary>
        /// RDFAP.
        /// </summary>
        public const string RDFAP = "RDFAP";

        /// <summary>
        /// RDGLBA.
        /// </summary>
        public const string RDGLBA = "RDGLBA";

        /// <summary>
        /// RDAM.
        /// </summary>
        public const string RDAM = "RDAM";

        /// <summary>
        /// RDTYIN.
        /// </summary>
        public const string RDTYIN = "RDTYIN";

        /// <summary>
        /// RDEXR.
        /// </summary>
        public const string RDEXR = "RDEXR";

        /// <summary>
        /// RDALT6.
        /// </summary>
        public const string RDALT6 = "RDALT6";

        /// <summary>
        /// RDRYIN.
        /// </summary>
        public const string RDRYIN = "RDRYIN";

        /// <summary>
        /// RDBKTR.
        /// </summary>
        public const string RDBKTR = "RDBKTR";

        /// <summary>
        /// RDALPH.
        /// </summary>
        public const string RDALPH = "RDALPH";

        /// <summary>
        /// RDDOCG.
        /// </summary>
        public const string RDDOCG = "RDDOCG";

        /// <summary>
        /// RDDCTG.
        /// </summary>
        public const string RDDCTG = "RDDCTG";

        /// <summary>
        /// RDKCOG.
        /// </summary>
        public const string RDKCOG = "RDKCOG";

        /// <summary>
        /// RDVDGJ.
        /// </summary>
        public const string RDVDGJ = "RDVDGJ";

        /// <summary>
        /// RDVRE.
        /// </summary>
        public const string RDVRE = "RDVRE";

        /// <summary>
        /// RDNFVD.
        /// </summary>
        public const string RDNFVD = "RDNFVD";

        /// <summary>
        /// RDDOCQ.
        /// </summary>
        public const string RDDOCQ = "RDDOCQ";

        /// <summary>
        /// RDDCTQ.
        /// </summary>
        public const string RDDCTQ = "RDDCTQ";

        /// <summary>
        /// RDKCOQ.
        /// </summary>
        public const string RDKCOQ = "RDKCOQ";

        /// <summary>
        /// RDICTQ.
        /// </summary>
        public const string RDICTQ = "RDICTQ";

        /// <summary>
        /// RDICUQ.
        /// </summary>
        public const string RDICUQ = "RDICUQ";

        /// <summary>
        /// RDDIQJ.
        /// </summary>
        public const string RDDIQJ = "RDDIQJ";

        /// <summary>
        /// RDPSTQ.
        /// </summary>
        public const string RDPSTQ = "RDPSTQ";

        /// <summary>
        /// RDCBNK.
        /// </summary>
        public const string RDCBNK = "RDCBNK";

        /// <summary>
        /// RDTNST.
        /// </summary>
        public const string RDTNST = "RDTNST";

        /// <summary>
        /// RDDKC.
        /// </summary>
        public const string RDDKC = "RDDKC";

        /// <summary>
        /// RDATCS.
        /// </summary>
        public const string RDATCS = "RDATCS";

        /// <summary>
        /// RDEAAC.
        /// </summary>
        public const string RDEAAC = "RDEAAC";

        /// <summary>
        /// RDEUFB.
        /// </summary>
        public const string RDEUFB = "RDEUFB";

        /// <summary>
        /// RDECLK.
        /// </summary>
        public const string RDECLK = "RDECLK";

        /// <summary>
        /// RDARL.
        /// </summary>
        public const string RDARL = "RDARL";

        /// <summary>
        /// RDARS.
        /// </summary>
        public const string RDARS = "RDARS";

        /// <summary>
        /// RDALGO.
        /// </summary>
        public const string RDALGO = "RDALGO";

        /// <summary>
        /// RDASTA.
        /// </summary>
        public const string RDASTA = "RDASTA";

        /// <summary>
        /// RDDDST.
        /// </summary>
        public const string RDDDST = "RDDDST";

        /// <summary>
        /// RDDCDS.
        /// </summary>
        public const string RDDCDS = "RDDCDS";

        /// <summary>
        /// RDDREG.
        /// </summary>
        public const string RDDREG = "RDDREG";

        /// <summary>
        /// RDGPBT.
        /// </summary>
        public const string RDGPBT = "RDGPBT";

        /// <summary>
        /// RDGPTN.
        /// </summary>
        public const string RDGPTN = "RDGPTN";

        /// <summary>
        /// RDURC1.
        /// </summary>
        public const string RDURC1 = "RDURC1";

        /// <summary>
        /// RDURDT.
        /// </summary>
        public const string RDURDT = "RDURDT";

        /// <summary>
        /// RDURAT.
        /// </summary>
        public const string RDURAT = "RDURAT";

        /// <summary>
        /// RDURAB.
        /// </summary>
        public const string RDURAB = "RDURAB";

        /// <summary>
        /// RDURRF.
        /// </summary>
        public const string RDURRF = "RDURRF";

        /// <summary>
        /// RDRNID.
        /// </summary>
        public const string RDRNID = "RDRNID";

        /// <summary>
        /// RDCUID.
        /// </summary>
        public const string RDCUID = "RDCUID";

        /// <summary>
        /// RDTORG.
        /// </summary>
        public const string RDTORG = "RDTORG";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B672";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20, true, true),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20, true, true),
        new JdeField("RDVERS", "RDVERS", JdeDataType.String, 20, true, true),
        new JdeField("RDPYID", "RDPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RDCKNU", "RDCKNU", JdeDataType.String, 50),
        new JdeField("RDAN8", "RDAN8", JdeDataType.Numeric),
        new JdeField("RDPYR", "RDPYR", JdeDataType.Numeric),
        new JdeField("RDDMTJ", "RDDMTJ", JdeDataType.Numeric),
        new JdeField("RDDGJ", "RDDGJ", JdeDataType.Numeric),
        new JdeField("RDVLDT", "RDVLDT", JdeDataType.Numeric),
        new JdeField("RDPOST", "RDPOST", JdeDataType.String, 2),
        new JdeField("RDISTR", "RDISTR", JdeDataType.String, 2),
        new JdeField("RDISTC", "RDISTC", JdeDataType.String, 2),
        new JdeField("RDEULP", "RDEULP", JdeDataType.String, 2),
        new JdeField("RDGLC", "RDGLC", JdeDataType.String, 8),
        new JdeField("RDAID", "RDAID", JdeDataType.String, 16),
        new JdeField("RDCTRY", "RDCTRY", JdeDataType.Numeric),
        new JdeField("RDFY", "RDFY", JdeDataType.Numeric),
        new JdeField("RDPN", "RDPN", JdeDataType.Numeric),
        new JdeField("RDCO", "RDCO", JdeDataType.String, 10),
        new JdeField("RDICUT", "RDICUT", JdeDataType.String, 4),
        new JdeField("RDICU", "RDICU", JdeDataType.Numeric),
        new JdeField("RDDICJ", "RDDICJ", JdeDataType.Numeric),
        new JdeField("RDPA8", "RDPA8", JdeDataType.Numeric),
        new JdeField("RDCKAM", "RDCKAM", JdeDataType.Numeric),
        new JdeField("RDAAP", "RDAAP", JdeDataType.Numeric),
        new JdeField("RDBCRC", "RDBCRC", JdeDataType.String, 6),
        new JdeField("RDCRRM", "RDCRRM", JdeDataType.String, 2),
        new JdeField("RDCRCD", "RDCRCD", JdeDataType.String, 6),
        new JdeField("RDCRR", "RDCRR", JdeDataType.Numeric),
        new JdeField("RDFCAM", "RDFCAM", JdeDataType.Numeric),
        new JdeField("RDFAP", "RDFAP", JdeDataType.Numeric),
        new JdeField("RDGLBA", "RDGLBA", JdeDataType.String, 16),
        new JdeField("RDAM", "RDAM", JdeDataType.String, 2),
        new JdeField("RDTYIN", "RDTYIN", JdeDataType.String, 2),
        new JdeField("RDEXR", "RDEXR", JdeDataType.String, 60),
        new JdeField("RDALT6", "RDALT6", JdeDataType.String, 2),
        new JdeField("RDRYIN", "RDRYIN", JdeDataType.String, 2),
        new JdeField("RDBKTR", "RDBKTR", JdeDataType.String, 16),
        new JdeField("RDALPH", "RDALPH", JdeDataType.String, 80),
        new JdeField("RDDOCG", "RDDOCG", JdeDataType.Numeric),
        new JdeField("RDDCTG", "RDDCTG", JdeDataType.String, 4),
        new JdeField("RDKCOG", "RDKCOG", JdeDataType.String, 10),
        new JdeField("RDVDGJ", "RDVDGJ", JdeDataType.Numeric),
        new JdeField("RDVRE", "RDVRE", JdeDataType.String, 6),
        new JdeField("RDNFVD", "RDNFVD", JdeDataType.String, 2),
        new JdeField("RDDOCQ", "RDDOCQ", JdeDataType.Numeric),
        new JdeField("RDDCTQ", "RDDCTQ", JdeDataType.String, 4),
        new JdeField("RDKCOQ", "RDKCOQ", JdeDataType.String, 10),
        new JdeField("RDICTQ", "RDICTQ", JdeDataType.String, 4),
        new JdeField("RDICUQ", "RDICUQ", JdeDataType.Numeric),
        new JdeField("RDDIQJ", "RDDIQJ", JdeDataType.Numeric),
        new JdeField("RDPSTQ", "RDPSTQ", JdeDataType.String, 2),
        new JdeField("RDCBNK", "RDCBNK", JdeDataType.String, 40),
        new JdeField("RDTNST", "RDTNST", JdeDataType.String, 40),
        new JdeField("RDDKC", "RDDKC", JdeDataType.Numeric),
        new JdeField("RDATCS", "RDATCS", JdeDataType.String, 2),
        new JdeField("RDEAAC", "RDEAAC", JdeDataType.String, 2),
        new JdeField("RDEUFB", "RDEUFB", JdeDataType.String, 2),
        new JdeField("RDECLK", "RDECLK", JdeDataType.String, 20),
        new JdeField("RDARL", "RDARL", JdeDataType.String, 20),
        new JdeField("RDARS", "RDARS", JdeDataType.Numeric),
        new JdeField("RDALGO", "RDALGO", JdeDataType.String, 20),
        new JdeField("RDASTA", "RDASTA", JdeDataType.String, 2),
        new JdeField("RDDDST", "RDDDST", JdeDataType.String, 2),
        new JdeField("RDDCDS", "RDDCDS", JdeDataType.String, 2),
        new JdeField("RDDREG", "RDDREG", JdeDataType.String, 26),
        new JdeField("RDGPBT", "RDGPBT", JdeDataType.Numeric),
        new JdeField("RDGPTN", "RDGPTN", JdeDataType.String, 28),
        new JdeField("RDURC1", "RDURC1", JdeDataType.String, 6),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDURRF", "RDURRF", JdeDataType.String, 30),
        new JdeField("RDRNID", "RDRNID", JdeDataType.Numeric),
        new JdeField("RDCUID", "RDCUID", JdeDataType.String, 20),
        new JdeField("RDTORG", "RDTORG", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B672_0", "Primary Key on RDUSER, RDPID, RDVERS, RDPYID", new[] { "RDUSER", "RDPID", "RDVERS", "RDPYID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B672_2", "Index on RDGPBT, RDGPTN", new[] { "RDGPBT", "RDGPTN" }),
        new JdeIndex("F03B672_3", "Index on RDPYID", new[] { "RDPYID" })
    };
}
