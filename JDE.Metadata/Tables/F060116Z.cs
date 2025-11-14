using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F060116Z - .
/// </summary>
public class F060116Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEDUS.
        /// </summary>
        public const string SZEDUS = "SZEDUS";

        /// <summary>
        /// SZEDBT.
        /// </summary>
        public const string SZEDBT = "SZEDBT";

        /// <summary>
        /// SZEDTN.
        /// </summary>
        public const string SZEDTN = "SZEDTN";

        /// <summary>
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZTYTN.
        /// </summary>
        public const string SZTYTN = "SZTYTN";

        /// <summary>
        /// SZEDFT.
        /// </summary>
        public const string SZEDFT = "SZEDFT";

        /// <summary>
        /// SZEDDT.
        /// </summary>
        public const string SZEDDT = "SZEDDT";

        /// <summary>
        /// SZDRIN.
        /// </summary>
        public const string SZDRIN = "SZDRIN";

        /// <summary>
        /// SZEDDL.
        /// </summary>
        public const string SZEDDL = "SZEDDL";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZTNAC.
        /// </summary>
        public const string SZTNAC = "SZTNAC";

        /// <summary>
        /// SZAN8.
        /// </summary>
        public const string SZAN8 = "SZAN8";

        /// <summary>
        /// SZALPH.
        /// </summary>
        public const string SZALPH = "SZALPH";

        /// <summary>
        /// SZSALU.
        /// </summary>
        public const string SZSALU = "SZSALU";

        /// <summary>
        /// SZSUFF.
        /// </summary>
        public const string SZSUFF = "SZSUFF";

        /// <summary>
        /// SZMLNM.
        /// </summary>
        public const string SZMLNM = "SZMLNM";

        /// <summary>
        /// SZSSN.
        /// </summary>
        public const string SZSSN = "SZSSN";

        /// <summary>
        /// SZAT1.
        /// </summary>
        public const string SZAT1 = "SZAT1";

        /// <summary>
        /// SZATE.
        /// </summary>
        public const string SZATE = "SZATE";

        /// <summary>
        /// SZHMCO.
        /// </summary>
        public const string SZHMCO = "SZHMCO";

        /// <summary>
        /// SZHMCU.
        /// </summary>
        public const string SZHMCU = "SZHMCU";

        /// <summary>
        /// SZANPA.
        /// </summary>
        public const string SZANPA = "SZANPA";

        /// <summary>
        /// SZJBCD.
        /// </summary>
        public const string SZJBCD = "SZJBCD";

        /// <summary>
        /// SZJBST.
        /// </summary>
        public const string SZJBST = "SZJBST";

        /// <summary>
        /// SZSAL.
        /// </summary>
        public const string SZSAL = "SZSAL";

        /// <summary>
        /// SZPHRT.
        /// </summary>
        public const string SZPHRT = "SZPHRT";

        /// <summary>
        /// SZDSI.
        /// </summary>
        public const string SZDSI = "SZDSI";

        /// <summary>
        /// SZEEOM.
        /// </summary>
        public const string SZEEOM = "SZEEOM";

        /// <summary>
        /// SZSEX.
        /// </summary>
        public const string SZSEX = "SZSEX";

        /// <summary>
        /// SZDOB.
        /// </summary>
        public const string SZDOB = "SZDOB";

        /// <summary>
        /// SZCCPR.
        /// </summary>
        public const string SZCCPR = "SZCCPR";

        /// <summary>
        /// SZHM01.
        /// </summary>
        public const string SZHM01 = "SZHM01";

        /// <summary>
        /// SZTARR.
        /// </summary>
        public const string SZTARR = "SZTARR";

        /// <summary>
        /// SZTARA.
        /// </summary>
        public const string SZTARA = "SZTARA";

        /// <summary>
        /// SZMSTX.
        /// </summary>
        public const string SZMSTX = "SZMSTX";

        /// <summary>
        /// SZMSTI.
        /// </summary>
        public const string SZMSTI = "SZMSTI";

        /// <summary>
        /// SZLMST.
        /// </summary>
        public const string SZLMST = "SZLMST";

        /// <summary>
        /// SZSHFT.
        /// </summary>
        public const string SZSHFT = "SZSHFT";

        /// <summary>
        /// SZMAIL.
        /// </summary>
        public const string SZMAIL = "SZMAIL";

        /// <summary>
        /// SZSLOC.
        /// </summary>
        public const string SZSLOC = "SZSLOC";

        /// <summary>
        /// SZPAST.
        /// </summary>
        public const string SZPAST = "SZPAST";

        /// <summary>
        /// SZEST.
        /// </summary>
        public const string SZEST = "SZEST";

        /// <summary>
        /// SZSDYY.
        /// </summary>
        public const string SZSDYY = "SZSDYY";

        /// <summary>
        /// SZPSDT.
        /// </summary>
        public const string SZPSDT = "SZPSDT";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZWSPS.
        /// </summary>
        public const string SZWSPS = "SZWSPS";

        /// <summary>
        /// SZNS.
        /// </summary>
        public const string SZNS = "SZNS";

        /// <summary>
        /// SZSUI.
        /// </summary>
        public const string SZSUI = "SZSUI";

        /// <summary>
        /// SZRCCD.
        /// </summary>
        public const string SZRCCD = "SZRCCD";

        /// <summary>
        /// SZFICM.
        /// </summary>
        public const string SZFICM = "SZFICM";

        /// <summary>
        /// SZAPPN.
        /// </summary>
        public const string SZAPPN = "SZAPPN";

        /// <summary>
        /// SZHM02.
        /// </summary>
        public const string SZHM02 = "SZHM02";

        /// <summary>
        /// SZHM03.
        /// </summary>
        public const string SZHM03 = "SZHM03";

        /// <summary>
        /// SZHM04.
        /// </summary>
        public const string SZHM04 = "SZHM04";

        /// <summary>
        /// SZPADT.
        /// </summary>
        public const string SZPADT = "SZPADT";

        /// <summary>
        /// SZBENS.
        /// </summary>
        public const string SZBENS = "SZBENS";

        /// <summary>
        /// SZPFRQ.
        /// </summary>
        public const string SZPFRQ = "SZPFRQ";

        /// <summary>
        /// SZSALY.
        /// </summary>
        public const string SZSALY = "SZSALY";

        /// <summary>
        /// SZPGRD.
        /// </summary>
        public const string SZPGRD = "SZPGRD";

        /// <summary>
        /// SZPGRS.
        /// </summary>
        public const string SZPGRS = "SZPGRS";

        /// <summary>
        /// SZFLSA.
        /// </summary>
        public const string SZFLSA = "SZFLSA";

        /// <summary>
        /// SZWCMP.
        /// </summary>
        public const string SZWCMP = "SZWCMP";

        /// <summary>
        /// SZWET.
        /// </summary>
        public const string SZWET = "SZWET";

        /// <summary>
        /// SZUN.
        /// </summary>
        public const string SZUN = "SZUN";

        /// <summary>
        /// SZDIVC.
        /// </summary>
        public const string SZDIVC = "SZDIVC";

        /// <summary>
        /// SZEEOJ.
        /// </summary>
        public const string SZEEOJ = "SZEEOJ";

        /// <summary>
        /// SZADD1.
        /// </summary>
        public const string SZADD1 = "SZADD1";

        /// <summary>
        /// SZADD2.
        /// </summary>
        public const string SZADD2 = "SZADD2";

        /// <summary>
        /// SZADD3.
        /// </summary>
        public const string SZADD3 = "SZADD3";

        /// <summary>
        /// SZADD4.
        /// </summary>
        public const string SZADD4 = "SZADD4";

        /// <summary>
        /// SZCTY1.
        /// </summary>
        public const string SZCTY1 = "SZCTY1";

        /// <summary>
        /// SZADDS.
        /// </summary>
        public const string SZADDS = "SZADDS";

        /// <summary>
        /// SZADDZ.
        /// </summary>
        public const string SZADDZ = "SZADDZ";

        /// <summary>
        /// SZCTR.
        /// </summary>
        public const string SZCTR = "SZCTR";

        /// <summary>
        /// SZAR1.
        /// </summary>
        public const string SZAR1 = "SZAR1";

        /// <summary>
        /// SZPH1.
        /// </summary>
        public const string SZPH1 = "SZPH1";

        /// <summary>
        /// SZAR3.
        /// </summary>
        public const string SZAR3 = "SZAR3";

        /// <summary>
        /// SZPH3.
        /// </summary>
        public const string SZPH3 = "SZPH3";

        /// <summary>
        /// SZWHO4.
        /// </summary>
        public const string SZWHO4 = "SZWHO4";

        /// <summary>
        /// SZAR4.
        /// </summary>
        public const string SZAR4 = "SZAR4";

        /// <summary>
        /// SZPH4.
        /// </summary>
        public const string SZPH4 = "SZPH4";

        /// <summary>
        /// SZREM1.
        /// </summary>
        public const string SZREM1 = "SZREM1";

        /// <summary>
        /// SZREQN.
        /// </summary>
        public const string SZREQN = "SZREQN";

        /// <summary>
        /// SZSALA.
        /// </summary>
        public const string SZSALA = "SZSALA";

        /// <summary>
        /// SZSC01.
        /// </summary>
        public const string SZSC01 = "SZSC01";

        /// <summary>
        /// SZTRS.
        /// </summary>
        public const string SZTRS = "SZTRS";

        /// <summary>
        /// SZEFTO.
        /// </summary>
        public const string SZEFTO = "SZEFTO";

        /// <summary>
        /// SZURCD.
        /// </summary>
        public const string SZURCD = "SZURCD";

        /// <summary>
        /// SZURDT.
        /// </summary>
        public const string SZURDT = "SZURDT";

        /// <summary>
        /// SZURAT.
        /// </summary>
        public const string SZURAT = "SZURAT";

        /// <summary>
        /// SZURAB.
        /// </summary>
        public const string SZURAB = "SZURAB";

        /// <summary>
        /// SZURRF.
        /// </summary>
        public const string SZURRF = "SZURRF";

        /// <summary>
        /// SZTORG.
        /// </summary>
        public const string SZTORG = "SZTORG";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";

        /// <summary>
        /// SZP001.
        /// </summary>
        public const string SZP001 = "SZP001";

        /// <summary>
        /// SZP002.
        /// </summary>
        public const string SZP002 = "SZP002";

        /// <summary>
        /// SZP003.
        /// </summary>
        public const string SZP003 = "SZP003";

        /// <summary>
        /// SZP004.
        /// </summary>
        public const string SZP004 = "SZP004";

        /// <summary>
        /// SZP005.
        /// </summary>
        public const string SZP005 = "SZP005";

        /// <summary>
        /// SZP006.
        /// </summary>
        public const string SZP006 = "SZP006";

        /// <summary>
        /// SZP007.
        /// </summary>
        public const string SZP007 = "SZP007";

        /// <summary>
        /// SZP008.
        /// </summary>
        public const string SZP008 = "SZP008";

        /// <summary>
        /// SZP009.
        /// </summary>
        public const string SZP009 = "SZP009";

        /// <summary>
        /// SZP010.
        /// </summary>
        public const string SZP010 = "SZP010";

        /// <summary>
        /// SZP011.
        /// </summary>
        public const string SZP011 = "SZP011";

        /// <summary>
        /// SZP012.
        /// </summary>
        public const string SZP012 = "SZP012";

        /// <summary>
        /// SZP013.
        /// </summary>
        public const string SZP013 = "SZP013";

        /// <summary>
        /// SZP014.
        /// </summary>
        public const string SZP014 = "SZP014";

        /// <summary>
        /// SZP015.
        /// </summary>
        public const string SZP015 = "SZP015";

        /// <summary>
        /// SZP016.
        /// </summary>
        public const string SZP016 = "SZP016";

        /// <summary>
        /// SZP017.
        /// </summary>
        public const string SZP017 = "SZP017";

        /// <summary>
        /// SZP018.
        /// </summary>
        public const string SZP018 = "SZP018";

        /// <summary>
        /// SZP019.
        /// </summary>
        public const string SZP019 = "SZP019";

        /// <summary>
        /// SZP020.
        /// </summary>
        public const string SZP020 = "SZP020";

        /// <summary>
        /// SZE001.
        /// </summary>
        public const string SZE001 = "SZE001";

        /// <summary>
        /// SZE002.
        /// </summary>
        public const string SZE002 = "SZE002";

        /// <summary>
        /// SZE003.
        /// </summary>
        public const string SZE003 = "SZE003";

        /// <summary>
        /// SZE004.
        /// </summary>
        public const string SZE004 = "SZE004";

        /// <summary>
        /// SZE005.
        /// </summary>
        public const string SZE005 = "SZE005";

        /// <summary>
        /// SZE006.
        /// </summary>
        public const string SZE006 = "SZE006";

        /// <summary>
        /// SZE007.
        /// </summary>
        public const string SZE007 = "SZE007";

        /// <summary>
        /// SZE008.
        /// </summary>
        public const string SZE008 = "SZE008";

        /// <summary>
        /// SZE009.
        /// </summary>
        public const string SZE009 = "SZE009";

        /// <summary>
        /// SZE010.
        /// </summary>
        public const string SZE010 = "SZE010";

        /// <summary>
        /// SZFTE.
        /// </summary>
        public const string SZFTE = "SZFTE";

        /// <summary>
        /// SZIH.
        /// </summary>
        public const string SZIH = "SZIH";

        /// <summary>
        /// SZCOUN.
        /// </summary>
        public const string SZCOUN = "SZCOUN";

        /// <summary>
        /// SZPOS.
        /// </summary>
        public const string SZPOS = "SZPOS";

        /// <summary>
        /// SZOEMP.
        /// </summary>
        public const string SZOEMP = "SZOEMP";

        /// <summary>
        /// SZIFN.
        /// </summary>
        public const string SZIFN = "SZIFN";

        /// <summary>
        /// SZIMN.
        /// </summary>
        public const string SZIMN = "SZIMN";

        /// <summary>
        /// SZDTSP.
        /// </summary>
        public const string SZDTSP = "SZDTSP";

        /// <summary>
        /// SZED01.
        /// </summary>
        public const string SZED01 = "SZED01";

        /// <summary>
        /// SZED02.
        /// </summary>
        public const string SZED02 = "SZED02";

        /// <summary>
        /// SZED03.
        /// </summary>
        public const string SZED03 = "SZED03";

        /// <summary>
        /// SZED04.
        /// </summary>
        public const string SZED04 = "SZED04";

        /// <summary>
        /// SZED05.
        /// </summary>
        public const string SZED05 = "SZED05";

        /// <summary>
        /// SZED06.
        /// </summary>
        public const string SZED06 = "SZED06";

        /// <summary>
        /// SZED07.
        /// </summary>
        public const string SZED07 = "SZED07";

        /// <summary>
        /// SZED08.
        /// </summary>
        public const string SZED08 = "SZED08";

        /// <summary>
        /// SZED09.
        /// </summary>
        public const string SZED09 = "SZED09";

        /// <summary>
        /// SZED10.
        /// </summary>
        public const string SZED10 = "SZED10";

        /// <summary>
        /// SZED11.
        /// </summary>
        public const string SZED11 = "SZED11";

        /// <summary>
        /// SZED12.
        /// </summary>
        public const string SZED12 = "SZED12";

        /// <summary>
        /// SZED13.
        /// </summary>
        public const string SZED13 = "SZED13";

        /// <summary>
        /// SZED14.
        /// </summary>
        public const string SZED14 = "SZED14";

        /// <summary>
        /// SZED15.
        /// </summary>
        public const string SZED15 = "SZED15";

        /// <summary>
        /// SZED16.
        /// </summary>
        public const string SZED16 = "SZED16";

        /// <summary>
        /// SZED17.
        /// </summary>
        public const string SZED17 = "SZED17";

        /// <summary>
        /// SZED18.
        /// </summary>
        public const string SZED18 = "SZED18";

        /// <summary>
        /// SZED19.
        /// </summary>
        public const string SZED19 = "SZED19";

        /// <summary>
        /// SZED20.
        /// </summary>
        public const string SZED20 = "SZED20";

        /// <summary>
        /// SZK001.
        /// </summary>
        public const string SZK001 = "SZK001";

        /// <summary>
        /// SZK002.
        /// </summary>
        public const string SZK002 = "SZK002";

        /// <summary>
        /// SZK003.
        /// </summary>
        public const string SZK003 = "SZK003";

        /// <summary>
        /// SZK004.
        /// </summary>
        public const string SZK004 = "SZK004";

        /// <summary>
        /// SZK005.
        /// </summary>
        public const string SZK005 = "SZK005";

        /// <summary>
        /// SZK006.
        /// </summary>
        public const string SZK006 = "SZK006";

        /// <summary>
        /// SZK007.
        /// </summary>
        public const string SZK007 = "SZK007";

        /// <summary>
        /// SZK008.
        /// </summary>
        public const string SZK008 = "SZK008";

        /// <summary>
        /// SZK009.
        /// </summary>
        public const string SZK009 = "SZK009";

        /// <summary>
        /// SZK010.
        /// </summary>
        public const string SZK010 = "SZK010";

        /// <summary>
        /// SZLF.
        /// </summary>
        public const string SZLF = "SZLF";

        /// <summary>
        /// SZLMTH.
        /// </summary>
        public const string SZLMTH = "SZLMTH";

        /// <summary>
        /// SZRMST.
        /// </summary>
        public const string SZRMST = "SZRMST";

        /// <summary>
        /// SZSTDD.
        /// </summary>
        public const string SZSTDD = "SZSTDD";

        /// <summary>
        /// SZSTDH.
        /// </summary>
        public const string SZSTDH = "SZSTDH";

        /// <summary>
        /// SZSMKR.
        /// </summary>
        public const string SZSMKR = "SZSMKR";

        /// <summary>
        /// SZTIPE.
        /// </summary>
        public const string SZTIPE = "SZTIPE";

        /// <summary>
        /// SZMSA.
        /// </summary>
        public const string SZMSA = "SZMSA";

        /// <summary>
        /// SZADPN.
        /// </summary>
        public const string SZADPN = "SZADPN";

        /// <summary>
        /// SZAC01.
        /// </summary>
        public const string SZAC01 = "SZAC01";

        /// <summary>
        /// SZAC02.
        /// </summary>
        public const string SZAC02 = "SZAC02";

        /// <summary>
        /// SZAC03.
        /// </summary>
        public const string SZAC03 = "SZAC03";

        /// <summary>
        /// SZAC04.
        /// </summary>
        public const string SZAC04 = "SZAC04";

        /// <summary>
        /// SZAC05.
        /// </summary>
        public const string SZAC05 = "SZAC05";

        /// <summary>
        /// SZAC06.
        /// </summary>
        public const string SZAC06 = "SZAC06";

        /// <summary>
        /// SZAC07.
        /// </summary>
        public const string SZAC07 = "SZAC07";

        /// <summary>
        /// SZAC08.
        /// </summary>
        public const string SZAC08 = "SZAC08";

        /// <summary>
        /// SZAC09.
        /// </summary>
        public const string SZAC09 = "SZAC09";

        /// <summary>
        /// SZAC10.
        /// </summary>
        public const string SZAC10 = "SZAC10";

        /// <summary>
        /// SZAC11.
        /// </summary>
        public const string SZAC11 = "SZAC11";

        /// <summary>
        /// SZAC12.
        /// </summary>
        public const string SZAC12 = "SZAC12";

        /// <summary>
        /// SZAC13.
        /// </summary>
        public const string SZAC13 = "SZAC13";

        /// <summary>
        /// SZAC14.
        /// </summary>
        public const string SZAC14 = "SZAC14";

        /// <summary>
        /// SZAC15.
        /// </summary>
        public const string SZAC15 = "SZAC15";

        /// <summary>
        /// SZAC16.
        /// </summary>
        public const string SZAC16 = "SZAC16";

        /// <summary>
        /// SZAC17.
        /// </summary>
        public const string SZAC17 = "SZAC17";

        /// <summary>
        /// SZAC18.
        /// </summary>
        public const string SZAC18 = "SZAC18";

        /// <summary>
        /// SZAC19.
        /// </summary>
        public const string SZAC19 = "SZAC19";

        /// <summary>
        /// SZAC20.
        /// </summary>
        public const string SZAC20 = "SZAC20";

        /// <summary>
        /// SZAC21.
        /// </summary>
        public const string SZAC21 = "SZAC21";

        /// <summary>
        /// SZAC22.
        /// </summary>
        public const string SZAC22 = "SZAC22";

        /// <summary>
        /// SZAC23.
        /// </summary>
        public const string SZAC23 = "SZAC23";

        /// <summary>
        /// SZAC24.
        /// </summary>
        public const string SZAC24 = "SZAC24";

        /// <summary>
        /// SZAC25.
        /// </summary>
        public const string SZAC25 = "SZAC25";

        /// <summary>
        /// SZAC26.
        /// </summary>
        public const string SZAC26 = "SZAC26";

        /// <summary>
        /// SZAC27.
        /// </summary>
        public const string SZAC27 = "SZAC27";

        /// <summary>
        /// SZAC28.
        /// </summary>
        public const string SZAC28 = "SZAC28";

        /// <summary>
        /// SZAC29.
        /// </summary>
        public const string SZAC29 = "SZAC29";

        /// <summary>
        /// SZAC30.
        /// </summary>
        public const string SZAC30 = "SZAC30";

        /// <summary>
        /// SZORMCU.
        /// </summary>
        public const string SZORMCU = "SZORMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F060116Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEDUS", "SZEDUS", JdeDataType.String, 20, true, true),
        new JdeField("SZEDBT", "SZEDBT", JdeDataType.String, 30, true, true),
        new JdeField("SZEDTN", "SZEDTN", JdeDataType.String, 44, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4),
        new JdeField("SZTYTN", "SZTYTN", JdeDataType.String, 16),
        new JdeField("SZEDFT", "SZEDFT", JdeDataType.String, 20),
        new JdeField("SZEDDT", "SZEDDT", JdeDataType.Numeric),
        new JdeField("SZDRIN", "SZDRIN", JdeDataType.String, 2),
        new JdeField("SZEDDL", "SZEDDL", JdeDataType.Numeric),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZTNAC", "SZTNAC", JdeDataType.String, 4),
        new JdeField("SZAN8", "SZAN8", JdeDataType.Numeric),
        new JdeField("SZALPH", "SZALPH", JdeDataType.String, 80),
        new JdeField("SZSALU", "SZSALU", JdeDataType.String, 10),
        new JdeField("SZSUFF", "SZSUFF", JdeDataType.String, 10),
        new JdeField("SZMLNM", "SZMLNM", JdeDataType.String, 80),
        new JdeField("SZSSN", "SZSSN", JdeDataType.String, 40),
        new JdeField("SZAT1", "SZAT1", JdeDataType.String, 6),
        new JdeField("SZATE", "SZATE", JdeDataType.String, 2),
        new JdeField("SZHMCO", "SZHMCO", JdeDataType.String, 10),
        new JdeField("SZHMCU", "SZHMCU", JdeDataType.String, 24),
        new JdeField("SZANPA", "SZANPA", JdeDataType.Numeric),
        new JdeField("SZJBCD", "SZJBCD", JdeDataType.String, 12),
        new JdeField("SZJBST", "SZJBST", JdeDataType.String, 8),
        new JdeField("SZSAL", "SZSAL", JdeDataType.Numeric),
        new JdeField("SZPHRT", "SZPHRT", JdeDataType.Numeric),
        new JdeField("SZDSI", "SZDSI", JdeDataType.Numeric),
        new JdeField("SZEEOM", "SZEEOM", JdeDataType.String, 4),
        new JdeField("SZSEX", "SZSEX", JdeDataType.String, 2),
        new JdeField("SZDOB", "SZDOB", JdeDataType.Numeric),
        new JdeField("SZCCPR", "SZCCPR", JdeDataType.String, 6),
        new JdeField("SZHM01", "SZHM01", JdeDataType.String, 2),
        new JdeField("SZTARR", "SZTARR", JdeDataType.String, 20),
        new JdeField("SZTARA", "SZTARA", JdeDataType.String, 20),
        new JdeField("SZMSTX", "SZMSTX", JdeDataType.String, 2),
        new JdeField("SZMSTI", "SZMSTI", JdeDataType.String, 2),
        new JdeField("SZLMST", "SZLMST", JdeDataType.String, 2),
        new JdeField("SZSHFT", "SZSHFT", JdeDataType.String, 2),
        new JdeField("SZMAIL", "SZMAIL", JdeDataType.String, 20),
        new JdeField("SZSLOC", "SZSLOC", JdeDataType.String, 16),
        new JdeField("SZPAST", "SZPAST", JdeDataType.String, 2),
        new JdeField("SZEST", "SZEST", JdeDataType.String, 2),
        new JdeField("SZSDYY", "SZSDYY", JdeDataType.Numeric),
        new JdeField("SZPSDT", "SZPSDT", JdeDataType.Numeric),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZWSPS", "SZWSPS", JdeDataType.String, 2),
        new JdeField("SZNS", "SZNS", JdeDataType.String, 2),
        new JdeField("SZSUI", "SZSUI", JdeDataType.String, 2),
        new JdeField("SZRCCD", "SZRCCD", JdeDataType.String, 2),
        new JdeField("SZFICM", "SZFICM", JdeDataType.String, 2),
        new JdeField("SZAPPN", "SZAPPN", JdeDataType.Numeric),
        new JdeField("SZHM02", "SZHM02", JdeDataType.String, 2),
        new JdeField("SZHM03", "SZHM03", JdeDataType.String, 2),
        new JdeField("SZHM04", "SZHM04", JdeDataType.String, 2),
        new JdeField("SZPADT", "SZPADT", JdeDataType.Numeric),
        new JdeField("SZBENS", "SZBENS", JdeDataType.String, 2),
        new JdeField("SZPFRQ", "SZPFRQ", JdeDataType.String, 2),
        new JdeField("SZSALY", "SZSALY", JdeDataType.String, 2),
        new JdeField("SZPGRD", "SZPGRD", JdeDataType.String, 12),
        new JdeField("SZPGRS", "SZPGRS", JdeDataType.String, 8),
        new JdeField("SZFLSA", "SZFLSA", JdeDataType.String, 2),
        new JdeField("SZWCMP", "SZWCMP", JdeDataType.String, 8),
        new JdeField("SZWET", "SZWET", JdeDataType.String, 2),
        new JdeField("SZUN", "SZUN", JdeDataType.String, 12),
        new JdeField("SZDIVC", "SZDIVC", JdeDataType.String, 12),
        new JdeField("SZEEOJ", "SZEEOJ", JdeDataType.String, 6),
        new JdeField("SZADD1", "SZADD1", JdeDataType.String, 80),
        new JdeField("SZADD2", "SZADD2", JdeDataType.String, 80),
        new JdeField("SZADD3", "SZADD3", JdeDataType.String, 80),
        new JdeField("SZADD4", "SZADD4", JdeDataType.String, 80),
        new JdeField("SZCTY1", "SZCTY1", JdeDataType.String, 50),
        new JdeField("SZADDS", "SZADDS", JdeDataType.String, 6),
        new JdeField("SZADDZ", "SZADDZ", JdeDataType.String, 24),
        new JdeField("SZCTR", "SZCTR", JdeDataType.String, 6),
        new JdeField("SZAR1", "SZAR1", JdeDataType.String, 12),
        new JdeField("SZPH1", "SZPH1", JdeDataType.String, 40),
        new JdeField("SZAR3", "SZAR3", JdeDataType.String, 12),
        new JdeField("SZPH3", "SZPH3", JdeDataType.String, 40),
        new JdeField("SZWHO4", "SZWHO4", JdeDataType.String, 80),
        new JdeField("SZAR4", "SZAR4", JdeDataType.String, 12),
        new JdeField("SZPH4", "SZPH4", JdeDataType.String, 40),
        new JdeField("SZREM1", "SZREM1", JdeDataType.String, 80),
        new JdeField("SZREQN", "SZREQN", JdeDataType.Numeric),
        new JdeField("SZSALA", "SZSALA", JdeDataType.Numeric),
        new JdeField("SZSC01", "SZSC01", JdeDataType.String, 6),
        new JdeField("SZTRS", "SZTRS", JdeDataType.String, 6),
        new JdeField("SZEFTO", "SZEFTO", JdeDataType.Numeric),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZP001", "SZP001", JdeDataType.String, 6),
        new JdeField("SZP002", "SZP002", JdeDataType.String, 6),
        new JdeField("SZP003", "SZP003", JdeDataType.String, 6),
        new JdeField("SZP004", "SZP004", JdeDataType.String, 6),
        new JdeField("SZP005", "SZP005", JdeDataType.String, 6),
        new JdeField("SZP006", "SZP006", JdeDataType.String, 6),
        new JdeField("SZP007", "SZP007", JdeDataType.String, 6),
        new JdeField("SZP008", "SZP008", JdeDataType.String, 6),
        new JdeField("SZP009", "SZP009", JdeDataType.String, 6),
        new JdeField("SZP010", "SZP010", JdeDataType.String, 6),
        new JdeField("SZP011", "SZP011", JdeDataType.String, 6),
        new JdeField("SZP012", "SZP012", JdeDataType.String, 6),
        new JdeField("SZP013", "SZP013", JdeDataType.String, 6),
        new JdeField("SZP014", "SZP014", JdeDataType.String, 6),
        new JdeField("SZP015", "SZP015", JdeDataType.String, 6),
        new JdeField("SZP016", "SZP016", JdeDataType.String, 6),
        new JdeField("SZP017", "SZP017", JdeDataType.String, 6),
        new JdeField("SZP018", "SZP018", JdeDataType.String, 6),
        new JdeField("SZP019", "SZP019", JdeDataType.String, 6),
        new JdeField("SZP020", "SZP020", JdeDataType.String, 6),
        new JdeField("SZE001", "SZE001", JdeDataType.String, 2),
        new JdeField("SZE002", "SZE002", JdeDataType.String, 2),
        new JdeField("SZE003", "SZE003", JdeDataType.String, 2),
        new JdeField("SZE004", "SZE004", JdeDataType.String, 2),
        new JdeField("SZE005", "SZE005", JdeDataType.String, 2),
        new JdeField("SZE006", "SZE006", JdeDataType.String, 2),
        new JdeField("SZE007", "SZE007", JdeDataType.String, 2),
        new JdeField("SZE008", "SZE008", JdeDataType.String, 2),
        new JdeField("SZE009", "SZE009", JdeDataType.String, 2),
        new JdeField("SZE010", "SZE010", JdeDataType.String, 2),
        new JdeField("SZFTE", "SZFTE", JdeDataType.Numeric),
        new JdeField("SZIH", "SZIH", JdeDataType.Numeric),
        new JdeField("SZCOUN", "SZCOUN", JdeDataType.String, 50),
        new JdeField("SZPOS", "SZPOS", JdeDataType.String, 16),
        new JdeField("SZOEMP", "SZOEMP", JdeDataType.String, 16),
        new JdeField("SZIFN", "SZIFN", JdeDataType.String, 2),
        new JdeField("SZIMN", "SZIMN", JdeDataType.String, 2),
        new JdeField("SZDTSP", "SZDTSP", JdeDataType.Numeric),
        new JdeField("SZED01", "SZED01", JdeDataType.Numeric),
        new JdeField("SZED02", "SZED02", JdeDataType.Numeric),
        new JdeField("SZED03", "SZED03", JdeDataType.Numeric),
        new JdeField("SZED04", "SZED04", JdeDataType.Numeric),
        new JdeField("SZED05", "SZED05", JdeDataType.Numeric),
        new JdeField("SZED06", "SZED06", JdeDataType.Numeric),
        new JdeField("SZED07", "SZED07", JdeDataType.Numeric),
        new JdeField("SZED08", "SZED08", JdeDataType.Numeric),
        new JdeField("SZED09", "SZED09", JdeDataType.Numeric),
        new JdeField("SZED10", "SZED10", JdeDataType.Numeric),
        new JdeField("SZED11", "SZED11", JdeDataType.Numeric),
        new JdeField("SZED12", "SZED12", JdeDataType.Numeric),
        new JdeField("SZED13", "SZED13", JdeDataType.Numeric),
        new JdeField("SZED14", "SZED14", JdeDataType.Numeric),
        new JdeField("SZED15", "SZED15", JdeDataType.Numeric),
        new JdeField("SZED16", "SZED16", JdeDataType.Numeric),
        new JdeField("SZED17", "SZED17", JdeDataType.Numeric),
        new JdeField("SZED18", "SZED18", JdeDataType.Numeric),
        new JdeField("SZED19", "SZED19", JdeDataType.Numeric),
        new JdeField("SZED20", "SZED20", JdeDataType.Numeric),
        new JdeField("SZK001", "SZK001", JdeDataType.String, 2),
        new JdeField("SZK002", "SZK002", JdeDataType.String, 2),
        new JdeField("SZK003", "SZK003", JdeDataType.String, 2),
        new JdeField("SZK004", "SZK004", JdeDataType.String, 2),
        new JdeField("SZK005", "SZK005", JdeDataType.String, 2),
        new JdeField("SZK006", "SZK006", JdeDataType.String, 2),
        new JdeField("SZK007", "SZK007", JdeDataType.String, 2),
        new JdeField("SZK008", "SZK008", JdeDataType.String, 2),
        new JdeField("SZK009", "SZK009", JdeDataType.String, 2),
        new JdeField("SZK010", "SZK010", JdeDataType.String, 2),
        new JdeField("SZLF", "SZLF", JdeDataType.Numeric),
        new JdeField("SZLMTH", "SZLMTH", JdeDataType.String, 2),
        new JdeField("SZRMST", "SZRMST", JdeDataType.String, 2),
        new JdeField("SZSTDD", "SZSTDD", JdeDataType.Numeric),
        new JdeField("SZSTDH", "SZSTDH", JdeDataType.Numeric),
        new JdeField("SZSMKR", "SZSMKR", JdeDataType.String, 4),
        new JdeField("SZTIPE", "SZTIPE", JdeDataType.String, 2),
        new JdeField("SZMSA", "SZMSA", JdeDataType.String, 2),
        new JdeField("SZADPN", "SZADPN", JdeDataType.String, 2),
        new JdeField("SZAC01", "SZAC01", JdeDataType.String, 6),
        new JdeField("SZAC02", "SZAC02", JdeDataType.String, 6),
        new JdeField("SZAC03", "SZAC03", JdeDataType.String, 6),
        new JdeField("SZAC04", "SZAC04", JdeDataType.String, 6),
        new JdeField("SZAC05", "SZAC05", JdeDataType.String, 6),
        new JdeField("SZAC06", "SZAC06", JdeDataType.String, 6),
        new JdeField("SZAC07", "SZAC07", JdeDataType.String, 6),
        new JdeField("SZAC08", "SZAC08", JdeDataType.String, 6),
        new JdeField("SZAC09", "SZAC09", JdeDataType.String, 6),
        new JdeField("SZAC10", "SZAC10", JdeDataType.String, 6),
        new JdeField("SZAC11", "SZAC11", JdeDataType.String, 6),
        new JdeField("SZAC12", "SZAC12", JdeDataType.String, 6),
        new JdeField("SZAC13", "SZAC13", JdeDataType.String, 6),
        new JdeField("SZAC14", "SZAC14", JdeDataType.String, 6),
        new JdeField("SZAC15", "SZAC15", JdeDataType.String, 6),
        new JdeField("SZAC16", "SZAC16", JdeDataType.String, 6),
        new JdeField("SZAC17", "SZAC17", JdeDataType.String, 6),
        new JdeField("SZAC18", "SZAC18", JdeDataType.String, 6),
        new JdeField("SZAC19", "SZAC19", JdeDataType.String, 6),
        new JdeField("SZAC20", "SZAC20", JdeDataType.String, 6),
        new JdeField("SZAC21", "SZAC21", JdeDataType.String, 6),
        new JdeField("SZAC22", "SZAC22", JdeDataType.String, 6),
        new JdeField("SZAC23", "SZAC23", JdeDataType.String, 6),
        new JdeField("SZAC24", "SZAC24", JdeDataType.String, 6),
        new JdeField("SZAC25", "SZAC25", JdeDataType.String, 6),
        new JdeField("SZAC26", "SZAC26", JdeDataType.String, 6),
        new JdeField("SZAC27", "SZAC27", JdeDataType.String, 6),
        new JdeField("SZAC28", "SZAC28", JdeDataType.String, 6),
        new JdeField("SZAC29", "SZAC29", JdeDataType.String, 6),
        new JdeField("SZAC30", "SZAC30", JdeDataType.String, 6),
        new JdeField("SZORMCU", "SZORMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F060116Z_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F060116Z_2", "Index on SZAN8", new[] { "SZAN8" })
    };
}
