using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76CUI04 - .
/// </summary>
public class F76CUI04 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// TDKCOO.
        /// </summary>
        public const string TDKCOO = "TDKCOO";

        /// <summary>
        /// TDDCTO.
        /// </summary>
        public const string TDDCTO = "TDDCTO";

        /// <summary>
        /// TDDOCO.
        /// </summary>
        public const string TDDOCO = "TDDOCO";

        /// <summary>
        /// TDLNID.
        /// </summary>
        public const string TDLNID = "TDLNID";

        /// <summary>
        /// TDSFXO.
        /// </summary>
        public const string TDSFXO = "TDSFXO";

        /// <summary>
        /// TDAN8.
        /// </summary>
        public const string TDAN8 = "TDAN8";

        /// <summary>
        /// TDTXA1.
        /// </summary>
        public const string TDTXA1 = "TDTXA1";

        /// <summary>
        /// TDEXR1.
        /// </summary>
        public const string TDEXR1 = "TDEXR1";

        /// <summary>
        /// TDTAXA.
        /// </summary>
        public const string TDTAXA = "TDTAXA";

        /// <summary>
        /// TDTRAT.
        /// </summary>
        public const string TDTRAT = "TDTRAT";

        /// <summary>
        /// TDSTAM.
        /// </summary>
        public const string TDSTAM = "TDSTAM";

        /// <summary>
        /// TDAEXP.
        /// </summary>
        public const string TDAEXP = "TDAEXP";

        /// <summary>
        /// TDTA1.
        /// </summary>
        public const string TDTA1 = "TDTA1";

        /// <summary>
        /// TDTA2.
        /// </summary>
        public const string TDTA2 = "TDTA2";

        /// <summary>
        /// TDTA3.
        /// </summary>
        public const string TDTA3 = "TDTA3";

        /// <summary>
        /// TDTA4.
        /// </summary>
        public const string TDTA4 = "TDTA4";

        /// <summary>
        /// TDTA5.
        /// </summary>
        public const string TDTA5 = "TDTA5";

        /// <summary>
        /// TDSTA1.
        /// </summary>
        public const string TDSTA1 = "TDSTA1";

        /// <summary>
        /// TDSTA2.
        /// </summary>
        public const string TDSTA2 = "TDSTA2";

        /// <summary>
        /// TDSTA3.
        /// </summary>
        public const string TDSTA3 = "TDSTA3";

        /// <summary>
        /// TDSTA4.
        /// </summary>
        public const string TDSTA4 = "TDSTA4";

        /// <summary>
        /// TDSTA5.
        /// </summary>
        public const string TDSTA5 = "TDSTA5";

        /// <summary>
        /// TDGL01.
        /// </summary>
        public const string TDGL01 = "TDGL01";

        /// <summary>
        /// TDGL02.
        /// </summary>
        public const string TDGL02 = "TDGL02";

        /// <summary>
        /// TDGL03.
        /// </summary>
        public const string TDGL03 = "TDGL03";

        /// <summary>
        /// TDGL04.
        /// </summary>
        public const string TDGL04 = "TDGL04";

        /// <summary>
        /// TDGL05.
        /// </summary>
        public const string TDGL05 = "TDGL05";

        /// <summary>
        /// TDTXR1.
        /// </summary>
        public const string TDTXR1 = "TDTXR1";

        /// <summary>
        /// TDTXR2.
        /// </summary>
        public const string TDTXR2 = "TDTXR2";

        /// <summary>
        /// TDTXR3.
        /// </summary>
        public const string TDTXR3 = "TDTXR3";

        /// <summary>
        /// TDTXR4.
        /// </summary>
        public const string TDTXR4 = "TDTXR4";

        /// <summary>
        /// TDTXR5.
        /// </summary>
        public const string TDTXR5 = "TDTXR5";

        /// <summary>
        /// TDCTA1.
        /// </summary>
        public const string TDCTA1 = "TDCTA1";

        /// <summary>
        /// TDCTA2.
        /// </summary>
        public const string TDCTA2 = "TDCTA2";

        /// <summary>
        /// TDCTA3.
        /// </summary>
        public const string TDCTA3 = "TDCTA3";

        /// <summary>
        /// TDCTA4.
        /// </summary>
        public const string TDCTA4 = "TDCTA4";

        /// <summary>
        /// TDCTA5.
        /// </summary>
        public const string TDCTA5 = "TDCTA5";

        /// <summary>
        /// TDCMA1.
        /// </summary>
        public const string TDCMA1 = "TDCMA1";

        /// <summary>
        /// TDCMA2.
        /// </summary>
        public const string TDCMA2 = "TDCMA2";

        /// <summary>
        /// TDCMA3.
        /// </summary>
        public const string TDCMA3 = "TDCMA3";

        /// <summary>
        /// TDCMA4.
        /// </summary>
        public const string TDCMA4 = "TDCMA4";

        /// <summary>
        /// TDCMA5.
        /// </summary>
        public const string TDCMA5 = "TDCMA5";

        /// <summary>
        /// TDFVTY.
        /// </summary>
        public const string TDFVTY = "TDFVTY";

        /// <summary>
        /// TDITM.
        /// </summary>
        public const string TDITM = "TDITM";

        /// <summary>
        /// TDTC2.
        /// </summary>
        public const string TDTC2 = "TDTC2";

        /// <summary>
        /// TDHBUS.
        /// </summary>
        public const string TDHBUS = "TDHBUS";

        /// <summary>
        /// TDTT3.
        /// </summary>
        public const string TDTT3 = "TDTT3";

        /// <summary>
        /// TDTT4.
        /// </summary>
        public const string TDTT4 = "TDTT4";

        /// <summary>
        /// TDTT5.
        /// </summary>
        public const string TDTT5 = "TDTT5";

        /// <summary>
        /// TDCRRM.
        /// </summary>
        public const string TDCRRM = "TDCRRM";

        /// <summary>
        /// TDPOST.
        /// </summary>
        public const string TDPOST = "TDPOST";

        /// <summary>
        /// TDCO.
        /// </summary>
        public const string TDCO = "TDCO";

        /// <summary>
        /// TDSTOL.
        /// </summary>
        public const string TDSTOL = "TDSTOL";

        /// <summary>
        /// TDICU.
        /// </summary>
        public const string TDICU = "TDICU";

        /// <summary>
        /// TDICUT.
        /// </summary>
        public const string TDICUT = "TDICUT";

        /// <summary>
        /// TDCRCD.
        /// </summary>
        public const string TDCRCD = "TDCRCD";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";

        /// <summary>
        /// TDCTID.
        /// </summary>
        public const string TDCTID = "TDCTID";

        /// <summary>
        /// TDJOBS.
        /// </summary>
        public const string TDJOBS = "TDJOBS";
    }

    /// <inheritdoc />
    public override string TableName => "F76CUI04";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDKCO", "TDKCO", JdeDataType.String, 10, true, true),
        new JdeField("TDDOC", "TDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("TDDCT", "TDDCT", JdeDataType.String, 4, true, true),
        new JdeField("TDKCOO", "TDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TDDCTO", "TDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TDDOCO", "TDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TDLNID", "TDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TDSFXO", "TDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("TDAN8", "TDAN8", JdeDataType.Numeric),
        new JdeField("TDTXA1", "TDTXA1", JdeDataType.String, 20),
        new JdeField("TDEXR1", "TDEXR1", JdeDataType.String, 4),
        new JdeField("TDTAXA", "TDTAXA", JdeDataType.String, 60),
        new JdeField("TDTRAT", "TDTRAT", JdeDataType.Numeric),
        new JdeField("TDSTAM", "TDSTAM", JdeDataType.Numeric),
        new JdeField("TDAEXP", "TDAEXP", JdeDataType.Numeric),
        new JdeField("TDTA1", "TDTA1", JdeDataType.Numeric),
        new JdeField("TDTA2", "TDTA2", JdeDataType.Numeric),
        new JdeField("TDTA3", "TDTA3", JdeDataType.Numeric),
        new JdeField("TDTA4", "TDTA4", JdeDataType.Numeric),
        new JdeField("TDTA5", "TDTA5", JdeDataType.Numeric),
        new JdeField("TDSTA1", "TDSTA1", JdeDataType.Numeric),
        new JdeField("TDSTA2", "TDSTA2", JdeDataType.Numeric),
        new JdeField("TDSTA3", "TDSTA3", JdeDataType.Numeric),
        new JdeField("TDSTA4", "TDSTA4", JdeDataType.Numeric),
        new JdeField("TDSTA5", "TDSTA5", JdeDataType.Numeric),
        new JdeField("TDGL01", "TDGL01", JdeDataType.String, 8),
        new JdeField("TDGL02", "TDGL02", JdeDataType.String, 8),
        new JdeField("TDGL03", "TDGL03", JdeDataType.String, 8),
        new JdeField("TDGL04", "TDGL04", JdeDataType.String, 8),
        new JdeField("TDGL05", "TDGL05", JdeDataType.String, 8),
        new JdeField("TDTXR1", "TDTXR1", JdeDataType.Numeric),
        new JdeField("TDTXR2", "TDTXR2", JdeDataType.Numeric),
        new JdeField("TDTXR3", "TDTXR3", JdeDataType.Numeric),
        new JdeField("TDTXR4", "TDTXR4", JdeDataType.Numeric),
        new JdeField("TDTXR5", "TDTXR5", JdeDataType.Numeric),
        new JdeField("TDCTA1", "TDCTA1", JdeDataType.String, 2),
        new JdeField("TDCTA2", "TDCTA2", JdeDataType.String, 2),
        new JdeField("TDCTA3", "TDCTA3", JdeDataType.String, 2),
        new JdeField("TDCTA4", "TDCTA4", JdeDataType.String, 2),
        new JdeField("TDCTA5", "TDCTA5", JdeDataType.String, 2),
        new JdeField("TDCMA1", "TDCMA1", JdeDataType.Numeric),
        new JdeField("TDCMA2", "TDCMA2", JdeDataType.Numeric),
        new JdeField("TDCMA3", "TDCMA3", JdeDataType.Numeric),
        new JdeField("TDCMA4", "TDCMA4", JdeDataType.Numeric),
        new JdeField("TDCMA5", "TDCMA5", JdeDataType.Numeric),
        new JdeField("TDFVTY", "TDFVTY", JdeDataType.String, 2),
        new JdeField("TDITM", "TDITM", JdeDataType.Numeric),
        new JdeField("TDTC2", "TDTC2", JdeDataType.String, 2),
        new JdeField("TDHBUS", "TDHBUS", JdeDataType.String, 2),
        new JdeField("TDTT3", "TDTT3", JdeDataType.String, 2),
        new JdeField("TDTT4", "TDTT4", JdeDataType.String, 2),
        new JdeField("TDTT5", "TDTT5", JdeDataType.String, 2),
        new JdeField("TDCRRM", "TDCRRM", JdeDataType.String, 2, true, true),
        new JdeField("TDPOST", "TDPOST", JdeDataType.String, 2),
        new JdeField("TDCO", "TDCO", JdeDataType.String, 10),
        new JdeField("TDSTOL", "TDSTOL", JdeDataType.Numeric),
        new JdeField("TDICU", "TDICU", JdeDataType.Numeric),
        new JdeField("TDICUT", "TDICUT", JdeDataType.String, 4),
        new JdeField("TDCRCD", "TDCRCD", JdeDataType.String, 6),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric),
        new JdeField("TDCTID", "TDCTID", JdeDataType.String, 30, true, true),
        new JdeField("TDJOBS", "TDJOBS", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76CUI04_0", "Primary Key on TDCTID, TDJOBS, TDKCO, TDDCT, TDDOC, TDCRRM, TDKCOO, TDDCTO, TDDOCO, TDSFXO, TDLNID", new[] { "TDCTID", "TDJOBS", "TDKCO", "TDDCT", "TDDOC", "TDCRRM", "TDKCOO", "TDDCTO", "TDDOCO", "TDSFXO", "TDLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76CUI04_2", "Index on TDCTID, TDJOBS, TDCRRM, TDKCOO, TDDCTO, TDDOCO, TDSFXO, TDLNID", new[] { "TDCTID", "TDJOBS", "TDCRRM", "TDKCOO", "TDDCTO", "TDDOCO", "TDSFXO", "TDLNID" }),
        new JdeIndex("F76CUI04_3", "Index on TDCTID, TDJOBS, TDKCOO, TDDCTO, TDDOCO, TDLNID", new[] { "TDCTID", "TDJOBS", "TDKCOO", "TDDCTO", "TDDOCO", "TDLNID" })
    };
}
