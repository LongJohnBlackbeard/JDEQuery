using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A42 - .
/// </summary>
public class F76A42 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TFCO.
        /// </summary>
        public const string TFCO = "TFCO";

        /// <summary>
        /// TFAID.
        /// </summary>
        public const string TFAID = "TFAID";

        /// <summary>
        /// TFACBO.
        /// </summary>
        public const string TFACBO = "TFACBO";

        /// <summary>
        /// TFDGJ.
        /// </summary>
        public const string TFDGJ = "TFDGJ";

        /// <summary>
        /// TFVLDT.
        /// </summary>
        public const string TFVLDT = "TFVLDT";

        /// <summary>
        /// TFAA.
        /// </summary>
        public const string TFAA = "TFAA";

        /// <summary>
        /// TFEV01.
        /// </summary>
        public const string TFEV01 = "TFEV01";

        /// <summary>
        /// TFCN.
        /// </summary>
        public const string TFCN = "TFCN";

        /// <summary>
        /// TFDC20.
        /// </summary>
        public const string TFDC20 = "TFDC20";

        /// <summary>
        /// TFVTOX.
        /// </summary>
        public const string TFVTOX = "TFVTOX";

        /// <summary>
        /// TFEXA.
        /// </summary>
        public const string TFEXA = "TFEXA";
    }

    /// <inheritdoc />
    public override string TableName => "F76A42";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TFCO", "TFCO", JdeDataType.String, 10),
        new JdeField("TFAID", "TFAID", JdeDataType.String, 16),
        new JdeField("TFACBO", "TFACBO", JdeDataType.String, 10),
        new JdeField("TFDGJ", "TFDGJ", JdeDataType.Numeric),
        new JdeField("TFVLDT", "TFVLDT", JdeDataType.Numeric),
        new JdeField("TFAA", "TFAA", JdeDataType.Numeric),
        new JdeField("TFEV01", "TFEV01", JdeDataType.String, 2),
        new JdeField("TFCN", "TFCN", JdeDataType.String, 16),
        new JdeField("TFDC20", "TFDC20", JdeDataType.String, 40),
        new JdeField("TFVTOX", "TFVTOX", JdeDataType.String, 60, true, true),
        new JdeField("TFEXA", "TFEXA", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A42_0", "Primary Key on TFVTOX", new[] { "TFVTOX" }, isUnique: true, isPrimaryKey: true)
    };
}
