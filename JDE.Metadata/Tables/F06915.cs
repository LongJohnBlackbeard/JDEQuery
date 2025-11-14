using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06915 - .
/// </summary>
public class F06915 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JHDTEY.
        /// </summary>
        public const string JHDTEY = "JHDTEY";

        /// <summary>
        /// JHHMCO.
        /// </summary>
        public const string JHHMCO = "JHHMCO";

        /// <summary>
        /// JHMCU.
        /// </summary>
        public const string JHMCU = "JHMCU";

        /// <summary>
        /// JHUN.
        /// </summary>
        public const string JHUN = "JHUN";

        /// <summary>
        /// JHJBCD.
        /// </summary>
        public const string JHJBCD = "JHJBCD";

        /// <summary>
        /// JHHLCD.
        /// </summary>
        public const string JHHLCD = "JHHLCD";

        /// <summary>
        /// JHAPG.
        /// </summary>
        public const string JHAPG = "JHAPG";

        /// <summary>
        /// JHHLDT.
        /// </summary>
        public const string JHHLDT = "JHHLDT";

        /// <summary>
        /// JHHRW.
        /// </summary>
        public const string JHHRW = "JHHRW";

        /// <summary>
        /// JHHLTY.
        /// </summary>
        public const string JHHLTY = "JHHLTY";

        /// <summary>
        /// JHCCPR.
        /// </summary>
        public const string JHCCPR = "JHCCPR";

        /// <summary>
        /// JHHLEC.
        /// </summary>
        public const string JHHLEC = "JHHLEC";

        /// <summary>
        /// JHEPA.
        /// </summary>
        public const string JHEPA = "JHEPA";

        /// <summary>
        /// JHPDBA.
        /// </summary>
        public const string JHPDBA = "JHPDBA";

        /// <summary>
        /// JHSALY.
        /// </summary>
        public const string JHSALY = "JHSALY";

        /// <summary>
        /// JHJBST.
        /// </summary>
        public const string JHJBST = "JHJBST";
    }

    /// <inheritdoc />
    public override string TableName => "F06915";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JHDTEY", "JHDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JHHMCO", "JHHMCO", JdeDataType.String, 10, true, true),
        new JdeField("JHMCU", "JHMCU", JdeDataType.String, 24, true, true),
        new JdeField("JHUN", "JHUN", JdeDataType.String, 12, true, true),
        new JdeField("JHJBCD", "JHJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JHHLCD", "JHHLCD", JdeDataType.String, 6, true, true),
        new JdeField("JHAPG", "JHAPG", JdeDataType.String, 2),
        new JdeField("JHHLDT", "JHHLDT", JdeDataType.Numeric, null, true, true),
        new JdeField("JHHRW", "JHHRW", JdeDataType.Numeric),
        new JdeField("JHHLTY", "JHHLTY", JdeDataType.String, 2),
        new JdeField("JHCCPR", "JHCCPR", JdeDataType.String, 6),
        new JdeField("JHHLEC", "JHHLEC", JdeDataType.String, 2),
        new JdeField("JHEPA", "JHEPA", JdeDataType.Numeric),
        new JdeField("JHPDBA", "JHPDBA", JdeDataType.Numeric),
        new JdeField("JHSALY", "JHSALY", JdeDataType.String, 2),
        new JdeField("JHJBST", "JHJBST", JdeDataType.String, 8, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06915_0", "Primary Key on JHDTEY, JHHMCO, JHMCU, JHUN, JHJBCD, JHJBST, JHHLDT, JHHLCD", new[] { "JHDTEY", "JHHMCO", "JHMCU", "JHUN", "JHJBCD", "JHJBST", "JHHLDT", "JHHLCD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06915_2", "Index on JHHLDT, JHHMCO", new[] { "JHHLDT", "JHHMCO" }),
        new JdeIndex("F06915_3", "Index on JHDTEY, JHHLCD", new[] { "JHDTEY", "JHHLCD" }),
        new JdeIndex("F06915_4", "Index on JHHMCO, JHHLCD", new[] { "JHHMCO", "JHHLCD" }),
        new JdeIndex("F06915_5", "Index on JHHLCD, SYS_NC00017$, JHHMCO", new[] { "JHHLCD", "SYS_NC00017$", "JHHMCO" })
    };
}
