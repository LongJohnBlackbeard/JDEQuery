using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F70404 - .
/// </summary>
public class F70404 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z7YR.
        /// </summary>
        public const string Z7YR = "Z7YR";

        /// <summary>
        /// Z7CTRY.
        /// </summary>
        public const string Z7CTRY = "Z7CTRY";

        /// <summary>
        /// Z7CO.
        /// </summary>
        public const string Z7CO = "Z7CO";

        /// <summary>
        /// Z7B101.
        /// </summary>
        public const string Z7B101 = "Z7B101";

        /// <summary>
        /// Z7B102.
        /// </summary>
        public const string Z7B102 = "Z7B102";

        /// <summary>
        /// Z7B103.
        /// </summary>
        public const string Z7B103 = "Z7B103";

        /// <summary>
        /// Z7B104.
        /// </summary>
        public const string Z7B104 = "Z7B104";

        /// <summary>
        /// Z7B105.
        /// </summary>
        public const string Z7B105 = "Z7B105";

        /// <summary>
        /// Z7B106.
        /// </summary>
        public const string Z7B106 = "Z7B106";

        /// <summary>
        /// Z7B107.
        /// </summary>
        public const string Z7B107 = "Z7B107";

        /// <summary>
        /// Z7B108.
        /// </summary>
        public const string Z7B108 = "Z7B108";

        /// <summary>
        /// Z7B109.
        /// </summary>
        public const string Z7B109 = "Z7B109";

        /// <summary>
        /// Z7B110.
        /// </summary>
        public const string Z7B110 = "Z7B110";

        /// <summary>
        /// Z7B111.
        /// </summary>
        public const string Z7B111 = "Z7B111";

        /// <summary>
        /// Z7B112.
        /// </summary>
        public const string Z7B112 = "Z7B112";

        /// <summary>
        /// Z7B201.
        /// </summary>
        public const string Z7B201 = "Z7B201";

        /// <summary>
        /// Z7B202.
        /// </summary>
        public const string Z7B202 = "Z7B202";

        /// <summary>
        /// Z7B203.
        /// </summary>
        public const string Z7B203 = "Z7B203";

        /// <summary>
        /// Z7B204.
        /// </summary>
        public const string Z7B204 = "Z7B204";

        /// <summary>
        /// Z7B205.
        /// </summary>
        public const string Z7B205 = "Z7B205";

        /// <summary>
        /// Z7B206.
        /// </summary>
        public const string Z7B206 = "Z7B206";

        /// <summary>
        /// Z7B207.
        /// </summary>
        public const string Z7B207 = "Z7B207";

        /// <summary>
        /// Z7B208.
        /// </summary>
        public const string Z7B208 = "Z7B208";

        /// <summary>
        /// Z7B209.
        /// </summary>
        public const string Z7B209 = "Z7B209";

        /// <summary>
        /// Z7B210.
        /// </summary>
        public const string Z7B210 = "Z7B210";

        /// <summary>
        /// Z7B211.
        /// </summary>
        public const string Z7B211 = "Z7B211";

        /// <summary>
        /// Z7B212.
        /// </summary>
        public const string Z7B212 = "Z7B212";

        /// <summary>
        /// Z7REG#.
        /// </summary>
        public const string Z7REG_ = "Z7REG#";
    }

    /// <inheritdoc />
    public override string TableName => "F70404";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z7YR", "Z7YR", JdeDataType.Numeric, null, true, true),
        new JdeField("Z7CTRY", "Z7CTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("Z7CO", "Z7CO", JdeDataType.String, 10, true, true),
        new JdeField("Z7B101", "Z7B101", JdeDataType.Numeric),
        new JdeField("Z7B102", "Z7B102", JdeDataType.Numeric),
        new JdeField("Z7B103", "Z7B103", JdeDataType.Numeric),
        new JdeField("Z7B104", "Z7B104", JdeDataType.Numeric),
        new JdeField("Z7B105", "Z7B105", JdeDataType.Numeric),
        new JdeField("Z7B106", "Z7B106", JdeDataType.Numeric),
        new JdeField("Z7B107", "Z7B107", JdeDataType.Numeric),
        new JdeField("Z7B108", "Z7B108", JdeDataType.Numeric),
        new JdeField("Z7B109", "Z7B109", JdeDataType.Numeric),
        new JdeField("Z7B110", "Z7B110", JdeDataType.Numeric),
        new JdeField("Z7B111", "Z7B111", JdeDataType.Numeric),
        new JdeField("Z7B112", "Z7B112", JdeDataType.Numeric),
        new JdeField("Z7B201", "Z7B201", JdeDataType.Numeric),
        new JdeField("Z7B202", "Z7B202", JdeDataType.Numeric),
        new JdeField("Z7B203", "Z7B203", JdeDataType.Numeric),
        new JdeField("Z7B204", "Z7B204", JdeDataType.Numeric),
        new JdeField("Z7B205", "Z7B205", JdeDataType.Numeric),
        new JdeField("Z7B206", "Z7B206", JdeDataType.Numeric),
        new JdeField("Z7B207", "Z7B207", JdeDataType.Numeric),
        new JdeField("Z7B208", "Z7B208", JdeDataType.Numeric),
        new JdeField("Z7B209", "Z7B209", JdeDataType.Numeric),
        new JdeField("Z7B210", "Z7B210", JdeDataType.Numeric),
        new JdeField("Z7B211", "Z7B211", JdeDataType.Numeric),
        new JdeField("Z7B212", "Z7B212", JdeDataType.Numeric),
        new JdeField("Z7REG#", "Z7REG#", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F70404_0", "Primary Key on Z7YR, Z7CTRY, Z7CO", new[] { "Z7YR", "Z7CTRY", "Z7CO" }, isUnique: true, isPrimaryKey: true)
    };
}
