using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A411Q - .
/// </summary>
public class F76A411Q : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B1DOC.
        /// </summary>
        public const string B1DOC = "B1DOC";

        /// <summary>
        /// B1DCT.
        /// </summary>
        public const string B1DCT = "B1DCT";

        /// <summary>
        /// B1KCO.
        /// </summary>
        public const string B1KCO = "B1KCO";

        /// <summary>
        /// B1SFX.
        /// </summary>
        public const string B1SFX = "B1SFX";

        /// <summary>
        /// B1SFXE.
        /// </summary>
        public const string B1SFXE = "B1SFXE";

        /// <summary>
        /// B1ACDS.
        /// </summary>
        public const string B1ACDS = "B1ACDS";

        /// <summary>
        /// B1ACOP.
        /// </summary>
        public const string B1ACOP = "B1ACOP";

        /// <summary>
        /// B1ACF.
        /// </summary>
        public const string B1ACF = "B1ACF";

        /// <summary>
        /// B1AIRG.
        /// </summary>
        public const string B1AIRG = "B1AIRG";

        /// <summary>
        /// B1AFCD.
        /// </summary>
        public const string B1AFCD = "B1AFCD";

        /// <summary>
        /// B1AFFE.
        /// </summary>
        public const string B1AFFE = "B1AFFE";

        /// <summary>
        /// B1AFAT.
        /// </summary>
        public const string B1AFAT = "B1AFAT";

        /// <summary>
        /// B1RP1.
        /// </summary>
        public const string B1RP1 = "B1RP1";

        /// <summary>
        /// B1ALTT.
        /// </summary>
        public const string B1ALTT = "B1ALTT";

        /// <summary>
        /// B1ALTU.
        /// </summary>
        public const string B1ALTU = "B1ALTU";

        /// <summary>
        /// B1ALTV.
        /// </summary>
        public const string B1ALTV = "B1ALTV";

        /// <summary>
        /// B1TRDJ.
        /// </summary>
        public const string B1TRDJ = "B1TRDJ";

        /// <summary>
        /// B1TORG.
        /// </summary>
        public const string B1TORG = "B1TORG";

        /// <summary>
        /// B1USER.
        /// </summary>
        public const string B1USER = "B1USER";

        /// <summary>
        /// B1PID.
        /// </summary>
        public const string B1PID = "B1PID";

        /// <summary>
        /// B1UPMJ.
        /// </summary>
        public const string B1UPMJ = "B1UPMJ";

        /// <summary>
        /// B1UPMT.
        /// </summary>
        public const string B1UPMT = "B1UPMT";

        /// <summary>
        /// B1JOBN.
        /// </summary>
        public const string B1JOBN = "B1JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A411Q";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B1DOC", "B1DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("B1DCT", "B1DCT", JdeDataType.String, 4, true, true),
        new JdeField("B1KCO", "B1KCO", JdeDataType.String, 10, true, true),
        new JdeField("B1SFX", "B1SFX", JdeDataType.String, 6, true, true),
        new JdeField("B1SFXE", "B1SFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("B1ACDS", "B1ACDS", JdeDataType.String, 8),
        new JdeField("B1ACOP", "B1ACOP", JdeDataType.String, 2),
        new JdeField("B1ACF", "B1ACF", JdeDataType.String, 2),
        new JdeField("B1AIRG", "B1AIRG", JdeDataType.String, 2),
        new JdeField("B1AFCD", "B1AFCD", JdeDataType.String, 20),
        new JdeField("B1AFFE", "B1AFFE", JdeDataType.Numeric),
        new JdeField("B1AFAT", "B1AFAT", JdeDataType.Numeric),
        new JdeField("B1RP1", "B1RP1", JdeDataType.String, 2),
        new JdeField("B1ALTT", "B1ALTT", JdeDataType.String, 2),
        new JdeField("B1ALTU", "B1ALTU", JdeDataType.String, 2),
        new JdeField("B1ALTV", "B1ALTV", JdeDataType.String, 2),
        new JdeField("B1TRDJ", "B1TRDJ", JdeDataType.Numeric),
        new JdeField("B1TORG", "B1TORG", JdeDataType.String, 20),
        new JdeField("B1USER", "B1USER", JdeDataType.String, 20),
        new JdeField("B1PID", "B1PID", JdeDataType.String, 20),
        new JdeField("B1UPMJ", "B1UPMJ", JdeDataType.Numeric),
        new JdeField("B1UPMT", "B1UPMT", JdeDataType.Numeric),
        new JdeField("B1JOBN", "B1JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A411Q_0", "Primary Key on B1DOC, B1DCT, B1KCO, B1SFX, B1SFXE", new[] { "B1DOC", "B1DCT", "B1KCO", "B1SFX", "B1SFXE" }, isUnique: true, isPrimaryKey: true)
    };
}
