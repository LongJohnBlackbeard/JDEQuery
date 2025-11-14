using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0101Z2 - .
/// </summary>
public class F0101Z2 : JdeTable
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
        /// SZALKY.
        /// </summary>
        public const string SZALKY = "SZALKY";

        /// <summary>
        /// SZTAX.
        /// </summary>
        public const string SZTAX = "SZTAX";

        /// <summary>
        /// SZALPH.
        /// </summary>
        public const string SZALPH = "SZALPH";

        /// <summary>
        /// SZDC.
        /// </summary>
        public const string SZDC = "SZDC";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZSIC.
        /// </summary>
        public const string SZSIC = "SZSIC";

        /// <summary>
        /// SZLNGP.
        /// </summary>
        public const string SZLNGP = "SZLNGP";

        /// <summary>
        /// SZAT1.
        /// </summary>
        public const string SZAT1 = "SZAT1";

        /// <summary>
        /// SZCM.
        /// </summary>
        public const string SZCM = "SZCM";

        /// <summary>
        /// SZTAXC.
        /// </summary>
        public const string SZTAXC = "SZTAXC";

        /// <summary>
        /// SZAT2.
        /// </summary>
        public const string SZAT2 = "SZAT2";

        /// <summary>
        /// SZAT3.
        /// </summary>
        public const string SZAT3 = "SZAT3";

        /// <summary>
        /// SZAT4.
        /// </summary>
        public const string SZAT4 = "SZAT4";

        /// <summary>
        /// SZATR.
        /// </summary>
        public const string SZATR = "SZATR";

        /// <summary>
        /// SZAT5.
        /// </summary>
        public const string SZAT5 = "SZAT5";

        /// <summary>
        /// SZATP.
        /// </summary>
        public const string SZATP = "SZATP";

        /// <summary>
        /// SZATPR.
        /// </summary>
        public const string SZATPR = "SZATPR";

        /// <summary>
        /// SZAB3.
        /// </summary>
        public const string SZAB3 = "SZAB3";

        /// <summary>
        /// SZATE.
        /// </summary>
        public const string SZATE = "SZATE";

        /// <summary>
        /// SZSBLI.
        /// </summary>
        public const string SZSBLI = "SZSBLI";

        /// <summary>
        /// SZEFTB.
        /// </summary>
        public const string SZEFTB = "SZEFTB";

        /// <summary>
        /// SZAN81.
        /// </summary>
        public const string SZAN81 = "SZAN81";

        /// <summary>
        /// SZAN82.
        /// </summary>
        public const string SZAN82 = "SZAN82";

        /// <summary>
        /// SZAN83.
        /// </summary>
        public const string SZAN83 = "SZAN83";

        /// <summary>
        /// SZAN84.
        /// </summary>
        public const string SZAN84 = "SZAN84";

        /// <summary>
        /// SZAN86.
        /// </summary>
        public const string SZAN86 = "SZAN86";

        /// <summary>
        /// SZAN85.
        /// </summary>
        public const string SZAN85 = "SZAN85";

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
        /// SZGLBA.
        /// </summary>
        public const string SZGLBA = "SZGLBA";

        /// <summary>
        /// SZPTI.
        /// </summary>
        public const string SZPTI = "SZPTI";

        /// <summary>
        /// SZPDI.
        /// </summary>
        public const string SZPDI = "SZPDI";

        /// <summary>
        /// SZMSGA.
        /// </summary>
        public const string SZMSGA = "SZMSGA";

        /// <summary>
        /// SZRMK.
        /// </summary>
        public const string SZRMK = "SZRMK";

        /// <summary>
        /// SZTXCT.
        /// </summary>
        public const string SZTXCT = "SZTXCT";

        /// <summary>
        /// SZTX2.
        /// </summary>
        public const string SZTX2 = "SZTX2";

        /// <summary>
        /// SZALP1.
        /// </summary>
        public const string SZALP1 = "SZALP1";

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
        /// SZMLNM.
        /// </summary>
        public const string SZMLNM = "SZMLNM";

        /// <summary>
        /// SZMLN1.
        /// </summary>
        public const string SZMLN1 = "SZMLN1";

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
        /// SZADDZ.
        /// </summary>
        public const string SZADDZ = "SZADDZ";

        /// <summary>
        /// SZCTY1.
        /// </summary>
        public const string SZCTY1 = "SZCTY1";

        /// <summary>
        /// SZCTR.
        /// </summary>
        public const string SZCTR = "SZCTR";

        /// <summary>
        /// SZADDS.
        /// </summary>
        public const string SZADDS = "SZADDS";

        /// <summary>
        /// SZCOUN.
        /// </summary>
        public const string SZCOUN = "SZCOUN";

        /// <summary>
        /// SZAR1.
        /// </summary>
        public const string SZAR1 = "SZAR1";

        /// <summary>
        /// SZPH1.
        /// </summary>
        public const string SZPH1 = "SZPH1";

        /// <summary>
        /// SZPHT1.
        /// </summary>
        public const string SZPHT1 = "SZPHT1";

        /// <summary>
        /// SZAR2.
        /// </summary>
        public const string SZAR2 = "SZAR2";

        /// <summary>
        /// SZPH2.
        /// </summary>
        public const string SZPH2 = "SZPH2";

        /// <summary>
        /// SZPHT2.
        /// </summary>
        public const string SZPHT2 = "SZPHT2";

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
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";

        /// <summary>
        /// SZPRGF.
        /// </summary>
        public const string SZPRGF = "SZPRGF";

        /// <summary>
        /// SZSCCLTP.
        /// </summary>
        public const string SZSCCLTP = "SZSCCLTP";

        /// <summary>
        /// SZPA8.
        /// </summary>
        public const string SZPA8 = "SZPA8";

        /// <summary>
        /// SZTICKER.
        /// </summary>
        public const string SZTICKER = "SZTICKER";

        /// <summary>
        /// SZEXCHG.
        /// </summary>
        public const string SZEXCHG = "SZEXCHG";

        /// <summary>
        /// SZDUNS.
        /// </summary>
        public const string SZDUNS = "SZDUNS";

        /// <summary>
        /// SZCLASS01.
        /// </summary>
        public const string SZCLASS01 = "SZCLASS01";

        /// <summary>
        /// SZCLASS02.
        /// </summary>
        public const string SZCLASS02 = "SZCLASS02";

        /// <summary>
        /// SZCLASS03.
        /// </summary>
        public const string SZCLASS03 = "SZCLASS03";

        /// <summary>
        /// SZCLASS04.
        /// </summary>
        public const string SZCLASS04 = "SZCLASS04";

        /// <summary>
        /// SZCLASS05.
        /// </summary>
        public const string SZCLASS05 = "SZCLASS05";

        /// <summary>
        /// SZNOE.
        /// </summary>
        public const string SZNOE = "SZNOE";

        /// <summary>
        /// SZGROWTHR.
        /// </summary>
        public const string SZGROWTHR = "SZGROWTHR";

        /// <summary>
        /// SZYEARSTAR.
        /// </summary>
        public const string SZYEARSTAR = "SZYEARSTAR";

        /// <summary>
        /// SZAEMPGP.
        /// </summary>
        public const string SZAEMPGP = "SZAEMPGP";

        /// <summary>
        /// SZACTIN.
        /// </summary>
        public const string SZACTIN = "SZACTIN";

        /// <summary>
        /// SZREVRNG.
        /// </summary>
        public const string SZREVRNG = "SZREVRNG";
    }

    /// <inheritdoc />
    public override string TableName => "F0101Z2";

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
        new JdeField("SZALKY", "SZALKY", JdeDataType.String, 40),
        new JdeField("SZTAX", "SZTAX", JdeDataType.String, 40),
        new JdeField("SZALPH", "SZALPH", JdeDataType.String, 80),
        new JdeField("SZDC", "SZDC", JdeDataType.String, 80),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZSIC", "SZSIC", JdeDataType.String, 20),
        new JdeField("SZLNGP", "SZLNGP", JdeDataType.String, 4),
        new JdeField("SZAT1", "SZAT1", JdeDataType.String, 6),
        new JdeField("SZCM", "SZCM", JdeDataType.String, 4),
        new JdeField("SZTAXC", "SZTAXC", JdeDataType.String, 2),
        new JdeField("SZAT2", "SZAT2", JdeDataType.String, 2),
        new JdeField("SZAT3", "SZAT3", JdeDataType.String, 2),
        new JdeField("SZAT4", "SZAT4", JdeDataType.String, 2),
        new JdeField("SZATR", "SZATR", JdeDataType.String, 2),
        new JdeField("SZAT5", "SZAT5", JdeDataType.String, 2),
        new JdeField("SZATP", "SZATP", JdeDataType.String, 2),
        new JdeField("SZATPR", "SZATPR", JdeDataType.String, 2),
        new JdeField("SZAB3", "SZAB3", JdeDataType.String, 2),
        new JdeField("SZATE", "SZATE", JdeDataType.String, 2),
        new JdeField("SZSBLI", "SZSBLI", JdeDataType.String, 2),
        new JdeField("SZEFTB", "SZEFTB", JdeDataType.Numeric),
        new JdeField("SZAN81", "SZAN81", JdeDataType.Numeric),
        new JdeField("SZAN82", "SZAN82", JdeDataType.Numeric),
        new JdeField("SZAN83", "SZAN83", JdeDataType.Numeric),
        new JdeField("SZAN84", "SZAN84", JdeDataType.Numeric),
        new JdeField("SZAN86", "SZAN86", JdeDataType.Numeric),
        new JdeField("SZAN85", "SZAN85", JdeDataType.Numeric),
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
        new JdeField("SZGLBA", "SZGLBA", JdeDataType.String, 16),
        new JdeField("SZPTI", "SZPTI", JdeDataType.Numeric),
        new JdeField("SZPDI", "SZPDI", JdeDataType.Numeric),
        new JdeField("SZMSGA", "SZMSGA", JdeDataType.String, 2),
        new JdeField("SZRMK", "SZRMK", JdeDataType.String, 60),
        new JdeField("SZTXCT", "SZTXCT", JdeDataType.String, 40),
        new JdeField("SZTX2", "SZTX2", JdeDataType.String, 40),
        new JdeField("SZALP1", "SZALP1", JdeDataType.String, 80),
        new JdeField("SZURCD", "SZURCD", JdeDataType.String, 4),
        new JdeField("SZURDT", "SZURDT", JdeDataType.Numeric),
        new JdeField("SZURAT", "SZURAT", JdeDataType.Numeric),
        new JdeField("SZURAB", "SZURAB", JdeDataType.Numeric),
        new JdeField("SZURRF", "SZURRF", JdeDataType.String, 30),
        new JdeField("SZMLNM", "SZMLNM", JdeDataType.String, 80),
        new JdeField("SZMLN1", "SZMLN1", JdeDataType.String, 80),
        new JdeField("SZADD1", "SZADD1", JdeDataType.String, 80),
        new JdeField("SZADD2", "SZADD2", JdeDataType.String, 80),
        new JdeField("SZADD3", "SZADD3", JdeDataType.String, 80),
        new JdeField("SZADD4", "SZADD4", JdeDataType.String, 80),
        new JdeField("SZADDZ", "SZADDZ", JdeDataType.String, 24),
        new JdeField("SZCTY1", "SZCTY1", JdeDataType.String, 50),
        new JdeField("SZCTR", "SZCTR", JdeDataType.String, 6),
        new JdeField("SZADDS", "SZADDS", JdeDataType.String, 6),
        new JdeField("SZCOUN", "SZCOUN", JdeDataType.String, 50),
        new JdeField("SZAR1", "SZAR1", JdeDataType.String, 12),
        new JdeField("SZPH1", "SZPH1", JdeDataType.String, 40),
        new JdeField("SZPHT1", "SZPHT1", JdeDataType.String, 8),
        new JdeField("SZAR2", "SZAR2", JdeDataType.String, 12),
        new JdeField("SZPH2", "SZPH2", JdeDataType.String, 40),
        new JdeField("SZPHT2", "SZPHT2", JdeDataType.String, 8),
        new JdeField("SZTORG", "SZTORG", JdeDataType.String, 20),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric),
        new JdeField("SZPRGF", "SZPRGF", JdeDataType.String, 2),
        new JdeField("SZSCCLTP", "SZSCCLTP", JdeDataType.String, 4),
        new JdeField("SZPA8", "SZPA8", JdeDataType.Numeric),
        new JdeField("SZTICKER", "SZTICKER", JdeDataType.String, 20),
        new JdeField("SZEXCHG", "SZEXCHG", JdeDataType.String, 20),
        new JdeField("SZDUNS", "SZDUNS", JdeDataType.String, 26),
        new JdeField("SZCLASS01", "SZCLASS01", JdeDataType.String, 6),
        new JdeField("SZCLASS02", "SZCLASS02", JdeDataType.String, 6),
        new JdeField("SZCLASS03", "SZCLASS03", JdeDataType.String, 6),
        new JdeField("SZCLASS04", "SZCLASS04", JdeDataType.String, 6),
        new JdeField("SZCLASS05", "SZCLASS05", JdeDataType.String, 6),
        new JdeField("SZNOE", "SZNOE", JdeDataType.Numeric),
        new JdeField("SZGROWTHR", "SZGROWTHR", JdeDataType.Numeric),
        new JdeField("SZYEARSTAR", "SZYEARSTAR", JdeDataType.String, 30),
        new JdeField("SZAEMPGP", "SZAEMPGP", JdeDataType.String, 10),
        new JdeField("SZACTIN", "SZACTIN", JdeDataType.String, 2),
        new JdeField("SZREVRNG", "SZREVRNG", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0101Z2_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0101Z2_2", "Index on SZEDUS, SZEDBT", new[] { "SZEDUS", "SZEDBT" })
    };
}
