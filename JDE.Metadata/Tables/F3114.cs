using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3114 - .
/// </summary>
public class F3114 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IQITM.
        /// </summary>
        public const string IQITM = "IQITM";

        /// <summary>
        /// IQMMCU.
        /// </summary>
        public const string IQMMCU = "IQMMCU";

        /// <summary>
        /// IQMCU.
        /// </summary>
        public const string IQMCU = "IQMCU";

        /// <summary>
        /// IQSCHT.
        /// </summary>
        public const string IQSCHT = "IQSCHT";

        /// <summary>
        /// IQSHFT.
        /// </summary>
        public const string IQSHFT = "IQSHFT";

        /// <summary>
        /// IQTRDJ.
        /// </summary>
        public const string IQTRDJ = "IQTRDJ";

        /// <summary>
        /// IQSOQS.
        /// </summary>
        public const string IQSOQS = "IQSOQS";

        /// <summary>
        /// IQSOCN.
        /// </summary>
        public const string IQSOCN = "IQSOCN";

        /// <summary>
        /// IQUOM.
        /// </summary>
        public const string IQUOM = "IQUOM";

        /// <summary>
        /// IQSETL.
        /// </summary>
        public const string IQSETL = "IQSETL";

        /// <summary>
        /// IQRUNL.
        /// </summary>
        public const string IQRUNL = "IQRUNL";

        /// <summary>
        /// IQRUNM.
        /// </summary>
        public const string IQRUNM = "IQRUNM";

        /// <summary>
        /// IQSETA.
        /// </summary>
        public const string IQSETA = "IQSETA";

        /// <summary>
        /// IQLABA.
        /// </summary>
        public const string IQLABA = "IQLABA";

        /// <summary>
        /// IQMACA.
        /// </summary>
        public const string IQMACA = "IQMACA";

        /// <summary>
        /// IQUSER.
        /// </summary>
        public const string IQUSER = "IQUSER";

        /// <summary>
        /// IQPID.
        /// </summary>
        public const string IQPID = "IQPID";

        /// <summary>
        /// IQUPMJ.
        /// </summary>
        public const string IQUPMJ = "IQUPMJ";

        /// <summary>
        /// IQJOBN.
        /// </summary>
        public const string IQJOBN = "IQJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F3114";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IQITM", "IQITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IQMMCU", "IQMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IQMCU", "IQMCU", JdeDataType.String, 24, true, true),
        new JdeField("IQSCHT", "IQSCHT", JdeDataType.String, 4, true, true),
        new JdeField("IQSHFT", "IQSHFT", JdeDataType.String, 2),
        new JdeField("IQTRDJ", "IQTRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("IQSOQS", "IQSOQS", JdeDataType.Numeric),
        new JdeField("IQSOCN", "IQSOCN", JdeDataType.Numeric),
        new JdeField("IQUOM", "IQUOM", JdeDataType.String, 4),
        new JdeField("IQSETL", "IQSETL", JdeDataType.Numeric),
        new JdeField("IQRUNL", "IQRUNL", JdeDataType.Numeric),
        new JdeField("IQRUNM", "IQRUNM", JdeDataType.Numeric),
        new JdeField("IQSETA", "IQSETA", JdeDataType.Numeric),
        new JdeField("IQLABA", "IQLABA", JdeDataType.Numeric),
        new JdeField("IQMACA", "IQMACA", JdeDataType.Numeric),
        new JdeField("IQUSER", "IQUSER", JdeDataType.String, 20),
        new JdeField("IQPID", "IQPID", JdeDataType.String, 20),
        new JdeField("IQUPMJ", "IQUPMJ", JdeDataType.Numeric),
        new JdeField("IQJOBN", "IQJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3114_0", "Primary Key on IQITM, IQMCU, IQMMCU, IQSCHT, IQTRDJ", new[] { "IQITM", "IQMCU", "IQMMCU", "IQSCHT", "IQTRDJ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3114_2", "Index on IQMMCU, IQMCU, IQSCHT, IQTRDJ, IQITM", new[] { "IQMMCU", "IQMCU", "IQSCHT", "IQTRDJ", "IQITM" })
    };
}
