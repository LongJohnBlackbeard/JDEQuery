using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI014 - .
/// </summary>
public class F30UI014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BHKIT.
        /// </summary>
        public const string BHKIT = "BHKIT";

        /// <summary>
        /// BHMMCU.
        /// </summary>
        public const string BHMMCU = "BHMMCU";

        /// <summary>
        /// BHBQTY.
        /// </summary>
        public const string BHBQTY = "BHBQTY";

        /// <summary>
        /// BHTBM.
        /// </summary>
        public const string BHTBM = "BHTBM";

        /// <summary>
        /// BHBREV.
        /// </summary>
        public const string BHBREV = "BHBREV";

        /// <summary>
        /// BHSTKT.
        /// </summary>
        public const string BHSTKT = "BHSTKT";

        /// <summary>
        /// BHUOM.
        /// </summary>
        public const string BHUOM = "BHUOM";

        /// <summary>
        /// BHEFFF.
        /// </summary>
        public const string BHEFFF = "BHEFFF";

        /// <summary>
        /// BHEFFT.
        /// </summary>
        public const string BHEFFT = "BHEFFT";

        /// <summary>
        /// BHSRKF.
        /// </summary>
        public const string BHSRKF = "BHSRKF";

        /// <summary>
        /// BHSRNK.
        /// </summary>
        public const string BHSRNK = "BHSRNK";

        /// <summary>
        /// BHUKID.
        /// </summary>
        public const string BHUKID = "BHUKID";

        /// <summary>
        /// BHURCD.
        /// </summary>
        public const string BHURCD = "BHURCD";

        /// <summary>
        /// BHURDT.
        /// </summary>
        public const string BHURDT = "BHURDT";

        /// <summary>
        /// BHURAT.
        /// </summary>
        public const string BHURAT = "BHURAT";

        /// <summary>
        /// BHURAB.
        /// </summary>
        public const string BHURAB = "BHURAB";

        /// <summary>
        /// BHUSER.
        /// </summary>
        public const string BHUSER = "BHUSER";

        /// <summary>
        /// BHPID.
        /// </summary>
        public const string BHPID = "BHPID";

        /// <summary>
        /// BHUPMJ.
        /// </summary>
        public const string BHUPMJ = "BHUPMJ";

        /// <summary>
        /// BHTDAY.
        /// </summary>
        public const string BHTDAY = "BHTDAY";

        /// <summary>
        /// BHMKEY.
        /// </summary>
        public const string BHMKEY = "BHMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BHKIT", "BHKIT", JdeDataType.Numeric, null, true, true),
        new JdeField("BHMMCU", "BHMMCU", JdeDataType.String, 24, true, true),
        new JdeField("BHBQTY", "BHBQTY", JdeDataType.Numeric, null, true, true),
        new JdeField("BHTBM", "BHTBM", JdeDataType.String, 6, true, true),
        new JdeField("BHBREV", "BHBREV", JdeDataType.String, 6, true, true),
        new JdeField("BHSTKT", "BHSTKT", JdeDataType.String, 2),
        new JdeField("BHUOM", "BHUOM", JdeDataType.String, 4),
        new JdeField("BHEFFF", "BHEFFF", JdeDataType.Numeric),
        new JdeField("BHEFFT", "BHEFFT", JdeDataType.Numeric),
        new JdeField("BHSRKF", "BHSRKF", JdeDataType.String, 2),
        new JdeField("BHSRNK", "BHSRNK", JdeDataType.Numeric),
        new JdeField("BHUKID", "BHUKID", JdeDataType.Numeric),
        new JdeField("BHURCD", "BHURCD", JdeDataType.String, 4),
        new JdeField("BHURDT", "BHURDT", JdeDataType.Numeric),
        new JdeField("BHURAT", "BHURAT", JdeDataType.Numeric),
        new JdeField("BHURAB", "BHURAB", JdeDataType.Numeric),
        new JdeField("BHUSER", "BHUSER", JdeDataType.String, 20),
        new JdeField("BHPID", "BHPID", JdeDataType.String, 20),
        new JdeField("BHUPMJ", "BHUPMJ", JdeDataType.Numeric),
        new JdeField("BHTDAY", "BHTDAY", JdeDataType.Numeric),
        new JdeField("BHMKEY", "BHMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI014_0", "Primary Key on BHKIT, BHMMCU, BHTBM, BHBQTY, BHBREV", new[] { "BHKIT", "BHMMCU", "BHTBM", "BHBQTY", "BHBREV" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30UI014_2", "Index on BHUKID", new[] { "BHUKID" })
    };
}
