using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00692 - .
/// </summary>
public class F00692 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// M2TYDA.
        /// </summary>
        public const string M2TYDA = "M2TYDA";

        /// <summary>
        /// M2MCU.
        /// </summary>
        public const string M2MCU = "M2MCU";

        /// <summary>
        /// M2KY.
        /// </summary>
        public const string M2KY = "M2KY";

        /// <summary>
        /// M2EFT.
        /// </summary>
        public const string M2EFT = "M2EFT";

        /// <summary>
        /// M2EFTE.
        /// </summary>
        public const string M2EFTE = "M2EFTE";

        /// <summary>
        /// M2AMTU.
        /// </summary>
        public const string M2AMTU = "M2AMTU";

        /// <summary>
        /// M2RMK.
        /// </summary>
        public const string M2RMK = "M2RMK";

        /// <summary>
        /// M2RMK2.
        /// </summary>
        public const string M2RMK2 = "M2RMK2";
    }

    /// <inheritdoc />
    public override string TableName => "F00692";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("M2TYDA", "M2TYDA", JdeDataType.String, 4, true, true),
        new JdeField("M2MCU", "M2MCU", JdeDataType.String, 24, true, true),
        new JdeField("M2KY", "M2KY", JdeDataType.String, 20, true, true),
        new JdeField("M2EFT", "M2EFT", JdeDataType.Numeric, null, true, true),
        new JdeField("M2EFTE", "M2EFTE", JdeDataType.Numeric),
        new JdeField("M2AMTU", "M2AMTU", JdeDataType.Numeric),
        new JdeField("M2RMK", "M2RMK", JdeDataType.String, 60),
        new JdeField("M2RMK2", "M2RMK2", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00692_0", "Primary Key on M2TYDA, M2MCU, M2EFT, M2KY", new[] { "M2TYDA", "M2MCU", "M2EFT", "M2KY" }, isUnique: true, isPrimaryKey: true)
    };
}
