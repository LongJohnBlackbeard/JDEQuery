using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H301 - .
/// </summary>
public class F44H301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PMHBMCUS.
        /// </summary>
        public const string PMHBMCUS = "PMHBMCUS";

        /// <summary>
        /// PMCPHASE.
        /// </summary>
        public const string PMCPHASE = "PMCPHASE";

        /// <summary>
        /// PMHBPLAN.
        /// </summary>
        public const string PMHBPLAN = "PMHBPLAN";

        /// <summary>
        /// PMHBELEV.
        /// </summary>
        public const string PMHBELEV = "PMHBELEV";

        /// <summary>
        /// PMHBAREA.
        /// </summary>
        public const string PMHBAREA = "PMHBAREA";

        /// <summary>
        /// PMBSP.
        /// </summary>
        public const string PMBSP = "PMBSP";

        /// <summary>
        /// PMBPP.
        /// </summary>
        public const string PMBPP = "PMBPP";

        /// <summary>
        /// PMSPJ.
        /// </summary>
        public const string PMSPJ = "PMSPJ";

        /// <summary>
        /// PMEXDE.
        /// </summary>
        public const string PMEXDE = "PMEXDE";

        /// <summary>
        /// PMMCUTJ.
        /// </summary>
        public const string PMMCUTJ = "PMMCUTJ";

        /// <summary>
        /// PMSCHTMPT.
        /// </summary>
        public const string PMSCHTMPT = "PMSCHTMPT";

        /// <summary>
        /// PMDL01.
        /// </summary>
        public const string PMDL01 = "PMDL01";

        /// <summary>
        /// PMDL02.
        /// </summary>
        public const string PMDL02 = "PMDL02";

        /// <summary>
        /// PMDL03.
        /// </summary>
        public const string PMDL03 = "PMDL03";

        /// <summary>
        /// PMPMPT.
        /// </summary>
        public const string PMPMPT = "PMPMPT";

        /// <summary>
        /// PMPMPG.
        /// </summary>
        public const string PMPMPG = "PMPMPG";

        /// <summary>
        /// PMSQFEET.
        /// </summary>
        public const string PMSQFEET = "PMSQFEET";

        /// <summary>
        /// PMDSC1.
        /// </summary>
        public const string PMDSC1 = "PMDSC1";

        /// <summary>
        /// PMDSC2.
        /// </summary>
        public const string PMDSC2 = "PMDSC2";

        /// <summary>
        /// PMPLNMX.
        /// </summary>
        public const string PMPLNMX = "PMPLNMX";

        /// <summary>
        /// PMPLNMXRL.
        /// </summary>
        public const string PMPLNMXRL = "PMPLNMXRL";

        /// <summary>
        /// PMESTDISC1.
        /// </summary>
        public const string PMESTDISC1 = "PMESTDISC1";

        /// <summary>
        /// PMESTDISC2.
        /// </summary>
        public const string PMESTDISC2 = "PMESTDISC2";

        /// <summary>
        /// PMESTDISC3.
        /// </summary>
        public const string PMESTDISC3 = "PMESTDISC3";

        /// <summary>
        /// PMOPTMGN1.
        /// </summary>
        public const string PMOPTMGN1 = "PMOPTMGN1";

        /// <summary>
        /// PMOPTMGN2.
        /// </summary>
        public const string PMOPTMGN2 = "PMOPTMGN2";

        /// <summary>
        /// PMOPTMGN3.
        /// </summary>
        public const string PMOPTMGN3 = "PMOPTMGN3";

        /// <summary>
        /// PMOPTMGN4.
        /// </summary>
        public const string PMOPTMGN4 = "PMOPTMGN4";

        /// <summary>
        /// PMOPTMGN5.
        /// </summary>
        public const string PMOPTMGN5 = "PMOPTMGN5";

        /// <summary>
        /// PMESTOPR1.
        /// </summary>
        public const string PMESTOPR1 = "PMESTOPR1";

        /// <summary>
        /// PMESTOPR2.
        /// </summary>
        public const string PMESTOPR2 = "PMESTOPR2";

        /// <summary>
        /// PMESTOPR3.
        /// </summary>
        public const string PMESTOPR3 = "PMESTOPR3";

        /// <summary>
        /// PMESTOPR4.
        /// </summary>
        public const string PMESTOPR4 = "PMESTOPR4";

        /// <summary>
        /// PMESTOPR5.
        /// </summary>
        public const string PMESTOPR5 = "PMESTOPR5";

        /// <summary>
        /// PMESTOPIN.
        /// </summary>
        public const string PMESTOPIN = "PMESTOPIN";

        /// <summary>
        /// PMESTPLANC.
        /// </summary>
        public const string PMESTPLANC = "PMESTPLANC";

        /// <summary>
        /// PMCSTAMT01.
        /// </summary>
        public const string PMCSTAMT01 = "PMCSTAMT01";

        /// <summary>
        /// PMCSTAMT02.
        /// </summary>
        public const string PMCSTAMT02 = "PMCSTAMT02";

        /// <summary>
        /// PMCSTAMT03.
        /// </summary>
        public const string PMCSTAMT03 = "PMCSTAMT03";

        /// <summary>
        /// PMCSTAMT04.
        /// </summary>
        public const string PMCSTAMT04 = "PMCSTAMT04";

        /// <summary>
        /// PMCSTAMT05.
        /// </summary>
        public const string PMCSTAMT05 = "PMCSTAMT05";

        /// <summary>
        /// PMCSTAMT06.
        /// </summary>
        public const string PMCSTAMT06 = "PMCSTAMT06";

        /// <summary>
        /// PMCSTAMT07.
        /// </summary>
        public const string PMCSTAMT07 = "PMCSTAMT07";

        /// <summary>
        /// PMCSTAMT08.
        /// </summary>
        public const string PMCSTAMT08 = "PMCSTAMT08";

        /// <summary>
        /// PMCSTAMT09.
        /// </summary>
        public const string PMCSTAMT09 = "PMCSTAMT09";

        /// <summary>
        /// PMCSTAMT10.
        /// </summary>
        public const string PMCSTAMT10 = "PMCSTAMT10";

        /// <summary>
        /// PMESTWKSL.
        /// </summary>
        public const string PMESTWKSL = "PMESTWKSL";

        /// <summary>
        /// PMPLC01.
        /// </summary>
        public const string PMPLC01 = "PMPLC01";

        /// <summary>
        /// PMPLC02.
        /// </summary>
        public const string PMPLC02 = "PMPLC02";

        /// <summary>
        /// PMPLC03.
        /// </summary>
        public const string PMPLC03 = "PMPLC03";

        /// <summary>
        /// PMPLC04.
        /// </summary>
        public const string PMPLC04 = "PMPLC04";

        /// <summary>
        /// PMPLC05.
        /// </summary>
        public const string PMPLC05 = "PMPLC05";

        /// <summary>
        /// PMPLC06.
        /// </summary>
        public const string PMPLC06 = "PMPLC06";

        /// <summary>
        /// PMPLC07.
        /// </summary>
        public const string PMPLC07 = "PMPLC07";

        /// <summary>
        /// PMPLC08.
        /// </summary>
        public const string PMPLC08 = "PMPLC08";

        /// <summary>
        /// PMPLC09.
        /// </summary>
        public const string PMPLC09 = "PMPLC09";

        /// <summary>
        /// PMPLC10.
        /// </summary>
        public const string PMPLC10 = "PMPLC10";

        /// <summary>
        /// PMPLC11.
        /// </summary>
        public const string PMPLC11 = "PMPLC11";

        /// <summary>
        /// PMPLC12.
        /// </summary>
        public const string PMPLC12 = "PMPLC12";

        /// <summary>
        /// PMPLC13.
        /// </summary>
        public const string PMPLC13 = "PMPLC13";

        /// <summary>
        /// PMPLC14.
        /// </summary>
        public const string PMPLC14 = "PMPLC14";

        /// <summary>
        /// PMPLC15.
        /// </summary>
        public const string PMPLC15 = "PMPLC15";

        /// <summary>
        /// PMUSD1.
        /// </summary>
        public const string PMUSD1 = "PMUSD1";

        /// <summary>
        /// PMUSD2.
        /// </summary>
        public const string PMUSD2 = "PMUSD2";

        /// <summary>
        /// PMUSD3.
        /// </summary>
        public const string PMUSD3 = "PMUSD3";

        /// <summary>
        /// PMUSD4.
        /// </summary>
        public const string PMUSD4 = "PMUSD4";

        /// <summary>
        /// PMUSD5.
        /// </summary>
        public const string PMUSD5 = "PMUSD5";

        /// <summary>
        /// PMCRTU.
        /// </summary>
        public const string PMCRTU = "PMCRTU";

        /// <summary>
        /// PMCRTJ.
        /// </summary>
        public const string PMCRTJ = "PMCRTJ";

        /// <summary>
        /// PMCRTT.
        /// </summary>
        public const string PMCRTT = "PMCRTT";

        /// <summary>
        /// PMWRKSTNID.
        /// </summary>
        public const string PMWRKSTNID = "PMWRKSTNID";

        /// <summary>
        /// PMHBOPID.
        /// </summary>
        public const string PMHBOPID = "PMHBOPID";

        /// <summary>
        /// PMUPMB.
        /// </summary>
        public const string PMUPMB = "PMUPMB";

        /// <summary>
        /// PMUPMJ.
        /// </summary>
        public const string PMUPMJ = "PMUPMJ";

        /// <summary>
        /// PMUPMT.
        /// </summary>
        public const string PMUPMT = "PMUPMT";

        /// <summary>
        /// PMJOBN.
        /// </summary>
        public const string PMJOBN = "PMJOBN";

        /// <summary>
        /// PMPID.
        /// </summary>
        public const string PMPID = "PMPID";

        /// <summary>
        /// PMHBST1.
        /// </summary>
        public const string PMHBST1 = "PMHBST1";

        /// <summary>
        /// PMHBST2.
        /// </summary>
        public const string PMHBST2 = "PMHBST2";

        /// <summary>
        /// PMHBST3.
        /// </summary>
        public const string PMHBST3 = "PMHBST3";

        /// <summary>
        /// PMHBST4.
        /// </summary>
        public const string PMHBST4 = "PMHBST4";

        /// <summary>
        /// PMHBST5.
        /// </summary>
        public const string PMHBST5 = "PMHBST5";
    }

    /// <inheritdoc />
    public override string TableName => "F44H301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PMHBMCUS", "PMHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("PMCPHASE", "PMCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("PMHBPLAN", "PMHBPLAN", JdeDataType.String, 8, true, true),
        new JdeField("PMHBELEV", "PMHBELEV", JdeDataType.String, 6, true, true),
        new JdeField("PMHBAREA", "PMHBAREA", JdeDataType.String, 6),
        new JdeField("PMBSP", "PMBSP", JdeDataType.Numeric),
        new JdeField("PMBPP", "PMBPP", JdeDataType.Numeric),
        new JdeField("PMSPJ", "PMSPJ", JdeDataType.Numeric),
        new JdeField("PMEXDE", "PMEXDE", JdeDataType.Numeric),
        new JdeField("PMMCUTJ", "PMMCUTJ", JdeDataType.String, 24),
        new JdeField("PMSCHTMPT", "PMSCHTMPT", JdeDataType.String, 24),
        new JdeField("PMDL01", "PMDL01", JdeDataType.String, 60),
        new JdeField("PMDL02", "PMDL02", JdeDataType.String, 60),
        new JdeField("PMDL03", "PMDL03", JdeDataType.String, 60),
        new JdeField("PMPMPT", "PMPMPT", JdeDataType.String, 6),
        new JdeField("PMPMPG", "PMPMPG", JdeDataType.String, 6),
        new JdeField("PMSQFEET", "PMSQFEET", JdeDataType.Numeric),
        new JdeField("PMDSC1", "PMDSC1", JdeDataType.String, 60),
        new JdeField("PMDSC2", "PMDSC2", JdeDataType.String, 60),
        new JdeField("PMPLNMX", "PMPLNMX", JdeDataType.Numeric),
        new JdeField("PMPLNMXRL", "PMPLNMXRL", JdeDataType.Numeric),
        new JdeField("PMESTDISC1", "PMESTDISC1", JdeDataType.Numeric),
        new JdeField("PMESTDISC2", "PMESTDISC2", JdeDataType.Numeric),
        new JdeField("PMESTDISC3", "PMESTDISC3", JdeDataType.Numeric),
        new JdeField("PMOPTMGN1", "PMOPTMGN1", JdeDataType.Numeric),
        new JdeField("PMOPTMGN2", "PMOPTMGN2", JdeDataType.Numeric),
        new JdeField("PMOPTMGN3", "PMOPTMGN3", JdeDataType.Numeric),
        new JdeField("PMOPTMGN4", "PMOPTMGN4", JdeDataType.Numeric),
        new JdeField("PMOPTMGN5", "PMOPTMGN5", JdeDataType.Numeric),
        new JdeField("PMESTOPR1", "PMESTOPR1", JdeDataType.Numeric),
        new JdeField("PMESTOPR2", "PMESTOPR2", JdeDataType.Numeric),
        new JdeField("PMESTOPR3", "PMESTOPR3", JdeDataType.Numeric),
        new JdeField("PMESTOPR4", "PMESTOPR4", JdeDataType.Numeric),
        new JdeField("PMESTOPR5", "PMESTOPR5", JdeDataType.Numeric),
        new JdeField("PMESTOPIN", "PMESTOPIN", JdeDataType.Numeric),
        new JdeField("PMESTPLANC", "PMESTPLANC", JdeDataType.Numeric),
        new JdeField("PMCSTAMT01", "PMCSTAMT01", JdeDataType.Numeric),
        new JdeField("PMCSTAMT02", "PMCSTAMT02", JdeDataType.Numeric),
        new JdeField("PMCSTAMT03", "PMCSTAMT03", JdeDataType.Numeric),
        new JdeField("PMCSTAMT04", "PMCSTAMT04", JdeDataType.Numeric),
        new JdeField("PMCSTAMT05", "PMCSTAMT05", JdeDataType.Numeric),
        new JdeField("PMCSTAMT06", "PMCSTAMT06", JdeDataType.Numeric),
        new JdeField("PMCSTAMT07", "PMCSTAMT07", JdeDataType.Numeric),
        new JdeField("PMCSTAMT08", "PMCSTAMT08", JdeDataType.Numeric),
        new JdeField("PMCSTAMT09", "PMCSTAMT09", JdeDataType.Numeric),
        new JdeField("PMCSTAMT10", "PMCSTAMT10", JdeDataType.Numeric),
        new JdeField("PMESTWKSL", "PMESTWKSL", JdeDataType.Numeric),
        new JdeField("PMPLC01", "PMPLC01", JdeDataType.String, 6),
        new JdeField("PMPLC02", "PMPLC02", JdeDataType.String, 6),
        new JdeField("PMPLC03", "PMPLC03", JdeDataType.String, 6),
        new JdeField("PMPLC04", "PMPLC04", JdeDataType.String, 6),
        new JdeField("PMPLC05", "PMPLC05", JdeDataType.String, 6),
        new JdeField("PMPLC06", "PMPLC06", JdeDataType.String, 6),
        new JdeField("PMPLC07", "PMPLC07", JdeDataType.String, 6),
        new JdeField("PMPLC08", "PMPLC08", JdeDataType.String, 6),
        new JdeField("PMPLC09", "PMPLC09", JdeDataType.String, 6),
        new JdeField("PMPLC10", "PMPLC10", JdeDataType.String, 6),
        new JdeField("PMPLC11", "PMPLC11", JdeDataType.String, 20),
        new JdeField("PMPLC12", "PMPLC12", JdeDataType.String, 20),
        new JdeField("PMPLC13", "PMPLC13", JdeDataType.String, 20),
        new JdeField("PMPLC14", "PMPLC14", JdeDataType.String, 20),
        new JdeField("PMPLC15", "PMPLC15", JdeDataType.String, 20),
        new JdeField("PMUSD1", "PMUSD1", JdeDataType.Numeric),
        new JdeField("PMUSD2", "PMUSD2", JdeDataType.Numeric),
        new JdeField("PMUSD3", "PMUSD3", JdeDataType.Numeric),
        new JdeField("PMUSD4", "PMUSD4", JdeDataType.Numeric),
        new JdeField("PMUSD5", "PMUSD5", JdeDataType.Numeric),
        new JdeField("PMCRTU", "PMCRTU", JdeDataType.String, 20),
        new JdeField("PMCRTJ", "PMCRTJ", JdeDataType.Numeric),
        new JdeField("PMCRTT", "PMCRTT", JdeDataType.Numeric),
        new JdeField("PMWRKSTNID", "PMWRKSTNID", JdeDataType.String, 20),
        new JdeField("PMHBOPID", "PMHBOPID", JdeDataType.String, 20),
        new JdeField("PMUPMB", "PMUPMB", JdeDataType.String, 20),
        new JdeField("PMUPMJ", "PMUPMJ", JdeDataType.Numeric),
        new JdeField("PMUPMT", "PMUPMT", JdeDataType.Numeric),
        new JdeField("PMJOBN", "PMJOBN", JdeDataType.String, 20),
        new JdeField("PMPID", "PMPID", JdeDataType.String, 20),
        new JdeField("PMHBST1", "PMHBST1", JdeDataType.String, 2),
        new JdeField("PMHBST2", "PMHBST2", JdeDataType.String, 2),
        new JdeField("PMHBST3", "PMHBST3", JdeDataType.String, 2),
        new JdeField("PMHBST4", "PMHBST4", JdeDataType.String, 2),
        new JdeField("PMHBST5", "PMHBST5", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H301_0", "Primary Key on PMHBMCUS, PMCPHASE, PMHBPLAN, PMHBELEV", new[] { "PMHBMCUS", "PMCPHASE", "PMHBPLAN", "PMHBELEV" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H301_2", "Index on PMCPHASE, PMHBPLAN, PMHBELEV", new[] { "PMCPHASE", "PMHBPLAN", "PMHBELEV" })
    };
}
