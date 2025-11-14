using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F700000 - .
/// </summary>
public class F700000 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FCLCTR.
        /// </summary>
        public const string FCLCTR = "FCLCTR";

        /// <summary>
        /// FCK70FCTR.
        /// </summary>
        public const string FCK70FCTR = "FCK70FCTR";

        /// <summary>
        /// FCUSER.
        /// </summary>
        public const string FCUSER = "FCUSER";

        /// <summary>
        /// FCUPMJ.
        /// </summary>
        public const string FCUPMJ = "FCUPMJ";

        /// <summary>
        /// FCUPMT.
        /// </summary>
        public const string FCUPMT = "FCUPMT";

        /// <summary>
        /// FCJOBN.
        /// </summary>
        public const string FCJOBN = "FCJOBN";

        /// <summary>
        /// FCPID.
        /// </summary>
        public const string FCPID = "FCPID";
    }

    /// <inheritdoc />
    public override string TableName => "F700000";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FCLCTR", "FCLCTR", JdeDataType.String, 6, true, true),
        new JdeField("FCK70FCTR", "FCK70FCTR", JdeDataType.String, 20, true, true),
        new JdeField("FCUSER", "FCUSER", JdeDataType.String, 20),
        new JdeField("FCUPMJ", "FCUPMJ", JdeDataType.Numeric),
        new JdeField("FCUPMT", "FCUPMT", JdeDataType.Numeric),
        new JdeField("FCJOBN", "FCJOBN", JdeDataType.String, 20),
        new JdeField("FCPID", "FCPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F700000_0", "Primary Key on FCLCTR, FCK70FCTR", new[] { "FCLCTR", "FCK70FCTR" }, isUnique: true, isPrimaryKey: true)
    };
}
