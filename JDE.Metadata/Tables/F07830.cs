using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07830 - .
/// </summary>
public class F07830 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y0IDYE.
        /// </summary>
        public const string Y0IDYE = "Y0IDYE";

        /// <summary>
        /// Y0DTEY.
        /// </summary>
        public const string Y0DTEY = "Y0DTEY";

        /// <summary>
        /// Y0TAXX.
        /// </summary>
        public const string Y0TAXX = "Y0TAXX";

        /// <summary>
        /// Y0CO.
        /// </summary>
        public const string Y0CO = "Y0CO";

        /// <summary>
        /// Y0AN8.
        /// </summary>
        public const string Y0AN8 = "Y0AN8";

        /// <summary>
        /// Y0TFYE.
        /// </summary>
        public const string Y0TFYE = "Y0TFYE";

        /// <summary>
        /// Y0TWYE.
        /// </summary>
        public const string Y0TWYE = "Y0TWYE";

        /// <summary>
        /// Y0CORF.
        /// </summary>
        public const string Y0CORF = "Y0CORF";

        /// <summary>
        /// Y0DTCF.
        /// </summary>
        public const string Y0DTCF = "Y0DTCF";

        /// <summary>
        /// Y0W2RT.
        /// </summary>
        public const string Y0W2RT = "Y0W2RT";

        /// <summary>
        /// Y0WCN.
        /// </summary>
        public const string Y0WCN = "Y0WCN";

        /// <summary>
        /// Y0WSCN.
        /// </summary>
        public const string Y0WSCN = "Y0WSCN";

        /// <summary>
        /// Y0TIS.
        /// </summary>
        public const string Y0TIS = "Y0TIS";

        /// <summary>
        /// Y0SSN.
        /// </summary>
        public const string Y0SSN = "Y0SSN";

        /// <summary>
        /// Y0FDWG.
        /// </summary>
        public const string Y0FDWG = "Y0FDWG";

        /// <summary>
        /// Y0FDAJ.
        /// </summary>
        public const string Y0FDAJ = "Y0FDAJ";

        /// <summary>
        /// Y0FDTX.
        /// </summary>
        public const string Y0FDTX = "Y0FDTX";

        /// <summary>
        /// Y0OAWG.
        /// </summary>
        public const string Y0OAWG = "Y0OAWG";

        /// <summary>
        /// Y0OAAJ.
        /// </summary>
        public const string Y0OAAJ = "Y0OAAJ";

        /// <summary>
        /// Y0OATX.
        /// </summary>
        public const string Y0OATX = "Y0OATX";

        /// <summary>
        /// Y0MCWG.
        /// </summary>
        public const string Y0MCWG = "Y0MCWG";

        /// <summary>
        /// Y0MCAJ.
        /// </summary>
        public const string Y0MCAJ = "Y0MCAJ";

        /// <summary>
        /// Y0MCT.
        /// </summary>
        public const string Y0MCT = "Y0MCT";

        /// <summary>
        /// Y0FDTP.
        /// </summary>
        public const string Y0FDTP = "Y0FDTP";

        /// <summary>
        /// Y0OATP.
        /// </summary>
        public const string Y0OATP = "Y0OATP";

        /// <summary>
        /// Y0MCTP.
        /// </summary>
        public const string Y0MCTP = "Y0MCTP";

        /// <summary>
        /// Y0ALTP.
        /// </summary>
        public const string Y0ALTP = "Y0ALTP";

        /// <summary>
        /// Y0T1WG.
        /// </summary>
        public const string Y0T1WG = "Y0T1WG";

        /// <summary>
        /// Y0T1AJ.
        /// </summary>
        public const string Y0T1AJ = "Y0T1AJ";

        /// <summary>
        /// Y0RRT1.
        /// </summary>
        public const string Y0RRT1 = "Y0RRT1";

        /// <summary>
        /// Y0T2WG.
        /// </summary>
        public const string Y0T2WG = "Y0T2WG";

        /// <summary>
        /// Y0T2AJ.
        /// </summary>
        public const string Y0T2AJ = "Y0T2AJ";

        /// <summary>
        /// Y0RRT2.
        /// </summary>
        public const string Y0RRT2 = "Y0RRT2";

        /// <summary>
        /// Y0AROA.
        /// </summary>
        public const string Y0AROA = "Y0AROA";

        /// <summary>
        /// Y0ARMC.
        /// </summary>
        public const string Y0ARMC = "Y0ARMC";

        /// <summary>
        /// Y0ART1.
        /// </summary>
        public const string Y0ART1 = "Y0ART1";

        /// <summary>
        /// Y0ART2.
        /// </summary>
        public const string Y0ART2 = "Y0ART2";

        /// <summary>
        /// Y0EARN.
        /// </summary>
        public const string Y0EARN = "Y0EARN";

        /// <summary>
        /// Y0PNSA.
        /// </summary>
        public const string Y0PNSA = "Y0PNSA";

        /// <summary>
        /// Y0NQWG.
        /// </summary>
        public const string Y0NQWG = "Y0NQWG";

        /// <summary>
        /// Y0WAN8.
        /// </summary>
        public const string Y0WAN8 = "Y0WAN8";

        /// <summary>
        /// Y0TX3S.
        /// </summary>
        public const string Y0TX3S = "Y0TX3S";

        /// <summary>
        /// Y0GD99.
        /// </summary>
        public const string Y0GD99 = "Y0GD99";

        /// <summary>
        /// Y0EC99.
        /// </summary>
        public const string Y0EC99 = "Y0EC99";

        /// <summary>
        /// Y0RT99.
        /// </summary>
        public const string Y0RT99 = "Y0RT99";

        /// <summary>
        /// Y0RY99.
        /// </summary>
        public const string Y0RY99 = "Y0RY99";

        /// <summary>
        /// Y0PA99.
        /// </summary>
        public const string Y0PA99 = "Y0PA99";

        /// <summary>
        /// Y0NC99.
        /// </summary>
        public const string Y0NC99 = "Y0NC99";

        /// <summary>
        /// Y0MH99.
        /// </summary>
        public const string Y0MH99 = "Y0MH99";

        /// <summary>
        /// Y0SP99.
        /// </summary>
        public const string Y0SP99 = "Y0SP99";

        /// <summary>
        /// Y0PEN.
        /// </summary>
        public const string Y0PEN = "Y0PEN";

        /// <summary>
        /// Y0STE.
        /// </summary>
        public const string Y0STE = "Y0STE";

        /// <summary>
        /// Y0DEC.
        /// </summary>
        public const string Y0DEC = "Y0DEC";

        /// <summary>
        /// Y0LEG.
        /// </summary>
        public const string Y0LEG = "Y0LEG";

        /// <summary>
        /// Y0DCC.
        /// </summary>
        public const string Y0DCC = "Y0DCC";

        /// <summary>
        /// Y0W2ST.
        /// </summary>
        public const string Y0W2ST = "Y0W2ST";

        /// <summary>
        /// Y0MQ.
        /// </summary>
        public const string Y0MQ = "Y0MQ";

        /// <summary>
        /// Y0RLRD.
        /// </summary>
        public const string Y0RLRD = "Y0RLRD";

        /// <summary>
        /// Y0PALF.
        /// </summary>
        public const string Y0PALF = "Y0PALF";

        /// <summary>
        /// Y0HMCO.
        /// </summary>
        public const string Y0HMCO = "Y0HMCO";

        /// <summary>
        /// Y0HMCU.
        /// </summary>
        public const string Y0HMCU = "Y0HMCU";

        /// <summary>
        /// Y0ADDZ.
        /// </summary>
        public const string Y0ADDZ = "Y0ADDZ";

        /// <summary>
        /// Y0MAIL.
        /// </summary>
        public const string Y0MAIL = "Y0MAIL";

        /// <summary>
        /// Y0SG.
        /// </summary>
        public const string Y0SG = "Y0SG";

        /// <summary>
        /// Y0W2P1.
        /// </summary>
        public const string Y0W2P1 = "Y0W2P1";

        /// <summary>
        /// Y0DTMT.
        /// </summary>
        public const string Y0DTMT = "Y0DTMT";

        /// <summary>
        /// Y0STCT.
        /// </summary>
        public const string Y0STCT = "Y0STCT";

        /// <summary>
        /// Y0PVNM.
        /// </summary>
        public const string Y0PVNM = "Y0PVNM";

        /// <summary>
        /// Y0W2FC.
        /// </summary>
        public const string Y0W2FC = "Y0W2FC";

        /// <summary>
        /// Y0R2CM.
        /// </summary>
        public const string Y0R2CM = "Y0R2CM";

        /// <summary>
        /// Y0R2CA.
        /// </summary>
        public const string Y0R2CA = "Y0R2CA";

        /// <summary>
        /// Y0R2RE.
        /// </summary>
        public const string Y0R2RE = "Y0R2RE";

        /// <summary>
        /// Y0R2RF.
        /// </summary>
        public const string Y0R2RF = "Y0R2RF";

        /// <summary>
        /// Y0R2CC.
        /// </summary>
        public const string Y0R2CC = "Y0R2CC";

        /// <summary>
        /// Y0R2MS.
        /// </summary>
        public const string Y0R2MS = "Y0R2MS";

        /// <summary>
        /// Y0W2P.
        /// </summary>
        public const string Y0W2P = "Y0W2P";

        /// <summary>
        /// Y0FBAM.
        /// </summary>
        public const string Y0FBAM = "Y0FBAM";

        /// <summary>
        /// Y0DFCP.
        /// </summary>
        public const string Y0DFCP = "Y0DFCP";

        /// <summary>
        /// Y0NQN4.
        /// </summary>
        public const string Y0NQN4 = "Y0NQN4";

        /// <summary>
        /// Y0DEPC.
        /// </summary>
        public const string Y0DEPC = "Y0DEPC";

        /// <summary>
        /// Y0GTLA.
        /// </summary>
        public const string Y0GTLA = "Y0GTLA";

        /// <summary>
        /// Y0PFRQ.
        /// </summary>
        public const string Y0PFRQ = "Y0PFRQ";

        /// <summary>
        /// Y0PAST.
        /// </summary>
        public const string Y0PAST = "Y0PAST";

        /// <summary>
        /// Y0DT.
        /// </summary>
        public const string Y0DT = "Y0DT";

        /// <summary>
        /// Y0BX01.
        /// </summary>
        public const string Y0BX01 = "Y0BX01";

        /// <summary>
        /// Y0UPMJ.
        /// </summary>
        public const string Y0UPMJ = "Y0UPMJ";

        /// <summary>
        /// Y0UPMT.
        /// </summary>
        public const string Y0UPMT = "Y0UPMT";

        /// <summary>
        /// Y0PID.
        /// </summary>
        public const string Y0PID = "Y0PID";

        /// <summary>
        /// Y0JOBN.
        /// </summary>
        public const string Y0JOBN = "Y0JOBN";

        /// <summary>
        /// Y0USER.
        /// </summary>
        public const string Y0USER = "Y0USER";
    }

    /// <inheritdoc />
    public override string TableName => "F07830";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y0IDYE", "Y0IDYE", JdeDataType.String, 20, true, true),
        new JdeField("Y0DTEY", "Y0DTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("Y0TAXX", "Y0TAXX", JdeDataType.String, 40, true, true),
        new JdeField("Y0CO", "Y0CO", JdeDataType.String, 10, true, true),
        new JdeField("Y0AN8", "Y0AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Y0TFYE", "Y0TFYE", JdeDataType.String, 2, true, true),
        new JdeField("Y0TWYE", "Y0TWYE", JdeDataType.String, 2, true, true),
        new JdeField("Y0CORF", "Y0CORF", JdeDataType.String, 2, true, true),
        new JdeField("Y0DTCF", "Y0DTCF", JdeDataType.Numeric, null, true, true),
        new JdeField("Y0W2RT", "Y0W2RT", JdeDataType.String, 2, true, true),
        new JdeField("Y0WCN", "Y0WCN", JdeDataType.Numeric),
        new JdeField("Y0WSCN", "Y0WSCN", JdeDataType.Numeric),
        new JdeField("Y0TIS", "Y0TIS", JdeDataType.String, 2),
        new JdeField("Y0SSN", "Y0SSN", JdeDataType.String, 40),
        new JdeField("Y0FDWG", "Y0FDWG", JdeDataType.Numeric),
        new JdeField("Y0FDAJ", "Y0FDAJ", JdeDataType.Numeric),
        new JdeField("Y0FDTX", "Y0FDTX", JdeDataType.Numeric),
        new JdeField("Y0OAWG", "Y0OAWG", JdeDataType.Numeric),
        new JdeField("Y0OAAJ", "Y0OAAJ", JdeDataType.Numeric),
        new JdeField("Y0OATX", "Y0OATX", JdeDataType.Numeric),
        new JdeField("Y0MCWG", "Y0MCWG", JdeDataType.Numeric),
        new JdeField("Y0MCAJ", "Y0MCAJ", JdeDataType.Numeric),
        new JdeField("Y0MCT", "Y0MCT", JdeDataType.Numeric),
        new JdeField("Y0FDTP", "Y0FDTP", JdeDataType.Numeric),
        new JdeField("Y0OATP", "Y0OATP", JdeDataType.Numeric),
        new JdeField("Y0MCTP", "Y0MCTP", JdeDataType.Numeric),
        new JdeField("Y0ALTP", "Y0ALTP", JdeDataType.Numeric),
        new JdeField("Y0T1WG", "Y0T1WG", JdeDataType.Numeric),
        new JdeField("Y0T1AJ", "Y0T1AJ", JdeDataType.Numeric),
        new JdeField("Y0RRT1", "Y0RRT1", JdeDataType.Numeric),
        new JdeField("Y0T2WG", "Y0T2WG", JdeDataType.Numeric),
        new JdeField("Y0T2AJ", "Y0T2AJ", JdeDataType.Numeric),
        new JdeField("Y0RRT2", "Y0RRT2", JdeDataType.Numeric),
        new JdeField("Y0AROA", "Y0AROA", JdeDataType.Numeric),
        new JdeField("Y0ARMC", "Y0ARMC", JdeDataType.Numeric),
        new JdeField("Y0ART1", "Y0ART1", JdeDataType.Numeric),
        new JdeField("Y0ART2", "Y0ART2", JdeDataType.Numeric),
        new JdeField("Y0EARN", "Y0EARN", JdeDataType.Numeric),
        new JdeField("Y0PNSA", "Y0PNSA", JdeDataType.Numeric),
        new JdeField("Y0NQWG", "Y0NQWG", JdeDataType.Numeric),
        new JdeField("Y0WAN8", "Y0WAN8", JdeDataType.Numeric),
        new JdeField("Y0TX3S", "Y0TX3S", JdeDataType.Numeric),
        new JdeField("Y0GD99", "Y0GD99", JdeDataType.Numeric),
        new JdeField("Y0EC99", "Y0EC99", JdeDataType.Numeric),
        new JdeField("Y0RT99", "Y0RT99", JdeDataType.Numeric),
        new JdeField("Y0RY99", "Y0RY99", JdeDataType.Numeric),
        new JdeField("Y0PA99", "Y0PA99", JdeDataType.Numeric),
        new JdeField("Y0NC99", "Y0NC99", JdeDataType.Numeric),
        new JdeField("Y0MH99", "Y0MH99", JdeDataType.Numeric),
        new JdeField("Y0SP99", "Y0SP99", JdeDataType.Numeric),
        new JdeField("Y0PEN", "Y0PEN", JdeDataType.String, 2),
        new JdeField("Y0STE", "Y0STE", JdeDataType.String, 2),
        new JdeField("Y0DEC", "Y0DEC", JdeDataType.String, 2),
        new JdeField("Y0LEG", "Y0LEG", JdeDataType.String, 2),
        new JdeField("Y0DCC", "Y0DCC", JdeDataType.String, 2),
        new JdeField("Y0W2ST", "Y0W2ST", JdeDataType.Numeric),
        new JdeField("Y0MQ", "Y0MQ", JdeDataType.String, 2),
        new JdeField("Y0RLRD", "Y0RLRD", JdeDataType.String, 2),
        new JdeField("Y0PALF", "Y0PALF", JdeDataType.String, 24),
        new JdeField("Y0HMCO", "Y0HMCO", JdeDataType.String, 10),
        new JdeField("Y0HMCU", "Y0HMCU", JdeDataType.String, 24),
        new JdeField("Y0ADDZ", "Y0ADDZ", JdeDataType.String, 24),
        new JdeField("Y0MAIL", "Y0MAIL", JdeDataType.String, 20),
        new JdeField("Y0SG", "Y0SG", JdeDataType.String, 24),
        new JdeField("Y0W2P1", "Y0W2P1", JdeDataType.Numeric),
        new JdeField("Y0DTMT", "Y0DTMT", JdeDataType.Numeric),
        new JdeField("Y0STCT", "Y0STCT", JdeDataType.Numeric),
        new JdeField("Y0PVNM", "Y0PVNM", JdeDataType.String, 80),
        new JdeField("Y0W2FC", "Y0W2FC", JdeDataType.Numeric),
        new JdeField("Y0R2CM", "Y0R2CM", JdeDataType.Numeric),
        new JdeField("Y0R2CA", "Y0R2CA", JdeDataType.Numeric),
        new JdeField("Y0R2RE", "Y0R2RE", JdeDataType.Numeric),
        new JdeField("Y0R2RF", "Y0R2RF", JdeDataType.Numeric),
        new JdeField("Y0R2CC", "Y0R2CC", JdeDataType.Numeric),
        new JdeField("Y0R2MS", "Y0R2MS", JdeDataType.String, 2),
        new JdeField("Y0W2P", "Y0W2P", JdeDataType.Numeric),
        new JdeField("Y0FBAM", "Y0FBAM", JdeDataType.Numeric),
        new JdeField("Y0DFCP", "Y0DFCP", JdeDataType.Numeric),
        new JdeField("Y0NQN4", "Y0NQN4", JdeDataType.Numeric),
        new JdeField("Y0DEPC", "Y0DEPC", JdeDataType.Numeric),
        new JdeField("Y0GTLA", "Y0GTLA", JdeDataType.Numeric),
        new JdeField("Y0PFRQ", "Y0PFRQ", JdeDataType.String, 2),
        new JdeField("Y0PAST", "Y0PAST", JdeDataType.String, 2),
        new JdeField("Y0DT", "Y0DT", JdeDataType.Numeric),
        new JdeField("Y0BX01", "Y0BX01", JdeDataType.Numeric),
        new JdeField("Y0UPMJ", "Y0UPMJ", JdeDataType.Numeric),
        new JdeField("Y0UPMT", "Y0UPMT", JdeDataType.Numeric),
        new JdeField("Y0PID", "Y0PID", JdeDataType.String, 20),
        new JdeField("Y0JOBN", "Y0JOBN", JdeDataType.String, 20),
        new JdeField("Y0USER", "Y0USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07830_0", "Primary Key on Y0IDYE, Y0DTEY, Y0TAXX, Y0CO, Y0AN8, Y0TFYE, Y0TWYE, Y0CORF, Y0DTCF, Y0W2RT", new[] { "Y0IDYE", "Y0DTEY", "Y0TAXX", "Y0CO", "Y0AN8", "Y0TFYE", "Y0TWYE", "Y0CORF", "Y0DTCF", "Y0W2RT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07830_10", "Index on Y0IDYE, Y0DTEY, Y0AN8, Y0TFYE, Y0TWYE, Y0W2RT", new[] { "Y0IDYE", "Y0DTEY", "Y0AN8", "Y0TFYE", "Y0TWYE", "Y0W2RT" }),
        new JdeIndex("F07830_11", "Index on Y0IDYE, Y0DTEY, Y0TAXX, Y0CO, Y0AN8, Y0TFYE, Y0TWYE, Y0W2RT", new[] { "Y0IDYE", "Y0DTEY", "Y0TAXX", "Y0CO", "Y0AN8", "Y0TFYE", "Y0TWYE", "Y0W2RT" }),
        new JdeIndex("F07830_2", "Index on Y0IDYE, Y0DTEY, Y0TFYE, Y0TAXX, Y0CO, Y0AN8", new[] { "Y0IDYE", "Y0DTEY", "Y0TFYE", "Y0TAXX", "Y0CO", "Y0AN8" }),
        new JdeIndex("F07830_3", "Index on Y0IDYE, Y0DTEY, Y0TAXX, Y0CO, Y0TWYE", new[] { "Y0IDYE", "Y0DTEY", "Y0TAXX", "Y0CO", "Y0TWYE" }),
        new JdeIndex("F07830_4", "Index on Y0DTEY, Y0TAXX, Y0CO, Y0AN8, Y0TFYE, Y0TWYE, Y0CORF, Y0DTCF", new[] { "Y0DTEY", "Y0TAXX", "Y0CO", "Y0AN8", "Y0TFYE", "Y0TWYE", "Y0CORF", "Y0DTCF" }),
        new JdeIndex("F07830_5", "Index on Y0IDYE, Y0DTEY, Y0AN8, Y0TAXX, Y0TFYE, Y0TWYE, Y0CORF, Y0DTCF, Y0W2RT", new[] { "Y0IDYE", "Y0DTEY", "Y0AN8", "Y0TAXX", "Y0TFYE", "Y0TWYE", "Y0CORF", "Y0DTCF", "Y0W2RT" }),
        new JdeIndex("F07830_6", "Index on Y0IDYE, Y0DTEY, Y0CO, Y0AN8", new[] { "Y0IDYE", "Y0DTEY", "Y0CO", "Y0AN8" }),
        new JdeIndex("F07830_7", "Index on Y0IDYE, Y0DTEY, Y0TAXX, Y0AN8, Y0TFYE, Y0TWYE, Y0CORF, Y0DTCF, Y0W2RT", new[] { "Y0IDYE", "Y0DTEY", "Y0TAXX", "Y0AN8", "Y0TFYE", "Y0TWYE", "Y0CORF", "Y0DTCF", "Y0W2RT" }),
        new JdeIndex("F07830_8", "Index on Y0IDYE, Y0DTEY, Y0TAXX, Y0AN8, Y0DTCF", new[] { "Y0IDYE", "Y0DTEY", "Y0TAXX", "Y0AN8", "Y0DTCF" }),
        new JdeIndex("F07830_9", "Index on Y0IDYE, Y0DTEY, Y0TAXX, Y0TFYE, Y0TWYE", new[] { "Y0IDYE", "Y0DTEY", "Y0TAXX", "Y0TFYE", "Y0TWYE" })
    };
}
