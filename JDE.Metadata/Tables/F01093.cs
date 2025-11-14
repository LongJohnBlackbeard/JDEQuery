using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01093 - .
/// </summary>
public class F01093 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A3TYDT.
        /// </summary>
        public const string A3TYDT = "A3TYDT";

        /// <summary>
        /// A3AT1.
        /// </summary>
        public const string A3AT1 = "A3AT1";

        /// <summary>
        /// A3AN8.
        /// </summary>
        public const string A3AN8 = "A3AN8";

        /// <summary>
        /// A3KY.
        /// </summary>
        public const string A3KY = "A3KY";

        /// <summary>
        /// A3EFT.
        /// </summary>
        public const string A3EFT = "A3EFT";

        /// <summary>
        /// A3LIN.
        /// </summary>
        public const string A3LIN = "A3LIN";

        /// <summary>
        /// A3DS80.
        /// </summary>
        public const string A3DS80 = "A3DS80";
    }

    /// <inheritdoc />
    public override string TableName => "F01093";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A3TYDT", "A3TYDT", JdeDataType.String, 4, true, true),
        new JdeField("A3AT1", "A3AT1", JdeDataType.String, 6, true, true),
        new JdeField("A3AN8", "A3AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("A3KY", "A3KY", JdeDataType.String, 20, true, true),
        new JdeField("A3EFT", "A3EFT", JdeDataType.Numeric, null, true, true),
        new JdeField("A3LIN", "A3LIN", JdeDataType.Numeric, null, true, true),
        new JdeField("A3DS80", "A3DS80", JdeDataType.String, 160)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01093_0", "Primary Key on A3TYDT, A3AT1, A3AN8, A3KY, A3EFT, A3LIN", new[] { "A3TYDT", "A3AT1", "A3AN8", "A3KY", "A3EFT", "A3LIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01093_2", "Index on A3AN8", new[] { "A3AN8" })
    };
}
