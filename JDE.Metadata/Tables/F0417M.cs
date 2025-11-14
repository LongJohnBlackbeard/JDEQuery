using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0417M - .
/// </summary>
public class F0417M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KBPYIN.
        /// </summary>
        public const string KBPYIN = "KBPYIN";

        /// <summary>
        /// KBGLBA.
        /// </summary>
        public const string KBGLBA = "KBGLBA";

        /// <summary>
        /// KBBKTP.
        /// </summary>
        public const string KBBKTP = "KBBKTP";
    }

    /// <inheritdoc />
    public override string TableName => "F0417M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KBPYIN", "KBPYIN", JdeDataType.String, 2, true, true),
        new JdeField("KBGLBA", "KBGLBA", JdeDataType.String, 16, true, true),
        new JdeField("KBBKTP", "KBBKTP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0417M_0", "Primary Key on KBPYIN, KBGLBA", new[] { "KBPYIN", "KBGLBA" }, isUnique: true, isPrimaryKey: true)
    };
}
