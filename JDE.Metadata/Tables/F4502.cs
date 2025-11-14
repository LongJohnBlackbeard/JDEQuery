using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4502 - .
/// </summary>
public class F4502 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FGCATLG.
        /// </summary>
        public const string FGCATLG = "FGCATLG";

        /// <summary>
        /// FGLITM.
        /// </summary>
        public const string FGLITM = "FGLITM";

        /// <summary>
        /// FGEFTJ.
        /// </summary>
        public const string FGEFTJ = "FGEFTJ";

        /// <summary>
        /// FGEXDJ.
        /// </summary>
        public const string FGEXDJ = "FGEXDJ";

        /// <summary>
        /// FGUSER.
        /// </summary>
        public const string FGUSER = "FGUSER";

        /// <summary>
        /// FGPID.
        /// </summary>
        public const string FGPID = "FGPID";

        /// <summary>
        /// FGJOBN.
        /// </summary>
        public const string FGJOBN = "FGJOBN";

        /// <summary>
        /// FGUPMJ.
        /// </summary>
        public const string FGUPMJ = "FGUPMJ";

        /// <summary>
        /// FGTDAY.
        /// </summary>
        public const string FGTDAY = "FGTDAY";

        /// <summary>
        /// FGURAB.
        /// </summary>
        public const string FGURAB = "FGURAB";

        /// <summary>
        /// FGURAT.
        /// </summary>
        public const string FGURAT = "FGURAT";

        /// <summary>
        /// FGURCD.
        /// </summary>
        public const string FGURCD = "FGURCD";

        /// <summary>
        /// FGURRF.
        /// </summary>
        public const string FGURRF = "FGURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F4502";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FGCATLG", "FGCATLG", JdeDataType.String, 20, true, true),
        new JdeField("FGLITM", "FGLITM", JdeDataType.String, 50, true, true),
        new JdeField("FGEFTJ", "FGEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("FGEXDJ", "FGEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("FGUSER", "FGUSER", JdeDataType.String, 20),
        new JdeField("FGPID", "FGPID", JdeDataType.String, 20),
        new JdeField("FGJOBN", "FGJOBN", JdeDataType.String, 20),
        new JdeField("FGUPMJ", "FGUPMJ", JdeDataType.Numeric),
        new JdeField("FGTDAY", "FGTDAY", JdeDataType.Numeric),
        new JdeField("FGURAB", "FGURAB", JdeDataType.Numeric),
        new JdeField("FGURAT", "FGURAT", JdeDataType.Numeric),
        new JdeField("FGURCD", "FGURCD", JdeDataType.String, 4),
        new JdeField("FGURRF", "FGURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4502_0", "Primary Key on FGCATLG, FGLITM, FGEFTJ, FGEXDJ", new[] { "FGCATLG", "FGLITM", "FGEFTJ", "FGEXDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
