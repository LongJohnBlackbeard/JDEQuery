using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F99102D - .
/// </summary>
public class F99102D : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DHSY.
        /// </summary>
        public const string DHSY = "DHSY";

        /// <summary>
        /// DHHFNAME.
        /// </summary>
        public const string DHHFNAME = "DHHFNAME";

        /// <summary>
        /// DHWTXT.
        /// </summary>
        public const string DHWTXT = "DHWTXT";
    }

    /// <inheritdoc />
    public override string TableName => "F99102D";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DHSY", "DHSY", JdeDataType.String, 8, true, true),
        new JdeField("DHHFNAME", "DHHFNAME", JdeDataType.String, 20),
        new JdeField("DHWTXT", "DHWTXT", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F99102D_0", "Primary Key on DHSY", new[] { "DHSY" }, isUnique: true, isPrimaryKey: true)
    };
}
