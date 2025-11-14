using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R12 - .
/// </summary>
public class F40R12 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CQCUMID.
        /// </summary>
        public const string CQCUMID = "CQCUMID";

        /// <summary>
        /// CQMCU.
        /// </summary>
        public const string CQMCU = "CQMCU";

        /// <summary>
        /// CQCITM.
        /// </summary>
        public const string CQCITM = "CQCITM";

        /// <summary>
        /// CQAN8.
        /// </summary>
        public const string CQAN8 = "CQAN8";

        /// <summary>
        /// CQSHAN.
        /// </summary>
        public const string CQSHAN = "CQSHAN";

        /// <summary>
        /// CQCSTPO.
        /// </summary>
        public const string CQCSTPO = "CQCSTPO";

        /// <summary>
        /// CQCUMUV1.
        /// </summary>
        public const string CQCUMUV1 = "CQCUMUV1";

        /// <summary>
        /// CQCUMUV2.
        /// </summary>
        public const string CQCUMUV2 = "CQCUMUV2";

        /// <summary>
        /// CQCUMUV3.
        /// </summary>
        public const string CQCUMUV3 = "CQCUMUV3";

        /// <summary>
        /// CQCUMUT1.
        /// </summary>
        public const string CQCUMUT1 = "CQCUMUT1";

        /// <summary>
        /// CQCUMUT2.
        /// </summary>
        public const string CQCUMUT2 = "CQCUMUT2";

        /// <summary>
        /// CQCUMUT3.
        /// </summary>
        public const string CQCUMUT3 = "CQCUMUT3";

        /// <summary>
        /// CQCUMTYPE.
        /// </summary>
        public const string CQCUMTYPE = "CQCUMTYPE";

        /// <summary>
        /// CQCUMADJ.
        /// </summary>
        public const string CQCUMADJ = "CQCUMADJ";

        /// <summary>
        /// CQSHPN.
        /// </summary>
        public const string CQSHPN = "CQSHPN";

        /// <summary>
        /// CQCUMREFNO.
        /// </summary>
        public const string CQCUMREFNO = "CQCUMREFNO";

        /// <summary>
        /// CQCUMS.
        /// </summary>
        public const string CQCUMS = "CQCUMS";

        /// <summary>
        /// CQCUMSADJ.
        /// </summary>
        public const string CQCUMSADJ = "CQCUMSADJ";

        /// <summary>
        /// CQADDJ.
        /// </summary>
        public const string CQADDJ = "CQADDJ";

        /// <summary>
        /// CQADTM.
        /// </summary>
        public const string CQADTM = "CQADTM";

        /// <summary>
        /// CQCCUMRQY.
        /// </summary>
        public const string CQCCUMRQY = "CQCCUMRQY";

        /// <summary>
        /// CQCCUMRDJ.
        /// </summary>
        public const string CQCCUMRDJ = "CQCCUMRDJ";

        /// <summary>
        /// CQCCUMRTM.
        /// </summary>
        public const string CQCCUMRTM = "CQCCUMRTM";

        /// <summary>
        /// CQCRQQYFM.
        /// </summary>
        public const string CQCRQQYFM = "CQCRQQYFM";

        /// <summary>
        /// CQCRQQYPN.
        /// </summary>
        public const string CQCRQQYPN = "CQCRQQYPN";

        /// <summary>
        /// CQCRQQYPS.
        /// </summary>
        public const string CQCRQQYPS = "CQCRQQYPS";

        /// <summary>
        /// CQCRQSDJFM.
        /// </summary>
        public const string CQCRQSDJFM = "CQCRQSDJFM";

        /// <summary>
        /// CQCRQSTMFM.
        /// </summary>
        public const string CQCRQSTMFM = "CQCRQSTMFM";

        /// <summary>
        /// CQCRQEDJFM.
        /// </summary>
        public const string CQCRQEDJFM = "CQCRQEDJFM";

        /// <summary>
        /// CQCRQETMFM.
        /// </summary>
        public const string CQCRQETMFM = "CQCRQETMFM";

        /// <summary>
        /// CQCRQSDJPN.
        /// </summary>
        public const string CQCRQSDJPN = "CQCRQSDJPN";

        /// <summary>
        /// CQCRQSTMPN.
        /// </summary>
        public const string CQCRQSTMPN = "CQCRQSTMPN";

        /// <summary>
        /// CQCRQEDJPN.
        /// </summary>
        public const string CQCRQEDJPN = "CQCRQEDJPN";

        /// <summary>
        /// CQCRQETMPN.
        /// </summary>
        public const string CQCRQETMPN = "CQCRQETMPN";

        /// <summary>
        /// CQCRQSDJPS.
        /// </summary>
        public const string CQCRQSDJPS = "CQCRQSDJPS";

        /// <summary>
        /// CQCRQSTMPS.
        /// </summary>
        public const string CQCRQSTMPS = "CQCRQSTMPS";

        /// <summary>
        /// CQCRQEDJPS.
        /// </summary>
        public const string CQCRQEDJPS = "CQCRQEDJPS";

        /// <summary>
        /// CQCRQETMPS.
        /// </summary>
        public const string CQCRQETMPS = "CQCRQETMPS";

        /// <summary>
        /// CQCCUMSQY.
        /// </summary>
        public const string CQCCUMSQY = "CQCCUMSQY";

        /// <summary>
        /// CQCCUMSDJ.
        /// </summary>
        public const string CQCCUMSDJ = "CQCCUMSDJ";

        /// <summary>
        /// CQCCUMSTM.
        /// </summary>
        public const string CQCCUMSTM = "CQCCUMSTM";

        /// <summary>
        /// CQCCUMSUOM.
        /// </summary>
        public const string CQCCUMSUOM = "CQCCUMSUOM";

        /// <summary>
        /// CQFBCUMQY.
        /// </summary>
        public const string CQFBCUMQY = "CQFBCUMQY";

        /// <summary>
        /// CQFBCUMSDJ.
        /// </summary>
        public const string CQFBCUMSDJ = "CQFBCUMSDJ";

        /// <summary>
        /// CQFBCUMEDJ.
        /// </summary>
        public const string CQFBCUMEDJ = "CQFBCUMEDJ";

        /// <summary>
        /// CQMTCUMQY.
        /// </summary>
        public const string CQMTCUMQY = "CQMTCUMQY";

        /// <summary>
        /// CQMTCUMSDJ.
        /// </summary>
        public const string CQMTCUMSDJ = "CQMTCUMSDJ";

        /// <summary>
        /// CQMTCUMEDJ.
        /// </summary>
        public const string CQMTCUMEDJ = "CQMTCUMEDJ";

        /// <summary>
        /// CQHFBCUMQY.
        /// </summary>
        public const string CQHFBCUMQY = "CQHFBCUMQY";

        /// <summary>
        /// CQHFBRLDJ.
        /// </summary>
        public const string CQHFBRLDJ = "CQHFBRLDJ";

        /// <summary>
        /// CQHFBRLNO.
        /// </summary>
        public const string CQHFBRLNO = "CQHFBRLNO";

        /// <summary>
        /// CQHMTCUMQY.
        /// </summary>
        public const string CQHMTCUMQY = "CQHMTCUMQY";

        /// <summary>
        /// CQHMTRLDJ.
        /// </summary>
        public const string CQHMTRLDJ = "CQHMTRLDJ";

        /// <summary>
        /// CQHMTRLNO.
        /// </summary>
        public const string CQHMTRLNO = "CQHMTRLNO";

        /// <summary>
        /// CQCUMRBDJ.
        /// </summary>
        public const string CQCUMRBDJ = "CQCUMRBDJ";

        /// <summary>
        /// CQCUMRBTM.
        /// </summary>
        public const string CQCUMRBTM = "CQCUMRBTM";

        /// <summary>
        /// CQURCD.
        /// </summary>
        public const string CQURCD = "CQURCD";

        /// <summary>
        /// CQURDT.
        /// </summary>
        public const string CQURDT = "CQURDT";

        /// <summary>
        /// CQURAT.
        /// </summary>
        public const string CQURAT = "CQURAT";

        /// <summary>
        /// CQURAB.
        /// </summary>
        public const string CQURAB = "CQURAB";

        /// <summary>
        /// CQURRF.
        /// </summary>
        public const string CQURRF = "CQURRF";

        /// <summary>
        /// CQUSER.
        /// </summary>
        public const string CQUSER = "CQUSER";

        /// <summary>
        /// CQPID.
        /// </summary>
        public const string CQPID = "CQPID";

        /// <summary>
        /// CQJOBN.
        /// </summary>
        public const string CQJOBN = "CQJOBN";

        /// <summary>
        /// CQUPMJ.
        /// </summary>
        public const string CQUPMJ = "CQUPMJ";

        /// <summary>
        /// CQTDAY.
        /// </summary>
        public const string CQTDAY = "CQTDAY";

        /// <summary>
        /// CQCUMATID.
        /// </summary>
        public const string CQCUMATID = "CQCUMATID";
    }

    /// <inheritdoc />
    public override string TableName => "F40R12";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CQCUMID", "CQCUMID", JdeDataType.Numeric, null, true, true),
        new JdeField("CQMCU", "CQMCU", JdeDataType.String, 24),
        new JdeField("CQCITM", "CQCITM", JdeDataType.String, 50),
        new JdeField("CQAN8", "CQAN8", JdeDataType.Numeric),
        new JdeField("CQSHAN", "CQSHAN", JdeDataType.Numeric),
        new JdeField("CQCSTPO", "CQCSTPO", JdeDataType.String, 60),
        new JdeField("CQCUMUV1", "CQCUMUV1", JdeDataType.String, 60),
        new JdeField("CQCUMUV2", "CQCUMUV2", JdeDataType.String, 60),
        new JdeField("CQCUMUV3", "CQCUMUV3", JdeDataType.String, 60),
        new JdeField("CQCUMUT1", "CQCUMUT1", JdeDataType.String, 6),
        new JdeField("CQCUMUT2", "CQCUMUT2", JdeDataType.String, 6),
        new JdeField("CQCUMUT3", "CQCUMUT3", JdeDataType.String, 6),
        new JdeField("CQCUMTYPE", "CQCUMTYPE", JdeDataType.String, 2),
        new JdeField("CQCUMADJ", "CQCUMADJ", JdeDataType.String, 4),
        new JdeField("CQSHPN", "CQSHPN", JdeDataType.Numeric),
        new JdeField("CQCUMREFNO", "CQCUMREFNO", JdeDataType.String, 50),
        new JdeField("CQCUMS", "CQCUMS", JdeDataType.Numeric),
        new JdeField("CQCUMSADJ", "CQCUMSADJ", JdeDataType.Numeric),
        new JdeField("CQADDJ", "CQADDJ", JdeDataType.Numeric),
        new JdeField("CQADTM", "CQADTM", JdeDataType.Numeric),
        new JdeField("CQCCUMRQY", "CQCCUMRQY", JdeDataType.Numeric),
        new JdeField("CQCCUMRDJ", "CQCCUMRDJ", JdeDataType.Numeric),
        new JdeField("CQCCUMRTM", "CQCCUMRTM", JdeDataType.Numeric),
        new JdeField("CQCRQQYFM", "CQCRQQYFM", JdeDataType.Numeric),
        new JdeField("CQCRQQYPN", "CQCRQQYPN", JdeDataType.Numeric),
        new JdeField("CQCRQQYPS", "CQCRQQYPS", JdeDataType.Numeric),
        new JdeField("CQCRQSDJFM", "CQCRQSDJFM", JdeDataType.Numeric),
        new JdeField("CQCRQSTMFM", "CQCRQSTMFM", JdeDataType.Numeric),
        new JdeField("CQCRQEDJFM", "CQCRQEDJFM", JdeDataType.Numeric),
        new JdeField("CQCRQETMFM", "CQCRQETMFM", JdeDataType.Numeric),
        new JdeField("CQCRQSDJPN", "CQCRQSDJPN", JdeDataType.Numeric),
        new JdeField("CQCRQSTMPN", "CQCRQSTMPN", JdeDataType.Numeric),
        new JdeField("CQCRQEDJPN", "CQCRQEDJPN", JdeDataType.Numeric),
        new JdeField("CQCRQETMPN", "CQCRQETMPN", JdeDataType.Numeric),
        new JdeField("CQCRQSDJPS", "CQCRQSDJPS", JdeDataType.Numeric),
        new JdeField("CQCRQSTMPS", "CQCRQSTMPS", JdeDataType.Numeric),
        new JdeField("CQCRQEDJPS", "CQCRQEDJPS", JdeDataType.Numeric),
        new JdeField("CQCRQETMPS", "CQCRQETMPS", JdeDataType.Numeric),
        new JdeField("CQCCUMSQY", "CQCCUMSQY", JdeDataType.Numeric),
        new JdeField("CQCCUMSDJ", "CQCCUMSDJ", JdeDataType.Numeric),
        new JdeField("CQCCUMSTM", "CQCCUMSTM", JdeDataType.Numeric),
        new JdeField("CQCCUMSUOM", "CQCCUMSUOM", JdeDataType.String, 4),
        new JdeField("CQFBCUMQY", "CQFBCUMQY", JdeDataType.Numeric),
        new JdeField("CQFBCUMSDJ", "CQFBCUMSDJ", JdeDataType.Numeric),
        new JdeField("CQFBCUMEDJ", "CQFBCUMEDJ", JdeDataType.Numeric),
        new JdeField("CQMTCUMQY", "CQMTCUMQY", JdeDataType.Numeric),
        new JdeField("CQMTCUMSDJ", "CQMTCUMSDJ", JdeDataType.Numeric),
        new JdeField("CQMTCUMEDJ", "CQMTCUMEDJ", JdeDataType.Numeric),
        new JdeField("CQHFBCUMQY", "CQHFBCUMQY", JdeDataType.Numeric),
        new JdeField("CQHFBRLDJ", "CQHFBRLDJ", JdeDataType.Numeric),
        new JdeField("CQHFBRLNO", "CQHFBRLNO", JdeDataType.String, 20),
        new JdeField("CQHMTCUMQY", "CQHMTCUMQY", JdeDataType.Numeric),
        new JdeField("CQHMTRLDJ", "CQHMTRLDJ", JdeDataType.Numeric),
        new JdeField("CQHMTRLNO", "CQHMTRLNO", JdeDataType.String, 20),
        new JdeField("CQCUMRBDJ", "CQCUMRBDJ", JdeDataType.Numeric),
        new JdeField("CQCUMRBTM", "CQCUMRBTM", JdeDataType.Numeric),
        new JdeField("CQURCD", "CQURCD", JdeDataType.String, 4),
        new JdeField("CQURDT", "CQURDT", JdeDataType.Numeric),
        new JdeField("CQURAT", "CQURAT", JdeDataType.Numeric),
        new JdeField("CQURAB", "CQURAB", JdeDataType.Numeric),
        new JdeField("CQURRF", "CQURRF", JdeDataType.String, 30),
        new JdeField("CQUSER", "CQUSER", JdeDataType.String, 20),
        new JdeField("CQPID", "CQPID", JdeDataType.String, 20),
        new JdeField("CQJOBN", "CQJOBN", JdeDataType.String, 20),
        new JdeField("CQUPMJ", "CQUPMJ", JdeDataType.Numeric),
        new JdeField("CQTDAY", "CQTDAY", JdeDataType.Numeric),
        new JdeField("CQCUMATID", "CQCUMATID", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R12_0", "Primary Key on CQCUMID", new[] { "CQCUMID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F40R12_2", "Index on CQMCU, CQCITM, CQAN8, CQSHAN, CQCSTPO, CQCUMUV1, CQCUMUV2, CQCUMUV3, CQCUMUT1, CQCUMUT2, CQCUMUT3, CQCUMTYPE", new[] { "CQMCU", "CQCITM", "CQAN8", "CQSHAN", "CQCSTPO", "CQCUMUV1", "CQCUMUV2", "CQCUMUV3", "CQCUMUT1", "CQCUMUT2", "CQCUMUT3", "CQCUMTYPE" })
    };
}
