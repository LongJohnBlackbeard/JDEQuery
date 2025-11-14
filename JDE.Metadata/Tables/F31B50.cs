using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B50 - .
/// </summary>
public class F31B50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BDUKID.
        /// </summary>
        public const string BDUKID = "BDUKID";

        /// <summary>
        /// BDMCU.
        /// </summary>
        public const string BDMCU = "BDMCU";

        /// <summary>
        /// BDWSN.
        /// </summary>
        public const string BDWSN = "BDWSN";

        /// <summary>
        /// BDPAPTY.
        /// </summary>
        public const string BDPAPTY = "BDPAPTY";

        /// <summary>
        /// BDPAPVL.
        /// </summary>
        public const string BDPAPVL = "BDPAPVL";

        /// <summary>
        /// BDSEGL.
        /// </summary>
        public const string BDSEGL = "BDSEGL";

        /// <summary>
        /// BDDL01.
        /// </summary>
        public const string BDDL01 = "BDDL01";

        /// <summary>
        /// BDCOFLG.
        /// </summary>
        public const string BDCOFLG = "BDCOFLG";

        /// <summary>
        /// BDURCD.
        /// </summary>
        public const string BDURCD = "BDURCD";

        /// <summary>
        /// BDURDT.
        /// </summary>
        public const string BDURDT = "BDURDT";

        /// <summary>
        /// BDURAT.
        /// </summary>
        public const string BDURAT = "BDURAT";

        /// <summary>
        /// BDURRF.
        /// </summary>
        public const string BDURRF = "BDURRF";

        /// <summary>
        /// BDURAB.
        /// </summary>
        public const string BDURAB = "BDURAB";

        /// <summary>
        /// BDUSER.
        /// </summary>
        public const string BDUSER = "BDUSER";

        /// <summary>
        /// BDPID.
        /// </summary>
        public const string BDPID = "BDPID";

        /// <summary>
        /// BDJOBN.
        /// </summary>
        public const string BDJOBN = "BDJOBN";

        /// <summary>
        /// BDUPMJ.
        /// </summary>
        public const string BDUPMJ = "BDUPMJ";

        /// <summary>
        /// BDUPMT.
        /// </summary>
        public const string BDUPMT = "BDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BDUKID", "BDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("BDMCU", "BDMCU", JdeDataType.String, 24),
        new JdeField("BDWSN", "BDWSN", JdeDataType.Numeric),
        new JdeField("BDPAPTY", "BDPAPTY", JdeDataType.String, 6),
        new JdeField("BDPAPVL", "BDPAPVL", JdeDataType.String, 10),
        new JdeField("BDSEGL", "BDSEGL", JdeDataType.Numeric),
        new JdeField("BDDL01", "BDDL01", JdeDataType.String, 60),
        new JdeField("BDCOFLG", "BDCOFLG", JdeDataType.String, 2),
        new JdeField("BDURCD", "BDURCD", JdeDataType.String, 4),
        new JdeField("BDURDT", "BDURDT", JdeDataType.Numeric),
        new JdeField("BDURAT", "BDURAT", JdeDataType.Numeric),
        new JdeField("BDURRF", "BDURRF", JdeDataType.String, 30),
        new JdeField("BDURAB", "BDURAB", JdeDataType.Numeric),
        new JdeField("BDUSER", "BDUSER", JdeDataType.String, 20),
        new JdeField("BDPID", "BDPID", JdeDataType.String, 20),
        new JdeField("BDJOBN", "BDJOBN", JdeDataType.String, 20),
        new JdeField("BDUPMJ", "BDUPMJ", JdeDataType.Numeric),
        new JdeField("BDUPMT", "BDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B50_0", "Primary Key on BDUKID", new[] { "BDUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B50_2", "Index on BDMCU, BDWSN", new[] { "BDMCU", "BDWSN" }),
        new JdeIndex("F31B50_3", "Index on BDMCU", new[] { "BDMCU" })
    };
}
