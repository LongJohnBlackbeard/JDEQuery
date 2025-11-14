using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW54 - .
/// </summary>
public class FCW54 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WBJOBS.
        /// </summary>
        public const string WBJOBS = "WBJOBS";

        /// <summary>
        /// WBUSER.
        /// </summary>
        public const string WBUSER = "WBUSER";

        /// <summary>
        /// WBITM.
        /// </summary>
        public const string WBITM = "WBITM";

        /// <summary>
        /// WBQTFN.
        /// </summary>
        public const string WBQTFN = "WBQTFN";
    }

    /// <inheritdoc />
    public override string TableName => "FCW54";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WBJOBS", "WBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WBUSER", "WBUSER", JdeDataType.String, 20, true, true),
        new JdeField("WBITM", "WBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WBQTFN", "WBQTFN", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW54_0", "Primary Key on WBJOBS, WBUSER, WBITM", new[] { "WBJOBS", "WBUSER", "WBITM" }, isUnique: true, isPrimaryKey: true)
    };
}
