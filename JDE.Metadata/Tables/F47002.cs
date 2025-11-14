using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47002 - .
/// </summary>
public class F47002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SVTYTN.
        /// </summary>
        public const string SVTYTN = "SVTYTN";

        /// <summary>
        /// SVDRIN.
        /// </summary>
        public const string SVDRIN = "SVDRIN";

        /// <summary>
        /// SVEDTY.
        /// </summary>
        public const string SVEDTY = "SVEDTY";

        /// <summary>
        /// SVFILE.
        /// </summary>
        public const string SVFILE = "SVFILE";

        /// <summary>
        /// SVNFLF.
        /// </summary>
        public const string SVNFLF = "SVNFLF";
    }

    /// <inheritdoc />
    public override string TableName => "F47002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SVTYTN", "SVTYTN", JdeDataType.String, 16, true, true),
        new JdeField("SVDRIN", "SVDRIN", JdeDataType.String, 2, true, true),
        new JdeField("SVEDTY", "SVEDTY", JdeDataType.String, 2, true, true),
        new JdeField("SVFILE", "SVFILE", JdeDataType.String, 20),
        new JdeField("SVNFLF", "SVNFLF", JdeDataType.String, 500)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47002_0", "Primary Key on SVTYTN, SVDRIN, SVEDTY", new[] { "SVTYTN", "SVDRIN", "SVEDTY" }, isUnique: true, isPrimaryKey: true)
    };
}
