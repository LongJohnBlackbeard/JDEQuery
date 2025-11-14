using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G0300 - .
/// </summary>
public class F40G0300 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HUHRUPID.
        /// </summary>
        public const string HUHRUPID = "HUHRUPID";

        /// <summary>
        /// HUHRUPDESC.
        /// </summary>
        public const string HUHRUPDESC = "HUHRUPDESC";

        /// <summary>
        /// HUUHARNAME.
        /// </summary>
        public const string HUUHARNAME = "HUUHARNAME";

        /// <summary>
        /// HUHARNAME.
        /// </summary>
        public const string HUHARNAME = "HUHARNAME";

        /// <summary>
        /// HUUHARSTS.
        /// </summary>
        public const string HUUHARSTS = "HUUHARSTS";

        /// <summary>
        /// HUHARSTS.
        /// </summary>
        public const string HUHARSTS = "HUHARSTS";

        /// <summary>
        /// HUUGRCMPCD.
        /// </summary>
        public const string HUUGRCMPCD = "HUUGRCMPCD";

        /// <summary>
        /// HUGRCMPCD.
        /// </summary>
        public const string HUGRCMPCD = "HUGRCMPCD";

        /// <summary>
        /// HUUAN8GR.
        /// </summary>
        public const string HUUAN8GR = "HUUAN8GR";

        /// <summary>
        /// HUAN8GR.
        /// </summary>
        public const string HUAN8GR = "HUAN8GR";

        /// <summary>
        /// HUUAN8BR.
        /// </summary>
        public const string HUUAN8BR = "HUUAN8BR";

        /// <summary>
        /// HUAN8BR.
        /// </summary>
        public const string HUAN8BR = "HUAN8BR";

        /// <summary>
        /// HUUAN8CR.
        /// </summary>
        public const string HUUAN8CR = "HUUAN8CR";

        /// <summary>
        /// HUAN8CR.
        /// </summary>
        public const string HUAN8CR = "HUAN8CR";

        /// <summary>
        /// HUUCURQLTY.
        /// </summary>
        public const string HUUCURQLTY = "HUUCURQLTY";

        /// <summary>
        /// HUCURQLTY.
        /// </summary>
        public const string HUCURQLTY = "HUCURQLTY";

        /// <summary>
        /// HUUTARQLTY.
        /// </summary>
        public const string HUUTARQLTY = "HUUTARQLTY";

        /// <summary>
        /// HUTARQLTY.
        /// </summary>
        public const string HUTARQLTY = "HUTARQLTY";

        /// <summary>
        /// HUUCSUPPLY.
        /// </summary>
        public const string HUUCSUPPLY = "HUUCSUPPLY";

        /// <summary>
        /// HUCSUPPLY.
        /// </summary>
        public const string HUCSUPPLY = "HUCSUPPLY";

        /// <summary>
        /// HUUUPLNMAT.
        /// </summary>
        public const string HUUUPLNMAT = "HUUUPLNMAT";

        /// <summary>
        /// HUUPLNMAT.
        /// </summary>
        public const string HUUPLNMAT = "HUUPLNMAT";

        /// <summary>
        /// HUUUCUTDAT.
        /// </summary>
        public const string HUUUCUTDAT = "HUUUCUTDAT";

        /// <summary>
        /// HUUCUTDAT.
        /// </summary>
        public const string HUUCUTDAT = "HUUCUTDAT";

        /// <summary>
        /// HUUPLNEST.
        /// </summary>
        public const string HUUPLNEST = "HUUPLNEST";

        /// <summary>
        /// HUPLNEST.
        /// </summary>
        public const string HUPLNEST = "HUPLNEST";

        /// <summary>
        /// HUUCURREST.
        /// </summary>
        public const string HUUCURREST = "HUUCURREST";

        /// <summary>
        /// HUCURREST.
        /// </summary>
        public const string HUCURREST = "HUCURREST";

        /// <summary>
        /// HUUUCURDAT.
        /// </summary>
        public const string HUUUCURDAT = "HUUUCURDAT";

        /// <summary>
        /// HUUCURDAT.
        /// </summary>
        public const string HUUCURDAT = "HUUCURDAT";

        /// <summary>
        /// HUUSCHQTY.
        /// </summary>
        public const string HUUSCHQTY = "HUUSCHQTY";

        /// <summary>
        /// HUSCHQTY.
        /// </summary>
        public const string HUSCHQTY = "HUSCHQTY";

        /// <summary>
        /// HUURECVQTY.
        /// </summary>
        public const string HUURECVQTY = "HUURECVQTY";

        /// <summary>
        /// HURECVQTY.
        /// </summary>
        public const string HURECVQTY = "HURECVQTY";

        /// <summary>
        /// HUUGOAREA.
        /// </summary>
        public const string HUUGOAREA = "HUUGOAREA";

        /// <summary>
        /// HUGOAREA.
        /// </summary>
        public const string HUGOAREA = "HUGOAREA";

        /// <summary>
        /// HUUAPPLLAT.
        /// </summary>
        public const string HUUAPPLLAT = "HUUAPPLLAT";

        /// <summary>
        /// HUAPPLLAT.
        /// </summary>
        public const string HUAPPLLAT = "HUAPPLLAT";

        /// <summary>
        /// HUUVARCODE.
        /// </summary>
        public const string HUUVARCODE = "HUUVARCODE";

        /// <summary>
        /// HUVARCODE.
        /// </summary>
        public const string HUVARCODE = "HUVARCODE";

        /// <summary>
        /// HUUGDISTR.
        /// </summary>
        public const string HUUGDISTR = "HUUGDISTR";

        /// <summary>
        /// HUGDISTR.
        /// </summary>
        public const string HUGDISTR = "HUGDISTR";

        /// <summary>
        /// HUUGREGION.
        /// </summary>
        public const string HUUGREGION = "HUUGREGION";

        /// <summary>
        /// HUGREGION.
        /// </summary>
        public const string HUGREGION = "HUGREGION";

        /// <summary>
        /// HUUCOUN.
        /// </summary>
        public const string HUUCOUN = "HUUCOUN";

        /// <summary>
        /// HUCOUN.
        /// </summary>
        public const string HUCOUN = "HUCOUN";

        /// <summary>
        /// HUUADDS.
        /// </summary>
        public const string HUUADDS = "HUUADDS";

        /// <summary>
        /// HUADDS.
        /// </summary>
        public const string HUADDS = "HUADDS";

        /// <summary>
        /// HUUMATYP.
        /// </summary>
        public const string HUUMATYP = "HUUMATYP";

        /// <summary>
        /// HUMATYP.
        /// </summary>
        public const string HUMATYP = "HUMATYP";

        /// <summary>
        /// HUUWATERTY.
        /// </summary>
        public const string HUUWATERTY = "HUUWATERTY";

        /// <summary>
        /// HUWATERTY.
        /// </summary>
        public const string HUWATERTY = "HUWATERTY";

        /// <summary>
        /// HUUIVOL.
        /// </summary>
        public const string HUUIVOL = "HUUIVOL";

        /// <summary>
        /// HUIVOL.
        /// </summary>
        public const string HUIVOL = "HUIVOL";

        /// <summary>
        /// HUUPRUNEMT.
        /// </summary>
        public const string HUUPRUNEMT = "HUUPRUNEMT";

        /// <summary>
        /// HUPRUNEMT.
        /// </summary>
        public const string HUPRUNEMT = "HUPRUNEMT";

        /// <summary>
        /// HUUSOILTYP.
        /// </summary>
        public const string HUUSOILTYP = "HUUSOILTYP";

        /// <summary>
        /// HUSOILTYP.
        /// </summary>
        public const string HUSOILTYP = "HUSOILTYP";

        /// <summary>
        /// HUUCLONE.
        /// </summary>
        public const string HUUCLONE = "HUUCLONE";

        /// <summary>
        /// HUCLONE.
        /// </summary>
        public const string HUCLONE = "HUCLONE";

        /// <summary>
        /// HUUROOTSTK.
        /// </summary>
        public const string HUUROOTSTK = "HUUROOTSTK";

        /// <summary>
        /// HUROOTSTK.
        /// </summary>
        public const string HUROOTSTK = "HUROOTSTK";

        /// <summary>
        /// HUUROWSPC.
        /// </summary>
        public const string HUUROWSPC = "HUUROWSPC";

        /// <summary>
        /// HUROWSPC.
        /// </summary>
        public const string HUROWSPC = "HUROWSPC";

        /// <summary>
        /// HUUPLTSPC.
        /// </summary>
        public const string HUUPLTSPC = "HUUPLTSPC";

        /// <summary>
        /// HUPLTSPC.
        /// </summary>
        public const string HUPLTSPC = "HUPLTSPC";

        /// <summary>
        /// HUUPDNOP.
        /// </summary>
        public const string HUUPDNOP = "HUUPDNOP";

        /// <summary>
        /// HUNOP.
        /// </summary>
        public const string HUNOP = "HUNOP";

        /// <summary>
        /// HUUPLTAREA.
        /// </summary>
        public const string HUUPLTAREA = "HUUPLTAREA";

        /// <summary>
        /// HUPLTAREA.
        /// </summary>
        public const string HUPLTAREA = "HUPLTAREA";

        /// <summary>
        /// HUUGRSAREA.
        /// </summary>
        public const string HUUGRSAREA = "HUUGRSAREA";

        /// <summary>
        /// HUGRSAREA.
        /// </summary>
        public const string HUGRSAREA = "HUGRSAREA";

        /// <summary>
        /// HUUUPLTDAT.
        /// </summary>
        public const string HUUUPLTDAT = "HUUUPLTDAT";

        /// <summary>
        /// HUUPLTDAT.
        /// </summary>
        public const string HUUPLTDAT = "HUUPLTDAT";

        /// <summary>
        /// HUUEXTRRTE.
        /// </summary>
        public const string HUUEXTRRTE = "HUUEXTRRTE";

        /// <summary>
        /// HUEXTRRTE.
        /// </summary>
        public const string HUEXTRRTE = "HUEXTRRTE";

        /// <summary>
        /// HUUCONTUOM.
        /// </summary>
        public const string HUUCONTUOM = "HUUCONTUOM";

        /// <summary>
        /// HUCONTUOM.
        /// </summary>
        public const string HUCONTUOM = "HUCONTUOM";

        /// <summary>
        /// HUUQTYLOAD.
        /// </summary>
        public const string HUUQTYLOAD = "HUUQTYLOAD";

        /// <summary>
        /// HUQTYLOAD.
        /// </summary>
        public const string HUQTYLOAD = "HUQTYLOAD";

        /// <summary>
        /// HUULSTLOAD.
        /// </summary>
        public const string HUULSTLOAD = "HUULSTLOAD";

        /// <summary>
        /// HULSTLOAD.
        /// </summary>
        public const string HULSTLOAD = "HULSTLOAD";

        /// <summary>
        /// HUUEXTRCMP.
        /// </summary>
        public const string HUUEXTRCMP = "HUUEXTRCMP";

        /// <summary>
        /// HUEXTRCMP.
        /// </summary>
        public const string HUEXTRCMP = "HUEXTRCMP";

        /// <summary>
        /// HUUQUARANT.
        /// </summary>
        public const string HUUQUARANT = "HUUQUARANT";

        /// <summary>
        /// HUQUARANT.
        /// </summary>
        public const string HUQUARANT = "HUQUARANT";

        /// <summary>
        /// HUUGROW01.
        /// </summary>
        public const string HUUGROW01 = "HUUGROW01";

        /// <summary>
        /// HUGROW01.
        /// </summary>
        public const string HUGROW01 = "HUGROW01";

        /// <summary>
        /// HUUGROW02.
        /// </summary>
        public const string HUUGROW02 = "HUUGROW02";

        /// <summary>
        /// HUGROW02.
        /// </summary>
        public const string HUGROW02 = "HUGROW02";

        /// <summary>
        /// HUUGROW03.
        /// </summary>
        public const string HUUGROW03 = "HUUGROW03";

        /// <summary>
        /// HUGROW03.
        /// </summary>
        public const string HUGROW03 = "HUGROW03";

        /// <summary>
        /// HUUGROW04.
        /// </summary>
        public const string HUUGROW04 = "HUUGROW04";

        /// <summary>
        /// HUGROW04.
        /// </summary>
        public const string HUGROW04 = "HUGROW04";

        /// <summary>
        /// HUUGROW05.
        /// </summary>
        public const string HUUGROW05 = "HUUGROW05";

        /// <summary>
        /// HUGROW05.
        /// </summary>
        public const string HUGROW05 = "HUGROW05";

        /// <summary>
        /// HUUGROW06.
        /// </summary>
        public const string HUUGROW06 = "HUUGROW06";

        /// <summary>
        /// HUGROW06.
        /// </summary>
        public const string HUGROW06 = "HUGROW06";

        /// <summary>
        /// HUUGROW07.
        /// </summary>
        public const string HUUGROW07 = "HUUGROW07";

        /// <summary>
        /// HUGROW07.
        /// </summary>
        public const string HUGROW07 = "HUGROW07";

        /// <summary>
        /// HUUGROW08.
        /// </summary>
        public const string HUUGROW08 = "HUUGROW08";

        /// <summary>
        /// HUGROW08.
        /// </summary>
        public const string HUGROW08 = "HUGROW08";

        /// <summary>
        /// HUUGROW09.
        /// </summary>
        public const string HUUGROW09 = "HUUGROW09";

        /// <summary>
        /// HUGROW09.
        /// </summary>
        public const string HUGROW09 = "HUGROW09";

        /// <summary>
        /// HUUGROW10.
        /// </summary>
        public const string HUUGROW10 = "HUUGROW10";

        /// <summary>
        /// HUGROW10.
        /// </summary>
        public const string HUGROW10 = "HUGROW10";

        /// <summary>
        /// HUUGROW11.
        /// </summary>
        public const string HUUGROW11 = "HUUGROW11";

        /// <summary>
        /// HUGROW11.
        /// </summary>
        public const string HUGROW11 = "HUGROW11";

        /// <summary>
        /// HUUGROW12.
        /// </summary>
        public const string HUUGROW12 = "HUUGROW12";

        /// <summary>
        /// HUGROW12.
        /// </summary>
        public const string HUGROW12 = "HUGROW12";

        /// <summary>
        /// HUUGROW13.
        /// </summary>
        public const string HUUGROW13 = "HUUGROW13";

        /// <summary>
        /// HUGROW13.
        /// </summary>
        public const string HUGROW13 = "HUGROW13";

        /// <summary>
        /// HUUGROW14.
        /// </summary>
        public const string HUUGROW14 = "HUUGROW14";

        /// <summary>
        /// HUGROW14.
        /// </summary>
        public const string HUGROW14 = "HUGROW14";

        /// <summary>
        /// HUUGROW15.
        /// </summary>
        public const string HUUGROW15 = "HUUGROW15";

        /// <summary>
        /// HUGROW15.
        /// </summary>
        public const string HUGROW15 = "HUGROW15";

        /// <summary>
        /// HUUUGDAT01.
        /// </summary>
        public const string HUUUGDAT01 = "HUUUGDAT01";

        /// <summary>
        /// HUUGDATE01.
        /// </summary>
        public const string HUUGDATE01 = "HUUGDATE01";

        /// <summary>
        /// HUUUGDAT02.
        /// </summary>
        public const string HUUUGDAT02 = "HUUUGDAT02";

        /// <summary>
        /// HUUGDATE02.
        /// </summary>
        public const string HUUGDATE02 = "HUUGDATE02";

        /// <summary>
        /// HUUUGDAT03.
        /// </summary>
        public const string HUUUGDAT03 = "HUUUGDAT03";

        /// <summary>
        /// HUUGDATE03.
        /// </summary>
        public const string HUUGDATE03 = "HUUGDATE03";

        /// <summary>
        /// HUUUGDAT04.
        /// </summary>
        public const string HUUUGDAT04 = "HUUUGDAT04";

        /// <summary>
        /// HUUGDATE04.
        /// </summary>
        public const string HUUGDATE04 = "HUUGDATE04";

        /// <summary>
        /// HUUUGDAT05.
        /// </summary>
        public const string HUUUGDAT05 = "HUUUGDAT05";

        /// <summary>
        /// HUUGDATE05.
        /// </summary>
        public const string HUUGDATE05 = "HUUGDATE05";

        /// <summary>
        /// HUUUGDAT06.
        /// </summary>
        public const string HUUUGDAT06 = "HUUUGDAT06";

        /// <summary>
        /// HUUGDATE06.
        /// </summary>
        public const string HUUGDATE06 = "HUUGDATE06";

        /// <summary>
        /// HUUUGDAT07.
        /// </summary>
        public const string HUUUGDAT07 = "HUUUGDAT07";

        /// <summary>
        /// HUUGDATE07.
        /// </summary>
        public const string HUUGDATE07 = "HUUGDATE07";

        /// <summary>
        /// HUUUGDAT08.
        /// </summary>
        public const string HUUUGDAT08 = "HUUUGDAT08";

        /// <summary>
        /// HUUGDATE08.
        /// </summary>
        public const string HUUGDATE08 = "HUUGDATE08";

        /// <summary>
        /// HUUGNUM01.
        /// </summary>
        public const string HUUGNUM01 = "HUUGNUM01";

        /// <summary>
        /// HUGNUM01.
        /// </summary>
        public const string HUGNUM01 = "HUGNUM01";

        /// <summary>
        /// HUUGNUM02.
        /// </summary>
        public const string HUUGNUM02 = "HUUGNUM02";

        /// <summary>
        /// HUGNUM02.
        /// </summary>
        public const string HUGNUM02 = "HUGNUM02";

        /// <summary>
        /// HUUGNUM03.
        /// </summary>
        public const string HUUGNUM03 = "HUUGNUM03";

        /// <summary>
        /// HUGNUM03.
        /// </summary>
        public const string HUGNUM03 = "HUGNUM03";

        /// <summary>
        /// HUUGNUM04.
        /// </summary>
        public const string HUUGNUM04 = "HUUGNUM04";

        /// <summary>
        /// HUGNUM04.
        /// </summary>
        public const string HUGNUM04 = "HUGNUM04";

        /// <summary>
        /// HUUGNUM05.
        /// </summary>
        public const string HUUGNUM05 = "HUUGNUM05";

        /// <summary>
        /// HUGNUM05.
        /// </summary>
        public const string HUGNUM05 = "HUGNUM05";

        /// <summary>
        /// HUUGNUM06.
        /// </summary>
        public const string HUUGNUM06 = "HUUGNUM06";

        /// <summary>
        /// HUGNUM06.
        /// </summary>
        public const string HUGNUM06 = "HUGNUM06";

        /// <summary>
        /// HUUCGROW01.
        /// </summary>
        public const string HUUCGROW01 = "HUUCGROW01";

        /// <summary>
        /// HUCGROW01.
        /// </summary>
        public const string HUCGROW01 = "HUCGROW01";

        /// <summary>
        /// HUUCGROW02.
        /// </summary>
        public const string HUUCGROW02 = "HUUCGROW02";

        /// <summary>
        /// HUCGROW02.
        /// </summary>
        public const string HUCGROW02 = "HUCGROW02";

        /// <summary>
        /// HUUCGROW03.
        /// </summary>
        public const string HUUCGROW03 = "HUUCGROW03";

        /// <summary>
        /// HUCGROW03.
        /// </summary>
        public const string HUCGROW03 = "HUCGROW03";

        /// <summary>
        /// HUUCGROW04.
        /// </summary>
        public const string HUUCGROW04 = "HUUCGROW04";

        /// <summary>
        /// HUCGROW04.
        /// </summary>
        public const string HUCGROW04 = "HUCGROW04";

        /// <summary>
        /// HUUCGROW05.
        /// </summary>
        public const string HUUCGROW05 = "HUUCGROW05";

        /// <summary>
        /// HUCGROW05.
        /// </summary>
        public const string HUCGROW05 = "HUCGROW05";

        /// <summary>
        /// HUUGPRC.
        /// </summary>
        public const string HUUGPRC = "HUUGPRC";

        /// <summary>
        /// HUGPRC.
        /// </summary>
        public const string HUGPRC = "HUGPRC";

        /// <summary>
        /// HUUAN8V.
        /// </summary>
        public const string HUUAN8V = "HUUAN8V";

        /// <summary>
        /// HUAN8V.
        /// </summary>
        public const string HUAN8V = "HUAN8V";

        /// <summary>
        /// HUUPTMATNM.
        /// </summary>
        public const string HUUPTMATNM = "HUUPTMATNM";

        /// <summary>
        /// HUMATCALID.
        /// </summary>
        public const string HUMATCALID = "HUMATCALID";

        /// <summary>
        /// HURECALMAT.
        /// </summary>
        public const string HURECALMAT = "HURECALMAT";

        /// <summary>
        /// HUURCD.
        /// </summary>
        public const string HUURCD = "HUURCD";

        /// <summary>
        /// HUURDT.
        /// </summary>
        public const string HUURDT = "HUURDT";

        /// <summary>
        /// HUURRF.
        /// </summary>
        public const string HUURRF = "HUURRF";

        /// <summary>
        /// HUURAB.
        /// </summary>
        public const string HUURAB = "HUURAB";

        /// <summary>
        /// HUURAT.
        /// </summary>
        public const string HUURAT = "HUURAT";

        /// <summary>
        /// HUTORG.
        /// </summary>
        public const string HUTORG = "HUTORG";

        /// <summary>
        /// HUUSER.
        /// </summary>
        public const string HUUSER = "HUUSER";

        /// <summary>
        /// HUPID.
        /// </summary>
        public const string HUPID = "HUPID";

        /// <summary>
        /// HUJOBN.
        /// </summary>
        public const string HUJOBN = "HUJOBN";

        /// <summary>
        /// HUUUPMJ.
        /// </summary>
        public const string HUUUPMJ = "HUUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G0300";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HUHRUPID", "HUHRUPID", JdeDataType.Numeric, null, true, true),
        new JdeField("HUHRUPDESC", "HUHRUPDESC", JdeDataType.String, 80),
        new JdeField("HUUHARNAME", "HUUHARNAME", JdeDataType.String, 2),
        new JdeField("HUHARNAME", "HUHARNAME", JdeDataType.String, 80),
        new JdeField("HUUHARSTS", "HUUHARSTS", JdeDataType.String, 2),
        new JdeField("HUHARSTS", "HUHARSTS", JdeDataType.String, 2),
        new JdeField("HUUGRCMPCD", "HUUGRCMPCD", JdeDataType.String, 2),
        new JdeField("HUGRCMPCD", "HUGRCMPCD", JdeDataType.String, 20),
        new JdeField("HUUAN8GR", "HUUAN8GR", JdeDataType.String, 2),
        new JdeField("HUAN8GR", "HUAN8GR", JdeDataType.Numeric),
        new JdeField("HUUAN8BR", "HUUAN8BR", JdeDataType.String, 2),
        new JdeField("HUAN8BR", "HUAN8BR", JdeDataType.Numeric),
        new JdeField("HUUAN8CR", "HUUAN8CR", JdeDataType.String, 2),
        new JdeField("HUAN8CR", "HUAN8CR", JdeDataType.Numeric),
        new JdeField("HUUCURQLTY", "HUUCURQLTY", JdeDataType.String, 2),
        new JdeField("HUCURQLTY", "HUCURQLTY", JdeDataType.String, 2),
        new JdeField("HUUTARQLTY", "HUUTARQLTY", JdeDataType.String, 2),
        new JdeField("HUTARQLTY", "HUTARQLTY", JdeDataType.String, 2),
        new JdeField("HUUCSUPPLY", "HUUCSUPPLY", JdeDataType.String, 2),
        new JdeField("HUCSUPPLY", "HUCSUPPLY", JdeDataType.Numeric),
        new JdeField("HUUUPLNMAT", "HUUUPLNMAT", JdeDataType.String, 2),
        new JdeField("HUUPLNMAT", "HUUPLNMAT", JdeDataType.Date),
        new JdeField("HUUUCUTDAT", "HUUUCUTDAT", JdeDataType.String, 2),
        new JdeField("HUUCUTDAT", "HUUCUTDAT", JdeDataType.Date),
        new JdeField("HUUPLNEST", "HUUPLNEST", JdeDataType.String, 2),
        new JdeField("HUPLNEST", "HUPLNEST", JdeDataType.Numeric),
        new JdeField("HUUCURREST", "HUUCURREST", JdeDataType.String, 2),
        new JdeField("HUCURREST", "HUCURREST", JdeDataType.Numeric),
        new JdeField("HUUUCURDAT", "HUUUCURDAT", JdeDataType.String, 2),
        new JdeField("HUUCURDAT", "HUUCURDAT", JdeDataType.Date),
        new JdeField("HUUSCHQTY", "HUUSCHQTY", JdeDataType.String, 2),
        new JdeField("HUSCHQTY", "HUSCHQTY", JdeDataType.Numeric),
        new JdeField("HUURECVQTY", "HUURECVQTY", JdeDataType.String, 2),
        new JdeField("HURECVQTY", "HURECVQTY", JdeDataType.Numeric),
        new JdeField("HUUGOAREA", "HUUGOAREA", JdeDataType.String, 2),
        new JdeField("HUGOAREA", "HUGOAREA", JdeDataType.String, 8),
        new JdeField("HUUAPPLLAT", "HUUAPPLLAT", JdeDataType.String, 2),
        new JdeField("HUAPPLLAT", "HUAPPLLAT", JdeDataType.String, 16),
        new JdeField("HUUVARCODE", "HUUVARCODE", JdeDataType.String, 2),
        new JdeField("HUVARCODE", "HUVARCODE", JdeDataType.String, 10),
        new JdeField("HUUGDISTR", "HUUGDISTR", JdeDataType.String, 2),
        new JdeField("HUGDISTR", "HUGDISTR", JdeDataType.String, 20),
        new JdeField("HUUGREGION", "HUUGREGION", JdeDataType.String, 2),
        new JdeField("HUGREGION", "HUGREGION", JdeDataType.String, 20),
        new JdeField("HUUCOUN", "HUUCOUN", JdeDataType.String, 2),
        new JdeField("HUCOUN", "HUCOUN", JdeDataType.String, 50),
        new JdeField("HUUADDS", "HUUADDS", JdeDataType.String, 2),
        new JdeField("HUADDS", "HUADDS", JdeDataType.String, 6),
        new JdeField("HUUMATYP", "HUUMATYP", JdeDataType.String, 2),
        new JdeField("HUMATYP", "HUMATYP", JdeDataType.String, 8),
        new JdeField("HUUWATERTY", "HUUWATERTY", JdeDataType.String, 2),
        new JdeField("HUWATERTY", "HUWATERTY", JdeDataType.String, 4),
        new JdeField("HUUIVOL", "HUUIVOL", JdeDataType.String, 2),
        new JdeField("HUIVOL", "HUIVOL", JdeDataType.Numeric),
        new JdeField("HUUPRUNEMT", "HUUPRUNEMT", JdeDataType.String, 2),
        new JdeField("HUPRUNEMT", "HUPRUNEMT", JdeDataType.String, 4),
        new JdeField("HUUSOILTYP", "HUUSOILTYP", JdeDataType.String, 2),
        new JdeField("HUSOILTYP", "HUSOILTYP", JdeDataType.String, 4),
        new JdeField("HUUCLONE", "HUUCLONE", JdeDataType.String, 2),
        new JdeField("HUCLONE", "HUCLONE", JdeDataType.String, 4),
        new JdeField("HUUROOTSTK", "HUUROOTSTK", JdeDataType.String, 2),
        new JdeField("HUROOTSTK", "HUROOTSTK", JdeDataType.String, 4),
        new JdeField("HUUROWSPC", "HUUROWSPC", JdeDataType.String, 2),
        new JdeField("HUROWSPC", "HUROWSPC", JdeDataType.String, 4),
        new JdeField("HUUPLTSPC", "HUUPLTSPC", JdeDataType.String, 2),
        new JdeField("HUPLTSPC", "HUPLTSPC", JdeDataType.String, 4),
        new JdeField("HUUPDNOP", "HUUPDNOP", JdeDataType.String, 2),
        new JdeField("HUNOP", "HUNOP", JdeDataType.Numeric),
        new JdeField("HUUPLTAREA", "HUUPLTAREA", JdeDataType.String, 2),
        new JdeField("HUPLTAREA", "HUPLTAREA", JdeDataType.Numeric),
        new JdeField("HUUGRSAREA", "HUUGRSAREA", JdeDataType.String, 2),
        new JdeField("HUGRSAREA", "HUGRSAREA", JdeDataType.Numeric),
        new JdeField("HUUUPLTDAT", "HUUUPLTDAT", JdeDataType.String, 2),
        new JdeField("HUUPLTDAT", "HUUPLTDAT", JdeDataType.Date),
        new JdeField("HUUEXTRRTE", "HUUEXTRRTE", JdeDataType.String, 2),
        new JdeField("HUEXTRRTE", "HUEXTRRTE", JdeDataType.Numeric),
        new JdeField("HUUCONTUOM", "HUUCONTUOM", JdeDataType.String, 2),
        new JdeField("HUCONTUOM", "HUCONTUOM", JdeDataType.String, 4),
        new JdeField("HUUQTYLOAD", "HUUQTYLOAD", JdeDataType.String, 2),
        new JdeField("HUQTYLOAD", "HUQTYLOAD", JdeDataType.Numeric),
        new JdeField("HUULSTLOAD", "HUULSTLOAD", JdeDataType.String, 2),
        new JdeField("HULSTLOAD", "HULSTLOAD", JdeDataType.String, 2),
        new JdeField("HUUEXTRCMP", "HUUEXTRCMP", JdeDataType.String, 2),
        new JdeField("HUEXTRCMP", "HUEXTRCMP", JdeDataType.String, 2),
        new JdeField("HUUQUARANT", "HUUQUARANT", JdeDataType.String, 2),
        new JdeField("HUQUARANT", "HUQUARANT", JdeDataType.String, 2),
        new JdeField("HUUGROW01", "HUUGROW01", JdeDataType.String, 2),
        new JdeField("HUGROW01", "HUGROW01", JdeDataType.String, 6),
        new JdeField("HUUGROW02", "HUUGROW02", JdeDataType.String, 2),
        new JdeField("HUGROW02", "HUGROW02", JdeDataType.String, 6),
        new JdeField("HUUGROW03", "HUUGROW03", JdeDataType.String, 2),
        new JdeField("HUGROW03", "HUGROW03", JdeDataType.String, 6),
        new JdeField("HUUGROW04", "HUUGROW04", JdeDataType.String, 2),
        new JdeField("HUGROW04", "HUGROW04", JdeDataType.String, 6),
        new JdeField("HUUGROW05", "HUUGROW05", JdeDataType.String, 2),
        new JdeField("HUGROW05", "HUGROW05", JdeDataType.String, 6),
        new JdeField("HUUGROW06", "HUUGROW06", JdeDataType.String, 2),
        new JdeField("HUGROW06", "HUGROW06", JdeDataType.String, 16),
        new JdeField("HUUGROW07", "HUUGROW07", JdeDataType.String, 2),
        new JdeField("HUGROW07", "HUGROW07", JdeDataType.String, 16),
        new JdeField("HUUGROW08", "HUUGROW08", JdeDataType.String, 2),
        new JdeField("HUGROW08", "HUGROW08", JdeDataType.String, 16),
        new JdeField("HUUGROW09", "HUUGROW09", JdeDataType.String, 2),
        new JdeField("HUGROW09", "HUGROW09", JdeDataType.String, 16),
        new JdeField("HUUGROW10", "HUUGROW10", JdeDataType.String, 2),
        new JdeField("HUGROW10", "HUGROW10", JdeDataType.String, 16),
        new JdeField("HUUGROW11", "HUUGROW11", JdeDataType.String, 2),
        new JdeField("HUGROW11", "HUGROW11", JdeDataType.String, 20),
        new JdeField("HUUGROW12", "HUUGROW12", JdeDataType.String, 2),
        new JdeField("HUGROW12", "HUGROW12", JdeDataType.String, 20),
        new JdeField("HUUGROW13", "HUUGROW13", JdeDataType.String, 2),
        new JdeField("HUGROW13", "HUGROW13", JdeDataType.String, 20),
        new JdeField("HUUGROW14", "HUUGROW14", JdeDataType.String, 2),
        new JdeField("HUGROW14", "HUGROW14", JdeDataType.String, 20),
        new JdeField("HUUGROW15", "HUUGROW15", JdeDataType.String, 2),
        new JdeField("HUGROW15", "HUGROW15", JdeDataType.String, 20),
        new JdeField("HUUUGDAT01", "HUUUGDAT01", JdeDataType.String, 2),
        new JdeField("HUUGDATE01", "HUUGDATE01", JdeDataType.Date),
        new JdeField("HUUUGDAT02", "HUUUGDAT02", JdeDataType.String, 2),
        new JdeField("HUUGDATE02", "HUUGDATE02", JdeDataType.Date),
        new JdeField("HUUUGDAT03", "HUUUGDAT03", JdeDataType.String, 2),
        new JdeField("HUUGDATE03", "HUUGDATE03", JdeDataType.Date),
        new JdeField("HUUUGDAT04", "HUUUGDAT04", JdeDataType.String, 2),
        new JdeField("HUUGDATE04", "HUUGDATE04", JdeDataType.Date),
        new JdeField("HUUUGDAT05", "HUUUGDAT05", JdeDataType.String, 2),
        new JdeField("HUUGDATE05", "HUUGDATE05", JdeDataType.Date),
        new JdeField("HUUUGDAT06", "HUUUGDAT06", JdeDataType.String, 2),
        new JdeField("HUUGDATE06", "HUUGDATE06", JdeDataType.Date),
        new JdeField("HUUUGDAT07", "HUUUGDAT07", JdeDataType.String, 2),
        new JdeField("HUUGDATE07", "HUUGDATE07", JdeDataType.Date),
        new JdeField("HUUUGDAT08", "HUUUGDAT08", JdeDataType.String, 2),
        new JdeField("HUUGDATE08", "HUUGDATE08", JdeDataType.Date),
        new JdeField("HUUGNUM01", "HUUGNUM01", JdeDataType.String, 2),
        new JdeField("HUGNUM01", "HUGNUM01", JdeDataType.Numeric),
        new JdeField("HUUGNUM02", "HUUGNUM02", JdeDataType.String, 2),
        new JdeField("HUGNUM02", "HUGNUM02", JdeDataType.Numeric),
        new JdeField("HUUGNUM03", "HUUGNUM03", JdeDataType.String, 2),
        new JdeField("HUGNUM03", "HUGNUM03", JdeDataType.Numeric),
        new JdeField("HUUGNUM04", "HUUGNUM04", JdeDataType.String, 2),
        new JdeField("HUGNUM04", "HUGNUM04", JdeDataType.Numeric),
        new JdeField("HUUGNUM05", "HUUGNUM05", JdeDataType.String, 2),
        new JdeField("HUGNUM05", "HUGNUM05", JdeDataType.Numeric),
        new JdeField("HUUGNUM06", "HUUGNUM06", JdeDataType.String, 2),
        new JdeField("HUGNUM06", "HUGNUM06", JdeDataType.Numeric),
        new JdeField("HUUCGROW01", "HUUCGROW01", JdeDataType.String, 2),
        new JdeField("HUCGROW01", "HUCGROW01", JdeDataType.String, 2),
        new JdeField("HUUCGROW02", "HUUCGROW02", JdeDataType.String, 2),
        new JdeField("HUCGROW02", "HUCGROW02", JdeDataType.String, 2),
        new JdeField("HUUCGROW03", "HUUCGROW03", JdeDataType.String, 2),
        new JdeField("HUCGROW03", "HUCGROW03", JdeDataType.String, 2),
        new JdeField("HUUCGROW04", "HUUCGROW04", JdeDataType.String, 2),
        new JdeField("HUCGROW04", "HUCGROW04", JdeDataType.String, 2),
        new JdeField("HUUCGROW05", "HUUCGROW05", JdeDataType.String, 2),
        new JdeField("HUCGROW05", "HUCGROW05", JdeDataType.String, 2),
        new JdeField("HUUGPRC", "HUUGPRC", JdeDataType.String, 2),
        new JdeField("HUGPRC", "HUGPRC", JdeDataType.Numeric),
        new JdeField("HUUAN8V", "HUUAN8V", JdeDataType.String, 2),
        new JdeField("HUAN8V", "HUAN8V", JdeDataType.Numeric),
        new JdeField("HUUPTMATNM", "HUUPTMATNM", JdeDataType.String, 2),
        new JdeField("HUMATCALID", "HUMATCALID", JdeDataType.Numeric),
        new JdeField("HURECALMAT", "HURECALMAT", JdeDataType.String, 2),
        new JdeField("HUURCD", "HUURCD", JdeDataType.String, 4),
        new JdeField("HUURDT", "HUURDT", JdeDataType.Numeric),
        new JdeField("HUURRF", "HUURRF", JdeDataType.String, 30),
        new JdeField("HUURAB", "HUURAB", JdeDataType.Numeric),
        new JdeField("HUURAT", "HUURAT", JdeDataType.Numeric),
        new JdeField("HUTORG", "HUTORG", JdeDataType.String, 20),
        new JdeField("HUUSER", "HUUSER", JdeDataType.String, 20),
        new JdeField("HUPID", "HUPID", JdeDataType.String, 20),
        new JdeField("HUJOBN", "HUJOBN", JdeDataType.String, 20),
        new JdeField("HUUUPMJ", "HUUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G0300_0", "Primary Key on HUHRUPID", new[] { "HUHRUPID" }, isUnique: true, isPrimaryKey: true)
    };
}
