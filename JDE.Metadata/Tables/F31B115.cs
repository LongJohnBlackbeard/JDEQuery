using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B115 - .
/// </summary>
public class F31B115 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDWTBID.
        /// </summary>
        public const string BDWTBID = "BDWTBID";

        /// <summary>
        /// BDWTBINOT.
        /// </summary>
        public const string BDWTBINOT = "BDWTBINOT";

        /// <summary>
        /// BDMCU.
        /// </summary>
        public const string BDMCU = "BDMCU";

        /// <summary>
        /// BDWLOTN.
        /// </summary>
        public const string BDWLOTN = "BDWLOTN";

        /// <summary>
        /// BDWTBLOSE.
        /// </summary>
        public const string BDWTBLOSE = "BDWTBLOSE";

        /// <summary>
        /// BDWVID.
        /// </summary>
        public const string BDWVID = "BDWVID";

        /// <summary>
        /// BDWVTY.
        /// </summary>
        public const string BDWVTY = "BDWVTY";

        /// <summary>
        /// BDWOPID.
        /// </summary>
        public const string BDWOPID = "BDWOPID";

        /// <summary>
        /// BDWTBSTAT.
        /// </summary>
        public const string BDWTBSTAT = "BDWTBSTAT";

        /// <summary>
        /// BDWTBQOP.
        /// </summary>
        public const string BDWTBQOP = "BDWTBQOP";

        /// <summary>
        /// BDWTBQCN.
        /// </summary>
        public const string BDWTBQCN = "BDWTBQCN";

        /// <summary>
        /// BDWTBPCN.
        /// </summary>
        public const string BDWTBPCN = "BDWTBPCN";

        /// <summary>
        /// BDWTBOQTY.
        /// </summary>
        public const string BDWTBOQTY = "BDWTBOQTY";

        /// <summary>
        /// BDWTBOUOM.
        /// </summary>
        public const string BDWTBOUOM = "BDWTBOUOM";

        /// <summary>
        /// BDWTBOTB.
        /// </summary>
        public const string BDWTBOTB = "BDWTBOTB";

        /// <summary>
        /// BDWTBOMAT.
        /// </summary>
        public const string BDWTBOMAT = "BDWTBOMAT";

        /// <summary>
        /// BDWTBOST.
        /// </summary>
        public const string BDWTBOST = "BDWTBOST";

        /// <summary>
        /// BDURAB.
        /// </summary>
        public const string BDURAB = "BDURAB";

        /// <summary>
        /// BDURAT.
        /// </summary>
        public const string BDURAT = "BDURAT";

        /// <summary>
        /// BDURCD.
        /// </summary>
        public const string BDURCD = "BDURCD";

        /// <summary>
        /// BDURDT.
        /// </summary>
        public const string BDURDT = "BDURDT";

        /// <summary>
        /// BDURRF.
        /// </summary>
        public const string BDURRF = "BDURRF";

        /// <summary>
        /// BDWAB.
        /// </summary>
        public const string BDWAB = "BDWAB";

        /// <summary>
        /// BDWNUM.
        /// </summary>
        public const string BDWNUM = "BDWNUM";

        /// <summary>
        /// BDWCD.
        /// </summary>
        public const string BDWCD = "BDWCD";

        /// <summary>
        /// BDWMDT.
        /// </summary>
        public const string BDWMDT = "BDWMDT";

        /// <summary>
        /// BDWRF.
        /// </summary>
        public const string BDWRF = "BDWRF";

        /// <summary>
        /// BDUSER.
        /// </summary>
        public const string BDUSER = "BDUSER";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";

        /// <summary>
        /// BDUPMT.
        /// </summary>
        public const string BDUPMT = "BDUPMT";

        /// <summary>
        /// BDJOBN.
        /// </summary>
        public const string BDJOBN = "BDJOBN";

        /// <summary>
        /// BDMKEY.
        /// </summary>
        public const string BDMKEY = "BDMKEY";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";

        /// <summary>
        /// BDWPERTBQ.
        /// </summary>
        public const string BDWPERTBQ = "BDWPERTBQ";
    }

    /// <inheritdoc />
    public override string TableName => "F31B115";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDWTBID", "BDWTBID", JdeDataType.Numeric, null, true, true),
        new JdeField("BDWTBINOT", "BDWTBINOT", JdeDataType.String, 2, true, true),
        new JdeField("BDMCU", "BDMCU", JdeDataType.String, 24, true, true),
        new JdeField("BDWLOTN", "BDWLOTN", JdeDataType.String, 60, true, true),
        new JdeField("BDWTBLOSE", "BDWTBLOSE", JdeDataType.String, 2),
        new JdeField("BDWVID", "BDWVID", JdeDataType.Numeric),
        new JdeField("BDWVTY", "BDWVTY", JdeDataType.String, 2),
        new JdeField("BDWOPID", "BDWOPID", JdeDataType.Numeric),
        new JdeField("BDWTBSTAT", "BDWTBSTAT", JdeDataType.String, 2),
        new JdeField("BDWTBQOP", "BDWTBQOP", JdeDataType.String, 2),
        new JdeField("BDWTBQCN", "BDWTBQCN", JdeDataType.Numeric),
        new JdeField("BDWTBPCN", "BDWTBPCN", JdeDataType.Numeric),
        new JdeField("BDWTBOQTY", "BDWTBOQTY", JdeDataType.Numeric),
        new JdeField("BDWTBOUOM", "BDWTBOUOM", JdeDataType.String, 6),
        new JdeField("BDWTBOTB", "BDWTBOTB", JdeDataType.String, 60),
        new JdeField("BDWTBOMAT", "BDWTBOMAT", JdeDataType.String, 8),
        new JdeField("BDWTBOST", "BDWTBOST", JdeDataType.String, 12),
        new JdeField("BDURAB", "BDURAB", JdeDataType.Numeric),
        new JdeField("BDURAT", "BDURAT", JdeDataType.Numeric),
        new JdeField("BDURCD", "BDURCD", JdeDataType.String, 4),
        new JdeField("BDURDT", "BDURDT", JdeDataType.Numeric),
        new JdeField("BDURRF", "BDURRF", JdeDataType.String, 30),
        new JdeField("BDWAB", "BDWAB", JdeDataType.Numeric),
        new JdeField("BDWNUM", "BDWNUM", JdeDataType.Numeric),
        new JdeField("BDWCD", "BDWCD", JdeDataType.String, 6),
        new JdeField("BDWMDT", "BDWMDT", JdeDataType.Numeric),
        new JdeField("BDWRF", "BDWRF", JdeDataType.String, 60),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDUPMT", "BDUPMT", JdeDataType.Numeric),
        new JdeField("BDJOBN", "BDJOBN", JdeDataType.String, 20),
        new JdeField("BDMKEY", "BDMKEY", JdeDataType.String, 30),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDWPERTBQ", "BDWPERTBQ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B115_0", "Primary Key on BDWTBID, BDWTBINOT, BDMCU, BDWLOTN", new[] { "BDWTBID", "BDWTBINOT", "BDMCU", "BDWLOTN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B115_2", "Index on BDWTBID, BDWLOTN, BDWVID", new[] { "BDWTBID", "BDWLOTN", "BDWVID" }),
        new JdeIndex("F31B115_3", "Index on BDWVID, BDWOPID", new[] { "BDWVID", "BDWOPID" }),
        new JdeIndex("F31B115_4", "Index on BDWVID, BDWTBID", new[] { "BDWVID", "BDWTBID" }),
        new JdeIndex("F31B115_5", "Index on BDWVID, BDWTBINOT", new[] { "BDWVID", "BDWTBINOT" }),
        new JdeIndex("F31B115_6", "Index on BDWLOTN, BDWTBINOT", new[] { "BDWLOTN", "BDWTBINOT" }),
        new JdeIndex("F31B115_7", "Index on BDWTBINOT, BDWLOTN", new[] { "BDWTBINOT", "BDWLOTN" })
    };
}
