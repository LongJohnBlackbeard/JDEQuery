using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40073 - .
/// </summary>
public class F40073 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HYPRFR.
        /// </summary>
        public const string HYPRFR = "HYPRFR";

        /// <summary>
        /// HYHYID.
        /// </summary>
        public const string HYHYID = "HYHYID";

        /// <summary>
        /// HYHY01.
        /// </summary>
        public const string HYHY01 = "HYHY01";

        /// <summary>
        /// HYHY02.
        /// </summary>
        public const string HYHY02 = "HYHY02";

        /// <summary>
        /// HYHY03.
        /// </summary>
        public const string HYHY03 = "HYHY03";

        /// <summary>
        /// HYHY04.
        /// </summary>
        public const string HYHY04 = "HYHY04";

        /// <summary>
        /// HYHY05.
        /// </summary>
        public const string HYHY05 = "HYHY05";

        /// <summary>
        /// HYHY06.
        /// </summary>
        public const string HYHY06 = "HYHY06";

        /// <summary>
        /// HYHY07.
        /// </summary>
        public const string HYHY07 = "HYHY07";

        /// <summary>
        /// HYHY08.
        /// </summary>
        public const string HYHY08 = "HYHY08";

        /// <summary>
        /// HYHY09.
        /// </summary>
        public const string HYHY09 = "HYHY09";

        /// <summary>
        /// HYHY10.
        /// </summary>
        public const string HYHY10 = "HYHY10";

        /// <summary>
        /// HYHY11.
        /// </summary>
        public const string HYHY11 = "HYHY11";

        /// <summary>
        /// HYHY12.
        /// </summary>
        public const string HYHY12 = "HYHY12";

        /// <summary>
        /// HYHY13.
        /// </summary>
        public const string HYHY13 = "HYHY13";

        /// <summary>
        /// HYHY14.
        /// </summary>
        public const string HYHY14 = "HYHY14";

        /// <summary>
        /// HYHY15.
        /// </summary>
        public const string HYHY15 = "HYHY15";

        /// <summary>
        /// HYHY16.
        /// </summary>
        public const string HYHY16 = "HYHY16";

        /// <summary>
        /// HYHY17.
        /// </summary>
        public const string HYHY17 = "HYHY17";

        /// <summary>
        /// HYHY18.
        /// </summary>
        public const string HYHY18 = "HYHY18";

        /// <summary>
        /// HYHY19.
        /// </summary>
        public const string HYHY19 = "HYHY19";

        /// <summary>
        /// HYHY20.
        /// </summary>
        public const string HYHY20 = "HYHY20";

        /// <summary>
        /// HYHY21.
        /// </summary>
        public const string HYHY21 = "HYHY21";

        /// <summary>
        /// HYURCD.
        /// </summary>
        public const string HYURCD = "HYURCD";

        /// <summary>
        /// HYURDT.
        /// </summary>
        public const string HYURDT = "HYURDT";

        /// <summary>
        /// HYURAT.
        /// </summary>
        public const string HYURAT = "HYURAT";

        /// <summary>
        /// HYURAB.
        /// </summary>
        public const string HYURAB = "HYURAB";

        /// <summary>
        /// HYURRF.
        /// </summary>
        public const string HYURRF = "HYURRF";

        /// <summary>
        /// HYUSER.
        /// </summary>
        public const string HYUSER = "HYUSER";

        /// <summary>
        /// HYPID.
        /// </summary>
        public const string HYPID = "HYPID";

        /// <summary>
        /// HYJOBN.
        /// </summary>
        public const string HYJOBN = "HYJOBN";

        /// <summary>
        /// HYUPMJ.
        /// </summary>
        public const string HYUPMJ = "HYUPMJ";

        /// <summary>
        /// HYTDAY.
        /// </summary>
        public const string HYTDAY = "HYTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40073";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HYPRFR", "HYPRFR", JdeDataType.String, 4, true, true),
        new JdeField("HYHYID", "HYHYID", JdeDataType.String, 20, true, true),
        new JdeField("HYHY01", "HYHY01", JdeDataType.Numeric),
        new JdeField("HYHY02", "HYHY02", JdeDataType.Numeric),
        new JdeField("HYHY03", "HYHY03", JdeDataType.Numeric),
        new JdeField("HYHY04", "HYHY04", JdeDataType.Numeric),
        new JdeField("HYHY05", "HYHY05", JdeDataType.Numeric),
        new JdeField("HYHY06", "HYHY06", JdeDataType.Numeric),
        new JdeField("HYHY07", "HYHY07", JdeDataType.Numeric),
        new JdeField("HYHY08", "HYHY08", JdeDataType.Numeric),
        new JdeField("HYHY09", "HYHY09", JdeDataType.Numeric),
        new JdeField("HYHY10", "HYHY10", JdeDataType.Numeric),
        new JdeField("HYHY11", "HYHY11", JdeDataType.Numeric),
        new JdeField("HYHY12", "HYHY12", JdeDataType.Numeric),
        new JdeField("HYHY13", "HYHY13", JdeDataType.Numeric),
        new JdeField("HYHY14", "HYHY14", JdeDataType.Numeric),
        new JdeField("HYHY15", "HYHY15", JdeDataType.Numeric),
        new JdeField("HYHY16", "HYHY16", JdeDataType.Numeric),
        new JdeField("HYHY17", "HYHY17", JdeDataType.Numeric),
        new JdeField("HYHY18", "HYHY18", JdeDataType.Numeric),
        new JdeField("HYHY19", "HYHY19", JdeDataType.Numeric),
        new JdeField("HYHY20", "HYHY20", JdeDataType.Numeric),
        new JdeField("HYHY21", "HYHY21", JdeDataType.Numeric),
        new JdeField("HYURCD", "HYURCD", JdeDataType.String, 4),
        new JdeField("HYURDT", "HYURDT", JdeDataType.Numeric),
        new JdeField("HYURAT", "HYURAT", JdeDataType.Numeric),
        new JdeField("HYURAB", "HYURAB", JdeDataType.Numeric),
        new JdeField("HYURRF", "HYURRF", JdeDataType.String, 30),
        new JdeField("HYUSER", "HYUSER", JdeDataType.String, 20),
        new JdeField("HYPID", "HYPID", JdeDataType.String, 20),
        new JdeField("HYJOBN", "HYJOBN", JdeDataType.String, 20),
        new JdeField("HYUPMJ", "HYUPMJ", JdeDataType.Numeric),
        new JdeField("HYTDAY", "HYTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40073_0", "Primary Key on HYPRFR, HYHYID", new[] { "HYPRFR", "HYHYID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40073_2", "Index on HYPRFR", new[] { "HYPRFR" })
    };
}
