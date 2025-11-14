using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0490 - .
/// </summary>
public class F0490 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GCDANM.
        /// </summary>
        public const string GCDANM = "GCDANM";

        /// <summary>
        /// GCUPMJ.
        /// </summary>
        public const string GCUPMJ = "GCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F0490";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GCDANM", "GCDANM", JdeDataType.String, 20, true, true),
        new JdeField("GCUPMJ", "GCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0490_0", "Primary Key on GCDANM", new[] { "GCDANM" }, isUnique: true, isPrimaryKey: true)
    };
}
