using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F702033 - .
/// </summary>
public class F702033 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// D1KCO.
        /// </summary>
        public const string D1KCO = "D1KCO";

        /// <summary>
        /// D1DCT.
        /// </summary>
        public const string D1DCT = "D1DCT";

        /// <summary>
        /// D1DOC.
        /// </summary>
        public const string D1DOC = "D1DOC";

        /// <summary>
        /// D1SEQ.
        /// </summary>
        public const string D1SEQ = "D1SEQ";

        /// <summary>
        /// D1STAM.
        /// </summary>
        public const string D1STAM = "D1STAM";

        /// <summary>
        /// D1MMEJ.
        /// </summary>
        public const string D1MMEJ = "D1MMEJ";

        /// <summary>
        /// D1ADSC.
        /// </summary>
        public const string D1ADSC = "D1ADSC";

        /// <summary>
        /// D1SOBK.
        /// </summary>
        public const string D1SOBK = "D1SOBK";

        /// <summary>
        /// D1SOCN.
        /// </summary>
        public const string D1SOCN = "D1SOCN";

        /// <summary>
        /// D1TRAT.
        /// </summary>
        public const string D1TRAT = "D1TRAT";

        /// <summary>
        /// D1CRCD.
        /// </summary>
        public const string D1CRCD = "D1CRCD";

        /// <summary>
        /// D1PTC.
        /// </summary>
        public const string D1PTC = "D1PTC";

        /// <summary>
        /// D1LOCN.
        /// </summary>
        public const string D1LOCN = "D1LOCN";

        /// <summary>
        /// D1MCU.
        /// </summary>
        public const string D1MCU = "D1MCU";
    }

    /// <inheritdoc />
    public override string TableName => "F702033";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("D1KCO", "D1KCO", JdeDataType.String, 10, true, true),
        new JdeField("D1DCT", "D1DCT", JdeDataType.String, 4, true, true),
        new JdeField("D1DOC", "D1DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("D1SEQ", "D1SEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("D1STAM", "D1STAM", JdeDataType.Numeric),
        new JdeField("D1MMEJ", "D1MMEJ", JdeDataType.Numeric),
        new JdeField("D1ADSC", "D1ADSC", JdeDataType.Numeric),
        new JdeField("D1SOBK", "D1SOBK", JdeDataType.Numeric),
        new JdeField("D1SOCN", "D1SOCN", JdeDataType.Numeric),
        new JdeField("D1TRAT", "D1TRAT", JdeDataType.Numeric),
        new JdeField("D1CRCD", "D1CRCD", JdeDataType.String, 6),
        new JdeField("D1PTC", "D1PTC", JdeDataType.String, 6),
        new JdeField("D1LOCN", "D1LOCN", JdeDataType.String, 40),
        new JdeField("D1MCU", "D1MCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F702033_0", "Primary Key on D1KCO, D1DCT, D1DOC, D1SEQ", new[] { "D1KCO", "D1DCT", "D1DOC", "D1SEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
