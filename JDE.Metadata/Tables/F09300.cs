using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09300 - .
/// </summary>
public class F09300 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FRRUNID.
        /// </summary>
        public const string FRRUNID = "FRRUNID";

        /// <summary>
        /// FRLINN.
        /// </summary>
        public const string FRLINN = "FRLINN";

        /// <summary>
        /// FRGRPV1.
        /// </summary>
        public const string FRGRPV1 = "FRGRPV1";

        /// <summary>
        /// FRGRPV2.
        /// </summary>
        public const string FRGRPV2 = "FRGRPV2";

        /// <summary>
        /// FRGRPV3.
        /// </summary>
        public const string FRGRPV3 = "FRGRPV3";

        /// <summary>
        /// FRGRPV4.
        /// </summary>
        public const string FRGRPV4 = "FRGRPV4";

        /// <summary>
        /// FRGRPV5.
        /// </summary>
        public const string FRGRPV5 = "FRGRPV5";

        /// <summary>
        /// FRGRPV6.
        /// </summary>
        public const string FRGRPV6 = "FRGRPV6";

        /// <summary>
        /// FRGRPV7.
        /// </summary>
        public const string FRGRPV7 = "FRGRPV7";

        /// <summary>
        /// FRGRPV8.
        /// </summary>
        public const string FRGRPV8 = "FRGRPV8";

        /// <summary>
        /// FRGRPV9.
        /// </summary>
        public const string FRGRPV9 = "FRGRPV9";

        /// <summary>
        /// FRGRPV10.
        /// </summary>
        public const string FRGRPV10 = "FRGRPV10";

        /// <summary>
        /// FRCOLAMT01.
        /// </summary>
        public const string FRCOLAMT01 = "FRCOLAMT01";

        /// <summary>
        /// FRCOLCUR01.
        /// </summary>
        public const string FRCOLCUR01 = "FRCOLCUR01";

        /// <summary>
        /// FRCOLAMT02.
        /// </summary>
        public const string FRCOLAMT02 = "FRCOLAMT02";

        /// <summary>
        /// FRCOLCUR02.
        /// </summary>
        public const string FRCOLCUR02 = "FRCOLCUR02";

        /// <summary>
        /// FRCOLAMT03.
        /// </summary>
        public const string FRCOLAMT03 = "FRCOLAMT03";

        /// <summary>
        /// FRCOLCUR03.
        /// </summary>
        public const string FRCOLCUR03 = "FRCOLCUR03";

        /// <summary>
        /// FRCOLAMT04.
        /// </summary>
        public const string FRCOLAMT04 = "FRCOLAMT04";

        /// <summary>
        /// FRCOLCUR04.
        /// </summary>
        public const string FRCOLCUR04 = "FRCOLCUR04";

        /// <summary>
        /// FRCOLAMT05.
        /// </summary>
        public const string FRCOLAMT05 = "FRCOLAMT05";

        /// <summary>
        /// FRCOLCUR05.
        /// </summary>
        public const string FRCOLCUR05 = "FRCOLCUR05";

        /// <summary>
        /// FRCOLAMT06.
        /// </summary>
        public const string FRCOLAMT06 = "FRCOLAMT06";

        /// <summary>
        /// FRCOLCUR06.
        /// </summary>
        public const string FRCOLCUR06 = "FRCOLCUR06";

        /// <summary>
        /// FRCOLAMT07.
        /// </summary>
        public const string FRCOLAMT07 = "FRCOLAMT07";

        /// <summary>
        /// FRCOLCUR07.
        /// </summary>
        public const string FRCOLCUR07 = "FRCOLCUR07";

        /// <summary>
        /// FRCOLAMT08.
        /// </summary>
        public const string FRCOLAMT08 = "FRCOLAMT08";

        /// <summary>
        /// FRCOLCUR08.
        /// </summary>
        public const string FRCOLCUR08 = "FRCOLCUR08";

        /// <summary>
        /// FRCOLAMT09.
        /// </summary>
        public const string FRCOLAMT09 = "FRCOLAMT09";

        /// <summary>
        /// FRCOLCUR09.
        /// </summary>
        public const string FRCOLCUR09 = "FRCOLCUR09";

        /// <summary>
        /// FRCOLAMT10.
        /// </summary>
        public const string FRCOLAMT10 = "FRCOLAMT10";

        /// <summary>
        /// FRCOLCUR10.
        /// </summary>
        public const string FRCOLCUR10 = "FRCOLCUR10";

        /// <summary>
        /// FRCOLAMT11.
        /// </summary>
        public const string FRCOLAMT11 = "FRCOLAMT11";

        /// <summary>
        /// FRCOLCUR11.
        /// </summary>
        public const string FRCOLCUR11 = "FRCOLCUR11";

        /// <summary>
        /// FRCOLAMT12.
        /// </summary>
        public const string FRCOLAMT12 = "FRCOLAMT12";

        /// <summary>
        /// FRCOLCUR12.
        /// </summary>
        public const string FRCOLCUR12 = "FRCOLCUR12";

        /// <summary>
        /// FRCOLAMT13.
        /// </summary>
        public const string FRCOLAMT13 = "FRCOLAMT13";

        /// <summary>
        /// FRCOLCUR13.
        /// </summary>
        public const string FRCOLCUR13 = "FRCOLCUR13";

        /// <summary>
        /// FRCOLAMT14.
        /// </summary>
        public const string FRCOLAMT14 = "FRCOLAMT14";

        /// <summary>
        /// FRCOLCUR14.
        /// </summary>
        public const string FRCOLCUR14 = "FRCOLCUR14";

        /// <summary>
        /// FRCOLAMT15.
        /// </summary>
        public const string FRCOLAMT15 = "FRCOLAMT15";

        /// <summary>
        /// FRCOLCUR15.
        /// </summary>
        public const string FRCOLCUR15 = "FRCOLCUR15";

        /// <summary>
        /// FRCOLAMT16.
        /// </summary>
        public const string FRCOLAMT16 = "FRCOLAMT16";

        /// <summary>
        /// FRCOLCUR16.
        /// </summary>
        public const string FRCOLCUR16 = "FRCOLCUR16";

        /// <summary>
        /// FRCOLAMT17.
        /// </summary>
        public const string FRCOLAMT17 = "FRCOLAMT17";

        /// <summary>
        /// FRCOLCUR17.
        /// </summary>
        public const string FRCOLCUR17 = "FRCOLCUR17";

        /// <summary>
        /// FRCOLAMT18.
        /// </summary>
        public const string FRCOLAMT18 = "FRCOLAMT18";

        /// <summary>
        /// FRCOLCUR18.
        /// </summary>
        public const string FRCOLCUR18 = "FRCOLCUR18";

        /// <summary>
        /// FRCOLAMT19.
        /// </summary>
        public const string FRCOLAMT19 = "FRCOLAMT19";

        /// <summary>
        /// FRCOLCUR19.
        /// </summary>
        public const string FRCOLCUR19 = "FRCOLCUR19";

        /// <summary>
        /// FRCOLAMT20.
        /// </summary>
        public const string FRCOLAMT20 = "FRCOLAMT20";

        /// <summary>
        /// FRCOLCUR20.
        /// </summary>
        public const string FRCOLCUR20 = "FRCOLCUR20";

        /// <summary>
        /// FRCOLAMT21.
        /// </summary>
        public const string FRCOLAMT21 = "FRCOLAMT21";

        /// <summary>
        /// FRCOLCUR21.
        /// </summary>
        public const string FRCOLCUR21 = "FRCOLCUR21";

        /// <summary>
        /// FRCOLAMT22.
        /// </summary>
        public const string FRCOLAMT22 = "FRCOLAMT22";

        /// <summary>
        /// FRCOLCUR22.
        /// </summary>
        public const string FRCOLCUR22 = "FRCOLCUR22";

        /// <summary>
        /// FRCOLAMT23.
        /// </summary>
        public const string FRCOLAMT23 = "FRCOLAMT23";

        /// <summary>
        /// FRCOLCUR23.
        /// </summary>
        public const string FRCOLCUR23 = "FRCOLCUR23";

        /// <summary>
        /// FRCOLAMT24.
        /// </summary>
        public const string FRCOLAMT24 = "FRCOLAMT24";

        /// <summary>
        /// FRCOLCUR24.
        /// </summary>
        public const string FRCOLCUR24 = "FRCOLCUR24";

        /// <summary>
        /// FRCOLAMT25.
        /// </summary>
        public const string FRCOLAMT25 = "FRCOLAMT25";

        /// <summary>
        /// FRCOLCUR25.
        /// </summary>
        public const string FRCOLCUR25 = "FRCOLCUR25";

        /// <summary>
        /// FRGRVDSC01.
        /// </summary>
        public const string FRGRVDSC01 = "FRGRVDSC01";

        /// <summary>
        /// FRGRVDSC02.
        /// </summary>
        public const string FRGRVDSC02 = "FRGRVDSC02";

        /// <summary>
        /// FRGRVDSC03.
        /// </summary>
        public const string FRGRVDSC03 = "FRGRVDSC03";

        /// <summary>
        /// FRGRVDSC04.
        /// </summary>
        public const string FRGRVDSC04 = "FRGRVDSC04";

        /// <summary>
        /// FRGRVDSC05.
        /// </summary>
        public const string FRGRVDSC05 = "FRGRVDSC05";

        /// <summary>
        /// FRGRVDSC06.
        /// </summary>
        public const string FRGRVDSC06 = "FRGRVDSC06";

        /// <summary>
        /// FRGRVDSC07.
        /// </summary>
        public const string FRGRVDSC07 = "FRGRVDSC07";

        /// <summary>
        /// FRGRVDSC08.
        /// </summary>
        public const string FRGRVDSC08 = "FRGRVDSC08";

        /// <summary>
        /// FRGRVDSC09.
        /// </summary>
        public const string FRGRVDSC09 = "FRGRVDSC09";

        /// <summary>
        /// FRGRVDSC10.
        /// </summary>
        public const string FRGRVDSC10 = "FRGRVDSC10";

        /// <summary>
        /// FRCO.
        /// </summary>
        public const string FRCO = "FRCO";

        /// <summary>
        /// FRCODES.
        /// </summary>
        public const string FRCODES = "FRCODES";

        /// <summary>
        /// FRMCU.
        /// </summary>
        public const string FRMCU = "FRMCU";

        /// <summary>
        /// FRBUDES.
        /// </summary>
        public const string FRBUDES = "FRBUDES";

        /// <summary>
        /// FROBJ.
        /// </summary>
        public const string FROBJ = "FROBJ";

        /// <summary>
        /// FRSUB.
        /// </summary>
        public const string FRSUB = "FRSUB";

        /// <summary>
        /// FRAID.
        /// </summary>
        public const string FRAID = "FRAID";

        /// <summary>
        /// FRACCDESC.
        /// </summary>
        public const string FRACCDESC = "FRACCDESC";

        /// <summary>
        /// FRLDA.
        /// </summary>
        public const string FRLDA = "FRLDA";

        /// <summary>
        /// FRPEC.
        /// </summary>
        public const string FRPEC = "FRPEC";

        /// <summary>
        /// FRRPRID.
        /// </summary>
        public const string FRRPRID = "FRRPRID";

        /// <summary>
        /// FRRIDDS.
        /// </summary>
        public const string FRRIDDS = "FRRIDDS";

        /// <summary>
        /// FRLODSEQ.
        /// </summary>
        public const string FRLODSEQ = "FRLODSEQ";

        /// <summary>
        /// FRLODTOTAL.
        /// </summary>
        public const string FRLODTOTAL = "FRLODTOTAL";

        /// <summary>
        /// FRGAIGID.
        /// </summary>
        public const string FRGAIGID = "FRGAIGID";

        /// <summary>
        /// FRGAIGDSC.
        /// </summary>
        public const string FRGAIGDSC = "FRGAIGDSC";

        /// <summary>
        /// FRRSTTY.
        /// </summary>
        public const string FRRSTTY = "FRRSTTY";

        /// <summary>
        /// FRRWRSF.
        /// </summary>
        public const string FRRWRSF = "FRRWRSF";

        /// <summary>
        /// FRLODR.
        /// </summary>
        public const string FRLODR = "FRLODR";

        /// <summary>
        /// FRFRNU1.
        /// </summary>
        public const string FRFRNU1 = "FRFRNU1";

        /// <summary>
        /// FRFRNU2.
        /// </summary>
        public const string FRFRNU2 = "FRFRNU2";

        /// <summary>
        /// FRFRNU3.
        /// </summary>
        public const string FRFRNU3 = "FRFRNU3";

        /// <summary>
        /// FRFRST1.
        /// </summary>
        public const string FRFRST1 = "FRFRST1";

        /// <summary>
        /// FRFRST2.
        /// </summary>
        public const string FRFRST2 = "FRFRST2";

        /// <summary>
        /// FRFRST3.
        /// </summary>
        public const string FRFRST3 = "FRFRST3";

        /// <summary>
        /// FRFRCT1.
        /// </summary>
        public const string FRFRCT1 = "FRFRCT1";

        /// <summary>
        /// FRFRCT2.
        /// </summary>
        public const string FRFRCT2 = "FRFRCT2";

        /// <summary>
        /// FRFRCT3.
        /// </summary>
        public const string FRFRCT3 = "FRFRCT3";

        /// <summary>
        /// FRFRDT1.
        /// </summary>
        public const string FRFRDT1 = "FRFRDT1";

        /// <summary>
        /// FRFRDT2.
        /// </summary>
        public const string FRFRDT2 = "FRFRDT2";

        /// <summary>
        /// FRFRDT3.
        /// </summary>
        public const string FRFRDT3 = "FRFRDT3";

        /// <summary>
        /// FRUSER.
        /// </summary>
        public const string FRUSER = "FRUSER";

        /// <summary>
        /// FRRPSTN.
        /// </summary>
        public const string FRRPSTN = "FRRPSTN";

        /// <summary>
        /// FRVERN.
        /// </summary>
        public const string FRVERN = "FRVERN";

        /// <summary>
        /// FRUPMJ.
        /// </summary>
        public const string FRUPMJ = "FRUPMJ";

        /// <summary>
        /// FRUPMT.
        /// </summary>
        public const string FRUPMT = "FRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09300";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FRRUNID", "FRRUNID", JdeDataType.Numeric, null, true, true),
        new JdeField("FRLINN", "FRLINN", JdeDataType.Numeric, null, true, true),
        new JdeField("FRGRPV1", "FRGRPV1", JdeDataType.String, 60, true, true),
        new JdeField("FRGRPV2", "FRGRPV2", JdeDataType.String, 60, true, true),
        new JdeField("FRGRPV3", "FRGRPV3", JdeDataType.String, 60, true, true),
        new JdeField("FRGRPV4", "FRGRPV4", JdeDataType.String, 60, true, true),
        new JdeField("FRGRPV5", "FRGRPV5", JdeDataType.String, 60, true, true),
        new JdeField("FRGRPV6", "FRGRPV6", JdeDataType.String, 60, true, true),
        new JdeField("FRGRPV7", "FRGRPV7", JdeDataType.String, 60, true, true),
        new JdeField("FRGRPV8", "FRGRPV8", JdeDataType.String, 60, true, true),
        new JdeField("FRGRPV9", "FRGRPV9", JdeDataType.String, 60, true, true),
        new JdeField("FRGRPV10", "FRGRPV10", JdeDataType.String, 60, true, true),
        new JdeField("FRCOLAMT01", "FRCOLAMT01", JdeDataType.Numeric),
        new JdeField("FRCOLCUR01", "FRCOLCUR01", JdeDataType.String, 6),
        new JdeField("FRCOLAMT02", "FRCOLAMT02", JdeDataType.Numeric),
        new JdeField("FRCOLCUR02", "FRCOLCUR02", JdeDataType.String, 6),
        new JdeField("FRCOLAMT03", "FRCOLAMT03", JdeDataType.Numeric),
        new JdeField("FRCOLCUR03", "FRCOLCUR03", JdeDataType.String, 6),
        new JdeField("FRCOLAMT04", "FRCOLAMT04", JdeDataType.Numeric),
        new JdeField("FRCOLCUR04", "FRCOLCUR04", JdeDataType.String, 6),
        new JdeField("FRCOLAMT05", "FRCOLAMT05", JdeDataType.Numeric),
        new JdeField("FRCOLCUR05", "FRCOLCUR05", JdeDataType.String, 6),
        new JdeField("FRCOLAMT06", "FRCOLAMT06", JdeDataType.Numeric),
        new JdeField("FRCOLCUR06", "FRCOLCUR06", JdeDataType.String, 6),
        new JdeField("FRCOLAMT07", "FRCOLAMT07", JdeDataType.Numeric),
        new JdeField("FRCOLCUR07", "FRCOLCUR07", JdeDataType.String, 6),
        new JdeField("FRCOLAMT08", "FRCOLAMT08", JdeDataType.Numeric),
        new JdeField("FRCOLCUR08", "FRCOLCUR08", JdeDataType.String, 6),
        new JdeField("FRCOLAMT09", "FRCOLAMT09", JdeDataType.Numeric),
        new JdeField("FRCOLCUR09", "FRCOLCUR09", JdeDataType.String, 6),
        new JdeField("FRCOLAMT10", "FRCOLAMT10", JdeDataType.Numeric),
        new JdeField("FRCOLCUR10", "FRCOLCUR10", JdeDataType.String, 6),
        new JdeField("FRCOLAMT11", "FRCOLAMT11", JdeDataType.Numeric),
        new JdeField("FRCOLCUR11", "FRCOLCUR11", JdeDataType.String, 6),
        new JdeField("FRCOLAMT12", "FRCOLAMT12", JdeDataType.Numeric),
        new JdeField("FRCOLCUR12", "FRCOLCUR12", JdeDataType.String, 6),
        new JdeField("FRCOLAMT13", "FRCOLAMT13", JdeDataType.Numeric),
        new JdeField("FRCOLCUR13", "FRCOLCUR13", JdeDataType.String, 6),
        new JdeField("FRCOLAMT14", "FRCOLAMT14", JdeDataType.Numeric),
        new JdeField("FRCOLCUR14", "FRCOLCUR14", JdeDataType.String, 6),
        new JdeField("FRCOLAMT15", "FRCOLAMT15", JdeDataType.Numeric),
        new JdeField("FRCOLCUR15", "FRCOLCUR15", JdeDataType.String, 6),
        new JdeField("FRCOLAMT16", "FRCOLAMT16", JdeDataType.Numeric),
        new JdeField("FRCOLCUR16", "FRCOLCUR16", JdeDataType.String, 6),
        new JdeField("FRCOLAMT17", "FRCOLAMT17", JdeDataType.Numeric),
        new JdeField("FRCOLCUR17", "FRCOLCUR17", JdeDataType.String, 6),
        new JdeField("FRCOLAMT18", "FRCOLAMT18", JdeDataType.Numeric),
        new JdeField("FRCOLCUR18", "FRCOLCUR18", JdeDataType.String, 6),
        new JdeField("FRCOLAMT19", "FRCOLAMT19", JdeDataType.Numeric),
        new JdeField("FRCOLCUR19", "FRCOLCUR19", JdeDataType.String, 6),
        new JdeField("FRCOLAMT20", "FRCOLAMT20", JdeDataType.Numeric),
        new JdeField("FRCOLCUR20", "FRCOLCUR20", JdeDataType.String, 6),
        new JdeField("FRCOLAMT21", "FRCOLAMT21", JdeDataType.Numeric),
        new JdeField("FRCOLCUR21", "FRCOLCUR21", JdeDataType.String, 6),
        new JdeField("FRCOLAMT22", "FRCOLAMT22", JdeDataType.Numeric),
        new JdeField("FRCOLCUR22", "FRCOLCUR22", JdeDataType.String, 6),
        new JdeField("FRCOLAMT23", "FRCOLAMT23", JdeDataType.Numeric),
        new JdeField("FRCOLCUR23", "FRCOLCUR23", JdeDataType.String, 6),
        new JdeField("FRCOLAMT24", "FRCOLAMT24", JdeDataType.Numeric),
        new JdeField("FRCOLCUR24", "FRCOLCUR24", JdeDataType.String, 6),
        new JdeField("FRCOLAMT25", "FRCOLAMT25", JdeDataType.Numeric),
        new JdeField("FRCOLCUR25", "FRCOLCUR25", JdeDataType.String, 6),
        new JdeField("FRGRVDSC01", "FRGRVDSC01", JdeDataType.String, 80),
        new JdeField("FRGRVDSC02", "FRGRVDSC02", JdeDataType.String, 80),
        new JdeField("FRGRVDSC03", "FRGRVDSC03", JdeDataType.String, 80),
        new JdeField("FRGRVDSC04", "FRGRVDSC04", JdeDataType.String, 80),
        new JdeField("FRGRVDSC05", "FRGRVDSC05", JdeDataType.String, 80),
        new JdeField("FRGRVDSC06", "FRGRVDSC06", JdeDataType.String, 80),
        new JdeField("FRGRVDSC07", "FRGRVDSC07", JdeDataType.String, 80),
        new JdeField("FRGRVDSC08", "FRGRVDSC08", JdeDataType.String, 80),
        new JdeField("FRGRVDSC09", "FRGRVDSC09", JdeDataType.String, 80),
        new JdeField("FRGRVDSC10", "FRGRVDSC10", JdeDataType.String, 80),
        new JdeField("FRCO", "FRCO", JdeDataType.String, 10),
        new JdeField("FRCODES", "FRCODES", JdeDataType.String, 60),
        new JdeField("FRMCU", "FRMCU", JdeDataType.String, 24),
        new JdeField("FRBUDES", "FRBUDES", JdeDataType.String, 60),
        new JdeField("FROBJ", "FROBJ", JdeDataType.String, 12),
        new JdeField("FRSUB", "FRSUB", JdeDataType.String, 16),
        new JdeField("FRAID", "FRAID", JdeDataType.String, 16),
        new JdeField("FRACCDESC", "FRACCDESC", JdeDataType.String, 60),
        new JdeField("FRLDA", "FRLDA", JdeDataType.String, 2),
        new JdeField("FRPEC", "FRPEC", JdeDataType.String, 2),
        new JdeField("FRRPRID", "FRRPRID", JdeDataType.Numeric, null, true, true),
        new JdeField("FRRIDDS", "FRRIDDS", JdeDataType.String, 160),
        new JdeField("FRLODSEQ", "FRLODSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("FRLODTOTAL", "FRLODTOTAL", JdeDataType.String, 2),
        new JdeField("FRGAIGID", "FRGAIGID", JdeDataType.String, 20),
        new JdeField("FRGAIGDSC", "FRGAIGDSC", JdeDataType.String, 80),
        new JdeField("FRRSTTY", "FRRSTTY", JdeDataType.String, 2),
        new JdeField("FRRWRSF", "FRRWRSF", JdeDataType.String, 2),
        new JdeField("FRLODR", "FRLODR", JdeDataType.String, 2),
        new JdeField("FRFRNU1", "FRFRNU1", JdeDataType.Numeric),
        new JdeField("FRFRNU2", "FRFRNU2", JdeDataType.Numeric),
        new JdeField("FRFRNU3", "FRFRNU3", JdeDataType.Numeric),
        new JdeField("FRFRST1", "FRFRST1", JdeDataType.String, 160),
        new JdeField("FRFRST2", "FRFRST2", JdeDataType.String, 160),
        new JdeField("FRFRST3", "FRFRST3", JdeDataType.String, 160),
        new JdeField("FRFRCT1", "FRFRCT1", JdeDataType.String, 2),
        new JdeField("FRFRCT2", "FRFRCT2", JdeDataType.String, 2),
        new JdeField("FRFRCT3", "FRFRCT3", JdeDataType.String, 2),
        new JdeField("FRFRDT1", "FRFRDT1", JdeDataType.Numeric),
        new JdeField("FRFRDT2", "FRFRDT2", JdeDataType.Numeric),
        new JdeField("FRFRDT3", "FRFRDT3", JdeDataType.Numeric),
        new JdeField("FRUSER", "FRUSER", JdeDataType.String, 20),
        new JdeField("FRRPSTN", "FRRPSTN", JdeDataType.String, 40),
        new JdeField("FRVERN", "FRVERN", JdeDataType.String, 40),
        new JdeField("FRUPMJ", "FRUPMJ", JdeDataType.Numeric),
        new JdeField("FRUPMT", "FRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09300_0", "Primary Key on FRRUNID, FRRPRID, FRLODSEQ, FRLINN, FRGRPV1, FRGRPV2, FRGRPV3, FRGRPV4, FRGRPV5, FRGRPV6, FRGRPV7, FRGRPV8, FRGRPV9, FRGRPV10", new[] { "FRRUNID", "FRRPRID", "FRLODSEQ", "FRLINN", "FRGRPV1", "FRGRPV2", "FRGRPV3", "FRGRPV4", "FRGRPV5", "FRGRPV6", "FRGRPV7", "FRGRPV8", "FRGRPV9", "FRGRPV10" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09300_2", "Index on FRRUNID, FRRPRID, FRCO, FRMCU, SYS_NC00109$, SYS_NC00110$", new[] { "FRRUNID", "FRRPRID", "FRCO", "FRMCU", "SYS_NC00109$", "SYS_NC00110$" }),
        new JdeIndex("F09300_3", "Index on FRUSER, FRRPSTN, FRVERN", new[] { "FRUSER", "FRRPSTN", "FRVERN" }),
        new JdeIndex("F09300_4", "Index on FRRUNID, FRRPRID, SYS_NC00109$, SYS_NC00110$", new[] { "FRRUNID", "FRRPRID", "SYS_NC00109$", "SYS_NC00110$" }),
        new JdeIndex("F09300_5", "Index on FRRUNID, FRRPRID, FRCO, FRMCU, FROBJ, FRSUB", new[] { "FRRUNID", "FRRPRID", "FRCO", "FRMCU", "FROBJ", "FRSUB" })
    };
}
