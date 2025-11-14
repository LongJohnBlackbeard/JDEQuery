using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H501Z - .
/// </summary>
public class F44H501Z : JdeTable
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
        /// SZHBLOT.
        /// </summary>
        public const string SZHBLOT = "SZHBLOT";

        /// <summary>
        /// SZCSSEQ.
        /// </summary>
        public const string SZCSSEQ = "SZCSSEQ";

        /// <summary>
        /// SZACTVSEQ.
        /// </summary>
        public const string SZACTVSEQ = "SZACTVSEQ";

        /// <summary>
        /// SZMCU.
        /// </summary>
        public const string SZMCU = "SZMCU";

        /// <summary>
        /// SZHBAREA.
        /// </summary>
        public const string SZHBAREA = "SZHBAREA";

        /// <summary>
        /// SZCPHASE.
        /// </summary>
        public const string SZCPHASE = "SZCPHASE";

        /// <summary>
        /// SZBYR.
        /// </summary>
        public const string SZBYR = "SZBYR";

        /// <summary>
        /// SZMLTBYR.
        /// </summary>
        public const string SZMLTBYR = "SZMLTBYR";

        /// <summary>
        /// SZHBPLAN.
        /// </summary>
        public const string SZHBPLAN = "SZHBPLAN";

        /// <summary>
        /// SZHBELEV.
        /// </summary>
        public const string SZHBELEV = "SZHBELEV";

        /// <summary>
        /// SZSWING.
        /// </summary>
        public const string SZSWING = "SZSWING";

        /// <summary>
        /// SZSALLST.
        /// </summary>
        public const string SZSALLST = "SZSALLST";

        /// <summary>
        /// SZSALNXT.
        /// </summary>
        public const string SZSALNXT = "SZSALNXT";

        /// <summary>
        /// SZDCG.
        /// </summary>
        public const string SZDCG = "SZDCG";

        /// <summary>
        /// SZCONACT.
        /// </summary>
        public const string SZCONACT = "SZCONACT";

        /// <summary>
        /// SZHBSCS.
        /// </summary>
        public const string SZHBSCS = "SZHBSCS";

        /// <summary>
        /// SZSDJ.
        /// </summary>
        public const string SZSDJ = "SZSDJ";

        /// <summary>
        /// SZSRPDJ.
        /// </summary>
        public const string SZSRPDJ = "SZSRPDJ";

        /// <summary>
        /// SZSRDJ.
        /// </summary>
        public const string SZSRDJ = "SZSRDJ";

        /// <summary>
        /// SZCAPRVL.
        /// </summary>
        public const string SZCAPRVL = "SZCAPRVL";

        /// <summary>
        /// SZECDJ.
        /// </summary>
        public const string SZECDJ = "SZECDJ";

        /// <summary>
        /// SZCDJ.
        /// </summary>
        public const string SZCDJ = "SZCDJ";

        /// <summary>
        /// SZEDJ.
        /// </summary>
        public const string SZEDJ = "SZEDJ";

        /// <summary>
        /// SZCSRCD.
        /// </summary>
        public const string SZCSRCD = "SZCSRCD";

        /// <summary>
        /// SZCSN1.
        /// </summary>
        public const string SZCSN1 = "SZCSN1";

        /// <summary>
        /// SZCSN2.
        /// </summary>
        public const string SZCSN2 = "SZCSN2";

        /// <summary>
        /// SZCSN3.
        /// </summary>
        public const string SZCSN3 = "SZCSN3";

        /// <summary>
        /// SZBHPRICE.
        /// </summary>
        public const string SZBHPRICE = "SZBHPRICE";

        /// <summary>
        /// SZLOTPREM.
        /// </summary>
        public const string SZLOTPREM = "SZLOTPREM";

        /// <summary>
        /// SZINCA1.
        /// </summary>
        public const string SZINCA1 = "SZINCA1";

        /// <summary>
        /// SZINCA2.
        /// </summary>
        public const string SZINCA2 = "SZINCA2";

        /// <summary>
        /// SZINCA3.
        /// </summary>
        public const string SZINCA3 = "SZINCA3";

        /// <summary>
        /// SZUPG.
        /// </summary>
        public const string SZUPG = "SZUPG";

        /// <summary>
        /// SZNETBP.
        /// </summary>
        public const string SZNETBP = "SZNETBP";

        /// <summary>
        /// SZOPRV1.
        /// </summary>
        public const string SZOPRV1 = "SZOPRV1";

        /// <summary>
        /// SZOPRV2.
        /// </summary>
        public const string SZOPRV2 = "SZOPRV2";

        /// <summary>
        /// SZOPRV3.
        /// </summary>
        public const string SZOPRV3 = "SZOPRV3";

        /// <summary>
        /// SZOPRV4.
        /// </summary>
        public const string SZOPRV4 = "SZOPRV4";

        /// <summary>
        /// SZOPRV5.
        /// </summary>
        public const string SZOPRV5 = "SZOPRV5";

        /// <summary>
        /// SZOPRV6.
        /// </summary>
        public const string SZOPRV6 = "SZOPRV6";

        /// <summary>
        /// SZOPRV7.
        /// </summary>
        public const string SZOPRV7 = "SZOPRV7";

        /// <summary>
        /// SZOPRV8.
        /// </summary>
        public const string SZOPRV8 = "SZOPRV8";

        /// <summary>
        /// SZOPRV9.
        /// </summary>
        public const string SZOPRV9 = "SZOPRV9";

        /// <summary>
        /// SZOPINCA.
        /// </summary>
        public const string SZOPINCA = "SZOPINCA";

        /// <summary>
        /// SZNETOPT.
        /// </summary>
        public const string SZNETOPT = "SZNETOPT";

        /// <summary>
        /// SZTOTSAL.
        /// </summary>
        public const string SZTOTSAL = "SZTOTSAL";

        /// <summary>
        /// SZANSM01.
        /// </summary>
        public const string SZANSM01 = "SZANSM01";

        /// <summary>
        /// SZANSM02.
        /// </summary>
        public const string SZANSM02 = "SZANSM02";

        /// <summary>
        /// SZANSM03.
        /// </summary>
        public const string SZANSM03 = "SZANSM03";

        /// <summary>
        /// SZANSM04.
        /// </summary>
        public const string SZANSM04 = "SZANSM04";

        /// <summary>
        /// SZANSM05.
        /// </summary>
        public const string SZANSM05 = "SZANSM05";

        /// <summary>
        /// SZANSM06.
        /// </summary>
        public const string SZANSM06 = "SZANSM06";

        /// <summary>
        /// SZANSM07.
        /// </summary>
        public const string SZANSM07 = "SZANSM07";

        /// <summary>
        /// SZANSM08.
        /// </summary>
        public const string SZANSM08 = "SZANSM08";

        /// <summary>
        /// SZANSM09.
        /// </summary>
        public const string SZANSM09 = "SZANSM09";

        /// <summary>
        /// SZANSM10.
        /// </summary>
        public const string SZANSM10 = "SZANSM10";

        /// <summary>
        /// SZCMPCT1.
        /// </summary>
        public const string SZCMPCT1 = "SZCMPCT1";

        /// <summary>
        /// SZCMPCT2.
        /// </summary>
        public const string SZCMPCT2 = "SZCMPCT2";

        /// <summary>
        /// SZCMPCT3.
        /// </summary>
        public const string SZCMPCT3 = "SZCMPCT3";

        /// <summary>
        /// SZCMPCT4.
        /// </summary>
        public const string SZCMPCT4 = "SZCMPCT4";

        /// <summary>
        /// SZCMPCT5.
        /// </summary>
        public const string SZCMPCT5 = "SZCMPCT5";

        /// <summary>
        /// SZCMPCT6.
        /// </summary>
        public const string SZCMPCT6 = "SZCMPCT6";

        /// <summary>
        /// SZCMPCT7.
        /// </summary>
        public const string SZCMPCT7 = "SZCMPCT7";

        /// <summary>
        /// SZCMPCT8.
        /// </summary>
        public const string SZCMPCT8 = "SZCMPCT8";

        /// <summary>
        /// SZCMPCT9.
        /// </summary>
        public const string SZCMPCT9 = "SZCMPCT9";

        /// <summary>
        /// SZCMPCT10.
        /// </summary>
        public const string SZCMPCT10 = "SZCMPCT10";

        /// <summary>
        /// SZCM1.
        /// </summary>
        public const string SZCM1 = "SZCM1";

        /// <summary>
        /// SZCM2.
        /// </summary>
        public const string SZCM2 = "SZCM2";

        /// <summary>
        /// SZCM3.
        /// </summary>
        public const string SZCM3 = "SZCM3";

        /// <summary>
        /// SZCM4.
        /// </summary>
        public const string SZCM4 = "SZCM4";

        /// <summary>
        /// SZCM5.
        /// </summary>
        public const string SZCM5 = "SZCM5";

        /// <summary>
        /// SZCM6.
        /// </summary>
        public const string SZCM6 = "SZCM6";

        /// <summary>
        /// SZCM7.
        /// </summary>
        public const string SZCM7 = "SZCM7";

        /// <summary>
        /// SZCM8.
        /// </summary>
        public const string SZCM8 = "SZCM8";

        /// <summary>
        /// SZCM9.
        /// </summary>
        public const string SZCM9 = "SZCM9";

        /// <summary>
        /// SZCM10.
        /// </summary>
        public const string SZCM10 = "SZCM10";

        /// <summary>
        /// SZLDR.
        /// </summary>
        public const string SZLDR = "SZLDR";

        /// <summary>
        /// SZLOANNUM.
        /// </summary>
        public const string SZLOANNUM = "SZLOANNUM";

        /// <summary>
        /// SZLOANTYP.
        /// </summary>
        public const string SZLOANTYP = "SZLOANTYP";

        /// <summary>
        /// SZMGA.
        /// </summary>
        public const string SZMGA = "SZMGA";

        /// <summary>
        /// SZINRTE.
        /// </summary>
        public const string SZINRTE = "SZINRTE";

        /// <summary>
        /// SZINRLCK.
        /// </summary>
        public const string SZINRLCK = "SZINRLCK";

        /// <summary>
        /// SZPXD.
        /// </summary>
        public const string SZPXD = "SZPXD";

        /// <summary>
        /// SZDNPT.
        /// </summary>
        public const string SZDNPT = "SZDNPT";

        /// <summary>
        /// SZEMD.
        /// </summary>
        public const string SZEMD = "SZEMD";

        /// <summary>
        /// SZDTKN.
        /// </summary>
        public const string SZDTKN = "SZDTKN";

        /// <summary>
        /// SZMAD.
        /// </summary>
        public const string SZMAD = "SZMAD";

        /// <summary>
        /// SZTAD.
        /// </summary>
        public const string SZTAD = "SZTAD";

        /// <summary>
        /// SZLADJ.
        /// </summary>
        public const string SZLADJ = "SZLADJ";

        /// <summary>
        /// SZCTG.
        /// </summary>
        public const string SZCTG = "SZCTG";

        /// <summary>
        /// SZCTGS.
        /// </summary>
        public const string SZCTGS = "SZCTGS";

        /// <summary>
        /// SZPTX.
        /// </summary>
        public const string SZPTX = "SZPTX";

        /// <summary>
        /// SZCTGJ.
        /// </summary>
        public const string SZCTGJ = "SZCTGJ";

        /// <summary>
        /// SZLRD.
        /// </summary>
        public const string SZLRD = "SZLRD";

        /// <summary>
        /// SZCCNVD.
        /// </summary>
        public const string SZCCNVD = "SZCCNVD";

        /// <summary>
        /// SZCLJ.
        /// </summary>
        public const string SZCLJ = "SZCLJ";

        /// <summary>
        /// SZCXD.
        /// </summary>
        public const string SZCXD = "SZCXD";

        /// <summary>
        /// SZCRD.
        /// </summary>
        public const string SZCRD = "SZCRD";

        /// <summary>
        /// SZCN1.
        /// </summary>
        public const string SZCN1 = "SZCN1";

        /// <summary>
        /// SZCN2.
        /// </summary>
        public const string SZCN2 = "SZCN2";

        /// <summary>
        /// SZLAG.
        /// </summary>
        public const string SZLAG = "SZLAG";

        /// <summary>
        /// SZDCAPPT.
        /// </summary>
        public const string SZDCAPPT = "SZDCAPPT";

        /// <summary>
        /// SZDCSTM.
        /// </summary>
        public const string SZDCSTM = "SZDCSTM";

        /// <summary>
        /// SZDCADT.
        /// </summary>
        public const string SZDCADT = "SZDCADT";

        /// <summary>
        /// SZCLT.
        /// </summary>
        public const string SZCLT = "SZCLT";

        /// <summary>
        /// SZTEDJ.
        /// </summary>
        public const string SZTEDJ = "SZTEDJ";

        /// <summary>
        /// SZTIDJ.
        /// </summary>
        public const string SZTIDJ = "SZTIDJ";

        /// <summary>
        /// SZTLN1.
        /// </summary>
        public const string SZTLN1 = "SZTLN1";

        /// <summary>
        /// SZTLN2.
        /// </summary>
        public const string SZTLN2 = "SZTLN2";

        /// <summary>
        /// SZTLN3.
        /// </summary>
        public const string SZTLN3 = "SZTLN3";

        /// <summary>
        /// SZBSWD.
        /// </summary>
        public const string SZBSWD = "SZBSWD";

        /// <summary>
        /// SZBSWT.
        /// </summary>
        public const string SZBSWT = "SZBSWT";

        /// <summary>
        /// SZBAWD.
        /// </summary>
        public const string SZBAWD = "SZBAWD";

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
        /// SZUSD11.
        /// </summary>
        public const string SZUSD11 = "SZUSD11";

        /// <summary>
        /// SZUSD12.
        /// </summary>
        public const string SZUSD12 = "SZUSD12";

        /// <summary>
        /// SZUSD13.
        /// </summary>
        public const string SZUSD13 = "SZUSD13";

        /// <summary>
        /// SZUSD14.
        /// </summary>
        public const string SZUSD14 = "SZUSD14";

        /// <summary>
        /// SZUSD15.
        /// </summary>
        public const string SZUSD15 = "SZUSD15";

        /// <summary>
        /// SZUSD16.
        /// </summary>
        public const string SZUSD16 = "SZUSD16";

        /// <summary>
        /// SZUSD17.
        /// </summary>
        public const string SZUSD17 = "SZUSD17";

        /// <summary>
        /// SZUSD18.
        /// </summary>
        public const string SZUSD18 = "SZUSD18";

        /// <summary>
        /// SZUSD19.
        /// </summary>
        public const string SZUSD19 = "SZUSD19";

        /// <summary>
        /// SZUSD20.
        /// </summary>
        public const string SZUSD20 = "SZUSD20";

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
        /// SZSMC01.
        /// </summary>
        public const string SZSMC01 = "SZSMC01";

        /// <summary>
        /// SZSMC02.
        /// </summary>
        public const string SZSMC02 = "SZSMC02";

        /// <summary>
        /// SZSMC03.
        /// </summary>
        public const string SZSMC03 = "SZSMC03";

        /// <summary>
        /// SZSMC04.
        /// </summary>
        public const string SZSMC04 = "SZSMC04";

        /// <summary>
        /// SZSMC05.
        /// </summary>
        public const string SZSMC05 = "SZSMC05";

        /// <summary>
        /// SZSMC06.
        /// </summary>
        public const string SZSMC06 = "SZSMC06";

        /// <summary>
        /// SZSMC07.
        /// </summary>
        public const string SZSMC07 = "SZSMC07";

        /// <summary>
        /// SZSMC08.
        /// </summary>
        public const string SZSMC08 = "SZSMC08";

        /// <summary>
        /// SZSMC09.
        /// </summary>
        public const string SZSMC09 = "SZSMC09";

        /// <summary>
        /// SZSMC10.
        /// </summary>
        public const string SZSMC10 = "SZSMC10";

        /// <summary>
        /// SZUSAN01.
        /// </summary>
        public const string SZUSAN01 = "SZUSAN01";

        /// <summary>
        /// SZUSAN02.
        /// </summary>
        public const string SZUSAN02 = "SZUSAN02";

        /// <summary>
        /// SZUSAN03.
        /// </summary>
        public const string SZUSAN03 = "SZUSAN03";

        /// <summary>
        /// SZUSAN04.
        /// </summary>
        public const string SZUSAN04 = "SZUSAN04";

        /// <summary>
        /// SZUSAN05.
        /// </summary>
        public const string SZUSAN05 = "SZUSAN05";

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
    }

    /// <inheritdoc />
    public override string TableName => "F44H501Z";

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
        new JdeField("SZHBLOT", "SZHBLOT", JdeDataType.String, 8),
        new JdeField("SZCSSEQ", "SZCSSEQ", JdeDataType.String, 6),
        new JdeField("SZACTVSEQ", "SZACTVSEQ", JdeDataType.String, 2),
        new JdeField("SZMCU", "SZMCU", JdeDataType.String, 24),
        new JdeField("SZHBAREA", "SZHBAREA", JdeDataType.String, 6),
        new JdeField("SZCPHASE", "SZCPHASE", JdeDataType.String, 6),
        new JdeField("SZBYR", "SZBYR", JdeDataType.Numeric),
        new JdeField("SZMLTBYR", "SZMLTBYR", JdeDataType.String, 2),
        new JdeField("SZHBPLAN", "SZHBPLAN", JdeDataType.String, 8),
        new JdeField("SZHBELEV", "SZHBELEV", JdeDataType.String, 6),
        new JdeField("SZSWING", "SZSWING", JdeDataType.String, 2),
        new JdeField("SZSALLST", "SZSALLST", JdeDataType.String, 6),
        new JdeField("SZSALNXT", "SZSALNXT", JdeDataType.String, 6),
        new JdeField("SZDCG", "SZDCG", JdeDataType.Numeric),
        new JdeField("SZCONACT", "SZCONACT", JdeDataType.String, 6),
        new JdeField("SZHBSCS", "SZHBSCS", JdeDataType.String, 6),
        new JdeField("SZSDJ", "SZSDJ", JdeDataType.Numeric),
        new JdeField("SZSRPDJ", "SZSRPDJ", JdeDataType.Numeric),
        new JdeField("SZSRDJ", "SZSRDJ", JdeDataType.Numeric),
        new JdeField("SZCAPRVL", "SZCAPRVL", JdeDataType.Numeric),
        new JdeField("SZECDJ", "SZECDJ", JdeDataType.Numeric),
        new JdeField("SZCDJ", "SZCDJ", JdeDataType.Numeric),
        new JdeField("SZEDJ", "SZEDJ", JdeDataType.Numeric),
        new JdeField("SZCSRCD", "SZCSRCD", JdeDataType.String, 6),
        new JdeField("SZCSN1", "SZCSN1", JdeDataType.String, 60),
        new JdeField("SZCSN2", "SZCSN2", JdeDataType.String, 60),
        new JdeField("SZCSN3", "SZCSN3", JdeDataType.String, 60),
        new JdeField("SZBHPRICE", "SZBHPRICE", JdeDataType.Numeric),
        new JdeField("SZLOTPREM", "SZLOTPREM", JdeDataType.Numeric),
        new JdeField("SZINCA1", "SZINCA1", JdeDataType.Numeric),
        new JdeField("SZINCA2", "SZINCA2", JdeDataType.Numeric),
        new JdeField("SZINCA3", "SZINCA3", JdeDataType.Numeric),
        new JdeField("SZUPG", "SZUPG", JdeDataType.Numeric),
        new JdeField("SZNETBP", "SZNETBP", JdeDataType.Numeric),
        new JdeField("SZOPRV1", "SZOPRV1", JdeDataType.Numeric),
        new JdeField("SZOPRV2", "SZOPRV2", JdeDataType.Numeric),
        new JdeField("SZOPRV3", "SZOPRV3", JdeDataType.Numeric),
        new JdeField("SZOPRV4", "SZOPRV4", JdeDataType.Numeric),
        new JdeField("SZOPRV5", "SZOPRV5", JdeDataType.Numeric),
        new JdeField("SZOPRV6", "SZOPRV6", JdeDataType.Numeric),
        new JdeField("SZOPRV7", "SZOPRV7", JdeDataType.Numeric),
        new JdeField("SZOPRV8", "SZOPRV8", JdeDataType.Numeric),
        new JdeField("SZOPRV9", "SZOPRV9", JdeDataType.Numeric),
        new JdeField("SZOPINCA", "SZOPINCA", JdeDataType.Numeric),
        new JdeField("SZNETOPT", "SZNETOPT", JdeDataType.Numeric),
        new JdeField("SZTOTSAL", "SZTOTSAL", JdeDataType.Numeric),
        new JdeField("SZANSM01", "SZANSM01", JdeDataType.Numeric),
        new JdeField("SZANSM02", "SZANSM02", JdeDataType.Numeric),
        new JdeField("SZANSM03", "SZANSM03", JdeDataType.Numeric),
        new JdeField("SZANSM04", "SZANSM04", JdeDataType.Numeric),
        new JdeField("SZANSM05", "SZANSM05", JdeDataType.Numeric),
        new JdeField("SZANSM06", "SZANSM06", JdeDataType.Numeric),
        new JdeField("SZANSM07", "SZANSM07", JdeDataType.Numeric),
        new JdeField("SZANSM08", "SZANSM08", JdeDataType.Numeric),
        new JdeField("SZANSM09", "SZANSM09", JdeDataType.Numeric),
        new JdeField("SZANSM10", "SZANSM10", JdeDataType.Numeric),
        new JdeField("SZCMPCT1", "SZCMPCT1", JdeDataType.Numeric),
        new JdeField("SZCMPCT2", "SZCMPCT2", JdeDataType.Numeric),
        new JdeField("SZCMPCT3", "SZCMPCT3", JdeDataType.Numeric),
        new JdeField("SZCMPCT4", "SZCMPCT4", JdeDataType.Numeric),
        new JdeField("SZCMPCT5", "SZCMPCT5", JdeDataType.Numeric),
        new JdeField("SZCMPCT6", "SZCMPCT6", JdeDataType.Numeric),
        new JdeField("SZCMPCT7", "SZCMPCT7", JdeDataType.Numeric),
        new JdeField("SZCMPCT8", "SZCMPCT8", JdeDataType.Numeric),
        new JdeField("SZCMPCT9", "SZCMPCT9", JdeDataType.Numeric),
        new JdeField("SZCMPCT10", "SZCMPCT10", JdeDataType.Numeric),
        new JdeField("SZCM1", "SZCM1", JdeDataType.Numeric),
        new JdeField("SZCM2", "SZCM2", JdeDataType.Numeric),
        new JdeField("SZCM3", "SZCM3", JdeDataType.Numeric),
        new JdeField("SZCM4", "SZCM4", JdeDataType.Numeric),
        new JdeField("SZCM5", "SZCM5", JdeDataType.Numeric),
        new JdeField("SZCM6", "SZCM6", JdeDataType.Numeric),
        new JdeField("SZCM7", "SZCM7", JdeDataType.Numeric),
        new JdeField("SZCM8", "SZCM8", JdeDataType.Numeric),
        new JdeField("SZCM9", "SZCM9", JdeDataType.Numeric),
        new JdeField("SZCM10", "SZCM10", JdeDataType.Numeric),
        new JdeField("SZLDR", "SZLDR", JdeDataType.Numeric),
        new JdeField("SZLOANNUM", "SZLOANNUM", JdeDataType.String, 50),
        new JdeField("SZLOANTYP", "SZLOANTYP", JdeDataType.String, 20),
        new JdeField("SZMGA", "SZMGA", JdeDataType.Numeric),
        new JdeField("SZINRTE", "SZINRTE", JdeDataType.Numeric),
        new JdeField("SZINRLCK", "SZINRLCK", JdeDataType.Numeric),
        new JdeField("SZPXD", "SZPXD", JdeDataType.Numeric),
        new JdeField("SZDNPT", "SZDNPT", JdeDataType.Numeric),
        new JdeField("SZEMD", "SZEMD", JdeDataType.Numeric),
        new JdeField("SZDTKN", "SZDTKN", JdeDataType.Numeric),
        new JdeField("SZMAD", "SZMAD", JdeDataType.Numeric),
        new JdeField("SZTAD", "SZTAD", JdeDataType.Numeric),
        new JdeField("SZLADJ", "SZLADJ", JdeDataType.Numeric),
        new JdeField("SZCTG", "SZCTG", JdeDataType.String, 2),
        new JdeField("SZCTGS", "SZCTGS", JdeDataType.String, 16),
        new JdeField("SZPTX", "SZPTX", JdeDataType.String, 60),
        new JdeField("SZCTGJ", "SZCTGJ", JdeDataType.Numeric),
        new JdeField("SZLRD", "SZLRD", JdeDataType.Numeric),
        new JdeField("SZCCNVD", "SZCCNVD", JdeDataType.Numeric),
        new JdeField("SZCLJ", "SZCLJ", JdeDataType.Numeric),
        new JdeField("SZCXD", "SZCXD", JdeDataType.Numeric),
        new JdeField("SZCRD", "SZCRD", JdeDataType.Numeric),
        new JdeField("SZCN1", "SZCN1", JdeDataType.String, 60),
        new JdeField("SZCN2", "SZCN2", JdeDataType.String, 60),
        new JdeField("SZLAG", "SZLAG", JdeDataType.Numeric),
        new JdeField("SZDCAPPT", "SZDCAPPT", JdeDataType.Numeric),
        new JdeField("SZDCSTM", "SZDCSTM", JdeDataType.String, 16),
        new JdeField("SZDCADT", "SZDCADT", JdeDataType.Numeric),
        new JdeField("SZCLT", "SZCLT", JdeDataType.String, 8),
        new JdeField("SZTEDJ", "SZTEDJ", JdeDataType.Numeric),
        new JdeField("SZTIDJ", "SZTIDJ", JdeDataType.Numeric),
        new JdeField("SZTLN1", "SZTLN1", JdeDataType.String, 60),
        new JdeField("SZTLN2", "SZTLN2", JdeDataType.String, 60),
        new JdeField("SZTLN3", "SZTLN3", JdeDataType.String, 60),
        new JdeField("SZBSWD", "SZBSWD", JdeDataType.Numeric),
        new JdeField("SZBSWT", "SZBSWT", JdeDataType.String, 16),
        new JdeField("SZBAWD", "SZBAWD", JdeDataType.Numeric),
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
        new JdeField("SZUSD11", "SZUSD11", JdeDataType.Numeric),
        new JdeField("SZUSD12", "SZUSD12", JdeDataType.Numeric),
        new JdeField("SZUSD13", "SZUSD13", JdeDataType.Numeric),
        new JdeField("SZUSD14", "SZUSD14", JdeDataType.Numeric),
        new JdeField("SZUSD15", "SZUSD15", JdeDataType.Numeric),
        new JdeField("SZUSD16", "SZUSD16", JdeDataType.Numeric),
        new JdeField("SZUSD17", "SZUSD17", JdeDataType.Numeric),
        new JdeField("SZUSD18", "SZUSD18", JdeDataType.Numeric),
        new JdeField("SZUSD19", "SZUSD19", JdeDataType.Numeric),
        new JdeField("SZUSD20", "SZUSD20", JdeDataType.Numeric),
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
        new JdeField("SZSMC01", "SZSMC01", JdeDataType.String, 6),
        new JdeField("SZSMC02", "SZSMC02", JdeDataType.String, 6),
        new JdeField("SZSMC03", "SZSMC03", JdeDataType.String, 6),
        new JdeField("SZSMC04", "SZSMC04", JdeDataType.String, 6),
        new JdeField("SZSMC05", "SZSMC05", JdeDataType.String, 6),
        new JdeField("SZSMC06", "SZSMC06", JdeDataType.String, 6),
        new JdeField("SZSMC07", "SZSMC07", JdeDataType.String, 6),
        new JdeField("SZSMC08", "SZSMC08", JdeDataType.String, 6),
        new JdeField("SZSMC09", "SZSMC09", JdeDataType.String, 6),
        new JdeField("SZSMC10", "SZSMC10", JdeDataType.String, 6),
        new JdeField("SZUSAN01", "SZUSAN01", JdeDataType.Numeric),
        new JdeField("SZUSAN02", "SZUSAN02", JdeDataType.Numeric),
        new JdeField("SZUSAN03", "SZUSAN03", JdeDataType.Numeric),
        new JdeField("SZUSAN04", "SZUSAN04", JdeDataType.Numeric),
        new JdeField("SZUSAN05", "SZUSAN05", JdeDataType.Numeric),
        new JdeField("SZHBST1", "SZHBST1", JdeDataType.String, 2),
        new JdeField("SZHBST2", "SZHBST2", JdeDataType.String, 2),
        new JdeField("SZHBST3", "SZHBST3", JdeDataType.String, 2),
        new JdeField("SZHBST4", "SZHBST4", JdeDataType.String, 2),
        new JdeField("SZHBST5", "SZHBST5", JdeDataType.String, 2),
        new JdeField("SZCRTU", "SZCRTU", JdeDataType.String, 20),
        new JdeField("SZCRTJ", "SZCRTJ", JdeDataType.Numeric),
        new JdeField("SZCRTT", "SZCRTT", JdeDataType.Numeric),
        new JdeField("SZWRKSTNID", "SZWRKSTNID", JdeDataType.String, 20),
        new JdeField("SZHBOPID", "SZHBOPID", JdeDataType.String, 20),
        new JdeField("SZUPMB", "SZUPMB", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZUPMT", "SZUPMT", JdeDataType.Numeric),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H501Z_0", "Primary Key on SZEDUS, SZEDBT, SZEDTN, SZEDLN", new[] { "SZEDUS", "SZEDBT", "SZEDTN", "SZEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H501Z_2", "Index on SZHBMCUS, SZHBLOT, SZCSSEQ", new[] { "SZHBMCUS", "SZHBLOT", "SZCSSEQ" })
    };
}
