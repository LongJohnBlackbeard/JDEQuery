using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31091 - .
/// </summary>
public class F31091 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IQITM.
        /// </summary>
        public const string IQITM = "IQITM";

        /// <summary>
        /// IQLITM.
        /// </summary>
        public const string IQLITM = "IQLITM";

        /// <summary>
        /// IQAITM.
        /// </summary>
        public const string IQAITM = "IQAITM";

        /// <summary>
        /// IQMMCU.
        /// </summary>
        public const string IQMMCU = "IQMMCU";

        /// <summary>
        /// IQLINE.
        /// </summary>
        public const string IQLINE = "IQLINE";

        /// <summary>
        /// IQDOCO.
        /// </summary>
        public const string IQDOCO = "IQDOCO";

        /// <summary>
        /// IQDCTO.
        /// </summary>
        public const string IQDCTO = "IQDCTO";

        /// <summary>
        /// IQSHFT.
        /// </summary>
        public const string IQSHFT = "IQSHFT";

        /// <summary>
        /// IQSESD.
        /// </summary>
        public const string IQSESD = "IQSESD";

        /// <summary>
        /// IQPLQT.
        /// </summary>
        public const string IQPLQT = "IQPLQT";

        /// <summary>
        /// IQUOM.
        /// </summary>
        public const string IQUOM = "IQUOM";

        /// <summary>
        /// IQOPSQ.
        /// </summary>
        public const string IQOPSQ = "IQOPSQ";

        /// <summary>
        /// IQWR01.
        /// </summary>
        public const string IQWR01 = "IQWR01";

        /// <summary>
        /// IQWR02.
        /// </summary>
        public const string IQWR02 = "IQWR02";

        /// <summary>
        /// IQWR03.
        /// </summary>
        public const string IQWR03 = "IQWR03";

        /// <summary>
        /// IQURCD.
        /// </summary>
        public const string IQURCD = "IQURCD";

        /// <summary>
        /// IQURDT.
        /// </summary>
        public const string IQURDT = "IQURDT";

        /// <summary>
        /// IQURAT.
        /// </summary>
        public const string IQURAT = "IQURAT";

        /// <summary>
        /// IQURAB.
        /// </summary>
        public const string IQURAB = "IQURAB";

        /// <summary>
        /// IQURRF.
        /// </summary>
        public const string IQURRF = "IQURRF";

        /// <summary>
        /// IQUSER.
        /// </summary>
        public const string IQUSER = "IQUSER";

        /// <summary>
        /// IQPID.
        /// </summary>
        public const string IQPID = "IQPID";

        /// <summary>
        /// IQJOBN.
        /// </summary>
        public const string IQJOBN = "IQJOBN";

        /// <summary>
        /// IQUPMJ.
        /// </summary>
        public const string IQUPMJ = "IQUPMJ";

        /// <summary>
        /// IQTDAY.
        /// </summary>
        public const string IQTDAY = "IQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31091";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IQITM", "IQITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IQLITM", "IQLITM", JdeDataType.String, 50),
        new JdeField("IQAITM", "IQAITM", JdeDataType.String, 50),
        new JdeField("IQMMCU", "IQMMCU", JdeDataType.String, 24, true, true),
        new JdeField("IQLINE", "IQLINE", JdeDataType.String, 24),
        new JdeField("IQDOCO", "IQDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IQDCTO", "IQDCTO", JdeDataType.String, 4, true, true),
        new JdeField("IQSHFT", "IQSHFT", JdeDataType.String, 2, true, true),
        new JdeField("IQSESD", "IQSESD", JdeDataType.Numeric, null, true, true),
        new JdeField("IQPLQT", "IQPLQT", JdeDataType.Numeric),
        new JdeField("IQUOM", "IQUOM", JdeDataType.String, 4),
        new JdeField("IQOPSQ", "IQOPSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("IQWR01", "IQWR01", JdeDataType.String, 8),
        new JdeField("IQWR02", "IQWR02", JdeDataType.String, 6),
        new JdeField("IQWR03", "IQWR03", JdeDataType.String, 6),
        new JdeField("IQURCD", "IQURCD", JdeDataType.String, 4),
        new JdeField("IQURDT", "IQURDT", JdeDataType.Numeric),
        new JdeField("IQURAT", "IQURAT", JdeDataType.Numeric),
        new JdeField("IQURAB", "IQURAB", JdeDataType.Numeric),
        new JdeField("IQURRF", "IQURRF", JdeDataType.String, 30),
        new JdeField("IQUSER", "IQUSER", JdeDataType.String, 20),
        new JdeField("IQPID", "IQPID", JdeDataType.String, 20),
        new JdeField("IQJOBN", "IQJOBN", JdeDataType.String, 20),
        new JdeField("IQUPMJ", "IQUPMJ", JdeDataType.Numeric),
        new JdeField("IQTDAY", "IQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31091_0", "Primary Key on IQDOCO, IQDCTO, IQMMCU, IQITM, IQSESD, IQSHFT, IQOPSQ", new[] { "IQDOCO", "IQDCTO", "IQMMCU", "IQITM", "IQSESD", "IQSHFT", "IQOPSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31091_2", "Index on IQMMCU, IQLINE, IQSESD, IQSHFT, IQOPSQ, IQWR01, IQWR02, IQWR03", new[] { "IQMMCU", "IQLINE", "IQSESD", "IQSHFT", "IQOPSQ", "IQWR01", "IQWR02", "IQWR03" }),
        new JdeIndex("F31091_3", "Index on IQMMCU, IQDOCO, IQSESD, IQSHFT", new[] { "IQMMCU", "IQDOCO", "IQSESD", "IQSHFT" }),
        new JdeIndex("F31091_4", "Index on IQMMCU, IQLINE, IQLITM, IQDOCO, IQSESD", new[] { "IQMMCU", "IQLINE", "IQLITM", "IQDOCO", "IQSESD" }),
        new JdeIndex("F31091_5", "Index on IQMMCU, IQLINE, IQDCTO, IQLITM, IQDOCO, IQSESD", new[] { "IQMMCU", "IQLINE", "IQDCTO", "IQLITM", "IQDOCO", "IQSESD" }),
        new JdeIndex("F31091_6", "Index on IQMMCU, IQLINE, IQDCTO, IQLITM, IQDOCO, IQSHFT, IQSESD", new[] { "IQMMCU", "IQLINE", "IQDCTO", "IQLITM", "IQDOCO", "IQSHFT", "IQSESD" }),
        new JdeIndex("F31091_7", "Index on IQMMCU, IQLINE, IQSHFT, IQLITM, IQDOCO, IQSESD", new[] { "IQMMCU", "IQLINE", "IQSHFT", "IQLITM", "IQDOCO", "IQSESD" }),
        new JdeIndex("F31091_8", "Index on IQMMCU, IQLINE, IQDCTO, IQSHFT, IQLITM, IQDOCO, IQSESD", new[] { "IQMMCU", "IQLINE", "IQDCTO", "IQSHFT", "IQLITM", "IQDOCO", "IQSESD" })
    };
}
