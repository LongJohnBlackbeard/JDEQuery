using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4317 - .
/// </summary>
public class F4317 : JdeTable
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
        /// PDDLNID.
        /// </summary>
        public const string PDDLNID = "PDDLNID";

        /// <summary>
        /// PDNBACTY.
        /// </summary>
        public const string PDNBACTY = "PDNBACTY";

        /// <summary>
        /// PDAID.
        /// </summary>
        public const string PDAID = "PDAID";

        /// <summary>
        /// PDANI.
        /// </summary>
        public const string PDANI = "PDANI";

        /// <summary>
        /// PDDL01.
        /// </summary>
        public const string PDDL01 = "PDDL01";

        /// <summary>
        /// PDCO.
        /// </summary>
        public const string PDCO = "PDCO";

        /// <summary>
        /// PDCRCD.
        /// </summary>
        public const string PDCRCD = "PDCRCD";

        /// <summary>
        /// PDNBRETA.
        /// </summary>
        public const string PDNBRETA = "PDNBRETA";

        /// <summary>
        /// PDNBREFA.
        /// </summary>
        public const string PDNBREFA = "PDNBREFA";

        /// <summary>
        /// PDURCD.
        /// </summary>
        public const string PDURCD = "PDURCD";

        /// <summary>
        /// PDURDT.
        /// </summary>
        public const string PDURDT = "PDURDT";

        /// <summary>
        /// PDURAT.
        /// </summary>
        public const string PDURAT = "PDURAT";

        /// <summary>
        /// PDURAB.
        /// </summary>
        public const string PDURAB = "PDURAB";

        /// <summary>
        /// PDURRF.
        /// </summary>
        public const string PDURRF = "PDURRF";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDTORG.
        /// </summary>
        public const string PDTORG = "PDTORG";

        /// <summary>
        /// PDUUPMJ.
        /// </summary>
        public const string PDUUPMJ = "PDUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4317";

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
        new JdeField("PDDLNID", "PDDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDNBACTY", "PDNBACTY", JdeDataType.String, 4, true, true),
        new JdeField("PDAID", "PDAID", JdeDataType.String, 16, true, true),
        new JdeField("PDANI", "PDANI", JdeDataType.String, 58),
        new JdeField("PDDL01", "PDDL01", JdeDataType.String, 60),
        new JdeField("PDCO", "PDCO", JdeDataType.String, 10),
        new JdeField("PDCRCD", "PDCRCD", JdeDataType.String, 6),
        new JdeField("PDNBRETA", "PDNBRETA", JdeDataType.Numeric),
        new JdeField("PDNBREFA", "PDNBREFA", JdeDataType.Numeric),
        new JdeField("PDURCD", "PDURCD", JdeDataType.String, 4),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDURAT", "PDURAT", JdeDataType.Numeric),
        new JdeField("PDURAB", "PDURAB", JdeDataType.Numeric),
        new JdeField("PDURRF", "PDURRF", JdeDataType.String, 30),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDTORG", "PDTORG", JdeDataType.String, 20),
        new JdeField("PDUUPMJ", "PDUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4317_0", "Primary Key on PDDOCO, PDDCTO, PDKCOO, PDSFXO, PDLNID, PDNBACTY, PDDLNID, PDAID", new[] { "PDDOCO", "PDDCTO", "PDKCOO", "PDSFXO", "PDLNID", "PDNBACTY", "PDDLNID", "PDAID" }, isUnique: true, isPrimaryKey: true)
    };
}
