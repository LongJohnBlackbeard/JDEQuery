using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40039 - .
/// </summary>
public class F40039 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTDCT.
        /// </summary>
        public const string DTDCT = "DTDCT";

        /// <summary>
        /// DTTNTP.
        /// </summary>
        public const string DTTNTP = "DTTNTP";

        /// <summary>
        /// DTIRPT.
        /// </summary>
        public const string DTIRPT = "DTIRPT";

        /// <summary>
        /// DTLTTC.
        /// </summary>
        public const string DTLTTC = "DTLTTC";

        /// <summary>
        /// DTILTT.
        /// </summary>
        public const string DTILTT = "DTILTT";

        /// <summary>
        /// DTNATN.
        /// </summary>
        public const string DTNATN = "DTNATN";

        /// <summary>
        /// DTCTPA.
        /// </summary>
        public const string DTCTPA = "DTCTPA";

        /// <summary>
        /// DTOCAT.
        /// </summary>
        public const string DTOCAT = "DTOCAT";

        /// <summary>
        /// DTOTQY.
        /// </summary>
        public const string DTOTQY = "DTOTQY";

        /// <summary>
        /// DTRELV.
        /// </summary>
        public const string DTRELV = "DTRELV";

        /// <summary>
        /// DTIBOR.
        /// </summary>
        public const string DTIBOR = "DTIBOR";

        /// <summary>
        /// DTSY.
        /// </summary>
        public const string DTSY = "DTSY";

        /// <summary>
        /// DTORNN.
        /// </summary>
        public const string DTORNN = "DTORNN";

        /// <summary>
        /// DTCSCT.
        /// </summary>
        public const string DTCSCT = "DTCSCT";

        /// <summary>
        /// DTCSOT.
        /// </summary>
        public const string DTCSOT = "DTCSOT";

        /// <summary>
        /// DTCSKT.
        /// </summary>
        public const string DTCSKT = "DTCSKT";

        /// <summary>
        /// DTCRTK.
        /// </summary>
        public const string DTCRTK = "DTCRTK";

        /// <summary>
        /// DTA101.
        /// </summary>
        public const string DTA101 = "DTA101";

        /// <summary>
        /// DTA102.
        /// </summary>
        public const string DTA102 = "DTA102";

        /// <summary>
        /// DTA103.
        /// </summary>
        public const string DTA103 = "DTA103";

        /// <summary>
        /// DTA104.
        /// </summary>
        public const string DTA104 = "DTA104";

        /// <summary>
        /// DTA105.
        /// </summary>
        public const string DTA105 = "DTA105";

        /// <summary>
        /// DTA106.
        /// </summary>
        public const string DTA106 = "DTA106";

        /// <summary>
        /// DTA107.
        /// </summary>
        public const string DTA107 = "DTA107";

        /// <summary>
        /// DTA108.
        /// </summary>
        public const string DTA108 = "DTA108";

        /// <summary>
        /// DTA109.
        /// </summary>
        public const string DTA109 = "DTA109";

        /// <summary>
        /// DTA110.
        /// </summary>
        public const string DTA110 = "DTA110";

        /// <summary>
        /// DTA111.
        /// </summary>
        public const string DTA111 = "DTA111";

        /// <summary>
        /// DTA112.
        /// </summary>
        public const string DTA112 = "DTA112";

        /// <summary>
        /// DTA113.
        /// </summary>
        public const string DTA113 = "DTA113";

        /// <summary>
        /// DTA114.
        /// </summary>
        public const string DTA114 = "DTA114";

        /// <summary>
        /// DTA115.
        /// </summary>
        public const string DTA115 = "DTA115";

        /// <summary>
        /// DTA116.
        /// </summary>
        public const string DTA116 = "DTA116";

        /// <summary>
        /// DTA117.
        /// </summary>
        public const string DTA117 = "DTA117";

        /// <summary>
        /// DTA118.
        /// </summary>
        public const string DTA118 = "DTA118";

        /// <summary>
        /// DTA119.
        /// </summary>
        public const string DTA119 = "DTA119";

        /// <summary>
        /// DTA120.
        /// </summary>
        public const string DTA120 = "DTA120";

        /// <summary>
        /// DTA201.
        /// </summary>
        public const string DTA201 = "DTA201";

        /// <summary>
        /// DTA202.
        /// </summary>
        public const string DTA202 = "DTA202";

        /// <summary>
        /// DTA203.
        /// </summary>
        public const string DTA203 = "DTA203";

        /// <summary>
        /// DTA204.
        /// </summary>
        public const string DTA204 = "DTA204";

        /// <summary>
        /// DTA205.
        /// </summary>
        public const string DTA205 = "DTA205";

        /// <summary>
        /// DTA301.
        /// </summary>
        public const string DTA301 = "DTA301";

        /// <summary>
        /// DTA302.
        /// </summary>
        public const string DTA302 = "DTA302";

        /// <summary>
        /// DTA303.
        /// </summary>
        public const string DTA303 = "DTA303";

        /// <summary>
        /// DTA304.
        /// </summary>
        public const string DTA304 = "DTA304";

        /// <summary>
        /// DTA305.
        /// </summary>
        public const string DTA305 = "DTA305";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTJOBN.
        /// </summary>
        public const string DTJOBN = "DTJOBN";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";

        /// <summary>
        /// DTTDAY.
        /// </summary>
        public const string DTTDAY = "DTTDAY";

        /// <summary>
        /// DTDTSQ.
        /// </summary>
        public const string DTDTSQ = "DTDTSQ";

        /// <summary>
        /// DTCSNOT.
        /// </summary>
        public const string DTCSNOT = "DTCSNOT";
    }

    /// <inheritdoc />
    public override string TableName => "F40039";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTDCT", "DTDCT", JdeDataType.String, 4, true, true),
        new JdeField("DTTNTP", "DTTNTP", JdeDataType.String, 2),
        new JdeField("DTIRPT", "DTIRPT", JdeDataType.String, 2),
        new JdeField("DTLTTC", "DTLTTC", JdeDataType.String, 2),
        new JdeField("DTILTT", "DTILTT", JdeDataType.String, 2),
        new JdeField("DTNATN", "DTNATN", JdeDataType.String, 2),
        new JdeField("DTCTPA", "DTCTPA", JdeDataType.String, 2),
        new JdeField("DTOCAT", "DTOCAT", JdeDataType.String, 4),
        new JdeField("DTOTQY", "DTOTQY", JdeDataType.String, 2),
        new JdeField("DTRELV", "DTRELV", JdeDataType.String, 2),
        new JdeField("DTIBOR", "DTIBOR", JdeDataType.String, 4),
        new JdeField("DTSY", "DTSY", JdeDataType.String, 8),
        new JdeField("DTORNN", "DTORNN", JdeDataType.Numeric),
        new JdeField("DTCSCT", "DTCSCT", JdeDataType.String, 2),
        new JdeField("DTCSOT", "DTCSOT", JdeDataType.String, 2),
        new JdeField("DTCSKT", "DTCSKT", JdeDataType.String, 2),
        new JdeField("DTCRTK", "DTCRTK", JdeDataType.String, 2),
        new JdeField("DTA101", "DTA101", JdeDataType.String, 2),
        new JdeField("DTA102", "DTA102", JdeDataType.String, 2),
        new JdeField("DTA103", "DTA103", JdeDataType.String, 2),
        new JdeField("DTA104", "DTA104", JdeDataType.String, 2),
        new JdeField("DTA105", "DTA105", JdeDataType.String, 2),
        new JdeField("DTA106", "DTA106", JdeDataType.String, 2),
        new JdeField("DTA107", "DTA107", JdeDataType.String, 2),
        new JdeField("DTA108", "DTA108", JdeDataType.String, 2),
        new JdeField("DTA109", "DTA109", JdeDataType.String, 2),
        new JdeField("DTA110", "DTA110", JdeDataType.String, 2),
        new JdeField("DTA111", "DTA111", JdeDataType.String, 2),
        new JdeField("DTA112", "DTA112", JdeDataType.String, 2),
        new JdeField("DTA113", "DTA113", JdeDataType.String, 2),
        new JdeField("DTA114", "DTA114", JdeDataType.String, 2),
        new JdeField("DTA115", "DTA115", JdeDataType.String, 2),
        new JdeField("DTA116", "DTA116", JdeDataType.String, 2),
        new JdeField("DTA117", "DTA117", JdeDataType.String, 2),
        new JdeField("DTA118", "DTA118", JdeDataType.String, 2),
        new JdeField("DTA119", "DTA119", JdeDataType.String, 2),
        new JdeField("DTA120", "DTA120", JdeDataType.String, 2),
        new JdeField("DTA201", "DTA201", JdeDataType.String, 4),
        new JdeField("DTA202", "DTA202", JdeDataType.String, 4),
        new JdeField("DTA203", "DTA203", JdeDataType.String, 4),
        new JdeField("DTA204", "DTA204", JdeDataType.String, 4),
        new JdeField("DTA205", "DTA205", JdeDataType.String, 4),
        new JdeField("DTA301", "DTA301", JdeDataType.String, 6),
        new JdeField("DTA302", "DTA302", JdeDataType.String, 6),
        new JdeField("DTA303", "DTA303", JdeDataType.String, 6),
        new JdeField("DTA304", "DTA304", JdeDataType.String, 6),
        new JdeField("DTA305", "DTA305", JdeDataType.String, 6),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTJOBN", "DTJOBN", JdeDataType.String, 20),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric),
        new JdeField("DTTDAY", "DTTDAY", JdeDataType.Numeric),
        new JdeField("DTDTSQ", "DTDTSQ", JdeDataType.String, 2),
        new JdeField("DTCSNOT", "DTCSNOT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40039_0", "Primary Key on DTDCT", new[] { "DTDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
