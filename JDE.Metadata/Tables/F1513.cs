using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1513 - .
/// </summary>
public class F1513 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// O3DOCO.
        /// </summary>
        public const string O3DOCO = "O3DOCO";

        /// <summary>
        /// O3MCU.
        /// </summary>
        public const string O3MCU = "O3MCU";

        /// <summary>
        /// O3UNIT.
        /// </summary>
        public const string O3UNIT = "O3UNIT";

        /// <summary>
        /// O3CTRY.
        /// </summary>
        public const string O3CTRY = "O3CTRY";

        /// <summary>
        /// O3YR.
        /// </summary>
        public const string O3YR = "O3YR";

        /// <summary>
        /// O3ICU.
        /// </summary>
        public const string O3ICU = "O3ICU";

        /// <summary>
        /// O3PSTF.
        /// </summary>
        public const string O3PSTF = "O3PSTF";

        /// <summary>
        /// O3GENC.
        /// </summary>
        public const string O3GENC = "O3GENC";

        /// <summary>
        /// O3AN8.
        /// </summary>
        public const string O3AN8 = "O3AN8";

        /// <summary>
        /// O3AN8J.
        /// </summary>
        public const string O3AN8J = "O3AN8J";

        /// <summary>
        /// O3EFTB.
        /// </summary>
        public const string O3EFTB = "O3EFTB";

        /// <summary>
        /// O3PMTC.
        /// </summary>
        public const string O3PMTC = "O3PMTC";

        /// <summary>
        /// O3AB01.
        /// </summary>
        public const string O3AB01 = "O3AB01";

        /// <summary>
        /// O3AB02.
        /// </summary>
        public const string O3AB02 = "O3AB02";

        /// <summary>
        /// O3AB03.
        /// </summary>
        public const string O3AB03 = "O3AB03";

        /// <summary>
        /// O3AB04.
        /// </summary>
        public const string O3AB04 = "O3AB04";

        /// <summary>
        /// O3AB05.
        /// </summary>
        public const string O3AB05 = "O3AB05";

        /// <summary>
        /// O3AB06.
        /// </summary>
        public const string O3AB06 = "O3AB06";

        /// <summary>
        /// O3AB07.
        /// </summary>
        public const string O3AB07 = "O3AB07";

        /// <summary>
        /// O3AB08.
        /// </summary>
        public const string O3AB08 = "O3AB08";

        /// <summary>
        /// O3AB09.
        /// </summary>
        public const string O3AB09 = "O3AB09";

        /// <summary>
        /// O3AB10.
        /// </summary>
        public const string O3AB10 = "O3AB10";

        /// <summary>
        /// O3AB11.
        /// </summary>
        public const string O3AB11 = "O3AB11";

        /// <summary>
        /// O3AB12.
        /// </summary>
        public const string O3AB12 = "O3AB12";

        /// <summary>
        /// O3AB13.
        /// </summary>
        public const string O3AB13 = "O3AB13";

        /// <summary>
        /// O3BS01.
        /// </summary>
        public const string O3BS01 = "O3BS01";

        /// <summary>
        /// O3BS02.
        /// </summary>
        public const string O3BS02 = "O3BS02";

        /// <summary>
        /// O3BS03.
        /// </summary>
        public const string O3BS03 = "O3BS03";

        /// <summary>
        /// O3BS04.
        /// </summary>
        public const string O3BS04 = "O3BS04";

        /// <summary>
        /// O3BS05.
        /// </summary>
        public const string O3BS05 = "O3BS05";

        /// <summary>
        /// O3BS06.
        /// </summary>
        public const string O3BS06 = "O3BS06";

        /// <summary>
        /// O3BS07.
        /// </summary>
        public const string O3BS07 = "O3BS07";

        /// <summary>
        /// O3BS08.
        /// </summary>
        public const string O3BS08 = "O3BS08";

        /// <summary>
        /// O3BS09.
        /// </summary>
        public const string O3BS09 = "O3BS09";

        /// <summary>
        /// O3BS10.
        /// </summary>
        public const string O3BS10 = "O3BS10";

        /// <summary>
        /// O3BS11.
        /// </summary>
        public const string O3BS11 = "O3BS11";

        /// <summary>
        /// O3BS12.
        /// </summary>
        public const string O3BS12 = "O3BS12";

        /// <summary>
        /// O3BS13.
        /// </summary>
        public const string O3BS13 = "O3BS13";

        /// <summary>
        /// O3BALF.
        /// </summary>
        public const string O3BALF = "O3BALF";

        /// <summary>
        /// O3CACH.
        /// </summary>
        public const string O3CACH = "O3CACH";

        /// <summary>
        /// O3CAHD.
        /// </summary>
        public const string O3CAHD = "O3CAHD";

        /// <summary>
        /// O3BA01.
        /// </summary>
        public const string O3BA01 = "O3BA01";

        /// <summary>
        /// O3BA02.
        /// </summary>
        public const string O3BA02 = "O3BA02";

        /// <summary>
        /// O3BA03.
        /// </summary>
        public const string O3BA03 = "O3BA03";

        /// <summary>
        /// O3BA04.
        /// </summary>
        public const string O3BA04 = "O3BA04";

        /// <summary>
        /// O3BA05.
        /// </summary>
        public const string O3BA05 = "O3BA05";

        /// <summary>
        /// O3BA06.
        /// </summary>
        public const string O3BA06 = "O3BA06";

        /// <summary>
        /// O3BA07.
        /// </summary>
        public const string O3BA07 = "O3BA07";

        /// <summary>
        /// O3BA08.
        /// </summary>
        public const string O3BA08 = "O3BA08";

        /// <summary>
        /// O3BA09.
        /// </summary>
        public const string O3BA09 = "O3BA09";

        /// <summary>
        /// O3BA10.
        /// </summary>
        public const string O3BA10 = "O3BA10";

        /// <summary>
        /// O3BA11.
        /// </summary>
        public const string O3BA11 = "O3BA11";

        /// <summary>
        /// O3BA12.
        /// </summary>
        public const string O3BA12 = "O3BA12";

        /// <summary>
        /// O3BA13.
        /// </summary>
        public const string O3BA13 = "O3BA13";

        /// <summary>
        /// O3UPMJ.
        /// </summary>
        public const string O3UPMJ = "O3UPMJ";

        /// <summary>
        /// O3USER.
        /// </summary>
        public const string O3USER = "O3USER";

        /// <summary>
        /// O3PID.
        /// </summary>
        public const string O3PID = "O3PID";

        /// <summary>
        /// O3JOBN.
        /// </summary>
        public const string O3JOBN = "O3JOBN";

        /// <summary>
        /// O3UPMT.
        /// </summary>
        public const string O3UPMT = "O3UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1513";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("O3DOCO", "O3DOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("O3MCU", "O3MCU", JdeDataType.String, 24, true, true),
        new JdeField("O3UNIT", "O3UNIT", JdeDataType.String, 16, true, true),
        new JdeField("O3CTRY", "O3CTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("O3YR", "O3YR", JdeDataType.Numeric, null, true, true),
        new JdeField("O3ICU", "O3ICU", JdeDataType.Numeric, null, true, true),
        new JdeField("O3PSTF", "O3PSTF", JdeDataType.String, 2),
        new JdeField("O3GENC", "O3GENC", JdeDataType.String, 2),
        new JdeField("O3AN8", "O3AN8", JdeDataType.Numeric),
        new JdeField("O3AN8J", "O3AN8J", JdeDataType.Numeric),
        new JdeField("O3EFTB", "O3EFTB", JdeDataType.Numeric),
        new JdeField("O3PMTC", "O3PMTC", JdeDataType.Numeric),
        new JdeField("O3AB01", "O3AB01", JdeDataType.Numeric),
        new JdeField("O3AB02", "O3AB02", JdeDataType.Numeric),
        new JdeField("O3AB03", "O3AB03", JdeDataType.Numeric),
        new JdeField("O3AB04", "O3AB04", JdeDataType.Numeric),
        new JdeField("O3AB05", "O3AB05", JdeDataType.Numeric),
        new JdeField("O3AB06", "O3AB06", JdeDataType.Numeric),
        new JdeField("O3AB07", "O3AB07", JdeDataType.Numeric),
        new JdeField("O3AB08", "O3AB08", JdeDataType.Numeric),
        new JdeField("O3AB09", "O3AB09", JdeDataType.Numeric),
        new JdeField("O3AB10", "O3AB10", JdeDataType.Numeric),
        new JdeField("O3AB11", "O3AB11", JdeDataType.Numeric),
        new JdeField("O3AB12", "O3AB12", JdeDataType.Numeric),
        new JdeField("O3AB13", "O3AB13", JdeDataType.Numeric),
        new JdeField("O3BS01", "O3BS01", JdeDataType.Numeric),
        new JdeField("O3BS02", "O3BS02", JdeDataType.Numeric),
        new JdeField("O3BS03", "O3BS03", JdeDataType.Numeric),
        new JdeField("O3BS04", "O3BS04", JdeDataType.Numeric),
        new JdeField("O3BS05", "O3BS05", JdeDataType.Numeric),
        new JdeField("O3BS06", "O3BS06", JdeDataType.Numeric),
        new JdeField("O3BS07", "O3BS07", JdeDataType.Numeric),
        new JdeField("O3BS08", "O3BS08", JdeDataType.Numeric),
        new JdeField("O3BS09", "O3BS09", JdeDataType.Numeric),
        new JdeField("O3BS10", "O3BS10", JdeDataType.Numeric),
        new JdeField("O3BS11", "O3BS11", JdeDataType.Numeric),
        new JdeField("O3BS12", "O3BS12", JdeDataType.Numeric),
        new JdeField("O3BS13", "O3BS13", JdeDataType.Numeric),
        new JdeField("O3BALF", "O3BALF", JdeDataType.Numeric),
        new JdeField("O3CACH", "O3CACH", JdeDataType.Numeric),
        new JdeField("O3CAHD", "O3CAHD", JdeDataType.Numeric),
        new JdeField("O3BA01", "O3BA01", JdeDataType.Numeric),
        new JdeField("O3BA02", "O3BA02", JdeDataType.Numeric),
        new JdeField("O3BA03", "O3BA03", JdeDataType.Numeric),
        new JdeField("O3BA04", "O3BA04", JdeDataType.Numeric),
        new JdeField("O3BA05", "O3BA05", JdeDataType.Numeric),
        new JdeField("O3BA06", "O3BA06", JdeDataType.Numeric),
        new JdeField("O3BA07", "O3BA07", JdeDataType.Numeric),
        new JdeField("O3BA08", "O3BA08", JdeDataType.Numeric),
        new JdeField("O3BA09", "O3BA09", JdeDataType.Numeric),
        new JdeField("O3BA10", "O3BA10", JdeDataType.Numeric),
        new JdeField("O3BA11", "O3BA11", JdeDataType.Numeric),
        new JdeField("O3BA12", "O3BA12", JdeDataType.Numeric),
        new JdeField("O3BA13", "O3BA13", JdeDataType.Numeric),
        new JdeField("O3UPMJ", "O3UPMJ", JdeDataType.Numeric),
        new JdeField("O3USER", "O3USER", JdeDataType.String, 20),
        new JdeField("O3PID", "O3PID", JdeDataType.String, 20),
        new JdeField("O3JOBN", "O3JOBN", JdeDataType.String, 20),
        new JdeField("O3UPMT", "O3UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1513_0", "Primary Key on O3DOCO, O3MCU, O3UNIT, O3CTRY, O3YR, O3ICU", new[] { "O3DOCO", "O3MCU", "O3UNIT", "O3CTRY", "O3YR", "O3ICU" }, isUnique: true, isPrimaryKey: true)
    };
}
