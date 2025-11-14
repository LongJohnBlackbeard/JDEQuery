using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q201 - .
/// </summary>
public class F43Q201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHEVNU.
        /// </summary>
        public const string EHEVNU = "EHEVNU";

        /// <summary>
        /// EHDCTO.
        /// </summary>
        public const string EHDCTO = "EHDCTO";

        /// <summary>
        /// EHKCOO.
        /// </summary>
        public const string EHKCOO = "EHKCOO";

        /// <summary>
        /// EHBIDQN.
        /// </summary>
        public const string EHBIDQN = "EHBIDQN";

        /// <summary>
        /// EHLLNB.
        /// </summary>
        public const string EHLLNB = "EHLLNB";

        /// <summary>
        /// EHLTIT.
        /// </summary>
        public const string EHLTIT = "EHLTIT";

        /// <summary>
        /// EHLSTSCR.
        /// </summary>
        public const string EHLSTSCR = "EHLSTSCR";

        /// <summary>
        /// EHURCD.
        /// </summary>
        public const string EHURCD = "EHURCD";

        /// <summary>
        /// EHURDT.
        /// </summary>
        public const string EHURDT = "EHURDT";

        /// <summary>
        /// EHURAT.
        /// </summary>
        public const string EHURAT = "EHURAT";

        /// <summary>
        /// EHURAB.
        /// </summary>
        public const string EHURAB = "EHURAB";

        /// <summary>
        /// EHURRF.
        /// </summary>
        public const string EHURRF = "EHURRF";

        /// <summary>
        /// EHTORG.
        /// </summary>
        public const string EHTORG = "EHTORG";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHJOBN.
        /// </summary>
        public const string EHJOBN = "EHJOBN";

        /// <summary>
        /// EHUPMJ.
        /// </summary>
        public const string EHUPMJ = "EHUPMJ";

        /// <summary>
        /// EHTDAY.
        /// </summary>
        public const string EHTDAY = "EHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHEVNU", "EHEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("EHDCTO", "EHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("EHKCOO", "EHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("EHBIDQN", "EHBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("EHLLNB", "EHLLNB", JdeDataType.Numeric, null, true, true),
        new JdeField("EHLTIT", "EHLTIT", JdeDataType.String, 110),
        new JdeField("EHLSTSCR", "EHLSTSCR", JdeDataType.Numeric),
        new JdeField("EHURCD", "EHURCD", JdeDataType.String, 4),
        new JdeField("EHURDT", "EHURDT", JdeDataType.Numeric),
        new JdeField("EHURAT", "EHURAT", JdeDataType.Numeric),
        new JdeField("EHURAB", "EHURAB", JdeDataType.Numeric),
        new JdeField("EHURRF", "EHURRF", JdeDataType.String, 30),
        new JdeField("EHTORG", "EHTORG", JdeDataType.String, 20),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHJOBN", "EHJOBN", JdeDataType.String, 20),
        new JdeField("EHUPMJ", "EHUPMJ", JdeDataType.Numeric),
        new JdeField("EHTDAY", "EHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q201_0", "Primary Key on EHEVNU, EHDCTO, EHKCOO, EHBIDQN, EHLLNB", new[] { "EHEVNU", "EHDCTO", "EHKCOO", "EHBIDQN", "EHLLNB" }, isUnique: true, isPrimaryKey: true)
    };
}
