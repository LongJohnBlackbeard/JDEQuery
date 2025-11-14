using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00092 - .
/// </summary>
public class F00092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T3SDB.
        /// </summary>
        public const string T3SDB = "T3SDB";

        /// <summary>
        /// T3TYDT.
        /// </summary>
        public const string T3TYDT = "T3TYDT";

        /// <summary>
        /// T3SBA1.
        /// </summary>
        public const string T3SBA1 = "T3SBA1";

        /// <summary>
        /// T3KCO.
        /// </summary>
        public const string T3KCO = "T3KCO";

        /// <summary>
        /// T3SBA2.
        /// </summary>
        public const string T3SBA2 = "T3SBA2";

        /// <summary>
        /// T3MCU.
        /// </summary>
        public const string T3MCU = "T3MCU";

        /// <summary>
        /// T3SBN1.
        /// </summary>
        public const string T3SBN1 = "T3SBN1";

        /// <summary>
        /// T3SBN2.
        /// </summary>
        public const string T3SBN2 = "T3SBN2";

        /// <summary>
        /// T3UKID.
        /// </summary>
        public const string T3UKID = "T3UKID";

        /// <summary>
        /// T3UORG.
        /// </summary>
        public const string T3UORG = "T3UORG";

        /// <summary>
        /// T3EFT.
        /// </summary>
        public const string T3EFT = "T3EFT";

        /// <summary>
        /// T3RORN.
        /// </summary>
        public const string T3RORN = "T3RORN";

        /// <summary>
        /// T3RCTO.
        /// </summary>
        public const string T3RCTO = "T3RCTO";

        /// <summary>
        /// T3KY.
        /// </summary>
        public const string T3KY = "T3KY";

        /// <summary>
        /// T3EFTE.
        /// </summary>
        public const string T3EFTE = "T3EFTE";

        /// <summary>
        /// T3AMTU.
        /// </summary>
        public const string T3AMTU = "T3AMTU";

        /// <summary>
        /// T3AMTV.
        /// </summary>
        public const string T3AMTV = "T3AMTV";

        /// <summary>
        /// T3RMK.
        /// </summary>
        public const string T3RMK = "T3RMK";

        /// <summary>
        /// T3RMK2.
        /// </summary>
        public const string T3RMK2 = "T3RMK2";

        /// <summary>
        /// T3UPDJ.
        /// </summary>
        public const string T3UPDJ = "T3UPDJ";

        /// <summary>
        /// T3DYUD.
        /// </summary>
        public const string T3DYUD = "T3DYUD";

        /// <summary>
        /// T3AN8.
        /// </summary>
        public const string T3AN8 = "T3AN8";

        /// <summary>
        /// T3KYWW.
        /// </summary>
        public const string T3KYWW = "T3KYWW";

        /// <summary>
        /// T3USER.
        /// </summary>
        public const string T3USER = "T3USER";

        /// <summary>
        /// T3PID.
        /// </summary>
        public const string T3PID = "T3PID";

        /// <summary>
        /// T3JOBN.
        /// </summary>
        public const string T3JOBN = "T3JOBN";

        /// <summary>
        /// T3UPMJ.
        /// </summary>
        public const string T3UPMJ = "T3UPMJ";

        /// <summary>
        /// T3TDAY.
        /// </summary>
        public const string T3TDAY = "T3TDAY";

        /// <summary>
        /// T3RMK3.
        /// </summary>
        public const string T3RMK3 = "T3RMK3";

        /// <summary>
        /// T3UPTM.
        /// </summary>
        public const string T3UPTM = "T3UPTM";
    }

    /// <inheritdoc />
    public override string TableName => "F00092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T3SDB", "T3SDB", JdeDataType.String, 8, true, true),
        new JdeField("T3TYDT", "T3TYDT", JdeDataType.String, 4, true, true),
        new JdeField("T3SBA1", "T3SBA1", JdeDataType.String, 20, true, true),
        new JdeField("T3KCO", "T3KCO", JdeDataType.String, 10, true, true),
        new JdeField("T3SBA2", "T3SBA2", JdeDataType.String, 20, true, true),
        new JdeField("T3MCU", "T3MCU", JdeDataType.String, 24, true, true),
        new JdeField("T3SBN1", "T3SBN1", JdeDataType.Numeric, null, true, true),
        new JdeField("T3SBN2", "T3SBN2", JdeDataType.Numeric, null, true, true),
        new JdeField("T3UKID", "T3UKID", JdeDataType.Numeric, null, true, true),
        new JdeField("T3UORG", "T3UORG", JdeDataType.Numeric),
        new JdeField("T3EFT", "T3EFT", JdeDataType.Numeric),
        new JdeField("T3RORN", "T3RORN", JdeDataType.String, 16),
        new JdeField("T3RCTO", "T3RCTO", JdeDataType.String, 4),
        new JdeField("T3KY", "T3KY", JdeDataType.String, 20),
        new JdeField("T3EFTE", "T3EFTE", JdeDataType.Numeric),
        new JdeField("T3AMTU", "T3AMTU", JdeDataType.Numeric),
        new JdeField("T3AMTV", "T3AMTV", JdeDataType.Numeric),
        new JdeField("T3RMK", "T3RMK", JdeDataType.String, 60),
        new JdeField("T3RMK2", "T3RMK2", JdeDataType.String, 60),
        new JdeField("T3UPDJ", "T3UPDJ", JdeDataType.Numeric),
        new JdeField("T3DYUD", "T3DYUD", JdeDataType.Numeric),
        new JdeField("T3AN8", "T3AN8", JdeDataType.Numeric),
        new JdeField("T3KYWW", "T3KYWW", JdeDataType.String, 20),
        new JdeField("T3USER", "T3USER", JdeDataType.String, 20),
        new JdeField("T3PID", "T3PID", JdeDataType.String, 20),
        new JdeField("T3JOBN", "T3JOBN", JdeDataType.String, 20),
        new JdeField("T3UPMJ", "T3UPMJ", JdeDataType.Numeric),
        new JdeField("T3TDAY", "T3TDAY", JdeDataType.Numeric),
        new JdeField("T3RMK3", "T3RMK3", JdeDataType.String, 100),
        new JdeField("T3UPTM", "T3UPTM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00092_0", "Primary Key on T3SDB, T3TYDT, T3SBN1, T3SBN2, T3SBA2, T3SBA1, T3MCU, T3KCO, T3UKID", new[] { "T3SDB", "T3TYDT", "T3SBN1", "T3SBN2", "T3SBA2", "T3SBA1", "T3MCU", "T3KCO", "T3UKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F00092_3", "Index on T3SDB, T3TYDT, T3SBN1, T3SBN2, T3SBA1, T3SBA2, T3KCO, T3MCU", new[] { "T3SDB", "T3TYDT", "T3SBN1", "T3SBN2", "T3SBA1", "T3SBA2", "T3KCO", "T3MCU" }),
        new JdeIndex("F00092_4", "Index on T3SDB, T3SBN1, T3SBN2, T3SBA1, T3SBA2, T3KCO, T3MCU", new[] { "T3SDB", "T3SBN1", "T3SBN2", "T3SBA1", "T3SBA2", "T3KCO", "T3MCU" }),
        new JdeIndex("F00092_5", "Index on SYS_NC00031$", new[] { "SYS_NC00031$" }),
        new JdeIndex("F00092_8", "Index on T3SDB, T3TYDT, T3SBN1, SYS_NC00032$, SYS_NC00031$", new[] { "T3SDB", "T3TYDT", "T3SBN1", "SYS_NC00032$", "SYS_NC00031$" }),
        new JdeIndex("F00092_9", "Index on T3SDB, T3TYDT, T3KCO, T3SBN1, T3KY", new[] { "T3SDB", "T3TYDT", "T3KCO", "T3SBN1", "T3KY" })
    };
}
