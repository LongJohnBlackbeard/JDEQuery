using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B33DC - .
/// </summary>
public class F31B33DC : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTJOBS.
        /// </summary>
        public const string DTJOBS = "DTJOBS";

        /// <summary>
        /// DTCTID.
        /// </summary>
        public const string DTCTID = "DTCTID";

        /// <summary>
        /// DTUKID.
        /// </summary>
        public const string DTUKID = "DTUKID";

        /// <summary>
        /// DTWVID.
        /// </summary>
        public const string DTWVID = "DTWVID";

        /// <summary>
        /// DTWDOCO.
        /// </summary>
        public const string DTWDOCO = "DTWDOCO";

        /// <summary>
        /// DTWASDT.
        /// </summary>
        public const string DTWASDT = "DTWASDT";

        /// <summary>
        /// DTWCDT.
        /// </summary>
        public const string DTWCDT = "DTWCDT";

        /// <summary>
        /// DTWOPID.
        /// </summary>
        public const string DTWOPID = "DTWOPID";

        /// <summary>
        /// DTWOPST.
        /// </summary>
        public const string DTWOPST = "DTWOPST";

        /// <summary>
        /// DTWALOTN.
        /// </summary>
        public const string DTWALOTN = "DTWALOTN";

        /// <summary>
        /// DTWOSP.
        /// </summary>
        public const string DTWOSP = "DTWOSP";

        /// <summary>
        /// DTPROCFG.
        /// </summary>
        public const string DTPROCFG = "DTPROCFG";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";

        /// <summary>
        /// DTTDAY.
        /// </summary>
        public const string DTTDAY = "DTTDAY";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTJOBN.
        /// </summary>
        public const string DTJOBN = "DTJOBN";

        /// <summary>
        /// DTWRECFLG.
        /// </summary>
        public const string DTWRECFLG = "DTWRECFLG";

        /// <summary>
        /// DTWVRST.
        /// </summary>
        public const string DTWVRST = "DTWVRST";

        /// <summary>
        /// DTMCU.
        /// </summary>
        public const string DTMCU = "DTMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F31B33DC";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTJOBS", "DTJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("DTCTID", "DTCTID", JdeDataType.String, 30, true, true),
        new JdeField("DTUKID", "DTUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("DTWVID", "DTWVID", JdeDataType.Numeric, null, true, true),
        new JdeField("DTWDOCO", "DTWDOCO", JdeDataType.Numeric),
        new JdeField("DTWASDT", "DTWASDT", JdeDataType.Date),
        new JdeField("DTWCDT", "DTWCDT", JdeDataType.Date),
        new JdeField("DTWOPID", "DTWOPID", JdeDataType.Numeric, null, true, true),
        new JdeField("DTWOPST", "DTWOPST", JdeDataType.String, 20),
        new JdeField("DTWALOTN", "DTWALOTN", JdeDataType.String, 60),
        new JdeField("DTWOSP", "DTWOSP", JdeDataType.String, 2),
        new JdeField("DTPROCFG", "DTPROCFG", JdeDataType.String, 2),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric),
        new JdeField("DTTDAY", "DTTDAY", JdeDataType.Numeric),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTJOBN", "DTJOBN", JdeDataType.String, 20),
        new JdeField("DTWRECFLG", "DTWRECFLG", JdeDataType.String, 2),
        new JdeField("DTWVRST", "DTWVRST", JdeDataType.String, 2),
        new JdeField("DTMCU", "DTMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B33DC_0", "Primary Key on DTJOBS, DTCTID, DTUKID, DTWVID, DTWOPID", new[] { "DTJOBS", "DTCTID", "DTUKID", "DTWVID", "DTWOPID" }, isUnique: true, isPrimaryKey: true)
    };
}
