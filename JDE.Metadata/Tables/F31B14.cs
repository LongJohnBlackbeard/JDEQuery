using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B14 - .
/// </summary>
public class F31B14 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MCSY.
        /// </summary>
        public const string MCSY = "MCSY";

        /// <summary>
        /// MCBTMF.
        /// </summary>
        public const string MCBTMF = "MCBTMF";

        /// <summary>
        /// MCBNSU.
        /// </summary>
        public const string MCBNSU = "MCBNSU";

        /// <summary>
        /// MCBNSP.
        /// </summary>
        public const string MCBNSP = "MCBNSP";

        /// <summary>
        /// MCROUND.
        /// </summary>
        public const string MCROUND = "MCROUND";

        /// <summary>
        /// MCDCMAL.
        /// </summary>
        public const string MCDCMAL = "MCDCMAL";

        /// <summary>
        /// MCACUOM.
        /// </summary>
        public const string MCACUOM = "MCACUOM";

        /// <summary>
        /// MCDENWTR.
        /// </summary>
        public const string MCDENWTR = "MCDENWTR";

        /// <summary>
        /// MCCONWIM.
        /// </summary>
        public const string MCCONWIM = "MCCONWIM";

        /// <summary>
        /// MCSEQLEV.
        /// </summary>
        public const string MCSEQLEV = "MCSEQLEV";

        /// <summary>
        /// MCURAT.
        /// </summary>
        public const string MCURAT = "MCURAT";

        /// <summary>
        /// MCURCD.
        /// </summary>
        public const string MCURCD = "MCURCD";

        /// <summary>
        /// MCURDT.
        /// </summary>
        public const string MCURDT = "MCURDT";

        /// <summary>
        /// MCURAB.
        /// </summary>
        public const string MCURAB = "MCURAB";

        /// <summary>
        /// MCURRF.
        /// </summary>
        public const string MCURRF = "MCURRF";

        /// <summary>
        /// MCUSER.
        /// </summary>
        public const string MCUSER = "MCUSER";

        /// <summary>
        /// MCUPMJ.
        /// </summary>
        public const string MCUPMJ = "MCUPMJ";

        /// <summary>
        /// MCUPMT.
        /// </summary>
        public const string MCUPMT = "MCUPMT";

        /// <summary>
        /// MCJOBN.
        /// </summary>
        public const string MCJOBN = "MCJOBN";

        /// <summary>
        /// MCPID.
        /// </summary>
        public const string MCPID = "MCPID";

        /// <summary>
        /// MCLCTH.
        /// </summary>
        public const string MCLCTH = "MCLCTH";

        /// <summary>
        /// MCDCT.
        /// </summary>
        public const string MCDCT = "MCDCT";

        /// <summary>
        /// MCTDAY.
        /// </summary>
        public const string MCTDAY = "MCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F31B14";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MCSY", "MCSY", JdeDataType.String, 8, true, true),
        new JdeField("MCBTMF", "MCBTMF", JdeDataType.String, 2),
        new JdeField("MCBNSU", "MCBNSU", JdeDataType.String, 2),
        new JdeField("MCBNSP", "MCBNSP", JdeDataType.String, 2),
        new JdeField("MCROUND", "MCROUND", JdeDataType.String, 8),
        new JdeField("MCDCMAL", "MCDCMAL", JdeDataType.Numeric),
        new JdeField("MCACUOM", "MCACUOM", JdeDataType.String, 6),
        new JdeField("MCDENWTR", "MCDENWTR", JdeDataType.Numeric),
        new JdeField("MCCONWIM", "MCCONWIM", JdeDataType.Numeric),
        new JdeField("MCSEQLEV", "MCSEQLEV", JdeDataType.String, 2),
        new JdeField("MCURAT", "MCURAT", JdeDataType.Numeric),
        new JdeField("MCURCD", "MCURCD", JdeDataType.String, 4),
        new JdeField("MCURDT", "MCURDT", JdeDataType.Numeric),
        new JdeField("MCURAB", "MCURAB", JdeDataType.Numeric),
        new JdeField("MCURRF", "MCURRF", JdeDataType.String, 30),
        new JdeField("MCUSER", "MCUSER", JdeDataType.String, 20),
        new JdeField("MCUPMJ", "MCUPMJ", JdeDataType.Numeric),
        new JdeField("MCUPMT", "MCUPMT", JdeDataType.Numeric),
        new JdeField("MCJOBN", "MCJOBN", JdeDataType.String, 20),
        new JdeField("MCPID", "MCPID", JdeDataType.String, 20),
        new JdeField("MCLCTH", "MCLCTH", JdeDataType.Numeric),
        new JdeField("MCDCT", "MCDCT", JdeDataType.String, 4),
        new JdeField("MCTDAY", "MCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B14_0", "Primary Key on MCSY", new[] { "MCSY" }, isUnique: true, isPrimaryKey: true)
    };
}
