using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F704220 - .
/// </summary>
public class F704220 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APDOC.
        /// </summary>
        public const string APDOC = "APDOC";

        /// <summary>
        /// APKCO.
        /// </summary>
        public const string APKCO = "APKCO";

        /// <summary>
        /// APDCT.
        /// </summary>
        public const string APDCT = "APDCT";

        /// <summary>
        /// APK70IT.
        /// </summary>
        public const string APK70IT = "APK70IT";

        /// <summary>
        /// APK70SER.
        /// </summary>
        public const string APK70SER = "APK70SER";

        /// <summary>
        /// APK70ENUM.
        /// </summary>
        public const string APK70ENUM = "APK70ENUM";

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
        /// APTDAY.
        /// </summary>
        public const string APTDAY = "APTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F704220";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APDOC", "APDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("APKCO", "APKCO", JdeDataType.String, 10, true, true),
        new JdeField("APDCT", "APDCT", JdeDataType.String, 4, true, true),
        new JdeField("APK70IT", "APK70IT", JdeDataType.String, 4),
        new JdeField("APK70SER", "APK70SER", JdeDataType.String, 40),
        new JdeField("APK70ENUM", "APK70ENUM", JdeDataType.String, 72),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APJOBN", "APJOBN", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APTDAY", "APTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F704220_0", "Primary Key on APDOC, APDCT, APKCO", new[] { "APDOC", "APDCT", "APKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
