using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41095 - .
/// </summary>
public class F41095 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T5DSS5.
        /// </summary>
        public const string T5DSS5 = "T5DSS5";

        /// <summary>
        /// T5USER.
        /// </summary>
        public const string T5USER = "T5USER";

        /// <summary>
        /// T5TYDB.
        /// </summary>
        public const string T5TYDB = "T5TYDB";

        /// <summary>
        /// T5UGRP.
        /// </summary>
        public const string T5UGRP = "T5UGRP";
    }

    /// <inheritdoc />
    public override string TableName => "F41095";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T5DSS5", "T5DSS5", JdeDataType.Numeric),
        new JdeField("T5USER", "T5USER", JdeDataType.String, 20, true, true),
        new JdeField("T5TYDB", "T5TYDB", JdeDataType.String, 4, true, true),
        new JdeField("T5UGRP", "T5UGRP", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41095_0", "Primary Key on T5USER, T5TYDB", new[] { "T5USER", "T5TYDB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41095_2", "Index on T5USER, T5UGRP, T5DSS5", new[] { "T5USER", "T5UGRP", "T5DSS5" }),
        new JdeIndex("F41095_3", "Index on T5TYDB, T5USER, T5UGRP", new[] { "T5TYDB", "T5USER", "T5UGRP" }),
        new JdeIndex("F41095_4", "Index on T5UGRP, T5TYDB", new[] { "T5UGRP", "T5TYDB" })
    };
}
