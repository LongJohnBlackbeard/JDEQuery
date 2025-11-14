using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700100 - .
/// </summary>
public class F700100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCSY.
        /// </summary>
        public const string SCSY = "SCSY";

        /// <summary>
        /// SCLCTR.
        /// </summary>
        public const string SCLCTR = "SCLCTR";

        /// <summary>
        /// SCK70PAAI.
        /// </summary>
        public const string SCK70PAAI = "SCK70PAAI";

        /// <summary>
        /// SCK70MTHD.
        /// </summary>
        public const string SCK70MTHD = "SCK70MTHD";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";
    }

    /// <inheritdoc />
    public override string TableName => "F700100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCSY", "SCSY", JdeDataType.String, 8, true, true),
        new JdeField("SCLCTR", "SCLCTR", JdeDataType.String, 6, true, true),
        new JdeField("SCK70PAAI", "SCK70PAAI", JdeDataType.String, 4),
        new JdeField("SCK70MTHD", "SCK70MTHD", JdeDataType.String, 2),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700100_0", "Primary Key on SCSY, SCLCTR", new[] { "SCSY", "SCLCTR" }, isUnique: true, isPrimaryKey: true)
    };
}
