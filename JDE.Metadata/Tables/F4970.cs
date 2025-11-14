using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4970 - .
/// </summary>
public class F4970 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FTFRSC.
        /// </summary>
        public const string FTFRSC = "FTFRSC";

        /// <summary>
        /// FTOSEQ.
        /// </summary>
        public const string FTOSEQ = "FTOSEQ";

        /// <summary>
        /// FTRTNM.
        /// </summary>
        public const string FTRTNM = "FTRTNM";

        /// <summary>
        /// FTFSC2.
        /// </summary>
        public const string FTFSC2 = "FTFSC2";

        /// <summary>
        /// FTSRTP.
        /// </summary>
        public const string FTSRTP = "FTSRTP";

        /// <summary>
        /// FTUSER.
        /// </summary>
        public const string FTUSER = "FTUSER";

        /// <summary>
        /// FTPID.
        /// </summary>
        public const string FTPID = "FTPID";

        /// <summary>
        /// FTJOBN.
        /// </summary>
        public const string FTJOBN = "FTJOBN";

        /// <summary>
        /// FTUPMJ.
        /// </summary>
        public const string FTUPMJ = "FTUPMJ";

        /// <summary>
        /// FTTDAY.
        /// </summary>
        public const string FTTDAY = "FTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4970";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FTFRSC", "FTFRSC", JdeDataType.String, 16, true, true),
        new JdeField("FTOSEQ", "FTOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("FTRTNM", "FTRTNM", JdeDataType.String, 20),
        new JdeField("FTFSC2", "FTFSC2", JdeDataType.String, 16),
        new JdeField("FTSRTP", "FTSRTP", JdeDataType.String, 2),
        new JdeField("FTUSER", "FTUSER", JdeDataType.String, 20),
        new JdeField("FTPID", "FTPID", JdeDataType.String, 20),
        new JdeField("FTJOBN", "FTJOBN", JdeDataType.String, 20),
        new JdeField("FTUPMJ", "FTUPMJ", JdeDataType.Numeric),
        new JdeField("FTTDAY", "FTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4970_0", "Primary Key on FTFRSC, FTOSEQ", new[] { "FTFRSC", "FTOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
