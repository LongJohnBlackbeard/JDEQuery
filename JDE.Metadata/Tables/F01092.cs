using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01092 - .
/// </summary>
public class F01092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A2TYDT.
        /// </summary>
        public const string A2TYDT = "A2TYDT";

        /// <summary>
        /// A2UPDJ.
        /// </summary>
        public const string A2UPDJ = "A2UPDJ";

        /// <summary>
        /// A2AT1.
        /// </summary>
        public const string A2AT1 = "A2AT1";

        /// <summary>
        /// A2AN8.
        /// </summary>
        public const string A2AN8 = "A2AN8";

        /// <summary>
        /// A2KY.
        /// </summary>
        public const string A2KY = "A2KY";

        /// <summary>
        /// A2EFT.
        /// </summary>
        public const string A2EFT = "A2EFT";

        /// <summary>
        /// A2EFTE.
        /// </summary>
        public const string A2EFTE = "A2EFTE";

        /// <summary>
        /// A2AMTU.
        /// </summary>
        public const string A2AMTU = "A2AMTU";

        /// <summary>
        /// A2RMK.
        /// </summary>
        public const string A2RMK = "A2RMK";

        /// <summary>
        /// A2RMK2.
        /// </summary>
        public const string A2RMK2 = "A2RMK2";
    }

    /// <inheritdoc />
    public override string TableName => "F01092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A2TYDT", "A2TYDT", JdeDataType.String, 4, true, true),
        new JdeField("A2UPDJ", "A2UPDJ", JdeDataType.Numeric),
        new JdeField("A2AT1", "A2AT1", JdeDataType.String, 6, true, true),
        new JdeField("A2AN8", "A2AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("A2KY", "A2KY", JdeDataType.String, 20, true, true),
        new JdeField("A2EFT", "A2EFT", JdeDataType.Numeric, null, true, true),
        new JdeField("A2EFTE", "A2EFTE", JdeDataType.Numeric),
        new JdeField("A2AMTU", "A2AMTU", JdeDataType.Numeric),
        new JdeField("A2RMK", "A2RMK", JdeDataType.String, 60),
        new JdeField("A2RMK2", "A2RMK2", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01092_0", "Primary Key on A2TYDT, A2AT1, A2AN8, A2KY, A2EFT", new[] { "A2TYDT", "A2AT1", "A2AN8", "A2KY", "A2EFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01092_2", "Index on A2AN8", new[] { "A2AN8" }),
        new JdeIndex("F01092_3", "Index on A2TYDT, A2AT1, A2AN8, SYS_NC00011$, A2KY", new[] { "A2TYDT", "A2AT1", "A2AN8", "SYS_NC00011$", "A2KY" }),
        new JdeIndex("F01092_4", "Index on A2TYDT, A2KY, SYS_NC00011$, A2AN8", new[] { "A2TYDT", "A2KY", "SYS_NC00011$", "A2AN8" })
    };
}
