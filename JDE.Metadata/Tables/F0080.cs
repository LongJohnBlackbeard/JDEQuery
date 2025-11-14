using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0080 - .
/// </summary>
public class F0080 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S2FILE.
        /// </summary>
        public const string S2FILE = "S2FILE";

        /// <summary>
        /// S2USER.
        /// </summary>
        public const string S2USER = "S2USER";

        /// <summary>
        /// S2KRS.
        /// </summary>
        public const string S2KRS = "S2KRS";

        /// <summary>
        /// S2TYDP.
        /// </summary>
        public const string S2TYDP = "S2TYDP";

        /// <summary>
        /// S2USAL.
        /// </summary>
        public const string S2USAL = "S2USAL";
    }

    /// <inheritdoc />
    public override string TableName => "F0080";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S2FILE", "S2FILE", JdeDataType.String, 20, true, true),
        new JdeField("S2USER", "S2USER", JdeDataType.String, 20, true, true),
        new JdeField("S2KRS", "S2KRS", JdeDataType.String, 6, true, true),
        new JdeField("S2TYDP", "S2TYDP", JdeDataType.String, 4, true, true),
        new JdeField("S2USAL", "S2USAL", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0080_0", "Primary Key on S2FILE, S2USER, S2KRS, S2TYDP", new[] { "S2FILE", "S2USER", "S2KRS", "S2TYDP" }, isUnique: true, isPrimaryKey: true)
    };
}
