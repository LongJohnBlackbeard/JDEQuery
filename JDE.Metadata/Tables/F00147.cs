using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00147 - .
/// </summary>
public class F00147 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// L8DDRL.
        /// </summary>
        public const string L8DDRL = "L8DDRL";

        /// <summary>
        /// L8DYF1.
        /// </summary>
        public const string L8DYF1 = "L8DYF1";

        /// <summary>
        /// L8DYT1.
        /// </summary>
        public const string L8DYT1 = "L8DYT1";

        /// <summary>
        /// L8DCP1.
        /// </summary>
        public const string L8DCP1 = "L8DCP1";

        /// <summary>
        /// L8DYF2.
        /// </summary>
        public const string L8DYF2 = "L8DYF2";

        /// <summary>
        /// L8DYT2.
        /// </summary>
        public const string L8DYT2 = "L8DYT2";

        /// <summary>
        /// L8DCP2.
        /// </summary>
        public const string L8DCP2 = "L8DCP2";

        /// <summary>
        /// L8DYF3.
        /// </summary>
        public const string L8DYF3 = "L8DYF3";

        /// <summary>
        /// L8DYT3.
        /// </summary>
        public const string L8DYT3 = "L8DYT3";

        /// <summary>
        /// L8DCP3.
        /// </summary>
        public const string L8DCP3 = "L8DCP3";

        /// <summary>
        /// L8DYF4.
        /// </summary>
        public const string L8DYF4 = "L8DYF4";

        /// <summary>
        /// L8DYT4.
        /// </summary>
        public const string L8DYT4 = "L8DYT4";

        /// <summary>
        /// L8DCP4.
        /// </summary>
        public const string L8DCP4 = "L8DCP4";

        /// <summary>
        /// L8DYF5.
        /// </summary>
        public const string L8DYF5 = "L8DYF5";

        /// <summary>
        /// L8DYT5.
        /// </summary>
        public const string L8DYT5 = "L8DYT5";

        /// <summary>
        /// L8DCP5.
        /// </summary>
        public const string L8DCP5 = "L8DCP5";
    }

    /// <inheritdoc />
    public override string TableName => "F00147";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("L8DDRL", "L8DDRL", JdeDataType.String, 10, true, true),
        new JdeField("L8DYF1", "L8DYF1", JdeDataType.Numeric),
        new JdeField("L8DYT1", "L8DYT1", JdeDataType.Numeric),
        new JdeField("L8DCP1", "L8DCP1", JdeDataType.Numeric),
        new JdeField("L8DYF2", "L8DYF2", JdeDataType.Numeric),
        new JdeField("L8DYT2", "L8DYT2", JdeDataType.Numeric),
        new JdeField("L8DCP2", "L8DCP2", JdeDataType.Numeric),
        new JdeField("L8DYF3", "L8DYF3", JdeDataType.Numeric),
        new JdeField("L8DYT3", "L8DYT3", JdeDataType.Numeric),
        new JdeField("L8DCP3", "L8DCP3", JdeDataType.Numeric),
        new JdeField("L8DYF4", "L8DYF4", JdeDataType.Numeric),
        new JdeField("L8DYT4", "L8DYT4", JdeDataType.Numeric),
        new JdeField("L8DCP4", "L8DCP4", JdeDataType.Numeric),
        new JdeField("L8DYF5", "L8DYF5", JdeDataType.Numeric),
        new JdeField("L8DYT5", "L8DYT5", JdeDataType.Numeric),
        new JdeField("L8DCP5", "L8DCP5", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00147_0", "Primary Key on L8DDRL", new[] { "L8DDRL" }, isUnique: true, isPrimaryKey: true)
    };
}
