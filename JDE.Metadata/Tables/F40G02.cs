using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G02 - .
/// </summary>
public class F40G02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GBBLUID.
        /// </summary>
        public const string GBBLUID = "GBBLUID";

        /// <summary>
        /// GBBLSCD2.
        /// </summary>
        public const string GBBLSCD2 = "GBBLSCD2";

        /// <summary>
        /// GBBLNAM.
        /// </summary>
        public const string GBBLNAM = "GBBLNAM";

        /// <summary>
        /// GBBLNAM2.
        /// </summary>
        public const string GBBLNAM2 = "GBBLNAM2";

        /// <summary>
        /// GBBLTYPE.
        /// </summary>
        public const string GBBLTYPE = "GBBLTYPE";

        /// <summary>
        /// GBBSTATUS.
        /// </summary>
        public const string GBBSTATUS = "GBBSTATUS";

        /// <summary>
        /// GBAN8BL.
        /// </summary>
        public const string GBAN8BL = "GBAN8BL";

        /// <summary>
        /// GBAN8FARM.
        /// </summary>
        public const string GBAN8FARM = "GBAN8FARM";

        /// <summary>
        /// GBFARMCODE.
        /// </summary>
        public const string GBFARMCODE = "GBFARMCODE";

        /// <summary>
        /// GBOMCU.
        /// </summary>
        public const string GBOMCU = "GBOMCU";

        /// <summary>
        /// GBGEOCST.
        /// </summary>
        public const string GBGEOCST = "GBGEOCST";

        /// <summary>
        /// GBGOAID.
        /// </summary>
        public const string GBGOAID = "GBGOAID";

        /// <summary>
        /// GBGOAREA.
        /// </summary>
        public const string GBGOAREA = "GBGOAREA";

        /// <summary>
        /// GBAPPID.
        /// </summary>
        public const string GBAPPID = "GBAPPID";

        /// <summary>
        /// GBAPPLLAT.
        /// </summary>
        public const string GBAPPLLAT = "GBAPPLLAT";

        /// <summary>
        /// GBGREGION.
        /// </summary>
        public const string GBGREGION = "GBGREGION";

        /// <summary>
        /// GBGDISTR.
        /// </summary>
        public const string GBGDISTR = "GBGDISTR";

        /// <summary>
        /// GBVARID.
        /// </summary>
        public const string GBVARID = "GBVARID";

        /// <summary>
        /// GBVARCODE.
        /// </summary>
        public const string GBVARCODE = "GBVARCODE";

        /// <summary>
        /// GBAN8V.
        /// </summary>
        public const string GBAN8V = "GBAN8V";

        /// <summary>
        /// GBGRCMPCD.
        /// </summary>
        public const string GBGRCMPCD = "GBGRCMPCD";

        /// <summary>
        /// GBAN8GR.
        /// </summary>
        public const string GBAN8GR = "GBAN8GR";

        /// <summary>
        /// GBAN8BR.
        /// </summary>
        public const string GBAN8BR = "GBAN8BR";

        /// <summary>
        /// GBAN8CR.
        /// </summary>
        public const string GBAN8CR = "GBAN8CR";

        /// <summary>
        /// GBELEVATIO.
        /// </summary>
        public const string GBELEVATIO = "GBELEVATIO";

        /// <summary>
        /// GBELEVUOM.
        /// </summary>
        public const string GBELEVUOM = "GBELEVUOM";

        /// <summary>
        /// GBGRSAREA.
        /// </summary>
        public const string GBGRSAREA = "GBGRSAREA";

        /// <summary>
        /// GBPLTAREA.
        /// </summary>
        public const string GBPLTAREA = "GBPLTAREA";

        /// <summary>
        /// GBAREAUOM.
        /// </summary>
        public const string GBAREAUOM = "GBAREAUOM";

        /// <summary>
        /// GBUPLTDAT.
        /// </summary>
        public const string GBUPLTDAT = "GBUPLTDAT";

        /// <summary>
        /// GBDIMA.
        /// </summary>
        public const string GBDIMA = "GBDIMA";

        /// <summary>
        /// GBDIMB.
        /// </summary>
        public const string GBDIMB = "GBDIMB";

        /// <summary>
        /// GBDIMUOM.
        /// </summary>
        public const string GBDIMUOM = "GBDIMUOM";

        /// <summary>
        /// GBPARCEL1.
        /// </summary>
        public const string GBPARCEL1 = "GBPARCEL1";

        /// <summary>
        /// GBPARCEL2.
        /// </summary>
        public const string GBPARCEL2 = "GBPARCEL2";

        /// <summary>
        /// GBPARCEL3.
        /// </summary>
        public const string GBPARCEL3 = "GBPARCEL3";

        /// <summary>
        /// GBPAREA1.
        /// </summary>
        public const string GBPAREA1 = "GBPAREA1";

        /// <summary>
        /// GBPAREA2.
        /// </summary>
        public const string GBPAREA2 = "GBPAREA2";

        /// <summary>
        /// GBPAREA3.
        /// </summary>
        public const string GBPAREA3 = "GBPAREA3";

        /// <summary>
        /// GBGOVID1.
        /// </summary>
        public const string GBGOVID1 = "GBGOVID1";

        /// <summary>
        /// GBGOVID2.
        /// </summary>
        public const string GBGOVID2 = "GBGOVID2";

        /// <summary>
        /// GBGOVID3.
        /// </summary>
        public const string GBGOVID3 = "GBGOVID3";

        /// <summary>
        /// GBGOVID4.
        /// </summary>
        public const string GBGOVID4 = "GBGOVID4";

        /// <summary>
        /// GBOPERID.
        /// </summary>
        public const string GBOPERID = "GBOPERID";

        /// <summary>
        /// GBSITEID.
        /// </summary>
        public const string GBSITEID = "GBSITEID";

        /// <summary>
        /// GBMATYP.
        /// </summary>
        public const string GBMATYP = "GBMATYP";

        /// <summary>
        /// GBSOILTYP.
        /// </summary>
        public const string GBSOILTYP = "GBSOILTYP";

        /// <summary>
        /// GBWATERTY.
        /// </summary>
        public const string GBWATERTY = "GBWATERTY";

        /// <summary>
        /// GBIVOL.
        /// </summary>
        public const string GBIVOL = "GBIVOL";

        /// <summary>
        /// GBVOLUM.
        /// </summary>
        public const string GBVOLUM = "GBVOLUM";

        /// <summary>
        /// GBPRUNEMT.
        /// </summary>
        public const string GBPRUNEMT = "GBPRUNEMT";

        /// <summary>
        /// GBCLONE.
        /// </summary>
        public const string GBCLONE = "GBCLONE";

        /// <summary>
        /// GBROOTSTK.
        /// </summary>
        public const string GBROOTSTK = "GBROOTSTK";

        /// <summary>
        /// GBROWSPC.
        /// </summary>
        public const string GBROWSPC = "GBROWSPC";

        /// <summary>
        /// GBPLTSPC.
        /// </summary>
        public const string GBPLTSPC = "GBPLTSPC";

        /// <summary>
        /// GBNOP.
        /// </summary>
        public const string GBNOP = "GBNOP";

        /// <summary>
        /// GBSITEC.
        /// </summary>
        public const string GBSITEC = "GBSITEC";

        /// <summary>
        /// GBSITEP.
        /// </summary>
        public const string GBSITEP = "GBSITEP";

        /// <summary>
        /// GBITM.
        /// </summary>
        public const string GBITM = "GBITM";

        /// <summary>
        /// GBLITM.
        /// </summary>
        public const string GBLITM = "GBLITM";

        /// <summary>
        /// GBAITM.
        /// </summary>
        public const string GBAITM = "GBAITM";

        /// <summary>
        /// GBGPRC.
        /// </summary>
        public const string GBGPRC = "GBGPRC";

        /// <summary>
        /// GBUOM4.
        /// </summary>
        public const string GBUOM4 = "GBUOM4";

        /// <summary>
        /// GBCRCD.
        /// </summary>
        public const string GBCRCD = "GBCRCD";

        /// <summary>
        /// GBCURREST.
        /// </summary>
        public const string GBCURREST = "GBCURREST";

        /// <summary>
        /// GBPLNEST.
        /// </summary>
        public const string GBPLNEST = "GBPLNEST";

        /// <summary>
        /// GBQTYUOM.
        /// </summary>
        public const string GBQTYUOM = "GBQTYUOM";

        /// <summary>
        /// GBQTYLOAD.
        /// </summary>
        public const string GBQTYLOAD = "GBQTYLOAD";

        /// <summary>
        /// GBCONTUOM.
        /// </summary>
        public const string GBCONTUOM = "GBCONTUOM";

        /// <summary>
        /// GBEXTRRTE.
        /// </summary>
        public const string GBEXTRRTE = "GBEXTRRTE";

        /// <summary>
        /// GBTARQLTY.
        /// </summary>
        public const string GBTARQLTY = "GBTARQLTY";

        /// <summary>
        /// GBCURQLTY.
        /// </summary>
        public const string GBCURQLTY = "GBCURQLTY";

        /// <summary>
        /// GBHARPAT.
        /// </summary>
        public const string GBHARPAT = "GBHARPAT";

        /// <summary>
        /// GBUCEF.
        /// </summary>
        public const string GBUCEF = "GBUCEF";

        /// <summary>
        /// GBMATCALID.
        /// </summary>
        public const string GBMATCALID = "GBMATCALID";

        /// <summary>
        /// GBGROW01.
        /// </summary>
        public const string GBGROW01 = "GBGROW01";

        /// <summary>
        /// GBGROW02.
        /// </summary>
        public const string GBGROW02 = "GBGROW02";

        /// <summary>
        /// GBGROW03.
        /// </summary>
        public const string GBGROW03 = "GBGROW03";

        /// <summary>
        /// GBGROW04.
        /// </summary>
        public const string GBGROW04 = "GBGROW04";

        /// <summary>
        /// GBGROW05.
        /// </summary>
        public const string GBGROW05 = "GBGROW05";

        /// <summary>
        /// GBGROW06.
        /// </summary>
        public const string GBGROW06 = "GBGROW06";

        /// <summary>
        /// GBGROW07.
        /// </summary>
        public const string GBGROW07 = "GBGROW07";

        /// <summary>
        /// GBGROW08.
        /// </summary>
        public const string GBGROW08 = "GBGROW08";

        /// <summary>
        /// GBGROW09.
        /// </summary>
        public const string GBGROW09 = "GBGROW09";

        /// <summary>
        /// GBGROW10.
        /// </summary>
        public const string GBGROW10 = "GBGROW10";

        /// <summary>
        /// GBGROW11.
        /// </summary>
        public const string GBGROW11 = "GBGROW11";

        /// <summary>
        /// GBGROW12.
        /// </summary>
        public const string GBGROW12 = "GBGROW12";

        /// <summary>
        /// GBGROW13.
        /// </summary>
        public const string GBGROW13 = "GBGROW13";

        /// <summary>
        /// GBGROW14.
        /// </summary>
        public const string GBGROW14 = "GBGROW14";

        /// <summary>
        /// GBGROW15.
        /// </summary>
        public const string GBGROW15 = "GBGROW15";

        /// <summary>
        /// GBCGROW01.
        /// </summary>
        public const string GBCGROW01 = "GBCGROW01";

        /// <summary>
        /// GBCGROW02.
        /// </summary>
        public const string GBCGROW02 = "GBCGROW02";

        /// <summary>
        /// GBCGROW03.
        /// </summary>
        public const string GBCGROW03 = "GBCGROW03";

        /// <summary>
        /// GBCGROW04.
        /// </summary>
        public const string GBCGROW04 = "GBCGROW04";

        /// <summary>
        /// GBCGROW05.
        /// </summary>
        public const string GBCGROW05 = "GBCGROW05";

        /// <summary>
        /// GBUGDATE01.
        /// </summary>
        public const string GBUGDATE01 = "GBUGDATE01";

        /// <summary>
        /// GBUGDATE02.
        /// </summary>
        public const string GBUGDATE02 = "GBUGDATE02";

        /// <summary>
        /// GBUGDATE03.
        /// </summary>
        public const string GBUGDATE03 = "GBUGDATE03";

        /// <summary>
        /// GBUGDATE04.
        /// </summary>
        public const string GBUGDATE04 = "GBUGDATE04";

        /// <summary>
        /// GBUGDATE05.
        /// </summary>
        public const string GBUGDATE05 = "GBUGDATE05";

        /// <summary>
        /// GBUGDATE06.
        /// </summary>
        public const string GBUGDATE06 = "GBUGDATE06";

        /// <summary>
        /// GBUGDATE07.
        /// </summary>
        public const string GBUGDATE07 = "GBUGDATE07";

        /// <summary>
        /// GBUGDATE08.
        /// </summary>
        public const string GBUGDATE08 = "GBUGDATE08";

        /// <summary>
        /// GBGNUM01.
        /// </summary>
        public const string GBGNUM01 = "GBGNUM01";

        /// <summary>
        /// GBGNUM02.
        /// </summary>
        public const string GBGNUM02 = "GBGNUM02";

        /// <summary>
        /// GBGNUM03.
        /// </summary>
        public const string GBGNUM03 = "GBGNUM03";

        /// <summary>
        /// GBGNUM04.
        /// </summary>
        public const string GBGNUM04 = "GBGNUM04";

        /// <summary>
        /// GBGNUM05.
        /// </summary>
        public const string GBGNUM05 = "GBGNUM05";

        /// <summary>
        /// GBURCD.
        /// </summary>
        public const string GBURCD = "GBURCD";

        /// <summary>
        /// GBURDT.
        /// </summary>
        public const string GBURDT = "GBURDT";

        /// <summary>
        /// GBURRF.
        /// </summary>
        public const string GBURRF = "GBURRF";

        /// <summary>
        /// GBURAB.
        /// </summary>
        public const string GBURAB = "GBURAB";

        /// <summary>
        /// GBURAT.
        /// </summary>
        public const string GBURAT = "GBURAT";

        /// <summary>
        /// GBCRTU.
        /// </summary>
        public const string GBCRTU = "GBCRTU";

        /// <summary>
        /// GBTORG.
        /// </summary>
        public const string GBTORG = "GBTORG";

        /// <summary>
        /// GBUSER.
        /// </summary>
        public const string GBUSER = "GBUSER";

        /// <summary>
        /// GBPID.
        /// </summary>
        public const string GBPID = "GBPID";

        /// <summary>
        /// GBJOBN.
        /// </summary>
        public const string GBJOBN = "GBJOBN";

        /// <summary>
        /// GBUUPMJ.
        /// </summary>
        public const string GBUUPMJ = "GBUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GBBLUID", "GBBLUID", JdeDataType.Numeric, null, true, true),
        new JdeField("GBBLSCD2", "GBBLSCD2", JdeDataType.String, 20),
        new JdeField("GBBLNAM", "GBBLNAM", JdeDataType.String, 80),
        new JdeField("GBBLNAM2", "GBBLNAM2", JdeDataType.String, 80),
        new JdeField("GBBLTYPE", "GBBLTYPE", JdeDataType.String, 2),
        new JdeField("GBBSTATUS", "GBBSTATUS", JdeDataType.String, 2),
        new JdeField("GBAN8BL", "GBAN8BL", JdeDataType.Numeric),
        new JdeField("GBAN8FARM", "GBAN8FARM", JdeDataType.Numeric),
        new JdeField("GBFARMCODE", "GBFARMCODE", JdeDataType.String, 16),
        new JdeField("GBOMCU", "GBOMCU", JdeDataType.String, 24),
        new JdeField("GBGEOCST", "GBGEOCST", JdeDataType.String, 6),
        new JdeField("GBGOAID", "GBGOAID", JdeDataType.Numeric),
        new JdeField("GBGOAREA", "GBGOAREA", JdeDataType.String, 8),
        new JdeField("GBAPPID", "GBAPPID", JdeDataType.Numeric),
        new JdeField("GBAPPLLAT", "GBAPPLLAT", JdeDataType.String, 16),
        new JdeField("GBGREGION", "GBGREGION", JdeDataType.String, 20),
        new JdeField("GBGDISTR", "GBGDISTR", JdeDataType.String, 20),
        new JdeField("GBVARID", "GBVARID", JdeDataType.Numeric),
        new JdeField("GBVARCODE", "GBVARCODE", JdeDataType.String, 10),
        new JdeField("GBAN8V", "GBAN8V", JdeDataType.Numeric),
        new JdeField("GBGRCMPCD", "GBGRCMPCD", JdeDataType.String, 20),
        new JdeField("GBAN8GR", "GBAN8GR", JdeDataType.Numeric),
        new JdeField("GBAN8BR", "GBAN8BR", JdeDataType.Numeric),
        new JdeField("GBAN8CR", "GBAN8CR", JdeDataType.Numeric),
        new JdeField("GBELEVATIO", "GBELEVATIO", JdeDataType.Numeric),
        new JdeField("GBELEVUOM", "GBELEVUOM", JdeDataType.String, 4),
        new JdeField("GBGRSAREA", "GBGRSAREA", JdeDataType.Numeric),
        new JdeField("GBPLTAREA", "GBPLTAREA", JdeDataType.Numeric),
        new JdeField("GBAREAUOM", "GBAREAUOM", JdeDataType.String, 4),
        new JdeField("GBUPLTDAT", "GBUPLTDAT", JdeDataType.Date),
        new JdeField("GBDIMA", "GBDIMA", JdeDataType.Numeric),
        new JdeField("GBDIMB", "GBDIMB", JdeDataType.Numeric),
        new JdeField("GBDIMUOM", "GBDIMUOM", JdeDataType.String, 4),
        new JdeField("GBPARCEL1", "GBPARCEL1", JdeDataType.String, 50),
        new JdeField("GBPARCEL2", "GBPARCEL2", JdeDataType.String, 50),
        new JdeField("GBPARCEL3", "GBPARCEL3", JdeDataType.String, 50),
        new JdeField("GBPAREA1", "GBPAREA1", JdeDataType.Numeric),
        new JdeField("GBPAREA2", "GBPAREA2", JdeDataType.Numeric),
        new JdeField("GBPAREA3", "GBPAREA3", JdeDataType.Numeric),
        new JdeField("GBGOVID1", "GBGOVID1", JdeDataType.String, 50),
        new JdeField("GBGOVID2", "GBGOVID2", JdeDataType.String, 50),
        new JdeField("GBGOVID3", "GBGOVID3", JdeDataType.String, 50),
        new JdeField("GBGOVID4", "GBGOVID4", JdeDataType.String, 50),
        new JdeField("GBOPERID", "GBOPERID", JdeDataType.String, 22),
        new JdeField("GBSITEID", "GBSITEID", JdeDataType.String, 16),
        new JdeField("GBMATYP", "GBMATYP", JdeDataType.String, 8),
        new JdeField("GBSOILTYP", "GBSOILTYP", JdeDataType.String, 4),
        new JdeField("GBWATERTY", "GBWATERTY", JdeDataType.String, 4),
        new JdeField("GBIVOL", "GBIVOL", JdeDataType.Numeric),
        new JdeField("GBVOLUM", "GBVOLUM", JdeDataType.String, 4),
        new JdeField("GBPRUNEMT", "GBPRUNEMT", JdeDataType.String, 4),
        new JdeField("GBCLONE", "GBCLONE", JdeDataType.String, 4),
        new JdeField("GBROOTSTK", "GBROOTSTK", JdeDataType.String, 4),
        new JdeField("GBROWSPC", "GBROWSPC", JdeDataType.String, 4),
        new JdeField("GBPLTSPC", "GBPLTSPC", JdeDataType.String, 4),
        new JdeField("GBNOP", "GBNOP", JdeDataType.Numeric),
        new JdeField("GBSITEC", "GBSITEC", JdeDataType.String, 24),
        new JdeField("GBSITEP", "GBSITEP", JdeDataType.String, 24),
        new JdeField("GBITM", "GBITM", JdeDataType.Numeric),
        new JdeField("GBLITM", "GBLITM", JdeDataType.String, 50),
        new JdeField("GBAITM", "GBAITM", JdeDataType.String, 50),
        new JdeField("GBGPRC", "GBGPRC", JdeDataType.Numeric),
        new JdeField("GBUOM4", "GBUOM4", JdeDataType.String, 4),
        new JdeField("GBCRCD", "GBCRCD", JdeDataType.String, 6),
        new JdeField("GBCURREST", "GBCURREST", JdeDataType.Numeric),
        new JdeField("GBPLNEST", "GBPLNEST", JdeDataType.Numeric),
        new JdeField("GBQTYUOM", "GBQTYUOM", JdeDataType.String, 4),
        new JdeField("GBQTYLOAD", "GBQTYLOAD", JdeDataType.Numeric),
        new JdeField("GBCONTUOM", "GBCONTUOM", JdeDataType.String, 4),
        new JdeField("GBEXTRRTE", "GBEXTRRTE", JdeDataType.Numeric),
        new JdeField("GBTARQLTY", "GBTARQLTY", JdeDataType.String, 2),
        new JdeField("GBCURQLTY", "GBCURQLTY", JdeDataType.String, 2),
        new JdeField("GBHARPAT", "GBHARPAT", JdeDataType.String, 20),
        new JdeField("GBUCEF", "GBUCEF", JdeDataType.String, 2),
        new JdeField("GBMATCALID", "GBMATCALID", JdeDataType.Numeric),
        new JdeField("GBGROW01", "GBGROW01", JdeDataType.String, 6),
        new JdeField("GBGROW02", "GBGROW02", JdeDataType.String, 6),
        new JdeField("GBGROW03", "GBGROW03", JdeDataType.String, 6),
        new JdeField("GBGROW04", "GBGROW04", JdeDataType.String, 6),
        new JdeField("GBGROW05", "GBGROW05", JdeDataType.String, 6),
        new JdeField("GBGROW06", "GBGROW06", JdeDataType.String, 16),
        new JdeField("GBGROW07", "GBGROW07", JdeDataType.String, 16),
        new JdeField("GBGROW08", "GBGROW08", JdeDataType.String, 16),
        new JdeField("GBGROW09", "GBGROW09", JdeDataType.String, 16),
        new JdeField("GBGROW10", "GBGROW10", JdeDataType.String, 16),
        new JdeField("GBGROW11", "GBGROW11", JdeDataType.String, 20),
        new JdeField("GBGROW12", "GBGROW12", JdeDataType.String, 20),
        new JdeField("GBGROW13", "GBGROW13", JdeDataType.String, 20),
        new JdeField("GBGROW14", "GBGROW14", JdeDataType.String, 20),
        new JdeField("GBGROW15", "GBGROW15", JdeDataType.String, 20),
        new JdeField("GBCGROW01", "GBCGROW01", JdeDataType.String, 2),
        new JdeField("GBCGROW02", "GBCGROW02", JdeDataType.String, 2),
        new JdeField("GBCGROW03", "GBCGROW03", JdeDataType.String, 2),
        new JdeField("GBCGROW04", "GBCGROW04", JdeDataType.String, 2),
        new JdeField("GBCGROW05", "GBCGROW05", JdeDataType.String, 2),
        new JdeField("GBUGDATE01", "GBUGDATE01", JdeDataType.Date),
        new JdeField("GBUGDATE02", "GBUGDATE02", JdeDataType.Date),
        new JdeField("GBUGDATE03", "GBUGDATE03", JdeDataType.Date),
        new JdeField("GBUGDATE04", "GBUGDATE04", JdeDataType.Date),
        new JdeField("GBUGDATE05", "GBUGDATE05", JdeDataType.Date),
        new JdeField("GBUGDATE06", "GBUGDATE06", JdeDataType.Date),
        new JdeField("GBUGDATE07", "GBUGDATE07", JdeDataType.Date),
        new JdeField("GBUGDATE08", "GBUGDATE08", JdeDataType.Date),
        new JdeField("GBGNUM01", "GBGNUM01", JdeDataType.Numeric),
        new JdeField("GBGNUM02", "GBGNUM02", JdeDataType.Numeric),
        new JdeField("GBGNUM03", "GBGNUM03", JdeDataType.Numeric),
        new JdeField("GBGNUM04", "GBGNUM04", JdeDataType.Numeric),
        new JdeField("GBGNUM05", "GBGNUM05", JdeDataType.Numeric),
        new JdeField("GBURCD", "GBURCD", JdeDataType.String, 4),
        new JdeField("GBURDT", "GBURDT", JdeDataType.Numeric),
        new JdeField("GBURRF", "GBURRF", JdeDataType.String, 30),
        new JdeField("GBURAB", "GBURAB", JdeDataType.Numeric),
        new JdeField("GBURAT", "GBURAT", JdeDataType.Numeric),
        new JdeField("GBCRTU", "GBCRTU", JdeDataType.String, 20),
        new JdeField("GBTORG", "GBTORG", JdeDataType.String, 20),
        new JdeField("GBUSER", "GBUSER", JdeDataType.String, 20),
        new JdeField("GBPID", "GBPID", JdeDataType.String, 20),
        new JdeField("GBJOBN", "GBJOBN", JdeDataType.String, 20),
        new JdeField("GBUUPMJ", "GBUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G02_0", "Primary Key on GBBLUID", new[] { "GBBLUID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G02_2", "Index on GBBLSCD2", new[] { "GBBLSCD2" })
    };
}
