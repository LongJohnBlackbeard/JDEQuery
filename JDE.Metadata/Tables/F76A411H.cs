using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A411H - .
/// </summary>
public class F76A411H : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B0KCO.
        /// </summary>
        public const string B0KCO = "B0KCO";

        /// <summary>
        /// B0DCT.
        /// </summary>
        public const string B0DCT = "B0DCT";

        /// <summary>
        /// B0DOC.
        /// </summary>
        public const string B0DOC = "B0DOC";

        /// <summary>
        /// B0ACAI.
        /// </summary>
        public const string B0ACAI = "B0ACAI";

        /// <summary>
        /// B0AFCD.
        /// </summary>
        public const string B0AFCD = "B0AFCD";

        /// <summary>
        /// B0AFFE.
        /// </summary>
        public const string B0AFFE = "B0AFFE";

        /// <summary>
        /// B0AFAT.
        /// </summary>
        public const string B0AFAT = "B0AFAT";

        /// <summary>
        /// B0VR01.
        /// </summary>
        public const string B0VR01 = "B0VR01";

        /// <summary>
        /// B0ALTT.
        /// </summary>
        public const string B0ALTT = "B0ALTT";

        /// <summary>
        /// B0ALTU.
        /// </summary>
        public const string B0ALTU = "B0ALTU";

        /// <summary>
        /// B0ALTV.
        /// </summary>
        public const string B0ALTV = "B0ALTV";

        /// <summary>
        /// B0TORG.
        /// </summary>
        public const string B0TORG = "B0TORG";

        /// <summary>
        /// B0USER.
        /// </summary>
        public const string B0USER = "B0USER";

        /// <summary>
        /// B0PID.
        /// </summary>
        public const string B0PID = "B0PID";

        /// <summary>
        /// B0UPMJ.
        /// </summary>
        public const string B0UPMJ = "B0UPMJ";

        /// <summary>
        /// B0UPMT.
        /// </summary>
        public const string B0UPMT = "B0UPMT";

        /// <summary>
        /// B0JOBN.
        /// </summary>
        public const string B0JOBN = "B0JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A411H";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B0KCO", "B0KCO", JdeDataType.String, 10, true, true),
        new JdeField("B0DCT", "B0DCT", JdeDataType.String, 4, true, true),
        new JdeField("B0DOC", "B0DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("B0ACAI", "B0ACAI", JdeDataType.String, 28),
        new JdeField("B0AFCD", "B0AFCD", JdeDataType.String, 20),
        new JdeField("B0AFFE", "B0AFFE", JdeDataType.Numeric),
        new JdeField("B0AFAT", "B0AFAT", JdeDataType.Numeric),
        new JdeField("B0VR01", "B0VR01", JdeDataType.String, 50),
        new JdeField("B0ALTT", "B0ALTT", JdeDataType.String, 2),
        new JdeField("B0ALTU", "B0ALTU", JdeDataType.String, 2),
        new JdeField("B0ALTV", "B0ALTV", JdeDataType.String, 2),
        new JdeField("B0TORG", "B0TORG", JdeDataType.String, 20),
        new JdeField("B0USER", "B0USER", JdeDataType.String, 20),
        new JdeField("B0PID", "B0PID", JdeDataType.String, 20),
        new JdeField("B0UPMJ", "B0UPMJ", JdeDataType.Numeric),
        new JdeField("B0UPMT", "B0UPMT", JdeDataType.Numeric),
        new JdeField("B0JOBN", "B0JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A411H_0", "Primary Key on B0KCO, B0DCT, B0DOC", new[] { "B0KCO", "B0DCT", "B0DOC" }, isUnique: true, isPrimaryKey: true)
    };
}
