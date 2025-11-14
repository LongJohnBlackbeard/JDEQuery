using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75010 - .
/// </summary>
public class F75010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// J0JPBK.
        /// </summary>
        public const string J0JPBK = "J0JPBK";

        /// <summary>
        /// J0JPBH.
        /// </summary>
        public const string J0JPBH = "J0JPBH";

        /// <summary>
        /// J0ALP1.
        /// </summary>
        public const string J0ALP1 = "J0ALP1";

        /// <summary>
        /// J0ALPH.
        /// </summary>
        public const string J0ALPH = "J0ALPH";
    }

    /// <inheritdoc />
    public override string TableName => "F75010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("J0JPBK", "J0JPBK", JdeDataType.String, 8, true, true),
        new JdeField("J0JPBH", "J0JPBH", JdeDataType.String, 6, true, true),
        new JdeField("J0ALP1", "J0ALP1", JdeDataType.String, 80),
        new JdeField("J0ALPH", "J0ALPH", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75010_0", "Primary Key on J0JPBK, J0JPBH", new[] { "J0JPBK", "J0JPBH" }, isUnique: true, isPrimaryKey: true)
    };
}
