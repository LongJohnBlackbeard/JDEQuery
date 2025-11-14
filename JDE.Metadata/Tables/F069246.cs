using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069246 - .
/// </summary>
public class F069246 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y3SHFT.
        /// </summary>
        public const string Y3SHFT = "Y3SHFT";

        /// <summary>
        /// Y3MCU.
        /// </summary>
        public const string Y3MCU = "Y3MCU";

        /// <summary>
        /// Y3UN.
        /// </summary>
        public const string Y3UN = "Y3UN";

        /// <summary>
        /// Y3EFTB.
        /// </summary>
        public const string Y3EFTB = "Y3EFTB";

        /// <summary>
        /// Y3EFTE.
        /// </summary>
        public const string Y3EFTE = "Y3EFTE";

        /// <summary>
        /// Y3SHD.
        /// </summary>
        public const string Y3SHD = "Y3SHD";

        /// <summary>
        /// Y3LD.
        /// </summary>
        public const string Y3LD = "Y3LD";

        /// <summary>
        /// Y3CMTH.
        /// </summary>
        public const string Y3CMTH = "Y3CMTH";
    }

    /// <inheritdoc />
    public override string TableName => "F069246";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y3SHFT", "Y3SHFT", JdeDataType.String, 2, true, true),
        new JdeField("Y3MCU", "Y3MCU", JdeDataType.String, 24, true, true),
        new JdeField("Y3UN", "Y3UN", JdeDataType.String, 12, true, true),
        new JdeField("Y3EFTB", "Y3EFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("Y3EFTE", "Y3EFTE", JdeDataType.Numeric),
        new JdeField("Y3SHD", "Y3SHD", JdeDataType.Numeric),
        new JdeField("Y3LD", "Y3LD", JdeDataType.String, 2),
        new JdeField("Y3CMTH", "Y3CMTH", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069246_0", "Primary Key on Y3SHFT, Y3MCU, Y3UN, Y3EFTB", new[] { "Y3SHFT", "Y3MCU", "Y3UN", "Y3EFTB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F069246_2", "Index on Y3SHFT, Y3MCU, Y3UN, Y3EFTE", new[] { "Y3SHFT", "Y3MCU", "Y3UN", "Y3EFTE" })
    };
}
