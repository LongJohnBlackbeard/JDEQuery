using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1310 - .
/// </summary>
public class F1310 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CAUKID.
        /// </summary>
        public const string CAUKID = "CAUKID";

        /// <summary>
        /// CANUMB.
        /// </summary>
        public const string CANUMB = "CANUMB";

        /// <summary>
        /// CAAPID.
        /// </summary>
        public const string CAAPID = "CAAPID";

        /// <summary>
        /// CAASID.
        /// </summary>
        public const string CAASID = "CAASID";

        /// <summary>
        /// CAMELC.
        /// </summary>
        public const string CAMELC = "CAMELC";

        /// <summary>
        /// CAAN8.
        /// </summary>
        public const string CAAN8 = "CAAN8";

        /// <summary>
        /// CALANO.
        /// </summary>
        public const string CALANO = "CALANO";

        /// <summary>
        /// CALOC.
        /// </summary>
        public const string CALOC = "CALOC";

        /// <summary>
        /// CAEQST.
        /// </summary>
        public const string CAEQST = "CAEQST";

        /// <summary>
        /// CATYRP.
        /// </summary>
        public const string CATYRP = "CATYRP";

        /// <summary>
        /// CASRVT.
        /// </summary>
        public const string CASRVT = "CASRVT";

        /// <summary>
        /// CADOCO.
        /// </summary>
        public const string CADOCO = "CADOCO";

        /// <summary>
        /// CADL01.
        /// </summary>
        public const string CADL01 = "CADL01";

        /// <summary>
        /// CAEVTDT.
        /// </summary>
        public const string CAEVTDT = "CAEVTDT";

        /// <summary>
        /// CAEVTTM.
        /// </summary>
        public const string CAEVTTM = "CAEVTTM";

        /// <summary>
        /// CAEVTUTC.
        /// </summary>
        public const string CAEVTUTC = "CAEVTUTC";

        /// <summary>
        /// CATIMEZONES.
        /// </summary>
        public const string CATIMEZONES = "CATIMEZONES";

        /// <summary>
        /// CADSAVNAME.
        /// </summary>
        public const string CADSAVNAME = "CADSAVNAME";

        /// <summary>
        /// CAQTST.
        /// </summary>
        public const string CAQTST = "CAQTST";

        /// <summary>
        /// CAQSPC.
        /// </summary>
        public const string CAQSPC = "CAQSPC";

        /// <summary>
        /// CADSC1.
        /// </summary>
        public const string CADSC1 = "CADSC1";

        /// <summary>
        /// CAQVAL.
        /// </summary>
        public const string CAQVAL = "CAQVAL";

        /// <summary>
        /// CAQPF.
        /// </summary>
        public const string CAQPF = "CAQPF";

        /// <summary>
        /// CATOVR.
        /// </summary>
        public const string CATOVR = "CATOVR";

        /// <summary>
        /// CAANO.
        /// </summary>
        public const string CAANO = "CAANO";

        /// <summary>
        /// CAPDFL.
        /// </summary>
        public const string CAPDFL = "CAPDFL";

        /// <summary>
        /// CADQLT.
        /// </summary>
        public const string CADQLT = "CADQLT";

        /// <summary>
        /// CAPNST.
        /// </summary>
        public const string CAPNST = "CAPNST";

        /// <summary>
        /// CAPMUKID.
        /// </summary>
        public const string CAPMUKID = "CAPMUKID";

        /// <summary>
        /// CAWONA.
        /// </summary>
        public const string CAWONA = "CAWONA";

        /// <summary>
        /// CASNDN.
        /// </summary>
        public const string CASNDN = "CASNDN";

        /// <summary>
        /// CANOTR.
        /// </summary>
        public const string CANOTR = "CANOTR";

        /// <summary>
        /// CANSTT.
        /// </summary>
        public const string CANSTT = "CANSTT";

        /// <summary>
        /// CAASTC.
        /// </summary>
        public const string CAASTC = "CAASTC";

        /// <summary>
        /// CASNDV.
        /// </summary>
        public const string CASNDV = "CASNDV";

        /// <summary>
        /// CAINVR.
        /// </summary>
        public const string CAINVR = "CAINVR";

        /// <summary>
        /// CAISTT.
        /// </summary>
        public const string CAISTT = "CAISTT";

        /// <summary>
        /// CAIVCP.
        /// </summary>
        public const string CAIVCP = "CAIVCP";

        /// <summary>
        /// CAISSUE.
        /// </summary>
        public const string CAISSUE = "CAISSUE";

        /// <summary>
        /// CASEST.
        /// </summary>
        public const string CASEST = "CASEST";

        /// <summary>
        /// CASCHSTTIME.
        /// </summary>
        public const string CASCHSTTIME = "CASCHSTTIME";

        /// <summary>
        /// CAVR01.
        /// </summary>
        public const string CAVR01 = "CAVR01";

        /// <summary>
        /// CAVR02.
        /// </summary>
        public const string CAVR02 = "CAVR02";

        /// <summary>
        /// CAWHO2.
        /// </summary>
        public const string CAWHO2 = "CAWHO2";

        /// <summary>
        /// CAAR1.
        /// </summary>
        public const string CAAR1 = "CAAR1";

        /// <summary>
        /// CAPHN1.
        /// </summary>
        public const string CAPHN1 = "CAPHN1";

        /// <summary>
        /// CAADD1.
        /// </summary>
        public const string CAADD1 = "CAADD1";

        /// <summary>
        /// CAADD2.
        /// </summary>
        public const string CAADD2 = "CAADD2";

        /// <summary>
        /// CAADD3.
        /// </summary>
        public const string CAADD3 = "CAADD3";

        /// <summary>
        /// CAADD4.
        /// </summary>
        public const string CAADD4 = "CAADD4";

        /// <summary>
        /// CACTY1.
        /// </summary>
        public const string CACTY1 = "CACTY1";

        /// <summary>
        /// CAADDS.
        /// </summary>
        public const string CAADDS = "CAADDS";

        /// <summary>
        /// CAADDZ.
        /// </summary>
        public const string CAADDZ = "CAADDZ";

        /// <summary>
        /// CACOUN.
        /// </summary>
        public const string CACOUN = "CACOUN";

        /// <summary>
        /// CACTR.
        /// </summary>
        public const string CACTR = "CACTR";

        /// <summary>
        /// CAURAB.
        /// </summary>
        public const string CAURAB = "CAURAB";

        /// <summary>
        /// CAURAT.
        /// </summary>
        public const string CAURAT = "CAURAT";

        /// <summary>
        /// CAURCD.
        /// </summary>
        public const string CAURCD = "CAURCD";

        /// <summary>
        /// CAURDT.
        /// </summary>
        public const string CAURDT = "CAURDT";

        /// <summary>
        /// CAURRF.
        /// </summary>
        public const string CAURRF = "CAURRF";

        /// <summary>
        /// CACBURCH1.
        /// </summary>
        public const string CACBURCH1 = "CACBURCH1";

        /// <summary>
        /// CACBURCH2.
        /// </summary>
        public const string CACBURCH2 = "CACBURCH2";

        /// <summary>
        /// CACBURDT1.
        /// </summary>
        public const string CACBURDT1 = "CACBURDT1";

        /// <summary>
        /// CACBURDT2.
        /// </summary>
        public const string CACBURDT2 = "CACBURDT2";

        /// <summary>
        /// CACBURMN1.
        /// </summary>
        public const string CACBURMN1 = "CACBURMN1";

        /// <summary>
        /// CACBURMN2.
        /// </summary>
        public const string CACBURMN2 = "CACBURMN2";

        /// <summary>
        /// CACBURAB1.
        /// </summary>
        public const string CACBURAB1 = "CACBURAB1";

        /// <summary>
        /// CACBURAB2.
        /// </summary>
        public const string CACBURAB2 = "CACBURAB2";

        /// <summary>
        /// CACBURST1.
        /// </summary>
        public const string CACBURST1 = "CACBURST1";

        /// <summary>
        /// CACBURST2.
        /// </summary>
        public const string CACBURST2 = "CACBURST2";

        /// <summary>
        /// CACBURST3.
        /// </summary>
        public const string CACBURST3 = "CACBURST3";

        /// <summary>
        /// CACBURST4.
        /// </summary>
        public const string CACBURST4 = "CACBURST4";

        /// <summary>
        /// CACBURST5.
        /// </summary>
        public const string CACBURST5 = "CACBURST5";

        /// <summary>
        /// CACBURST6.
        /// </summary>
        public const string CACBURST6 = "CACBURST6";

        /// <summary>
        /// CACBURST7.
        /// </summary>
        public const string CACBURST7 = "CACBURST7";

        /// <summary>
        /// CACBURST8.
        /// </summary>
        public const string CACBURST8 = "CACBURST8";

        /// <summary>
        /// CACBURST9.
        /// </summary>
        public const string CACBURST9 = "CACBURST9";

        /// <summary>
        /// CACBURST0.
        /// </summary>
        public const string CACBURST0 = "CACBURST0";

        /// <summary>
        /// CAUSER.
        /// </summary>
        public const string CAUSER = "CAUSER";

        /// <summary>
        /// CAPID.
        /// </summary>
        public const string CAPID = "CAPID";

        /// <summary>
        /// CAMKEY.
        /// </summary>
        public const string CAMKEY = "CAMKEY";

        /// <summary>
        /// CAUPMJ.
        /// </summary>
        public const string CAUPMJ = "CAUPMJ";

        /// <summary>
        /// CAUPMT.
        /// </summary>
        public const string CAUPMT = "CAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1310";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CAUKID", "CAUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("CANUMB", "CANUMB", JdeDataType.Numeric),
        new JdeField("CAAPID", "CAAPID", JdeDataType.String, 24),
        new JdeField("CAASID", "CAASID", JdeDataType.String, 50),
        new JdeField("CAMELC", "CAMELC", JdeDataType.String, 20),
        new JdeField("CAAN8", "CAAN8", JdeDataType.Numeric),
        new JdeField("CALANO", "CALANO", JdeDataType.Numeric),
        new JdeField("CALOC", "CALOC", JdeDataType.String, 24),
        new JdeField("CAEQST", "CAEQST", JdeDataType.String, 4),
        new JdeField("CATYRP", "CATYRP", JdeDataType.String, 2),
        new JdeField("CASRVT", "CASRVT", JdeDataType.String, 16),
        new JdeField("CADOCO", "CADOCO", JdeDataType.Numeric),
        new JdeField("CADL01", "CADL01", JdeDataType.String, 60),
        new JdeField("CAEVTDT", "CAEVTDT", JdeDataType.Numeric),
        new JdeField("CAEVTTM", "CAEVTTM", JdeDataType.Numeric),
        new JdeField("CAEVTUTC", "CAEVTUTC", JdeDataType.Numeric),
        new JdeField("CATIMEZONES", "CATIMEZONES", JdeDataType.String, 4),
        new JdeField("CADSAVNAME", "CADSAVNAME", JdeDataType.String, 20),
        new JdeField("CAQTST", "CAQTST", JdeDataType.String, 50),
        new JdeField("CAQSPC", "CAQSPC", JdeDataType.String, 50),
        new JdeField("CADSC1", "CADSC1", JdeDataType.String, 60),
        new JdeField("CAQVAL", "CAQVAL", JdeDataType.String, 30),
        new JdeField("CAQPF", "CAQPF", JdeDataType.String, 2),
        new JdeField("CATOVR", "CATOVR", JdeDataType.String, 2),
        new JdeField("CAANO", "CAANO", JdeDataType.Numeric),
        new JdeField("CAPDFL", "CAPDFL", JdeDataType.String, 2),
        new JdeField("CADQLT", "CADQLT", JdeDataType.String, 2),
        new JdeField("CAPNST", "CAPNST", JdeDataType.Numeric),
        new JdeField("CAPMUKID", "CAPMUKID", JdeDataType.Numeric),
        new JdeField("CAWONA", "CAWONA", JdeDataType.Numeric),
        new JdeField("CASNDN", "CASNDN", JdeDataType.String, 2),
        new JdeField("CANOTR", "CANOTR", JdeDataType.Numeric),
        new JdeField("CANSTT", "CANSTT", JdeDataType.String, 6),
        new JdeField("CAASTC", "CAASTC", JdeDataType.String, 2),
        new JdeField("CASNDV", "CASNDV", JdeDataType.String, 2),
        new JdeField("CAINVR", "CAINVR", JdeDataType.Numeric),
        new JdeField("CAISTT", "CAISTT", JdeDataType.String, 6),
        new JdeField("CAIVCP", "CAIVCP", JdeDataType.String, 2),
        new JdeField("CAISSUE", "CAISSUE", JdeDataType.String, 160),
        new JdeField("CASEST", "CASEST", JdeDataType.Numeric),
        new JdeField("CASCHSTTIME", "CASCHSTTIME", JdeDataType.Numeric),
        new JdeField("CAVR01", "CAVR01", JdeDataType.String, 50),
        new JdeField("CAVR02", "CAVR02", JdeDataType.String, 50),
        new JdeField("CAWHO2", "CAWHO2", JdeDataType.String, 80),
        new JdeField("CAAR1", "CAAR1", JdeDataType.String, 12),
        new JdeField("CAPHN1", "CAPHN1", JdeDataType.String, 40),
        new JdeField("CAADD1", "CAADD1", JdeDataType.String, 80),
        new JdeField("CAADD2", "CAADD2", JdeDataType.String, 80),
        new JdeField("CAADD3", "CAADD3", JdeDataType.String, 80),
        new JdeField("CAADD4", "CAADD4", JdeDataType.String, 80),
        new JdeField("CACTY1", "CACTY1", JdeDataType.String, 50),
        new JdeField("CAADDS", "CAADDS", JdeDataType.String, 6),
        new JdeField("CAADDZ", "CAADDZ", JdeDataType.String, 24),
        new JdeField("CACOUN", "CACOUN", JdeDataType.String, 50),
        new JdeField("CACTR", "CACTR", JdeDataType.String, 6),
        new JdeField("CAURAB", "CAURAB", JdeDataType.Numeric),
        new JdeField("CAURAT", "CAURAT", JdeDataType.Numeric),
        new JdeField("CAURCD", "CAURCD", JdeDataType.String, 4),
        new JdeField("CAURDT", "CAURDT", JdeDataType.Numeric),
        new JdeField("CAURRF", "CAURRF", JdeDataType.String, 30),
        new JdeField("CACBURCH1", "CACBURCH1", JdeDataType.String, 2),
        new JdeField("CACBURCH2", "CACBURCH2", JdeDataType.String, 2),
        new JdeField("CACBURDT1", "CACBURDT1", JdeDataType.Numeric),
        new JdeField("CACBURDT2", "CACBURDT2", JdeDataType.Numeric),
        new JdeField("CACBURMN1", "CACBURMN1", JdeDataType.Numeric),
        new JdeField("CACBURMN2", "CACBURMN2", JdeDataType.Numeric),
        new JdeField("CACBURAB1", "CACBURAB1", JdeDataType.Numeric),
        new JdeField("CACBURAB2", "CACBURAB2", JdeDataType.Numeric),
        new JdeField("CACBURST1", "CACBURST1", JdeDataType.String, 10),
        new JdeField("CACBURST2", "CACBURST2", JdeDataType.String, 10),
        new JdeField("CACBURST3", "CACBURST3", JdeDataType.String, 30),
        new JdeField("CACBURST4", "CACBURST4", JdeDataType.String, 30),
        new JdeField("CACBURST5", "CACBURST5", JdeDataType.String, 60),
        new JdeField("CACBURST6", "CACBURST6", JdeDataType.String, 60),
        new JdeField("CACBURST7", "CACBURST7", JdeDataType.String, 60),
        new JdeField("CACBURST8", "CACBURST8", JdeDataType.String, 160),
        new JdeField("CACBURST9", "CACBURST9", JdeDataType.String, 160),
        new JdeField("CACBURST0", "CACBURST0", JdeDataType.String, 160),
        new JdeField("CAUSER", "CAUSER", JdeDataType.String, 20),
        new JdeField("CAPID", "CAPID", JdeDataType.String, 20),
        new JdeField("CAMKEY", "CAMKEY", JdeDataType.String, 30),
        new JdeField("CAUPMJ", "CAUPMJ", JdeDataType.Numeric),
        new JdeField("CAUPMT", "CAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1310_0", "Primary Key on CAUKID", new[] { "CAUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1310_2", "Index on CAPMUKID", new[] { "CAPMUKID" }),
        new JdeIndex("F1310_3", "Index on CANUMB", new[] { "CANUMB" }),
        new JdeIndex("F1310_4", "Index on CAWONA", new[] { "CAWONA" })
    };
}
