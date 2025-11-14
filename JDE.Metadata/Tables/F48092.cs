using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48092 - .
/// </summary>
public class F48092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W8WODB.
        /// </summary>
        public const string W8WODB = "W8WODB";

        /// <summary>
        /// W8TYWO.
        /// </summary>
        public const string W8TYWO = "W8TYWO";

        /// <summary>
        /// W8DOCO.
        /// </summary>
        public const string W8DOCO = "W8DOCO";

        /// <summary>
        /// W8KY.
        /// </summary>
        public const string W8KY = "W8KY";

        /// <summary>
        /// W8UORG.
        /// </summary>
        public const string W8UORG = "W8UORG";

        /// <summary>
        /// W8AMTU.
        /// </summary>
        public const string W8AMTU = "W8AMTU";

        /// <summary>
        /// W8RMK.
        /// </summary>
        public const string W8RMK = "W8RMK";

        /// <summary>
        /// W8DTUD.
        /// </summary>
        public const string W8DTUD = "W8DTUD";

        /// <summary>
        /// W8DYUD.
        /// </summary>
        public const string W8DYUD = "W8DYUD";

        /// <summary>
        /// W8RORN.
        /// </summary>
        public const string W8RORN = "W8RORN";

        /// <summary>
        /// W8RCTO.
        /// </summary>
        public const string W8RCTO = "W8RCTO";

        /// <summary>
        /// W8USER.
        /// </summary>
        public const string W8USER = "W8USER";

        /// <summary>
        /// W8PID.
        /// </summary>
        public const string W8PID = "W8PID";

        /// <summary>
        /// W8UPMJ.
        /// </summary>
        public const string W8UPMJ = "W8UPMJ";

        /// <summary>
        /// W8TDAY.
        /// </summary>
        public const string W8TDAY = "W8TDAY";

        /// <summary>
        /// W8JOBN.
        /// </summary>
        public const string W8JOBN = "W8JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F48092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W8WODB", "W8WODB", JdeDataType.String, 2, true, true),
        new JdeField("W8TYWO", "W8TYWO", JdeDataType.String, 4, true, true),
        new JdeField("W8DOCO", "W8DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("W8KY", "W8KY", JdeDataType.String, 20, true, true),
        new JdeField("W8UORG", "W8UORG", JdeDataType.Numeric),
        new JdeField("W8AMTU", "W8AMTU", JdeDataType.Numeric),
        new JdeField("W8RMK", "W8RMK", JdeDataType.String, 60),
        new JdeField("W8DTUD", "W8DTUD", JdeDataType.Numeric, null, true, true),
        new JdeField("W8DYUD", "W8DYUD", JdeDataType.Numeric),
        new JdeField("W8RORN", "W8RORN", JdeDataType.String, 16, true, true),
        new JdeField("W8RCTO", "W8RCTO", JdeDataType.String, 4, true, true),
        new JdeField("W8USER", "W8USER", JdeDataType.String, 20),
        new JdeField("W8PID", "W8PID", JdeDataType.String, 20),
        new JdeField("W8UPMJ", "W8UPMJ", JdeDataType.Numeric),
        new JdeField("W8TDAY", "W8TDAY", JdeDataType.Numeric),
        new JdeField("W8JOBN", "W8JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48092_0", "Primary Key on W8WODB, W8TYWO, W8DOCO, W8KY, W8DTUD, W8RORN, W8RCTO", new[] { "W8WODB", "W8TYWO", "W8DOCO", "W8KY", "W8DTUD", "W8RORN", "W8RCTO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48092_2", "Index on W8WODB, W8TYWO, W8DTUD, W8KY, W8RORN, W8RCTO", new[] { "W8WODB", "W8TYWO", "W8DTUD", "W8KY", "W8RORN", "W8RCTO" })
    };
}
