using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43121T - .
/// </summary>
public class F43121T : JdeTable
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
        /// PRDCT.
        /// </summary>
        public const string PRDCT = "PRDCT";

        /// <summary>
        /// PRKCO.
        /// </summary>
        public const string PRKCO = "PRKCO";

        /// <summary>
        /// PRSFX.
        /// </summary>
        public const string PRSFX = "PRSFX";

        /// <summary>
        /// PRSFXE.
        /// </summary>
        public const string PRSFXE = "PRSFXE";

        /// <summary>
        /// PRSFXO.
        /// </summary>
        public const string PRSFXO = "PRSFXO";

        /// <summary>
        /// PRRETA.
        /// </summary>
        public const string PRRETA = "PRRETA";

        /// <summary>
        /// PRRETT.
        /// </summary>
        public const string PRRETT = "PRRETT";

        /// <summary>
        /// PRREFA.
        /// </summary>
        public const string PRREFA = "PRREFA";

        /// <summary>
        /// PRREFT.
        /// </summary>
        public const string PRREFT = "PRREFT";

        /// <summary>
        /// PRCRCD.
        /// </summary>
        public const string PRCRCD = "PRCRCD";

        /// <summary>
        /// PRCRDC.
        /// </summary>
        public const string PRCRDC = "PRCRDC";

        /// <summary>
        /// PRABT1.
        /// </summary>
        public const string PRABT1 = "PRABT1";

        /// <summary>
        /// PRABR1.
        /// </summary>
        public const string PRABR1 = "PRABR1";

        /// <summary>
        /// PRABT2.
        /// </summary>
        public const string PRABT2 = "PRABT2";

        /// <summary>
        /// PRABR2.
        /// </summary>
        public const string PRABR2 = "PRABR2";

        /// <summary>
        /// PRABT3.
        /// </summary>
        public const string PRABT3 = "PRABT3";

        /// <summary>
        /// PRABR3.
        /// </summary>
        public const string PRABR3 = "PRABR3";

        /// <summary>
        /// PRABT4.
        /// </summary>
        public const string PRABT4 = "PRABT4";

        /// <summary>
        /// PRABR4.
        /// </summary>
        public const string PRABR4 = "PRABR4";
    }

    /// <inheritdoc />
    public override string TableName => "F43121T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PRMATC", "PRMATC", JdeDataType.String, 2, true, true),
        new JdeField("PRKCOO", "PRKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PRDOCO", "PRDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDCTO", "PRDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PRLNID", "PRLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PRNLIN", "PRNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDOC", "PRDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PRDCT", "PRDCT", JdeDataType.String, 4),
        new JdeField("PRKCO", "PRKCO", JdeDataType.String, 10),
        new JdeField("PRSFX", "PRSFX", JdeDataType.String, 6),
        new JdeField("PRSFXE", "PRSFXE", JdeDataType.Numeric),
        new JdeField("PRSFXO", "PRSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PRRETA", "PRRETA", JdeDataType.Numeric),
        new JdeField("PRRETT", "PRRETT", JdeDataType.Numeric),
        new JdeField("PRREFA", "PRREFA", JdeDataType.Numeric),
        new JdeField("PRREFT", "PRREFT", JdeDataType.Numeric),
        new JdeField("PRCRCD", "PRCRCD", JdeDataType.String, 6),
        new JdeField("PRCRDC", "PRCRDC", JdeDataType.String, 6),
        new JdeField("PRABT1", "PRABT1", JdeDataType.String, 2),
        new JdeField("PRABR1", "PRABR1", JdeDataType.String, 24),
        new JdeField("PRABT2", "PRABT2", JdeDataType.String, 2),
        new JdeField("PRABR2", "PRABR2", JdeDataType.String, 24),
        new JdeField("PRABT3", "PRABT3", JdeDataType.String, 2),
        new JdeField("PRABR3", "PRABR3", JdeDataType.String, 24),
        new JdeField("PRABT4", "PRABT4", JdeDataType.String, 2),
        new JdeField("PRABR4", "PRABR4", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43121T_0", "Primary Key on PRMATC, PRDOCO, PRDCTO, PRKCOO, PRSFXO, PRLNID, PRNLIN, PRDOC", new[] { "PRMATC", "PRDOCO", "PRDCTO", "PRKCOO", "PRSFXO", "PRLNID", "PRNLIN", "PRDOC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F43121T_2", "Index on PRDOC, PRDCT, PRKCO, PRSFX, PRSFXE", new[] { "PRDOC", "PRDCT", "PRKCO", "PRSFX", "PRSFXE" })
    };
}
