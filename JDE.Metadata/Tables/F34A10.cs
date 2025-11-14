using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A10 - .
/// </summary>
public class F34A10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// N0SY.
        /// </summary>
        public const string N0SY = "N0SY";

        /// <summary>
        /// N0CMUM.
        /// </summary>
        public const string N0CMUM = "N0CMUM";

        /// <summary>
        /// N0SVUM.
        /// </summary>
        public const string N0SVUM = "N0SVUM";

        /// <summary>
        /// N0MDWH.
        /// </summary>
        public const string N0MDWH = "N0MDWH";

        /// <summary>
        /// N0FRMT.
        /// </summary>
        public const string N0FRMT = "N0FRMT";

        /// <summary>
        /// N0FFDL.
        /// </summary>
        public const string N0FFDL = "N0FFDL";

        /// <summary>
        /// N0TC056.
        /// </summary>
        public const string N0TC056 = "N0TC056";

        /// <summary>
        /// N0BN01.
        /// </summary>
        public const string N0BN01 = "N0BN01";

        /// <summary>
        /// N0DATE01.
        /// </summary>
        public const string N0DATE01 = "N0DATE01";

        /// <summary>
        /// N0TICU.
        /// </summary>
        public const string N0TICU = "N0TICU";

        /// <summary>
        /// N0ERLV.
        /// </summary>
        public const string N0ERLV = "N0ERLV";

        /// <summary>
        /// N0BN02.
        /// </summary>
        public const string N0BN02 = "N0BN02";

        /// <summary>
        /// N0DATE02.
        /// </summary>
        public const string N0DATE02 = "N0DATE02";

        /// <summary>
        /// N0ENTI.
        /// </summary>
        public const string N0ENTI = "N0ENTI";

        /// <summary>
        /// N0ERRC.
        /// </summary>
        public const string N0ERRC = "N0ERRC";

        /// <summary>
        /// N0FFU2.
        /// </summary>
        public const string N0FFU2 = "N0FFU2";

        /// <summary>
        /// N0X1.
        /// </summary>
        public const string N0X1 = "N0X1";

        /// <summary>
        /// N0X2.
        /// </summary>
        public const string N0X2 = "N0X2";

        /// <summary>
        /// N0URCD.
        /// </summary>
        public const string N0URCD = "N0URCD";

        /// <summary>
        /// N0URDT.
        /// </summary>
        public const string N0URDT = "N0URDT";

        /// <summary>
        /// N0URAT.
        /// </summary>
        public const string N0URAT = "N0URAT";

        /// <summary>
        /// N0URAB.
        /// </summary>
        public const string N0URAB = "N0URAB";

        /// <summary>
        /// N0URRF.
        /// </summary>
        public const string N0URRF = "N0URRF";

        /// <summary>
        /// N0USER.
        /// </summary>
        public const string N0USER = "N0USER";

        /// <summary>
        /// N0PID.
        /// </summary>
        public const string N0PID = "N0PID";

        /// <summary>
        /// N0JOBN.
        /// </summary>
        public const string N0JOBN = "N0JOBN";

        /// <summary>
        /// N0UPMJ.
        /// </summary>
        public const string N0UPMJ = "N0UPMJ";

        /// <summary>
        /// N0TDAY.
        /// </summary>
        public const string N0TDAY = "N0TDAY";

        /// <summary>
        /// N0END.
        /// </summary>
        public const string N0END = "N0END";

        /// <summary>
        /// N0MVER.
        /// </summary>
        public const string N0MVER = "N0MVER";

        /// <summary>
        /// N0EV01.
        /// </summary>
        public const string N0EV01 = "N0EV01";

        /// <summary>
        /// N0EV02.
        /// </summary>
        public const string N0EV02 = "N0EV02";

        /// <summary>
        /// N0EV03.
        /// </summary>
        public const string N0EV03 = "N0EV03";

        /// <summary>
        /// N0SRST.
        /// </summary>
        public const string N0SRST = "N0SRST";

        /// <summary>
        /// N0EV04.
        /// </summary>
        public const string N0EV04 = "N0EV04";

        /// <summary>
        /// N0EV05.
        /// </summary>
        public const string N0EV05 = "N0EV05";

        /// <summary>
        /// N0EV06.
        /// </summary>
        public const string N0EV06 = "N0EV06";

        /// <summary>
        /// N0EV07.
        /// </summary>
        public const string N0EV07 = "N0EV07";

        /// <summary>
        /// N0EV08.
        /// </summary>
        public const string N0EV08 = "N0EV08";

        /// <summary>
        /// N0EV09.
        /// </summary>
        public const string N0EV09 = "N0EV09";

        /// <summary>
        /// N0EV10.
        /// </summary>
        public const string N0EV10 = "N0EV10";

        /// <summary>
        /// N0LOTI.
        /// </summary>
        public const string N0LOTI = "N0LOTI";

        /// <summary>
        /// N0EV11.
        /// </summary>
        public const string N0EV11 = "N0EV11";

        /// <summary>
        /// N0DCTO.
        /// </summary>
        public const string N0DCTO = "N0DCTO";

        /// <summary>
        /// N0DCT4.
        /// </summary>
        public const string N0DCT4 = "N0DCT4";

        /// <summary>
        /// N0DCT5.
        /// </summary>
        public const string N0DCT5 = "N0DCT5";

        /// <summary>
        /// N0EV12.
        /// </summary>
        public const string N0EV12 = "N0EV12";

        /// <summary>
        /// N0VER.
        /// </summary>
        public const string N0VER = "N0VER";

        /// <summary>
        /// N0MMCU.
        /// </summary>
        public const string N0MMCU = "N0MMCU";

        /// <summary>
        /// N0OPVER.
        /// </summary>
        public const string N0OPVER = "N0OPVER";

        /// <summary>
        /// N0GOPASF.
        /// </summary>
        public const string N0GOPASF = "N0GOPASF";
    }

    /// <inheritdoc />
    public override string TableName => "F34A10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("N0SY", "N0SY", JdeDataType.String, 8, true, true),
        new JdeField("N0CMUM", "N0CMUM", JdeDataType.String, 4),
        new JdeField("N0SVUM", "N0SVUM", JdeDataType.String, 4),
        new JdeField("N0MDWH", "N0MDWH", JdeDataType.String, 2),
        new JdeField("N0FRMT", "N0FRMT", JdeDataType.String, 6),
        new JdeField("N0FFDL", "N0FFDL", JdeDataType.String, 2),
        new JdeField("N0TC056", "N0TC056", JdeDataType.String, 2),
        new JdeField("N0BN01", "N0BN01", JdeDataType.Numeric),
        new JdeField("N0DATE01", "N0DATE01", JdeDataType.Numeric),
        new JdeField("N0TICU", "N0TICU", JdeDataType.Numeric),
        new JdeField("N0ERLV", "N0ERLV", JdeDataType.String, 2),
        new JdeField("N0BN02", "N0BN02", JdeDataType.Numeric),
        new JdeField("N0DATE02", "N0DATE02", JdeDataType.Numeric),
        new JdeField("N0ENTI", "N0ENTI", JdeDataType.Numeric),
        new JdeField("N0ERRC", "N0ERRC", JdeDataType.String, 2),
        new JdeField("N0FFU2", "N0FFU2", JdeDataType.String, 2),
        new JdeField("N0X1", "N0X1", JdeDataType.String, 2),
        new JdeField("N0X2", "N0X2", JdeDataType.String, 2),
        new JdeField("N0URCD", "N0URCD", JdeDataType.String, 4),
        new JdeField("N0URDT", "N0URDT", JdeDataType.Numeric),
        new JdeField("N0URAT", "N0URAT", JdeDataType.Numeric),
        new JdeField("N0URAB", "N0URAB", JdeDataType.Numeric),
        new JdeField("N0URRF", "N0URRF", JdeDataType.String, 30),
        new JdeField("N0USER", "N0USER", JdeDataType.String, 20),
        new JdeField("N0PID", "N0PID", JdeDataType.String, 20),
        new JdeField("N0JOBN", "N0JOBN", JdeDataType.String, 20),
        new JdeField("N0UPMJ", "N0UPMJ", JdeDataType.Numeric),
        new JdeField("N0TDAY", "N0TDAY", JdeDataType.Numeric),
        new JdeField("N0END", "N0END", JdeDataType.Numeric),
        new JdeField("N0MVER", "N0MVER", JdeDataType.String, 6),
        new JdeField("N0EV01", "N0EV01", JdeDataType.String, 2),
        new JdeField("N0EV02", "N0EV02", JdeDataType.String, 2),
        new JdeField("N0EV03", "N0EV03", JdeDataType.String, 2),
        new JdeField("N0SRST", "N0SRST", JdeDataType.String, 4),
        new JdeField("N0EV04", "N0EV04", JdeDataType.String, 2),
        new JdeField("N0EV05", "N0EV05", JdeDataType.String, 2),
        new JdeField("N0EV06", "N0EV06", JdeDataType.String, 2),
        new JdeField("N0EV07", "N0EV07", JdeDataType.String, 2),
        new JdeField("N0EV08", "N0EV08", JdeDataType.String, 2),
        new JdeField("N0EV09", "N0EV09", JdeDataType.String, 2),
        new JdeField("N0EV10", "N0EV10", JdeDataType.String, 2),
        new JdeField("N0LOTI", "N0LOTI", JdeDataType.String, 10),
        new JdeField("N0EV11", "N0EV11", JdeDataType.String, 2),
        new JdeField("N0DCTO", "N0DCTO", JdeDataType.String, 4),
        new JdeField("N0DCT4", "N0DCT4", JdeDataType.String, 4),
        new JdeField("N0DCT5", "N0DCT5", JdeDataType.String, 4),
        new JdeField("N0EV12", "N0EV12", JdeDataType.String, 2),
        new JdeField("N0VER", "N0VER", JdeDataType.String, 20),
        new JdeField("N0MMCU", "N0MMCU", JdeDataType.String, 24, true, true),
        new JdeField("N0OPVER", "N0OPVER", JdeDataType.String, 20),
        new JdeField("N0GOPASF", "N0GOPASF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A10_0", "Primary Key on N0SY, N0MMCU", new[] { "N0SY", "N0MMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
