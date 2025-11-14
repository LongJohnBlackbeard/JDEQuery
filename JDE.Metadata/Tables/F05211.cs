using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F05211 - .
/// </summary>
public class F05211 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AOAWBOI.
        /// </summary>
        public const string AOAWBOI = "AOAWBOI";

        /// <summary>
        /// AOAWBOD.
        /// </summary>
        public const string AOAWBOD = "AOAWBOD";

        /// <summary>
        /// AOAWBSI.
        /// </summary>
        public const string AOAWBSI = "AOAWBSI";

        /// <summary>
        /// AOAWBSU.
        /// </summary>
        public const string AOAWBSU = "AOAWBSU";

        /// <summary>
        /// AOAWBSC.
        /// </summary>
        public const string AOAWBSC = "AOAWBSC";

        /// <summary>
        /// AOAWBST.
        /// </summary>
        public const string AOAWBST = "AOAWBST";

        /// <summary>
        /// AOAWBSJ.
        /// </summary>
        public const string AOAWBSJ = "AOAWBSJ";

        /// <summary>
        /// AOAWBSP.
        /// </summary>
        public const string AOAWBSP = "AOAWBSP";

        /// <summary>
        /// AOPID.
        /// </summary>
        public const string AOPID = "AOPID";

        /// <summary>
        /// AOUSER.
        /// </summary>
        public const string AOUSER = "AOUSER";

        /// <summary>
        /// AOUPMJ.
        /// </summary>
        public const string AOUPMJ = "AOUPMJ";

        /// <summary>
        /// AOUPMT.
        /// </summary>
        public const string AOUPMT = "AOUPMT";

        /// <summary>
        /// AOMKEY.
        /// </summary>
        public const string AOMKEY = "AOMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F05211";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AOAWBOI", "AOAWBOI", JdeDataType.String, 20, true, true),
        new JdeField("AOAWBOD", "AOAWBOD", JdeDataType.String, 80),
        new JdeField("AOAWBSI", "AOAWBSI", JdeDataType.String, 2),
        new JdeField("AOAWBSU", "AOAWBSU", JdeDataType.String, 2),
        new JdeField("AOAWBSC", "AOAWBSC", JdeDataType.String, 2),
        new JdeField("AOAWBST", "AOAWBST", JdeDataType.String, 2),
        new JdeField("AOAWBSJ", "AOAWBSJ", JdeDataType.String, 2),
        new JdeField("AOAWBSP", "AOAWBSP", JdeDataType.String, 2),
        new JdeField("AOPID", "AOPID", JdeDataType.String, 20),
        new JdeField("AOUSER", "AOUSER", JdeDataType.String, 20),
        new JdeField("AOUPMJ", "AOUPMJ", JdeDataType.Numeric),
        new JdeField("AOUPMT", "AOUPMT", JdeDataType.Numeric),
        new JdeField("AOMKEY", "AOMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F05211_0", "Primary Key on AOAWBOI", new[] { "AOAWBOI" }, isUnique: true, isPrimaryKey: true)
    };
}
