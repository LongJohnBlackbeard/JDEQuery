using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F42800G1 - .
/// </summary>
public class F42800G1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DGBDID.
        /// </summary>
        public const string DGBDID = "DGBDID";

        /// <summary>
        /// DGGBJN.
        /// </summary>
        public const string DGGBJN = "DGGBJN";

        /// <summary>
        /// DGJELN.
        /// </summary>
        public const string DGJELN = "DGJELN";

        /// <summary>
        /// DGLACTN.
        /// </summary>
        public const string DGLACTN = "DGLACTN";

        /// <summary>
        /// DGPMODE.
        /// </summary>
        public const string DGPMODE = "DGPMODE";

        /// <summary>
        /// DGGBEF.
        /// </summary>
        public const string DGGBEF = "DGGBEF";

        /// <summary>
        /// DGUKERRO.
        /// </summary>
        public const string DGUKERRO = "DGUKERRO";

        /// <summary>
        /// DGRWFL.
        /// </summary>
        public const string DGRWFL = "DGRWFL";

        /// <summary>
        /// DGTYDC.
        /// </summary>
        public const string DGTYDC = "DGTYDC";

        /// <summary>
        /// DGAA.
        /// </summary>
        public const string DGAA = "DGAA";

        /// <summary>
        /// DGANI.
        /// </summary>
        public const string DGANI = "DGANI";

        /// <summary>
        /// DGAID.
        /// </summary>
        public const string DGAID = "DGAID";

        /// <summary>
        /// DGMCU.
        /// </summary>
        public const string DGMCU = "DGMCU";

        /// <summary>
        /// DGOBJ.
        /// </summary>
        public const string DGOBJ = "DGOBJ";

        /// <summary>
        /// DGSUB.
        /// </summary>
        public const string DGSUB = "DGSUB";

        /// <summary>
        /// DGAM.
        /// </summary>
        public const string DGAM = "DGAM";

        /// <summary>
        /// DGFY.
        /// </summary>
        public const string DGFY = "DGFY";

        /// <summary>
        /// DGPN.
        /// </summary>
        public const string DGPN = "DGPN";

        /// <summary>
        /// DGCTRY.
        /// </summary>
        public const string DGCTRY = "DGCTRY";

        /// <summary>
        /// DGSBL.
        /// </summary>
        public const string DGSBL = "DGSBL";

        /// <summary>
        /// DGSBLT.
        /// </summary>
        public const string DGSBLT = "DGSBLT";

        /// <summary>
        /// DGU.
        /// </summary>
        public const string DGU = "DGU";

        /// <summary>
        /// DGUM.
        /// </summary>
        public const string DGUM = "DGUM";

        /// <summary>
        /// DGDSVJ.
        /// </summary>
        public const string DGDSVJ = "DGDSVJ";

        /// <summary>
        /// DGEXTL.
        /// </summary>
        public const string DGEXTL = "DGEXTL";

        /// <summary>
        /// DGASID.
        /// </summary>
        public const string DGASID = "DGASID";

        /// <summary>
        /// DGPOST.
        /// </summary>
        public const string DGPOST = "DGPOST";

        /// <summary>
        /// DGEXR.
        /// </summary>
        public const string DGEXR = "DGEXR";

        /// <summary>
        /// DGR2.
        /// </summary>
        public const string DGR2 = "DGR2";

        /// <summary>
        /// DGSFX.
        /// </summary>
        public const string DGSFX = "DGSFX";

        /// <summary>
        /// DGBC.
        /// </summary>
        public const string DGBC = "DGBC";

        /// <summary>
        /// DGDOI.
        /// </summary>
        public const string DGDOI = "DGDOI";

        /// <summary>
        /// DGWR01.
        /// </summary>
        public const string DGWR01 = "DGWR01";

        /// <summary>
        /// DGALID.
        /// </summary>
        public const string DGALID = "DGALID";

        /// <summary>
        /// DGDCTO.
        /// </summary>
        public const string DGDCTO = "DGDCTO";

        /// <summary>
        /// DGLNID.
        /// </summary>
        public const string DGLNID = "DGLNID";

        /// <summary>
        /// DGPDCT.
        /// </summary>
        public const string DGPDCT = "DGPDCT";

        /// <summary>
        /// DGPKCO.
        /// </summary>
        public const string DGPKCO = "DGPKCO";

        /// <summary>
        /// DGPO.
        /// </summary>
        public const string DGPO = "DGPO";

        /// <summary>
        /// DGPSFX.
        /// </summary>
        public const string DGPSFX = "DGPSFX";

        /// <summary>
        /// DGTNN.
        /// </summary>
        public const string DGTNN = "DGTNN";

        /// <summary>
        /// DGACR.
        /// </summary>
        public const string DGACR = "DGACR";

        /// <summary>
        /// DGCTAM.
        /// </summary>
        public const string DGCTAM = "DGCTAM";

        /// <summary>
        /// DGCTXA.
        /// </summary>
        public const string DGCTXA = "DGCTXA";

        /// <summary>
        /// DGSTAM.
        /// </summary>
        public const string DGSTAM = "DGSTAM";

        /// <summary>
        /// DGATXA.
        /// </summary>
        public const string DGATXA = "DGATXA";

        /// <summary>
        /// DGEXR1.
        /// </summary>
        public const string DGEXR1 = "DGEXR1";

        /// <summary>
        /// DGTXA1.
        /// </summary>
        public const string DGTXA1 = "DGTXA1";

        /// <summary>
        /// DGCRYR.
        /// </summary>
        public const string DGCRYR = "DGCRYR";

        /// <summary>
        /// DGCO.
        /// </summary>
        public const string DGCO = "DGCO";

        /// <summary>
        /// DGDKJ.
        /// </summary>
        public const string DGDKJ = "DGDKJ";

        /// <summary>
        /// DGKCO.
        /// </summary>
        public const string DGKCO = "DGKCO";

        /// <summary>
        /// DGCRDC.
        /// </summary>
        public const string DGCRDC = "DGCRDC";

        /// <summary>
        /// DGCRCD.
        /// </summary>
        public const string DGCRCD = "DGCRCD";

        /// <summary>
        /// DGCRR.
        /// </summary>
        public const string DGCRR = "DGCRR";

        /// <summary>
        /// DGCRRM.
        /// </summary>
        public const string DGCRRM = "DGCRRM";

        /// <summary>
        /// DGLLNM.
        /// </summary>
        public const string DGLLNM = "DGLLNM";

        /// <summary>
        /// DGANOG.
        /// </summary>
        public const string DGANOG = "DGANOG";

        /// <summary>
        /// DGFAA.
        /// </summary>
        public const string DGFAA = "DGFAA";

        /// <summary>
        /// DGALT1.
        /// </summary>
        public const string DGALT1 = "DGALT1";

        /// <summary>
        /// DGALT2.
        /// </summary>
        public const string DGALT2 = "DGALT2";

        /// <summary>
        /// DGALT3.
        /// </summary>
        public const string DGALT3 = "DGALT3";

        /// <summary>
        /// DGALT4.
        /// </summary>
        public const string DGALT4 = "DGALT4";

        /// <summary>
        /// DGALT5.
        /// </summary>
        public const string DGALT5 = "DGALT5";

        /// <summary>
        /// DGALT6.
        /// </summary>
        public const string DGALT6 = "DGALT6";

        /// <summary>
        /// DGALT7.
        /// </summary>
        public const string DGALT7 = "DGALT7";

        /// <summary>
        /// DGALT8.
        /// </summary>
        public const string DGALT8 = "DGALT8";

        /// <summary>
        /// DGALT9.
        /// </summary>
        public const string DGALT9 = "DGALT9";

        /// <summary>
        /// DGALT0.
        /// </summary>
        public const string DGALT0 = "DGALT0";

        /// <summary>
        /// DGALTX.
        /// </summary>
        public const string DGALTX = "DGALTX";

        /// <summary>
        /// DGCN.
        /// </summary>
        public const string DGCN = "DGCN";

        /// <summary>
        /// DGDKC.
        /// </summary>
        public const string DGDKC = "DGDKC";

        /// <summary>
        /// DGSUMM.
        /// </summary>
        public const string DGSUMM = "DGSUMM";

        /// <summary>
        /// DGPRGE.
        /// </summary>
        public const string DGPRGE = "DGPRGE";

        /// <summary>
        /// DGBRE.
        /// </summary>
        public const string DGBRE = "DGBRE";

        /// <summary>
        /// DGJBCD.
        /// </summary>
        public const string DGJBCD = "DGJBCD";

        /// <summary>
        /// DGJBST.
        /// </summary>
        public const string DGJBST = "DGJBST";

        /// <summary>
        /// DGWY.
        /// </summary>
        public const string DGWY = "DGWY";

        /// <summary>
        /// DGWN.
        /// </summary>
        public const string DGWN = "DGWN";

        /// <summary>
        /// DGFNLP.
        /// </summary>
        public const string DGFNLP = "DGFNLP";

        /// <summary>
        /// DGASM.
        /// </summary>
        public const string DGASM = "DGASM";

        /// <summary>
        /// DGOPSQ.
        /// </summary>
        public const string DGOPSQ = "DGOPSQ";

        /// <summary>
        /// DGODOC.
        /// </summary>
        public const string DGODOC = "DGODOC";

        /// <summary>
        /// DGOKCO.
        /// </summary>
        public const string DGOKCO = "DGOKCO";

        /// <summary>
        /// DGCFF1.
        /// </summary>
        public const string DGCFF1 = "DGCFF1";

        /// <summary>
        /// DGCFF2.
        /// </summary>
        public const string DGCFF2 = "DGCFF2";

        /// <summary>
        /// DGGLC.
        /// </summary>
        public const string DGGLC = "DGGLC";

        /// <summary>
        /// DGDLNA.
        /// </summary>
        public const string DGDLNA = "DGDLNA";

        /// <summary>
        /// DGALTY.
        /// </summary>
        public const string DGALTY = "DGALTY";

        /// <summary>
        /// DGSBDS.
        /// </summary>
        public const string DGSBDS = "DGSBDS";

        /// <summary>
        /// DGACTDS.
        /// </summary>
        public const string DGACTDS = "DGACTDS";

        /// <summary>
        /// DGBEFL.
        /// </summary>
        public const string DGBEFL = "DGBEFL";

        /// <summary>
        /// DGRCND.
        /// </summary>
        public const string DGRCND = "DGRCND";

        /// <summary>
        /// DGTXAG.
        /// </summary>
        public const string DGTXAG = "DGTXAG";

        /// <summary>
        /// DGFTAG.
        /// </summary>
        public const string DGFTAG = "DGFTAG";

        /// <summary>
        /// DGPM01.
        /// </summary>
        public const string DGPM01 = "DGPM01";

        /// <summary>
        /// DGPM02.
        /// </summary>
        public const string DGPM02 = "DGPM02";

        /// <summary>
        /// DGPM03.
        /// </summary>
        public const string DGPM03 = "DGPM03";

        /// <summary>
        /// DGPM04.
        /// </summary>
        public const string DGPM04 = "DGPM04";

        /// <summary>
        /// DGPM05.
        /// </summary>
        public const string DGPM05 = "DGPM05";

        /// <summary>
        /// DGPM06.
        /// </summary>
        public const string DGPM06 = "DGPM06";

        /// <summary>
        /// DGPM07.
        /// </summary>
        public const string DGPM07 = "DGPM07";

        /// <summary>
        /// DGPM08.
        /// </summary>
        public const string DGPM08 = "DGPM08";

        /// <summary>
        /// DGPM09.
        /// </summary>
        public const string DGPM09 = "DGPM09";

        /// <summary>
        /// DGPM10.
        /// </summary>
        public const string DGPM10 = "DGPM10";

        /// <summary>
        /// DGABT1.
        /// </summary>
        public const string DGABT1 = "DGABT1";

        /// <summary>
        /// DGABR1.
        /// </summary>
        public const string DGABR1 = "DGABR1";

        /// <summary>
        /// DGABT2.
        /// </summary>
        public const string DGABT2 = "DGABT2";

        /// <summary>
        /// DGABR2.
        /// </summary>
        public const string DGABR2 = "DGABR2";

        /// <summary>
        /// DGABT3.
        /// </summary>
        public const string DGABT3 = "DGABT3";

        /// <summary>
        /// DGABR3.
        /// </summary>
        public const string DGABR3 = "DGABR3";

        /// <summary>
        /// DGABT4.
        /// </summary>
        public const string DGABT4 = "DGABT4";

        /// <summary>
        /// DGABR4.
        /// </summary>
        public const string DGABR4 = "DGABR4";

        /// <summary>
        /// DGITM.
        /// </summary>
        public const string DGITM = "DGITM";

        /// <summary>
        /// DGAN8.
        /// </summary>
        public const string DGAN8 = "DGAN8";

        /// <summary>
        /// DGEXA.
        /// </summary>
        public const string DGEXA = "DGEXA";

        /// <summary>
        /// DGTXITM.
        /// </summary>
        public const string DGTXITM = "DGTXITM";

        /// <summary>
        /// DGTKTX.
        /// </summary>
        public const string DGTKTX = "DGTKTX";

        /// <summary>
        /// DGUSER.
        /// </summary>
        public const string DGUSER = "DGUSER";

        /// <summary>
        /// DGPID.
        /// </summary>
        public const string DGPID = "DGPID";

        /// <summary>
        /// DGUPMJ.
        /// </summary>
        public const string DGUPMJ = "DGUPMJ";

        /// <summary>
        /// DGTDAY.
        /// </summary>
        public const string DGTDAY = "DGTDAY";

        /// <summary>
        /// DGJOBN.
        /// </summary>
        public const string DGJOBN = "DGJOBN";

        /// <summary>
        /// DGDLNID.
        /// </summary>
        public const string DGDLNID = "DGDLNID";

        /// <summary>
        /// DGALTW.
        /// </summary>
        public const string DGALTW = "DGALTW";
    }

    /// <inheritdoc />
    public override string TableName => "F42800G1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DGBDID", "DGBDID", JdeDataType.Numeric, null, true, true),
        new JdeField("DGGBJN", "DGGBJN", JdeDataType.Numeric, null, true, true),
        new JdeField("DGJELN", "DGJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("DGLACTN", "DGLACTN", JdeDataType.String, 2),
        new JdeField("DGPMODE", "DGPMODE", JdeDataType.String, 2),
        new JdeField("DGGBEF", "DGGBEF", JdeDataType.String, 2),
        new JdeField("DGUKERRO", "DGUKERRO", JdeDataType.String, 2),
        new JdeField("DGRWFL", "DGRWFL", JdeDataType.String, 2),
        new JdeField("DGTYDC", "DGTYDC", JdeDataType.String, 2),
        new JdeField("DGAA", "DGAA", JdeDataType.Numeric),
        new JdeField("DGANI", "DGANI", JdeDataType.String, 58),
        new JdeField("DGAID", "DGAID", JdeDataType.String, 16),
        new JdeField("DGMCU", "DGMCU", JdeDataType.String, 24),
        new JdeField("DGOBJ", "DGOBJ", JdeDataType.String, 12),
        new JdeField("DGSUB", "DGSUB", JdeDataType.String, 16),
        new JdeField("DGAM", "DGAM", JdeDataType.String, 2),
        new JdeField("DGFY", "DGFY", JdeDataType.Numeric),
        new JdeField("DGPN", "DGPN", JdeDataType.Numeric),
        new JdeField("DGCTRY", "DGCTRY", JdeDataType.Numeric),
        new JdeField("DGSBL", "DGSBL", JdeDataType.String, 16),
        new JdeField("DGSBLT", "DGSBLT", JdeDataType.String, 2),
        new JdeField("DGU", "DGU", JdeDataType.Numeric),
        new JdeField("DGUM", "DGUM", JdeDataType.String, 4),
        new JdeField("DGDSVJ", "DGDSVJ", JdeDataType.Numeric),
        new JdeField("DGEXTL", "DGEXTL", JdeDataType.String, 4),
        new JdeField("DGASID", "DGASID", JdeDataType.String, 50),
        new JdeField("DGPOST", "DGPOST", JdeDataType.String, 2),
        new JdeField("DGEXR", "DGEXR", JdeDataType.String, 60),
        new JdeField("DGR2", "DGR2", JdeDataType.String, 16),
        new JdeField("DGSFX", "DGSFX", JdeDataType.String, 6),
        new JdeField("DGBC", "DGBC", JdeDataType.String, 2),
        new JdeField("DGDOI", "DGDOI", JdeDataType.Numeric),
        new JdeField("DGWR01", "DGWR01", JdeDataType.String, 8),
        new JdeField("DGALID", "DGALID", JdeDataType.String, 50),
        new JdeField("DGDCTO", "DGDCTO", JdeDataType.String, 4),
        new JdeField("DGLNID", "DGLNID", JdeDataType.Numeric),
        new JdeField("DGPDCT", "DGPDCT", JdeDataType.String, 4),
        new JdeField("DGPKCO", "DGPKCO", JdeDataType.String, 10),
        new JdeField("DGPO", "DGPO", JdeDataType.String, 16),
        new JdeField("DGPSFX", "DGPSFX", JdeDataType.String, 6),
        new JdeField("DGTNN", "DGTNN", JdeDataType.String, 2),
        new JdeField("DGACR", "DGACR", JdeDataType.Numeric),
        new JdeField("DGCTAM", "DGCTAM", JdeDataType.Numeric),
        new JdeField("DGCTXA", "DGCTXA", JdeDataType.Numeric),
        new JdeField("DGSTAM", "DGSTAM", JdeDataType.Numeric),
        new JdeField("DGATXA", "DGATXA", JdeDataType.Numeric),
        new JdeField("DGEXR1", "DGEXR1", JdeDataType.String, 4),
        new JdeField("DGTXA1", "DGTXA1", JdeDataType.String, 20),
        new JdeField("DGCRYR", "DGCRYR", JdeDataType.String, 2),
        new JdeField("DGCO", "DGCO", JdeDataType.String, 10),
        new JdeField("DGDKJ", "DGDKJ", JdeDataType.Numeric),
        new JdeField("DGKCO", "DGKCO", JdeDataType.String, 10),
        new JdeField("DGCRDC", "DGCRDC", JdeDataType.String, 6),
        new JdeField("DGCRCD", "DGCRCD", JdeDataType.String, 6),
        new JdeField("DGCRR", "DGCRR", JdeDataType.Numeric),
        new JdeField("DGCRRM", "DGCRRM", JdeDataType.String, 2),
        new JdeField("DGLLNM", "DGLLNM", JdeDataType.Numeric),
        new JdeField("DGANOG", "DGANOG", JdeDataType.Numeric),
        new JdeField("DGFAA", "DGFAA", JdeDataType.Numeric),
        new JdeField("DGALT1", "DGALT1", JdeDataType.String, 2),
        new JdeField("DGALT2", "DGALT2", JdeDataType.String, 2),
        new JdeField("DGALT3", "DGALT3", JdeDataType.String, 2),
        new JdeField("DGALT4", "DGALT4", JdeDataType.String, 2),
        new JdeField("DGALT5", "DGALT5", JdeDataType.String, 2),
        new JdeField("DGALT6", "DGALT6", JdeDataType.String, 2),
        new JdeField("DGALT7", "DGALT7", JdeDataType.String, 2),
        new JdeField("DGALT8", "DGALT8", JdeDataType.String, 2),
        new JdeField("DGALT9", "DGALT9", JdeDataType.String, 2),
        new JdeField("DGALT0", "DGALT0", JdeDataType.String, 2),
        new JdeField("DGALTX", "DGALTX", JdeDataType.String, 2),
        new JdeField("DGCN", "DGCN", JdeDataType.String, 16),
        new JdeField("DGDKC", "DGDKC", JdeDataType.Numeric),
        new JdeField("DGSUMM", "DGSUMM", JdeDataType.String, 2),
        new JdeField("DGPRGE", "DGPRGE", JdeDataType.String, 2),
        new JdeField("DGBRE", "DGBRE", JdeDataType.String, 2),
        new JdeField("DGJBCD", "DGJBCD", JdeDataType.String, 12),
        new JdeField("DGJBST", "DGJBST", JdeDataType.String, 8),
        new JdeField("DGWY", "DGWY", JdeDataType.Numeric),
        new JdeField("DGWN", "DGWN", JdeDataType.Numeric),
        new JdeField("DGFNLP", "DGFNLP", JdeDataType.String, 2),
        new JdeField("DGASM", "DGASM", JdeDataType.String, 2),
        new JdeField("DGOPSQ", "DGOPSQ", JdeDataType.Numeric),
        new JdeField("DGODOC", "DGODOC", JdeDataType.Numeric),
        new JdeField("DGOKCO", "DGOKCO", JdeDataType.String, 10),
        new JdeField("DGCFF1", "DGCFF1", JdeDataType.String, 2),
        new JdeField("DGCFF2", "DGCFF2", JdeDataType.String, 2),
        new JdeField("DGGLC", "DGGLC", JdeDataType.String, 8),
        new JdeField("DGDLNA", "DGDLNA", JdeDataType.String, 2),
        new JdeField("DGALTY", "DGALTY", JdeDataType.String, 4),
        new JdeField("DGSBDS", "DGSBDS", JdeDataType.String, 60),
        new JdeField("DGACTDS", "DGACTDS", JdeDataType.String, 60),
        new JdeField("DGBEFL", "DGBEFL", JdeDataType.String, 2),
        new JdeField("DGRCND", "DGRCND", JdeDataType.String, 2),
        new JdeField("DGTXAG", "DGTXAG", JdeDataType.Numeric),
        new JdeField("DGFTAG", "DGFTAG", JdeDataType.Numeric),
        new JdeField("DGPM01", "DGPM01", JdeDataType.String, 2),
        new JdeField("DGPM02", "DGPM02", JdeDataType.String, 2),
        new JdeField("DGPM03", "DGPM03", JdeDataType.String, 2),
        new JdeField("DGPM04", "DGPM04", JdeDataType.String, 2),
        new JdeField("DGPM05", "DGPM05", JdeDataType.String, 2),
        new JdeField("DGPM06", "DGPM06", JdeDataType.String, 2),
        new JdeField("DGPM07", "DGPM07", JdeDataType.String, 2),
        new JdeField("DGPM08", "DGPM08", JdeDataType.String, 2),
        new JdeField("DGPM09", "DGPM09", JdeDataType.String, 2),
        new JdeField("DGPM10", "DGPM10", JdeDataType.String, 2),
        new JdeField("DGABT1", "DGABT1", JdeDataType.String, 2),
        new JdeField("DGABR1", "DGABR1", JdeDataType.String, 24),
        new JdeField("DGABT2", "DGABT2", JdeDataType.String, 2),
        new JdeField("DGABR2", "DGABR2", JdeDataType.String, 24),
        new JdeField("DGABT3", "DGABT3", JdeDataType.String, 2),
        new JdeField("DGABR3", "DGABR3", JdeDataType.String, 24),
        new JdeField("DGABT4", "DGABT4", JdeDataType.String, 2),
        new JdeField("DGABR4", "DGABR4", JdeDataType.String, 24),
        new JdeField("DGITM", "DGITM", JdeDataType.Numeric),
        new JdeField("DGAN8", "DGAN8", JdeDataType.Numeric),
        new JdeField("DGEXA", "DGEXA", JdeDataType.String, 60),
        new JdeField("DGTXITM", "DGTXITM", JdeDataType.Numeric),
        new JdeField("DGTKTX", "DGTKTX", JdeDataType.String, 2),
        new JdeField("DGUSER", "DGUSER", JdeDataType.String, 20),
        new JdeField("DGPID", "DGPID", JdeDataType.String, 20),
        new JdeField("DGUPMJ", "DGUPMJ", JdeDataType.Numeric),
        new JdeField("DGTDAY", "DGTDAY", JdeDataType.Numeric),
        new JdeField("DGJOBN", "DGJOBN", JdeDataType.String, 20),
        new JdeField("DGDLNID", "DGDLNID", JdeDataType.Numeric),
        new JdeField("DGALTW", "DGALTW", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F42800G1_0", "Primary Key on DGBDID, DGGBJN, DGJELN", new[] { "DGBDID", "DGGBJN", "DGJELN" }, isUnique: true, isPrimaryKey: true)
    };
}
