using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F12092 - .
/// </summary>
public class F12092 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// F3TYDD.
        /// </summary>
        public const string F3TYDD = "F3TYDD";

        /// <summary>
        /// F3NUMB.
        /// </summary>
        public const string F3NUMB = "F3NUMB";

        /// <summary>
        /// F3KY.
        /// </summary>
        public const string F3KY = "F3KY";

        /// <summary>
        /// F3EFT.
        /// </summary>
        public const string F3EFT = "F3EFT";

        /// <summary>
        /// F3EFTE.
        /// </summary>
        public const string F3EFTE = "F3EFTE";

        /// <summary>
        /// F3AMTU.
        /// </summary>
        public const string F3AMTU = "F3AMTU";

        /// <summary>
        /// F3RMK.
        /// </summary>
        public const string F3RMK = "F3RMK";

        /// <summary>
        /// F3RMK2.
        /// </summary>
        public const string F3RMK2 = "F3RMK2";

        /// <summary>
        /// F3TDTE.
        /// </summary>
        public const string F3TDTE = "F3TDTE";

        /// <summary>
        /// F3AN8.
        /// </summary>
        public const string F3AN8 = "F3AN8";

        /// <summary>
        /// F3DOCO.
        /// </summary>
        public const string F3DOCO = "F3DOCO";
    }

    /// <inheritdoc />
    public override string TableName => "F12092";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("F3TYDD", "F3TYDD", JdeDataType.String, 4, true, true),
        new JdeField("F3NUMB", "F3NUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("F3KY", "F3KY", JdeDataType.String, 20, true, true),
        new JdeField("F3EFT", "F3EFT", JdeDataType.Numeric, null, true, true),
        new JdeField("F3EFTE", "F3EFTE", JdeDataType.Numeric),
        new JdeField("F3AMTU", "F3AMTU", JdeDataType.Numeric),
        new JdeField("F3RMK", "F3RMK", JdeDataType.String, 60),
        new JdeField("F3RMK2", "F3RMK2", JdeDataType.String, 60),
        new JdeField("F3TDTE", "F3TDTE", JdeDataType.Numeric),
        new JdeField("F3AN8", "F3AN8", JdeDataType.Numeric),
        new JdeField("F3DOCO", "F3DOCO", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F12092_0", "Primary Key on F3TYDD, F3NUMB, F3EFT, F3KY", new[] { "F3TYDD", "F3NUMB", "F3EFT", "F3KY" }, isUnique: true, isPrimaryKey: true)
    };
}
