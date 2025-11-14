using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3403 - .
/// </summary>
public class F3403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MPMMCU.
        /// </summary>
        public const string MPMMCU = "MPMMCU";

        /// <summary>
        /// MPCMCU.
        /// </summary>
        public const string MPCMCU = "MPCMCU";

        /// <summary>
        /// MPITM.
        /// </summary>
        public const string MPITM = "MPITM";

        /// <summary>
        /// MPPRPX.
        /// </summary>
        public const string MPPRPX = "MPPRPX";

        /// <summary>
        /// MPBRLV.
        /// </summary>
        public const string MPBRLV = "MPBRLV";

        /// <summary>
        /// MPBRSQ.
        /// </summary>
        public const string MPBRSQ = "MPBRSQ";

        /// <summary>
        /// MPEXIN.
        /// </summary>
        public const string MPEXIN = "MPEXIN";

        /// <summary>
        /// MPAVLC.
        /// </summary>
        public const string MPAVLC = "MPAVLC";

        /// <summary>
        /// MPEFFF.
        /// </summary>
        public const string MPEFFF = "MPEFFF";

        /// <summary>
        /// MPEFFT.
        /// </summary>
        public const string MPEFFT = "MPEFFT";

        /// <summary>
        /// MPTRLT.
        /// </summary>
        public const string MPTRLT = "MPTRLT";

        /// <summary>
        /// MPSRCP.
        /// </summary>
        public const string MPSRCP = "MPSRCP";

        /// <summary>
        /// MPPCTF.
        /// </summary>
        public const string MPPCTF = "MPPCTF";

        /// <summary>
        /// MPPCMU.
        /// </summary>
        public const string MPPCMU = "MPPCMU";

        /// <summary>
        /// MPFXMU.
        /// </summary>
        public const string MPFXMU = "MPFXMU";

        /// <summary>
        /// MPFXUE.
        /// </summary>
        public const string MPFXUE = "MPFXUE";

        /// <summary>
        /// MPUSER.
        /// </summary>
        public const string MPUSER = "MPUSER";

        /// <summary>
        /// MPPID.
        /// </summary>
        public const string MPPID = "MPPID";

        /// <summary>
        /// MPUPMJ.
        /// </summary>
        public const string MPUPMJ = "MPUPMJ";

        /// <summary>
        /// MPTDAY.
        /// </summary>
        public const string MPTDAY = "MPTDAY";

        /// <summary>
        /// MPJOBN.
        /// </summary>
        public const string MPJOBN = "MPJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F3403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MPMMCU", "MPMMCU", JdeDataType.String, 24, true, true),
        new JdeField("MPCMCU", "MPCMCU", JdeDataType.String, 24, true, true),
        new JdeField("MPITM", "MPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("MPPRPX", "MPPRPX", JdeDataType.String, 6, true, true),
        new JdeField("MPBRLV", "MPBRLV", JdeDataType.Numeric, null, true, true),
        new JdeField("MPBRSQ", "MPBRSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("MPEXIN", "MPEXIN", JdeDataType.String, 2),
        new JdeField("MPAVLC", "MPAVLC", JdeDataType.String, 2),
        new JdeField("MPEFFF", "MPEFFF", JdeDataType.Numeric),
        new JdeField("MPEFFT", "MPEFFT", JdeDataType.Numeric),
        new JdeField("MPTRLT", "MPTRLT", JdeDataType.Numeric),
        new JdeField("MPSRCP", "MPSRCP", JdeDataType.Numeric),
        new JdeField("MPPCTF", "MPPCTF", JdeDataType.Numeric),
        new JdeField("MPPCMU", "MPPCMU", JdeDataType.Numeric),
        new JdeField("MPFXMU", "MPFXMU", JdeDataType.Numeric),
        new JdeField("MPFXUE", "MPFXUE", JdeDataType.String, 2),
        new JdeField("MPUSER", "MPUSER", JdeDataType.String, 20),
        new JdeField("MPPID", "MPPID", JdeDataType.String, 20),
        new JdeField("MPUPMJ", "MPUPMJ", JdeDataType.Numeric),
        new JdeField("MPTDAY", "MPTDAY", JdeDataType.Numeric),
        new JdeField("MPJOBN", "MPJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3403_0", "Primary Key on MPMMCU, MPCMCU, MPPRPX, MPITM, MPBRLV, MPBRSQ", new[] { "MPMMCU", "MPCMCU", "MPPRPX", "MPITM", "MPBRLV", "MPBRSQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3403_1", "Index on MPMMCU, MPCMCU, MPITM, MPPRPX, MPBRLV, MPEFFT", new[] { "MPMMCU", "MPCMCU", "MPITM", "MPPRPX", "MPBRLV", "MPEFFT" }),
        new JdeIndex("F3403_2", "Index on MPCMCU, MPITM, MPPRPX, MPBRSQ, MPEFFT", new[] { "MPCMCU", "MPITM", "MPPRPX", "MPBRSQ", "MPEFFT" })
    };
}
