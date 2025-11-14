using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40347 - .
/// </summary>
public class F40347 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RIAN8.
        /// </summary>
        public const string RIAN8 = "RIAN8";

        /// <summary>
        /// RICS47.
        /// </summary>
        public const string RICS47 = "RICS47";

        /// <summary>
        /// RIITM.
        /// </summary>
        public const string RIITM = "RIITM";

        /// <summary>
        /// RIIT47.
        /// </summary>
        public const string RIIT47 = "RIIT47";

        /// <summary>
        /// RIEFTJ.
        /// </summary>
        public const string RIEFTJ = "RIEFTJ";

        /// <summary>
        /// RIEXDJ.
        /// </summary>
        public const string RIEXDJ = "RIEXDJ";

        /// <summary>
        /// RIMNQ.
        /// </summary>
        public const string RIMNQ = "RIMNQ";

        /// <summary>
        /// RIMXQ.
        /// </summary>
        public const string RIMXQ = "RIMXQ";

        /// <summary>
        /// RIUOM.
        /// </summary>
        public const string RIUOM = "RIUOM";

        /// <summary>
        /// RITXID.
        /// </summary>
        public const string RITXID = "RITXID";

        /// <summary>
        /// RISTPR.
        /// </summary>
        public const string RISTPR = "RISTPR";

        /// <summary>
        /// RIOSEQ.
        /// </summary>
        public const string RIOSEQ = "RIOSEQ";

        /// <summary>
        /// RIMCU.
        /// </summary>
        public const string RIMCU = "RIMCU";

        /// <summary>
        /// RIUOM4.
        /// </summary>
        public const string RIUOM4 = "RIUOM4";

        /// <summary>
        /// RIPRAS.
        /// </summary>
        public const string RIPRAS = "RIPRAS";

        /// <summary>
        /// RICP01.
        /// </summary>
        public const string RICP01 = "RICP01";

        /// <summary>
        /// RIURCD.
        /// </summary>
        public const string RIURCD = "RIURCD";

        /// <summary>
        /// RIURDT.
        /// </summary>
        public const string RIURDT = "RIURDT";

        /// <summary>
        /// RIURAT.
        /// </summary>
        public const string RIURAT = "RIURAT";

        /// <summary>
        /// RIURAB.
        /// </summary>
        public const string RIURAB = "RIURAB";

        /// <summary>
        /// RIURRF.
        /// </summary>
        public const string RIURRF = "RIURRF";

        /// <summary>
        /// RIUSER.
        /// </summary>
        public const string RIUSER = "RIUSER";

        /// <summary>
        /// RIPID.
        /// </summary>
        public const string RIPID = "RIPID";

        /// <summary>
        /// RIJOBN.
        /// </summary>
        public const string RIJOBN = "RIJOBN";

        /// <summary>
        /// RIUPMJ.
        /// </summary>
        public const string RIUPMJ = "RIUPMJ";

        /// <summary>
        /// RITDAY.
        /// </summary>
        public const string RITDAY = "RITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40347";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RIAN8", "RIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RICS47", "RICS47", JdeDataType.String, 16, true, true),
        new JdeField("RIITM", "RIITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RIIT47", "RIIT47", JdeDataType.String, 16, true, true),
        new JdeField("RIEFTJ", "RIEFTJ", JdeDataType.Numeric),
        new JdeField("RIEXDJ", "RIEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("RIMNQ", "RIMNQ", JdeDataType.Numeric),
        new JdeField("RIMXQ", "RIMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RIUOM", "RIUOM", JdeDataType.String, 4, true, true),
        new JdeField("RITXID", "RITXID", JdeDataType.Numeric),
        new JdeField("RISTPR", "RISTPR", JdeDataType.String, 2),
        new JdeField("RIOSEQ", "RIOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RIMCU", "RIMCU", JdeDataType.String, 24),
        new JdeField("RIUOM4", "RIUOM4", JdeDataType.String, 4),
        new JdeField("RIPRAS", "RIPRAS", JdeDataType.String, 2),
        new JdeField("RICP01", "RICP01", JdeDataType.String, 2),
        new JdeField("RIURCD", "RIURCD", JdeDataType.String, 4),
        new JdeField("RIURDT", "RIURDT", JdeDataType.Numeric),
        new JdeField("RIURAT", "RIURAT", JdeDataType.Numeric),
        new JdeField("RIURAB", "RIURAB", JdeDataType.Numeric),
        new JdeField("RIURRF", "RIURRF", JdeDataType.String, 30),
        new JdeField("RIUSER", "RIUSER", JdeDataType.String, 20),
        new JdeField("RIPID", "RIPID", JdeDataType.String, 20),
        new JdeField("RIJOBN", "RIJOBN", JdeDataType.String, 20),
        new JdeField("RIUPMJ", "RIUPMJ", JdeDataType.Numeric),
        new JdeField("RITDAY", "RITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40347_0", "Primary Key on RIAN8, RICS47, RIITM, RIIT47, RIEXDJ, RIUOM, RIMXQ, RIOSEQ", new[] { "RIAN8", "RICS47", "RIITM", "RIIT47", "RIEXDJ", "RIUOM", "RIMXQ", "RIOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
