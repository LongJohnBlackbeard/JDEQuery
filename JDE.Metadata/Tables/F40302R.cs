using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40302R - .
/// </summary>
public class F40302R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PUUKID.
        /// </summary>
        public const string PUUKID = "PUUKID";

        /// <summary>
        /// PUREFC.
        /// </summary>
        public const string PUREFC = "PUREFC";

        /// <summary>
        /// PUAN8.
        /// </summary>
        public const string PUAN8 = "PUAN8";

        /// <summary>
        /// PUCS02.
        /// </summary>
        public const string PUCS02 = "PUCS02";

        /// <summary>
        /// PUITM.
        /// </summary>
        public const string PUITM = "PUITM";

        /// <summary>
        /// PUIT02.
        /// </summary>
        public const string PUIT02 = "PUIT02";

        /// <summary>
        /// PUEFTJ.
        /// </summary>
        public const string PUEFTJ = "PUEFTJ";

        /// <summary>
        /// PUEXDJ.
        /// </summary>
        public const string PUEXDJ = "PUEXDJ";

        /// <summary>
        /// PUMNQ.
        /// </summary>
        public const string PUMNQ = "PUMNQ";

        /// <summary>
        /// PUMXQ.
        /// </summary>
        public const string PUMXQ = "PUMXQ";

        /// <summary>
        /// PUUOM.
        /// </summary>
        public const string PUUOM = "PUUOM";

        /// <summary>
        /// PUTXID.
        /// </summary>
        public const string PUTXID = "PUTXID";

        /// <summary>
        /// PUSTPR.
        /// </summary>
        public const string PUSTPR = "PUSTPR";

        /// <summary>
        /// PUUOM4.
        /// </summary>
        public const string PUUOM4 = "PUUOM4";

        /// <summary>
        /// PUURCD.
        /// </summary>
        public const string PUURCD = "PUURCD";

        /// <summary>
        /// PUURDT.
        /// </summary>
        public const string PUURDT = "PUURDT";

        /// <summary>
        /// PUURAT.
        /// </summary>
        public const string PUURAT = "PUURAT";

        /// <summary>
        /// PUURAB.
        /// </summary>
        public const string PUURAB = "PUURAB";

        /// <summary>
        /// PUURRF.
        /// </summary>
        public const string PUURRF = "PUURRF";

        /// <summary>
        /// PUUSER.
        /// </summary>
        public const string PUUSER = "PUUSER";

        /// <summary>
        /// PUPID.
        /// </summary>
        public const string PUPID = "PUPID";

        /// <summary>
        /// PUJOBN.
        /// </summary>
        public const string PUJOBN = "PUJOBN";

        /// <summary>
        /// PUUPMJ.
        /// </summary>
        public const string PUUPMJ = "PUUPMJ";

        /// <summary>
        /// PUTDAY.
        /// </summary>
        public const string PUTDAY = "PUTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40302R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PUUKID", "PUUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PUREFC", "PUREFC", JdeDataType.Numeric),
        new JdeField("PUAN8", "PUAN8", JdeDataType.Numeric),
        new JdeField("PUCS02", "PUCS02", JdeDataType.String, 16),
        new JdeField("PUITM", "PUITM", JdeDataType.Numeric),
        new JdeField("PUIT02", "PUIT02", JdeDataType.String, 16),
        new JdeField("PUEFTJ", "PUEFTJ", JdeDataType.Numeric),
        new JdeField("PUEXDJ", "PUEXDJ", JdeDataType.Numeric),
        new JdeField("PUMNQ", "PUMNQ", JdeDataType.Numeric),
        new JdeField("PUMXQ", "PUMXQ", JdeDataType.Numeric),
        new JdeField("PUUOM", "PUUOM", JdeDataType.String, 4),
        new JdeField("PUTXID", "PUTXID", JdeDataType.Numeric),
        new JdeField("PUSTPR", "PUSTPR", JdeDataType.String, 2),
        new JdeField("PUUOM4", "PUUOM4", JdeDataType.String, 4),
        new JdeField("PUURCD", "PUURCD", JdeDataType.String, 4),
        new JdeField("PUURDT", "PUURDT", JdeDataType.Numeric),
        new JdeField("PUURAT", "PUURAT", JdeDataType.Numeric),
        new JdeField("PUURAB", "PUURAB", JdeDataType.Numeric),
        new JdeField("PUURRF", "PUURRF", JdeDataType.String, 30),
        new JdeField("PUUSER", "PUUSER", JdeDataType.String, 20),
        new JdeField("PUPID", "PUPID", JdeDataType.String, 20),
        new JdeField("PUJOBN", "PUJOBN", JdeDataType.String, 20),
        new JdeField("PUUPMJ", "PUUPMJ", JdeDataType.Numeric),
        new JdeField("PUTDAY", "PUTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40302R_0", "Primary Key on PUUKID", new[] { "PUUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40302R_2", "Index on PUAN8, PUCS02, PUITM, PUIT02, PUEXDJ, PUMXQ, PUUOM, PUUOM4, PUUPMJ, PUTDAY", new[] { "PUAN8", "PUCS02", "PUITM", "PUIT02", "PUEXDJ", "PUMXQ", "PUUOM", "PUUOM4", "PUUPMJ", "PUTDAY" })
    };
}
