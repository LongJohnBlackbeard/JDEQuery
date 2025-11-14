using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B575 - .
/// </summary>
public class F03B575 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RDADCN.
        /// </summary>
        public const string RDADCN = "RDADCN";

        /// <summary>
        /// RDCKNU.
        /// </summary>
        public const string RDCKNU = "RDCKNU";

        /// <summary>
        /// RDRC.
        /// </summary>
        public const string RDRC = "RDRC";

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
        /// RDSFX.
        /// </summary>
        public const string RDSFX = "RDSFX";

        /// <summary>
        /// RDAN8.
        /// </summary>
        public const string RDAN8 = "RDAN8";

        /// <summary>
        /// RDDGJ.
        /// </summary>
        public const string RDDGJ = "RDDGJ";

        /// <summary>
        /// RDDIVJ.
        /// </summary>
        public const string RDDIVJ = "RDDIVJ";

        /// <summary>
        /// RDICUT.
        /// </summary>
        public const string RDICUT = "RDICUT";

        /// <summary>
        /// RDICU.
        /// </summary>
        public const string RDICU = "RDICU";

        /// <summary>
        /// RDDICJ.
        /// </summary>
        public const string RDDICJ = "RDDICJ";

        /// <summary>
        /// RDFY.
        /// </summary>
        public const string RDFY = "RDFY";

        /// <summary>
        /// RDCTRY.
        /// </summary>
        public const string RDCTRY = "RDCTRY";

        /// <summary>
        /// RDPN.
        /// </summary>
        public const string RDPN = "RDPN";

        /// <summary>
        /// RDCO.
        /// </summary>
        public const string RDCO = "RDCO";

        /// <summary>
        /// RDGLC.
        /// </summary>
        public const string RDGLC = "RDGLC";

        /// <summary>
        /// RDAID.
        /// </summary>
        public const string RDAID = "RDAID";

        /// <summary>
        /// RDPA8.
        /// </summary>
        public const string RDPA8 = "RDPA8";

        /// <summary>
        /// RDAN8J.
        /// </summary>
        public const string RDAN8J = "RDAN8J";

        /// <summary>
        /// RDPYR.
        /// </summary>
        public const string RDPYR = "RDPYR";

        /// <summary>
        /// RDPOST.
        /// </summary>
        public const string RDPOST = "RDPOST";

        /// <summary>
        /// RDISTR.
        /// </summary>
        public const string RDISTR = "RDISTR";

        /// <summary>
        /// RDBALJ.
        /// </summary>
        public const string RDBALJ = "RDBALJ";

        /// <summary>
        /// RDPST.
        /// </summary>
        public const string RDPST = "RDPST";

        /// <summary>
        /// RDAG.
        /// </summary>
        public const string RDAG = "RDAG";

        /// <summary>
        /// RDAAP.
        /// </summary>
        public const string RDAAP = "RDAAP";

        /// <summary>
        /// RDADSC.
        /// </summary>
        public const string RDADSC = "RDADSC";

        /// <summary>
        /// RDADSA.
        /// </summary>
        public const string RDADSA = "RDADSA";

        /// <summary>
        /// RDATXA.
        /// </summary>
        public const string RDATXA = "RDATXA";

        /// <summary>
        /// RDATXN.
        /// </summary>
        public const string RDATXN = "RDATXN";

        /// <summary>
        /// RDSTAM.
        /// </summary>
        public const string RDSTAM = "RDSTAM";

        /// <summary>
        /// RDBCRC.
        /// </summary>
        public const string RDBCRC = "RDBCRC";

        /// <summary>
        /// RDCRRM.
        /// </summary>
        public const string RDCRRM = "RDCRRM";

        /// <summary>
        /// RDCRCD.
        /// </summary>
        public const string RDCRCD = "RDCRCD";

        /// <summary>
        /// RDCRR.
        /// </summary>
        public const string RDCRR = "RDCRR";

        /// <summary>
        /// RDCRR1.
        /// </summary>
        public const string RDCRR1 = "RDCRR1";

        /// <summary>
        /// RDCRR2.
        /// </summary>
        public const string RDCRR2 = "RDCRR2";

        /// <summary>
        /// RDCRCM.
        /// </summary>
        public const string RDCRCM = "RDCRCM";

        /// <summary>
        /// RDTCRC.
        /// </summary>
        public const string RDTCRC = "RDTCRC";

        /// <summary>
        /// RDTAAP.
        /// </summary>
        public const string RDTAAP = "RDTAAP";

        /// <summary>
        /// RDTADA.
        /// </summary>
        public const string RDTADA = "RDTADA";

        /// <summary>
        /// RDDMCD.
        /// </summary>
        public const string RDDMCD = "RDDMCD";

        /// <summary>
        /// RDACR.
        /// </summary>
        public const string RDACR = "RDACR";

        /// <summary>
        /// RDFAP.
        /// </summary>
        public const string RDFAP = "RDFAP";

        /// <summary>
        /// RDCDS.
        /// </summary>
        public const string RDCDS = "RDCDS";

        /// <summary>
        /// RDCDSA.
        /// </summary>
        public const string RDCDSA = "RDCDSA";

        /// <summary>
        /// RDCTXA.
        /// </summary>
        public const string RDCTXA = "RDCTXA";

        /// <summary>
        /// RDCTXN.
        /// </summary>
        public const string RDCTXN = "RDCTXN";

        /// <summary>
        /// RDCTAM.
        /// </summary>
        public const string RDCTAM = "RDCTAM";

        /// <summary>
        /// RDTXA1.
        /// </summary>
        public const string RDTXA1 = "RDTXA1";

        /// <summary>
        /// RDEXR1.
        /// </summary>
        public const string RDEXR1 = "RDEXR1";

        /// <summary>
        /// RDDSVJ.
        /// </summary>
        public const string RDDSVJ = "RDDSVJ";

        /// <summary>
        /// RDGLBA.
        /// </summary>
        public const string RDGLBA = "RDGLBA";

        /// <summary>
        /// RDAM.
        /// </summary>
        public const string RDAM = "RDAM";

        /// <summary>
        /// RDAID2.
        /// </summary>
        public const string RDAID2 = "RDAID2";

        /// <summary>
        /// RDAM2.
        /// </summary>
        public const string RDAM2 = "RDAM2";

        /// <summary>
        /// RDMCU.
        /// </summary>
        public const string RDMCU = "RDMCU";

        /// <summary>
        /// RDOBJ.
        /// </summary>
        public const string RDOBJ = "RDOBJ";

        /// <summary>
        /// RDSUB.
        /// </summary>
        public const string RDSUB = "RDSUB";

        /// <summary>
        /// RDSBLT.
        /// </summary>
        public const string RDSBLT = "RDSBLT";

        /// <summary>
        /// RDSBL.
        /// </summary>
        public const string RDSBL = "RDSBL";

        /// <summary>
        /// RDPTC.
        /// </summary>
        public const string RDPTC = "RDPTC";

        /// <summary>
        /// RDDDJ.
        /// </summary>
        public const string RDDDJ = "RDDDJ";

        /// <summary>
        /// RDDDNJ.
        /// </summary>
        public const string RDDDNJ = "RDDDNJ";

        /// <summary>
        /// RDRDDJ.
        /// </summary>
        public const string RDRDDJ = "RDRDDJ";

        /// <summary>
        /// RDRDSJ.
        /// </summary>
        public const string RDRDSJ = "RDRDSJ";

        /// <summary>
        /// RDLFCJ.
        /// </summary>
        public const string RDLFCJ = "RDLFCJ";

        /// <summary>
        /// RDSMTJ.
        /// </summary>
        public const string RDSMTJ = "RDSMTJ";

        /// <summary>
        /// RDNBRR.
        /// </summary>
        public const string RDNBRR = "RDNBRR";

        /// <summary>
        /// RDRDRL.
        /// </summary>
        public const string RDRDRL = "RDRDRL";

        /// <summary>
        /// RDRMDS.
        /// </summary>
        public const string RDRMDS = "RDRMDS";

        /// <summary>
        /// RDCOLL.
        /// </summary>
        public const string RDCOLL = "RDCOLL";

        /// <summary>
        /// RDCORC.
        /// </summary>
        public const string RDCORC = "RDCORC";

        /// <summary>
        /// RDAFC.
        /// </summary>
        public const string RDAFC = "RDAFC";

        /// <summary>
        /// RDDNLT.
        /// </summary>
        public const string RDDNLT = "RDDNLT";

        /// <summary>
        /// RDRSCO.
        /// </summary>
        public const string RDRSCO = "RDRSCO";

        /// <summary>
        /// RDODOC.
        /// </summary>
        public const string RDODOC = "RDODOC";

        /// <summary>
        /// RDODCT.
        /// </summary>
        public const string RDODCT = "RDODCT";

        /// <summary>
        /// RDOKCO.
        /// </summary>
        public const string RDOKCO = "RDOKCO";

        /// <summary>
        /// RDOSFX.
        /// </summary>
        public const string RDOSFX = "RDOSFX";

        /// <summary>
        /// RDVINV.
        /// </summary>
        public const string RDVINV = "RDVINV";

        /// <summary>
        /// RDPO.
        /// </summary>
        public const string RDPO = "RDPO";

        /// <summary>
        /// RDPDCT.
        /// </summary>
        public const string RDPDCT = "RDPDCT";

        /// <summary>
        /// RDPKCO.
        /// </summary>
        public const string RDPKCO = "RDPKCO";

        /// <summary>
        /// RDDCTO.
        /// </summary>
        public const string RDDCTO = "RDDCTO";

        /// <summary>
        /// RDLNID.
        /// </summary>
        public const string RDLNID = "RDLNID";

        /// <summary>
        /// RDSDOC.
        /// </summary>
        public const string RDSDOC = "RDSDOC";

        /// <summary>
        /// RDSDCT.
        /// </summary>
        public const string RDSDCT = "RDSDCT";

        /// <summary>
        /// RDSKCO.
        /// </summary>
        public const string RDSKCO = "RDSKCO";

        /// <summary>
        /// RDSFXO.
        /// </summary>
        public const string RDSFXO = "RDSFXO";

        /// <summary>
        /// RDVLDT.
        /// </summary>
        public const string RDVLDT = "RDVLDT";

        /// <summary>
        /// RDCMC1.
        /// </summary>
        public const string RDCMC1 = "RDCMC1";

        /// <summary>
        /// RDVR01.
        /// </summary>
        public const string RDVR01 = "RDVR01";

        /// <summary>
        /// RDUNIT.
        /// </summary>
        public const string RDUNIT = "RDUNIT";

        /// <summary>
        /// RDMCU2.
        /// </summary>
        public const string RDMCU2 = "RDMCU2";

        /// <summary>
        /// RDRMK.
        /// </summary>
        public const string RDRMK = "RDRMK";

        /// <summary>
        /// RDALPH.
        /// </summary>
        public const string RDALPH = "RDALPH";

        /// <summary>
        /// RDRF.
        /// </summary>
        public const string RDRF = "RDRF";

        /// <summary>
        /// RDDRF.
        /// </summary>
        public const string RDDRF = "RDDRF";

        /// <summary>
        /// RDCTL.
        /// </summary>
        public const string RDCTL = "RDCTL";

        /// <summary>
        /// RDFNLP.
        /// </summary>
        public const string RDFNLP = "RDFNLP";

        /// <summary>
        /// RDITM.
        /// </summary>
        public const string RDITM = "RDITM";

        /// <summary>
        /// RDU.
        /// </summary>
        public const string RDU = "RDU";

        /// <summary>
        /// RDUM.
        /// </summary>
        public const string RDUM = "RDUM";

        /// <summary>
        /// RDALT6.
        /// </summary>
        public const string RDALT6 = "RDALT6";

        /// <summary>
        /// RDRYIN.
        /// </summary>
        public const string RDRYIN = "RDRYIN";

        /// <summary>
        /// RDVDGJ.
        /// </summary>
        public const string RDVDGJ = "RDVDGJ";

        /// <summary>
        /// RDVOD.
        /// </summary>
        public const string RDVOD = "RDVOD";

        /// <summary>
        /// RDRP1.
        /// </summary>
        public const string RDRP1 = "RDRP1";

        /// <summary>
        /// RDRP2.
        /// </summary>
        public const string RDRP2 = "RDRP2";

        /// <summary>
        /// RDRP3.
        /// </summary>
        public const string RDRP3 = "RDRP3";

        /// <summary>
        /// RDAR01.
        /// </summary>
        public const string RDAR01 = "RDAR01";

        /// <summary>
        /// RDAR02.
        /// </summary>
        public const string RDAR02 = "RDAR02";

        /// <summary>
        /// RDAR03.
        /// </summary>
        public const string RDAR03 = "RDAR03";

        /// <summary>
        /// RDAR04.
        /// </summary>
        public const string RDAR04 = "RDAR04";

        /// <summary>
        /// RDAR05.
        /// </summary>
        public const string RDAR05 = "RDAR05";

        /// <summary>
        /// RDAR06.
        /// </summary>
        public const string RDAR06 = "RDAR06";

        /// <summary>
        /// RDAR07.
        /// </summary>
        public const string RDAR07 = "RDAR07";

        /// <summary>
        /// RDAR08.
        /// </summary>
        public const string RDAR08 = "RDAR08";

        /// <summary>
        /// RDAR09.
        /// </summary>
        public const string RDAR09 = "RDAR09";

        /// <summary>
        /// RDAR10.
        /// </summary>
        public const string RDAR10 = "RDAR10";

        /// <summary>
        /// RDISTC.
        /// </summary>
        public const string RDISTC = "RDISTC";

        /// <summary>
        /// RDPYID.
        /// </summary>
        public const string RDPYID = "RDPYID";

        /// <summary>
        /// RDURC1.
        /// </summary>
        public const string RDURC1 = "RDURC1";

        /// <summary>
        /// RDURDT.
        /// </summary>
        public const string RDURDT = "RDURDT";

        /// <summary>
        /// RDURAT.
        /// </summary>
        public const string RDURAT = "RDURAT";

        /// <summary>
        /// RDURAB.
        /// </summary>
        public const string RDURAB = "RDURAB";

        /// <summary>
        /// RDURRF.
        /// </summary>
        public const string RDURRF = "RDURRF";

        /// <summary>
        /// RDRNID.
        /// </summary>
        public const string RDRNID = "RDRNID";

        /// <summary>
        /// RDPPDI.
        /// </summary>
        public const string RDPPDI = "RDPPDI";

        /// <summary>
        /// RDTORG.
        /// </summary>
        public const string RDTORG = "RDTORG";

        /// <summary>
        /// RDUSER.
        /// </summary>
        public const string RDUSER = "RDUSER";

        /// <summary>
        /// RDJCL.
        /// </summary>
        public const string RDJCL = "RDJCL";

        /// <summary>
        /// RDPID.
        /// </summary>
        public const string RDPID = "RDPID";

        /// <summary>
        /// RDUPMJ.
        /// </summary>
        public const string RDUPMJ = "RDUPMJ";

        /// <summary>
        /// RDUPMT.
        /// </summary>
        public const string RDUPMT = "RDUPMT";

        /// <summary>
        /// RDDDEX.
        /// </summary>
        public const string RDDDEX = "RDDDEX";

        /// <summary>
        /// RDJOBN.
        /// </summary>
        public const string RDJOBN = "RDJOBN";

        /// <summary>
        /// RDHCRR.
        /// </summary>
        public const string RDHCRR = "RDHCRR";

        /// <summary>
        /// RDHDGJ.
        /// </summary>
        public const string RDHDGJ = "RDHDGJ";

        /// <summary>
        /// RDDETL.
        /// </summary>
        public const string RDDETL = "RDDETL";

        /// <summary>
        /// RDSHPN.
        /// </summary>
        public const string RDSHPN = "RDSHPN";
    }

    /// <inheritdoc />
    public override string TableName => "F03B575";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RDADCN", "RDADCN", JdeDataType.Numeric, null, true, true),
        new JdeField("RDCKNU", "RDCKNU", JdeDataType.String, 50, true, true),
        new JdeField("RDRC", "RDRC", JdeDataType.String, 2, true, true),
        new JdeField("RDDOC", "RDDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RDDCT", "RDDCT", JdeDataType.String, 4, true, true),
        new JdeField("RDKCO", "RDKCO", JdeDataType.String, 10, true, true),
        new JdeField("RDSFX", "RDSFX", JdeDataType.String, 6, true, true),
        new JdeField("RDAN8", "RDAN8", JdeDataType.Numeric),
        new JdeField("RDDGJ", "RDDGJ", JdeDataType.Numeric),
        new JdeField("RDDIVJ", "RDDIVJ", JdeDataType.Numeric),
        new JdeField("RDICUT", "RDICUT", JdeDataType.String, 4),
        new JdeField("RDICU", "RDICU", JdeDataType.Numeric),
        new JdeField("RDDICJ", "RDDICJ", JdeDataType.Numeric),
        new JdeField("RDFY", "RDFY", JdeDataType.Numeric),
        new JdeField("RDCTRY", "RDCTRY", JdeDataType.Numeric),
        new JdeField("RDPN", "RDPN", JdeDataType.Numeric),
        new JdeField("RDCO", "RDCO", JdeDataType.String, 10),
        new JdeField("RDGLC", "RDGLC", JdeDataType.String, 8),
        new JdeField("RDAID", "RDAID", JdeDataType.String, 16),
        new JdeField("RDPA8", "RDPA8", JdeDataType.Numeric),
        new JdeField("RDAN8J", "RDAN8J", JdeDataType.Numeric),
        new JdeField("RDPYR", "RDPYR", JdeDataType.Numeric),
        new JdeField("RDPOST", "RDPOST", JdeDataType.String, 2),
        new JdeField("RDISTR", "RDISTR", JdeDataType.String, 2),
        new JdeField("RDBALJ", "RDBALJ", JdeDataType.String, 2),
        new JdeField("RDPST", "RDPST", JdeDataType.String, 2),
        new JdeField("RDAG", "RDAG", JdeDataType.Numeric),
        new JdeField("RDAAP", "RDAAP", JdeDataType.Numeric),
        new JdeField("RDADSC", "RDADSC", JdeDataType.Numeric),
        new JdeField("RDADSA", "RDADSA", JdeDataType.Numeric),
        new JdeField("RDATXA", "RDATXA", JdeDataType.Numeric),
        new JdeField("RDATXN", "RDATXN", JdeDataType.Numeric),
        new JdeField("RDSTAM", "RDSTAM", JdeDataType.Numeric),
        new JdeField("RDBCRC", "RDBCRC", JdeDataType.String, 6),
        new JdeField("RDCRRM", "RDCRRM", JdeDataType.String, 2),
        new JdeField("RDCRCD", "RDCRCD", JdeDataType.String, 6),
        new JdeField("RDCRR", "RDCRR", JdeDataType.Numeric),
        new JdeField("RDCRR1", "RDCRR1", JdeDataType.Numeric),
        new JdeField("RDCRR2", "RDCRR2", JdeDataType.Numeric),
        new JdeField("RDCRCM", "RDCRCM", JdeDataType.String, 2),
        new JdeField("RDTCRC", "RDTCRC", JdeDataType.String, 6),
        new JdeField("RDTAAP", "RDTAAP", JdeDataType.Numeric),
        new JdeField("RDTADA", "RDTADA", JdeDataType.Numeric),
        new JdeField("RDDMCD", "RDDMCD", JdeDataType.String, 2),
        new JdeField("RDACR", "RDACR", JdeDataType.Numeric),
        new JdeField("RDFAP", "RDFAP", JdeDataType.Numeric),
        new JdeField("RDCDS", "RDCDS", JdeDataType.Numeric),
        new JdeField("RDCDSA", "RDCDSA", JdeDataType.Numeric),
        new JdeField("RDCTXA", "RDCTXA", JdeDataType.Numeric),
        new JdeField("RDCTXN", "RDCTXN", JdeDataType.Numeric),
        new JdeField("RDCTAM", "RDCTAM", JdeDataType.Numeric),
        new JdeField("RDTXA1", "RDTXA1", JdeDataType.String, 20),
        new JdeField("RDEXR1", "RDEXR1", JdeDataType.String, 4),
        new JdeField("RDDSVJ", "RDDSVJ", JdeDataType.Numeric),
        new JdeField("RDGLBA", "RDGLBA", JdeDataType.String, 16),
        new JdeField("RDAM", "RDAM", JdeDataType.String, 2),
        new JdeField("RDAID2", "RDAID2", JdeDataType.String, 16),
        new JdeField("RDAM2", "RDAM2", JdeDataType.String, 2),
        new JdeField("RDMCU", "RDMCU", JdeDataType.String, 24),
        new JdeField("RDOBJ", "RDOBJ", JdeDataType.String, 12),
        new JdeField("RDSUB", "RDSUB", JdeDataType.String, 16),
        new JdeField("RDSBLT", "RDSBLT", JdeDataType.String, 2),
        new JdeField("RDSBL", "RDSBL", JdeDataType.String, 16),
        new JdeField("RDPTC", "RDPTC", JdeDataType.String, 6),
        new JdeField("RDDDJ", "RDDDJ", JdeDataType.Numeric),
        new JdeField("RDDDNJ", "RDDDNJ", JdeDataType.Numeric),
        new JdeField("RDRDDJ", "RDRDDJ", JdeDataType.Numeric),
        new JdeField("RDRDSJ", "RDRDSJ", JdeDataType.Numeric),
        new JdeField("RDLFCJ", "RDLFCJ", JdeDataType.Numeric),
        new JdeField("RDSMTJ", "RDSMTJ", JdeDataType.Numeric),
        new JdeField("RDNBRR", "RDNBRR", JdeDataType.String, 2),
        new JdeField("RDRDRL", "RDRDRL", JdeDataType.String, 2),
        new JdeField("RDRMDS", "RDRMDS", JdeDataType.Numeric),
        new JdeField("RDCOLL", "RDCOLL", JdeDataType.String, 2),
        new JdeField("RDCORC", "RDCORC", JdeDataType.String, 4),
        new JdeField("RDAFC", "RDAFC", JdeDataType.String, 2),
        new JdeField("RDDNLT", "RDDNLT", JdeDataType.String, 2),
        new JdeField("RDRSCO", "RDRSCO", JdeDataType.String, 4),
        new JdeField("RDODOC", "RDODOC", JdeDataType.Numeric),
        new JdeField("RDODCT", "RDODCT", JdeDataType.String, 4),
        new JdeField("RDOKCO", "RDOKCO", JdeDataType.String, 10),
        new JdeField("RDOSFX", "RDOSFX", JdeDataType.String, 6),
        new JdeField("RDVINV", "RDVINV", JdeDataType.String, 50),
        new JdeField("RDPO", "RDPO", JdeDataType.String, 16),
        new JdeField("RDPDCT", "RDPDCT", JdeDataType.String, 4),
        new JdeField("RDPKCO", "RDPKCO", JdeDataType.String, 10),
        new JdeField("RDDCTO", "RDDCTO", JdeDataType.String, 4),
        new JdeField("RDLNID", "RDLNID", JdeDataType.Numeric),
        new JdeField("RDSDOC", "RDSDOC", JdeDataType.Numeric),
        new JdeField("RDSDCT", "RDSDCT", JdeDataType.String, 4),
        new JdeField("RDSKCO", "RDSKCO", JdeDataType.String, 10),
        new JdeField("RDSFXO", "RDSFXO", JdeDataType.String, 6),
        new JdeField("RDVLDT", "RDVLDT", JdeDataType.Numeric),
        new JdeField("RDCMC1", "RDCMC1", JdeDataType.Numeric),
        new JdeField("RDVR01", "RDVR01", JdeDataType.String, 50),
        new JdeField("RDUNIT", "RDUNIT", JdeDataType.String, 16),
        new JdeField("RDMCU2", "RDMCU2", JdeDataType.String, 24),
        new JdeField("RDRMK", "RDRMK", JdeDataType.String, 60),
        new JdeField("RDALPH", "RDALPH", JdeDataType.String, 80),
        new JdeField("RDRF", "RDRF", JdeDataType.String, 4),
        new JdeField("RDDRF", "RDDRF", JdeDataType.Numeric),
        new JdeField("RDCTL", "RDCTL", JdeDataType.String, 26),
        new JdeField("RDFNLP", "RDFNLP", JdeDataType.String, 2),
        new JdeField("RDITM", "RDITM", JdeDataType.Numeric),
        new JdeField("RDU", "RDU", JdeDataType.Numeric),
        new JdeField("RDUM", "RDUM", JdeDataType.String, 4),
        new JdeField("RDALT6", "RDALT6", JdeDataType.String, 2),
        new JdeField("RDRYIN", "RDRYIN", JdeDataType.String, 2),
        new JdeField("RDVDGJ", "RDVDGJ", JdeDataType.Numeric),
        new JdeField("RDVOD", "RDVOD", JdeDataType.String, 2),
        new JdeField("RDRP1", "RDRP1", JdeDataType.String, 2),
        new JdeField("RDRP2", "RDRP2", JdeDataType.String, 2),
        new JdeField("RDRP3", "RDRP3", JdeDataType.String, 2),
        new JdeField("RDAR01", "RDAR01", JdeDataType.String, 6),
        new JdeField("RDAR02", "RDAR02", JdeDataType.String, 6),
        new JdeField("RDAR03", "RDAR03", JdeDataType.String, 6),
        new JdeField("RDAR04", "RDAR04", JdeDataType.String, 6),
        new JdeField("RDAR05", "RDAR05", JdeDataType.String, 6),
        new JdeField("RDAR06", "RDAR06", JdeDataType.String, 6),
        new JdeField("RDAR07", "RDAR07", JdeDataType.String, 6),
        new JdeField("RDAR08", "RDAR08", JdeDataType.String, 6),
        new JdeField("RDAR09", "RDAR09", JdeDataType.String, 6),
        new JdeField("RDAR10", "RDAR10", JdeDataType.String, 6),
        new JdeField("RDISTC", "RDISTC", JdeDataType.String, 2),
        new JdeField("RDPYID", "RDPYID", JdeDataType.Numeric),
        new JdeField("RDURC1", "RDURC1", JdeDataType.String, 6),
        new JdeField("RDURDT", "RDURDT", JdeDataType.Numeric),
        new JdeField("RDURAT", "RDURAT", JdeDataType.Numeric),
        new JdeField("RDURAB", "RDURAB", JdeDataType.Numeric),
        new JdeField("RDURRF", "RDURRF", JdeDataType.String, 30),
        new JdeField("RDRNID", "RDRNID", JdeDataType.Numeric),
        new JdeField("RDPPDI", "RDPPDI", JdeDataType.Numeric),
        new JdeField("RDTORG", "RDTORG", JdeDataType.String, 20),
        new JdeField("RDUSER", "RDUSER", JdeDataType.String, 20),
        new JdeField("RDJCL", "RDJCL", JdeDataType.Numeric),
        new JdeField("RDPID", "RDPID", JdeDataType.String, 20),
        new JdeField("RDUPMJ", "RDUPMJ", JdeDataType.Numeric),
        new JdeField("RDUPMT", "RDUPMT", JdeDataType.Numeric),
        new JdeField("RDDDEX", "RDDDEX", JdeDataType.String, 4),
        new JdeField("RDJOBN", "RDJOBN", JdeDataType.String, 20),
        new JdeField("RDHCRR", "RDHCRR", JdeDataType.Numeric),
        new JdeField("RDHDGJ", "RDHDGJ", JdeDataType.Numeric),
        new JdeField("RDDETL", "RDDETL", JdeDataType.Numeric),
        new JdeField("RDSHPN", "RDSHPN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B575_0", "Primary Key on RDADCN, RDCKNU, RDRC, RDKCO, RDDCT, RDDOC, RDSFX", new[] { "RDADCN", "RDCKNU", "RDRC", "RDKCO", "RDDCT", "RDDOC", "RDSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
