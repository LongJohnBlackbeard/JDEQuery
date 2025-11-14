using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1201Z1 - .
/// </summary>
public class F1201Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FAEDUS.
        /// </summary>
        public const string FAEDUS = "FAEDUS";

        /// <summary>
        /// FAEDBT.
        /// </summary>
        public const string FAEDBT = "FAEDBT";

        /// <summary>
        /// FAEDTN.
        /// </summary>
        public const string FAEDTN = "FAEDTN";

        /// <summary>
        /// FAEDLN.
        /// </summary>
        public const string FAEDLN = "FAEDLN";

        /// <summary>
        /// FAEDCT.
        /// </summary>
        public const string FAEDCT = "FAEDCT";

        /// <summary>
        /// FATYTN.
        /// </summary>
        public const string FATYTN = "FATYTN";

        /// <summary>
        /// FAEDFT.
        /// </summary>
        public const string FAEDFT = "FAEDFT";

        /// <summary>
        /// FAEDDT.
        /// </summary>
        public const string FAEDDT = "FAEDDT";

        /// <summary>
        /// FADRIN.
        /// </summary>
        public const string FADRIN = "FADRIN";

        /// <summary>
        /// FAEDDL.
        /// </summary>
        public const string FAEDDL = "FAEDDL";

        /// <summary>
        /// FAEDSP.
        /// </summary>
        public const string FAEDSP = "FAEDSP";

        /// <summary>
        /// FAPNID.
        /// </summary>
        public const string FAPNID = "FAPNID";

        /// <summary>
        /// FATNAC.
        /// </summary>
        public const string FATNAC = "FATNAC";

        /// <summary>
        /// FACO.
        /// </summary>
        public const string FACO = "FACO";

        /// <summary>
        /// FANUMB.
        /// </summary>
        public const string FANUMB = "FANUMB";

        /// <summary>
        /// FAAPID.
        /// </summary>
        public const string FAAPID = "FAAPID";

        /// <summary>
        /// FAAAID.
        /// </summary>
        public const string FAAAID = "FAAAID";

        /// <summary>
        /// FAASID.
        /// </summary>
        public const string FAASID = "FAASID";

        /// <summary>
        /// FASEQ.
        /// </summary>
        public const string FASEQ = "FASEQ";

        /// <summary>
        /// FAACL1.
        /// </summary>
        public const string FAACL1 = "FAACL1";

        /// <summary>
        /// FAACL2.
        /// </summary>
        public const string FAACL2 = "FAACL2";

        /// <summary>
        /// FAACL3.
        /// </summary>
        public const string FAACL3 = "FAACL3";

        /// <summary>
        /// FAACL4.
        /// </summary>
        public const string FAACL4 = "FAACL4";

        /// <summary>
        /// FAACL5.
        /// </summary>
        public const string FAACL5 = "FAACL5";

        /// <summary>
        /// FAMCU.
        /// </summary>
        public const string FAMCU = "FAMCU";

        /// <summary>
        /// FADL01.
        /// </summary>
        public const string FADL01 = "FADL01";

        /// <summary>
        /// FADL02.
        /// </summary>
        public const string FADL02 = "FADL02";

        /// <summary>
        /// FADL03.
        /// </summary>
        public const string FADL03 = "FADL03";

        /// <summary>
        /// FADSCC.
        /// </summary>
        public const string FADSCC = "FADSCC";

        /// <summary>
        /// FADAJ.
        /// </summary>
        public const string FADAJ = "FADAJ";

        /// <summary>
        /// FADSP.
        /// </summary>
        public const string FADSP = "FADSP";

        /// <summary>
        /// FAEQST.
        /// </summary>
        public const string FAEQST = "FAEQST";

        /// <summary>
        /// FANORU.
        /// </summary>
        public const string FANORU = "FANORU";

        /// <summary>
        /// FAAESV.
        /// </summary>
        public const string FAAESV = "FAAESV";

        /// <summary>
        /// FAARPC.
        /// </summary>
        public const string FAARPC = "FAARPC";

        /// <summary>
        /// FAALRC.
        /// </summary>
        public const string FAALRC = "FAALRC";

        /// <summary>
        /// FAAMCU.
        /// </summary>
        public const string FAAMCU = "FAAMCU";

        /// <summary>
        /// FAAOBJ.
        /// </summary>
        public const string FAAOBJ = "FAAOBJ";

        /// <summary>
        /// FAASUB.
        /// </summary>
        public const string FAASUB = "FAASUB";

        /// <summary>
        /// FADMCU.
        /// </summary>
        public const string FADMCU = "FADMCU";

        /// <summary>
        /// FADOBJ.
        /// </summary>
        public const string FADOBJ = "FADOBJ";

        /// <summary>
        /// FADSUB.
        /// </summary>
        public const string FADSUB = "FADSUB";

        /// <summary>
        /// FAXMCU.
        /// </summary>
        public const string FAXMCU = "FAXMCU";

        /// <summary>
        /// FAXOBJ.
        /// </summary>
        public const string FAXOBJ = "FAXOBJ";

        /// <summary>
        /// FAXSUB.
        /// </summary>
        public const string FAXSUB = "FAXSUB";

        /// <summary>
        /// FARMCU.
        /// </summary>
        public const string FARMCU = "FARMCU";

        /// <summary>
        /// FAROBJ.
        /// </summary>
        public const string FAROBJ = "FAROBJ";

        /// <summary>
        /// FARSUB.
        /// </summary>
        public const string FARSUB = "FARSUB";

        /// <summary>
        /// FAARCQ.
        /// </summary>
        public const string FAARCQ = "FAARCQ";

        /// <summary>
        /// FAAROQ.
        /// </summary>
        public const string FAAROQ = "FAAROQ";

        /// <summary>
        /// FATXJS.
        /// </summary>
        public const string FATXJS = "FATXJS";

        /// <summary>
        /// FAAITY.
        /// </summary>
        public const string FAAITY = "FAAITY";

        /// <summary>
        /// FAAITP.
        /// </summary>
        public const string FAAITP = "FAAITP";

        /// <summary>
        /// FAFINC.
        /// </summary>
        public const string FAFINC = "FAFINC";

        /// <summary>
        /// FAITCO.
        /// </summary>
        public const string FAITCO = "FAITCO";

        /// <summary>
        /// FAPURO.
        /// </summary>
        public const string FAPURO = "FAPURO";

        /// <summary>
        /// FAAPUR.
        /// </summary>
        public const string FAAPUR = "FAAPUR";

        /// <summary>
        /// FAPURP.
        /// </summary>
        public const string FAPURP = "FAPURP";

        /// <summary>
        /// FAAPOM.
        /// </summary>
        public const string FAAPOM = "FAAPOM";

        /// <summary>
        /// FALANO.
        /// </summary>
        public const string FALANO = "FALANO";

        /// <summary>
        /// FAJCD.
        /// </summary>
        public const string FAJCD = "FAJCD";

        /// <summary>
        /// FADEXJ.
        /// </summary>
        public const string FADEXJ = "FADEXJ";

        /// <summary>
        /// FAAMF.
        /// </summary>
        public const string FAAMF = "FAAMF";

        /// <summary>
        /// FARMK.
        /// </summary>
        public const string FARMK = "FARMK";

        /// <summary>
        /// FARMK2.
        /// </summary>
        public const string FARMK2 = "FARMK2";

        /// <summary>
        /// FAINSP.
        /// </summary>
        public const string FAINSP = "FAINSP";

        /// <summary>
        /// FAINSC.
        /// </summary>
        public const string FAINSC = "FAINSC";

        /// <summary>
        /// FAINSM.
        /// </summary>
        public const string FAINSM = "FAINSM";

        /// <summary>
        /// FAINSA.
        /// </summary>
        public const string FAINSA = "FAINSA";

        /// <summary>
        /// FAAIV.
        /// </summary>
        public const string FAAIV = "FAAIV";

        /// <summary>
        /// FAINSI.
        /// </summary>
        public const string FAINSI = "FAINSI";

        /// <summary>
        /// FALCT.
        /// </summary>
        public const string FALCT = "FALCT";

        /// <summary>
        /// FALOC.
        /// </summary>
        public const string FALOC = "FALOC";

        /// <summary>
        /// FAADDS.
        /// </summary>
        public const string FAADDS = "FAADDS";

        /// <summary>
        /// FAEFTB.
        /// </summary>
        public const string FAEFTB = "FAEFTB";

        /// <summary>
        /// FADER.
        /// </summary>
        public const string FADER = "FADER";

        /// <summary>
        /// FAMSGA.
        /// </summary>
        public const string FAMSGA = "FAMSGA";

        /// <summary>
        /// FAEX.
        /// </summary>
        public const string FAEX = "FAEX";

        /// <summary>
        /// FAEXR.
        /// </summary>
        public const string FAEXR = "FAEXR";

        /// <summary>
        /// FAAN8.
        /// </summary>
        public const string FAAN8 = "FAAN8";

        /// <summary>
        /// FAACL6.
        /// </summary>
        public const string FAACL6 = "FAACL6";

        /// <summary>
        /// FAACL7.
        /// </summary>
        public const string FAACL7 = "FAACL7";

        /// <summary>
        /// FAACL8.
        /// </summary>
        public const string FAACL8 = "FAACL8";

        /// <summary>
        /// FAACL9.
        /// </summary>
        public const string FAACL9 = "FAACL9";

        /// <summary>
        /// FAACL0.
        /// </summary>
        public const string FAACL0 = "FAACL0";

        /// <summary>
        /// FASFC.
        /// </summary>
        public const string FASFC = "FASFC";

        /// <summary>
        /// FADADC.
        /// </summary>
        public const string FADADC = "FADADC";

        /// <summary>
        /// FADADO.
        /// </summary>
        public const string FADADO = "FADADO";

        /// <summary>
        /// FADADS.
        /// </summary>
        public const string FADADS = "FADADS";

        /// <summary>
        /// FAUNIT.
        /// </summary>
        public const string FAUNIT = "FAUNIT";

        /// <summary>
        /// FAKIT.
        /// </summary>
        public const string FAKIT = "FAKIT";

        /// <summary>
        /// FAKITL.
        /// </summary>
        public const string FAKITL = "FAKITL";

        /// <summary>
        /// FAAFE.
        /// </summary>
        public const string FAAFE = "FAAFE";

        /// <summary>
        /// FAJBCD.
        /// </summary>
        public const string FAJBCD = "FAJBCD";

        /// <summary>
        /// FAJBST.
        /// </summary>
        public const string FAJBST = "FAJBST";

        /// <summary>
        /// FAUN.
        /// </summary>
        public const string FAUN = "FAUN";

        /// <summary>
        /// FASBLI.
        /// </summary>
        public const string FASBLI = "FASBLI";

        /// <summary>
        /// FAUPMT.
        /// </summary>
        public const string FAUPMT = "FAUPMT";

        /// <summary>
        /// FAFA0.
        /// </summary>
        public const string FAFA0 = "FAFA0";

        /// <summary>
        /// FAFA1.
        /// </summary>
        public const string FAFA1 = "FAFA1";

        /// <summary>
        /// FAFA2.
        /// </summary>
        public const string FAFA2 = "FAFA2";

        /// <summary>
        /// FAFA3.
        /// </summary>
        public const string FAFA3 = "FAFA3";

        /// <summary>
        /// FAFA4.
        /// </summary>
        public const string FAFA4 = "FAFA4";

        /// <summary>
        /// FAFA5.
        /// </summary>
        public const string FAFA5 = "FAFA5";

        /// <summary>
        /// FAFA6.
        /// </summary>
        public const string FAFA6 = "FAFA6";

        /// <summary>
        /// FAFA7.
        /// </summary>
        public const string FAFA7 = "FAFA7";

        /// <summary>
        /// FAFA8.
        /// </summary>
        public const string FAFA8 = "FAFA8";

        /// <summary>
        /// FAFA9.
        /// </summary>
        public const string FAFA9 = "FAFA9";

        /// <summary>
        /// FAFA21.
        /// </summary>
        public const string FAFA21 = "FAFA21";

        /// <summary>
        /// FAFA22.
        /// </summary>
        public const string FAFA22 = "FAFA22";

        /// <summary>
        /// FAFA23.
        /// </summary>
        public const string FAFA23 = "FAFA23";

        /// <summary>
        /// FAWOYN.
        /// </summary>
        public const string FAWOYN = "FAWOYN";

        /// <summary>
        /// FACRTL.
        /// </summary>
        public const string FACRTL = "FACRTL";

        /// <summary>
        /// FAWRFL.
        /// </summary>
        public const string FAWRFL = "FAWRFL";

        /// <summary>
        /// FAWARJ.
        /// </summary>
        public const string FAWARJ = "FAWARJ";

        /// <summary>
        /// FAURCD.
        /// </summary>
        public const string FAURCD = "FAURCD";

        /// <summary>
        /// FAURDT.
        /// </summary>
        public const string FAURDT = "FAURDT";

        /// <summary>
        /// FAURAT.
        /// </summary>
        public const string FAURAT = "FAURAT";

        /// <summary>
        /// FAURAB.
        /// </summary>
        public const string FAURAB = "FAURAB";

        /// <summary>
        /// FAURRF.
        /// </summary>
        public const string FAURRF = "FAURRF";

        /// <summary>
        /// FATORG.
        /// </summary>
        public const string FATORG = "FATORG";

        /// <summary>
        /// FAUSER.
        /// </summary>
        public const string FAUSER = "FAUSER";

        /// <summary>
        /// FAPID.
        /// </summary>
        public const string FAPID = "FAPID";

        /// <summary>
        /// FAJOBN.
        /// </summary>
        public const string FAJOBN = "FAJOBN";

        /// <summary>
        /// FAUPMJ.
        /// </summary>
        public const string FAUPMJ = "FAUPMJ";

        /// <summary>
        /// FATDAY.
        /// </summary>
        public const string FATDAY = "FATDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F1201Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FAEDUS", "FAEDUS", JdeDataType.String, 20, true, true),
        new JdeField("FAEDBT", "FAEDBT", JdeDataType.String, 30, true, true),
        new JdeField("FAEDTN", "FAEDTN", JdeDataType.String, 44, true, true),
        new JdeField("FAEDLN", "FAEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("FAEDCT", "FAEDCT", JdeDataType.String, 4),
        new JdeField("FATYTN", "FATYTN", JdeDataType.String, 16),
        new JdeField("FAEDFT", "FAEDFT", JdeDataType.String, 20),
        new JdeField("FAEDDT", "FAEDDT", JdeDataType.Numeric),
        new JdeField("FADRIN", "FADRIN", JdeDataType.String, 2),
        new JdeField("FAEDDL", "FAEDDL", JdeDataType.Numeric),
        new JdeField("FAEDSP", "FAEDSP", JdeDataType.String, 2),
        new JdeField("FAPNID", "FAPNID", JdeDataType.String, 30),
        new JdeField("FATNAC", "FATNAC", JdeDataType.String, 4),
        new JdeField("FACO", "FACO", JdeDataType.String, 10),
        new JdeField("FANUMB", "FANUMB", JdeDataType.Numeric),
        new JdeField("FAAPID", "FAAPID", JdeDataType.String, 24),
        new JdeField("FAAAID", "FAAAID", JdeDataType.Numeric),
        new JdeField("FAASID", "FAASID", JdeDataType.String, 50),
        new JdeField("FASEQ", "FASEQ", JdeDataType.Numeric),
        new JdeField("FAACL1", "FAACL1", JdeDataType.String, 6),
        new JdeField("FAACL2", "FAACL2", JdeDataType.String, 6),
        new JdeField("FAACL3", "FAACL3", JdeDataType.String, 6),
        new JdeField("FAACL4", "FAACL4", JdeDataType.String, 6),
        new JdeField("FAACL5", "FAACL5", JdeDataType.String, 6),
        new JdeField("FAMCU", "FAMCU", JdeDataType.String, 24),
        new JdeField("FADL01", "FADL01", JdeDataType.String, 60),
        new JdeField("FADL02", "FADL02", JdeDataType.String, 60),
        new JdeField("FADL03", "FADL03", JdeDataType.String, 60),
        new JdeField("FADSCC", "FADSCC", JdeDataType.String, 80),
        new JdeField("FADAJ", "FADAJ", JdeDataType.Numeric),
        new JdeField("FADSP", "FADSP", JdeDataType.Numeric),
        new JdeField("FAEQST", "FAEQST", JdeDataType.String, 4),
        new JdeField("FANORU", "FANORU", JdeDataType.String, 2),
        new JdeField("FAAESV", "FAAESV", JdeDataType.Numeric),
        new JdeField("FAARPC", "FAARPC", JdeDataType.Numeric),
        new JdeField("FAALRC", "FAALRC", JdeDataType.Numeric),
        new JdeField("FAAMCU", "FAAMCU", JdeDataType.String, 24),
        new JdeField("FAAOBJ", "FAAOBJ", JdeDataType.String, 12),
        new JdeField("FAASUB", "FAASUB", JdeDataType.String, 16),
        new JdeField("FADMCU", "FADMCU", JdeDataType.String, 24),
        new JdeField("FADOBJ", "FADOBJ", JdeDataType.String, 12),
        new JdeField("FADSUB", "FADSUB", JdeDataType.String, 16),
        new JdeField("FAXMCU", "FAXMCU", JdeDataType.String, 24),
        new JdeField("FAXOBJ", "FAXOBJ", JdeDataType.String, 12),
        new JdeField("FAXSUB", "FAXSUB", JdeDataType.String, 16),
        new JdeField("FARMCU", "FARMCU", JdeDataType.String, 24),
        new JdeField("FAROBJ", "FAROBJ", JdeDataType.String, 12),
        new JdeField("FARSUB", "FARSUB", JdeDataType.String, 16),
        new JdeField("FAARCQ", "FAARCQ", JdeDataType.Numeric),
        new JdeField("FAAROQ", "FAAROQ", JdeDataType.Numeric),
        new JdeField("FATXJS", "FATXJS", JdeDataType.Numeric),
        new JdeField("FAAITY", "FAAITY", JdeDataType.Numeric),
        new JdeField("FAAITP", "FAAITP", JdeDataType.Numeric),
        new JdeField("FAFINC", "FAFINC", JdeDataType.String, 2),
        new JdeField("FAITCO", "FAITCO", JdeDataType.String, 2),
        new JdeField("FAPURO", "FAPURO", JdeDataType.String, 2),
        new JdeField("FAAPUR", "FAAPUR", JdeDataType.Numeric),
        new JdeField("FAPURP", "FAPURP", JdeDataType.Numeric),
        new JdeField("FAAPOM", "FAAPOM", JdeDataType.Numeric),
        new JdeField("FALANO", "FALANO", JdeDataType.Numeric),
        new JdeField("FAJCD", "FAJCD", JdeDataType.Numeric),
        new JdeField("FADEXJ", "FADEXJ", JdeDataType.Numeric),
        new JdeField("FAAMF", "FAAMF", JdeDataType.Numeric),
        new JdeField("FARMK", "FARMK", JdeDataType.String, 60),
        new JdeField("FARMK2", "FARMK2", JdeDataType.String, 60),
        new JdeField("FAINSP", "FAINSP", JdeDataType.String, 50),
        new JdeField("FAINSC", "FAINSC", JdeDataType.String, 50),
        new JdeField("FAINSM", "FAINSM", JdeDataType.Numeric),
        new JdeField("FAINSA", "FAINSA", JdeDataType.Numeric),
        new JdeField("FAAIV", "FAAIV", JdeDataType.Numeric),
        new JdeField("FAINSI", "FAINSI", JdeDataType.Numeric),
        new JdeField("FALCT", "FALCT", JdeDataType.Numeric),
        new JdeField("FALOC", "FALOC", JdeDataType.String, 24),
        new JdeField("FAADDS", "FAADDS", JdeDataType.String, 6),
        new JdeField("FAEFTB", "FAEFTB", JdeDataType.Numeric),
        new JdeField("FADER", "FADER", JdeDataType.Numeric),
        new JdeField("FAMSGA", "FAMSGA", JdeDataType.String, 2),
        new JdeField("FAEX", "FAEX", JdeDataType.String, 60),
        new JdeField("FAEXR", "FAEXR", JdeDataType.String, 60),
        new JdeField("FAAN8", "FAAN8", JdeDataType.Numeric),
        new JdeField("FAACL6", "FAACL6", JdeDataType.String, 6),
        new JdeField("FAACL7", "FAACL7", JdeDataType.String, 6),
        new JdeField("FAACL8", "FAACL8", JdeDataType.String, 6),
        new JdeField("FAACL9", "FAACL9", JdeDataType.String, 6),
        new JdeField("FAACL0", "FAACL0", JdeDataType.String, 6),
        new JdeField("FASFC", "FASFC", JdeDataType.Numeric),
        new JdeField("FADADC", "FADADC", JdeDataType.String, 24),
        new JdeField("FADADO", "FADADO", JdeDataType.String, 12),
        new JdeField("FADADS", "FADADS", JdeDataType.String, 16),
        new JdeField("FAUNIT", "FAUNIT", JdeDataType.String, 16),
        new JdeField("FAKIT", "FAKIT", JdeDataType.Numeric),
        new JdeField("FAKITL", "FAKITL", JdeDataType.String, 50),
        new JdeField("FAAFE", "FAAFE", JdeDataType.String, 24),
        new JdeField("FAJBCD", "FAJBCD", JdeDataType.String, 12),
        new JdeField("FAJBST", "FAJBST", JdeDataType.String, 8),
        new JdeField("FAUN", "FAUN", JdeDataType.String, 12),
        new JdeField("FASBLI", "FASBLI", JdeDataType.String, 2),
        new JdeField("FAUPMT", "FAUPMT", JdeDataType.Numeric),
        new JdeField("FAFA0", "FAFA0", JdeDataType.String, 6),
        new JdeField("FAFA1", "FAFA1", JdeDataType.String, 6),
        new JdeField("FAFA2", "FAFA2", JdeDataType.String, 6),
        new JdeField("FAFA3", "FAFA3", JdeDataType.String, 6),
        new JdeField("FAFA4", "FAFA4", JdeDataType.String, 6),
        new JdeField("FAFA5", "FAFA5", JdeDataType.String, 6),
        new JdeField("FAFA6", "FAFA6", JdeDataType.String, 6),
        new JdeField("FAFA7", "FAFA7", JdeDataType.String, 6),
        new JdeField("FAFA8", "FAFA8", JdeDataType.String, 6),
        new JdeField("FAFA9", "FAFA9", JdeDataType.String, 6),
        new JdeField("FAFA21", "FAFA21", JdeDataType.String, 20),
        new JdeField("FAFA22", "FAFA22", JdeDataType.String, 20),
        new JdeField("FAFA23", "FAFA23", JdeDataType.String, 20),
        new JdeField("FAWOYN", "FAWOYN", JdeDataType.String, 2),
        new JdeField("FACRTL", "FACRTL", JdeDataType.Numeric),
        new JdeField("FAWRFL", "FAWRFL", JdeDataType.String, 2),
        new JdeField("FAWARJ", "FAWARJ", JdeDataType.Numeric),
        new JdeField("FAURCD", "FAURCD", JdeDataType.String, 4),
        new JdeField("FAURDT", "FAURDT", JdeDataType.Numeric),
        new JdeField("FAURAT", "FAURAT", JdeDataType.Numeric),
        new JdeField("FAURAB", "FAURAB", JdeDataType.Numeric),
        new JdeField("FAURRF", "FAURRF", JdeDataType.String, 30),
        new JdeField("FATORG", "FATORG", JdeDataType.String, 20),
        new JdeField("FAUSER", "FAUSER", JdeDataType.String, 20),
        new JdeField("FAPID", "FAPID", JdeDataType.String, 20),
        new JdeField("FAJOBN", "FAJOBN", JdeDataType.String, 20),
        new JdeField("FAUPMJ", "FAUPMJ", JdeDataType.Numeric),
        new JdeField("FATDAY", "FATDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1201Z1_0", "Primary Key on FAEDUS, FAEDBT, FAEDTN, FAEDLN", new[] { "FAEDUS", "FAEDBT", "FAEDTN", "FAEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
