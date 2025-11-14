using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4701260 - .
/// </summary>
public class F4701260 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDDOCO.
        /// </summary>
        public const string PDDOCO = "PDDOCO";

        /// <summary>
        /// PDDCTO.
        /// </summary>
        public const string PDDCTO = "PDDCTO";

        /// <summary>
        /// PDKCOO.
        /// </summary>
        public const string PDKCOO = "PDKCOO";

        /// <summary>
        /// PDSFXO.
        /// </summary>
        public const string PDSFXO = "PDSFXO";

        /// <summary>
        /// PDLNID.
        /// </summary>
        public const string PDLNID = "PDLNID";

        /// <summary>
        /// PDCMLN.
        /// </summary>
        public const string PDCMLN = "PDCMLN";

        /// <summary>
        /// PDSLSM.
        /// </summary>
        public const string PDSLSM = "PDSLSM";

        /// <summary>
        /// PDSLCM.
        /// </summary>
        public const string PDSLCM = "PDSLCM";

        /// <summary>
        /// PDFCA.
        /// </summary>
        public const string PDFCA = "PDFCA";

        /// <summary>
        /// PDAPUN.
        /// </summary>
        public const string PDAPUN = "PDAPUN";

        /// <summary>
        /// PDCCTY.
        /// </summary>
        public const string PDCCTY = "PDCCTY";
    }

    /// <inheritdoc />
    public override string TableName => "F4701260";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDDOCO", "PDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PDDCTO", "PDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PDKCOO", "PDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("PDSFXO", "PDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("PDLNID", "PDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDCMLN", "PDCMLN", JdeDataType.Numeric, null, true, true),
        new JdeField("PDSLSM", "PDSLSM", JdeDataType.Numeric, null, true, true),
        new JdeField("PDSLCM", "PDSLCM", JdeDataType.Numeric),
        new JdeField("PDFCA", "PDFCA", JdeDataType.Numeric),
        new JdeField("PDAPUN", "PDAPUN", JdeDataType.Numeric),
        new JdeField("PDCCTY", "PDCCTY", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4701260_0", "Primary Key on PDDOCO, PDDCTO, PDKCOO, PDSFXO, PDLNID, PDCMLN, PDSLSM", new[] { "PDDOCO", "PDDCTO", "PDKCOO", "PDSFXO", "PDLNID", "PDCMLN", "PDSLSM" }, isUnique: true, isPrimaryKey: true)
    };
}
