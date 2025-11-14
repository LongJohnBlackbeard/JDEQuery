using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08005 - .
/// </summary>
public class F08005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JVHMCU.
        /// </summary>
        public const string JVHMCU = "JVHMCU";

        /// <summary>
        /// JVJBCD.
        /// </summary>
        public const string JVJBCD = "JVJBCD";

        /// <summary>
        /// JVJBST.
        /// </summary>
        public const string JVJBST = "JVJBST";

        /// <summary>
        /// JVDIVC.
        /// </summary>
        public const string JVDIVC = "JVDIVC";

        /// <summary>
        /// JVUN.
        /// </summary>
        public const string JVUN = "JVUN";

        /// <summary>
        /// JVWCMP.
        /// </summary>
        public const string JVWCMP = "JVWCMP";

        /// <summary>
        /// JVWET.
        /// </summary>
        public const string JVWET = "JVWET";
    }

    /// <inheritdoc />
    public override string TableName => "F08005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JVHMCU", "JVHMCU", JdeDataType.String, 24, true, true),
        new JdeField("JVJBCD", "JVJBCD", JdeDataType.String, 12, true, true),
        new JdeField("JVJBST", "JVJBST", JdeDataType.String, 8, true, true),
        new JdeField("JVDIVC", "JVDIVC", JdeDataType.String, 12),
        new JdeField("JVUN", "JVUN", JdeDataType.String, 12),
        new JdeField("JVWCMP", "JVWCMP", JdeDataType.String, 8),
        new JdeField("JVWET", "JVWET", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08005_0", "Primary Key on JVHMCU, JVJBCD, JVJBST", new[] { "JVHMCU", "JVJBCD", "JVJBST" }, isUnique: true, isPrimaryKey: true)
    };
}
