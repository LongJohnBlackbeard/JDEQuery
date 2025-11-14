using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S101 - .
/// </summary>
public class F74S101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AIAN8.
        /// </summary>
        public const string AIAN8 = "AIAN8";

        /// <summary>
        /// AIS740111.
        /// </summary>
        public const string AIS740111 = "AIS740111";

        /// <summary>
        /// AIS740112.
        /// </summary>
        public const string AIS740112 = "AIS740112";

        /// <summary>
        /// AIS740113.
        /// </summary>
        public const string AIS740113 = "AIS740113";

        /// <summary>
        /// AIS740115.
        /// </summary>
        public const string AIS740115 = "AIS740115";

        /// <summary>
        /// AIUSER.
        /// </summary>
        public const string AIUSER = "AIUSER";

        /// <summary>
        /// AIPID.
        /// </summary>
        public const string AIPID = "AIPID";

        /// <summary>
        /// AIUPMJ.
        /// </summary>
        public const string AIUPMJ = "AIUPMJ";

        /// <summary>
        /// AIUPMT.
        /// </summary>
        public const string AIUPMT = "AIUPMT";

        /// <summary>
        /// AIJOBN.
        /// </summary>
        public const string AIJOBN = "AIJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74S101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AIAN8", "AIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("AIS740111", "AIS740111", JdeDataType.Numeric),
        new JdeField("AIS740112", "AIS740112", JdeDataType.Numeric),
        new JdeField("AIS740113", "AIS740113", JdeDataType.String, 2),
        new JdeField("AIS740115", "AIS740115", JdeDataType.String, 2),
        new JdeField("AIUSER", "AIUSER", JdeDataType.String, 20),
        new JdeField("AIPID", "AIPID", JdeDataType.String, 20),
        new JdeField("AIUPMJ", "AIUPMJ", JdeDataType.Numeric),
        new JdeField("AIUPMT", "AIUPMT", JdeDataType.Numeric),
        new JdeField("AIJOBN", "AIJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S101_0", "Primary Key on AIAN8", new[] { "AIAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
