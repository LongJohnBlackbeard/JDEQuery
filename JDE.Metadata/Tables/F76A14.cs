using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A14 - .
/// </summary>
public class F76A14 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TPATXC.
        /// </summary>
        public const string TPATXC = "TPATXC";

        /// <summary>
        /// TPATXP.
        /// </summary>
        public const string TPATXP = "TPATXP";
    }

    /// <inheritdoc />
    public override string TableName => "F76A14";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TPATXC", "TPATXC", JdeDataType.String, 20, true, true),
        new JdeField("TPATXP", "TPATXP", JdeDataType.String, 20, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A14_0", "Primary Key on TPATXC, TPATXP", new[] { "TPATXC", "TPATXP" }, isUnique: true, isPrimaryKey: true)
    };
}
