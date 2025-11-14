using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0018T - .
/// </summary>
public class F0018T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDKCOO.
        /// </summary>
        public const string TDKCOO = "TDKCOO";

        /// <summary>
        /// TDDOCO.
        /// </summary>
        public const string TDDOCO = "TDDOCO";

        /// <summary>
        /// TDDCTO.
        /// </summary>
        public const string TDDCTO = "TDDCTO";

        /// <summary>
        /// TDSFXO.
        /// </summary>
        public const string TDSFXO = "TDSFXO";

        /// <summary>
        /// TDLNID.
        /// </summary>
        public const string TDLNID = "TDLNID";

        /// <summary>
        /// TDNLIN.
        /// </summary>
        public const string TDNLIN = "TDNLIN";

        /// <summary>
        /// TDMCU.
        /// </summary>
        public const string TDMCU = "TDMCU";

        /// <summary>
        /// TDCO.
        /// </summary>
        public const string TDCO = "TDCO";

        /// <summary>
        /// TDAN8.
        /// </summary>
        public const string TDAN8 = "TDAN8";

        /// <summary>
        /// TDKCO.
        /// </summary>
        public const string TDKCO = "TDKCO";

        /// <summary>
        /// TDDOC.
        /// </summary>
        public const string TDDOC = "TDDOC";

        /// <summary>
        /// TDDCT.
        /// </summary>
        public const string TDDCT = "TDDCT";

        /// <summary>
        /// TDIVD.
        /// </summary>
        public const string TDIVD = "TDIVD";

        /// <summary>
        /// TDDGL.
        /// </summary>
        public const string TDDGL = "TDDGL";

        /// <summary>
        /// TDLNTY.
        /// </summary>
        public const string TDLNTY = "TDLNTY";

        /// <summary>
        /// TDORIG.
        /// </summary>
        public const string TDORIG = "TDORIG";

        /// <summary>
        /// TDORGO.
        /// </summary>
        public const string TDORGO = "TDORGO";

        /// <summary>
        /// TDROO.
        /// </summary>
        public const string TDROO = "TDROO";

        /// <summary>
        /// TDPOE.
        /// </summary>
        public const string TDPOE = "TDPOE";

        /// <summary>
        /// TDCDCD.
        /// </summary>
        public const string TDCDCD = "TDCDCD";

        /// <summary>
        /// TDMOT.
        /// </summary>
        public const string TDMOT = "TDMOT";

        /// <summary>
        /// TDCOT.
        /// </summary>
        public const string TDCOT = "TDCOT";

        /// <summary>
        /// TDCOTX.
        /// </summary>
        public const string TDCOTX = "TDCOTX";

        /// <summary>
        /// TDNTR.
        /// </summary>
        public const string TDNTR = "TDNTR";

        /// <summary>
        /// TDNVAT.
        /// </summary>
        public const string TDNVAT = "TDNVAT";

        /// <summary>
        /// TDNCD.
        /// </summary>
        public const string TDNCD = "TDNCD";

        /// <summary>
        /// TDPIND.
        /// </summary>
        public const string TDPIND = "TDPIND";

        /// <summary>
        /// TDMSAM.
        /// </summary>
        public const string TDMSAM = "TDMSAM";

        /// <summary>
        /// TDSUAM.
        /// </summary>
        public const string TDSUAM = "TDSUAM";

        /// <summary>
        /// TDATXA.
        /// </summary>
        public const string TDATXA = "TDATXA";

        /// <summary>
        /// TDSAM.
        /// </summary>
        public const string TDSAM = "TDSAM";

        /// <summary>
        /// TDURCD.
        /// </summary>
        public const string TDURCD = "TDURCD";

        /// <summary>
        /// TDURDT.
        /// </summary>
        public const string TDURDT = "TDURDT";

        /// <summary>
        /// TDURAT.
        /// </summary>
        public const string TDURAT = "TDURAT";

        /// <summary>
        /// TDURAB.
        /// </summary>
        public const string TDURAB = "TDURAB";

        /// <summary>
        /// TDURRF.
        /// </summary>
        public const string TDURRF = "TDURRF";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDADDJ.
        /// </summary>
        public const string TDADDJ = "TDADDJ";

        /// <summary>
        /// TDRCDJ.
        /// </summary>
        public const string TDRCDJ = "TDRCDJ";

        /// <summary>
        /// TDCRCD.
        /// </summary>
        public const string TDCRCD = "TDCRCD";

        /// <summary>
        /// TDCRDC.
        /// </summary>
        public const string TDCRDC = "TDCRDC";

        /// <summary>
        /// TDFSAM.
        /// </summary>
        public const string TDFSAM = "TDFSAM";

        /// <summary>
        /// TDCTXA.
        /// </summary>
        public const string TDCTXA = "TDCTXA";

        /// <summary>
        /// TDFFU1.
        /// </summary>
        public const string TDFFU1 = "TDFFU1";

        /// <summary>
        /// TDSHAN.
        /// </summary>
        public const string TDSHAN = "TDSHAN";
    }

    /// <inheritdoc />
    public override string TableName => "F0018T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDKCOO", "TDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TDDOCO", "TDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TDDCTO", "TDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TDSFXO", "TDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("TDLNID", "TDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TDNLIN", "TDNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("TDMCU", "TDMCU", JdeDataType.String, 24),
        new JdeField("TDCO", "TDCO", JdeDataType.String, 10),
        new JdeField("TDAN8", "TDAN8", JdeDataType.Numeric),
        new JdeField("TDKCO", "TDKCO", JdeDataType.String, 10),
        new JdeField("TDDOC", "TDDOC", JdeDataType.Numeric),
        new JdeField("TDDCT", "TDDCT", JdeDataType.String, 4),
        new JdeField("TDIVD", "TDIVD", JdeDataType.Numeric),
        new JdeField("TDDGL", "TDDGL", JdeDataType.Numeric),
        new JdeField("TDLNTY", "TDLNTY", JdeDataType.String, 4),
        new JdeField("TDORIG", "TDORIG", JdeDataType.String, 6),
        new JdeField("TDORGO", "TDORGO", JdeDataType.String, 6),
        new JdeField("TDROO", "TDROO", JdeDataType.String, 6),
        new JdeField("TDPOE", "TDPOE", JdeDataType.String, 12),
        new JdeField("TDCDCD", "TDCDCD", JdeDataType.String, 30),
        new JdeField("TDMOT", "TDMOT", JdeDataType.String, 6),
        new JdeField("TDCOT", "TDCOT", JdeDataType.String, 6),
        new JdeField("TDCOTX", "TDCOTX", JdeDataType.String, 2),
        new JdeField("TDNTR", "TDNTR", JdeDataType.String, 4),
        new JdeField("TDNVAT", "TDNVAT", JdeDataType.String, 10),
        new JdeField("TDNCD", "TDNCD", JdeDataType.String, 2),
        new JdeField("TDPIND", "TDPIND", JdeDataType.String, 2),
        new JdeField("TDMSAM", "TDMSAM", JdeDataType.Numeric),
        new JdeField("TDSUAM", "TDSUAM", JdeDataType.Numeric),
        new JdeField("TDATXA", "TDATXA", JdeDataType.Numeric),
        new JdeField("TDSAM", "TDSAM", JdeDataType.Numeric),
        new JdeField("TDURCD", "TDURCD", JdeDataType.String, 4),
        new JdeField("TDURDT", "TDURDT", JdeDataType.Numeric),
        new JdeField("TDURAT", "TDURAT", JdeDataType.Numeric),
        new JdeField("TDURAB", "TDURAB", JdeDataType.Numeric),
        new JdeField("TDURRF", "TDURRF", JdeDataType.String, 30),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDADDJ", "TDADDJ", JdeDataType.Numeric),
        new JdeField("TDRCDJ", "TDRCDJ", JdeDataType.Numeric),
        new JdeField("TDCRCD", "TDCRCD", JdeDataType.String, 6),
        new JdeField("TDCRDC", "TDCRDC", JdeDataType.String, 6),
        new JdeField("TDFSAM", "TDFSAM", JdeDataType.Numeric),
        new JdeField("TDCTXA", "TDCTXA", JdeDataType.Numeric),
        new JdeField("TDFFU1", "TDFFU1", JdeDataType.String, 2),
        new JdeField("TDSHAN", "TDSHAN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0018T_0", "Primary Key on TDDOCO, TDDCTO, TDKCOO, TDSFXO, TDLNID, TDNLIN", new[] { "TDDOCO", "TDDCTO", "TDKCOO", "TDSFXO", "TDLNID", "TDNLIN" }, isUnique: true, isPrimaryKey: true)
    };
}
