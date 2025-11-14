using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B501 - .
/// </summary>
public class F31B501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BSMCU.
        /// </summary>
        public const string BSMCU = "BSMCU";

        /// <summary>
        /// BSVARID.
        /// </summary>
        public const string BSVARID = "BSVARID";

        /// <summary>
        /// BSSEQNUMB.
        /// </summary>
        public const string BSSEQNUMB = "BSSEQNUMB";
    }

    /// <inheritdoc />
    public override string TableName => "F31B501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BSMCU", "BSMCU", JdeDataType.String, 24, true, true),
        new JdeField("BSVARID", "BSVARID", JdeDataType.Numeric, null, true, true),
        new JdeField("BSSEQNUMB", "BSSEQNUMB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B501_0", "Primary Key on BSMCU, BSVARID", new[] { "BSMCU", "BSVARID" }, isUnique: true, isPrimaryKey: true)
    };
}
