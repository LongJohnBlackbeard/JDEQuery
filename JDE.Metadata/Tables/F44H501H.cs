using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H501H - .
/// </summary>
public class F44H501H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LSHBMCUS.
        /// </summary>
        public const string LSHBMCUS = "LSHBMCUS";

        /// <summary>
        /// LSHBLOT.
        /// </summary>
        public const string LSHBLOT = "LSHBLOT";

        /// <summary>
        /// LSCSSEQ.
        /// </summary>
        public const string LSCSSEQ = "LSCSSEQ";

        /// <summary>
        /// LSSHSEQ.
        /// </summary>
        public const string LSSHSEQ = "LSSHSEQ";

        /// <summary>
        /// LSACTVSEQ.
        /// </summary>
        public const string LSACTVSEQ = "LSACTVSEQ";

        /// <summary>
        /// LSMCU.
        /// </summary>
        public const string LSMCU = "LSMCU";

        /// <summary>
        /// LSHBAREA.
        /// </summary>
        public const string LSHBAREA = "LSHBAREA";

        /// <summary>
        /// LSCPHASE.
        /// </summary>
        public const string LSCPHASE = "LSCPHASE";

        /// <summary>
        /// LSBYR.
        /// </summary>
        public const string LSBYR = "LSBYR";

        /// <summary>
        /// LSMLTBYR.
        /// </summary>
        public const string LSMLTBYR = "LSMLTBYR";

        /// <summary>
        /// LSHBPLAN.
        /// </summary>
        public const string LSHBPLAN = "LSHBPLAN";

        /// <summary>
        /// LSHBELEV.
        /// </summary>
        public const string LSHBELEV = "LSHBELEV";

        /// <summary>
        /// LSSWING.
        /// </summary>
        public const string LSSWING = "LSSWING";

        /// <summary>
        /// LSSALLST.
        /// </summary>
        public const string LSSALLST = "LSSALLST";

        /// <summary>
        /// LSSALNXT.
        /// </summary>
        public const string LSSALNXT = "LSSALNXT";

        /// <summary>
        /// LSDCG.
        /// </summary>
        public const string LSDCG = "LSDCG";

        /// <summary>
        /// LSCONACT.
        /// </summary>
        public const string LSCONACT = "LSCONACT";

        /// <summary>
        /// LSHBSCS.
        /// </summary>
        public const string LSHBSCS = "LSHBSCS";

        /// <summary>
        /// LSSDJ.
        /// </summary>
        public const string LSSDJ = "LSSDJ";

        /// <summary>
        /// LSSRPDJ.
        /// </summary>
        public const string LSSRPDJ = "LSSRPDJ";

        /// <summary>
        /// LSSRDJ.
        /// </summary>
        public const string LSSRDJ = "LSSRDJ";

        /// <summary>
        /// LSCAPRVL.
        /// </summary>
        public const string LSCAPRVL = "LSCAPRVL";

        /// <summary>
        /// LSECDJ.
        /// </summary>
        public const string LSECDJ = "LSECDJ";

        /// <summary>
        /// LSCDJ.
        /// </summary>
        public const string LSCDJ = "LSCDJ";

        /// <summary>
        /// LSEDJ.
        /// </summary>
        public const string LSEDJ = "LSEDJ";

        /// <summary>
        /// LSCSRCD.
        /// </summary>
        public const string LSCSRCD = "LSCSRCD";

        /// <summary>
        /// LSCSN1.
        /// </summary>
        public const string LSCSN1 = "LSCSN1";

        /// <summary>
        /// LSCSN2.
        /// </summary>
        public const string LSCSN2 = "LSCSN2";

        /// <summary>
        /// LSCSN3.
        /// </summary>
        public const string LSCSN3 = "LSCSN3";

        /// <summary>
        /// LSBHPRICE.
        /// </summary>
        public const string LSBHPRICE = "LSBHPRICE";

        /// <summary>
        /// LSLOTPREM.
        /// </summary>
        public const string LSLOTPREM = "LSLOTPREM";

        /// <summary>
        /// LSINCA1.
        /// </summary>
        public const string LSINCA1 = "LSINCA1";

        /// <summary>
        /// LSINCA2.
        /// </summary>
        public const string LSINCA2 = "LSINCA2";

        /// <summary>
        /// LSINCA3.
        /// </summary>
        public const string LSINCA3 = "LSINCA3";

        /// <summary>
        /// LSUPG.
        /// </summary>
        public const string LSUPG = "LSUPG";

        /// <summary>
        /// LSNETBP.
        /// </summary>
        public const string LSNETBP = "LSNETBP";

        /// <summary>
        /// LSOPRV1.
        /// </summary>
        public const string LSOPRV1 = "LSOPRV1";

        /// <summary>
        /// LSOPRV2.
        /// </summary>
        public const string LSOPRV2 = "LSOPRV2";

        /// <summary>
        /// LSOPRV3.
        /// </summary>
        public const string LSOPRV3 = "LSOPRV3";

        /// <summary>
        /// LSOPRV4.
        /// </summary>
        public const string LSOPRV4 = "LSOPRV4";

        /// <summary>
        /// LSOPRV5.
        /// </summary>
        public const string LSOPRV5 = "LSOPRV5";

        /// <summary>
        /// LSOPRV6.
        /// </summary>
        public const string LSOPRV6 = "LSOPRV6";

        /// <summary>
        /// LSOPRV7.
        /// </summary>
        public const string LSOPRV7 = "LSOPRV7";

        /// <summary>
        /// LSOPRV8.
        /// </summary>
        public const string LSOPRV8 = "LSOPRV8";

        /// <summary>
        /// LSOPRV9.
        /// </summary>
        public const string LSOPRV9 = "LSOPRV9";

        /// <summary>
        /// LSOPINCA.
        /// </summary>
        public const string LSOPINCA = "LSOPINCA";

        /// <summary>
        /// LSNETOPT.
        /// </summary>
        public const string LSNETOPT = "LSNETOPT";

        /// <summary>
        /// LSTOTSAL.
        /// </summary>
        public const string LSTOTSAL = "LSTOTSAL";

        /// <summary>
        /// LSANSM01.
        /// </summary>
        public const string LSANSM01 = "LSANSM01";

        /// <summary>
        /// LSANSM02.
        /// </summary>
        public const string LSANSM02 = "LSANSM02";

        /// <summary>
        /// LSANSM03.
        /// </summary>
        public const string LSANSM03 = "LSANSM03";

        /// <summary>
        /// LSANSM04.
        /// </summary>
        public const string LSANSM04 = "LSANSM04";

        /// <summary>
        /// LSANSM05.
        /// </summary>
        public const string LSANSM05 = "LSANSM05";

        /// <summary>
        /// LSANSM06.
        /// </summary>
        public const string LSANSM06 = "LSANSM06";

        /// <summary>
        /// LSANSM07.
        /// </summary>
        public const string LSANSM07 = "LSANSM07";

        /// <summary>
        /// LSANSM08.
        /// </summary>
        public const string LSANSM08 = "LSANSM08";

        /// <summary>
        /// LSANSM09.
        /// </summary>
        public const string LSANSM09 = "LSANSM09";

        /// <summary>
        /// LSANSM10.
        /// </summary>
        public const string LSANSM10 = "LSANSM10";

        /// <summary>
        /// LSCMPCT1.
        /// </summary>
        public const string LSCMPCT1 = "LSCMPCT1";

        /// <summary>
        /// LSCMPCT2.
        /// </summary>
        public const string LSCMPCT2 = "LSCMPCT2";

        /// <summary>
        /// LSCMPCT3.
        /// </summary>
        public const string LSCMPCT3 = "LSCMPCT3";

        /// <summary>
        /// LSCMPCT4.
        /// </summary>
        public const string LSCMPCT4 = "LSCMPCT4";

        /// <summary>
        /// LSCMPCT5.
        /// </summary>
        public const string LSCMPCT5 = "LSCMPCT5";

        /// <summary>
        /// LSCMPCT6.
        /// </summary>
        public const string LSCMPCT6 = "LSCMPCT6";

        /// <summary>
        /// LSCMPCT7.
        /// </summary>
        public const string LSCMPCT7 = "LSCMPCT7";

        /// <summary>
        /// LSCMPCT8.
        /// </summary>
        public const string LSCMPCT8 = "LSCMPCT8";

        /// <summary>
        /// LSCMPCT9.
        /// </summary>
        public const string LSCMPCT9 = "LSCMPCT9";

        /// <summary>
        /// LSCMPCT10.
        /// </summary>
        public const string LSCMPCT10 = "LSCMPCT10";

        /// <summary>
        /// LSCM1.
        /// </summary>
        public const string LSCM1 = "LSCM1";

        /// <summary>
        /// LSCM2.
        /// </summary>
        public const string LSCM2 = "LSCM2";

        /// <summary>
        /// LSCM3.
        /// </summary>
        public const string LSCM3 = "LSCM3";

        /// <summary>
        /// LSCM4.
        /// </summary>
        public const string LSCM4 = "LSCM4";

        /// <summary>
        /// LSCM5.
        /// </summary>
        public const string LSCM5 = "LSCM5";

        /// <summary>
        /// LSCM6.
        /// </summary>
        public const string LSCM6 = "LSCM6";

        /// <summary>
        /// LSCM7.
        /// </summary>
        public const string LSCM7 = "LSCM7";

        /// <summary>
        /// LSCM8.
        /// </summary>
        public const string LSCM8 = "LSCM8";

        /// <summary>
        /// LSCM9.
        /// </summary>
        public const string LSCM9 = "LSCM9";

        /// <summary>
        /// LSCM10.
        /// </summary>
        public const string LSCM10 = "LSCM10";

        /// <summary>
        /// LSLDR.
        /// </summary>
        public const string LSLDR = "LSLDR";

        /// <summary>
        /// LSLOANNUM.
        /// </summary>
        public const string LSLOANNUM = "LSLOANNUM";

        /// <summary>
        /// LSLOANTYP.
        /// </summary>
        public const string LSLOANTYP = "LSLOANTYP";

        /// <summary>
        /// LSMGA.
        /// </summary>
        public const string LSMGA = "LSMGA";

        /// <summary>
        /// LSINRTE.
        /// </summary>
        public const string LSINRTE = "LSINRTE";

        /// <summary>
        /// LSINRLCK.
        /// </summary>
        public const string LSINRLCK = "LSINRLCK";

        /// <summary>
        /// LSPXD.
        /// </summary>
        public const string LSPXD = "LSPXD";

        /// <summary>
        /// LSDNPT.
        /// </summary>
        public const string LSDNPT = "LSDNPT";

        /// <summary>
        /// LSEMD.
        /// </summary>
        public const string LSEMD = "LSEMD";

        /// <summary>
        /// LSDTKN.
        /// </summary>
        public const string LSDTKN = "LSDTKN";

        /// <summary>
        /// LSMAD.
        /// </summary>
        public const string LSMAD = "LSMAD";

        /// <summary>
        /// LSTAD.
        /// </summary>
        public const string LSTAD = "LSTAD";

        /// <summary>
        /// LSLADJ.
        /// </summary>
        public const string LSLADJ = "LSLADJ";

        /// <summary>
        /// LSCTG.
        /// </summary>
        public const string LSCTG = "LSCTG";

        /// <summary>
        /// LSCTGS.
        /// </summary>
        public const string LSCTGS = "LSCTGS";

        /// <summary>
        /// LSPTX.
        /// </summary>
        public const string LSPTX = "LSPTX";

        /// <summary>
        /// LSCTGJ.
        /// </summary>
        public const string LSCTGJ = "LSCTGJ";

        /// <summary>
        /// LSLRD.
        /// </summary>
        public const string LSLRD = "LSLRD";

        /// <summary>
        /// LSCCNVD.
        /// </summary>
        public const string LSCCNVD = "LSCCNVD";

        /// <summary>
        /// LSCLJ.
        /// </summary>
        public const string LSCLJ = "LSCLJ";

        /// <summary>
        /// LSCXD.
        /// </summary>
        public const string LSCXD = "LSCXD";

        /// <summary>
        /// LSCRD.
        /// </summary>
        public const string LSCRD = "LSCRD";

        /// <summary>
        /// LSCN1.
        /// </summary>
        public const string LSCN1 = "LSCN1";

        /// <summary>
        /// LSCN2.
        /// </summary>
        public const string LSCN2 = "LSCN2";

        /// <summary>
        /// LSLAG.
        /// </summary>
        public const string LSLAG = "LSLAG";

        /// <summary>
        /// LSDCAPPT.
        /// </summary>
        public const string LSDCAPPT = "LSDCAPPT";

        /// <summary>
        /// LSDCSTM.
        /// </summary>
        public const string LSDCSTM = "LSDCSTM";

        /// <summary>
        /// LSDCADT.
        /// </summary>
        public const string LSDCADT = "LSDCADT";

        /// <summary>
        /// LSCLT.
        /// </summary>
        public const string LSCLT = "LSCLT";

        /// <summary>
        /// LSTEDJ.
        /// </summary>
        public const string LSTEDJ = "LSTEDJ";

        /// <summary>
        /// LSTIDJ.
        /// </summary>
        public const string LSTIDJ = "LSTIDJ";

        /// <summary>
        /// LSTLN1.
        /// </summary>
        public const string LSTLN1 = "LSTLN1";

        /// <summary>
        /// LSTLN2.
        /// </summary>
        public const string LSTLN2 = "LSTLN2";

        /// <summary>
        /// LSTLN3.
        /// </summary>
        public const string LSTLN3 = "LSTLN3";

        /// <summary>
        /// LSBSWD.
        /// </summary>
        public const string LSBSWD = "LSBSWD";

        /// <summary>
        /// LSBSWT.
        /// </summary>
        public const string LSBSWT = "LSBSWT";

        /// <summary>
        /// LSBAWD.
        /// </summary>
        public const string LSBAWD = "LSBAWD";

        /// <summary>
        /// LSUSD1.
        /// </summary>
        public const string LSUSD1 = "LSUSD1";

        /// <summary>
        /// LSUSD2.
        /// </summary>
        public const string LSUSD2 = "LSUSD2";

        /// <summary>
        /// LSUSD3.
        /// </summary>
        public const string LSUSD3 = "LSUSD3";

        /// <summary>
        /// LSUSD4.
        /// </summary>
        public const string LSUSD4 = "LSUSD4";

        /// <summary>
        /// LSUSD5.
        /// </summary>
        public const string LSUSD5 = "LSUSD5";

        /// <summary>
        /// LSUSD6.
        /// </summary>
        public const string LSUSD6 = "LSUSD6";

        /// <summary>
        /// LSUSD7.
        /// </summary>
        public const string LSUSD7 = "LSUSD7";

        /// <summary>
        /// LSUSD8.
        /// </summary>
        public const string LSUSD8 = "LSUSD8";

        /// <summary>
        /// LSUSD9.
        /// </summary>
        public const string LSUSD9 = "LSUSD9";

        /// <summary>
        /// LSUSD10.
        /// </summary>
        public const string LSUSD10 = "LSUSD10";

        /// <summary>
        /// LSUSD11.
        /// </summary>
        public const string LSUSD11 = "LSUSD11";

        /// <summary>
        /// LSUSD12.
        /// </summary>
        public const string LSUSD12 = "LSUSD12";

        /// <summary>
        /// LSUSD13.
        /// </summary>
        public const string LSUSD13 = "LSUSD13";

        /// <summary>
        /// LSUSD14.
        /// </summary>
        public const string LSUSD14 = "LSUSD14";

        /// <summary>
        /// LSUSD15.
        /// </summary>
        public const string LSUSD15 = "LSUSD15";

        /// <summary>
        /// LSUSD16.
        /// </summary>
        public const string LSUSD16 = "LSUSD16";

        /// <summary>
        /// LSUSD17.
        /// </summary>
        public const string LSUSD17 = "LSUSD17";

        /// <summary>
        /// LSUSD18.
        /// </summary>
        public const string LSUSD18 = "LSUSD18";

        /// <summary>
        /// LSUSD19.
        /// </summary>
        public const string LSUSD19 = "LSUSD19";

        /// <summary>
        /// LSUSD20.
        /// </summary>
        public const string LSUSD20 = "LSUSD20";

        /// <summary>
        /// LSUAMT01.
        /// </summary>
        public const string LSUAMT01 = "LSUAMT01";

        /// <summary>
        /// LSUAMT02.
        /// </summary>
        public const string LSUAMT02 = "LSUAMT02";

        /// <summary>
        /// LSUAMT03.
        /// </summary>
        public const string LSUAMT03 = "LSUAMT03";

        /// <summary>
        /// LSUAMT04.
        /// </summary>
        public const string LSUAMT04 = "LSUAMT04";

        /// <summary>
        /// LSUAMT05.
        /// </summary>
        public const string LSUAMT05 = "LSUAMT05";

        /// <summary>
        /// LSUAMT06.
        /// </summary>
        public const string LSUAMT06 = "LSUAMT06";

        /// <summary>
        /// LSUAMT07.
        /// </summary>
        public const string LSUAMT07 = "LSUAMT07";

        /// <summary>
        /// LSUAMT08.
        /// </summary>
        public const string LSUAMT08 = "LSUAMT08";

        /// <summary>
        /// LSUAMT09.
        /// </summary>
        public const string LSUAMT09 = "LSUAMT09";

        /// <summary>
        /// LSUAMT10.
        /// </summary>
        public const string LSUAMT10 = "LSUAMT10";

        /// <summary>
        /// LSSMC01.
        /// </summary>
        public const string LSSMC01 = "LSSMC01";

        /// <summary>
        /// LSSMC02.
        /// </summary>
        public const string LSSMC02 = "LSSMC02";

        /// <summary>
        /// LSSMC03.
        /// </summary>
        public const string LSSMC03 = "LSSMC03";

        /// <summary>
        /// LSSMC04.
        /// </summary>
        public const string LSSMC04 = "LSSMC04";

        /// <summary>
        /// LSSMC05.
        /// </summary>
        public const string LSSMC05 = "LSSMC05";

        /// <summary>
        /// LSSMC06.
        /// </summary>
        public const string LSSMC06 = "LSSMC06";

        /// <summary>
        /// LSSMC07.
        /// </summary>
        public const string LSSMC07 = "LSSMC07";

        /// <summary>
        /// LSSMC08.
        /// </summary>
        public const string LSSMC08 = "LSSMC08";

        /// <summary>
        /// LSSMC09.
        /// </summary>
        public const string LSSMC09 = "LSSMC09";

        /// <summary>
        /// LSSMC10.
        /// </summary>
        public const string LSSMC10 = "LSSMC10";

        /// <summary>
        /// LSUSAN01.
        /// </summary>
        public const string LSUSAN01 = "LSUSAN01";

        /// <summary>
        /// LSUSAN02.
        /// </summary>
        public const string LSUSAN02 = "LSUSAN02";

        /// <summary>
        /// LSUSAN03.
        /// </summary>
        public const string LSUSAN03 = "LSUSAN03";

        /// <summary>
        /// LSUSAN04.
        /// </summary>
        public const string LSUSAN04 = "LSUSAN04";

        /// <summary>
        /// LSUSAN05.
        /// </summary>
        public const string LSUSAN05 = "LSUSAN05";

        /// <summary>
        /// LSHBST1.
        /// </summary>
        public const string LSHBST1 = "LSHBST1";

        /// <summary>
        /// LSHBST2.
        /// </summary>
        public const string LSHBST2 = "LSHBST2";

        /// <summary>
        /// LSHBST3.
        /// </summary>
        public const string LSHBST3 = "LSHBST3";

        /// <summary>
        /// LSHBST4.
        /// </summary>
        public const string LSHBST4 = "LSHBST4";

        /// <summary>
        /// LSHBST5.
        /// </summary>
        public const string LSHBST5 = "LSHBST5";

        /// <summary>
        /// LSCONLST.
        /// </summary>
        public const string LSCONLST = "LSCONLST";

        /// <summary>
        /// LSCONNXT.
        /// </summary>
        public const string LSCONNXT = "LSCONNXT";

        /// <summary>
        /// LSLSTATHB.
        /// </summary>
        public const string LSLSTATHB = "LSLSTATHB";

        /// <summary>
        /// LSCONSSEQ.
        /// </summary>
        public const string LSCONSSEQ = "LSCONSSEQ";

        /// <summary>
        /// LSCTY1.
        /// </summary>
        public const string LSCTY1 = "LSCTY1";

        /// <summary>
        /// LSADDS.
        /// </summary>
        public const string LSADDS = "LSADDS";

        /// <summary>
        /// LSADDZ.
        /// </summary>
        public const string LSADDZ = "LSADDZ";

        /// <summary>
        /// LSLOTADD.
        /// </summary>
        public const string LSLOTADD = "LSLOTADD";

        /// <summary>
        /// LSLPP.
        /// </summary>
        public const string LSLPP = "LSLPP";

        /// <summary>
        /// LSCRTU.
        /// </summary>
        public const string LSCRTU = "LSCRTU";

        /// <summary>
        /// LSCRTJ.
        /// </summary>
        public const string LSCRTJ = "LSCRTJ";

        /// <summary>
        /// LSCRTT.
        /// </summary>
        public const string LSCRTT = "LSCRTT";

        /// <summary>
        /// LSWRKSTNID.
        /// </summary>
        public const string LSWRKSTNID = "LSWRKSTNID";

        /// <summary>
        /// LSHBOPID.
        /// </summary>
        public const string LSHBOPID = "LSHBOPID";

        /// <summary>
        /// LSUPMB.
        /// </summary>
        public const string LSUPMB = "LSUPMB";

        /// <summary>
        /// LSUPMJ.
        /// </summary>
        public const string LSUPMJ = "LSUPMJ";

        /// <summary>
        /// LSUPMT.
        /// </summary>
        public const string LSUPMT = "LSUPMT";

        /// <summary>
        /// LSJOBN.
        /// </summary>
        public const string LSJOBN = "LSJOBN";

        /// <summary>
        /// LSPID.
        /// </summary>
        public const string LSPID = "LSPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H501H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LSHBMCUS", "LSHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("LSHBLOT", "LSHBLOT", JdeDataType.String, 8, true, true),
        new JdeField("LSCSSEQ", "LSCSSEQ", JdeDataType.String, 6, true, true),
        new JdeField("LSSHSEQ", "LSSHSEQ", JdeDataType.String, 6, true, true),
        new JdeField("LSACTVSEQ", "LSACTVSEQ", JdeDataType.String, 2),
        new JdeField("LSMCU", "LSMCU", JdeDataType.String, 24),
        new JdeField("LSHBAREA", "LSHBAREA", JdeDataType.String, 6),
        new JdeField("LSCPHASE", "LSCPHASE", JdeDataType.String, 6),
        new JdeField("LSBYR", "LSBYR", JdeDataType.Numeric),
        new JdeField("LSMLTBYR", "LSMLTBYR", JdeDataType.String, 2),
        new JdeField("LSHBPLAN", "LSHBPLAN", JdeDataType.String, 8),
        new JdeField("LSHBELEV", "LSHBELEV", JdeDataType.String, 6),
        new JdeField("LSSWING", "LSSWING", JdeDataType.String, 2),
        new JdeField("LSSALLST", "LSSALLST", JdeDataType.String, 6),
        new JdeField("LSSALNXT", "LSSALNXT", JdeDataType.String, 6),
        new JdeField("LSDCG", "LSDCG", JdeDataType.Numeric),
        new JdeField("LSCONACT", "LSCONACT", JdeDataType.String, 6),
        new JdeField("LSHBSCS", "LSHBSCS", JdeDataType.String, 6),
        new JdeField("LSSDJ", "LSSDJ", JdeDataType.Numeric),
        new JdeField("LSSRPDJ", "LSSRPDJ", JdeDataType.Numeric),
        new JdeField("LSSRDJ", "LSSRDJ", JdeDataType.Numeric),
        new JdeField("LSCAPRVL", "LSCAPRVL", JdeDataType.Numeric),
        new JdeField("LSECDJ", "LSECDJ", JdeDataType.Numeric),
        new JdeField("LSCDJ", "LSCDJ", JdeDataType.Numeric),
        new JdeField("LSEDJ", "LSEDJ", JdeDataType.Numeric),
        new JdeField("LSCSRCD", "LSCSRCD", JdeDataType.String, 6),
        new JdeField("LSCSN1", "LSCSN1", JdeDataType.String, 60),
        new JdeField("LSCSN2", "LSCSN2", JdeDataType.String, 60),
        new JdeField("LSCSN3", "LSCSN3", JdeDataType.String, 60),
        new JdeField("LSBHPRICE", "LSBHPRICE", JdeDataType.Numeric),
        new JdeField("LSLOTPREM", "LSLOTPREM", JdeDataType.Numeric),
        new JdeField("LSINCA1", "LSINCA1", JdeDataType.Numeric),
        new JdeField("LSINCA2", "LSINCA2", JdeDataType.Numeric),
        new JdeField("LSINCA3", "LSINCA3", JdeDataType.Numeric),
        new JdeField("LSUPG", "LSUPG", JdeDataType.Numeric),
        new JdeField("LSNETBP", "LSNETBP", JdeDataType.Numeric),
        new JdeField("LSOPRV1", "LSOPRV1", JdeDataType.Numeric),
        new JdeField("LSOPRV2", "LSOPRV2", JdeDataType.Numeric),
        new JdeField("LSOPRV3", "LSOPRV3", JdeDataType.Numeric),
        new JdeField("LSOPRV4", "LSOPRV4", JdeDataType.Numeric),
        new JdeField("LSOPRV5", "LSOPRV5", JdeDataType.Numeric),
        new JdeField("LSOPRV6", "LSOPRV6", JdeDataType.Numeric),
        new JdeField("LSOPRV7", "LSOPRV7", JdeDataType.Numeric),
        new JdeField("LSOPRV8", "LSOPRV8", JdeDataType.Numeric),
        new JdeField("LSOPRV9", "LSOPRV9", JdeDataType.Numeric),
        new JdeField("LSOPINCA", "LSOPINCA", JdeDataType.Numeric),
        new JdeField("LSNETOPT", "LSNETOPT", JdeDataType.Numeric),
        new JdeField("LSTOTSAL", "LSTOTSAL", JdeDataType.Numeric),
        new JdeField("LSANSM01", "LSANSM01", JdeDataType.Numeric),
        new JdeField("LSANSM02", "LSANSM02", JdeDataType.Numeric),
        new JdeField("LSANSM03", "LSANSM03", JdeDataType.Numeric),
        new JdeField("LSANSM04", "LSANSM04", JdeDataType.Numeric),
        new JdeField("LSANSM05", "LSANSM05", JdeDataType.Numeric),
        new JdeField("LSANSM06", "LSANSM06", JdeDataType.Numeric),
        new JdeField("LSANSM07", "LSANSM07", JdeDataType.Numeric),
        new JdeField("LSANSM08", "LSANSM08", JdeDataType.Numeric),
        new JdeField("LSANSM09", "LSANSM09", JdeDataType.Numeric),
        new JdeField("LSANSM10", "LSANSM10", JdeDataType.Numeric),
        new JdeField("LSCMPCT1", "LSCMPCT1", JdeDataType.Numeric),
        new JdeField("LSCMPCT2", "LSCMPCT2", JdeDataType.Numeric),
        new JdeField("LSCMPCT3", "LSCMPCT3", JdeDataType.Numeric),
        new JdeField("LSCMPCT4", "LSCMPCT4", JdeDataType.Numeric),
        new JdeField("LSCMPCT5", "LSCMPCT5", JdeDataType.Numeric),
        new JdeField("LSCMPCT6", "LSCMPCT6", JdeDataType.Numeric),
        new JdeField("LSCMPCT7", "LSCMPCT7", JdeDataType.Numeric),
        new JdeField("LSCMPCT8", "LSCMPCT8", JdeDataType.Numeric),
        new JdeField("LSCMPCT9", "LSCMPCT9", JdeDataType.Numeric),
        new JdeField("LSCMPCT10", "LSCMPCT10", JdeDataType.Numeric),
        new JdeField("LSCM1", "LSCM1", JdeDataType.Numeric),
        new JdeField("LSCM2", "LSCM2", JdeDataType.Numeric),
        new JdeField("LSCM3", "LSCM3", JdeDataType.Numeric),
        new JdeField("LSCM4", "LSCM4", JdeDataType.Numeric),
        new JdeField("LSCM5", "LSCM5", JdeDataType.Numeric),
        new JdeField("LSCM6", "LSCM6", JdeDataType.Numeric),
        new JdeField("LSCM7", "LSCM7", JdeDataType.Numeric),
        new JdeField("LSCM8", "LSCM8", JdeDataType.Numeric),
        new JdeField("LSCM9", "LSCM9", JdeDataType.Numeric),
        new JdeField("LSCM10", "LSCM10", JdeDataType.Numeric),
        new JdeField("LSLDR", "LSLDR", JdeDataType.Numeric),
        new JdeField("LSLOANNUM", "LSLOANNUM", JdeDataType.String, 50),
        new JdeField("LSLOANTYP", "LSLOANTYP", JdeDataType.String, 20),
        new JdeField("LSMGA", "LSMGA", JdeDataType.Numeric),
        new JdeField("LSINRTE", "LSINRTE", JdeDataType.Numeric),
        new JdeField("LSINRLCK", "LSINRLCK", JdeDataType.Numeric),
        new JdeField("LSPXD", "LSPXD", JdeDataType.Numeric),
        new JdeField("LSDNPT", "LSDNPT", JdeDataType.Numeric),
        new JdeField("LSEMD", "LSEMD", JdeDataType.Numeric),
        new JdeField("LSDTKN", "LSDTKN", JdeDataType.Numeric),
        new JdeField("LSMAD", "LSMAD", JdeDataType.Numeric),
        new JdeField("LSTAD", "LSTAD", JdeDataType.Numeric),
        new JdeField("LSLADJ", "LSLADJ", JdeDataType.Numeric),
        new JdeField("LSCTG", "LSCTG", JdeDataType.String, 2),
        new JdeField("LSCTGS", "LSCTGS", JdeDataType.String, 16),
        new JdeField("LSPTX", "LSPTX", JdeDataType.String, 60),
        new JdeField("LSCTGJ", "LSCTGJ", JdeDataType.Numeric),
        new JdeField("LSLRD", "LSLRD", JdeDataType.Numeric),
        new JdeField("LSCCNVD", "LSCCNVD", JdeDataType.Numeric),
        new JdeField("LSCLJ", "LSCLJ", JdeDataType.Numeric),
        new JdeField("LSCXD", "LSCXD", JdeDataType.Numeric),
        new JdeField("LSCRD", "LSCRD", JdeDataType.Numeric),
        new JdeField("LSCN1", "LSCN1", JdeDataType.String, 60),
        new JdeField("LSCN2", "LSCN2", JdeDataType.String, 60),
        new JdeField("LSLAG", "LSLAG", JdeDataType.Numeric),
        new JdeField("LSDCAPPT", "LSDCAPPT", JdeDataType.Numeric),
        new JdeField("LSDCSTM", "LSDCSTM", JdeDataType.String, 16),
        new JdeField("LSDCADT", "LSDCADT", JdeDataType.Numeric),
        new JdeField("LSCLT", "LSCLT", JdeDataType.String, 8),
        new JdeField("LSTEDJ", "LSTEDJ", JdeDataType.Numeric),
        new JdeField("LSTIDJ", "LSTIDJ", JdeDataType.Numeric),
        new JdeField("LSTLN1", "LSTLN1", JdeDataType.String, 60),
        new JdeField("LSTLN2", "LSTLN2", JdeDataType.String, 60),
        new JdeField("LSTLN3", "LSTLN3", JdeDataType.String, 60),
        new JdeField("LSBSWD", "LSBSWD", JdeDataType.Numeric),
        new JdeField("LSBSWT", "LSBSWT", JdeDataType.String, 16),
        new JdeField("LSBAWD", "LSBAWD", JdeDataType.Numeric),
        new JdeField("LSUSD1", "LSUSD1", JdeDataType.Numeric),
        new JdeField("LSUSD2", "LSUSD2", JdeDataType.Numeric),
        new JdeField("LSUSD3", "LSUSD3", JdeDataType.Numeric),
        new JdeField("LSUSD4", "LSUSD4", JdeDataType.Numeric),
        new JdeField("LSUSD5", "LSUSD5", JdeDataType.Numeric),
        new JdeField("LSUSD6", "LSUSD6", JdeDataType.Numeric),
        new JdeField("LSUSD7", "LSUSD7", JdeDataType.Numeric),
        new JdeField("LSUSD8", "LSUSD8", JdeDataType.Numeric),
        new JdeField("LSUSD9", "LSUSD9", JdeDataType.Numeric),
        new JdeField("LSUSD10", "LSUSD10", JdeDataType.Numeric),
        new JdeField("LSUSD11", "LSUSD11", JdeDataType.Numeric),
        new JdeField("LSUSD12", "LSUSD12", JdeDataType.Numeric),
        new JdeField("LSUSD13", "LSUSD13", JdeDataType.Numeric),
        new JdeField("LSUSD14", "LSUSD14", JdeDataType.Numeric),
        new JdeField("LSUSD15", "LSUSD15", JdeDataType.Numeric),
        new JdeField("LSUSD16", "LSUSD16", JdeDataType.Numeric),
        new JdeField("LSUSD17", "LSUSD17", JdeDataType.Numeric),
        new JdeField("LSUSD18", "LSUSD18", JdeDataType.Numeric),
        new JdeField("LSUSD19", "LSUSD19", JdeDataType.Numeric),
        new JdeField("LSUSD20", "LSUSD20", JdeDataType.Numeric),
        new JdeField("LSUAMT01", "LSUAMT01", JdeDataType.Numeric),
        new JdeField("LSUAMT02", "LSUAMT02", JdeDataType.Numeric),
        new JdeField("LSUAMT03", "LSUAMT03", JdeDataType.Numeric),
        new JdeField("LSUAMT04", "LSUAMT04", JdeDataType.Numeric),
        new JdeField("LSUAMT05", "LSUAMT05", JdeDataType.Numeric),
        new JdeField("LSUAMT06", "LSUAMT06", JdeDataType.Numeric),
        new JdeField("LSUAMT07", "LSUAMT07", JdeDataType.Numeric),
        new JdeField("LSUAMT08", "LSUAMT08", JdeDataType.Numeric),
        new JdeField("LSUAMT09", "LSUAMT09", JdeDataType.Numeric),
        new JdeField("LSUAMT10", "LSUAMT10", JdeDataType.Numeric),
        new JdeField("LSSMC01", "LSSMC01", JdeDataType.String, 6),
        new JdeField("LSSMC02", "LSSMC02", JdeDataType.String, 6),
        new JdeField("LSSMC03", "LSSMC03", JdeDataType.String, 6),
        new JdeField("LSSMC04", "LSSMC04", JdeDataType.String, 6),
        new JdeField("LSSMC05", "LSSMC05", JdeDataType.String, 6),
        new JdeField("LSSMC06", "LSSMC06", JdeDataType.String, 6),
        new JdeField("LSSMC07", "LSSMC07", JdeDataType.String, 6),
        new JdeField("LSSMC08", "LSSMC08", JdeDataType.String, 6),
        new JdeField("LSSMC09", "LSSMC09", JdeDataType.String, 6),
        new JdeField("LSSMC10", "LSSMC10", JdeDataType.String, 6),
        new JdeField("LSUSAN01", "LSUSAN01", JdeDataType.Numeric),
        new JdeField("LSUSAN02", "LSUSAN02", JdeDataType.Numeric),
        new JdeField("LSUSAN03", "LSUSAN03", JdeDataType.Numeric),
        new JdeField("LSUSAN04", "LSUSAN04", JdeDataType.Numeric),
        new JdeField("LSUSAN05", "LSUSAN05", JdeDataType.Numeric),
        new JdeField("LSHBST1", "LSHBST1", JdeDataType.String, 2),
        new JdeField("LSHBST2", "LSHBST2", JdeDataType.String, 2),
        new JdeField("LSHBST3", "LSHBST3", JdeDataType.String, 2),
        new JdeField("LSHBST4", "LSHBST4", JdeDataType.String, 2),
        new JdeField("LSHBST5", "LSHBST5", JdeDataType.String, 2),
        new JdeField("LSCONLST", "LSCONLST", JdeDataType.String, 6),
        new JdeField("LSCONNXT", "LSCONNXT", JdeDataType.String, 6),
        new JdeField("LSLSTATHB", "LSLSTATHB", JdeDataType.String, 2),
        new JdeField("LSCONSSEQ", "LSCONSSEQ", JdeDataType.String, 6),
        new JdeField("LSCTY1", "LSCTY1", JdeDataType.String, 50),
        new JdeField("LSADDS", "LSADDS", JdeDataType.String, 6),
        new JdeField("LSADDZ", "LSADDZ", JdeDataType.String, 24),
        new JdeField("LSLOTADD", "LSLOTADD", JdeDataType.String, 80),
        new JdeField("LSLPP", "LSLPP", JdeDataType.Numeric),
        new JdeField("LSCRTU", "LSCRTU", JdeDataType.String, 20),
        new JdeField("LSCRTJ", "LSCRTJ", JdeDataType.Numeric),
        new JdeField("LSCRTT", "LSCRTT", JdeDataType.Numeric),
        new JdeField("LSWRKSTNID", "LSWRKSTNID", JdeDataType.String, 20),
        new JdeField("LSHBOPID", "LSHBOPID", JdeDataType.String, 20),
        new JdeField("LSUPMB", "LSUPMB", JdeDataType.String, 20),
        new JdeField("LSUPMJ", "LSUPMJ", JdeDataType.Numeric),
        new JdeField("LSUPMT", "LSUPMT", JdeDataType.Numeric),
        new JdeField("LSJOBN", "LSJOBN", JdeDataType.String, 20),
        new JdeField("LSPID", "LSPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H501H_0", "Primary Key on LSHBMCUS, LSHBLOT, LSCSSEQ, LSSHSEQ", new[] { "LSHBMCUS", "LSHBLOT", "LSCSSEQ", "LSSHSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
