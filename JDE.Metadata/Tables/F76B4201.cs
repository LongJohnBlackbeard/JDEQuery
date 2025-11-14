using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4201 - .
/// </summary>
public class F76B4201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SHKCOO.
        /// </summary>
        public const string SHKCOO = "SHKCOO";

        /// <summary>
        /// SHDOCO.
        /// </summary>
        public const string SHDOCO = "SHDOCO";

        /// <summary>
        /// SHDCTO.
        /// </summary>
        public const string SHDCTO = "SHDCTO";

        /// <summary>
        /// SHSFXO.
        /// </summary>
        public const string SHSFXO = "SHSFXO";

        /// <summary>
        /// SHB76BICC.
        /// </summary>
        public const string SHB76BICC = "SHB76BICC";

        /// <summary>
        /// SHB76PPI.
        /// </summary>
        public const string SHB76PPI = "SHB76PPI";

        /// <summary>
        /// SHB76NUM.
        /// </summary>
        public const string SHB76NUM = "SHB76NUM";

        /// <summary>
        /// SHB76AA.
        /// </summary>
        public const string SHB76AA = "SHB76AA";

        /// <summary>
        /// SHB76REF.
        /// </summary>
        public const string SHB76REF = "SHB76REF";

        /// <summary>
        /// SHB76COD.
        /// </summary>
        public const string SHB76COD = "SHB76COD";

        /// <summary>
        /// SHB76DATE.
        /// </summary>
        public const string SHB76DATE = "SHB76DATE";

        /// <summary>
        /// SHUSER.
        /// </summary>
        public const string SHUSER = "SHUSER";

        /// <summary>
        /// SHPID.
        /// </summary>
        public const string SHPID = "SHPID";

        /// <summary>
        /// SHJOBN.
        /// </summary>
        public const string SHJOBN = "SHJOBN";

        /// <summary>
        /// SHUPMJ.
        /// </summary>
        public const string SHUPMJ = "SHUPMJ";

        /// <summary>
        /// SHUPMT.
        /// </summary>
        public const string SHUPMT = "SHUPMT";

        /// <summary>
        /// SHB76INTRM.
        /// </summary>
        public const string SHB76INTRM = "SHB76INTRM";

        /// <summary>
        /// SHB76CNPJ.
        /// </summary>
        public const string SHB76CNPJ = "SHB76CNPJ";

        /// <summary>
        /// SHB76INTDC.
        /// </summary>
        public const string SHB76INTDC = "SHB76INTDC";

        /// <summary>
        /// SHB76NUM1.
        /// </summary>
        public const string SHB76NUM1 = "SHB76NUM1";

        /// <summary>
        /// SHB76STR1.
        /// </summary>
        public const string SHB76STR1 = "SHB76STR1";

        /// <summary>
        /// SHB76DATE1.
        /// </summary>
        public const string SHB76DATE1 = "SHB76DATE1";
    }

    /// <inheritdoc />
    public override string TableName => "F76B4201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SHKCOO", "SHKCOO", JdeDataType.String, 10, true, true),
        new JdeField("SHDOCO", "SHDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("SHDCTO", "SHDCTO", JdeDataType.String, 4, true, true),
        new JdeField("SHSFXO", "SHSFXO", JdeDataType.String, 6),
        new JdeField("SHB76BICC", "SHB76BICC", JdeDataType.String, 2),
        new JdeField("SHB76PPI", "SHB76PPI", JdeDataType.String, 4),
        new JdeField("SHB76NUM", "SHB76NUM", JdeDataType.Numeric),
        new JdeField("SHB76AA", "SHB76AA", JdeDataType.Numeric),
        new JdeField("SHB76REF", "SHB76REF", JdeDataType.String, 30),
        new JdeField("SHB76COD", "SHB76COD", JdeDataType.String, 4),
        new JdeField("SHB76DATE", "SHB76DATE", JdeDataType.Numeric),
        new JdeField("SHUSER", "SHUSER", JdeDataType.String, 20),
        new JdeField("SHPID", "SHPID", JdeDataType.String, 20),
        new JdeField("SHJOBN", "SHJOBN", JdeDataType.String, 20),
        new JdeField("SHUPMJ", "SHUPMJ", JdeDataType.Numeric),
        new JdeField("SHUPMT", "SHUPMT", JdeDataType.Numeric),
        new JdeField("SHB76INTRM", "SHB76INTRM", JdeDataType.String, 2),
        new JdeField("SHB76CNPJ", "SHB76CNPJ", JdeDataType.Numeric),
        new JdeField("SHB76INTDC", "SHB76INTDC", JdeDataType.String, 120),
        new JdeField("SHB76NUM1", "SHB76NUM1", JdeDataType.Numeric),
        new JdeField("SHB76STR1", "SHB76STR1", JdeDataType.String, 30),
        new JdeField("SHB76DATE1", "SHB76DATE1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4201_0", "Primary Key on SHKCOO, SHDOCO, SHDCTO", new[] { "SHKCOO", "SHDOCO", "SHDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
