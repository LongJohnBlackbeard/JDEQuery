using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0618TS - .
/// </summary>
public class F0618TS : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YTAN8.
        /// </summary>
        public const string YTAN8 = "YTAN8";

        /// <summary>
        /// YTDWK.
        /// </summary>
        public const string YTDWK = "YTDWK";

        /// <summary>
        /// YTPRTR.
        /// </summary>
        public const string YTPRTR = "YTPRTR";

        /// <summary>
        /// YTPCCD.
        /// </summary>
        public const string YTPCCD = "YTPCCD";

        /// <summary>
        /// YTETHSPC1.
        /// </summary>
        public const string YTETHSPC1 = "YTETHSPC1";

        /// <summary>
        /// YTETHSPC2.
        /// </summary>
        public const string YTETHSPC2 = "YTETHSPC2";

        /// <summary>
        /// YTETHSPC3.
        /// </summary>
        public const string YTETHSPC3 = "YTETHSPC3";

        /// <summary>
        /// YTETHSPC4.
        /// </summary>
        public const string YTETHSPC4 = "YTETHSPC4";

        /// <summary>
        /// YTETHSPD1.
        /// </summary>
        public const string YTETHSPD1 = "YTETHSPD1";

        /// <summary>
        /// YTETHSPD2.
        /// </summary>
        public const string YTETHSPD2 = "YTETHSPD2";

        /// <summary>
        /// YTETHSPD3.
        /// </summary>
        public const string YTETHSPD3 = "YTETHSPD3";

        /// <summary>
        /// YTETHSPD4.
        /// </summary>
        public const string YTETHSPD4 = "YTETHSPD4";

        /// <summary>
        /// YTETHSPN1.
        /// </summary>
        public const string YTETHSPN1 = "YTETHSPN1";

        /// <summary>
        /// YTETHSPN2.
        /// </summary>
        public const string YTETHSPN2 = "YTETHSPN2";

        /// <summary>
        /// YTETHSPN3.
        /// </summary>
        public const string YTETHSPN3 = "YTETHSPN3";

        /// <summary>
        /// YTETHSPN4.
        /// </summary>
        public const string YTETHSPN4 = "YTETHSPN4";

        /// <summary>
        /// YTETHSPS1.
        /// </summary>
        public const string YTETHSPS1 = "YTETHSPS1";

        /// <summary>
        /// YTETHSPS2.
        /// </summary>
        public const string YTETHSPS2 = "YTETHSPS2";

        /// <summary>
        /// YTETHSPS3.
        /// </summary>
        public const string YTETHSPS3 = "YTETHSPS3";

        /// <summary>
        /// YTETHSPS4.
        /// </summary>
        public const string YTETHSPS4 = "YTETHSPS4";

        /// <summary>
        /// YTUSER.
        /// </summary>
        public const string YTUSER = "YTUSER";

        /// <summary>
        /// YTUPMJ.
        /// </summary>
        public const string YTUPMJ = "YTUPMJ";

        /// <summary>
        /// YTUPMT.
        /// </summary>
        public const string YTUPMT = "YTUPMT";

        /// <summary>
        /// YTPID.
        /// </summary>
        public const string YTPID = "YTPID";

        /// <summary>
        /// YTJOBN.
        /// </summary>
        public const string YTJOBN = "YTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F0618TS";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YTAN8", "YTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("YTDWK", "YTDWK", JdeDataType.Numeric, null, true, true),
        new JdeField("YTPRTR", "YTPRTR", JdeDataType.Numeric, null, true, true),
        new JdeField("YTPCCD", "YTPCCD", JdeDataType.String, 10),
        new JdeField("YTETHSPC1", "YTETHSPC1", JdeDataType.String, 2),
        new JdeField("YTETHSPC2", "YTETHSPC2", JdeDataType.String, 2),
        new JdeField("YTETHSPC3", "YTETHSPC3", JdeDataType.String, 2),
        new JdeField("YTETHSPC4", "YTETHSPC4", JdeDataType.String, 2),
        new JdeField("YTETHSPD1", "YTETHSPD1", JdeDataType.Numeric),
        new JdeField("YTETHSPD2", "YTETHSPD2", JdeDataType.Numeric),
        new JdeField("YTETHSPD3", "YTETHSPD3", JdeDataType.Numeric),
        new JdeField("YTETHSPD4", "YTETHSPD4", JdeDataType.Numeric),
        new JdeField("YTETHSPN1", "YTETHSPN1", JdeDataType.Numeric),
        new JdeField("YTETHSPN2", "YTETHSPN2", JdeDataType.Numeric),
        new JdeField("YTETHSPN3", "YTETHSPN3", JdeDataType.Numeric),
        new JdeField("YTETHSPN4", "YTETHSPN4", JdeDataType.Numeric),
        new JdeField("YTETHSPS1", "YTETHSPS1", JdeDataType.String, 60),
        new JdeField("YTETHSPS2", "YTETHSPS2", JdeDataType.String, 60),
        new JdeField("YTETHSPS3", "YTETHSPS3", JdeDataType.String, 60),
        new JdeField("YTETHSPS4", "YTETHSPS4", JdeDataType.String, 60),
        new JdeField("YTUSER", "YTUSER", JdeDataType.String, 20),
        new JdeField("YTUPMJ", "YTUPMJ", JdeDataType.Numeric),
        new JdeField("YTUPMT", "YTUPMT", JdeDataType.Numeric),
        new JdeField("YTPID", "YTPID", JdeDataType.String, 20),
        new JdeField("YTJOBN", "YTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0618TS_0", "Primary Key on YTAN8, YTDWK, YTPRTR", new[] { "YTAN8", "YTDWK", "YTPRTR" }, isUnique: true, isPrimaryKey: true)
    };
}
