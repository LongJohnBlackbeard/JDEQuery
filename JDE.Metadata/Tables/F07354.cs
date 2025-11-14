using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07354 - .
/// </summary>
public class F07354 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y4PAYD.
        /// </summary>
        public const string Y4PAYD = "Y4PAYD";

        /// <summary>
        /// Y4RPSC.
        /// </summary>
        public const string Y4RPSC = "Y4RPSC";

        /// <summary>
        /// Y4RTID.
        /// </summary>
        public const string Y4RTID = "Y4RTID";

        /// <summary>
        /// Y4RTVE.
        /// </summary>
        public const string Y4RTVE = "Y4RTVE";

        /// <summary>
        /// Y4DL01.
        /// </summary>
        public const string Y4DL01 = "Y4DL01";

        /// <summary>
        /// Y4UPMJ.
        /// </summary>
        public const string Y4UPMJ = "Y4UPMJ";

        /// <summary>
        /// Y4UPMT.
        /// </summary>
        public const string Y4UPMT = "Y4UPMT";

        /// <summary>
        /// Y4PID.
        /// </summary>
        public const string Y4PID = "Y4PID";

        /// <summary>
        /// Y4JOBN.
        /// </summary>
        public const string Y4JOBN = "Y4JOBN";

        /// <summary>
        /// Y4USER.
        /// </summary>
        public const string Y4USER = "Y4USER";
    }

    /// <inheritdoc />
    public override string TableName => "F07354";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y4PAYD", "Y4PAYD", JdeDataType.String, 20, true, true),
        new JdeField("Y4RPSC", "Y4RPSC", JdeDataType.String, 2, true, true),
        new JdeField("Y4RTID", "Y4RTID", JdeDataType.String, 20, true, true),
        new JdeField("Y4RTVE", "Y4RTVE", JdeDataType.String, 20, true, true),
        new JdeField("Y4DL01", "Y4DL01", JdeDataType.String, 60),
        new JdeField("Y4UPMJ", "Y4UPMJ", JdeDataType.Numeric),
        new JdeField("Y4UPMT", "Y4UPMT", JdeDataType.Numeric),
        new JdeField("Y4PID", "Y4PID", JdeDataType.String, 20),
        new JdeField("Y4JOBN", "Y4JOBN", JdeDataType.String, 20),
        new JdeField("Y4USER", "Y4USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07354_0", "Primary Key on Y4PAYD, Y4RPSC, Y4RTID, Y4RTVE", new[] { "Y4PAYD", "Y4RPSC", "Y4RTID", "Y4RTVE" }, isUnique: true, isPrimaryKey: true)
    };
}
