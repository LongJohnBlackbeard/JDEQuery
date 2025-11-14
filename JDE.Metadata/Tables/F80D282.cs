using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D282 - .
/// </summary>
public class F80D282 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIPRDJ.
        /// </summary>
        public const string DIPRDJ = "DIPRDJ";

        /// <summary>
        /// DIMCU.
        /// </summary>
        public const string DIMCU = "DIMCU";

        /// <summary>
        /// DIAADSC.
        /// </summary>
        public const string DIAADSC = "DIAADSC";

        /// <summary>
        /// DIADSE.
        /// </summary>
        public const string DIADSE = "DIADSE";

        /// <summary>
        /// DIADSU.
        /// </summary>
        public const string DIADSU = "DIADSU";

        /// <summary>
        /// DIACDSA.
        /// </summary>
        public const string DIACDSA = "DIACDSA";

        /// <summary>
        /// DIACDSE.
        /// </summary>
        public const string DIACDSE = "DIACDSE";

        /// <summary>
        /// DIACDSU.
        /// </summary>
        public const string DIACDSU = "DIACDSU";

        /// <summary>
        /// DIUSER.
        /// </summary>
        public const string DIUSER = "DIUSER";

        /// <summary>
        /// DIPID.
        /// </summary>
        public const string DIPID = "DIPID";

        /// <summary>
        /// DIMKEY.
        /// </summary>
        public const string DIMKEY = "DIMKEY";

        /// <summary>
        /// DIUTIME.
        /// </summary>
        public const string DIUTIME = "DIUTIME";

        /// <summary>
        /// DIURCD.
        /// </summary>
        public const string DIURCD = "DIURCD";

        /// <summary>
        /// DIURDT.
        /// </summary>
        public const string DIURDT = "DIURDT";

        /// <summary>
        /// DIURAT.
        /// </summary>
        public const string DIURAT = "DIURAT";

        /// <summary>
        /// DIURAB.
        /// </summary>
        public const string DIURAB = "DIURAB";

        /// <summary>
        /// DIURRF.
        /// </summary>
        public const string DIURRF = "DIURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D282";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIPRDJ", "DIPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("DIMCU", "DIMCU", JdeDataType.String, 24, true, true),
        new JdeField("DIAADSC", "DIAADSC", JdeDataType.Numeric),
        new JdeField("DIADSE", "DIADSE", JdeDataType.Numeric),
        new JdeField("DIADSU", "DIADSU", JdeDataType.Numeric),
        new JdeField("DIACDSA", "DIACDSA", JdeDataType.Numeric),
        new JdeField("DIACDSE", "DIACDSE", JdeDataType.Numeric),
        new JdeField("DIACDSU", "DIACDSU", JdeDataType.Numeric),
        new JdeField("DIUSER", "DIUSER", JdeDataType.String, 20),
        new JdeField("DIPID", "DIPID", JdeDataType.String, 20),
        new JdeField("DIMKEY", "DIMKEY", JdeDataType.String, 30),
        new JdeField("DIUTIME", "DIUTIME", JdeDataType.Date),
        new JdeField("DIURCD", "DIURCD", JdeDataType.String, 4),
        new JdeField("DIURDT", "DIURDT", JdeDataType.Numeric),
        new JdeField("DIURAT", "DIURAT", JdeDataType.Numeric),
        new JdeField("DIURAB", "DIURAB", JdeDataType.Numeric),
        new JdeField("DIURRF", "DIURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D282_0", "Primary Key on DIPRDJ, DIMCU", new[] { "DIPRDJ", "DIMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
