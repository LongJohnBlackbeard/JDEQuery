using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B20 - .
/// </summary>
public class F76B20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRKCO.
        /// </summary>
        public const string PRKCO = "PRKCO";

        /// <summary>
        /// PRAT1.
        /// </summary>
        public const string PRAT1 = "PRAT1";

        /// <summary>
        /// PRAN8.
        /// </summary>
        public const string PRAN8 = "PRAN8";

        /// <summary>
        /// PRDGJ.
        /// </summary>
        public const string PRDGJ = "PRDGJ";

        /// <summary>
        /// PRBRTPO.
        /// </summary>
        public const string PRBRTPO = "PRBRTPO";

        /// <summary>
        /// PRAG.
        /// </summary>
        public const string PRAG = "PRAG";

        /// <summary>
        /// PRCRDB.
        /// </summary>
        public const string PRCRDB = "PRCRDB";

        /// <summary>
        /// PRBRDCTP.
        /// </summary>
        public const string PRBRDCTP = "PRBRDCTP";

        /// <summary>
        /// PRDOC.
        /// </summary>
        public const string PRDOC = "PRDOC";

        /// <summary>
        /// PRSFX.
        /// </summary>
        public const string PRSFX = "PRSFX";

        /// <summary>
        /// PRBRSSR.
        /// </summary>
        public const string PRBRSSR = "PRBRSSR";

        /// <summary>
        /// PRDIVJ.
        /// </summary>
        public const string PRDIVJ = "PRDIVJ";

        /// <summary>
        /// PRDDJ.
        /// </summary>
        public const string PRDDJ = "PRDDJ";

        /// <summary>
        /// PRACTAA.
        /// </summary>
        public const string PRACTAA = "PRACTAA";

        /// <summary>
        /// PRICU.
        /// </summary>
        public const string PRICU = "PRICU";

        /// <summary>
        /// PRUSER.
        /// </summary>
        public const string PRUSER = "PRUSER";

        /// <summary>
        /// PREAP.
        /// </summary>
        public const string PREAP = "PREAP";

        /// <summary>
        /// PRJOBN.
        /// </summary>
        public const string PRJOBN = "PRJOBN";

        /// <summary>
        /// PRUPMJ.
        /// </summary>
        public const string PRUPMJ = "PRUPMJ";

        /// <summary>
        /// PRUPMT.
        /// </summary>
        public const string PRUPMT = "PRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRKCO", "PRKCO", JdeDataType.String, 10, true, true),
        new JdeField("PRAT1", "PRAT1", JdeDataType.String, 6),
        new JdeField("PRAN8", "PRAN8", JdeDataType.Numeric),
        new JdeField("PRDGJ", "PRDGJ", JdeDataType.Numeric),
        new JdeField("PRBRTPO", "PRBRTPO", JdeDataType.String, 6, true, true),
        new JdeField("PRAG", "PRAG", JdeDataType.Numeric),
        new JdeField("PRCRDB", "PRCRDB", JdeDataType.String, 2),
        new JdeField("PRBRDCTP", "PRBRDCTP", JdeDataType.String, 6),
        new JdeField("PRDOC", "PRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PRSFX", "PRSFX", JdeDataType.String, 6, true, true),
        new JdeField("PRBRSSR", "PRBRSSR", JdeDataType.String, 10),
        new JdeField("PRDIVJ", "PRDIVJ", JdeDataType.Numeric),
        new JdeField("PRDDJ", "PRDDJ", JdeDataType.Numeric),
        new JdeField("PRACTAA", "PRACTAA", JdeDataType.Numeric),
        new JdeField("PRICU", "PRICU", JdeDataType.Numeric),
        new JdeField("PRUSER", "PRUSER", JdeDataType.String, 20),
        new JdeField("PREAP", "PREAP", JdeDataType.String, 20),
        new JdeField("PRJOBN", "PRJOBN", JdeDataType.String, 20),
        new JdeField("PRUPMJ", "PRUPMJ", JdeDataType.Numeric),
        new JdeField("PRUPMT", "PRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B20_0", "Primary Key on PRDOC, PRSFX, PRBRTPO, PRKCO", new[] { "PRDOC", "PRSFX", "PRBRTPO", "PRKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
