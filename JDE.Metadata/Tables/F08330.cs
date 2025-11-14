using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08330 - .
/// </summary>
public class F08330 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BGAN8.
        /// </summary>
        public const string BGAN8 = "BGAN8";

        /// <summary>
        /// BGPLAN.
        /// </summary>
        public const string BGPLAN = "BGPLAN";

        /// <summary>
        /// BGEFT.
        /// </summary>
        public const string BGEFT = "BGEFT";

        /// <summary>
        /// BGEFTE.
        /// </summary>
        public const string BGEFTE = "BGEFTE";

        /// <summary>
        /// BGXDFS.
        /// </summary>
        public const string BGXDFS = "BGXDFS";

        /// <summary>
        /// BGXEST.
        /// </summary>
        public const string BGXEST = "BGXEST";

        /// <summary>
        /// BGDELG.
        /// </summary>
        public const string BGDELG = "BGDELG";

        /// <summary>
        /// BGDPTC.
        /// </summary>
        public const string BGDPTC = "BGDPTC";

        /// <summary>
        /// BGDUSR.
        /// </summary>
        public const string BGDUSR = "BGDUSR";

        /// <summary>
        /// BGAOPT.
        /// </summary>
        public const string BGAOPT = "BGAOPT";

        /// <summary>
        /// BGFCTR.
        /// </summary>
        public const string BGFCTR = "BGFCTR";

        /// <summary>
        /// BGDTDB.
        /// </summary>
        public const string BGDTDB = "BGDTDB";

        /// <summary>
        /// BGDTDE.
        /// </summary>
        public const string BGDTDE = "BGDTDE";

        /// <summary>
        /// BGSEQ#.
        /// </summary>
        public const string BGSEQ_ = "BGSEQ#";

        /// <summary>
        /// BGUSER.
        /// </summary>
        public const string BGUSER = "BGUSER";

        /// <summary>
        /// BGPID.
        /// </summary>
        public const string BGPID = "BGPID";

        /// <summary>
        /// BGJOBN.
        /// </summary>
        public const string BGJOBN = "BGJOBN";

        /// <summary>
        /// BGUPMJ.
        /// </summary>
        public const string BGUPMJ = "BGUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F08330";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BGAN8", "BGAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("BGPLAN", "BGPLAN", JdeDataType.String, 16, true, true),
        new JdeField("BGEFT", "BGEFT", JdeDataType.Numeric, null, true, true),
        new JdeField("BGEFTE", "BGEFTE", JdeDataType.Numeric),
        new JdeField("BGXDFS", "BGXDFS", JdeDataType.String, 6),
        new JdeField("BGXEST", "BGXEST", JdeDataType.String, 6),
        new JdeField("BGDELG", "BGDELG", JdeDataType.Numeric),
        new JdeField("BGDPTC", "BGDPTC", JdeDataType.Numeric),
        new JdeField("BGDUSR", "BGDUSR", JdeDataType.Numeric),
        new JdeField("BGAOPT", "BGAOPT", JdeDataType.String, 6, true, true),
        new JdeField("BGFCTR", "BGFCTR", JdeDataType.Numeric),
        new JdeField("BGDTDB", "BGDTDB", JdeDataType.Numeric),
        new JdeField("BGDTDE", "BGDTDE", JdeDataType.Numeric),
        new JdeField("BGSEQ#", "BGSEQ#", JdeDataType.Numeric),
        new JdeField("BGUSER", "BGUSER", JdeDataType.String, 20),
        new JdeField("BGPID", "BGPID", JdeDataType.String, 20),
        new JdeField("BGJOBN", "BGJOBN", JdeDataType.String, 20),
        new JdeField("BGUPMJ", "BGUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08330_0", "Primary Key on BGAN8, BGPLAN, BGAOPT, BGEFT", new[] { "BGAN8", "BGPLAN", "BGAOPT", "BGEFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08330_10", "Index on SYS_NC00019$, BGPLAN, BGAN8", new[] { "SYS_NC00019$", "BGPLAN", "BGAN8" }),
        new JdeIndex("F08330_2", "Index on BGPLAN, BGEFT", new[] { "BGPLAN", "BGEFT" }),
        new JdeIndex("F08330_3", "Index on BGPLAN, BGAN8, BGEFT", new[] { "BGPLAN", "BGAN8", "BGEFT" }),
        new JdeIndex("F08330_4", "Index on BGPLAN, BGAOPT, BGEFT, BGAN8", new[] { "BGPLAN", "BGAOPT", "BGEFT", "BGAN8" }),
        new JdeIndex("F08330_5", "Index on BGPLAN, BGEFT, BGAN8", new[] { "BGPLAN", "BGEFT", "BGAN8" }),
        new JdeIndex("F08330_6", "Index on BGAN8, BGEFT, BGPLAN", new[] { "BGAN8", "BGEFT", "BGPLAN" }),
        new JdeIndex("F08330_8", "Index on BGPLAN, BGAN8, SYS_NC00019$", new[] { "BGPLAN", "BGAN8", "SYS_NC00019$" }),
        new JdeIndex("F08330_9", "Index on BGPLAN, SYS_NC00019$, BGAN8", new[] { "BGPLAN", "SYS_NC00019$", "BGAN8" })
    };
}
