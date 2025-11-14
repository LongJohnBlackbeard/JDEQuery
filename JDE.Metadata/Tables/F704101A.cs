using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F704101A - .
/// </summary>
public class F704101A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LAITM.
        /// </summary>
        public const string LAITM = "LAITM";

        /// <summary>
        /// LALCTR.
        /// </summary>
        public const string LALCTR = "LALCTR";

        /// <summary>
        /// LAK70ADSTR.
        /// </summary>
        public const string LAK70ADSTR = "LAK70ADSTR";

        /// <summary>
        /// LAK70ADS01.
        /// </summary>
        public const string LAK70ADS01 = "LAK70ADS01";

        /// <summary>
        /// LAK70ADS02.
        /// </summary>
        public const string LAK70ADS02 = "LAK70ADS02";

        /// <summary>
        /// LAK70ADS03.
        /// </summary>
        public const string LAK70ADS03 = "LAK70ADS03";

        /// <summary>
        /// LAK70ADS04.
        /// </summary>
        public const string LAK70ADS04 = "LAK70ADS04";

        /// <summary>
        /// LAK70ADS05.
        /// </summary>
        public const string LAK70ADS05 = "LAK70ADS05";

        /// <summary>
        /// LAK70ADS06.
        /// </summary>
        public const string LAK70ADS06 = "LAK70ADS06";

        /// <summary>
        /// LAK70ADS07.
        /// </summary>
        public const string LAK70ADS07 = "LAK70ADS07";

        /// <summary>
        /// LAK70ADS08.
        /// </summary>
        public const string LAK70ADS08 = "LAK70ADS08";

        /// <summary>
        /// LAK70ADS09.
        /// </summary>
        public const string LAK70ADS09 = "LAK70ADS09";

        /// <summary>
        /// LAK70ADS10.
        /// </summary>
        public const string LAK70ADS10 = "LAK70ADS10";

        /// <summary>
        /// LAK70ADS11.
        /// </summary>
        public const string LAK70ADS11 = "LAK70ADS11";

        /// <summary>
        /// LAK70ADS12.
        /// </summary>
        public const string LAK70ADS12 = "LAK70ADS12";

        /// <summary>
        /// LAK70ADS13.
        /// </summary>
        public const string LAK70ADS13 = "LAK70ADS13";

        /// <summary>
        /// LAK70ADS14.
        /// </summary>
        public const string LAK70ADS14 = "LAK70ADS14";

        /// <summary>
        /// LAK70ADS15.
        /// </summary>
        public const string LAK70ADS15 = "LAK70ADS15";

        /// <summary>
        /// LAK70ADS16.
        /// </summary>
        public const string LAK70ADS16 = "LAK70ADS16";

        /// <summary>
        /// LAK70ADS17.
        /// </summary>
        public const string LAK70ADS17 = "LAK70ADS17";

        /// <summary>
        /// LAK70ADS18.
        /// </summary>
        public const string LAK70ADS18 = "LAK70ADS18";

        /// <summary>
        /// LAK70ADS19.
        /// </summary>
        public const string LAK70ADS19 = "LAK70ADS19";

        /// <summary>
        /// LAK70ADS20.
        /// </summary>
        public const string LAK70ADS20 = "LAK70ADS20";

        /// <summary>
        /// LAK70ADN01.
        /// </summary>
        public const string LAK70ADN01 = "LAK70ADN01";

        /// <summary>
        /// LAK70ADN02.
        /// </summary>
        public const string LAK70ADN02 = "LAK70ADN02";

        /// <summary>
        /// LAK70ADN03.
        /// </summary>
        public const string LAK70ADN03 = "LAK70ADN03";

        /// <summary>
        /// LAK70ADN04.
        /// </summary>
        public const string LAK70ADN04 = "LAK70ADN04";

        /// <summary>
        /// LAK70ADN05.
        /// </summary>
        public const string LAK70ADN05 = "LAK70ADN05";

        /// <summary>
        /// LAK70ADN06.
        /// </summary>
        public const string LAK70ADN06 = "LAK70ADN06";

        /// <summary>
        /// LAK70ADN07.
        /// </summary>
        public const string LAK70ADN07 = "LAK70ADN07";

        /// <summary>
        /// LAK70ADN08.
        /// </summary>
        public const string LAK70ADN08 = "LAK70ADN08";

        /// <summary>
        /// LAK70ADN09.
        /// </summary>
        public const string LAK70ADN09 = "LAK70ADN09";

        /// <summary>
        /// LAK70ADN10.
        /// </summary>
        public const string LAK70ADN10 = "LAK70ADN10";

        /// <summary>
        /// LAK70ADD01.
        /// </summary>
        public const string LAK70ADD01 = "LAK70ADD01";

        /// <summary>
        /// LAK70ADD02.
        /// </summary>
        public const string LAK70ADD02 = "LAK70ADD02";

        /// <summary>
        /// LAK70ADD03.
        /// </summary>
        public const string LAK70ADD03 = "LAK70ADD03";

        /// <summary>
        /// LAK70ADD04.
        /// </summary>
        public const string LAK70ADD04 = "LAK70ADD04";

        /// <summary>
        /// LAK70ADD05.
        /// </summary>
        public const string LAK70ADD05 = "LAK70ADD05";

        /// <summary>
        /// LAK70ADD06.
        /// </summary>
        public const string LAK70ADD06 = "LAK70ADD06";

        /// <summary>
        /// LAK70ADD07.
        /// </summary>
        public const string LAK70ADD07 = "LAK70ADD07";

        /// <summary>
        /// LAK70ADD08.
        /// </summary>
        public const string LAK70ADD08 = "LAK70ADD08";

        /// <summary>
        /// LAK70ADD09.
        /// </summary>
        public const string LAK70ADD09 = "LAK70ADD09";

        /// <summary>
        /// LAK70ADD10.
        /// </summary>
        public const string LAK70ADD10 = "LAK70ADD10";

        /// <summary>
        /// LAK70ADC01.
        /// </summary>
        public const string LAK70ADC01 = "LAK70ADC01";

        /// <summary>
        /// LAK70ADC02.
        /// </summary>
        public const string LAK70ADC02 = "LAK70ADC02";

        /// <summary>
        /// LAK70ADC03.
        /// </summary>
        public const string LAK70ADC03 = "LAK70ADC03";

        /// <summary>
        /// LAK70ADC04.
        /// </summary>
        public const string LAK70ADC04 = "LAK70ADC04";

        /// <summary>
        /// LAK70ADC05.
        /// </summary>
        public const string LAK70ADC05 = "LAK70ADC05";

        /// <summary>
        /// LAK70ADC06.
        /// </summary>
        public const string LAK70ADC06 = "LAK70ADC06";

        /// <summary>
        /// LAK70ADC07.
        /// </summary>
        public const string LAK70ADC07 = "LAK70ADC07";

        /// <summary>
        /// LAK70ADC08.
        /// </summary>
        public const string LAK70ADC08 = "LAK70ADC08";

        /// <summary>
        /// LAK70ADC09.
        /// </summary>
        public const string LAK70ADC09 = "LAK70ADC09";

        /// <summary>
        /// LAK70ADC10.
        /// </summary>
        public const string LAK70ADC10 = "LAK70ADC10";

        /// <summary>
        /// LABCRC.
        /// </summary>
        public const string LABCRC = "LABCRC";

        /// <summary>
        /// LACRCD.
        /// </summary>
        public const string LACRCD = "LACRCD";

        /// <summary>
        /// LAUSER.
        /// </summary>
        public const string LAUSER = "LAUSER";

        /// <summary>
        /// LAPID.
        /// </summary>
        public const string LAPID = "LAPID";

        /// <summary>
        /// LAUPMJ.
        /// </summary>
        public const string LAUPMJ = "LAUPMJ";

        /// <summary>
        /// LAUPMT.
        /// </summary>
        public const string LAUPMT = "LAUPMT";

        /// <summary>
        /// LAJOBN.
        /// </summary>
        public const string LAJOBN = "LAJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F704101A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LAITM", "LAITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LALCTR", "LALCTR", JdeDataType.String, 6, true, true),
        new JdeField("LAK70ADSTR", "LAK70ADSTR", JdeDataType.String, 20, true, true),
        new JdeField("LAK70ADS01", "LAK70ADS01", JdeDataType.String, 300),
        new JdeField("LAK70ADS02", "LAK70ADS02", JdeDataType.String, 300),
        new JdeField("LAK70ADS03", "LAK70ADS03", JdeDataType.String, 300),
        new JdeField("LAK70ADS04", "LAK70ADS04", JdeDataType.String, 300),
        new JdeField("LAK70ADS05", "LAK70ADS05", JdeDataType.String, 300),
        new JdeField("LAK70ADS06", "LAK70ADS06", JdeDataType.String, 300),
        new JdeField("LAK70ADS07", "LAK70ADS07", JdeDataType.String, 300),
        new JdeField("LAK70ADS08", "LAK70ADS08", JdeDataType.String, 300),
        new JdeField("LAK70ADS09", "LAK70ADS09", JdeDataType.String, 300),
        new JdeField("LAK70ADS10", "LAK70ADS10", JdeDataType.String, 300),
        new JdeField("LAK70ADS11", "LAK70ADS11", JdeDataType.String, 300),
        new JdeField("LAK70ADS12", "LAK70ADS12", JdeDataType.String, 300),
        new JdeField("LAK70ADS13", "LAK70ADS13", JdeDataType.String, 300),
        new JdeField("LAK70ADS14", "LAK70ADS14", JdeDataType.String, 300),
        new JdeField("LAK70ADS15", "LAK70ADS15", JdeDataType.String, 300),
        new JdeField("LAK70ADS16", "LAK70ADS16", JdeDataType.String, 300),
        new JdeField("LAK70ADS17", "LAK70ADS17", JdeDataType.String, 300),
        new JdeField("LAK70ADS18", "LAK70ADS18", JdeDataType.String, 300),
        new JdeField("LAK70ADS19", "LAK70ADS19", JdeDataType.String, 300),
        new JdeField("LAK70ADS20", "LAK70ADS20", JdeDataType.String, 300),
        new JdeField("LAK70ADN01", "LAK70ADN01", JdeDataType.Numeric),
        new JdeField("LAK70ADN02", "LAK70ADN02", JdeDataType.Numeric),
        new JdeField("LAK70ADN03", "LAK70ADN03", JdeDataType.Numeric),
        new JdeField("LAK70ADN04", "LAK70ADN04", JdeDataType.Numeric),
        new JdeField("LAK70ADN05", "LAK70ADN05", JdeDataType.Numeric),
        new JdeField("LAK70ADN06", "LAK70ADN06", JdeDataType.Numeric),
        new JdeField("LAK70ADN07", "LAK70ADN07", JdeDataType.Numeric),
        new JdeField("LAK70ADN08", "LAK70ADN08", JdeDataType.Numeric),
        new JdeField("LAK70ADN09", "LAK70ADN09", JdeDataType.Numeric),
        new JdeField("LAK70ADN10", "LAK70ADN10", JdeDataType.Numeric),
        new JdeField("LAK70ADD01", "LAK70ADD01", JdeDataType.Numeric),
        new JdeField("LAK70ADD02", "LAK70ADD02", JdeDataType.Numeric),
        new JdeField("LAK70ADD03", "LAK70ADD03", JdeDataType.Numeric),
        new JdeField("LAK70ADD04", "LAK70ADD04", JdeDataType.Numeric),
        new JdeField("LAK70ADD05", "LAK70ADD05", JdeDataType.Numeric),
        new JdeField("LAK70ADD06", "LAK70ADD06", JdeDataType.Numeric),
        new JdeField("LAK70ADD07", "LAK70ADD07", JdeDataType.Numeric),
        new JdeField("LAK70ADD08", "LAK70ADD08", JdeDataType.Numeric),
        new JdeField("LAK70ADD09", "LAK70ADD09", JdeDataType.Numeric),
        new JdeField("LAK70ADD10", "LAK70ADD10", JdeDataType.Numeric),
        new JdeField("LAK70ADC01", "LAK70ADC01", JdeDataType.String, 2),
        new JdeField("LAK70ADC02", "LAK70ADC02", JdeDataType.String, 2),
        new JdeField("LAK70ADC03", "LAK70ADC03", JdeDataType.String, 2),
        new JdeField("LAK70ADC04", "LAK70ADC04", JdeDataType.String, 2),
        new JdeField("LAK70ADC05", "LAK70ADC05", JdeDataType.String, 2),
        new JdeField("LAK70ADC06", "LAK70ADC06", JdeDataType.String, 2),
        new JdeField("LAK70ADC07", "LAK70ADC07", JdeDataType.String, 2),
        new JdeField("LAK70ADC08", "LAK70ADC08", JdeDataType.String, 2),
        new JdeField("LAK70ADC09", "LAK70ADC09", JdeDataType.String, 2),
        new JdeField("LAK70ADC10", "LAK70ADC10", JdeDataType.String, 2),
        new JdeField("LABCRC", "LABCRC", JdeDataType.String, 6),
        new JdeField("LACRCD", "LACRCD", JdeDataType.String, 6),
        new JdeField("LAUSER", "LAUSER", JdeDataType.String, 20),
        new JdeField("LAPID", "LAPID", JdeDataType.String, 20),
        new JdeField("LAUPMJ", "LAUPMJ", JdeDataType.Numeric),
        new JdeField("LAUPMT", "LAUPMT", JdeDataType.Numeric),
        new JdeField("LAJOBN", "LAJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F704101A_0", "Primary Key on LAITM, LALCTR, LAK70ADSTR", new[] { "LAITM", "LALCTR", "LAK70ADSTR" }, isUnique: true, isPrimaryKey: true)
    };
}
