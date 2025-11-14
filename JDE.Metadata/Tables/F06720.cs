using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06720 - .
/// </summary>
public class F06720 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JEVERS.
        /// </summary>
        public const string JEVERS = "JEVERS";

        /// <summary>
        /// JEDTEY.
        /// </summary>
        public const string JEDTEY = "JEDTEY";

        /// <summary>
        /// JEYR.
        /// </summary>
        public const string JEYR = "JEYR";

        /// <summary>
        /// JEPQTR.
        /// </summary>
        public const string JEPQTR = "JEPQTR";

        /// <summary>
        /// JEW2TP.
        /// </summary>
        public const string JEW2TP = "JEW2TP";

        /// <summary>
        /// JEW2TI.
        /// </summary>
        public const string JEW2TI = "JEW2TI";

        /// <summary>
        /// JETAXX.
        /// </summary>
        public const string JETAXX = "JETAXX";

        /// <summary>
        /// JETIS.
        /// </summary>
        public const string JETIS = "JETIS";

        /// <summary>
        /// JESSDL.
        /// </summary>
        public const string JESSDL = "JESSDL";

        /// <summary>
        /// JEMDDL.
        /// </summary>
        public const string JEMDDL = "JEMDDL";

        /// <summary>
        /// JEPRID.
        /// </summary>
        public const string JEPRID = "JEPRID";

        /// <summary>
        /// JET1DL.
        /// </summary>
        public const string JET1DL = "JET1DL";

        /// <summary>
        /// JET2DL.
        /// </summary>
        public const string JET2DL = "JET2DL";

        /// <summary>
        /// JETAPD.
        /// </summary>
        public const string JETAPD = "JETAPD";

        /// <summary>
        /// JEMMFI.
        /// </summary>
        public const string JEMMFI = "JEMMFI";

        /// <summary>
        /// JEDEVN.
        /// </summary>
        public const string JEDEVN = "JEDEVN";

        /// <summary>
        /// JEW2LC.
        /// </summary>
        public const string JEW2LC = "JEW2LC";

        /// <summary>
        /// JEW2NF.
        /// </summary>
        public const string JEW2NF = "JEW2NF";

        /// <summary>
        /// JEW2PS.
        /// </summary>
        public const string JEW2PS = "JEW2PS";

        /// <summary>
        /// JEW2FI.
        /// </summary>
        public const string JEW2FI = "JEW2FI";

        /// <summary>
        /// JEW2AW.
        /// </summary>
        public const string JEW2AW = "JEW2AW";

        /// <summary>
        /// JEW22S.
        /// </summary>
        public const string JEW22S = "JEW22S";

        /// <summary>
        /// JEW2AC.
        /// </summary>
        public const string JEW2AC = "JEW2AC";

        /// <summary>
        /// JEWBST.
        /// </summary>
        public const string JEWBST = "JEWBST";

        /// <summary>
        /// JERAST.
        /// </summary>
        public const string JERAST = "JERAST";

        /// <summary>
        /// JEFPST.
        /// </summary>
        public const string JEFPST = "JEFPST";

        /// <summary>
        /// JEMMST.
        /// </summary>
        public const string JEMMST = "JEMMST";

        /// <summary>
        /// JECWST.
        /// </summary>
        public const string JECWST = "JECWST";

        /// <summary>
        /// JECCST.
        /// </summary>
        public const string JECCST = "JECCST";

        /// <summary>
        /// JEST17.
        /// </summary>
        public const string JEST17 = "JEST17";

        /// <summary>
        /// JEW2S.
        /// </summary>
        public const string JEW2S = "JEW2S";

        /// <summary>
        /// JEW2CS.
        /// </summary>
        public const string JEW2CS = "JEW2CS";

        /// <summary>
        /// JEW3S.
        /// </summary>
        public const string JEW3S = "JEW3S";

        /// <summary>
        /// JEW3CS.
        /// </summary>
        public const string JEW3CS = "JEW3CS";

        /// <summary>
        /// JER2S.
        /// </summary>
        public const string JER2S = "JER2S";

        /// <summary>
        /// JER2CS.
        /// </summary>
        public const string JER2CS = "JER2CS";

        /// <summary>
        /// JER3S.
        /// </summary>
        public const string JER3S = "JER3S";

        /// <summary>
        /// JER3CS.
        /// </summary>
        public const string JER3CS = "JER3CS";

        /// <summary>
        /// JEM99S.
        /// </summary>
        public const string JEM99S = "JEM99S";

        /// <summary>
        /// JER99S.
        /// </summary>
        public const string JER99S = "JER99S";

        /// <summary>
        /// JES96S.
        /// </summary>
        public const string JES96S = "JES96S";

        /// <summary>
        /// JESEQC.
        /// </summary>
        public const string JESEQC = "JESEQC";

        /// <summary>
        /// JEPA8.
        /// </summary>
        public const string JEPA8 = "JEPA8";

        /// <summary>
        /// JEAN8T.
        /// </summary>
        public const string JEAN8T = "JEAN8T";

        /// <summary>
        /// JEAN8N.
        /// </summary>
        public const string JEAN8N = "JEAN8N";

        /// <summary>
        /// JEWAN8.
        /// </summary>
        public const string JEWAN8 = "JEWAN8";

        /// <summary>
        /// JEAN8D.
        /// </summary>
        public const string JEAN8D = "JEAN8D";

        /// <summary>
        /// JEW2P1.
        /// </summary>
        public const string JEW2P1 = "JEW2P1";

        /// <summary>
        /// JEW2P2.
        /// </summary>
        public const string JEW2P2 = "JEW2P2";

        /// <summary>
        /// JEW2P3.
        /// </summary>
        public const string JEW2P3 = "JEW2P3";

        /// <summary>
        /// JEW2P4.
        /// </summary>
        public const string JEW2P4 = "JEW2P4";

        /// <summary>
        /// JEW2P5.
        /// </summary>
        public const string JEW2P5 = "JEW2P5";

        /// <summary>
        /// JEW2P6.
        /// </summary>
        public const string JEW2P6 = "JEW2P6";

        /// <summary>
        /// JEW2P7.
        /// </summary>
        public const string JEW2P7 = "JEW2P7";

        /// <summary>
        /// JEW2P8.
        /// </summary>
        public const string JEW2P8 = "JEW2P8";

        /// <summary>
        /// JEW2P9.
        /// </summary>
        public const string JEW2P9 = "JEW2P9";

        /// <summary>
        /// JEW2P0.
        /// </summary>
        public const string JEW2P0 = "JEW2P0";

        /// <summary>
        /// JEW201.
        /// </summary>
        public const string JEW201 = "JEW201";

        /// <summary>
        /// JEW202.
        /// </summary>
        public const string JEW202 = "JEW202";

        /// <summary>
        /// JEW203.
        /// </summary>
        public const string JEW203 = "JEW203";

        /// <summary>
        /// JEW204.
        /// </summary>
        public const string JEW204 = "JEW204";

        /// <summary>
        /// JEW205.
        /// </summary>
        public const string JEW205 = "JEW205";

        /// <summary>
        /// JEW206.
        /// </summary>
        public const string JEW206 = "JEW206";

        /// <summary>
        /// JEW207.
        /// </summary>
        public const string JEW207 = "JEW207";

        /// <summary>
        /// JEW208.
        /// </summary>
        public const string JEW208 = "JEW208";

        /// <summary>
        /// JEW209.
        /// </summary>
        public const string JEW209 = "JEW209";

        /// <summary>
        /// JEW210.
        /// </summary>
        public const string JEW210 = "JEW210";

        /// <summary>
        /// JEW211.
        /// </summary>
        public const string JEW211 = "JEW211";

        /// <summary>
        /// JEW212.
        /// </summary>
        public const string JEW212 = "JEW212";

        /// <summary>
        /// JEW213.
        /// </summary>
        public const string JEW213 = "JEW213";

        /// <summary>
        /// JEW214.
        /// </summary>
        public const string JEW214 = "JEW214";

        /// <summary>
        /// JEW215.
        /// </summary>
        public const string JEW215 = "JEW215";

        /// <summary>
        /// JEW216.
        /// </summary>
        public const string JEW216 = "JEW216";

        /// <summary>
        /// JEW217.
        /// </summary>
        public const string JEW217 = "JEW217";

        /// <summary>
        /// JEW218.
        /// </summary>
        public const string JEW218 = "JEW218";

        /// <summary>
        /// JEW219.
        /// </summary>
        public const string JEW219 = "JEW219";

        /// <summary>
        /// JEW220.
        /// </summary>
        public const string JEW220 = "JEW220";

        /// <summary>
        /// JEW221.
        /// </summary>
        public const string JEW221 = "JEW221";

        /// <summary>
        /// JEW222.
        /// </summary>
        public const string JEW222 = "JEW222";

        /// <summary>
        /// JEW223.
        /// </summary>
        public const string JEW223 = "JEW223";

        /// <summary>
        /// JEW224.
        /// </summary>
        public const string JEW224 = "JEW224";

        /// <summary>
        /// JEW225.
        /// </summary>
        public const string JEW225 = "JEW225";

        /// <summary>
        /// JEW226.
        /// </summary>
        public const string JEW226 = "JEW226";

        /// <summary>
        /// JEW227.
        /// </summary>
        public const string JEW227 = "JEW227";

        /// <summary>
        /// JEW228.
        /// </summary>
        public const string JEW228 = "JEW228";

        /// <summary>
        /// JEW229.
        /// </summary>
        public const string JEW229 = "JEW229";

        /// <summary>
        /// JEW230.
        /// </summary>
        public const string JEW230 = "JEW230";

        /// <summary>
        /// JEW231.
        /// </summary>
        public const string JEW231 = "JEW231";

        /// <summary>
        /// JEW232.
        /// </summary>
        public const string JEW232 = "JEW232";

        /// <summary>
        /// JEW233.
        /// </summary>
        public const string JEW233 = "JEW233";

        /// <summary>
        /// JEW234.
        /// </summary>
        public const string JEW234 = "JEW234";

        /// <summary>
        /// JEW235.
        /// </summary>
        public const string JEW235 = "JEW235";

        /// <summary>
        /// JEW236.
        /// </summary>
        public const string JEW236 = "JEW236";

        /// <summary>
        /// JEW237.
        /// </summary>
        public const string JEW237 = "JEW237";

        /// <summary>
        /// JEW238.
        /// </summary>
        public const string JEW238 = "JEW238";

        /// <summary>
        /// JEW239.
        /// </summary>
        public const string JEW239 = "JEW239";

        /// <summary>
        /// JEW240.
        /// </summary>
        public const string JEW240 = "JEW240";

        /// <summary>
        /// JEW241.
        /// </summary>
        public const string JEW241 = "JEW241";

        /// <summary>
        /// JEW242.
        /// </summary>
        public const string JEW242 = "JEW242";

        /// <summary>
        /// JEW243.
        /// </summary>
        public const string JEW243 = "JEW243";

        /// <summary>
        /// JEW244.
        /// </summary>
        public const string JEW244 = "JEW244";

        /// <summary>
        /// JEW245.
        /// </summary>
        public const string JEW245 = "JEW245";

        /// <summary>
        /// JEW246.
        /// </summary>
        public const string JEW246 = "JEW246";

        /// <summary>
        /// JEW247.
        /// </summary>
        public const string JEW247 = "JEW247";

        /// <summary>
        /// JEW248.
        /// </summary>
        public const string JEW248 = "JEW248";

        /// <summary>
        /// JEW249.
        /// </summary>
        public const string JEW249 = "JEW249";

        /// <summary>
        /// JEW250.
        /// </summary>
        public const string JEW250 = "JEW250";

        /// <summary>
        /// JEW251.
        /// </summary>
        public const string JEW251 = "JEW251";

        /// <summary>
        /// JEW252.
        /// </summary>
        public const string JEW252 = "JEW252";

        /// <summary>
        /// JEW253.
        /// </summary>
        public const string JEW253 = "JEW253";

        /// <summary>
        /// JEW254.
        /// </summary>
        public const string JEW254 = "JEW254";

        /// <summary>
        /// JEW255.
        /// </summary>
        public const string JEW255 = "JEW255";

        /// <summary>
        /// JEW256.
        /// </summary>
        public const string JEW256 = "JEW256";

        /// <summary>
        /// JEW257.
        /// </summary>
        public const string JEW257 = "JEW257";

        /// <summary>
        /// JEW258.
        /// </summary>
        public const string JEW258 = "JEW258";

        /// <summary>
        /// JEW259.
        /// </summary>
        public const string JEW259 = "JEW259";

        /// <summary>
        /// JEW260.
        /// </summary>
        public const string JEW260 = "JEW260";

        /// <summary>
        /// JEHC01.
        /// </summary>
        public const string JEHC01 = "JEHC01";

        /// <summary>
        /// JEHC02.
        /// </summary>
        public const string JEHC02 = "JEHC02";

        /// <summary>
        /// JEHC03.
        /// </summary>
        public const string JEHC03 = "JEHC03";

        /// <summary>
        /// JEHC04.
        /// </summary>
        public const string JEHC04 = "JEHC04";

        /// <summary>
        /// JEHC05.
        /// </summary>
        public const string JEHC05 = "JEHC05";

        /// <summary>
        /// JEHC06.
        /// </summary>
        public const string JEHC06 = "JEHC06";

        /// <summary>
        /// JEHC07.
        /// </summary>
        public const string JEHC07 = "JEHC07";

        /// <summary>
        /// JEHC08.
        /// </summary>
        public const string JEHC08 = "JEHC08";

        /// <summary>
        /// JEHC09.
        /// </summary>
        public const string JEHC09 = "JEHC09";

        /// <summary>
        /// JEHC10.
        /// </summary>
        public const string JEHC10 = "JEHC10";

        /// <summary>
        /// JEEE01.
        /// </summary>
        public const string JEEE01 = "JEEE01";

        /// <summary>
        /// JEEE02.
        /// </summary>
        public const string JEEE02 = "JEEE02";

        /// <summary>
        /// JEEE03.
        /// </summary>
        public const string JEEE03 = "JEEE03";

        /// <summary>
        /// JEEE04.
        /// </summary>
        public const string JEEE04 = "JEEE04";

        /// <summary>
        /// JEEE05.
        /// </summary>
        public const string JEEE05 = "JEEE05";

        /// <summary>
        /// JEEE06.
        /// </summary>
        public const string JEEE06 = "JEEE06";

        /// <summary>
        /// JEEE07.
        /// </summary>
        public const string JEEE07 = "JEEE07";

        /// <summary>
        /// JEEE08.
        /// </summary>
        public const string JEEE08 = "JEEE08";

        /// <summary>
        /// JEEE09.
        /// </summary>
        public const string JEEE09 = "JEEE09";

        /// <summary>
        /// JEEE10.
        /// </summary>
        public const string JEEE10 = "JEEE10";

        /// <summary>
        /// JEEE11.
        /// </summary>
        public const string JEEE11 = "JEEE11";

        /// <summary>
        /// JEEE12.
        /// </summary>
        public const string JEEE12 = "JEEE12";

        /// <summary>
        /// JEEE13.
        /// </summary>
        public const string JEEE13 = "JEEE13";

        /// <summary>
        /// JEEE14.
        /// </summary>
        public const string JEEE14 = "JEEE14";

        /// <summary>
        /// JEEE15.
        /// </summary>
        public const string JEEE15 = "JEEE15";

        /// <summary>
        /// JEEE16.
        /// </summary>
        public const string JEEE16 = "JEEE16";

        /// <summary>
        /// JEEE17.
        /// </summary>
        public const string JEEE17 = "JEEE17";

        /// <summary>
        /// JEEE18.
        /// </summary>
        public const string JEEE18 = "JEEE18";

        /// <summary>
        /// JEEE19.
        /// </summary>
        public const string JEEE19 = "JEEE19";

        /// <summary>
        /// JEEE20.
        /// </summary>
        public const string JEEE20 = "JEEE20";

        /// <summary>
        /// JEEE21.
        /// </summary>
        public const string JEEE21 = "JEEE21";

        /// <summary>
        /// JEEE22.
        /// </summary>
        public const string JEEE22 = "JEEE22";

        /// <summary>
        /// JEEE23.
        /// </summary>
        public const string JEEE23 = "JEEE23";

        /// <summary>
        /// JEEE24.
        /// </summary>
        public const string JEEE24 = "JEEE24";

        /// <summary>
        /// JEEE25.
        /// </summary>
        public const string JEEE25 = "JEEE25";

        /// <summary>
        /// JEEE26.
        /// </summary>
        public const string JEEE26 = "JEEE26";

        /// <summary>
        /// JEEE27.
        /// </summary>
        public const string JEEE27 = "JEEE27";

        /// <summary>
        /// JEEE28.
        /// </summary>
        public const string JEEE28 = "JEEE28";

        /// <summary>
        /// JEEE29.
        /// </summary>
        public const string JEEE29 = "JEEE29";

        /// <summary>
        /// JEEE30.
        /// </summary>
        public const string JEEE30 = "JEEE30";

        /// <summary>
        /// JEEE31.
        /// </summary>
        public const string JEEE31 = "JEEE31";

        /// <summary>
        /// JEEE32.
        /// </summary>
        public const string JEEE32 = "JEEE32";

        /// <summary>
        /// JEEE33.
        /// </summary>
        public const string JEEE33 = "JEEE33";

        /// <summary>
        /// JEEE34.
        /// </summary>
        public const string JEEE34 = "JEEE34";

        /// <summary>
        /// JEEE35.
        /// </summary>
        public const string JEEE35 = "JEEE35";

        /// <summary>
        /// JEEE36.
        /// </summary>
        public const string JEEE36 = "JEEE36";

        /// <summary>
        /// JEEE37.
        /// </summary>
        public const string JEEE37 = "JEEE37";

        /// <summary>
        /// JEEE38.
        /// </summary>
        public const string JEEE38 = "JEEE38";

        /// <summary>
        /// JEEE39.
        /// </summary>
        public const string JEEE39 = "JEEE39";

        /// <summary>
        /// JEEE40.
        /// </summary>
        public const string JEEE40 = "JEEE40";

        /// <summary>
        /// JEEE41.
        /// </summary>
        public const string JEEE41 = "JEEE41";

        /// <summary>
        /// JEEE42.
        /// </summary>
        public const string JEEE42 = "JEEE42";

        /// <summary>
        /// JEEE43.
        /// </summary>
        public const string JEEE43 = "JEEE43";

        /// <summary>
        /// JEEE44.
        /// </summary>
        public const string JEEE44 = "JEEE44";

        /// <summary>
        /// JEEE45.
        /// </summary>
        public const string JEEE45 = "JEEE45";

        /// <summary>
        /// JEEE46.
        /// </summary>
        public const string JEEE46 = "JEEE46";

        /// <summary>
        /// JEEE47.
        /// </summary>
        public const string JEEE47 = "JEEE47";

        /// <summary>
        /// JEEE48.
        /// </summary>
        public const string JEEE48 = "JEEE48";

        /// <summary>
        /// JEEE49.
        /// </summary>
        public const string JEEE49 = "JEEE49";

        /// <summary>
        /// JEEE50.
        /// </summary>
        public const string JEEE50 = "JEEE50";

        /// <summary>
        /// JEOF01.
        /// </summary>
        public const string JEOF01 = "JEOF01";

        /// <summary>
        /// JEOF02.
        /// </summary>
        public const string JEOF02 = "JEOF02";

        /// <summary>
        /// JEOF03.
        /// </summary>
        public const string JEOF03 = "JEOF03";

        /// <summary>
        /// JEOF04.
        /// </summary>
        public const string JEOF04 = "JEOF04";

        /// <summary>
        /// JEOF05.
        /// </summary>
        public const string JEOF05 = "JEOF05";

        /// <summary>
        /// JEOF06.
        /// </summary>
        public const string JEOF06 = "JEOF06";

        /// <summary>
        /// JEOF07.
        /// </summary>
        public const string JEOF07 = "JEOF07";

        /// <summary>
        /// JEOF08.
        /// </summary>
        public const string JEOF08 = "JEOF08";

        /// <summary>
        /// JEOF09.
        /// </summary>
        public const string JEOF09 = "JEOF09";

        /// <summary>
        /// JEOF10.
        /// </summary>
        public const string JEOF10 = "JEOF10";

        /// <summary>
        /// JEOF11.
        /// </summary>
        public const string JEOF11 = "JEOF11";

        /// <summary>
        /// JEOF12.
        /// </summary>
        public const string JEOF12 = "JEOF12";

        /// <summary>
        /// JEOF13.
        /// </summary>
        public const string JEOF13 = "JEOF13";

        /// <summary>
        /// JEOF14.
        /// </summary>
        public const string JEOF14 = "JEOF14";

        /// <summary>
        /// JEOF15.
        /// </summary>
        public const string JEOF15 = "JEOF15";

        /// <summary>
        /// JEOF16.
        /// </summary>
        public const string JEOF16 = "JEOF16";

        /// <summary>
        /// JEOF17.
        /// </summary>
        public const string JEOF17 = "JEOF17";

        /// <summary>
        /// JEOF18.
        /// </summary>
        public const string JEOF18 = "JEOF18";

        /// <summary>
        /// JEOF19.
        /// </summary>
        public const string JEOF19 = "JEOF19";

        /// <summary>
        /// JEOF20.
        /// </summary>
        public const string JEOF20 = "JEOF20";

        /// <summary>
        /// JEW41S.
        /// </summary>
        public const string JEW41S = "JEW41S";

        /// <summary>
        /// JER241.
        /// </summary>
        public const string JER241 = "JER241";

        /// <summary>
        /// JEM941.
        /// </summary>
        public const string JEM941 = "JEM941";

        /// <summary>
        /// JER941.
        /// </summary>
        public const string JER941 = "JER941";

        /// <summary>
        /// JEWS01.
        /// </summary>
        public const string JEWS01 = "JEWS01";

        /// <summary>
        /// JEWS02.
        /// </summary>
        public const string JEWS02 = "JEWS02";

        /// <summary>
        /// JEWS03.
        /// </summary>
        public const string JEWS03 = "JEWS03";

        /// <summary>
        /// JEWS04.
        /// </summary>
        public const string JEWS04 = "JEWS04";

        /// <summary>
        /// JEWS05.
        /// </summary>
        public const string JEWS05 = "JEWS05";

        /// <summary>
        /// JEWS06.
        /// </summary>
        public const string JEWS06 = "JEWS06";

        /// <summary>
        /// JEWS07.
        /// </summary>
        public const string JEWS07 = "JEWS07";

        /// <summary>
        /// JEWS08.
        /// </summary>
        public const string JEWS08 = "JEWS08";

        /// <summary>
        /// JEWS09.
        /// </summary>
        public const string JEWS09 = "JEWS09";

        /// <summary>
        /// JEWS10.
        /// </summary>
        public const string JEWS10 = "JEWS10";

        /// <summary>
        /// JEWS11.
        /// </summary>
        public const string JEWS11 = "JEWS11";

        /// <summary>
        /// JEWS12.
        /// </summary>
        public const string JEWS12 = "JEWS12";

        /// <summary>
        /// JEWS13.
        /// </summary>
        public const string JEWS13 = "JEWS13";

        /// <summary>
        /// JEWS14.
        /// </summary>
        public const string JEWS14 = "JEWS14";

        /// <summary>
        /// JEWS15.
        /// </summary>
        public const string JEWS15 = "JEWS15";

        /// <summary>
        /// JERNUM.
        /// </summary>
        public const string JERNUM = "JERNUM";

        /// <summary>
        /// JEUSER.
        /// </summary>
        public const string JEUSER = "JEUSER";

        /// <summary>
        /// JEPID.
        /// </summary>
        public const string JEPID = "JEPID";

        /// <summary>
        /// JEUPMJ.
        /// </summary>
        public const string JEUPMJ = "JEUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F06720";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JEVERS", "JEVERS", JdeDataType.String, 20),
        new JdeField("JEDTEY", "JEDTEY", JdeDataType.Numeric),
        new JdeField("JEYR", "JEYR", JdeDataType.Numeric),
        new JdeField("JEPQTR", "JEPQTR", JdeDataType.String, 2),
        new JdeField("JEW2TP", "JEW2TP", JdeDataType.String, 2),
        new JdeField("JEW2TI", "JEW2TI", JdeDataType.String, 2),
        new JdeField("JETAXX", "JETAXX", JdeDataType.String, 40),
        new JdeField("JETIS", "JETIS", JdeDataType.String, 2),
        new JdeField("JESSDL", "JESSDL", JdeDataType.Numeric),
        new JdeField("JEMDDL", "JEMDDL", JdeDataType.Numeric),
        new JdeField("JEPRID", "JEPRID", JdeDataType.Numeric, null, true, true),
        new JdeField("JET1DL", "JET1DL", JdeDataType.Numeric),
        new JdeField("JET2DL", "JET2DL", JdeDataType.Numeric),
        new JdeField("JETAPD", "JETAPD", JdeDataType.Numeric),
        new JdeField("JEMMFI", "JEMMFI", JdeDataType.String, 20),
        new JdeField("JEDEVN", "JEDEVN", JdeDataType.String, 20),
        new JdeField("JEW2LC", "JEW2LC", JdeDataType.Numeric),
        new JdeField("JEW2NF", "JEW2NF", JdeDataType.String, 2),
        new JdeField("JEW2PS", "JEW2PS", JdeDataType.String, 2),
        new JdeField("JEW2FI", "JEW2FI", JdeDataType.String, 2),
        new JdeField("JEW2AW", "JEW2AW", JdeDataType.String, 2),
        new JdeField("JEW22S", "JEW22S", JdeDataType.String, 2),
        new JdeField("JEW2AC", "JEW2AC", JdeDataType.String, 2),
        new JdeField("JEWBST", "JEWBST", JdeDataType.String, 2),
        new JdeField("JERAST", "JERAST", JdeDataType.String, 2),
        new JdeField("JEFPST", "JEFPST", JdeDataType.String, 2),
        new JdeField("JEMMST", "JEMMST", JdeDataType.String, 2),
        new JdeField("JECWST", "JECWST", JdeDataType.String, 2),
        new JdeField("JECCST", "JECCST", JdeDataType.String, 2),
        new JdeField("JEST17", "JEST17", JdeDataType.String, 2),
        new JdeField("JEW2S", "JEW2S", JdeDataType.String, 2),
        new JdeField("JEW2CS", "JEW2CS", JdeDataType.String, 2),
        new JdeField("JEW3S", "JEW3S", JdeDataType.String, 2),
        new JdeField("JEW3CS", "JEW3CS", JdeDataType.String, 2),
        new JdeField("JER2S", "JER2S", JdeDataType.String, 2),
        new JdeField("JER2CS", "JER2CS", JdeDataType.String, 2),
        new JdeField("JER3S", "JER3S", JdeDataType.String, 2),
        new JdeField("JER3CS", "JER3CS", JdeDataType.String, 2),
        new JdeField("JEM99S", "JEM99S", JdeDataType.String, 2),
        new JdeField("JER99S", "JER99S", JdeDataType.String, 2),
        new JdeField("JES96S", "JES96S", JdeDataType.String, 2),
        new JdeField("JESEQC", "JESEQC", JdeDataType.String, 2),
        new JdeField("JEPA8", "JEPA8", JdeDataType.Numeric),
        new JdeField("JEAN8T", "JEAN8T", JdeDataType.Numeric),
        new JdeField("JEAN8N", "JEAN8N", JdeDataType.Numeric),
        new JdeField("JEWAN8", "JEWAN8", JdeDataType.Numeric),
        new JdeField("JEAN8D", "JEAN8D", JdeDataType.Numeric),
        new JdeField("JEW2P1", "JEW2P1", JdeDataType.Numeric),
        new JdeField("JEW2P2", "JEW2P2", JdeDataType.Numeric),
        new JdeField("JEW2P3", "JEW2P3", JdeDataType.Numeric),
        new JdeField("JEW2P4", "JEW2P4", JdeDataType.Numeric),
        new JdeField("JEW2P5", "JEW2P5", JdeDataType.Numeric),
        new JdeField("JEW2P6", "JEW2P6", JdeDataType.Numeric),
        new JdeField("JEW2P7", "JEW2P7", JdeDataType.Numeric),
        new JdeField("JEW2P8", "JEW2P8", JdeDataType.Numeric),
        new JdeField("JEW2P9", "JEW2P9", JdeDataType.Numeric),
        new JdeField("JEW2P0", "JEW2P0", JdeDataType.Numeric),
        new JdeField("JEW201", "JEW201", JdeDataType.String, 6),
        new JdeField("JEW202", "JEW202", JdeDataType.String, 6),
        new JdeField("JEW203", "JEW203", JdeDataType.String, 6),
        new JdeField("JEW204", "JEW204", JdeDataType.String, 6),
        new JdeField("JEW205", "JEW205", JdeDataType.String, 6),
        new JdeField("JEW206", "JEW206", JdeDataType.String, 6),
        new JdeField("JEW207", "JEW207", JdeDataType.String, 6),
        new JdeField("JEW208", "JEW208", JdeDataType.String, 6),
        new JdeField("JEW209", "JEW209", JdeDataType.String, 6),
        new JdeField("JEW210", "JEW210", JdeDataType.String, 6),
        new JdeField("JEW211", "JEW211", JdeDataType.String, 6),
        new JdeField("JEW212", "JEW212", JdeDataType.String, 6),
        new JdeField("JEW213", "JEW213", JdeDataType.String, 6),
        new JdeField("JEW214", "JEW214", JdeDataType.String, 6),
        new JdeField("JEW215", "JEW215", JdeDataType.String, 6),
        new JdeField("JEW216", "JEW216", JdeDataType.String, 6),
        new JdeField("JEW217", "JEW217", JdeDataType.String, 6),
        new JdeField("JEW218", "JEW218", JdeDataType.String, 6),
        new JdeField("JEW219", "JEW219", JdeDataType.String, 6),
        new JdeField("JEW220", "JEW220", JdeDataType.String, 6),
        new JdeField("JEW221", "JEW221", JdeDataType.String, 6),
        new JdeField("JEW222", "JEW222", JdeDataType.String, 6),
        new JdeField("JEW223", "JEW223", JdeDataType.String, 6),
        new JdeField("JEW224", "JEW224", JdeDataType.String, 6),
        new JdeField("JEW225", "JEW225", JdeDataType.String, 6),
        new JdeField("JEW226", "JEW226", JdeDataType.String, 6),
        new JdeField("JEW227", "JEW227", JdeDataType.String, 6),
        new JdeField("JEW228", "JEW228", JdeDataType.String, 6),
        new JdeField("JEW229", "JEW229", JdeDataType.String, 6),
        new JdeField("JEW230", "JEW230", JdeDataType.String, 6),
        new JdeField("JEW231", "JEW231", JdeDataType.String, 6),
        new JdeField("JEW232", "JEW232", JdeDataType.String, 6),
        new JdeField("JEW233", "JEW233", JdeDataType.String, 6),
        new JdeField("JEW234", "JEW234", JdeDataType.String, 6),
        new JdeField("JEW235", "JEW235", JdeDataType.String, 6),
        new JdeField("JEW236", "JEW236", JdeDataType.String, 6),
        new JdeField("JEW237", "JEW237", JdeDataType.String, 6),
        new JdeField("JEW238", "JEW238", JdeDataType.String, 6),
        new JdeField("JEW239", "JEW239", JdeDataType.String, 6),
        new JdeField("JEW240", "JEW240", JdeDataType.String, 6),
        new JdeField("JEW241", "JEW241", JdeDataType.String, 6),
        new JdeField("JEW242", "JEW242", JdeDataType.String, 6),
        new JdeField("JEW243", "JEW243", JdeDataType.String, 6),
        new JdeField("JEW244", "JEW244", JdeDataType.String, 6),
        new JdeField("JEW245", "JEW245", JdeDataType.String, 6),
        new JdeField("JEW246", "JEW246", JdeDataType.String, 6),
        new JdeField("JEW247", "JEW247", JdeDataType.String, 6),
        new JdeField("JEW248", "JEW248", JdeDataType.String, 6),
        new JdeField("JEW249", "JEW249", JdeDataType.String, 6),
        new JdeField("JEW250", "JEW250", JdeDataType.String, 6),
        new JdeField("JEW251", "JEW251", JdeDataType.String, 6),
        new JdeField("JEW252", "JEW252", JdeDataType.String, 6),
        new JdeField("JEW253", "JEW253", JdeDataType.String, 6),
        new JdeField("JEW254", "JEW254", JdeDataType.String, 6),
        new JdeField("JEW255", "JEW255", JdeDataType.String, 6),
        new JdeField("JEW256", "JEW256", JdeDataType.String, 6),
        new JdeField("JEW257", "JEW257", JdeDataType.String, 6),
        new JdeField("JEW258", "JEW258", JdeDataType.String, 6),
        new JdeField("JEW259", "JEW259", JdeDataType.String, 6),
        new JdeField("JEW260", "JEW260", JdeDataType.String, 6),
        new JdeField("JEHC01", "JEHC01", JdeDataType.String, 10),
        new JdeField("JEHC02", "JEHC02", JdeDataType.String, 10),
        new JdeField("JEHC03", "JEHC03", JdeDataType.String, 10),
        new JdeField("JEHC04", "JEHC04", JdeDataType.String, 10),
        new JdeField("JEHC05", "JEHC05", JdeDataType.String, 10),
        new JdeField("JEHC06", "JEHC06", JdeDataType.String, 10),
        new JdeField("JEHC07", "JEHC07", JdeDataType.String, 10),
        new JdeField("JEHC08", "JEHC08", JdeDataType.String, 10),
        new JdeField("JEHC09", "JEHC09", JdeDataType.String, 10),
        new JdeField("JEHC10", "JEHC10", JdeDataType.String, 10),
        new JdeField("JEEE01", "JEEE01", JdeDataType.Numeric),
        new JdeField("JEEE02", "JEEE02", JdeDataType.Numeric),
        new JdeField("JEEE03", "JEEE03", JdeDataType.Numeric),
        new JdeField("JEEE04", "JEEE04", JdeDataType.Numeric),
        new JdeField("JEEE05", "JEEE05", JdeDataType.Numeric),
        new JdeField("JEEE06", "JEEE06", JdeDataType.Numeric),
        new JdeField("JEEE07", "JEEE07", JdeDataType.Numeric),
        new JdeField("JEEE08", "JEEE08", JdeDataType.Numeric),
        new JdeField("JEEE09", "JEEE09", JdeDataType.Numeric),
        new JdeField("JEEE10", "JEEE10", JdeDataType.Numeric),
        new JdeField("JEEE11", "JEEE11", JdeDataType.Numeric),
        new JdeField("JEEE12", "JEEE12", JdeDataType.Numeric),
        new JdeField("JEEE13", "JEEE13", JdeDataType.Numeric),
        new JdeField("JEEE14", "JEEE14", JdeDataType.Numeric),
        new JdeField("JEEE15", "JEEE15", JdeDataType.Numeric),
        new JdeField("JEEE16", "JEEE16", JdeDataType.Numeric),
        new JdeField("JEEE17", "JEEE17", JdeDataType.Numeric),
        new JdeField("JEEE18", "JEEE18", JdeDataType.Numeric),
        new JdeField("JEEE19", "JEEE19", JdeDataType.Numeric),
        new JdeField("JEEE20", "JEEE20", JdeDataType.Numeric),
        new JdeField("JEEE21", "JEEE21", JdeDataType.Numeric),
        new JdeField("JEEE22", "JEEE22", JdeDataType.Numeric),
        new JdeField("JEEE23", "JEEE23", JdeDataType.Numeric),
        new JdeField("JEEE24", "JEEE24", JdeDataType.Numeric),
        new JdeField("JEEE25", "JEEE25", JdeDataType.Numeric),
        new JdeField("JEEE26", "JEEE26", JdeDataType.Numeric),
        new JdeField("JEEE27", "JEEE27", JdeDataType.Numeric),
        new JdeField("JEEE28", "JEEE28", JdeDataType.Numeric),
        new JdeField("JEEE29", "JEEE29", JdeDataType.Numeric),
        new JdeField("JEEE30", "JEEE30", JdeDataType.Numeric),
        new JdeField("JEEE31", "JEEE31", JdeDataType.Numeric),
        new JdeField("JEEE32", "JEEE32", JdeDataType.Numeric),
        new JdeField("JEEE33", "JEEE33", JdeDataType.Numeric),
        new JdeField("JEEE34", "JEEE34", JdeDataType.Numeric),
        new JdeField("JEEE35", "JEEE35", JdeDataType.Numeric),
        new JdeField("JEEE36", "JEEE36", JdeDataType.Numeric),
        new JdeField("JEEE37", "JEEE37", JdeDataType.Numeric),
        new JdeField("JEEE38", "JEEE38", JdeDataType.Numeric),
        new JdeField("JEEE39", "JEEE39", JdeDataType.Numeric),
        new JdeField("JEEE40", "JEEE40", JdeDataType.Numeric),
        new JdeField("JEEE41", "JEEE41", JdeDataType.Numeric),
        new JdeField("JEEE42", "JEEE42", JdeDataType.Numeric),
        new JdeField("JEEE43", "JEEE43", JdeDataType.Numeric),
        new JdeField("JEEE44", "JEEE44", JdeDataType.Numeric),
        new JdeField("JEEE45", "JEEE45", JdeDataType.Numeric),
        new JdeField("JEEE46", "JEEE46", JdeDataType.Numeric),
        new JdeField("JEEE47", "JEEE47", JdeDataType.Numeric),
        new JdeField("JEEE48", "JEEE48", JdeDataType.Numeric),
        new JdeField("JEEE49", "JEEE49", JdeDataType.Numeric),
        new JdeField("JEEE50", "JEEE50", JdeDataType.Numeric),
        new JdeField("JEOF01", "JEOF01", JdeDataType.String, 2),
        new JdeField("JEOF02", "JEOF02", JdeDataType.String, 2),
        new JdeField("JEOF03", "JEOF03", JdeDataType.String, 2),
        new JdeField("JEOF04", "JEOF04", JdeDataType.String, 2),
        new JdeField("JEOF05", "JEOF05", JdeDataType.String, 2),
        new JdeField("JEOF06", "JEOF06", JdeDataType.String, 2),
        new JdeField("JEOF07", "JEOF07", JdeDataType.String, 2),
        new JdeField("JEOF08", "JEOF08", JdeDataType.String, 2),
        new JdeField("JEOF09", "JEOF09", JdeDataType.String, 2),
        new JdeField("JEOF10", "JEOF10", JdeDataType.String, 2),
        new JdeField("JEOF11", "JEOF11", JdeDataType.String, 2),
        new JdeField("JEOF12", "JEOF12", JdeDataType.String, 2),
        new JdeField("JEOF13", "JEOF13", JdeDataType.String, 2),
        new JdeField("JEOF14", "JEOF14", JdeDataType.String, 2),
        new JdeField("JEOF15", "JEOF15", JdeDataType.String, 2),
        new JdeField("JEOF16", "JEOF16", JdeDataType.String, 2),
        new JdeField("JEOF17", "JEOF17", JdeDataType.String, 2),
        new JdeField("JEOF18", "JEOF18", JdeDataType.String, 2),
        new JdeField("JEOF19", "JEOF19", JdeDataType.String, 2),
        new JdeField("JEOF20", "JEOF20", JdeDataType.String, 2),
        new JdeField("JEW41S", "JEW41S", JdeDataType.String, 2),
        new JdeField("JER241", "JER241", JdeDataType.String, 2),
        new JdeField("JEM941", "JEM941", JdeDataType.String, 2),
        new JdeField("JER941", "JER941", JdeDataType.String, 2),
        new JdeField("JEWS01", "JEWS01", JdeDataType.String, 8),
        new JdeField("JEWS02", "JEWS02", JdeDataType.String, 8),
        new JdeField("JEWS03", "JEWS03", JdeDataType.String, 8),
        new JdeField("JEWS04", "JEWS04", JdeDataType.String, 8),
        new JdeField("JEWS05", "JEWS05", JdeDataType.String, 8),
        new JdeField("JEWS06", "JEWS06", JdeDataType.String, 8),
        new JdeField("JEWS07", "JEWS07", JdeDataType.String, 8),
        new JdeField("JEWS08", "JEWS08", JdeDataType.String, 8),
        new JdeField("JEWS09", "JEWS09", JdeDataType.String, 8),
        new JdeField("JEWS10", "JEWS10", JdeDataType.String, 8),
        new JdeField("JEWS11", "JEWS11", JdeDataType.String, 8),
        new JdeField("JEWS12", "JEWS12", JdeDataType.String, 8),
        new JdeField("JEWS13", "JEWS13", JdeDataType.String, 8),
        new JdeField("JEWS14", "JEWS14", JdeDataType.String, 8),
        new JdeField("JEWS15", "JEWS15", JdeDataType.String, 8),
        new JdeField("JERNUM", "JERNUM", JdeDataType.Numeric),
        new JdeField("JEUSER", "JEUSER", JdeDataType.String, 20),
        new JdeField("JEPID", "JEPID", JdeDataType.String, 20),
        new JdeField("JEUPMJ", "JEUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06720_0", "Primary Key on JEPRID", new[] { "JEPRID" }, isUnique: true, isPrimaryKey: true)
    };
}
