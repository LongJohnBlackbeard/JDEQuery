using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS07M - .
/// </summary>
public class F54HS07M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// I8HSINO.
        /// </summary>
        public const string I8HSINO = "I8HSINO";

        /// <summary>
        /// I8UKID.
        /// </summary>
        public const string I8UKID = "I8UKID";

        /// <summary>
        /// I8HSIMN.
        /// </summary>
        public const string I8HSIMN = "I8HSIMN";

        /// <summary>
        /// I8HSIMT.
        /// </summary>
        public const string I8HSIMT = "I8HSIMT";

        /// <summary>
        /// I8MODDT.
        /// </summary>
        public const string I8MODDT = "I8MODDT";

        /// <summary>
        /// I8HSIDOC.
        /// </summary>
        public const string I8HSIDOC = "I8HSIDOC";

        /// <summary>
        /// I8HSIEIC.
        /// </summary>
        public const string I8HSIEIC = "I8HSIEIC";

        /// <summary>
        /// I8HSIAIC.
        /// </summary>
        public const string I8HSIAIC = "I8HSIAIC";

        /// <summary>
        /// I8HSITC.
        /// </summary>
        public const string I8HSITC = "I8HSITC";

        /// <summary>
        /// I8HSICC.
        /// </summary>
        public const string I8HSICC = "I8HSICC";

        /// <summary>
        /// I8CRCD.
        /// </summary>
        public const string I8CRCD = "I8CRCD";

        /// <summary>
        /// I8HSIS1.
        /// </summary>
        public const string I8HSIS1 = "I8HSIS1";

        /// <summary>
        /// I8HSIS2.
        /// </summary>
        public const string I8HSIS2 = "I8HSIS2";

        /// <summary>
        /// I8HSIS3.
        /// </summary>
        public const string I8HSIS3 = "I8HSIS3";

        /// <summary>
        /// I8HSIS4.
        /// </summary>
        public const string I8HSIS4 = "I8HSIS4";

        /// <summary>
        /// I8HSIS5.
        /// </summary>
        public const string I8HSIS5 = "I8HSIS5";

        /// <summary>
        /// I8URAB.
        /// </summary>
        public const string I8URAB = "I8URAB";

        /// <summary>
        /// I8URCD.
        /// </summary>
        public const string I8URCD = "I8URCD";

        /// <summary>
        /// I8URAT.
        /// </summary>
        public const string I8URAT = "I8URAT";

        /// <summary>
        /// I8URDT.
        /// </summary>
        public const string I8URDT = "I8URDT";

        /// <summary>
        /// I8URRF.
        /// </summary>
        public const string I8URRF = "I8URRF";

        /// <summary>
        /// I8USER.
        /// </summary>
        public const string I8USER = "I8USER";

        /// <summary>
        /// I8UPMJ.
        /// </summary>
        public const string I8UPMJ = "I8UPMJ";

        /// <summary>
        /// I8UPMT.
        /// </summary>
        public const string I8UPMT = "I8UPMT";

        /// <summary>
        /// I8JOBN.
        /// </summary>
        public const string I8JOBN = "I8JOBN";

        /// <summary>
        /// I8PID.
        /// </summary>
        public const string I8PID = "I8PID";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS07M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("I8HSINO", "I8HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("I8UKID", "I8UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("I8HSIMN", "I8HSIMN", JdeDataType.Numeric, null, true, true),
        new JdeField("I8HSIMT", "I8HSIMT", JdeDataType.String, 2),
        new JdeField("I8MODDT", "I8MODDT", JdeDataType.Numeric),
        new JdeField("I8HSIDOC", "I8HSIDOC", JdeDataType.Numeric),
        new JdeField("I8HSIEIC", "I8HSIEIC", JdeDataType.Numeric),
        new JdeField("I8HSIAIC", "I8HSIAIC", JdeDataType.Numeric),
        new JdeField("I8HSITC", "I8HSITC", JdeDataType.String, 4),
        new JdeField("I8HSICC", "I8HSICC", JdeDataType.String, 400),
        new JdeField("I8CRCD", "I8CRCD", JdeDataType.String, 6),
        new JdeField("I8HSIS1", "I8HSIS1", JdeDataType.String, 6),
        new JdeField("I8HSIS2", "I8HSIS2", JdeDataType.String, 6),
        new JdeField("I8HSIS3", "I8HSIS3", JdeDataType.String, 6),
        new JdeField("I8HSIS4", "I8HSIS4", JdeDataType.String, 6),
        new JdeField("I8HSIS5", "I8HSIS5", JdeDataType.String, 6),
        new JdeField("I8URAB", "I8URAB", JdeDataType.Numeric),
        new JdeField("I8URCD", "I8URCD", JdeDataType.String, 4),
        new JdeField("I8URAT", "I8URAT", JdeDataType.Numeric),
        new JdeField("I8URDT", "I8URDT", JdeDataType.Numeric),
        new JdeField("I8URRF", "I8URRF", JdeDataType.String, 30),
        new JdeField("I8USER", "I8USER", JdeDataType.String, 20),
        new JdeField("I8UPMJ", "I8UPMJ", JdeDataType.Numeric),
        new JdeField("I8UPMT", "I8UPMT", JdeDataType.Numeric),
        new JdeField("I8JOBN", "I8JOBN", JdeDataType.String, 20),
        new JdeField("I8PID", "I8PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS07M_0", "Primary Key on I8HSINO, I8UKID, I8HSIMN", new[] { "I8HSINO", "I8UKID", "I8HSIMN" }, isUnique: true, isPrimaryKey: true)
    };
}
