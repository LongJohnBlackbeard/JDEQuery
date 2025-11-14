using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0114 - .
/// </summary>
public class F0114 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ATAN8.
        /// </summary>
        public const string ATAN8 = "ATAN8";

        /// <summary>
        /// ATLINS.
        /// </summary>
        public const string ATLINS = "ATLINS";

        /// <summary>
        /// ATDS80.
        /// </summary>
        public const string ATDS80 = "ATDS80";

        /// <summary>
        /// ATMSTP.
        /// </summary>
        public const string ATMSTP = "ATMSTP";
    }

    /// <inheritdoc />
    public override string TableName => "F0114";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ATAN8", "ATAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ATLINS", "ATLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("ATDS80", "ATDS80", JdeDataType.String, 160),
        new JdeField("ATMSTP", "ATMSTP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0114_0", "Primary Key on ATAN8, ATLINS", new[] { "ATAN8", "ATLINS" }, isUnique: true, isPrimaryKey: true)
    };
}
