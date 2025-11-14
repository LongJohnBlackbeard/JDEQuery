using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P420 - .
/// </summary>
public class F76P420 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDCSQ.
        /// </summary>
        public const string PDCSQ = "PDCSQ";

        /// <summary>
        /// PDP76PDTP.
        /// </summary>
        public const string PDP76PDTP = "PDP76PDTP";
    }

    /// <inheritdoc />
    public override string TableName => "F76P420";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDCSQ", "PDCSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PDP76PDTP", "PDP76PDTP", JdeDataType.String, 386)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P420_0", "Primary Key on PDCSQ", new[] { "PDCSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76P420_2", "Index on SYS_NC00003$", new[] { "SYS_NC00003$" })
    };
}
