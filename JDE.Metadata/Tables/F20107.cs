using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F20107 - .
/// </summary>
public class F20107 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BPEMPLOYID.
        /// </summary>
        public const string BPEMPLOYID = "BPEMPLOYID";

        /// <summary>
        /// BPBUSPURP.
        /// </summary>
        public const string BPBUSPURP = "BPBUSPURP";

        /// <summary>
        /// BPPID.
        /// </summary>
        public const string BPPID = "BPPID";

        /// <summary>
        /// BPJOBN.
        /// </summary>
        public const string BPJOBN = "BPJOBN";

        /// <summary>
        /// BPUPMJ.
        /// </summary>
        public const string BPUPMJ = "BPUPMJ";

        /// <summary>
        /// BPUPMT.
        /// </summary>
        public const string BPUPMT = "BPUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F20107";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BPEMPLOYID", "BPEMPLOYID", JdeDataType.Numeric, null, true, true),
        new JdeField("BPBUSPURP", "BPBUSPURP", JdeDataType.String, 80, true, true),
        new JdeField("BPPID", "BPPID", JdeDataType.String, 20),
        new JdeField("BPJOBN", "BPJOBN", JdeDataType.String, 20),
        new JdeField("BPUPMJ", "BPUPMJ", JdeDataType.Numeric),
        new JdeField("BPUPMT", "BPUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F20107_0", "Primary Key on BPEMPLOYID, BPBUSPURP", new[] { "BPEMPLOYID", "BPBUSPURP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F20107_2", "Index on BPEMPLOYID, SYS_NC00007$, SYS_NC00008$, BPBUSPURP", new[] { "BPEMPLOYID", "SYS_NC00007$", "SYS_NC00008$", "BPBUSPURP" })
    };
}
