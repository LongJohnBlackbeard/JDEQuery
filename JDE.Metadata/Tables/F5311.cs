using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5311 - .
/// </summary>
public class F5311 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DKMCU.
        /// </summary>
        public const string DKMCU = "DKMCU";

        /// <summary>
        /// DKCONO.
        /// </summary>
        public const string DKCONO = "DKCONO";

        /// <summary>
        /// DKLNID.
        /// </summary>
        public const string DKLNID = "DKLNID";

        /// <summary>
        /// DKREQB.
        /// </summary>
        public const string DKREQB = "DKREQB";

        /// <summary>
        /// DKCO.
        /// </summary>
        public const string DKCO = "DKCO";

        /// <summary>
        /// DKRQBD.
        /// </summary>
        public const string DKRQBD = "DKRQBD";

        /// <summary>
        /// DKDL01.
        /// </summary>
        public const string DKDL01 = "DKDL01";

        /// <summary>
        /// DKPROC.
        /// </summary>
        public const string DKPROC = "DKPROC";

        /// <summary>
        /// DKSCOS.
        /// </summary>
        public const string DKSCOS = "DKSCOS";

        /// <summary>
        /// DKLTC.
        /// </summary>
        public const string DKLTC = "DKLTC";

        /// <summary>
        /// DKCOAM.
        /// </summary>
        public const string DKCOAM = "DKCOAM";

        /// <summary>
        /// DKCQAM.
        /// </summary>
        public const string DKCQAM = "DKCQAM";

        /// <summary>
        /// DKCFAM.
        /// </summary>
        public const string DKCFAM = "DKCFAM";

        /// <summary>
        /// DKBCAM.
        /// </summary>
        public const string DKBCAM = "DKBCAM";

        /// <summary>
        /// DKPTYC.
        /// </summary>
        public const string DKPTYC = "DKPTYC";

        /// <summary>
        /// DKCURO.
        /// </summary>
        public const string DKCURO = "DKCURO";

        /// <summary>
        /// DKCURQ.
        /// </summary>
        public const string DKCURQ = "DKCURQ";

        /// <summary>
        /// DKFURC.
        /// </summary>
        public const string DKFURC = "DKFURC";

        /// <summary>
        /// DKBURC.
        /// </summary>
        public const string DKBURC = "DKBURC";

        /// <summary>
        /// DKUOCM.
        /// </summary>
        public const string DKUOCM = "DKUOCM";

        /// <summary>
        /// DKOQTC.
        /// </summary>
        public const string DKOQTC = "DKOQTC";

        /// <summary>
        /// DKQQTC.
        /// </summary>
        public const string DKQQTC = "DKQQTC";

        /// <summary>
        /// DKCQTF.
        /// </summary>
        public const string DKCQTF = "DKCQTF";

        /// <summary>
        /// DKCBTF.
        /// </summary>
        public const string DKCBTF = "DKCBTF";

        /// <summary>
        /// DKANIC.
        /// </summary>
        public const string DKANIC = "DKANIC";

        /// <summary>
        /// DKCAID.
        /// </summary>
        public const string DKCAID = "DKCAID";

        /// <summary>
        /// DKMCU5.
        /// </summary>
        public const string DKMCU5 = "DKMCU5";

        /// <summary>
        /// DKOBJC.
        /// </summary>
        public const string DKOBJC = "DKOBJC";

        /// <summary>
        /// DKSUB7.
        /// </summary>
        public const string DKSUB7 = "DKSUB7";

        /// <summary>
        /// DKDL05.
        /// </summary>
        public const string DKDL05 = "DKDL05";

        /// <summary>
        /// DKSBLC.
        /// </summary>
        public const string DKSBLC = "DKSBLC";

        /// <summary>
        /// DKSBTC.
        /// </summary>
        public const string DKSBTC = "DKSBTC";

        /// <summary>
        /// DKCDTG.
        /// </summary>
        public const string DKCDTG = "DKCDTG";

        /// <summary>
        /// DKR01C.
        /// </summary>
        public const string DKR01C = "DKR01C";

        /// <summary>
        /// DKDTOC.
        /// </summary>
        public const string DKDTOC = "DKDTOC";

        /// <summary>
        /// DKDTQC.
        /// </summary>
        public const string DKDTQC = "DKDTQC";

        /// <summary>
        /// DKDTFC.
        /// </summary>
        public const string DKDTFC = "DKDTFC";

        /// <summary>
        /// DKCWFF.
        /// </summary>
        public const string DKCWFF = "DKCWFF";

        /// <summary>
        /// DKCFB0.
        /// </summary>
        public const string DKCFB0 = "DKCFB0";

        /// <summary>
        /// DKCOFA.
        /// </summary>
        public const string DKCOFA = "DKCOFA";

        /// <summary>
        /// DKCQFA.
        /// </summary>
        public const string DKCQFA = "DKCQFA";

        /// <summary>
        /// DKCFFA.
        /// </summary>
        public const string DKCFFA = "DKCFFA";

        /// <summary>
        /// DKCBFA.
        /// </summary>
        public const string DKCBFA = "DKCBFA";

        /// <summary>
        /// DKSREV.
        /// </summary>
        public const string DKSREV = "DKSREV";

        /// <summary>
        /// DKLTO.
        /// </summary>
        public const string DKLTO = "DKLTO";

        /// <summary>
        /// DKTRMO.
        /// </summary>
        public const string DKTRMO = "DKTRMO";

        /// <summary>
        /// DKROAM.
        /// </summary>
        public const string DKROAM = "DKROAM";

        /// <summary>
        /// DKRQAM.
        /// </summary>
        public const string DKRQAM = "DKRQAM";

        /// <summary>
        /// DKFRAM.
        /// </summary>
        public const string DKFRAM = "DKFRAM";

        /// <summary>
        /// DKBRAM.
        /// </summary>
        public const string DKBRAM = "DKBRAM";

        /// <summary>
        /// DKPTYR.
        /// </summary>
        public const string DKPTYR = "DKPTYR";

        /// <summary>
        /// DKRURO.
        /// </summary>
        public const string DKRURO = "DKRURO";

        /// <summary>
        /// DKRURQ.
        /// </summary>
        public const string DKRURQ = "DKRURQ";

        /// <summary>
        /// DKFURR.
        /// </summary>
        public const string DKFURR = "DKFURR";

        /// <summary>
        /// DKFURB.
        /// </summary>
        public const string DKFURB = "DKFURB";

        /// <summary>
        /// DKUOMR.
        /// </summary>
        public const string DKUOMR = "DKUOMR";

        /// <summary>
        /// DKRQTO.
        /// </summary>
        public const string DKRQTO = "DKRQTO";

        /// <summary>
        /// DKRQTQ.
        /// </summary>
        public const string DKRQTQ = "DKRQTQ";

        /// <summary>
        /// DKRQTF.
        /// </summary>
        public const string DKRQTF = "DKRQTF";

        /// <summary>
        /// DKRQTB.
        /// </summary>
        public const string DKRQTB = "DKRQTB";

        /// <summary>
        /// DKMCU6.
        /// </summary>
        public const string DKMCU6 = "DKMCU6";

        /// <summary>
        /// DKANIR.
        /// </summary>
        public const string DKANIR = "DKANIR";

        /// <summary>
        /// DKRAID.
        /// </summary>
        public const string DKRAID = "DKRAID";

        /// <summary>
        /// DKOBJ8.
        /// </summary>
        public const string DKOBJ8 = "DKOBJ8";

        /// <summary>
        /// DKSUB8.
        /// </summary>
        public const string DKSUB8 = "DKSUB8";

        /// <summary>
        /// DKDL06.
        /// </summary>
        public const string DKDL06 = "DKDL06";

        /// <summary>
        /// DKSBLR.
        /// </summary>
        public const string DKSBLR = "DKSBLR";

        /// <summary>
        /// DKSBTR.
        /// </summary>
        public const string DKSBTR = "DKSBTR";

        /// <summary>
        /// DKDGCG.
        /// </summary>
        public const string DKDGCG = "DKDGCG";

        /// <summary>
        /// DKR01R.
        /// </summary>
        public const string DKR01R = "DKR01R";

        /// <summary>
        /// DKDTOR.
        /// </summary>
        public const string DKDTOR = "DKDTOR";

        /// <summary>
        /// DKDTQR.
        /// </summary>
        public const string DKDTQR = "DKDTQR";

        /// <summary>
        /// DKFRDT.
        /// </summary>
        public const string DKFRDT = "DKFRDT";

        /// <summary>
        /// DKRWFF.
        /// </summary>
        public const string DKRWFF = "DKRWFF";

        /// <summary>
        /// DKRFB0.
        /// </summary>
        public const string DKRFB0 = "DKRFB0";

        /// <summary>
        /// DKROFA.
        /// </summary>
        public const string DKROFA = "DKROFA";

        /// <summary>
        /// DKRQFA.
        /// </summary>
        public const string DKRQFA = "DKRQFA";

        /// <summary>
        /// DKRFFA.
        /// </summary>
        public const string DKRFFA = "DKRFFA";

        /// <summary>
        /// DKRBFA.
        /// </summary>
        public const string DKRBFA = "DKRBFA";

        /// <summary>
        /// DKSSUB.
        /// </summary>
        public const string DKSSUB = "DKSSUB";

        /// <summary>
        /// DKLTS.
        /// </summary>
        public const string DKLTS = "DKLTS";

        /// <summary>
        /// DKTRM1.
        /// </summary>
        public const string DKTRM1 = "DKTRM1";

        /// <summary>
        /// DKSOAM.
        /// </summary>
        public const string DKSOAM = "DKSOAM";

        /// <summary>
        /// DKSQAM.
        /// </summary>
        public const string DKSQAM = "DKSQAM";

        /// <summary>
        /// DKSFAM.
        /// </summary>
        public const string DKSFAM = "DKSFAM";

        /// <summary>
        /// DKBSAM.
        /// </summary>
        public const string DKBSAM = "DKBSAM";

        /// <summary>
        /// DKPTYS.
        /// </summary>
        public const string DKPTYS = "DKPTYS";

        /// <summary>
        /// DKSURO.
        /// </summary>
        public const string DKSURO = "DKSURO";

        /// <summary>
        /// DKSURQ.
        /// </summary>
        public const string DKSURQ = "DKSURQ";

        /// <summary>
        /// DKFURS.
        /// </summary>
        public const string DKFURS = "DKFURS";

        /// <summary>
        /// DKBURS.
        /// </summary>
        public const string DKBURS = "DKBURS";

        /// <summary>
        /// DKUOMS.
        /// </summary>
        public const string DKUOMS = "DKUOMS";

        /// <summary>
        /// DKSQTO.
        /// </summary>
        public const string DKSQTO = "DKSQTO";

        /// <summary>
        /// DKSQTQ.
        /// </summary>
        public const string DKSQTQ = "DKSQTQ";

        /// <summary>
        /// DKSQTF.
        /// </summary>
        public const string DKSQTF = "DKSQTF";

        /// <summary>
        /// DKSQTB.
        /// </summary>
        public const string DKSQTB = "DKSQTB";

        /// <summary>
        /// DKANIS.
        /// </summary>
        public const string DKANIS = "DKANIS";

        /// <summary>
        /// DKAIDS.
        /// </summary>
        public const string DKAIDS = "DKAIDS";

        /// <summary>
        /// DKMCU7.
        /// </summary>
        public const string DKMCU7 = "DKMCU7";

        /// <summary>
        /// DKSOBJ.
        /// </summary>
        public const string DKSOBJ = "DKSOBJ";

        /// <summary>
        /// DKSUB9.
        /// </summary>
        public const string DKSUB9 = "DKSUB9";

        /// <summary>
        /// DKDL07.
        /// </summary>
        public const string DKDL07 = "DKDL07";

        /// <summary>
        /// DKSBL.
        /// </summary>
        public const string DKSBL = "DKSBL";

        /// <summary>
        /// DKSBTS.
        /// </summary>
        public const string DKSBTS = "DKSBTS";

        /// <summary>
        /// DKDCGS.
        /// </summary>
        public const string DKDCGS = "DKDCGS";

        /// <summary>
        /// DKR01S.
        /// </summary>
        public const string DKR01S = "DKR01S";

        /// <summary>
        /// DKFUF2.
        /// </summary>
        public const string DKFUF2 = "DKFUF2";

        /// <summary>
        /// DKDTOS.
        /// </summary>
        public const string DKDTOS = "DKDTOS";

        /// <summary>
        /// DKDTQS.
        /// </summary>
        public const string DKDTQS = "DKDTQS";

        /// <summary>
        /// DKDTFS.
        /// </summary>
        public const string DKDTFS = "DKDTFS";

        /// <summary>
        /// DKSWFF.
        /// </summary>
        public const string DKSWFF = "DKSWFF";

        /// <summary>
        /// DKSFB0.
        /// </summary>
        public const string DKSFB0 = "DKSFB0";

        /// <summary>
        /// DKSOFA.
        /// </summary>
        public const string DKSOFA = "DKSOFA";

        /// <summary>
        /// DKSQFA.
        /// </summary>
        public const string DKSQFA = "DKSQFA";

        /// <summary>
        /// DKSFFA.
        /// </summary>
        public const string DKSFFA = "DKSFFA";

        /// <summary>
        /// DKSBFA.
        /// </summary>
        public const string DKSBFA = "DKSBFA";

        /// <summary>
        /// DKEXTD.
        /// </summary>
        public const string DKEXTD = "DKEXTD";

        /// <summary>
        /// DKRQDD.
        /// </summary>
        public const string DKRQDD = "DKRQDD";

        /// <summary>
        /// DKQTDD.
        /// </summary>
        public const string DKQTDD = "DKQTDD";

        /// <summary>
        /// DKQTRD.
        /// </summary>
        public const string DKQTRD = "DKQTRD";

        /// <summary>
        /// DKDOCM.
        /// </summary>
        public const string DKDOCM = "DKDOCM";

        /// <summary>
        /// DKDCTM.
        /// </summary>
        public const string DKDCTM = "DKDCTM";

        /// <summary>
        /// DKSFXO.
        /// </summary>
        public const string DKSFXO = "DKSFXO";

        /// <summary>
        /// DKKCOO.
        /// </summary>
        public const string DKKCOO = "DKKCOO";

        /// <summary>
        /// DKLINN.
        /// </summary>
        public const string DKLINN = "DKLINN";

        /// <summary>
        /// DKAN8V.
        /// </summary>
        public const string DKAN8V = "DKAN8V";

        /// <summary>
        /// DKSMSF.
        /// </summary>
        public const string DKSMSF = "DKSMSF";

        /// <summary>
        /// DKDSBP.
        /// </summary>
        public const string DKDSBP = "DKDSBP";

        /// <summary>
        /// DKDOCO.
        /// </summary>
        public const string DKDOCO = "DKDOCO";

        /// <summary>
        /// DKDCTO.
        /// </summary>
        public const string DKDCTO = "DKDCTO";

        /// <summary>
        /// DKCOCH.
        /// </summary>
        public const string DKCOCH = "DKCOCH";

        /// <summary>
        /// DKLNCT.
        /// </summary>
        public const string DKLNCT = "DKLNCT";

        /// <summary>
        /// DKKCO.
        /// </summary>
        public const string DKKCO = "DKKCO";

        /// <summary>
        /// DKAN8O.
        /// </summary>
        public const string DKAN8O = "DKAN8O";

        /// <summary>
        /// DKOPIM.
        /// </summary>
        public const string DKOPIM = "DKOPIM";

        /// <summary>
        /// DKDL03.
        /// </summary>
        public const string DKDL03 = "DKDL03";

        /// <summary>
        /// DKCBSF.
        /// </summary>
        public const string DKCBSF = "DKCBSF";

        /// <summary>
        /// DKDRVP.
        /// </summary>
        public const string DKDRVP = "DKDRVP";

        /// <summary>
        /// DKCRCL.
        /// </summary>
        public const string DKCRCL = "DKCRCL";

        /// <summary>
        /// DKCRRM.
        /// </summary>
        public const string DKCRRM = "DKCRRM";

        /// <summary>
        /// DKCRCD.
        /// </summary>
        public const string DKCRCD = "DKCRCD";

        /// <summary>
        /// DKCRR.
        /// </summary>
        public const string DKCRR = "DKCRR";

        /// <summary>
        /// DKCRCF.
        /// </summary>
        public const string DKCRCF = "DKCRCF";

        /// <summary>
        /// DKCRRD.
        /// </summary>
        public const string DKCRRD = "DKCRRD";

        /// <summary>
        /// DKRB01.
        /// </summary>
        public const string DKRB01 = "DKRB01";

        /// <summary>
        /// DKRB02.
        /// </summary>
        public const string DKRB02 = "DKRB02";

        /// <summary>
        /// DKRB03.
        /// </summary>
        public const string DKRB03 = "DKRB03";

        /// <summary>
        /// DKF1A.
        /// </summary>
        public const string DKF1A = "DKF1A";

        /// <summary>
        /// DKF3T.
        /// </summary>
        public const string DKF3T = "DKF3T";

        /// <summary>
        /// DKCMDT.
        /// </summary>
        public const string DKCMDT = "DKCMDT";

        /// <summary>
        /// DKUSER.
        /// </summary>
        public const string DKUSER = "DKUSER";

        /// <summary>
        /// DKPID.
        /// </summary>
        public const string DKPID = "DKPID";

        /// <summary>
        /// DKJOBN.
        /// </summary>
        public const string DKJOBN = "DKJOBN";

        /// <summary>
        /// DKUPMJ.
        /// </summary>
        public const string DKUPMJ = "DKUPMJ";

        /// <summary>
        /// DKUPMT.
        /// </summary>
        public const string DKUPMT = "DKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F5311";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DKMCU", "DKMCU", JdeDataType.String, 24, true, true),
        new JdeField("DKCONO", "DKCONO", JdeDataType.Numeric, null, true, true),
        new JdeField("DKLNID", "DKLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("DKREQB", "DKREQB", JdeDataType.Numeric, null, true, true),
        new JdeField("DKCO", "DKCO", JdeDataType.String, 10),
        new JdeField("DKRQBD", "DKRQBD", JdeDataType.Numeric),
        new JdeField("DKDL01", "DKDL01", JdeDataType.String, 60),
        new JdeField("DKPROC", "DKPROC", JdeDataType.String, 2),
        new JdeField("DKSCOS", "DKSCOS", JdeDataType.String, 4),
        new JdeField("DKLTC", "DKLTC", JdeDataType.String, 4),
        new JdeField("DKCOAM", "DKCOAM", JdeDataType.Numeric),
        new JdeField("DKCQAM", "DKCQAM", JdeDataType.Numeric),
        new JdeField("DKCFAM", "DKCFAM", JdeDataType.Numeric),
        new JdeField("DKBCAM", "DKBCAM", JdeDataType.Numeric),
        new JdeField("DKPTYC", "DKPTYC", JdeDataType.String, 2),
        new JdeField("DKCURO", "DKCURO", JdeDataType.Numeric),
        new JdeField("DKCURQ", "DKCURQ", JdeDataType.Numeric),
        new JdeField("DKFURC", "DKFURC", JdeDataType.Numeric),
        new JdeField("DKBURC", "DKBURC", JdeDataType.Numeric),
        new JdeField("DKUOCM", "DKUOCM", JdeDataType.String, 4),
        new JdeField("DKOQTC", "DKOQTC", JdeDataType.Numeric),
        new JdeField("DKQQTC", "DKQQTC", JdeDataType.Numeric),
        new JdeField("DKCQTF", "DKCQTF", JdeDataType.Numeric),
        new JdeField("DKCBTF", "DKCBTF", JdeDataType.Numeric),
        new JdeField("DKANIC", "DKANIC", JdeDataType.String, 58),
        new JdeField("DKCAID", "DKCAID", JdeDataType.String, 16),
        new JdeField("DKMCU5", "DKMCU5", JdeDataType.String, 24),
        new JdeField("DKOBJC", "DKOBJC", JdeDataType.String, 12),
        new JdeField("DKSUB7", "DKSUB7", JdeDataType.String, 16),
        new JdeField("DKDL05", "DKDL05", JdeDataType.String, 60),
        new JdeField("DKSBLC", "DKSBLC", JdeDataType.String, 16),
        new JdeField("DKSBTC", "DKSBTC", JdeDataType.String, 2),
        new JdeField("DKCDTG", "DKCDTG", JdeDataType.Numeric),
        new JdeField("DKR01C", "DKR01C", JdeDataType.String, 6),
        new JdeField("DKDTOC", "DKDTOC", JdeDataType.Numeric),
        new JdeField("DKDTQC", "DKDTQC", JdeDataType.Numeric),
        new JdeField("DKDTFC", "DKDTFC", JdeDataType.Numeric),
        new JdeField("DKCWFF", "DKCWFF", JdeDataType.String, 2),
        new JdeField("DKCFB0", "DKCFB0", JdeDataType.String, 2),
        new JdeField("DKCOFA", "DKCOFA", JdeDataType.Numeric),
        new JdeField("DKCQFA", "DKCQFA", JdeDataType.Numeric),
        new JdeField("DKCFFA", "DKCFFA", JdeDataType.Numeric),
        new JdeField("DKCBFA", "DKCBFA", JdeDataType.Numeric),
        new JdeField("DKSREV", "DKSREV", JdeDataType.String, 4),
        new JdeField("DKLTO", "DKLTO", JdeDataType.String, 4),
        new JdeField("DKTRMO", "DKTRMO", JdeDataType.String, 2),
        new JdeField("DKROAM", "DKROAM", JdeDataType.Numeric),
        new JdeField("DKRQAM", "DKRQAM", JdeDataType.Numeric),
        new JdeField("DKFRAM", "DKFRAM", JdeDataType.Numeric),
        new JdeField("DKBRAM", "DKBRAM", JdeDataType.Numeric),
        new JdeField("DKPTYR", "DKPTYR", JdeDataType.String, 2),
        new JdeField("DKRURO", "DKRURO", JdeDataType.Numeric),
        new JdeField("DKRURQ", "DKRURQ", JdeDataType.Numeric),
        new JdeField("DKFURR", "DKFURR", JdeDataType.Numeric),
        new JdeField("DKFURB", "DKFURB", JdeDataType.Numeric),
        new JdeField("DKUOMR", "DKUOMR", JdeDataType.String, 4),
        new JdeField("DKRQTO", "DKRQTO", JdeDataType.Numeric),
        new JdeField("DKRQTQ", "DKRQTQ", JdeDataType.Numeric),
        new JdeField("DKRQTF", "DKRQTF", JdeDataType.Numeric),
        new JdeField("DKRQTB", "DKRQTB", JdeDataType.Numeric),
        new JdeField("DKMCU6", "DKMCU6", JdeDataType.String, 24),
        new JdeField("DKANIR", "DKANIR", JdeDataType.String, 58),
        new JdeField("DKRAID", "DKRAID", JdeDataType.String, 16),
        new JdeField("DKOBJ8", "DKOBJ8", JdeDataType.String, 12),
        new JdeField("DKSUB8", "DKSUB8", JdeDataType.String, 16),
        new JdeField("DKDL06", "DKDL06", JdeDataType.String, 60),
        new JdeField("DKSBLR", "DKSBLR", JdeDataType.String, 16),
        new JdeField("DKSBTR", "DKSBTR", JdeDataType.String, 2),
        new JdeField("DKDGCG", "DKDGCG", JdeDataType.Numeric),
        new JdeField("DKR01R", "DKR01R", JdeDataType.String, 6),
        new JdeField("DKDTOR", "DKDTOR", JdeDataType.Numeric),
        new JdeField("DKDTQR", "DKDTQR", JdeDataType.Numeric),
        new JdeField("DKFRDT", "DKFRDT", JdeDataType.Numeric),
        new JdeField("DKRWFF", "DKRWFF", JdeDataType.String, 2),
        new JdeField("DKRFB0", "DKRFB0", JdeDataType.String, 2),
        new JdeField("DKROFA", "DKROFA", JdeDataType.Numeric),
        new JdeField("DKRQFA", "DKRQFA", JdeDataType.Numeric),
        new JdeField("DKRFFA", "DKRFFA", JdeDataType.Numeric),
        new JdeField("DKRBFA", "DKRBFA", JdeDataType.Numeric),
        new JdeField("DKSSUB", "DKSSUB", JdeDataType.String, 4),
        new JdeField("DKLTS", "DKLTS", JdeDataType.String, 4),
        new JdeField("DKTRM1", "DKTRM1", JdeDataType.String, 2),
        new JdeField("DKSOAM", "DKSOAM", JdeDataType.Numeric),
        new JdeField("DKSQAM", "DKSQAM", JdeDataType.Numeric),
        new JdeField("DKSFAM", "DKSFAM", JdeDataType.Numeric),
        new JdeField("DKBSAM", "DKBSAM", JdeDataType.Numeric),
        new JdeField("DKPTYS", "DKPTYS", JdeDataType.String, 2),
        new JdeField("DKSURO", "DKSURO", JdeDataType.Numeric),
        new JdeField("DKSURQ", "DKSURQ", JdeDataType.Numeric),
        new JdeField("DKFURS", "DKFURS", JdeDataType.Numeric),
        new JdeField("DKBURS", "DKBURS", JdeDataType.Numeric),
        new JdeField("DKUOMS", "DKUOMS", JdeDataType.String, 4),
        new JdeField("DKSQTO", "DKSQTO", JdeDataType.Numeric),
        new JdeField("DKSQTQ", "DKSQTQ", JdeDataType.Numeric),
        new JdeField("DKSQTF", "DKSQTF", JdeDataType.Numeric),
        new JdeField("DKSQTB", "DKSQTB", JdeDataType.Numeric),
        new JdeField("DKANIS", "DKANIS", JdeDataType.String, 58),
        new JdeField("DKAIDS", "DKAIDS", JdeDataType.String, 16),
        new JdeField("DKMCU7", "DKMCU7", JdeDataType.String, 24),
        new JdeField("DKSOBJ", "DKSOBJ", JdeDataType.String, 12),
        new JdeField("DKSUB9", "DKSUB9", JdeDataType.String, 16),
        new JdeField("DKDL07", "DKDL07", JdeDataType.String, 60),
        new JdeField("DKSBL", "DKSBL", JdeDataType.String, 16),
        new JdeField("DKSBTS", "DKSBTS", JdeDataType.String, 2),
        new JdeField("DKDCGS", "DKDCGS", JdeDataType.Numeric),
        new JdeField("DKR01S", "DKR01S", JdeDataType.String, 6),
        new JdeField("DKFUF2", "DKFUF2", JdeDataType.String, 2),
        new JdeField("DKDTOS", "DKDTOS", JdeDataType.Numeric),
        new JdeField("DKDTQS", "DKDTQS", JdeDataType.Numeric),
        new JdeField("DKDTFS", "DKDTFS", JdeDataType.Numeric),
        new JdeField("DKSWFF", "DKSWFF", JdeDataType.String, 2),
        new JdeField("DKSFB0", "DKSFB0", JdeDataType.String, 2),
        new JdeField("DKSOFA", "DKSOFA", JdeDataType.Numeric),
        new JdeField("DKSQFA", "DKSQFA", JdeDataType.Numeric),
        new JdeField("DKSFFA", "DKSFFA", JdeDataType.Numeric),
        new JdeField("DKSBFA", "DKSBFA", JdeDataType.Numeric),
        new JdeField("DKEXTD", "DKEXTD", JdeDataType.Numeric),
        new JdeField("DKRQDD", "DKRQDD", JdeDataType.Numeric),
        new JdeField("DKQTDD", "DKQTDD", JdeDataType.Numeric),
        new JdeField("DKQTRD", "DKQTRD", JdeDataType.Numeric),
        new JdeField("DKDOCM", "DKDOCM", JdeDataType.Numeric),
        new JdeField("DKDCTM", "DKDCTM", JdeDataType.String, 4),
        new JdeField("DKSFXO", "DKSFXO", JdeDataType.String, 6),
        new JdeField("DKKCOO", "DKKCOO", JdeDataType.String, 10),
        new JdeField("DKLINN", "DKLINN", JdeDataType.Numeric),
        new JdeField("DKAN8V", "DKAN8V", JdeDataType.Numeric),
        new JdeField("DKSMSF", "DKSMSF", JdeDataType.String, 2),
        new JdeField("DKDSBP", "DKDSBP", JdeDataType.Numeric),
        new JdeField("DKDOCO", "DKDOCO", JdeDataType.Numeric),
        new JdeField("DKDCTO", "DKDCTO", JdeDataType.String, 4),
        new JdeField("DKCOCH", "DKCOCH", JdeDataType.String, 6),
        new JdeField("DKLNCT", "DKLNCT", JdeDataType.Numeric),
        new JdeField("DKKCO", "DKKCO", JdeDataType.String, 10),
        new JdeField("DKAN8O", "DKAN8O", JdeDataType.Numeric),
        new JdeField("DKOPIM", "DKOPIM", JdeDataType.String, 30),
        new JdeField("DKDL03", "DKDL03", JdeDataType.String, 60),
        new JdeField("DKCBSF", "DKCBSF", JdeDataType.String, 2),
        new JdeField("DKDRVP", "DKDRVP", JdeDataType.Numeric),
        new JdeField("DKCRCL", "DKCRCL", JdeDataType.String, 2),
        new JdeField("DKCRRM", "DKCRRM", JdeDataType.String, 2),
        new JdeField("DKCRCD", "DKCRCD", JdeDataType.String, 6),
        new JdeField("DKCRR", "DKCRR", JdeDataType.Numeric),
        new JdeField("DKCRCF", "DKCRCF", JdeDataType.String, 6),
        new JdeField("DKCRRD", "DKCRRD", JdeDataType.Numeric),
        new JdeField("DKRB01", "DKRB01", JdeDataType.String, 6),
        new JdeField("DKRB02", "DKRB02", JdeDataType.String, 6),
        new JdeField("DKRB03", "DKRB03", JdeDataType.String, 6),
        new JdeField("DKF1A", "DKF1A", JdeDataType.Numeric),
        new JdeField("DKF3T", "DKF3T", JdeDataType.String, 60),
        new JdeField("DKCMDT", "DKCMDT", JdeDataType.Numeric),
        new JdeField("DKUSER", "DKUSER", JdeDataType.String, 20),
        new JdeField("DKPID", "DKPID", JdeDataType.String, 20),
        new JdeField("DKJOBN", "DKJOBN", JdeDataType.String, 20),
        new JdeField("DKUPMJ", "DKUPMJ", JdeDataType.Numeric),
        new JdeField("DKUPMT", "DKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5311_0", "Primary Key on DKMCU, DKCONO, DKLNID, DKREQB", new[] { "DKMCU", "DKCONO", "DKLNID", "DKREQB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5311_10", "Index on DKMCU, DKCONO, DKREQB, SYS_NC00157$", new[] { "DKMCU", "DKCONO", "DKREQB", "SYS_NC00157$" }),
        new JdeIndex("F5311_11", "Index on DKMCU, DKCONO, SYS_NC00156$", new[] { "DKMCU", "DKCONO", "SYS_NC00156$" }),
        new JdeIndex("F5311_2", "Index on DKSCOS", new[] { "DKSCOS" }),
        new JdeIndex("F5311_3", "Index on DKSREV", new[] { "DKSREV" }),
        new JdeIndex("F5311_4", "Index on DKSSUB", new[] { "DKSSUB" }),
        new JdeIndex("F5311_5", "Index on DKAN8O, DKCONO, SYS_NC00156$", new[] { "DKAN8O", "DKCONO", "SYS_NC00156$" }),
        new JdeIndex("F5311_6", "Index on DKMCU, DKCONO, DKREQB, DKLNID", new[] { "DKMCU", "DKCONO", "DKREQB", "DKLNID" }),
        new JdeIndex("F5311_7", "Index on DKDOCO, DKDCTO, DKKCO, DKCONO, SYS_NC00156$", new[] { "DKDOCO", "DKDCTO", "DKKCO", "DKCONO", "SYS_NC00156$" }),
        new JdeIndex("F5311_8", "Index on DKAN8V, DKCONO, SYS_NC00156$", new[] { "DKAN8V", "DKCONO", "SYS_NC00156$" }),
        new JdeIndex("F5311_9", "Index on DKDOCM, DKDCTM, DKKCOO, DKCONO, SYS_NC00156$", new[] { "DKDOCM", "DKDCTM", "DKKCOO", "DKCONO", "SYS_NC00156$" })
    };
}
