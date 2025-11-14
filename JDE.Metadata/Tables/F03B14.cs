using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B14 - .
/// </summary>
public class F03B14 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RZPYID.
        /// </summary>
        public const string RZPYID = "RZPYID";

        /// <summary>
        /// RZRC5.
        /// </summary>
        public const string RZRC5 = "RZRC5";

        /// <summary>
        /// RZCKNU.
        /// </summary>
        public const string RZCKNU = "RZCKNU";

        /// <summary>
        /// RZDOC.
        /// </summary>
        public const string RZDOC = "RZDOC";

        /// <summary>
        /// RZDCT.
        /// </summary>
        public const string RZDCT = "RZDCT";

        /// <summary>
        /// RZKCO.
        /// </summary>
        public const string RZKCO = "RZKCO";

        /// <summary>
        /// RZSFX.
        /// </summary>
        public const string RZSFX = "RZSFX";

        /// <summary>
        /// RZAN8.
        /// </summary>
        public const string RZAN8 = "RZAN8";

        /// <summary>
        /// RZDCTM.
        /// </summary>
        public const string RZDCTM = "RZDCTM";

        /// <summary>
        /// RZDMTJ.
        /// </summary>
        public const string RZDMTJ = "RZDMTJ";

        /// <summary>
        /// RZDGJ.
        /// </summary>
        public const string RZDGJ = "RZDGJ";

        /// <summary>
        /// RZPOST.
        /// </summary>
        public const string RZPOST = "RZPOST";

        /// <summary>
        /// RZGLC.
        /// </summary>
        public const string RZGLC = "RZGLC";

        /// <summary>
        /// RZAID.
        /// </summary>
        public const string RZAID = "RZAID";

        /// <summary>
        /// RZCTRY.
        /// </summary>
        public const string RZCTRY = "RZCTRY";

        /// <summary>
        /// RZFY.
        /// </summary>
        public const string RZFY = "RZFY";

        /// <summary>
        /// RZPN.
        /// </summary>
        public const string RZPN = "RZPN";

        /// <summary>
        /// RZCO.
        /// </summary>
        public const string RZCO = "RZCO";

        /// <summary>
        /// RZICUT.
        /// </summary>
        public const string RZICUT = "RZICUT";

        /// <summary>
        /// RZICU.
        /// </summary>
        public const string RZICU = "RZICU";

        /// <summary>
        /// RZDICJ.
        /// </summary>
        public const string RZDICJ = "RZDICJ";

        /// <summary>
        /// RZPA8.
        /// </summary>
        public const string RZPA8 = "RZPA8";

        /// <summary>
        /// RZRPID.
        /// </summary>
        public const string RZRPID = "RZRPID";

        /// <summary>
        /// RZRLIN.
        /// </summary>
        public const string RZRLIN = "RZRLIN";

        /// <summary>
        /// RZPAAP.
        /// </summary>
        public const string RZPAAP = "RZPAAP";

        /// <summary>
        /// RZADSC.
        /// </summary>
        public const string RZADSC = "RZADSC";

        /// <summary>
        /// RZADSA.
        /// </summary>
        public const string RZADSA = "RZADSA";

        /// <summary>
        /// RZAAAJ.
        /// </summary>
        public const string RZAAAJ = "RZAAAJ";

        /// <summary>
        /// RZECBA.
        /// </summary>
        public const string RZECBA = "RZECBA";

        /// <summary>
        /// RZDDA.
        /// </summary>
        public const string RZDDA = "RZDDA";

        /// <summary>
        /// RZBCRC.
        /// </summary>
        public const string RZBCRC = "RZBCRC";

        /// <summary>
        /// RZCRRM.
        /// </summary>
        public const string RZCRRM = "RZCRRM";

        /// <summary>
        /// RZCRCD.
        /// </summary>
        public const string RZCRCD = "RZCRCD";

        /// <summary>
        /// RZCRR.
        /// </summary>
        public const string RZCRR = "RZCRR";

        /// <summary>
        /// RZPFAP.
        /// </summary>
        public const string RZPFAP = "RZPFAP";

        /// <summary>
        /// RZCDS.
        /// </summary>
        public const string RZCDS = "RZCDS";

        /// <summary>
        /// RZCDSA.
        /// </summary>
        public const string RZCDSA = "RZCDSA";

        /// <summary>
        /// RZFCHG.
        /// </summary>
        public const string RZFCHG = "RZFCHG";

        /// <summary>
        /// RZECBF.
        /// </summary>
        public const string RZECBF = "RZECBF";

        /// <summary>
        /// RZFDA.
        /// </summary>
        public const string RZFDA = "RZFDA";

        /// <summary>
        /// RZAGL.
        /// </summary>
        public const string RZAGL = "RZAGL";

        /// <summary>
        /// RZAIDT.
        /// </summary>
        public const string RZAIDT = "RZAIDT";

        /// <summary>
        /// RZTCRC.
        /// </summary>
        public const string RZTCRC = "RZTCRC";

        /// <summary>
        /// RZTAAP.
        /// </summary>
        public const string RZTAAP = "RZTAAP";

        /// <summary>
        /// RZTADA.
        /// </summary>
        public const string RZTADA = "RZTADA";

        /// <summary>
        /// RZTAAJ.
        /// </summary>
        public const string RZTAAJ = "RZTAAJ";

        /// <summary>
        /// RZTCBA.
        /// </summary>
        public const string RZTCBA = "RZTCBA";

        /// <summary>
        /// RZTDA.
        /// </summary>
        public const string RZTDA = "RZTDA";

        /// <summary>
        /// RZACRR.
        /// </summary>
        public const string RZACRR = "RZACRR";

        /// <summary>
        /// RZACR1.
        /// </summary>
        public const string RZACR1 = "RZACR1";

        /// <summary>
        /// RZACR2.
        /// </summary>
        public const string RZACR2 = "RZACR2";

        /// <summary>
        /// RZACRM.
        /// </summary>
        public const string RZACRM = "RZACRM";

        /// <summary>
        /// RZAGLA.
        /// </summary>
        public const string RZAGLA = "RZAGLA";

        /// <summary>
        /// RZAIDA.
        /// </summary>
        public const string RZAIDA = "RZAIDA";

        /// <summary>
        /// RZAIDD.
        /// </summary>
        public const string RZAIDD = "RZAIDD";

        /// <summary>
        /// RZRSCO.
        /// </summary>
        public const string RZRSCO = "RZRSCO";

        /// <summary>
        /// RZAIDW.
        /// </summary>
        public const string RZAIDW = "RZAIDW";

        /// <summary>
        /// RZECBR.
        /// </summary>
        public const string RZECBR = "RZECBR";

        /// <summary>
        /// RZGLCC.
        /// </summary>
        public const string RZGLCC = "RZGLCC";

        /// <summary>
        /// RZAIDC.
        /// </summary>
        public const string RZAIDC = "RZAIDC";

        /// <summary>
        /// RZDDEX.
        /// </summary>
        public const string RZDDEX = "RZDDEX";

        /// <summary>
        /// RZDAID.
        /// </summary>
        public const string RZDAID = "RZDAID";

        /// <summary>
        /// RZTYIN.
        /// </summary>
        public const string RZTYIN = "RZTYIN";

        /// <summary>
        /// RZUTIC.
        /// </summary>
        public const string RZUTIC = "RZUTIC";

        /// <summary>
        /// RZUCTF.
        /// </summary>
        public const string RZUCTF = "RZUCTF";

        /// <summary>
        /// RZAID2.
        /// </summary>
        public const string RZAID2 = "RZAID2";

        /// <summary>
        /// RZAM2.
        /// </summary>
        public const string RZAM2 = "RZAM2";

        /// <summary>
        /// RZMCU.
        /// </summary>
        public const string RZMCU = "RZMCU";

        /// <summary>
        /// RZSBL.
        /// </summary>
        public const string RZSBL = "RZSBL";

        /// <summary>
        /// RZSBLT.
        /// </summary>
        public const string RZSBLT = "RZSBLT";

        /// <summary>
        /// RZPKCO.
        /// </summary>
        public const string RZPKCO = "RZPKCO";

        /// <summary>
        /// RZPO.
        /// </summary>
        public const string RZPO = "RZPO";

        /// <summary>
        /// RZPDCT.
        /// </summary>
        public const string RZPDCT = "RZPDCT";

        /// <summary>
        /// RZNUMB.
        /// </summary>
        public const string RZNUMB = "RZNUMB";

        /// <summary>
        /// RZUNIT.
        /// </summary>
        public const string RZUNIT = "RZUNIT";

        /// <summary>
        /// RZMCU2.
        /// </summary>
        public const string RZMCU2 = "RZMCU2";

        /// <summary>
        /// RZRMK.
        /// </summary>
        public const string RZRMK = "RZRMK";

        /// <summary>
        /// RZFNLP.
        /// </summary>
        public const string RZFNLP = "RZFNLP";

        /// <summary>
        /// RZALT6.
        /// </summary>
        public const string RZALT6 = "RZALT6";

        /// <summary>
        /// RZODOC.
        /// </summary>
        public const string RZODOC = "RZODOC";

        /// <summary>
        /// RZODCT.
        /// </summary>
        public const string RZODCT = "RZODCT";

        /// <summary>
        /// RZOKCO.
        /// </summary>
        public const string RZOKCO = "RZOKCO";

        /// <summary>
        /// RZOSFX.
        /// </summary>
        public const string RZOSFX = "RZOSFX";

        /// <summary>
        /// RZGDOC.
        /// </summary>
        public const string RZGDOC = "RZGDOC";

        /// <summary>
        /// RZGDCT.
        /// </summary>
        public const string RZGDCT = "RZGDCT";

        /// <summary>
        /// RZGKCO.
        /// </summary>
        public const string RZGKCO = "RZGKCO";

        /// <summary>
        /// RZGSFX.
        /// </summary>
        public const string RZGSFX = "RZGSFX";

        /// <summary>
        /// RZDCTG.
        /// </summary>
        public const string RZDCTG = "RZDCTG";

        /// <summary>
        /// RZDOCG.
        /// </summary>
        public const string RZDOCG = "RZDOCG";

        /// <summary>
        /// RZKCOG.
        /// </summary>
        public const string RZKCOG = "RZKCOG";

        /// <summary>
        /// RZCTL.
        /// </summary>
        public const string RZCTL = "RZCTL";

        /// <summary>
        /// RZSMTJ.
        /// </summary>
        public const string RZSMTJ = "RZSMTJ";

        /// <summary>
        /// RZVDGJ.
        /// </summary>
        public const string RZVDGJ = "RZVDGJ";

        /// <summary>
        /// RZVRE.
        /// </summary>
        public const string RZVRE = "RZVRE";

        /// <summary>
        /// RZNFVD.
        /// </summary>
        public const string RZNFVD = "RZNFVD";

        /// <summary>
        /// RZHCRR.
        /// </summary>
        public const string RZHCRR = "RZHCRR";

        /// <summary>
        /// RZISTC.
        /// </summary>
        public const string RZISTC = "RZISTC";

        /// <summary>
        /// RZLFCJ.
        /// </summary>
        public const string RZLFCJ = "RZLFCJ";

        /// <summary>
        /// RZPDLT.
        /// </summary>
        public const string RZPDLT = "RZPDLT";

        /// <summary>
        /// RZDDJ.
        /// </summary>
        public const string RZDDJ = "RZDDJ";

        /// <summary>
        /// RZDDNJ.
        /// </summary>
        public const string RZDDNJ = "RZDDNJ";

        /// <summary>
        /// RZIDGJ.
        /// </summary>
        public const string RZIDGJ = "RZIDGJ";

        /// <summary>
        /// RZDDST.
        /// </summary>
        public const string RZDDST = "RZDDST";

        /// <summary>
        /// RZVR01.
        /// </summary>
        public const string RZVR01 = "RZVR01";

        /// <summary>
        /// RZRFID.
        /// </summary>
        public const string RZRFID = "RZRFID";

        /// <summary>
        /// RZRIDC.
        /// </summary>
        public const string RZRIDC = "RZRIDC";

        /// <summary>
        /// RZPRGF.
        /// </summary>
        public const string RZPRGF = "RZPRGF";

        /// <summary>
        /// RZGFL1.
        /// </summary>
        public const string RZGFL1 = "RZGFL1";

        /// <summary>
        /// RZRNID.
        /// </summary>
        public const string RZRNID = "RZRNID";

        /// <summary>
        /// RZTORG.
        /// </summary>
        public const string RZTORG = "RZTORG";

        /// <summary>
        /// RZUSER.
        /// </summary>
        public const string RZUSER = "RZUSER";

        /// <summary>
        /// RZPID.
        /// </summary>
        public const string RZPID = "RZPID";

        /// <summary>
        /// RZUPMJ.
        /// </summary>
        public const string RZUPMJ = "RZUPMJ";

        /// <summary>
        /// RZUPMT.
        /// </summary>
        public const string RZUPMT = "RZUPMT";

        /// <summary>
        /// RZJOBN.
        /// </summary>
        public const string RZJOBN = "RZJOBN";

        /// <summary>
        /// RZURAB.
        /// </summary>
        public const string RZURAB = "RZURAB";

        /// <summary>
        /// RZURAT.
        /// </summary>
        public const string RZURAT = "RZURAT";

        /// <summary>
        /// RZURC1.
        /// </summary>
        public const string RZURC1 = "RZURC1";

        /// <summary>
        /// RZURDT.
        /// </summary>
        public const string RZURDT = "RZURDT";

        /// <summary>
        /// RZURRF.
        /// </summary>
        public const string RZURRF = "RZURRF";

        /// <summary>
        /// RZSHPN.
        /// </summary>
        public const string RZSHPN = "RZSHPN";

        /// <summary>
        /// RZOMOD.
        /// </summary>
        public const string RZOMOD = "RZOMOD";

        /// <summary>
        /// RZDOCO.
        /// </summary>
        public const string RZDOCO = "RZDOCO";

        /// <summary>
        /// RZRASI.
        /// </summary>
        public const string RZRASI = "RZRASI";

        /// <summary>
        /// RZSFXO.
        /// </summary>
        public const string RZSFXO = "RZSFXO";

        /// <summary>
        /// RZKCOO.
        /// </summary>
        public const string RZKCOO = "RZKCOO";

        /// <summary>
        /// RZDCTO.
        /// </summary>
        public const string RZDCTO = "RZDCTO";

        /// <summary>
        /// RZRAMT.
        /// </summary>
        public const string RZRAMT = "RZRAMT";

        /// <summary>
        /// RZLRFL.
        /// </summary>
        public const string RZLRFL = "RZLRFL";

        /// <summary>
        /// RZGFL2.
        /// </summary>
        public const string RZGFL2 = "RZGFL2";

        /// <summary>
        /// RZDRCO.
        /// </summary>
        public const string RZDRCO = "RZDRCO";

        /// <summary>
        /// RZNETTCID.
        /// </summary>
        public const string RZNETTCID = "RZNETTCID";

        /// <summary>
        /// RZNETDOC.
        /// </summary>
        public const string RZNETDOC = "RZNETDOC";

        /// <summary>
        /// RZNETRC5.
        /// </summary>
        public const string RZNETRC5 = "RZNETRC5";

        /// <summary>
        /// RZADGJ.
        /// </summary>
        public const string RZADGJ = "RZADGJ";
    }

    /// <inheritdoc />
    public override string TableName => "F03B14";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RZPYID", "RZPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RZRC5", "RZRC5", JdeDataType.Numeric, null, true, true),
        new JdeField("RZCKNU", "RZCKNU", JdeDataType.String, 50),
        new JdeField("RZDOC", "RZDOC", JdeDataType.Numeric),
        new JdeField("RZDCT", "RZDCT", JdeDataType.String, 4),
        new JdeField("RZKCO", "RZKCO", JdeDataType.String, 10),
        new JdeField("RZSFX", "RZSFX", JdeDataType.String, 6),
        new JdeField("RZAN8", "RZAN8", JdeDataType.Numeric),
        new JdeField("RZDCTM", "RZDCTM", JdeDataType.String, 4),
        new JdeField("RZDMTJ", "RZDMTJ", JdeDataType.Numeric),
        new JdeField("RZDGJ", "RZDGJ", JdeDataType.Numeric),
        new JdeField("RZPOST", "RZPOST", JdeDataType.String, 2),
        new JdeField("RZGLC", "RZGLC", JdeDataType.String, 8),
        new JdeField("RZAID", "RZAID", JdeDataType.String, 16),
        new JdeField("RZCTRY", "RZCTRY", JdeDataType.Numeric),
        new JdeField("RZFY", "RZFY", JdeDataType.Numeric),
        new JdeField("RZPN", "RZPN", JdeDataType.Numeric),
        new JdeField("RZCO", "RZCO", JdeDataType.String, 10),
        new JdeField("RZICUT", "RZICUT", JdeDataType.String, 4),
        new JdeField("RZICU", "RZICU", JdeDataType.Numeric),
        new JdeField("RZDICJ", "RZDICJ", JdeDataType.Numeric),
        new JdeField("RZPA8", "RZPA8", JdeDataType.Numeric),
        new JdeField("RZRPID", "RZRPID", JdeDataType.Numeric),
        new JdeField("RZRLIN", "RZRLIN", JdeDataType.Numeric),
        new JdeField("RZPAAP", "RZPAAP", JdeDataType.Numeric),
        new JdeField("RZADSC", "RZADSC", JdeDataType.Numeric),
        new JdeField("RZADSA", "RZADSA", JdeDataType.Numeric),
        new JdeField("RZAAAJ", "RZAAAJ", JdeDataType.Numeric),
        new JdeField("RZECBA", "RZECBA", JdeDataType.Numeric),
        new JdeField("RZDDA", "RZDDA", JdeDataType.Numeric),
        new JdeField("RZBCRC", "RZBCRC", JdeDataType.String, 6),
        new JdeField("RZCRRM", "RZCRRM", JdeDataType.String, 2),
        new JdeField("RZCRCD", "RZCRCD", JdeDataType.String, 6),
        new JdeField("RZCRR", "RZCRR", JdeDataType.Numeric),
        new JdeField("RZPFAP", "RZPFAP", JdeDataType.Numeric),
        new JdeField("RZCDS", "RZCDS", JdeDataType.Numeric),
        new JdeField("RZCDSA", "RZCDSA", JdeDataType.Numeric),
        new JdeField("RZFCHG", "RZFCHG", JdeDataType.Numeric),
        new JdeField("RZECBF", "RZECBF", JdeDataType.Numeric),
        new JdeField("RZFDA", "RZFDA", JdeDataType.Numeric),
        new JdeField("RZAGL", "RZAGL", JdeDataType.Numeric),
        new JdeField("RZAIDT", "RZAIDT", JdeDataType.String, 16),
        new JdeField("RZTCRC", "RZTCRC", JdeDataType.String, 6),
        new JdeField("RZTAAP", "RZTAAP", JdeDataType.Numeric),
        new JdeField("RZTADA", "RZTADA", JdeDataType.Numeric),
        new JdeField("RZTAAJ", "RZTAAJ", JdeDataType.Numeric),
        new JdeField("RZTCBA", "RZTCBA", JdeDataType.Numeric),
        new JdeField("RZTDA", "RZTDA", JdeDataType.Numeric),
        new JdeField("RZACRR", "RZACRR", JdeDataType.Numeric),
        new JdeField("RZACR1", "RZACR1", JdeDataType.Numeric),
        new JdeField("RZACR2", "RZACR2", JdeDataType.Numeric),
        new JdeField("RZACRM", "RZACRM", JdeDataType.String, 2),
        new JdeField("RZAGLA", "RZAGLA", JdeDataType.Numeric),
        new JdeField("RZAIDA", "RZAIDA", JdeDataType.String, 16),
        new JdeField("RZAIDD", "RZAIDD", JdeDataType.String, 16),
        new JdeField("RZRSCO", "RZRSCO", JdeDataType.String, 4),
        new JdeField("RZAIDW", "RZAIDW", JdeDataType.String, 16),
        new JdeField("RZECBR", "RZECBR", JdeDataType.String, 4),
        new JdeField("RZGLCC", "RZGLCC", JdeDataType.String, 8),
        new JdeField("RZAIDC", "RZAIDC", JdeDataType.String, 16),
        new JdeField("RZDDEX", "RZDDEX", JdeDataType.String, 4),
        new JdeField("RZDAID", "RZDAID", JdeDataType.String, 16),
        new JdeField("RZTYIN", "RZTYIN", JdeDataType.String, 2),
        new JdeField("RZUTIC", "RZUTIC", JdeDataType.String, 4),
        new JdeField("RZUCTF", "RZUCTF", JdeDataType.String, 2),
        new JdeField("RZAID2", "RZAID2", JdeDataType.String, 16),
        new JdeField("RZAM2", "RZAM2", JdeDataType.String, 2),
        new JdeField("RZMCU", "RZMCU", JdeDataType.String, 24),
        new JdeField("RZSBL", "RZSBL", JdeDataType.String, 16),
        new JdeField("RZSBLT", "RZSBLT", JdeDataType.String, 2),
        new JdeField("RZPKCO", "RZPKCO", JdeDataType.String, 10),
        new JdeField("RZPO", "RZPO", JdeDataType.String, 16),
        new JdeField("RZPDCT", "RZPDCT", JdeDataType.String, 4),
        new JdeField("RZNUMB", "RZNUMB", JdeDataType.Numeric),
        new JdeField("RZUNIT", "RZUNIT", JdeDataType.String, 16),
        new JdeField("RZMCU2", "RZMCU2", JdeDataType.String, 24),
        new JdeField("RZRMK", "RZRMK", JdeDataType.String, 60),
        new JdeField("RZFNLP", "RZFNLP", JdeDataType.String, 2),
        new JdeField("RZALT6", "RZALT6", JdeDataType.String, 2),
        new JdeField("RZODOC", "RZODOC", JdeDataType.Numeric),
        new JdeField("RZODCT", "RZODCT", JdeDataType.String, 4),
        new JdeField("RZOKCO", "RZOKCO", JdeDataType.String, 10),
        new JdeField("RZOSFX", "RZOSFX", JdeDataType.String, 6),
        new JdeField("RZGDOC", "RZGDOC", JdeDataType.Numeric),
        new JdeField("RZGDCT", "RZGDCT", JdeDataType.String, 4),
        new JdeField("RZGKCO", "RZGKCO", JdeDataType.String, 10),
        new JdeField("RZGSFX", "RZGSFX", JdeDataType.String, 6),
        new JdeField("RZDCTG", "RZDCTG", JdeDataType.String, 4),
        new JdeField("RZDOCG", "RZDOCG", JdeDataType.Numeric),
        new JdeField("RZKCOG", "RZKCOG", JdeDataType.String, 10),
        new JdeField("RZCTL", "RZCTL", JdeDataType.String, 26),
        new JdeField("RZSMTJ", "RZSMTJ", JdeDataType.Numeric),
        new JdeField("RZVDGJ", "RZVDGJ", JdeDataType.Numeric),
        new JdeField("RZVRE", "RZVRE", JdeDataType.String, 6),
        new JdeField("RZNFVD", "RZNFVD", JdeDataType.String, 2),
        new JdeField("RZHCRR", "RZHCRR", JdeDataType.Numeric),
        new JdeField("RZISTC", "RZISTC", JdeDataType.String, 2),
        new JdeField("RZLFCJ", "RZLFCJ", JdeDataType.Numeric),
        new JdeField("RZPDLT", "RZPDLT", JdeDataType.String, 2),
        new JdeField("RZDDJ", "RZDDJ", JdeDataType.Numeric),
        new JdeField("RZDDNJ", "RZDDNJ", JdeDataType.Numeric),
        new JdeField("RZIDGJ", "RZIDGJ", JdeDataType.Numeric),
        new JdeField("RZDDST", "RZDDST", JdeDataType.String, 2),
        new JdeField("RZVR01", "RZVR01", JdeDataType.String, 50),
        new JdeField("RZRFID", "RZRFID", JdeDataType.Numeric),
        new JdeField("RZRIDC", "RZRIDC", JdeDataType.String, 2),
        new JdeField("RZPRGF", "RZPRGF", JdeDataType.String, 2),
        new JdeField("RZGFL1", "RZGFL1", JdeDataType.String, 2),
        new JdeField("RZRNID", "RZRNID", JdeDataType.Numeric),
        new JdeField("RZTORG", "RZTORG", JdeDataType.String, 20),
        new JdeField("RZUSER", "RZUSER", JdeDataType.String, 20),
        new JdeField("RZPID", "RZPID", JdeDataType.String, 20),
        new JdeField("RZUPMJ", "RZUPMJ", JdeDataType.Numeric),
        new JdeField("RZUPMT", "RZUPMT", JdeDataType.Numeric),
        new JdeField("RZJOBN", "RZJOBN", JdeDataType.String, 20),
        new JdeField("RZURAB", "RZURAB", JdeDataType.Numeric),
        new JdeField("RZURAT", "RZURAT", JdeDataType.Numeric),
        new JdeField("RZURC1", "RZURC1", JdeDataType.String, 6),
        new JdeField("RZURDT", "RZURDT", JdeDataType.Numeric),
        new JdeField("RZURRF", "RZURRF", JdeDataType.String, 30),
        new JdeField("RZSHPN", "RZSHPN", JdeDataType.Numeric),
        new JdeField("RZOMOD", "RZOMOD", JdeDataType.String, 2),
        new JdeField("RZDOCO", "RZDOCO", JdeDataType.Numeric),
        new JdeField("RZRASI", "RZRASI", JdeDataType.String, 16),
        new JdeField("RZSFXO", "RZSFXO", JdeDataType.String, 6),
        new JdeField("RZKCOO", "RZKCOO", JdeDataType.String, 10),
        new JdeField("RZDCTO", "RZDCTO", JdeDataType.String, 4),
        new JdeField("RZRAMT", "RZRAMT", JdeDataType.Numeric),
        new JdeField("RZLRFL", "RZLRFL", JdeDataType.String, 2),
        new JdeField("RZGFL2", "RZGFL2", JdeDataType.String, 2),
        new JdeField("RZDRCO", "RZDRCO", JdeDataType.String, 6),
        new JdeField("RZNETTCID", "RZNETTCID", JdeDataType.Numeric),
        new JdeField("RZNETDOC", "RZNETDOC", JdeDataType.Numeric),
        new JdeField("RZNETRC5", "RZNETRC5", JdeDataType.Numeric),
        new JdeField("RZADGJ", "RZADGJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B14_0", "Primary Key on RZPYID, RZRC5", new[] { "RZPYID", "RZRC5" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B14_10", "Index on RZAN8, RZDGJ, RZDCT, RZDOC, RZKCO, RZSFX", new[] { "RZAN8", "RZDGJ", "RZDCT", "RZDOC", "RZKCO", "RZSFX" }),
        new JdeIndex("F03B14_11", "Index on RZDGJ, RZCO", new[] { "RZDGJ", "RZCO" }),
        new JdeIndex("F03B14_12", "Index on RZAN8, RZCO, RZDGJ, RZDICJ, RZRC5", new[] { "RZAN8", "RZCO", "RZDGJ", "RZDICJ", "RZRC5" }),
        new JdeIndex("F03B14_13", "Index on RZCTL, RZCRCD, RZPYID", new[] { "RZCTL", "RZCRCD", "RZPYID" }),
        new JdeIndex("F03B14_14", "Index on RZNETTCID, RZNETDOC, RZNETRC5", new[] { "RZNETTCID", "RZNETDOC", "RZNETRC5" }),
        new JdeIndex("F03B14_15", "Index on RZNETTCID, RZNETDOC, RZNETRC5, RZVRE", new[] { "RZNETTCID", "RZNETDOC", "RZNETRC5", "RZVRE" }),
        new JdeIndex("F03B14_16", "Index on RZGDOC, RZGDCT, RZGKCO, RZGSFX", new[] { "RZGDOC", "RZGDCT", "RZGKCO", "RZGSFX" }),
        new JdeIndex("F03B14_17", "Index on RZDOCG, RZICUT, RZICU, RZSFX, RZRC5, RZVDGJ", new[] { "RZDOCG", "RZICUT", "RZICU", "RZSFX", "RZRC5", "RZVDGJ" }),
        new JdeIndex("F03B14_2", "Index on RZPYID, RZPOST", new[] { "RZPYID", "RZPOST" }),
        new JdeIndex("F03B14_3", "Index on RZDOC, RZDCT, RZKCO, RZSFX, RZPYID, RZRC5", new[] { "RZDOC", "RZDCT", "RZKCO", "RZSFX", "RZPYID", "RZRC5" }),
        new JdeIndex("F03B14_4", "Index on RZICU, RZICUT, RZPOST, RZRPID, RZRLIN", new[] { "RZICU", "RZICUT", "RZPOST", "RZRPID", "RZRLIN" }),
        new JdeIndex("F03B14_5", "Index on RZAN8, RZCO", new[] { "RZAN8", "RZCO" }),
        new JdeIndex("F03B14_6", "Index on RZDOC, RZDCT, RZKCO, RZSFX, RZTCRC, RZPYID, RZRC5", new[] { "RZDOC", "RZDCT", "RZKCO", "RZSFX", "RZTCRC", "RZPYID", "RZRC5" }),
        new JdeIndex("F03B14_7", "Index on RZPYID, SYS_NC00136$", new[] { "RZPYID", "SYS_NC00136$" }),
        new JdeIndex("F03B14_8", "Index on RZPO, RZGLC, RZDGJ", new[] { "RZPO", "RZGLC", "RZDGJ" }),
        new JdeIndex("F03B14_9", "Index on RZAN8, RZCKNU, RZDCT, RZDOC, RZKCO, RZSFX", new[] { "RZAN8", "RZCKNU", "RZDCT", "RZDOC", "RZKCO", "RZSFX" })
    };
}
