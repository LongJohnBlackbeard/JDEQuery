using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47172 - .
/// </summary>
public class F47172 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDEDTY.
        /// </summary>
        public const string EDEDTY = "EDEDTY";

        /// <summary>
        /// EDEDSQ.
        /// </summary>
        public const string EDEDSQ = "EDEDSQ";

        /// <summary>
        /// EDEKCO.
        /// </summary>
        public const string EDEKCO = "EDEKCO";

        /// <summary>
        /// EDEDOC.
        /// </summary>
        public const string EDEDOC = "EDEDOC";

        /// <summary>
        /// EDEDCT.
        /// </summary>
        public const string EDEDCT = "EDEDCT";

        /// <summary>
        /// EDEDLN.
        /// </summary>
        public const string EDEDLN = "EDEDLN";

        /// <summary>
        /// EDEDST.
        /// </summary>
        public const string EDEDST = "EDEDST";

        /// <summary>
        /// EDEDFT.
        /// </summary>
        public const string EDEDFT = "EDEDFT";

        /// <summary>
        /// EDEDDT.
        /// </summary>
        public const string EDEDDT = "EDEDDT";

        /// <summary>
        /// EDEDER.
        /// </summary>
        public const string EDEDER = "EDEDER";

        /// <summary>
        /// EDEDDL.
        /// </summary>
        public const string EDEDDL = "EDEDDL";

        /// <summary>
        /// EDEDSP.
        /// </summary>
        public const string EDEDSP = "EDEDSP";

        /// <summary>
        /// EDEDBT.
        /// </summary>
        public const string EDEDBT = "EDEDBT";

        /// <summary>
        /// EDITM.
        /// </summary>
        public const string EDITM = "EDITM";

        /// <summary>
        /// EDLITM.
        /// </summary>
        public const string EDLITM = "EDLITM";

        /// <summary>
        /// EDAITM.
        /// </summary>
        public const string EDAITM = "EDAITM";

        /// <summary>
        /// EDCITM.
        /// </summary>
        public const string EDCITM = "EDCITM";

        /// <summary>
        /// EDCSTPO.
        /// </summary>
        public const string EDCSTPO = "EDCSTPO";

        /// <summary>
        /// EDCSTPODJ.
        /// </summary>
        public const string EDCSTPODJ = "EDCSTPODJ";

        /// <summary>
        /// EDCSTPOTM.
        /// </summary>
        public const string EDCSTPOTM = "EDCSTPOTM";

        /// <summary>
        /// EDCSTPOLIN.
        /// </summary>
        public const string EDCSTPOLIN = "EDCSTPOLIN";

        /// <summary>
        /// EDDKID.
        /// </summary>
        public const string EDDKID = "EDDKID";

        /// <summary>
        /// EDDVAN.
        /// </summary>
        public const string EDDVAN = "EDDVAN";

        /// <summary>
        /// EDCIRV.
        /// </summary>
        public const string EDCIRV = "EDCIRV";

        /// <summary>
        /// EDYEAR1.
        /// </summary>
        public const string EDYEAR1 = "EDYEAR1";

        /// <summary>
        /// EDPTRLSSTS.
        /// </summary>
        public const string EDPTRLSSTS = "EDPTRLSSTS";

        /// <summary>
        /// EDLCRCVDJ.
        /// </summary>
        public const string EDLCRCVDJ = "EDLCRCVDJ";

        /// <summary>
        /// EDLCRCVQTY.
        /// </summary>
        public const string EDLCRCVQTY = "EDLCRCVQTY";

        /// <summary>
        /// EDLCRCVTM.
        /// </summary>
        public const string EDLCRCVTM = "EDLCRCVTM";

        /// <summary>
        /// EDLCRCVUOM.
        /// </summary>
        public const string EDLCRCVUOM = "EDLCRCVUOM";

        /// <summary>
        /// EDLCSHPDJ.
        /// </summary>
        public const string EDLCSHPDJ = "EDLCSHPDJ";

        /// <summary>
        /// EDLCSHPQTY.
        /// </summary>
        public const string EDLCSHPQTY = "EDLCSHPQTY";

        /// <summary>
        /// EDLCSHPTM.
        /// </summary>
        public const string EDLCSHPTM = "EDLCSHPTM";

        /// <summary>
        /// EDLCSHPUOM.
        /// </summary>
        public const string EDLCSHPUOM = "EDLCSHPUOM";

        /// <summary>
        /// EDLASTSID.
        /// </summary>
        public const string EDLASTSID = "EDLASTSID";

        /// <summary>
        /// EDOPTCUMQY.
        /// </summary>
        public const string EDOPTCUMQY = "EDOPTCUMQY";

        /// <summary>
        /// EDCUMREFNO.
        /// </summary>
        public const string EDCUMREFNO = "EDCUMREFNO";

        /// <summary>
        /// EDCCUMRQY.
        /// </summary>
        public const string EDCCUMRQY = "EDCCUMRQY";

        /// <summary>
        /// EDCCUMRDJ.
        /// </summary>
        public const string EDCCUMRDJ = "EDCCUMRDJ";

        /// <summary>
        /// EDCCUMRTM.
        /// </summary>
        public const string EDCCUMRTM = "EDCCUMRTM";

        /// <summary>
        /// EDCRQQYFM.
        /// </summary>
        public const string EDCRQQYFM = "EDCRQQYFM";

        /// <summary>
        /// EDCRQQYPN.
        /// </summary>
        public const string EDCRQQYPN = "EDCRQQYPN";

        /// <summary>
        /// EDCRQQYPS.
        /// </summary>
        public const string EDCRQQYPS = "EDCRQQYPS";

        /// <summary>
        /// EDCRQSDJFM.
        /// </summary>
        public const string EDCRQSDJFM = "EDCRQSDJFM";

        /// <summary>
        /// EDCRQSTMFM.
        /// </summary>
        public const string EDCRQSTMFM = "EDCRQSTMFM";

        /// <summary>
        /// EDCRQEDJFM.
        /// </summary>
        public const string EDCRQEDJFM = "EDCRQEDJFM";

        /// <summary>
        /// EDCRQETMFM.
        /// </summary>
        public const string EDCRQETMFM = "EDCRQETMFM";

        /// <summary>
        /// EDCRQSDJPN.
        /// </summary>
        public const string EDCRQSDJPN = "EDCRQSDJPN";

        /// <summary>
        /// EDCRQSTMPN.
        /// </summary>
        public const string EDCRQSTMPN = "EDCRQSTMPN";

        /// <summary>
        /// EDCRQEDJPN.
        /// </summary>
        public const string EDCRQEDJPN = "EDCRQEDJPN";

        /// <summary>
        /// EDCRQETMPN.
        /// </summary>
        public const string EDCRQETMPN = "EDCRQETMPN";

        /// <summary>
        /// EDCRQSDJPS.
        /// </summary>
        public const string EDCRQSDJPS = "EDCRQSDJPS";

        /// <summary>
        /// EDCRQSTMPS.
        /// </summary>
        public const string EDCRQSTMPS = "EDCRQSTMPS";

        /// <summary>
        /// EDCRQEDJPS.
        /// </summary>
        public const string EDCRQEDJPS = "EDCRQEDJPS";

        /// <summary>
        /// EDCRQETMPS.
        /// </summary>
        public const string EDCRQETMPS = "EDCRQETMPS";

        /// <summary>
        /// EDCCUMSQY.
        /// </summary>
        public const string EDCCUMSQY = "EDCCUMSQY";

        /// <summary>
        /// EDCCUMSDJ.
        /// </summary>
        public const string EDCCUMSDJ = "EDCCUMSDJ";

        /// <summary>
        /// EDCCUMSTM.
        /// </summary>
        public const string EDCCUMSTM = "EDCCUMSTM";

        /// <summary>
        /// EDCCUMSUOM.
        /// </summary>
        public const string EDCCUMSUOM = "EDCCUMSUOM";

        /// <summary>
        /// EDFBCUMQY.
        /// </summary>
        public const string EDFBCUMQY = "EDFBCUMQY";

        /// <summary>
        /// EDFBCUMSDJ.
        /// </summary>
        public const string EDFBCUMSDJ = "EDFBCUMSDJ";

        /// <summary>
        /// EDFBCUMEDJ.
        /// </summary>
        public const string EDFBCUMEDJ = "EDFBCUMEDJ";

        /// <summary>
        /// EDMTCUMQY.
        /// </summary>
        public const string EDMTCUMQY = "EDMTCUMQY";

        /// <summary>
        /// EDMTCUMSDJ.
        /// </summary>
        public const string EDMTCUMSDJ = "EDMTCUMSDJ";

        /// <summary>
        /// EDMTCUMEDJ.
        /// </summary>
        public const string EDMTCUMEDJ = "EDMTCUMEDJ";

        /// <summary>
        /// EDVINNO.
        /// </summary>
        public const string EDVINNO = "EDVINNO";

        /// <summary>
        /// EDASBLNFD.
        /// </summary>
        public const string EDASBLNFD = "EDASBLNFD";

        /// <summary>
        /// EDASBLNLOC.
        /// </summary>
        public const string EDASBLNLOC = "EDASBLNLOC";

        /// <summary>
        /// EDASBNO.
        /// </summary>
        public const string EDASBNO = "EDASBNO";

        /// <summary>
        /// EDGCNT.
        /// </summary>
        public const string EDGCNT = "EDGCNT";

        /// <summary>
        /// EDCSTORDNO.
        /// </summary>
        public const string EDCSTORDNO = "EDCSTORDNO";

        /// <summary>
        /// EDHZCLSNO.
        /// </summary>
        public const string EDHZCLSNO = "EDHZCLSNO";

        /// <summary>
        /// EDKBSNO.
        /// </summary>
        public const string EDKBSNO = "EDKBSNO";

        /// <summary>
        /// EDKBENO.
        /// </summary>
        public const string EDKBENO = "EDKBENO";

        /// <summary>
        /// EDLABORHR.
        /// </summary>
        public const string EDLABORHR = "EDLABORHR";

        /// <summary>
        /// EDRSVLNFD.
        /// </summary>
        public const string EDRSVLNFD = "EDRSVLNFD";

        /// <summary>
        /// EDTRSRTE.
        /// </summary>
        public const string EDTRSRTE = "EDTRSRTE";

        /// <summary>
        /// EDTRSRTSFX.
        /// </summary>
        public const string EDTRSRTSFX = "EDTRSRTSFX";

        /// <summary>
        /// EDUCARTNO.
        /// </summary>
        public const string EDUCARTNO = "EDUCARTNO";

        /// <summary>
        /// EDCTLNUM.
        /// </summary>
        public const string EDCTLNUM = "EDCTLNUM";

        /// <summary>
        /// EDDMD01.
        /// </summary>
        public const string EDDMD01 = "EDDMD01";

        /// <summary>
        /// EDDMD02.
        /// </summary>
        public const string EDDMD02 = "EDDMD02";

        /// <summary>
        /// EDDMD03.
        /// </summary>
        public const string EDDMD03 = "EDDMD03";

        /// <summary>
        /// EDDMD04.
        /// </summary>
        public const string EDDMD04 = "EDDMD04";

        /// <summary>
        /// EDDMD05.
        /// </summary>
        public const string EDDMD05 = "EDDMD05";

        /// <summary>
        /// EDDMDREF1.
        /// </summary>
        public const string EDDMDREF1 = "EDDMDREF1";

        /// <summary>
        /// EDDMDREF2.
        /// </summary>
        public const string EDDMDREF2 = "EDDMDREF2";

        /// <summary>
        /// EDURCD.
        /// </summary>
        public const string EDURCD = "EDURCD";

        /// <summary>
        /// EDURDT.
        /// </summary>
        public const string EDURDT = "EDURDT";

        /// <summary>
        /// EDURAT.
        /// </summary>
        public const string EDURAT = "EDURAT";

        /// <summary>
        /// EDURAB.
        /// </summary>
        public const string EDURAB = "EDURAB";

        /// <summary>
        /// EDURRF.
        /// </summary>
        public const string EDURRF = "EDURRF";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDTDAY.
        /// </summary>
        public const string EDTDAY = "EDTDAY";

        /// <summary>
        /// EDCARDNO.
        /// </summary>
        public const string EDCARDNO = "EDCARDNO";

        /// <summary>
        /// EDCIRVQ.
        /// </summary>
        public const string EDCIRVQ = "EDCIRVQ";

        /// <summary>
        /// EDPRODTYPE.
        /// </summary>
        public const string EDPRODTYPE = "EDPRODTYPE";

        /// <summary>
        /// EDRTORSQ.
        /// </summary>
        public const string EDRTORSQ = "EDRTORSQ";

        /// <summary>
        /// EDRTGDAT.
        /// </summary>
        public const string EDRTGDAT = "EDRTGDAT";

        /// <summary>
        /// EDRTGTIM.
        /// </summary>
        public const string EDRTGTIM = "EDRTGTIM";

        /// <summary>
        /// EDDMDREF3.
        /// </summary>
        public const string EDDMDREF3 = "EDDMDREF3";

        /// <summary>
        /// EDDMDREF4.
        /// </summary>
        public const string EDDMDREF4 = "EDDMDREF4";

        /// <summary>
        /// EDDMDREF5.
        /// </summary>
        public const string EDDMDREF5 = "EDDMDREF5";

        /// <summary>
        /// EDDMDREF6.
        /// </summary>
        public const string EDDMDREF6 = "EDDMDREF6";

        /// <summary>
        /// EDDMDREF7.
        /// </summary>
        public const string EDDMDREF7 = "EDDMDREF7";

        /// <summary>
        /// EDDMDREF8.
        /// </summary>
        public const string EDDMDREF8 = "EDDMDREF8";

        /// <summary>
        /// EDDMDREF9.
        /// </summary>
        public const string EDDMDREF9 = "EDDMDREF9";

        /// <summary>
        /// EDDMDREF10.
        /// </summary>
        public const string EDDMDREF10 = "EDDMDREF10";

        /// <summary>
        /// EDSCAC.
        /// </summary>
        public const string EDSCAC = "EDSCAC";

        /// <summary>
        /// EDATMCN.
        /// </summary>
        public const string EDATMCN = "EDATMCN";

        /// <summary>
        /// EDOFFLNDT.
        /// </summary>
        public const string EDOFFLNDT = "EDOFFLNDT";

        /// <summary>
        /// EDGDVAN.
        /// </summary>
        public const string EDGDVAN = "EDGDVAN";
    }

    /// <inheritdoc />
    public override string TableName => "F47172";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDEDTY", "EDEDTY", JdeDataType.String, 2),
        new JdeField("EDEDSQ", "EDEDSQ", JdeDataType.Numeric),
        new JdeField("EDEKCO", "EDEKCO", JdeDataType.String, 10, true, true),
        new JdeField("EDEDOC", "EDEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("EDEDCT", "EDEDCT", JdeDataType.String, 4, true, true),
        new JdeField("EDEDLN", "EDEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDEDST", "EDEDST", JdeDataType.String, 12),
        new JdeField("EDEDFT", "EDEDFT", JdeDataType.String, 20),
        new JdeField("EDEDDT", "EDEDDT", JdeDataType.Numeric),
        new JdeField("EDEDER", "EDEDER", JdeDataType.String, 2),
        new JdeField("EDEDDL", "EDEDDL", JdeDataType.Numeric),
        new JdeField("EDEDSP", "EDEDSP", JdeDataType.String, 2),
        new JdeField("EDEDBT", "EDEDBT", JdeDataType.String, 30),
        new JdeField("EDITM", "EDITM", JdeDataType.Numeric),
        new JdeField("EDLITM", "EDLITM", JdeDataType.String, 50),
        new JdeField("EDAITM", "EDAITM", JdeDataType.String, 50),
        new JdeField("EDCITM", "EDCITM", JdeDataType.String, 50),
        new JdeField("EDCSTPO", "EDCSTPO", JdeDataType.String, 60),
        new JdeField("EDCSTPODJ", "EDCSTPODJ", JdeDataType.Numeric),
        new JdeField("EDCSTPOTM", "EDCSTPOTM", JdeDataType.Numeric),
        new JdeField("EDCSTPOLIN", "EDCSTPOLIN", JdeDataType.String, 10),
        new JdeField("EDDKID", "EDDKID", JdeDataType.String, 40),
        new JdeField("EDDVAN", "EDDVAN", JdeDataType.Numeric),
        new JdeField("EDCIRV", "EDCIRV", JdeDataType.String, 40),
        new JdeField("EDYEAR1", "EDYEAR1", JdeDataType.Numeric),
        new JdeField("EDPTRLSSTS", "EDPTRLSSTS", JdeDataType.String, 4),
        new JdeField("EDLCRCVDJ", "EDLCRCVDJ", JdeDataType.Numeric),
        new JdeField("EDLCRCVQTY", "EDLCRCVQTY", JdeDataType.Numeric),
        new JdeField("EDLCRCVTM", "EDLCRCVTM", JdeDataType.Numeric),
        new JdeField("EDLCRCVUOM", "EDLCRCVUOM", JdeDataType.String, 4),
        new JdeField("EDLCSHPDJ", "EDLCSHPDJ", JdeDataType.Numeric),
        new JdeField("EDLCSHPQTY", "EDLCSHPQTY", JdeDataType.Numeric),
        new JdeField("EDLCSHPTM", "EDLCSHPTM", JdeDataType.Numeric),
        new JdeField("EDLCSHPUOM", "EDLCSHPUOM", JdeDataType.String, 4),
        new JdeField("EDLASTSID", "EDLASTSID", JdeDataType.String, 32),
        new JdeField("EDOPTCUMQY", "EDOPTCUMQY", JdeDataType.String, 2),
        new JdeField("EDCUMREFNO", "EDCUMREFNO", JdeDataType.String, 50),
        new JdeField("EDCCUMRQY", "EDCCUMRQY", JdeDataType.Numeric),
        new JdeField("EDCCUMRDJ", "EDCCUMRDJ", JdeDataType.Numeric),
        new JdeField("EDCCUMRTM", "EDCCUMRTM", JdeDataType.Numeric),
        new JdeField("EDCRQQYFM", "EDCRQQYFM", JdeDataType.Numeric),
        new JdeField("EDCRQQYPN", "EDCRQQYPN", JdeDataType.Numeric),
        new JdeField("EDCRQQYPS", "EDCRQQYPS", JdeDataType.Numeric),
        new JdeField("EDCRQSDJFM", "EDCRQSDJFM", JdeDataType.Numeric),
        new JdeField("EDCRQSTMFM", "EDCRQSTMFM", JdeDataType.Numeric),
        new JdeField("EDCRQEDJFM", "EDCRQEDJFM", JdeDataType.Numeric),
        new JdeField("EDCRQETMFM", "EDCRQETMFM", JdeDataType.Numeric),
        new JdeField("EDCRQSDJPN", "EDCRQSDJPN", JdeDataType.Numeric),
        new JdeField("EDCRQSTMPN", "EDCRQSTMPN", JdeDataType.Numeric),
        new JdeField("EDCRQEDJPN", "EDCRQEDJPN", JdeDataType.Numeric),
        new JdeField("EDCRQETMPN", "EDCRQETMPN", JdeDataType.Numeric),
        new JdeField("EDCRQSDJPS", "EDCRQSDJPS", JdeDataType.Numeric),
        new JdeField("EDCRQSTMPS", "EDCRQSTMPS", JdeDataType.Numeric),
        new JdeField("EDCRQEDJPS", "EDCRQEDJPS", JdeDataType.Numeric),
        new JdeField("EDCRQETMPS", "EDCRQETMPS", JdeDataType.Numeric),
        new JdeField("EDCCUMSQY", "EDCCUMSQY", JdeDataType.Numeric),
        new JdeField("EDCCUMSDJ", "EDCCUMSDJ", JdeDataType.Numeric),
        new JdeField("EDCCUMSTM", "EDCCUMSTM", JdeDataType.Numeric),
        new JdeField("EDCCUMSUOM", "EDCCUMSUOM", JdeDataType.String, 4),
        new JdeField("EDFBCUMQY", "EDFBCUMQY", JdeDataType.Numeric),
        new JdeField("EDFBCUMSDJ", "EDFBCUMSDJ", JdeDataType.Numeric),
        new JdeField("EDFBCUMEDJ", "EDFBCUMEDJ", JdeDataType.Numeric),
        new JdeField("EDMTCUMQY", "EDMTCUMQY", JdeDataType.Numeric),
        new JdeField("EDMTCUMSDJ", "EDMTCUMSDJ", JdeDataType.Numeric),
        new JdeField("EDMTCUMEDJ", "EDMTCUMEDJ", JdeDataType.Numeric),
        new JdeField("EDVINNO", "EDVINNO", JdeDataType.String, 40),
        new JdeField("EDASBLNFD", "EDASBLNFD", JdeDataType.String, 20),
        new JdeField("EDASBLNLOC", "EDASBLNLOC", JdeDataType.String, 12),
        new JdeField("EDASBNO", "EDASBNO", JdeDataType.String, 30),
        new JdeField("EDGCNT", "EDGCNT", JdeDataType.String, 24),
        new JdeField("EDCSTORDNO", "EDCSTORDNO", JdeDataType.String, 30),
        new JdeField("EDHZCLSNO", "EDHZCLSNO", JdeDataType.String, 30),
        new JdeField("EDKBSNO", "EDKBSNO", JdeDataType.String, 30),
        new JdeField("EDKBENO", "EDKBENO", JdeDataType.String, 30),
        new JdeField("EDLABORHR", "EDLABORHR", JdeDataType.Numeric),
        new JdeField("EDRSVLNFD", "EDRSVLNFD", JdeDataType.String, 20),
        new JdeField("EDTRSRTE", "EDTRSRTE", JdeDataType.String, 30),
        new JdeField("EDTRSRTSFX", "EDTRSRTSFX", JdeDataType.String, 30),
        new JdeField("EDUCARTNO", "EDUCARTNO", JdeDataType.String, 30),
        new JdeField("EDCTLNUM", "EDCTLNUM", JdeDataType.String, 70),
        new JdeField("EDDMD01", "EDDMD01", JdeDataType.String, 6),
        new JdeField("EDDMD02", "EDDMD02", JdeDataType.String, 6),
        new JdeField("EDDMD03", "EDDMD03", JdeDataType.String, 6),
        new JdeField("EDDMD04", "EDDMD04", JdeDataType.String, 6),
        new JdeField("EDDMD05", "EDDMD05", JdeDataType.String, 6),
        new JdeField("EDDMDREF1", "EDDMDREF1", JdeDataType.String, 70),
        new JdeField("EDDMDREF2", "EDDMDREF2", JdeDataType.String, 70),
        new JdeField("EDURCD", "EDURCD", JdeDataType.String, 4),
        new JdeField("EDURDT", "EDURDT", JdeDataType.Numeric),
        new JdeField("EDURAT", "EDURAT", JdeDataType.Numeric),
        new JdeField("EDURAB", "EDURAB", JdeDataType.Numeric),
        new JdeField("EDURRF", "EDURRF", JdeDataType.String, 30),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric),
        new JdeField("EDTDAY", "EDTDAY", JdeDataType.Numeric),
        new JdeField("EDCARDNO", "EDCARDNO", JdeDataType.String, 8),
        new JdeField("EDCIRVQ", "EDCIRVQ", JdeDataType.String, 4),
        new JdeField("EDPRODTYPE", "EDPRODTYPE", JdeDataType.String, 60),
        new JdeField("EDRTORSQ", "EDRTORSQ", JdeDataType.String, 60),
        new JdeField("EDRTGDAT", "EDRTGDAT", JdeDataType.Numeric),
        new JdeField("EDRTGTIM", "EDRTGTIM", JdeDataType.Numeric),
        new JdeField("EDDMDREF3", "EDDMDREF3", JdeDataType.String, 70),
        new JdeField("EDDMDREF4", "EDDMDREF4", JdeDataType.String, 70),
        new JdeField("EDDMDREF5", "EDDMDREF5", JdeDataType.String, 70),
        new JdeField("EDDMDREF6", "EDDMDREF6", JdeDataType.String, 70),
        new JdeField("EDDMDREF7", "EDDMDREF7", JdeDataType.String, 70),
        new JdeField("EDDMDREF8", "EDDMDREF8", JdeDataType.String, 70),
        new JdeField("EDDMDREF9", "EDDMDREF9", JdeDataType.String, 70),
        new JdeField("EDDMDREF10", "EDDMDREF10", JdeDataType.String, 70),
        new JdeField("EDSCAC", "EDSCAC", JdeDataType.String, 8),
        new JdeField("EDATMCN", "EDATMCN", JdeDataType.Numeric),
        new JdeField("EDOFFLNDT", "EDOFFLNDT", JdeDataType.Numeric),
        new JdeField("EDGDVAN", "EDGDVAN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47172_0", "Primary Key on EDEDOC, EDEDCT, EDEKCO, EDEDLN", new[] { "EDEDOC", "EDEDCT", "EDEKCO", "EDEDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F47172_2", "Index on EDEDSP, EDEDSQ, EDEKCO, EDEDOC, EDEDCT", new[] { "EDEDSP", "EDEDSQ", "EDEKCO", "EDEDOC", "EDEDCT" })
    };
}
