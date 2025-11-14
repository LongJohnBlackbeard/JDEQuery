using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09UI004 - .
/// </summary>
public class F09UI004 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// R#ICU.
        /// </summary>
        public const string R_ICU = "R#ICU";

        /// <summary>
        /// R#ICUT.
        /// </summary>
        public const string R_ICUT = "R#ICUT";

        /// <summary>
        /// R#RTAL.
        /// </summary>
        public const string R_RTAL = "R#RTAL";

        /// <summary>
        /// R#RCK9.
        /// </summary>
        public const string R_RCK9 = "R#RCK9";

        /// <summary>
        /// R#DOC.
        /// </summary>
        public const string R_DOC = "R#DOC";

        /// <summary>
        /// R#DCT.
        /// </summary>
        public const string R_DCT = "R#DCT";

        /// <summary>
        /// R#KCO.
        /// </summary>
        public const string R_KCO = "R#KCO";

        /// <summary>
        /// R#AID.
        /// </summary>
        public const string R_AID = "R#AID";

        /// <summary>
        /// R#MCU.
        /// </summary>
        public const string R_MCU = "R#MCU";

        /// <summary>
        /// R#OBJ.
        /// </summary>
        public const string R_OBJ = "R#OBJ";

        /// <summary>
        /// R#SUB.
        /// </summary>
        public const string R_SUB = "R#SUB";

        /// <summary>
        /// R#SBL.
        /// </summary>
        public const string R_SBL = "R#SBL";

        /// <summary>
        /// R#SBLT.
        /// </summary>
        public const string R_SBLT = "R#SBLT";

        /// <summary>
        /// R#LT.
        /// </summary>
        public const string R_LT = "R#LT";

        /// <summary>
        /// R#CTRY.
        /// </summary>
        public const string R_CTRY = "R#CTRY";

        /// <summary>
        /// R#FY.
        /// </summary>
        public const string R_FY = "R#FY";

        /// <summary>
        /// R#PNC.
        /// </summary>
        public const string R_PNC = "R#PNC";

        /// <summary>
        /// R#APYC.
        /// </summary>
        public const string R_APYC = "R#APYC";

        /// <summary>
        /// R#CRCX.
        /// </summary>
        public const string R_CRCX = "R#CRCX";
    }

    /// <inheritdoc />
    public override string TableName => "F09UI004";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("R#ICU", "R#ICU", JdeDataType.Numeric, null, true, true),
        new JdeField("R#ICUT", "R#ICUT", JdeDataType.String, 4, true, true),
        new JdeField("R#RTAL", "R#RTAL", JdeDataType.String, 2, true, true),
        new JdeField("R#RCK9", "R#RCK9", JdeDataType.Numeric, null, true, true),
        new JdeField("R#DOC", "R#DOC", JdeDataType.Numeric),
        new JdeField("R#DCT", "R#DCT", JdeDataType.String, 4),
        new JdeField("R#KCO", "R#KCO", JdeDataType.String, 10),
        new JdeField("R#AID", "R#AID", JdeDataType.String, 16),
        new JdeField("R#MCU", "R#MCU", JdeDataType.String, 24),
        new JdeField("R#OBJ", "R#OBJ", JdeDataType.String, 12),
        new JdeField("R#SUB", "R#SUB", JdeDataType.String, 16),
        new JdeField("R#SBL", "R#SBL", JdeDataType.String, 16),
        new JdeField("R#SBLT", "R#SBLT", JdeDataType.String, 2),
        new JdeField("R#LT", "R#LT", JdeDataType.String, 4),
        new JdeField("R#CTRY", "R#CTRY", JdeDataType.Numeric),
        new JdeField("R#FY", "R#FY", JdeDataType.Numeric),
        new JdeField("R#PNC", "R#PNC", JdeDataType.Numeric),
        new JdeField("R#APYC", "R#APYC", JdeDataType.Numeric),
        new JdeField("R#CRCX", "R#CRCX", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09UI004_0", "Primary Key on R#ICU, R#ICUT, R#RTAL, R#RCK9", new[] { "R#ICU", "R#ICUT", "R#RTAL", "R#RCK9" }, isUnique: true, isPrimaryKey: true)
    };
}
