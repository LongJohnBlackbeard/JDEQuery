using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R42 - .
/// </summary>
public class F40R42 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CHCUMID.
        /// </summary>
        public const string CHCUMID = "CHCUMID";

        /// <summary>
        /// CHCREATEDJ.
        /// </summary>
        public const string CHCREATEDJ = "CHCREATEDJ";

        /// <summary>
        /// CHCREATETM.
        /// </summary>
        public const string CHCREATETM = "CHCREATETM";

        /// <summary>
        /// CHMCU.
        /// </summary>
        public const string CHMCU = "CHMCU";

        /// <summary>
        /// CHAN8.
        /// </summary>
        public const string CHAN8 = "CHAN8";

        /// <summary>
        /// CHCITM.
        /// </summary>
        public const string CHCITM = "CHCITM";

        /// <summary>
        /// CHSHAN.
        /// </summary>
        public const string CHSHAN = "CHSHAN";

        /// <summary>
        /// CHCSTPO.
        /// </summary>
        public const string CHCSTPO = "CHCSTPO";

        /// <summary>
        /// CHCUMUV1.
        /// </summary>
        public const string CHCUMUV1 = "CHCUMUV1";

        /// <summary>
        /// CHCUMUV2.
        /// </summary>
        public const string CHCUMUV2 = "CHCUMUV2";

        /// <summary>
        /// CHCUMUV3.
        /// </summary>
        public const string CHCUMUV3 = "CHCUMUV3";

        /// <summary>
        /// CHCUMUT1.
        /// </summary>
        public const string CHCUMUT1 = "CHCUMUT1";

        /// <summary>
        /// CHCUMUT2.
        /// </summary>
        public const string CHCUMUT2 = "CHCUMUT2";

        /// <summary>
        /// CHCUMUT3.
        /// </summary>
        public const string CHCUMUT3 = "CHCUMUT3";

        /// <summary>
        /// CHCUMTYPE.
        /// </summary>
        public const string CHCUMTYPE = "CHCUMTYPE";

        /// <summary>
        /// CHCUMATID.
        /// </summary>
        public const string CHCUMATID = "CHCUMATID";

        /// <summary>
        /// CHCUMADJ.
        /// </summary>
        public const string CHCUMADJ = "CHCUMADJ";

        /// <summary>
        /// CHSHPN.
        /// </summary>
        public const string CHSHPN = "CHSHPN";

        /// <summary>
        /// CHCUMREFNO.
        /// </summary>
        public const string CHCUMREFNO = "CHCUMREFNO";

        /// <summary>
        /// CHCUMS.
        /// </summary>
        public const string CHCUMS = "CHCUMS";

        /// <summary>
        /// CHCUMSADJ.
        /// </summary>
        public const string CHCUMSADJ = "CHCUMSADJ";

        /// <summary>
        /// CHADDJ.
        /// </summary>
        public const string CHADDJ = "CHADDJ";

        /// <summary>
        /// CHADTM.
        /// </summary>
        public const string CHADTM = "CHADTM";

        /// <summary>
        /// CHCCUMRQY.
        /// </summary>
        public const string CHCCUMRQY = "CHCCUMRQY";

        /// <summary>
        /// CHCCUMRDJ.
        /// </summary>
        public const string CHCCUMRDJ = "CHCCUMRDJ";

        /// <summary>
        /// CHCCUMRTM.
        /// </summary>
        public const string CHCCUMRTM = "CHCCUMRTM";

        /// <summary>
        /// CHCRQQYFM.
        /// </summary>
        public const string CHCRQQYFM = "CHCRQQYFM";

        /// <summary>
        /// CHCRQQYPN.
        /// </summary>
        public const string CHCRQQYPN = "CHCRQQYPN";

        /// <summary>
        /// CHCRQQYPS.
        /// </summary>
        public const string CHCRQQYPS = "CHCRQQYPS";

        /// <summary>
        /// CHCRQSDJFM.
        /// </summary>
        public const string CHCRQSDJFM = "CHCRQSDJFM";

        /// <summary>
        /// CHCRQSTMFM.
        /// </summary>
        public const string CHCRQSTMFM = "CHCRQSTMFM";

        /// <summary>
        /// CHCRQEDJFM.
        /// </summary>
        public const string CHCRQEDJFM = "CHCRQEDJFM";

        /// <summary>
        /// CHCRQETMFM.
        /// </summary>
        public const string CHCRQETMFM = "CHCRQETMFM";

        /// <summary>
        /// CHCRQSDJPN.
        /// </summary>
        public const string CHCRQSDJPN = "CHCRQSDJPN";

        /// <summary>
        /// CHCRQSTMPN.
        /// </summary>
        public const string CHCRQSTMPN = "CHCRQSTMPN";

        /// <summary>
        /// CHCRQEDJPN.
        /// </summary>
        public const string CHCRQEDJPN = "CHCRQEDJPN";

        /// <summary>
        /// CHCRQETMPN.
        /// </summary>
        public const string CHCRQETMPN = "CHCRQETMPN";

        /// <summary>
        /// CHCRQSDJPS.
        /// </summary>
        public const string CHCRQSDJPS = "CHCRQSDJPS";

        /// <summary>
        /// CHCRQSTMPS.
        /// </summary>
        public const string CHCRQSTMPS = "CHCRQSTMPS";

        /// <summary>
        /// CHCRQEDJPS.
        /// </summary>
        public const string CHCRQEDJPS = "CHCRQEDJPS";

        /// <summary>
        /// CHCRQETMPS.
        /// </summary>
        public const string CHCRQETMPS = "CHCRQETMPS";

        /// <summary>
        /// CHCCUMSQY.
        /// </summary>
        public const string CHCCUMSQY = "CHCCUMSQY";

        /// <summary>
        /// CHCCUMSDJ.
        /// </summary>
        public const string CHCCUMSDJ = "CHCCUMSDJ";

        /// <summary>
        /// CHCCUMSTM.
        /// </summary>
        public const string CHCCUMSTM = "CHCCUMSTM";

        /// <summary>
        /// CHCCUMSUOM.
        /// </summary>
        public const string CHCCUMSUOM = "CHCCUMSUOM";

        /// <summary>
        /// CHFBCUMQY.
        /// </summary>
        public const string CHFBCUMQY = "CHFBCUMQY";

        /// <summary>
        /// CHFBCUMSDJ.
        /// </summary>
        public const string CHFBCUMSDJ = "CHFBCUMSDJ";

        /// <summary>
        /// CHFBCUMEDJ.
        /// </summary>
        public const string CHFBCUMEDJ = "CHFBCUMEDJ";

        /// <summary>
        /// CHMTCUMQY.
        /// </summary>
        public const string CHMTCUMQY = "CHMTCUMQY";

        /// <summary>
        /// CHMTCUMSDJ.
        /// </summary>
        public const string CHMTCUMSDJ = "CHMTCUMSDJ";

        /// <summary>
        /// CHMTCUMEDJ.
        /// </summary>
        public const string CHMTCUMEDJ = "CHMTCUMEDJ";

        /// <summary>
        /// CHCUMRBDJ.
        /// </summary>
        public const string CHCUMRBDJ = "CHCUMRBDJ";

        /// <summary>
        /// CHCUMRBTM.
        /// </summary>
        public const string CHCUMRBTM = "CHCUMRBTM";

        /// <summary>
        /// CHURCD.
        /// </summary>
        public const string CHURCD = "CHURCD";

        /// <summary>
        /// CHURDT.
        /// </summary>
        public const string CHURDT = "CHURDT";

        /// <summary>
        /// CHURAT.
        /// </summary>
        public const string CHURAT = "CHURAT";

        /// <summary>
        /// CHURAB.
        /// </summary>
        public const string CHURAB = "CHURAB";

        /// <summary>
        /// CHURRF.
        /// </summary>
        public const string CHURRF = "CHURRF";

        /// <summary>
        /// CHUSER.
        /// </summary>
        public const string CHUSER = "CHUSER";

        /// <summary>
        /// CHPID.
        /// </summary>
        public const string CHPID = "CHPID";

        /// <summary>
        /// CHJOBN.
        /// </summary>
        public const string CHJOBN = "CHJOBN";

        /// <summary>
        /// CHUPMJ.
        /// </summary>
        public const string CHUPMJ = "CHUPMJ";

        /// <summary>
        /// CHTDAY.
        /// </summary>
        public const string CHTDAY = "CHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R42";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CHCUMID", "CHCUMID", JdeDataType.Numeric, null, true, true),
        new JdeField("CHCREATEDJ", "CHCREATEDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CHCREATETM", "CHCREATETM", JdeDataType.Numeric, null, true, true),
        new JdeField("CHMCU", "CHMCU", JdeDataType.String, 24),
        new JdeField("CHAN8", "CHAN8", JdeDataType.Numeric),
        new JdeField("CHCITM", "CHCITM", JdeDataType.String, 50),
        new JdeField("CHSHAN", "CHSHAN", JdeDataType.Numeric),
        new JdeField("CHCSTPO", "CHCSTPO", JdeDataType.String, 60),
        new JdeField("CHCUMUV1", "CHCUMUV1", JdeDataType.String, 60),
        new JdeField("CHCUMUV2", "CHCUMUV2", JdeDataType.String, 60),
        new JdeField("CHCUMUV3", "CHCUMUV3", JdeDataType.String, 60),
        new JdeField("CHCUMUT1", "CHCUMUT1", JdeDataType.String, 6),
        new JdeField("CHCUMUT2", "CHCUMUT2", JdeDataType.String, 6),
        new JdeField("CHCUMUT3", "CHCUMUT3", JdeDataType.String, 6),
        new JdeField("CHCUMTYPE", "CHCUMTYPE", JdeDataType.String, 2),
        new JdeField("CHCUMATID", "CHCUMATID", JdeDataType.Numeric),
        new JdeField("CHCUMADJ", "CHCUMADJ", JdeDataType.String, 4),
        new JdeField("CHSHPN", "CHSHPN", JdeDataType.Numeric),
        new JdeField("CHCUMREFNO", "CHCUMREFNO", JdeDataType.String, 50),
        new JdeField("CHCUMS", "CHCUMS", JdeDataType.Numeric),
        new JdeField("CHCUMSADJ", "CHCUMSADJ", JdeDataType.Numeric),
        new JdeField("CHADDJ", "CHADDJ", JdeDataType.Numeric),
        new JdeField("CHADTM", "CHADTM", JdeDataType.Numeric),
        new JdeField("CHCCUMRQY", "CHCCUMRQY", JdeDataType.Numeric),
        new JdeField("CHCCUMRDJ", "CHCCUMRDJ", JdeDataType.Numeric),
        new JdeField("CHCCUMRTM", "CHCCUMRTM", JdeDataType.Numeric),
        new JdeField("CHCRQQYFM", "CHCRQQYFM", JdeDataType.Numeric),
        new JdeField("CHCRQQYPN", "CHCRQQYPN", JdeDataType.Numeric),
        new JdeField("CHCRQQYPS", "CHCRQQYPS", JdeDataType.Numeric),
        new JdeField("CHCRQSDJFM", "CHCRQSDJFM", JdeDataType.Numeric),
        new JdeField("CHCRQSTMFM", "CHCRQSTMFM", JdeDataType.Numeric),
        new JdeField("CHCRQEDJFM", "CHCRQEDJFM", JdeDataType.Numeric),
        new JdeField("CHCRQETMFM", "CHCRQETMFM", JdeDataType.Numeric),
        new JdeField("CHCRQSDJPN", "CHCRQSDJPN", JdeDataType.Numeric),
        new JdeField("CHCRQSTMPN", "CHCRQSTMPN", JdeDataType.Numeric),
        new JdeField("CHCRQEDJPN", "CHCRQEDJPN", JdeDataType.Numeric),
        new JdeField("CHCRQETMPN", "CHCRQETMPN", JdeDataType.Numeric),
        new JdeField("CHCRQSDJPS", "CHCRQSDJPS", JdeDataType.Numeric),
        new JdeField("CHCRQSTMPS", "CHCRQSTMPS", JdeDataType.Numeric),
        new JdeField("CHCRQEDJPS", "CHCRQEDJPS", JdeDataType.Numeric),
        new JdeField("CHCRQETMPS", "CHCRQETMPS", JdeDataType.Numeric),
        new JdeField("CHCCUMSQY", "CHCCUMSQY", JdeDataType.Numeric),
        new JdeField("CHCCUMSDJ", "CHCCUMSDJ", JdeDataType.Numeric),
        new JdeField("CHCCUMSTM", "CHCCUMSTM", JdeDataType.Numeric),
        new JdeField("CHCCUMSUOM", "CHCCUMSUOM", JdeDataType.String, 4),
        new JdeField("CHFBCUMQY", "CHFBCUMQY", JdeDataType.Numeric),
        new JdeField("CHFBCUMSDJ", "CHFBCUMSDJ", JdeDataType.Numeric),
        new JdeField("CHFBCUMEDJ", "CHFBCUMEDJ", JdeDataType.Numeric),
        new JdeField("CHMTCUMQY", "CHMTCUMQY", JdeDataType.Numeric),
        new JdeField("CHMTCUMSDJ", "CHMTCUMSDJ", JdeDataType.Numeric),
        new JdeField("CHMTCUMEDJ", "CHMTCUMEDJ", JdeDataType.Numeric),
        new JdeField("CHCUMRBDJ", "CHCUMRBDJ", JdeDataType.Numeric),
        new JdeField("CHCUMRBTM", "CHCUMRBTM", JdeDataType.Numeric),
        new JdeField("CHURCD", "CHURCD", JdeDataType.String, 4),
        new JdeField("CHURDT", "CHURDT", JdeDataType.Numeric),
        new JdeField("CHURAT", "CHURAT", JdeDataType.Numeric),
        new JdeField("CHURAB", "CHURAB", JdeDataType.Numeric),
        new JdeField("CHURRF", "CHURRF", JdeDataType.String, 30),
        new JdeField("CHUSER", "CHUSER", JdeDataType.String, 20),
        new JdeField("CHPID", "CHPID", JdeDataType.String, 20),
        new JdeField("CHJOBN", "CHJOBN", JdeDataType.String, 20),
        new JdeField("CHUPMJ", "CHUPMJ", JdeDataType.Numeric),
        new JdeField("CHTDAY", "CHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R42_0", "Primary Key on CHCUMID, CHCREATEDJ, CHCREATETM", new[] { "CHCUMID", "CHCREATEDJ", "CHCREATETM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40R42_2", "Index on CHCUMID, SYS_NC00064$, SYS_NC00065$", new[] { "CHCUMID", "SYS_NC00064$", "SYS_NC00065$" })
    };
}
