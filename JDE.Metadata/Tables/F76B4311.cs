using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4311 - .
/// </summary>
public class F76B4311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PHDOCO.
        /// </summary>
        public const string PHDOCO = "PHDOCO";

        /// <summary>
        /// PHDCTO.
        /// </summary>
        public const string PHDCTO = "PHDCTO";

        /// <summary>
        /// PHKCOO.
        /// </summary>
        public const string PHKCOO = "PHKCOO";

        /// <summary>
        /// PHSFXO.
        /// </summary>
        public const string PHSFXO = "PHSFXO";

        /// <summary>
        /// PHB76BICC.
        /// </summary>
        public const string PHB76BICC = "PHB76BICC";

        /// <summary>
        /// PHB76NUM.
        /// </summary>
        public const string PHB76NUM = "PHB76NUM";

        /// <summary>
        /// PHB76AA.
        /// </summary>
        public const string PHB76AA = "PHB76AA";

        /// <summary>
        /// PHB76REF.
        /// </summary>
        public const string PHB76REF = "PHB76REF";

        /// <summary>
        /// PHB76COD.
        /// </summary>
        public const string PHB76COD = "PHB76COD";

        /// <summary>
        /// PHB76DATE.
        /// </summary>
        public const string PHB76DATE = "PHB76DATE";

        /// <summary>
        /// PHPID.
        /// </summary>
        public const string PHPID = "PHPID";

        /// <summary>
        /// PHUSER.
        /// </summary>
        public const string PHUSER = "PHUSER";

        /// <summary>
        /// PHJOBN.
        /// </summary>
        public const string PHJOBN = "PHJOBN";

        /// <summary>
        /// PHUPMJ.
        /// </summary>
        public const string PHUPMJ = "PHUPMJ";

        /// <summary>
        /// PHUPMT.
        /// </summary>
        public const string PHUPMT = "PHUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B4311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PHDOCO", "PHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PHDCTO", "PHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PHKCOO", "PHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PHSFXO", "PHSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PHB76BICC", "PHB76BICC", JdeDataType.String, 2),
        new JdeField("PHB76NUM", "PHB76NUM", JdeDataType.Numeric),
        new JdeField("PHB76AA", "PHB76AA", JdeDataType.Numeric),
        new JdeField("PHB76REF", "PHB76REF", JdeDataType.String, 30),
        new JdeField("PHB76COD", "PHB76COD", JdeDataType.String, 4),
        new JdeField("PHB76DATE", "PHB76DATE", JdeDataType.Numeric),
        new JdeField("PHPID", "PHPID", JdeDataType.String, 20),
        new JdeField("PHUSER", "PHUSER", JdeDataType.String, 20),
        new JdeField("PHJOBN", "PHJOBN", JdeDataType.String, 20),
        new JdeField("PHUPMJ", "PHUPMJ", JdeDataType.Numeric),
        new JdeField("PHUPMT", "PHUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4311_0", "Primary Key on PHDOCO, PHDCTO, PHKCOO, PHSFXO", new[] { "PHDOCO", "PHDCTO", "PHKCOO", "PHSFXO" }, isUnique: true, isPrimaryKey: true)
    };
}
