using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F32169 - .
/// </summary>
public class F32169 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KBCFGID.
        /// </summary>
        public const string KBCFGID = "KBCFGID";

        /// <summary>
        /// KBCFGCID.
        /// </summary>
        public const string KBCFGCID = "KBCFGCID";

        /// <summary>
        /// KBSEQN.
        /// </summary>
        public const string KBSEQN = "KBSEQN";

        /// <summary>
        /// KBDSC1.
        /// </summary>
        public const string KBDSC1 = "KBDSC1";

        /// <summary>
        /// KBLNTY.
        /// </summary>
        public const string KBLNTY = "KBLNTY";

        /// <summary>
        /// KBPRU.
        /// </summary>
        public const string KBPRU = "KBPRU";

        /// <summary>
        /// KBSOCF.
        /// </summary>
        public const string KBSOCF = "KBSOCF";

        /// <summary>
        /// KBFOVQ.
        /// </summary>
        public const string KBFOVQ = "KBFOVQ";

        /// <summary>
        /// KBATMU.
        /// </summary>
        public const string KBATMU = "KBATMU";

        /// <summary>
        /// KBECST.
        /// </summary>
        public const string KBECST = "KBECST";

        /// <summary>
        /// KBFEC.
        /// </summary>
        public const string KBFEC = "KBFEC";

        /// <summary>
        /// KBAEXP.
        /// </summary>
        public const string KBAEXP = "KBAEXP";

        /// <summary>
        /// KBFEA.
        /// </summary>
        public const string KBFEA = "KBFEA";

        /// <summary>
        /// KBATOT.
        /// </summary>
        public const string KBATOT = "KBATOT";

        /// <summary>
        /// KBATO#.
        /// </summary>
        public const string KBATO_ = "KBATO#";

        /// <summary>
        /// KBATOS.
        /// </summary>
        public const string KBATOS = "KBATOS";

        /// <summary>
        /// KBLNID.
        /// </summary>
        public const string KBLNID = "KBLNID";

        /// <summary>
        /// KBAKID.
        /// </summary>
        public const string KBAKID = "KBAKID";

        /// <summary>
        /// KBURCD.
        /// </summary>
        public const string KBURCD = "KBURCD";

        /// <summary>
        /// KBURDT.
        /// </summary>
        public const string KBURDT = "KBURDT";

        /// <summary>
        /// KBURAT.
        /// </summary>
        public const string KBURAT = "KBURAT";

        /// <summary>
        /// KBURAB.
        /// </summary>
        public const string KBURAB = "KBURAB";

        /// <summary>
        /// KBURRF.
        /// </summary>
        public const string KBURRF = "KBURRF";

        /// <summary>
        /// KBUSER.
        /// </summary>
        public const string KBUSER = "KBUSER";

        /// <summary>
        /// KBPID.
        /// </summary>
        public const string KBPID = "KBPID";

        /// <summary>
        /// KBJOBN.
        /// </summary>
        public const string KBJOBN = "KBJOBN";

        /// <summary>
        /// KBUPMJ.
        /// </summary>
        public const string KBUPMJ = "KBUPMJ";

        /// <summary>
        /// KBTDAY.
        /// </summary>
        public const string KBTDAY = "KBTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F32169";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KBCFGID", "KBCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("KBCFGCID", "KBCFGCID", JdeDataType.Numeric, null, true, true),
        new JdeField("KBSEQN", "KBSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("KBDSC1", "KBDSC1", JdeDataType.String, 60),
        new JdeField("KBLNTY", "KBLNTY", JdeDataType.String, 4, true, true),
        new JdeField("KBPRU", "KBPRU", JdeDataType.String, 2, true, true),
        new JdeField("KBSOCF", "KBSOCF", JdeDataType.String, 2),
        new JdeField("KBFOVQ", "KBFOVQ", JdeDataType.String, 2),
        new JdeField("KBATMU", "KBATMU", JdeDataType.Numeric),
        new JdeField("KBECST", "KBECST", JdeDataType.Numeric),
        new JdeField("KBFEC", "KBFEC", JdeDataType.Numeric),
        new JdeField("KBAEXP", "KBAEXP", JdeDataType.Numeric),
        new JdeField("KBFEA", "KBFEA", JdeDataType.Numeric),
        new JdeField("KBATOT", "KBATOT", JdeDataType.String, 2),
        new JdeField("KBATO#", "KBATO#", JdeDataType.Numeric),
        new JdeField("KBATOS", "KBATOS", JdeDataType.Numeric),
        new JdeField("KBLNID", "KBLNID", JdeDataType.Numeric),
        new JdeField("KBAKID", "KBAKID", JdeDataType.Numeric),
        new JdeField("KBURCD", "KBURCD", JdeDataType.String, 4),
        new JdeField("KBURDT", "KBURDT", JdeDataType.Numeric),
        new JdeField("KBURAT", "KBURAT", JdeDataType.Numeric),
        new JdeField("KBURAB", "KBURAB", JdeDataType.Numeric),
        new JdeField("KBURRF", "KBURRF", JdeDataType.String, 30),
        new JdeField("KBUSER", "KBUSER", JdeDataType.String, 20),
        new JdeField("KBPID", "KBPID", JdeDataType.String, 20),
        new JdeField("KBJOBN", "KBJOBN", JdeDataType.String, 20),
        new JdeField("KBUPMJ", "KBUPMJ", JdeDataType.Numeric),
        new JdeField("KBTDAY", "KBTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F32169_0", "Primary Key on KBCFGID, KBCFGCID, KBSEQN, KBLNTY, KBPRU", new[] { "KBCFGID", "KBCFGCID", "KBSEQN", "KBLNTY", "KBPRU" }, isUnique: true, isPrimaryKey: true)
    };
}
