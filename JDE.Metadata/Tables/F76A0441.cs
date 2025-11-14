using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A0441 - .
/// </summary>
public class F76A0441 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRRESSQ.
        /// </summary>
        public const string TRRESSQ = "TRRESSQ";

        /// <summary>
        /// TRP3.
        /// </summary>
        public const string TRP3 = "TRP3";
    }

    /// <inheritdoc />
    public override string TableName => "F76A0441";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRRESSQ", "TRRESSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("TRP3", "TRP3", JdeDataType.String, 512)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A0441_0", "Primary Key on TRRESSQ", new[] { "TRRESSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A0441_2", "Index on SYS_NC00003$", new[] { "SYS_NC00003$" })
    };
}
