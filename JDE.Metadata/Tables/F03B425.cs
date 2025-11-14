using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F03B425 - .
/// </summary>
public class F03B425 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKCO.
        /// </summary>
        public const string TKCO = "TKCO";

        /// <summary>
        /// TKCALFD.
        /// </summary>
        public const string TKCALFD = "TKCALFD";

        /// <summary>
        /// TKCOMWD.
        /// </summary>
        public const string TKCOMWD = "TKCOMWD";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";
    }

    /// <inheritdoc />
    public override string TableName => "F03B425";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKCO", "TKCO", JdeDataType.String, 10, true, true),
        new JdeField("TKCALFD", "TKCALFD", JdeDataType.String, 2),
        new JdeField("TKCOMWD", "TKCOMWD", JdeDataType.String, 2),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F03B425_0", "Primary Key on TKCO", new[] { "TKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
