using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F99101 - .
/// </summary>
public class F99101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DIDTAI.
        /// </summary>
        public const string DIDTAI = "DIDTAI";

        /// <summary>
        /// DIOWDI.
        /// </summary>
        public const string DIOWDI = "DIOWDI";

        /// <summary>
        /// DISY.
        /// </summary>
        public const string DISY = "DISY";

        /// <summary>
        /// DIDSCA.
        /// </summary>
        public const string DIDSCA = "DIDSCA";
    }

    /// <inheritdoc />
    public override string TableName => "F99101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DIDTAI", "DIDTAI", JdeDataType.String, 20, true, true),
        new JdeField("DIOWDI", "DIOWDI", JdeDataType.String, 80),
        new JdeField("DISY", "DISY", JdeDataType.String, 8),
        new JdeField("DIDSCA", "DIDSCA", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F99101_0", "Primary Key on DIDTAI", new[] { "DIDTAI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F99101_3", "Index on DIOWDI", new[] { "DIOWDI" })
    };
}
