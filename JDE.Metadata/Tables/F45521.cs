using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F45521 - .
/// </summary>
public class F45521 : JdeTable
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
        /// PDLNID.
        /// </summary>
        public const string PDLNID = "PDLNID";

        /// <summary>
        /// PDEFTJ.
        /// </summary>
        public const string PDEFTJ = "PDEFTJ";

        /// <summary>
        /// PDMCU.
        /// </summary>
        public const string PDMCU = "PDMCU";

        /// <summary>
        /// PDUORG.
        /// </summary>
        public const string PDUORG = "PDUORG";

        /// <summary>
        /// PDITM.
        /// </summary>
        public const string PDITM = "PDITM";

        /// <summary>
        /// PDLITM.
        /// </summary>
        public const string PDLITM = "PDLITM";

        /// <summary>
        /// PDAITM.
        /// </summary>
        public const string PDAITM = "PDAITM";

        /// <summary>
        /// PDCITM.
        /// </summary>
        public const string PDCITM = "PDCITM";

        /// <summary>
        /// PDUOM.
        /// </summary>
        public const string PDUOM = "PDUOM";

        /// <summary>
        /// PDLPRC.
        /// </summary>
        public const string PDLPRC = "PDLPRC";

        /// <summary>
        /// PDPLCAMT1.
        /// </summary>
        public const string PDPLCAMT1 = "PDPLCAMT1";

        /// <summary>
        /// PDPLCAMT2.
        /// </summary>
        public const string PDPLCAMT2 = "PDPLCAMT2";

        /// <summary>
        /// PDPLCAMT3.
        /// </summary>
        public const string PDPLCAMT3 = "PDPLCAMT3";

        /// <summary>
        /// PDPLCAMT4.
        /// </summary>
        public const string PDPLCAMT4 = "PDPLCAMT4";

        /// <summary>
        /// PDPLCAMT5.
        /// </summary>
        public const string PDPLCAMT5 = "PDPLCAMT5";

        /// <summary>
        /// PDUPRC.
        /// </summary>
        public const string PDUPRC = "PDUPRC";

        /// <summary>
        /// PDAN8.
        /// </summary>
        public const string PDAN8 = "PDAN8";

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
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDUPMT.
        /// </summary>
        public const string PDUPMT = "PDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F45521";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDDOCO", "PDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("PDDCTO", "PDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("PDLNID", "PDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDEFTJ", "PDEFTJ", JdeDataType.Numeric),
        new JdeField("PDMCU", "PDMCU", JdeDataType.String, 24),
        new JdeField("PDUORG", "PDUORG", JdeDataType.Numeric),
        new JdeField("PDITM", "PDITM", JdeDataType.Numeric),
        new JdeField("PDLITM", "PDLITM", JdeDataType.String, 50),
        new JdeField("PDAITM", "PDAITM", JdeDataType.String, 50),
        new JdeField("PDCITM", "PDCITM", JdeDataType.String, 50),
        new JdeField("PDUOM", "PDUOM", JdeDataType.String, 4),
        new JdeField("PDLPRC", "PDLPRC", JdeDataType.Numeric),
        new JdeField("PDPLCAMT1", "PDPLCAMT1", JdeDataType.Numeric),
        new JdeField("PDPLCAMT2", "PDPLCAMT2", JdeDataType.Numeric),
        new JdeField("PDPLCAMT3", "PDPLCAMT3", JdeDataType.Numeric),
        new JdeField("PDPLCAMT4", "PDPLCAMT4", JdeDataType.Numeric),
        new JdeField("PDPLCAMT5", "PDPLCAMT5", JdeDataType.Numeric),
        new JdeField("PDUPRC", "PDUPRC", JdeDataType.Numeric),
        new JdeField("PDAN8", "PDAN8", JdeDataType.Numeric),
        new JdeField("PDURCD", "PDURCD", JdeDataType.String, 4),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDURAT", "PDURAT", JdeDataType.Numeric),
        new JdeField("PDURAB", "PDURAB", JdeDataType.Numeric),
        new JdeField("PDURRF", "PDURRF", JdeDataType.String, 30),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F45521_0", "Primary Key on PDDOCO, PDDCTO, PDLNID", new[] { "PDDOCO", "PDDCTO", "PDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F45521_2", "Index on PDDOCO, PDDCTO", new[] { "PDDOCO", "PDDCTO" })
    };
}
