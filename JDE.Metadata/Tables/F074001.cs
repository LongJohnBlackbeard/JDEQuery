using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F074001 - .
/// </summary>
public class F074001 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NHAN8.
        /// </summary>
        public const string NHAN8 = "NHAN8";

        /// <summary>
        /// NHCO.
        /// </summary>
        public const string NHCO = "NHCO";

        /// <summary>
        /// NHWST.
        /// </summary>
        public const string NHWST = "NHWST";

        /// <summary>
        /// NHTARA.
        /// </summary>
        public const string NHTARA = "NHTARA";

        /// <summary>
        /// NHNHBD.
        /// </summary>
        public const string NHNHBD = "NHNHBD";

        /// <summary>
        /// NHNHED.
        /// </summary>
        public const string NHNHED = "NHNHED";

        /// <summary>
        /// NHSSN.
        /// </summary>
        public const string NHSSN = "NHSSN";

        /// <summary>
        /// NHALPH.
        /// </summary>
        public const string NHALPH = "NHALPH";

        /// <summary>
        /// NHGNNM.
        /// </summary>
        public const string NHGNNM = "NHGNNM";

        /// <summary>
        /// NHMDNM.
        /// </summary>
        public const string NHMDNM = "NHMDNM";

        /// <summary>
        /// NHSRNM.
        /// </summary>
        public const string NHSRNM = "NHSRNM";

        /// <summary>
        /// NHADD1.
        /// </summary>
        public const string NHADD1 = "NHADD1";

        /// <summary>
        /// NHADD2.
        /// </summary>
        public const string NHADD2 = "NHADD2";

        /// <summary>
        /// NHADD3.
        /// </summary>
        public const string NHADD3 = "NHADD3";

        /// <summary>
        /// NHCTY1.
        /// </summary>
        public const string NHCTY1 = "NHCTY1";

        /// <summary>
        /// NHADDS.
        /// </summary>
        public const string NHADDS = "NHADDS";

        /// <summary>
        /// NHADDZ.
        /// </summary>
        public const string NHADDZ = "NHADDZ";

        /// <summary>
        /// NHCRTE.
        /// </summary>
        public const string NHCRTE = "NHCRTE";

        /// <summary>
        /// NHCTR.
        /// </summary>
        public const string NHCTR = "NHCTR";

        /// <summary>
        /// NHCOUN.
        /// </summary>
        public const string NHCOUN = "NHCOUN";

        /// <summary>
        /// NHFPC1.
        /// </summary>
        public const string NHFPC1 = "NHFPC1";

        /// <summary>
        /// NHDST.
        /// </summary>
        public const string NHDST = "NHDST";

        /// <summary>
        /// NHDT.
        /// </summary>
        public const string NHDT = "NHDT";

        /// <summary>
        /// NHECNT.
        /// </summary>
        public const string NHECNT = "NHECNT";

        /// <summary>
        /// NHMSTX.
        /// </summary>
        public const string NHMSTX = "NHMSTX";

        /// <summary>
        /// NHTAXX.
        /// </summary>
        public const string NHTAXX = "NHTAXX";

        /// <summary>
        /// NHCTAX.
        /// </summary>
        public const string NHCTAX = "NHCTAX";

        /// <summary>
        /// NHETAX.
        /// </summary>
        public const string NHETAX = "NHETAX";

        /// <summary>
        /// NHALPH1.
        /// </summary>
        public const string NHALPH1 = "NHALPH1";

        /// <summary>
        /// NHADD4.
        /// </summary>
        public const string NHADD4 = "NHADD4";

        /// <summary>
        /// NHADD5.
        /// </summary>
        public const string NHADD5 = "NHADD5";

        /// <summary>
        /// NHADD6.
        /// </summary>
        public const string NHADD6 = "NHADD6";

        /// <summary>
        /// NHMSCY.
        /// </summary>
        public const string NHMSCY = "NHMSCY";

        /// <summary>
        /// NHSTCD.
        /// </summary>
        public const string NHSTCD = "NHSTCD";

        /// <summary>
        /// NHADDO.
        /// </summary>
        public const string NHADDO = "NHADDO";

        /// <summary>
        /// NHCRRT.
        /// </summary>
        public const string NHCRRT = "NHCRRT";

        /// <summary>
        /// NHCTR2.
        /// </summary>
        public const string NHCTR2 = "NHCTR2";

        /// <summary>
        /// NHCNT2.
        /// </summary>
        public const string NHCNT2 = "NHCNT2";

        /// <summary>
        /// NHFPC2.
        /// </summary>
        public const string NHFPC2 = "NHFPC2";

        /// <summary>
        /// NHAR1.
        /// </summary>
        public const string NHAR1 = "NHAR1";

        /// <summary>
        /// NHPH1.
        /// </summary>
        public const string NHPH1 = "NHPH1";

        /// <summary>
        /// NHDL01.
        /// </summary>
        public const string NHDL01 = "NHDL01";

        /// <summary>
        /// NHSAL.
        /// </summary>
        public const string NHSAL = "NHSAL";

        /// <summary>
        /// NHPFRQ.
        /// </summary>
        public const string NHPFRQ = "NHPFRQ";

        /// <summary>
        /// NHSCOD.
        /// </summary>
        public const string NHSCOD = "NHSCOD";

        /// <summary>
        /// NHWKSE.
        /// </summary>
        public const string NHWKSE = "NHWKSE";

        /// <summary>
        /// NHHMCO.
        /// </summary>
        public const string NHHMCO = "NHHMCO";

        /// <summary>
        /// NHSEX.
        /// </summary>
        public const string NHSEX = "NHSEX";

        /// <summary>
        /// NHDOB.
        /// </summary>
        public const string NHDOB = "NHDOB";

        /// <summary>
        /// NHED01.
        /// </summary>
        public const string NHED01 = "NHED01";

        /// <summary>
        /// NHEEF.
        /// </summary>
        public const string NHEEF = "NHEEF";

        /// <summary>
        /// NHED02.
        /// </summary>
        public const string NHED02 = "NHED02";

        /// <summary>
        /// NHEEDF.
        /// </summary>
        public const string NHEEDF = "NHEEDF";

        /// <summary>
        /// NHADD7.
        /// </summary>
        public const string NHADD7 = "NHADD7";

        /// <summary>
        /// NHADD8.
        /// </summary>
        public const string NHADD8 = "NHADD8";

        /// <summary>
        /// NHADD9.
        /// </summary>
        public const string NHADD9 = "NHADD9";

        /// <summary>
        /// NHCTYNH.
        /// </summary>
        public const string NHCTYNH = "NHCTYNH";

        /// <summary>
        /// NHADDSNH.
        /// </summary>
        public const string NHADDSNH = "NHADDSNH";

        /// <summary>
        /// NHADDZNH.
        /// </summary>
        public const string NHADDZNH = "NHADDZNH";

        /// <summary>
        /// NHCRTENH.
        /// </summary>
        public const string NHCRTENH = "NHCRTENH";

        /// <summary>
        /// NHCTR4.
        /// </summary>
        public const string NHCTR4 = "NHCTR4";

        /// <summary>
        /// NHCOUNNH.
        /// </summary>
        public const string NHCOUNNH = "NHCOUNNH";

        /// <summary>
        /// NHFPC3.
        /// </summary>
        public const string NHFPC3 = "NHFPC3";

        /// <summary>
        /// NHAR2.
        /// </summary>
        public const string NHAR2 = "NHAR2";

        /// <summary>
        /// NHPH2.
        /// </summary>
        public const string NHPH2 = "NHPH2";

        /// <summary>
        /// NHAN80.
        /// </summary>
        public const string NHAN80 = "NHAN80";

        /// <summary>
        /// NHALPH3.
        /// </summary>
        public const string NHALPH3 = "NHALPH3";

        /// <summary>
        /// NHALPH4.
        /// </summary>
        public const string NHALPH4 = "NHALPH4";

        /// <summary>
        /// NHADD10.
        /// </summary>
        public const string NHADD10 = "NHADD10";

        /// <summary>
        /// NHADD11.
        /// </summary>
        public const string NHADD11 = "NHADD11";

        /// <summary>
        /// NHADD12.
        /// </summary>
        public const string NHADD12 = "NHADD12";

        /// <summary>
        /// NHCTYNH2.
        /// </summary>
        public const string NHCTYNH2 = "NHCTYNH2";

        /// <summary>
        /// NHADDSNH2.
        /// </summary>
        public const string NHADDSNH2 = "NHADDSNH2";

        /// <summary>
        /// NHADDZNH2.
        /// </summary>
        public const string NHADDZNH2 = "NHADDZNH2";

        /// <summary>
        /// NHCRTENH2.
        /// </summary>
        public const string NHCRTENH2 = "NHCRTENH2";

        /// <summary>
        /// NHCTR5.
        /// </summary>
        public const string NHCTR5 = "NHCTR5";

        /// <summary>
        /// NHCOUNNH2.
        /// </summary>
        public const string NHCOUNNH2 = "NHCOUNNH2";

        /// <summary>
        /// NHFPC4.
        /// </summary>
        public const string NHFPC4 = "NHFPC4";

        /// <summary>
        /// NHAR3.
        /// </summary>
        public const string NHAR3 = "NHAR3";

        /// <summary>
        /// NHPH3.
        /// </summary>
        public const string NHPH3 = "NHPH3";

        /// <summary>
        /// NHJBCD.
        /// </summary>
        public const string NHJBCD = "NHJBCD";

        /// <summary>
        /// NHJBST.
        /// </summary>
        public const string NHJBST = "NHJBST";

        /// <summary>
        /// NHDL02.
        /// </summary>
        public const string NHDL02 = "NHDL02";

        /// <summary>
        /// NHAN8Z.
        /// </summary>
        public const string NHAN8Z = "NHAN8Z";

        /// <summary>
        /// NHALPH5.
        /// </summary>
        public const string NHALPH5 = "NHALPH5";

        /// <summary>
        /// NHALPH6.
        /// </summary>
        public const string NHALPH6 = "NHALPH6";

        /// <summary>
        /// NHADD13.
        /// </summary>
        public const string NHADD13 = "NHADD13";

        /// <summary>
        /// NHADD14.
        /// </summary>
        public const string NHADD14 = "NHADD14";

        /// <summary>
        /// NHADD15.
        /// </summary>
        public const string NHADD15 = "NHADD15";

        /// <summary>
        /// NHCTYNH3.
        /// </summary>
        public const string NHCTYNH3 = "NHCTYNH3";

        /// <summary>
        /// NHADDSNH3.
        /// </summary>
        public const string NHADDSNH3 = "NHADDSNH3";

        /// <summary>
        /// NHADDZNH3.
        /// </summary>
        public const string NHADDZNH3 = "NHADDZNH3";

        /// <summary>
        /// NHCRTENH3.
        /// </summary>
        public const string NHCRTENH3 = "NHCRTENH3";

        /// <summary>
        /// NHCTR6.
        /// </summary>
        public const string NHCTR6 = "NHCTR6";

        /// <summary>
        /// NHCOUNNH3.
        /// </summary>
        public const string NHCOUNNH3 = "NHCOUNNH3";

        /// <summary>
        /// NHFPC5.
        /// </summary>
        public const string NHFPC5 = "NHFPC5";

        /// <summary>
        /// NHAR4.
        /// </summary>
        public const string NHAR4 = "NHAR4";

        /// <summary>
        /// NHPH4.
        /// </summary>
        public const string NHPH4 = "NHPH4";

        /// <summary>
        /// NHAR12.
        /// </summary>
        public const string NHAR12 = "NHAR12";

        /// <summary>
        /// NHPHN1.
        /// </summary>
        public const string NHPHN1 = "NHPHN1";

        /// <summary>
        /// NHTAXX2.
        /// </summary>
        public const string NHTAXX2 = "NHTAXX2";

        /// <summary>
        /// NHOTAX.
        /// </summary>
        public const string NHOTAX = "NHOTAX";

        /// <summary>
        /// NHCTRY.
        /// </summary>
        public const string NHCTRY = "NHCTRY";

        /// <summary>
        /// NHGLBA.
        /// </summary>
        public const string NHGLBA = "NHGLBA";

        /// <summary>
        /// NHICU.
        /// </summary>
        public const string NHICU = "NHICU";

        /// <summary>
        /// NHAC01.
        /// </summary>
        public const string NHAC01 = "NHAC01";

        /// <summary>
        /// NHAC02.
        /// </summary>
        public const string NHAC02 = "NHAC02";

        /// <summary>
        /// NHAC03.
        /// </summary>
        public const string NHAC03 = "NHAC03";

        /// <summary>
        /// NHMCU.
        /// </summary>
        public const string NHMCU = "NHMCU";

        /// <summary>
        /// NHDTE.
        /// </summary>
        public const string NHDTE = "NHDTE";

        /// <summary>
        /// NHUPMJ.
        /// </summary>
        public const string NHUPMJ = "NHUPMJ";

        /// <summary>
        /// NHUPMT.
        /// </summary>
        public const string NHUPMT = "NHUPMT";

        /// <summary>
        /// NHPID.
        /// </summary>
        public const string NHPID = "NHPID";

        /// <summary>
        /// NHJOBN.
        /// </summary>
        public const string NHJOBN = "NHJOBN";

        /// <summary>
        /// NHUSER.
        /// </summary>
        public const string NHUSER = "NHUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F074001";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NHAN8", "NHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("NHCO", "NHCO", JdeDataType.String, 10, true, true),
        new JdeField("NHWST", "NHWST", JdeDataType.Numeric, null, true, true),
        new JdeField("NHTARA", "NHTARA", JdeDataType.String, 20),
        new JdeField("NHNHBD", "NHNHBD", JdeDataType.Numeric),
        new JdeField("NHNHED", "NHNHED", JdeDataType.Numeric),
        new JdeField("NHSSN", "NHSSN", JdeDataType.String, 40),
        new JdeField("NHALPH", "NHALPH", JdeDataType.String, 80),
        new JdeField("NHGNNM", "NHGNNM", JdeDataType.String, 50),
        new JdeField("NHMDNM", "NHMDNM", JdeDataType.String, 50),
        new JdeField("NHSRNM", "NHSRNM", JdeDataType.String, 50),
        new JdeField("NHADD1", "NHADD1", JdeDataType.String, 80),
        new JdeField("NHADD2", "NHADD2", JdeDataType.String, 80),
        new JdeField("NHADD3", "NHADD3", JdeDataType.String, 80),
        new JdeField("NHCTY1", "NHCTY1", JdeDataType.String, 50),
        new JdeField("NHADDS", "NHADDS", JdeDataType.String, 6),
        new JdeField("NHADDZ", "NHADDZ", JdeDataType.String, 24),
        new JdeField("NHCRTE", "NHCRTE", JdeDataType.String, 8),
        new JdeField("NHCTR", "NHCTR", JdeDataType.String, 6),
        new JdeField("NHCOUN", "NHCOUN", JdeDataType.String, 50),
        new JdeField("NHFPC1", "NHFPC1", JdeDataType.String, 30),
        new JdeField("NHDST", "NHDST", JdeDataType.Numeric),
        new JdeField("NHDT", "NHDT", JdeDataType.Numeric),
        new JdeField("NHECNT", "NHECNT", JdeDataType.String, 2),
        new JdeField("NHMSTX", "NHMSTX", JdeDataType.String, 2),
        new JdeField("NHTAXX", "NHTAXX", JdeDataType.String, 40),
        new JdeField("NHCTAX", "NHCTAX", JdeDataType.String, 40),
        new JdeField("NHETAX", "NHETAX", JdeDataType.String, 40),
        new JdeField("NHALPH1", "NHALPH1", JdeDataType.String, 80),
        new JdeField("NHADD4", "NHADD4", JdeDataType.String, 80),
        new JdeField("NHADD5", "NHADD5", JdeDataType.String, 80),
        new JdeField("NHADD6", "NHADD6", JdeDataType.String, 80),
        new JdeField("NHMSCY", "NHMSCY", JdeDataType.String, 50),
        new JdeField("NHSTCD", "NHSTCD", JdeDataType.String, 6),
        new JdeField("NHADDO", "NHADDO", JdeDataType.String, 24),
        new JdeField("NHCRRT", "NHCRRT", JdeDataType.String, 8),
        new JdeField("NHCTR2", "NHCTR2", JdeDataType.String, 6),
        new JdeField("NHCNT2", "NHCNT2", JdeDataType.String, 50),
        new JdeField("NHFPC2", "NHFPC2", JdeDataType.String, 30),
        new JdeField("NHAR1", "NHAR1", JdeDataType.String, 12),
        new JdeField("NHPH1", "NHPH1", JdeDataType.String, 40),
        new JdeField("NHDL01", "NHDL01", JdeDataType.String, 60),
        new JdeField("NHSAL", "NHSAL", JdeDataType.Numeric),
        new JdeField("NHPFRQ", "NHPFRQ", JdeDataType.String, 2),
        new JdeField("NHSCOD", "NHSCOD", JdeDataType.String, 6),
        new JdeField("NHWKSE", "NHWKSE", JdeDataType.String, 6),
        new JdeField("NHHMCO", "NHHMCO", JdeDataType.String, 10),
        new JdeField("NHSEX", "NHSEX", JdeDataType.String, 2),
        new JdeField("NHDOB", "NHDOB", JdeDataType.Numeric),
        new JdeField("NHED01", "NHED01", JdeDataType.Numeric),
        new JdeField("NHEEF", "NHEEF", JdeDataType.String, 2),
        new JdeField("NHED02", "NHED02", JdeDataType.Numeric),
        new JdeField("NHEEDF", "NHEEDF", JdeDataType.String, 2),
        new JdeField("NHADD7", "NHADD7", JdeDataType.String, 80),
        new JdeField("NHADD8", "NHADD8", JdeDataType.String, 80),
        new JdeField("NHADD9", "NHADD9", JdeDataType.String, 80),
        new JdeField("NHCTYNH", "NHCTYNH", JdeDataType.String, 50),
        new JdeField("NHADDSNH", "NHADDSNH", JdeDataType.String, 6),
        new JdeField("NHADDZNH", "NHADDZNH", JdeDataType.String, 24),
        new JdeField("NHCRTENH", "NHCRTENH", JdeDataType.String, 8),
        new JdeField("NHCTR4", "NHCTR4", JdeDataType.String, 6),
        new JdeField("NHCOUNNH", "NHCOUNNH", JdeDataType.String, 50),
        new JdeField("NHFPC3", "NHFPC3", JdeDataType.String, 30),
        new JdeField("NHAR2", "NHAR2", JdeDataType.String, 12),
        new JdeField("NHPH2", "NHPH2", JdeDataType.String, 40),
        new JdeField("NHAN80", "NHAN80", JdeDataType.Numeric),
        new JdeField("NHALPH3", "NHALPH3", JdeDataType.String, 80),
        new JdeField("NHALPH4", "NHALPH4", JdeDataType.String, 80),
        new JdeField("NHADD10", "NHADD10", JdeDataType.String, 80),
        new JdeField("NHADD11", "NHADD11", JdeDataType.String, 80),
        new JdeField("NHADD12", "NHADD12", JdeDataType.String, 80),
        new JdeField("NHCTYNH2", "NHCTYNH2", JdeDataType.String, 50),
        new JdeField("NHADDSNH2", "NHADDSNH2", JdeDataType.String, 6),
        new JdeField("NHADDZNH2", "NHADDZNH2", JdeDataType.String, 24),
        new JdeField("NHCRTENH2", "NHCRTENH2", JdeDataType.String, 8),
        new JdeField("NHCTR5", "NHCTR5", JdeDataType.String, 6),
        new JdeField("NHCOUNNH2", "NHCOUNNH2", JdeDataType.String, 50),
        new JdeField("NHFPC4", "NHFPC4", JdeDataType.String, 30),
        new JdeField("NHAR3", "NHAR3", JdeDataType.String, 12),
        new JdeField("NHPH3", "NHPH3", JdeDataType.String, 40),
        new JdeField("NHJBCD", "NHJBCD", JdeDataType.String, 12),
        new JdeField("NHJBST", "NHJBST", JdeDataType.String, 8),
        new JdeField("NHDL02", "NHDL02", JdeDataType.String, 60),
        new JdeField("NHAN8Z", "NHAN8Z", JdeDataType.Numeric),
        new JdeField("NHALPH5", "NHALPH5", JdeDataType.String, 80),
        new JdeField("NHALPH6", "NHALPH6", JdeDataType.String, 80),
        new JdeField("NHADD13", "NHADD13", JdeDataType.String, 80),
        new JdeField("NHADD14", "NHADD14", JdeDataType.String, 80),
        new JdeField("NHADD15", "NHADD15", JdeDataType.String, 80),
        new JdeField("NHCTYNH3", "NHCTYNH3", JdeDataType.String, 50),
        new JdeField("NHADDSNH3", "NHADDSNH3", JdeDataType.String, 6),
        new JdeField("NHADDZNH3", "NHADDZNH3", JdeDataType.String, 24),
        new JdeField("NHCRTENH3", "NHCRTENH3", JdeDataType.String, 8),
        new JdeField("NHCTR6", "NHCTR6", JdeDataType.String, 6),
        new JdeField("NHCOUNNH3", "NHCOUNNH3", JdeDataType.String, 50),
        new JdeField("NHFPC5", "NHFPC5", JdeDataType.String, 30),
        new JdeField("NHAR4", "NHAR4", JdeDataType.String, 12),
        new JdeField("NHPH4", "NHPH4", JdeDataType.String, 40),
        new JdeField("NHAR12", "NHAR12", JdeDataType.String, 12),
        new JdeField("NHPHN1", "NHPHN1", JdeDataType.String, 40),
        new JdeField("NHTAXX2", "NHTAXX2", JdeDataType.String, 40),
        new JdeField("NHOTAX", "NHOTAX", JdeDataType.String, 40),
        new JdeField("NHCTRY", "NHCTRY", JdeDataType.Numeric),
        new JdeField("NHGLBA", "NHGLBA", JdeDataType.String, 16),
        new JdeField("NHICU", "NHICU", JdeDataType.Numeric),
        new JdeField("NHAC01", "NHAC01", JdeDataType.String, 6),
        new JdeField("NHAC02", "NHAC02", JdeDataType.String, 6),
        new JdeField("NHAC03", "NHAC03", JdeDataType.String, 6),
        new JdeField("NHMCU", "NHMCU", JdeDataType.String, 24),
        new JdeField("NHDTE", "NHDTE", JdeDataType.Numeric),
        new JdeField("NHUPMJ", "NHUPMJ", JdeDataType.Numeric),
        new JdeField("NHUPMT", "NHUPMT", JdeDataType.Numeric),
        new JdeField("NHPID", "NHPID", JdeDataType.String, 20),
        new JdeField("NHJOBN", "NHJOBN", JdeDataType.String, 20),
        new JdeField("NHUSER", "NHUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F074001_0", "Primary Key on NHCO, NHWST, NHAN8", new[] { "NHCO", "NHWST", "NHAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
