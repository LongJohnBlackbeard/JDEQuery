using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15L105 - .
/// </summary>
public class F15L105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GPMCU.
        /// </summary>
        public const string GPMCU = "GPMCU";

        /// <summary>
        /// GPGRPA.
        /// </summary>
        public const string GPGRPA = "GPGRPA";

        /// <summary>
        /// GPRVNB.
        /// </summary>
        public const string GPRVNB = "GPRVNB";

        /// <summary>
        /// GPDS50.
        /// </summary>
        public const string GPDS50 = "GPDS50";

        /// <summary>
        /// GPGPTT.
        /// </summary>
        public const string GPGPTT = "GPGPTT";

        /// <summary>
        /// GPGW01.
        /// </summary>
        public const string GPGW01 = "GPGW01";

        /// <summary>
        /// GPGW02.
        /// </summary>
        public const string GPGW02 = "GPGW02";

        /// <summary>
        /// GPGW03.
        /// </summary>
        public const string GPGW03 = "GPGW03";

        /// <summary>
        /// GPGW04.
        /// </summary>
        public const string GPGW04 = "GPGW04";

        /// <summary>
        /// GPGW05.
        /// </summary>
        public const string GPGW05 = "GPGW05";

        /// <summary>
        /// GPGW06.
        /// </summary>
        public const string GPGW06 = "GPGW06";

        /// <summary>
        /// GPGW07.
        /// </summary>
        public const string GPGW07 = "GPGW07";

        /// <summary>
        /// GPGW08.
        /// </summary>
        public const string GPGW08 = "GPGW08";

        /// <summary>
        /// GPGW09.
        /// </summary>
        public const string GPGW09 = "GPGW09";

        /// <summary>
        /// GPGW10.
        /// </summary>
        public const string GPGW10 = "GPGW10";

        /// <summary>
        /// GPGW11.
        /// </summary>
        public const string GPGW11 = "GPGW11";

        /// <summary>
        /// GPGW12.
        /// </summary>
        public const string GPGW12 = "GPGW12";

        /// <summary>
        /// GPGW13.
        /// </summary>
        public const string GPGW13 = "GPGW13";

        /// <summary>
        /// GPGW14.
        /// </summary>
        public const string GPGW14 = "GPGW14";

        /// <summary>
        /// GPGW15.
        /// </summary>
        public const string GPGW15 = "GPGW15";

        /// <summary>
        /// GPUR01.
        /// </summary>
        public const string GPUR01 = "GPUR01";

        /// <summary>
        /// GPUR02.
        /// </summary>
        public const string GPUR02 = "GPUR02";

        /// <summary>
        /// GPUR03.
        /// </summary>
        public const string GPUR03 = "GPUR03";

        /// <summary>
        /// GPUR04.
        /// </summary>
        public const string GPUR04 = "GPUR04";

        /// <summary>
        /// GPUR05.
        /// </summary>
        public const string GPUR05 = "GPUR05";

        /// <summary>
        /// GPURCD.
        /// </summary>
        public const string GPURCD = "GPURCD";

        /// <summary>
        /// GPURDT.
        /// </summary>
        public const string GPURDT = "GPURDT";

        /// <summary>
        /// GPURAT.
        /// </summary>
        public const string GPURAT = "GPURAT";

        /// <summary>
        /// GPURAB.
        /// </summary>
        public const string GPURAB = "GPURAB";

        /// <summary>
        /// GPURRF.
        /// </summary>
        public const string GPURRF = "GPURRF";

        /// <summary>
        /// GPUSER.
        /// </summary>
        public const string GPUSER = "GPUSER";

        /// <summary>
        /// GPPID.
        /// </summary>
        public const string GPPID = "GPPID";

        /// <summary>
        /// GPJOBN.
        /// </summary>
        public const string GPJOBN = "GPJOBN";

        /// <summary>
        /// GPUPMJ.
        /// </summary>
        public const string GPUPMJ = "GPUPMJ";

        /// <summary>
        /// GPUPMT.
        /// </summary>
        public const string GPUPMT = "GPUPMT";

        /// <summary>
        /// GPTORG.
        /// </summary>
        public const string GPTORG = "GPTORG";

        /// <summary>
        /// GPENTJ.
        /// </summary>
        public const string GPENTJ = "GPENTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F15L105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GPMCU", "GPMCU", JdeDataType.String, 24, true, true),
        new JdeField("GPGRPA", "GPGRPA", JdeDataType.String, 20, true, true),
        new JdeField("GPRVNB", "GPRVNB", JdeDataType.Numeric, null, true, true),
        new JdeField("GPDS50", "GPDS50", JdeDataType.String, 100),
        new JdeField("GPGPTT", "GPGPTT", JdeDataType.String, 4),
        new JdeField("GPGW01", "GPGW01", JdeDataType.Numeric),
        new JdeField("GPGW02", "GPGW02", JdeDataType.Numeric),
        new JdeField("GPGW03", "GPGW03", JdeDataType.Numeric),
        new JdeField("GPGW04", "GPGW04", JdeDataType.Numeric),
        new JdeField("GPGW05", "GPGW05", JdeDataType.Numeric),
        new JdeField("GPGW06", "GPGW06", JdeDataType.Numeric),
        new JdeField("GPGW07", "GPGW07", JdeDataType.Numeric),
        new JdeField("GPGW08", "GPGW08", JdeDataType.Numeric),
        new JdeField("GPGW09", "GPGW09", JdeDataType.Numeric),
        new JdeField("GPGW10", "GPGW10", JdeDataType.Numeric),
        new JdeField("GPGW11", "GPGW11", JdeDataType.Numeric),
        new JdeField("GPGW12", "GPGW12", JdeDataType.Numeric),
        new JdeField("GPGW13", "GPGW13", JdeDataType.Numeric),
        new JdeField("GPGW14", "GPGW14", JdeDataType.Numeric),
        new JdeField("GPGW15", "GPGW15", JdeDataType.Numeric),
        new JdeField("GPUR01", "GPUR01", JdeDataType.String, 6),
        new JdeField("GPUR02", "GPUR02", JdeDataType.String, 6),
        new JdeField("GPUR03", "GPUR03", JdeDataType.String, 6),
        new JdeField("GPUR04", "GPUR04", JdeDataType.String, 6),
        new JdeField("GPUR05", "GPUR05", JdeDataType.String, 6),
        new JdeField("GPURCD", "GPURCD", JdeDataType.String, 4),
        new JdeField("GPURDT", "GPURDT", JdeDataType.Numeric),
        new JdeField("GPURAT", "GPURAT", JdeDataType.Numeric),
        new JdeField("GPURAB", "GPURAB", JdeDataType.Numeric),
        new JdeField("GPURRF", "GPURRF", JdeDataType.String, 30),
        new JdeField("GPUSER", "GPUSER", JdeDataType.String, 20),
        new JdeField("GPPID", "GPPID", JdeDataType.String, 20),
        new JdeField("GPJOBN", "GPJOBN", JdeDataType.String, 20),
        new JdeField("GPUPMJ", "GPUPMJ", JdeDataType.Numeric),
        new JdeField("GPUPMT", "GPUPMT", JdeDataType.Numeric),
        new JdeField("GPTORG", "GPTORG", JdeDataType.String, 20),
        new JdeField("GPENTJ", "GPENTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15L105_0", "Primary Key on GPMCU, GPGRPA, GPRVNB", new[] { "GPMCU", "GPGRPA", "GPRVNB" }, isUnique: true, isPrimaryKey: true)
    };
}
