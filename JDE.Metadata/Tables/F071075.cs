using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F071075 - .
/// </summary>
public class F071075 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JWAN8.
        /// </summary>
        public const string JWAN8 = "JWAN8";

        /// <summary>
        /// JWPDBA.
        /// </summary>
        public const string JWPDBA = "JWPDBA";

        /// <summary>
        /// JWWANO.
        /// </summary>
        public const string JWWANO = "JWWANO";

        /// <summary>
        /// JWCSFIPS.
        /// </summary>
        public const string JWCSFIPS = "JWCSFIPS";

        /// <summary>
        /// JWCSPT.
        /// </summary>
        public const string JWCSPT = "JWCSPT";

        /// <summary>
        /// JWCSMSI.
        /// </summary>
        public const string JWCSMSI = "JWCSMSI";

        /// <summary>
        /// JWCSCH01.
        /// </summary>
        public const string JWCSCH01 = "JWCSCH01";

        /// <summary>
        /// JWCSCH02.
        /// </summary>
        public const string JWCSCH02 = "JWCSCH02";

        /// <summary>
        /// JWCSST01.
        /// </summary>
        public const string JWCSST01 = "JWCSST01";

        /// <summary>
        /// JWCSST02.
        /// </summary>
        public const string JWCSST02 = "JWCSST02";

        /// <summary>
        /// JWCSST03.
        /// </summary>
        public const string JWCSST03 = "JWCSST03";

        /// <summary>
        /// JWCSST04.
        /// </summary>
        public const string JWCSST04 = "JWCSST04";

        /// <summary>
        /// JWCSAMT01.
        /// </summary>
        public const string JWCSAMT01 = "JWCSAMT01";

        /// <summary>
        /// JWCSAMT02.
        /// </summary>
        public const string JWCSAMT02 = "JWCSAMT02";

        /// <summary>
        /// JWCSAMT03.
        /// </summary>
        public const string JWCSAMT03 = "JWCSAMT03";

        /// <summary>
        /// JWCSAMT04.
        /// </summary>
        public const string JWCSAMT04 = "JWCSAMT04";

        /// <summary>
        /// JWCSDT01.
        /// </summary>
        public const string JWCSDT01 = "JWCSDT01";

        /// <summary>
        /// JWCSDT02.
        /// </summary>
        public const string JWCSDT02 = "JWCSDT02";

        /// <summary>
        /// JWUSER.
        /// </summary>
        public const string JWUSER = "JWUSER";

        /// <summary>
        /// JWPID.
        /// </summary>
        public const string JWPID = "JWPID";

        /// <summary>
        /// JWJOBN.
        /// </summary>
        public const string JWJOBN = "JWJOBN";

        /// <summary>
        /// JWUPMJ.
        /// </summary>
        public const string JWUPMJ = "JWUPMJ";

        /// <summary>
        /// JWUPMT.
        /// </summary>
        public const string JWUPMT = "JWUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F071075";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JWAN8", "JWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JWPDBA", "JWPDBA", JdeDataType.Numeric, null, true, true),
        new JdeField("JWWANO", "JWWANO", JdeDataType.Numeric, null, true, true),
        new JdeField("JWCSFIPS", "JWCSFIPS", JdeDataType.String, 20),
        new JdeField("JWCSPT", "JWCSPT", JdeDataType.String, 2),
        new JdeField("JWCSMSI", "JWCSMSI", JdeDataType.String, 2),
        new JdeField("JWCSCH01", "JWCSCH01", JdeDataType.String, 2),
        new JdeField("JWCSCH02", "JWCSCH02", JdeDataType.String, 2),
        new JdeField("JWCSST01", "JWCSST01", JdeDataType.String, 20),
        new JdeField("JWCSST02", "JWCSST02", JdeDataType.String, 20),
        new JdeField("JWCSST03", "JWCSST03", JdeDataType.String, 40),
        new JdeField("JWCSST04", "JWCSST04", JdeDataType.String, 40),
        new JdeField("JWCSAMT01", "JWCSAMT01", JdeDataType.Numeric),
        new JdeField("JWCSAMT02", "JWCSAMT02", JdeDataType.Numeric),
        new JdeField("JWCSAMT03", "JWCSAMT03", JdeDataType.Numeric),
        new JdeField("JWCSAMT04", "JWCSAMT04", JdeDataType.Numeric),
        new JdeField("JWCSDT01", "JWCSDT01", JdeDataType.Numeric),
        new JdeField("JWCSDT02", "JWCSDT02", JdeDataType.Numeric),
        new JdeField("JWUSER", "JWUSER", JdeDataType.String, 20),
        new JdeField("JWPID", "JWPID", JdeDataType.String, 20),
        new JdeField("JWJOBN", "JWJOBN", JdeDataType.String, 20),
        new JdeField("JWUPMJ", "JWUPMJ", JdeDataType.Numeric),
        new JdeField("JWUPMT", "JWUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F071075_0", "Primary Key on JWAN8, JWPDBA, JWWANO", new[] { "JWAN8", "JWPDBA", "JWWANO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F071075_2", "Index on JWWANO", new[] { "JWWANO" })
    };
}
