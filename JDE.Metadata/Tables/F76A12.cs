using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A12 - .
/// </summary>
public class F76A12 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TMATXC.
        /// </summary>
        public const string TMATXC = "TMATXC";

        /// <summary>
        /// TMEFTJ.
        /// </summary>
        public const string TMEFTJ = "TMEFTJ";

        /// <summary>
        /// TMEFDJ.
        /// </summary>
        public const string TMEFDJ = "TMEFDJ";

        /// <summary>
        /// TMAMIA.
        /// </summary>
        public const string TMAMIA = "TMAMIA";
    }

    /// <inheritdoc />
    public override string TableName => "F76A12";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TMATXC", "TMATXC", JdeDataType.String, 20, true, true),
        new JdeField("TMEFTJ", "TMEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TMEFDJ", "TMEFDJ", JdeDataType.Numeric),
        new JdeField("TMAMIA", "TMAMIA", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A12_0", "Primary Key on TMATXC, TMEFTJ", new[] { "TMATXC", "TMEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
