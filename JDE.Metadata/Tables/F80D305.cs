using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D305 - .
/// </summary>
public class F80D305 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HDHIID.
        /// </summary>
        public const string HDHIID = "HDHIID";

        /// <summary>
        /// HDLNID.
        /// </summary>
        public const string HDLNID = "HDLNID";

        /// <summary>
        /// HDDDALU.
        /// </summary>
        public const string HDDDALU = "HDDDALU";

        /// <summary>
        /// HDTIDEN.
        /// </summary>
        public const string HDTIDEN = "HDTIDEN";

        /// <summary>
        /// HDURCD.
        /// </summary>
        public const string HDURCD = "HDURCD";

        /// <summary>
        /// HDURDT.
        /// </summary>
        public const string HDURDT = "HDURDT";

        /// <summary>
        /// HDURAT.
        /// </summary>
        public const string HDURAT = "HDURAT";

        /// <summary>
        /// HDURAB.
        /// </summary>
        public const string HDURAB = "HDURAB";

        /// <summary>
        /// HDURRF.
        /// </summary>
        public const string HDURRF = "HDURRF";

        /// <summary>
        /// HDUSER.
        /// </summary>
        public const string HDUSER = "HDUSER";

        /// <summary>
        /// HDMKEY.
        /// </summary>
        public const string HDMKEY = "HDMKEY";

        /// <summary>
        /// HDPID.
        /// </summary>
        public const string HDPID = "HDPID";

        /// <summary>
        /// HDUUPMJ.
        /// </summary>
        public const string HDUUPMJ = "HDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F80D305";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HDHIID", "HDHIID", JdeDataType.Numeric, null, true, true),
        new JdeField("HDLNID", "HDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("HDDDALU", "HDDDALU", JdeDataType.String, 10),
        new JdeField("HDTIDEN", "HDTIDEN", JdeDataType.Numeric),
        new JdeField("HDURCD", "HDURCD", JdeDataType.String, 4),
        new JdeField("HDURDT", "HDURDT", JdeDataType.Numeric),
        new JdeField("HDURAT", "HDURAT", JdeDataType.Numeric),
        new JdeField("HDURAB", "HDURAB", JdeDataType.Numeric),
        new JdeField("HDURRF", "HDURRF", JdeDataType.String, 30),
        new JdeField("HDUSER", "HDUSER", JdeDataType.String, 20),
        new JdeField("HDMKEY", "HDMKEY", JdeDataType.String, 30),
        new JdeField("HDPID", "HDPID", JdeDataType.String, 20),
        new JdeField("HDUUPMJ", "HDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D305_0", "Primary Key on HDHIID, HDLNID", new[] { "HDHIID", "HDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F80D305_2", "Unique Index on HDHIID, HDDDALU", new[] { "HDHIID", "HDDDALU" }, isUnique: true)
    };
}
