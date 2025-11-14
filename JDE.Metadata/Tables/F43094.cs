using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43094 - .
/// </summary>
public class F43094 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// P5AN8.
        /// </summary>
        public const string P5AN8 = "P5AN8";

        /// <summary>
        /// P5ITM.
        /// </summary>
        public const string P5ITM = "P5ITM";

        /// <summary>
        /// P5MCU.
        /// </summary>
        public const string P5MCU = "P5MCU";

        /// <summary>
        /// P5CEFJ.
        /// </summary>
        public const string P5CEFJ = "P5CEFJ";

        /// <summary>
        /// P5CXPJ.
        /// </summary>
        public const string P5CXPJ = "P5CXPJ";

        /// <summary>
        /// P5NROU.
        /// </summary>
        public const string P5NROU = "P5NROU";

        /// <summary>
        /// P5TROU.
        /// </summary>
        public const string P5TROU = "P5TROU";

        /// <summary>
        /// P5ROTP.
        /// </summary>
        public const string P5ROTP = "P5ROTP";
    }

    /// <inheritdoc />
    public override string TableName => "F43094";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("P5AN8", "P5AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("P5ITM", "P5ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("P5MCU", "P5MCU", JdeDataType.String, 24, true, true),
        new JdeField("P5CEFJ", "P5CEFJ", JdeDataType.Numeric),
        new JdeField("P5CXPJ", "P5CXPJ", JdeDataType.Numeric, null, true, true),
        new JdeField("P5NROU", "P5NROU", JdeDataType.String, 8),
        new JdeField("P5TROU", "P5TROU", JdeDataType.String, 8),
        new JdeField("P5ROTP", "P5ROTP", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43094_0", "Primary Key on P5AN8, P5ITM, P5MCU, P5ROTP, P5CXPJ", new[] { "P5AN8", "P5ITM", "P5MCU", "P5ROTP", "P5CXPJ" }, isUnique: true, isPrimaryKey: true)
    };
}
