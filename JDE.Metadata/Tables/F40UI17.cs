using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40UI17 - .
/// </summary>
public class F40UI17 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZGCTID.
        /// </summary>
        public const string ZGCTID = "ZGCTID";

        /// <summary>
        /// ZGJOBS.
        /// </summary>
        public const string ZGJOBS = "ZGJOBS";

        /// <summary>
        /// ZGXLIN.
        /// </summary>
        public const string ZGXLIN = "ZGXLIN";

        /// <summary>
        /// ZGDOCO.
        /// </summary>
        public const string ZGDOCO = "ZGDOCO";

        /// <summary>
        /// ZGDCTO.
        /// </summary>
        public const string ZGDCTO = "ZGDCTO";

        /// <summary>
        /// ZGKCOO.
        /// </summary>
        public const string ZGKCOO = "ZGKCOO";

        /// <summary>
        /// ZGLNID.
        /// </summary>
        public const string ZGLNID = "ZGLNID";

        /// <summary>
        /// ZGAN8.
        /// </summary>
        public const string ZGAN8 = "ZGAN8";

        /// <summary>
        /// ZGCSTP.
        /// </summary>
        public const string ZGCSTP = "ZGCSTP";

        /// <summary>
        /// ZGITM.
        /// </summary>
        public const string ZGITM = "ZGITM";

        /// <summary>
        /// ZGITTP.
        /// </summary>
        public const string ZGITTP = "ZGITTP";

        /// <summary>
        /// ZGQLIM.
        /// </summary>
        public const string ZGQLIM = "ZGQLIM";

        /// <summary>
        /// ZGQSLD.
        /// </summary>
        public const string ZGQSLD = "ZGQSLD";

        /// <summary>
        /// ZGALOC.
        /// </summary>
        public const string ZGALOC = "ZGALOC";

        /// <summary>
        /// ZGEFTJ.
        /// </summary>
        public const string ZGEFTJ = "ZGEFTJ";

        /// <summary>
        /// ZGEXDJ.
        /// </summary>
        public const string ZGEXDJ = "ZGEXDJ";

        /// <summary>
        /// ZGMNQ.
        /// </summary>
        public const string ZGMNQ = "ZGMNQ";

        /// <summary>
        /// ZGMXQ.
        /// </summary>
        public const string ZGMXQ = "ZGMXQ";

        /// <summary>
        /// ZGUOM.
        /// </summary>
        public const string ZGUOM = "ZGUOM";

        /// <summary>
        /// ZGUORG.
        /// </summary>
        public const string ZGUORG = "ZGUORG";

        /// <summary>
        /// ZGOSEQ.
        /// </summary>
        public const string ZGOSEQ = "ZGOSEQ";

        /// <summary>
        /// ZGMCU.
        /// </summary>
        public const string ZGMCU = "ZGMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F40UI17";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZGCTID", "ZGCTID", JdeDataType.String, 30, true, true),
        new JdeField("ZGJOBS", "ZGJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZGXLIN", "ZGXLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZGDOCO", "ZGDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("ZGDCTO", "ZGDCTO", JdeDataType.String, 4, true, true),
        new JdeField("ZGKCOO", "ZGKCOO", JdeDataType.String, 10, true, true),
        new JdeField("ZGLNID", "ZGLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("ZGAN8", "ZGAN8", JdeDataType.Numeric),
        new JdeField("ZGCSTP", "ZGCSTP", JdeDataType.String, 16),
        new JdeField("ZGITM", "ZGITM", JdeDataType.Numeric),
        new JdeField("ZGITTP", "ZGITTP", JdeDataType.String, 16),
        new JdeField("ZGQLIM", "ZGQLIM", JdeDataType.Numeric),
        new JdeField("ZGQSLD", "ZGQSLD", JdeDataType.Numeric),
        new JdeField("ZGALOC", "ZGALOC", JdeDataType.String, 2),
        new JdeField("ZGEFTJ", "ZGEFTJ", JdeDataType.Numeric),
        new JdeField("ZGEXDJ", "ZGEXDJ", JdeDataType.Numeric),
        new JdeField("ZGMNQ", "ZGMNQ", JdeDataType.Numeric),
        new JdeField("ZGMXQ", "ZGMXQ", JdeDataType.Numeric),
        new JdeField("ZGUOM", "ZGUOM", JdeDataType.String, 4),
        new JdeField("ZGUORG", "ZGUORG", JdeDataType.Numeric),
        new JdeField("ZGOSEQ", "ZGOSEQ", JdeDataType.Numeric),
        new JdeField("ZGMCU", "ZGMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40UI17_0", "Primary Key on ZGCTID, ZGJOBS, ZGXLIN, ZGDOCO, ZGDCTO, ZGKCOO, ZGLNID", new[] { "ZGCTID", "ZGJOBS", "ZGXLIN", "ZGDOCO", "ZGDCTO", "ZGKCOO", "ZGLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
