using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q402 - .
/// </summary>
public class F43Q402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDEVNU.
        /// </summary>
        public const string RDEVNU = "RDEVNU";

        /// <summary>
        /// RDDCTO.
        /// </summary>
        public const string RDDCTO = "RDDCTO";

        /// <summary>
        /// RDKCOO.
        /// </summary>
        public const string RDKCOO = "RDKCOO";

        /// <summary>
        /// RDBIDNUM.
        /// </summary>
        public const string RDBIDNUM = "RDBIDNUM";

        /// <summary>
        /// RDBIDQN.
        /// </summary>
        public const string RDBIDQN = "RDBIDQN";

        /// <summary>
        /// RDAN8.
        /// </summary>
        public const string RDAN8 = "RDAN8";

        /// <summary>
        /// RDLLNB.
        /// </summary>
        public const string RDLLNB = "RDLLNB";

        /// <summary>
        /// RDITMSEL.
        /// </summary>
        public const string RDITMSEL = "RDITMSEL";

        /// <summary>
        /// RDLTIT.
        /// </summary>
        public const string RDLTIT = "RDLTIT";

        /// <summary>
        /// RDBIDCODE.
        /// </summary>
        public const string RDBIDCODE = "RDBIDCODE";

        /// <summary>
        /// RDLSTSCR.
        /// </summary>
        public const string RDLSTSCR = "RDLSTSCR";

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
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDTDAY.
        /// </summary>
        public const string RDTDAY = "RDTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDEVNU", "RDEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("RDDCTO", "RDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RDKCOO", "RDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RDBIDNUM", "RDBIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("RDBIDQN", "RDBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("RDAN8", "RDAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RDLLNB", "RDLLNB", JdeDataType.Numeric, null, true, true),
        new JdeField("RDITMSEL", "RDITMSEL", JdeDataType.String, 2),
        new JdeField("RDLTIT", "RDLTIT", JdeDataType.String, 110),
        new JdeField("RDBIDCODE", "RDBIDCODE", JdeDataType.String, 36),
        new JdeField("RDLSTSCR", "RDLSTSCR", JdeDataType.Numeric),
        new JdeField("RDURCD", "RDURCD", JdeDataType.String, 4),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDURRF", "RDURRF", JdeDataType.String, 30),
        new JdeField("RDTORG", "RDTORG", JdeDataType.String, 20),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDTDAY", "RDTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q402_0", "Primary Key on RDEVNU, RDDCTO, RDKCOO, RDBIDNUM, RDBIDQN, RDAN8, RDLLNB", new[] { "RDEVNU", "RDDCTO", "RDKCOO", "RDBIDNUM", "RDBIDQN", "RDAN8", "RDLLNB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q402_2", "Index on RDEVNU, RDDCTO, RDKCOO, RDAN8, RDBIDNUM, RDBIDQN, RDLLNB", new[] { "RDEVNU", "RDDCTO", "RDKCOO", "RDAN8", "RDBIDNUM", "RDBIDQN", "RDLLNB" })
    };
}
