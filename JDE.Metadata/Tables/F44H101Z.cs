using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H101Z - .
/// </summary>
public class F44H101Z : JdeTable
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
        /// SZHBMCUS.
        /// </summary>
        public const string SZHBMCUS = "SZHBMCUS";

        /// <summary>
        /// SZCPHASE.
        /// </summary>
        public const string SZCPHASE = "SZCPHASE";

        /// <summary>
        /// SZPHSENB.
        /// </summary>
        public const string SZPHSENB = "SZPHSENB";

        /// <summary>
        /// SZHBAREA.
        /// </summary>
        public const string SZHBAREA = "SZHBAREA";

        /// <summary>
        /// SZDL01.
        /// </summary>
        public const string SZDL01 = "SZDL01";

        /// <summary>
        /// SZNBRPHS.
        /// </summary>
        public const string SZNBRPHS = "SZNBRPHS";

        /// <summary>
        /// SZPMPT.
        /// </summary>
        public const string SZPMPT = "SZPMPT";

        /// <summary>
        /// SZPMPG.
        /// </summary>
        public const string SZPMPG = "SZPMPG";

        /// <summary>
        /// SZAN8MCUS.
        /// </summary>
        public const string SZAN8MCUS = "SZAN8MCUS";

        /// <summary>
        /// SZAN8SOF.
        /// </summary>
        public const string SZAN8SOF = "SZAN8SOF";

        /// <summary>
        /// SZAN8COF.
        /// </summary>
        public const string SZAN8COF = "SZAN8COF";

        /// <summary>
        /// SZAN8CM01.
        /// </summary>
        public const string SZAN8CM01 = "SZAN8CM01";

        /// <summary>
        /// SZAN8CM02.
        /// </summary>
        public const string SZAN8CM02 = "SZAN8CM02";

        /// <summary>
        /// SZAN8CM03.
        /// </summary>
        public const string SZAN8CM03 = "SZAN8CM03";

        /// <summary>
        /// SZAN8CM04.
        /// </summary>
        public const string SZAN8CM04 = "SZAN8CM04";

        /// <summary>
        /// SZAN8CM05.
        /// </summary>
        public const string SZAN8CM05 = "SZAN8CM05";

        /// <summary>
        /// SZAN8CM06.
        /// </summary>
        public const string SZAN8CM06 = "SZAN8CM06";

        /// <summary>
        /// SZAN8CM07.
        /// </summary>
        public const string SZAN8CM07 = "SZAN8CM07";

        /// <summary>
        /// SZAN8CM08.
        /// </summary>
        public const string SZAN8CM08 = "SZAN8CM08";

        /// <summary>
        /// SZAN8CM09.
        /// </summary>
        public const string SZAN8CM09 = "SZAN8CM09";

        /// <summary>
        /// SZAN8CM10.
        /// </summary>
        public const string SZAN8CM10 = "SZAN8CM10";

        /// <summary>
        /// SZAN8CM11.
        /// </summary>
        public const string SZAN8CM11 = "SZAN8CM11";

        /// <summary>
        /// SZAN8CM12.
        /// </summary>
        public const string SZAN8CM12 = "SZAN8CM12";

        /// <summary>
        /// SZAN8CM13.
        /// </summary>
        public const string SZAN8CM13 = "SZAN8CM13";

        /// <summary>
        /// SZAN8CM14.
        /// </summary>
        public const string SZAN8CM14 = "SZAN8CM14";

        /// <summary>
        /// SZAN8CM15.
        /// </summary>
        public const string SZAN8CM15 = "SZAN8CM15";

        /// <summary>
        /// SZAN8CM16.
        /// </summary>
        public const string SZAN8CM16 = "SZAN8CM16";

        /// <summary>
        /// SZAN8CM17.
        /// </summary>
        public const string SZAN8CM17 = "SZAN8CM17";

        /// <summary>
        /// SZAN8CM18.
        /// </summary>
        public const string SZAN8CM18 = "SZAN8CM18";

        /// <summary>
        /// SZAN8CM19.
        /// </summary>
        public const string SZAN8CM19 = "SZAN8CM19";

        /// <summary>
        /// SZAN8CM20.
        /// </summary>
        public const string SZAN8CM20 = "SZAN8CM20";

        /// <summary>
        /// SZAN8UR01.
        /// </summary>
        public const string SZAN8UR01 = "SZAN8UR01";

        /// <summary>
        /// SZAN8UR02.
        /// </summary>
        public const string SZAN8UR02 = "SZAN8UR02";

        /// <summary>
        /// SZAN8UR03.
        /// </summary>
        public const string SZAN8UR03 = "SZAN8UR03";

        /// <summary>
        /// SZAN8UR04.
        /// </summary>
        public const string SZAN8UR04 = "SZAN8UR04";

        /// <summary>
        /// SZAN8UR05.
        /// </summary>
        public const string SZAN8UR05 = "SZAN8UR05";

        /// <summary>
        /// SZCONSSEQ.
        /// </summary>
        public const string SZCONSSEQ = "SZCONSSEQ";

        /// <summary>
        /// SZNBRLOT.
        /// </summary>
        public const string SZNBRLOT = "SZNBRLOT";

        /// <summary>
        /// SZNBRSLD.
        /// </summary>
        public const string SZNBRSLD = "SZNBRSLD";

        /// <summary>
        /// SZNBRCLSD.
        /// </summary>
        public const string SZNBRCLSD = "SZNBRCLSD";

        /// <summary>
        /// SZNBRSTRD.
        /// </summary>
        public const string SZNBRSTRD = "SZNBRSTRD";

        /// <summary>
        /// SZNBRFIN.
        /// </summary>
        public const string SZNBRFIN = "SZNBRFIN";

        /// <summary>
        /// SZAOCST01.
        /// </summary>
        public const string SZAOCST01 = "SZAOCST01";

        /// <summary>
        /// SZAOCST02.
        /// </summary>
        public const string SZAOCST02 = "SZAOCST02";

        /// <summary>
        /// SZAOCST03.
        /// </summary>
        public const string SZAOCST03 = "SZAOCST03";

        /// <summary>
        /// SZAOCST04.
        /// </summary>
        public const string SZAOCST04 = "SZAOCST04";

        /// <summary>
        /// SZAOCST05.
        /// </summary>
        public const string SZAOCST05 = "SZAOCST05";

        /// <summary>
        /// SZAOREV01.
        /// </summary>
        public const string SZAOREV01 = "SZAOREV01";

        /// <summary>
        /// SZAOREV02.
        /// </summary>
        public const string SZAOREV02 = "SZAOREV02";

        /// <summary>
        /// SZAOREV03.
        /// </summary>
        public const string SZAOREV03 = "SZAOREV03";

        /// <summary>
        /// SZAOREV04.
        /// </summary>
        public const string SZAOREV04 = "SZAOREV04";

        /// <summary>
        /// SZAOREV05.
        /// </summary>
        public const string SZAOREV05 = "SZAOREV05";

        /// <summary>
        /// SZCSTPCT01.
        /// </summary>
        public const string SZCSTPCT01 = "SZCSTPCT01";

        /// <summary>
        /// SZCSTPCT02.
        /// </summary>
        public const string SZCSTPCT02 = "SZCSTPCT02";

        /// <summary>
        /// SZCSTPCT03.
        /// </summary>
        public const string SZCSTPCT03 = "SZCSTPCT03";

        /// <summary>
        /// SZCSTPCT04.
        /// </summary>
        public const string SZCSTPCT04 = "SZCSTPCT04";

        /// <summary>
        /// SZCSTPCT05.
        /// </summary>
        public const string SZCSTPCT05 = "SZCSTPCT05";

        /// <summary>
        /// SZCSTPCT06.
        /// </summary>
        public const string SZCSTPCT06 = "SZCSTPCT06";

        /// <summary>
        /// SZCSTPCT07.
        /// </summary>
        public const string SZCSTPCT07 = "SZCSTPCT07";

        /// <summary>
        /// SZCSTPCT08.
        /// </summary>
        public const string SZCSTPCT08 = "SZCSTPCT08";

        /// <summary>
        /// SZCSTPCT09.
        /// </summary>
        public const string SZCSTPCT09 = "SZCSTPCT09";

        /// <summary>
        /// SZCSTPCT10.
        /// </summary>
        public const string SZCSTPCT10 = "SZCSTPCT10";

        /// <summary>
        /// SZHBRLTPC.
        /// </summary>
        public const string SZHBRLTPC = "SZHBRLTPC";

        /// <summary>
        /// SZHBRLTPS.
        /// </summary>
        public const string SZHBRLTPS = "SZHBRLTPS";

        /// <summary>
        /// SZINCMCU.
        /// </summary>
        public const string SZINCMCU = "SZINCMCU";

        /// <summary>
        /// SZWAMCU.
        /// </summary>
        public const string SZWAMCU = "SZWAMCU";

        /// <summary>
        /// SZCWTMPT.
        /// </summary>
        public const string SZCWTMPT = "SZCWTMPT";

        /// <summary>
        /// SZUAMT01.
        /// </summary>
        public const string SZUAMT01 = "SZUAMT01";

        /// <summary>
        /// SZUAMT02.
        /// </summary>
        public const string SZUAMT02 = "SZUAMT02";

        /// <summary>
        /// SZUAMT03.
        /// </summary>
        public const string SZUAMT03 = "SZUAMT03";

        /// <summary>
        /// SZUAMT04.
        /// </summary>
        public const string SZUAMT04 = "SZUAMT04";

        /// <summary>
        /// SZUAMT05.
        /// </summary>
        public const string SZUAMT05 = "SZUAMT05";

        /// <summary>
        /// SZUAMT06.
        /// </summary>
        public const string SZUAMT06 = "SZUAMT06";

        /// <summary>
        /// SZUAMT07.
        /// </summary>
        public const string SZUAMT07 = "SZUAMT07";

        /// <summary>
        /// SZUAMT08.
        /// </summary>
        public const string SZUAMT08 = "SZUAMT08";

        /// <summary>
        /// SZUAMT09.
        /// </summary>
        public const string SZUAMT09 = "SZUAMT09";

        /// <summary>
        /// SZUAMT10.
        /// </summary>
        public const string SZUAMT10 = "SZUAMT10";

        /// <summary>
        /// SZF1A.
        /// </summary>
        public const string SZF1A = "SZF1A";

        /// <summary>
        /// SZF2A.
        /// </summary>
        public const string SZF2A = "SZF2A";

        /// <summary>
        /// SZF3A.
        /// </summary>
        public const string SZF3A = "SZF3A";

        /// <summary>
        /// SZF4A.
        /// </summary>
        public const string SZF4A = "SZF4A";

        /// <summary>
        /// SZF5A.
        /// </summary>
        public const string SZF5A = "SZF5A";

        /// <summary>
        /// SZUSD1.
        /// </summary>
        public const string SZUSD1 = "SZUSD1";

        /// <summary>
        /// SZUSD2.
        /// </summary>
        public const string SZUSD2 = "SZUSD2";

        /// <summary>
        /// SZUSD3.
        /// </summary>
        public const string SZUSD3 = "SZUSD3";

        /// <summary>
        /// SZUSD4.
        /// </summary>
        public const string SZUSD4 = "SZUSD4";

        /// <summary>
        /// SZUSD5.
        /// </summary>
        public const string SZUSD5 = "SZUSD5";

        /// <summary>
        /// SZUSD6.
        /// </summary>
        public const string SZUSD6 = "SZUSD6";

        /// <summary>
        /// SZUSD7.
        /// </summary>
        public const string SZUSD7 = "SZUSD7";

        /// <summary>
        /// SZUSD8.
        /// </summary>
        public const string SZUSD8 = "SZUSD8";

        /// <summary>
        /// SZUSD9.
        /// </summary>
        public const string SZUSD9 = "SZUSD9";

        /// <summary>
        /// SZUSD10.
        /// </summary>
        public const string SZUSD10 = "SZUSD10";

        /// <summary>
        /// SZCRTU.
        /// </summary>
        public const string SZCRTU = "SZCRTU";

        /// <summary>
        /// SZCRTJ.
        /// </summary>
        public const string SZCRTJ = "SZCRTJ";

        /// <summary>
        /// SZCRTT.
        /// </summary>
        public const string SZCRTT = "SZCRTT";

        /// <summary>
        /// SZWRKSTNID.
        /// </summary>
        public const string SZWRKSTNID = "SZWRKSTNID";

        /// <summary>
        /// SZHBOPID.
        /// </summary>
        public const string SZHBOPID = "SZHBOPID";

        /// <summary>
        /// SZUPMB.
        /// </summary>
        public const string SZUPMB = "SZUPMB";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZUPMT.
        /// </summary>
        public const string SZUPMT = "SZUPMT";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZSCHENB.
        /// </summary>
        public const string SZSCHENB = "SZSCHENB";

        /// <summary>
        /// SZHBST1.
        /// </summary>
        public const string SZHBST1 = "SZHBST1";

        /// <summary>
        /// SZHBST2.
        /// </summary>
        public const string SZHBST2 = "SZHBST2";

        /// <summary>
        /// SZHBST3.
        /// </summary>
        public const string SZHBST3 = "SZHBST3";

        /// <summary>
        /// SZHBST4.
        /// </summary>
        public const string SZHBST4 = "SZHBST4";

        /// <summary>
        /// SZHBST5.
        /// </summary>
        public const string SZHBST5 = "SZHBST5";
    }

    /// <inheritdoc />
    public override string TableName => "F44H101Z";

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
        new JdeField("SZHBMCUS", "SZHBMCUS", JdeDataType.String, 24),
        new JdeField("SZCPHASE", "SZCPHASE", JdeDataType.String, 6),
        new JdeField("SZPHSENB", "SZPHSENB", JdeDataType.String, 2),
        new JdeField("SZHBAREA", "SZHBAREA", JdeDataType.String, 6),
        new JdeField("SZDL01", "SZDL01", JdeDataType.String, 60),
        new JdeField("SZNBRPHS", "SZNBRPHS", JdeDataType.Numeric),
        new JdeField("SZPMPT", "SZPMPT", JdeDataType.String, 6),
        new JdeField("SZPMPG", "SZPMPG", JdeDataType.String, 6),
        new JdeField("SZAN8MCUS", "SZAN8MCUS", JdeDataType.Numeric),
        new JdeField("SZAN8SOF", "SZAN8SOF", JdeDataType.Numeric),
        new JdeField("SZAN8COF", "SZAN8COF", JdeDataType.Numeric),
        new JdeField("SZAN8CM01", "SZAN8CM01", JdeDataType.Numeric),
        new JdeField("SZAN8CM02", "SZAN8CM02", JdeDataType.Numeric),
        new JdeField("SZAN8CM03", "SZAN8CM03", JdeDataType.Numeric),
        new JdeField("SZAN8CM04", "SZAN8CM04", JdeDataType.Numeric),
        new JdeField("SZAN8CM05", "SZAN8CM05", JdeDataType.Numeric),
        new JdeField("SZAN8CM06", "SZAN8CM06", JdeDataType.Numeric),
        new JdeField("SZAN8CM07", "SZAN8CM07", JdeDataType.Numeric),
        new JdeField("SZAN8CM08", "SZAN8CM08", JdeDataType.Numeric),
        new JdeField("SZAN8CM09", "SZAN8CM09", JdeDataType.Numeric),
        new JdeField("SZAN8CM10", "SZAN8CM10", JdeDataType.Numeric),
        new JdeField("SZAN8CM11", "SZAN8CM11", JdeDataType.Numeric),
        new JdeField("SZAN8CM12", "SZAN8CM12", JdeDataType.Numeric),
        new JdeField("SZAN8CM13", "SZAN8CM13", JdeDataType.Numeric),
        new JdeField("SZAN8CM14", "SZAN8CM14", JdeDataType.Numeric),
        new JdeField("SZAN8CM15", "SZAN8CM15", JdeDataType.Numeric),
        new JdeField("SZAN8CM16", "SZAN8CM16", JdeDataType.Numeric),
        new JdeField("SZAN8CM17", "SZAN8CM17", JdeDataType.Numeric),
        new JdeField("SZAN8CM18", "SZAN8CM18", JdeDataType.Numeric),
        new JdeField("SZAN8CM19", "SZAN8CM19", JdeDataType.Numeric),
        new JdeField("SZAN8CM20", "SZAN8CM20", JdeDataType.Numeric),
        new JdeField("SZAN8UR01", "SZAN8UR01", JdeDataType.Numeric),
        new JdeField("SZAN8UR02", "SZAN8UR02", JdeDataType.Numeric),
        new JdeField("SZAN8UR03", "SZAN8UR03", JdeDataType.Numeric),
        new JdeField("SZAN8UR04", "SZAN8UR04", JdeDataType.Numeric),
        new JdeField("SZAN8UR05", "SZAN8UR05", JdeDataType.Numeric),
        new JdeField("SZCONSSEQ", "SZCONSSEQ", JdeDataType.String, 6),
        new JdeField("SZNBRLOT", "SZNBRLOT", JdeDataType.Numeric),
        new JdeField("SZNBRSLD", "SZNBRSLD", JdeDataType.Numeric),
        new JdeField("SZNBRCLSD", "SZNBRCLSD", JdeDataType.Numeric),
        new JdeField("SZNBRSTRD", "SZNBRSTRD", JdeDataType.Numeric),
        new JdeField("SZNBRFIN", "SZNBRFIN", JdeDataType.Numeric),
        new JdeField("SZAOCST01", "SZAOCST01", JdeDataType.Numeric),
        new JdeField("SZAOCST02", "SZAOCST02", JdeDataType.Numeric),
        new JdeField("SZAOCST03", "SZAOCST03", JdeDataType.Numeric),
        new JdeField("SZAOCST04", "SZAOCST04", JdeDataType.Numeric),
        new JdeField("SZAOCST05", "SZAOCST05", JdeDataType.Numeric),
        new JdeField("SZAOREV01", "SZAOREV01", JdeDataType.Numeric),
        new JdeField("SZAOREV02", "SZAOREV02", JdeDataType.Numeric),
        new JdeField("SZAOREV03", "SZAOREV03", JdeDataType.Numeric),
        new JdeField("SZAOREV04", "SZAOREV04", JdeDataType.Numeric),
        new JdeField("SZAOREV05", "SZAOREV05", JdeDataType.Numeric),
        new JdeField("SZCSTPCT01", "SZCSTPCT01", JdeDataType.Numeric),
        new JdeField("SZCSTPCT02", "SZCSTPCT02", JdeDataType.Numeric),
        new JdeField("SZCSTPCT03", "SZCSTPCT03", JdeDataType.Numeric),
        new JdeField("SZCSTPCT04", "SZCSTPCT04", JdeDataType.Numeric),
        new JdeField("SZCSTPCT05", "SZCSTPCT05", JdeDataType.Numeric),
        new JdeField("SZCSTPCT06", "SZCSTPCT06", JdeDataType.Numeric),
        new JdeField("SZCSTPCT07", "SZCSTPCT07", JdeDataType.Numeric),
        new JdeField("SZCSTPCT08", "SZCSTPCT08", JdeDataType.Numeric),
        new JdeField("SZCSTPCT09", "SZCSTPCT09", JdeDataType.Numeric),
        new JdeField("SZCSTPCT10", "SZCSTPCT10", JdeDataType.Numeric),
        new JdeField("SZHBRLTPC", "SZHBRLTPC", JdeDataType.String, 6),
        new JdeField("SZHBRLTPS", "SZHBRLTPS", JdeDataType.String, 6),
        new JdeField("SZINCMCU", "SZINCMCU", JdeDataType.String, 24),
        new JdeField("SZWAMCU", "SZWAMCU", JdeDataType.String, 24),
        new JdeField("SZCWTMPT", "SZCWTMPT", JdeDataType.String, 24),
        new JdeField("SZUAMT01", "SZUAMT01", JdeDataType.Numeric),
        new JdeField("SZUAMT02", "SZUAMT02", JdeDataType.Numeric),
        new JdeField("SZUAMT03", "SZUAMT03", JdeDataType.Numeric),
        new JdeField("SZUAMT04", "SZUAMT04", JdeDataType.Numeric),
        new JdeField("SZUAMT05", "SZUAMT05", JdeDataType.Numeric),
        new JdeField("SZUAMT06", "SZUAMT06", JdeDataType.Numeric),
        new JdeField("SZUAMT07", "SZUAMT07", JdeDataType.Numeric),
        new JdeField("SZUAMT08", "SZUAMT08", JdeDataType.Numeric),
        new JdeField("SZUAMT09", "SZUAMT09", JdeDataType.Numeric),
        new JdeField("SZUAMT10", "SZUAMT10", JdeDataType.Numeric),
        new JdeField("SZF1A", "SZF1A", JdeDataType.Numeric),
        new JdeField("SZF2A", "SZF2A", JdeDataType.Numeric),
        new JdeField("SZF3A", "SZF3A", JdeDataType.Numeric),
        new JdeField("SZF4A", "SZF4A", JdeDataType.Numeric),
        new JdeField("SZF5A", "SZF5A", JdeDataType.Numeric),
        new JdeField("SZUSD1", "SZUSD1", JdeDataType.Numeric),
        new JdeField("SZUSD2", "SZUSD2", JdeDataType.Numeric),
        new JdeField("SZUSD3", "SZUSD3", JdeDataType.Numeric),
        new JdeField("SZUSD4", "SZUSD4", JdeDataType.Numeric),
        new JdeField("SZUSD5", "SZUSD5", JdeDataType.Numeric),
        new JdeField("SZUSD6", "SZUSD6", JdeDataType.Numeric),
        new JdeField("SZUSD7", "SZUSD7", JdeDataType.Numeric),
        new JdeField("SZUSD8", "SZUSD8", JdeDataType.Numeric),
        new JdeField("SZUSD9", "SZUSD9", JdeDataType.Numeric),
        new JdeField("SZUSD10", "SZUSD10", JdeDataType.Numeric),
        new JdeField("SZCRTU", "SZCRTU", JdeDataType.String, 20),
        new JdeField("SZCRTJ", "SZCRTJ", JdeDataType.Numeric),
        new JdeField("SZCRTT", "SZCRTT", JdeDataType.Numeric),
        new JdeField("SZWRKSTNID", "SZWRKSTNID", JdeDataType.String, 20),
        new JdeField("SZHBOPID", "SZHBOPID", JdeDataType.String, 20),
        new JdeField("SZUPMB", "SZUPMB", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZSCHENB", "SZSCHENB", JdeDataType.String, 2),
        new JdeField("SZHBST1", "SZHBST1", JdeDataType.String, 2),
        new JdeField("SZHBST2", "SZHBST2", JdeDataType.String, 2),
        new JdeField("SZHBST3", "SZHBST3", JdeDataType.String, 2),
        new JdeField("SZHBST4", "SZHBST4", JdeDataType.String, 2),
        new JdeField("SZHBST5", "SZHBST5", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H101Z_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H101Z_2", "Index on SZHBMCUS, SZCPHASE", new[] { "SZHBMCUS", "SZCPHASE" })
    };
}
