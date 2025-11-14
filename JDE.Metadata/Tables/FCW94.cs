using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW94 - .
/// </summary>
public class FCW94 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WKC9ITM.
        /// </summary>
        public const string WKC9ITM = "WKC9ITM";

        /// <summary>
        /// WKUSER.
        /// </summary>
        public const string WKUSER = "WKUSER";

        /// <summary>
        /// WKPID.
        /// </summary>
        public const string WKPID = "WKPID";
    }

    /// <inheritdoc />
    public override string TableName => "FCW94";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WKC9ITM", "WKC9ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WKUSER", "WKUSER", JdeDataType.String, 20),
        new JdeField("WKPID", "WKPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW94_0", "Primary Key on WKC9ITM", new[] { "WKC9ITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW94_2", "Index on WKUSER, WKPID", new[] { "WKUSER", "WKPID" })
    };
}
