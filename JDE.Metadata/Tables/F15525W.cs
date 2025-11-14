using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15525W - .
/// </summary>
public class F15525W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTAN8.
        /// </summary>
        public const string RTAN8 = "RTAN8";

        /// <summary>
        /// RTCMGR.
        /// </summary>
        public const string RTCMGR = "RTCMGR";

        /// <summary>
        /// RTCLMG.
        /// </summary>
        public const string RTCLMG = "RTCLMG";

        /// <summary>
        /// RTCO.
        /// </summary>
        public const string RTCO = "RTCO";

        /// <summary>
        /// RTPA8.
        /// </summary>
        public const string RTPA8 = "RTPA8";

        /// <summary>
        /// RTAAP.
        /// </summary>
        public const string RTAAP = "RTAAP";

        /// <summary>
        /// RTAD.
        /// </summary>
        public const string RTAD = "RTAD";

        /// <summary>
        /// RTFTR.
        /// </summary>
        public const string RTFTR = "RTFTR";

        /// <summary>
        /// RTCURR.
        /// </summary>
        public const string RTCURR = "RTCURR";

        /// <summary>
        /// RTAG1.
        /// </summary>
        public const string RTAG1 = "RTAG1";

        /// <summary>
        /// RTAG2.
        /// </summary>
        public const string RTAG2 = "RTAG2";

        /// <summary>
        /// RTAG3.
        /// </summary>
        public const string RTAG3 = "RTAG3";

        /// <summary>
        /// RTAG4.
        /// </summary>
        public const string RTAG4 = "RTAG4";

        /// <summary>
        /// RTAG5.
        /// </summary>
        public const string RTAG5 = "RTAG5";

        /// <summary>
        /// RTAG6.
        /// </summary>
        public const string RTAG6 = "RTAG6";

        /// <summary>
        /// RTAG7.
        /// </summary>
        public const string RTAG7 = "RTAG7";

        /// <summary>
        /// RTEV01.
        /// </summary>
        public const string RTEV01 = "RTEV01";

        /// <summary>
        /// RTMSGC.
        /// </summary>
        public const string RTMSGC = "RTMSGC";

        /// <summary>
        /// RTMSGA.
        /// </summary>
        public const string RTMSGA = "RTMSGA";

        /// <summary>
        /// RTPART.
        /// </summary>
        public const string RTPART = "RTPART";

        /// <summary>
        /// RTAOCL.
        /// </summary>
        public const string RTAOCL = "RTAOCL";

        /// <summary>
        /// RTTSTA.
        /// </summary>
        public const string RTTSTA = "RTTSTA";

        /// <summary>
        /// RTAC01.
        /// </summary>
        public const string RTAC01 = "RTAC01";

        /// <summary>
        /// RTAC02.
        /// </summary>
        public const string RTAC02 = "RTAC02";

        /// <summary>
        /// RTAC03.
        /// </summary>
        public const string RTAC03 = "RTAC03";

        /// <summary>
        /// RTAC04.
        /// </summary>
        public const string RTAC04 = "RTAC04";

        /// <summary>
        /// RTAC05.
        /// </summary>
        public const string RTAC05 = "RTAC05";

        /// <summary>
        /// RTAC06.
        /// </summary>
        public const string RTAC06 = "RTAC06";

        /// <summary>
        /// RTAC07.
        /// </summary>
        public const string RTAC07 = "RTAC07";

        /// <summary>
        /// RTAC08.
        /// </summary>
        public const string RTAC08 = "RTAC08";

        /// <summary>
        /// RTAC09.
        /// </summary>
        public const string RTAC09 = "RTAC09";

        /// <summary>
        /// RTAC10.
        /// </summary>
        public const string RTAC10 = "RTAC10";

        /// <summary>
        /// RTAC11.
        /// </summary>
        public const string RTAC11 = "RTAC11";

        /// <summary>
        /// RTAC12.
        /// </summary>
        public const string RTAC12 = "RTAC12";

        /// <summary>
        /// RTAC13.
        /// </summary>
        public const string RTAC13 = "RTAC13";

        /// <summary>
        /// RTAC14.
        /// </summary>
        public const string RTAC14 = "RTAC14";

        /// <summary>
        /// RTAC15.
        /// </summary>
        public const string RTAC15 = "RTAC15";

        /// <summary>
        /// RTAC16.
        /// </summary>
        public const string RTAC16 = "RTAC16";

        /// <summary>
        /// RTAC17.
        /// </summary>
        public const string RTAC17 = "RTAC17";

        /// <summary>
        /// RTAC18.
        /// </summary>
        public const string RTAC18 = "RTAC18";

        /// <summary>
        /// RTAC19.
        /// </summary>
        public const string RTAC19 = "RTAC19";

        /// <summary>
        /// RTAC20.
        /// </summary>
        public const string RTAC20 = "RTAC20";

        /// <summary>
        /// RTSTMA.
        /// </summary>
        public const string RTSTMA = "RTSTMA";

        /// <summary>
        /// RTCRCD.
        /// </summary>
        public const string RTCRCD = "RTCRCD";

        /// <summary>
        /// RTODAM.
        /// </summary>
        public const string RTODAM = "RTODAM";

        /// <summary>
        /// RTPO.
        /// </summary>
        public const string RTPO = "RTPO";

        /// <summary>
        /// RTMCU.
        /// </summary>
        public const string RTMCU = "RTMCU";

        /// <summary>
        /// RTUNIT.
        /// </summary>
        public const string RTUNIT = "RTUNIT";

        /// <summary>
        /// RTURCD.
        /// </summary>
        public const string RTURCD = "RTURCD";

        /// <summary>
        /// RTURDT.
        /// </summary>
        public const string RTURDT = "RTURDT";

        /// <summary>
        /// RTURAT.
        /// </summary>
        public const string RTURAT = "RTURAT";

        /// <summary>
        /// RTURAB.
        /// </summary>
        public const string RTURAB = "RTURAB";

        /// <summary>
        /// RTURRF.
        /// </summary>
        public const string RTURRF = "RTURRF";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTCRRM.
        /// </summary>
        public const string RTCRRM = "RTCRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F15525W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTAN8", "RTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RTCMGR", "RTCMGR", JdeDataType.String, 20),
        new JdeField("RTCLMG", "RTCLMG", JdeDataType.String, 20),
        new JdeField("RTCO", "RTCO", JdeDataType.String, 10, true, true),
        new JdeField("RTPA8", "RTPA8", JdeDataType.Numeric),
        new JdeField("RTAAP", "RTAAP", JdeDataType.Numeric),
        new JdeField("RTAD", "RTAD", JdeDataType.Numeric),
        new JdeField("RTFTR", "RTFTR", JdeDataType.Numeric),
        new JdeField("RTCURR", "RTCURR", JdeDataType.Numeric),
        new JdeField("RTAG1", "RTAG1", JdeDataType.Numeric),
        new JdeField("RTAG2", "RTAG2", JdeDataType.Numeric),
        new JdeField("RTAG3", "RTAG3", JdeDataType.Numeric),
        new JdeField("RTAG4", "RTAG4", JdeDataType.Numeric),
        new JdeField("RTAG5", "RTAG5", JdeDataType.Numeric),
        new JdeField("RTAG6", "RTAG6", JdeDataType.Numeric),
        new JdeField("RTAG7", "RTAG7", JdeDataType.Numeric),
        new JdeField("RTEV01", "RTEV01", JdeDataType.String, 2, true, true),
        new JdeField("RTMSGC", "RTMSGC", JdeDataType.String, 2),
        new JdeField("RTMSGA", "RTMSGA", JdeDataType.String, 2),
        new JdeField("RTPART", "RTPART", JdeDataType.String, 2),
        new JdeField("RTAOCL", "RTAOCL", JdeDataType.Numeric),
        new JdeField("RTTSTA", "RTTSTA", JdeDataType.String, 4),
        new JdeField("RTAC01", "RTAC01", JdeDataType.String, 6),
        new JdeField("RTAC02", "RTAC02", JdeDataType.String, 6),
        new JdeField("RTAC03", "RTAC03", JdeDataType.String, 6),
        new JdeField("RTAC04", "RTAC04", JdeDataType.String, 6),
        new JdeField("RTAC05", "RTAC05", JdeDataType.String, 6),
        new JdeField("RTAC06", "RTAC06", JdeDataType.String, 6),
        new JdeField("RTAC07", "RTAC07", JdeDataType.String, 6),
        new JdeField("RTAC08", "RTAC08", JdeDataType.String, 6),
        new JdeField("RTAC09", "RTAC09", JdeDataType.String, 6),
        new JdeField("RTAC10", "RTAC10", JdeDataType.String, 6),
        new JdeField("RTAC11", "RTAC11", JdeDataType.String, 6),
        new JdeField("RTAC12", "RTAC12", JdeDataType.String, 6),
        new JdeField("RTAC13", "RTAC13", JdeDataType.String, 6),
        new JdeField("RTAC14", "RTAC14", JdeDataType.String, 6),
        new JdeField("RTAC15", "RTAC15", JdeDataType.String, 6),
        new JdeField("RTAC16", "RTAC16", JdeDataType.String, 6),
        new JdeField("RTAC17", "RTAC17", JdeDataType.String, 6),
        new JdeField("RTAC18", "RTAC18", JdeDataType.String, 6),
        new JdeField("RTAC19", "RTAC19", JdeDataType.String, 6),
        new JdeField("RTAC20", "RTAC20", JdeDataType.String, 6),
        new JdeField("RTSTMA", "RTSTMA", JdeDataType.Numeric, null, true, true),
        new JdeField("RTCRCD", "RTCRCD", JdeDataType.String, 6),
        new JdeField("RTODAM", "RTODAM", JdeDataType.Numeric),
        new JdeField("RTPO", "RTPO", JdeDataType.String, 16),
        new JdeField("RTMCU", "RTMCU", JdeDataType.String, 24),
        new JdeField("RTUNIT", "RTUNIT", JdeDataType.String, 16),
        new JdeField("RTURCD", "RTURCD", JdeDataType.String, 4),
        new JdeField("RTURDT", "RTURDT", JdeDataType.Numeric),
        new JdeField("RTURAT", "RTURAT", JdeDataType.Numeric),
        new JdeField("RTURAB", "RTURAB", JdeDataType.Numeric),
        new JdeField("RTURRF", "RTURRF", JdeDataType.String, 30),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20, true, true),
        new JdeField("RTCRRM", "RTCRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15525W_0", "Primary Key on RTCO, RTSTMA, RTAN8, RTEV01, RTJOBN", new[] { "RTCO", "RTSTMA", "RTAN8", "RTEV01", "RTJOBN" }, isUnique: true, isPrimaryKey: true)
    };
}
