using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4304 - .
/// </summary>
public class F4304 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCLOGH.
        /// </summary>
        public const string PCLOGH = "PCLOGH";

        /// <summary>
        /// PCLGSQ.
        /// </summary>
        public const string PCLGSQ = "PCLGSQ";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCUPMT.
        /// </summary>
        public const string PCUPMT = "PCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4304";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCLOGH", "PCLOGH", JdeDataType.String, 4, true, true),
        new JdeField("PCLGSQ", "PCLGSQ", JdeDataType.Numeric),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCUPMT", "PCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4304_0", "Primary Key on PCLOGH", new[] { "PCLOGH" }, isUnique: true, isPrimaryKey: true)
    };
}
