using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76M003 - .
/// </summary>
public class F76M003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WPCO.
        /// </summary>
        public const string WPCO = "WPCO";

        /// <summary>
        /// WPM76WCON.
        /// </summary>
        public const string WPM76WCON = "WPM76WCON";

        /// <summary>
        /// WPM76WHTP.
        /// </summary>
        public const string WPM76WHTP = "WPM76WHTP";

        /// <summary>
        /// WPM76EFFD.
        /// </summary>
        public const string WPM76EFFD = "WPM76EFFD";

        /// <summary>
        /// WPM76EXPD.
        /// </summary>
        public const string WPM76EXPD = "WPM76EXPD";

        /// <summary>
        /// WPM76WPER.
        /// </summary>
        public const string WPM76WPER = "WPM76WPER";

        /// <summary>
        /// WPM76GORT.
        /// </summary>
        public const string WPM76GORT = "WPM76GORT";

        /// <summary>
        /// WPURAB.
        /// </summary>
        public const string WPURAB = "WPURAB";

        /// <summary>
        /// WPURRF.
        /// </summary>
        public const string WPURRF = "WPURRF";

        /// <summary>
        /// WPURCD.
        /// </summary>
        public const string WPURCD = "WPURCD";

        /// <summary>
        /// WPURDT.
        /// </summary>
        public const string WPURDT = "WPURDT";

        /// <summary>
        /// WPUSER.
        /// </summary>
        public const string WPUSER = "WPUSER";

        /// <summary>
        /// WPPID.
        /// </summary>
        public const string WPPID = "WPPID";

        /// <summary>
        /// WPJOBN.
        /// </summary>
        public const string WPJOBN = "WPJOBN";

        /// <summary>
        /// WPUPMJ.
        /// </summary>
        public const string WPUPMJ = "WPUPMJ";

        /// <summary>
        /// WPUPMT.
        /// </summary>
        public const string WPUPMT = "WPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76M003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WPCO", "WPCO", JdeDataType.String, 10, true, true),
        new JdeField("WPM76WCON", "WPM76WCON", JdeDataType.String, 6, true, true),
        new JdeField("WPM76WHTP", "WPM76WHTP", JdeDataType.String, 2, true, true),
        new JdeField("WPM76EFFD", "WPM76EFFD", JdeDataType.Numeric, null, true, true),
        new JdeField("WPM76EXPD", "WPM76EXPD", JdeDataType.Numeric, null, true, true),
        new JdeField("WPM76WPER", "WPM76WPER", JdeDataType.Numeric),
        new JdeField("WPM76GORT", "WPM76GORT", JdeDataType.String, 2),
        new JdeField("WPURAB", "WPURAB", JdeDataType.Numeric),
        new JdeField("WPURRF", "WPURRF", JdeDataType.String, 30),
        new JdeField("WPURCD", "WPURCD", JdeDataType.String, 4),
        new JdeField("WPURDT", "WPURDT", JdeDataType.Numeric),
        new JdeField("WPUSER", "WPUSER", JdeDataType.String, 20),
        new JdeField("WPPID", "WPPID", JdeDataType.String, 20),
        new JdeField("WPJOBN", "WPJOBN", JdeDataType.String, 20),
        new JdeField("WPUPMJ", "WPUPMJ", JdeDataType.Numeric),
        new JdeField("WPUPMT", "WPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76M003_0", "Primary Key on WPCO, WPM76WCON, WPM76WHTP, WPM76EFFD, WPM76EXPD", new[] { "WPCO", "WPM76WCON", "WPM76WHTP", "WPM76EFFD", "WPM76EXPD" }, isUnique: true, isPrimaryKey: true)
    };
}
