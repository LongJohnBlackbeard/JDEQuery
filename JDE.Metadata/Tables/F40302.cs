using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40302 - .
/// </summary>
public class F40302 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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

        /// <summary>
        /// PUPRAS.
        /// </summary>
        public const string PUPRAS = "PUPRAS";

        /// <summary>
        /// PUOSEQ.
        /// </summary>
        public const string PUOSEQ = "PUOSEQ";

        /// <summary>
        /// PUMCU.
        /// </summary>
        public const string PUMCU = "PUMCU";

        /// <summary>
        /// PUCP01.
        /// </summary>
        public const string PUCP01 = "PUCP01";
    }

    /// <inheritdoc />
    public override string TableName => "F40302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PUAN8", "PUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PUCS02", "PUCS02", JdeDataType.String, 16, true, true),
        new JdeField("PUITM", "PUITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PUIT02", "PUIT02", JdeDataType.String, 16, true, true),
        new JdeField("PUEFTJ", "PUEFTJ", JdeDataType.Numeric),
        new JdeField("PUEXDJ", "PUEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PUMNQ", "PUMNQ", JdeDataType.Numeric),
        new JdeField("PUMXQ", "PUMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PUUOM", "PUUOM", JdeDataType.String, 4, true, true),
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
        new JdeField("PUTDAY", "PUTDAY", JdeDataType.Numeric),
        new JdeField("PUPRAS", "PUPRAS", JdeDataType.String, 2),
        new JdeField("PUOSEQ", "PUOSEQ", JdeDataType.Numeric),
        new JdeField("PUMCU", "PUMCU", JdeDataType.String, 24),
        new JdeField("PUCP01", "PUCP01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40302_0", "Primary Key on PUAN8, PUCS02, PUITM, PUIT02, PUEXDJ, PUUOM, PUMXQ", new[] { "PUAN8", "PUCS02", "PUITM", "PUIT02", "PUEXDJ", "PUUOM", "PUMXQ" }, isUnique: true, isPrimaryKey: true)
    };
}
