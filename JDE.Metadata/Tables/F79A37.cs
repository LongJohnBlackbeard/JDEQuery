using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A37 - .
/// </summary>
public class F79A37 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UC79AUMC.
        /// </summary>
        public const string UC79AUMC = "UC79AUMC";

        /// <summary>
        /// UC79AUMCD.
        /// </summary>
        public const string UC79AUMCD = "UC79AUMCD";

        /// <summary>
        /// UC79ASUUM.
        /// </summary>
        public const string UC79ASUUM = "UC79ASUUM";

        /// <summary>
        /// UCPID.
        /// </summary>
        public const string UCPID = "UCPID";

        /// <summary>
        /// UCUSER.
        /// </summary>
        public const string UCUSER = "UCUSER";

        /// <summary>
        /// UCJOBN.
        /// </summary>
        public const string UCJOBN = "UCJOBN";

        /// <summary>
        /// UCUPMJ.
        /// </summary>
        public const string UCUPMJ = "UCUPMJ";

        /// <summary>
        /// UCTDAY.
        /// </summary>
        public const string UCTDAY = "UCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A37";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UC79AUMC", "UC79AUMC", JdeDataType.String, 50, true, true),
        new JdeField("UC79AUMCD", "UC79AUMCD", JdeDataType.String, 200),
        new JdeField("UC79ASUUM", "UC79ASUUM", JdeDataType.String, 4),
        new JdeField("UCPID", "UCPID", JdeDataType.String, 20),
        new JdeField("UCUSER", "UCUSER", JdeDataType.String, 20),
        new JdeField("UCJOBN", "UCJOBN", JdeDataType.String, 20),
        new JdeField("UCUPMJ", "UCUPMJ", JdeDataType.Numeric),
        new JdeField("UCTDAY", "UCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A37_0", "Primary Key on UC79AUMC", new[] { "UC79AUMC" }, isUnique: true, isPrimaryKey: true)
    };
}
