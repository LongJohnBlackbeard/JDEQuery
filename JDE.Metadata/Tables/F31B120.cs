using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B120 - .
/// </summary>
public class F31B120 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HIWOPID.
        /// </summary>
        public const string HIWOPID = "HIWOPID";

        /// <summary>
        /// HIMCU.
        /// </summary>
        public const string HIMCU = "HIMCU";

        /// <summary>
        /// HIUKID.
        /// </summary>
        public const string HIUKID = "HIUKID";

        /// <summary>
        /// HIWOPN.
        /// </summary>
        public const string HIWOPN = "HIWOPN";

        /// <summary>
        /// HIWDSC1.
        /// </summary>
        public const string HIWDSC1 = "HIWDSC1";

        /// <summary>
        /// HIWCFGID.
        /// </summary>
        public const string HIWCFGID = "HIWCFGID";

        /// <summary>
        /// HIWCOPCD.
        /// </summary>
        public const string HIWCOPCD = "HIWCOPCD";

        /// <summary>
        /// HIWCDL01.
        /// </summary>
        public const string HIWCDL01 = "HIWCDL01";

        /// <summary>
        /// HIWASDT.
        /// </summary>
        public const string HIWASDT = "HIWASDT";

        /// <summary>
        /// HIWAEDT.
        /// </summary>
        public const string HIWAEDT = "HIWAEDT";

        /// <summary>
        /// HIWFVTY.
        /// </summary>
        public const string HIWFVTY = "HIWFVTY";

        /// <summary>
        /// HIWFROMVID.
        /// </summary>
        public const string HIWFROMVID = "HIWFROMVID";

        /// <summary>
        /// HIWTVTY.
        /// </summary>
        public const string HIWTVTY = "HIWTVTY";

        /// <summary>
        /// HIWTOVID.
        /// </summary>
        public const string HIWTOVID = "HIWTOVID";

        /// <summary>
        /// HIFRVNUM.
        /// </summary>
        public const string HIFRVNUM = "HIFRVNUM";

        /// <summary>
        /// HITOVNUM.
        /// </summary>
        public const string HITOVNUM = "HITOVNUM";

        /// <summary>
        /// HIWFB4LOTN.
        /// </summary>
        public const string HIWFB4LOTN = "HIWFB4LOTN";

        /// <summary>
        /// HIWFAFLOTN.
        /// </summary>
        public const string HIWFAFLOTN = "HIWFAFLOTN";

        /// <summary>
        /// HIWTB4LOTN.
        /// </summary>
        public const string HIWTB4LOTN = "HIWTB4LOTN";

        /// <summary>
        /// HIWTAFLOTN.
        /// </summary>
        public const string HIWTAFLOTN = "HIWTAFLOTN";

        /// <summary>
        /// HISB4BID.
        /// </summary>
        public const string HISB4BID = "HISB4BID";

        /// <summary>
        /// HIWFABID.
        /// </summary>
        public const string HIWFABID = "HIWFABID";

        /// <summary>
        /// HIWBID.
        /// </summary>
        public const string HIWBID = "HIWBID";

        /// <summary>
        /// HIWTABID.
        /// </summary>
        public const string HIWTABID = "HIWTABID";

        /// <summary>
        /// HIWFAAQTY.
        /// </summary>
        public const string HIWFAAQTY = "HIWFAAQTY";

        /// <summary>
        /// HIWFAAUOM.
        /// </summary>
        public const string HIWFAAUOM = "HIWFAAUOM";

        /// <summary>
        /// HIWTAAQTY.
        /// </summary>
        public const string HIWTAAQTY = "HIWTAAQTY";

        /// <summary>
        /// HIWTAAUOM.
        /// </summary>
        public const string HIWTAAUOM = "HIWTAAUOM";

        /// <summary>
        /// HIWACTVLMV.
        /// </summary>
        public const string HIWACTVLMV = "HIWACTVLMV";

        /// <summary>
        /// HIWACTUOM.
        /// </summary>
        public const string HIWACTUOM = "HIWACTUOM";

        /// <summary>
        /// HIWFRMAT.
        /// </summary>
        public const string HIWFRMAT = "HIWFRMAT";

        /// <summary>
        /// HIWTRMAT.
        /// </summary>
        public const string HIWTRMAT = "HIWTRMAT";

        /// <summary>
        /// HIWFAWS.
        /// </summary>
        public const string HIWFAWS = "HIWFAWS";

        /// <summary>
        /// HIWTAWS.
        /// </summary>
        public const string HIWTAWS = "HIWTAWS";
    }

    /// <inheritdoc />
    public override string TableName => "F31B120";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HIWOPID", "HIWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("HIMCU", "HIMCU", JdeDataType.String, 24, true, true),
        new JdeField("HIUKID", "HIUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("HIWOPN", "HIWOPN", JdeDataType.Numeric, null, true, true),
        new JdeField("HIWDSC1", "HIWDSC1", JdeDataType.String, 60),
        new JdeField("HIWCFGID", "HIWCFGID", JdeDataType.Numeric),
        new JdeField("HIWCOPCD", "HIWCOPCD", JdeDataType.String, 20),
        new JdeField("HIWCDL01", "HIWCDL01", JdeDataType.String, 60),
        new JdeField("HIWASDT", "HIWASDT", JdeDataType.Date),
        new JdeField("HIWAEDT", "HIWAEDT", JdeDataType.Date),
        new JdeField("HIWFVTY", "HIWFVTY", JdeDataType.String, 2, true, true),
        new JdeField("HIWFROMVID", "HIWFROMVID", JdeDataType.Numeric, null, true, true),
        new JdeField("HIWTVTY", "HIWTVTY", JdeDataType.String, 2, true, true),
        new JdeField("HIWTOVID", "HIWTOVID", JdeDataType.Numeric, null, true, true),
        new JdeField("HIFRVNUM", "HIFRVNUM", JdeDataType.String, 60),
        new JdeField("HITOVNUM", "HITOVNUM", JdeDataType.String, 60),
        new JdeField("HIWFB4LOTN", "HIWFB4LOTN", JdeDataType.String, 60),
        new JdeField("HIWFAFLOTN", "HIWFAFLOTN", JdeDataType.String, 60),
        new JdeField("HIWTB4LOTN", "HIWTB4LOTN", JdeDataType.String, 60),
        new JdeField("HIWTAFLOTN", "HIWTAFLOTN", JdeDataType.String, 60),
        new JdeField("HISB4BID", "HISB4BID", JdeDataType.String, 60),
        new JdeField("HIWFABID", "HIWFABID", JdeDataType.String, 60),
        new JdeField("HIWBID", "HIWBID", JdeDataType.String, 60),
        new JdeField("HIWTABID", "HIWTABID", JdeDataType.String, 60),
        new JdeField("HIWFAAQTY", "HIWFAAQTY", JdeDataType.Numeric),
        new JdeField("HIWFAAUOM", "HIWFAAUOM", JdeDataType.String, 6),
        new JdeField("HIWTAAQTY", "HIWTAAQTY", JdeDataType.Numeric),
        new JdeField("HIWTAAUOM", "HIWTAAUOM", JdeDataType.String, 6),
        new JdeField("HIWACTVLMV", "HIWACTVLMV", JdeDataType.Numeric),
        new JdeField("HIWACTUOM", "HIWACTUOM", JdeDataType.String, 6),
        new JdeField("HIWFRMAT", "HIWFRMAT", JdeDataType.String, 8),
        new JdeField("HIWTRMAT", "HIWTRMAT", JdeDataType.String, 8),
        new JdeField("HIWFAWS", "HIWFAWS", JdeDataType.String, 12),
        new JdeField("HIWTAWS", "HIWTAWS", JdeDataType.String, 12)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B120_0", "Primary Key on HIUKID, HIMCU, HIWOPN, HIWTOVID, HIWFROMVID, HIWOPID, HIWFVTY, HIWTVTY", new[] { "HIUKID", "HIMCU", "HIWOPN", "HIWTOVID", "HIWFROMVID", "HIWOPID", "HIWFVTY", "HIWTVTY" }, isUnique: true, isPrimaryKey: true)
    };
}
