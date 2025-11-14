using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F410014 - .
/// </summary>
public class F410014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T7TMPL.
        /// </summary>
        public const string T7TMPL = "T7TMPL";

        /// <summary>
        /// T7MCU.
        /// </summary>
        public const string T7MCU = "T7MCU";

        /// <summary>
        /// T7BKLC.
        /// </summary>
        public const string T7BKLC = "T7BKLC";

        /// <summary>
        /// T7OB00.
        /// </summary>
        public const string T7OB00 = "T7OB00";

        /// <summary>
        /// T7LEN1.
        /// </summary>
        public const string T7LEN1 = "T7LEN1";

        /// <summary>
        /// T7LE01.
        /// </summary>
        public const string T7LE01 = "T7LE01";

        /// <summary>
        /// T7LS01.
        /// </summary>
        public const string T7LS01 = "T7LS01";

        /// <summary>
        /// T7LS02.
        /// </summary>
        public const string T7LS02 = "T7LS02";

        /// <summary>
        /// T7OB01.
        /// </summary>
        public const string T7OB01 = "T7OB01";

        /// <summary>
        /// T7LEN2.
        /// </summary>
        public const string T7LEN2 = "T7LEN2";

        /// <summary>
        /// T7LE02.
        /// </summary>
        public const string T7LE02 = "T7LE02";

        /// <summary>
        /// T7LS03.
        /// </summary>
        public const string T7LS03 = "T7LS03";

        /// <summary>
        /// T7LS04.
        /// </summary>
        public const string T7LS04 = "T7LS04";

        /// <summary>
        /// T7OB02.
        /// </summary>
        public const string T7OB02 = "T7OB02";

        /// <summary>
        /// T7LEN3.
        /// </summary>
        public const string T7LEN3 = "T7LEN3";

        /// <summary>
        /// T7LE03.
        /// </summary>
        public const string T7LE03 = "T7LE03";

        /// <summary>
        /// T7LS05.
        /// </summary>
        public const string T7LS05 = "T7LS05";

        /// <summary>
        /// T7LS06.
        /// </summary>
        public const string T7LS06 = "T7LS06";

        /// <summary>
        /// T7OB03.
        /// </summary>
        public const string T7OB03 = "T7OB03";

        /// <summary>
        /// T7LENA.
        /// </summary>
        public const string T7LENA = "T7LENA";

        /// <summary>
        /// T7LE04.
        /// </summary>
        public const string T7LE04 = "T7LE04";

        /// <summary>
        /// T7LS07.
        /// </summary>
        public const string T7LS07 = "T7LS07";

        /// <summary>
        /// T7LS08.
        /// </summary>
        public const string T7LS08 = "T7LS08";

        /// <summary>
        /// T7OB04.
        /// </summary>
        public const string T7OB04 = "T7OB04";

        /// <summary>
        /// T7LEN5.
        /// </summary>
        public const string T7LEN5 = "T7LEN5";

        /// <summary>
        /// T7LE05.
        /// </summary>
        public const string T7LE05 = "T7LE05";

        /// <summary>
        /// T7LS09.
        /// </summary>
        public const string T7LS09 = "T7LS09";

        /// <summary>
        /// T7LS10.
        /// </summary>
        public const string T7LS10 = "T7LS10";

        /// <summary>
        /// T7OB05.
        /// </summary>
        public const string T7OB05 = "T7OB05";

        /// <summary>
        /// T7LEN6.
        /// </summary>
        public const string T7LEN6 = "T7LEN6";

        /// <summary>
        /// T7LE06.
        /// </summary>
        public const string T7LE06 = "T7LE06";

        /// <summary>
        /// T7LS11.
        /// </summary>
        public const string T7LS11 = "T7LS11";

        /// <summary>
        /// T7LS12.
        /// </summary>
        public const string T7LS12 = "T7LS12";

        /// <summary>
        /// T7OB06.
        /// </summary>
        public const string T7OB06 = "T7OB06";

        /// <summary>
        /// T7LEN7.
        /// </summary>
        public const string T7LEN7 = "T7LEN7";

        /// <summary>
        /// T7LE07.
        /// </summary>
        public const string T7LE07 = "T7LE07";

        /// <summary>
        /// T7LS13.
        /// </summary>
        public const string T7LS13 = "T7LS13";

        /// <summary>
        /// T7LS14.
        /// </summary>
        public const string T7LS14 = "T7LS14";

        /// <summary>
        /// T7OB07.
        /// </summary>
        public const string T7OB07 = "T7OB07";

        /// <summary>
        /// T7LEN8.
        /// </summary>
        public const string T7LEN8 = "T7LEN8";

        /// <summary>
        /// T7LE08.
        /// </summary>
        public const string T7LE08 = "T7LE08";

        /// <summary>
        /// T7LS15.
        /// </summary>
        public const string T7LS15 = "T7LS15";

        /// <summary>
        /// T7LS16.
        /// </summary>
        public const string T7LS16 = "T7LS16";

        /// <summary>
        /// T7OB08.
        /// </summary>
        public const string T7OB08 = "T7OB08";

        /// <summary>
        /// T7LEN9.
        /// </summary>
        public const string T7LEN9 = "T7LEN9";

        /// <summary>
        /// T7LE09.
        /// </summary>
        public const string T7LE09 = "T7LE09";

        /// <summary>
        /// T7LS17.
        /// </summary>
        public const string T7LS17 = "T7LS17";

        /// <summary>
        /// T7LS18.
        /// </summary>
        public const string T7LS18 = "T7LS18";

        /// <summary>
        /// T7OB09.
        /// </summary>
        public const string T7OB09 = "T7OB09";

        /// <summary>
        /// T7LEN0.
        /// </summary>
        public const string T7LEN0 = "T7LEN0";

        /// <summary>
        /// T7LE10.
        /// </summary>
        public const string T7LE10 = "T7LE10";

        /// <summary>
        /// T7LS19.
        /// </summary>
        public const string T7LS19 = "T7LS19";

        /// <summary>
        /// T7LS20.
        /// </summary>
        public const string T7LS20 = "T7LS20";

        /// <summary>
        /// T7OB10.
        /// </summary>
        public const string T7OB10 = "T7OB10";

        /// <summary>
        /// T7USER.
        /// </summary>
        public const string T7USER = "T7USER";

        /// <summary>
        /// T7PID.
        /// </summary>
        public const string T7PID = "T7PID";

        /// <summary>
        /// T7JOBN.
        /// </summary>
        public const string T7JOBN = "T7JOBN";

        /// <summary>
        /// T7UPMJ.
        /// </summary>
        public const string T7UPMJ = "T7UPMJ";

        /// <summary>
        /// T7TDAY.
        /// </summary>
        public const string T7TDAY = "T7TDAY";

        /// <summary>
        /// T7A0CC.
        /// </summary>
        public const string T7A0CC = "T7A0CC";

        /// <summary>
        /// T7A1CC.
        /// </summary>
        public const string T7A1CC = "T7A1CC";

        /// <summary>
        /// T7A2CC.
        /// </summary>
        public const string T7A2CC = "T7A2CC";

        /// <summary>
        /// T7A3CC.
        /// </summary>
        public const string T7A3CC = "T7A3CC";

        /// <summary>
        /// T7A4CC.
        /// </summary>
        public const string T7A4CC = "T7A4CC";

        /// <summary>
        /// T7A5CC.
        /// </summary>
        public const string T7A5CC = "T7A5CC";

        /// <summary>
        /// T7A6CC.
        /// </summary>
        public const string T7A6CC = "T7A6CC";

        /// <summary>
        /// T7A7CC.
        /// </summary>
        public const string T7A7CC = "T7A7CC";

        /// <summary>
        /// T7A8CC.
        /// </summary>
        public const string T7A8CC = "T7A8CC";

        /// <summary>
        /// T7A9CC.
        /// </summary>
        public const string T7A9CC = "T7A9CC";

        /// <summary>
        /// T7HSEG.
        /// </summary>
        public const string T7HSEG = "T7HSEG";

        /// <summary>
        /// T7NSEG.
        /// </summary>
        public const string T7NSEG = "T7NSEG";

        /// <summary>
        /// T7SGD0.
        /// </summary>
        public const string T7SGD0 = "T7SGD0";

        /// <summary>
        /// T7SGD1.
        /// </summary>
        public const string T7SGD1 = "T7SGD1";

        /// <summary>
        /// T7SGD2.
        /// </summary>
        public const string T7SGD2 = "T7SGD2";

        /// <summary>
        /// T7SGD3.
        /// </summary>
        public const string T7SGD3 = "T7SGD3";

        /// <summary>
        /// T7SGD4.
        /// </summary>
        public const string T7SGD4 = "T7SGD4";

        /// <summary>
        /// T7SGD5.
        /// </summary>
        public const string T7SGD5 = "T7SGD5";

        /// <summary>
        /// T7SGD6.
        /// </summary>
        public const string T7SGD6 = "T7SGD6";

        /// <summary>
        /// T7SGD7.
        /// </summary>
        public const string T7SGD7 = "T7SGD7";

        /// <summary>
        /// T7SGD8.
        /// </summary>
        public const string T7SGD8 = "T7SGD8";

        /// <summary>
        /// T7SGD9.
        /// </summary>
        public const string T7SGD9 = "T7SGD9";

        /// <summary>
        /// T7TDES.
        /// </summary>
        public const string T7TDES = "T7TDES";

        /// <summary>
        /// T7VSEG.
        /// </summary>
        public const string T7VSEG = "T7VSEG";

        /// <summary>
        /// T7SEGA.
        /// </summary>
        public const string T7SEGA = "T7SEGA";
    }

    /// <inheritdoc />
    public override string TableName => "F410014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T7TMPL", "T7TMPL", JdeDataType.String, 40, true, true),
        new JdeField("T7MCU", "T7MCU", JdeDataType.String, 24, true, true),
        new JdeField("T7BKLC", "T7BKLC", JdeDataType.String, 2),
        new JdeField("T7OB00", "T7OB00", JdeDataType.String, 40),
        new JdeField("T7LEN1", "T7LEN1", JdeDataType.Numeric),
        new JdeField("T7LE01", "T7LE01", JdeDataType.String, 2),
        new JdeField("T7LS01", "T7LS01", JdeDataType.String, 16),
        new JdeField("T7LS02", "T7LS02", JdeDataType.String, 16),
        new JdeField("T7OB01", "T7OB01", JdeDataType.String, 40),
        new JdeField("T7LEN2", "T7LEN2", JdeDataType.Numeric),
        new JdeField("T7LE02", "T7LE02", JdeDataType.String, 2),
        new JdeField("T7LS03", "T7LS03", JdeDataType.String, 16),
        new JdeField("T7LS04", "T7LS04", JdeDataType.String, 16),
        new JdeField("T7OB02", "T7OB02", JdeDataType.String, 40),
        new JdeField("T7LEN3", "T7LEN3", JdeDataType.Numeric),
        new JdeField("T7LE03", "T7LE03", JdeDataType.String, 2),
        new JdeField("T7LS05", "T7LS05", JdeDataType.String, 8),
        new JdeField("T7LS06", "T7LS06", JdeDataType.String, 8),
        new JdeField("T7OB03", "T7OB03", JdeDataType.String, 40),
        new JdeField("T7LENA", "T7LENA", JdeDataType.Numeric),
        new JdeField("T7LE04", "T7LE04", JdeDataType.String, 2),
        new JdeField("T7LS07", "T7LS07", JdeDataType.String, 8),
        new JdeField("T7LS08", "T7LS08", JdeDataType.String, 8),
        new JdeField("T7OB04", "T7OB04", JdeDataType.String, 40),
        new JdeField("T7LEN5", "T7LEN5", JdeDataType.Numeric),
        new JdeField("T7LE05", "T7LE05", JdeDataType.String, 2),
        new JdeField("T7LS09", "T7LS09", JdeDataType.String, 8),
        new JdeField("T7LS10", "T7LS10", JdeDataType.String, 8),
        new JdeField("T7OB05", "T7OB05", JdeDataType.String, 40),
        new JdeField("T7LEN6", "T7LEN6", JdeDataType.Numeric),
        new JdeField("T7LE06", "T7LE06", JdeDataType.String, 2),
        new JdeField("T7LS11", "T7LS11", JdeDataType.String, 8),
        new JdeField("T7LS12", "T7LS12", JdeDataType.String, 8),
        new JdeField("T7OB06", "T7OB06", JdeDataType.String, 40),
        new JdeField("T7LEN7", "T7LEN7", JdeDataType.Numeric),
        new JdeField("T7LE07", "T7LE07", JdeDataType.String, 2),
        new JdeField("T7LS13", "T7LS13", JdeDataType.String, 8),
        new JdeField("T7LS14", "T7LS14", JdeDataType.String, 8),
        new JdeField("T7OB07", "T7OB07", JdeDataType.String, 40),
        new JdeField("T7LEN8", "T7LEN8", JdeDataType.Numeric),
        new JdeField("T7LE08", "T7LE08", JdeDataType.String, 2),
        new JdeField("T7LS15", "T7LS15", JdeDataType.String, 8),
        new JdeField("T7LS16", "T7LS16", JdeDataType.String, 8),
        new JdeField("T7OB08", "T7OB08", JdeDataType.String, 40),
        new JdeField("T7LEN9", "T7LEN9", JdeDataType.Numeric),
        new JdeField("T7LE09", "T7LE09", JdeDataType.String, 2),
        new JdeField("T7LS17", "T7LS17", JdeDataType.String, 8),
        new JdeField("T7LS18", "T7LS18", JdeDataType.String, 8),
        new JdeField("T7OB09", "T7OB09", JdeDataType.String, 40),
        new JdeField("T7LEN0", "T7LEN0", JdeDataType.Numeric),
        new JdeField("T7LE10", "T7LE10", JdeDataType.String, 2),
        new JdeField("T7LS19", "T7LS19", JdeDataType.String, 8),
        new JdeField("T7LS20", "T7LS20", JdeDataType.String, 8),
        new JdeField("T7OB10", "T7OB10", JdeDataType.String, 40),
        new JdeField("T7USER", "T7USER", JdeDataType.String, 20),
        new JdeField("T7PID", "T7PID", JdeDataType.String, 20),
        new JdeField("T7JOBN", "T7JOBN", JdeDataType.String, 20),
        new JdeField("T7UPMJ", "T7UPMJ", JdeDataType.Numeric),
        new JdeField("T7TDAY", "T7TDAY", JdeDataType.Numeric),
        new JdeField("T7A0CC", "T7A0CC", JdeDataType.String, 20),
        new JdeField("T7A1CC", "T7A1CC", JdeDataType.String, 20),
        new JdeField("T7A2CC", "T7A2CC", JdeDataType.String, 20),
        new JdeField("T7A3CC", "T7A3CC", JdeDataType.String, 20),
        new JdeField("T7A4CC", "T7A4CC", JdeDataType.String, 20),
        new JdeField("T7A5CC", "T7A5CC", JdeDataType.String, 20),
        new JdeField("T7A6CC", "T7A6CC", JdeDataType.String, 20),
        new JdeField("T7A7CC", "T7A7CC", JdeDataType.String, 20),
        new JdeField("T7A8CC", "T7A8CC", JdeDataType.String, 20),
        new JdeField("T7A9CC", "T7A9CC", JdeDataType.String, 20),
        new JdeField("T7HSEG", "T7HSEG", JdeDataType.Numeric),
        new JdeField("T7NSEG", "T7NSEG", JdeDataType.Numeric),
        new JdeField("T7SGD0", "T7SGD0", JdeDataType.String, 30),
        new JdeField("T7SGD1", "T7SGD1", JdeDataType.String, 30),
        new JdeField("T7SGD2", "T7SGD2", JdeDataType.String, 30),
        new JdeField("T7SGD3", "T7SGD3", JdeDataType.String, 30),
        new JdeField("T7SGD4", "T7SGD4", JdeDataType.String, 30),
        new JdeField("T7SGD5", "T7SGD5", JdeDataType.String, 30),
        new JdeField("T7SGD6", "T7SGD6", JdeDataType.String, 30),
        new JdeField("T7SGD7", "T7SGD7", JdeDataType.String, 30),
        new JdeField("T7SGD8", "T7SGD8", JdeDataType.String, 30),
        new JdeField("T7SGD9", "T7SGD9", JdeDataType.String, 30),
        new JdeField("T7TDES", "T7TDES", JdeDataType.String, 60),
        new JdeField("T7VSEG", "T7VSEG", JdeDataType.Numeric),
        new JdeField("T7SEGA", "T7SEGA", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F410014_0", "Primary Key on T7TMPL, T7MCU", new[] { "T7TMPL", "T7MCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F410014_2", "Index on T7TMPL", new[] { "T7TMPL" }),
        new JdeIndex("F410014_3", "Index on T7MCU", new[] { "T7MCU" })
    };
}
