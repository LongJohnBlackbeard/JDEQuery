using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0011W - .
/// </summary>
public class F0011W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ICICUT.
        /// </summary>
        public const string ICICUT = "ICICUT";

        /// <summary>
        /// ICICU.
        /// </summary>
        public const string ICICU = "ICICU";

        /// <summary>
        /// ICIST.
        /// </summary>
        public const string ICIST = "ICIST";

        /// <summary>
        /// ICDICJ.
        /// </summary>
        public const string ICDICJ = "ICDICJ";

        /// <summary>
        /// ICDS40.
        /// </summary>
        public const string ICDS40 = "ICDS40";
    }

    /// <inheritdoc />
    public override string TableName => "F0011W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ICICUT", "ICICUT", JdeDataType.String, 4, true, true),
        new JdeField("ICICU", "ICICU", JdeDataType.Numeric, null, true, true),
        new JdeField("ICIST", "ICIST", JdeDataType.String, 2),
        new JdeField("ICDICJ", "ICDICJ", JdeDataType.Numeric),
        new JdeField("ICDS40", "ICDS40", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0011W_0", "Primary Key on ICICUT, ICICU", new[] { "ICICUT", "ICICU" }, isUnique: true, isPrimaryKey: true)
    };
}
