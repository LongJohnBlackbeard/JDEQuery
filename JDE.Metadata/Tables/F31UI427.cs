using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31UI427 - .
/// </summary>
public class F31UI427 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W1JOBS.
        /// </summary>
        public const string W1JOBS = "W1JOBS";

        /// <summary>
        /// W1CTID.
        /// </summary>
        public const string W1CTID = "W1CTID";

        /// <summary>
        /// W1MCU.
        /// </summary>
        public const string W1MCU = "W1MCU";

        /// <summary>
        /// W1OBJ.
        /// </summary>
        public const string W1OBJ = "W1OBJ";

        /// <summary>
        /// W1SUB.
        /// </summary>
        public const string W1SUB = "W1SUB";

        /// <summary>
        /// W1DOCO.
        /// </summary>
        public const string W1DOCO = "W1DOCO";

        /// <summary>
        /// W1DCTO.
        /// </summary>
        public const string W1DCTO = "W1DCTO";

        /// <summary>
        /// W1GLPT.
        /// </summary>
        public const string W1GLPT = "W1GLPT";

        /// <summary>
        /// W1MMCU.
        /// </summary>
        public const string W1MMCU = "W1MMCU";

        /// <summary>
        /// W1CMCU.
        /// </summary>
        public const string W1CMCU = "W1CMCU";

        /// <summary>
        /// W1VARA.
        /// </summary>
        public const string W1VARA = "W1VARA";
    }

    /// <inheritdoc />
    public override string TableName => "F31UI427";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W1JOBS", "W1JOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("W1CTID", "W1CTID", JdeDataType.String, 30, true, true),
        new JdeField("W1MCU", "W1MCU", JdeDataType.String, 24, true, true),
        new JdeField("W1OBJ", "W1OBJ", JdeDataType.String, 12, true, true),
        new JdeField("W1SUB", "W1SUB", JdeDataType.String, 16, true, true),
        new JdeField("W1DOCO", "W1DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("W1DCTO", "W1DCTO", JdeDataType.String, 4, true, true),
        new JdeField("W1GLPT", "W1GLPT", JdeDataType.String, 8, true, true),
        new JdeField("W1MMCU", "W1MMCU", JdeDataType.String, 24),
        new JdeField("W1CMCU", "W1CMCU", JdeDataType.String, 24),
        new JdeField("W1VARA", "W1VARA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31UI427_0", "Primary Key on W1JOBS, W1CTID, W1MCU, W1OBJ, W1SUB, W1DOCO, W1DCTO, W1GLPT", new[] { "W1JOBS", "W1CTID", "W1MCU", "W1OBJ", "W1SUB", "W1DOCO", "W1DCTO", "W1GLPT" }, isUnique: true, isPrimaryKey: true)
    };
}
