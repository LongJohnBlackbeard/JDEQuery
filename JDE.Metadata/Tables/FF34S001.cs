using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF34S001 - .
/// </summary>
public class FF34S001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SQFSCID.
        /// </summary>
        public const string SQFSCID = "SQFSCID";

        /// <summary>
        /// SQPLNID.
        /// </summary>
        public const string SQPLNID = "SQPLNID";

        /// <summary>
        /// SQDFLNID.
        /// </summary>
        public const string SQDFLNID = "SQDFLNID";

        /// <summary>
        /// SQSEQDT.
        /// </summary>
        public const string SQSEQDT = "SQSEQDT";

        /// <summary>
        /// SQSEQNMR.
        /// </summary>
        public const string SQSEQNMR = "SQSEQNMR";

        /// <summary>
        /// SQSEQQTY.
        /// </summary>
        public const string SQSEQQTY = "SQSEQQTY";

        /// <summary>
        /// SQCUSN.
        /// </summary>
        public const string SQCUSN = "SQCUSN";

        /// <summary>
        /// SQSEQID.
        /// </summary>
        public const string SQSEQID = "SQSEQID";

        /// <summary>
        /// SQURCD.
        /// </summary>
        public const string SQURCD = "SQURCD";

        /// <summary>
        /// SQURDT.
        /// </summary>
        public const string SQURDT = "SQURDT";

        /// <summary>
        /// SQURAT.
        /// </summary>
        public const string SQURAT = "SQURAT";

        /// <summary>
        /// SQURAB.
        /// </summary>
        public const string SQURAB = "SQURAB";

        /// <summary>
        /// SQURRF.
        /// </summary>
        public const string SQURRF = "SQURRF";

        /// <summary>
        /// SQUSER.
        /// </summary>
        public const string SQUSER = "SQUSER";

        /// <summary>
        /// SQMKEY.
        /// </summary>
        public const string SQMKEY = "SQMKEY";

        /// <summary>
        /// SQPID.
        /// </summary>
        public const string SQPID = "SQPID";

        /// <summary>
        /// SQUUPMJ.
        /// </summary>
        public const string SQUUPMJ = "SQUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF34S001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SQFSCID", "SQFSCID", JdeDataType.Numeric),
        new JdeField("SQPLNID", "SQPLNID", JdeDataType.Numeric),
        new JdeField("SQDFLNID", "SQDFLNID", JdeDataType.Numeric),
        new JdeField("SQSEQDT", "SQSEQDT", JdeDataType.Date),
        new JdeField("SQSEQNMR", "SQSEQNMR", JdeDataType.Numeric),
        new JdeField("SQSEQQTY", "SQSEQQTY", JdeDataType.Numeric),
        new JdeField("SQCUSN", "SQCUSN", JdeDataType.Numeric),
        new JdeField("SQSEQID", "SQSEQID", JdeDataType.Numeric, null, true, true),
        new JdeField("SQURCD", "SQURCD", JdeDataType.String, 4),
        new JdeField("SQURDT", "SQURDT", JdeDataType.Numeric),
        new JdeField("SQURAT", "SQURAT", JdeDataType.Numeric),
        new JdeField("SQURAB", "SQURAB", JdeDataType.Numeric),
        new JdeField("SQURRF", "SQURRF", JdeDataType.String, 30),
        new JdeField("SQUSER", "SQUSER", JdeDataType.String, 20),
        new JdeField("SQMKEY", "SQMKEY", JdeDataType.String, 30),
        new JdeField("SQPID", "SQPID", JdeDataType.String, 20),
        new JdeField("SQUUPMJ", "SQUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF34S001_0", "Primary Key on SQSEQID", new[] { "SQSEQID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF34S001_3", "Index on SQFSCID", new[] { "SQFSCID" }),
        new JdeIndex("FF34S001_4", "Index on SQPLNID", new[] { "SQPLNID" }),
        new JdeIndex("FF34S001_5", "Index on SQFSCID, SQDFLNID, SQSEQDT, SYS_NC00018$", new[] { "SQFSCID", "SQDFLNID", "SQSEQDT", "SYS_NC00018$" })
    };
}
