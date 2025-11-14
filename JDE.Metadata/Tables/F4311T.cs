using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4311T - .
/// </summary>
public class F4311T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDKCOO.
        /// </summary>
        public const string PDKCOO = "PDKCOO";

        /// <summary>
        /// PDDOCO.
        /// </summary>
        public const string PDDOCO = "PDDOCO";

        /// <summary>
        /// PDDCTO.
        /// </summary>
        public const string PDDCTO = "PDDCTO";

        /// <summary>
        /// PDSFXO.
        /// </summary>
        public const string PDSFXO = "PDSFXO";

        /// <summary>
        /// PDLNID.
        /// </summary>
        public const string PDLNID = "PDLNID";

        /// <summary>
        /// PDRETA.
        /// </summary>
        public const string PDRETA = "PDRETA";

        /// <summary>
        /// PDRETT.
        /// </summary>
        public const string PDRETT = "PDRETT";

        /// <summary>
        /// PDREFA.
        /// </summary>
        public const string PDREFA = "PDREFA";

        /// <summary>
        /// PDREFT.
        /// </summary>
        public const string PDREFT = "PDREFT";

        /// <summary>
        /// PDCRCD.
        /// </summary>
        public const string PDCRCD = "PDCRCD";

        /// <summary>
        /// PDCRDC.
        /// </summary>
        public const string PDCRDC = "PDCRDC";

        /// <summary>
        /// PDABT1.
        /// </summary>
        public const string PDABT1 = "PDABT1";

        /// <summary>
        /// PDABR1.
        /// </summary>
        public const string PDABR1 = "PDABR1";

        /// <summary>
        /// PDABT2.
        /// </summary>
        public const string PDABT2 = "PDABT2";

        /// <summary>
        /// PDABR2.
        /// </summary>
        public const string PDABR2 = "PDABR2";

        /// <summary>
        /// PDABT3.
        /// </summary>
        public const string PDABT3 = "PDABT3";

        /// <summary>
        /// PDABR3.
        /// </summary>
        public const string PDABR3 = "PDABR3";

        /// <summary>
        /// PDABT4.
        /// </summary>
        public const string PDABT4 = "PDABT4";

        /// <summary>
        /// PDABR4.
        /// </summary>
        public const string PDABR4 = "PDABR4";
    }

    /// <inheritdoc />
    public override string TableName => "F4311T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDKCOO", "PDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PDDOCO", "PDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PDDCTO", "PDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PDSFXO", "PDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PDLNID", "PDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDRETA", "PDRETA", JdeDataType.Numeric),
        new JdeField("PDRETT", "PDRETT", JdeDataType.Numeric),
        new JdeField("PDREFA", "PDREFA", JdeDataType.Numeric),
        new JdeField("PDREFT", "PDREFT", JdeDataType.Numeric),
        new JdeField("PDCRCD", "PDCRCD", JdeDataType.String, 6),
        new JdeField("PDCRDC", "PDCRDC", JdeDataType.String, 6),
        new JdeField("PDABT1", "PDABT1", JdeDataType.String, 2),
        new JdeField("PDABR1", "PDABR1", JdeDataType.String, 24),
        new JdeField("PDABT2", "PDABT2", JdeDataType.String, 2),
        new JdeField("PDABR2", "PDABR2", JdeDataType.String, 24),
        new JdeField("PDABT3", "PDABT3", JdeDataType.String, 2),
        new JdeField("PDABR3", "PDABR3", JdeDataType.String, 24),
        new JdeField("PDABT4", "PDABT4", JdeDataType.String, 2),
        new JdeField("PDABR4", "PDABR4", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4311T_0", "Primary Key on PDKCOO, PDDOCO, PDDCTO, PDSFXO, PDLNID", new[] { "PDKCOO", "PDDOCO", "PDDCTO", "PDSFXO", "PDLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
