using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069025 - .
/// </summary>
public class F069025 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRFTC.
        /// </summary>
        public const string TRFTC = "TRFTC";

        /// <summary>
        /// TRDCLC.
        /// </summary>
        public const string TRDCLC = "TRDCLC";

        /// <summary>
        /// TRWKSV.
        /// </summary>
        public const string TRWKSV = "TRWKSV";

        /// <summary>
        /// TRDEFR.
        /// </summary>
        public const string TRDEFR = "TRDEFR";
    }

    /// <inheritdoc />
    public override string TableName => "F069025";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRFTC", "TRFTC", JdeDataType.String, 10, true, true),
        new JdeField("TRDCLC", "TRDCLC", JdeDataType.String, 2),
        new JdeField("TRWKSV", "TRWKSV", JdeDataType.String, 2),
        new JdeField("TRDEFR", "TRDEFR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069025_0", "Primary Key on TRFTC", new[] { "TRFTC" }, isUnique: true, isPrimaryKey: true)
    };
}
