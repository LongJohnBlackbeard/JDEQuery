using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4848 - .
/// </summary>
public class F4848 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SQDTAI.
        /// </summary>
        public const string SQDTAI = "SQDTAI";

        /// <summary>
        /// SQSBSQ.
        /// </summary>
        public const string SQSBSQ = "SQSBSQ";

        /// <summary>
        /// SQDL01.
        /// </summary>
        public const string SQDL01 = "SQDL01";
    }

    /// <inheritdoc />
    public override string TableName => "F4848";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SQDTAI", "SQDTAI", JdeDataType.String, 20, true, true),
        new JdeField("SQSBSQ", "SQSBSQ", JdeDataType.Numeric),
        new JdeField("SQDL01", "SQDL01", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4848_0", "Primary Key on SQDTAI", new[] { "SQDTAI" }, isUnique: true, isPrimaryKey: true)
    };
}
