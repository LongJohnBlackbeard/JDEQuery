using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F083302 - .
/// </summary>
public class F083302 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HTHDCD.
        /// </summary>
        public const string HTHDCD = "HTHDCD";

        /// <summary>
        /// HTDESC.
        /// </summary>
        public const string HTDESC = "HTDESC";

        /// <summary>
        /// HTHDTY.
        /// </summary>
        public const string HTHDTY = "HTHDTY";

        /// <summary>
        /// HTUSER.
        /// </summary>
        public const string HTUSER = "HTUSER";

        /// <summary>
        /// HTPID.
        /// </summary>
        public const string HTPID = "HTPID";

        /// <summary>
        /// HTUPMJ.
        /// </summary>
        public const string HTUPMJ = "HTUPMJ";

        /// <summary>
        /// HTJOBN.
        /// </summary>
        public const string HTJOBN = "HTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F083302";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HTHDCD", "HTHDCD", JdeDataType.String, 20, true, true),
        new JdeField("HTDESC", "HTDESC", JdeDataType.String, 60),
        new JdeField("HTHDTY", "HTHDTY", JdeDataType.String, 2, true, true),
        new JdeField("HTUSER", "HTUSER", JdeDataType.String, 20),
        new JdeField("HTPID", "HTPID", JdeDataType.String, 20),
        new JdeField("HTUPMJ", "HTUPMJ", JdeDataType.Numeric),
        new JdeField("HTJOBN", "HTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F083302_0", "Primary Key on HTHDCD, HTHDTY", new[] { "HTHDCD", "HTHDTY" }, isUnique: true, isPrimaryKey: true)
    };
}
