using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40341 - .
/// </summary>
public class F40341 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NSAN8.
        /// </summary>
        public const string NSAN8 = "NSAN8";

        /// <summary>
        /// NSCS41.
        /// </summary>
        public const string NSCS41 = "NSCS41";

        /// <summary>
        /// NSITM.
        /// </summary>
        public const string NSITM = "NSITM";

        /// <summary>
        /// NSIT41.
        /// </summary>
        public const string NSIT41 = "NSIT41";

        /// <summary>
        /// NSEFTJ.
        /// </summary>
        public const string NSEFTJ = "NSEFTJ";

        /// <summary>
        /// NSEXDJ.
        /// </summary>
        public const string NSEXDJ = "NSEXDJ";

        /// <summary>
        /// NSMNQ.
        /// </summary>
        public const string NSMNQ = "NSMNQ";

        /// <summary>
        /// NSMXQ.
        /// </summary>
        public const string NSMXQ = "NSMXQ";

        /// <summary>
        /// NSUOM.
        /// </summary>
        public const string NSUOM = "NSUOM";

        /// <summary>
        /// NSTXID.
        /// </summary>
        public const string NSTXID = "NSTXID";

        /// <summary>
        /// NSSTPR.
        /// </summary>
        public const string NSSTPR = "NSSTPR";

        /// <summary>
        /// NSOSEQ.
        /// </summary>
        public const string NSOSEQ = "NSOSEQ";

        /// <summary>
        /// NSMCU.
        /// </summary>
        public const string NSMCU = "NSMCU";

        /// <summary>
        /// NSDCTO.
        /// </summary>
        public const string NSDCTO = "NSDCTO";

        /// <summary>
        /// NSLNTY.
        /// </summary>
        public const string NSLNTY = "NSLNTY";

        /// <summary>
        /// NSLTTR.
        /// </summary>
        public const string NSLTTR = "NSLTTR";

        /// <summary>
        /// NSNXTR.
        /// </summary>
        public const string NSNXTR = "NSNXTR";

        /// <summary>
        /// NSURCD.
        /// </summary>
        public const string NSURCD = "NSURCD";

        /// <summary>
        /// NSURDT.
        /// </summary>
        public const string NSURDT = "NSURDT";

        /// <summary>
        /// NSURAT.
        /// </summary>
        public const string NSURAT = "NSURAT";

        /// <summary>
        /// NSURAB.
        /// </summary>
        public const string NSURAB = "NSURAB";

        /// <summary>
        /// NSURRF.
        /// </summary>
        public const string NSURRF = "NSURRF";

        /// <summary>
        /// NSUSER.
        /// </summary>
        public const string NSUSER = "NSUSER";

        /// <summary>
        /// NSPID.
        /// </summary>
        public const string NSPID = "NSPID";

        /// <summary>
        /// NSJOBN.
        /// </summary>
        public const string NSJOBN = "NSJOBN";

        /// <summary>
        /// NSUPMJ.
        /// </summary>
        public const string NSUPMJ = "NSUPMJ";

        /// <summary>
        /// NSTDAY.
        /// </summary>
        public const string NSTDAY = "NSTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40341";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NSAN8", "NSAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NSCS41", "NSCS41", JdeDataType.String, 16, true, true),
        new JdeField("NSITM", "NSITM", JdeDataType.Numeric, null, true, true),
        new JdeField("NSIT41", "NSIT41", JdeDataType.String, 16, true, true),
        new JdeField("NSEFTJ", "NSEFTJ", JdeDataType.Numeric),
        new JdeField("NSEXDJ", "NSEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("NSMNQ", "NSMNQ", JdeDataType.Numeric),
        new JdeField("NSMXQ", "NSMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("NSUOM", "NSUOM", JdeDataType.String, 4, true, true),
        new JdeField("NSTXID", "NSTXID", JdeDataType.Numeric),
        new JdeField("NSSTPR", "NSSTPR", JdeDataType.String, 2),
        new JdeField("NSOSEQ", "NSOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("NSMCU", "NSMCU", JdeDataType.String, 24),
        new JdeField("NSDCTO", "NSDCTO", JdeDataType.String, 4),
        new JdeField("NSLNTY", "NSLNTY", JdeDataType.String, 4),
        new JdeField("NSLTTR", "NSLTTR", JdeDataType.String, 6),
        new JdeField("NSNXTR", "NSNXTR", JdeDataType.String, 6),
        new JdeField("NSURCD", "NSURCD", JdeDataType.String, 4),
        new JdeField("NSURDT", "NSURDT", JdeDataType.Numeric),
        new JdeField("NSURAT", "NSURAT", JdeDataType.Numeric),
        new JdeField("NSURAB", "NSURAB", JdeDataType.Numeric),
        new JdeField("NSURRF", "NSURRF", JdeDataType.String, 30),
        new JdeField("NSUSER", "NSUSER", JdeDataType.String, 20),
        new JdeField("NSPID", "NSPID", JdeDataType.String, 20),
        new JdeField("NSJOBN", "NSJOBN", JdeDataType.String, 20),
        new JdeField("NSUPMJ", "NSUPMJ", JdeDataType.Numeric),
        new JdeField("NSTDAY", "NSTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40341_0", "Primary Key on NSAN8, NSCS41, NSITM, NSIT41, NSEXDJ, NSUOM, NSMXQ, NSOSEQ", new[] { "NSAN8", "NSCS41", "NSITM", "NSIT41", "NSEXDJ", "NSUOM", "NSMXQ", "NSOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
