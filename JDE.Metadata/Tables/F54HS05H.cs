using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS05H - .
/// </summary>
public class F54HS05H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I6HSINO.
        /// </summary>
        public const string I6HSINO = "I6HSINO";

        /// <summary>
        /// I6UKID.
        /// </summary>
        public const string I6UKID = "I6UKID";

        /// <summary>
        /// I6HSISN.
        /// </summary>
        public const string I6HSISN = "I6HSISN";

        /// <summary>
        /// I6HSIDS.
        /// </summary>
        public const string I6HSIDS = "I6HSIDS";

        /// <summary>
        /// I6AN8.
        /// </summary>
        public const string I6AN8 = "I6AN8";

        /// <summary>
        /// I6PA8.
        /// </summary>
        public const string I6PA8 = "I6PA8";

        /// <summary>
        /// I6OSTP.
        /// </summary>
        public const string I6OSTP = "I6OSTP";

        /// <summary>
        /// I6USER.
        /// </summary>
        public const string I6USER = "I6USER";

        /// <summary>
        /// I6UPMJ.
        /// </summary>
        public const string I6UPMJ = "I6UPMJ";

        /// <summary>
        /// I6UPMT.
        /// </summary>
        public const string I6UPMT = "I6UPMT";

        /// <summary>
        /// I6JOBN.
        /// </summary>
        public const string I6JOBN = "I6JOBN";

        /// <summary>
        /// I6PID.
        /// </summary>
        public const string I6PID = "I6PID";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS05H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I6HSINO", "I6HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("I6UKID", "I6UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I6HSISN", "I6HSISN", JdeDataType.Numeric, null, true, true),
        new JdeField("I6HSIDS", "I6HSIDS", JdeDataType.Numeric),
        new JdeField("I6AN8", "I6AN8", JdeDataType.Numeric),
        new JdeField("I6PA8", "I6PA8", JdeDataType.Numeric),
        new JdeField("I6OSTP", "I6OSTP", JdeDataType.String, 6),
        new JdeField("I6USER", "I6USER", JdeDataType.String, 20),
        new JdeField("I6UPMJ", "I6UPMJ", JdeDataType.Numeric),
        new JdeField("I6UPMT", "I6UPMT", JdeDataType.Numeric),
        new JdeField("I6JOBN", "I6JOBN", JdeDataType.String, 20),
        new JdeField("I6PID", "I6PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS05H_0", "Primary Key on I6HSINO, I6UKID, I6HSISN", new[] { "I6HSINO", "I6UKID", "I6HSISN" }, isUnique: true, isPrimaryKey: true)
    };
}
