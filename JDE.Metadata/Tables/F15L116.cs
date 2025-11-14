using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L116 - .
/// </summary>
public class F15L116 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDMCU.
        /// </summary>
        public const string RDMCU = "RDMCU";

        /// <summary>
        /// RDRVNB.
        /// </summary>
        public const string RDRVNB = "RDRVNB";

        /// <summary>
        /// RDBCRI.
        /// </summary>
        public const string RDBCRI = "RDBCRI";

        /// <summary>
        /// RDGLC.
        /// </summary>
        public const string RDGLC = "RDGLC";

        /// <summary>
        /// RDUDGP.
        /// </summary>
        public const string RDUDGP = "RDUDGP";

        /// <summary>
        /// RDRENF.
        /// </summary>
        public const string RDRENF = "RDRENF";

        /// <summary>
        /// RDUR01.
        /// </summary>
        public const string RDUR01 = "RDUR01";

        /// <summary>
        /// RDUR02.
        /// </summary>
        public const string RDUR02 = "RDUR02";

        /// <summary>
        /// RDUR03.
        /// </summary>
        public const string RDUR03 = "RDUR03";

        /// <summary>
        /// RDUR04.
        /// </summary>
        public const string RDUR04 = "RDUR04";

        /// <summary>
        /// RDUR05.
        /// </summary>
        public const string RDUR05 = "RDUR05";

        /// <summary>
        /// RDURCD.
        /// </summary>
        public const string RDURCD = "RDURCD";

        /// <summary>
        /// RDURDT.
        /// </summary>
        public const string RDURDT = "RDURDT";

        /// <summary>
        /// RDURAT.
        /// </summary>
        public const string RDURAT = "RDURAT";

        /// <summary>
        /// RDURAB.
        /// </summary>
        public const string RDURAB = "RDURAB";

        /// <summary>
        /// RDURRF.
        /// </summary>
        public const string RDURRF = "RDURRF";

        /// <summary>
        /// RDTORG.
        /// </summary>
        public const string RDTORG = "RDTORG";

        /// <summary>
        /// RDENTJ.
        /// </summary>
        public const string RDENTJ = "RDENTJ";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";

        /// <summary>
        /// RDLAFF.
        /// </summary>
        public const string RDLAFF = "RDLAFF";
    }

    /// <inheritdoc />
    public override string TableName => "F15L116";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDMCU", "RDMCU", JdeDataType.String, 24, true, true),
        new JdeField("RDRVNB", "RDRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("RDBCRI", "RDBCRI", JdeDataType.String, 20, true, true),
        new JdeField("RDGLC", "RDGLC", JdeDataType.String, 8, true, true),
        new JdeField("RDUDGP", "RDUDGP", JdeDataType.String, 20),
        new JdeField("RDRENF", "RDRENF", JdeDataType.String, 2),
        new JdeField("RDUR01", "RDUR01", JdeDataType.String, 6),
        new JdeField("RDUR02", "RDUR02", JdeDataType.String, 6),
        new JdeField("RDUR03", "RDUR03", JdeDataType.String, 6),
        new JdeField("RDUR04", "RDUR04", JdeDataType.String, 6),
        new JdeField("RDUR05", "RDUR05", JdeDataType.String, 6),
        new JdeField("RDURCD", "RDURCD", JdeDataType.String, 4),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDURRF", "RDURRF", JdeDataType.String, 30),
        new JdeField("RDTORG", "RDTORG", JdeDataType.String, 20),
        new JdeField("RDENTJ", "RDENTJ", JdeDataType.Numeric),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric),
        new JdeField("RDLAFF", "RDLAFF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L116_0", "Primary Key on RDMCU, RDRVNB, RDBCRI, RDGLC", new[] { "RDMCU", "RDRVNB", "RDBCRI", "RDGLC" }, isUnique: true, isPrimaryKey: true)
    };
}
