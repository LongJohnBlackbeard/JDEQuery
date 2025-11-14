using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P3B70 - .
/// </summary>
public class F76P3B70 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDSEQ.
        /// </summary>
        public const string PDSEQ = "PDSEQ";

        /// <summary>
        /// PDP76PDTA.
        /// </summary>
        public const string PDP76PDTA = "PDP76PDTA";
    }

    /// <inheritdoc />
    public override string TableName => "F76P3B70";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDSEQ", "PDSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PDP76PDTA", "PDP76PDTA", JdeDataType.String, 394)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P3B70_0", "Primary Key on PDSEQ", new[] { "PDSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76P3B70_2", "Index on SYS_NC00003$", new[] { "SYS_NC00003$" })
    };
}
