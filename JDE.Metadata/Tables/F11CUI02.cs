using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F11CUI02 - .
/// </summary>
public class F11CUI02 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CBJOBS.
        /// </summary>
        public const string CBJOBS = "CBJOBS";

        /// <summary>
        /// CBICU.
        /// </summary>
        public const string CBICU = "CBICU";

        /// <summary>
        /// CBICUT.
        /// </summary>
        public const string CBICUT = "CBICUT";
    }

    /// <inheritdoc />
    public override string TableName => "F11CUI02";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CBJOBS", "CBJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CBICU", "CBICU", JdeDataType.Numeric, null, true, true),
        new JdeField("CBICUT", "CBICUT", JdeDataType.String, 4, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F11CUI02_0", "Primary Key on CBJOBS, CBICU, CBICUT", new[] { "CBJOBS", "CBICU", "CBICUT" }, isUnique: true, isPrimaryKey: true)
    };
}
