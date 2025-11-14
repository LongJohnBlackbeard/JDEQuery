using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085573W - .
/// </summary>
public class F085573W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MMEVET.
        /// </summary>
        public const string MMEVET = "MMEVET";

        /// <summary>
        /// MMPDBA.
        /// </summary>
        public const string MMPDBA = "MMPDBA";

        /// <summary>
        /// MMPFRQ.
        /// </summary>
        public const string MMPFRQ = "MMPFRQ";

        /// <summary>
        /// MMFRQT.
        /// </summary>
        public const string MMFRQT = "MMFRQT";

        /// <summary>
        /// MMMINCOV.
        /// </summary>
        public const string MMMINCOV = "MMMINCOV";

        /// <summary>
        /// MMMAXCOV.
        /// </summary>
        public const string MMMAXCOV = "MMMAXCOV";

        /// <summary>
        /// MMUSER.
        /// </summary>
        public const string MMUSER = "MMUSER";

        /// <summary>
        /// MMPID.
        /// </summary>
        public const string MMPID = "MMPID";

        /// <summary>
        /// MMJOBN.
        /// </summary>
        public const string MMJOBN = "MMJOBN";

        /// <summary>
        /// MMUPMJ.
        /// </summary>
        public const string MMUPMJ = "MMUPMJ";

        /// <summary>
        /// MMUPMT.
        /// </summary>
        public const string MMUPMT = "MMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F085573W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MMEVET", "MMEVET", JdeDataType.Numeric, null, true, true),
        new JdeField("MMPDBA", "MMPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("MMPFRQ", "MMPFRQ", JdeDataType.String, 2, true, true),
        new JdeField("MMFRQT", "MMFRQT", JdeDataType.Numeric),
        new JdeField("MMMINCOV", "MMMINCOV", JdeDataType.Numeric),
        new JdeField("MMMAXCOV", "MMMAXCOV", JdeDataType.Numeric),
        new JdeField("MMUSER", "MMUSER", JdeDataType.String, 20),
        new JdeField("MMPID", "MMPID", JdeDataType.String, 20),
        new JdeField("MMJOBN", "MMJOBN", JdeDataType.String, 20),
        new JdeField("MMUPMJ", "MMUPMJ", JdeDataType.Numeric),
        new JdeField("MMUPMT", "MMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085573W_0", "Primary Key on MMEVET, MMPDBA, MMPFRQ", new[] { "MMEVET", "MMPDBA", "MMPFRQ" }, isUnique: true, isPrimaryKey: true)
    };
}
