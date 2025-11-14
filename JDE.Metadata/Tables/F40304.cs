using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40304 - .
/// </summary>
public class F40304 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PEAN8.
        /// </summary>
        public const string PEAN8 = "PEAN8";

        /// <summary>
        /// PECS04.
        /// </summary>
        public const string PECS04 = "PECS04";

        /// <summary>
        /// PEITM.
        /// </summary>
        public const string PEITM = "PEITM";

        /// <summary>
        /// PEIT04.
        /// </summary>
        public const string PEIT04 = "PEIT04";

        /// <summary>
        /// PEEFTJ.
        /// </summary>
        public const string PEEFTJ = "PEEFTJ";

        /// <summary>
        /// PEEXDJ.
        /// </summary>
        public const string PEEXDJ = "PEEXDJ";

        /// <summary>
        /// PEMNQ.
        /// </summary>
        public const string PEMNQ = "PEMNQ";

        /// <summary>
        /// PEMXQ.
        /// </summary>
        public const string PEMXQ = "PEMXQ";

        /// <summary>
        /// PEUOM.
        /// </summary>
        public const string PEUOM = "PEUOM";

        /// <summary>
        /// PETXID.
        /// </summary>
        public const string PETXID = "PETXID";

        /// <summary>
        /// PESTPR.
        /// </summary>
        public const string PESTPR = "PESTPR";

        /// <summary>
        /// PEEUSE.
        /// </summary>
        public const string PEEUSE = "PEEUSE";

        /// <summary>
        /// PEDTYS.
        /// </summary>
        public const string PEDTYS = "PEDTYS";

        /// <summary>
        /// PEURCD.
        /// </summary>
        public const string PEURCD = "PEURCD";

        /// <summary>
        /// PEURDT.
        /// </summary>
        public const string PEURDT = "PEURDT";

        /// <summary>
        /// PEURAT.
        /// </summary>
        public const string PEURAT = "PEURAT";

        /// <summary>
        /// PEURAB.
        /// </summary>
        public const string PEURAB = "PEURAB";

        /// <summary>
        /// PEURRF.
        /// </summary>
        public const string PEURRF = "PEURRF";

        /// <summary>
        /// PEUSER.
        /// </summary>
        public const string PEUSER = "PEUSER";

        /// <summary>
        /// PEPID.
        /// </summary>
        public const string PEPID = "PEPID";

        /// <summary>
        /// PEJOBN.
        /// </summary>
        public const string PEJOBN = "PEJOBN";

        /// <summary>
        /// PEUPMJ.
        /// </summary>
        public const string PEUPMJ = "PEUPMJ";

        /// <summary>
        /// PETDAY.
        /// </summary>
        public const string PETDAY = "PETDAY";

        /// <summary>
        /// PEOSEQ.
        /// </summary>
        public const string PEOSEQ = "PEOSEQ";
    }

    /// <inheritdoc />
    public override string TableName => "F40304";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PEAN8", "PEAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PECS04", "PECS04", JdeDataType.String, 16, true, true),
        new JdeField("PEITM", "PEITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PEIT04", "PEIT04", JdeDataType.String, 16, true, true),
        new JdeField("PEEFTJ", "PEEFTJ", JdeDataType.Numeric),
        new JdeField("PEEXDJ", "PEEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PEMNQ", "PEMNQ", JdeDataType.Numeric),
        new JdeField("PEMXQ", "PEMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PEUOM", "PEUOM", JdeDataType.String, 4, true, true),
        new JdeField("PETXID", "PETXID", JdeDataType.Numeric),
        new JdeField("PESTPR", "PESTPR", JdeDataType.String, 2),
        new JdeField("PEEUSE", "PEEUSE", JdeDataType.String, 6),
        new JdeField("PEDTYS", "PEDTYS", JdeDataType.String, 4),
        new JdeField("PEURCD", "PEURCD", JdeDataType.String, 4),
        new JdeField("PEURDT", "PEURDT", JdeDataType.Numeric),
        new JdeField("PEURAT", "PEURAT", JdeDataType.Numeric),
        new JdeField("PEURAB", "PEURAB", JdeDataType.Numeric),
        new JdeField("PEURRF", "PEURRF", JdeDataType.String, 30),
        new JdeField("PEUSER", "PEUSER", JdeDataType.String, 20),
        new JdeField("PEPID", "PEPID", JdeDataType.String, 20),
        new JdeField("PEJOBN", "PEJOBN", JdeDataType.String, 20),
        new JdeField("PEUPMJ", "PEUPMJ", JdeDataType.Numeric),
        new JdeField("PETDAY", "PETDAY", JdeDataType.Numeric),
        new JdeField("PEOSEQ", "PEOSEQ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40304_0", "Primary Key on PEAN8, PECS04, PEITM, PEIT04, PEEXDJ, PEUOM, PEMXQ", new[] { "PEAN8", "PECS04", "PEITM", "PEIT04", "PEEXDJ", "PEUOM", "PEMXQ" }, isUnique: true, isPrimaryKey: true)
    };
}
