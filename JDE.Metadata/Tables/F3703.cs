using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3703 - .
/// </summary>
public class F3703 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QEDFCT.
        /// </summary>
        public const string QEDFCT = "QEDFCT";

        /// <summary>
        /// QEMCU.
        /// </summary>
        public const string QEMCU = "QEMCU";

        /// <summary>
        /// QEITM.
        /// </summary>
        public const string QEITM = "QEITM";

        /// <summary>
        /// QELOTN.
        /// </summary>
        public const string QELOTN = "QELOTN";

        /// <summary>
        /// QELOCN.
        /// </summary>
        public const string QELOCN = "QELOCN";

        /// <summary>
        /// QELITM.
        /// </summary>
        public const string QELITM = "QELITM";

        /// <summary>
        /// QEAITM.
        /// </summary>
        public const string QEAITM = "QEAITM";

        /// <summary>
        /// QEQTST.
        /// </summary>
        public const string QEQTST = "QEQTST";

        /// <summary>
        /// QEMCU2.
        /// </summary>
        public const string QEMCU2 = "QEMCU2";

        /// <summary>
        /// QEQVAL.
        /// </summary>
        public const string QEQVAL = "QEQVAL";

        /// <summary>
        /// QEDOCO.
        /// </summary>
        public const string QEDOCO = "QEDOCO";

        /// <summary>
        /// QEDCTO.
        /// </summary>
        public const string QEDCTO = "QEDCTO";

        /// <summary>
        /// QEMCUZ.
        /// </summary>
        public const string QEMCUZ = "QEMCUZ";

        /// <summary>
        /// QEDOC1.
        /// </summary>
        public const string QEDOC1 = "QEDOC1";

        /// <summary>
        /// QEDCT.
        /// </summary>
        public const string QEDCT = "QEDCT";

        /// <summary>
        /// QEKCOO.
        /// </summary>
        public const string QEKCOO = "QEKCOO";

        /// <summary>
        /// QELNID.
        /// </summary>
        public const string QELNID = "QELNID";

        /// <summary>
        /// QETSRT.
        /// </summary>
        public const string QETSRT = "QETSRT";

        /// <summary>
        /// QETRP.
        /// </summary>
        public const string QETRP = "QETRP";

        /// <summary>
        /// QETRPL.
        /// </summary>
        public const string QETRPL = "QETRPL";

        /// <summary>
        /// QELCMP.
        /// </summary>
        public const string QELCMP = "QELCMP";

        /// <summary>
        /// QEQRCD.
        /// </summary>
        public const string QEQRCD = "QEQRCD";

        /// <summary>
        /// QEQDFC.
        /// </summary>
        public const string QEQDFC = "QEQDFC";

        /// <summary>
        /// QEQRTC.
        /// </summary>
        public const string QEQRTC = "QEQRTC";

        /// <summary>
        /// QEMMCU.
        /// </summary>
        public const string QEMMCU = "QEMMCU";

        /// <summary>
        /// QEUSER.
        /// </summary>
        public const string QEUSER = "QEUSER";

        /// <summary>
        /// QEPID.
        /// </summary>
        public const string QEPID = "QEPID";

        /// <summary>
        /// QEUPMJ.
        /// </summary>
        public const string QEUPMJ = "QEUPMJ";

        /// <summary>
        /// QETDAY.
        /// </summary>
        public const string QETDAY = "QETDAY";

        /// <summary>
        /// QEJOBN.
        /// </summary>
        public const string QEJOBN = "QEJOBN";

        /// <summary>
        /// QEWOPID.
        /// </summary>
        public const string QEWOPID = "QEWOPID";

        /// <summary>
        /// QEWLOTN.
        /// </summary>
        public const string QEWLOTN = "QEWLOTN";

        /// <summary>
        /// QEWVID.
        /// </summary>
        public const string QEWVID = "QEWVID";

        /// <summary>
        /// QEWVTY.
        /// </summary>
        public const string QEWVTY = "QEWVTY";

        /// <summary>
        /// QEQMRF4.
        /// </summary>
        public const string QEQMRF4 = "QEQMRF4";

        /// <summary>
        /// QEQMCD4.
        /// </summary>
        public const string QEQMCD4 = "QEQMCD4";

        /// <summary>
        /// QEQMAB4.
        /// </summary>
        public const string QEQMAB4 = "QEQMAB4";

        /// <summary>
        /// QEQMNUM4.
        /// </summary>
        public const string QEQMNUM4 = "QEQMNUM4";

        /// <summary>
        /// QEQMDT4.
        /// </summary>
        public const string QEQMDT4 = "QEQMDT4";
    }

    /// <inheritdoc />
    public override string TableName => "F3703";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QEDFCT", "QEDFCT", JdeDataType.Numeric, null, true, true),
        new JdeField("QEMCU", "QEMCU", JdeDataType.String, 24, true, true),
        new JdeField("QEITM", "QEITM", JdeDataType.Numeric, null, true, true),
        new JdeField("QELOTN", "QELOTN", JdeDataType.String, 60, true, true),
        new JdeField("QELOCN", "QELOCN", JdeDataType.String, 40, true, true),
        new JdeField("QELITM", "QELITM", JdeDataType.String, 50),
        new JdeField("QEAITM", "QEAITM", JdeDataType.String, 50),
        new JdeField("QEQTST", "QEQTST", JdeDataType.String, 50),
        new JdeField("QEMCU2", "QEMCU2", JdeDataType.String, 24),
        new JdeField("QEQVAL", "QEQVAL", JdeDataType.String, 30),
        new JdeField("QEDOCO", "QEDOCO", JdeDataType.Numeric),
        new JdeField("QEDCTO", "QEDCTO", JdeDataType.String, 4),
        new JdeField("QEMCUZ", "QEMCUZ", JdeDataType.String, 24),
        new JdeField("QEDOC1", "QEDOC1", JdeDataType.Numeric),
        new JdeField("QEDCT", "QEDCT", JdeDataType.String, 4),
        new JdeField("QEKCOO", "QEKCOO", JdeDataType.String, 10),
        new JdeField("QELNID", "QELNID", JdeDataType.Numeric),
        new JdeField("QETSRT", "QETSRT", JdeDataType.Numeric),
        new JdeField("QETRP", "QETRP", JdeDataType.Numeric),
        new JdeField("QETRPL", "QETRPL", JdeDataType.Numeric),
        new JdeField("QELCMP", "QELCMP", JdeDataType.Numeric),
        new JdeField("QEQRCD", "QEQRCD", JdeDataType.String, 6),
        new JdeField("QEQDFC", "QEQDFC", JdeDataType.String, 6),
        new JdeField("QEQRTC", "QEQRTC", JdeDataType.String, 6),
        new JdeField("QEMMCU", "QEMMCU", JdeDataType.String, 24),
        new JdeField("QEUSER", "QEUSER", JdeDataType.String, 20),
        new JdeField("QEPID", "QEPID", JdeDataType.String, 20),
        new JdeField("QEUPMJ", "QEUPMJ", JdeDataType.Numeric),
        new JdeField("QETDAY", "QETDAY", JdeDataType.Numeric),
        new JdeField("QEJOBN", "QEJOBN", JdeDataType.String, 20),
        new JdeField("QEWOPID", "QEWOPID", JdeDataType.Numeric),
        new JdeField("QEWLOTN", "QEWLOTN", JdeDataType.String, 60),
        new JdeField("QEWVID", "QEWVID", JdeDataType.Numeric),
        new JdeField("QEWVTY", "QEWVTY", JdeDataType.String, 2),
        new JdeField("QEQMRF4", "QEQMRF4", JdeDataType.String, 60),
        new JdeField("QEQMCD4", "QEQMCD4", JdeDataType.String, 6),
        new JdeField("QEQMAB4", "QEQMAB4", JdeDataType.Numeric),
        new JdeField("QEQMNUM4", "QEQMNUM4", JdeDataType.Numeric),
        new JdeField("QEQMDT4", "QEQMDT4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3703_0", "Primary Key on QEITM, QEMCU, QELOTN, QELOCN, QEDFCT", new[] { "QEITM", "QEMCU", "QELOTN", "QELOCN", "QEDFCT" }, isUnique: true, isPrimaryKey: true)
    };
}
