using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI006 - .
/// </summary>
public class F09UI006 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDCO.
        /// </summary>
        public const string TDCO = "TDCO";

        /// <summary>
        /// TDMCU.
        /// </summary>
        public const string TDMCU = "TDMCU";

        /// <summary>
        /// TDOBJ.
        /// </summary>
        public const string TDOBJ = "TDOBJ";

        /// <summary>
        /// TDSUB.
        /// </summary>
        public const string TDSUB = "TDSUB";

        /// <summary>
        /// TDDCTO.
        /// </summary>
        public const string TDDCTO = "TDDCTO";

        /// <summary>
        /// TDDOCO.
        /// </summary>
        public const string TDDOCO = "TDDOCO";

        /// <summary>
        /// TDSFXO.
        /// </summary>
        public const string TDSFXO = "TDSFXO";

        /// <summary>
        /// TDLNID.
        /// </summary>
        public const string TDLNID = "TDLNID";

        /// <summary>
        /// TDAN8.
        /// </summary>
        public const string TDAN8 = "TDAN8";

        /// <summary>
        /// TDECST.
        /// </summary>
        public const string TDECST = "TDECST";

        /// <summary>
        /// TDAEXP.
        /// </summary>
        public const string TDAEXP = "TDAEXP";

        /// <summary>
        /// TDATXN.
        /// </summary>
        public const string TDATXN = "TDATXN";

        /// <summary>
        /// TDATXA.
        /// </summary>
        public const string TDATXA = "TDATXA";

        /// <summary>
        /// TDNRTA.
        /// </summary>
        public const string TDNRTA = "TDNRTA";

        /// <summary>
        /// TDSTAM.
        /// </summary>
        public const string TDSTAM = "TDSTAM";

        /// <summary>
        /// TDTXA1.
        /// </summary>
        public const string TDTXA1 = "TDTXA1";

        /// <summary>
        /// TDEXR1.
        /// </summary>
        public const string TDEXR1 = "TDEXR1";

        /// <summary>
        /// TDEXR2.
        /// </summary>
        public const string TDEXR2 = "TDEXR2";

        /// <summary>
        /// TDTRDJ.
        /// </summary>
        public const string TDTRDJ = "TDTRDJ";

        /// <summary>
        /// TDDGL.
        /// </summary>
        public const string TDDGL = "TDDGL";

        /// <summary>
        /// TDDSVJ.
        /// </summary>
        public const string TDDSVJ = "TDDSVJ";

        /// <summary>
        /// TDTX.
        /// </summary>
        public const string TDTX = "TDTX";

        /// <summary>
        /// TDITM.
        /// </summary>
        public const string TDITM = "TDITM";

        /// <summary>
        /// TDLITM.
        /// </summary>
        public const string TDLITM = "TDLITM";

        /// <summary>
        /// TDAITM.
        /// </summary>
        public const string TDAITM = "TDAITM";

        /// <summary>
        /// TDLNTY.
        /// </summary>
        public const string TDLNTY = "TDLNTY";

        /// <summary>
        /// TDUORG.
        /// </summary>
        public const string TDUORG = "TDUORG";

        /// <summary>
        /// TDUOM.
        /// </summary>
        public const string TDUOM = "TDUOM";

        /// <summary>
        /// TDFVTY.
        /// </summary>
        public const string TDFVTY = "TDFVTY";

        /// <summary>
        /// TDTA1.
        /// </summary>
        public const string TDTA1 = "TDTA1";

        /// <summary>
        /// TDTXR1.
        /// </summary>
        public const string TDTXR1 = "TDTXR1";

        /// <summary>
        /// TDTA2.
        /// </summary>
        public const string TDTA2 = "TDTA2";

        /// <summary>
        /// TDTXR2.
        /// </summary>
        public const string TDTXR2 = "TDTXR2";

        /// <summary>
        /// TDTA3.
        /// </summary>
        public const string TDTA3 = "TDTA3";

        /// <summary>
        /// TDTXR3.
        /// </summary>
        public const string TDTXR3 = "TDTXR3";

        /// <summary>
        /// TDTA4.
        /// </summary>
        public const string TDTA4 = "TDTA4";

        /// <summary>
        /// TDTXR4.
        /// </summary>
        public const string TDTXR4 = "TDTXR4";

        /// <summary>
        /// TDTA5.
        /// </summary>
        public const string TDTA5 = "TDTA5";

        /// <summary>
        /// TDTXR5.
        /// </summary>
        public const string TDTXR5 = "TDTXR5";

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
        /// TDPRT1.
        /// </summary>
        public const string TDPRT1 = "TDPRT1";

        /// <summary>
        /// TDOVTX.
        /// </summary>
        public const string TDOVTX = "TDOVTX";

        /// <summary>
        /// TDTXVA.
        /// </summary>
        public const string TDTXVA = "TDTXVA";

        /// <summary>
        /// TDTXVR.
        /// </summary>
        public const string TDTXVR = "TDTXVR";

        /// <summary>
        /// TDPOST.
        /// </summary>
        public const string TDPOST = "TDPOST";

        /// <summary>
        /// TDICU.
        /// </summary>
        public const string TDICU = "TDICU";

        /// <summary>
        /// TDICUT.
        /// </summary>
        public const string TDICUT = "TDICUT";

        /// <summary>
        /// TDGDVL.
        /// </summary>
        public const string TDGDVL = "TDGDVL";

        /// <summary>
        /// TDCRCD.
        /// </summary>
        public const string TDCRCD = "TDCRCD";

        /// <summary>
        /// TDCRR.
        /// </summary>
        public const string TDCRR = "TDCRR";

        /// <summary>
        /// TDSQNO.
        /// </summary>
        public const string TDSQNO = "TDSQNO";

        /// <summary>
        /// TDAG.
        /// </summary>
        public const string TDAG = "TDAG";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDAPD.
        /// </summary>
        public const string TDAPD = "TDAPD";

        /// <summary>
        /// TDTAXE.
        /// </summary>
        public const string TDTAXE = "TDTAXE";

        /// <summary>
        /// TDDOC.
        /// </summary>
        public const string TDDOC = "TDDOC";

        /// <summary>
        /// TDKCOO.
        /// </summary>
        public const string TDKCOO = "TDKCOO";

        /// <summary>
        /// TDPROCFL.
        /// </summary>
        public const string TDPROCFL = "TDPROCFL";

        /// <summary>
        /// TDADJFL.
        /// </summary>
        public const string TDADJFL = "TDADJFL";

        /// <summary>
        /// TDTOFL.
        /// </summary>
        public const string TDTOFL = "TDTOFL";
    }

    /// <inheritdoc />
    public override string TableName => "F09UI006";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDCO", "TDCO", JdeDataType.String, 10),
        new JdeField("TDMCU", "TDMCU", JdeDataType.String, 24),
        new JdeField("TDOBJ", "TDOBJ", JdeDataType.String, 12),
        new JdeField("TDSUB", "TDSUB", JdeDataType.String, 16),
        new JdeField("TDDCTO", "TDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TDDOCO", "TDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TDSFXO", "TDSFXO", JdeDataType.String, 6, true, true),
        new JdeField("TDLNID", "TDLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TDAN8", "TDAN8", JdeDataType.Numeric),
        new JdeField("TDECST", "TDECST", JdeDataType.Numeric),
        new JdeField("TDAEXP", "TDAEXP", JdeDataType.Numeric),
        new JdeField("TDATXN", "TDATXN", JdeDataType.Numeric),
        new JdeField("TDATXA", "TDATXA", JdeDataType.Numeric),
        new JdeField("TDNRTA", "TDNRTA", JdeDataType.Numeric),
        new JdeField("TDSTAM", "TDSTAM", JdeDataType.Numeric),
        new JdeField("TDTXA1", "TDTXA1", JdeDataType.String, 20),
        new JdeField("TDEXR1", "TDEXR1", JdeDataType.String, 4),
        new JdeField("TDEXR2", "TDEXR2", JdeDataType.String, 4),
        new JdeField("TDTRDJ", "TDTRDJ", JdeDataType.Numeric),
        new JdeField("TDDGL", "TDDGL", JdeDataType.Numeric),
        new JdeField("TDDSVJ", "TDDSVJ", JdeDataType.Numeric),
        new JdeField("TDTX", "TDTX", JdeDataType.String, 2),
        new JdeField("TDITM", "TDITM", JdeDataType.Numeric),
        new JdeField("TDLITM", "TDLITM", JdeDataType.String, 50),
        new JdeField("TDAITM", "TDAITM", JdeDataType.String, 50),
        new JdeField("TDLNTY", "TDLNTY", JdeDataType.String, 4),
        new JdeField("TDUORG", "TDUORG", JdeDataType.Numeric),
        new JdeField("TDUOM", "TDUOM", JdeDataType.String, 4),
        new JdeField("TDFVTY", "TDFVTY", JdeDataType.String, 2),
        new JdeField("TDTA1", "TDTA1", JdeDataType.Numeric),
        new JdeField("TDTXR1", "TDTXR1", JdeDataType.Numeric),
        new JdeField("TDTA2", "TDTA2", JdeDataType.Numeric),
        new JdeField("TDTXR2", "TDTXR2", JdeDataType.Numeric),
        new JdeField("TDTA3", "TDTA3", JdeDataType.Numeric),
        new JdeField("TDTXR3", "TDTXR3", JdeDataType.Numeric),
        new JdeField("TDTA4", "TDTA4", JdeDataType.Numeric),
        new JdeField("TDTXR4", "TDTXR4", JdeDataType.Numeric),
        new JdeField("TDTA5", "TDTA5", JdeDataType.Numeric),
        new JdeField("TDTXR5", "TDTXR5", JdeDataType.Numeric),
        new JdeField("TDSTA1", "TDSTA1", JdeDataType.Numeric),
        new JdeField("TDSTA2", "TDSTA2", JdeDataType.Numeric),
        new JdeField("TDSTA3", "TDSTA3", JdeDataType.Numeric),
        new JdeField("TDSTA4", "TDSTA4", JdeDataType.Numeric),
        new JdeField("TDSTA5", "TDSTA5", JdeDataType.Numeric),
        new JdeField("TDPRT1", "TDPRT1", JdeDataType.String, 2),
        new JdeField("TDOVTX", "TDOVTX", JdeDataType.String, 2),
        new JdeField("TDTXVA", "TDTXVA", JdeDataType.Numeric),
        new JdeField("TDTXVR", "TDTXVR", JdeDataType.Numeric),
        new JdeField("TDPOST", "TDPOST", JdeDataType.String, 2),
        new JdeField("TDICU", "TDICU", JdeDataType.Numeric, null, true, true),
        new JdeField("TDICUT", "TDICUT", JdeDataType.String, 4, true, true),
        new JdeField("TDGDVL", "TDGDVL", JdeDataType.Numeric),
        new JdeField("TDCRCD", "TDCRCD", JdeDataType.String, 6),
        new JdeField("TDCRR", "TDCRR", JdeDataType.Numeric),
        new JdeField("TDSQNO", "TDSQNO", JdeDataType.Numeric),
        new JdeField("TDAG", "TDAG", JdeDataType.Numeric),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric, null, true, true),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDAPD", "TDAPD", JdeDataType.Numeric),
        new JdeField("TDTAXE", "TDTAXE", JdeDataType.Numeric),
        new JdeField("TDDOC", "TDDOC", JdeDataType.Numeric),
        new JdeField("TDKCOO", "TDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("TDPROCFL", "TDPROCFL", JdeDataType.String, 2),
        new JdeField("TDADJFL", "TDADJFL", JdeDataType.String, 2),
        new JdeField("TDTOFL", "TDTOFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI006_0", "Primary Key on TDICU, TDICUT, TDDOCO, TDDCTO, TDKCOO, TDSFXO, TDLNID, TDUPMJ, TDUPMT", new[] { "TDICU", "TDICUT", "TDDOCO", "TDDCTO", "TDKCOO", "TDSFXO", "TDLNID", "TDUPMJ", "TDUPMT" }, isUnique: true, isPrimaryKey: true)
    };
}
