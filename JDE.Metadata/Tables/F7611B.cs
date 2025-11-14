using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7611B - .
/// </summary>
public class F7611B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FDBNNF.
        /// </summary>
        public const string FDBNNF = "FDBNNF";

        /// <summary>
        /// FDBSER.
        /// </summary>
        public const string FDBSER = "FDBSER";

        /// <summary>
        /// FDN001.
        /// </summary>
        public const string FDN001 = "FDN001";

        /// <summary>
        /// FDDCT.
        /// </summary>
        public const string FDDCT = "FDDCT";

        /// <summary>
        /// FDUKID.
        /// </summary>
        public const string FDUKID = "FDUKID";

        /// <summary>
        /// FDSOS1.
        /// </summary>
        public const string FDSOS1 = "FDSOS1";

        /// <summary>
        /// FDBNF0.
        /// </summary>
        public const string FDBNF0 = "FDBNF0";

        /// <summary>
        /// FDBSR0.
        /// </summary>
        public const string FDBSR0 = "FDBSR0";

        /// <summary>
        /// FDN002.
        /// </summary>
        public const string FDN002 = "FDN002";

        /// <summary>
        /// FDBNFS.
        /// </summary>
        public const string FDBNFS = "FDBNFS";

        /// <summary>
        /// FDOCTO.
        /// </summary>
        public const string FDOCTO = "FDOCTO";

        /// <summary>
        /// FDMATC.
        /// </summary>
        public const string FDMATC = "FDMATC";

        /// <summary>
        /// FDDOCO.
        /// </summary>
        public const string FDDOCO = "FDDOCO";

        /// <summary>
        /// FDPDCT.
        /// </summary>
        public const string FDPDCT = "FDPDCT";

        /// <summary>
        /// FDKCOO.
        /// </summary>
        public const string FDKCOO = "FDKCOO";

        /// <summary>
        /// FDSFXO.
        /// </summary>
        public const string FDSFXO = "FDSFXO";

        /// <summary>
        /// FDLNID.
        /// </summary>
        public const string FDLNID = "FDLNID";

        /// <summary>
        /// FDNLIN.
        /// </summary>
        public const string FDNLIN = "FDNLIN";

        /// <summary>
        /// FDDOC.
        /// </summary>
        public const string FDDOC = "FDDOC";

        /// <summary>
        /// FDDCTO.
        /// </summary>
        public const string FDDCTO = "FDDCTO";

        /// <summary>
        /// FDCO.
        /// </summary>
        public const string FDCO = "FDCO";

        /// <summary>
        /// FDFCO.
        /// </summary>
        public const string FDFCO = "FDFCO";

        /// <summary>
        /// FDITM.
        /// </summary>
        public const string FDITM = "FDITM";

        /// <summary>
        /// FDLITM.
        /// </summary>
        public const string FDLITM = "FDLITM";

        /// <summary>
        /// FDAITM.
        /// </summary>
        public const string FDAITM = "FDAITM";

        /// <summary>
        /// FDCITM.
        /// </summary>
        public const string FDCITM = "FDCITM";

        /// <summary>
        /// FDMCU.
        /// </summary>
        public const string FDMCU = "FDMCU";

        /// <summary>
        /// FDLOCN.
        /// </summary>
        public const string FDLOCN = "FDLOCN";

        /// <summary>
        /// FDLOTN.
        /// </summary>
        public const string FDLOTN = "FDLOTN";

        /// <summary>
        /// FDDSC1.
        /// </summary>
        public const string FDDSC1 = "FDDSC1";

        /// <summary>
        /// FDDSC2.
        /// </summary>
        public const string FDDSC2 = "FDDSC2";

        /// <summary>
        /// FDLNTY.
        /// </summary>
        public const string FDLNTY = "FDLNTY";

        /// <summary>
        /// FDUOM.
        /// </summary>
        public const string FDUOM = "FDUOM";

        /// <summary>
        /// FDUORG.
        /// </summary>
        public const string FDUORG = "FDUORG";

        /// <summary>
        /// FDUOM3.
        /// </summary>
        public const string FDUOM3 = "FDUOM3";

        /// <summary>
        /// FDUOM4.
        /// </summary>
        public const string FDUOM4 = "FDUOM4";

        /// <summary>
        /// FDUPRC.
        /// </summary>
        public const string FDUPRC = "FDUPRC";

        /// <summary>
        /// FDAEXP.
        /// </summary>
        public const string FDAEXP = "FDAEXP";

        /// <summary>
        /// FDBDES.
        /// </summary>
        public const string FDBDES = "FDBDES";

        /// <summary>
        /// FDGLC.
        /// </summary>
        public const string FDGLC = "FDGLC";

        /// <summary>
        /// FDSHAN.
        /// </summary>
        public const string FDSHAN = "FDSHAN";

        /// <summary>
        /// FDAN8.
        /// </summary>
        public const string FDAN8 = "FDAN8";

        /// <summary>
        /// FDBCGT.
        /// </summary>
        public const string FDBCGT = "FDBCGT";

        /// <summary>
        /// FDBCPT.
        /// </summary>
        public const string FDBCPT = "FDBCPT";

        /// <summary>
        /// FDSHST.
        /// </summary>
        public const string FDSHST = "FDSHST";

        /// <summary>
        /// FDSHZP.
        /// </summary>
        public const string FDSHZP = "FDSHZP";

        /// <summary>
        /// FDBSFH.
        /// </summary>
        public const string FDBSFH = "FDBSFH";

        /// <summary>
        /// FDAN8V.
        /// </summary>
        public const string FDAN8V = "FDAN8V";

        /// <summary>
        /// FDBCGF.
        /// </summary>
        public const string FDBCGF = "FDBCGF";

        /// <summary>
        /// FDBCPF.
        /// </summary>
        public const string FDBCPF = "FDBCPF";

        /// <summary>
        /// FDADDS.
        /// </summary>
        public const string FDADDS = "FDADDS";

        /// <summary>
        /// FDBNOP.
        /// </summary>
        public const string FDBNOP = "FDBNOP";

        /// <summary>
        /// FDBSOP.
        /// </summary>
        public const string FDBSOP = "FDBSOP";

        /// <summary>
        /// FDBDIP.
        /// </summary>
        public const string FDBDIP = "FDBDIP";

        /// <summary>
        /// FDBCLF.
        /// </summary>
        public const string FDBCLF = "FDBCLF";

        /// <summary>
        /// FDBCTF.
        /// </summary>
        public const string FDBCTF = "FDBCTF";

        /// <summary>
        /// FDBIST.
        /// </summary>
        public const string FDBIST = "FDBIST";

        /// <summary>
        /// FDBORI.
        /// </summary>
        public const string FDBORI = "FDBORI";

        /// <summary>
        /// FDBCFC.
        /// </summary>
        public const string FDBCFC = "FDBCFC";

        /// <summary>
        /// FDBSTT.
        /// </summary>
        public const string FDBSTT = "FDBSTT";

        /// <summary>
        /// FDBST1.
        /// </summary>
        public const string FDBST1 = "FDBST1";

        /// <summary>
        /// FDBFRT.
        /// </summary>
        public const string FDBFRT = "FDBFRT";

        /// <summary>
        /// FDBSEG.
        /// </summary>
        public const string FDBSEG = "FDBSEG";

        /// <summary>
        /// FDBDFN.
        /// </summary>
        public const string FDBDFN = "FDBDFN";

        /// <summary>
        /// FDBICM.
        /// </summary>
        public const string FDBICM = "FDBICM";

        /// <summary>
        /// FDTXR1.
        /// </summary>
        public const string FDTXR1 = "FDTXR1";

        /// <summary>
        /// FDBBCL.
        /// </summary>
        public const string FDBBCL = "FDBBCL";

        /// <summary>
        /// FDBBIR.
        /// </summary>
        public const string FDBBIR = "FDBBIR";

        /// <summary>
        /// FDBVIS.
        /// </summary>
        public const string FDBVIS = "FDBVIS";

        /// <summary>
        /// FDBBIS.
        /// </summary>
        public const string FDBBIS = "FDBBIS";

        /// <summary>
        /// FDBREP.
        /// </summary>
        public const string FDBREP = "FDBREP";

        /// <summary>
        /// FDBDIZ.
        /// </summary>
        public const string FDBDIZ = "FDBDIZ";

        /// <summary>
        /// FDBICP.
        /// </summary>
        public const string FDBICP = "FDBICP";

        /// <summary>
        /// FDBFII.
        /// </summary>
        public const string FDBFII = "FDBFII";

        /// <summary>
        /// FDBIPR.
        /// </summary>
        public const string FDBIPR = "FDBIPR";

        /// <summary>
        /// FDBIPI.
        /// </summary>
        public const string FDBIPI = "FDBIPI";

        /// <summary>
        /// FDTXR2.
        /// </summary>
        public const string FDTXR2 = "FDTXR2";

        /// <summary>
        /// FDBBTP.
        /// </summary>
        public const string FDBBTP = "FDBBTP";

        /// <summary>
        /// FDBFIP.
        /// </summary>
        public const string FDBFIP = "FDBFIP";

        /// <summary>
        /// FDBISS.
        /// </summary>
        public const string FDBISS = "FDBISS";

        /// <summary>
        /// FDTXR3.
        /// </summary>
        public const string FDTXR3 = "FDTXR3";

        /// <summary>
        /// FDBBCS.
        /// </summary>
        public const string FDBBCS = "FDBBCS";

        /// <summary>
        /// FDBIRT.
        /// </summary>
        public const string FDBIRT = "FDBIRT";

        /// <summary>
        /// FDTXR4.
        /// </summary>
        public const string FDTXR4 = "FDTXR4";

        /// <summary>
        /// FDBBCR.
        /// </summary>
        public const string FDBBCR = "FDBBCR";

        /// <summary>
        /// FDBIIT.
        /// </summary>
        public const string FDBIIT = "FDBIIT";

        /// <summary>
        /// FDTXR5.
        /// </summary>
        public const string FDTXR5 = "FDTXR5";

        /// <summary>
        /// FDBBCI.
        /// </summary>
        public const string FDBBCI = "FDBBCI";

        /// <summary>
        /// FDANI.
        /// </summary>
        public const string FDANI = "FDANI";

        /// <summary>
        /// FDAID.
        /// </summary>
        public const string FDAID = "FDAID";

        /// <summary>
        /// FDOMCU.
        /// </summary>
        public const string FDOMCU = "FDOMCU";

        /// <summary>
        /// FDOBJ.
        /// </summary>
        public const string FDOBJ = "FDOBJ";

        /// <summary>
        /// FDSUB.
        /// </summary>
        public const string FDSUB = "FDSUB";

        /// <summary>
        /// FDSBLT.
        /// </summary>
        public const string FDSBLT = "FDSBLT";

        /// <summary>
        /// FDSBL.
        /// </summary>
        public const string FDSBL = "FDSBL";

        /// <summary>
        /// FDBINM.
        /// </summary>
        public const string FDBINM = "FDBINM";

        /// <summary>
        /// FDISSU.
        /// </summary>
        public const string FDISSU = "FDISSU";

        /// <summary>
        /// FDBNIV.
        /// </summary>
        public const string FDBNIV = "FDBNIV";

        /// <summary>
        /// FDPGNO.
        /// </summary>
        public const string FDPGNO = "FDPGNO";

        /// <summary>
        /// FDNXTR.
        /// </summary>
        public const string FDNXTR = "FDNXTR";

        /// <summary>
        /// FDLTTR.
        /// </summary>
        public const string FDLTTR = "FDLTTR";

        /// <summary>
        /// FDUSER.
        /// </summary>
        public const string FDUSER = "FDUSER";

        /// <summary>
        /// FDPID.
        /// </summary>
        public const string FDPID = "FDPID";

        /// <summary>
        /// FDJOBN.
        /// </summary>
        public const string FDJOBN = "FDJOBN";

        /// <summary>
        /// FDUPMJ.
        /// </summary>
        public const string FDUPMJ = "FDUPMJ";

        /// <summary>
        /// FDTDAY.
        /// </summary>
        public const string FDTDAY = "FDTDAY";

        /// <summary>
        /// FDCRCD.
        /// </summary>
        public const string FDCRCD = "FDCRCD";

        /// <summary>
        /// FDFTR.
        /// </summary>
        public const string FDFTR = "FDFTR";

        /// <summary>
        /// FDF1T.
        /// </summary>
        public const string FDF1T = "FDF1T";

        /// <summary>
        /// FDF2A.
        /// </summary>
        public const string FDF2A = "FDF2A";

        /// <summary>
        /// FDF2T.
        /// </summary>
        public const string FDF2T = "FDF2T";

        /// <summary>
        /// FDUSB1.
        /// </summary>
        public const string FDUSB1 = "FDUSB1";

        /// <summary>
        /// FDFLD3.
        /// </summary>
        public const string FDFLD3 = "FDFLD3";

        /// <summary>
        /// FDFLD4.
        /// </summary>
        public const string FDFLD4 = "FDFLD4";

        /// <summary>
        /// FDPVAD.
        /// </summary>
        public const string FDPVAD = "FDPVAD";

        /// <summary>
        /// FDPVRATE.
        /// </summary>
        public const string FDPVRATE = "FDPVRATE";

        /// <summary>
        /// FDPVAMT.
        /// </summary>
        public const string FDPVAMT = "FDPVAMT";

        /// <summary>
        /// FDORRATE.
        /// </summary>
        public const string FDORRATE = "FDORRATE";

        /// <summary>
        /// FDORAMT.
        /// </summary>
        public const string FDORAMT = "FDORAMT";

        /// <summary>
        /// FDDSRATE.
        /// </summary>
        public const string FDDSRATE = "FDDSRATE";

        /// <summary>
        /// FDDSAMT.
        /// </summary>
        public const string FDDSAMT = "FDDSAMT";

        /// <summary>
        /// FDICDSTL.
        /// </summary>
        public const string FDICDSTL = "FDICDSTL";

        /// <summary>
        /// FDDIFRATE.
        /// </summary>
        public const string FDDIFRATE = "FDDIFRATE";

        /// <summary>
        /// FDDSIC.
        /// </summary>
        public const string FDDSIC = "FDDSIC";

        /// <summary>
        /// FDAMTDS.
        /// </summary>
        public const string FDAMTDS = "FDAMTDS";

        /// <summary>
        /// FDPVAMTST.
        /// </summary>
        public const string FDPVAMTST = "FDPVAMTST";

        /// <summary>
        /// FDB76ADRA1.
        /// </summary>
        public const string FDB76ADRA1 = "FDB76ADRA1";

        /// <summary>
        /// FDB76ADRA2.
        /// </summary>
        public const string FDB76ADRA2 = "FDB76ADRA2";

        /// <summary>
        /// FDIATR.
        /// </summary>
        public const string FDIATR = "FDIATR";

        /// <summary>
        /// FDISMR.
        /// </summary>
        public const string FDISMR = "FDISMR";

        /// <summary>
        /// FDTXRR2.
        /// </summary>
        public const string FDTXRR2 = "FDTXRR2";

        /// <summary>
        /// FDFNUMB4.
        /// </summary>
        public const string FDFNUMB4 = "FDFNUMB4";

        /// <summary>
        /// FDFNUMB5.
        /// </summary>
        public const string FDFNUMB5 = "FDFNUMB5";

        /// <summary>
        /// FDFNUMB6.
        /// </summary>
        public const string FDFNUMB6 = "FDFNUMB6";

        /// <summary>
        /// FDFNUMB7.
        /// </summary>
        public const string FDFNUMB7 = "FDFNUMB7";

        /// <summary>
        /// FDFSTRN4.
        /// </summary>
        public const string FDFSTRN4 = "FDFSTRN4";

        /// <summary>
        /// FDFSTRN5.
        /// </summary>
        public const string FDFSTRN5 = "FDFSTRN5";

        /// <summary>
        /// FDFSTRN6.
        /// </summary>
        public const string FDFSTRN6 = "FDFSTRN6";

        /// <summary>
        /// FDFSTRN7.
        /// </summary>
        public const string FDFSTRN7 = "FDFSTRN7";
    }

    /// <inheritdoc />
    public override string TableName => "F7611B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FDBNNF", "FDBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("FDBSER", "FDBSER", JdeDataType.String, 4, true, true),
        new JdeField("FDN001", "FDN001", JdeDataType.Numeric, null, true, true),
        new JdeField("FDDCT", "FDDCT", JdeDataType.String, 4, true, true),
        new JdeField("FDUKID", "FDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("FDSOS1", "FDSOS1", JdeDataType.String, 6),
        new JdeField("FDBNF0", "FDBNF0", JdeDataType.Numeric),
        new JdeField("FDBSR0", "FDBSR0", JdeDataType.String, 4),
        new JdeField("FDN002", "FDN002", JdeDataType.Numeric),
        new JdeField("FDBNFS", "FDBNFS", JdeDataType.String, 2),
        new JdeField("FDOCTO", "FDOCTO", JdeDataType.String, 4),
        new JdeField("FDMATC", "FDMATC", JdeDataType.String, 2),
        new JdeField("FDDOCO", "FDDOCO", JdeDataType.Numeric),
        new JdeField("FDPDCT", "FDPDCT", JdeDataType.String, 4),
        new JdeField("FDKCOO", "FDKCOO", JdeDataType.String, 10),
        new JdeField("FDSFXO", "FDSFXO", JdeDataType.String, 6),
        new JdeField("FDLNID", "FDLNID", JdeDataType.Numeric),
        new JdeField("FDNLIN", "FDNLIN", JdeDataType.Numeric),
        new JdeField("FDDOC", "FDDOC", JdeDataType.Numeric),
        new JdeField("FDDCTO", "FDDCTO", JdeDataType.String, 4),
        new JdeField("FDCO", "FDCO", JdeDataType.String, 10),
        new JdeField("FDFCO", "FDFCO", JdeDataType.String, 10),
        new JdeField("FDITM", "FDITM", JdeDataType.Numeric),
        new JdeField("FDLITM", "FDLITM", JdeDataType.String, 50),
        new JdeField("FDAITM", "FDAITM", JdeDataType.String, 50),
        new JdeField("FDCITM", "FDCITM", JdeDataType.String, 50),
        new JdeField("FDMCU", "FDMCU", JdeDataType.String, 24),
        new JdeField("FDLOCN", "FDLOCN", JdeDataType.String, 40),
        new JdeField("FDLOTN", "FDLOTN", JdeDataType.String, 60),
        new JdeField("FDDSC1", "FDDSC1", JdeDataType.String, 60),
        new JdeField("FDDSC2", "FDDSC2", JdeDataType.String, 60),
        new JdeField("FDLNTY", "FDLNTY", JdeDataType.String, 4),
        new JdeField("FDUOM", "FDUOM", JdeDataType.String, 4),
        new JdeField("FDUORG", "FDUORG", JdeDataType.Numeric),
        new JdeField("FDUOM3", "FDUOM3", JdeDataType.String, 4),
        new JdeField("FDUOM4", "FDUOM4", JdeDataType.String, 4),
        new JdeField("FDUPRC", "FDUPRC", JdeDataType.Numeric),
        new JdeField("FDAEXP", "FDAEXP", JdeDataType.Numeric),
        new JdeField("FDBDES", "FDBDES", JdeDataType.Numeric),
        new JdeField("FDGLC", "FDGLC", JdeDataType.String, 8),
        new JdeField("FDSHAN", "FDSHAN", JdeDataType.Numeric),
        new JdeField("FDAN8", "FDAN8", JdeDataType.Numeric),
        new JdeField("FDBCGT", "FDBCGT", JdeDataType.String, 30),
        new JdeField("FDBCPT", "FDBCPT", JdeDataType.String, 22),
        new JdeField("FDSHST", "FDSHST", JdeDataType.String, 6),
        new JdeField("FDSHZP", "FDSHZP", JdeDataType.String, 24),
        new JdeField("FDBSFH", "FDBSFH", JdeDataType.Numeric),
        new JdeField("FDAN8V", "FDAN8V", JdeDataType.Numeric),
        new JdeField("FDBCGF", "FDBCGF", JdeDataType.String, 30),
        new JdeField("FDBCPF", "FDBCPF", JdeDataType.String, 22),
        new JdeField("FDADDS", "FDADDS", JdeDataType.String, 6),
        new JdeField("FDBNOP", "FDBNOP", JdeDataType.Numeric),
        new JdeField("FDBSOP", "FDBSOP", JdeDataType.String, 4),
        new JdeField("FDBDIP", "FDBDIP", JdeDataType.String, 8),
        new JdeField("FDBCLF", "FDBCLF", JdeDataType.String, 20),
        new JdeField("FDBCTF", "FDBCTF", JdeDataType.String, 4),
        new JdeField("FDBIST", "FDBIST", JdeDataType.String, 2),
        new JdeField("FDBORI", "FDBORI", JdeDataType.String, 2),
        new JdeField("FDBCFC", "FDBCFC", JdeDataType.String, 6),
        new JdeField("FDBSTT", "FDBSTT", JdeDataType.String, 4),
        new JdeField("FDBST1", "FDBST1", JdeDataType.String, 6),
        new JdeField("FDBFRT", "FDBFRT", JdeDataType.Numeric),
        new JdeField("FDBSEG", "FDBSEG", JdeDataType.Numeric),
        new JdeField("FDBDFN", "FDBDFN", JdeDataType.Numeric),
        new JdeField("FDBICM", "FDBICM", JdeDataType.Numeric),
        new JdeField("FDTXR1", "FDTXR1", JdeDataType.Numeric),
        new JdeField("FDBBCL", "FDBBCL", JdeDataType.Numeric),
        new JdeField("FDBBIR", "FDBBIR", JdeDataType.Numeric),
        new JdeField("FDBVIS", "FDBVIS", JdeDataType.Numeric),
        new JdeField("FDBBIS", "FDBBIS", JdeDataType.Numeric),
        new JdeField("FDBREP", "FDBREP", JdeDataType.Numeric),
        new JdeField("FDBDIZ", "FDBDIZ", JdeDataType.Numeric),
        new JdeField("FDBICP", "FDBICP", JdeDataType.Numeric),
        new JdeField("FDBFII", "FDBFII", JdeDataType.String, 2),
        new JdeField("FDBIPR", "FDBIPR", JdeDataType.Numeric),
        new JdeField("FDBIPI", "FDBIPI", JdeDataType.Numeric),
        new JdeField("FDTXR2", "FDTXR2", JdeDataType.Numeric),
        new JdeField("FDBBTP", "FDBBTP", JdeDataType.Numeric),
        new JdeField("FDBFIP", "FDBFIP", JdeDataType.String, 2),
        new JdeField("FDBISS", "FDBISS", JdeDataType.Numeric),
        new JdeField("FDTXR3", "FDTXR3", JdeDataType.Numeric),
        new JdeField("FDBBCS", "FDBBCS", JdeDataType.Numeric),
        new JdeField("FDBIRT", "FDBIRT", JdeDataType.Numeric),
        new JdeField("FDTXR4", "FDTXR4", JdeDataType.Numeric),
        new JdeField("FDBBCR", "FDBBCR", JdeDataType.Numeric),
        new JdeField("FDBIIT", "FDBIIT", JdeDataType.Numeric),
        new JdeField("FDTXR5", "FDTXR5", JdeDataType.Numeric),
        new JdeField("FDBBCI", "FDBBCI", JdeDataType.Numeric),
        new JdeField("FDANI", "FDANI", JdeDataType.String, 58),
        new JdeField("FDAID", "FDAID", JdeDataType.String, 16),
        new JdeField("FDOMCU", "FDOMCU", JdeDataType.String, 24),
        new JdeField("FDOBJ", "FDOBJ", JdeDataType.String, 12),
        new JdeField("FDSUB", "FDSUB", JdeDataType.String, 16),
        new JdeField("FDSBLT", "FDSBLT", JdeDataType.String, 2),
        new JdeField("FDSBL", "FDSBL", JdeDataType.String, 16),
        new JdeField("FDBINM", "FDBINM", JdeDataType.String, 20),
        new JdeField("FDISSU", "FDISSU", JdeDataType.Numeric),
        new JdeField("FDBNIV", "FDBNIV", JdeDataType.Numeric),
        new JdeField("FDPGNO", "FDPGNO", JdeDataType.Numeric),
        new JdeField("FDNXTR", "FDNXTR", JdeDataType.String, 6),
        new JdeField("FDLTTR", "FDLTTR", JdeDataType.String, 6),
        new JdeField("FDUSER", "FDUSER", JdeDataType.String, 20),
        new JdeField("FDPID", "FDPID", JdeDataType.String, 20),
        new JdeField("FDJOBN", "FDJOBN", JdeDataType.String, 20),
        new JdeField("FDUPMJ", "FDUPMJ", JdeDataType.Numeric),
        new JdeField("FDTDAY", "FDTDAY", JdeDataType.Numeric),
        new JdeField("FDCRCD", "FDCRCD", JdeDataType.String, 6),
        new JdeField("FDFTR", "FDFTR", JdeDataType.Numeric),
        new JdeField("FDF1T", "FDF1T", JdeDataType.String, 60),
        new JdeField("FDF2A", "FDF2A", JdeDataType.Numeric),
        new JdeField("FDF2T", "FDF2T", JdeDataType.String, 60),
        new JdeField("FDUSB1", "FDUSB1", JdeDataType.Numeric),
        new JdeField("FDFLD3", "FDFLD3", JdeDataType.String, 2),
        new JdeField("FDFLD4", "FDFLD4", JdeDataType.String, 2),
        new JdeField("FDPVAD", "FDPVAD", JdeDataType.String, 2),
        new JdeField("FDPVRATE", "FDPVRATE", JdeDataType.Numeric),
        new JdeField("FDPVAMT", "FDPVAMT", JdeDataType.Numeric),
        new JdeField("FDORRATE", "FDORRATE", JdeDataType.Numeric),
        new JdeField("FDORAMT", "FDORAMT", JdeDataType.Numeric),
        new JdeField("FDDSRATE", "FDDSRATE", JdeDataType.Numeric),
        new JdeField("FDDSAMT", "FDDSAMT", JdeDataType.Numeric),
        new JdeField("FDICDSTL", "FDICDSTL", JdeDataType.Numeric),
        new JdeField("FDDIFRATE", "FDDIFRATE", JdeDataType.Numeric),
        new JdeField("FDDSIC", "FDDSIC", JdeDataType.Numeric),
        new JdeField("FDAMTDS", "FDAMTDS", JdeDataType.Numeric),
        new JdeField("FDPVAMTST", "FDPVAMTST", JdeDataType.Numeric),
        new JdeField("FDB76ADRA1", "FDB76ADRA1", JdeDataType.String, 22),
        new JdeField("FDB76ADRA2", "FDB76ADRA2", JdeDataType.String, 22),
        new JdeField("FDIATR", "FDIATR", JdeDataType.Numeric),
        new JdeField("FDISMR", "FDISMR", JdeDataType.Numeric),
        new JdeField("FDTXRR2", "FDTXRR2", JdeDataType.Numeric),
        new JdeField("FDFNUMB4", "FDFNUMB4", JdeDataType.Numeric),
        new JdeField("FDFNUMB5", "FDFNUMB5", JdeDataType.Numeric),
        new JdeField("FDFNUMB6", "FDFNUMB6", JdeDataType.Numeric),
        new JdeField("FDFNUMB7", "FDFNUMB7", JdeDataType.Numeric),
        new JdeField("FDFSTRN4", "FDFSTRN4", JdeDataType.String, 50),
        new JdeField("FDFSTRN5", "FDFSTRN5", JdeDataType.String, 50),
        new JdeField("FDFSTRN6", "FDFSTRN6", JdeDataType.String, 50),
        new JdeField("FDFSTRN7", "FDFSTRN7", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7611B_0", "Primary Key on FDBNNF, FDBSER, FDN001, FDDCT, FDUKID", new[] { "FDBNNF", "FDBSER", "FDN001", "FDDCT", "FDUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7611B_2", "Index on FDMATC, FDDOCO, FDPDCT, FDKCOO, FDSFXO, FDLNID, FDNLIN", new[] { "FDMATC", "FDDOCO", "FDPDCT", "FDKCOO", "FDSFXO", "FDLNID", "FDNLIN" }),
        new JdeIndex("F7611B_3", "Index on FDMATC, FDDOCO, FDPDCT, FDKCOO, FDLNID, FDNLIN, FDDOC", new[] { "FDMATC", "FDDOCO", "FDPDCT", "FDKCOO", "FDLNID", "FDNLIN", "FDDOC" }),
        new JdeIndex("F7611B_4", "Index on FDKCOO, FDBNNF, FDBSER, FDDOCO, FDPDCT, FDLNID", new[] { "FDKCOO", "FDBNNF", "FDBSER", "FDDOCO", "FDPDCT", "FDLNID" }),
        new JdeIndex("F7611B_5", "Index on FDKCOO, FDDOC, FDDCTO", new[] { "FDKCOO", "FDDOC", "FDDCTO" }),
        new JdeIndex("F7611B_6", "Index on FDBNNF, FDBSER, FDN001, FDDCT, SYS_NC00140$", new[] { "FDBNNF", "FDBSER", "FDN001", "FDDCT", "SYS_NC00140$" })
    };
}
