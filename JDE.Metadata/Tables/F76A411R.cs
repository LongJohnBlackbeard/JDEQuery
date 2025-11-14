using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A411R - .
/// </summary>
public class F76A411R : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B4KCO.
        /// </summary>
        public const string B4KCO = "B4KCO";

        /// <summary>
        /// B4DCT.
        /// </summary>
        public const string B4DCT = "B4DCT";

        /// <summary>
        /// B4DOC.
        /// </summary>
        public const string B4DOC = "B4DOC";

        /// <summary>
        /// B4ACAI.
        /// </summary>
        public const string B4ACAI = "B4ACAI";

        /// <summary>
        /// B4AFCD.
        /// </summary>
        public const string B4AFCD = "B4AFCD";

        /// <summary>
        /// B4AFFE.
        /// </summary>
        public const string B4AFFE = "B4AFFE";

        /// <summary>
        /// B4AFAT.
        /// </summary>
        public const string B4AFAT = "B4AFAT";

        /// <summary>
        /// B4VR01.
        /// </summary>
        public const string B4VR01 = "B4VR01";

        /// <summary>
        /// B4ALTT.
        /// </summary>
        public const string B4ALTT = "B4ALTT";

        /// <summary>
        /// B4ALTU.
        /// </summary>
        public const string B4ALTU = "B4ALTU";

        /// <summary>
        /// B4ALTV.
        /// </summary>
        public const string B4ALTV = "B4ALTV";

        /// <summary>
        /// B4TORG.
        /// </summary>
        public const string B4TORG = "B4TORG";

        /// <summary>
        /// B4USER.
        /// </summary>
        public const string B4USER = "B4USER";

        /// <summary>
        /// B4PID.
        /// </summary>
        public const string B4PID = "B4PID";

        /// <summary>
        /// B4UPMJ.
        /// </summary>
        public const string B4UPMJ = "B4UPMJ";

        /// <summary>
        /// B4UPMT.
        /// </summary>
        public const string B4UPMT = "B4UPMT";

        /// <summary>
        /// B4JOBN.
        /// </summary>
        public const string B4JOBN = "B4JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76A411R";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B4KCO", "B4KCO", JdeDataType.String, 10, true, true),
        new JdeField("B4DCT", "B4DCT", JdeDataType.String, 4, true, true),
        new JdeField("B4DOC", "B4DOC", JdeDataType.Numeric, null, true, true),
        new JdeField("B4ACAI", "B4ACAI", JdeDataType.String, 28),
        new JdeField("B4AFCD", "B4AFCD", JdeDataType.String, 20),
        new JdeField("B4AFFE", "B4AFFE", JdeDataType.Numeric),
        new JdeField("B4AFAT", "B4AFAT", JdeDataType.Numeric),
        new JdeField("B4VR01", "B4VR01", JdeDataType.String, 50),
        new JdeField("B4ALTT", "B4ALTT", JdeDataType.String, 2),
        new JdeField("B4ALTU", "B4ALTU", JdeDataType.String, 2),
        new JdeField("B4ALTV", "B4ALTV", JdeDataType.String, 2),
        new JdeField("B4TORG", "B4TORG", JdeDataType.String, 20),
        new JdeField("B4USER", "B4USER", JdeDataType.String, 20),
        new JdeField("B4PID", "B4PID", JdeDataType.String, 20),
        new JdeField("B4UPMJ", "B4UPMJ", JdeDataType.Numeric),
        new JdeField("B4UPMT", "B4UPMT", JdeDataType.Numeric),
        new JdeField("B4JOBN", "B4JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A411R_0", "Primary Key on B4KCO, B4DCT, B4DOC", new[] { "B4KCO", "B4DCT", "B4DOC" }, isUnique: true, isPrimaryKey: true)
    };
}
