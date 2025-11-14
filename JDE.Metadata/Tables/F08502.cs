using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08502 - .
/// </summary>
public class F08502 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HIAN8.
        /// </summary>
        public const string HIAN8 = "HIAN8";

        /// <summary>
        /// HIPLAN.
        /// </summary>
        public const string HIPLAN = "HIPLAN";

        /// <summary>
        /// HIYRA.
        /// </summary>
        public const string HIYRA = "HIYRA";

        /// <summary>
        /// HIHRV.
        /// </summary>
        public const string HIHRV = "HIHRV";

        /// <summary>
        /// HIYVS.
        /// </summary>
        public const string HIYVS = "HIYVS";

        /// <summary>
        /// HIHRBN.
        /// </summary>
        public const string HIHRBN = "HIHRBN";

        /// <summary>
        /// HIYBS.
        /// </summary>
        public const string HIYBS = "HIYBS";

        /// <summary>
        /// HISLR1.
        /// </summary>
        public const string HISLR1 = "HISLR1";

        /// <summary>
        /// HISLR2.
        /// </summary>
        public const string HISLR2 = "HISLR2";

        /// <summary>
        /// HISLR3.
        /// </summary>
        public const string HISLR3 = "HISLR3";

        /// <summary>
        /// HISLR4.
        /// </summary>
        public const string HISLR4 = "HISLR4";

        /// <summary>
        /// HISLR5.
        /// </summary>
        public const string HISLR5 = "HISLR5";

        /// <summary>
        /// HIFAV1.
        /// </summary>
        public const string HIFAV1 = "HIFAV1";

        /// <summary>
        /// HIFAV2.
        /// </summary>
        public const string HIFAV2 = "HIFAV2";

        /// <summary>
        /// HIFAV3.
        /// </summary>
        public const string HIFAV3 = "HIFAV3";

        /// <summary>
        /// HIFAV4.
        /// </summary>
        public const string HIFAV4 = "HIFAV4";

        /// <summary>
        /// HIFAV5.
        /// </summary>
        public const string HIFAV5 = "HIFAV5";

        /// <summary>
        /// HIBEN1.
        /// </summary>
        public const string HIBEN1 = "HIBEN1";

        /// <summary>
        /// HIBEN2.
        /// </summary>
        public const string HIBEN2 = "HIBEN2";

        /// <summary>
        /// HIBEN3.
        /// </summary>
        public const string HIBEN3 = "HIBEN3";

        /// <summary>
        /// HIBEN4.
        /// </summary>
        public const string HIBEN4 = "HIBEN4";

        /// <summary>
        /// HIBEN5.
        /// </summary>
        public const string HIBEN5 = "HIBEN5";

        /// <summary>
        /// HITPLN.
        /// </summary>
        public const string HITPLN = "HITPLN";

        /// <summary>
        /// HICPBS.
        /// </summary>
        public const string HICPBS = "HICPBS";

        /// <summary>
        /// HIUSER.
        /// </summary>
        public const string HIUSER = "HIUSER";

        /// <summary>
        /// HIPID.
        /// </summary>
        public const string HIPID = "HIPID";

        /// <summary>
        /// HIUPMJ.
        /// </summary>
        public const string HIUPMJ = "HIUPMJ";

        /// <summary>
        /// HIJOBN.
        /// </summary>
        public const string HIJOBN = "HIJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F08502";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HIAN8", "HIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HIPLAN", "HIPLAN", JdeDataType.String, 16, true, true),
        new JdeField("HIYRA", "HIYRA", JdeDataType.Numeric, null, true, true),
        new JdeField("HIHRV", "HIHRV", JdeDataType.Numeric),
        new JdeField("HIYVS", "HIYVS", JdeDataType.Numeric),
        new JdeField("HIHRBN", "HIHRBN", JdeDataType.Numeric),
        new JdeField("HIYBS", "HIYBS", JdeDataType.Numeric),
        new JdeField("HISLR1", "HISLR1", JdeDataType.Numeric),
        new JdeField("HISLR2", "HISLR2", JdeDataType.Numeric),
        new JdeField("HISLR3", "HISLR3", JdeDataType.Numeric),
        new JdeField("HISLR4", "HISLR4", JdeDataType.Numeric),
        new JdeField("HISLR5", "HISLR5", JdeDataType.Numeric),
        new JdeField("HIFAV1", "HIFAV1", JdeDataType.Numeric),
        new JdeField("HIFAV2", "HIFAV2", JdeDataType.Numeric),
        new JdeField("HIFAV3", "HIFAV3", JdeDataType.Numeric),
        new JdeField("HIFAV4", "HIFAV4", JdeDataType.Numeric),
        new JdeField("HIFAV5", "HIFAV5", JdeDataType.Numeric),
        new JdeField("HIBEN1", "HIBEN1", JdeDataType.Numeric),
        new JdeField("HIBEN2", "HIBEN2", JdeDataType.Numeric),
        new JdeField("HIBEN3", "HIBEN3", JdeDataType.Numeric),
        new JdeField("HIBEN4", "HIBEN4", JdeDataType.Numeric),
        new JdeField("HIBEN5", "HIBEN5", JdeDataType.Numeric),
        new JdeField("HITPLN", "HITPLN", JdeDataType.String, 16),
        new JdeField("HICPBS", "HICPBS", JdeDataType.String, 2),
        new JdeField("HIUSER", "HIUSER", JdeDataType.String, 20),
        new JdeField("HIPID", "HIPID", JdeDataType.String, 20),
        new JdeField("HIUPMJ", "HIUPMJ", JdeDataType.Numeric),
        new JdeField("HIJOBN", "HIJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08502_0", "Primary Key on HIAN8, HIPLAN, HIYRA", new[] { "HIAN8", "HIPLAN", "HIYRA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08502_2", "Index on HIAN8, HIYRA, HIPLAN", new[] { "HIAN8", "HIYRA", "HIPLAN" })
    };
}
