using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q414 - .
/// </summary>
public class F43Q414 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RLEVNU.
        /// </summary>
        public const string RLEVNU = "RLEVNU";

        /// <summary>
        /// RLDCTO.
        /// </summary>
        public const string RLDCTO = "RLDCTO";

        /// <summary>
        /// RLKCOO.
        /// </summary>
        public const string RLKCOO = "RLKCOO";

        /// <summary>
        /// RLEVLN.
        /// </summary>
        public const string RLEVLN = "RLEVLN";

        /// <summary>
        /// RLBIDNUM.
        /// </summary>
        public const string RLBIDNUM = "RLBIDNUM";

        /// <summary>
        /// RLBIDQN.
        /// </summary>
        public const string RLBIDQN = "RLBIDQN";

        /// <summary>
        /// RLAN8.
        /// </summary>
        public const string RLAN8 = "RLAN8";

        /// <summary>
        /// RLLLNB.
        /// </summary>
        public const string RLLLNB = "RLLLNB";

        /// <summary>
        /// RLITMSEL.
        /// </summary>
        public const string RLITMSEL = "RLITMSEL";

        /// <summary>
        /// RLLTIT.
        /// </summary>
        public const string RLLTIT = "RLLTIT";

        /// <summary>
        /// RLBIDCODE.
        /// </summary>
        public const string RLBIDCODE = "RLBIDCODE";

        /// <summary>
        /// RLLSTSCR.
        /// </summary>
        public const string RLLSTSCR = "RLLSTSCR";

        /// <summary>
        /// RLURCD.
        /// </summary>
        public const string RLURCD = "RLURCD";

        /// <summary>
        /// RLURDT.
        /// </summary>
        public const string RLURDT = "RLURDT";

        /// <summary>
        /// RLURAT.
        /// </summary>
        public const string RLURAT = "RLURAT";

        /// <summary>
        /// RLURAB.
        /// </summary>
        public const string RLURAB = "RLURAB";

        /// <summary>
        /// RLURRF.
        /// </summary>
        public const string RLURRF = "RLURRF";

        /// <summary>
        /// RLTORG.
        /// </summary>
        public const string RLTORG = "RLTORG";

        /// <summary>
        /// RLUSER.
        /// </summary>
        public const string RLUSER = "RLUSER";

        /// <summary>
        /// RLPID.
        /// </summary>
        public const string RLPID = "RLPID";

        /// <summary>
        /// RLJOBN.
        /// </summary>
        public const string RLJOBN = "RLJOBN";

        /// <summary>
        /// RLUPMJ.
        /// </summary>
        public const string RLUPMJ = "RLUPMJ";

        /// <summary>
        /// RLTDAY.
        /// </summary>
        public const string RLTDAY = "RLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q414";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RLEVNU", "RLEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("RLDCTO", "RLDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RLKCOO", "RLKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RLEVLN", "RLEVLN", JdeDataType.Numeric, null, true, true),
        new JdeField("RLBIDNUM", "RLBIDNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("RLBIDQN", "RLBIDQN", JdeDataType.Numeric, null, true, true),
        new JdeField("RLAN8", "RLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RLLLNB", "RLLLNB", JdeDataType.Numeric, null, true, true),
        new JdeField("RLITMSEL", "RLITMSEL", JdeDataType.String, 2),
        new JdeField("RLLTIT", "RLLTIT", JdeDataType.String, 110),
        new JdeField("RLBIDCODE", "RLBIDCODE", JdeDataType.String, 36),
        new JdeField("RLLSTSCR", "RLLSTSCR", JdeDataType.Numeric),
        new JdeField("RLURCD", "RLURCD", JdeDataType.String, 4),
        new JdeField("RLURDT", "RLURDT", JdeDataType.Numeric),
        new JdeField("RLURAT", "RLURAT", JdeDataType.Numeric),
        new JdeField("RLURAB", "RLURAB", JdeDataType.Numeric),
        new JdeField("RLURRF", "RLURRF", JdeDataType.String, 30),
        new JdeField("RLTORG", "RLTORG", JdeDataType.String, 20),
        new JdeField("RLUSER", "RLUSER", JdeDataType.String, 20),
        new JdeField("RLPID", "RLPID", JdeDataType.String, 20),
        new JdeField("RLJOBN", "RLJOBN", JdeDataType.String, 20),
        new JdeField("RLUPMJ", "RLUPMJ", JdeDataType.Numeric),
        new JdeField("RLTDAY", "RLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q414_0", "Primary Key on RLEVNU, RLDCTO, RLKCOO, RLEVLN, RLBIDNUM, RLBIDQN, RLAN8, RLLLNB", new[] { "RLEVNU", "RLDCTO", "RLKCOO", "RLEVLN", "RLBIDNUM", "RLBIDQN", "RLAN8", "RLLLNB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43Q414_2", "Index on RLEVNU, RLDCTO, RLKCOO, RLAN8, RLBIDNUM, RLEVLN, RLBIDQN, RLLLNB", new[] { "RLEVNU", "RLDCTO", "RLKCOO", "RLAN8", "RLBIDNUM", "RLEVLN", "RLBIDQN", "RLLLNB" })
    };
}
