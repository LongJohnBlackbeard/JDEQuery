using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74W200 - .
/// </summary>
public class F74W200 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// K0HDC.
        /// </summary>
        public const string K0HDC = "K0HDC";

        /// <summary>
        /// K0CKC.
        /// </summary>
        public const string K0CKC = "K0CKC";

        /// <summary>
        /// K0RC.
        /// </summary>
        public const string K0RC = "K0RC";

        /// <summary>
        /// K0DOC.
        /// </summary>
        public const string K0DOC = "K0DOC";

        /// <summary>
        /// K0DCT.
        /// </summary>
        public const string K0DCT = "K0DCT";

        /// <summary>
        /// K0KCO.
        /// </summary>
        public const string K0KCO = "K0KCO";

        /// <summary>
        /// K0SFX.
        /// </summary>
        public const string K0SFX = "K0SFX";

        /// <summary>
        /// K0SFXE.
        /// </summary>
        public const string K0SFXE = "K0SFXE";

        /// <summary>
        /// K0N001.
        /// </summary>
        public const string K0N001 = "K0N001";
    }

    /// <inheritdoc />
    public override string TableName => "F74W200";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("K0HDC", "K0HDC", JdeDataType.Numeric, null, true, true),
        new JdeField("K0CKC", "K0CKC", JdeDataType.Numeric, null, true, true),
        new JdeField("K0RC", "K0RC", JdeDataType.String, 2, true, true),
        new JdeField("K0DOC", "K0DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("K0DCT", "K0DCT", JdeDataType.String, 4, true, true),
        new JdeField("K0KCO", "K0KCO", JdeDataType.String, 10, true, true),
        new JdeField("K0SFX", "K0SFX", JdeDataType.String, 6, true, true),
        new JdeField("K0SFXE", "K0SFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("K0N001", "K0N001", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74W200_0", "Primary Key on K0HDC, K0CKC, K0RC, K0DOC, K0DCT, K0KCO, K0SFX, K0SFXE", new[] { "K0HDC", "K0CKC", "K0RC", "K0DOC", "K0DCT", "K0KCO", "K0SFX", "K0SFXE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74W200_4", "Index on K0N001", new[] { "K0N001" })
    };
}
