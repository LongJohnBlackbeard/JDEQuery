using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW60 - .
/// </summary>
public class FCW60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMC9ITM.
        /// </summary>
        public const string CMC9ITM = "CMC9ITM";

        /// <summary>
        /// CMC9CMP.
        /// </summary>
        public const string CMC9CMP = "CMC9CMP";

        /// <summary>
        /// CMC9SEQ.
        /// </summary>
        public const string CMC9SEQ = "CMC9SEQ";

        /// <summary>
        /// CMC9PERC.
        /// </summary>
        public const string CMC9PERC = "CMC9PERC";

        /// <summary>
        /// CMC9MAT.
        /// </summary>
        public const string CMC9MAT = "CMC9MAT";
    }

    /// <inheritdoc />
    public override string TableName => "FCW60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMC9ITM", "CMC9ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CMC9CMP", "CMC9CMP", JdeDataType.String, 20, true, true),
        new JdeField("CMC9SEQ", "CMC9SEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CMC9PERC", "CMC9PERC", JdeDataType.Numeric),
        new JdeField("CMC9MAT", "CMC9MAT", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW60_0", "Primary Key on CMC9ITM, CMC9CMP, CMC9SEQ", new[] { "CMC9ITM", "CMC9CMP", "CMC9SEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
