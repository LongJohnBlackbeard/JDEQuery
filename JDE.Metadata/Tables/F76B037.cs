using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B037 - .
/// </summary>
public class F76B037 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APB76APID.
        /// </summary>
        public const string APB76APID = "APB76APID";

        /// <summary>
        /// APB76APNT.
        /// </summary>
        public const string APB76APNT = "APB76APNT";

        /// <summary>
        /// APB76POI.
        /// </summary>
        public const string APB76POI = "APB76POI";

        /// <summary>
        /// APB76DAD.
        /// </summary>
        public const string APB76DAD = "APB76DAD";

        /// <summary>
        /// APB76URAB.
        /// </summary>
        public const string APB76URAB = "APB76URAB";

        /// <summary>
        /// APB76URAT.
        /// </summary>
        public const string APB76URAT = "APB76URAT";

        /// <summary>
        /// APB76URRF.
        /// </summary>
        public const string APB76URRF = "APB76URRF";

        /// <summary>
        /// APB76URDT.
        /// </summary>
        public const string APB76URDT = "APB76URDT";

        /// <summary>
        /// APB76URCD.
        /// </summary>
        public const string APB76URCD = "APB76URCD";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APJOBN.
        /// </summary>
        public const string APJOBN = "APJOBN";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B037";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APB76APID", "APB76APID", JdeDataType.String, 80, true, true),
        new JdeField("APB76APNT", "APB76APNT", JdeDataType.String, 4),
        new JdeField("APB76POI", "APB76POI", JdeDataType.Numeric),
        new JdeField("APB76DAD", "APB76DAD", JdeDataType.Numeric),
        new JdeField("APB76URAB", "APB76URAB", JdeDataType.Numeric),
        new JdeField("APB76URAT", "APB76URAT", JdeDataType.Numeric),
        new JdeField("APB76URRF", "APB76URRF", JdeDataType.String, 30),
        new JdeField("APB76URDT", "APB76URDT", JdeDataType.Numeric),
        new JdeField("APB76URCD", "APB76URCD", JdeDataType.String, 4),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B037_0", "Primary Key on APB76APID", new[] { "APB76APID" }, isUnique: true, isPrimaryKey: true)
    };
}
