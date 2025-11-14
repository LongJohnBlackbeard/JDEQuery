using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1113 - .
/// </summary>
public class F1113 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C1RTTY.
        /// </summary>
        public const string C1RTTY = "C1RTTY";

        /// <summary>
        /// C1CRDC.
        /// </summary>
        public const string C1CRDC = "C1CRDC";

        /// <summary>
        /// C1CRCD.
        /// </summary>
        public const string C1CRCD = "C1CRCD";

        /// <summary>
        /// C1EFT.
        /// </summary>
        public const string C1EFT = "C1EFT";

        /// <summary>
        /// C1CRR.
        /// </summary>
        public const string C1CRR = "C1CRR";

        /// <summary>
        /// C1CRRD.
        /// </summary>
        public const string C1CRRD = "C1CRRD";
    }

    /// <inheritdoc />
    public override string TableName => "F1113";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C1RTTY", "C1RTTY", JdeDataType.String, 4, true, true),
        new JdeField("C1CRDC", "C1CRDC", JdeDataType.String, 6, true, true),
        new JdeField("C1CRCD", "C1CRCD", JdeDataType.String, 6, true, true),
        new JdeField("C1EFT", "C1EFT", JdeDataType.Numeric, null, true, true),
        new JdeField("C1CRR", "C1CRR", JdeDataType.Numeric),
        new JdeField("C1CRRD", "C1CRRD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1113_0", "Primary Key on C1CRDC, C1CRCD, C1RTTY, C1EFT", new[] { "C1CRDC", "C1CRCD", "C1RTTY", "C1EFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1113_2", "Index on C1EFT", new[] { "C1EFT" })
    };
}
