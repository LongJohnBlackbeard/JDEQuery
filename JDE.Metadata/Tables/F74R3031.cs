using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R3031 - .
/// </summary>
public class F74R3031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIKCO.
        /// </summary>
        public const string PIKCO = "PIKCO";

        /// <summary>
        /// PIDCT.
        /// </summary>
        public const string PIDCT = "PIDCT";

        /// <summary>
        /// PIDOC.
        /// </summary>
        public const string PIDOC = "PIDOC";

        /// <summary>
        /// PIAN8.
        /// </summary>
        public const string PIAN8 = "PIAN8";

        /// <summary>
        /// PIANTY.
        /// </summary>
        public const string PIANTY = "PIANTY";

        /// <summary>
        /// PIR74LAR.
        /// </summary>
        public const string PIR74LAR = "PIR74LAR";

        /// <summary>
        /// PIK74LMN.
        /// </summary>
        public const string PIK74LMN = "PIK74LMN";

        /// <summary>
        /// PIK74ADL1.
        /// </summary>
        public const string PIK74ADL1 = "PIK74ADL1";

        /// <summary>
        /// PIK74ADL2.
        /// </summary>
        public const string PIK74ADL2 = "PIK74ADL2";

        /// <summary>
        /// PIK74ADL3.
        /// </summary>
        public const string PIK74ADL3 = "PIK74ADL3";

        /// <summary>
        /// PIK74ADL4.
        /// </summary>
        public const string PIK74ADL4 = "PIK74ADL4";
    }

    /// <inheritdoc />
    public override string TableName => "F74R3031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PIAN8", "PIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PIANTY", "PIANTY", JdeDataType.String, 2, true, true),
        new JdeField("PIR74LAR", "PIR74LAR", JdeDataType.String, 200),
        new JdeField("PIK74LMN", "PIK74LMN", JdeDataType.String, 200),
        new JdeField("PIK74ADL1", "PIK74ADL1", JdeDataType.String, 200),
        new JdeField("PIK74ADL2", "PIK74ADL2", JdeDataType.String, 200),
        new JdeField("PIK74ADL3", "PIK74ADL3", JdeDataType.String, 200),
        new JdeField("PIK74ADL4", "PIK74ADL4", JdeDataType.String, 200)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R3031_0", "Primary Key on PIKCO, PIDCT, PIDOC, PIAN8, PIANTY", new[] { "PIKCO", "PIDCT", "PIDOC", "PIAN8", "PIANTY" }, isUnique: true, isPrimaryKey: true)
    };
}
