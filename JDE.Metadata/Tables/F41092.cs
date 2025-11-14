using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41092 - .
/// </summary>
public class F41092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T2DSDB.
        /// </summary>
        public const string T2DSDB = "T2DSDB";

        /// <summary>
        /// T2TYDB.
        /// </summary>
        public const string T2TYDB = "T2TYDB";

        /// <summary>
        /// T2ITM.
        /// </summary>
        public const string T2ITM = "T2ITM";

        /// <summary>
        /// T2MCU.
        /// </summary>
        public const string T2MCU = "T2MCU";

        /// <summary>
        /// T2KY.
        /// </summary>
        public const string T2KY = "T2KY";

        /// <summary>
        /// T2EFT.
        /// </summary>
        public const string T2EFT = "T2EFT";

        /// <summary>
        /// T2EFTE.
        /// </summary>
        public const string T2EFTE = "T2EFTE";

        /// <summary>
        /// T2AMTU.
        /// </summary>
        public const string T2AMTU = "T2AMTU";

        /// <summary>
        /// T2RMK.
        /// </summary>
        public const string T2RMK = "T2RMK";

        /// <summary>
        /// T2RMK2.
        /// </summary>
        public const string T2RMK2 = "T2RMK2";

        /// <summary>
        /// T2UPDJ.
        /// </summary>
        public const string T2UPDJ = "T2UPDJ";

        /// <summary>
        /// T2USER.
        /// </summary>
        public const string T2USER = "T2USER";

        /// <summary>
        /// T2PID.
        /// </summary>
        public const string T2PID = "T2PID";

        /// <summary>
        /// T2JOBN.
        /// </summary>
        public const string T2JOBN = "T2JOBN";

        /// <summary>
        /// T2UPMJ.
        /// </summary>
        public const string T2UPMJ = "T2UPMJ";

        /// <summary>
        /// T2TDAY.
        /// </summary>
        public const string T2TDAY = "T2TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F41092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T2DSDB", "T2DSDB", JdeDataType.String, 2, true, true),
        new JdeField("T2TYDB", "T2TYDB", JdeDataType.String, 4, true, true),
        new JdeField("T2ITM", "T2ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("T2MCU", "T2MCU", JdeDataType.String, 24, true, true),
        new JdeField("T2KY", "T2KY", JdeDataType.String, 20, true, true),
        new JdeField("T2EFT", "T2EFT", JdeDataType.Numeric, null, true, true),
        new JdeField("T2EFTE", "T2EFTE", JdeDataType.Numeric),
        new JdeField("T2AMTU", "T2AMTU", JdeDataType.Numeric),
        new JdeField("T2RMK", "T2RMK", JdeDataType.String, 60),
        new JdeField("T2RMK2", "T2RMK2", JdeDataType.String, 60),
        new JdeField("T2UPDJ", "T2UPDJ", JdeDataType.Numeric),
        new JdeField("T2USER", "T2USER", JdeDataType.String, 20),
        new JdeField("T2PID", "T2PID", JdeDataType.String, 20),
        new JdeField("T2JOBN", "T2JOBN", JdeDataType.String, 20),
        new JdeField("T2UPMJ", "T2UPMJ", JdeDataType.Numeric),
        new JdeField("T2TDAY", "T2TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41092_0", "Primary Key on T2DSDB, T2TYDB, T2ITM, T2MCU, T2KY, T2EFT", new[] { "T2DSDB", "T2TYDB", "T2ITM", "T2MCU", "T2KY", "T2EFT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F41092_2", "Index on T2DSDB, T2TYDB, T2MCU, T2KY, T2EFT, T2ITM", new[] { "T2DSDB", "T2TYDB", "T2MCU", "T2KY", "T2EFT", "T2ITM" }),
        new JdeIndex("F41092_3", "Index on T2DSDB, T2ITM, T2MCU, T2TYDB, T2KY, T2EFT", new[] { "T2DSDB", "T2ITM", "T2MCU", "T2TYDB", "T2KY", "T2EFT" }),
        new JdeIndex("F41092_4", "Index on T2DSDB, T2TYDB, T2ITM, T2MCU, T2EFT, T2KY", new[] { "T2DSDB", "T2TYDB", "T2ITM", "T2MCU", "T2EFT", "T2KY" })
    };
}
