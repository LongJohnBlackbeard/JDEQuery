using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1390 - .
/// </summary>
public class F1390 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FVERC.
        /// </summary>
        public const string FVERC = "FVERC";

        /// <summary>
        /// FVBFRE.
        /// </summary>
        public const string FVBFRE = "FVBFRE";

        /// <summary>
        /// FVBLL.
        /// </summary>
        public const string FVBLL = "FVBLL";

        /// <summary>
        /// FVERCW.
        /// </summary>
        public const string FVERCW = "FVERCW";

        /// <summary>
        /// FVERCD.
        /// </summary>
        public const string FVERCD = "FVERCD";

        /// <summary>
        /// FVERCH.
        /// </summary>
        public const string FVERCH = "FVERCH";
    }

    /// <inheritdoc />
    public override string TableName => "F1390";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FVERC", "FVERC", JdeDataType.String, 4, true, true),
        new JdeField("FVBFRE", "FVBFRE", JdeDataType.String, 2),
        new JdeField("FVBLL", "FVBLL", JdeDataType.String, 2),
        new JdeField("FVERCW", "FVERCW", JdeDataType.String, 4),
        new JdeField("FVERCD", "FVERCD", JdeDataType.String, 4),
        new JdeField("FVERCH", "FVERCH", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1390_0", "Primary Key on FVERC", new[] { "FVERC" }, isUnique: true, isPrimaryKey: true)
    };
}
