using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43100 - .
/// </summary>
public class F43100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IXAN8V.
        /// </summary>
        public const string IXAN8V = "IXAN8V";

        /// <summary>
        /// IXMCU.
        /// </summary>
        public const string IXMCU = "IXMCU";

        /// <summary>
        /// IXUSER.
        /// </summary>
        public const string IXUSER = "IXUSER";

        /// <summary>
        /// IXPID.
        /// </summary>
        public const string IXPID = "IXPID";

        /// <summary>
        /// IXJOBN.
        /// </summary>
        public const string IXJOBN = "IXJOBN";

        /// <summary>
        /// IXUPMT.
        /// </summary>
        public const string IXUPMT = "IXUPMT";

        /// <summary>
        /// IXUPMJ.
        /// </summary>
        public const string IXUPMJ = "IXUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F43100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IXAN8V", "IXAN8V", JdeDataType.Numeric, null, true, true),
        new JdeField("IXMCU", "IXMCU", JdeDataType.String, 24, true, true),
        new JdeField("IXUSER", "IXUSER", JdeDataType.String, 20),
        new JdeField("IXPID", "IXPID", JdeDataType.String, 20),
        new JdeField("IXJOBN", "IXJOBN", JdeDataType.String, 20),
        new JdeField("IXUPMT", "IXUPMT", JdeDataType.Numeric),
        new JdeField("IXUPMJ", "IXUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43100_0", "Primary Key on IXAN8V, IXMCU", new[] { "IXAN8V", "IXMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
