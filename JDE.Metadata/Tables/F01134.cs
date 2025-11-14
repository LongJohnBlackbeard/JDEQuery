using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01134 - .
/// </summary>
public class F01134 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZWUSER.
        /// </summary>
        public const string ZWUSER = "ZWUSER";

        /// <summary>
        /// ZWDSS5.
        /// </summary>
        public const string ZWDSS5 = "ZWDSS5";

        /// <summary>
        /// ZWUGRP.
        /// </summary>
        public const string ZWUGRP = "ZWUGRP";

        /// <summary>
        /// ZWAN8.
        /// </summary>
        public const string ZWAN8 = "ZWAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F01134";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZWUSER", "ZWUSER", JdeDataType.String, 20, true, true),
        new JdeField("ZWDSS5", "ZWDSS5", JdeDataType.Numeric),
        new JdeField("ZWUGRP", "ZWUGRP", JdeDataType.String, 20, true, true),
        new JdeField("ZWAN8", "ZWAN8", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01134_0", "Primary Key on ZWUSER, ZWUGRP, ZWAN8", new[] { "ZWUSER", "ZWUGRP", "ZWAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01134_2", "Index on ZWUSER, ZWAN8", new[] { "ZWUSER", "ZWAN8" }),
        new JdeIndex("F01134_3", "Index on ZWUGRP, ZWAN8", new[] { "ZWUGRP", "ZWAN8" })
    };
}
