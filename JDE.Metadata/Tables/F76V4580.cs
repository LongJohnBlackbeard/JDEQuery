using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76V4580 - .
/// </summary>
public class F76V4580 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTAC07.
        /// </summary>
        public const string RTAC07 = "RTAC07";

        /// <summary>
        /// RTTNN.
        /// </summary>
        public const string RTTNN = "RTTNN";

        /// <summary>
        /// RTSMAM.
        /// </summary>
        public const string RTSMAM = "RTSMAM";

        /// <summary>
        /// RTSXAM.
        /// </summary>
        public const string RTSXAM = "RTSXAM";

        /// <summary>
        /// RTIRPC.
        /// </summary>
        public const string RTIRPC = "RTIRPC";

        /// <summary>
        /// RTIRPR.
        /// </summary>
        public const string RTIRPR = "RTIRPR";

        /// <summary>
        /// RTBBIR.
        /// </summary>
        public const string RTBBIR = "RTBBIR";

        /// <summary>
        /// RTIWTT.
        /// </summary>
        public const string RTIWTT = "RTIWTT";

        /// <summary>
        /// RTUPMB.
        /// </summary>
        public const string RTUPMB = "RTUPMB";

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
    public override string TableName => "F76V4580";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTAC07", "RTAC07", JdeDataType.String, 6, true, true),
        new JdeField("RTTNN", "RTTNN", JdeDataType.String, 2, true, true),
        new JdeField("RTSMAM", "RTSMAM", JdeDataType.Numeric, null, true, true),
        new JdeField("RTSXAM", "RTSXAM", JdeDataType.Numeric, null, true, true),
        new JdeField("RTIRPC", "RTIRPC", JdeDataType.Numeric),
        new JdeField("RTIRPR", "RTIRPR", JdeDataType.Numeric),
        new JdeField("RTBBIR", "RTBBIR", JdeDataType.Numeric),
        new JdeField("RTIWTT", "RTIWTT", JdeDataType.String, 2),
        new JdeField("RTUPMB", "RTUPMB", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76V4580_0", "Primary Key on RTAC07, RTTNN, RTSMAM, RTSXAM", new[] { "RTAC07", "RTTNN", "RTSMAM", "RTSXAM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76V4580_2", "Index on RTAC07", new[] { "RTAC07" }),
        new JdeIndex("F76V4580_3", "Index on RTTNN", new[] { "RTTNN" })
    };
}
