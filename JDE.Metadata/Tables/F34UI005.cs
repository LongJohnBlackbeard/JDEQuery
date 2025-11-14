using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34UI005 - .
/// </summary>
public class F34UI005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// F5JOBS.
        /// </summary>
        public const string F5JOBS = "F5JOBS";

        /// <summary>
        /// F5CTID.
        /// </summary>
        public const string F5CTID = "F5CTID";

        /// <summary>
        /// F5MCU.
        /// </summary>
        public const string F5MCU = "F5MCU";

        /// <summary>
        /// F5ITM.
        /// </summary>
        public const string F5ITM = "F5ITM";

        /// <summary>
        /// F5DRQJ.
        /// </summary>
        public const string F5DRQJ = "F5DRQJ";

        /// <summary>
        /// F5TP.
        /// </summary>
        public const string F5TP = "F5TP";

        /// <summary>
        /// F5NQ01.
        /// </summary>
        public const string F5NQ01 = "F5NQ01";
    }

    /// <inheritdoc />
    public override string TableName => "F34UI005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("F5JOBS", "F5JOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("F5CTID", "F5CTID", JdeDataType.String, 30, true, true),
        new JdeField("F5MCU", "F5MCU", JdeDataType.String, 24, true, true),
        new JdeField("F5ITM", "F5ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("F5DRQJ", "F5DRQJ", JdeDataType.Numeric, null, true, true),
        new JdeField("F5TP", "F5TP", JdeDataType.String, 6, true, true),
        new JdeField("F5NQ01", "F5NQ01", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34UI005_0", "Primary Key on F5JOBS, F5CTID, F5MCU, F5ITM, F5DRQJ, F5TP", new[] { "F5JOBS", "F5CTID", "F5MCU", "F5ITM", "F5DRQJ", "F5TP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34UI005_2", "Index on F5JOBS, F5CTID, F5TP", new[] { "F5JOBS", "F5CTID", "F5TP" }),
        new JdeIndex("F34UI005_3", "Index on F5JOBS, F5CTID, F5MCU, F5ITM, F5TP, F5DRQJ", new[] { "F5JOBS", "F5CTID", "F5MCU", "F5ITM", "F5TP", "F5DRQJ" }),
        new JdeIndex("F34UI005_4", "Index on F5JOBS, F5CTID, F5ITM, F5TP", new[] { "F5JOBS", "F5CTID", "F5ITM", "F5TP" })
    };
}
