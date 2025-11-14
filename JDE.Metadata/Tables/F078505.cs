using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F078505 - .
/// </summary>
public class F078505 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YABXNO.
        /// </summary>
        public const string YABXNO = "YABXNO";

        /// <summary>
        /// YAPDBA.
        /// </summary>
        public const string YAPDBA = "YAPDBA";
    }

    /// <inheritdoc />
    public override string TableName => "F078505";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YABXNO", "YABXNO", JdeDataType.String, 20, true, true),
        new JdeField("YAPDBA", "YAPDBA", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F078505_0", "Primary Key on YABXNO, YAPDBA", new[] { "YABXNO", "YAPDBA" }, isUnique: true, isPrimaryKey: true)
    };
}
