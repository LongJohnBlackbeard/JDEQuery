using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW03 - .
/// </summary>
public class FCW03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MGC9GRCD.
        /// </summary>
        public const string MGC9GRCD = "MGC9GRCD";

        /// <summary>
        /// MGLCTR.
        /// </summary>
        public const string MGLCTR = "MGLCTR";

        /// <summary>
        /// MGC9LNGP.
        /// </summary>
        public const string MGC9LNGP = "MGC9LNGP";

        /// <summary>
        /// MGC9DS01.
        /// </summary>
        public const string MGC9DS01 = "MGC9DS01";

        /// <summary>
        /// MGC9DS02.
        /// </summary>
        public const string MGC9DS02 = "MGC9DS02";

        /// <summary>
        /// MGC9DS03.
        /// </summary>
        public const string MGC9DS03 = "MGC9DS03";

        /// <summary>
        /// MGC9DS04.
        /// </summary>
        public const string MGC9DS04 = "MGC9DS04";

        /// <summary>
        /// MGC9DS05.
        /// </summary>
        public const string MGC9DS05 = "MGC9DS05";

        /// <summary>
        /// MGC9DS06.
        /// </summary>
        public const string MGC9DS06 = "MGC9DS06";

        /// <summary>
        /// MGC9DS07.
        /// </summary>
        public const string MGC9DS07 = "MGC9DS07";

        /// <summary>
        /// MGC9DS08.
        /// </summary>
        public const string MGC9DS08 = "MGC9DS08";

        /// <summary>
        /// MGC9DS09.
        /// </summary>
        public const string MGC9DS09 = "MGC9DS09";

        /// <summary>
        /// MGC9DS10.
        /// </summary>
        public const string MGC9DS10 = "MGC9DS10";

        /// <summary>
        /// MGC9DS11.
        /// </summary>
        public const string MGC9DS11 = "MGC9DS11";

        /// <summary>
        /// MGC9DS12.
        /// </summary>
        public const string MGC9DS12 = "MGC9DS12";

        /// <summary>
        /// MGC9DS13.
        /// </summary>
        public const string MGC9DS13 = "MGC9DS13";

        /// <summary>
        /// MGC9DS14.
        /// </summary>
        public const string MGC9DS14 = "MGC9DS14";

        /// <summary>
        /// MGC9DS15.
        /// </summary>
        public const string MGC9DS15 = "MGC9DS15";

        /// <summary>
        /// MGC9DS16.
        /// </summary>
        public const string MGC9DS16 = "MGC9DS16";

        /// <summary>
        /// MGC9DS17.
        /// </summary>
        public const string MGC9DS17 = "MGC9DS17";

        /// <summary>
        /// MGC9DS18.
        /// </summary>
        public const string MGC9DS18 = "MGC9DS18";

        /// <summary>
        /// MGC9DS19.
        /// </summary>
        public const string MGC9DS19 = "MGC9DS19";

        /// <summary>
        /// MGC9DS20.
        /// </summary>
        public const string MGC9DS20 = "MGC9DS20";

        /// <summary>
        /// MGC9DS21.
        /// </summary>
        public const string MGC9DS21 = "MGC9DS21";

        /// <summary>
        /// MGC9DS22.
        /// </summary>
        public const string MGC9DS22 = "MGC9DS22";

        /// <summary>
        /// MGC9DS23.
        /// </summary>
        public const string MGC9DS23 = "MGC9DS23";

        /// <summary>
        /// MGC9DS24.
        /// </summary>
        public const string MGC9DS24 = "MGC9DS24";

        /// <summary>
        /// MGC9DS25.
        /// </summary>
        public const string MGC9DS25 = "MGC9DS25";

        /// <summary>
        /// MGC9DS26.
        /// </summary>
        public const string MGC9DS26 = "MGC9DS26";

        /// <summary>
        /// MGC9DS27.
        /// </summary>
        public const string MGC9DS27 = "MGC9DS27";

        /// <summary>
        /// MGC9DS28.
        /// </summary>
        public const string MGC9DS28 = "MGC9DS28";

        /// <summary>
        /// MGC9DS29.
        /// </summary>
        public const string MGC9DS29 = "MGC9DS29";

        /// <summary>
        /// MGC9DS30.
        /// </summary>
        public const string MGC9DS30 = "MGC9DS30";
    }

    /// <inheritdoc />
    public override string TableName => "FCW03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MGC9GRCD", "MGC9GRCD", JdeDataType.String, 6, true, true),
        new JdeField("MGLCTR", "MGLCTR", JdeDataType.String, 6, true, true),
        new JdeField("MGC9LNGP", "MGC9LNGP", JdeDataType.String, 4, true, true),
        new JdeField("MGC9DS01", "MGC9DS01", JdeDataType.String, 12),
        new JdeField("MGC9DS02", "MGC9DS02", JdeDataType.String, 12),
        new JdeField("MGC9DS03", "MGC9DS03", JdeDataType.String, 12),
        new JdeField("MGC9DS04", "MGC9DS04", JdeDataType.String, 12),
        new JdeField("MGC9DS05", "MGC9DS05", JdeDataType.String, 12),
        new JdeField("MGC9DS06", "MGC9DS06", JdeDataType.String, 12),
        new JdeField("MGC9DS07", "MGC9DS07", JdeDataType.String, 12),
        new JdeField("MGC9DS08", "MGC9DS08", JdeDataType.String, 12),
        new JdeField("MGC9DS09", "MGC9DS09", JdeDataType.String, 12),
        new JdeField("MGC9DS10", "MGC9DS10", JdeDataType.String, 12),
        new JdeField("MGC9DS11", "MGC9DS11", JdeDataType.String, 12),
        new JdeField("MGC9DS12", "MGC9DS12", JdeDataType.String, 12),
        new JdeField("MGC9DS13", "MGC9DS13", JdeDataType.String, 12),
        new JdeField("MGC9DS14", "MGC9DS14", JdeDataType.String, 12),
        new JdeField("MGC9DS15", "MGC9DS15", JdeDataType.String, 12),
        new JdeField("MGC9DS16", "MGC9DS16", JdeDataType.String, 12),
        new JdeField("MGC9DS17", "MGC9DS17", JdeDataType.String, 12),
        new JdeField("MGC9DS18", "MGC9DS18", JdeDataType.String, 12),
        new JdeField("MGC9DS19", "MGC9DS19", JdeDataType.String, 12),
        new JdeField("MGC9DS20", "MGC9DS20", JdeDataType.String, 12),
        new JdeField("MGC9DS21", "MGC9DS21", JdeDataType.String, 12),
        new JdeField("MGC9DS22", "MGC9DS22", JdeDataType.String, 12),
        new JdeField("MGC9DS23", "MGC9DS23", JdeDataType.String, 12),
        new JdeField("MGC9DS24", "MGC9DS24", JdeDataType.String, 12),
        new JdeField("MGC9DS25", "MGC9DS25", JdeDataType.String, 12),
        new JdeField("MGC9DS26", "MGC9DS26", JdeDataType.String, 12),
        new JdeField("MGC9DS27", "MGC9DS27", JdeDataType.String, 12),
        new JdeField("MGC9DS28", "MGC9DS28", JdeDataType.String, 12),
        new JdeField("MGC9DS29", "MGC9DS29", JdeDataType.String, 12),
        new JdeField("MGC9DS30", "MGC9DS30", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW03_0", "Primary Key on MGC9GRCD, MGLCTR, MGC9LNGP", new[] { "MGC9GRCD", "MGLCTR", "MGC9LNGP" }, isUnique: true, isPrimaryKey: true)
    };
}
