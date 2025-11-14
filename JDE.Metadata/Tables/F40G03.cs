using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G03 - .
/// </summary>
public class F40G03 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GHWVID.
        /// </summary>
        public const string GHWVID = "GHWVID";

        /// <summary>
        /// GHBLSCD2.
        /// </summary>
        public const string GHBLSCD2 = "GHBLSCD2";

        /// <summary>
        /// GHHARPER.
        /// </summary>
        public const string GHHARPER = "GHHARPER";

        /// <summary>
        /// GHHARSFX.
        /// </summary>
        public const string GHHARSFX = "GHHARSFX";

        /// <summary>
        /// GHHARNAME.
        /// </summary>
        public const string GHHARNAME = "GHHARNAME";

        /// <summary>
        /// GHHARSTS.
        /// </summary>
        public const string GHHARSTS = "GHHARSTS";

        /// <summary>
        /// GHBLUID.
        /// </summary>
        public const string GHBLUID = "GHBLUID";

        /// <summary>
        /// GHGRCMPCD.
        /// </summary>
        public const string GHGRCMPCD = "GHGRCMPCD";

        /// <summary>
        /// GHAN8GR.
        /// </summary>
        public const string GHAN8GR = "GHAN8GR";

        /// <summary>
        /// GHAN8BR.
        /// </summary>
        public const string GHAN8BR = "GHAN8BR";

        /// <summary>
        /// GHAN8CR.
        /// </summary>
        public const string GHAN8CR = "GHAN8CR";

        /// <summary>
        /// GHCURQLTY.
        /// </summary>
        public const string GHCURQLTY = "GHCURQLTY";

        /// <summary>
        /// GHTARQLTY.
        /// </summary>
        public const string GHTARQLTY = "GHTARQLTY";

        /// <summary>
        /// GHCSUPPLY.
        /// </summary>
        public const string GHCSUPPLY = "GHCSUPPLY";

        /// <summary>
        /// GHUPLNMAT.
        /// </summary>
        public const string GHUPLNMAT = "GHUPLNMAT";

        /// <summary>
        /// GHUTPMDLU.
        /// </summary>
        public const string GHUTPMDLU = "GHUTPMDLU";

        /// <summary>
        /// GHUCLCMAT.
        /// </summary>
        public const string GHUCLCMAT = "GHUCLCMAT";

        /// <summary>
        /// GHUTCMDLU.
        /// </summary>
        public const string GHUTCMDLU = "GHUTCMDLU";

        /// <summary>
        /// GHUCURDAT.
        /// </summary>
        public const string GHUCURDAT = "GHUCURDAT";

        /// <summary>
        /// GHCURREST.
        /// </summary>
        public const string GHCURREST = "GHCURREST";

        /// <summary>
        /// GHPLNEST.
        /// </summary>
        public const string GHPLNEST = "GHPLNEST";

        /// <summary>
        /// GHSCHQTY.
        /// </summary>
        public const string GHSCHQTY = "GHSCHQTY";

        /// <summary>
        /// GHRECVQTY.
        /// </summary>
        public const string GHRECVQTY = "GHRECVQTY";

        /// <summary>
        /// GHUCUTDAT.
        /// </summary>
        public const string GHUCUTDAT = "GHUCUTDAT";

        /// <summary>
        /// GHGEOCST.
        /// </summary>
        public const string GHGEOCST = "GHGEOCST";

        /// <summary>
        /// GHGOAID.
        /// </summary>
        public const string GHGOAID = "GHGOAID";

        /// <summary>
        /// GHGOAREA.
        /// </summary>
        public const string GHGOAREA = "GHGOAREA";

        /// <summary>
        /// GHAPPID.
        /// </summary>
        public const string GHAPPID = "GHAPPID";

        /// <summary>
        /// GHAPPLLAT.
        /// </summary>
        public const string GHAPPLLAT = "GHAPPLLAT";

        /// <summary>
        /// GHGREGION.
        /// </summary>
        public const string GHGREGION = "GHGREGION";

        /// <summary>
        /// GHGDISTR.
        /// </summary>
        public const string GHGDISTR = "GHGDISTR";

        /// <summary>
        /// GHADDS.
        /// </summary>
        public const string GHADDS = "GHADDS";

        /// <summary>
        /// GHCOUN.
        /// </summary>
        public const string GHCOUN = "GHCOUN";

        /// <summary>
        /// GHVARID.
        /// </summary>
        public const string GHVARID = "GHVARID";

        /// <summary>
        /// GHVARCODE.
        /// </summary>
        public const string GHVARCODE = "GHVARCODE";

        /// <summary>
        /// GHGRSAREA.
        /// </summary>
        public const string GHGRSAREA = "GHGRSAREA";

        /// <summary>
        /// GHPLTAREA.
        /// </summary>
        public const string GHPLTAREA = "GHPLTAREA";

        /// <summary>
        /// GHUPLTDAT.
        /// </summary>
        public const string GHUPLTDAT = "GHUPLTDAT";

        /// <summary>
        /// GHMATYP.
        /// </summary>
        public const string GHMATYP = "GHMATYP";

        /// <summary>
        /// GHSOILTYP.
        /// </summary>
        public const string GHSOILTYP = "GHSOILTYP";

        /// <summary>
        /// GHWATERTY.
        /// </summary>
        public const string GHWATERTY = "GHWATERTY";

        /// <summary>
        /// GHIVOL.
        /// </summary>
        public const string GHIVOL = "GHIVOL";

        /// <summary>
        /// GHPRUNEMT.
        /// </summary>
        public const string GHPRUNEMT = "GHPRUNEMT";

        /// <summary>
        /// GHCLONE.
        /// </summary>
        public const string GHCLONE = "GHCLONE";

        /// <summary>
        /// GHROOTSTK.
        /// </summary>
        public const string GHROOTSTK = "GHROOTSTK";

        /// <summary>
        /// GHROWSPC.
        /// </summary>
        public const string GHROWSPC = "GHROWSPC";

        /// <summary>
        /// GHPLTSPC.
        /// </summary>
        public const string GHPLTSPC = "GHPLTSPC";

        /// <summary>
        /// GHNOP.
        /// </summary>
        public const string GHNOP = "GHNOP";

        /// <summary>
        /// GHEXTRRTE.
        /// </summary>
        public const string GHEXTRRTE = "GHEXTRRTE";

        /// <summary>
        /// GHCONTUOM.
        /// </summary>
        public const string GHCONTUOM = "GHCONTUOM";

        /// <summary>
        /// GHQTYLOAD.
        /// </summary>
        public const string GHQTYLOAD = "GHQTYLOAD";

        /// <summary>
        /// GHHARVSD.
        /// </summary>
        public const string GHHARVSD = "GHHARVSD";

        /// <summary>
        /// GHHARVED.
        /// </summary>
        public const string GHHARVED = "GHHARVED";

        /// <summary>
        /// GHLSTLOAD.
        /// </summary>
        public const string GHLSTLOAD = "GHLSTLOAD";

        /// <summary>
        /// GHEXTRCMP.
        /// </summary>
        public const string GHEXTRCMP = "GHEXTRCMP";

        /// <summary>
        /// GHQUARANT.
        /// </summary>
        public const string GHQUARANT = "GHQUARANT";

        /// <summary>
        /// GHAN8V.
        /// </summary>
        public const string GHAN8V = "GHAN8V";

        /// <summary>
        /// GHAN8FARM.
        /// </summary>
        public const string GHAN8FARM = "GHAN8FARM";

        /// <summary>
        /// GHFARMCODE.
        /// </summary>
        public const string GHFARMCODE = "GHFARMCODE";

        /// <summary>
        /// GHFARMTYPE.
        /// </summary>
        public const string GHFARMTYPE = "GHFARMTYPE";

        /// <summary>
        /// GHCNTRTID.
        /// </summary>
        public const string GHCNTRTID = "GHCNTRTID";

        /// <summary>
        /// GHCNTRTDID.
        /// </summary>
        public const string GHCNTRTDID = "GHCNTRTDID";

        /// <summary>
        /// GHGPRC.
        /// </summary>
        public const string GHGPRC = "GHGPRC";

        /// <summary>
        /// GHHACOST.
        /// </summary>
        public const string GHHACOST = "GHHACOST";

        /// <summary>
        /// GHCOSTQTY.
        /// </summary>
        public const string GHCOSTQTY = "GHCOSTQTY";

        /// <summary>
        /// GHCSTAREA.
        /// </summary>
        public const string GHCSTAREA = "GHCSTAREA";

        /// <summary>
        /// GHOMCU.
        /// </summary>
        public const string GHOMCU = "GHOMCU";

        /// <summary>
        /// GHSITEC.
        /// </summary>
        public const string GHSITEC = "GHSITEC";

        /// <summary>
        /// GHSITEP.
        /// </summary>
        public const string GHSITEP = "GHSITEP";

        /// <summary>
        /// GHQTYUOM.
        /// </summary>
        public const string GHQTYUOM = "GHQTYUOM";

        /// <summary>
        /// GHAREAUOM.
        /// </summary>
        public const string GHAREAUOM = "GHAREAUOM";

        /// <summary>
        /// GHVOLUM.
        /// </summary>
        public const string GHVOLUM = "GHVOLUM";

        /// <summary>
        /// GHUOM4.
        /// </summary>
        public const string GHUOM4 = "GHUOM4";

        /// <summary>
        /// GHCRCD.
        /// </summary>
        public const string GHCRCD = "GHCRCD";

        /// <summary>
        /// GHWLOTN.
        /// </summary>
        public const string GHWLOTN = "GHWLOTN";

        /// <summary>
        /// GHMATCALID.
        /// </summary>
        public const string GHMATCALID = "GHMATCALID";

        /// <summary>
        /// GHGROW01.
        /// </summary>
        public const string GHGROW01 = "GHGROW01";

        /// <summary>
        /// GHGROW02.
        /// </summary>
        public const string GHGROW02 = "GHGROW02";

        /// <summary>
        /// GHGROW03.
        /// </summary>
        public const string GHGROW03 = "GHGROW03";

        /// <summary>
        /// GHGROW04.
        /// </summary>
        public const string GHGROW04 = "GHGROW04";

        /// <summary>
        /// GHGROW05.
        /// </summary>
        public const string GHGROW05 = "GHGROW05";

        /// <summary>
        /// GHGROW06.
        /// </summary>
        public const string GHGROW06 = "GHGROW06";

        /// <summary>
        /// GHGROW07.
        /// </summary>
        public const string GHGROW07 = "GHGROW07";

        /// <summary>
        /// GHGROW08.
        /// </summary>
        public const string GHGROW08 = "GHGROW08";

        /// <summary>
        /// GHGROW09.
        /// </summary>
        public const string GHGROW09 = "GHGROW09";

        /// <summary>
        /// GHGROW10.
        /// </summary>
        public const string GHGROW10 = "GHGROW10";

        /// <summary>
        /// GHGROW11.
        /// </summary>
        public const string GHGROW11 = "GHGROW11";

        /// <summary>
        /// GHGROW12.
        /// </summary>
        public const string GHGROW12 = "GHGROW12";

        /// <summary>
        /// GHGROW13.
        /// </summary>
        public const string GHGROW13 = "GHGROW13";

        /// <summary>
        /// GHGROW14.
        /// </summary>
        public const string GHGROW14 = "GHGROW14";

        /// <summary>
        /// GHGROW15.
        /// </summary>
        public const string GHGROW15 = "GHGROW15";

        /// <summary>
        /// GHGROW16.
        /// </summary>
        public const string GHGROW16 = "GHGROW16";

        /// <summary>
        /// GHCGROW01.
        /// </summary>
        public const string GHCGROW01 = "GHCGROW01";

        /// <summary>
        /// GHCGROW02.
        /// </summary>
        public const string GHCGROW02 = "GHCGROW02";

        /// <summary>
        /// GHCGROW03.
        /// </summary>
        public const string GHCGROW03 = "GHCGROW03";

        /// <summary>
        /// GHCGROW04.
        /// </summary>
        public const string GHCGROW04 = "GHCGROW04";

        /// <summary>
        /// GHCGROW05.
        /// </summary>
        public const string GHCGROW05 = "GHCGROW05";

        /// <summary>
        /// GHUGDATE01.
        /// </summary>
        public const string GHUGDATE01 = "GHUGDATE01";

        /// <summary>
        /// GHUGDATE02.
        /// </summary>
        public const string GHUGDATE02 = "GHUGDATE02";

        /// <summary>
        /// GHUGDATE03.
        /// </summary>
        public const string GHUGDATE03 = "GHUGDATE03";

        /// <summary>
        /// GHUGDATE04.
        /// </summary>
        public const string GHUGDATE04 = "GHUGDATE04";

        /// <summary>
        /// GHUGDATE05.
        /// </summary>
        public const string GHUGDATE05 = "GHUGDATE05";

        /// <summary>
        /// GHUGDATE06.
        /// </summary>
        public const string GHUGDATE06 = "GHUGDATE06";

        /// <summary>
        /// GHUGDATE07.
        /// </summary>
        public const string GHUGDATE07 = "GHUGDATE07";

        /// <summary>
        /// GHUGDATE08.
        /// </summary>
        public const string GHUGDATE08 = "GHUGDATE08";

        /// <summary>
        /// GHGNUM01.
        /// </summary>
        public const string GHGNUM01 = "GHGNUM01";

        /// <summary>
        /// GHGNUM02.
        /// </summary>
        public const string GHGNUM02 = "GHGNUM02";

        /// <summary>
        /// GHGNUM03.
        /// </summary>
        public const string GHGNUM03 = "GHGNUM03";

        /// <summary>
        /// GHGNUM04.
        /// </summary>
        public const string GHGNUM04 = "GHGNUM04";

        /// <summary>
        /// GHGNUM05.
        /// </summary>
        public const string GHGNUM05 = "GHGNUM05";

        /// <summary>
        /// GHGNUM06.
        /// </summary>
        public const string GHGNUM06 = "GHGNUM06";

        /// <summary>
        /// GHGNUM07.
        /// </summary>
        public const string GHGNUM07 = "GHGNUM07";

        /// <summary>
        /// GHDOCO.
        /// </summary>
        public const string GHDOCO = "GHDOCO";

        /// <summary>
        /// GHDCTO.
        /// </summary>
        public const string GHDCTO = "GHDCTO";

        /// <summary>
        /// GHSFXO.
        /// </summary>
        public const string GHSFXO = "GHSFXO";

        /// <summary>
        /// GHKCOO.
        /// </summary>
        public const string GHKCOO = "GHKCOO";

        /// <summary>
        /// GHLNID.
        /// </summary>
        public const string GHLNID = "GHLNID";

        /// <summary>
        /// GHURCD.
        /// </summary>
        public const string GHURCD = "GHURCD";

        /// <summary>
        /// GHURDT.
        /// </summary>
        public const string GHURDT = "GHURDT";

        /// <summary>
        /// GHURRF.
        /// </summary>
        public const string GHURRF = "GHURRF";

        /// <summary>
        /// GHURAB.
        /// </summary>
        public const string GHURAB = "GHURAB";

        /// <summary>
        /// GHURAT.
        /// </summary>
        public const string GHURAT = "GHURAT";

        /// <summary>
        /// GHUSER.
        /// </summary>
        public const string GHUSER = "GHUSER";

        /// <summary>
        /// GHPID.
        /// </summary>
        public const string GHPID = "GHPID";

        /// <summary>
        /// GHJOBN.
        /// </summary>
        public const string GHJOBN = "GHJOBN";

        /// <summary>
        /// GHTORG.
        /// </summary>
        public const string GHTORG = "GHTORG";

        /// <summary>
        /// GHUUPMJ.
        /// </summary>
        public const string GHUUPMJ = "GHUUPMJ";

        /// <summary>
        /// GHUCEF.
        /// </summary>
        public const string GHUCEF = "GHUCEF";

        /// <summary>
        /// GHCOMPQTY.
        /// </summary>
        public const string GHCOMPQTY = "GHCOMPQTY";

        /// <summary>
        /// GHOWNFG.
        /// </summary>
        public const string GHOWNFG = "GHOWNFG";
    }

    /// <inheritdoc />
    public override string TableName => "F40G03";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GHWVID", "GHWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("GHBLSCD2", "GHBLSCD2", JdeDataType.String, 20),
        new JdeField("GHHARPER", "GHHARPER", JdeDataType.String, 12),
        new JdeField("GHHARSFX", "GHHARSFX", JdeDataType.String, 20),
        new JdeField("GHHARNAME", "GHHARNAME", JdeDataType.String, 80),
        new JdeField("GHHARSTS", "GHHARSTS", JdeDataType.String, 2),
        new JdeField("GHBLUID", "GHBLUID", JdeDataType.Numeric),
        new JdeField("GHGRCMPCD", "GHGRCMPCD", JdeDataType.String, 20),
        new JdeField("GHAN8GR", "GHAN8GR", JdeDataType.Numeric),
        new JdeField("GHAN8BR", "GHAN8BR", JdeDataType.Numeric),
        new JdeField("GHAN8CR", "GHAN8CR", JdeDataType.Numeric),
        new JdeField("GHCURQLTY", "GHCURQLTY", JdeDataType.String, 2),
        new JdeField("GHTARQLTY", "GHTARQLTY", JdeDataType.String, 2),
        new JdeField("GHCSUPPLY", "GHCSUPPLY", JdeDataType.Numeric),
        new JdeField("GHUPLNMAT", "GHUPLNMAT", JdeDataType.Date),
        new JdeField("GHUTPMDLU", "GHUTPMDLU", JdeDataType.Date),
        new JdeField("GHUCLCMAT", "GHUCLCMAT", JdeDataType.Date),
        new JdeField("GHUTCMDLU", "GHUTCMDLU", JdeDataType.Date),
        new JdeField("GHUCURDAT", "GHUCURDAT", JdeDataType.Date),
        new JdeField("GHCURREST", "GHCURREST", JdeDataType.Numeric),
        new JdeField("GHPLNEST", "GHPLNEST", JdeDataType.Numeric),
        new JdeField("GHSCHQTY", "GHSCHQTY", JdeDataType.Numeric),
        new JdeField("GHRECVQTY", "GHRECVQTY", JdeDataType.Numeric),
        new JdeField("GHUCUTDAT", "GHUCUTDAT", JdeDataType.Date),
        new JdeField("GHGEOCST", "GHGEOCST", JdeDataType.String, 6),
        new JdeField("GHGOAID", "GHGOAID", JdeDataType.Numeric),
        new JdeField("GHGOAREA", "GHGOAREA", JdeDataType.String, 8),
        new JdeField("GHAPPID", "GHAPPID", JdeDataType.Numeric),
        new JdeField("GHAPPLLAT", "GHAPPLLAT", JdeDataType.String, 16),
        new JdeField("GHGREGION", "GHGREGION", JdeDataType.String, 20),
        new JdeField("GHGDISTR", "GHGDISTR", JdeDataType.String, 20),
        new JdeField("GHADDS", "GHADDS", JdeDataType.String, 6),
        new JdeField("GHCOUN", "GHCOUN", JdeDataType.String, 50),
        new JdeField("GHVARID", "GHVARID", JdeDataType.Numeric),
        new JdeField("GHVARCODE", "GHVARCODE", JdeDataType.String, 10),
        new JdeField("GHGRSAREA", "GHGRSAREA", JdeDataType.Numeric),
        new JdeField("GHPLTAREA", "GHPLTAREA", JdeDataType.Numeric),
        new JdeField("GHUPLTDAT", "GHUPLTDAT", JdeDataType.Date),
        new JdeField("GHMATYP", "GHMATYP", JdeDataType.String, 8),
        new JdeField("GHSOILTYP", "GHSOILTYP", JdeDataType.String, 4),
        new JdeField("GHWATERTY", "GHWATERTY", JdeDataType.String, 4),
        new JdeField("GHIVOL", "GHIVOL", JdeDataType.Numeric),
        new JdeField("GHPRUNEMT", "GHPRUNEMT", JdeDataType.String, 4),
        new JdeField("GHCLONE", "GHCLONE", JdeDataType.String, 4),
        new JdeField("GHROOTSTK", "GHROOTSTK", JdeDataType.String, 4),
        new JdeField("GHROWSPC", "GHROWSPC", JdeDataType.String, 4),
        new JdeField("GHPLTSPC", "GHPLTSPC", JdeDataType.String, 4),
        new JdeField("GHNOP", "GHNOP", JdeDataType.Numeric),
        new JdeField("GHEXTRRTE", "GHEXTRRTE", JdeDataType.Numeric),
        new JdeField("GHCONTUOM", "GHCONTUOM", JdeDataType.String, 4),
        new JdeField("GHQTYLOAD", "GHQTYLOAD", JdeDataType.Numeric),
        new JdeField("GHHARVSD", "GHHARVSD", JdeDataType.Date),
        new JdeField("GHHARVED", "GHHARVED", JdeDataType.Date),
        new JdeField("GHLSTLOAD", "GHLSTLOAD", JdeDataType.String, 2),
        new JdeField("GHEXTRCMP", "GHEXTRCMP", JdeDataType.String, 2),
        new JdeField("GHQUARANT", "GHQUARANT", JdeDataType.String, 2),
        new JdeField("GHAN8V", "GHAN8V", JdeDataType.Numeric),
        new JdeField("GHAN8FARM", "GHAN8FARM", JdeDataType.Numeric),
        new JdeField("GHFARMCODE", "GHFARMCODE", JdeDataType.String, 16),
        new JdeField("GHFARMTYPE", "GHFARMTYPE", JdeDataType.String, 2),
        new JdeField("GHCNTRTID", "GHCNTRTID", JdeDataType.Numeric),
        new JdeField("GHCNTRTDID", "GHCNTRTDID", JdeDataType.Numeric),
        new JdeField("GHGPRC", "GHGPRC", JdeDataType.Numeric),
        new JdeField("GHHACOST", "GHHACOST", JdeDataType.Numeric),
        new JdeField("GHCOSTQTY", "GHCOSTQTY", JdeDataType.Numeric),
        new JdeField("GHCSTAREA", "GHCSTAREA", JdeDataType.Numeric),
        new JdeField("GHOMCU", "GHOMCU", JdeDataType.String, 24),
        new JdeField("GHSITEC", "GHSITEC", JdeDataType.String, 24),
        new JdeField("GHSITEP", "GHSITEP", JdeDataType.String, 24),
        new JdeField("GHQTYUOM", "GHQTYUOM", JdeDataType.String, 4),
        new JdeField("GHAREAUOM", "GHAREAUOM", JdeDataType.String, 4),
        new JdeField("GHVOLUM", "GHVOLUM", JdeDataType.String, 4),
        new JdeField("GHUOM4", "GHUOM4", JdeDataType.String, 4),
        new JdeField("GHCRCD", "GHCRCD", JdeDataType.String, 6),
        new JdeField("GHWLOTN", "GHWLOTN", JdeDataType.String, 60),
        new JdeField("GHMATCALID", "GHMATCALID", JdeDataType.Numeric),
        new JdeField("GHGROW01", "GHGROW01", JdeDataType.String, 6),
        new JdeField("GHGROW02", "GHGROW02", JdeDataType.String, 6),
        new JdeField("GHGROW03", "GHGROW03", JdeDataType.String, 6),
        new JdeField("GHGROW04", "GHGROW04", JdeDataType.String, 6),
        new JdeField("GHGROW05", "GHGROW05", JdeDataType.String, 6),
        new JdeField("GHGROW06", "GHGROW06", JdeDataType.String, 16),
        new JdeField("GHGROW07", "GHGROW07", JdeDataType.String, 16),
        new JdeField("GHGROW08", "GHGROW08", JdeDataType.String, 16),
        new JdeField("GHGROW09", "GHGROW09", JdeDataType.String, 16),
        new JdeField("GHGROW10", "GHGROW10", JdeDataType.String, 16),
        new JdeField("GHGROW11", "GHGROW11", JdeDataType.String, 20),
        new JdeField("GHGROW12", "GHGROW12", JdeDataType.String, 20),
        new JdeField("GHGROW13", "GHGROW13", JdeDataType.String, 20),
        new JdeField("GHGROW14", "GHGROW14", JdeDataType.String, 20),
        new JdeField("GHGROW15", "GHGROW15", JdeDataType.String, 20),
        new JdeField("GHGROW16", "GHGROW16", JdeDataType.String, 20),
        new JdeField("GHCGROW01", "GHCGROW01", JdeDataType.String, 2),
        new JdeField("GHCGROW02", "GHCGROW02", JdeDataType.String, 2),
        new JdeField("GHCGROW03", "GHCGROW03", JdeDataType.String, 2),
        new JdeField("GHCGROW04", "GHCGROW04", JdeDataType.String, 2),
        new JdeField("GHCGROW05", "GHCGROW05", JdeDataType.String, 2),
        new JdeField("GHUGDATE01", "GHUGDATE01", JdeDataType.Date),
        new JdeField("GHUGDATE02", "GHUGDATE02", JdeDataType.Date),
        new JdeField("GHUGDATE03", "GHUGDATE03", JdeDataType.Date),
        new JdeField("GHUGDATE04", "GHUGDATE04", JdeDataType.Date),
        new JdeField("GHUGDATE05", "GHUGDATE05", JdeDataType.Date),
        new JdeField("GHUGDATE06", "GHUGDATE06", JdeDataType.Date),
        new JdeField("GHUGDATE07", "GHUGDATE07", JdeDataType.Date),
        new JdeField("GHUGDATE08", "GHUGDATE08", JdeDataType.Date),
        new JdeField("GHGNUM01", "GHGNUM01", JdeDataType.Numeric),
        new JdeField("GHGNUM02", "GHGNUM02", JdeDataType.Numeric),
        new JdeField("GHGNUM03", "GHGNUM03", JdeDataType.Numeric),
        new JdeField("GHGNUM04", "GHGNUM04", JdeDataType.Numeric),
        new JdeField("GHGNUM05", "GHGNUM05", JdeDataType.Numeric),
        new JdeField("GHGNUM06", "GHGNUM06", JdeDataType.Numeric),
        new JdeField("GHGNUM07", "GHGNUM07", JdeDataType.Numeric),
        new JdeField("GHDOCO", "GHDOCO", JdeDataType.Numeric),
        new JdeField("GHDCTO", "GHDCTO", JdeDataType.String, 4),
        new JdeField("GHSFXO", "GHSFXO", JdeDataType.String, 6),
        new JdeField("GHKCOO", "GHKCOO", JdeDataType.String, 10),
        new JdeField("GHLNID", "GHLNID", JdeDataType.Numeric),
        new JdeField("GHURCD", "GHURCD", JdeDataType.String, 4),
        new JdeField("GHURDT", "GHURDT", JdeDataType.Numeric),
        new JdeField("GHURRF", "GHURRF", JdeDataType.String, 30),
        new JdeField("GHURAB", "GHURAB", JdeDataType.Numeric),
        new JdeField("GHURAT", "GHURAT", JdeDataType.Numeric),
        new JdeField("GHUSER", "GHUSER", JdeDataType.String, 20),
        new JdeField("GHPID", "GHPID", JdeDataType.String, 20),
        new JdeField("GHJOBN", "GHJOBN", JdeDataType.String, 20),
        new JdeField("GHTORG", "GHTORG", JdeDataType.String, 20),
        new JdeField("GHUUPMJ", "GHUUPMJ", JdeDataType.Date),
        new JdeField("GHUCEF", "GHUCEF", JdeDataType.String, 2),
        new JdeField("GHCOMPQTY", "GHCOMPQTY", JdeDataType.Numeric),
        new JdeField("GHOWNFG", "GHOWNFG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G03_0", "Primary Key on GHWVID", new[] { "GHWVID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40G03_2", "Index on GHBLSCD2, GHHARPER, GHHARSFX", new[] { "GHBLSCD2", "GHHARPER", "GHHARSFX" }),
        new JdeIndex("F40G03_3", "Index on GHGEOCST, GHHARPER, GHBLSCD2, GHHARSFX", new[] { "GHGEOCST", "GHHARPER", "GHBLSCD2", "GHHARSFX" }),
        new JdeIndex("F40G03_4", "Index on GHCNTRTID, GHCNTRTDID", new[] { "GHCNTRTID", "GHCNTRTDID" }),
        new JdeIndex("F40G03_5", "Index on GHBLUID, GHHARPER, GHHARSFX", new[] { "GHBLUID", "GHHARPER", "GHHARSFX" })
    };
}
