using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B15T - .
/// </summary>
public class F03B15T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTAN8.
        /// </summary>
        public const string RTAN8 = "RTAN8";

        /// <summary>
        /// RTPART.
        /// </summary>
        public const string RTPART = "RTPART";

        /// <summary>
        /// RTCO.
        /// </summary>
        public const string RTCO = "RTCO";

        /// <summary>
        /// RTALPH.
        /// </summary>
        public const string RTALPH = "RTALPH";

        /// <summary>
        /// RTAC01.
        /// </summary>
        public const string RTAC01 = "RTAC01";

        /// <summary>
        /// RTAC02.
        /// </summary>
        public const string RTAC02 = "RTAC02";

        /// <summary>
        /// RTAC03.
        /// </summary>
        public const string RTAC03 = "RTAC03";

        /// <summary>
        /// RTAC04.
        /// </summary>
        public const string RTAC04 = "RTAC04";

        /// <summary>
        /// RTAC05.
        /// </summary>
        public const string RTAC05 = "RTAC05";

        /// <summary>
        /// RTAC06.
        /// </summary>
        public const string RTAC06 = "RTAC06";

        /// <summary>
        /// RTAC07.
        /// </summary>
        public const string RTAC07 = "RTAC07";

        /// <summary>
        /// RTAC08.
        /// </summary>
        public const string RTAC08 = "RTAC08";

        /// <summary>
        /// RTAC09.
        /// </summary>
        public const string RTAC09 = "RTAC09";

        /// <summary>
        /// RTAC10.
        /// </summary>
        public const string RTAC10 = "RTAC10";

        /// <summary>
        /// RTAC11.
        /// </summary>
        public const string RTAC11 = "RTAC11";

        /// <summary>
        /// RTAC12.
        /// </summary>
        public const string RTAC12 = "RTAC12";

        /// <summary>
        /// RTAC13.
        /// </summary>
        public const string RTAC13 = "RTAC13";

        /// <summary>
        /// RTAC14.
        /// </summary>
        public const string RTAC14 = "RTAC14";

        /// <summary>
        /// RTAC15.
        /// </summary>
        public const string RTAC15 = "RTAC15";

        /// <summary>
        /// RTAC16.
        /// </summary>
        public const string RTAC16 = "RTAC16";

        /// <summary>
        /// RTAC17.
        /// </summary>
        public const string RTAC17 = "RTAC17";

        /// <summary>
        /// RTAC18.
        /// </summary>
        public const string RTAC18 = "RTAC18";

        /// <summary>
        /// RTAC19.
        /// </summary>
        public const string RTAC19 = "RTAC19";

        /// <summary>
        /// RTAC20.
        /// </summary>
        public const string RTAC20 = "RTAC20";

        /// <summary>
        /// RTAC21.
        /// </summary>
        public const string RTAC21 = "RTAC21";

        /// <summary>
        /// RTAC22.
        /// </summary>
        public const string RTAC22 = "RTAC22";

        /// <summary>
        /// RTAC23.
        /// </summary>
        public const string RTAC23 = "RTAC23";

        /// <summary>
        /// RTAC24.
        /// </summary>
        public const string RTAC24 = "RTAC24";

        /// <summary>
        /// RTAC25.
        /// </summary>
        public const string RTAC25 = "RTAC25";

        /// <summary>
        /// RTAC26.
        /// </summary>
        public const string RTAC26 = "RTAC26";

        /// <summary>
        /// RTAC27.
        /// </summary>
        public const string RTAC27 = "RTAC27";

        /// <summary>
        /// RTAC28.
        /// </summary>
        public const string RTAC28 = "RTAC28";

        /// <summary>
        /// RTAC29.
        /// </summary>
        public const string RTAC29 = "RTAC29";

        /// <summary>
        /// RTAC30.
        /// </summary>
        public const string RTAC30 = "RTAC30";
    }

    /// <inheritdoc />
    public override string TableName => "F03B15T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTAN8", "RTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RTPART", "RTPART", JdeDataType.String, 2, true, true),
        new JdeField("RTCO", "RTCO", JdeDataType.String, 10, true, true),
        new JdeField("RTALPH", "RTALPH", JdeDataType.String, 80),
        new JdeField("RTAC01", "RTAC01", JdeDataType.String, 6),
        new JdeField("RTAC02", "RTAC02", JdeDataType.String, 6),
        new JdeField("RTAC03", "RTAC03", JdeDataType.String, 6),
        new JdeField("RTAC04", "RTAC04", JdeDataType.String, 6),
        new JdeField("RTAC05", "RTAC05", JdeDataType.String, 6),
        new JdeField("RTAC06", "RTAC06", JdeDataType.String, 6),
        new JdeField("RTAC07", "RTAC07", JdeDataType.String, 6),
        new JdeField("RTAC08", "RTAC08", JdeDataType.String, 6),
        new JdeField("RTAC09", "RTAC09", JdeDataType.String, 6),
        new JdeField("RTAC10", "RTAC10", JdeDataType.String, 6),
        new JdeField("RTAC11", "RTAC11", JdeDataType.String, 6),
        new JdeField("RTAC12", "RTAC12", JdeDataType.String, 6),
        new JdeField("RTAC13", "RTAC13", JdeDataType.String, 6),
        new JdeField("RTAC14", "RTAC14", JdeDataType.String, 6),
        new JdeField("RTAC15", "RTAC15", JdeDataType.String, 6),
        new JdeField("RTAC16", "RTAC16", JdeDataType.String, 6),
        new JdeField("RTAC17", "RTAC17", JdeDataType.String, 6),
        new JdeField("RTAC18", "RTAC18", JdeDataType.String, 6),
        new JdeField("RTAC19", "RTAC19", JdeDataType.String, 6),
        new JdeField("RTAC20", "RTAC20", JdeDataType.String, 6),
        new JdeField("RTAC21", "RTAC21", JdeDataType.String, 6),
        new JdeField("RTAC22", "RTAC22", JdeDataType.String, 6),
        new JdeField("RTAC23", "RTAC23", JdeDataType.String, 6),
        new JdeField("RTAC24", "RTAC24", JdeDataType.String, 6),
        new JdeField("RTAC25", "RTAC25", JdeDataType.String, 6),
        new JdeField("RTAC26", "RTAC26", JdeDataType.String, 6),
        new JdeField("RTAC27", "RTAC27", JdeDataType.String, 6),
        new JdeField("RTAC28", "RTAC28", JdeDataType.String, 6),
        new JdeField("RTAC29", "RTAC29", JdeDataType.String, 6),
        new JdeField("RTAC30", "RTAC30", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B15T_0", "Primary Key on RTAN8, RTPART, RTCO", new[] { "RTAN8", "RTPART", "RTCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B15T_2", "Index on RTAN8, RTCO", new[] { "RTAN8", "RTCO" })
    };
}
