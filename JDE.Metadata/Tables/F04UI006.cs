using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F04UI006 - .
/// </summary>
public class F04UI006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G1CO.
        /// </summary>
        public const string G1CO = "G1CO";

        /// <summary>
        /// G1EIN.
        /// </summary>
        public const string G1EIN = "G1EIN";

        /// <summary>
        /// G1AN8.
        /// </summary>
        public const string G1AN8 = "G1AN8";

        /// <summary>
        /// G1TAX.
        /// </summary>
        public const string G1TAX = "G1TAX";

        /// <summary>
        /// G1JOBS.
        /// </summary>
        public const string G1JOBS = "G1JOBS";

        /// <summary>
        /// G1CTID.
        /// </summary>
        public const string G1CTID = "G1CTID";
    }

    /// <inheritdoc />
    public override string TableName => "F04UI006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G1CO", "G1CO", JdeDataType.String, 10, true, true),
        new JdeField("G1EIN", "G1EIN", JdeDataType.String, 40, true, true),
        new JdeField("G1AN8", "G1AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("G1TAX", "G1TAX", JdeDataType.String, 40, true, true),
        new JdeField("G1JOBS", "G1JOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("G1CTID", "G1CTID", JdeDataType.String, 30, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F04UI006_0", "Primary Key on G1CO, G1EIN, G1AN8, G1TAX, G1JOBS, G1CTID", new[] { "G1CO", "G1EIN", "G1AN8", "G1TAX", "G1JOBS", "G1CTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F04UI006_2", "Index on G1CO, G1JOBS, G1CTID", new[] { "G1CO", "G1JOBS", "G1CTID" }),
        new JdeIndex("F04UI006_3", "Index on G1EIN, G1JOBS, G1CTID", new[] { "G1EIN", "G1JOBS", "G1CTID" }),
        new JdeIndex("F04UI006_4", "Index on G1AN8, G1JOBS, G1CTID", new[] { "G1AN8", "G1JOBS", "G1CTID" }),
        new JdeIndex("F04UI006_5", "Index on G1TAX, G1JOBS, G1CTID", new[] { "G1TAX", "G1JOBS", "G1CTID" })
    };
}
