using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A33 - .
/// </summary>
public class F76A33 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// X4KCO.
        /// </summary>
        public const string X4KCO = "X4KCO";

        /// <summary>
        /// X4DOC.
        /// </summary>
        public const string X4DOC = "X4DOC";

        /// <summary>
        /// X4DCT.
        /// </summary>
        public const string X4DCT = "X4DCT";

        /// <summary>
        /// X4SFX.
        /// </summary>
        public const string X4SFX = "X4SFX";

        /// <summary>
        /// X4SFXE.
        /// </summary>
        public const string X4SFXE = "X4SFXE";

        /// <summary>
        /// X4USER.
        /// </summary>
        public const string X4USER = "X4USER";

        /// <summary>
        /// X4PID.
        /// </summary>
        public const string X4PID = "X4PID";

        /// <summary>
        /// X4UPMJ.
        /// </summary>
        public const string X4UPMJ = "X4UPMJ";

        /// <summary>
        /// X4UPMT.
        /// </summary>
        public const string X4UPMT = "X4UPMT";

        /// <summary>
        /// X4JOBN.
        /// </summary>
        public const string X4JOBN = "X4JOBN";

        /// <summary>
        /// X4URRF.
        /// </summary>
        public const string X4URRF = "X4URRF";

        /// <summary>
        /// X4URDT.
        /// </summary>
        public const string X4URDT = "X4URDT";

        /// <summary>
        /// X4URC1.
        /// </summary>
        public const string X4URC1 = "X4URC1";

        /// <summary>
        /// X4URAT.
        /// </summary>
        public const string X4URAT = "X4URAT";

        /// <summary>
        /// X4URAB.
        /// </summary>
        public const string X4URAB = "X4URAB";
    }

    /// <inheritdoc />
    public override string TableName => "F76A33";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("X4KCO", "X4KCO", JdeDataType.String, 10, true, true),
        new JdeField("X4DOC", "X4DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("X4DCT", "X4DCT", JdeDataType.String, 4, true, true),
        new JdeField("X4SFX", "X4SFX", JdeDataType.String, 6, true, true),
        new JdeField("X4SFXE", "X4SFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("X4USER", "X4USER", JdeDataType.String, 20),
        new JdeField("X4PID", "X4PID", JdeDataType.String, 20),
        new JdeField("X4UPMJ", "X4UPMJ", JdeDataType.Numeric),
        new JdeField("X4UPMT", "X4UPMT", JdeDataType.Numeric),
        new JdeField("X4JOBN", "X4JOBN", JdeDataType.String, 20),
        new JdeField("X4URRF", "X4URRF", JdeDataType.String, 30),
        new JdeField("X4URDT", "X4URDT", JdeDataType.Numeric),
        new JdeField("X4URC1", "X4URC1", JdeDataType.String, 6),
        new JdeField("X4URAT", "X4URAT", JdeDataType.Numeric),
        new JdeField("X4URAB", "X4URAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A33_0", "Primary Key on X4DOC, X4DCT, X4KCO, X4SFX, X4SFXE", new[] { "X4DOC", "X4DCT", "X4KCO", "X4SFX", "X4SFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
