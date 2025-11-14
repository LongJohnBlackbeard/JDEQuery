using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0728 - .
/// </summary>
public class F0728 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YWAN8.
        /// </summary>
        public const string YWAN8 = "YWAN8";

        /// <summary>
        /// YWPRTR.
        /// </summary>
        public const string YWPRTR = "YWPRTR";

        /// <summary>
        /// YWDWK.
        /// </summary>
        public const string YWDWK = "YWDWK";

        /// <summary>
        /// YWCKCN.
        /// </summary>
        public const string YWCKCN = "YWCKCN";

        /// <summary>
        /// YWPDBA.
        /// </summary>
        public const string YWPDBA = "YWPDBA";

        /// <summary>
        /// YWRTWC.
        /// </summary>
        public const string YWRTWC = "YWRTWC";

        /// <summary>
        /// YWWCAM.
        /// </summary>
        public const string YWWCAM = "YWWCAM";

        /// <summary>
        /// YWPHRW.
        /// </summary>
        public const string YWPHRW = "YWPHRW";

        /// <summary>
        /// YWUSER.
        /// </summary>
        public const string YWUSER = "YWUSER";

        /// <summary>
        /// YWPID.
        /// </summary>
        public const string YWPID = "YWPID";

        /// <summary>
        /// YWUPMJ.
        /// </summary>
        public const string YWUPMJ = "YWUPMJ";

        /// <summary>
        /// YWUPMT.
        /// </summary>
        public const string YWUPMT = "YWUPMT";

        /// <summary>
        /// YWJOBN.
        /// </summary>
        public const string YWJOBN = "YWJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F0728";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YWAN8", "YWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YWPRTR", "YWPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("YWDWK", "YWDWK", JdeDataType.Numeric, null, true, true),
        new JdeField("YWCKCN", "YWCKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("YWPDBA", "YWPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("YWRTWC", "YWRTWC", JdeDataType.Numeric),
        new JdeField("YWWCAM", "YWWCAM", JdeDataType.Numeric),
        new JdeField("YWPHRW", "YWPHRW", JdeDataType.Numeric),
        new JdeField("YWUSER", "YWUSER", JdeDataType.String, 20),
        new JdeField("YWPID", "YWPID", JdeDataType.String, 20),
        new JdeField("YWUPMJ", "YWUPMJ", JdeDataType.Numeric),
        new JdeField("YWUPMT", "YWUPMT", JdeDataType.Numeric),
        new JdeField("YWJOBN", "YWJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0728_0", "Primary Key on YWAN8, YWPRTR, YWDWK, YWCKCN, YWPDBA", new[] { "YWAN8", "YWPRTR", "YWDWK", "YWCKCN", "YWPDBA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0728_2", "Index on YWAN8, YWCKCN", new[] { "YWAN8", "YWCKCN" })
    };
}
