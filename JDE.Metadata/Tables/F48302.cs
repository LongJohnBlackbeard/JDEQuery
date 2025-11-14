using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48302 - .
/// </summary>
public class F48302 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WPDTSPN.
        /// </summary>
        public const string WPDTSPN = "WPDTSPN";

        /// <summary>
        /// WPSESD.
        /// </summary>
        public const string WPSESD = "WPSESD";

        /// <summary>
        /// WPSEED.
        /// </summary>
        public const string WPSEED = "WPSEED";

        /// <summary>
        /// WPSEST.
        /// </summary>
        public const string WPSEST = "WPSEST";

        /// <summary>
        /// WPSEET.
        /// </summary>
        public const string WPSEET = "WPSEET";

        /// <summary>
        /// WPCURPD.
        /// </summary>
        public const string WPCURPD = "WPCURPD";

        /// <summary>
        /// WPURCD.
        /// </summary>
        public const string WPURCD = "WPURCD";

        /// <summary>
        /// WPURDT.
        /// </summary>
        public const string WPURDT = "WPURDT";

        /// <summary>
        /// WPURAT.
        /// </summary>
        public const string WPURAT = "WPURAT";

        /// <summary>
        /// WPURRF.
        /// </summary>
        public const string WPURRF = "WPURRF";

        /// <summary>
        /// WPURAB.
        /// </summary>
        public const string WPURAB = "WPURAB";

        /// <summary>
        /// WPMKEY.
        /// </summary>
        public const string WPMKEY = "WPMKEY";

        /// <summary>
        /// WPUSER.
        /// </summary>
        public const string WPUSER = "WPUSER";

        /// <summary>
        /// WPUPMJ.
        /// </summary>
        public const string WPUPMJ = "WPUPMJ";

        /// <summary>
        /// WPUPMT.
        /// </summary>
        public const string WPUPMT = "WPUPMT";

        /// <summary>
        /// WPPID.
        /// </summary>
        public const string WPPID = "WPPID";
    }

    /// <inheritdoc />
    public override string TableName => "F48302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WPDTSPN", "WPDTSPN", JdeDataType.String, 2, true, true),
        new JdeField("WPSESD", "WPSESD", JdeDataType.Numeric, null, true, true),
        new JdeField("WPSEED", "WPSEED", JdeDataType.Numeric),
        new JdeField("WPSEST", "WPSEST", JdeDataType.Numeric),
        new JdeField("WPSEET", "WPSEET", JdeDataType.Numeric),
        new JdeField("WPCURPD", "WPCURPD", JdeDataType.String, 2),
        new JdeField("WPURCD", "WPURCD", JdeDataType.String, 4),
        new JdeField("WPURDT", "WPURDT", JdeDataType.Numeric),
        new JdeField("WPURAT", "WPURAT", JdeDataType.Numeric),
        new JdeField("WPURRF", "WPURRF", JdeDataType.String, 30),
        new JdeField("WPURAB", "WPURAB", JdeDataType.Numeric),
        new JdeField("WPMKEY", "WPMKEY", JdeDataType.String, 30),
        new JdeField("WPUSER", "WPUSER", JdeDataType.String, 20),
        new JdeField("WPUPMJ", "WPUPMJ", JdeDataType.Numeric),
        new JdeField("WPUPMT", "WPUPMT", JdeDataType.Numeric),
        new JdeField("WPPID", "WPPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48302_0", "Primary Key on WPDTSPN, WPSESD", new[] { "WPDTSPN", "WPSESD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48302_2", "Index on WPDTSPN, SYS_NC00017$", new[] { "WPDTSPN", "SYS_NC00017$" }),
        new JdeIndex("F48302_3", "Index on WPDTSPN, WPCURPD", new[] { "WPDTSPN", "WPCURPD" })
    };
}
