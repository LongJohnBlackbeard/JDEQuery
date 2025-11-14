using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F54HS07 - .
/// </summary>
public class F54HS07 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S8HSINO.
        /// </summary>
        public const string S8HSINO = "S8HSINO";

        /// <summary>
        /// S8UKID.
        /// </summary>
        public const string S8UKID = "S8UKID";

        /// <summary>
        /// S8HSIDOC.
        /// </summary>
        public const string S8HSIDOC = "S8HSIDOC";

        /// <summary>
        /// S8HSIEIC.
        /// </summary>
        public const string S8HSIEIC = "S8HSIEIC";

        /// <summary>
        /// S8HSIAIC.
        /// </summary>
        public const string S8HSIAIC = "S8HSIAIC";

        /// <summary>
        /// S8HSITC.
        /// </summary>
        public const string S8HSITC = "S8HSITC";

        /// <summary>
        /// S8HSICC.
        /// </summary>
        public const string S8HSICC = "S8HSICC";

        /// <summary>
        /// S8CRCD.
        /// </summary>
        public const string S8CRCD = "S8CRCD";

        /// <summary>
        /// S8HSIS1.
        /// </summary>
        public const string S8HSIS1 = "S8HSIS1";

        /// <summary>
        /// S8HSIS2.
        /// </summary>
        public const string S8HSIS2 = "S8HSIS2";

        /// <summary>
        /// S8HSIS3.
        /// </summary>
        public const string S8HSIS3 = "S8HSIS3";

        /// <summary>
        /// S8HSIS4.
        /// </summary>
        public const string S8HSIS4 = "S8HSIS4";

        /// <summary>
        /// S8HSIS5.
        /// </summary>
        public const string S8HSIS5 = "S8HSIS5";

        /// <summary>
        /// S8URAB.
        /// </summary>
        public const string S8URAB = "S8URAB";

        /// <summary>
        /// S8URCD.
        /// </summary>
        public const string S8URCD = "S8URCD";

        /// <summary>
        /// S8URAT.
        /// </summary>
        public const string S8URAT = "S8URAT";

        /// <summary>
        /// S8URDT.
        /// </summary>
        public const string S8URDT = "S8URDT";

        /// <summary>
        /// S8URRF.
        /// </summary>
        public const string S8URRF = "S8URRF";

        /// <summary>
        /// S8USER.
        /// </summary>
        public const string S8USER = "S8USER";

        /// <summary>
        /// S8UPMJ.
        /// </summary>
        public const string S8UPMJ = "S8UPMJ";

        /// <summary>
        /// S8UPMT.
        /// </summary>
        public const string S8UPMT = "S8UPMT";

        /// <summary>
        /// S8JOBN.
        /// </summary>
        public const string S8JOBN = "S8JOBN";

        /// <summary>
        /// S8PID.
        /// </summary>
        public const string S8PID = "S8PID";
    }

    /// <inheritdoc />
    public override string TableName => "F54HS07";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S8HSINO", "S8HSINO", JdeDataType.Numeric, null, true, true),
        new JdeField("S8UKID", "S8UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("S8HSIDOC", "S8HSIDOC", JdeDataType.Numeric),
        new JdeField("S8HSIEIC", "S8HSIEIC", JdeDataType.Numeric),
        new JdeField("S8HSIAIC", "S8HSIAIC", JdeDataType.Numeric),
        new JdeField("S8HSITC", "S8HSITC", JdeDataType.String, 4),
        new JdeField("S8HSICC", "S8HSICC", JdeDataType.String, 400),
        new JdeField("S8CRCD", "S8CRCD", JdeDataType.String, 6),
        new JdeField("S8HSIS1", "S8HSIS1", JdeDataType.String, 6),
        new JdeField("S8HSIS2", "S8HSIS2", JdeDataType.String, 6),
        new JdeField("S8HSIS3", "S8HSIS3", JdeDataType.String, 6),
        new JdeField("S8HSIS4", "S8HSIS4", JdeDataType.String, 6),
        new JdeField("S8HSIS5", "S8HSIS5", JdeDataType.String, 6),
        new JdeField("S8URAB", "S8URAB", JdeDataType.Numeric),
        new JdeField("S8URCD", "S8URCD", JdeDataType.String, 4),
        new JdeField("S8URAT", "S8URAT", JdeDataType.Numeric),
        new JdeField("S8URDT", "S8URDT", JdeDataType.Numeric),
        new JdeField("S8URRF", "S8URRF", JdeDataType.String, 30),
        new JdeField("S8USER", "S8USER", JdeDataType.String, 20),
        new JdeField("S8UPMJ", "S8UPMJ", JdeDataType.Numeric),
        new JdeField("S8UPMT", "S8UPMT", JdeDataType.Numeric),
        new JdeField("S8JOBN", "S8JOBN", JdeDataType.String, 20),
        new JdeField("S8PID", "S8PID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F54HS07_0", "Primary Key on S8HSINO, S8UKID", new[] { "S8HSINO", "S8UKID" }, isUnique: true, isPrimaryKey: true)
    };
}
