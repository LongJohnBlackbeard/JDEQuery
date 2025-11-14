using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L910 - .
/// </summary>
public class FF30L910 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LHLNDSID.
        /// </summary>
        public const string LHLNDSID = "LHLNDSID";

        /// <summary>
        /// LHDFLNID.
        /// </summary>
        public const string LHDFLNID = "LHDFLNID";

        /// <summary>
        /// LHFSCID.
        /// </summary>
        public const string LHFSCID = "LHFSCID";

        /// <summary>
        /// LHLNDSNA.
        /// </summary>
        public const string LHLNDSNA = "LHLNDSNA";

        /// <summary>
        /// LHLDDD.
        /// </summary>
        public const string LHLDDD = "LHLDDD";

        /// <summary>
        /// LHLDACT.
        /// </summary>
        public const string LHLDACT = "LHLDACT";

        /// <summary>
        /// LHPMAPID.
        /// </summary>
        public const string LHPMAPID = "LHPMAPID";

        /// <summary>
        /// LHDS01.
        /// </summary>
        public const string LHDS01 = "LHDS01";

        /// <summary>
        /// LHDTYPE.
        /// </summary>
        public const string LHDTYPE = "LHDTYPE";

        /// <summary>
        /// LHDFLDTY.
        /// </summary>
        public const string LHDFLDTY = "LHDFLDTY";

        /// <summary>
        /// LHDFLDSC.
        /// </summary>
        public const string LHDFLDSC = "LHDFLDSC";

        /// <summary>
        /// LHDFDMP.
        /// </summary>
        public const string LHDFDMP = "LHDFDMP";

        /// <summary>
        /// LHURCD.
        /// </summary>
        public const string LHURCD = "LHURCD";

        /// <summary>
        /// LHURDT.
        /// </summary>
        public const string LHURDT = "LHURDT";

        /// <summary>
        /// LHURAT.
        /// </summary>
        public const string LHURAT = "LHURAT";

        /// <summary>
        /// LHURAB.
        /// </summary>
        public const string LHURAB = "LHURAB";

        /// <summary>
        /// LHURRF.
        /// </summary>
        public const string LHURRF = "LHURRF";

        /// <summary>
        /// LHUSER.
        /// </summary>
        public const string LHUSER = "LHUSER";

        /// <summary>
        /// LHMKEY.
        /// </summary>
        public const string LHMKEY = "LHMKEY";

        /// <summary>
        /// LHPID.
        /// </summary>
        public const string LHPID = "LHPID";

        /// <summary>
        /// LHUUPMJ.
        /// </summary>
        public const string LHUUPMJ = "LHUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L910";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LHLNDSID", "LHLNDSID", JdeDataType.Numeric, null, true, true),
        new JdeField("LHDFLNID", "LHDFLNID", JdeDataType.Numeric),
        new JdeField("LHFSCID", "LHFSCID", JdeDataType.Numeric),
        new JdeField("LHLNDSNA", "LHLNDSNA", JdeDataType.String, 60),
        new JdeField("LHLDDD", "LHLDDD", JdeDataType.Date),
        new JdeField("LHLDACT", "LHLDACT", JdeDataType.String, 2),
        new JdeField("LHPMAPID", "LHPMAPID", JdeDataType.Numeric),
        new JdeField("LHDS01", "LHDS01", JdeDataType.String, 160),
        new JdeField("LHDTYPE", "LHDTYPE", JdeDataType.String, 4),
        new JdeField("LHDFLDTY", "LHDFLDTY", JdeDataType.String, 2),
        new JdeField("LHDFLDSC", "LHDFLDSC", JdeDataType.String, 4),
        new JdeField("LHDFDMP", "LHDFDMP", JdeDataType.Numeric),
        new JdeField("LHURCD", "LHURCD", JdeDataType.String, 4),
        new JdeField("LHURDT", "LHURDT", JdeDataType.Numeric),
        new JdeField("LHURAT", "LHURAT", JdeDataType.Numeric),
        new JdeField("LHURAB", "LHURAB", JdeDataType.Numeric),
        new JdeField("LHURRF", "LHURRF", JdeDataType.String, 30),
        new JdeField("LHUSER", "LHUSER", JdeDataType.String, 20),
        new JdeField("LHMKEY", "LHMKEY", JdeDataType.String, 30),
        new JdeField("LHPID", "LHPID", JdeDataType.String, 20),
        new JdeField("LHUUPMJ", "LHUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L910_0", "Primary Key on LHLNDSID", new[] { "LHLNDSID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L910_2", "Unique Index on LHFSCID, LHLNDSNA", new[] { "LHFSCID", "LHLNDSNA" }, isUnique: true),
        new JdeIndex("FF30L910_3", "Index on LHFSCID", new[] { "LHFSCID" }),
        new JdeIndex("FF30L910_4", "Index on LHDFLNID, LHLDACT", new[] { "LHDFLNID", "LHLDACT" }),
        new JdeIndex("FF30L910_5", "Unique Index on LHLNDSID, LHDFLNID", new[] { "LHLNDSID", "LHDFLNID" }, isUnique: true),
        new JdeIndex("FF30L910_6", "Index on LHFSCID, LHPMAPID", new[] { "LHFSCID", "LHPMAPID" })
    };
}
