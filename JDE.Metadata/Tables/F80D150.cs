using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D150 - .
/// </summary>
public class F80D150 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RLWBTYPE.
        /// </summary>
        public const string RLWBTYPE = "RLWBTYPE";

        /// <summary>
        /// RLEMAL.
        /// </summary>
        public const string RLEMAL = "RLEMAL";

        /// <summary>
        /// RLAN8.
        /// </summary>
        public const string RLAN8 = "RLAN8";

        /// <summary>
        /// RLPA8.
        /// </summary>
        public const string RLPA8 = "RLPA8";

        /// <summary>
        /// RLOSTP.
        /// </summary>
        public const string RLOSTP = "RLOSTP";

        /// <summary>
        /// RLMBDS.
        /// </summary>
        public const string RLMBDS = "RLMBDS";

        /// <summary>
        /// RLURCD.
        /// </summary>
        public const string RLURCD = "RLURCD";

        /// <summary>
        /// RLURDT.
        /// </summary>
        public const string RLURDT = "RLURDT";

        /// <summary>
        /// RLURAT.
        /// </summary>
        public const string RLURAT = "RLURAT";

        /// <summary>
        /// RLURAB.
        /// </summary>
        public const string RLURAB = "RLURAB";

        /// <summary>
        /// RLURRF.
        /// </summary>
        public const string RLURRF = "RLURRF";

        /// <summary>
        /// RLUSER.
        /// </summary>
        public const string RLUSER = "RLUSER";

        /// <summary>
        /// RLPID.
        /// </summary>
        public const string RLPID = "RLPID";

        /// <summary>
        /// RLMKEY.
        /// </summary>
        public const string RLMKEY = "RLMKEY";

        /// <summary>
        /// RLUUPMJ.
        /// </summary>
        public const string RLUUPMJ = "RLUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D150";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RLWBTYPE", "RLWBTYPE", JdeDataType.String, 2, true, true),
        new JdeField("RLEMAL", "RLEMAL", JdeDataType.String, 512),
        new JdeField("RLAN8", "RLAN8", JdeDataType.Numeric),
        new JdeField("RLPA8", "RLPA8", JdeDataType.Numeric),
        new JdeField("RLOSTP", "RLOSTP", JdeDataType.String, 6),
        new JdeField("RLMBDS", "RLMBDS", JdeDataType.String, 4),
        new JdeField("RLURCD", "RLURCD", JdeDataType.String, 4),
        new JdeField("RLURDT", "RLURDT", JdeDataType.Numeric),
        new JdeField("RLURAT", "RLURAT", JdeDataType.Numeric),
        new JdeField("RLURAB", "RLURAB", JdeDataType.Numeric),
        new JdeField("RLURRF", "RLURRF", JdeDataType.String, 30),
        new JdeField("RLUSER", "RLUSER", JdeDataType.String, 20),
        new JdeField("RLPID", "RLPID", JdeDataType.String, 20),
        new JdeField("RLMKEY", "RLMKEY", JdeDataType.String, 30),
        new JdeField("RLUUPMJ", "RLUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D150_0", "Primary Key on RLWBTYPE", new[] { "RLWBTYPE" }, isUnique: true, isPrimaryKey: true)
    };
}
