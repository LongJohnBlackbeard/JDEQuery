using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F30UI004 - .
/// </summary>
public class F30UI004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFCTID.
        /// </summary>
        public const string WFCTID = "WFCTID";

        /// <summary>
        /// WFPSQ.
        /// </summary>
        public const string WFPSQ = "WFPSQ";

        /// <summary>
        /// WFOKIT.
        /// </summary>
        public const string WFOKIT = "WFOKIT";

        /// <summary>
        /// WFOMCU.
        /// </summary>
        public const string WFOMCU = "WFOMCU";

        /// <summary>
        /// WFOTBM.
        /// </summary>
        public const string WFOTBM = "WFOTBM";

        /// <summary>
        /// WFOBQT.
        /// </summary>
        public const string WFOBQT = "WFOBQT";

        /// <summary>
        /// WFOUOM.
        /// </summary>
        public const string WFOUOM = "WFOUOM";

        /// <summary>
        /// WFOITM.
        /// </summary>
        public const string WFOITM = "WFOITM";

        /// <summary>
        /// WFCCMC.
        /// </summary>
        public const string WFCCMC = "WFCCMC";

        /// <summary>
        /// WFOCPN.
        /// </summary>
        public const string WFOCPN = "WFOCPN";

        /// <summary>
        /// WFLINS.
        /// </summary>
        public const string WFLINS = "WFLINS";

        /// <summary>
        /// WFKIT.
        /// </summary>
        public const string WFKIT = "WFKIT";

        /// <summary>
        /// WFMMCU.
        /// </summary>
        public const string WFMMCU = "WFMMCU";

        /// <summary>
        /// WFTBM.
        /// </summary>
        public const string WFTBM = "WFTBM";

        /// <summary>
        /// WFBQTY.
        /// </summary>
        public const string WFBQTY = "WFBQTY";

        /// <summary>
        /// WFUOM.
        /// </summary>
        public const string WFUOM = "WFUOM";

        /// <summary>
        /// WFITM.
        /// </summary>
        public const string WFITM = "WFITM";

        /// <summary>
        /// WFCMCU.
        /// </summary>
        public const string WFCMCU = "WFCMCU";

        /// <summary>
        /// WFCPNT.
        /// </summary>
        public const string WFCPNT = "WFCPNT";

        /// <summary>
        /// WFOEF.
        /// </summary>
        public const string WFOEF = "WFOEF";

        /// <summary>
        /// WFOET.
        /// </summary>
        public const string WFOET = "WFOET";

        /// <summary>
        /// WFNET.
        /// </summary>
        public const string WFNET = "WFNET";

        /// <summary>
        /// WFNEF.
        /// </summary>
        public const string WFNEF = "WFNEF";

        /// <summary>
        /// WFQNTY.
        /// </summary>
        public const string WFQNTY = "WFQNTY";

        /// <summary>
        /// WFUM.
        /// </summary>
        public const string WFUM = "WFUM";

        /// <summary>
        /// WFBREV.
        /// </summary>
        public const string WFBREV = "WFBREV";

        /// <summary>
        /// WFCMRV.
        /// </summary>
        public const string WFCMRV = "WFCMRV";

        /// <summary>
        /// WFTIC.
        /// </summary>
        public const string WFTIC = "WFTIC";

        /// <summary>
        /// WFECPR.
        /// </summary>
        public const string WFECPR = "WFECPR";

        /// <summary>
        /// WFRSQ.
        /// </summary>
        public const string WFRSQ = "WFRSQ";

        /// <summary>
        /// WFERR1.
        /// </summary>
        public const string WFERR1 = "WFERR1";

        /// <summary>
        /// WFERR2.
        /// </summary>
        public const string WFERR2 = "WFERR2";

        /// <summary>
        /// WFERR3.
        /// </summary>
        public const string WFERR3 = "WFERR3";

        /// <summary>
        /// WFOPSQ.
        /// </summary>
        public const string WFOPSQ = "WFOPSQ";

        /// <summary>
        /// WFFORQ.
        /// </summary>
        public const string WFFORQ = "WFFORQ";

        /// <summary>
        /// WFOREV.
        /// </summary>
        public const string WFOREV = "WFOREV";

        /// <summary>
        /// WFUKID.
        /// </summary>
        public const string WFUKID = "WFUKID";

        /// <summary>
        /// WFMCU.
        /// </summary>
        public const string WFMCU = "WFMCU";

        /// <summary>
        /// WFRITM.
        /// </summary>
        public const string WFRITM = "WFRITM";

        /// <summary>
        /// WFTP.
        /// </summary>
        public const string WFTP = "WFTP";

        /// <summary>
        /// WFCPCN.
        /// </summary>
        public const string WFCPCN = "WFCPCN";

        /// <summary>
        /// WFCPNN.
        /// </summary>
        public const string WFCPNN = "WFCPNN";

        /// <summary>
        /// WFSBNT.
        /// </summary>
        public const string WFSBNT = "WFSBNT";

        /// <summary>
        /// WFCOBY.
        /// </summary>
        public const string WFCOBY = "WFCOBY";

        /// <summary>
        /// WFSRV.
        /// </summary>
        public const string WFSRV = "WFSRV";

        /// <summary>
        /// WFRVNO.
        /// </summary>
        public const string WFRVNO = "WFRVNO";

        /// <summary>
        /// WFTRV.
        /// </summary>
        public const string WFTRV = "WFTRV";

        /// <summary>
        /// WFERR4.
        /// </summary>
        public const string WFERR4 = "WFERR4";

        /// <summary>
        /// WFERR5.
        /// </summary>
        public const string WFERR5 = "WFERR5";

        /// <summary>
        /// WFITC.
        /// </summary>
        public const string WFITC = "WFITC";

        /// <summary>
        /// WFFSER.
        /// </summary>
        public const string WFFSER = "WFFSER";

        /// <summary>
        /// WFTSER.
        /// </summary>
        public const string WFTSER = "WFTSER";

        /// <summary>
        /// WFLOVD.
        /// </summary>
        public const string WFLOVD = "WFLOVD";

        /// <summary>
        /// WFPRIC.
        /// </summary>
        public const string WFPRIC = "WFPRIC";

        /// <summary>
        /// WFUNCS.
        /// </summary>
        public const string WFUNCS = "WFUNCS";

        /// <summary>
        /// WFFRGD.
        /// </summary>
        public const string WFFRGD = "WFFRGD";

        /// <summary>
        /// WFTHGD.
        /// </summary>
        public const string WFTHGD = "WFTHGD";

        /// <summary>
        /// WFFRMP.
        /// </summary>
        public const string WFFRMP = "WFFRMP";

        /// <summary>
        /// WFOPTK.
        /// </summary>
        public const string WFOPTK = "WFOPTK";

        /// <summary>
        /// WFSCRP.
        /// </summary>
        public const string WFSCRP = "WFSCRP";

        /// <summary>
        /// WFFTRC.
        /// </summary>
        public const string WFFTRC = "WFFTRC";

        /// <summary>
        /// WFTHRP.
        /// </summary>
        public const string WFTHRP = "WFTHRP";

        /// <summary>
        /// WFFORV.
        /// </summary>
        public const string WFFORV = "WFFORV";

        /// <summary>
        /// WFBSEQ.
        /// </summary>
        public const string WFBSEQ = "WFBSEQ";

        /// <summary>
        /// WFPRTA.
        /// </summary>
        public const string WFPRTA = "WFPRTA";

        /// <summary>
        /// WFLNTY.
        /// </summary>
        public const string WFLNTY = "WFLNTY";

        /// <summary>
        /// WFDSC1.
        /// </summary>
        public const string WFDSC1 = "WFDSC1";

        /// <summary>
        /// WFFTRP.
        /// </summary>
        public const string WFFTRP = "WFFTRP";

        /// <summary>
        /// WFF$RP.
        /// </summary>
        public const string WFF_RP = "WFF$RP";

        /// <summary>
        /// WFCPNB.
        /// </summary>
        public const string WFCPNB = "WFCPNB";

        /// <summary>
        /// WFBSEQAN.
        /// </summary>
        public const string WFBSEQAN = "WFBSEQAN";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFDOCO.
        /// </summary>
        public const string WFDOCO = "WFDOCO";
    }

    /// <inheritdoc />
    public override string TableName => "F30UI004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFCTID", "WFCTID", JdeDataType.String, 30, true, true),
        new JdeField("WFPSQ", "WFPSQ", JdeDataType.Numeric),
        new JdeField("WFOKIT", "WFOKIT", JdeDataType.Numeric),
        new JdeField("WFOMCU", "WFOMCU", JdeDataType.String, 24),
        new JdeField("WFOTBM", "WFOTBM", JdeDataType.String, 6),
        new JdeField("WFOBQT", "WFOBQT", JdeDataType.Numeric),
        new JdeField("WFOUOM", "WFOUOM", JdeDataType.String, 4),
        new JdeField("WFOITM", "WFOITM", JdeDataType.Numeric),
        new JdeField("WFCCMC", "WFCCMC", JdeDataType.String, 24),
        new JdeField("WFOCPN", "WFOCPN", JdeDataType.Numeric),
        new JdeField("WFLINS", "WFLINS", JdeDataType.Numeric),
        new JdeField("WFKIT", "WFKIT", JdeDataType.Numeric),
        new JdeField("WFMMCU", "WFMMCU", JdeDataType.String, 24),
        new JdeField("WFTBM", "WFTBM", JdeDataType.String, 6),
        new JdeField("WFBQTY", "WFBQTY", JdeDataType.Numeric),
        new JdeField("WFUOM", "WFUOM", JdeDataType.String, 4),
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric),
        new JdeField("WFCMCU", "WFCMCU", JdeDataType.String, 24),
        new JdeField("WFCPNT", "WFCPNT", JdeDataType.Numeric),
        new JdeField("WFOEF", "WFOEF", JdeDataType.Numeric),
        new JdeField("WFOET", "WFOET", JdeDataType.Numeric),
        new JdeField("WFNET", "WFNET", JdeDataType.Numeric),
        new JdeField("WFNEF", "WFNEF", JdeDataType.Numeric),
        new JdeField("WFQNTY", "WFQNTY", JdeDataType.Numeric),
        new JdeField("WFUM", "WFUM", JdeDataType.String, 4),
        new JdeField("WFBREV", "WFBREV", JdeDataType.String, 6),
        new JdeField("WFCMRV", "WFCMRV", JdeDataType.String, 6),
        new JdeField("WFTIC", "WFTIC", JdeDataType.String, 2),
        new JdeField("WFECPR", "WFECPR", JdeDataType.String, 2),
        new JdeField("WFRSQ", "WFRSQ", JdeDataType.Numeric),
        new JdeField("WFERR1", "WFERR1", JdeDataType.String, 2),
        new JdeField("WFERR2", "WFERR2", JdeDataType.String, 2),
        new JdeField("WFERR3", "WFERR3", JdeDataType.String, 2),
        new JdeField("WFOPSQ", "WFOPSQ", JdeDataType.Numeric),
        new JdeField("WFFORQ", "WFFORQ", JdeDataType.String, 2),
        new JdeField("WFOREV", "WFOREV", JdeDataType.String, 6),
        new JdeField("WFUKID", "WFUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24),
        new JdeField("WFRITM", "WFRITM", JdeDataType.Numeric),
        new JdeField("WFTP", "WFTP", JdeDataType.String, 6),
        new JdeField("WFCPCN", "WFCPCN", JdeDataType.Numeric),
        new JdeField("WFCPNN", "WFCPNN", JdeDataType.Numeric),
        new JdeField("WFSBNT", "WFSBNT", JdeDataType.Numeric),
        new JdeField("WFCOBY", "WFCOBY", JdeDataType.String, 2),
        new JdeField("WFSRV", "WFSRV", JdeDataType.String, 6),
        new JdeField("WFRVNO", "WFRVNO", JdeDataType.String, 4),
        new JdeField("WFTRV", "WFTRV", JdeDataType.String, 6),
        new JdeField("WFERR4", "WFERR4", JdeDataType.String, 2),
        new JdeField("WFERR5", "WFERR5", JdeDataType.String, 2),
        new JdeField("WFITC", "WFITC", JdeDataType.String, 2),
        new JdeField("WFFSER", "WFFSER", JdeDataType.String, 50),
        new JdeField("WFTSER", "WFTSER", JdeDataType.String, 50),
        new JdeField("WFLOVD", "WFLOVD", JdeDataType.Numeric),
        new JdeField("WFPRIC", "WFPRIC", JdeDataType.Numeric),
        new JdeField("WFUNCS", "WFUNCS", JdeDataType.Numeric),
        new JdeField("WFFRGD", "WFFRGD", JdeDataType.String, 6),
        new JdeField("WFTHGD", "WFTHGD", JdeDataType.String, 6),
        new JdeField("WFFRMP", "WFFRMP", JdeDataType.Numeric),
        new JdeField("WFOPTK", "WFOPTK", JdeDataType.String, 2),
        new JdeField("WFSCRP", "WFSCRP", JdeDataType.Numeric),
        new JdeField("WFFTRC", "WFFTRC", JdeDataType.String, 2),
        new JdeField("WFTHRP", "WFTHRP", JdeDataType.Numeric),
        new JdeField("WFFORV", "WFFORV", JdeDataType.String, 2),
        new JdeField("WFBSEQ", "WFBSEQ", JdeDataType.Numeric),
        new JdeField("WFPRTA", "WFPRTA", JdeDataType.String, 2),
        new JdeField("WFLNTY", "WFLNTY", JdeDataType.String, 4),
        new JdeField("WFDSC1", "WFDSC1", JdeDataType.String, 60),
        new JdeField("WFFTRP", "WFFTRP", JdeDataType.Numeric),
        new JdeField("WFF$RP", "WFF$RP", JdeDataType.Numeric),
        new JdeField("WFCPNB", "WFCPNB", JdeDataType.Numeric),
        new JdeField("WFBSEQAN", "WFBSEQAN", JdeDataType.String, 10),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20),
        new JdeField("WFDOCO", "WFDOCO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F30UI004_0", "Primary Key on WFCTID, WFUKID", new[] { "WFCTID", "WFUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F30UI004_1", "Unique Index on WFUKID, WFCTID, WFPSQ, WFOKIT, WFOMCU, WFOTBM, WFOBQT, WFOUOM, WFOITM, WFCCMC", new[] { "WFUKID", "WFCTID", "WFPSQ", "WFOKIT", "WFOMCU", "WFOTBM", "WFOBQT", "WFOUOM", "WFOITM", "WFCCMC" }, isUnique: true),
        new JdeIndex("F30UI004_3", "Index on WFUSER", new[] { "WFUSER" }),
        new JdeIndex("F30UI004_4", "Index on WFDOCO", new[] { "WFDOCO" })
    };
}
