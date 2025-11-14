using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76002A - .
/// </summary>
public class F76002A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JDDCT.
        /// </summary>
        public const string JDDCT = "JDDCT";

        /// <summary>
        /// JDAGRP.
        /// </summary>
        public const string JDAGRP = "JDAGRP";

        /// <summary>
        /// JDADGI.
        /// </summary>
        public const string JDADGI = "JDADGI";

        /// <summary>
        /// JDADGI1.
        /// </summary>
        public const string JDADGI1 = "JDADGI1";
    }

    /// <inheritdoc />
    public override string TableName => "F76002A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JDDCT", "JDDCT", JdeDataType.String, 4, true, true),
        new JdeField("JDAGRP", "JDAGRP", JdeDataType.String, 2, true, true),
        new JdeField("JDADGI", "JDADGI", JdeDataType.String, 4),
        new JdeField("JDADGI1", "JDADGI1", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76002A_0", "Primary Key on JDDCT, JDAGRP", new[] { "JDDCT", "JDAGRP" }, isUnique: true, isPrimaryKey: true)
    };
}
