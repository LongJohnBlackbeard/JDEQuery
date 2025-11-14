using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F33UI001 - .
/// </summary>
public class F33UI001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WLKIT.
        /// </summary>
        public const string WLKIT = "WLKIT";

        /// <summary>
        /// WLKITL.
        /// </summary>
        public const string WLKITL = "WLKITL";

        /// <summary>
        /// WLKITA.
        /// </summary>
        public const string WLKITA = "WLKITA";

        /// <summary>
        /// WLMMCU.
        /// </summary>
        public const string WLMMCU = "WLMMCU";

        /// <summary>
        /// WLDOCO.
        /// </summary>
        public const string WLDOCO = "WLDOCO";

        /// <summary>
        /// WLDCTO.
        /// </summary>
        public const string WLDCTO = "WLDCTO";

        /// <summary>
        /// WLMCU.
        /// </summary>
        public const string WLMCU = "WLMCU";

        /// <summary>
        /// WLOPSQ.
        /// </summary>
        public const string WLOPSQ = "WLOPSQ";

        /// <summary>
        /// WLOPSC.
        /// </summary>
        public const string WLOPSC = "WLOPSC";

        /// <summary>
        /// WLDRQJ.
        /// </summary>
        public const string WLDRQJ = "WLDRQJ";

        /// <summary>
        /// WLSTRT.
        /// </summary>
        public const string WLSTRT = "WLSTRT";

        /// <summary>
        /// WLRSFT.
        /// </summary>
        public const string WLRSFT = "WLRSFT";

        /// <summary>
        /// WLSSFT.
        /// </summary>
        public const string WLSSFT = "WLSSFT";

        /// <summary>
        /// WLRUNM.
        /// </summary>
        public const string WLRUNM = "WLRUNM";

        /// <summary>
        /// WLRUNL.
        /// </summary>
        public const string WLRUNL = "WLRUNL";

        /// <summary>
        /// WLSETL.
        /// </summary>
        public const string WLSETL = "WLSETL";

        /// <summary>
        /// WLTIMB.
        /// </summary>
        public const string WLTIMB = "WLTIMB";

        /// <summary>
        /// WLMOVD.
        /// </summary>
        public const string WLMOVD = "WLMOVD";

        /// <summary>
        /// WLQUED.
        /// </summary>
        public const string WLQUED = "WLQUED";

        /// <summary>
        /// WLUORG.
        /// </summary>
        public const string WLUORG = "WLUORG";

        /// <summary>
        /// WLUOM.
        /// </summary>
        public const string WLUOM = "WLUOM";

        /// <summary>
        /// WLPOVR.
        /// </summary>
        public const string WLPOVR = "WLPOVR";

        /// <summary>
        /// WLNXOP.
        /// </summary>
        public const string WLNXOP = "WLNXOP";

        /// <summary>
        /// WLCTID.
        /// </summary>
        public const string WLCTID = "WLCTID";

        /// <summary>
        /// WLJOBS.
        /// </summary>
        public const string WLJOBS = "WLJOBS";

        /// <summary>
        /// WLUKID.
        /// </summary>
        public const string WLUKID = "WLUKID";

        /// <summary>
        /// WLWMCU.
        /// </summary>
        public const string WLWMCU = "WLWMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F33UI001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WLKIT", "WLKIT", JdeDataType.Numeric),
        new JdeField("WLKITL", "WLKITL", JdeDataType.String, 50),
        new JdeField("WLKITA", "WLKITA", JdeDataType.String, 50),
        new JdeField("WLMMCU", "WLMMCU", JdeDataType.String, 24),
        new JdeField("WLDOCO", "WLDOCO", JdeDataType.Numeric),
        new JdeField("WLDCTO", "WLDCTO", JdeDataType.String, 4),
        new JdeField("WLMCU", "WLMCU", JdeDataType.String, 24),
        new JdeField("WLOPSQ", "WLOPSQ", JdeDataType.Numeric),
        new JdeField("WLOPSC", "WLOPSC", JdeDataType.String, 4),
        new JdeField("WLDRQJ", "WLDRQJ", JdeDataType.Numeric),
        new JdeField("WLSTRT", "WLSTRT", JdeDataType.Numeric),
        new JdeField("WLRSFT", "WLRSFT", JdeDataType.String, 2),
        new JdeField("WLSSFT", "WLSSFT", JdeDataType.String, 2),
        new JdeField("WLRUNM", "WLRUNM", JdeDataType.Numeric),
        new JdeField("WLRUNL", "WLRUNL", JdeDataType.Numeric),
        new JdeField("WLSETL", "WLSETL", JdeDataType.Numeric),
        new JdeField("WLTIMB", "WLTIMB", JdeDataType.String, 2),
        new JdeField("WLMOVD", "WLMOVD", JdeDataType.Numeric),
        new JdeField("WLQUED", "WLQUED", JdeDataType.Numeric),
        new JdeField("WLUORG", "WLUORG", JdeDataType.Numeric),
        new JdeField("WLUOM", "WLUOM", JdeDataType.String, 4),
        new JdeField("WLPOVR", "WLPOVR", JdeDataType.Numeric),
        new JdeField("WLNXOP", "WLNXOP", JdeDataType.Numeric),
        new JdeField("WLCTID", "WLCTID", JdeDataType.String, 30, true, true),
        new JdeField("WLJOBS", "WLJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WLUKID", "WLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WLWMCU", "WLWMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F33UI001_0", "Primary Key on WLCTID, WLJOBS, WLUKID", new[] { "WLCTID", "WLJOBS", "WLUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F33UI001_1", "Index on WLCTID, WLJOBS, WLMMCU, WLMCU, WLWMCU, WLOPSC, WLDOCO", new[] { "WLCTID", "WLJOBS", "WLMMCU", "WLMCU", "WLWMCU", "WLOPSC", "WLDOCO" }),
        new JdeIndex("F33UI001_2", "Index on WLCTID, WLJOBS, WLDOCO, SYS_NC00028$, WLOPSC, WLMCU", new[] { "WLCTID", "WLJOBS", "WLDOCO", "SYS_NC00028$", "WLOPSC", "WLMCU" })
    };
}
