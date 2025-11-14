using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40G0200 - .
/// </summary>
public class F40G0200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BUBLUPID.
        /// </summary>
        public const string BUBLUPID = "BUBLUPID";

        /// <summary>
        /// BUBLUPDESC.
        /// </summary>
        public const string BUBLUPDESC = "BUBLUPDESC";

        /// <summary>
        /// BUUFRMCODE.
        /// </summary>
        public const string BUUFRMCODE = "BUUFRMCODE";

        /// <summary>
        /// BUFARMCODE.
        /// </summary>
        public const string BUFARMCODE = "BUFARMCODE";

        /// <summary>
        /// BUUBLNAM.
        /// </summary>
        public const string BUUBLNAM = "BUUBLNAM";

        /// <summary>
        /// BUBLNAM.
        /// </summary>
        public const string BUBLNAM = "BUBLNAM";

        /// <summary>
        /// BUUBLTYPE.
        /// </summary>
        public const string BUUBLTYPE = "BUUBLTYPE";

        /// <summary>
        /// BUBLTYPE.
        /// </summary>
        public const string BUBLTYPE = "BUBLTYPE";

        /// <summary>
        /// BUUGRCMPCD.
        /// </summary>
        public const string BUUGRCMPCD = "BUUGRCMPCD";

        /// <summary>
        /// BUGRCMPCD.
        /// </summary>
        public const string BUGRCMPCD = "BUGRCMPCD";

        /// <summary>
        /// BUUAN8GR.
        /// </summary>
        public const string BUUAN8GR = "BUUAN8GR";

        /// <summary>
        /// BUAN8GR.
        /// </summary>
        public const string BUAN8GR = "BUAN8GR";

        /// <summary>
        /// BUUAN8BR.
        /// </summary>
        public const string BUUAN8BR = "BUUAN8BR";

        /// <summary>
        /// BUAN8BR.
        /// </summary>
        public const string BUAN8BR = "BUAN8BR";

        /// <summary>
        /// BUUAN8CR.
        /// </summary>
        public const string BUUAN8CR = "BUUAN8CR";

        /// <summary>
        /// BUAN8CR.
        /// </summary>
        public const string BUAN8CR = "BUAN8CR";

        /// <summary>
        /// BUUAN8V.
        /// </summary>
        public const string BUUAN8V = "BUUAN8V";

        /// <summary>
        /// BUAN8V.
        /// </summary>
        public const string BUAN8V = "BUAN8V";

        /// <summary>
        /// BUUAN8BL.
        /// </summary>
        public const string BUUAN8BL = "BUUAN8BL";

        /// <summary>
        /// BUAN8BL.
        /// </summary>
        public const string BUAN8BL = "BUAN8BL";

        /// <summary>
        /// BUUGOAREA.
        /// </summary>
        public const string BUUGOAREA = "BUUGOAREA";

        /// <summary>
        /// BUGOAREA.
        /// </summary>
        public const string BUGOAREA = "BUGOAREA";

        /// <summary>
        /// BUUAPPLLAT.
        /// </summary>
        public const string BUUAPPLLAT = "BUUAPPLLAT";

        /// <summary>
        /// BUAPPLLAT.
        /// </summary>
        public const string BUAPPLLAT = "BUAPPLLAT";

        /// <summary>
        /// BUUGREGION.
        /// </summary>
        public const string BUUGREGION = "BUUGREGION";

        /// <summary>
        /// BUGREGION.
        /// </summary>
        public const string BUGREGION = "BUGREGION";

        /// <summary>
        /// BUUGDISTR.
        /// </summary>
        public const string BUUGDISTR = "BUUGDISTR";

        /// <summary>
        /// BUGDISTR.
        /// </summary>
        public const string BUGDISTR = "BUGDISTR";

        /// <summary>
        /// BUUVARCODE.
        /// </summary>
        public const string BUUVARCODE = "BUUVARCODE";

        /// <summary>
        /// BUVARCODE.
        /// </summary>
        public const string BUVARCODE = "BUVARCODE";

        /// <summary>
        /// BUUCURQLTY.
        /// </summary>
        public const string BUUCURQLTY = "BUUCURQLTY";

        /// <summary>
        /// BUCURQLTY.
        /// </summary>
        public const string BUCURQLTY = "BUCURQLTY";

        /// <summary>
        /// BUUTARQLTY.
        /// </summary>
        public const string BUUTARQLTY = "BUUTARQLTY";

        /// <summary>
        /// BUTARQLTY.
        /// </summary>
        public const string BUTARQLTY = "BUTARQLTY";

        /// <summary>
        /// BUUMATYP.
        /// </summary>
        public const string BUUMATYP = "BUUMATYP";

        /// <summary>
        /// BUMATYP.
        /// </summary>
        public const string BUMATYP = "BUMATYP";

        /// <summary>
        /// BUUWATERTY.
        /// </summary>
        public const string BUUWATERTY = "BUUWATERTY";

        /// <summary>
        /// BUWATERTY.
        /// </summary>
        public const string BUWATERTY = "BUWATERTY";

        /// <summary>
        /// BUUIVOL.
        /// </summary>
        public const string BUUIVOL = "BUUIVOL";

        /// <summary>
        /// BUIVOL.
        /// </summary>
        public const string BUIVOL = "BUIVOL";

        /// <summary>
        /// BUUPRUNEMT.
        /// </summary>
        public const string BUUPRUNEMT = "BUUPRUNEMT";

        /// <summary>
        /// BUPRUNEMT.
        /// </summary>
        public const string BUPRUNEMT = "BUPRUNEMT";

        /// <summary>
        /// BUUSOILTYP.
        /// </summary>
        public const string BUUSOILTYP = "BUUSOILTYP";

        /// <summary>
        /// BUSOILTYP.
        /// </summary>
        public const string BUSOILTYP = "BUSOILTYP";

        /// <summary>
        /// BUUCLONE.
        /// </summary>
        public const string BUUCLONE = "BUUCLONE";

        /// <summary>
        /// BUCLONE.
        /// </summary>
        public const string BUCLONE = "BUCLONE";

        /// <summary>
        /// BUUROOTSTK.
        /// </summary>
        public const string BUUROOTSTK = "BUUROOTSTK";

        /// <summary>
        /// BUROOTSTK.
        /// </summary>
        public const string BUROOTSTK = "BUROOTSTK";

        /// <summary>
        /// BUUROWSPC.
        /// </summary>
        public const string BUUROWSPC = "BUUROWSPC";

        /// <summary>
        /// BUROWSPC.
        /// </summary>
        public const string BUROWSPC = "BUROWSPC";

        /// <summary>
        /// BUUPLTSPC.
        /// </summary>
        public const string BUUPLTSPC = "BUUPLTSPC";

        /// <summary>
        /// BUPLTSPC.
        /// </summary>
        public const string BUPLTSPC = "BUPLTSPC";

        /// <summary>
        /// BUUPDNOP.
        /// </summary>
        public const string BUUPDNOP = "BUUPDNOP";

        /// <summary>
        /// BUNOP.
        /// </summary>
        public const string BUNOP = "BUNOP";

        /// <summary>
        /// BUUPLTAREA.
        /// </summary>
        public const string BUUPLTAREA = "BUUPLTAREA";

        /// <summary>
        /// BUPLTAREA.
        /// </summary>
        public const string BUPLTAREA = "BUPLTAREA";

        /// <summary>
        /// BUUGRSAREA.
        /// </summary>
        public const string BUUGRSAREA = "BUUGRSAREA";

        /// <summary>
        /// BUGRSAREA.
        /// </summary>
        public const string BUGRSAREA = "BUGRSAREA";

        /// <summary>
        /// BUUDIMA.
        /// </summary>
        public const string BUUDIMA = "BUUDIMA";

        /// <summary>
        /// BUDIMA.
        /// </summary>
        public const string BUDIMA = "BUDIMA";

        /// <summary>
        /// BUUDIMB.
        /// </summary>
        public const string BUUDIMB = "BUUDIMB";

        /// <summary>
        /// BUDIMB.
        /// </summary>
        public const string BUDIMB = "BUDIMB";

        /// <summary>
        /// BUUDIMUOM.
        /// </summary>
        public const string BUUDIMUOM = "BUUDIMUOM";

        /// <summary>
        /// BUDIMUOM.
        /// </summary>
        public const string BUDIMUOM = "BUDIMUOM";

        /// <summary>
        /// BUUELEV.
        /// </summary>
        public const string BUUELEV = "BUUELEV";

        /// <summary>
        /// BUELEVATIO.
        /// </summary>
        public const string BUELEVATIO = "BUELEVATIO";

        /// <summary>
        /// BUUEXTRRTE.
        /// </summary>
        public const string BUUEXTRRTE = "BUUEXTRRTE";

        /// <summary>
        /// BUEXTRRTE.
        /// </summary>
        public const string BUEXTRRTE = "BUEXTRRTE";

        /// <summary>
        /// BUUUPLTDAT.
        /// </summary>
        public const string BUUUPLTDAT = "BUUUPLTDAT";

        /// <summary>
        /// BUUPLTDAT.
        /// </summary>
        public const string BUUPLTDAT = "BUUPLTDAT";

        /// <summary>
        /// BUUGROW01.
        /// </summary>
        public const string BUUGROW01 = "BUUGROW01";

        /// <summary>
        /// BUGROW01.
        /// </summary>
        public const string BUGROW01 = "BUGROW01";

        /// <summary>
        /// BUUGROW02.
        /// </summary>
        public const string BUUGROW02 = "BUUGROW02";

        /// <summary>
        /// BUGROW02.
        /// </summary>
        public const string BUGROW02 = "BUGROW02";

        /// <summary>
        /// BUUGROW03.
        /// </summary>
        public const string BUUGROW03 = "BUUGROW03";

        /// <summary>
        /// BUGROW03.
        /// </summary>
        public const string BUGROW03 = "BUGROW03";

        /// <summary>
        /// BUUGROW04.
        /// </summary>
        public const string BUUGROW04 = "BUUGROW04";

        /// <summary>
        /// BUGROW04.
        /// </summary>
        public const string BUGROW04 = "BUGROW04";

        /// <summary>
        /// BUUGROW05.
        /// </summary>
        public const string BUUGROW05 = "BUUGROW05";

        /// <summary>
        /// BUGROW05.
        /// </summary>
        public const string BUGROW05 = "BUGROW05";

        /// <summary>
        /// BUUGROW06.
        /// </summary>
        public const string BUUGROW06 = "BUUGROW06";

        /// <summary>
        /// BUGROW06.
        /// </summary>
        public const string BUGROW06 = "BUGROW06";

        /// <summary>
        /// BUUGROW07.
        /// </summary>
        public const string BUUGROW07 = "BUUGROW07";

        /// <summary>
        /// BUGROW07.
        /// </summary>
        public const string BUGROW07 = "BUGROW07";

        /// <summary>
        /// BUUGROW08.
        /// </summary>
        public const string BUUGROW08 = "BUUGROW08";

        /// <summary>
        /// BUGROW08.
        /// </summary>
        public const string BUGROW08 = "BUGROW08";

        /// <summary>
        /// BUUGROW09.
        /// </summary>
        public const string BUUGROW09 = "BUUGROW09";

        /// <summary>
        /// BUGROW09.
        /// </summary>
        public const string BUGROW09 = "BUGROW09";

        /// <summary>
        /// BUUGROW10.
        /// </summary>
        public const string BUUGROW10 = "BUUGROW10";

        /// <summary>
        /// BUGROW10.
        /// </summary>
        public const string BUGROW10 = "BUGROW10";

        /// <summary>
        /// BUUGROW11.
        /// </summary>
        public const string BUUGROW11 = "BUUGROW11";

        /// <summary>
        /// BUGROW11.
        /// </summary>
        public const string BUGROW11 = "BUGROW11";

        /// <summary>
        /// BUUGROW12.
        /// </summary>
        public const string BUUGROW12 = "BUUGROW12";

        /// <summary>
        /// BUGROW12.
        /// </summary>
        public const string BUGROW12 = "BUGROW12";

        /// <summary>
        /// BUUGROW13.
        /// </summary>
        public const string BUUGROW13 = "BUUGROW13";

        /// <summary>
        /// BUGROW13.
        /// </summary>
        public const string BUGROW13 = "BUGROW13";

        /// <summary>
        /// BUUGROW14.
        /// </summary>
        public const string BUUGROW14 = "BUUGROW14";

        /// <summary>
        /// BUGROW14.
        /// </summary>
        public const string BUGROW14 = "BUGROW14";

        /// <summary>
        /// BUUGROW15.
        /// </summary>
        public const string BUUGROW15 = "BUUGROW15";

        /// <summary>
        /// BUGROW15.
        /// </summary>
        public const string BUGROW15 = "BUGROW15";

        /// <summary>
        /// BUUCGROW01.
        /// </summary>
        public const string BUUCGROW01 = "BUUCGROW01";

        /// <summary>
        /// BUCGROW01.
        /// </summary>
        public const string BUCGROW01 = "BUCGROW01";

        /// <summary>
        /// BUUCGROW02.
        /// </summary>
        public const string BUUCGROW02 = "BUUCGROW02";

        /// <summary>
        /// BUCGROW02.
        /// </summary>
        public const string BUCGROW02 = "BUCGROW02";

        /// <summary>
        /// BUUCGROW03.
        /// </summary>
        public const string BUUCGROW03 = "BUUCGROW03";

        /// <summary>
        /// BUCGROW03.
        /// </summary>
        public const string BUCGROW03 = "BUCGROW03";

        /// <summary>
        /// BUUCGROW04.
        /// </summary>
        public const string BUUCGROW04 = "BUUCGROW04";

        /// <summary>
        /// BUCGROW04.
        /// </summary>
        public const string BUCGROW04 = "BUCGROW04";

        /// <summary>
        /// BUUCGROW05.
        /// </summary>
        public const string BUUCGROW05 = "BUUCGROW05";

        /// <summary>
        /// BUCGROW05.
        /// </summary>
        public const string BUCGROW05 = "BUCGROW05";

        /// <summary>
        /// BUUUGDAT01.
        /// </summary>
        public const string BUUUGDAT01 = "BUUUGDAT01";

        /// <summary>
        /// BUUGDATE01.
        /// </summary>
        public const string BUUGDATE01 = "BUUGDATE01";

        /// <summary>
        /// BUUUGDAT02.
        /// </summary>
        public const string BUUUGDAT02 = "BUUUGDAT02";

        /// <summary>
        /// BUUGDATE02.
        /// </summary>
        public const string BUUGDATE02 = "BUUGDATE02";

        /// <summary>
        /// BUUUGDAT03.
        /// </summary>
        public const string BUUUGDAT03 = "BUUUGDAT03";

        /// <summary>
        /// BUUGDATE03.
        /// </summary>
        public const string BUUGDATE03 = "BUUGDATE03";

        /// <summary>
        /// BUUUGDAT04.
        /// </summary>
        public const string BUUUGDAT04 = "BUUUGDAT04";

        /// <summary>
        /// BUUGDATE04.
        /// </summary>
        public const string BUUGDATE04 = "BUUGDATE04";

        /// <summary>
        /// BUUUGDAT05.
        /// </summary>
        public const string BUUUGDAT05 = "BUUUGDAT05";

        /// <summary>
        /// BUUGDATE05.
        /// </summary>
        public const string BUUGDATE05 = "BUUGDATE05";

        /// <summary>
        /// BUUUGDAT06.
        /// </summary>
        public const string BUUUGDAT06 = "BUUUGDAT06";

        /// <summary>
        /// BUUGDATE06.
        /// </summary>
        public const string BUUGDATE06 = "BUUGDATE06";

        /// <summary>
        /// BUUUGDAT07.
        /// </summary>
        public const string BUUUGDAT07 = "BUUUGDAT07";

        /// <summary>
        /// BUUGDATE07.
        /// </summary>
        public const string BUUGDATE07 = "BUUGDATE07";

        /// <summary>
        /// BUUUGDAT08.
        /// </summary>
        public const string BUUUGDAT08 = "BUUUGDAT08";

        /// <summary>
        /// BUUGDATE08.
        /// </summary>
        public const string BUUGDATE08 = "BUUGDATE08";

        /// <summary>
        /// BUUGNUM01.
        /// </summary>
        public const string BUUGNUM01 = "BUUGNUM01";

        /// <summary>
        /// BUGNUM01.
        /// </summary>
        public const string BUGNUM01 = "BUGNUM01";

        /// <summary>
        /// BUUGNUM02.
        /// </summary>
        public const string BUUGNUM02 = "BUUGNUM02";

        /// <summary>
        /// BUGNUM02.
        /// </summary>
        public const string BUGNUM02 = "BUGNUM02";

        /// <summary>
        /// BUUGNUM03.
        /// </summary>
        public const string BUUGNUM03 = "BUUGNUM03";

        /// <summary>
        /// BUGNUM03.
        /// </summary>
        public const string BUGNUM03 = "BUGNUM03";

        /// <summary>
        /// BUUGNUM04.
        /// </summary>
        public const string BUUGNUM04 = "BUUGNUM04";

        /// <summary>
        /// BUGNUM04.
        /// </summary>
        public const string BUGNUM04 = "BUGNUM04";

        /// <summary>
        /// BUUGNUM05.
        /// </summary>
        public const string BUUGNUM05 = "BUUGNUM05";

        /// <summary>
        /// BUGNUM05.
        /// </summary>
        public const string BUGNUM05 = "BUGNUM05";

        /// <summary>
        /// BUUSITEC.
        /// </summary>
        public const string BUUSITEC = "BUUSITEC";

        /// <summary>
        /// BUSITEC.
        /// </summary>
        public const string BUSITEC = "BUSITEC";

        /// <summary>
        /// BUUSITEP.
        /// </summary>
        public const string BUUSITEP = "BUUSITEP";

        /// <summary>
        /// BUSITEP.
        /// </summary>
        public const string BUSITEP = "BUSITEP";

        /// <summary>
        /// BUUGPRC.
        /// </summary>
        public const string BUUGPRC = "BUUGPRC";

        /// <summary>
        /// BUGPRC.
        /// </summary>
        public const string BUGPRC = "BUGPRC";

        /// <summary>
        /// BUUUOM4.
        /// </summary>
        public const string BUUUOM4 = "BUUUOM4";

        /// <summary>
        /// BUUOM4.
        /// </summary>
        public const string BUUOM4 = "BUUOM4";

        /// <summary>
        /// BUUPLNEST.
        /// </summary>
        public const string BUUPLNEST = "BUUPLNEST";

        /// <summary>
        /// BUPLNEST.
        /// </summary>
        public const string BUPLNEST = "BUPLNEST";

        /// <summary>
        /// BUUCONTUOM.
        /// </summary>
        public const string BUUCONTUOM = "BUUCONTUOM";

        /// <summary>
        /// BUCONTUOM.
        /// </summary>
        public const string BUCONTUOM = "BUCONTUOM";

        /// <summary>
        /// BUUQTYLOAD.
        /// </summary>
        public const string BUUQTYLOAD = "BUUQTYLOAD";

        /// <summary>
        /// BUQTYLOAD.
        /// </summary>
        public const string BUQTYLOAD = "BUQTYLOAD";

        /// <summary>
        /// BUUBLNAM2.
        /// </summary>
        public const string BUUBLNAM2 = "BUUBLNAM2";

        /// <summary>
        /// BUBLNAM2.
        /// </summary>
        public const string BUBLNAM2 = "BUBLNAM2";

        /// <summary>
        /// BUUPARCEL1.
        /// </summary>
        public const string BUUPARCEL1 = "BUUPARCEL1";

        /// <summary>
        /// BUPARCEL1.
        /// </summary>
        public const string BUPARCEL1 = "BUPARCEL1";

        /// <summary>
        /// BUUPARCEL2.
        /// </summary>
        public const string BUUPARCEL2 = "BUUPARCEL2";

        /// <summary>
        /// BUPARCEL2.
        /// </summary>
        public const string BUPARCEL2 = "BUPARCEL2";

        /// <summary>
        /// BUUPARCEL3.
        /// </summary>
        public const string BUUPARCEL3 = "BUUPARCEL3";

        /// <summary>
        /// BUPARCEL3.
        /// </summary>
        public const string BUPARCEL3 = "BUPARCEL3";

        /// <summary>
        /// BUUPAREA1.
        /// </summary>
        public const string BUUPAREA1 = "BUUPAREA1";

        /// <summary>
        /// BUPAREA1.
        /// </summary>
        public const string BUPAREA1 = "BUPAREA1";

        /// <summary>
        /// BUUPAREA2.
        /// </summary>
        public const string BUUPAREA2 = "BUUPAREA2";

        /// <summary>
        /// BUPAREA2.
        /// </summary>
        public const string BUPAREA2 = "BUPAREA2";

        /// <summary>
        /// BUUPAREA3.
        /// </summary>
        public const string BUUPAREA3 = "BUUPAREA3";

        /// <summary>
        /// BUPAREA3.
        /// </summary>
        public const string BUPAREA3 = "BUPAREA3";

        /// <summary>
        /// BUUGOVID1.
        /// </summary>
        public const string BUUGOVID1 = "BUUGOVID1";

        /// <summary>
        /// BUGOVID1.
        /// </summary>
        public const string BUGOVID1 = "BUGOVID1";

        /// <summary>
        /// BUUGOVID2.
        /// </summary>
        public const string BUUGOVID2 = "BUUGOVID2";

        /// <summary>
        /// BUGOVID2.
        /// </summary>
        public const string BUGOVID2 = "BUGOVID2";

        /// <summary>
        /// BUUGOVID3.
        /// </summary>
        public const string BUUGOVID3 = "BUUGOVID3";

        /// <summary>
        /// BUGOVID3.
        /// </summary>
        public const string BUGOVID3 = "BUGOVID3";

        /// <summary>
        /// BUUGOVID4.
        /// </summary>
        public const string BUUGOVID4 = "BUUGOVID4";

        /// <summary>
        /// BUGOVID4.
        /// </summary>
        public const string BUGOVID4 = "BUGOVID4";

        /// <summary>
        /// BUUOPERID.
        /// </summary>
        public const string BUUOPERID = "BUUOPERID";

        /// <summary>
        /// BUOPERID.
        /// </summary>
        public const string BUOPERID = "BUOPERID";

        /// <summary>
        /// BUUSITEID.
        /// </summary>
        public const string BUUSITEID = "BUUSITEID";

        /// <summary>
        /// BUSITEID.
        /// </summary>
        public const string BUSITEID = "BUSITEID";

        /// <summary>
        /// BUUPTMATNM.
        /// </summary>
        public const string BUUPTMATNM = "BUUPTMATNM";

        /// <summary>
        /// BUMATCALID.
        /// </summary>
        public const string BUMATCALID = "BUMATCALID";

        /// <summary>
        /// BUURCD.
        /// </summary>
        public const string BUURCD = "BUURCD";

        /// <summary>
        /// BUURDT.
        /// </summary>
        public const string BUURDT = "BUURDT";

        /// <summary>
        /// BUURRF.
        /// </summary>
        public const string BUURRF = "BUURRF";

        /// <summary>
        /// BUURAB.
        /// </summary>
        public const string BUURAB = "BUURAB";

        /// <summary>
        /// BUURAT.
        /// </summary>
        public const string BUURAT = "BUURAT";

        /// <summary>
        /// BUTORG.
        /// </summary>
        public const string BUTORG = "BUTORG";

        /// <summary>
        /// BUUSER.
        /// </summary>
        public const string BUUSER = "BUUSER";

        /// <summary>
        /// BUPID.
        /// </summary>
        public const string BUPID = "BUPID";

        /// <summary>
        /// BUJOBN.
        /// </summary>
        public const string BUJOBN = "BUJOBN";

        /// <summary>
        /// BUUUPMJ.
        /// </summary>
        public const string BUUUPMJ = "BUUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F40G0200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BUBLUPID", "BUBLUPID", JdeDataType.Numeric, null, true, true),
        new JdeField("BUBLUPDESC", "BUBLUPDESC", JdeDataType.String, 80),
        new JdeField("BUUFRMCODE", "BUUFRMCODE", JdeDataType.String, 2),
        new JdeField("BUFARMCODE", "BUFARMCODE", JdeDataType.String, 16),
        new JdeField("BUUBLNAM", "BUUBLNAM", JdeDataType.String, 2),
        new JdeField("BUBLNAM", "BUBLNAM", JdeDataType.String, 80),
        new JdeField("BUUBLTYPE", "BUUBLTYPE", JdeDataType.String, 2),
        new JdeField("BUBLTYPE", "BUBLTYPE", JdeDataType.String, 2),
        new JdeField("BUUGRCMPCD", "BUUGRCMPCD", JdeDataType.String, 2),
        new JdeField("BUGRCMPCD", "BUGRCMPCD", JdeDataType.String, 20),
        new JdeField("BUUAN8GR", "BUUAN8GR", JdeDataType.String, 2),
        new JdeField("BUAN8GR", "BUAN8GR", JdeDataType.Numeric),
        new JdeField("BUUAN8BR", "BUUAN8BR", JdeDataType.String, 2),
        new JdeField("BUAN8BR", "BUAN8BR", JdeDataType.Numeric),
        new JdeField("BUUAN8CR", "BUUAN8CR", JdeDataType.String, 2),
        new JdeField("BUAN8CR", "BUAN8CR", JdeDataType.Numeric),
        new JdeField("BUUAN8V", "BUUAN8V", JdeDataType.String, 2),
        new JdeField("BUAN8V", "BUAN8V", JdeDataType.Numeric),
        new JdeField("BUUAN8BL", "BUUAN8BL", JdeDataType.String, 2),
        new JdeField("BUAN8BL", "BUAN8BL", JdeDataType.Numeric),
        new JdeField("BUUGOAREA", "BUUGOAREA", JdeDataType.String, 2),
        new JdeField("BUGOAREA", "BUGOAREA", JdeDataType.String, 8),
        new JdeField("BUUAPPLLAT", "BUUAPPLLAT", JdeDataType.String, 2),
        new JdeField("BUAPPLLAT", "BUAPPLLAT", JdeDataType.String, 16),
        new JdeField("BUUGREGION", "BUUGREGION", JdeDataType.String, 2),
        new JdeField("BUGREGION", "BUGREGION", JdeDataType.String, 20),
        new JdeField("BUUGDISTR", "BUUGDISTR", JdeDataType.String, 2),
        new JdeField("BUGDISTR", "BUGDISTR", JdeDataType.String, 20),
        new JdeField("BUUVARCODE", "BUUVARCODE", JdeDataType.String, 2),
        new JdeField("BUVARCODE", "BUVARCODE", JdeDataType.String, 10),
        new JdeField("BUUCURQLTY", "BUUCURQLTY", JdeDataType.String, 2),
        new JdeField("BUCURQLTY", "BUCURQLTY", JdeDataType.String, 2),
        new JdeField("BUUTARQLTY", "BUUTARQLTY", JdeDataType.String, 2),
        new JdeField("BUTARQLTY", "BUTARQLTY", JdeDataType.String, 2),
        new JdeField("BUUMATYP", "BUUMATYP", JdeDataType.String, 2),
        new JdeField("BUMATYP", "BUMATYP", JdeDataType.String, 8),
        new JdeField("BUUWATERTY", "BUUWATERTY", JdeDataType.String, 2),
        new JdeField("BUWATERTY", "BUWATERTY", JdeDataType.String, 4),
        new JdeField("BUUIVOL", "BUUIVOL", JdeDataType.String, 2),
        new JdeField("BUIVOL", "BUIVOL", JdeDataType.Numeric),
        new JdeField("BUUPRUNEMT", "BUUPRUNEMT", JdeDataType.String, 2),
        new JdeField("BUPRUNEMT", "BUPRUNEMT", JdeDataType.String, 4),
        new JdeField("BUUSOILTYP", "BUUSOILTYP", JdeDataType.String, 2),
        new JdeField("BUSOILTYP", "BUSOILTYP", JdeDataType.String, 4),
        new JdeField("BUUCLONE", "BUUCLONE", JdeDataType.String, 2),
        new JdeField("BUCLONE", "BUCLONE", JdeDataType.String, 4),
        new JdeField("BUUROOTSTK", "BUUROOTSTK", JdeDataType.String, 2),
        new JdeField("BUROOTSTK", "BUROOTSTK", JdeDataType.String, 4),
        new JdeField("BUUROWSPC", "BUUROWSPC", JdeDataType.String, 2),
        new JdeField("BUROWSPC", "BUROWSPC", JdeDataType.String, 4),
        new JdeField("BUUPLTSPC", "BUUPLTSPC", JdeDataType.String, 2),
        new JdeField("BUPLTSPC", "BUPLTSPC", JdeDataType.String, 4),
        new JdeField("BUUPDNOP", "BUUPDNOP", JdeDataType.String, 2),
        new JdeField("BUNOP", "BUNOP", JdeDataType.Numeric),
        new JdeField("BUUPLTAREA", "BUUPLTAREA", JdeDataType.String, 2),
        new JdeField("BUPLTAREA", "BUPLTAREA", JdeDataType.Numeric),
        new JdeField("BUUGRSAREA", "BUUGRSAREA", JdeDataType.String, 2),
        new JdeField("BUGRSAREA", "BUGRSAREA", JdeDataType.Numeric),
        new JdeField("BUUDIMA", "BUUDIMA", JdeDataType.String, 2),
        new JdeField("BUDIMA", "BUDIMA", JdeDataType.Numeric),
        new JdeField("BUUDIMB", "BUUDIMB", JdeDataType.String, 2),
        new JdeField("BUDIMB", "BUDIMB", JdeDataType.Numeric),
        new JdeField("BUUDIMUOM", "BUUDIMUOM", JdeDataType.String, 2),
        new JdeField("BUDIMUOM", "BUDIMUOM", JdeDataType.String, 4),
        new JdeField("BUUELEV", "BUUELEV", JdeDataType.String, 2),
        new JdeField("BUELEVATIO", "BUELEVATIO", JdeDataType.Numeric),
        new JdeField("BUUEXTRRTE", "BUUEXTRRTE", JdeDataType.String, 2),
        new JdeField("BUEXTRRTE", "BUEXTRRTE", JdeDataType.Numeric),
        new JdeField("BUUUPLTDAT", "BUUUPLTDAT", JdeDataType.String, 2),
        new JdeField("BUUPLTDAT", "BUUPLTDAT", JdeDataType.Date),
        new JdeField("BUUGROW01", "BUUGROW01", JdeDataType.String, 2),
        new JdeField("BUGROW01", "BUGROW01", JdeDataType.String, 6),
        new JdeField("BUUGROW02", "BUUGROW02", JdeDataType.String, 2),
        new JdeField("BUGROW02", "BUGROW02", JdeDataType.String, 6),
        new JdeField("BUUGROW03", "BUUGROW03", JdeDataType.String, 2),
        new JdeField("BUGROW03", "BUGROW03", JdeDataType.String, 6),
        new JdeField("BUUGROW04", "BUUGROW04", JdeDataType.String, 2),
        new JdeField("BUGROW04", "BUGROW04", JdeDataType.String, 6),
        new JdeField("BUUGROW05", "BUUGROW05", JdeDataType.String, 2),
        new JdeField("BUGROW05", "BUGROW05", JdeDataType.String, 6),
        new JdeField("BUUGROW06", "BUUGROW06", JdeDataType.String, 2),
        new JdeField("BUGROW06", "BUGROW06", JdeDataType.String, 16),
        new JdeField("BUUGROW07", "BUUGROW07", JdeDataType.String, 2),
        new JdeField("BUGROW07", "BUGROW07", JdeDataType.String, 16),
        new JdeField("BUUGROW08", "BUUGROW08", JdeDataType.String, 2),
        new JdeField("BUGROW08", "BUGROW08", JdeDataType.String, 16),
        new JdeField("BUUGROW09", "BUUGROW09", JdeDataType.String, 2),
        new JdeField("BUGROW09", "BUGROW09", JdeDataType.String, 16),
        new JdeField("BUUGROW10", "BUUGROW10", JdeDataType.String, 2),
        new JdeField("BUGROW10", "BUGROW10", JdeDataType.String, 16),
        new JdeField("BUUGROW11", "BUUGROW11", JdeDataType.String, 2),
        new JdeField("BUGROW11", "BUGROW11", JdeDataType.String, 20),
        new JdeField("BUUGROW12", "BUUGROW12", JdeDataType.String, 2),
        new JdeField("BUGROW12", "BUGROW12", JdeDataType.String, 20),
        new JdeField("BUUGROW13", "BUUGROW13", JdeDataType.String, 2),
        new JdeField("BUGROW13", "BUGROW13", JdeDataType.String, 20),
        new JdeField("BUUGROW14", "BUUGROW14", JdeDataType.String, 2),
        new JdeField("BUGROW14", "BUGROW14", JdeDataType.String, 20),
        new JdeField("BUUGROW15", "BUUGROW15", JdeDataType.String, 2),
        new JdeField("BUGROW15", "BUGROW15", JdeDataType.String, 20),
        new JdeField("BUUCGROW01", "BUUCGROW01", JdeDataType.String, 2),
        new JdeField("BUCGROW01", "BUCGROW01", JdeDataType.String, 2),
        new JdeField("BUUCGROW02", "BUUCGROW02", JdeDataType.String, 2),
        new JdeField("BUCGROW02", "BUCGROW02", JdeDataType.String, 2),
        new JdeField("BUUCGROW03", "BUUCGROW03", JdeDataType.String, 2),
        new JdeField("BUCGROW03", "BUCGROW03", JdeDataType.String, 2),
        new JdeField("BUUCGROW04", "BUUCGROW04", JdeDataType.String, 2),
        new JdeField("BUCGROW04", "BUCGROW04", JdeDataType.String, 2),
        new JdeField("BUUCGROW05", "BUUCGROW05", JdeDataType.String, 2),
        new JdeField("BUCGROW05", "BUCGROW05", JdeDataType.String, 2),
        new JdeField("BUUUGDAT01", "BUUUGDAT01", JdeDataType.String, 2),
        new JdeField("BUUGDATE01", "BUUGDATE01", JdeDataType.Date),
        new JdeField("BUUUGDAT02", "BUUUGDAT02", JdeDataType.String, 2),
        new JdeField("BUUGDATE02", "BUUGDATE02", JdeDataType.Date),
        new JdeField("BUUUGDAT03", "BUUUGDAT03", JdeDataType.String, 2),
        new JdeField("BUUGDATE03", "BUUGDATE03", JdeDataType.Date),
        new JdeField("BUUUGDAT04", "BUUUGDAT04", JdeDataType.String, 2),
        new JdeField("BUUGDATE04", "BUUGDATE04", JdeDataType.Date),
        new JdeField("BUUUGDAT05", "BUUUGDAT05", JdeDataType.String, 2),
        new JdeField("BUUGDATE05", "BUUGDATE05", JdeDataType.Date),
        new JdeField("BUUUGDAT06", "BUUUGDAT06", JdeDataType.String, 2),
        new JdeField("BUUGDATE06", "BUUGDATE06", JdeDataType.Date),
        new JdeField("BUUUGDAT07", "BUUUGDAT07", JdeDataType.String, 2),
        new JdeField("BUUGDATE07", "BUUGDATE07", JdeDataType.Date),
        new JdeField("BUUUGDAT08", "BUUUGDAT08", JdeDataType.String, 2),
        new JdeField("BUUGDATE08", "BUUGDATE08", JdeDataType.Date),
        new JdeField("BUUGNUM01", "BUUGNUM01", JdeDataType.String, 2),
        new JdeField("BUGNUM01", "BUGNUM01", JdeDataType.Numeric),
        new JdeField("BUUGNUM02", "BUUGNUM02", JdeDataType.String, 2),
        new JdeField("BUGNUM02", "BUGNUM02", JdeDataType.Numeric),
        new JdeField("BUUGNUM03", "BUUGNUM03", JdeDataType.String, 2),
        new JdeField("BUGNUM03", "BUGNUM03", JdeDataType.Numeric),
        new JdeField("BUUGNUM04", "BUUGNUM04", JdeDataType.String, 2),
        new JdeField("BUGNUM04", "BUGNUM04", JdeDataType.Numeric),
        new JdeField("BUUGNUM05", "BUUGNUM05", JdeDataType.String, 2),
        new JdeField("BUGNUM05", "BUGNUM05", JdeDataType.Numeric),
        new JdeField("BUUSITEC", "BUUSITEC", JdeDataType.String, 2),
        new JdeField("BUSITEC", "BUSITEC", JdeDataType.String, 24),
        new JdeField("BUUSITEP", "BUUSITEP", JdeDataType.String, 2),
        new JdeField("BUSITEP", "BUSITEP", JdeDataType.String, 24),
        new JdeField("BUUGPRC", "BUUGPRC", JdeDataType.String, 2),
        new JdeField("BUGPRC", "BUGPRC", JdeDataType.Numeric),
        new JdeField("BUUUOM4", "BUUUOM4", JdeDataType.String, 2),
        new JdeField("BUUOM4", "BUUOM4", JdeDataType.String, 4),
        new JdeField("BUUPLNEST", "BUUPLNEST", JdeDataType.String, 2),
        new JdeField("BUPLNEST", "BUPLNEST", JdeDataType.Numeric),
        new JdeField("BUUCONTUOM", "BUUCONTUOM", JdeDataType.String, 2),
        new JdeField("BUCONTUOM", "BUCONTUOM", JdeDataType.String, 4),
        new JdeField("BUUQTYLOAD", "BUUQTYLOAD", JdeDataType.String, 2),
        new JdeField("BUQTYLOAD", "BUQTYLOAD", JdeDataType.Numeric),
        new JdeField("BUUBLNAM2", "BUUBLNAM2", JdeDataType.String, 2),
        new JdeField("BUBLNAM2", "BUBLNAM2", JdeDataType.String, 80),
        new JdeField("BUUPARCEL1", "BUUPARCEL1", JdeDataType.String, 2),
        new JdeField("BUPARCEL1", "BUPARCEL1", JdeDataType.String, 50),
        new JdeField("BUUPARCEL2", "BUUPARCEL2", JdeDataType.String, 2),
        new JdeField("BUPARCEL2", "BUPARCEL2", JdeDataType.String, 50),
        new JdeField("BUUPARCEL3", "BUUPARCEL3", JdeDataType.String, 2),
        new JdeField("BUPARCEL3", "BUPARCEL3", JdeDataType.String, 50),
        new JdeField("BUUPAREA1", "BUUPAREA1", JdeDataType.String, 2),
        new JdeField("BUPAREA1", "BUPAREA1", JdeDataType.Numeric),
        new JdeField("BUUPAREA2", "BUUPAREA2", JdeDataType.String, 2),
        new JdeField("BUPAREA2", "BUPAREA2", JdeDataType.Numeric),
        new JdeField("BUUPAREA3", "BUUPAREA3", JdeDataType.String, 2),
        new JdeField("BUPAREA3", "BUPAREA3", JdeDataType.Numeric),
        new JdeField("BUUGOVID1", "BUUGOVID1", JdeDataType.String, 2),
        new JdeField("BUGOVID1", "BUGOVID1", JdeDataType.String, 50),
        new JdeField("BUUGOVID2", "BUUGOVID2", JdeDataType.String, 2),
        new JdeField("BUGOVID2", "BUGOVID2", JdeDataType.String, 50),
        new JdeField("BUUGOVID3", "BUUGOVID3", JdeDataType.String, 2),
        new JdeField("BUGOVID3", "BUGOVID3", JdeDataType.String, 50),
        new JdeField("BUUGOVID4", "BUUGOVID4", JdeDataType.String, 2),
        new JdeField("BUGOVID4", "BUGOVID4", JdeDataType.String, 50),
        new JdeField("BUUOPERID", "BUUOPERID", JdeDataType.String, 2),
        new JdeField("BUOPERID", "BUOPERID", JdeDataType.String, 22),
        new JdeField("BUUSITEID", "BUUSITEID", JdeDataType.String, 2),
        new JdeField("BUSITEID", "BUSITEID", JdeDataType.String, 16),
        new JdeField("BUUPTMATNM", "BUUPTMATNM", JdeDataType.String, 2),
        new JdeField("BUMATCALID", "BUMATCALID", JdeDataType.Numeric),
        new JdeField("BUURCD", "BUURCD", JdeDataType.String, 4),
        new JdeField("BUURDT", "BUURDT", JdeDataType.Numeric),
        new JdeField("BUURRF", "BUURRF", JdeDataType.String, 30),
        new JdeField("BUURAB", "BUURAB", JdeDataType.Numeric),
        new JdeField("BUURAT", "BUURAT", JdeDataType.Numeric),
        new JdeField("BUTORG", "BUTORG", JdeDataType.String, 20),
        new JdeField("BUUSER", "BUUSER", JdeDataType.String, 20),
        new JdeField("BUPID", "BUPID", JdeDataType.String, 20),
        new JdeField("BUJOBN", "BUJOBN", JdeDataType.String, 20),
        new JdeField("BUUUPMJ", "BUUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40G0200_0", "Primary Key on BUBLUPID", new[] { "BUBLUPID" }, isUnique: true, isPrimaryKey: true)
    };
}
