using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F06914 - .
/// </summary>
public class F06914 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JGCO.
        /// </summary>
        public const string JGCO = "JGCO";

        /// <summary>
        /// JGMCU.
        /// </summary>
        public const string JGMCU = "JGMCU";

        /// <summary>
        /// JGOBJB.
        /// </summary>
        public const string JGOBJB = "JGOBJB";

        /// <summary>
        /// JGOBJE.
        /// </summary>
        public const string JGOBJE = "JGOBJE";

        /// <summary>
        /// JGGLS.
        /// </summary>
        public const string JGGLS = "JGGLS";
    }

    /// <inheritdoc />
    public override string TableName => "F06914";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JGCO", "JGCO", JdeDataType.String, 10, true, true),
        new JdeField("JGMCU", "JGMCU", JdeDataType.String, 24, true, true),
        new JdeField("JGOBJB", "JGOBJB", JdeDataType.String, 12, true, true),
        new JdeField("JGOBJE", "JGOBJE", JdeDataType.String, 12),
        new JdeField("JGGLS", "JGGLS", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F06914_0", "Primary Key on JGCO, JGMCU, JGOBJB", new[] { "JGCO", "JGMCU", "JGOBJB" }, isUnique: true, isPrimaryKey: true)
    };
}
