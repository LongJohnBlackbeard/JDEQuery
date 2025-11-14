using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F051123 - .
/// </summary>
public class F051123 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y3HMCO.
        /// </summary>
        public const string Y3HMCO = "Y3HMCO";

        /// <summary>
        /// Y3HMCU.
        /// </summary>
        public const string Y3HMCU = "Y3HMCU";

        /// <summary>
        /// Y3ESZ000.
        /// </summary>
        public const string Y3ESZ000 = "Y3ESZ000";

        /// <summary>
        /// Y3ESZ174.
        /// </summary>
        public const string Y3ESZ174 = "Y3ESZ174";

        /// <summary>
        /// Y3ESZ173.
        /// </summary>
        public const string Y3ESZ173 = "Y3ESZ173";

        /// <summary>
        /// Y3ESZ001.
        /// </summary>
        public const string Y3ESZ001 = "Y3ESZ001";

        /// <summary>
        /// Y3ESZ002.
        /// </summary>
        public const string Y3ESZ002 = "Y3ESZ002";

        /// <summary>
        /// Y3ESZ003.
        /// </summary>
        public const string Y3ESZ003 = "Y3ESZ003";

        /// <summary>
        /// Y3ESZ004.
        /// </summary>
        public const string Y3ESZ004 = "Y3ESZ004";

        /// <summary>
        /// Y3ESZ005.
        /// </summary>
        public const string Y3ESZ005 = "Y3ESZ005";

        /// <summary>
        /// Y3ESZ006.
        /// </summary>
        public const string Y3ESZ006 = "Y3ESZ006";

        /// <summary>
        /// Y3ESZ007.
        /// </summary>
        public const string Y3ESZ007 = "Y3ESZ007";

        /// <summary>
        /// Y3ESZ008.
        /// </summary>
        public const string Y3ESZ008 = "Y3ESZ008";

        /// <summary>
        /// Y3ESZ009.
        /// </summary>
        public const string Y3ESZ009 = "Y3ESZ009";

        /// <summary>
        /// Y3ESZ010.
        /// </summary>
        public const string Y3ESZ010 = "Y3ESZ010";

        /// <summary>
        /// Y3ESZ011.
        /// </summary>
        public const string Y3ESZ011 = "Y3ESZ011";

        /// <summary>
        /// Y3ESZ012.
        /// </summary>
        public const string Y3ESZ012 = "Y3ESZ012";

        /// <summary>
        /// Y3ESZ013.
        /// </summary>
        public const string Y3ESZ013 = "Y3ESZ013";

        /// <summary>
        /// Y3ESZ014.
        /// </summary>
        public const string Y3ESZ014 = "Y3ESZ014";

        /// <summary>
        /// Y3ESZ015.
        /// </summary>
        public const string Y3ESZ015 = "Y3ESZ015";

        /// <summary>
        /// Y3ESZ016.
        /// </summary>
        public const string Y3ESZ016 = "Y3ESZ016";

        /// <summary>
        /// Y3ESZ017.
        /// </summary>
        public const string Y3ESZ017 = "Y3ESZ017";

        /// <summary>
        /// Y3ESZ018.
        /// </summary>
        public const string Y3ESZ018 = "Y3ESZ018";

        /// <summary>
        /// Y3ESZ019.
        /// </summary>
        public const string Y3ESZ019 = "Y3ESZ019";

        /// <summary>
        /// Y3ESZ020.
        /// </summary>
        public const string Y3ESZ020 = "Y3ESZ020";

        /// <summary>
        /// Y3ESZ021.
        /// </summary>
        public const string Y3ESZ021 = "Y3ESZ021";

        /// <summary>
        /// Y3ESZ022.
        /// </summary>
        public const string Y3ESZ022 = "Y3ESZ022";

        /// <summary>
        /// Y3ESZ023.
        /// </summary>
        public const string Y3ESZ023 = "Y3ESZ023";

        /// <summary>
        /// Y3ESZ024.
        /// </summary>
        public const string Y3ESZ024 = "Y3ESZ024";

        /// <summary>
        /// Y3ESZ025.
        /// </summary>
        public const string Y3ESZ025 = "Y3ESZ025";

        /// <summary>
        /// Y3ESZ026.
        /// </summary>
        public const string Y3ESZ026 = "Y3ESZ026";

        /// <summary>
        /// Y3ESZ027.
        /// </summary>
        public const string Y3ESZ027 = "Y3ESZ027";

        /// <summary>
        /// Y3ESZ028.
        /// </summary>
        public const string Y3ESZ028 = "Y3ESZ028";

        /// <summary>
        /// Y3ESZ029.
        /// </summary>
        public const string Y3ESZ029 = "Y3ESZ029";

        /// <summary>
        /// Y3ESZ030.
        /// </summary>
        public const string Y3ESZ030 = "Y3ESZ030";

        /// <summary>
        /// Y3ESZ031.
        /// </summary>
        public const string Y3ESZ031 = "Y3ESZ031";

        /// <summary>
        /// Y3ESZ032.
        /// </summary>
        public const string Y3ESZ032 = "Y3ESZ032";

        /// <summary>
        /// Y3ESZ033.
        /// </summary>
        public const string Y3ESZ033 = "Y3ESZ033";

        /// <summary>
        /// Y3ESZ034.
        /// </summary>
        public const string Y3ESZ034 = "Y3ESZ034";

        /// <summary>
        /// Y3ESZ035.
        /// </summary>
        public const string Y3ESZ035 = "Y3ESZ035";

        /// <summary>
        /// Y3ESZ036.
        /// </summary>
        public const string Y3ESZ036 = "Y3ESZ036";

        /// <summary>
        /// Y3ESZ037.
        /// </summary>
        public const string Y3ESZ037 = "Y3ESZ037";

        /// <summary>
        /// Y3ESZ038.
        /// </summary>
        public const string Y3ESZ038 = "Y3ESZ038";

        /// <summary>
        /// Y3ESZ039.
        /// </summary>
        public const string Y3ESZ039 = "Y3ESZ039";

        /// <summary>
        /// Y3ESZ040.
        /// </summary>
        public const string Y3ESZ040 = "Y3ESZ040";

        /// <summary>
        /// Y3ESZ041.
        /// </summary>
        public const string Y3ESZ041 = "Y3ESZ041";

        /// <summary>
        /// Y3ESZ042.
        /// </summary>
        public const string Y3ESZ042 = "Y3ESZ042";

        /// <summary>
        /// Y3ESZ043.
        /// </summary>
        public const string Y3ESZ043 = "Y3ESZ043";

        /// <summary>
        /// Y3ESZ044.
        /// </summary>
        public const string Y3ESZ044 = "Y3ESZ044";

        /// <summary>
        /// Y3ESZ045.
        /// </summary>
        public const string Y3ESZ045 = "Y3ESZ045";

        /// <summary>
        /// Y3ESZ046.
        /// </summary>
        public const string Y3ESZ046 = "Y3ESZ046";

        /// <summary>
        /// Y3ESZ047.
        /// </summary>
        public const string Y3ESZ047 = "Y3ESZ047";

        /// <summary>
        /// Y3ESZ048.
        /// </summary>
        public const string Y3ESZ048 = "Y3ESZ048";

        /// <summary>
        /// Y3ESZ049.
        /// </summary>
        public const string Y3ESZ049 = "Y3ESZ049";

        /// <summary>
        /// Y3ESZ050.
        /// </summary>
        public const string Y3ESZ050 = "Y3ESZ050";

        /// <summary>
        /// Y3ESZ051.
        /// </summary>
        public const string Y3ESZ051 = "Y3ESZ051";

        /// <summary>
        /// Y3ESZ052.
        /// </summary>
        public const string Y3ESZ052 = "Y3ESZ052";

        /// <summary>
        /// Y3ESZ053.
        /// </summary>
        public const string Y3ESZ053 = "Y3ESZ053";

        /// <summary>
        /// Y3ESZ054.
        /// </summary>
        public const string Y3ESZ054 = "Y3ESZ054";

        /// <summary>
        /// Y3ESZ055.
        /// </summary>
        public const string Y3ESZ055 = "Y3ESZ055";

        /// <summary>
        /// Y3ESZ056.
        /// </summary>
        public const string Y3ESZ056 = "Y3ESZ056";

        /// <summary>
        /// Y3ESZ057.
        /// </summary>
        public const string Y3ESZ057 = "Y3ESZ057";

        /// <summary>
        /// Y3ESZ058.
        /// </summary>
        public const string Y3ESZ058 = "Y3ESZ058";

        /// <summary>
        /// Y3ESZ059.
        /// </summary>
        public const string Y3ESZ059 = "Y3ESZ059";

        /// <summary>
        /// Y3ESZ060.
        /// </summary>
        public const string Y3ESZ060 = "Y3ESZ060";

        /// <summary>
        /// Y3ESZ061.
        /// </summary>
        public const string Y3ESZ061 = "Y3ESZ061";

        /// <summary>
        /// Y3ESZ062.
        /// </summary>
        public const string Y3ESZ062 = "Y3ESZ062";

        /// <summary>
        /// Y3ESZ063.
        /// </summary>
        public const string Y3ESZ063 = "Y3ESZ063";

        /// <summary>
        /// Y3ESZ064.
        /// </summary>
        public const string Y3ESZ064 = "Y3ESZ064";

        /// <summary>
        /// Y3ESZ065.
        /// </summary>
        public const string Y3ESZ065 = "Y3ESZ065";

        /// <summary>
        /// Y3ESZ066.
        /// </summary>
        public const string Y3ESZ066 = "Y3ESZ066";

        /// <summary>
        /// Y3ESZ067.
        /// </summary>
        public const string Y3ESZ067 = "Y3ESZ067";

        /// <summary>
        /// Y3ESZ068.
        /// </summary>
        public const string Y3ESZ068 = "Y3ESZ068";

        /// <summary>
        /// Y3ESZ069.
        /// </summary>
        public const string Y3ESZ069 = "Y3ESZ069";

        /// <summary>
        /// Y3ESZ070.
        /// </summary>
        public const string Y3ESZ070 = "Y3ESZ070";

        /// <summary>
        /// Y3ESZ071.
        /// </summary>
        public const string Y3ESZ071 = "Y3ESZ071";

        /// <summary>
        /// Y3ESZ072.
        /// </summary>
        public const string Y3ESZ072 = "Y3ESZ072";

        /// <summary>
        /// Y3ESZ073.
        /// </summary>
        public const string Y3ESZ073 = "Y3ESZ073";

        /// <summary>
        /// Y3ESZ074.
        /// </summary>
        public const string Y3ESZ074 = "Y3ESZ074";

        /// <summary>
        /// Y3ESZ075.
        /// </summary>
        public const string Y3ESZ075 = "Y3ESZ075";

        /// <summary>
        /// Y3ESZ076.
        /// </summary>
        public const string Y3ESZ076 = "Y3ESZ076";

        /// <summary>
        /// Y3ESZ077.
        /// </summary>
        public const string Y3ESZ077 = "Y3ESZ077";

        /// <summary>
        /// Y3ESZ078.
        /// </summary>
        public const string Y3ESZ078 = "Y3ESZ078";

        /// <summary>
        /// Y3ESZ079.
        /// </summary>
        public const string Y3ESZ079 = "Y3ESZ079";

        /// <summary>
        /// Y3ESZ080.
        /// </summary>
        public const string Y3ESZ080 = "Y3ESZ080";

        /// <summary>
        /// Y3ESZ081.
        /// </summary>
        public const string Y3ESZ081 = "Y3ESZ081";

        /// <summary>
        /// Y3ESZ082.
        /// </summary>
        public const string Y3ESZ082 = "Y3ESZ082";

        /// <summary>
        /// Y3ESZ083.
        /// </summary>
        public const string Y3ESZ083 = "Y3ESZ083";

        /// <summary>
        /// Y3ESZ084.
        /// </summary>
        public const string Y3ESZ084 = "Y3ESZ084";

        /// <summary>
        /// Y3ESZ085.
        /// </summary>
        public const string Y3ESZ085 = "Y3ESZ085";

        /// <summary>
        /// Y3ESZ086.
        /// </summary>
        public const string Y3ESZ086 = "Y3ESZ086";

        /// <summary>
        /// Y3ESZ087.
        /// </summary>
        public const string Y3ESZ087 = "Y3ESZ087";

        /// <summary>
        /// Y3ESZ088.
        /// </summary>
        public const string Y3ESZ088 = "Y3ESZ088";

        /// <summary>
        /// Y3ESZ089.
        /// </summary>
        public const string Y3ESZ089 = "Y3ESZ089";

        /// <summary>
        /// Y3ESZ175.
        /// </summary>
        public const string Y3ESZ175 = "Y3ESZ175";

        /// <summary>
        /// Y3ESZ090.
        /// </summary>
        public const string Y3ESZ090 = "Y3ESZ090";

        /// <summary>
        /// Y3ESZ091.
        /// </summary>
        public const string Y3ESZ091 = "Y3ESZ091";

        /// <summary>
        /// Y3ESZ092.
        /// </summary>
        public const string Y3ESZ092 = "Y3ESZ092";

        /// <summary>
        /// Y3ESZ093.
        /// </summary>
        public const string Y3ESZ093 = "Y3ESZ093";

        /// <summary>
        /// Y3ESZ096.
        /// </summary>
        public const string Y3ESZ096 = "Y3ESZ096";

        /// <summary>
        /// Y3ESZ097.
        /// </summary>
        public const string Y3ESZ097 = "Y3ESZ097";

        /// <summary>
        /// Y3ESZ098.
        /// </summary>
        public const string Y3ESZ098 = "Y3ESZ098";

        /// <summary>
        /// Y3ESZ099.
        /// </summary>
        public const string Y3ESZ099 = "Y3ESZ099";

        /// <summary>
        /// Y3ESZ100.
        /// </summary>
        public const string Y3ESZ100 = "Y3ESZ100";

        /// <summary>
        /// Y3ESZ101.
        /// </summary>
        public const string Y3ESZ101 = "Y3ESZ101";

        /// <summary>
        /// Y3ESZ102.
        /// </summary>
        public const string Y3ESZ102 = "Y3ESZ102";

        /// <summary>
        /// Y3ESZ103.
        /// </summary>
        public const string Y3ESZ103 = "Y3ESZ103";

        /// <summary>
        /// Y3ESZ104.
        /// </summary>
        public const string Y3ESZ104 = "Y3ESZ104";

        /// <summary>
        /// Y3ESZ105.
        /// </summary>
        public const string Y3ESZ105 = "Y3ESZ105";

        /// <summary>
        /// Y3ESZ106.
        /// </summary>
        public const string Y3ESZ106 = "Y3ESZ106";

        /// <summary>
        /// Y3ESZ107.
        /// </summary>
        public const string Y3ESZ107 = "Y3ESZ107";

        /// <summary>
        /// Y3ESZ108.
        /// </summary>
        public const string Y3ESZ108 = "Y3ESZ108";

        /// <summary>
        /// Y3ESZ109.
        /// </summary>
        public const string Y3ESZ109 = "Y3ESZ109";

        /// <summary>
        /// Y3ESZ110.
        /// </summary>
        public const string Y3ESZ110 = "Y3ESZ110";

        /// <summary>
        /// Y3ESZ111.
        /// </summary>
        public const string Y3ESZ111 = "Y3ESZ111";

        /// <summary>
        /// Y3ESZ112.
        /// </summary>
        public const string Y3ESZ112 = "Y3ESZ112";

        /// <summary>
        /// Y3ESZ113.
        /// </summary>
        public const string Y3ESZ113 = "Y3ESZ113";

        /// <summary>
        /// Y3ESZ114.
        /// </summary>
        public const string Y3ESZ114 = "Y3ESZ114";

        /// <summary>
        /// Y3ESZ115.
        /// </summary>
        public const string Y3ESZ115 = "Y3ESZ115";

        /// <summary>
        /// Y3ESZ116.
        /// </summary>
        public const string Y3ESZ116 = "Y3ESZ116";

        /// <summary>
        /// Y3ESZ117.
        /// </summary>
        public const string Y3ESZ117 = "Y3ESZ117";

        /// <summary>
        /// Y3ESZ118.
        /// </summary>
        public const string Y3ESZ118 = "Y3ESZ118";

        /// <summary>
        /// Y3ESZ119.
        /// </summary>
        public const string Y3ESZ119 = "Y3ESZ119";

        /// <summary>
        /// Y3ESZ120.
        /// </summary>
        public const string Y3ESZ120 = "Y3ESZ120";

        /// <summary>
        /// Y3ESZ121.
        /// </summary>
        public const string Y3ESZ121 = "Y3ESZ121";

        /// <summary>
        /// Y3ESZ122.
        /// </summary>
        public const string Y3ESZ122 = "Y3ESZ122";

        /// <summary>
        /// Y3ESZ123.
        /// </summary>
        public const string Y3ESZ123 = "Y3ESZ123";

        /// <summary>
        /// Y3ESZ124.
        /// </summary>
        public const string Y3ESZ124 = "Y3ESZ124";

        /// <summary>
        /// Y3ESZ125.
        /// </summary>
        public const string Y3ESZ125 = "Y3ESZ125";

        /// <summary>
        /// Y3ESZ126.
        /// </summary>
        public const string Y3ESZ126 = "Y3ESZ126";

        /// <summary>
        /// Y3ESZ127.
        /// </summary>
        public const string Y3ESZ127 = "Y3ESZ127";

        /// <summary>
        /// Y3ESZ128.
        /// </summary>
        public const string Y3ESZ128 = "Y3ESZ128";

        /// <summary>
        /// Y3ESZ129.
        /// </summary>
        public const string Y3ESZ129 = "Y3ESZ129";

        /// <summary>
        /// Y3ESZ130.
        /// </summary>
        public const string Y3ESZ130 = "Y3ESZ130";

        /// <summary>
        /// Y3ESZ131.
        /// </summary>
        public const string Y3ESZ131 = "Y3ESZ131";

        /// <summary>
        /// Y3ESZ132.
        /// </summary>
        public const string Y3ESZ132 = "Y3ESZ132";

        /// <summary>
        /// Y3ESZ133.
        /// </summary>
        public const string Y3ESZ133 = "Y3ESZ133";

        /// <summary>
        /// Y3ESZ134.
        /// </summary>
        public const string Y3ESZ134 = "Y3ESZ134";

        /// <summary>
        /// Y3ESZ135.
        /// </summary>
        public const string Y3ESZ135 = "Y3ESZ135";

        /// <summary>
        /// Y3ESZ136.
        /// </summary>
        public const string Y3ESZ136 = "Y3ESZ136";

        /// <summary>
        /// Y3ESZ137.
        /// </summary>
        public const string Y3ESZ137 = "Y3ESZ137";

        /// <summary>
        /// Y3ESZ138.
        /// </summary>
        public const string Y3ESZ138 = "Y3ESZ138";

        /// <summary>
        /// Y3ESZ139.
        /// </summary>
        public const string Y3ESZ139 = "Y3ESZ139";

        /// <summary>
        /// Y3ESZ140.
        /// </summary>
        public const string Y3ESZ140 = "Y3ESZ140";

        /// <summary>
        /// Y3ESZ141.
        /// </summary>
        public const string Y3ESZ141 = "Y3ESZ141";

        /// <summary>
        /// Y3ESZ142.
        /// </summary>
        public const string Y3ESZ142 = "Y3ESZ142";

        /// <summary>
        /// Y3ESZ143.
        /// </summary>
        public const string Y3ESZ143 = "Y3ESZ143";

        /// <summary>
        /// Y3ESZ144.
        /// </summary>
        public const string Y3ESZ144 = "Y3ESZ144";

        /// <summary>
        /// Y3ESZ145.
        /// </summary>
        public const string Y3ESZ145 = "Y3ESZ145";

        /// <summary>
        /// Y3ESZ146.
        /// </summary>
        public const string Y3ESZ146 = "Y3ESZ146";

        /// <summary>
        /// Y3ESZ147.
        /// </summary>
        public const string Y3ESZ147 = "Y3ESZ147";

        /// <summary>
        /// Y3ESZ148.
        /// </summary>
        public const string Y3ESZ148 = "Y3ESZ148";

        /// <summary>
        /// Y3ESZ149.
        /// </summary>
        public const string Y3ESZ149 = "Y3ESZ149";

        /// <summary>
        /// Y3ESZ150.
        /// </summary>
        public const string Y3ESZ150 = "Y3ESZ150";

        /// <summary>
        /// Y3ESZ151.
        /// </summary>
        public const string Y3ESZ151 = "Y3ESZ151";

        /// <summary>
        /// Y3ESZ152.
        /// </summary>
        public const string Y3ESZ152 = "Y3ESZ152";

        /// <summary>
        /// Y3ESZ155.
        /// </summary>
        public const string Y3ESZ155 = "Y3ESZ155";

        /// <summary>
        /// Y3ESZ153.
        /// </summary>
        public const string Y3ESZ153 = "Y3ESZ153";

        /// <summary>
        /// Y3ESZ156.
        /// </summary>
        public const string Y3ESZ156 = "Y3ESZ156";

        /// <summary>
        /// Y3ESZ154.
        /// </summary>
        public const string Y3ESZ154 = "Y3ESZ154";

        /// <summary>
        /// Y3ESZ157.
        /// </summary>
        public const string Y3ESZ157 = "Y3ESZ157";

        /// <summary>
        /// Y3ESZ158.
        /// </summary>
        public const string Y3ESZ158 = "Y3ESZ158";

        /// <summary>
        /// Y3ESZ159.
        /// </summary>
        public const string Y3ESZ159 = "Y3ESZ159";

        /// <summary>
        /// Y3ESZ160.
        /// </summary>
        public const string Y3ESZ160 = "Y3ESZ160";

        /// <summary>
        /// Y3ESZ161.
        /// </summary>
        public const string Y3ESZ161 = "Y3ESZ161";

        /// <summary>
        /// Y3ESZ162.
        /// </summary>
        public const string Y3ESZ162 = "Y3ESZ162";

        /// <summary>
        /// Y3ESZ163.
        /// </summary>
        public const string Y3ESZ163 = "Y3ESZ163";

        /// <summary>
        /// Y3ESZ164.
        /// </summary>
        public const string Y3ESZ164 = "Y3ESZ164";

        /// <summary>
        /// Y3ESZ165.
        /// </summary>
        public const string Y3ESZ165 = "Y3ESZ165";

        /// <summary>
        /// Y3ESZ166.
        /// </summary>
        public const string Y3ESZ166 = "Y3ESZ166";

        /// <summary>
        /// Y3ESZ167.
        /// </summary>
        public const string Y3ESZ167 = "Y3ESZ167";

        /// <summary>
        /// Y3ESZ168.
        /// </summary>
        public const string Y3ESZ168 = "Y3ESZ168";

        /// <summary>
        /// Y3ESZ169.
        /// </summary>
        public const string Y3ESZ169 = "Y3ESZ169";

        /// <summary>
        /// Y3ESZ170.
        /// </summary>
        public const string Y3ESZ170 = "Y3ESZ170";

        /// <summary>
        /// Y3ESZ171.
        /// </summary>
        public const string Y3ESZ171 = "Y3ESZ171";

        /// <summary>
        /// Y3ESZ095.
        /// </summary>
        public const string Y3ESZ095 = "Y3ESZ095";

        /// <summary>
        /// Y3ESZ177.
        /// </summary>
        public const string Y3ESZ177 = "Y3ESZ177";

        /// <summary>
        /// Y3ESZ094.
        /// </summary>
        public const string Y3ESZ094 = "Y3ESZ094";

        /// <summary>
        /// Y3ESZ176.
        /// </summary>
        public const string Y3ESZ176 = "Y3ESZ176";

        /// <summary>
        /// Y3ESZ172.
        /// </summary>
        public const string Y3ESZ172 = "Y3ESZ172";

        /// <summary>
        /// Y3PID.
        /// </summary>
        public const string Y3PID = "Y3PID";

        /// <summary>
        /// Y3UPMJ.
        /// </summary>
        public const string Y3UPMJ = "Y3UPMJ";

        /// <summary>
        /// Y3JOBN.
        /// </summary>
        public const string Y3JOBN = "Y3JOBN";

        /// <summary>
        /// Y3UPMT.
        /// </summary>
        public const string Y3UPMT = "Y3UPMT";

        /// <summary>
        /// Y3ESZ178.
        /// </summary>
        public const string Y3ESZ178 = "Y3ESZ178";

        /// <summary>
        /// Y3ESZ179.
        /// </summary>
        public const string Y3ESZ179 = "Y3ESZ179";

        /// <summary>
        /// Y3ESZ180.
        /// </summary>
        public const string Y3ESZ180 = "Y3ESZ180";

        /// <summary>
        /// Y3ESZ181.
        /// </summary>
        public const string Y3ESZ181 = "Y3ESZ181";

        /// <summary>
        /// Y3ESZ182.
        /// </summary>
        public const string Y3ESZ182 = "Y3ESZ182";

        /// <summary>
        /// Y3ESZ183.
        /// </summary>
        public const string Y3ESZ183 = "Y3ESZ183";

        /// <summary>
        /// Y3ESZ184.
        /// </summary>
        public const string Y3ESZ184 = "Y3ESZ184";

        /// <summary>
        /// Y3ESZ185.
        /// </summary>
        public const string Y3ESZ185 = "Y3ESZ185";

        /// <summary>
        /// Y3ESZ186.
        /// </summary>
        public const string Y3ESZ186 = "Y3ESZ186";

        /// <summary>
        /// Y3ESZ187.
        /// </summary>
        public const string Y3ESZ187 = "Y3ESZ187";
    }

    /// <inheritdoc />
    public override string TableName => "F051123";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y3HMCO", "Y3HMCO", JdeDataType.String, 10, true, true),
        new JdeField("Y3HMCU", "Y3HMCU", JdeDataType.String, 24, true, true),
        new JdeField("Y3ESZ000", "Y3ESZ000", JdeDataType.String, 2),
        new JdeField("Y3ESZ174", "Y3ESZ174", JdeDataType.String, 2),
        new JdeField("Y3ESZ173", "Y3ESZ173", JdeDataType.String, 2),
        new JdeField("Y3ESZ001", "Y3ESZ001", JdeDataType.String, 2),
        new JdeField("Y3ESZ002", "Y3ESZ002", JdeDataType.String, 2),
        new JdeField("Y3ESZ003", "Y3ESZ003", JdeDataType.String, 2),
        new JdeField("Y3ESZ004", "Y3ESZ004", JdeDataType.String, 2),
        new JdeField("Y3ESZ005", "Y3ESZ005", JdeDataType.String, 2),
        new JdeField("Y3ESZ006", "Y3ESZ006", JdeDataType.String, 2),
        new JdeField("Y3ESZ007", "Y3ESZ007", JdeDataType.String, 2),
        new JdeField("Y3ESZ008", "Y3ESZ008", JdeDataType.String, 2),
        new JdeField("Y3ESZ009", "Y3ESZ009", JdeDataType.String, 2),
        new JdeField("Y3ESZ010", "Y3ESZ010", JdeDataType.String, 2),
        new JdeField("Y3ESZ011", "Y3ESZ011", JdeDataType.String, 2),
        new JdeField("Y3ESZ012", "Y3ESZ012", JdeDataType.String, 2),
        new JdeField("Y3ESZ013", "Y3ESZ013", JdeDataType.String, 2),
        new JdeField("Y3ESZ014", "Y3ESZ014", JdeDataType.String, 2),
        new JdeField("Y3ESZ015", "Y3ESZ015", JdeDataType.String, 2),
        new JdeField("Y3ESZ016", "Y3ESZ016", JdeDataType.String, 2),
        new JdeField("Y3ESZ017", "Y3ESZ017", JdeDataType.String, 2),
        new JdeField("Y3ESZ018", "Y3ESZ018", JdeDataType.String, 2),
        new JdeField("Y3ESZ019", "Y3ESZ019", JdeDataType.String, 2),
        new JdeField("Y3ESZ020", "Y3ESZ020", JdeDataType.String, 2),
        new JdeField("Y3ESZ021", "Y3ESZ021", JdeDataType.String, 2),
        new JdeField("Y3ESZ022", "Y3ESZ022", JdeDataType.String, 2),
        new JdeField("Y3ESZ023", "Y3ESZ023", JdeDataType.String, 2),
        new JdeField("Y3ESZ024", "Y3ESZ024", JdeDataType.String, 2),
        new JdeField("Y3ESZ025", "Y3ESZ025", JdeDataType.String, 2),
        new JdeField("Y3ESZ026", "Y3ESZ026", JdeDataType.String, 2),
        new JdeField("Y3ESZ027", "Y3ESZ027", JdeDataType.String, 2),
        new JdeField("Y3ESZ028", "Y3ESZ028", JdeDataType.String, 2),
        new JdeField("Y3ESZ029", "Y3ESZ029", JdeDataType.String, 2),
        new JdeField("Y3ESZ030", "Y3ESZ030", JdeDataType.String, 2),
        new JdeField("Y3ESZ031", "Y3ESZ031", JdeDataType.String, 2),
        new JdeField("Y3ESZ032", "Y3ESZ032", JdeDataType.String, 2),
        new JdeField("Y3ESZ033", "Y3ESZ033", JdeDataType.String, 2),
        new JdeField("Y3ESZ034", "Y3ESZ034", JdeDataType.String, 2),
        new JdeField("Y3ESZ035", "Y3ESZ035", JdeDataType.String, 2),
        new JdeField("Y3ESZ036", "Y3ESZ036", JdeDataType.String, 2),
        new JdeField("Y3ESZ037", "Y3ESZ037", JdeDataType.String, 2),
        new JdeField("Y3ESZ038", "Y3ESZ038", JdeDataType.String, 2),
        new JdeField("Y3ESZ039", "Y3ESZ039", JdeDataType.String, 2),
        new JdeField("Y3ESZ040", "Y3ESZ040", JdeDataType.String, 2),
        new JdeField("Y3ESZ041", "Y3ESZ041", JdeDataType.String, 2),
        new JdeField("Y3ESZ042", "Y3ESZ042", JdeDataType.String, 2),
        new JdeField("Y3ESZ043", "Y3ESZ043", JdeDataType.String, 2),
        new JdeField("Y3ESZ044", "Y3ESZ044", JdeDataType.String, 2),
        new JdeField("Y3ESZ045", "Y3ESZ045", JdeDataType.String, 2),
        new JdeField("Y3ESZ046", "Y3ESZ046", JdeDataType.String, 2),
        new JdeField("Y3ESZ047", "Y3ESZ047", JdeDataType.String, 2),
        new JdeField("Y3ESZ048", "Y3ESZ048", JdeDataType.String, 2),
        new JdeField("Y3ESZ049", "Y3ESZ049", JdeDataType.String, 2),
        new JdeField("Y3ESZ050", "Y3ESZ050", JdeDataType.String, 2),
        new JdeField("Y3ESZ051", "Y3ESZ051", JdeDataType.String, 2),
        new JdeField("Y3ESZ052", "Y3ESZ052", JdeDataType.String, 2),
        new JdeField("Y3ESZ053", "Y3ESZ053", JdeDataType.String, 2),
        new JdeField("Y3ESZ054", "Y3ESZ054", JdeDataType.String, 2),
        new JdeField("Y3ESZ055", "Y3ESZ055", JdeDataType.String, 2),
        new JdeField("Y3ESZ056", "Y3ESZ056", JdeDataType.String, 2),
        new JdeField("Y3ESZ057", "Y3ESZ057", JdeDataType.String, 2),
        new JdeField("Y3ESZ058", "Y3ESZ058", JdeDataType.String, 2),
        new JdeField("Y3ESZ059", "Y3ESZ059", JdeDataType.String, 2),
        new JdeField("Y3ESZ060", "Y3ESZ060", JdeDataType.String, 2),
        new JdeField("Y3ESZ061", "Y3ESZ061", JdeDataType.String, 2),
        new JdeField("Y3ESZ062", "Y3ESZ062", JdeDataType.String, 2),
        new JdeField("Y3ESZ063", "Y3ESZ063", JdeDataType.String, 2),
        new JdeField("Y3ESZ064", "Y3ESZ064", JdeDataType.String, 2),
        new JdeField("Y3ESZ065", "Y3ESZ065", JdeDataType.String, 2),
        new JdeField("Y3ESZ066", "Y3ESZ066", JdeDataType.String, 2),
        new JdeField("Y3ESZ067", "Y3ESZ067", JdeDataType.String, 2),
        new JdeField("Y3ESZ068", "Y3ESZ068", JdeDataType.String, 2),
        new JdeField("Y3ESZ069", "Y3ESZ069", JdeDataType.String, 2),
        new JdeField("Y3ESZ070", "Y3ESZ070", JdeDataType.String, 2),
        new JdeField("Y3ESZ071", "Y3ESZ071", JdeDataType.String, 2),
        new JdeField("Y3ESZ072", "Y3ESZ072", JdeDataType.String, 2),
        new JdeField("Y3ESZ073", "Y3ESZ073", JdeDataType.String, 2),
        new JdeField("Y3ESZ074", "Y3ESZ074", JdeDataType.String, 2),
        new JdeField("Y3ESZ075", "Y3ESZ075", JdeDataType.String, 2),
        new JdeField("Y3ESZ076", "Y3ESZ076", JdeDataType.String, 2),
        new JdeField("Y3ESZ077", "Y3ESZ077", JdeDataType.String, 2),
        new JdeField("Y3ESZ078", "Y3ESZ078", JdeDataType.String, 2),
        new JdeField("Y3ESZ079", "Y3ESZ079", JdeDataType.String, 2),
        new JdeField("Y3ESZ080", "Y3ESZ080", JdeDataType.String, 2),
        new JdeField("Y3ESZ081", "Y3ESZ081", JdeDataType.String, 2),
        new JdeField("Y3ESZ082", "Y3ESZ082", JdeDataType.String, 2),
        new JdeField("Y3ESZ083", "Y3ESZ083", JdeDataType.String, 2),
        new JdeField("Y3ESZ084", "Y3ESZ084", JdeDataType.String, 2),
        new JdeField("Y3ESZ085", "Y3ESZ085", JdeDataType.String, 2),
        new JdeField("Y3ESZ086", "Y3ESZ086", JdeDataType.String, 2),
        new JdeField("Y3ESZ087", "Y3ESZ087", JdeDataType.String, 2),
        new JdeField("Y3ESZ088", "Y3ESZ088", JdeDataType.String, 2),
        new JdeField("Y3ESZ089", "Y3ESZ089", JdeDataType.String, 2),
        new JdeField("Y3ESZ175", "Y3ESZ175", JdeDataType.String, 2),
        new JdeField("Y3ESZ090", "Y3ESZ090", JdeDataType.String, 2),
        new JdeField("Y3ESZ091", "Y3ESZ091", JdeDataType.String, 2),
        new JdeField("Y3ESZ092", "Y3ESZ092", JdeDataType.String, 2),
        new JdeField("Y3ESZ093", "Y3ESZ093", JdeDataType.String, 2),
        new JdeField("Y3ESZ096", "Y3ESZ096", JdeDataType.String, 2),
        new JdeField("Y3ESZ097", "Y3ESZ097", JdeDataType.String, 2),
        new JdeField("Y3ESZ098", "Y3ESZ098", JdeDataType.String, 2),
        new JdeField("Y3ESZ099", "Y3ESZ099", JdeDataType.String, 2),
        new JdeField("Y3ESZ100", "Y3ESZ100", JdeDataType.String, 2),
        new JdeField("Y3ESZ101", "Y3ESZ101", JdeDataType.String, 2),
        new JdeField("Y3ESZ102", "Y3ESZ102", JdeDataType.String, 2),
        new JdeField("Y3ESZ103", "Y3ESZ103", JdeDataType.String, 2),
        new JdeField("Y3ESZ104", "Y3ESZ104", JdeDataType.String, 2),
        new JdeField("Y3ESZ105", "Y3ESZ105", JdeDataType.String, 2),
        new JdeField("Y3ESZ106", "Y3ESZ106", JdeDataType.String, 2),
        new JdeField("Y3ESZ107", "Y3ESZ107", JdeDataType.String, 2),
        new JdeField("Y3ESZ108", "Y3ESZ108", JdeDataType.String, 2),
        new JdeField("Y3ESZ109", "Y3ESZ109", JdeDataType.String, 2),
        new JdeField("Y3ESZ110", "Y3ESZ110", JdeDataType.String, 2),
        new JdeField("Y3ESZ111", "Y3ESZ111", JdeDataType.String, 2),
        new JdeField("Y3ESZ112", "Y3ESZ112", JdeDataType.String, 2),
        new JdeField("Y3ESZ113", "Y3ESZ113", JdeDataType.String, 2),
        new JdeField("Y3ESZ114", "Y3ESZ114", JdeDataType.String, 2),
        new JdeField("Y3ESZ115", "Y3ESZ115", JdeDataType.String, 2),
        new JdeField("Y3ESZ116", "Y3ESZ116", JdeDataType.String, 2),
        new JdeField("Y3ESZ117", "Y3ESZ117", JdeDataType.String, 2),
        new JdeField("Y3ESZ118", "Y3ESZ118", JdeDataType.String, 2),
        new JdeField("Y3ESZ119", "Y3ESZ119", JdeDataType.String, 2),
        new JdeField("Y3ESZ120", "Y3ESZ120", JdeDataType.String, 2),
        new JdeField("Y3ESZ121", "Y3ESZ121", JdeDataType.String, 2),
        new JdeField("Y3ESZ122", "Y3ESZ122", JdeDataType.String, 2),
        new JdeField("Y3ESZ123", "Y3ESZ123", JdeDataType.String, 2),
        new JdeField("Y3ESZ124", "Y3ESZ124", JdeDataType.String, 2),
        new JdeField("Y3ESZ125", "Y3ESZ125", JdeDataType.String, 2),
        new JdeField("Y3ESZ126", "Y3ESZ126", JdeDataType.String, 2),
        new JdeField("Y3ESZ127", "Y3ESZ127", JdeDataType.String, 2),
        new JdeField("Y3ESZ128", "Y3ESZ128", JdeDataType.String, 2),
        new JdeField("Y3ESZ129", "Y3ESZ129", JdeDataType.String, 2),
        new JdeField("Y3ESZ130", "Y3ESZ130", JdeDataType.String, 2),
        new JdeField("Y3ESZ131", "Y3ESZ131", JdeDataType.String, 2),
        new JdeField("Y3ESZ132", "Y3ESZ132", JdeDataType.String, 2),
        new JdeField("Y3ESZ133", "Y3ESZ133", JdeDataType.String, 2),
        new JdeField("Y3ESZ134", "Y3ESZ134", JdeDataType.String, 2),
        new JdeField("Y3ESZ135", "Y3ESZ135", JdeDataType.String, 2),
        new JdeField("Y3ESZ136", "Y3ESZ136", JdeDataType.String, 2),
        new JdeField("Y3ESZ137", "Y3ESZ137", JdeDataType.String, 2),
        new JdeField("Y3ESZ138", "Y3ESZ138", JdeDataType.String, 2),
        new JdeField("Y3ESZ139", "Y3ESZ139", JdeDataType.String, 2),
        new JdeField("Y3ESZ140", "Y3ESZ140", JdeDataType.String, 2),
        new JdeField("Y3ESZ141", "Y3ESZ141", JdeDataType.String, 2),
        new JdeField("Y3ESZ142", "Y3ESZ142", JdeDataType.String, 2),
        new JdeField("Y3ESZ143", "Y3ESZ143", JdeDataType.String, 2),
        new JdeField("Y3ESZ144", "Y3ESZ144", JdeDataType.String, 2),
        new JdeField("Y3ESZ145", "Y3ESZ145", JdeDataType.String, 2),
        new JdeField("Y3ESZ146", "Y3ESZ146", JdeDataType.String, 2),
        new JdeField("Y3ESZ147", "Y3ESZ147", JdeDataType.String, 2),
        new JdeField("Y3ESZ148", "Y3ESZ148", JdeDataType.String, 2),
        new JdeField("Y3ESZ149", "Y3ESZ149", JdeDataType.String, 2),
        new JdeField("Y3ESZ150", "Y3ESZ150", JdeDataType.String, 2),
        new JdeField("Y3ESZ151", "Y3ESZ151", JdeDataType.String, 2),
        new JdeField("Y3ESZ152", "Y3ESZ152", JdeDataType.String, 2),
        new JdeField("Y3ESZ155", "Y3ESZ155", JdeDataType.String, 2),
        new JdeField("Y3ESZ153", "Y3ESZ153", JdeDataType.String, 2),
        new JdeField("Y3ESZ156", "Y3ESZ156", JdeDataType.String, 2),
        new JdeField("Y3ESZ154", "Y3ESZ154", JdeDataType.String, 2),
        new JdeField("Y3ESZ157", "Y3ESZ157", JdeDataType.String, 2),
        new JdeField("Y3ESZ158", "Y3ESZ158", JdeDataType.String, 2),
        new JdeField("Y3ESZ159", "Y3ESZ159", JdeDataType.String, 2),
        new JdeField("Y3ESZ160", "Y3ESZ160", JdeDataType.String, 2),
        new JdeField("Y3ESZ161", "Y3ESZ161", JdeDataType.String, 2),
        new JdeField("Y3ESZ162", "Y3ESZ162", JdeDataType.String, 2),
        new JdeField("Y3ESZ163", "Y3ESZ163", JdeDataType.String, 2),
        new JdeField("Y3ESZ164", "Y3ESZ164", JdeDataType.String, 2),
        new JdeField("Y3ESZ165", "Y3ESZ165", JdeDataType.String, 2),
        new JdeField("Y3ESZ166", "Y3ESZ166", JdeDataType.String, 2),
        new JdeField("Y3ESZ167", "Y3ESZ167", JdeDataType.String, 2),
        new JdeField("Y3ESZ168", "Y3ESZ168", JdeDataType.String, 2),
        new JdeField("Y3ESZ169", "Y3ESZ169", JdeDataType.String, 2),
        new JdeField("Y3ESZ170", "Y3ESZ170", JdeDataType.String, 2),
        new JdeField("Y3ESZ171", "Y3ESZ171", JdeDataType.String, 2),
        new JdeField("Y3ESZ095", "Y3ESZ095", JdeDataType.String, 2),
        new JdeField("Y3ESZ177", "Y3ESZ177", JdeDataType.String, 2),
        new JdeField("Y3ESZ094", "Y3ESZ094", JdeDataType.String, 2),
        new JdeField("Y3ESZ176", "Y3ESZ176", JdeDataType.String, 2),
        new JdeField("Y3ESZ172", "Y3ESZ172", JdeDataType.String, 2),
        new JdeField("Y3PID", "Y3PID", JdeDataType.String, 20),
        new JdeField("Y3UPMJ", "Y3UPMJ", JdeDataType.Numeric),
        new JdeField("Y3JOBN", "Y3JOBN", JdeDataType.String, 20),
        new JdeField("Y3UPMT", "Y3UPMT", JdeDataType.Numeric),
        new JdeField("Y3ESZ178", "Y3ESZ178", JdeDataType.String, 2),
        new JdeField("Y3ESZ179", "Y3ESZ179", JdeDataType.String, 2),
        new JdeField("Y3ESZ180", "Y3ESZ180", JdeDataType.String, 2),
        new JdeField("Y3ESZ181", "Y3ESZ181", JdeDataType.String, 2),
        new JdeField("Y3ESZ182", "Y3ESZ182", JdeDataType.String, 2),
        new JdeField("Y3ESZ183", "Y3ESZ183", JdeDataType.String, 2),
        new JdeField("Y3ESZ184", "Y3ESZ184", JdeDataType.String, 2),
        new JdeField("Y3ESZ185", "Y3ESZ185", JdeDataType.String, 2),
        new JdeField("Y3ESZ186", "Y3ESZ186", JdeDataType.String, 2),
        new JdeField("Y3ESZ187", "Y3ESZ187", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F051123_0", "Primary Key on Y3HMCO, Y3HMCU", new[] { "Y3HMCO", "Y3HMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
