using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H101 - .
/// </summary>
public class F44H101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMHBMCUS.
        /// </summary>
        public const string CMHBMCUS = "CMHBMCUS";

        /// <summary>
        /// CMCPHASE.
        /// </summary>
        public const string CMCPHASE = "CMCPHASE";

        /// <summary>
        /// CMPHSENB.
        /// </summary>
        public const string CMPHSENB = "CMPHSENB";

        /// <summary>
        /// CMHBAREA.
        /// </summary>
        public const string CMHBAREA = "CMHBAREA";

        /// <summary>
        /// CMDL01.
        /// </summary>
        public const string CMDL01 = "CMDL01";

        /// <summary>
        /// CMNBRPHS.
        /// </summary>
        public const string CMNBRPHS = "CMNBRPHS";

        /// <summary>
        /// CMPMPT.
        /// </summary>
        public const string CMPMPT = "CMPMPT";

        /// <summary>
        /// CMPMPG.
        /// </summary>
        public const string CMPMPG = "CMPMPG";

        /// <summary>
        /// CMAN8MCUS.
        /// </summary>
        public const string CMAN8MCUS = "CMAN8MCUS";

        /// <summary>
        /// CMAN8SOF.
        /// </summary>
        public const string CMAN8SOF = "CMAN8SOF";

        /// <summary>
        /// CMAN8COF.
        /// </summary>
        public const string CMAN8COF = "CMAN8COF";

        /// <summary>
        /// CMAN8CM01.
        /// </summary>
        public const string CMAN8CM01 = "CMAN8CM01";

        /// <summary>
        /// CMAN8CM02.
        /// </summary>
        public const string CMAN8CM02 = "CMAN8CM02";

        /// <summary>
        /// CMAN8CM03.
        /// </summary>
        public const string CMAN8CM03 = "CMAN8CM03";

        /// <summary>
        /// CMAN8CM04.
        /// </summary>
        public const string CMAN8CM04 = "CMAN8CM04";

        /// <summary>
        /// CMAN8CM05.
        /// </summary>
        public const string CMAN8CM05 = "CMAN8CM05";

        /// <summary>
        /// CMAN8CM06.
        /// </summary>
        public const string CMAN8CM06 = "CMAN8CM06";

        /// <summary>
        /// CMAN8CM07.
        /// </summary>
        public const string CMAN8CM07 = "CMAN8CM07";

        /// <summary>
        /// CMAN8CM08.
        /// </summary>
        public const string CMAN8CM08 = "CMAN8CM08";

        /// <summary>
        /// CMAN8CM09.
        /// </summary>
        public const string CMAN8CM09 = "CMAN8CM09";

        /// <summary>
        /// CMAN8CM10.
        /// </summary>
        public const string CMAN8CM10 = "CMAN8CM10";

        /// <summary>
        /// CMAN8CM11.
        /// </summary>
        public const string CMAN8CM11 = "CMAN8CM11";

        /// <summary>
        /// CMAN8CM12.
        /// </summary>
        public const string CMAN8CM12 = "CMAN8CM12";

        /// <summary>
        /// CMAN8CM13.
        /// </summary>
        public const string CMAN8CM13 = "CMAN8CM13";

        /// <summary>
        /// CMAN8CM14.
        /// </summary>
        public const string CMAN8CM14 = "CMAN8CM14";

        /// <summary>
        /// CMAN8CM15.
        /// </summary>
        public const string CMAN8CM15 = "CMAN8CM15";

        /// <summary>
        /// CMAN8CM16.
        /// </summary>
        public const string CMAN8CM16 = "CMAN8CM16";

        /// <summary>
        /// CMAN8CM17.
        /// </summary>
        public const string CMAN8CM17 = "CMAN8CM17";

        /// <summary>
        /// CMAN8CM18.
        /// </summary>
        public const string CMAN8CM18 = "CMAN8CM18";

        /// <summary>
        /// CMAN8CM19.
        /// </summary>
        public const string CMAN8CM19 = "CMAN8CM19";

        /// <summary>
        /// CMAN8CM20.
        /// </summary>
        public const string CMAN8CM20 = "CMAN8CM20";

        /// <summary>
        /// CMAN8UR01.
        /// </summary>
        public const string CMAN8UR01 = "CMAN8UR01";

        /// <summary>
        /// CMAN8UR02.
        /// </summary>
        public const string CMAN8UR02 = "CMAN8UR02";

        /// <summary>
        /// CMAN8UR03.
        /// </summary>
        public const string CMAN8UR03 = "CMAN8UR03";

        /// <summary>
        /// CMAN8UR04.
        /// </summary>
        public const string CMAN8UR04 = "CMAN8UR04";

        /// <summary>
        /// CMAN8UR05.
        /// </summary>
        public const string CMAN8UR05 = "CMAN8UR05";

        /// <summary>
        /// CMCONSSEQ.
        /// </summary>
        public const string CMCONSSEQ = "CMCONSSEQ";

        /// <summary>
        /// CMNBRLOT.
        /// </summary>
        public const string CMNBRLOT = "CMNBRLOT";

        /// <summary>
        /// CMNBRSLD.
        /// </summary>
        public const string CMNBRSLD = "CMNBRSLD";

        /// <summary>
        /// CMNBRCLSD.
        /// </summary>
        public const string CMNBRCLSD = "CMNBRCLSD";

        /// <summary>
        /// CMNBRSTRD.
        /// </summary>
        public const string CMNBRSTRD = "CMNBRSTRD";

        /// <summary>
        /// CMNBRFIN.
        /// </summary>
        public const string CMNBRFIN = "CMNBRFIN";

        /// <summary>
        /// CMAOCST01.
        /// </summary>
        public const string CMAOCST01 = "CMAOCST01";

        /// <summary>
        /// CMAOCST02.
        /// </summary>
        public const string CMAOCST02 = "CMAOCST02";

        /// <summary>
        /// CMAOCST03.
        /// </summary>
        public const string CMAOCST03 = "CMAOCST03";

        /// <summary>
        /// CMAOCST04.
        /// </summary>
        public const string CMAOCST04 = "CMAOCST04";

        /// <summary>
        /// CMAOCST05.
        /// </summary>
        public const string CMAOCST05 = "CMAOCST05";

        /// <summary>
        /// CMAOREV01.
        /// </summary>
        public const string CMAOREV01 = "CMAOREV01";

        /// <summary>
        /// CMAOREV02.
        /// </summary>
        public const string CMAOREV02 = "CMAOREV02";

        /// <summary>
        /// CMAOREV03.
        /// </summary>
        public const string CMAOREV03 = "CMAOREV03";

        /// <summary>
        /// CMAOREV04.
        /// </summary>
        public const string CMAOREV04 = "CMAOREV04";

        /// <summary>
        /// CMAOREV05.
        /// </summary>
        public const string CMAOREV05 = "CMAOREV05";

        /// <summary>
        /// CMCSTPCT01.
        /// </summary>
        public const string CMCSTPCT01 = "CMCSTPCT01";

        /// <summary>
        /// CMCSTPCT02.
        /// </summary>
        public const string CMCSTPCT02 = "CMCSTPCT02";

        /// <summary>
        /// CMCSTPCT03.
        /// </summary>
        public const string CMCSTPCT03 = "CMCSTPCT03";

        /// <summary>
        /// CMCSTPCT04.
        /// </summary>
        public const string CMCSTPCT04 = "CMCSTPCT04";

        /// <summary>
        /// CMCSTPCT05.
        /// </summary>
        public const string CMCSTPCT05 = "CMCSTPCT05";

        /// <summary>
        /// CMCSTPCT06.
        /// </summary>
        public const string CMCSTPCT06 = "CMCSTPCT06";

        /// <summary>
        /// CMCSTPCT07.
        /// </summary>
        public const string CMCSTPCT07 = "CMCSTPCT07";

        /// <summary>
        /// CMCSTPCT08.
        /// </summary>
        public const string CMCSTPCT08 = "CMCSTPCT08";

        /// <summary>
        /// CMCSTPCT09.
        /// </summary>
        public const string CMCSTPCT09 = "CMCSTPCT09";

        /// <summary>
        /// CMCSTPCT10.
        /// </summary>
        public const string CMCSTPCT10 = "CMCSTPCT10";

        /// <summary>
        /// CMHBRLTPC.
        /// </summary>
        public const string CMHBRLTPC = "CMHBRLTPC";

        /// <summary>
        /// CMHBRLTPS.
        /// </summary>
        public const string CMHBRLTPS = "CMHBRLTPS";

        /// <summary>
        /// CMINCMCU.
        /// </summary>
        public const string CMINCMCU = "CMINCMCU";

        /// <summary>
        /// CMWAMCU.
        /// </summary>
        public const string CMWAMCU = "CMWAMCU";

        /// <summary>
        /// CMCWTMPT.
        /// </summary>
        public const string CMCWTMPT = "CMCWTMPT";

        /// <summary>
        /// CMUAMT01.
        /// </summary>
        public const string CMUAMT01 = "CMUAMT01";

        /// <summary>
        /// CMUAMT02.
        /// </summary>
        public const string CMUAMT02 = "CMUAMT02";

        /// <summary>
        /// CMUAMT03.
        /// </summary>
        public const string CMUAMT03 = "CMUAMT03";

        /// <summary>
        /// CMUAMT04.
        /// </summary>
        public const string CMUAMT04 = "CMUAMT04";

        /// <summary>
        /// CMUAMT05.
        /// </summary>
        public const string CMUAMT05 = "CMUAMT05";

        /// <summary>
        /// CMUAMT06.
        /// </summary>
        public const string CMUAMT06 = "CMUAMT06";

        /// <summary>
        /// CMUAMT07.
        /// </summary>
        public const string CMUAMT07 = "CMUAMT07";

        /// <summary>
        /// CMUAMT08.
        /// </summary>
        public const string CMUAMT08 = "CMUAMT08";

        /// <summary>
        /// CMUAMT09.
        /// </summary>
        public const string CMUAMT09 = "CMUAMT09";

        /// <summary>
        /// CMUAMT10.
        /// </summary>
        public const string CMUAMT10 = "CMUAMT10";

        /// <summary>
        /// CMF1A.
        /// </summary>
        public const string CMF1A = "CMF1A";

        /// <summary>
        /// CMF2A.
        /// </summary>
        public const string CMF2A = "CMF2A";

        /// <summary>
        /// CMF3A.
        /// </summary>
        public const string CMF3A = "CMF3A";

        /// <summary>
        /// CMF4A.
        /// </summary>
        public const string CMF4A = "CMF4A";

        /// <summary>
        /// CMF5A.
        /// </summary>
        public const string CMF5A = "CMF5A";

        /// <summary>
        /// CMUSD1.
        /// </summary>
        public const string CMUSD1 = "CMUSD1";

        /// <summary>
        /// CMUSD2.
        /// </summary>
        public const string CMUSD2 = "CMUSD2";

        /// <summary>
        /// CMUSD3.
        /// </summary>
        public const string CMUSD3 = "CMUSD3";

        /// <summary>
        /// CMUSD4.
        /// </summary>
        public const string CMUSD4 = "CMUSD4";

        /// <summary>
        /// CMUSD5.
        /// </summary>
        public const string CMUSD5 = "CMUSD5";

        /// <summary>
        /// CMUSD6.
        /// </summary>
        public const string CMUSD6 = "CMUSD6";

        /// <summary>
        /// CMUSD7.
        /// </summary>
        public const string CMUSD7 = "CMUSD7";

        /// <summary>
        /// CMUSD8.
        /// </summary>
        public const string CMUSD8 = "CMUSD8";

        /// <summary>
        /// CMUSD9.
        /// </summary>
        public const string CMUSD9 = "CMUSD9";

        /// <summary>
        /// CMUSD10.
        /// </summary>
        public const string CMUSD10 = "CMUSD10";

        /// <summary>
        /// CMCRTU.
        /// </summary>
        public const string CMCRTU = "CMCRTU";

        /// <summary>
        /// CMCRTJ.
        /// </summary>
        public const string CMCRTJ = "CMCRTJ";

        /// <summary>
        /// CMCRTT.
        /// </summary>
        public const string CMCRTT = "CMCRTT";

        /// <summary>
        /// CMWRKSTNID.
        /// </summary>
        public const string CMWRKSTNID = "CMWRKSTNID";

        /// <summary>
        /// CMHBOPID.
        /// </summary>
        public const string CMHBOPID = "CMHBOPID";

        /// <summary>
        /// CMUPMB.
        /// </summary>
        public const string CMUPMB = "CMUPMB";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";

        /// <summary>
        /// CMJOBN.
        /// </summary>
        public const string CMJOBN = "CMJOBN";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMSCHENB.
        /// </summary>
        public const string CMSCHENB = "CMSCHENB";

        /// <summary>
        /// CMHBST1.
        /// </summary>
        public const string CMHBST1 = "CMHBST1";

        /// <summary>
        /// CMHBST2.
        /// </summary>
        public const string CMHBST2 = "CMHBST2";

        /// <summary>
        /// CMHBST3.
        /// </summary>
        public const string CMHBST3 = "CMHBST3";

        /// <summary>
        /// CMHBST4.
        /// </summary>
        public const string CMHBST4 = "CMHBST4";

        /// <summary>
        /// CMHBST5.
        /// </summary>
        public const string CMHBST5 = "CMHBST5";
    }

    /// <inheritdoc />
    public override string TableName => "F44H101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMHBMCUS", "CMHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("CMCPHASE", "CMCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("CMPHSENB", "CMPHSENB", JdeDataType.String, 2),
        new JdeField("CMHBAREA", "CMHBAREA", JdeDataType.String, 6),
        new JdeField("CMDL01", "CMDL01", JdeDataType.String, 60),
        new JdeField("CMNBRPHS", "CMNBRPHS", JdeDataType.Numeric),
        new JdeField("CMPMPT", "CMPMPT", JdeDataType.String, 6),
        new JdeField("CMPMPG", "CMPMPG", JdeDataType.String, 6),
        new JdeField("CMAN8MCUS", "CMAN8MCUS", JdeDataType.Numeric),
        new JdeField("CMAN8SOF", "CMAN8SOF", JdeDataType.Numeric),
        new JdeField("CMAN8COF", "CMAN8COF", JdeDataType.Numeric),
        new JdeField("CMAN8CM01", "CMAN8CM01", JdeDataType.Numeric),
        new JdeField("CMAN8CM02", "CMAN8CM02", JdeDataType.Numeric),
        new JdeField("CMAN8CM03", "CMAN8CM03", JdeDataType.Numeric),
        new JdeField("CMAN8CM04", "CMAN8CM04", JdeDataType.Numeric),
        new JdeField("CMAN8CM05", "CMAN8CM05", JdeDataType.Numeric),
        new JdeField("CMAN8CM06", "CMAN8CM06", JdeDataType.Numeric),
        new JdeField("CMAN8CM07", "CMAN8CM07", JdeDataType.Numeric),
        new JdeField("CMAN8CM08", "CMAN8CM08", JdeDataType.Numeric),
        new JdeField("CMAN8CM09", "CMAN8CM09", JdeDataType.Numeric),
        new JdeField("CMAN8CM10", "CMAN8CM10", JdeDataType.Numeric),
        new JdeField("CMAN8CM11", "CMAN8CM11", JdeDataType.Numeric),
        new JdeField("CMAN8CM12", "CMAN8CM12", JdeDataType.Numeric),
        new JdeField("CMAN8CM13", "CMAN8CM13", JdeDataType.Numeric),
        new JdeField("CMAN8CM14", "CMAN8CM14", JdeDataType.Numeric),
        new JdeField("CMAN8CM15", "CMAN8CM15", JdeDataType.Numeric),
        new JdeField("CMAN8CM16", "CMAN8CM16", JdeDataType.Numeric),
        new JdeField("CMAN8CM17", "CMAN8CM17", JdeDataType.Numeric),
        new JdeField("CMAN8CM18", "CMAN8CM18", JdeDataType.Numeric),
        new JdeField("CMAN8CM19", "CMAN8CM19", JdeDataType.Numeric),
        new JdeField("CMAN8CM20", "CMAN8CM20", JdeDataType.Numeric),
        new JdeField("CMAN8UR01", "CMAN8UR01", JdeDataType.Numeric),
        new JdeField("CMAN8UR02", "CMAN8UR02", JdeDataType.Numeric),
        new JdeField("CMAN8UR03", "CMAN8UR03", JdeDataType.Numeric),
        new JdeField("CMAN8UR04", "CMAN8UR04", JdeDataType.Numeric),
        new JdeField("CMAN8UR05", "CMAN8UR05", JdeDataType.Numeric),
        new JdeField("CMCONSSEQ", "CMCONSSEQ", JdeDataType.String, 6),
        new JdeField("CMNBRLOT", "CMNBRLOT", JdeDataType.Numeric),
        new JdeField("CMNBRSLD", "CMNBRSLD", JdeDataType.Numeric),
        new JdeField("CMNBRCLSD", "CMNBRCLSD", JdeDataType.Numeric),
        new JdeField("CMNBRSTRD", "CMNBRSTRD", JdeDataType.Numeric),
        new JdeField("CMNBRFIN", "CMNBRFIN", JdeDataType.Numeric),
        new JdeField("CMAOCST01", "CMAOCST01", JdeDataType.Numeric),
        new JdeField("CMAOCST02", "CMAOCST02", JdeDataType.Numeric),
        new JdeField("CMAOCST03", "CMAOCST03", JdeDataType.Numeric),
        new JdeField("CMAOCST04", "CMAOCST04", JdeDataType.Numeric),
        new JdeField("CMAOCST05", "CMAOCST05", JdeDataType.Numeric),
        new JdeField("CMAOREV01", "CMAOREV01", JdeDataType.Numeric),
        new JdeField("CMAOREV02", "CMAOREV02", JdeDataType.Numeric),
        new JdeField("CMAOREV03", "CMAOREV03", JdeDataType.Numeric),
        new JdeField("CMAOREV04", "CMAOREV04", JdeDataType.Numeric),
        new JdeField("CMAOREV05", "CMAOREV05", JdeDataType.Numeric),
        new JdeField("CMCSTPCT01", "CMCSTPCT01", JdeDataType.Numeric),
        new JdeField("CMCSTPCT02", "CMCSTPCT02", JdeDataType.Numeric),
        new JdeField("CMCSTPCT03", "CMCSTPCT03", JdeDataType.Numeric),
        new JdeField("CMCSTPCT04", "CMCSTPCT04", JdeDataType.Numeric),
        new JdeField("CMCSTPCT05", "CMCSTPCT05", JdeDataType.Numeric),
        new JdeField("CMCSTPCT06", "CMCSTPCT06", JdeDataType.Numeric),
        new JdeField("CMCSTPCT07", "CMCSTPCT07", JdeDataType.Numeric),
        new JdeField("CMCSTPCT08", "CMCSTPCT08", JdeDataType.Numeric),
        new JdeField("CMCSTPCT09", "CMCSTPCT09", JdeDataType.Numeric),
        new JdeField("CMCSTPCT10", "CMCSTPCT10", JdeDataType.Numeric),
        new JdeField("CMHBRLTPC", "CMHBRLTPC", JdeDataType.String, 6),
        new JdeField("CMHBRLTPS", "CMHBRLTPS", JdeDataType.String, 6),
        new JdeField("CMINCMCU", "CMINCMCU", JdeDataType.String, 24),
        new JdeField("CMWAMCU", "CMWAMCU", JdeDataType.String, 24),
        new JdeField("CMCWTMPT", "CMCWTMPT", JdeDataType.String, 24),
        new JdeField("CMUAMT01", "CMUAMT01", JdeDataType.Numeric),
        new JdeField("CMUAMT02", "CMUAMT02", JdeDataType.Numeric),
        new JdeField("CMUAMT03", "CMUAMT03", JdeDataType.Numeric),
        new JdeField("CMUAMT04", "CMUAMT04", JdeDataType.Numeric),
        new JdeField("CMUAMT05", "CMUAMT05", JdeDataType.Numeric),
        new JdeField("CMUAMT06", "CMUAMT06", JdeDataType.Numeric),
        new JdeField("CMUAMT07", "CMUAMT07", JdeDataType.Numeric),
        new JdeField("CMUAMT08", "CMUAMT08", JdeDataType.Numeric),
        new JdeField("CMUAMT09", "CMUAMT09", JdeDataType.Numeric),
        new JdeField("CMUAMT10", "CMUAMT10", JdeDataType.Numeric),
        new JdeField("CMF1A", "CMF1A", JdeDataType.Numeric),
        new JdeField("CMF2A", "CMF2A", JdeDataType.Numeric),
        new JdeField("CMF3A", "CMF3A", JdeDataType.Numeric),
        new JdeField("CMF4A", "CMF4A", JdeDataType.Numeric),
        new JdeField("CMF5A", "CMF5A", JdeDataType.Numeric),
        new JdeField("CMUSD1", "CMUSD1", JdeDataType.Numeric),
        new JdeField("CMUSD2", "CMUSD2", JdeDataType.Numeric),
        new JdeField("CMUSD3", "CMUSD3", JdeDataType.Numeric),
        new JdeField("CMUSD4", "CMUSD4", JdeDataType.Numeric),
        new JdeField("CMUSD5", "CMUSD5", JdeDataType.Numeric),
        new JdeField("CMUSD6", "CMUSD6", JdeDataType.Numeric),
        new JdeField("CMUSD7", "CMUSD7", JdeDataType.Numeric),
        new JdeField("CMUSD8", "CMUSD8", JdeDataType.Numeric),
        new JdeField("CMUSD9", "CMUSD9", JdeDataType.Numeric),
        new JdeField("CMUSD10", "CMUSD10", JdeDataType.Numeric),
        new JdeField("CMCRTU", "CMCRTU", JdeDataType.String, 20),
        new JdeField("CMCRTJ", "CMCRTJ", JdeDataType.Numeric),
        new JdeField("CMCRTT", "CMCRTT", JdeDataType.Numeric),
        new JdeField("CMWRKSTNID", "CMWRKSTNID", JdeDataType.String, 20),
        new JdeField("CMHBOPID", "CMHBOPID", JdeDataType.String, 20),
        new JdeField("CMUPMB", "CMUPMB", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMSCHENB", "CMSCHENB", JdeDataType.String, 2),
        new JdeField("CMHBST1", "CMHBST1", JdeDataType.String, 2),
        new JdeField("CMHBST2", "CMHBST2", JdeDataType.String, 2),
        new JdeField("CMHBST3", "CMHBST3", JdeDataType.String, 2),
        new JdeField("CMHBST4", "CMHBST4", JdeDataType.String, 2),
        new JdeField("CMHBST5", "CMHBST5", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H101_0", "Primary Key on CMHBMCUS, CMCPHASE", new[] { "CMHBMCUS", "CMCPHASE" }, isUnique: true, isPrimaryKey: true)
    };
}
