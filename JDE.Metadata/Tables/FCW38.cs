using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW38 - .
/// </summary>
public class FCW38 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRCRCD.
        /// </summary>
        public const string TRCRCD = "TRCRCD";

        /// <summary>
        /// TRCRDC.
        /// </summary>
        public const string TRCRDC = "TRCRDC";

        /// <summary>
        /// TREFT.
        /// </summary>
        public const string TREFT = "TREFT";

        /// <summary>
        /// TRCRR.
        /// </summary>
        public const string TRCRR = "TRCRR";

        /// <summary>
        /// TRCRRD.
        /// </summary>
        public const string TRCRRD = "TRCRRD";
    }

    /// <inheritdoc />
    public override string TableName => "FCW38";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRCRCD", "TRCRCD", JdeDataType.String, 6, true, true),
        new JdeField("TRCRDC", "TRCRDC", JdeDataType.String, 6, true, true),
        new JdeField("TREFT", "TREFT", JdeDataType.Numeric, null, true, true),
        new JdeField("TRCRR", "TRCRR", JdeDataType.Numeric),
        new JdeField("TRCRRD", "TRCRRD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW38_0", "Primary Key on TRCRCD, TREFT, TRCRDC", new[] { "TRCRCD", "TREFT", "TRCRDC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FCW38_2", "Index on TRCRCD, TRCRDC, TREFT", new[] { "TRCRCD", "TRCRDC", "TREFT" }),
        new JdeIndex("FCW38_3", "Index on TRCRCD, TRCRDC, SYS_NC00006$", new[] { "TRCRCD", "TRCRDC", "SYS_NC00006$" })
    };
}
