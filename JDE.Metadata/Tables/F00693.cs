using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00693 - .
/// </summary>
public class F00693 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M3TYDA.
        /// </summary>
        public const string M3TYDA = "M3TYDA";

        /// <summary>
        /// M3MCU.
        /// </summary>
        public const string M3MCU = "M3MCU";

        /// <summary>
        /// M3KY.
        /// </summary>
        public const string M3KY = "M3KY";

        /// <summary>
        /// M3EFT.
        /// </summary>
        public const string M3EFT = "M3EFT";

        /// <summary>
        /// M3LIN.
        /// </summary>
        public const string M3LIN = "M3LIN";

        /// <summary>
        /// M3DS80.
        /// </summary>
        public const string M3DS80 = "M3DS80";
    }

    /// <inheritdoc />
    public override string TableName => "F00693";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M3TYDA", "M3TYDA", JdeDataType.String, 4, true, true),
        new JdeField("M3MCU", "M3MCU", JdeDataType.String, 24, true, true),
        new JdeField("M3KY", "M3KY", JdeDataType.String, 20, true, true),
        new JdeField("M3EFT", "M3EFT", JdeDataType.Numeric, null, true, true),
        new JdeField("M3LIN", "M3LIN", JdeDataType.Numeric, null, true, true),
        new JdeField("M3DS80", "M3DS80", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00693_0", "Primary Key on M3TYDA, M3MCU, M3KY, M3EFT, M3LIN", new[] { "M3TYDA", "M3MCU", "M3KY", "M3EFT", "M3LIN" }, isUnique: true, isPrimaryKey: true)
    };
}
