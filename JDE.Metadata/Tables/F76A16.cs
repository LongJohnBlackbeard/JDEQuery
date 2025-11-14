using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A16 - .
/// </summary>
public class F76A16 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TGTXA1.
        /// </summary>
        public const string TGTXA1 = "TGTXA1";

        /// <summary>
        /// TGKCO.
        /// </summary>
        public const string TGKCO = "TGKCO";

        /// <summary>
        /// TGMCU.
        /// </summary>
        public const string TGMCU = "TGMCU";

        /// <summary>
        /// TGEFTJ.
        /// </summary>
        public const string TGEFTJ = "TGEFTJ";

        /// <summary>
        /// TGATXC.
        /// </summary>
        public const string TGATXC = "TGATXC";

        /// <summary>
        /// TGASEC.
        /// </summary>
        public const string TGASEC = "TGASEC";
    }

    /// <inheritdoc />
    public override string TableName => "F76A16";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TGTXA1", "TGTXA1", JdeDataType.String, 20, true, true),
        new JdeField("TGKCO", "TGKCO", JdeDataType.String, 10, true, true),
        new JdeField("TGMCU", "TGMCU", JdeDataType.String, 24, true, true),
        new JdeField("TGEFTJ", "TGEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TGATXC", "TGATXC", JdeDataType.String, 20, true, true),
        new JdeField("TGASEC", "TGASEC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A16_0", "Primary Key on TGTXA1, TGKCO, TGMCU, TGEFTJ, TGATXC", new[] { "TGTXA1", "TGKCO", "TGMCU", "TGEFTJ", "TGATXC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76A16_2", "Index on TGTXA1, TGKCO, TGMCU, TGEFTJ, TGASEC", new[] { "TGTXA1", "TGKCO", "TGMCU", "TGEFTJ", "TGASEC" })
    };
}
