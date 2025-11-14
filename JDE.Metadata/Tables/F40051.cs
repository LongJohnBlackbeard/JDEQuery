using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40051 - .
/// </summary>
public class F40051 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDRORN.
        /// </summary>
        public const string RDRORN = "RDRORN";

        /// <summary>
        /// RDRCTO.
        /// </summary>
        public const string RDRCTO = "RDRCTO";

        /// <summary>
        /// RDRKCO.
        /// </summary>
        public const string RDRKCO = "RDRKCO";

        /// <summary>
        /// RDRLLN.
        /// </summary>
        public const string RDRLLN = "RDRLLN";

        /// <summary>
        /// RDRMAST.
        /// </summary>
        public const string RDRMAST = "RDRMAST";

        /// <summary>
        /// RDABCX.
        /// </summary>
        public const string RDABCX = "RDABCX";

        /// <summary>
        /// RDWHO.
        /// </summary>
        public const string RDWHO = "RDWHO";

        /// <summary>
        /// RDDL01.
        /// </summary>
        public const string RDDL01 = "RDDL01";

        /// <summary>
        /// RDPHN1.
        /// </summary>
        public const string RDPHN1 = "RDPHN1";

        /// <summary>
        /// RDAR1.
        /// </summary>
        public const string RDAR1 = "RDAR1";

        /// <summary>
        /// RDISNO.
        /// </summary>
        public const string RDISNO = "RDISNO";

        /// <summary>
        /// RDDCTI.
        /// </summary>
        public const string RDDCTI = "RDDCTI";

        /// <summary>
        /// RDDOCZ.
        /// </summary>
        public const string RDDOCZ = "RDDOCZ";

        /// <summary>
        /// RDDOC.
        /// </summary>
        public const string RDDOC = "RDDOC";

        /// <summary>
        /// RDDCT.
        /// </summary>
        public const string RDDCT = "RDDCT";

        /// <summary>
        /// RDKCO.
        /// </summary>
        public const string RDKCO = "RDKCO";

        /// <summary>
        /// RDOGNO.
        /// </summary>
        public const string RDOGNO = "RDOGNO";

        /// <summary>
        /// RDDOCO.
        /// </summary>
        public const string RDDOCO = "RDDOCO";

        /// <summary>
        /// RDDCTO.
        /// </summary>
        public const string RDDCTO = "RDDCTO";

        /// <summary>
        /// RDKCOO.
        /// </summary>
        public const string RDKCOO = "RDKCOO";

        /// <summary>
        /// RDLNID.
        /// </summary>
        public const string RDLNID = "RDLNID";

        /// <summary>
        /// RDAN8.
        /// </summary>
        public const string RDAN8 = "RDAN8";

        /// <summary>
        /// RDSHAN.
        /// </summary>
        public const string RDSHAN = "RDSHAN";

        /// <summary>
        /// RDOORN.
        /// </summary>
        public const string RDOORN = "RDOORN";

        /// <summary>
        /// RDOKCO.
        /// </summary>
        public const string RDOKCO = "RDOKCO";

        /// <summary>
        /// RDOCTO.
        /// </summary>
        public const string RDOCTO = "RDOCTO";

        /// <summary>
        /// RDPOLN.
        /// </summary>
        public const string RDPOLN = "RDPOLN";

        /// <summary>
        /// RDSFXO.
        /// </summary>
        public const string RDSFXO = "RDSFXO";

        /// <summary>
        /// RDITM.
        /// </summary>
        public const string RDITM = "RDITM";

        /// <summary>
        /// RDLITM.
        /// </summary>
        public const string RDLITM = "RDLITM";

        /// <summary>
        /// RDUOM.
        /// </summary>
        public const string RDUOM = "RDUOM";

        /// <summary>
        /// RDUORG.
        /// </summary>
        public const string RDUORG = "RDUORG";

        /// <summary>
        /// RDUPRC.
        /// </summary>
        public const string RDUPRC = "RDUPRC";

        /// <summary>
        /// RDAEXP.
        /// </summary>
        public const string RDAEXP = "RDAEXP";

        /// <summary>
        /// RDDRQJ.
        /// </summary>
        public const string RDDRQJ = "RDDRQJ";

        /// <summary>
        /// RDNUMB.
        /// </summary>
        public const string RDNUMB = "RDNUMB";

        /// <summary>
        /// RDDCD1.
        /// </summary>
        public const string RDDCD1 = "RDDCD1";

        /// <summary>
        /// RDCPIT.
        /// </summary>
        public const string RDCPIT = "RDCPIT";

        /// <summary>
        /// RDCPIL.
        /// </summary>
        public const string RDCPIL = "RDCPIL";

        /// <summary>
        /// RDTRQT.
        /// </summary>
        public const string RDTRQT = "RDTRQT";

        /// <summary>
        /// RDEXPJ.
        /// </summary>
        public const string RDEXPJ = "RDEXPJ";

        /// <summary>
        /// RDAAID.
        /// </summary>
        public const string RDAAID = "RDAAID";

        /// <summary>
        /// RDDCD2.
        /// </summary>
        public const string RDDCD2 = "RDDCD2";

        /// <summary>
        /// RDRCD1.
        /// </summary>
        public const string RDRCD1 = "RDRCD1";

        /// <summary>
        /// RDTKBY.
        /// </summary>
        public const string RDTKBY = "RDTKBY";

        /// <summary>
        /// RDMMCU.
        /// </summary>
        public const string RDMMCU = "RDMMCU";

        /// <summary>
        /// RDURDT.
        /// </summary>
        public const string RDURDT = "RDURDT";

        /// <summary>
        /// RDURCD.
        /// </summary>
        public const string RDURCD = "RDURCD";

        /// <summary>
        /// RDURAB.
        /// </summary>
        public const string RDURAB = "RDURAB";

        /// <summary>
        /// RDURAT.
        /// </summary>
        public const string RDURAT = "RDURAT";

        /// <summary>
        /// RDURRF.
        /// </summary>
        public const string RDURRF = "RDURRF";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDCRTU.
        /// </summary>
        public const string RDCRTU = "RDCRTU";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";

        /// <summary>
        /// RDSERN.
        /// </summary>
        public const string RDSERN = "RDSERN";

        /// <summary>
        /// RDLOTN.
        /// </summary>
        public const string RDLOTN = "RDLOTN";

        /// <summary>
        /// RDSOCLM.
        /// </summary>
        public const string RDSOCLM = "RDSOCLM";

        /// <summary>
        /// RDRTRND.
        /// </summary>
        public const string RDRTRND = "RDRTRND";

        /// <summary>
        /// RDRPRBL.
        /// </summary>
        public const string RDRPRBL = "RDRPRBL";

        /// <summary>
        /// RDDCFR.
        /// </summary>
        public const string RDDCFR = "RDDCFR";

        /// <summary>
        /// RDVR01.
        /// </summary>
        public const string RDVR01 = "RDVR01";

        /// <summary>
        /// RDMCU2.
        /// </summary>
        public const string RDMCU2 = "RDMCU2";

        /// <summary>
        /// RDMCU3.
        /// </summary>
        public const string RDMCU3 = "RDMCU3";

        /// <summary>
        /// RDMCU4.
        /// </summary>
        public const string RDMCU4 = "RDMCU4";

        /// <summary>
        /// RDMCU5.
        /// </summary>
        public const string RDMCU5 = "RDMCU5";

        /// <summary>
        /// RDDOC1.
        /// </summary>
        public const string RDDOC1 = "RDDOC1";

        /// <summary>
        /// RDDCT4.
        /// </summary>
        public const string RDDCT4 = "RDDCT4";

        /// <summary>
        /// RDDMCT.
        /// </summary>
        public const string RDDMCT = "RDDMCT";

        /// <summary>
        /// RDDMCS.
        /// </summary>
        public const string RDDMCS = "RDDMCS";

        /// <summary>
        /// RDSEQ.
        /// </summary>
        public const string RDSEQ = "RDSEQ";

        /// <summary>
        /// RDOLOCN.
        /// </summary>
        public const string RDOLOCN = "RDOLOCN";

        /// <summary>
        /// RDOLOTN.
        /// </summary>
        public const string RDOLOTN = "RDOLOTN";
    }

    /// <inheritdoc />
    public override string TableName => "F40051";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDRORN", "RDRORN", JdeDataType.String, 16, true, true),
        new JdeField("RDRCTO", "RDRCTO", JdeDataType.String, 4, true, true),
        new JdeField("RDRKCO", "RDRKCO", JdeDataType.String, 10, true, true),
        new JdeField("RDRLLN", "RDRLLN", JdeDataType.Numeric, null, true, true),
        new JdeField("RDRMAST", "RDRMAST", JdeDataType.String, 6),
        new JdeField("RDABCX", "RDABCX", JdeDataType.Numeric),
        new JdeField("RDWHO", "RDWHO", JdeDataType.String, 240),
        new JdeField("RDDL01", "RDDL01", JdeDataType.String, 60),
        new JdeField("RDPHN1", "RDPHN1", JdeDataType.String, 40),
        new JdeField("RDAR1", "RDAR1", JdeDataType.String, 12),
        new JdeField("RDISNO", "RDISNO", JdeDataType.Numeric),
        new JdeField("RDDCTI", "RDDCTI", JdeDataType.String, 4),
        new JdeField("RDDOCZ", "RDDOCZ", JdeDataType.Numeric),
        new JdeField("RDDOC", "RDDOC", JdeDataType.Numeric),
        new JdeField("RDDCT", "RDDCT", JdeDataType.String, 4),
        new JdeField("RDKCO", "RDKCO", JdeDataType.String, 10),
        new JdeField("RDOGNO", "RDOGNO", JdeDataType.Numeric),
        new JdeField("RDDOCO", "RDDOCO", JdeDataType.Numeric),
        new JdeField("RDDCTO", "RDDCTO", JdeDataType.String, 4),
        new JdeField("RDKCOO", "RDKCOO", JdeDataType.String, 10),
        new JdeField("RDLNID", "RDLNID", JdeDataType.Numeric),
        new JdeField("RDAN8", "RDAN8", JdeDataType.Numeric),
        new JdeField("RDSHAN", "RDSHAN", JdeDataType.Numeric),
        new JdeField("RDOORN", "RDOORN", JdeDataType.String, 16),
        new JdeField("RDOKCO", "RDOKCO", JdeDataType.String, 10),
        new JdeField("RDOCTO", "RDOCTO", JdeDataType.String, 4),
        new JdeField("RDPOLN", "RDPOLN", JdeDataType.Numeric),
        new JdeField("RDSFXO", "RDSFXO", JdeDataType.String, 6),
        new JdeField("RDITM", "RDITM", JdeDataType.Numeric),
        new JdeField("RDLITM", "RDLITM", JdeDataType.String, 50),
        new JdeField("RDUOM", "RDUOM", JdeDataType.String, 4),
        new JdeField("RDUORG", "RDUORG", JdeDataType.Numeric),
        new JdeField("RDUPRC", "RDUPRC", JdeDataType.Numeric),
        new JdeField("RDAEXP", "RDAEXP", JdeDataType.Numeric),
        new JdeField("RDDRQJ", "RDDRQJ", JdeDataType.Numeric),
        new JdeField("RDNUMB", "RDNUMB", JdeDataType.Numeric),
        new JdeField("RDDCD1", "RDDCD1", JdeDataType.String, 6),
        new JdeField("RDCPIT", "RDCPIT", JdeDataType.Numeric),
        new JdeField("RDCPIL", "RDCPIL", JdeDataType.String, 50),
        new JdeField("RDTRQT", "RDTRQT", JdeDataType.Numeric),
        new JdeField("RDEXPJ", "RDEXPJ", JdeDataType.Numeric),
        new JdeField("RDAAID", "RDAAID", JdeDataType.Numeric),
        new JdeField("RDDCD2", "RDDCD2", JdeDataType.String, 6),
        new JdeField("RDRCD1", "RDRCD1", JdeDataType.String, 6),
        new JdeField("RDTKBY", "RDTKBY", JdeDataType.String, 20),
        new JdeField("RDMMCU", "RDMMCU", JdeDataType.String, 24),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURCD", "RDURCD", JdeDataType.String, 4),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURRF", "RDURRF", JdeDataType.String, 30),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDCRTU", "RDCRTU", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric),
        new JdeField("RDSERN", "RDSERN", JdeDataType.String, 60),
        new JdeField("RDLOTN", "RDLOTN", JdeDataType.String, 60),
        new JdeField("RDSOCLM", "RDSOCLM", JdeDataType.String, 50),
        new JdeField("RDRTRND", "RDRTRND", JdeDataType.String, 2),
        new JdeField("RDRPRBL", "RDRPRBL", JdeDataType.String, 2),
        new JdeField("RDDCFR", "RDDCFR", JdeDataType.String, 2),
        new JdeField("RDVR01", "RDVR01", JdeDataType.String, 50),
        new JdeField("RDMCU2", "RDMCU2", JdeDataType.String, 24),
        new JdeField("RDMCU3", "RDMCU3", JdeDataType.String, 24),
        new JdeField("RDMCU4", "RDMCU4", JdeDataType.String, 24),
        new JdeField("RDMCU5", "RDMCU5", JdeDataType.String, 24),
        new JdeField("RDDOC1", "RDDOC1", JdeDataType.Numeric),
        new JdeField("RDDCT4", "RDDCT4", JdeDataType.String, 4),
        new JdeField("RDDMCT", "RDDMCT", JdeDataType.String, 24),
        new JdeField("RDDMCS", "RDDMCS", JdeDataType.Numeric),
        new JdeField("RDSEQ", "RDSEQ", JdeDataType.Numeric),
        new JdeField("RDOLOCN", "RDOLOCN", JdeDataType.String, 40),
        new JdeField("RDOLOTN", "RDOLOTN", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40051_0", "Primary Key on RDRORN, RDRCTO, RDRKCO, RDRLLN", new[] { "RDRORN", "RDRCTO", "RDRKCO", "RDRLLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40051_2", "Index on RDRORN, RDRKCO, RDRCTO, SYS_NC00076$", new[] { "RDRORN", "RDRKCO", "RDRCTO", "SYS_NC00076$" }),
        new JdeIndex("F40051_3", "Index on RDDOC", new[] { "RDDOC" }),
        new JdeIndex("F40051_5", "Index on RDDOCO, RDDCTO, RDKCOO, RDLNID", new[] { "RDDOCO", "RDDCTO", "RDKCOO", "RDLNID" }),
        new JdeIndex("F40051_6", "Index on RDDMCT, RDDMCS, RDSEQ, RDOLOCN, RDOLOTN", new[] { "RDDMCT", "RDDMCS", "RDSEQ", "RDOLOCN", "RDOLOTN" })
    };
}
