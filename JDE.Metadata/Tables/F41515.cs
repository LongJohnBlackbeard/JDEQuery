using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41515 - .
/// </summary>
public class F41515 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PQMETN.
        /// </summary>
        public const string PQMETN = "PQMETN";

        /// <summary>
        /// PQITM.
        /// </summary>
        public const string PQITM = "PQITM";

        /// <summary>
        /// PQMCU.
        /// </summary>
        public const string PQMCU = "PQMCU";

        /// <summary>
        /// PQTKID.
        /// </summary>
        public const string PQTKID = "PQTKID";

        /// <summary>
        /// PQPPRR.
        /// </summary>
        public const string PQPPRR = "PQPPRR";

        /// <summary>
        /// PQPNCR.
        /// </summary>
        public const string PQPNCR = "PQPNCR";

        /// <summary>
        /// PQTTRE.
        /// </summary>
        public const string PQTTRE = "PQTTRE";

        /// <summary>
        /// PQBUM0.
        /// </summary>
        public const string PQBUM0 = "PQBUM0";

        /// <summary>
        /// PQAMBI.
        /// </summary>
        public const string PQAMBI = "PQAMBI";

        /// <summary>
        /// PQAMBU.
        /// </summary>
        public const string PQAMBU = "PQAMBU";

        /// <summary>
        /// PQNRDJ.
        /// </summary>
        public const string PQNRDJ = "PQNRDJ";

        /// <summary>
        /// PQRDTM.
        /// </summary>
        public const string PQRDTM = "PQRDTM";

        /// <summary>
        /// PQRECS.
        /// </summary>
        public const string PQRECS = "PQRECS";

        /// <summary>
        /// PQMETS.
        /// </summary>
        public const string PQMETS = "PQMETS";

        /// <summary>
        /// PQTMCP.
        /// </summary>
        public const string PQTMCP = "PQTMCP";

        /// <summary>
        /// PQLRST.
        /// </summary>
        public const string PQLRST = "PQLRST";

        /// <summary>
        /// PQNRST.
        /// </summary>
        public const string PQNRST = "PQNRST";

        /// <summary>
        /// PQTHDT.
        /// </summary>
        public const string PQTHDT = "PQTHDT";

        /// <summary>
        /// PQMCYN.
        /// </summary>
        public const string PQMCYN = "PQMCYN";

        /// <summary>
        /// PQUSER.
        /// </summary>
        public const string PQUSER = "PQUSER";

        /// <summary>
        /// PQPID.
        /// </summary>
        public const string PQPID = "PQPID";

        /// <summary>
        /// PQJOBN.
        /// </summary>
        public const string PQJOBN = "PQJOBN";

        /// <summary>
        /// PQUPMJ.
        /// </summary>
        public const string PQUPMJ = "PQUPMJ";

        /// <summary>
        /// PQTDAY.
        /// </summary>
        public const string PQTDAY = "PQTDAY";

        /// <summary>
        /// PQSTOK.
        /// </summary>
        public const string PQSTOK = "PQSTOK";

        /// <summary>
        /// PQBUM4.
        /// </summary>
        public const string PQBUM4 = "PQBUM4";

        /// <summary>
        /// PQWGTR.
        /// </summary>
        public const string PQWGTR = "PQWGTR";

        /// <summary>
        /// PQBUM5.
        /// </summary>
        public const string PQBUM5 = "PQBUM5";

        /// <summary>
        /// PQSTUM.
        /// </summary>
        public const string PQSTUM = "PQSTUM";

        /// <summary>
        /// PQBUM6.
        /// </summary>
        public const string PQBUM6 = "PQBUM6";

        /// <summary>
        /// PQTEMP.
        /// </summary>
        public const string PQTEMP = "PQTEMP";

        /// <summary>
        /// PQSTPU.
        /// </summary>
        public const string PQSTPU = "PQSTPU";

        /// <summary>
        /// PQDNTY.
        /// </summary>
        public const string PQDNTY = "PQDNTY";

        /// <summary>
        /// PQDNTP.
        /// </summary>
        public const string PQDNTP = "PQDNTP";

        /// <summary>
        /// PQDETP.
        /// </summary>
        public const string PQDETP = "PQDETP";

        /// <summary>
        /// PQVCF.
        /// </summary>
        public const string PQVCF = "PQVCF";

        /// <summary>
        /// PQURRF.
        /// </summary>
        public const string PQURRF = "PQURRF";

        /// <summary>
        /// PQDTPU.
        /// </summary>
        public const string PQDTPU = "PQDTPU";

        /// <summary>
        /// PQURDT.
        /// </summary>
        public const string PQURDT = "PQURDT";

        /// <summary>
        /// PQURCD.
        /// </summary>
        public const string PQURCD = "PQURCD";

        /// <summary>
        /// PQURAT.
        /// </summary>
        public const string PQURAT = "PQURAT";

        /// <summary>
        /// PQURAB.
        /// </summary>
        public const string PQURAB = "PQURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F41515";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PQMETN", "PQMETN", JdeDataType.String, 20, true, true),
        new JdeField("PQITM", "PQITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PQMCU", "PQMCU", JdeDataType.String, 24, true, true),
        new JdeField("PQTKID", "PQTKID", JdeDataType.String, 16),
        new JdeField("PQPPRR", "PQPPRR", JdeDataType.Numeric),
        new JdeField("PQPNCR", "PQPNCR", JdeDataType.Numeric),
        new JdeField("PQTTRE", "PQTTRE", JdeDataType.Numeric),
        new JdeField("PQBUM0", "PQBUM0", JdeDataType.String, 4),
        new JdeField("PQAMBI", "PQAMBI", JdeDataType.Numeric),
        new JdeField("PQAMBU", "PQAMBU", JdeDataType.String, 4),
        new JdeField("PQNRDJ", "PQNRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PQRDTM", "PQRDTM", JdeDataType.Numeric, null, true, true),
        new JdeField("PQRECS", "PQRECS", JdeDataType.String, 2),
        new JdeField("PQMETS", "PQMETS", JdeDataType.String, 2),
        new JdeField("PQTMCP", "PQTMCP", JdeDataType.String, 2),
        new JdeField("PQLRST", "PQLRST", JdeDataType.Numeric),
        new JdeField("PQNRST", "PQNRST", JdeDataType.Numeric),
        new JdeField("PQTHDT", "PQTHDT", JdeDataType.Numeric),
        new JdeField("PQMCYN", "PQMCYN", JdeDataType.String, 2),
        new JdeField("PQUSER", "PQUSER", JdeDataType.String, 20),
        new JdeField("PQPID", "PQPID", JdeDataType.String, 20),
        new JdeField("PQJOBN", "PQJOBN", JdeDataType.String, 20),
        new JdeField("PQUPMJ", "PQUPMJ", JdeDataType.Numeric),
        new JdeField("PQTDAY", "PQTDAY", JdeDataType.Numeric),
        new JdeField("PQSTOK", "PQSTOK", JdeDataType.Numeric),
        new JdeField("PQBUM4", "PQBUM4", JdeDataType.String, 4),
        new JdeField("PQWGTR", "PQWGTR", JdeDataType.Numeric),
        new JdeField("PQBUM5", "PQBUM5", JdeDataType.String, 4),
        new JdeField("PQSTUM", "PQSTUM", JdeDataType.Numeric),
        new JdeField("PQBUM6", "PQBUM6", JdeDataType.String, 4),
        new JdeField("PQTEMP", "PQTEMP", JdeDataType.Numeric),
        new JdeField("PQSTPU", "PQSTPU", JdeDataType.String, 2),
        new JdeField("PQDNTY", "PQDNTY", JdeDataType.Numeric),
        new JdeField("PQDNTP", "PQDNTP", JdeDataType.String, 2),
        new JdeField("PQDETP", "PQDETP", JdeDataType.Numeric),
        new JdeField("PQVCF", "PQVCF", JdeDataType.Numeric),
        new JdeField("PQURRF", "PQURRF", JdeDataType.String, 30),
        new JdeField("PQDTPU", "PQDTPU", JdeDataType.String, 2),
        new JdeField("PQURDT", "PQURDT", JdeDataType.Numeric),
        new JdeField("PQURCD", "PQURCD", JdeDataType.String, 4),
        new JdeField("PQURAT", "PQURAT", JdeDataType.Numeric),
        new JdeField("PQURAB", "PQURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41515_0", "Primary Key on PQMCU, PQITM, PQMETN, PQNRDJ, PQRDTM", new[] { "PQMCU", "PQITM", "PQMETN", "PQNRDJ", "PQRDTM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41515_2", "Index on PQMCU, PQMETN, PQRECS", new[] { "PQMCU", "PQMETN", "PQRECS" }),
        new JdeIndex("F41515_3", "Index on PQMETN, PQMCU, PQMETS, PQNRDJ, PQRDTM", new[] { "PQMETN", "PQMCU", "PQMETS", "PQNRDJ", "PQRDTM" }),
        new JdeIndex("F41515_4", "Index on PQITM, PQMCU, PQMETS, SYS_NC00043$, SYS_NC00044$", new[] { "PQITM", "PQMCU", "PQMETS", "SYS_NC00043$", "SYS_NC00044$" }),
        new JdeIndex("F41515_5", "Index on PQMCU, PQITM, PQLRST, PQMCYN, PQNRDJ, PQRDTM, PQMETN", new[] { "PQMCU", "PQITM", "PQLRST", "PQMCYN", "PQNRDJ", "PQRDTM", "PQMETN" }),
        new JdeIndex("F41515_6", "Index on PQMCU, PQITM, SYS_NC00045$", new[] { "PQMCU", "PQITM", "SYS_NC00045$" }),
        new JdeIndex("F41515_7", "Index on PQMCU, PQITM, PQLRST, PQMCYN, PQMETN, PQNRDJ, PQRDTM", new[] { "PQMCU", "PQITM", "PQLRST", "PQMCYN", "PQMETN", "PQNRDJ", "PQRDTM" }),
        new JdeIndex("F41515_8", "Index on PQITM, PQMCU, PQMETS, PQNRDJ, PQRDTM", new[] { "PQITM", "PQMCU", "PQMETS", "PQNRDJ", "PQRDTM" }),
        new JdeIndex("F41515_9", "Index on PQMETN, PQMCU, PQMETS, SYS_NC00043$, SYS_NC00044$", new[] { "PQMETN", "PQMCU", "PQMETS", "SYS_NC00043$", "SYS_NC00044$" })
    };
}
