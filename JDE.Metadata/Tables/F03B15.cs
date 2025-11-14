using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B15 - .
/// </summary>
public class F03B15 : JdeTable
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
        /// RTPART.
        /// </summary>
        public const string RTPART = "RTPART";

        /// <summary>
        /// RTCO.
        /// </summary>
        public const string RTCO = "RTCO";

        /// <summary>
        /// RTDAG.
        /// </summary>
        public const string RTDAG = "RTDAG";

        /// <summary>
        /// RTPA8.
        /// </summary>
        public const string RTPA8 = "RTPA8";

        /// <summary>
        /// RTCMGR.
        /// </summary>
        public const string RTCMGR = "RTCMGR";

        /// <summary>
        /// RTCLMG.
        /// </summary>
        public const string RTCLMG = "RTCLMG";

        /// <summary>
        /// RTAAP.
        /// </summary>
        public const string RTAAP = "RTAAP";

        /// <summary>
        /// RTOINV.
        /// </summary>
        public const string RTOINV = "RTOINV";

        /// <summary>
        /// RTOCB.
        /// </summary>
        public const string RTOCB = "RTOCB";

        /// <summary>
        /// RTNOCB.
        /// </summary>
        public const string RTNOCB = "RTNOCB";

        /// <summary>
        /// RTADSC.
        /// </summary>
        public const string RTADSC = "RTADSC";

        /// <summary>
        /// RTEDSC.
        /// </summary>
        public const string RTEDSC = "RTEDSC";

        /// <summary>
        /// RTPDA.
        /// </summary>
        public const string RTPDA = "RTPDA";

        /// <summary>
        /// RTPDIN.
        /// </summary>
        public const string RTPDIN = "RTPDIN";

        /// <summary>
        /// RTOCBP.
        /// </summary>
        public const string RTOCBP = "RTOCBP";

        /// <summary>
        /// RTDSCP.
        /// </summary>
        public const string RTDSCP = "RTDSCP";

        /// <summary>
        /// RTFTR.
        /// </summary>
        public const string RTFTR = "RTFTR";

        /// <summary>
        /// RTCURR.
        /// </summary>
        public const string RTCURR = "RTCURR";

        /// <summary>
        /// RTCUIN.
        /// </summary>
        public const string RTCUIN = "RTCUIN";

        /// <summary>
        /// RTOCBC.
        /// </summary>
        public const string RTOCBC = "RTOCBC";

        /// <summary>
        /// RTCUDS.
        /// </summary>
        public const string RTCUDS = "RTCUDS";

        /// <summary>
        /// RTCUED.
        /// </summary>
        public const string RTCUED = "RTCUED";

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
        /// RTAOCL.
        /// </summary>
        public const string RTAOCL = "RTAOCL";

        /// <summary>
        /// RTUAA.
        /// </summary>
        public const string RTUAA = "RTUAA";

        /// <summary>
        /// RTNUR.
        /// </summary>
        public const string RTNUR = "RTNUR";

        /// <summary>
        /// RTCREE.
        /// </summary>
        public const string RTCREE = "RTCREE";

        /// <summary>
        /// RTCREN.
        /// </summary>
        public const string RTCREN = "RTCREN";

        /// <summary>
        /// RTCRCD.
        /// </summary>
        public const string RTCRCD = "RTCRCD";

        /// <summary>
        /// RTODAM.
        /// </summary>
        public const string RTODAM = "RTODAM";

        /// <summary>
        /// RTNOD.
        /// </summary>
        public const string RTNOD = "RTNOD";

        /// <summary>
        /// RTAGEM.
        /// </summary>
        public const string RTAGEM = "RTAGEM";

        /// <summary>
        /// RTCRDY.
        /// </summary>
        public const string RTCRDY = "RTCRDY";

        /// <summary>
        /// RTAGR1.
        /// </summary>
        public const string RTAGR1 = "RTAGR1";

        /// <summary>
        /// RTAGR2.
        /// </summary>
        public const string RTAGR2 = "RTAGR2";

        /// <summary>
        /// RTAGR3.
        /// </summary>
        public const string RTAGR3 = "RTAGR3";

        /// <summary>
        /// RTAGR4.
        /// </summary>
        public const string RTAGR4 = "RTAGR4";

        /// <summary>
        /// RTAGR5.
        /// </summary>
        public const string RTAGR5 = "RTAGR5";

        /// <summary>
        /// RTAGR6.
        /// </summary>
        public const string RTAGR6 = "RTAGR6";

        /// <summary>
        /// RTAGR7.
        /// </summary>
        public const string RTAGR7 = "RTAGR7";

        /// <summary>
        /// RTAGE.
        /// </summary>
        public const string RTAGE = "RTAGE";

        /// <summary>
        /// RTDDOA.
        /// </summary>
        public const string RTDDOA = "RTDDOA";

        /// <summary>
        /// RTDDNB.
        /// </summary>
        public const string RTDDNB = "RTDDNB";

        /// <summary>
        /// RTWKFL.
        /// </summary>
        public const string RTWKFL = "RTWKFL";

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
    }

    /// <inheritdoc />
    public override string TableName => "F03B15";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTAN8", "RTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RTPART", "RTPART", JdeDataType.String, 2, true, true),
        new JdeField("RTCO", "RTCO", JdeDataType.String, 10, true, true),
        new JdeField("RTDAG", "RTDAG", JdeDataType.Numeric),
        new JdeField("RTPA8", "RTPA8", JdeDataType.Numeric),
        new JdeField("RTCMGR", "RTCMGR", JdeDataType.String, 20),
        new JdeField("RTCLMG", "RTCLMG", JdeDataType.String, 20),
        new JdeField("RTAAP", "RTAAP", JdeDataType.Numeric),
        new JdeField("RTOINV", "RTOINV", JdeDataType.Numeric),
        new JdeField("RTOCB", "RTOCB", JdeDataType.Numeric),
        new JdeField("RTNOCB", "RTNOCB", JdeDataType.Numeric),
        new JdeField("RTADSC", "RTADSC", JdeDataType.Numeric),
        new JdeField("RTEDSC", "RTEDSC", JdeDataType.Numeric),
        new JdeField("RTPDA", "RTPDA", JdeDataType.Numeric),
        new JdeField("RTPDIN", "RTPDIN", JdeDataType.Numeric),
        new JdeField("RTOCBP", "RTOCBP", JdeDataType.Numeric),
        new JdeField("RTDSCP", "RTDSCP", JdeDataType.Numeric),
        new JdeField("RTFTR", "RTFTR", JdeDataType.Numeric),
        new JdeField("RTCURR", "RTCURR", JdeDataType.Numeric),
        new JdeField("RTCUIN", "RTCUIN", JdeDataType.Numeric),
        new JdeField("RTOCBC", "RTOCBC", JdeDataType.Numeric),
        new JdeField("RTCUDS", "RTCUDS", JdeDataType.Numeric),
        new JdeField("RTCUED", "RTCUED", JdeDataType.Numeric),
        new JdeField("RTAG1", "RTAG1", JdeDataType.Numeric),
        new JdeField("RTAG2", "RTAG2", JdeDataType.Numeric),
        new JdeField("RTAG3", "RTAG3", JdeDataType.Numeric),
        new JdeField("RTAG4", "RTAG4", JdeDataType.Numeric),
        new JdeField("RTAG5", "RTAG5", JdeDataType.Numeric),
        new JdeField("RTAG6", "RTAG6", JdeDataType.Numeric),
        new JdeField("RTAG7", "RTAG7", JdeDataType.Numeric),
        new JdeField("RTAOCL", "RTAOCL", JdeDataType.Numeric),
        new JdeField("RTUAA", "RTUAA", JdeDataType.Numeric),
        new JdeField("RTNUR", "RTNUR", JdeDataType.Numeric),
        new JdeField("RTCREE", "RTCREE", JdeDataType.Numeric),
        new JdeField("RTCREN", "RTCREN", JdeDataType.Numeric),
        new JdeField("RTCRCD", "RTCRCD", JdeDataType.String, 6),
        new JdeField("RTODAM", "RTODAM", JdeDataType.Numeric),
        new JdeField("RTNOD", "RTNOD", JdeDataType.Numeric),
        new JdeField("RTAGEM", "RTAGEM", JdeDataType.String, 2),
        new JdeField("RTCRDY", "RTCRDY", JdeDataType.Numeric),
        new JdeField("RTAGR1", "RTAGR1", JdeDataType.Numeric),
        new JdeField("RTAGR2", "RTAGR2", JdeDataType.Numeric),
        new JdeField("RTAGR3", "RTAGR3", JdeDataType.Numeric),
        new JdeField("RTAGR4", "RTAGR4", JdeDataType.Numeric),
        new JdeField("RTAGR5", "RTAGR5", JdeDataType.Numeric),
        new JdeField("RTAGR6", "RTAGR6", JdeDataType.Numeric),
        new JdeField("RTAGR7", "RTAGR7", JdeDataType.Numeric),
        new JdeField("RTAGE", "RTAGE", JdeDataType.String, 2),
        new JdeField("RTDDOA", "RTDDOA", JdeDataType.Numeric),
        new JdeField("RTDDNB", "RTDDNB", JdeDataType.Numeric),
        new JdeField("RTWKFL", "RTWKFL", JdeDataType.String, 2),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B15_0", "Primary Key on RTAN8, RTPART, RTCO", new[] { "RTAN8", "RTPART", "RTCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F03B15_2", "Index on RTCO, SYS_NC00057$", new[] { "RTCO", "SYS_NC00057$" })
    };
}
