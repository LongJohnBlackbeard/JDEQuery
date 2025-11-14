using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A08 - .
/// </summary>
public class F79A08 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GSNUMB.
        /// </summary>
        public const string GSNUMB = "GSNUMB";

        /// <summary>
        /// GSASII.
        /// </summary>
        public const string GSASII = "GSASII";

        /// <summary>
        /// GSBEFD.
        /// </summary>
        public const string GSBEFD = "GSBEFD";

        /// <summary>
        /// GSEEFD.
        /// </summary>
        public const string GSEEFD = "GSEEFD";

        /// <summary>
        /// GSAN8.
        /// </summary>
        public const string GSAN8 = "GSAN8";

        /// <summary>
        /// GS79AGAT.
        /// </summary>
        public const string GS79AGAT = "GS79AGAT";

        /// <summary>
        /// GS79AGAST.
        /// </summary>
        public const string GS79AGAST = "GS79AGAST";

        /// <summary>
        /// GS79AGHGTT.
        /// </summary>
        public const string GS79AGHGTT = "GS79AGHGTT";

        /// <summary>
        /// GS79AGYN.
        /// </summary>
        public const string GS79AGYN = "GS79AGYN";

        /// <summary>
        /// GSURCD.
        /// </summary>
        public const string GSURCD = "GSURCD";

        /// <summary>
        /// GSURDT.
        /// </summary>
        public const string GSURDT = "GSURDT";

        /// <summary>
        /// GSURAT.
        /// </summary>
        public const string GSURAT = "GSURAT";

        /// <summary>
        /// GSURAB.
        /// </summary>
        public const string GSURAB = "GSURAB";

        /// <summary>
        /// GSURRF.
        /// </summary>
        public const string GSURRF = "GSURRF";

        /// <summary>
        /// GSUSER.
        /// </summary>
        public const string GSUSER = "GSUSER";

        /// <summary>
        /// GSPID.
        /// </summary>
        public const string GSPID = "GSPID";

        /// <summary>
        /// GSJOBN.
        /// </summary>
        public const string GSJOBN = "GSJOBN";

        /// <summary>
        /// GSUPMJ.
        /// </summary>
        public const string GSUPMJ = "GSUPMJ";

        /// <summary>
        /// GSUPMT.
        /// </summary>
        public const string GSUPMT = "GSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F79A08";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GSNUMB", "GSNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("GSASII", "GSASII", JdeDataType.String, 52),
        new JdeField("GSBEFD", "GSBEFD", JdeDataType.Numeric, null, true, true),
        new JdeField("GSEEFD", "GSEEFD", JdeDataType.Numeric),
        new JdeField("GSAN8", "GSAN8", JdeDataType.Numeric),
        new JdeField("GS79AGAT", "GS79AGAT", JdeDataType.String, 20),
        new JdeField("GS79AGAST", "GS79AGAST", JdeDataType.String, 20),
        new JdeField("GS79AGHGTT", "GS79AGHGTT", JdeDataType.String, 10),
        new JdeField("GS79AGYN", "GS79AGYN", JdeDataType.String, 2),
        new JdeField("GSURCD", "GSURCD", JdeDataType.String, 4),
        new JdeField("GSURDT", "GSURDT", JdeDataType.Numeric),
        new JdeField("GSURAT", "GSURAT", JdeDataType.Numeric),
        new JdeField("GSURAB", "GSURAB", JdeDataType.Numeric),
        new JdeField("GSURRF", "GSURRF", JdeDataType.String, 30),
        new JdeField("GSUSER", "GSUSER", JdeDataType.String, 20),
        new JdeField("GSPID", "GSPID", JdeDataType.String, 20),
        new JdeField("GSJOBN", "GSJOBN", JdeDataType.String, 20),
        new JdeField("GSUPMJ", "GSUPMJ", JdeDataType.Numeric),
        new JdeField("GSUPMT", "GSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A08_0", "Primary Key on GSNUMB, GSBEFD", new[] { "GSNUMB", "GSBEFD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A08_2", "Index on GSASII, GSAN8", new[] { "GSASII", "GSAN8" }),
        new JdeIndex("F79A08_3", "Index on GSAN8", new[] { "GSAN8" })
    };
}
