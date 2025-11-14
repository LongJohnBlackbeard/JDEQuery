using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15174 - .
/// </summary>
public class F15174 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// APLZDLT.
        /// </summary>
        public const string APLZDLT = "APLZDLT";

        /// <summary>
        /// APLZFLT.
        /// </summary>
        public const string APLZFLT = "APLZFLT";

        /// <summary>
        /// APLZLTPU.
        /// </summary>
        public const string APLZLTPU = "APLZLTPU";

        /// <summary>
        /// APURAB.
        /// </summary>
        public const string APURAB = "APURAB";

        /// <summary>
        /// APURAT.
        /// </summary>
        public const string APURAT = "APURAT";

        /// <summary>
        /// APURCD.
        /// </summary>
        public const string APURCD = "APURCD";

        /// <summary>
        /// APURDT.
        /// </summary>
        public const string APURDT = "APURDT";

        /// <summary>
        /// APURRF.
        /// </summary>
        public const string APURRF = "APURRF";

        /// <summary>
        /// APTORG.
        /// </summary>
        public const string APTORG = "APTORG";

        /// <summary>
        /// APENTJ.
        /// </summary>
        public const string APENTJ = "APENTJ";

        /// <summary>
        /// APUSER.
        /// </summary>
        public const string APUSER = "APUSER";

        /// <summary>
        /// APPID.
        /// </summary>
        public const string APPID = "APPID";

        /// <summary>
        /// APUPMJ.
        /// </summary>
        public const string APUPMJ = "APUPMJ";

        /// <summary>
        /// APUPMT.
        /// </summary>
        public const string APUPMT = "APUPMT";

        /// <summary>
        /// APMKEY.
        /// </summary>
        public const string APMKEY = "APMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F15174";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("APLZDLT", "APLZDLT", JdeDataType.String, 4, true, true),
        new JdeField("APLZFLT", "APLZFLT", JdeDataType.String, 4, true, true),
        new JdeField("APLZLTPU", "APLZLTPU", JdeDataType.String, 2, true, true),
        new JdeField("APURAB", "APURAB", JdeDataType.Numeric),
        new JdeField("APURAT", "APURAT", JdeDataType.Numeric),
        new JdeField("APURCD", "APURCD", JdeDataType.String, 4),
        new JdeField("APURDT", "APURDT", JdeDataType.Numeric),
        new JdeField("APURRF", "APURRF", JdeDataType.String, 30),
        new JdeField("APTORG", "APTORG", JdeDataType.String, 20),
        new JdeField("APENTJ", "APENTJ", JdeDataType.Numeric),
        new JdeField("APUSER", "APUSER", JdeDataType.String, 20),
        new JdeField("APPID", "APPID", JdeDataType.String, 20),
        new JdeField("APUPMJ", "APUPMJ", JdeDataType.Numeric),
        new JdeField("APUPMT", "APUPMT", JdeDataType.Numeric),
        new JdeField("APMKEY", "APMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15174_0", "Primary Key on APLZDLT, APLZFLT, APLZLTPU", new[] { "APLZDLT", "APLZFLT", "APLZLTPU" }, isUnique: true, isPrimaryKey: true)
    };
}
