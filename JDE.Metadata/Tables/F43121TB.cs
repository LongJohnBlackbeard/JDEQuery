using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43121TB - .
/// </summary>
public class F43121TB : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PRMATC.
        /// </summary>
        public const string PRMATC = "PRMATC";

        /// <summary>
        /// PRKCOO.
        /// </summary>
        public const string PRKCOO = "PRKCOO";

        /// <summary>
        /// PRDOCO.
        /// </summary>
        public const string PRDOCO = "PRDOCO";

        /// <summary>
        /// PRDCTO.
        /// </summary>
        public const string PRDCTO = "PRDCTO";

        /// <summary>
        /// PRSFXO.
        /// </summary>
        public const string PRSFXO = "PRSFXO";

        /// <summary>
        /// PRLNID.
        /// </summary>
        public const string PRLNID = "PRLNID";

        /// <summary>
        /// PRNLIN.
        /// </summary>
        public const string PRNLIN = "PRNLIN";

        /// <summary>
        /// PRDOC.
        /// </summary>
        public const string PRDOC = "PRDOC";

        /// <summary>
        /// PRSRRC.
        /// </summary>
        public const string PRSRRC = "PRSRRC";

        /// <summary>
        /// PRFSRRC.
        /// </summary>
        public const string PRFSRRC = "PRFSRRC";
    }

    /// <inheritdoc />
    public override string TableName => "F43121TB";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRMATC", "PRMATC", JdeDataType.String, 2, true, true),
        new JdeField("PRKCOO", "PRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PRDOCO", "PRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDCTO", "PRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PRSFXO", "PRSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PRLNID", "PRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PRNLIN", "PRNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDOC", "PRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PRSRRC", "PRSRRC", JdeDataType.Numeric),
        new JdeField("PRFSRRC", "PRFSRRC", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43121TB_0", "Primary Key on PRMATC, PRKCOO, PRDOCO, PRDCTO, PRSFXO, PRLNID, PRNLIN, PRDOC", new[] { "PRMATC", "PRKCOO", "PRDOCO", "PRDCTO", "PRSFXO", "PRLNID", "PRNLIN", "PRDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43121TB_2", "Index on PRDOCO, PRKCOO, PRDCTO, PRSFXO, PRLNID, PRNLIN, PRDOC", new[] { "PRDOCO", "PRKCOO", "PRDCTO", "PRSFXO", "PRLNID", "PRNLIN", "PRDOC" })
    };
}
