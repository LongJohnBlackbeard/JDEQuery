using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S505 - .
/// </summary>
public class F74S505 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHUKID.
        /// </summary>
        public const string SHUKID = "SHUKID";

        /// <summary>
        /// SHCRCD.
        /// </summary>
        public const string SHCRCD = "SHCRCD";

        /// <summary>
        /// SHDOTD.
        /// </summary>
        public const string SHDOTD = "SHDOTD";

        /// <summary>
        /// SHEFTJ.
        /// </summary>
        public const string SHEFTJ = "SHEFTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F74S505";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHUKID", "SHUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SHCRCD", "SHCRCD", JdeDataType.String, 6),
        new JdeField("SHDOTD", "SHDOTD", JdeDataType.Numeric),
        new JdeField("SHEFTJ", "SHEFTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S505_0", "Primary Key on SHUKID", new[] { "SHUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S505_2", "Index on SHCRCD, SYS_NC00005$, SHDOTD", new[] { "SHCRCD", "SYS_NC00005$", "SHDOTD" }),
        new JdeIndex("F74S505_3", "Index on SHCRCD, SYS_NC00006$, SYS_NC00005$", new[] { "SHCRCD", "SYS_NC00006$", "SYS_NC00005$" })
    };
}
