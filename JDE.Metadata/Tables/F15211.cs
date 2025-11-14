using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15211 - .
/// </summary>
public class F15211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATATTRIBTY.
        /// </summary>
        public const string ATATTRIBTY = "ATATTRIBTY";

        /// <summary>
        /// ATMCU.
        /// </summary>
        public const string ATMCU = "ATMCU";

        /// <summary>
        /// ATFLOR.
        /// </summary>
        public const string ATFLOR = "ATFLOR";

        /// <summary>
        /// ATUNIT.
        /// </summary>
        public const string ATUNIT = "ATUNIT";

        /// <summary>
        /// ATZCA001.
        /// </summary>
        public const string ATZCA001 = "ATZCA001";

        /// <summary>
        /// ATZCA002.
        /// </summary>
        public const string ATZCA002 = "ATZCA002";

        /// <summary>
        /// ATZCA003.
        /// </summary>
        public const string ATZCA003 = "ATZCA003";

        /// <summary>
        /// ATZCA004.
        /// </summary>
        public const string ATZCA004 = "ATZCA004";

        /// <summary>
        /// ATZCA005.
        /// </summary>
        public const string ATZCA005 = "ATZCA005";

        /// <summary>
        /// ATZCA006.
        /// </summary>
        public const string ATZCA006 = "ATZCA006";

        /// <summary>
        /// ATZCA007.
        /// </summary>
        public const string ATZCA007 = "ATZCA007";

        /// <summary>
        /// ATZCA008.
        /// </summary>
        public const string ATZCA008 = "ATZCA008";

        /// <summary>
        /// ATZCA009.
        /// </summary>
        public const string ATZCA009 = "ATZCA009";

        /// <summary>
        /// ATZCA010.
        /// </summary>
        public const string ATZCA010 = "ATZCA010";

        /// <summary>
        /// ATZCA011.
        /// </summary>
        public const string ATZCA011 = "ATZCA011";

        /// <summary>
        /// ATZCA012.
        /// </summary>
        public const string ATZCA012 = "ATZCA012";

        /// <summary>
        /// ATZCA013.
        /// </summary>
        public const string ATZCA013 = "ATZCA013";

        /// <summary>
        /// ATZCA014.
        /// </summary>
        public const string ATZCA014 = "ATZCA014";

        /// <summary>
        /// ATZCA015.
        /// </summary>
        public const string ATZCA015 = "ATZCA015";

        /// <summary>
        /// ATZCA016.
        /// </summary>
        public const string ATZCA016 = "ATZCA016";

        /// <summary>
        /// ATZCA017.
        /// </summary>
        public const string ATZCA017 = "ATZCA017";

        /// <summary>
        /// ATZCA018.
        /// </summary>
        public const string ATZCA018 = "ATZCA018";

        /// <summary>
        /// ATZCA019.
        /// </summary>
        public const string ATZCA019 = "ATZCA019";

        /// <summary>
        /// ATZCA020.
        /// </summary>
        public const string ATZCA020 = "ATZCA020";

        /// <summary>
        /// ATZCA021.
        /// </summary>
        public const string ATZCA021 = "ATZCA021";

        /// <summary>
        /// ATZCA022.
        /// </summary>
        public const string ATZCA022 = "ATZCA022";

        /// <summary>
        /// ATZCA023.
        /// </summary>
        public const string ATZCA023 = "ATZCA023";

        /// <summary>
        /// ATZCA024.
        /// </summary>
        public const string ATZCA024 = "ATZCA024";

        /// <summary>
        /// ATZCA025.
        /// </summary>
        public const string ATZCA025 = "ATZCA025";

        /// <summary>
        /// ATZCA026.
        /// </summary>
        public const string ATZCA026 = "ATZCA026";

        /// <summary>
        /// ATZCA027.
        /// </summary>
        public const string ATZCA027 = "ATZCA027";

        /// <summary>
        /// ATZCA028.
        /// </summary>
        public const string ATZCA028 = "ATZCA028";

        /// <summary>
        /// ATZCA029.
        /// </summary>
        public const string ATZCA029 = "ATZCA029";

        /// <summary>
        /// ATZCA030.
        /// </summary>
        public const string ATZCA030 = "ATZCA030";

        /// <summary>
        /// ATZCA031.
        /// </summary>
        public const string ATZCA031 = "ATZCA031";

        /// <summary>
        /// ATZCA032.
        /// </summary>
        public const string ATZCA032 = "ATZCA032";

        /// <summary>
        /// ATZCA033.
        /// </summary>
        public const string ATZCA033 = "ATZCA033";

        /// <summary>
        /// ATZCA034.
        /// </summary>
        public const string ATZCA034 = "ATZCA034";

        /// <summary>
        /// ATZCA035.
        /// </summary>
        public const string ATZCA035 = "ATZCA035";

        /// <summary>
        /// ATZCA036.
        /// </summary>
        public const string ATZCA036 = "ATZCA036";

        /// <summary>
        /// ATZCA037.
        /// </summary>
        public const string ATZCA037 = "ATZCA037";

        /// <summary>
        /// ATZCA038.
        /// </summary>
        public const string ATZCA038 = "ATZCA038";

        /// <summary>
        /// ATZCA039.
        /// </summary>
        public const string ATZCA039 = "ATZCA039";

        /// <summary>
        /// ATZCA040.
        /// </summary>
        public const string ATZCA040 = "ATZCA040";

        /// <summary>
        /// ATZCA041.
        /// </summary>
        public const string ATZCA041 = "ATZCA041";

        /// <summary>
        /// ATZCA042.
        /// </summary>
        public const string ATZCA042 = "ATZCA042";

        /// <summary>
        /// ATZCA043.
        /// </summary>
        public const string ATZCA043 = "ATZCA043";

        /// <summary>
        /// ATZCA044.
        /// </summary>
        public const string ATZCA044 = "ATZCA044";

        /// <summary>
        /// ATZCA045.
        /// </summary>
        public const string ATZCA045 = "ATZCA045";

        /// <summary>
        /// ATZCA046.
        /// </summary>
        public const string ATZCA046 = "ATZCA046";

        /// <summary>
        /// ATZCA047.
        /// </summary>
        public const string ATZCA047 = "ATZCA047";

        /// <summary>
        /// ATZCA048.
        /// </summary>
        public const string ATZCA048 = "ATZCA048";

        /// <summary>
        /// ATZCA049.
        /// </summary>
        public const string ATZCA049 = "ATZCA049";

        /// <summary>
        /// ATZCA050.
        /// </summary>
        public const string ATZCA050 = "ATZCA050";

        /// <summary>
        /// ATZCA051.
        /// </summary>
        public const string ATZCA051 = "ATZCA051";

        /// <summary>
        /// ATZCA052.
        /// </summary>
        public const string ATZCA052 = "ATZCA052";

        /// <summary>
        /// ATZCA053.
        /// </summary>
        public const string ATZCA053 = "ATZCA053";

        /// <summary>
        /// ATZCA054.
        /// </summary>
        public const string ATZCA054 = "ATZCA054";

        /// <summary>
        /// ATZCA055.
        /// </summary>
        public const string ATZCA055 = "ATZCA055";

        /// <summary>
        /// ATZCA056.
        /// </summary>
        public const string ATZCA056 = "ATZCA056";

        /// <summary>
        /// ATZCA057.
        /// </summary>
        public const string ATZCA057 = "ATZCA057";

        /// <summary>
        /// ATZCA058.
        /// </summary>
        public const string ATZCA058 = "ATZCA058";

        /// <summary>
        /// ATZCA059.
        /// </summary>
        public const string ATZCA059 = "ATZCA059";

        /// <summary>
        /// ATZCA060.
        /// </summary>
        public const string ATZCA060 = "ATZCA060";

        /// <summary>
        /// ATZCA061.
        /// </summary>
        public const string ATZCA061 = "ATZCA061";

        /// <summary>
        /// ATZCA062.
        /// </summary>
        public const string ATZCA062 = "ATZCA062";

        /// <summary>
        /// ATZCA063.
        /// </summary>
        public const string ATZCA063 = "ATZCA063";

        /// <summary>
        /// ATZCA064.
        /// </summary>
        public const string ATZCA064 = "ATZCA064";

        /// <summary>
        /// ATZCA065.
        /// </summary>
        public const string ATZCA065 = "ATZCA065";

        /// <summary>
        /// ATZCA066.
        /// </summary>
        public const string ATZCA066 = "ATZCA066";

        /// <summary>
        /// ATZCA067.
        /// </summary>
        public const string ATZCA067 = "ATZCA067";

        /// <summary>
        /// ATZCA068.
        /// </summary>
        public const string ATZCA068 = "ATZCA068";

        /// <summary>
        /// ATZCA069.
        /// </summary>
        public const string ATZCA069 = "ATZCA069";

        /// <summary>
        /// ATZCA070.
        /// </summary>
        public const string ATZCA070 = "ATZCA070";

        /// <summary>
        /// ATZCA071.
        /// </summary>
        public const string ATZCA071 = "ATZCA071";

        /// <summary>
        /// ATZCA072.
        /// </summary>
        public const string ATZCA072 = "ATZCA072";

        /// <summary>
        /// ATZCA073.
        /// </summary>
        public const string ATZCA073 = "ATZCA073";

        /// <summary>
        /// ATZCA074.
        /// </summary>
        public const string ATZCA074 = "ATZCA074";

        /// <summary>
        /// ATZCA075.
        /// </summary>
        public const string ATZCA075 = "ATZCA075";

        /// <summary>
        /// ATZCA076.
        /// </summary>
        public const string ATZCA076 = "ATZCA076";

        /// <summary>
        /// ATZCA077.
        /// </summary>
        public const string ATZCA077 = "ATZCA077";

        /// <summary>
        /// ATZCA078.
        /// </summary>
        public const string ATZCA078 = "ATZCA078";

        /// <summary>
        /// ATZCA079.
        /// </summary>
        public const string ATZCA079 = "ATZCA079";

        /// <summary>
        /// ATZCA080.
        /// </summary>
        public const string ATZCA080 = "ATZCA080";

        /// <summary>
        /// ATZCA081.
        /// </summary>
        public const string ATZCA081 = "ATZCA081";

        /// <summary>
        /// ATZCA082.
        /// </summary>
        public const string ATZCA082 = "ATZCA082";

        /// <summary>
        /// ATZCA083.
        /// </summary>
        public const string ATZCA083 = "ATZCA083";

        /// <summary>
        /// ATZCA084.
        /// </summary>
        public const string ATZCA084 = "ATZCA084";

        /// <summary>
        /// ATZCA085.
        /// </summary>
        public const string ATZCA085 = "ATZCA085";

        /// <summary>
        /// ATZCA086.
        /// </summary>
        public const string ATZCA086 = "ATZCA086";

        /// <summary>
        /// ATZCA087.
        /// </summary>
        public const string ATZCA087 = "ATZCA087";

        /// <summary>
        /// ATZCA088.
        /// </summary>
        public const string ATZCA088 = "ATZCA088";

        /// <summary>
        /// ATZCA089.
        /// </summary>
        public const string ATZCA089 = "ATZCA089";

        /// <summary>
        /// ATZCA090.
        /// </summary>
        public const string ATZCA090 = "ATZCA090";

        /// <summary>
        /// ATZCA091.
        /// </summary>
        public const string ATZCA091 = "ATZCA091";

        /// <summary>
        /// ATZCA092.
        /// </summary>
        public const string ATZCA092 = "ATZCA092";

        /// <summary>
        /// ATZCA093.
        /// </summary>
        public const string ATZCA093 = "ATZCA093";

        /// <summary>
        /// ATZCA094.
        /// </summary>
        public const string ATZCA094 = "ATZCA094";

        /// <summary>
        /// ATZCA095.
        /// </summary>
        public const string ATZCA095 = "ATZCA095";

        /// <summary>
        /// ATZCA096.
        /// </summary>
        public const string ATZCA096 = "ATZCA096";

        /// <summary>
        /// ATZCA097.
        /// </summary>
        public const string ATZCA097 = "ATZCA097";

        /// <summary>
        /// ATZCA098.
        /// </summary>
        public const string ATZCA098 = "ATZCA098";

        /// <summary>
        /// ATZCA099.
        /// </summary>
        public const string ATZCA099 = "ATZCA099";

        /// <summary>
        /// ATZCA100.
        /// </summary>
        public const string ATZCA100 = "ATZCA100";

        /// <summary>
        /// ATZCA101.
        /// </summary>
        public const string ATZCA101 = "ATZCA101";

        /// <summary>
        /// ATZCA102.
        /// </summary>
        public const string ATZCA102 = "ATZCA102";

        /// <summary>
        /// ATZCA103.
        /// </summary>
        public const string ATZCA103 = "ATZCA103";

        /// <summary>
        /// ATZCA104.
        /// </summary>
        public const string ATZCA104 = "ATZCA104";

        /// <summary>
        /// ATZCA105.
        /// </summary>
        public const string ATZCA105 = "ATZCA105";

        /// <summary>
        /// ATZCA106.
        /// </summary>
        public const string ATZCA106 = "ATZCA106";

        /// <summary>
        /// ATZCA107.
        /// </summary>
        public const string ATZCA107 = "ATZCA107";

        /// <summary>
        /// ATZCA108.
        /// </summary>
        public const string ATZCA108 = "ATZCA108";

        /// <summary>
        /// ATZCA109.
        /// </summary>
        public const string ATZCA109 = "ATZCA109";

        /// <summary>
        /// ATZCA110.
        /// </summary>
        public const string ATZCA110 = "ATZCA110";

        /// <summary>
        /// ATZCA111.
        /// </summary>
        public const string ATZCA111 = "ATZCA111";

        /// <summary>
        /// ATZCA112.
        /// </summary>
        public const string ATZCA112 = "ATZCA112";

        /// <summary>
        /// ATZCA113.
        /// </summary>
        public const string ATZCA113 = "ATZCA113";

        /// <summary>
        /// ATZCA114.
        /// </summary>
        public const string ATZCA114 = "ATZCA114";

        /// <summary>
        /// ATZCA115.
        /// </summary>
        public const string ATZCA115 = "ATZCA115";

        /// <summary>
        /// ATZCA116.
        /// </summary>
        public const string ATZCA116 = "ATZCA116";

        /// <summary>
        /// ATZCA117.
        /// </summary>
        public const string ATZCA117 = "ATZCA117";

        /// <summary>
        /// ATZCA118.
        /// </summary>
        public const string ATZCA118 = "ATZCA118";

        /// <summary>
        /// ATZCA119.
        /// </summary>
        public const string ATZCA119 = "ATZCA119";

        /// <summary>
        /// ATZCA120.
        /// </summary>
        public const string ATZCA120 = "ATZCA120";

        /// <summary>
        /// ATZCA121.
        /// </summary>
        public const string ATZCA121 = "ATZCA121";

        /// <summary>
        /// ATZCA122.
        /// </summary>
        public const string ATZCA122 = "ATZCA122";

        /// <summary>
        /// ATZCA123.
        /// </summary>
        public const string ATZCA123 = "ATZCA123";

        /// <summary>
        /// ATZCA124.
        /// </summary>
        public const string ATZCA124 = "ATZCA124";

        /// <summary>
        /// ATZCA125.
        /// </summary>
        public const string ATZCA125 = "ATZCA125";

        /// <summary>
        /// ATZCA126.
        /// </summary>
        public const string ATZCA126 = "ATZCA126";

        /// <summary>
        /// ATZCA127.
        /// </summary>
        public const string ATZCA127 = "ATZCA127";

        /// <summary>
        /// ATZCA128.
        /// </summary>
        public const string ATZCA128 = "ATZCA128";

        /// <summary>
        /// ATZCA129.
        /// </summary>
        public const string ATZCA129 = "ATZCA129";

        /// <summary>
        /// ATZCA130.
        /// </summary>
        public const string ATZCA130 = "ATZCA130";

        /// <summary>
        /// ATZCA131.
        /// </summary>
        public const string ATZCA131 = "ATZCA131";

        /// <summary>
        /// ATZCA132.
        /// </summary>
        public const string ATZCA132 = "ATZCA132";

        /// <summary>
        /// ATZCA133.
        /// </summary>
        public const string ATZCA133 = "ATZCA133";

        /// <summary>
        /// ATZCA134.
        /// </summary>
        public const string ATZCA134 = "ATZCA134";

        /// <summary>
        /// ATZCA135.
        /// </summary>
        public const string ATZCA135 = "ATZCA135";

        /// <summary>
        /// ATZCA136.
        /// </summary>
        public const string ATZCA136 = "ATZCA136";

        /// <summary>
        /// ATZCA137.
        /// </summary>
        public const string ATZCA137 = "ATZCA137";

        /// <summary>
        /// ATZCA138.
        /// </summary>
        public const string ATZCA138 = "ATZCA138";

        /// <summary>
        /// ATZCA139.
        /// </summary>
        public const string ATZCA139 = "ATZCA139";

        /// <summary>
        /// ATZCA140.
        /// </summary>
        public const string ATZCA140 = "ATZCA140";

        /// <summary>
        /// ATUSER.
        /// </summary>
        public const string ATUSER = "ATUSER";

        /// <summary>
        /// ATUPMT.
        /// </summary>
        public const string ATUPMT = "ATUPMT";

        /// <summary>
        /// ATUPMJ.
        /// </summary>
        public const string ATUPMJ = "ATUPMJ";

        /// <summary>
        /// ATPID.
        /// </summary>
        public const string ATPID = "ATPID";

        /// <summary>
        /// ATMKEY.
        /// </summary>
        public const string ATMKEY = "ATMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F15211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATATTRIBTY", "ATATTRIBTY", JdeDataType.String, 2, true, true),
        new JdeField("ATMCU", "ATMCU", JdeDataType.String, 24, true, true),
        new JdeField("ATFLOR", "ATFLOR", JdeDataType.String, 8, true, true),
        new JdeField("ATUNIT", "ATUNIT", JdeDataType.String, 16, true, true),
        new JdeField("ATZCA001", "ATZCA001", JdeDataType.Numeric),
        new JdeField("ATZCA002", "ATZCA002", JdeDataType.Numeric),
        new JdeField("ATZCA003", "ATZCA003", JdeDataType.Numeric),
        new JdeField("ATZCA004", "ATZCA004", JdeDataType.Numeric),
        new JdeField("ATZCA005", "ATZCA005", JdeDataType.Numeric),
        new JdeField("ATZCA006", "ATZCA006", JdeDataType.Numeric),
        new JdeField("ATZCA007", "ATZCA007", JdeDataType.Numeric),
        new JdeField("ATZCA008", "ATZCA008", JdeDataType.Numeric),
        new JdeField("ATZCA009", "ATZCA009", JdeDataType.Numeric),
        new JdeField("ATZCA010", "ATZCA010", JdeDataType.Numeric),
        new JdeField("ATZCA011", "ATZCA011", JdeDataType.Numeric),
        new JdeField("ATZCA012", "ATZCA012", JdeDataType.Numeric),
        new JdeField("ATZCA013", "ATZCA013", JdeDataType.Numeric),
        new JdeField("ATZCA014", "ATZCA014", JdeDataType.Numeric),
        new JdeField("ATZCA015", "ATZCA015", JdeDataType.Numeric),
        new JdeField("ATZCA016", "ATZCA016", JdeDataType.Numeric),
        new JdeField("ATZCA017", "ATZCA017", JdeDataType.Numeric),
        new JdeField("ATZCA018", "ATZCA018", JdeDataType.Numeric),
        new JdeField("ATZCA019", "ATZCA019", JdeDataType.Numeric),
        new JdeField("ATZCA020", "ATZCA020", JdeDataType.Numeric),
        new JdeField("ATZCA021", "ATZCA021", JdeDataType.Numeric),
        new JdeField("ATZCA022", "ATZCA022", JdeDataType.Numeric),
        new JdeField("ATZCA023", "ATZCA023", JdeDataType.Numeric),
        new JdeField("ATZCA024", "ATZCA024", JdeDataType.Numeric),
        new JdeField("ATZCA025", "ATZCA025", JdeDataType.Numeric),
        new JdeField("ATZCA026", "ATZCA026", JdeDataType.Numeric),
        new JdeField("ATZCA027", "ATZCA027", JdeDataType.Numeric),
        new JdeField("ATZCA028", "ATZCA028", JdeDataType.Numeric),
        new JdeField("ATZCA029", "ATZCA029", JdeDataType.Numeric),
        new JdeField("ATZCA030", "ATZCA030", JdeDataType.Numeric),
        new JdeField("ATZCA031", "ATZCA031", JdeDataType.Numeric),
        new JdeField("ATZCA032", "ATZCA032", JdeDataType.Numeric),
        new JdeField("ATZCA033", "ATZCA033", JdeDataType.Numeric),
        new JdeField("ATZCA034", "ATZCA034", JdeDataType.Numeric),
        new JdeField("ATZCA035", "ATZCA035", JdeDataType.Numeric),
        new JdeField("ATZCA036", "ATZCA036", JdeDataType.Numeric),
        new JdeField("ATZCA037", "ATZCA037", JdeDataType.Numeric),
        new JdeField("ATZCA038", "ATZCA038", JdeDataType.Numeric),
        new JdeField("ATZCA039", "ATZCA039", JdeDataType.Numeric),
        new JdeField("ATZCA040", "ATZCA040", JdeDataType.Numeric),
        new JdeField("ATZCA041", "ATZCA041", JdeDataType.Numeric),
        new JdeField("ATZCA042", "ATZCA042", JdeDataType.Numeric),
        new JdeField("ATZCA043", "ATZCA043", JdeDataType.Numeric),
        new JdeField("ATZCA044", "ATZCA044", JdeDataType.Numeric),
        new JdeField("ATZCA045", "ATZCA045", JdeDataType.Numeric),
        new JdeField("ATZCA046", "ATZCA046", JdeDataType.Numeric),
        new JdeField("ATZCA047", "ATZCA047", JdeDataType.Numeric),
        new JdeField("ATZCA048", "ATZCA048", JdeDataType.Numeric),
        new JdeField("ATZCA049", "ATZCA049", JdeDataType.Numeric),
        new JdeField("ATZCA050", "ATZCA050", JdeDataType.Numeric),
        new JdeField("ATZCA051", "ATZCA051", JdeDataType.Numeric),
        new JdeField("ATZCA052", "ATZCA052", JdeDataType.Numeric),
        new JdeField("ATZCA053", "ATZCA053", JdeDataType.Numeric),
        new JdeField("ATZCA054", "ATZCA054", JdeDataType.Numeric),
        new JdeField("ATZCA055", "ATZCA055", JdeDataType.Numeric),
        new JdeField("ATZCA056", "ATZCA056", JdeDataType.Numeric),
        new JdeField("ATZCA057", "ATZCA057", JdeDataType.Numeric),
        new JdeField("ATZCA058", "ATZCA058", JdeDataType.Numeric),
        new JdeField("ATZCA059", "ATZCA059", JdeDataType.Numeric),
        new JdeField("ATZCA060", "ATZCA060", JdeDataType.Numeric),
        new JdeField("ATZCA061", "ATZCA061", JdeDataType.Numeric),
        new JdeField("ATZCA062", "ATZCA062", JdeDataType.Numeric),
        new JdeField("ATZCA063", "ATZCA063", JdeDataType.Numeric),
        new JdeField("ATZCA064", "ATZCA064", JdeDataType.Numeric),
        new JdeField("ATZCA065", "ATZCA065", JdeDataType.Numeric),
        new JdeField("ATZCA066", "ATZCA066", JdeDataType.Numeric),
        new JdeField("ATZCA067", "ATZCA067", JdeDataType.Numeric),
        new JdeField("ATZCA068", "ATZCA068", JdeDataType.Numeric),
        new JdeField("ATZCA069", "ATZCA069", JdeDataType.Numeric),
        new JdeField("ATZCA070", "ATZCA070", JdeDataType.Numeric),
        new JdeField("ATZCA071", "ATZCA071", JdeDataType.Numeric),
        new JdeField("ATZCA072", "ATZCA072", JdeDataType.Numeric),
        new JdeField("ATZCA073", "ATZCA073", JdeDataType.Numeric),
        new JdeField("ATZCA074", "ATZCA074", JdeDataType.Numeric),
        new JdeField("ATZCA075", "ATZCA075", JdeDataType.Numeric),
        new JdeField("ATZCA076", "ATZCA076", JdeDataType.Numeric),
        new JdeField("ATZCA077", "ATZCA077", JdeDataType.Numeric),
        new JdeField("ATZCA078", "ATZCA078", JdeDataType.Numeric),
        new JdeField("ATZCA079", "ATZCA079", JdeDataType.Numeric),
        new JdeField("ATZCA080", "ATZCA080", JdeDataType.Numeric),
        new JdeField("ATZCA081", "ATZCA081", JdeDataType.String, 60),
        new JdeField("ATZCA082", "ATZCA082", JdeDataType.String, 60),
        new JdeField("ATZCA083", "ATZCA083", JdeDataType.String, 60),
        new JdeField("ATZCA084", "ATZCA084", JdeDataType.String, 60),
        new JdeField("ATZCA085", "ATZCA085", JdeDataType.String, 60),
        new JdeField("ATZCA086", "ATZCA086", JdeDataType.String, 60),
        new JdeField("ATZCA087", "ATZCA087", JdeDataType.String, 60),
        new JdeField("ATZCA088", "ATZCA088", JdeDataType.String, 60),
        new JdeField("ATZCA089", "ATZCA089", JdeDataType.String, 60),
        new JdeField("ATZCA090", "ATZCA090", JdeDataType.String, 60),
        new JdeField("ATZCA091", "ATZCA091", JdeDataType.Numeric),
        new JdeField("ATZCA092", "ATZCA092", JdeDataType.Numeric),
        new JdeField("ATZCA093", "ATZCA093", JdeDataType.Numeric),
        new JdeField("ATZCA094", "ATZCA094", JdeDataType.Numeric),
        new JdeField("ATZCA095", "ATZCA095", JdeDataType.Numeric),
        new JdeField("ATZCA096", "ATZCA096", JdeDataType.Numeric),
        new JdeField("ATZCA097", "ATZCA097", JdeDataType.Numeric),
        new JdeField("ATZCA098", "ATZCA098", JdeDataType.Numeric),
        new JdeField("ATZCA099", "ATZCA099", JdeDataType.Numeric),
        new JdeField("ATZCA100", "ATZCA100", JdeDataType.Numeric),
        new JdeField("ATZCA101", "ATZCA101", JdeDataType.Numeric),
        new JdeField("ATZCA102", "ATZCA102", JdeDataType.Numeric),
        new JdeField("ATZCA103", "ATZCA103", JdeDataType.Numeric),
        new JdeField("ATZCA104", "ATZCA104", JdeDataType.Numeric),
        new JdeField("ATZCA105", "ATZCA105", JdeDataType.Numeric),
        new JdeField("ATZCA106", "ATZCA106", JdeDataType.Numeric),
        new JdeField("ATZCA107", "ATZCA107", JdeDataType.Numeric),
        new JdeField("ATZCA108", "ATZCA108", JdeDataType.Numeric),
        new JdeField("ATZCA109", "ATZCA109", JdeDataType.Numeric),
        new JdeField("ATZCA110", "ATZCA110", JdeDataType.Numeric),
        new JdeField("ATZCA111", "ATZCA111", JdeDataType.Numeric),
        new JdeField("ATZCA112", "ATZCA112", JdeDataType.Numeric),
        new JdeField("ATZCA113", "ATZCA113", JdeDataType.Numeric),
        new JdeField("ATZCA114", "ATZCA114", JdeDataType.Numeric),
        new JdeField("ATZCA115", "ATZCA115", JdeDataType.Numeric),
        new JdeField("ATZCA116", "ATZCA116", JdeDataType.Numeric),
        new JdeField("ATZCA117", "ATZCA117", JdeDataType.Numeric),
        new JdeField("ATZCA118", "ATZCA118", JdeDataType.Numeric),
        new JdeField("ATZCA119", "ATZCA119", JdeDataType.Numeric),
        new JdeField("ATZCA120", "ATZCA120", JdeDataType.Numeric),
        new JdeField("ATZCA121", "ATZCA121", JdeDataType.String, 60),
        new JdeField("ATZCA122", "ATZCA122", JdeDataType.String, 60),
        new JdeField("ATZCA123", "ATZCA123", JdeDataType.String, 60),
        new JdeField("ATZCA124", "ATZCA124", JdeDataType.String, 60),
        new JdeField("ATZCA125", "ATZCA125", JdeDataType.String, 60),
        new JdeField("ATZCA126", "ATZCA126", JdeDataType.String, 60),
        new JdeField("ATZCA127", "ATZCA127", JdeDataType.String, 60),
        new JdeField("ATZCA128", "ATZCA128", JdeDataType.String, 60),
        new JdeField("ATZCA129", "ATZCA129", JdeDataType.String, 60),
        new JdeField("ATZCA130", "ATZCA130", JdeDataType.String, 60),
        new JdeField("ATZCA131", "ATZCA131", JdeDataType.String, 60),
        new JdeField("ATZCA132", "ATZCA132", JdeDataType.String, 60),
        new JdeField("ATZCA133", "ATZCA133", JdeDataType.String, 60),
        new JdeField("ATZCA134", "ATZCA134", JdeDataType.String, 60),
        new JdeField("ATZCA135", "ATZCA135", JdeDataType.String, 60),
        new JdeField("ATZCA136", "ATZCA136", JdeDataType.String, 60),
        new JdeField("ATZCA137", "ATZCA137", JdeDataType.String, 60),
        new JdeField("ATZCA138", "ATZCA138", JdeDataType.String, 60),
        new JdeField("ATZCA139", "ATZCA139", JdeDataType.String, 60),
        new JdeField("ATZCA140", "ATZCA140", JdeDataType.String, 60),
        new JdeField("ATUSER", "ATUSER", JdeDataType.String, 20),
        new JdeField("ATUPMT", "ATUPMT", JdeDataType.Numeric),
        new JdeField("ATUPMJ", "ATUPMJ", JdeDataType.Numeric),
        new JdeField("ATPID", "ATPID", JdeDataType.String, 20),
        new JdeField("ATMKEY", "ATMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15211_0", "Primary Key on ATATTRIBTY, ATMCU, ATFLOR, ATUNIT", new[] { "ATATTRIBTY", "ATMCU", "ATFLOR", "ATUNIT" }, isUnique: true, isPrimaryKey: true)
    };
}
