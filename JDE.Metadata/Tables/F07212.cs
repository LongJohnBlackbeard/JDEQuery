using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07212 - .
/// </summary>
public class F07212 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Y2SCOD.
        /// </summary>
        public const string Y2SCOD = "Y2SCOD";

        /// <summary>
        /// Y2DL01.
        /// </summary>
        public const string Y2DL01 = "Y2DL01";

        /// <summary>
        /// Y2PF09.
        /// </summary>
        public const string Y2PF09 = "Y2PF09";

        /// <summary>
        /// Y2UPMJ.
        /// </summary>
        public const string Y2UPMJ = "Y2UPMJ";

        /// <summary>
        /// Y2UPMT.
        /// </summary>
        public const string Y2UPMT = "Y2UPMT";

        /// <summary>
        /// Y2PID.
        /// </summary>
        public const string Y2PID = "Y2PID";

        /// <summary>
        /// Y2JOBN.
        /// </summary>
        public const string Y2JOBN = "Y2JOBN";

        /// <summary>
        /// Y2USER.
        /// </summary>
        public const string Y2USER = "Y2USER";
    }

    /// <inheritdoc />
    public override string TableName => "F07212";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Y2SCOD", "Y2SCOD", JdeDataType.String, 6, true, true),
        new JdeField("Y2DL01", "Y2DL01", JdeDataType.String, 60),
        new JdeField("Y2PF09", "Y2PF09", JdeDataType.String, 2),
        new JdeField("Y2UPMJ", "Y2UPMJ", JdeDataType.Numeric),
        new JdeField("Y2UPMT", "Y2UPMT", JdeDataType.Numeric),
        new JdeField("Y2PID", "Y2PID", JdeDataType.String, 20),
        new JdeField("Y2JOBN", "Y2JOBN", JdeDataType.String, 20),
        new JdeField("Y2USER", "Y2USER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07212_0", "Primary Key on Y2SCOD", new[] { "Y2SCOD" }, isUnique: true, isPrimaryKey: true)
    };
}
