using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A50 - .
/// </summary>
public class F76A50 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// A1KCO.
        /// </summary>
        public const string A1KCO = "A1KCO";

        /// <summary>
        /// A1DCT.
        /// </summary>
        public const string A1DCT = "A1DCT";

        /// <summary>
        /// A1DOC.
        /// </summary>
        public const string A1DOC = "A1DOC";

        /// <summary>
        /// A1SFX.
        /// </summary>
        public const string A1SFX = "A1SFX";

        /// <summary>
        /// A1VOD.
        /// </summary>
        public const string A1VOD = "A1VOD";

        /// <summary>
        /// A1ALAC.
        /// </summary>
        public const string A1ALAC = "A1ALAC";

        /// <summary>
        /// A1APDO.
        /// </summary>
        public const string A1APDO = "A1APDO";

        /// <summary>
        /// A1USER.
        /// </summary>
        public const string A1USER = "A1USER";

        /// <summary>
        /// A1JOBN.
        /// </summary>
        public const string A1JOBN = "A1JOBN";

        /// <summary>
        /// A1PID.
        /// </summary>
        public const string A1PID = "A1PID";

        /// <summary>
        /// A1UPMJ.
        /// </summary>
        public const string A1UPMJ = "A1UPMJ";

        /// <summary>
        /// A1TDAY.
        /// </summary>
        public const string A1TDAY = "A1TDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76A50";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("A1KCO", "A1KCO", JdeDataType.String, 10, true, true),
        new JdeField("A1DCT", "A1DCT", JdeDataType.String, 4, true, true),
        new JdeField("A1DOC", "A1DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("A1SFX", "A1SFX", JdeDataType.String, 6, true, true),
        new JdeField("A1VOD", "A1VOD", JdeDataType.String, 2, true, true),
        new JdeField("A1ALAC", "A1ALAC", JdeDataType.String, 16, true, true),
        new JdeField("A1APDO", "A1APDO", JdeDataType.String, 2),
        new JdeField("A1USER", "A1USER", JdeDataType.String, 20),
        new JdeField("A1JOBN", "A1JOBN", JdeDataType.String, 20),
        new JdeField("A1PID", "A1PID", JdeDataType.String, 20),
        new JdeField("A1UPMJ", "A1UPMJ", JdeDataType.Numeric),
        new JdeField("A1TDAY", "A1TDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A50_0", "Primary Key on A1KCO, A1DCT, A1DOC, A1SFX, A1VOD, A1ALAC", new[] { "A1KCO", "A1DCT", "A1DOC", "A1SFX", "A1VOD", "A1ALAC" }, isUnique: true, isPrimaryKey: true)
    };
}
