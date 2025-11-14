using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A17 - .
/// </summary>
public class F76A17 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TLTXA1.
        /// </summary>
        public const string TLTXA1 = "TLTXA1";

        /// <summary>
        /// TLKCO.
        /// </summary>
        public const string TLKCO = "TLKCO";

        /// <summary>
        /// TLMCU.
        /// </summary>
        public const string TLMCU = "TLMCU";

        /// <summary>
        /// TLAGRP.
        /// </summary>
        public const string TLAGRP = "TLAGRP";

        /// <summary>
        /// TLARBR.
        /// </summary>
        public const string TLARBR = "TLARBR";
    }

    /// <inheritdoc />
    public override string TableName => "F76A17";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TLTXA1", "TLTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TLKCO", "TLKCO", JdeDataType.String, 10, true, true),
        new JdeField("TLMCU", "TLMCU", JdeDataType.String, 24, true, true),
        new JdeField("TLAGRP", "TLAGRP", JdeDataType.String, 2),
        new JdeField("TLARBR", "TLARBR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A17_0", "Primary Key on TLTXA1, TLKCO, TLMCU", new[] { "TLTXA1", "TLKCO", "TLMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
