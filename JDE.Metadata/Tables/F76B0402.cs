using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0402 - .
/// </summary>
public class F76B0402 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TPAA.
        /// </summary>
        public const string TPAA = "TPAA";

        /// <summary>
        /// TPAA1.
        /// </summary>
        public const string TPAA1 = "TPAA1";

        /// <summary>
        /// TPBRALQ.
        /// </summary>
        public const string TPBRALQ = "TPBRALQ";

        /// <summary>
        /// TPAA2.
        /// </summary>
        public const string TPAA2 = "TPAA2";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0402";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TPAA", "TPAA", JdeDataType.Numeric, null, true, true),
        new JdeField("TPAA1", "TPAA1", JdeDataType.Numeric, null, true, true),
        new JdeField("TPBRALQ", "TPBRALQ", JdeDataType.Numeric),
        new JdeField("TPAA2", "TPAA2", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0402_0", "Primary Key on TPAA, TPAA1", new[] { "TPAA", "TPAA1" }, isUnique: true, isPrimaryKey: true)
    };
}
