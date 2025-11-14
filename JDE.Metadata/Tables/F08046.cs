using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08046 - .
/// </summary>
public class F08046 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HZTCN.
        /// </summary>
        public const string HZTCN = "HZTCN";

        /// <summary>
        /// HZTRS.
        /// </summary>
        public const string HZTRS = "HZTRS";

        /// <summary>
        /// HZTCH1.
        /// </summary>
        public const string HZTCH1 = "HZTCH1";

        /// <summary>
        /// HZTCH2.
        /// </summary>
        public const string HZTCH2 = "HZTCH2";

        /// <summary>
        /// HZTCLV.
        /// </summary>
        public const string HZTCLV = "HZTCLV";
    }

    /// <inheritdoc />
    public override string TableName => "F08046";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HZTCN", "HZTCN", JdeDataType.Numeric, null, true, true),
        new JdeField("HZTRS", "HZTRS", JdeDataType.String, 6, true, true),
        new JdeField("HZTCH1", "HZTCH1", JdeDataType.String, 14),
        new JdeField("HZTCH2", "HZTCH2", JdeDataType.String, 14),
        new JdeField("HZTCLV", "HZTCLV", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08046_0", "Primary Key on HZTCN, HZTRS, HZTCLV", new[] { "HZTCN", "HZTRS", "HZTCLV" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08046_2", "Index on HZTCN, HZTCLV, HZTRS", new[] { "HZTCN", "HZTCLV", "HZTRS" })
    };
}
