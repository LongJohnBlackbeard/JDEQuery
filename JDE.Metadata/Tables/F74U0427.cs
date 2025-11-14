using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0427 - .
/// </summary>
public class F74U0427 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LR74ULDTE.
        /// </summary>
        public const string LR74ULDTE = "LR74ULDTE";

        /// <summary>
        /// LR74ULDTEE.
        /// </summary>
        public const string LR74ULDTEE = "LR74ULDTEE";

        /// <summary>
        /// LR74ULTP.
        /// </summary>
        public const string LR74ULTP = "LR74ULTP";

        /// <summary>
        /// LR74ULRTE.
        /// </summary>
        public const string LR74ULRTE = "LR74ULRTE";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0427";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LR74ULDTE", "LR74ULDTE", JdeDataType.Numeric, null, true, true),
        new JdeField("LR74ULDTEE", "LR74ULDTEE", JdeDataType.Numeric, null, true, true),
        new JdeField("LR74ULTP", "LR74ULTP", JdeDataType.String, 8, true, true),
        new JdeField("LR74ULRTE", "LR74ULRTE", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0427_0", "Primary Key on LR74ULDTE, LR74ULDTEE, LR74ULTP", new[] { "LR74ULDTE", "LR74ULDTEE", "LR74ULTP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74U0427_2", "Index on LR74ULDTE, LR74ULTP", new[] { "LR74ULDTE", "LR74ULTP" })
    };
}
