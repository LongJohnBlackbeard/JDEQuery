using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F761BA - .
/// </summary>
public class F761BA : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FBBNNF.
        /// </summary>
        public const string FBBNNF = "FBBNNF";

        /// <summary>
        /// FBBSER.
        /// </summary>
        public const string FBBSER = "FBBSER";

        /// <summary>
        /// FBN001.
        /// </summary>
        public const string FBN001 = "FBN001";

        /// <summary>
        /// FBDCT.
        /// </summary>
        public const string FBDCT = "FBDCT";

        /// <summary>
        /// FBDCT4.
        /// </summary>
        public const string FBDCT4 = "FBDCT4";

        /// <summary>
        /// FBSOS1.
        /// </summary>
        public const string FBSOS1 = "FBSOS1";

        /// <summary>
        /// FBBNF0.
        /// </summary>
        public const string FBBNF0 = "FBBNF0";

        /// <summary>
        /// FBBSR0.
        /// </summary>
        public const string FBBSR0 = "FBBSR0";

        /// <summary>
        /// FBN002.
        /// </summary>
        public const string FBN002 = "FBN002";

        /// <summary>
        /// FBOCTO.
        /// </summary>
        public const string FBOCTO = "FBOCTO";

        /// <summary>
        /// FBMATC.
        /// </summary>
        public const string FBMATC = "FBMATC";

        /// <summary>
        /// FBDOCO.
        /// </summary>
        public const string FBDOCO = "FBDOCO";

        /// <summary>
        /// FBPDCT.
        /// </summary>
        public const string FBPDCT = "FBPDCT";

        /// <summary>
        /// FBKCOO.
        /// </summary>
        public const string FBKCOO = "FBKCOO";

        /// <summary>
        /// FBSFXO.
        /// </summary>
        public const string FBSFXO = "FBSFXO";

        /// <summary>
        /// FBLNID.
        /// </summary>
        public const string FBLNID = "FBLNID";

        /// <summary>
        /// FBNLIN.
        /// </summary>
        public const string FBNLIN = "FBNLIN";

        /// <summary>
        /// FBDOC.
        /// </summary>
        public const string FBDOC = "FBDOC";

        /// <summary>
        /// FBDCTO.
        /// </summary>
        public const string FBDCTO = "FBDCTO";

        /// <summary>
        /// FBCO.
        /// </summary>
        public const string FBCO = "FBCO";

        /// <summary>
        /// FBFCO.
        /// </summary>
        public const string FBFCO = "FBFCO";

        /// <summary>
        /// FBMCU.
        /// </summary>
        public const string FBMCU = "FBMCU";

        /// <summary>
        /// FBAN8L.
        /// </summary>
        public const string FBAN8L = "FBAN8L";

        /// <summary>
        /// FBTX40.
        /// </summary>
        public const string FBTX40 = "FBTX40";

        /// <summary>
        /// FBADD6.
        /// </summary>
        public const string FBADD6 = "FBADD6";

        /// <summary>
        /// FBTAX.
        /// </summary>
        public const string FBTAX = "FBTAX";

        /// <summary>
        /// FBTX2.
        /// </summary>
        public const string FBTX2 = "FBTX2";

        /// <summary>
        /// FBITM.
        /// </summary>
        public const string FBITM = "FBITM";

        /// <summary>
        /// FBLITM.
        /// </summary>
        public const string FBLITM = "FBLITM";

        /// <summary>
        /// FBAITM.
        /// </summary>
        public const string FBAITM = "FBAITM";

        /// <summary>
        /// FBCITM.
        /// </summary>
        public const string FBCITM = "FBCITM";

        /// <summary>
        /// FBLOCN.
        /// </summary>
        public const string FBLOCN = "FBLOCN";

        /// <summary>
        /// FBLOTN.
        /// </summary>
        public const string FBLOTN = "FBLOTN";

        /// <summary>
        /// FBDSC1.
        /// </summary>
        public const string FBDSC1 = "FBDSC1";

        /// <summary>
        /// FBDSC2.
        /// </summary>
        public const string FBDSC2 = "FBDSC2";

        /// <summary>
        /// FBLNTY.
        /// </summary>
        public const string FBLNTY = "FBLNTY";

        /// <summary>
        /// FBUOM.
        /// </summary>
        public const string FBUOM = "FBUOM";

        /// <summary>
        /// FBUORG.
        /// </summary>
        public const string FBUORG = "FBUORG";

        /// <summary>
        /// FBUOM3.
        /// </summary>
        public const string FBUOM3 = "FBUOM3";

        /// <summary>
        /// FBUPRC.
        /// </summary>
        public const string FBUPRC = "FBUPRC";

        /// <summary>
        /// FBAEXP.
        /// </summary>
        public const string FBAEXP = "FBAEXP";

        /// <summary>
        /// FBBDES.
        /// </summary>
        public const string FBBDES = "FBBDES";

        /// <summary>
        /// FBGLC.
        /// </summary>
        public const string FBGLC = "FBGLC";

        /// <summary>
        /// FBSHAN.
        /// </summary>
        public const string FBSHAN = "FBSHAN";

        /// <summary>
        /// FBAN8.
        /// </summary>
        public const string FBAN8 = "FBAN8";

        /// <summary>
        /// FBBCGT.
        /// </summary>
        public const string FBBCGT = "FBBCGT";

        /// <summary>
        /// FBBCPT.
        /// </summary>
        public const string FBBCPT = "FBBCPT";

        /// <summary>
        /// FBSHST.
        /// </summary>
        public const string FBSHST = "FBSHST";

        /// <summary>
        /// FBSHZP.
        /// </summary>
        public const string FBSHZP = "FBSHZP";

        /// <summary>
        /// FBBSFH.
        /// </summary>
        public const string FBBSFH = "FBBSFH";

        /// <summary>
        /// FBAN8V.
        /// </summary>
        public const string FBAN8V = "FBAN8V";

        /// <summary>
        /// FBBCGF.
        /// </summary>
        public const string FBBCGF = "FBBCGF";

        /// <summary>
        /// FBBCPF.
        /// </summary>
        public const string FBBCPF = "FBBCPF";

        /// <summary>
        /// FBADDS.
        /// </summary>
        public const string FBADDS = "FBADDS";

        /// <summary>
        /// FBBNOP.
        /// </summary>
        public const string FBBNOP = "FBBNOP";

        /// <summary>
        /// FBBSOP.
        /// </summary>
        public const string FBBSOP = "FBBSOP";

        /// <summary>
        /// FBBDIP.
        /// </summary>
        public const string FBBDIP = "FBBDIP";

        /// <summary>
        /// FBBDIB.
        /// </summary>
        public const string FBBDIB = "FBBDIB";

        /// <summary>
        /// FBBCLF.
        /// </summary>
        public const string FBBCLF = "FBBCLF";

        /// <summary>
        /// FBBCTF.
        /// </summary>
        public const string FBBCTF = "FBBCTF";

        /// <summary>
        /// FBBSTT.
        /// </summary>
        public const string FBBSTT = "FBBSTT";

        /// <summary>
        /// FBBFRT.
        /// </summary>
        public const string FBBFRT = "FBBFRT";

        /// <summary>
        /// FBBSEG.
        /// </summary>
        public const string FBBSEG = "FBBSEG";

        /// <summary>
        /// FBBDFN.
        /// </summary>
        public const string FBBDFN = "FBBDFN";

        /// <summary>
        /// FBTXR1.
        /// </summary>
        public const string FBTXR1 = "FBTXR1";

        /// <summary>
        /// FBBBIR.
        /// </summary>
        public const string FBBBIR = "FBBBIR";

        /// <summary>
        /// FBBVIS.
        /// </summary>
        public const string FBBVIS = "FBBVIS";

        /// <summary>
        /// FBBBIS.
        /// </summary>
        public const string FBBBIS = "FBBBIS";

        /// <summary>
        /// FBBREP.
        /// </summary>
        public const string FBBREP = "FBBREP";

        /// <summary>
        /// FBBDIZ.
        /// </summary>
        public const string FBBDIZ = "FBBDIZ";

        /// <summary>
        /// FBBIPR.
        /// </summary>
        public const string FBBIPR = "FBBIPR";

        /// <summary>
        /// FBTXR2.
        /// </summary>
        public const string FBTXR2 = "FBTXR2";

        /// <summary>
        /// FBBISS.
        /// </summary>
        public const string FBBISS = "FBBISS";

        /// <summary>
        /// FBTXR3.
        /// </summary>
        public const string FBTXR3 = "FBTXR3";

        /// <summary>
        /// FBBBCS.
        /// </summary>
        public const string FBBBCS = "FBBBCS";

        /// <summary>
        /// FBBINM.
        /// </summary>
        public const string FBBINM = "FBBINM";

        /// <summary>
        /// FBBNIV.
        /// </summary>
        public const string FBBNIV = "FBBNIV";

        /// <summary>
        /// FBPGNO.
        /// </summary>
        public const string FBPGNO = "FBPGNO";

        /// <summary>
        /// FBNXTR.
        /// </summary>
        public const string FBNXTR = "FBNXTR";

        /// <summary>
        /// FBLTTR.
        /// </summary>
        public const string FBLTTR = "FBLTTR";

        /// <summary>
        /// FBUSER.
        /// </summary>
        public const string FBUSER = "FBUSER";

        /// <summary>
        /// FBPID.
        /// </summary>
        public const string FBPID = "FBPID";

        /// <summary>
        /// FBJOBN.
        /// </summary>
        public const string FBJOBN = "FBJOBN";

        /// <summary>
        /// FBUPMJ.
        /// </summary>
        public const string FBUPMJ = "FBUPMJ";

        /// <summary>
        /// FBTDAY.
        /// </summary>
        public const string FBTDAY = "FBTDAY";

        /// <summary>
        /// FBISSU.
        /// </summary>
        public const string FBISSU = "FBISSU";

        /// <summary>
        /// FBADDJ.
        /// </summary>
        public const string FBADDJ = "FBADDJ";

        /// <summary>
        /// FBBVTN.
        /// </summary>
        public const string FBBVTN = "FBBVTN";

        /// <summary>
        /// FBNCD.
        /// </summary>
        public const string FBNCD = "FBNCD";

        /// <summary>
        /// FBBORI.
        /// </summary>
        public const string FBBORI = "FBBORI";

        /// <summary>
        /// FBBDMF.
        /// </summary>
        public const string FBBDMF = "FBBDMF";

        /// <summary>
        /// FBSPLT.
        /// </summary>
        public const string FBSPLT = "FBSPLT";

        /// <summary>
        /// FBCSJ.
        /// </summary>
        public const string FBCSJ = "FBCSJ";

        /// <summary>
        /// FBBDPM.
        /// </summary>
        public const string FBBDPM = "FBBDPM";

        /// <summary>
        /// FBBESP.
        /// </summary>
        public const string FBBESP = "FBBESP";

        /// <summary>
        /// FBPQOR.
        /// </summary>
        public const string FBPQOR = "FBPQOR";

        /// <summary>
        /// FBUOM1.
        /// </summary>
        public const string FBUOM1 = "FBUOM1";

        /// <summary>
        /// FBPRIC.
        /// </summary>
        public const string FBPRIC = "FBPRIC";

        /// <summary>
        /// FBYRA.
        /// </summary>
        public const string FBYRA = "FBYRA";

        /// <summary>
        /// FBHMO.
        /// </summary>
        public const string FBHMO = "FBHMO";

        /// <summary>
        /// FBDOM.
        /// </summary>
        public const string FBDOM = "FBDOM";

        /// <summary>
        /// FBBBCL.
        /// </summary>
        public const string FBBBCL = "FBBBCL";

        /// <summary>
        /// FBBICM.
        /// </summary>
        public const string FBBICM = "FBBICM";

        /// <summary>
        /// FBBVII.
        /// </summary>
        public const string FBBVII = "FBBVII";

        /// <summary>
        /// FBBVOI.
        /// </summary>
        public const string FBBVOI = "FBBVOI";

        /// <summary>
        /// FBBBTP.
        /// </summary>
        public const string FBBBTP = "FBBBTP";

        /// <summary>
        /// FBBIPI.
        /// </summary>
        public const string FBBIPI = "FBBIPI";

        /// <summary>
        /// FBBVIP.
        /// </summary>
        public const string FBBVIP = "FBBVIP";

        /// <summary>
        /// FBBVOP.
        /// </summary>
        public const string FBBVOP = "FBBVOP";

        /// <summary>
        /// FBSY.
        /// </summary>
        public const string FBSY = "FBSY";

        /// <summary>
        /// FBUKID.
        /// </summary>
        public const string FBUKID = "FBUKID";
    }

    /// <inheritdoc />
    public override string TableName => "F761BA";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FBBNNF", "FBBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("FBBSER", "FBBSER", JdeDataType.String, 4, true, true),
        new JdeField("FBN001", "FBN001", JdeDataType.Numeric, null, true, true),
        new JdeField("FBDCT", "FBDCT", JdeDataType.String, 4, true, true),
        new JdeField("FBDCT4", "FBDCT4", JdeDataType.String, 4),
        new JdeField("FBSOS1", "FBSOS1", JdeDataType.String, 6),
        new JdeField("FBBNF0", "FBBNF0", JdeDataType.Numeric),
        new JdeField("FBBSR0", "FBBSR0", JdeDataType.String, 4),
        new JdeField("FBN002", "FBN002", JdeDataType.Numeric),
        new JdeField("FBOCTO", "FBOCTO", JdeDataType.String, 4),
        new JdeField("FBMATC", "FBMATC", JdeDataType.String, 2),
        new JdeField("FBDOCO", "FBDOCO", JdeDataType.Numeric),
        new JdeField("FBPDCT", "FBPDCT", JdeDataType.String, 4),
        new JdeField("FBKCOO", "FBKCOO", JdeDataType.String, 10),
        new JdeField("FBSFXO", "FBSFXO", JdeDataType.String, 6),
        new JdeField("FBLNID", "FBLNID", JdeDataType.Numeric),
        new JdeField("FBNLIN", "FBNLIN", JdeDataType.Numeric),
        new JdeField("FBDOC", "FBDOC", JdeDataType.Numeric),
        new JdeField("FBDCTO", "FBDCTO", JdeDataType.String, 4),
        new JdeField("FBCO", "FBCO", JdeDataType.String, 10),
        new JdeField("FBFCO", "FBFCO", JdeDataType.String, 10),
        new JdeField("FBMCU", "FBMCU", JdeDataType.String, 24),
        new JdeField("FBAN8L", "FBAN8L", JdeDataType.Numeric),
        new JdeField("FBTX40", "FBTX40", JdeDataType.String, 80),
        new JdeField("FBADD6", "FBADD6", JdeDataType.String, 80),
        new JdeField("FBTAX", "FBTAX", JdeDataType.String, 40),
        new JdeField("FBTX2", "FBTX2", JdeDataType.String, 40),
        new JdeField("FBITM", "FBITM", JdeDataType.Numeric),
        new JdeField("FBLITM", "FBLITM", JdeDataType.String, 50),
        new JdeField("FBAITM", "FBAITM", JdeDataType.String, 50),
        new JdeField("FBCITM", "FBCITM", JdeDataType.String, 50),
        new JdeField("FBLOCN", "FBLOCN", JdeDataType.String, 40),
        new JdeField("FBLOTN", "FBLOTN", JdeDataType.String, 60),
        new JdeField("FBDSC1", "FBDSC1", JdeDataType.String, 60),
        new JdeField("FBDSC2", "FBDSC2", JdeDataType.String, 60),
        new JdeField("FBLNTY", "FBLNTY", JdeDataType.String, 4),
        new JdeField("FBUOM", "FBUOM", JdeDataType.String, 4),
        new JdeField("FBUORG", "FBUORG", JdeDataType.Numeric),
        new JdeField("FBUOM3", "FBUOM3", JdeDataType.String, 4),
        new JdeField("FBUPRC", "FBUPRC", JdeDataType.Numeric),
        new JdeField("FBAEXP", "FBAEXP", JdeDataType.Numeric),
        new JdeField("FBBDES", "FBBDES", JdeDataType.Numeric),
        new JdeField("FBGLC", "FBGLC", JdeDataType.String, 8),
        new JdeField("FBSHAN", "FBSHAN", JdeDataType.Numeric),
        new JdeField("FBAN8", "FBAN8", JdeDataType.Numeric),
        new JdeField("FBBCGT", "FBBCGT", JdeDataType.String, 30),
        new JdeField("FBBCPT", "FBBCPT", JdeDataType.String, 22),
        new JdeField("FBSHST", "FBSHST", JdeDataType.String, 6),
        new JdeField("FBSHZP", "FBSHZP", JdeDataType.String, 24),
        new JdeField("FBBSFH", "FBBSFH", JdeDataType.Numeric),
        new JdeField("FBAN8V", "FBAN8V", JdeDataType.Numeric),
        new JdeField("FBBCGF", "FBBCGF", JdeDataType.String, 30),
        new JdeField("FBBCPF", "FBBCPF", JdeDataType.String, 22),
        new JdeField("FBADDS", "FBADDS", JdeDataType.String, 6),
        new JdeField("FBBNOP", "FBBNOP", JdeDataType.Numeric),
        new JdeField("FBBSOP", "FBBSOP", JdeDataType.String, 4),
        new JdeField("FBBDIP", "FBBDIP", JdeDataType.String, 8),
        new JdeField("FBBDIB", "FBBDIB", JdeDataType.String, 4),
        new JdeField("FBBCLF", "FBBCLF", JdeDataType.String, 20),
        new JdeField("FBBCTF", "FBBCTF", JdeDataType.String, 4),
        new JdeField("FBBSTT", "FBBSTT", JdeDataType.String, 4),
        new JdeField("FBBFRT", "FBBFRT", JdeDataType.Numeric),
        new JdeField("FBBSEG", "FBBSEG", JdeDataType.Numeric),
        new JdeField("FBBDFN", "FBBDFN", JdeDataType.Numeric),
        new JdeField("FBTXR1", "FBTXR1", JdeDataType.Numeric),
        new JdeField("FBBBIR", "FBBBIR", JdeDataType.Numeric),
        new JdeField("FBBVIS", "FBBVIS", JdeDataType.Numeric),
        new JdeField("FBBBIS", "FBBBIS", JdeDataType.Numeric),
        new JdeField("FBBREP", "FBBREP", JdeDataType.Numeric),
        new JdeField("FBBDIZ", "FBBDIZ", JdeDataType.Numeric),
        new JdeField("FBBIPR", "FBBIPR", JdeDataType.Numeric),
        new JdeField("FBTXR2", "FBTXR2", JdeDataType.Numeric),
        new JdeField("FBBISS", "FBBISS", JdeDataType.Numeric),
        new JdeField("FBTXR3", "FBTXR3", JdeDataType.Numeric),
        new JdeField("FBBBCS", "FBBBCS", JdeDataType.Numeric),
        new JdeField("FBBINM", "FBBINM", JdeDataType.String, 20),
        new JdeField("FBBNIV", "FBBNIV", JdeDataType.Numeric),
        new JdeField("FBPGNO", "FBPGNO", JdeDataType.Numeric),
        new JdeField("FBNXTR", "FBNXTR", JdeDataType.String, 6),
        new JdeField("FBLTTR", "FBLTTR", JdeDataType.String, 6),
        new JdeField("FBUSER", "FBUSER", JdeDataType.String, 20),
        new JdeField("FBPID", "FBPID", JdeDataType.String, 20),
        new JdeField("FBJOBN", "FBJOBN", JdeDataType.String, 20),
        new JdeField("FBUPMJ", "FBUPMJ", JdeDataType.Numeric),
        new JdeField("FBTDAY", "FBTDAY", JdeDataType.Numeric),
        new JdeField("FBISSU", "FBISSU", JdeDataType.Numeric),
        new JdeField("FBADDJ", "FBADDJ", JdeDataType.Numeric),
        new JdeField("FBBVTN", "FBBVTN", JdeDataType.Numeric),
        new JdeField("FBNCD", "FBNCD", JdeDataType.String, 2),
        new JdeField("FBBORI", "FBBORI", JdeDataType.String, 2),
        new JdeField("FBBDMF", "FBBDMF", JdeDataType.String, 6),
        new JdeField("FBSPLT", "FBSPLT", JdeDataType.String, 2),
        new JdeField("FBCSJ", "FBCSJ", JdeDataType.String, 2),
        new JdeField("FBBDPM", "FBBDPM", JdeDataType.String, 4),
        new JdeField("FBBESP", "FBBESP", JdeDataType.String, 10),
        new JdeField("FBPQOR", "FBPQOR", JdeDataType.Numeric),
        new JdeField("FBUOM1", "FBUOM1", JdeDataType.String, 4),
        new JdeField("FBPRIC", "FBPRIC", JdeDataType.Numeric),
        new JdeField("FBYRA", "FBYRA", JdeDataType.Numeric),
        new JdeField("FBHMO", "FBHMO", JdeDataType.Numeric),
        new JdeField("FBDOM", "FBDOM", JdeDataType.Numeric),
        new JdeField("FBBBCL", "FBBBCL", JdeDataType.Numeric),
        new JdeField("FBBICM", "FBBICM", JdeDataType.Numeric),
        new JdeField("FBBVII", "FBBVII", JdeDataType.Numeric),
        new JdeField("FBBVOI", "FBBVOI", JdeDataType.Numeric),
        new JdeField("FBBBTP", "FBBBTP", JdeDataType.Numeric),
        new JdeField("FBBIPI", "FBBIPI", JdeDataType.Numeric),
        new JdeField("FBBVIP", "FBBVIP", JdeDataType.Numeric),
        new JdeField("FBBVOP", "FBBVOP", JdeDataType.Numeric),
        new JdeField("FBSY", "FBSY", JdeDataType.String, 8),
        new JdeField("FBUKID", "FBUKID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F761BA_0", "Primary Key on FBBNNF, FBBSER, FBN001, FBDCT, FBUKID", new[] { "FBBNNF", "FBBSER", "FBN001", "FBDCT", "FBUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
