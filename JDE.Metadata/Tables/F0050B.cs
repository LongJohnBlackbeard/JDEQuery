using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0050B - .
/// </summary>
public class F0050B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MAOTPS.
        /// </summary>
        public const string MAOTPS = "MAOTPS";

        /// <summary>
        /// MADL01.
        /// </summary>
        public const string MADL01 = "MADL01";

        /// <summary>
        /// MALV01.
        /// </summary>
        public const string MALV01 = "MALV01";

        /// <summary>
        /// MAOD01.
        /// </summary>
        public const string MAOD01 = "MAOD01";

        /// <summary>
        /// MALV02.
        /// </summary>
        public const string MALV02 = "MALV02";

        /// <summary>
        /// MAOD02.
        /// </summary>
        public const string MAOD02 = "MAOD02";

        /// <summary>
        /// MALV03.
        /// </summary>
        public const string MALV03 = "MALV03";

        /// <summary>
        /// MAOD03.
        /// </summary>
        public const string MAOD03 = "MAOD03";

        /// <summary>
        /// MALV04.
        /// </summary>
        public const string MALV04 = "MALV04";

        /// <summary>
        /// MAOD04.
        /// </summary>
        public const string MAOD04 = "MAOD04";

        /// <summary>
        /// MALV05.
        /// </summary>
        public const string MALV05 = "MALV05";

        /// <summary>
        /// MAOD05.
        /// </summary>
        public const string MAOD05 = "MAOD05";

        /// <summary>
        /// MALV06.
        /// </summary>
        public const string MALV06 = "MALV06";

        /// <summary>
        /// MAOD06.
        /// </summary>
        public const string MAOD06 = "MAOD06";

        /// <summary>
        /// MALV07.
        /// </summary>
        public const string MALV07 = "MALV07";

        /// <summary>
        /// MAOD07.
        /// </summary>
        public const string MAOD07 = "MAOD07";

        /// <summary>
        /// MALV08.
        /// </summary>
        public const string MALV08 = "MALV08";

        /// <summary>
        /// MAOD08.
        /// </summary>
        public const string MAOD08 = "MAOD08";

        /// <summary>
        /// MALV09.
        /// </summary>
        public const string MALV09 = "MALV09";

        /// <summary>
        /// MAOD09.
        /// </summary>
        public const string MAOD09 = "MAOD09";

        /// <summary>
        /// MALV10.
        /// </summary>
        public const string MALV10 = "MALV10";

        /// <summary>
        /// MAOD10.
        /// </summary>
        public const string MAOD10 = "MAOD10";

        /// <summary>
        /// MALV11.
        /// </summary>
        public const string MALV11 = "MALV11";

        /// <summary>
        /// MAOD11.
        /// </summary>
        public const string MAOD11 = "MAOD11";

        /// <summary>
        /// MALV12.
        /// </summary>
        public const string MALV12 = "MALV12";

        /// <summary>
        /// MAOD12.
        /// </summary>
        public const string MAOD12 = "MAOD12";

        /// <summary>
        /// MALV13.
        /// </summary>
        public const string MALV13 = "MALV13";

        /// <summary>
        /// MAOD13.
        /// </summary>
        public const string MAOD13 = "MAOD13";

        /// <summary>
        /// MALV14.
        /// </summary>
        public const string MALV14 = "MALV14";

        /// <summary>
        /// MAOD14.
        /// </summary>
        public const string MAOD14 = "MAOD14";

        /// <summary>
        /// MALV15.
        /// </summary>
        public const string MALV15 = "MALV15";

        /// <summary>
        /// MAOD15.
        /// </summary>
        public const string MAOD15 = "MAOD15";

        /// <summary>
        /// MALV16.
        /// </summary>
        public const string MALV16 = "MALV16";

        /// <summary>
        /// MAOD16.
        /// </summary>
        public const string MAOD16 = "MAOD16";

        /// <summary>
        /// MALV17.
        /// </summary>
        public const string MALV17 = "MALV17";

        /// <summary>
        /// MAOD17.
        /// </summary>
        public const string MAOD17 = "MAOD17";

        /// <summary>
        /// MALV18.
        /// </summary>
        public const string MALV18 = "MALV18";

        /// <summary>
        /// MAOD18.
        /// </summary>
        public const string MAOD18 = "MAOD18";

        /// <summary>
        /// MALV19.
        /// </summary>
        public const string MALV19 = "MALV19";

        /// <summary>
        /// MAOD19.
        /// </summary>
        public const string MAOD19 = "MAOD19";

        /// <summary>
        /// MALV20.
        /// </summary>
        public const string MALV20 = "MALV20";

        /// <summary>
        /// MAOD20.
        /// </summary>
        public const string MAOD20 = "MAOD20";

        /// <summary>
        /// MAEFFF.
        /// </summary>
        public const string MAEFFF = "MAEFFF";

        /// <summary>
        /// MANET.
        /// </summary>
        public const string MANET = "MANET";

        /// <summary>
        /// MAPID.
        /// </summary>
        public const string MAPID = "MAPID";

        /// <summary>
        /// MAJOBN.
        /// </summary>
        public const string MAJOBN = "MAJOBN";

        /// <summary>
        /// MAUPMJ.
        /// </summary>
        public const string MAUPMJ = "MAUPMJ";

        /// <summary>
        /// MATDAY.
        /// </summary>
        public const string MATDAY = "MATDAY";

        /// <summary>
        /// MACO.
        /// </summary>
        public const string MACO = "MACO";
    }

    /// <inheritdoc />
    public override string TableName => "F0050B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MAOTPS", "MAOTPS", JdeDataType.String, 6, true, true),
        new JdeField("MADL01", "MADL01", JdeDataType.String, 60),
        new JdeField("MALV01", "MALV01", JdeDataType.String, 10),
        new JdeField("MAOD01", "MAOD01", JdeDataType.String, 80),
        new JdeField("MALV02", "MALV02", JdeDataType.String, 10),
        new JdeField("MAOD02", "MAOD02", JdeDataType.String, 80),
        new JdeField("MALV03", "MALV03", JdeDataType.String, 10),
        new JdeField("MAOD03", "MAOD03", JdeDataType.String, 80),
        new JdeField("MALV04", "MALV04", JdeDataType.String, 10),
        new JdeField("MAOD04", "MAOD04", JdeDataType.String, 80),
        new JdeField("MALV05", "MALV05", JdeDataType.String, 10),
        new JdeField("MAOD05", "MAOD05", JdeDataType.String, 80),
        new JdeField("MALV06", "MALV06", JdeDataType.String, 10),
        new JdeField("MAOD06", "MAOD06", JdeDataType.String, 80),
        new JdeField("MALV07", "MALV07", JdeDataType.String, 10),
        new JdeField("MAOD07", "MAOD07", JdeDataType.String, 80),
        new JdeField("MALV08", "MALV08", JdeDataType.String, 10),
        new JdeField("MAOD08", "MAOD08", JdeDataType.String, 80),
        new JdeField("MALV09", "MALV09", JdeDataType.String, 10),
        new JdeField("MAOD09", "MAOD09", JdeDataType.String, 80),
        new JdeField("MALV10", "MALV10", JdeDataType.String, 10),
        new JdeField("MAOD10", "MAOD10", JdeDataType.String, 80),
        new JdeField("MALV11", "MALV11", JdeDataType.String, 10),
        new JdeField("MAOD11", "MAOD11", JdeDataType.String, 80),
        new JdeField("MALV12", "MALV12", JdeDataType.String, 10),
        new JdeField("MAOD12", "MAOD12", JdeDataType.String, 80),
        new JdeField("MALV13", "MALV13", JdeDataType.String, 10),
        new JdeField("MAOD13", "MAOD13", JdeDataType.String, 80),
        new JdeField("MALV14", "MALV14", JdeDataType.String, 10),
        new JdeField("MAOD14", "MAOD14", JdeDataType.String, 80),
        new JdeField("MALV15", "MALV15", JdeDataType.String, 10),
        new JdeField("MAOD15", "MAOD15", JdeDataType.String, 80),
        new JdeField("MALV16", "MALV16", JdeDataType.String, 10),
        new JdeField("MAOD16", "MAOD16", JdeDataType.String, 80),
        new JdeField("MALV17", "MALV17", JdeDataType.String, 10),
        new JdeField("MAOD17", "MAOD17", JdeDataType.String, 80),
        new JdeField("MALV18", "MALV18", JdeDataType.String, 10),
        new JdeField("MAOD18", "MAOD18", JdeDataType.String, 80),
        new JdeField("MALV19", "MALV19", JdeDataType.String, 10),
        new JdeField("MAOD19", "MAOD19", JdeDataType.String, 80),
        new JdeField("MALV20", "MALV20", JdeDataType.String, 10),
        new JdeField("MAOD20", "MAOD20", JdeDataType.String, 80),
        new JdeField("MAEFFF", "MAEFFF", JdeDataType.Numeric),
        new JdeField("MANET", "MANET", JdeDataType.Numeric),
        new JdeField("MAPID", "MAPID", JdeDataType.String, 20),
        new JdeField("MAJOBN", "MAJOBN", JdeDataType.String, 20),
        new JdeField("MAUPMJ", "MAUPMJ", JdeDataType.Numeric),
        new JdeField("MATDAY", "MATDAY", JdeDataType.Numeric),
        new JdeField("MACO", "MACO", JdeDataType.String, 10)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0050B_0", "Primary Key on MAOTPS", new[] { "MAOTPS" }, isUnique: true, isPrimaryKey: true)
    };
}
