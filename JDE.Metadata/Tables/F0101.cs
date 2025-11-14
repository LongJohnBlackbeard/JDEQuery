using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0101 - .
/// </summary>
public class F0101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABAN8.
        /// </summary>
        public const string ABAN8 = "ABAN8";

        /// <summary>
        /// ABALKY.
        /// </summary>
        public const string ABALKY = "ABALKY";

        /// <summary>
        /// ABTAX.
        /// </summary>
        public const string ABTAX = "ABTAX";

        /// <summary>
        /// ABALPH.
        /// </summary>
        public const string ABALPH = "ABALPH";

        /// <summary>
        /// ABDC.
        /// </summary>
        public const string ABDC = "ABDC";

        /// <summary>
        /// ABMCU.
        /// </summary>
        public const string ABMCU = "ABMCU";

        /// <summary>
        /// ABSIC.
        /// </summary>
        public const string ABSIC = "ABSIC";

        /// <summary>
        /// ABLNGP.
        /// </summary>
        public const string ABLNGP = "ABLNGP";

        /// <summary>
        /// ABAT1.
        /// </summary>
        public const string ABAT1 = "ABAT1";

        /// <summary>
        /// ABCM.
        /// </summary>
        public const string ABCM = "ABCM";

        /// <summary>
        /// ABTAXC.
        /// </summary>
        public const string ABTAXC = "ABTAXC";

        /// <summary>
        /// ABAT2.
        /// </summary>
        public const string ABAT2 = "ABAT2";

        /// <summary>
        /// ABAT3.
        /// </summary>
        public const string ABAT3 = "ABAT3";

        /// <summary>
        /// ABAT4.
        /// </summary>
        public const string ABAT4 = "ABAT4";

        /// <summary>
        /// ABAT5.
        /// </summary>
        public const string ABAT5 = "ABAT5";

        /// <summary>
        /// ABATP.
        /// </summary>
        public const string ABATP = "ABATP";

        /// <summary>
        /// ABATR.
        /// </summary>
        public const string ABATR = "ABATR";

        /// <summary>
        /// ABATPR.
        /// </summary>
        public const string ABATPR = "ABATPR";

        /// <summary>
        /// ABAB3.
        /// </summary>
        public const string ABAB3 = "ABAB3";

        /// <summary>
        /// ABATE.
        /// </summary>
        public const string ABATE = "ABATE";

        /// <summary>
        /// ABSBLI.
        /// </summary>
        public const string ABSBLI = "ABSBLI";

        /// <summary>
        /// ABEFTB.
        /// </summary>
        public const string ABEFTB = "ABEFTB";

        /// <summary>
        /// ABAN81.
        /// </summary>
        public const string ABAN81 = "ABAN81";

        /// <summary>
        /// ABAN82.
        /// </summary>
        public const string ABAN82 = "ABAN82";

        /// <summary>
        /// ABAN83.
        /// </summary>
        public const string ABAN83 = "ABAN83";

        /// <summary>
        /// ABAN84.
        /// </summary>
        public const string ABAN84 = "ABAN84";

        /// <summary>
        /// ABAN86.
        /// </summary>
        public const string ABAN86 = "ABAN86";

        /// <summary>
        /// ABAN85.
        /// </summary>
        public const string ABAN85 = "ABAN85";

        /// <summary>
        /// ABAC01.
        /// </summary>
        public const string ABAC01 = "ABAC01";

        /// <summary>
        /// ABAC02.
        /// </summary>
        public const string ABAC02 = "ABAC02";

        /// <summary>
        /// ABAC03.
        /// </summary>
        public const string ABAC03 = "ABAC03";

        /// <summary>
        /// ABAC04.
        /// </summary>
        public const string ABAC04 = "ABAC04";

        /// <summary>
        /// ABAC05.
        /// </summary>
        public const string ABAC05 = "ABAC05";

        /// <summary>
        /// ABAC06.
        /// </summary>
        public const string ABAC06 = "ABAC06";

        /// <summary>
        /// ABAC07.
        /// </summary>
        public const string ABAC07 = "ABAC07";

        /// <summary>
        /// ABAC08.
        /// </summary>
        public const string ABAC08 = "ABAC08";

        /// <summary>
        /// ABAC09.
        /// </summary>
        public const string ABAC09 = "ABAC09";

        /// <summary>
        /// ABAC10.
        /// </summary>
        public const string ABAC10 = "ABAC10";

        /// <summary>
        /// ABAC11.
        /// </summary>
        public const string ABAC11 = "ABAC11";

        /// <summary>
        /// ABAC12.
        /// </summary>
        public const string ABAC12 = "ABAC12";

        /// <summary>
        /// ABAC13.
        /// </summary>
        public const string ABAC13 = "ABAC13";

        /// <summary>
        /// ABAC14.
        /// </summary>
        public const string ABAC14 = "ABAC14";

        /// <summary>
        /// ABAC15.
        /// </summary>
        public const string ABAC15 = "ABAC15";

        /// <summary>
        /// ABAC16.
        /// </summary>
        public const string ABAC16 = "ABAC16";

        /// <summary>
        /// ABAC17.
        /// </summary>
        public const string ABAC17 = "ABAC17";

        /// <summary>
        /// ABAC18.
        /// </summary>
        public const string ABAC18 = "ABAC18";

        /// <summary>
        /// ABAC19.
        /// </summary>
        public const string ABAC19 = "ABAC19";

        /// <summary>
        /// ABAC20.
        /// </summary>
        public const string ABAC20 = "ABAC20";

        /// <summary>
        /// ABAC21.
        /// </summary>
        public const string ABAC21 = "ABAC21";

        /// <summary>
        /// ABAC22.
        /// </summary>
        public const string ABAC22 = "ABAC22";

        /// <summary>
        /// ABAC23.
        /// </summary>
        public const string ABAC23 = "ABAC23";

        /// <summary>
        /// ABAC24.
        /// </summary>
        public const string ABAC24 = "ABAC24";

        /// <summary>
        /// ABAC25.
        /// </summary>
        public const string ABAC25 = "ABAC25";

        /// <summary>
        /// ABAC26.
        /// </summary>
        public const string ABAC26 = "ABAC26";

        /// <summary>
        /// ABAC27.
        /// </summary>
        public const string ABAC27 = "ABAC27";

        /// <summary>
        /// ABAC28.
        /// </summary>
        public const string ABAC28 = "ABAC28";

        /// <summary>
        /// ABAC29.
        /// </summary>
        public const string ABAC29 = "ABAC29";

        /// <summary>
        /// ABAC30.
        /// </summary>
        public const string ABAC30 = "ABAC30";

        /// <summary>
        /// ABGLBA.
        /// </summary>
        public const string ABGLBA = "ABGLBA";

        /// <summary>
        /// ABPTI.
        /// </summary>
        public const string ABPTI = "ABPTI";

        /// <summary>
        /// ABPDI.
        /// </summary>
        public const string ABPDI = "ABPDI";

        /// <summary>
        /// ABMSGA.
        /// </summary>
        public const string ABMSGA = "ABMSGA";

        /// <summary>
        /// ABRMK.
        /// </summary>
        public const string ABRMK = "ABRMK";

        /// <summary>
        /// ABTXCT.
        /// </summary>
        public const string ABTXCT = "ABTXCT";

        /// <summary>
        /// ABTX2.
        /// </summary>
        public const string ABTX2 = "ABTX2";

        /// <summary>
        /// ABALP1.
        /// </summary>
        public const string ABALP1 = "ABALP1";

        /// <summary>
        /// ABURCD.
        /// </summary>
        public const string ABURCD = "ABURCD";

        /// <summary>
        /// ABURDT.
        /// </summary>
        public const string ABURDT = "ABURDT";

        /// <summary>
        /// ABURAT.
        /// </summary>
        public const string ABURAT = "ABURAT";

        /// <summary>
        /// ABURAB.
        /// </summary>
        public const string ABURAB = "ABURAB";

        /// <summary>
        /// ABURRF.
        /// </summary>
        public const string ABURRF = "ABURRF";

        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABPID.
        /// </summary>
        public const string ABPID = "ABPID";

        /// <summary>
        /// ABUPMJ.
        /// </summary>
        public const string ABUPMJ = "ABUPMJ";

        /// <summary>
        /// ABJOBN.
        /// </summary>
        public const string ABJOBN = "ABJOBN";

        /// <summary>
        /// ABUPMT.
        /// </summary>
        public const string ABUPMT = "ABUPMT";

        /// <summary>
        /// ABPRGF.
        /// </summary>
        public const string ABPRGF = "ABPRGF";

        /// <summary>
        /// ABSCCLTP.
        /// </summary>
        public const string ABSCCLTP = "ABSCCLTP";

        /// <summary>
        /// ABTICKER.
        /// </summary>
        public const string ABTICKER = "ABTICKER";

        /// <summary>
        /// ABEXCHG.
        /// </summary>
        public const string ABEXCHG = "ABEXCHG";

        /// <summary>
        /// ABDUNS.
        /// </summary>
        public const string ABDUNS = "ABDUNS";

        /// <summary>
        /// ABCLASS01.
        /// </summary>
        public const string ABCLASS01 = "ABCLASS01";

        /// <summary>
        /// ABCLASS02.
        /// </summary>
        public const string ABCLASS02 = "ABCLASS02";

        /// <summary>
        /// ABCLASS03.
        /// </summary>
        public const string ABCLASS03 = "ABCLASS03";

        /// <summary>
        /// ABCLASS04.
        /// </summary>
        public const string ABCLASS04 = "ABCLASS04";

        /// <summary>
        /// ABCLASS05.
        /// </summary>
        public const string ABCLASS05 = "ABCLASS05";

        /// <summary>
        /// ABNOE.
        /// </summary>
        public const string ABNOE = "ABNOE";

        /// <summary>
        /// ABGROWTHR.
        /// </summary>
        public const string ABGROWTHR = "ABGROWTHR";

        /// <summary>
        /// ABYEARSTAR.
        /// </summary>
        public const string ABYEARSTAR = "ABYEARSTAR";

        /// <summary>
        /// ABAEMPGP.
        /// </summary>
        public const string ABAEMPGP = "ABAEMPGP";

        /// <summary>
        /// ABACTIN.
        /// </summary>
        public const string ABACTIN = "ABACTIN";

        /// <summary>
        /// ABREVRNG.
        /// </summary>
        public const string ABREVRNG = "ABREVRNG";

        /// <summary>
        /// ABSYNCS.
        /// </summary>
        public const string ABSYNCS = "ABSYNCS";

        /// <summary>
        /// ABPERRS.
        /// </summary>
        public const string ABPERRS = "ABPERRS";

        /// <summary>
        /// ABCAAD.
        /// </summary>
        public const string ABCAAD = "ABCAAD";
    }

    /// <inheritdoc />
    public override string TableName => "F0101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABAN8", "ABAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ABALKY", "ABALKY", JdeDataType.String, 40),
        new JdeField("ABTAX", "ABTAX", JdeDataType.String, 40),
        new JdeField("ABALPH", "ABALPH", JdeDataType.String, 80),
        new JdeField("ABDC", "ABDC", JdeDataType.String, 80),
        new JdeField("ABMCU", "ABMCU", JdeDataType.String, 24),
        new JdeField("ABSIC", "ABSIC", JdeDataType.String, 20),
        new JdeField("ABLNGP", "ABLNGP", JdeDataType.String, 4),
        new JdeField("ABAT1", "ABAT1", JdeDataType.String, 6),
        new JdeField("ABCM", "ABCM", JdeDataType.String, 4),
        new JdeField("ABTAXC", "ABTAXC", JdeDataType.String, 2),
        new JdeField("ABAT2", "ABAT2", JdeDataType.String, 2),
        new JdeField("ABAT3", "ABAT3", JdeDataType.String, 2),
        new JdeField("ABAT4", "ABAT4", JdeDataType.String, 2),
        new JdeField("ABAT5", "ABAT5", JdeDataType.String, 2),
        new JdeField("ABATP", "ABATP", JdeDataType.String, 2),
        new JdeField("ABATR", "ABATR", JdeDataType.String, 2),
        new JdeField("ABATPR", "ABATPR", JdeDataType.String, 2),
        new JdeField("ABAB3", "ABAB3", JdeDataType.String, 2),
        new JdeField("ABATE", "ABATE", JdeDataType.String, 2),
        new JdeField("ABSBLI", "ABSBLI", JdeDataType.String, 2),
        new JdeField("ABEFTB", "ABEFTB", JdeDataType.Numeric),
        new JdeField("ABAN81", "ABAN81", JdeDataType.Numeric),
        new JdeField("ABAN82", "ABAN82", JdeDataType.Numeric),
        new JdeField("ABAN83", "ABAN83", JdeDataType.Numeric),
        new JdeField("ABAN84", "ABAN84", JdeDataType.Numeric),
        new JdeField("ABAN86", "ABAN86", JdeDataType.Numeric),
        new JdeField("ABAN85", "ABAN85", JdeDataType.Numeric),
        new JdeField("ABAC01", "ABAC01", JdeDataType.String, 6),
        new JdeField("ABAC02", "ABAC02", JdeDataType.String, 6),
        new JdeField("ABAC03", "ABAC03", JdeDataType.String, 6),
        new JdeField("ABAC04", "ABAC04", JdeDataType.String, 6),
        new JdeField("ABAC05", "ABAC05", JdeDataType.String, 6),
        new JdeField("ABAC06", "ABAC06", JdeDataType.String, 6),
        new JdeField("ABAC07", "ABAC07", JdeDataType.String, 6),
        new JdeField("ABAC08", "ABAC08", JdeDataType.String, 6),
        new JdeField("ABAC09", "ABAC09", JdeDataType.String, 6),
        new JdeField("ABAC10", "ABAC10", JdeDataType.String, 6),
        new JdeField("ABAC11", "ABAC11", JdeDataType.String, 6),
        new JdeField("ABAC12", "ABAC12", JdeDataType.String, 6),
        new JdeField("ABAC13", "ABAC13", JdeDataType.String, 6),
        new JdeField("ABAC14", "ABAC14", JdeDataType.String, 6),
        new JdeField("ABAC15", "ABAC15", JdeDataType.String, 6),
        new JdeField("ABAC16", "ABAC16", JdeDataType.String, 6),
        new JdeField("ABAC17", "ABAC17", JdeDataType.String, 6),
        new JdeField("ABAC18", "ABAC18", JdeDataType.String, 6),
        new JdeField("ABAC19", "ABAC19", JdeDataType.String, 6),
        new JdeField("ABAC20", "ABAC20", JdeDataType.String, 6),
        new JdeField("ABAC21", "ABAC21", JdeDataType.String, 6),
        new JdeField("ABAC22", "ABAC22", JdeDataType.String, 6),
        new JdeField("ABAC23", "ABAC23", JdeDataType.String, 6),
        new JdeField("ABAC24", "ABAC24", JdeDataType.String, 6),
        new JdeField("ABAC25", "ABAC25", JdeDataType.String, 6),
        new JdeField("ABAC26", "ABAC26", JdeDataType.String, 6),
        new JdeField("ABAC27", "ABAC27", JdeDataType.String, 6),
        new JdeField("ABAC28", "ABAC28", JdeDataType.String, 6),
        new JdeField("ABAC29", "ABAC29", JdeDataType.String, 6),
        new JdeField("ABAC30", "ABAC30", JdeDataType.String, 6),
        new JdeField("ABGLBA", "ABGLBA", JdeDataType.String, 16),
        new JdeField("ABPTI", "ABPTI", JdeDataType.Numeric),
        new JdeField("ABPDI", "ABPDI", JdeDataType.Numeric),
        new JdeField("ABMSGA", "ABMSGA", JdeDataType.String, 2),
        new JdeField("ABRMK", "ABRMK", JdeDataType.String, 60),
        new JdeField("ABTXCT", "ABTXCT", JdeDataType.String, 40),
        new JdeField("ABTX2", "ABTX2", JdeDataType.String, 40),
        new JdeField("ABALP1", "ABALP1", JdeDataType.String, 80),
        new JdeField("ABURCD", "ABURCD", JdeDataType.String, 4),
        new JdeField("ABURDT", "ABURDT", JdeDataType.Numeric),
        new JdeField("ABURAT", "ABURAT", JdeDataType.Numeric),
        new JdeField("ABURAB", "ABURAB", JdeDataType.Numeric),
        new JdeField("ABURRF", "ABURRF", JdeDataType.String, 30),
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20),
        new JdeField("ABPID", "ABPID", JdeDataType.String, 20),
        new JdeField("ABUPMJ", "ABUPMJ", JdeDataType.Numeric),
        new JdeField("ABJOBN", "ABJOBN", JdeDataType.String, 20),
        new JdeField("ABUPMT", "ABUPMT", JdeDataType.Numeric),
        new JdeField("ABPRGF", "ABPRGF", JdeDataType.String, 2),
        new JdeField("ABSCCLTP", "ABSCCLTP", JdeDataType.String, 4),
        new JdeField("ABTICKER", "ABTICKER", JdeDataType.String, 20),
        new JdeField("ABEXCHG", "ABEXCHG", JdeDataType.String, 20),
        new JdeField("ABDUNS", "ABDUNS", JdeDataType.String, 26),
        new JdeField("ABCLASS01", "ABCLASS01", JdeDataType.String, 6),
        new JdeField("ABCLASS02", "ABCLASS02", JdeDataType.String, 6),
        new JdeField("ABCLASS03", "ABCLASS03", JdeDataType.String, 6),
        new JdeField("ABCLASS04", "ABCLASS04", JdeDataType.String, 6),
        new JdeField("ABCLASS05", "ABCLASS05", JdeDataType.String, 6),
        new JdeField("ABNOE", "ABNOE", JdeDataType.Numeric),
        new JdeField("ABGROWTHR", "ABGROWTHR", JdeDataType.Numeric),
        new JdeField("ABYEARSTAR", "ABYEARSTAR", JdeDataType.String, 30),
        new JdeField("ABAEMPGP", "ABAEMPGP", JdeDataType.String, 10),
        new JdeField("ABACTIN", "ABACTIN", JdeDataType.String, 2),
        new JdeField("ABREVRNG", "ABREVRNG", JdeDataType.String, 10),
        new JdeField("ABSYNCS", "ABSYNCS", JdeDataType.Numeric),
        new JdeField("ABPERRS", "ABPERRS", JdeDataType.Numeric),
        new JdeField("ABCAAD", "ABCAAD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0101_0", "Primary Key on ABAN8", new[] { "ABAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0101_10", "Index on ABAT1, ABAC01, ABAC04, ABDC", new[] { "ABAT1", "ABAC01", "ABAC04", "ABDC" }),
        new JdeIndex("F0101_11", "Index on ABAT1, ABAC01, ABAC03, ABDC", new[] { "ABAT1", "ABAC01", "ABAC03", "ABDC" }),
        new JdeIndex("F0101_12", "Index on ABAT1, ABAC01, ABAC02, ABDC", new[] { "ABAT1", "ABAC01", "ABAC02", "ABDC" }),
        new JdeIndex("F0101_13", "Index on ABAT1, ABAC01, ABDC", new[] { "ABAT1", "ABAC01", "ABDC" }),
        new JdeIndex("F0101_14", "Index on ABAN8, ABTX2", new[] { "ABAN8", "ABTX2" }),
        new JdeIndex("F0101_15", "Index on ABALPH", new[] { "ABALPH" }),
        new JdeIndex("F0101_2", "Index on ABDC", new[] { "ABDC" }),
        new JdeIndex("F0101_3", "Index on ABALKY", new[] { "ABALKY" }),
        new JdeIndex("F0101_4", "Index on ABTAX", new[] { "ABTAX" }),
        new JdeIndex("F0101_5", "Index on ABAT1, ABDC", new[] { "ABAT1", "ABDC" }),
        new JdeIndex("F0101_6", "Index on ABAC01, ABAC04, ABDC", new[] { "ABAC01", "ABAC04", "ABDC" }),
        new JdeIndex("F0101_7", "Index on ABAC01, ABAC03, ABDC", new[] { "ABAC01", "ABAC03", "ABDC" }),
        new JdeIndex("F0101_8", "Index on ABAC01, ABAC02, ABDC", new[] { "ABAC01", "ABAC02", "ABDC" }),
        new JdeIndex("F0101_9", "Index on ABAC01, ABDC", new[] { "ABAC01", "ABDC" })
    };
}
