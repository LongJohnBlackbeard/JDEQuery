using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW69 - .
/// </summary>
public class FCW69 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WPJOBS.
        /// </summary>
        public const string WPJOBS = "WPJOBS";

        /// <summary>
        /// WPC9LANC.
        /// </summary>
        public const string WPC9LANC = "WPC9LANC";

        /// <summary>
        /// WPDOCO.
        /// </summary>
        public const string WPDOCO = "WPDOCO";

        /// <summary>
        /// WPITM.
        /// </summary>
        public const string WPITM = "WPITM";

        /// <summary>
        /// WPUORG.
        /// </summary>
        public const string WPUORG = "WPUORG";

        /// <summary>
        /// WPTRQT.
        /// </summary>
        public const string WPTRQT = "WPTRQT";

        /// <summary>
        /// WPSOCN.
        /// </summary>
        public const string WPSOCN = "WPSOCN";

        /// <summary>
        /// WPUSER.
        /// </summary>
        public const string WPUSER = "WPUSER";

        /// <summary>
        /// WPPID.
        /// </summary>
        public const string WPPID = "WPPID";

        /// <summary>
        /// WPCTID.
        /// </summary>
        public const string WPCTID = "WPCTID";

        /// <summary>
        /// WPUPMJ.
        /// </summary>
        public const string WPUPMJ = "WPUPMJ";

        /// <summary>
        /// WPTDAY.
        /// </summary>
        public const string WPTDAY = "WPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "FCW69";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WPJOBS", "WPJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WPC9LANC", "WPC9LANC", JdeDataType.Numeric, null, true, true),
        new JdeField("WPDOCO", "WPDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WPITM", "WPITM", JdeDataType.Numeric),
        new JdeField("WPUORG", "WPUORG", JdeDataType.Numeric),
        new JdeField("WPTRQT", "WPTRQT", JdeDataType.Numeric),
        new JdeField("WPSOCN", "WPSOCN", JdeDataType.Numeric),
        new JdeField("WPUSER", "WPUSER", JdeDataType.String, 20),
        new JdeField("WPPID", "WPPID", JdeDataType.String, 20),
        new JdeField("WPCTID", "WPCTID", JdeDataType.String, 30),
        new JdeField("WPUPMJ", "WPUPMJ", JdeDataType.Numeric),
        new JdeField("WPTDAY", "WPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW69_0", "Primary Key on WPJOBS, WPC9LANC, WPDOCO", new[] { "WPJOBS", "WPC9LANC", "WPDOCO" }, isUnique: true, isPrimaryKey: true)
    };
}
