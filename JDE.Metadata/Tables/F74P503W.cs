using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P503W - .
/// </summary>
public class F74P503W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTDOC.
        /// </summary>
        public const string TTDOC = "TTDOC";

        /// <summary>
        /// TTDCT.
        /// </summary>
        public const string TTDCT = "TTDCT";

        /// <summary>
        /// TTKCO.
        /// </summary>
        public const string TTKCO = "TTKCO";

        /// <summary>
        /// TTAN8.
        /// </summary>
        public const string TTAN8 = "TTAN8";

        /// <summary>
        /// TTPA8.
        /// </summary>
        public const string TTPA8 = "TTPA8";

        /// <summary>
        /// TTCO.
        /// </summary>
        public const string TTCO = "TTCO";

        /// <summary>
        /// TTDGJ.
        /// </summary>
        public const string TTDGJ = "TTDGJ";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTJOBN.
        /// </summary>
        public const string TTJOBN = "TTJOBN";

        /// <summary>
        /// TTUPMJ.
        /// </summary>
        public const string TTUPMJ = "TTUPMJ";

        /// <summary>
        /// TTUPMT.
        /// </summary>
        public const string TTUPMT = "TTUPMT";

        /// <summary>
        /// TTDATF01.
        /// </summary>
        public const string TTDATF01 = "TTDATF01";

        /// <summary>
        /// TTDEPFUT2.
        /// </summary>
        public const string TTDEPFUT2 = "TTDEPFUT2";

        /// <summary>
        /// TTACTFU1.
        /// </summary>
        public const string TTACTFU1 = "TTACTFU1";

        /// <summary>
        /// TTFLAG.
        /// </summary>
        public const string TTFLAG = "TTFLAG";

        /// <summary>
        /// TTUKID.
        /// </summary>
        public const string TTUKID = "TTUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F74P503W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTDOC", "TTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TTDCT", "TTDCT", JdeDataType.String, 4, true, true),
        new JdeField("TTKCO", "TTKCO", JdeDataType.String, 10, true, true),
        new JdeField("TTAN8", "TTAN8", JdeDataType.Numeric),
        new JdeField("TTPA8", "TTPA8", JdeDataType.Numeric),
        new JdeField("TTCO", "TTCO", JdeDataType.String, 10),
        new JdeField("TTDGJ", "TTDGJ", JdeDataType.Numeric),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTUPMT", "TTUPMT", JdeDataType.Numeric),
        new JdeField("TTDATF01", "TTDATF01", JdeDataType.Numeric),
        new JdeField("TTDEPFUT2", "TTDEPFUT2", JdeDataType.String, 60),
        new JdeField("TTACTFU1", "TTACTFU1", JdeDataType.String, 2),
        new JdeField("TTFLAG", "TTFLAG", JdeDataType.String, 2),
        new JdeField("TTUKID", "TTUKID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P503W_0", "Primary Key on TTDOC, TTDCT, TTKCO", new[] { "TTDOC", "TTDCT", "TTKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
