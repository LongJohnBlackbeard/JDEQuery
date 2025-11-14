using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G50 - .
/// </summary>
public class F40G50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MCMATCALID.
        /// </summary>
        public const string MCMATCALID = "MCMATCALID";

        /// <summary>
        /// MCMATCALNM.
        /// </summary>
        public const string MCMATCALNM = "MCMATCALNM";

        /// <summary>
        /// MCMD.
        /// </summary>
        public const string MCMD = "MCMD";

        /// <summary>
        /// MCOBNM.
        /// </summary>
        public const string MCOBNM = "MCOBNM";

        /// <summary>
        /// MCFCTNM.
        /// </summary>
        public const string MCFCTNM = "MCFCTNM";

        /// <summary>
        /// MCDSTNM.
        /// </summary>
        public const string MCDSTNM = "MCDSTNM";

        /// <summary>
        /// MCURCD.
        /// </summary>
        public const string MCURCD = "MCURCD";

        /// <summary>
        /// MCURDT.
        /// </summary>
        public const string MCURDT = "MCURDT";

        /// <summary>
        /// MCURRF.
        /// </summary>
        public const string MCURRF = "MCURRF";

        /// <summary>
        /// MCURAB.
        /// </summary>
        public const string MCURAB = "MCURAB";

        /// <summary>
        /// MCURAT.
        /// </summary>
        public const string MCURAT = "MCURAT";

        /// <summary>
        /// MCTORG.
        /// </summary>
        public const string MCTORG = "MCTORG";

        /// <summary>
        /// MCUSER.
        /// </summary>
        public const string MCUSER = "MCUSER";

        /// <summary>
        /// MCPID.
        /// </summary>
        public const string MCPID = "MCPID";

        /// <summary>
        /// MCJOBN.
        /// </summary>
        public const string MCJOBN = "MCJOBN";

        /// <summary>
        /// MCUUPMJ.
        /// </summary>
        public const string MCUUPMJ = "MCUUPMJ";

        /// <summary>
        /// MCMCALNMID.
        /// </summary>
        public const string MCMCALNMID = "MCMCALNMID";
    }

    /// <inheritdoc />
    public override string TableName => "F40G50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MCMATCALID", "MCMATCALID", JdeDataType.Numeric, null, true, true),
        new JdeField("MCMATCALNM", "MCMATCALNM", JdeDataType.String, 60),
        new JdeField("MCMD", "MCMD", JdeDataType.String, 120),
        new JdeField("MCOBNM", "MCOBNM", JdeDataType.String, 20),
        new JdeField("MCFCTNM", "MCFCTNM", JdeDataType.String, 64),
        new JdeField("MCDSTNM", "MCDSTNM", JdeDataType.String, 20),
        new JdeField("MCURCD", "MCURCD", JdeDataType.String, 4),
        new JdeField("MCURDT", "MCURDT", JdeDataType.Numeric),
        new JdeField("MCURRF", "MCURRF", JdeDataType.String, 30),
        new JdeField("MCURAB", "MCURAB", JdeDataType.Numeric),
        new JdeField("MCURAT", "MCURAT", JdeDataType.Numeric),
        new JdeField("MCTORG", "MCTORG", JdeDataType.String, 20),
        new JdeField("MCUSER", "MCUSER", JdeDataType.String, 20),
        new JdeField("MCPID", "MCPID", JdeDataType.String, 20),
        new JdeField("MCJOBN", "MCJOBN", JdeDataType.String, 20),
        new JdeField("MCUUPMJ", "MCUUPMJ", JdeDataType.Date),
        new JdeField("MCMCALNMID", "MCMCALNMID", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G50_0", "Primary Key on MCMATCALID", new[] { "MCMATCALID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G50_2", "Index on MCMCALNMID", new[] { "MCMCALNMID" })
    };
}
