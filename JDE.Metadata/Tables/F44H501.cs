using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H501 - .
/// </summary>
public class F44H501 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SMHBMCUS.
        /// </summary>
        public const string SMHBMCUS = "SMHBMCUS";

        /// <summary>
        /// SMHBLOT.
        /// </summary>
        public const string SMHBLOT = "SMHBLOT";

        /// <summary>
        /// SMCSSEQ.
        /// </summary>
        public const string SMCSSEQ = "SMCSSEQ";

        /// <summary>
        /// SMACTVSEQ.
        /// </summary>
        public const string SMACTVSEQ = "SMACTVSEQ";

        /// <summary>
        /// SMMCU.
        /// </summary>
        public const string SMMCU = "SMMCU";

        /// <summary>
        /// SMHBAREA.
        /// </summary>
        public const string SMHBAREA = "SMHBAREA";

        /// <summary>
        /// SMCPHASE.
        /// </summary>
        public const string SMCPHASE = "SMCPHASE";

        /// <summary>
        /// SMBYR.
        /// </summary>
        public const string SMBYR = "SMBYR";

        /// <summary>
        /// SMMLTBYR.
        /// </summary>
        public const string SMMLTBYR = "SMMLTBYR";

        /// <summary>
        /// SMHBPLAN.
        /// </summary>
        public const string SMHBPLAN = "SMHBPLAN";

        /// <summary>
        /// SMHBELEV.
        /// </summary>
        public const string SMHBELEV = "SMHBELEV";

        /// <summary>
        /// SMSWING.
        /// </summary>
        public const string SMSWING = "SMSWING";

        /// <summary>
        /// SMSALLST.
        /// </summary>
        public const string SMSALLST = "SMSALLST";

        /// <summary>
        /// SMSALNXT.
        /// </summary>
        public const string SMSALNXT = "SMSALNXT";

        /// <summary>
        /// SMDCG.
        /// </summary>
        public const string SMDCG = "SMDCG";

        /// <summary>
        /// SMCONACT.
        /// </summary>
        public const string SMCONACT = "SMCONACT";

        /// <summary>
        /// SMHBSCS.
        /// </summary>
        public const string SMHBSCS = "SMHBSCS";

        /// <summary>
        /// SMSDJ.
        /// </summary>
        public const string SMSDJ = "SMSDJ";

        /// <summary>
        /// SMSRPDJ.
        /// </summary>
        public const string SMSRPDJ = "SMSRPDJ";

        /// <summary>
        /// SMSRDJ.
        /// </summary>
        public const string SMSRDJ = "SMSRDJ";

        /// <summary>
        /// SMCAPRVL.
        /// </summary>
        public const string SMCAPRVL = "SMCAPRVL";

        /// <summary>
        /// SMECDJ.
        /// </summary>
        public const string SMECDJ = "SMECDJ";

        /// <summary>
        /// SMCDJ.
        /// </summary>
        public const string SMCDJ = "SMCDJ";

        /// <summary>
        /// SMEDJ.
        /// </summary>
        public const string SMEDJ = "SMEDJ";

        /// <summary>
        /// SMCSRCD.
        /// </summary>
        public const string SMCSRCD = "SMCSRCD";

        /// <summary>
        /// SMCSN1.
        /// </summary>
        public const string SMCSN1 = "SMCSN1";

        /// <summary>
        /// SMCSN2.
        /// </summary>
        public const string SMCSN2 = "SMCSN2";

        /// <summary>
        /// SMCSN3.
        /// </summary>
        public const string SMCSN3 = "SMCSN3";

        /// <summary>
        /// SMBHPRICE.
        /// </summary>
        public const string SMBHPRICE = "SMBHPRICE";

        /// <summary>
        /// SMLOTPREM.
        /// </summary>
        public const string SMLOTPREM = "SMLOTPREM";

        /// <summary>
        /// SMINCA1.
        /// </summary>
        public const string SMINCA1 = "SMINCA1";

        /// <summary>
        /// SMINCA2.
        /// </summary>
        public const string SMINCA2 = "SMINCA2";

        /// <summary>
        /// SMINCA3.
        /// </summary>
        public const string SMINCA3 = "SMINCA3";

        /// <summary>
        /// SMUPG.
        /// </summary>
        public const string SMUPG = "SMUPG";

        /// <summary>
        /// SMNETBP.
        /// </summary>
        public const string SMNETBP = "SMNETBP";

        /// <summary>
        /// SMOPRV1.
        /// </summary>
        public const string SMOPRV1 = "SMOPRV1";

        /// <summary>
        /// SMOPRV2.
        /// </summary>
        public const string SMOPRV2 = "SMOPRV2";

        /// <summary>
        /// SMOPRV3.
        /// </summary>
        public const string SMOPRV3 = "SMOPRV3";

        /// <summary>
        /// SMOPRV4.
        /// </summary>
        public const string SMOPRV4 = "SMOPRV4";

        /// <summary>
        /// SMOPRV5.
        /// </summary>
        public const string SMOPRV5 = "SMOPRV5";

        /// <summary>
        /// SMOPRV6.
        /// </summary>
        public const string SMOPRV6 = "SMOPRV6";

        /// <summary>
        /// SMOPRV7.
        /// </summary>
        public const string SMOPRV7 = "SMOPRV7";

        /// <summary>
        /// SMOPRV8.
        /// </summary>
        public const string SMOPRV8 = "SMOPRV8";

        /// <summary>
        /// SMOPRV9.
        /// </summary>
        public const string SMOPRV9 = "SMOPRV9";

        /// <summary>
        /// SMOPINCA.
        /// </summary>
        public const string SMOPINCA = "SMOPINCA";

        /// <summary>
        /// SMNETOPT.
        /// </summary>
        public const string SMNETOPT = "SMNETOPT";

        /// <summary>
        /// SMTOTSAL.
        /// </summary>
        public const string SMTOTSAL = "SMTOTSAL";

        /// <summary>
        /// SMANSM01.
        /// </summary>
        public const string SMANSM01 = "SMANSM01";

        /// <summary>
        /// SMANSM02.
        /// </summary>
        public const string SMANSM02 = "SMANSM02";

        /// <summary>
        /// SMANSM03.
        /// </summary>
        public const string SMANSM03 = "SMANSM03";

        /// <summary>
        /// SMANSM04.
        /// </summary>
        public const string SMANSM04 = "SMANSM04";

        /// <summary>
        /// SMANSM05.
        /// </summary>
        public const string SMANSM05 = "SMANSM05";

        /// <summary>
        /// SMANSM06.
        /// </summary>
        public const string SMANSM06 = "SMANSM06";

        /// <summary>
        /// SMANSM07.
        /// </summary>
        public const string SMANSM07 = "SMANSM07";

        /// <summary>
        /// SMANSM08.
        /// </summary>
        public const string SMANSM08 = "SMANSM08";

        /// <summary>
        /// SMANSM09.
        /// </summary>
        public const string SMANSM09 = "SMANSM09";

        /// <summary>
        /// SMANSM10.
        /// </summary>
        public const string SMANSM10 = "SMANSM10";

        /// <summary>
        /// SMCMPCT1.
        /// </summary>
        public const string SMCMPCT1 = "SMCMPCT1";

        /// <summary>
        /// SMCMPCT2.
        /// </summary>
        public const string SMCMPCT2 = "SMCMPCT2";

        /// <summary>
        /// SMCMPCT3.
        /// </summary>
        public const string SMCMPCT3 = "SMCMPCT3";

        /// <summary>
        /// SMCMPCT4.
        /// </summary>
        public const string SMCMPCT4 = "SMCMPCT4";

        /// <summary>
        /// SMCMPCT5.
        /// </summary>
        public const string SMCMPCT5 = "SMCMPCT5";

        /// <summary>
        /// SMCMPCT6.
        /// </summary>
        public const string SMCMPCT6 = "SMCMPCT6";

        /// <summary>
        /// SMCMPCT7.
        /// </summary>
        public const string SMCMPCT7 = "SMCMPCT7";

        /// <summary>
        /// SMCMPCT8.
        /// </summary>
        public const string SMCMPCT8 = "SMCMPCT8";

        /// <summary>
        /// SMCMPCT9.
        /// </summary>
        public const string SMCMPCT9 = "SMCMPCT9";

        /// <summary>
        /// SMCMPCT10.
        /// </summary>
        public const string SMCMPCT10 = "SMCMPCT10";

        /// <summary>
        /// SMCM1.
        /// </summary>
        public const string SMCM1 = "SMCM1";

        /// <summary>
        /// SMCM2.
        /// </summary>
        public const string SMCM2 = "SMCM2";

        /// <summary>
        /// SMCM3.
        /// </summary>
        public const string SMCM3 = "SMCM3";

        /// <summary>
        /// SMCM4.
        /// </summary>
        public const string SMCM4 = "SMCM4";

        /// <summary>
        /// SMCM5.
        /// </summary>
        public const string SMCM5 = "SMCM5";

        /// <summary>
        /// SMCM6.
        /// </summary>
        public const string SMCM6 = "SMCM6";

        /// <summary>
        /// SMCM7.
        /// </summary>
        public const string SMCM7 = "SMCM7";

        /// <summary>
        /// SMCM8.
        /// </summary>
        public const string SMCM8 = "SMCM8";

        /// <summary>
        /// SMCM9.
        /// </summary>
        public const string SMCM9 = "SMCM9";

        /// <summary>
        /// SMCM10.
        /// </summary>
        public const string SMCM10 = "SMCM10";

        /// <summary>
        /// SMLDR.
        /// </summary>
        public const string SMLDR = "SMLDR";

        /// <summary>
        /// SMLOANNUM.
        /// </summary>
        public const string SMLOANNUM = "SMLOANNUM";

        /// <summary>
        /// SMLOANTYP.
        /// </summary>
        public const string SMLOANTYP = "SMLOANTYP";

        /// <summary>
        /// SMMGA.
        /// </summary>
        public const string SMMGA = "SMMGA";

        /// <summary>
        /// SMINRTE.
        /// </summary>
        public const string SMINRTE = "SMINRTE";

        /// <summary>
        /// SMINRLCK.
        /// </summary>
        public const string SMINRLCK = "SMINRLCK";

        /// <summary>
        /// SMPXD.
        /// </summary>
        public const string SMPXD = "SMPXD";

        /// <summary>
        /// SMDNPT.
        /// </summary>
        public const string SMDNPT = "SMDNPT";

        /// <summary>
        /// SMEMD.
        /// </summary>
        public const string SMEMD = "SMEMD";

        /// <summary>
        /// SMDTKN.
        /// </summary>
        public const string SMDTKN = "SMDTKN";

        /// <summary>
        /// SMMAD.
        /// </summary>
        public const string SMMAD = "SMMAD";

        /// <summary>
        /// SMTAD.
        /// </summary>
        public const string SMTAD = "SMTAD";

        /// <summary>
        /// SMLADJ.
        /// </summary>
        public const string SMLADJ = "SMLADJ";

        /// <summary>
        /// SMCTG.
        /// </summary>
        public const string SMCTG = "SMCTG";

        /// <summary>
        /// SMCTGS.
        /// </summary>
        public const string SMCTGS = "SMCTGS";

        /// <summary>
        /// SMPTX.
        /// </summary>
        public const string SMPTX = "SMPTX";

        /// <summary>
        /// SMCTGJ.
        /// </summary>
        public const string SMCTGJ = "SMCTGJ";

        /// <summary>
        /// SMLRD.
        /// </summary>
        public const string SMLRD = "SMLRD";

        /// <summary>
        /// SMCCNVD.
        /// </summary>
        public const string SMCCNVD = "SMCCNVD";

        /// <summary>
        /// SMCLJ.
        /// </summary>
        public const string SMCLJ = "SMCLJ";

        /// <summary>
        /// SMCXD.
        /// </summary>
        public const string SMCXD = "SMCXD";

        /// <summary>
        /// SMCRD.
        /// </summary>
        public const string SMCRD = "SMCRD";

        /// <summary>
        /// SMCN1.
        /// </summary>
        public const string SMCN1 = "SMCN1";

        /// <summary>
        /// SMCN2.
        /// </summary>
        public const string SMCN2 = "SMCN2";

        /// <summary>
        /// SMLAG.
        /// </summary>
        public const string SMLAG = "SMLAG";

        /// <summary>
        /// SMDCAPPT.
        /// </summary>
        public const string SMDCAPPT = "SMDCAPPT";

        /// <summary>
        /// SMDCSTM.
        /// </summary>
        public const string SMDCSTM = "SMDCSTM";

        /// <summary>
        /// SMDCADT.
        /// </summary>
        public const string SMDCADT = "SMDCADT";

        /// <summary>
        /// SMCLT.
        /// </summary>
        public const string SMCLT = "SMCLT";

        /// <summary>
        /// SMTEDJ.
        /// </summary>
        public const string SMTEDJ = "SMTEDJ";

        /// <summary>
        /// SMTIDJ.
        /// </summary>
        public const string SMTIDJ = "SMTIDJ";

        /// <summary>
        /// SMTLN1.
        /// </summary>
        public const string SMTLN1 = "SMTLN1";

        /// <summary>
        /// SMTLN2.
        /// </summary>
        public const string SMTLN2 = "SMTLN2";

        /// <summary>
        /// SMTLN3.
        /// </summary>
        public const string SMTLN3 = "SMTLN3";

        /// <summary>
        /// SMBSWD.
        /// </summary>
        public const string SMBSWD = "SMBSWD";

        /// <summary>
        /// SMBSWT.
        /// </summary>
        public const string SMBSWT = "SMBSWT";

        /// <summary>
        /// SMBAWD.
        /// </summary>
        public const string SMBAWD = "SMBAWD";

        /// <summary>
        /// SMUSD1.
        /// </summary>
        public const string SMUSD1 = "SMUSD1";

        /// <summary>
        /// SMUSD2.
        /// </summary>
        public const string SMUSD2 = "SMUSD2";

        /// <summary>
        /// SMUSD3.
        /// </summary>
        public const string SMUSD3 = "SMUSD3";

        /// <summary>
        /// SMUSD4.
        /// </summary>
        public const string SMUSD4 = "SMUSD4";

        /// <summary>
        /// SMUSD5.
        /// </summary>
        public const string SMUSD5 = "SMUSD5";

        /// <summary>
        /// SMUSD6.
        /// </summary>
        public const string SMUSD6 = "SMUSD6";

        /// <summary>
        /// SMUSD7.
        /// </summary>
        public const string SMUSD7 = "SMUSD7";

        /// <summary>
        /// SMUSD8.
        /// </summary>
        public const string SMUSD8 = "SMUSD8";

        /// <summary>
        /// SMUSD9.
        /// </summary>
        public const string SMUSD9 = "SMUSD9";

        /// <summary>
        /// SMUSD10.
        /// </summary>
        public const string SMUSD10 = "SMUSD10";

        /// <summary>
        /// SMUSD11.
        /// </summary>
        public const string SMUSD11 = "SMUSD11";

        /// <summary>
        /// SMUSD12.
        /// </summary>
        public const string SMUSD12 = "SMUSD12";

        /// <summary>
        /// SMUSD13.
        /// </summary>
        public const string SMUSD13 = "SMUSD13";

        /// <summary>
        /// SMUSD14.
        /// </summary>
        public const string SMUSD14 = "SMUSD14";

        /// <summary>
        /// SMUSD15.
        /// </summary>
        public const string SMUSD15 = "SMUSD15";

        /// <summary>
        /// SMUSD16.
        /// </summary>
        public const string SMUSD16 = "SMUSD16";

        /// <summary>
        /// SMUSD17.
        /// </summary>
        public const string SMUSD17 = "SMUSD17";

        /// <summary>
        /// SMUSD18.
        /// </summary>
        public const string SMUSD18 = "SMUSD18";

        /// <summary>
        /// SMUSD19.
        /// </summary>
        public const string SMUSD19 = "SMUSD19";

        /// <summary>
        /// SMUSD20.
        /// </summary>
        public const string SMUSD20 = "SMUSD20";

        /// <summary>
        /// SMUAMT01.
        /// </summary>
        public const string SMUAMT01 = "SMUAMT01";

        /// <summary>
        /// SMUAMT02.
        /// </summary>
        public const string SMUAMT02 = "SMUAMT02";

        /// <summary>
        /// SMUAMT03.
        /// </summary>
        public const string SMUAMT03 = "SMUAMT03";

        /// <summary>
        /// SMUAMT04.
        /// </summary>
        public const string SMUAMT04 = "SMUAMT04";

        /// <summary>
        /// SMUAMT05.
        /// </summary>
        public const string SMUAMT05 = "SMUAMT05";

        /// <summary>
        /// SMUAMT06.
        /// </summary>
        public const string SMUAMT06 = "SMUAMT06";

        /// <summary>
        /// SMUAMT07.
        /// </summary>
        public const string SMUAMT07 = "SMUAMT07";

        /// <summary>
        /// SMUAMT08.
        /// </summary>
        public const string SMUAMT08 = "SMUAMT08";

        /// <summary>
        /// SMUAMT09.
        /// </summary>
        public const string SMUAMT09 = "SMUAMT09";

        /// <summary>
        /// SMUAMT10.
        /// </summary>
        public const string SMUAMT10 = "SMUAMT10";

        /// <summary>
        /// SMSMC01.
        /// </summary>
        public const string SMSMC01 = "SMSMC01";

        /// <summary>
        /// SMSMC02.
        /// </summary>
        public const string SMSMC02 = "SMSMC02";

        /// <summary>
        /// SMSMC03.
        /// </summary>
        public const string SMSMC03 = "SMSMC03";

        /// <summary>
        /// SMSMC04.
        /// </summary>
        public const string SMSMC04 = "SMSMC04";

        /// <summary>
        /// SMSMC05.
        /// </summary>
        public const string SMSMC05 = "SMSMC05";

        /// <summary>
        /// SMSMC06.
        /// </summary>
        public const string SMSMC06 = "SMSMC06";

        /// <summary>
        /// SMSMC07.
        /// </summary>
        public const string SMSMC07 = "SMSMC07";

        /// <summary>
        /// SMSMC08.
        /// </summary>
        public const string SMSMC08 = "SMSMC08";

        /// <summary>
        /// SMSMC09.
        /// </summary>
        public const string SMSMC09 = "SMSMC09";

        /// <summary>
        /// SMSMC10.
        /// </summary>
        public const string SMSMC10 = "SMSMC10";

        /// <summary>
        /// SMUSAN01.
        /// </summary>
        public const string SMUSAN01 = "SMUSAN01";

        /// <summary>
        /// SMUSAN02.
        /// </summary>
        public const string SMUSAN02 = "SMUSAN02";

        /// <summary>
        /// SMUSAN03.
        /// </summary>
        public const string SMUSAN03 = "SMUSAN03";

        /// <summary>
        /// SMUSAN04.
        /// </summary>
        public const string SMUSAN04 = "SMUSAN04";

        /// <summary>
        /// SMUSAN05.
        /// </summary>
        public const string SMUSAN05 = "SMUSAN05";

        /// <summary>
        /// SMHBST1.
        /// </summary>
        public const string SMHBST1 = "SMHBST1";

        /// <summary>
        /// SMHBST2.
        /// </summary>
        public const string SMHBST2 = "SMHBST2";

        /// <summary>
        /// SMHBST3.
        /// </summary>
        public const string SMHBST3 = "SMHBST3";

        /// <summary>
        /// SMHBST4.
        /// </summary>
        public const string SMHBST4 = "SMHBST4";

        /// <summary>
        /// SMHBST5.
        /// </summary>
        public const string SMHBST5 = "SMHBST5";

        /// <summary>
        /// SMCRTU.
        /// </summary>
        public const string SMCRTU = "SMCRTU";

        /// <summary>
        /// SMCRTJ.
        /// </summary>
        public const string SMCRTJ = "SMCRTJ";

        /// <summary>
        /// SMCRTT.
        /// </summary>
        public const string SMCRTT = "SMCRTT";

        /// <summary>
        /// SMWRKSTNID.
        /// </summary>
        public const string SMWRKSTNID = "SMWRKSTNID";

        /// <summary>
        /// SMHBOPID.
        /// </summary>
        public const string SMHBOPID = "SMHBOPID";

        /// <summary>
        /// SMUPMB.
        /// </summary>
        public const string SMUPMB = "SMUPMB";

        /// <summary>
        /// SMUPMJ.
        /// </summary>
        public const string SMUPMJ = "SMUPMJ";

        /// <summary>
        /// SMUPMT.
        /// </summary>
        public const string SMUPMT = "SMUPMT";

        /// <summary>
        /// SMJOBN.
        /// </summary>
        public const string SMJOBN = "SMJOBN";

        /// <summary>
        /// SMPID.
        /// </summary>
        public const string SMPID = "SMPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H501";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SMHBMCUS", "SMHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("SMHBLOT", "SMHBLOT", JdeDataType.String, 8, true, true),
        new JdeField("SMCSSEQ", "SMCSSEQ", JdeDataType.String, 6, true, true),
        new JdeField("SMACTVSEQ", "SMACTVSEQ", JdeDataType.String, 2),
        new JdeField("SMMCU", "SMMCU", JdeDataType.String, 24),
        new JdeField("SMHBAREA", "SMHBAREA", JdeDataType.String, 6),
        new JdeField("SMCPHASE", "SMCPHASE", JdeDataType.String, 6),
        new JdeField("SMBYR", "SMBYR", JdeDataType.Numeric),
        new JdeField("SMMLTBYR", "SMMLTBYR", JdeDataType.String, 2),
        new JdeField("SMHBPLAN", "SMHBPLAN", JdeDataType.String, 8),
        new JdeField("SMHBELEV", "SMHBELEV", JdeDataType.String, 6),
        new JdeField("SMSWING", "SMSWING", JdeDataType.String, 2),
        new JdeField("SMSALLST", "SMSALLST", JdeDataType.String, 6),
        new JdeField("SMSALNXT", "SMSALNXT", JdeDataType.String, 6),
        new JdeField("SMDCG", "SMDCG", JdeDataType.Numeric),
        new JdeField("SMCONACT", "SMCONACT", JdeDataType.String, 6),
        new JdeField("SMHBSCS", "SMHBSCS", JdeDataType.String, 6),
        new JdeField("SMSDJ", "SMSDJ", JdeDataType.Numeric),
        new JdeField("SMSRPDJ", "SMSRPDJ", JdeDataType.Numeric),
        new JdeField("SMSRDJ", "SMSRDJ", JdeDataType.Numeric),
        new JdeField("SMCAPRVL", "SMCAPRVL", JdeDataType.Numeric),
        new JdeField("SMECDJ", "SMECDJ", JdeDataType.Numeric),
        new JdeField("SMCDJ", "SMCDJ", JdeDataType.Numeric),
        new JdeField("SMEDJ", "SMEDJ", JdeDataType.Numeric),
        new JdeField("SMCSRCD", "SMCSRCD", JdeDataType.String, 6),
        new JdeField("SMCSN1", "SMCSN1", JdeDataType.String, 60),
        new JdeField("SMCSN2", "SMCSN2", JdeDataType.String, 60),
        new JdeField("SMCSN3", "SMCSN3", JdeDataType.String, 60),
        new JdeField("SMBHPRICE", "SMBHPRICE", JdeDataType.Numeric),
        new JdeField("SMLOTPREM", "SMLOTPREM", JdeDataType.Numeric),
        new JdeField("SMINCA1", "SMINCA1", JdeDataType.Numeric),
        new JdeField("SMINCA2", "SMINCA2", JdeDataType.Numeric),
        new JdeField("SMINCA3", "SMINCA3", JdeDataType.Numeric),
        new JdeField("SMUPG", "SMUPG", JdeDataType.Numeric),
        new JdeField("SMNETBP", "SMNETBP", JdeDataType.Numeric),
        new JdeField("SMOPRV1", "SMOPRV1", JdeDataType.Numeric),
        new JdeField("SMOPRV2", "SMOPRV2", JdeDataType.Numeric),
        new JdeField("SMOPRV3", "SMOPRV3", JdeDataType.Numeric),
        new JdeField("SMOPRV4", "SMOPRV4", JdeDataType.Numeric),
        new JdeField("SMOPRV5", "SMOPRV5", JdeDataType.Numeric),
        new JdeField("SMOPRV6", "SMOPRV6", JdeDataType.Numeric),
        new JdeField("SMOPRV7", "SMOPRV7", JdeDataType.Numeric),
        new JdeField("SMOPRV8", "SMOPRV8", JdeDataType.Numeric),
        new JdeField("SMOPRV9", "SMOPRV9", JdeDataType.Numeric),
        new JdeField("SMOPINCA", "SMOPINCA", JdeDataType.Numeric),
        new JdeField("SMNETOPT", "SMNETOPT", JdeDataType.Numeric),
        new JdeField("SMTOTSAL", "SMTOTSAL", JdeDataType.Numeric),
        new JdeField("SMANSM01", "SMANSM01", JdeDataType.Numeric),
        new JdeField("SMANSM02", "SMANSM02", JdeDataType.Numeric),
        new JdeField("SMANSM03", "SMANSM03", JdeDataType.Numeric),
        new JdeField("SMANSM04", "SMANSM04", JdeDataType.Numeric),
        new JdeField("SMANSM05", "SMANSM05", JdeDataType.Numeric),
        new JdeField("SMANSM06", "SMANSM06", JdeDataType.Numeric),
        new JdeField("SMANSM07", "SMANSM07", JdeDataType.Numeric),
        new JdeField("SMANSM08", "SMANSM08", JdeDataType.Numeric),
        new JdeField("SMANSM09", "SMANSM09", JdeDataType.Numeric),
        new JdeField("SMANSM10", "SMANSM10", JdeDataType.Numeric),
        new JdeField("SMCMPCT1", "SMCMPCT1", JdeDataType.Numeric),
        new JdeField("SMCMPCT2", "SMCMPCT2", JdeDataType.Numeric),
        new JdeField("SMCMPCT3", "SMCMPCT3", JdeDataType.Numeric),
        new JdeField("SMCMPCT4", "SMCMPCT4", JdeDataType.Numeric),
        new JdeField("SMCMPCT5", "SMCMPCT5", JdeDataType.Numeric),
        new JdeField("SMCMPCT6", "SMCMPCT6", JdeDataType.Numeric),
        new JdeField("SMCMPCT7", "SMCMPCT7", JdeDataType.Numeric),
        new JdeField("SMCMPCT8", "SMCMPCT8", JdeDataType.Numeric),
        new JdeField("SMCMPCT9", "SMCMPCT9", JdeDataType.Numeric),
        new JdeField("SMCMPCT10", "SMCMPCT10", JdeDataType.Numeric),
        new JdeField("SMCM1", "SMCM1", JdeDataType.Numeric),
        new JdeField("SMCM2", "SMCM2", JdeDataType.Numeric),
        new JdeField("SMCM3", "SMCM3", JdeDataType.Numeric),
        new JdeField("SMCM4", "SMCM4", JdeDataType.Numeric),
        new JdeField("SMCM5", "SMCM5", JdeDataType.Numeric),
        new JdeField("SMCM6", "SMCM6", JdeDataType.Numeric),
        new JdeField("SMCM7", "SMCM7", JdeDataType.Numeric),
        new JdeField("SMCM8", "SMCM8", JdeDataType.Numeric),
        new JdeField("SMCM9", "SMCM9", JdeDataType.Numeric),
        new JdeField("SMCM10", "SMCM10", JdeDataType.Numeric),
        new JdeField("SMLDR", "SMLDR", JdeDataType.Numeric),
        new JdeField("SMLOANNUM", "SMLOANNUM", JdeDataType.String, 50),
        new JdeField("SMLOANTYP", "SMLOANTYP", JdeDataType.String, 20),
        new JdeField("SMMGA", "SMMGA", JdeDataType.Numeric),
        new JdeField("SMINRTE", "SMINRTE", JdeDataType.Numeric),
        new JdeField("SMINRLCK", "SMINRLCK", JdeDataType.Numeric),
        new JdeField("SMPXD", "SMPXD", JdeDataType.Numeric),
        new JdeField("SMDNPT", "SMDNPT", JdeDataType.Numeric),
        new JdeField("SMEMD", "SMEMD", JdeDataType.Numeric),
        new JdeField("SMDTKN", "SMDTKN", JdeDataType.Numeric),
        new JdeField("SMMAD", "SMMAD", JdeDataType.Numeric),
        new JdeField("SMTAD", "SMTAD", JdeDataType.Numeric),
        new JdeField("SMLADJ", "SMLADJ", JdeDataType.Numeric),
        new JdeField("SMCTG", "SMCTG", JdeDataType.String, 2),
        new JdeField("SMCTGS", "SMCTGS", JdeDataType.String, 16),
        new JdeField("SMPTX", "SMPTX", JdeDataType.String, 60),
        new JdeField("SMCTGJ", "SMCTGJ", JdeDataType.Numeric),
        new JdeField("SMLRD", "SMLRD", JdeDataType.Numeric),
        new JdeField("SMCCNVD", "SMCCNVD", JdeDataType.Numeric),
        new JdeField("SMCLJ", "SMCLJ", JdeDataType.Numeric),
        new JdeField("SMCXD", "SMCXD", JdeDataType.Numeric),
        new JdeField("SMCRD", "SMCRD", JdeDataType.Numeric),
        new JdeField("SMCN1", "SMCN1", JdeDataType.String, 60),
        new JdeField("SMCN2", "SMCN2", JdeDataType.String, 60),
        new JdeField("SMLAG", "SMLAG", JdeDataType.Numeric),
        new JdeField("SMDCAPPT", "SMDCAPPT", JdeDataType.Numeric),
        new JdeField("SMDCSTM", "SMDCSTM", JdeDataType.String, 16),
        new JdeField("SMDCADT", "SMDCADT", JdeDataType.Numeric),
        new JdeField("SMCLT", "SMCLT", JdeDataType.String, 8),
        new JdeField("SMTEDJ", "SMTEDJ", JdeDataType.Numeric),
        new JdeField("SMTIDJ", "SMTIDJ", JdeDataType.Numeric),
        new JdeField("SMTLN1", "SMTLN1", JdeDataType.String, 60),
        new JdeField("SMTLN2", "SMTLN2", JdeDataType.String, 60),
        new JdeField("SMTLN3", "SMTLN3", JdeDataType.String, 60),
        new JdeField("SMBSWD", "SMBSWD", JdeDataType.Numeric),
        new JdeField("SMBSWT", "SMBSWT", JdeDataType.String, 16),
        new JdeField("SMBAWD", "SMBAWD", JdeDataType.Numeric),
        new JdeField("SMUSD1", "SMUSD1", JdeDataType.Numeric),
        new JdeField("SMUSD2", "SMUSD2", JdeDataType.Numeric),
        new JdeField("SMUSD3", "SMUSD3", JdeDataType.Numeric),
        new JdeField("SMUSD4", "SMUSD4", JdeDataType.Numeric),
        new JdeField("SMUSD5", "SMUSD5", JdeDataType.Numeric),
        new JdeField("SMUSD6", "SMUSD6", JdeDataType.Numeric),
        new JdeField("SMUSD7", "SMUSD7", JdeDataType.Numeric),
        new JdeField("SMUSD8", "SMUSD8", JdeDataType.Numeric),
        new JdeField("SMUSD9", "SMUSD9", JdeDataType.Numeric),
        new JdeField("SMUSD10", "SMUSD10", JdeDataType.Numeric),
        new JdeField("SMUSD11", "SMUSD11", JdeDataType.Numeric),
        new JdeField("SMUSD12", "SMUSD12", JdeDataType.Numeric),
        new JdeField("SMUSD13", "SMUSD13", JdeDataType.Numeric),
        new JdeField("SMUSD14", "SMUSD14", JdeDataType.Numeric),
        new JdeField("SMUSD15", "SMUSD15", JdeDataType.Numeric),
        new JdeField("SMUSD16", "SMUSD16", JdeDataType.Numeric),
        new JdeField("SMUSD17", "SMUSD17", JdeDataType.Numeric),
        new JdeField("SMUSD18", "SMUSD18", JdeDataType.Numeric),
        new JdeField("SMUSD19", "SMUSD19", JdeDataType.Numeric),
        new JdeField("SMUSD20", "SMUSD20", JdeDataType.Numeric),
        new JdeField("SMUAMT01", "SMUAMT01", JdeDataType.Numeric),
        new JdeField("SMUAMT02", "SMUAMT02", JdeDataType.Numeric),
        new JdeField("SMUAMT03", "SMUAMT03", JdeDataType.Numeric),
        new JdeField("SMUAMT04", "SMUAMT04", JdeDataType.Numeric),
        new JdeField("SMUAMT05", "SMUAMT05", JdeDataType.Numeric),
        new JdeField("SMUAMT06", "SMUAMT06", JdeDataType.Numeric),
        new JdeField("SMUAMT07", "SMUAMT07", JdeDataType.Numeric),
        new JdeField("SMUAMT08", "SMUAMT08", JdeDataType.Numeric),
        new JdeField("SMUAMT09", "SMUAMT09", JdeDataType.Numeric),
        new JdeField("SMUAMT10", "SMUAMT10", JdeDataType.Numeric),
        new JdeField("SMSMC01", "SMSMC01", JdeDataType.String, 6),
        new JdeField("SMSMC02", "SMSMC02", JdeDataType.String, 6),
        new JdeField("SMSMC03", "SMSMC03", JdeDataType.String, 6),
        new JdeField("SMSMC04", "SMSMC04", JdeDataType.String, 6),
        new JdeField("SMSMC05", "SMSMC05", JdeDataType.String, 6),
        new JdeField("SMSMC06", "SMSMC06", JdeDataType.String, 6),
        new JdeField("SMSMC07", "SMSMC07", JdeDataType.String, 6),
        new JdeField("SMSMC08", "SMSMC08", JdeDataType.String, 6),
        new JdeField("SMSMC09", "SMSMC09", JdeDataType.String, 6),
        new JdeField("SMSMC10", "SMSMC10", JdeDataType.String, 6),
        new JdeField("SMUSAN01", "SMUSAN01", JdeDataType.Numeric),
        new JdeField("SMUSAN02", "SMUSAN02", JdeDataType.Numeric),
        new JdeField("SMUSAN03", "SMUSAN03", JdeDataType.Numeric),
        new JdeField("SMUSAN04", "SMUSAN04", JdeDataType.Numeric),
        new JdeField("SMUSAN05", "SMUSAN05", JdeDataType.Numeric),
        new JdeField("SMHBST1", "SMHBST1", JdeDataType.String, 2),
        new JdeField("SMHBST2", "SMHBST2", JdeDataType.String, 2),
        new JdeField("SMHBST3", "SMHBST3", JdeDataType.String, 2),
        new JdeField("SMHBST4", "SMHBST4", JdeDataType.String, 2),
        new JdeField("SMHBST5", "SMHBST5", JdeDataType.String, 2),
        new JdeField("SMCRTU", "SMCRTU", JdeDataType.String, 20),
        new JdeField("SMCRTJ", "SMCRTJ", JdeDataType.Numeric),
        new JdeField("SMCRTT", "SMCRTT", JdeDataType.Numeric),
        new JdeField("SMWRKSTNID", "SMWRKSTNID", JdeDataType.String, 20),
        new JdeField("SMHBOPID", "SMHBOPID", JdeDataType.String, 20),
        new JdeField("SMUPMB", "SMUPMB", JdeDataType.String, 20),
        new JdeField("SMUPMJ", "SMUPMJ", JdeDataType.Numeric),
        new JdeField("SMUPMT", "SMUPMT", JdeDataType.Numeric),
        new JdeField("SMJOBN", "SMJOBN", JdeDataType.String, 20),
        new JdeField("SMPID", "SMPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H501_0", "Primary Key on SMHBMCUS, SMHBLOT, SMCSSEQ", new[] { "SMHBMCUS", "SMHBLOT", "SMCSSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
