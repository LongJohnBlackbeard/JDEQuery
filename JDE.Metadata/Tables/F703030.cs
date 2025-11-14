using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F703030 - .
/// </summary>
public class F703030 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// H1KCO.
        /// </summary>
        public const string H1KCO = "H1KCO";

        /// <summary>
        /// H1DCT.
        /// </summary>
        public const string H1DCT = "H1DCT";

        /// <summary>
        /// H1DOC.
        /// </summary>
        public const string H1DOC = "H1DOC";

        /// <summary>
        /// H1MCU.
        /// </summary>
        public const string H1MCU = "H1MCU";

        /// <summary>
        /// H1VR01.
        /// </summary>
        public const string H1VR01 = "H1VR01";

        /// <summary>
        /// H1FRTH.
        /// </summary>
        public const string H1FRTH = "H1FRTH";

        /// <summary>
        /// H1RYIN.
        /// </summary>
        public const string H1RYIN = "H1RYIN";

        /// <summary>
        /// H1SY.
        /// </summary>
        public const string H1SY = "H1SY";

        /// <summary>
        /// H1DSVJ.
        /// </summary>
        public const string H1DSVJ = "H1DSVJ";

        /// <summary>
        /// H1K74FLEN.
        /// </summary>
        public const string H1K74FLEN = "H1K74FLEN";
    }

    /// <inheritdoc />
    public override string TableName => "F703030";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("H1KCO", "H1KCO", JdeDataType.String, 10, true, true),
        new JdeField("H1DCT", "H1DCT", JdeDataType.String, 4, true, true),
        new JdeField("H1DOC", "H1DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("H1MCU", "H1MCU", JdeDataType.String, 24),
        new JdeField("H1VR01", "H1VR01", JdeDataType.String, 50),
        new JdeField("H1FRTH", "H1FRTH", JdeDataType.String, 6),
        new JdeField("H1RYIN", "H1RYIN", JdeDataType.String, 2),
        new JdeField("H1SY", "H1SY", JdeDataType.String, 8),
        new JdeField("H1DSVJ", "H1DSVJ", JdeDataType.Numeric),
        new JdeField("H1K74FLEN", "H1K74FLEN", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F703030_0", "Primary Key on H1KCO, H1DCT, H1DOC", new[] { "H1KCO", "H1DCT", "H1DOC" }, isUnique: true, isPrimaryKey: true)
    };
}
