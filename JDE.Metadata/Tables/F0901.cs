using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0901 - .
/// </summary>
public class F0901 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GMCO.
        /// </summary>
        public const string GMCO = "GMCO";

        /// <summary>
        /// GMAID.
        /// </summary>
        public const string GMAID = "GMAID";

        /// <summary>
        /// GMMCU.
        /// </summary>
        public const string GMMCU = "GMMCU";

        /// <summary>
        /// GMOBJ.
        /// </summary>
        public const string GMOBJ = "GMOBJ";

        /// <summary>
        /// GMSUB.
        /// </summary>
        public const string GMSUB = "GMSUB";

        /// <summary>
        /// GMANS.
        /// </summary>
        public const string GMANS = "GMANS";

        /// <summary>
        /// GMDL01.
        /// </summary>
        public const string GMDL01 = "GMDL01";

        /// <summary>
        /// GMLDA.
        /// </summary>
        public const string GMLDA = "GMLDA";

        /// <summary>
        /// GMBPC.
        /// </summary>
        public const string GMBPC = "GMBPC";

        /// <summary>
        /// GMPEC.
        /// </summary>
        public const string GMPEC = "GMPEC";

        /// <summary>
        /// GMBILL.
        /// </summary>
        public const string GMBILL = "GMBILL";

        /// <summary>
        /// GMCRCD.
        /// </summary>
        public const string GMCRCD = "GMCRCD";

        /// <summary>
        /// GMUM.
        /// </summary>
        public const string GMUM = "GMUM";

        /// <summary>
        /// GMR001.
        /// </summary>
        public const string GMR001 = "GMR001";

        /// <summary>
        /// GMR002.
        /// </summary>
        public const string GMR002 = "GMR002";

        /// <summary>
        /// GMR003.
        /// </summary>
        public const string GMR003 = "GMR003";

        /// <summary>
        /// GMR004.
        /// </summary>
        public const string GMR004 = "GMR004";

        /// <summary>
        /// GMR005.
        /// </summary>
        public const string GMR005 = "GMR005";

        /// <summary>
        /// GMR006.
        /// </summary>
        public const string GMR006 = "GMR006";

        /// <summary>
        /// GMR007.
        /// </summary>
        public const string GMR007 = "GMR007";

        /// <summary>
        /// GMR008.
        /// </summary>
        public const string GMR008 = "GMR008";

        /// <summary>
        /// GMR009.
        /// </summary>
        public const string GMR009 = "GMR009";

        /// <summary>
        /// GMR010.
        /// </summary>
        public const string GMR010 = "GMR010";

        /// <summary>
        /// GMR011.
        /// </summary>
        public const string GMR011 = "GMR011";

        /// <summary>
        /// GMR012.
        /// </summary>
        public const string GMR012 = "GMR012";

        /// <summary>
        /// GMR013.
        /// </summary>
        public const string GMR013 = "GMR013";

        /// <summary>
        /// GMR014.
        /// </summary>
        public const string GMR014 = "GMR014";

        /// <summary>
        /// GMR015.
        /// </summary>
        public const string GMR015 = "GMR015";

        /// <summary>
        /// GMR016.
        /// </summary>
        public const string GMR016 = "GMR016";

        /// <summary>
        /// GMR017.
        /// </summary>
        public const string GMR017 = "GMR017";

        /// <summary>
        /// GMR018.
        /// </summary>
        public const string GMR018 = "GMR018";

        /// <summary>
        /// GMR019.
        /// </summary>
        public const string GMR019 = "GMR019";

        /// <summary>
        /// GMR020.
        /// </summary>
        public const string GMR020 = "GMR020";

        /// <summary>
        /// GMR021.
        /// </summary>
        public const string GMR021 = "GMR021";

        /// <summary>
        /// GMR022.
        /// </summary>
        public const string GMR022 = "GMR022";

        /// <summary>
        /// GMR023.
        /// </summary>
        public const string GMR023 = "GMR023";

        /// <summary>
        /// GMOBJA.
        /// </summary>
        public const string GMOBJA = "GMOBJA";

        /// <summary>
        /// GMSUBA.
        /// </summary>
        public const string GMSUBA = "GMSUBA";

        /// <summary>
        /// GMWCMP.
        /// </summary>
        public const string GMWCMP = "GMWCMP";

        /// <summary>
        /// GMCCT.
        /// </summary>
        public const string GMCCT = "GMCCT";

        /// <summary>
        /// GMERC.
        /// </summary>
        public const string GMERC = "GMERC";

        /// <summary>
        /// GMHTC.
        /// </summary>
        public const string GMHTC = "GMHTC";

        /// <summary>
        /// GMQLDA.
        /// </summary>
        public const string GMQLDA = "GMQLDA";

        /// <summary>
        /// GMCCC.
        /// </summary>
        public const string GMCCC = "GMCCC";

        /// <summary>
        /// GMFMOD.
        /// </summary>
        public const string GMFMOD = "GMFMOD";

        /// <summary>
        /// GMUSER.
        /// </summary>
        public const string GMUSER = "GMUSER";

        /// <summary>
        /// GMPID.
        /// </summary>
        public const string GMPID = "GMPID";

        /// <summary>
        /// GMJOBN.
        /// </summary>
        public const string GMJOBN = "GMJOBN";

        /// <summary>
        /// GMUPMJ.
        /// </summary>
        public const string GMUPMJ = "GMUPMJ";

        /// <summary>
        /// GMUPMT.
        /// </summary>
        public const string GMUPMT = "GMUPMT";

        /// <summary>
        /// GMCEC1.
        /// </summary>
        public const string GMCEC1 = "GMCEC1";

        /// <summary>
        /// GMCEC2.
        /// </summary>
        public const string GMCEC2 = "GMCEC2";

        /// <summary>
        /// GMCEC3.
        /// </summary>
        public const string GMCEC3 = "GMCEC3";

        /// <summary>
        /// GMCEC4.
        /// </summary>
        public const string GMCEC4 = "GMCEC4";

        /// <summary>
        /// GMIEC.
        /// </summary>
        public const string GMIEC = "GMIEC";

        /// <summary>
        /// GMFPEC.
        /// </summary>
        public const string GMFPEC = "GMFPEC";

        /// <summary>
        /// GMSTPC.
        /// </summary>
        public const string GMSTPC = "GMSTPC";

        /// <summary>
        /// GMTXGL.
        /// </summary>
        public const string GMTXGL = "GMTXGL";

        /// <summary>
        /// GMTOBJ.
        /// </summary>
        public const string GMTOBJ = "GMTOBJ";

        /// <summary>
        /// GMTSUB.
        /// </summary>
        public const string GMTSUB = "GMTSUB";

        /// <summary>
        /// GMPRGF.
        /// </summary>
        public const string GMPRGF = "GMPRGF";

        /// <summary>
        /// GMTXA1.
        /// </summary>
        public const string GMTXA1 = "GMTXA1";

        /// <summary>
        /// GMR024.
        /// </summary>
        public const string GMR024 = "GMR024";

        /// <summary>
        /// GMR025.
        /// </summary>
        public const string GMR025 = "GMR025";

        /// <summary>
        /// GMR026.
        /// </summary>
        public const string GMR026 = "GMR026";

        /// <summary>
        /// GMR027.
        /// </summary>
        public const string GMR027 = "GMR027";

        /// <summary>
        /// GMR028.
        /// </summary>
        public const string GMR028 = "GMR028";

        /// <summary>
        /// GMR029.
        /// </summary>
        public const string GMR029 = "GMR029";

        /// <summary>
        /// GMR030.
        /// </summary>
        public const string GMR030 = "GMR030";

        /// <summary>
        /// GMR031.
        /// </summary>
        public const string GMR031 = "GMR031";

        /// <summary>
        /// GMR032.
        /// </summary>
        public const string GMR032 = "GMR032";

        /// <summary>
        /// GMR033.
        /// </summary>
        public const string GMR033 = "GMR033";

        /// <summary>
        /// GMR034.
        /// </summary>
        public const string GMR034 = "GMR034";

        /// <summary>
        /// GMR035.
        /// </summary>
        public const string GMR035 = "GMR035";

        /// <summary>
        /// GMR036.
        /// </summary>
        public const string GMR036 = "GMR036";

        /// <summary>
        /// GMR037.
        /// </summary>
        public const string GMR037 = "GMR037";

        /// <summary>
        /// GMR038.
        /// </summary>
        public const string GMR038 = "GMR038";

        /// <summary>
        /// GMR039.
        /// </summary>
        public const string GMR039 = "GMR039";

        /// <summary>
        /// GMR040.
        /// </summary>
        public const string GMR040 = "GMR040";

        /// <summary>
        /// GMR041.
        /// </summary>
        public const string GMR041 = "GMR041";

        /// <summary>
        /// GMR042.
        /// </summary>
        public const string GMR042 = "GMR042";

        /// <summary>
        /// GMR043.
        /// </summary>
        public const string GMR043 = "GMR043";

        /// <summary>
        /// GMADJENT.
        /// </summary>
        public const string GMADJENT = "GMADJENT";

        /// <summary>
        /// GMUAFL.
        /// </summary>
        public const string GMUAFL = "GMUAFL";
    }

    /// <inheritdoc />
    public override string TableName => "F0901";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GMCO", "GMCO", JdeDataType.String, 10),
        new JdeField("GMAID", "GMAID", JdeDataType.String, 16, true, true),
        new JdeField("GMMCU", "GMMCU", JdeDataType.String, 24),
        new JdeField("GMOBJ", "GMOBJ", JdeDataType.String, 12),
        new JdeField("GMSUB", "GMSUB", JdeDataType.String, 16),
        new JdeField("GMANS", "GMANS", JdeDataType.String, 50),
        new JdeField("GMDL01", "GMDL01", JdeDataType.String, 60),
        new JdeField("GMLDA", "GMLDA", JdeDataType.String, 2),
        new JdeField("GMBPC", "GMBPC", JdeDataType.String, 6),
        new JdeField("GMPEC", "GMPEC", JdeDataType.String, 2),
        new JdeField("GMBILL", "GMBILL", JdeDataType.String, 2),
        new JdeField("GMCRCD", "GMCRCD", JdeDataType.String, 6),
        new JdeField("GMUM", "GMUM", JdeDataType.String, 4),
        new JdeField("GMR001", "GMR001", JdeDataType.String, 6),
        new JdeField("GMR002", "GMR002", JdeDataType.String, 6),
        new JdeField("GMR003", "GMR003", JdeDataType.String, 6),
        new JdeField("GMR004", "GMR004", JdeDataType.String, 6),
        new JdeField("GMR005", "GMR005", JdeDataType.String, 6),
        new JdeField("GMR006", "GMR006", JdeDataType.String, 6),
        new JdeField("GMR007", "GMR007", JdeDataType.String, 6),
        new JdeField("GMR008", "GMR008", JdeDataType.String, 6),
        new JdeField("GMR009", "GMR009", JdeDataType.String, 6),
        new JdeField("GMR010", "GMR010", JdeDataType.String, 6),
        new JdeField("GMR011", "GMR011", JdeDataType.String, 6),
        new JdeField("GMR012", "GMR012", JdeDataType.String, 6),
        new JdeField("GMR013", "GMR013", JdeDataType.String, 6),
        new JdeField("GMR014", "GMR014", JdeDataType.String, 6),
        new JdeField("GMR015", "GMR015", JdeDataType.String, 6),
        new JdeField("GMR016", "GMR016", JdeDataType.String, 6),
        new JdeField("GMR017", "GMR017", JdeDataType.String, 6),
        new JdeField("GMR018", "GMR018", JdeDataType.String, 6),
        new JdeField("GMR019", "GMR019", JdeDataType.String, 6),
        new JdeField("GMR020", "GMR020", JdeDataType.String, 6),
        new JdeField("GMR021", "GMR021", JdeDataType.String, 20),
        new JdeField("GMR022", "GMR022", JdeDataType.String, 20),
        new JdeField("GMR023", "GMR023", JdeDataType.String, 20),
        new JdeField("GMOBJA", "GMOBJA", JdeDataType.String, 12),
        new JdeField("GMSUBA", "GMSUBA", JdeDataType.String, 16),
        new JdeField("GMWCMP", "GMWCMP", JdeDataType.String, 8),
        new JdeField("GMCCT", "GMCCT", JdeDataType.String, 2),
        new JdeField("GMERC", "GMERC", JdeDataType.String, 4),
        new JdeField("GMHTC", "GMHTC", JdeDataType.String, 2),
        new JdeField("GMQLDA", "GMQLDA", JdeDataType.String, 2),
        new JdeField("GMCCC", "GMCCC", JdeDataType.String, 2),
        new JdeField("GMFMOD", "GMFMOD", JdeDataType.String, 2),
        new JdeField("GMUSER", "GMUSER", JdeDataType.String, 20),
        new JdeField("GMPID", "GMPID", JdeDataType.String, 20),
        new JdeField("GMJOBN", "GMJOBN", JdeDataType.String, 20),
        new JdeField("GMUPMJ", "GMUPMJ", JdeDataType.Numeric),
        new JdeField("GMUPMT", "GMUPMT", JdeDataType.Numeric),
        new JdeField("GMCEC1", "GMCEC1", JdeDataType.String, 2),
        new JdeField("GMCEC2", "GMCEC2", JdeDataType.String, 2),
        new JdeField("GMCEC3", "GMCEC3", JdeDataType.String, 2),
        new JdeField("GMCEC4", "GMCEC4", JdeDataType.String, 2),
        new JdeField("GMIEC", "GMIEC", JdeDataType.String, 2),
        new JdeField("GMFPEC", "GMFPEC", JdeDataType.String, 2),
        new JdeField("GMSTPC", "GMSTPC", JdeDataType.String, 2),
        new JdeField("GMTXGL", "GMTXGL", JdeDataType.String, 2),
        new JdeField("GMTOBJ", "GMTOBJ", JdeDataType.String, 12),
        new JdeField("GMTSUB", "GMTSUB", JdeDataType.String, 16),
        new JdeField("GMPRGF", "GMPRGF", JdeDataType.String, 2),
        new JdeField("GMTXA1", "GMTXA1", JdeDataType.String, 20),
        new JdeField("GMR024", "GMR024", JdeDataType.String, 20),
        new JdeField("GMR025", "GMR025", JdeDataType.String, 20),
        new JdeField("GMR026", "GMR026", JdeDataType.String, 20),
        new JdeField("GMR027", "GMR027", JdeDataType.String, 20),
        new JdeField("GMR028", "GMR028", JdeDataType.String, 20),
        new JdeField("GMR029", "GMR029", JdeDataType.String, 20),
        new JdeField("GMR030", "GMR030", JdeDataType.String, 20),
        new JdeField("GMR031", "GMR031", JdeDataType.String, 20),
        new JdeField("GMR032", "GMR032", JdeDataType.String, 20),
        new JdeField("GMR033", "GMR033", JdeDataType.String, 20),
        new JdeField("GMR034", "GMR034", JdeDataType.String, 20),
        new JdeField("GMR035", "GMR035", JdeDataType.String, 20),
        new JdeField("GMR036", "GMR036", JdeDataType.String, 20),
        new JdeField("GMR037", "GMR037", JdeDataType.String, 20),
        new JdeField("GMR038", "GMR038", JdeDataType.String, 20),
        new JdeField("GMR039", "GMR039", JdeDataType.String, 20),
        new JdeField("GMR040", "GMR040", JdeDataType.String, 20),
        new JdeField("GMR041", "GMR041", JdeDataType.String, 20),
        new JdeField("GMR042", "GMR042", JdeDataType.String, 20),
        new JdeField("GMR043", "GMR043", JdeDataType.String, 20),
        new JdeField("GMADJENT", "GMADJENT", JdeDataType.String, 2),
        new JdeField("GMUAFL", "GMUAFL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0901_0", "Primary Key on GMAID", new[] { "GMAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0901_10", "Unique Index on GMMCU, GMSUB, GMOBJ", new[] { "GMMCU", "GMSUB", "GMOBJ" }, isUnique: true),
        new JdeIndex("F0901_11", "Index on GMR001, GMSUB, GMOBJ, GMMCU", new[] { "GMR001", "GMSUB", "GMOBJ", "GMMCU" }),
        new JdeIndex("F0901_12", "Index on GMR002, GMSUB, GMOBJ, GMMCU", new[] { "GMR002", "GMSUB", "GMOBJ", "GMMCU" }),
        new JdeIndex("F0901_13", "Index on GMR003, GMSUB, GMOBJ, GMMCU", new[] { "GMR003", "GMSUB", "GMOBJ", "GMMCU" }),
        new JdeIndex("F0901_14", "Index on GMSUBA, GMSUB, GMOBJ, GMMCU", new[] { "GMSUBA", "GMSUB", "GMOBJ", "GMMCU" }),
        new JdeIndex("F0901_15", "Index on GMSUB, GMOBJ, GMMCU", new[] { "GMSUB", "GMOBJ", "GMMCU" }),
        new JdeIndex("F0901_16", "Index on GMDL01", new[] { "GMDL01" }),
        new JdeIndex("F0901_2", "Unique Index on GMMCU, GMOBJ, GMSUB", new[] { "GMMCU", "GMOBJ", "GMSUB" }, isUnique: true),
        new JdeIndex("F0901_4", "Index on GMANS", new[] { "GMANS" }),
        new JdeIndex("F0901_5", "Index on GMCO, GMOBJ, GMSUB, GMMCU", new[] { "GMCO", "GMOBJ", "GMSUB", "GMMCU" }),
        new JdeIndex("F0901_6", "Index on GMCO, GMMCU, GMOBJ, GMSUB", new[] { "GMCO", "GMMCU", "GMOBJ", "GMSUB" }),
        new JdeIndex("F0901_7", "Unique Index on GMOBJ, GMSUB, GMMCU", new[] { "GMOBJ", "GMSUB", "GMMCU" }, isUnique: true),
        new JdeIndex("F0901_8", "Index on GMSUB, GMOBJ, GMCO", new[] { "GMSUB", "GMOBJ", "GMCO" }),
        new JdeIndex("F0901_9", "Index on GMSUB, GMCO, GMOBJ", new[] { "GMSUB", "GMCO", "GMOBJ" })
    };
}
