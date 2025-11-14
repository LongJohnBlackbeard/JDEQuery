using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05137 - .
/// </summary>
public class F05137 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ADCHGF.
        /// </summary>
        public const string ADCHGF = "ADCHGF";

        /// <summary>
        /// ADPAYBN.
        /// </summary>
        public const string ADPAYBN = "ADPAYBN";

        /// <summary>
        /// ADAN8.
        /// </summary>
        public const string ADAN8 = "ADAN8";

        /// <summary>
        /// ADNDEP.
        /// </summary>
        public const string ADNDEP = "ADNDEP";

        /// <summary>
        /// ADDOB.
        /// </summary>
        public const string ADDOB = "ADDOB";

        /// <summary>
        /// ADEEOM.
        /// </summary>
        public const string ADEEOM = "ADEEOM";

        /// <summary>
        /// ADEST.
        /// </summary>
        public const string ADEST = "ADEST";

        /// <summary>
        /// ADSEX.
        /// </summary>
        public const string ADSEX = "ADSEX";

        /// <summary>
        /// ADDST.
        /// </summary>
        public const string ADDST = "ADDST";

        /// <summary>
        /// ADPAST.
        /// </summary>
        public const string ADPAST = "ADPAST";

        /// <summary>
        /// ADHMCU.
        /// </summary>
        public const string ADHMCU = "ADHMCU";

        /// <summary>
        /// ADSHFT.
        /// </summary>
        public const string ADSHFT = "ADSHFT";

        /// <summary>
        /// ADSSN.
        /// </summary>
        public const string ADSSN = "ADSSN";

        /// <summary>
        /// ADUN.
        /// </summary>
        public const string ADUN = "ADUN";

        /// <summary>
        /// ADHM02.
        /// </summary>
        public const string ADHM02 = "ADHM02";

        /// <summary>
        /// ADEEOJ.
        /// </summary>
        public const string ADEEOJ = "ADEEOJ";

        /// <summary>
        /// ADFLSA.
        /// </summary>
        public const string ADFLSA = "ADFLSA";

        /// <summary>
        /// ADPFRQ.
        /// </summary>
        public const string ADPFRQ = "ADPFRQ";

        /// <summary>
        /// ADPGRD.
        /// </summary>
        public const string ADPGRD = "ADPGRD";

        /// <summary>
        /// ADPGRS.
        /// </summary>
        public const string ADPGRS = "ADPGRS";

        /// <summary>
        /// ADSAL.
        /// </summary>
        public const string ADSAL = "ADSAL";

        /// <summary>
        /// ADPHRT.
        /// </summary>
        public const string ADPHRT = "ADPHRT";

        /// <summary>
        /// ADSALY.
        /// </summary>
        public const string ADSALY = "ADSALY";

        /// <summary>
        /// ADIH.
        /// </summary>
        public const string ADIH = "ADIH";

        /// <summary>
        /// ADSTDH.
        /// </summary>
        public const string ADSTDH = "ADSTDH";

        /// <summary>
        /// ADSTDD.
        /// </summary>
        public const string ADSTDD = "ADSTDD";

        /// <summary>
        /// ADANPA.
        /// </summary>
        public const string ADANPA = "ADANPA";

        /// <summary>
        /// ADWCMP.
        /// </summary>
        public const string ADWCMP = "ADWCMP";

        /// <summary>
        /// ADEIC.
        /// </summary>
        public const string ADEIC = "ADEIC";

        /// <summary>
        /// ADMSTX.
        /// </summary>
        public const string ADMSTX = "ADMSTX";

        /// <summary>
        /// ADTARR.
        /// </summary>
        public const string ADTARR = "ADTARR";

        /// <summary>
        /// ADSCDC.
        /// </summary>
        public const string ADSCDC = "ADSCDC";

        /// <summary>
        /// ADMSTI.
        /// </summary>
        public const string ADMSTI = "ADMSTI";

        /// <summary>
        /// ADSUI.
        /// </summary>
        public const string ADSUI = "ADSUI";

        /// <summary>
        /// ADTARA.
        /// </summary>
        public const string ADTARA = "ADTARA";

        /// <summary>
        /// ADHMCO.
        /// </summary>
        public const string ADHMCO = "ADHMCO";

        /// <summary>
        /// ADNRVW.
        /// </summary>
        public const string ADNRVW = "ADNRVW";

        /// <summary>
        /// ADPSDT.
        /// </summary>
        public const string ADPSDT = "ADPSDT";

        /// <summary>
        /// ADDSI.
        /// </summary>
        public const string ADDSI = "ADDSI";

        /// <summary>
        /// ADLADT.
        /// </summary>
        public const string ADLADT = "ADLADT";

        /// <summary>
        /// ADLSDT.
        /// </summary>
        public const string ADLSDT = "ADLSDT";

        /// <summary>
        /// ADDT.
        /// </summary>
        public const string ADDT = "ADDT";

        /// <summary>
        /// ADFICM.
        /// </summary>
        public const string ADFICM = "ADFICM";

        /// <summary>
        /// ADGNNM.
        /// </summary>
        public const string ADGNNM = "ADGNNM";

        /// <summary>
        /// ADSRNM.
        /// </summary>
        public const string ADSRNM = "ADSRNM";

        /// <summary>
        /// ADMDNM.
        /// </summary>
        public const string ADMDNM = "ADMDNM";

        /// <summary>
        /// ADAR1.
        /// </summary>
        public const string ADAR1 = "ADAR1";

        /// <summary>
        /// ADPH1.
        /// </summary>
        public const string ADPH1 = "ADPH1";

        /// <summary>
        /// ADPHTP.
        /// </summary>
        public const string ADPHTP = "ADPHTP";

        /// <summary>
        /// ADAR2.
        /// </summary>
        public const string ADAR2 = "ADAR2";

        /// <summary>
        /// ADPH2.
        /// </summary>
        public const string ADPH2 = "ADPH2";

        /// <summary>
        /// ADPHT2.
        /// </summary>
        public const string ADPHT2 = "ADPHT2";

        /// <summary>
        /// ADADD1.
        /// </summary>
        public const string ADADD1 = "ADADD1";

        /// <summary>
        /// ADADD2.
        /// </summary>
        public const string ADADD2 = "ADADD2";

        /// <summary>
        /// ADADD3.
        /// </summary>
        public const string ADADD3 = "ADADD3";

        /// <summary>
        /// ADADD4.
        /// </summary>
        public const string ADADD4 = "ADADD4";

        /// <summary>
        /// ADCTY1.
        /// </summary>
        public const string ADCTY1 = "ADCTY1";

        /// <summary>
        /// ADADDS.
        /// </summary>
        public const string ADADDS = "ADADDS";

        /// <summary>
        /// ADADDZ.
        /// </summary>
        public const string ADADDZ = "ADADDZ";

        /// <summary>
        /// ADEMAL.
        /// </summary>
        public const string ADEMAL = "ADEMAL";

        /// <summary>
        /// ADETP.
        /// </summary>
        public const string ADETP = "ADETP";

        /// <summary>
        /// ADMSA.
        /// </summary>
        public const string ADMSA = "ADMSA";

        /// <summary>
        /// ADTINCL.
        /// </summary>
        public const string ADTINCL = "ADTINCL";

        /// <summary>
        /// ADJBCX.
        /// </summary>
        public const string ADJBCX = "ADJBCX";

        /// <summary>
        /// ADDATRVW.
        /// </summary>
        public const string ADDATRVW = "ADDATRVW";

        /// <summary>
        /// ADLSRD.
        /// </summary>
        public const string ADLSRD = "ADLSRD";

        /// <summary>
        /// ADNSRD.
        /// </summary>
        public const string ADNSRD = "ADNSRD";

        /// <summary>
        /// ADRWTYP.
        /// </summary>
        public const string ADRWTYP = "ADRWTYP";

        /// <summary>
        /// ADPRNM.
        /// </summary>
        public const string ADPRNM = "ADPRNM";

        /// <summary>
        /// ADAPS.
        /// </summary>
        public const string ADAPS = "ADAPS";

        /// <summary>
        /// ADUPMJ.
        /// </summary>
        public const string ADUPMJ = "ADUPMJ";

        /// <summary>
        /// ADLVEL.
        /// </summary>
        public const string ADLVEL = "ADLVEL";

        /// <summary>
        /// ADAPPST.
        /// </summary>
        public const string ADAPPST = "ADAPPST";

        /// <summary>
        /// ADAPPTY.
        /// </summary>
        public const string ADAPPTY = "ADAPPTY";

        /// <summary>
        /// ADADP01.
        /// </summary>
        public const string ADADP01 = "ADADP01";

        /// <summary>
        /// ADADP02.
        /// </summary>
        public const string ADADP02 = "ADADP02";

        /// <summary>
        /// ADADP03.
        /// </summary>
        public const string ADADP03 = "ADADP03";

        /// <summary>
        /// ADADP04.
        /// </summary>
        public const string ADADP04 = "ADADP04";

        /// <summary>
        /// ADADP05.
        /// </summary>
        public const string ADADP05 = "ADADP05";

        /// <summary>
        /// ADADP11.
        /// </summary>
        public const string ADADP11 = "ADADP11";

        /// <summary>
        /// ADADP12.
        /// </summary>
        public const string ADADP12 = "ADADP12";

        /// <summary>
        /// ADADP13.
        /// </summary>
        public const string ADADP13 = "ADADP13";

        /// <summary>
        /// ADADP14.
        /// </summary>
        public const string ADADP14 = "ADADP14";

        /// <summary>
        /// ADADP15.
        /// </summary>
        public const string ADADP15 = "ADADP15";

        /// <summary>
        /// ADADP21.
        /// </summary>
        public const string ADADP21 = "ADADP21";

        /// <summary>
        /// ADADP22.
        /// </summary>
        public const string ADADP22 = "ADADP22";

        /// <summary>
        /// ADADP23.
        /// </summary>
        public const string ADADP23 = "ADADP23";

        /// <summary>
        /// ADADP24.
        /// </summary>
        public const string ADADP24 = "ADADP24";

        /// <summary>
        /// ADADP25.
        /// </summary>
        public const string ADADP25 = "ADADP25";

        /// <summary>
        /// ADADP31.
        /// </summary>
        public const string ADADP31 = "ADADP31";

        /// <summary>
        /// ADADP32.
        /// </summary>
        public const string ADADP32 = "ADADP32";

        /// <summary>
        /// ADADP33.
        /// </summary>
        public const string ADADP33 = "ADADP33";

        /// <summary>
        /// ADADP34.
        /// </summary>
        public const string ADADP34 = "ADADP34";

        /// <summary>
        /// ADADP35.
        /// </summary>
        public const string ADADP35 = "ADADP35";
    }

    /// <inheritdoc />
    public override string TableName => "F05137";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ADCHGF", "ADCHGF", JdeDataType.String, 2),
        new JdeField("ADPAYBN", "ADPAYBN", JdeDataType.Numeric, null, true, true),
        new JdeField("ADAN8", "ADAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ADNDEP", "ADNDEP", JdeDataType.Numeric),
        new JdeField("ADDOB", "ADDOB", JdeDataType.Numeric),
        new JdeField("ADEEOM", "ADEEOM", JdeDataType.String, 4),
        new JdeField("ADEST", "ADEST", JdeDataType.String, 2),
        new JdeField("ADSEX", "ADSEX", JdeDataType.String, 2),
        new JdeField("ADDST", "ADDST", JdeDataType.Numeric),
        new JdeField("ADPAST", "ADPAST", JdeDataType.String, 2),
        new JdeField("ADHMCU", "ADHMCU", JdeDataType.String, 24),
        new JdeField("ADSHFT", "ADSHFT", JdeDataType.String, 2),
        new JdeField("ADSSN", "ADSSN", JdeDataType.String, 40),
        new JdeField("ADUN", "ADUN", JdeDataType.String, 12),
        new JdeField("ADHM02", "ADHM02", JdeDataType.String, 2),
        new JdeField("ADEEOJ", "ADEEOJ", JdeDataType.String, 6),
        new JdeField("ADFLSA", "ADFLSA", JdeDataType.String, 2),
        new JdeField("ADPFRQ", "ADPFRQ", JdeDataType.String, 2),
        new JdeField("ADPGRD", "ADPGRD", JdeDataType.String, 12),
        new JdeField("ADPGRS", "ADPGRS", JdeDataType.String, 8),
        new JdeField("ADSAL", "ADSAL", JdeDataType.Numeric),
        new JdeField("ADPHRT", "ADPHRT", JdeDataType.Numeric),
        new JdeField("ADSALY", "ADSALY", JdeDataType.String, 2),
        new JdeField("ADIH", "ADIH", JdeDataType.Numeric),
        new JdeField("ADSTDH", "ADSTDH", JdeDataType.Numeric),
        new JdeField("ADSTDD", "ADSTDD", JdeDataType.Numeric),
        new JdeField("ADANPA", "ADANPA", JdeDataType.Numeric),
        new JdeField("ADWCMP", "ADWCMP", JdeDataType.String, 8),
        new JdeField("ADEIC", "ADEIC", JdeDataType.String, 2),
        new JdeField("ADMSTX", "ADMSTX", JdeDataType.String, 2),
        new JdeField("ADTARR", "ADTARR", JdeDataType.String, 20),
        new JdeField("ADSCDC", "ADSCDC", JdeDataType.Numeric),
        new JdeField("ADMSTI", "ADMSTI", JdeDataType.String, 2),
        new JdeField("ADSUI", "ADSUI", JdeDataType.String, 2),
        new JdeField("ADTARA", "ADTARA", JdeDataType.String, 20),
        new JdeField("ADHMCO", "ADHMCO", JdeDataType.String, 10),
        new JdeField("ADNRVW", "ADNRVW", JdeDataType.Numeric),
        new JdeField("ADPSDT", "ADPSDT", JdeDataType.Numeric),
        new JdeField("ADDSI", "ADDSI", JdeDataType.Numeric),
        new JdeField("ADLADT", "ADLADT", JdeDataType.Numeric),
        new JdeField("ADLSDT", "ADLSDT", JdeDataType.Numeric),
        new JdeField("ADDT", "ADDT", JdeDataType.Numeric),
        new JdeField("ADFICM", "ADFICM", JdeDataType.String, 2),
        new JdeField("ADGNNM", "ADGNNM", JdeDataType.String, 50),
        new JdeField("ADSRNM", "ADSRNM", JdeDataType.String, 50),
        new JdeField("ADMDNM", "ADMDNM", JdeDataType.String, 50),
        new JdeField("ADAR1", "ADAR1", JdeDataType.String, 12),
        new JdeField("ADPH1", "ADPH1", JdeDataType.String, 40),
        new JdeField("ADPHTP", "ADPHTP", JdeDataType.String, 8),
        new JdeField("ADAR2", "ADAR2", JdeDataType.String, 12),
        new JdeField("ADPH2", "ADPH2", JdeDataType.String, 40),
        new JdeField("ADPHT2", "ADPHT2", JdeDataType.String, 8),
        new JdeField("ADADD1", "ADADD1", JdeDataType.String, 80),
        new JdeField("ADADD2", "ADADD2", JdeDataType.String, 80),
        new JdeField("ADADD3", "ADADD3", JdeDataType.String, 80),
        new JdeField("ADADD4", "ADADD4", JdeDataType.String, 80),
        new JdeField("ADCTY1", "ADCTY1", JdeDataType.String, 50),
        new JdeField("ADADDS", "ADADDS", JdeDataType.String, 6),
        new JdeField("ADADDZ", "ADADDZ", JdeDataType.String, 24),
        new JdeField("ADEMAL", "ADEMAL", JdeDataType.String, 512),
        new JdeField("ADETP", "ADETP", JdeDataType.String, 8),
        new JdeField("ADMSA", "ADMSA", JdeDataType.String, 2),
        new JdeField("ADTINCL", "ADTINCL", JdeDataType.String, 2),
        new JdeField("ADJBCX", "ADJBCX", JdeDataType.String, 60),
        new JdeField("ADDATRVW", "ADDATRVW", JdeDataType.Numeric),
        new JdeField("ADLSRD", "ADLSRD", JdeDataType.Numeric),
        new JdeField("ADNSRD", "ADNSRD", JdeDataType.Numeric),
        new JdeField("ADRWTYP", "ADRWTYP", JdeDataType.String, 2),
        new JdeField("ADPRNM", "ADPRNM", JdeDataType.String, 40),
        new JdeField("ADAPS", "ADAPS", JdeDataType.String, 4),
        new JdeField("ADUPMJ", "ADUPMJ", JdeDataType.Numeric),
        new JdeField("ADLVEL", "ADLVEL", JdeDataType.Numeric),
        new JdeField("ADAPPST", "ADAPPST", JdeDataType.String, 2),
        new JdeField("ADAPPTY", "ADAPPTY", JdeDataType.String, 8),
        new JdeField("ADADP01", "ADADP01", JdeDataType.String, 2),
        new JdeField("ADADP02", "ADADP02", JdeDataType.String, 2),
        new JdeField("ADADP03", "ADADP03", JdeDataType.String, 2),
        new JdeField("ADADP04", "ADADP04", JdeDataType.String, 2),
        new JdeField("ADADP05", "ADADP05", JdeDataType.String, 2),
        new JdeField("ADADP11", "ADADP11", JdeDataType.Numeric),
        new JdeField("ADADP12", "ADADP12", JdeDataType.Numeric),
        new JdeField("ADADP13", "ADADP13", JdeDataType.Numeric),
        new JdeField("ADADP14", "ADADP14", JdeDataType.Numeric),
        new JdeField("ADADP15", "ADADP15", JdeDataType.Numeric),
        new JdeField("ADADP21", "ADADP21", JdeDataType.String, 40),
        new JdeField("ADADP22", "ADADP22", JdeDataType.String, 40),
        new JdeField("ADADP23", "ADADP23", JdeDataType.String, 40),
        new JdeField("ADADP24", "ADADP24", JdeDataType.String, 40),
        new JdeField("ADADP25", "ADADP25", JdeDataType.String, 40),
        new JdeField("ADADP31", "ADADP31", JdeDataType.Numeric),
        new JdeField("ADADP32", "ADADP32", JdeDataType.Numeric),
        new JdeField("ADADP33", "ADADP33", JdeDataType.Numeric),
        new JdeField("ADADP34", "ADADP34", JdeDataType.Numeric),
        new JdeField("ADADP35", "ADADP35", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05137_0", "Primary Key on ADPAYBN, ADAN8", new[] { "ADPAYBN", "ADAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
