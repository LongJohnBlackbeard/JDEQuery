using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06923 - .
/// </summary>
public class F06923 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YHTRTE.
        /// </summary>
        public const string YHTRTE = "YHTRTE";

        /// <summary>
        /// YHJBCD.
        /// </summary>
        public const string YHJBCD = "YHJBCD";

        /// <summary>
        /// YHJBST.
        /// </summary>
        public const string YHJBST = "YHJBST";

        /// <summary>
        /// YHUN.
        /// </summary>
        public const string YHUN = "YHUN";

        /// <summary>
        /// YHMCU.
        /// </summary>
        public const string YHMCU = "YHMCU";

        /// <summary>
        /// YHAJBC.
        /// </summary>
        public const string YHAJBC = "YHAJBC";

        /// <summary>
        /// YHAJBS.
        /// </summary>
        public const string YHAJBS = "YHAJBS";

        /// <summary>
        /// YHLHRT.
        /// </summary>
        public const string YHLHRT = "YHLHRT";

        /// <summary>
        /// YHUHRT.
        /// </summary>
        public const string YHUHRT = "YHUHRT";

        /// <summary>
        /// YHRPTC.
        /// </summary>
        public const string YHRPTC = "YHRPTC";

        /// <summary>
        /// YHEJBC.
        /// </summary>
        public const string YHEJBC = "YHEJBC";

        /// <summary>
        /// YHCEDT.
        /// </summary>
        public const string YHCEDT = "YHCEDT";

        /// <summary>
        /// YHJOBT.
        /// </summary>
        public const string YHJOBT = "YHJOBT";

        /// <summary>
        /// YHSEC1.
        /// </summary>
        public const string YHSEC1 = "YHSEC1";

        /// <summary>
        /// YHSEC2.
        /// </summary>
        public const string YHSEC2 = "YHSEC2";

        /// <summary>
        /// YHSEC3.
        /// </summary>
        public const string YHSEC3 = "YHSEC3";

        /// <summary>
        /// YHSEC4.
        /// </summary>
        public const string YHSEC4 = "YHSEC4";

        /// <summary>
        /// YHSEC5.
        /// </summary>
        public const string YHSEC5 = "YHSEC5";

        /// <summary>
        /// YHEFTB.
        /// </summary>
        public const string YHEFTB = "YHEFTB";

        /// <summary>
        /// YHEFTE.
        /// </summary>
        public const string YHEFTE = "YHEFTE";

        /// <summary>
        /// YHHMIN.
        /// </summary>
        public const string YHHMIN = "YHHMIN";

        /// <summary>
        /// YHHMAX.
        /// </summary>
        public const string YHHMAX = "YHHMAX";

        /// <summary>
        /// YHNJCD.
        /// </summary>
        public const string YHNJCD = "YHNJCD";

        /// <summary>
        /// YHNJST.
        /// </summary>
        public const string YHNJST = "YHNJST";

        /// <summary>
        /// YHCOLR.
        /// </summary>
        public const string YHCOLR = "YHCOLR";

        /// <summary>
        /// YHCOLA.
        /// </summary>
        public const string YHCOLA = "YHCOLA";

        /// <summary>
        /// YHCRAR.
        /// </summary>
        public const string YHCRAR = "YHCRAR";

        /// <summary>
        /// YHCRAA.
        /// </summary>
        public const string YHCRAA = "YHCRAA";

        /// <summary>
        /// YHCRBR.
        /// </summary>
        public const string YHCRBR = "YHCRBR";

        /// <summary>
        /// YHCRAB.
        /// </summary>
        public const string YHCRAB = "YHCRAB";

        /// <summary>
        /// YHCRCR.
        /// </summary>
        public const string YHCRCR = "YHCRCR";

        /// <summary>
        /// YHCRAC.
        /// </summary>
        public const string YHCRAC = "YHCRAC";

        /// <summary>
        /// YHCRDR.
        /// </summary>
        public const string YHCRDR = "YHCRDR";

        /// <summary>
        /// YHCRAD.
        /// </summary>
        public const string YHCRAD = "YHCRAD";

        /// <summary>
        /// YHCLSH.
        /// </summary>
        public const string YHCLSH = "YHCLSH";

        /// <summary>
        /// YHPDBA.
        /// </summary>
        public const string YHPDBA = "YHPDBA";
    }

    /// <inheritdoc />
    public override string TableName => "F06923";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YHTRTE", "YHTRTE", JdeDataType.String, 2),
        new JdeField("YHJBCD", "YHJBCD", JdeDataType.String, 12, true, true),
        new JdeField("YHJBST", "YHJBST", JdeDataType.String, 8, true, true),
        new JdeField("YHUN", "YHUN", JdeDataType.String, 12, true, true),
        new JdeField("YHMCU", "YHMCU", JdeDataType.String, 24, true, true),
        new JdeField("YHAJBC", "YHAJBC", JdeDataType.String, 12),
        new JdeField("YHAJBS", "YHAJBS", JdeDataType.String, 8),
        new JdeField("YHLHRT", "YHLHRT", JdeDataType.Numeric),
        new JdeField("YHUHRT", "YHUHRT", JdeDataType.Numeric),
        new JdeField("YHRPTC", "YHRPTC", JdeDataType.String, 2),
        new JdeField("YHEJBC", "YHEJBC", JdeDataType.String, 12),
        new JdeField("YHCEDT", "YHCEDT", JdeDataType.String, 2),
        new JdeField("YHJOBT", "YHJOBT", JdeDataType.String, 2),
        new JdeField("YHSEC1", "YHSEC1", JdeDataType.String, 6),
        new JdeField("YHSEC2", "YHSEC2", JdeDataType.String, 6),
        new JdeField("YHSEC3", "YHSEC3", JdeDataType.String, 6),
        new JdeField("YHSEC4", "YHSEC4", JdeDataType.String, 6),
        new JdeField("YHSEC5", "YHSEC5", JdeDataType.String, 6),
        new JdeField("YHEFTB", "YHEFTB", JdeDataType.Numeric),
        new JdeField("YHEFTE", "YHEFTE", JdeDataType.Numeric),
        new JdeField("YHHMIN", "YHHMIN", JdeDataType.Numeric),
        new JdeField("YHHMAX", "YHHMAX", JdeDataType.Numeric),
        new JdeField("YHNJCD", "YHNJCD", JdeDataType.String, 12),
        new JdeField("YHNJST", "YHNJST", JdeDataType.String, 8),
        new JdeField("YHCOLR", "YHCOLR", JdeDataType.Numeric),
        new JdeField("YHCOLA", "YHCOLA", JdeDataType.Numeric),
        new JdeField("YHCRAR", "YHCRAR", JdeDataType.Numeric),
        new JdeField("YHCRAA", "YHCRAA", JdeDataType.Numeric),
        new JdeField("YHCRBR", "YHCRBR", JdeDataType.Numeric),
        new JdeField("YHCRAB", "YHCRAB", JdeDataType.Numeric),
        new JdeField("YHCRCR", "YHCRCR", JdeDataType.Numeric),
        new JdeField("YHCRAC", "YHCRAC", JdeDataType.Numeric),
        new JdeField("YHCRDR", "YHCRDR", JdeDataType.Numeric),
        new JdeField("YHCRAD", "YHCRAD", JdeDataType.Numeric),
        new JdeField("YHCLSH", "YHCLSH", JdeDataType.Numeric),
        new JdeField("YHPDBA", "YHPDBA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06923_0", "Primary Key on YHJBCD, YHJBST, YHUN, YHMCU", new[] { "YHJBCD", "YHJBST", "YHUN", "YHMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F06923_2", "Index on YHJBCD, YHJBST, YHMCU", new[] { "YHJBCD", "YHJBST", "YHMCU" })
    };
}
