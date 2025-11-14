using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S85 - .
/// </summary>
public class F48S85 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTSEGMID.
        /// </summary>
        public const string RTSEGMID = "RTSEGMID";

        /// <summary>
        /// RTEFTB.
        /// </summary>
        public const string RTEFTB = "RTEFTB";

        /// <summary>
        /// RTBUCA.
        /// </summary>
        public const string RTBUCA = "RTBUCA";

        /// <summary>
        /// RTBURT.
        /// </summary>
        public const string RTBURT = "RTBURT";

        /// <summary>
        /// RTPOOLID.
        /// </summary>
        public const string RTPOOLID = "RTPOOLID";

        /// <summary>
        /// RTUORC.
        /// </summary>
        public const string RTUORC = "RTUORC";

        /// <summary>
        /// RTCRTP.
        /// </summary>
        public const string RTCRTP = "RTCRTP";

        /// <summary>
        /// RTCRCD.
        /// </summary>
        public const string RTCRCD = "RTCRCD";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48S85";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTSEGMID", "RTSEGMID", JdeDataType.String, 6, true, true),
        new JdeField("RTEFTB", "RTEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("RTBUCA", "RTBUCA", JdeDataType.String, 10, true, true),
        new JdeField("RTBURT", "RTBURT", JdeDataType.String, 10, true, true),
        new JdeField("RTPOOLID", "RTPOOLID", JdeDataType.String, 8, true, true),
        new JdeField("RTUORC", "RTUORC", JdeDataType.String, 2),
        new JdeField("RTCRTP", "RTCRTP", JdeDataType.Numeric),
        new JdeField("RTCRCD", "RTCRCD", JdeDataType.String, 6, true, true),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S85_0", "Primary Key on RTSEGMID, RTEFTB, RTCRCD, RTBUCA, RTBURT, RTPOOLID", new[] { "RTSEGMID", "RTEFTB", "RTCRCD", "RTBUCA", "RTBURT", "RTPOOLID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S85_2", "Index on RTSEGMID, SYS_NC00014$, RTCRCD, RTBUCA, RTBURT, RTPOOLID", new[] { "RTSEGMID", "SYS_NC00014$", "RTCRCD", "RTBUCA", "RTBURT", "RTPOOLID" })
    };
}
