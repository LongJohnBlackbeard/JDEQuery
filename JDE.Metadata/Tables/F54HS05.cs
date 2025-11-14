using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS05 - .
/// </summary>
public class F54HS05 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S6HSINO.
        /// </summary>
        public const string S6HSINO = "S6HSINO";

        /// <summary>
        /// S6UKID.
        /// </summary>
        public const string S6UKID = "S6UKID";

        /// <summary>
        /// S6AN8.
        /// </summary>
        public const string S6AN8 = "S6AN8";

        /// <summary>
        /// S6PA8.
        /// </summary>
        public const string S6PA8 = "S6PA8";

        /// <summary>
        /// S6OSTP.
        /// </summary>
        public const string S6OSTP = "S6OSTP";

        /// <summary>
        /// S6URAB.
        /// </summary>
        public const string S6URAB = "S6URAB";

        /// <summary>
        /// S6URCD.
        /// </summary>
        public const string S6URCD = "S6URCD";

        /// <summary>
        /// S6URAT.
        /// </summary>
        public const string S6URAT = "S6URAT";

        /// <summary>
        /// S6URDT.
        /// </summary>
        public const string S6URDT = "S6URDT";

        /// <summary>
        /// S6URRF.
        /// </summary>
        public const string S6URRF = "S6URRF";

        /// <summary>
        /// S6USER.
        /// </summary>
        public const string S6USER = "S6USER";

        /// <summary>
        /// S6UPMJ.
        /// </summary>
        public const string S6UPMJ = "S6UPMJ";

        /// <summary>
        /// S6UPMT.
        /// </summary>
        public const string S6UPMT = "S6UPMT";

        /// <summary>
        /// S6JOBN.
        /// </summary>
        public const string S6JOBN = "S6JOBN";

        /// <summary>
        /// S6PID.
        /// </summary>
        public const string S6PID = "S6PID";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS05";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S6HSINO", "S6HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("S6UKID", "S6UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("S6AN8", "S6AN8", JdeDataType.Numeric),
        new JdeField("S6PA8", "S6PA8", JdeDataType.Numeric),
        new JdeField("S6OSTP", "S6OSTP", JdeDataType.String, 6),
        new JdeField("S6URAB", "S6URAB", JdeDataType.Numeric),
        new JdeField("S6URCD", "S6URCD", JdeDataType.String, 4),
        new JdeField("S6URAT", "S6URAT", JdeDataType.Numeric),
        new JdeField("S6URDT", "S6URDT", JdeDataType.Numeric),
        new JdeField("S6URRF", "S6URRF", JdeDataType.String, 30),
        new JdeField("S6USER", "S6USER", JdeDataType.String, 20),
        new JdeField("S6UPMJ", "S6UPMJ", JdeDataType.Numeric),
        new JdeField("S6UPMT", "S6UPMT", JdeDataType.Numeric),
        new JdeField("S6JOBN", "S6JOBN", JdeDataType.String, 20),
        new JdeField("S6PID", "S6PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS05_0", "Primary Key on S6HSINO, S6UKID", new[] { "S6HSINO", "S6UKID" }, isUnique: true, isPrimaryKey: true)
    };
}
