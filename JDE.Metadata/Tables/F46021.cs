using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46021 - .
/// </summary>
public class F46021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LQMCU.
        /// </summary>
        public const string LQMCU = "LQMCU";

        /// <summary>
        /// LQCGRP.
        /// </summary>
        public const string LQCGRP = "LQCGRP";

        /// <summary>
        /// LQLOCN.
        /// </summary>
        public const string LQLOCN = "LQLOCN";

        /// <summary>
        /// LQDEFI.
        /// </summary>
        public const string LQDEFI = "LQDEFI";

        /// <summary>
        /// LQUSER.
        /// </summary>
        public const string LQUSER = "LQUSER";

        /// <summary>
        /// LQUPMJ.
        /// </summary>
        public const string LQUPMJ = "LQUPMJ";

        /// <summary>
        /// LQTDAY.
        /// </summary>
        public const string LQTDAY = "LQTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LQMCU", "LQMCU", JdeDataType.String, 24, true, true),
        new JdeField("LQCGRP", "LQCGRP", JdeDataType.String, 12, true, true),
        new JdeField("LQLOCN", "LQLOCN", JdeDataType.String, 40, true, true),
        new JdeField("LQDEFI", "LQDEFI", JdeDataType.String, 20, true, true),
        new JdeField("LQUSER", "LQUSER", JdeDataType.String, 20),
        new JdeField("LQUPMJ", "LQUPMJ", JdeDataType.Numeric),
        new JdeField("LQTDAY", "LQTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46021_0", "Primary Key on LQMCU, LQCGRP, LQLOCN, LQDEFI", new[] { "LQMCU", "LQCGRP", "LQLOCN", "LQDEFI" }, isUnique: true, isPrimaryKey: true)
    };
}
