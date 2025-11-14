using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4971 - .
/// </summary>
public class F4971 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDMCU.
        /// </summary>
        public const string RDMCU = "RDMCU";

        /// <summary>
        /// RDRTNM.
        /// </summary>
        public const string RDRTNM = "RDRTNM";

        /// <summary>
        /// RDBLPY.
        /// </summary>
        public const string RDBLPY = "RDBLPY";

        /// <summary>
        /// RDCGC1.
        /// </summary>
        public const string RDCGC1 = "RDCGC1";

        /// <summary>
        /// RDCGC2.
        /// </summary>
        public const string RDCGC2 = "RDCGC2";

        /// <summary>
        /// RDFRTP.
        /// </summary>
        public const string RDFRTP = "RDFRTP";

        /// <summary>
        /// RDRTGB.
        /// </summary>
        public const string RDRTGB = "RDRTGB";

        /// <summary>
        /// RDRTUM.
        /// </summary>
        public const string RDRTUM = "RDRTUM";

        /// <summary>
        /// RDRTSN.
        /// </summary>
        public const string RDRTSN = "RDRTSN";

        /// <summary>
        /// RDLUT1.
        /// </summary>
        public const string RDLUT1 = "RDLUT1";

        /// <summary>
        /// RDNTE1.
        /// </summary>
        public const string RDNTE1 = "RDNTE1";

        /// <summary>
        /// RDUOM1.
        /// </summary>
        public const string RDUOM1 = "RDUOM1";

        /// <summary>
        /// RDCLPD.
        /// </summary>
        public const string RDCLPD = "RDCLPD";

        /// <summary>
        /// RDLUT2.
        /// </summary>
        public const string RDLUT2 = "RDLUT2";

        /// <summary>
        /// RDNTE2.
        /// </summary>
        public const string RDNTE2 = "RDNTE2";

        /// <summary>
        /// RDUOM2.
        /// </summary>
        public const string RDUOM2 = "RDUOM2";

        /// <summary>
        /// RDAPDS.
        /// </summary>
        public const string RDAPDS = "RDAPDS";

        /// <summary>
        /// RDDSCM.
        /// </summary>
        public const string RDDSCM = "RDDSCM";

        /// <summary>
        /// RDSHPC.
        /// </summary>
        public const string RDSHPC = "RDSHPC";

        /// <summary>
        /// RDRDLV.
        /// </summary>
        public const string RDRDLV = "RDRDLV";

        /// <summary>
        /// RDCGC4.
        /// </summary>
        public const string RDCGC4 = "RDCGC4";

        /// <summary>
        /// RDPRTB.
        /// </summary>
        public const string RDPRTB = "RDPRTB";

        /// <summary>
        /// RDCSTP.
        /// </summary>
        public const string RDCSTP = "RDCSTP";

        /// <summary>
        /// RDOPEQ.
        /// </summary>
        public const string RDOPEQ = "RDOPEQ";

        /// <summary>
        /// RDSLPF.
        /// </summary>
        public const string RDSLPF = "RDSLPF";

        /// <summary>
        /// RDVFPF.
        /// </summary>
        public const string RDVFPF = "RDVFPF";

        /// <summary>
        /// RDFCNM.
        /// </summary>
        public const string RDFCNM = "RDFCNM";

        /// <summary>
        /// RDCRNM.
        /// </summary>
        public const string RDCRNM = "RDCRNM";

        /// <summary>
        /// RDRTBD.
        /// </summary>
        public const string RDRTBD = "RDRTBD";

        /// <summary>
        /// RDRNDN.
        /// </summary>
        public const string RDRNDN = "RDRNDN";

        /// <summary>
        /// RDURCD.
        /// </summary>
        public const string RDURCD = "RDURCD";

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
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDTDAY.
        /// </summary>
        public const string RDTDAY = "RDTDAY";

        /// <summary>
        /// RDUDWR.
        /// </summary>
        public const string RDUDWR = "RDUDWR";

        /// <summary>
        /// RDDWTH.
        /// </summary>
        public const string RDDWTH = "RDDWTH";

        /// <summary>
        /// RDVLUM.
        /// </summary>
        public const string RDVLUM = "RDVLUM";

        /// <summary>
        /// RDDWFC.
        /// </summary>
        public const string RDDWFC = "RDDWFC";

        /// <summary>
        /// RDQTY1.
        /// </summary>
        public const string RDQTY1 = "RDQTY1";

        /// <summary>
        /// RDFLD4.
        /// </summary>
        public const string RDFLD4 = "RDFLD4";

        /// <summary>
        /// RDFLD5.
        /// </summary>
        public const string RDFLD5 = "RDFLD5";

        /// <summary>
        /// RDFUF8.
        /// </summary>
        public const string RDFUF8 = "RDFUF8";

        /// <summary>
        /// RDBPF3.
        /// </summary>
        public const string RDBPF3 = "RDBPF3";
    }

    /// <inheritdoc />
    public override string TableName => "F4971";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDMCU", "RDMCU", JdeDataType.String, 24),
        new JdeField("RDRTNM", "RDRTNM", JdeDataType.String, 20, true, true),
        new JdeField("RDBLPY", "RDBLPY", JdeDataType.String, 2),
        new JdeField("RDCGC1", "RDCGC1", JdeDataType.String, 6),
        new JdeField("RDCGC2", "RDCGC2", JdeDataType.String, 6),
        new JdeField("RDFRTP", "RDFRTP", JdeDataType.String, 2),
        new JdeField("RDRTGB", "RDRTGB", JdeDataType.String, 2),
        new JdeField("RDRTUM", "RDRTUM", JdeDataType.String, 4),
        new JdeField("RDRTSN", "RDRTSN", JdeDataType.String, 20),
        new JdeField("RDLUT1", "RDLUT1", JdeDataType.String, 2),
        new JdeField("RDNTE1", "RDNTE1", JdeDataType.Numeric),
        new JdeField("RDUOM1", "RDUOM1", JdeDataType.String, 4),
        new JdeField("RDCLPD", "RDCLPD", JdeDataType.String, 2),
        new JdeField("RDLUT2", "RDLUT2", JdeDataType.String, 2),
        new JdeField("RDNTE2", "RDNTE2", JdeDataType.Numeric),
        new JdeField("RDUOM2", "RDUOM2", JdeDataType.String, 4),
        new JdeField("RDAPDS", "RDAPDS", JdeDataType.String, 2),
        new JdeField("RDDSCM", "RDDSCM", JdeDataType.String, 2),
        new JdeField("RDSHPC", "RDSHPC", JdeDataType.String, 2),
        new JdeField("RDRDLV", "RDRDLV", JdeDataType.String, 2),
        new JdeField("RDCGC4", "RDCGC4", JdeDataType.String, 6),
        new JdeField("RDPRTB", "RDPRTB", JdeDataType.String, 2),
        new JdeField("RDCSTP", "RDCSTP", JdeDataType.String, 16),
        new JdeField("RDOPEQ", "RDOPEQ", JdeDataType.String, 20),
        new JdeField("RDSLPF", "RDSLPF", JdeDataType.String, 2),
        new JdeField("RDVFPF", "RDVFPF", JdeDataType.String, 2),
        new JdeField("RDFCNM", "RDFCNM", JdeDataType.String, 64),
        new JdeField("RDCRNM", "RDCRNM", JdeDataType.String, 20),
        new JdeField("RDRTBD", "RDRTBD", JdeDataType.Numeric),
        new JdeField("RDRNDN", "RDRNDN", JdeDataType.String, 2),
        new JdeField("RDURCD", "RDURCD", JdeDataType.String, 4),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDURRF", "RDURRF", JdeDataType.String, 30),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDTDAY", "RDTDAY", JdeDataType.Numeric),
        new JdeField("RDUDWR", "RDUDWR", JdeDataType.String, 2),
        new JdeField("RDDWTH", "RDDWTH", JdeDataType.Numeric),
        new JdeField("RDVLUM", "RDVLUM", JdeDataType.String, 4),
        new JdeField("RDDWFC", "RDDWFC", JdeDataType.Numeric),
        new JdeField("RDQTY1", "RDQTY1", JdeDataType.Numeric),
        new JdeField("RDFLD4", "RDFLD4", JdeDataType.String, 2),
        new JdeField("RDFLD5", "RDFLD5", JdeDataType.String, 2),
        new JdeField("RDFUF8", "RDFUF8", JdeDataType.Numeric),
        new JdeField("RDBPF3", "RDBPF3", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4971_0", "Primary Key on RDRTNM", new[] { "RDRTNM" }, isUnique: true, isPrimaryKey: true)
    };
}
