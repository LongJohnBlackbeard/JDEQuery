using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I319B - .
/// </summary>
public class F75I319B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R1YEXU.
        /// </summary>
        public const string R1YEXU = "R1YEXU";

        /// <summary>
        /// R1YRM.
        /// </summary>
        public const string R1YRM = "R1YRM";

        /// <summary>
        /// R1MNTH.
        /// </summary>
        public const string R1MNTH = "R1MNTH";

        /// <summary>
        /// R1LNID.
        /// </summary>
        public const string R1LNID = "R1LNID";

        /// <summary>
        /// R1FLG.
        /// </summary>
        public const string R1FLG = "R1FLG";

        /// <summary>
        /// R1AN01.
        /// </summary>
        public const string R1AN01 = "R1AN01";

        /// <summary>
        /// R1YMOB.
        /// </summary>
        public const string R1YMOB = "R1YMOB";

        /// <summary>
        /// R1YMCR.
        /// </summary>
        public const string R1YMCR = "R1YMCR";

        /// <summary>
        /// R1YMDR.
        /// </summary>
        public const string R1YMDR = "R1YMDR";

        /// <summary>
        /// R1YMCB.
        /// </summary>
        public const string R1YMCB = "R1YMCB";

        /// <summary>
        /// R1YCOB.
        /// </summary>
        public const string R1YCOB = "R1YCOB";

        /// <summary>
        /// R1YCCR.
        /// </summary>
        public const string R1YCCR = "R1YCCR";

        /// <summary>
        /// R1YCDR.
        /// </summary>
        public const string R1YCDR = "R1YCDR";

        /// <summary>
        /// R1YCCB.
        /// </summary>
        public const string R1YCCB = "R1YCCB";

        /// <summary>
        /// R1YA2BEDOP.
        /// </summary>
        public const string R1YA2BEDOP = "R1YA2BEDOP";

        /// <summary>
        /// R1YA2BEDCR.
        /// </summary>
        public const string R1YA2BEDCR = "R1YA2BEDCR";

        /// <summary>
        /// R1YA2BEDDR.
        /// </summary>
        public const string R1YA2BEDDR = "R1YA2BEDDR";

        /// <summary>
        /// R1YA2BEDCB.
        /// </summary>
        public const string R1YA2BEDCB = "R1YA2BEDCB";

        /// <summary>
        /// R1YA2SEDOP.
        /// </summary>
        public const string R1YA2SEDOP = "R1YA2SEDOP";

        /// <summary>
        /// R1YA2SEDCR.
        /// </summary>
        public const string R1YA2SEDCR = "R1YA2SEDCR";

        /// <summary>
        /// R1YA2SEDDR.
        /// </summary>
        public const string R1YA2SEDDR = "R1YA2SEDDR";

        /// <summary>
        /// R1YA2SEDCB.
        /// </summary>
        public const string R1YA2SEDCB = "R1YA2SEDCB";

        /// <summary>
        /// R1YC2BEDOP.
        /// </summary>
        public const string R1YC2BEDOP = "R1YC2BEDOP";

        /// <summary>
        /// R1YC2BEDCR.
        /// </summary>
        public const string R1YC2BEDCR = "R1YC2BEDCR";

        /// <summary>
        /// R1YC2BEDDR.
        /// </summary>
        public const string R1YC2BEDDR = "R1YC2BEDDR";

        /// <summary>
        /// R1YC2BEDCB.
        /// </summary>
        public const string R1YC2BEDCB = "R1YC2BEDCB";

        /// <summary>
        /// R1YC2SEDOP.
        /// </summary>
        public const string R1YC2SEDOP = "R1YC2SEDOP";

        /// <summary>
        /// R1YC2SEDCR.
        /// </summary>
        public const string R1YC2SEDCR = "R1YC2SEDCR";

        /// <summary>
        /// R1YC2SEDDR.
        /// </summary>
        public const string R1YC2SEDDR = "R1YC2SEDDR";

        /// <summary>
        /// R1YC2SEDCB.
        /// </summary>
        public const string R1YC2SEDCB = "R1YC2SEDCB";

        /// <summary>
        /// R1USER.
        /// </summary>
        public const string R1USER = "R1USER";

        /// <summary>
        /// R1JOBN.
        /// </summary>
        public const string R1JOBN = "R1JOBN";

        /// <summary>
        /// R1PID.
        /// </summary>
        public const string R1PID = "R1PID";

        /// <summary>
        /// R1UPMJ.
        /// </summary>
        public const string R1UPMJ = "R1UPMJ";

        /// <summary>
        /// R1UPMT.
        /// </summary>
        public const string R1UPMT = "R1UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I319B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R1YEXU", "R1YEXU", JdeDataType.Numeric, null, true, true),
        new JdeField("R1YRM", "R1YRM", JdeDataType.Numeric, null, true, true),
        new JdeField("R1MNTH", "R1MNTH", JdeDataType.Numeric, null, true, true),
        new JdeField("R1LNID", "R1LNID", JdeDataType.Numeric, null, true, true),
        new JdeField("R1FLG", "R1FLG", JdeDataType.String, 2),
        new JdeField("R1AN01", "R1AN01", JdeDataType.Numeric),
        new JdeField("R1YMOB", "R1YMOB", JdeDataType.Numeric),
        new JdeField("R1YMCR", "R1YMCR", JdeDataType.Numeric),
        new JdeField("R1YMDR", "R1YMDR", JdeDataType.Numeric),
        new JdeField("R1YMCB", "R1YMCB", JdeDataType.Numeric),
        new JdeField("R1YCOB", "R1YCOB", JdeDataType.Numeric),
        new JdeField("R1YCCR", "R1YCCR", JdeDataType.Numeric),
        new JdeField("R1YCDR", "R1YCDR", JdeDataType.Numeric),
        new JdeField("R1YCCB", "R1YCCB", JdeDataType.Numeric),
        new JdeField("R1YA2BEDOP", "R1YA2BEDOP", JdeDataType.Numeric),
        new JdeField("R1YA2BEDCR", "R1YA2BEDCR", JdeDataType.Numeric),
        new JdeField("R1YA2BEDDR", "R1YA2BEDDR", JdeDataType.Numeric),
        new JdeField("R1YA2BEDCB", "R1YA2BEDCB", JdeDataType.Numeric),
        new JdeField("R1YA2SEDOP", "R1YA2SEDOP", JdeDataType.Numeric),
        new JdeField("R1YA2SEDCR", "R1YA2SEDCR", JdeDataType.Numeric),
        new JdeField("R1YA2SEDDR", "R1YA2SEDDR", JdeDataType.Numeric),
        new JdeField("R1YA2SEDCB", "R1YA2SEDCB", JdeDataType.Numeric),
        new JdeField("R1YC2BEDOP", "R1YC2BEDOP", JdeDataType.Numeric),
        new JdeField("R1YC2BEDCR", "R1YC2BEDCR", JdeDataType.Numeric),
        new JdeField("R1YC2BEDDR", "R1YC2BEDDR", JdeDataType.Numeric),
        new JdeField("R1YC2BEDCB", "R1YC2BEDCB", JdeDataType.Numeric),
        new JdeField("R1YC2SEDOP", "R1YC2SEDOP", JdeDataType.Numeric),
        new JdeField("R1YC2SEDCR", "R1YC2SEDCR", JdeDataType.Numeric),
        new JdeField("R1YC2SEDDR", "R1YC2SEDDR", JdeDataType.Numeric),
        new JdeField("R1YC2SEDCB", "R1YC2SEDCB", JdeDataType.Numeric),
        new JdeField("R1USER", "R1USER", JdeDataType.String, 20),
        new JdeField("R1JOBN", "R1JOBN", JdeDataType.String, 20),
        new JdeField("R1PID", "R1PID", JdeDataType.String, 20),
        new JdeField("R1UPMJ", "R1UPMJ", JdeDataType.Numeric),
        new JdeField("R1UPMT", "R1UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I319B_0", "Primary Key on R1YEXU, R1YRM, R1MNTH, R1LNID", new[] { "R1YEXU", "R1YRM", "R1MNTH", "R1LNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I319B_2", "Index on R1YEXU, R1YRM, R1MNTH, SYS_NC00036$", new[] { "R1YEXU", "R1YRM", "R1MNTH", "SYS_NC00036$" })
    };
}
