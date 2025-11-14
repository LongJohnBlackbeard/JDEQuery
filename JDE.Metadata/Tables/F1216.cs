using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1216 - .
/// </summary>
public class F1216 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GZNUMB.
        /// </summary>
        public const string GZNUMB = "GZNUMB";

        /// <summary>
        /// GZPGNM.
        /// </summary>
        public const string GZPGNM = "GZPGNM";

        /// <summary>
        /// GZFB01.
        /// </summary>
        public const string GZFB01 = "GZFB01";

        /// <summary>
        /// GZFB02.
        /// </summary>
        public const string GZFB02 = "GZFB02";

        /// <summary>
        /// GZFB03.
        /// </summary>
        public const string GZFB03 = "GZFB03";

        /// <summary>
        /// GZFB04.
        /// </summary>
        public const string GZFB04 = "GZFB04";

        /// <summary>
        /// GZFB05.
        /// </summary>
        public const string GZFB05 = "GZFB05";

        /// <summary>
        /// GZFB06.
        /// </summary>
        public const string GZFB06 = "GZFB06";

        /// <summary>
        /// GZFB07.
        /// </summary>
        public const string GZFB07 = "GZFB07";

        /// <summary>
        /// GZFB08.
        /// </summary>
        public const string GZFB08 = "GZFB08";

        /// <summary>
        /// GZFB09.
        /// </summary>
        public const string GZFB09 = "GZFB09";

        /// <summary>
        /// GZFB10.
        /// </summary>
        public const string GZFB10 = "GZFB10";

        /// <summary>
        /// GZFB11.
        /// </summary>
        public const string GZFB11 = "GZFB11";

        /// <summary>
        /// GZFB12.
        /// </summary>
        public const string GZFB12 = "GZFB12";

        /// <summary>
        /// GZFB13.
        /// </summary>
        public const string GZFB13 = "GZFB13";

        /// <summary>
        /// GZFB14.
        /// </summary>
        public const string GZFB14 = "GZFB14";

        /// <summary>
        /// GZFB15.
        /// </summary>
        public const string GZFB15 = "GZFB15";

        /// <summary>
        /// GZFB16.
        /// </summary>
        public const string GZFB16 = "GZFB16";
    }

    /// <inheritdoc />
    public override string TableName => "F1216";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GZNUMB", "GZNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("GZPGNM", "GZPGNM", JdeDataType.Numeric, null, true, true),
        new JdeField("GZFB01", "GZFB01", JdeDataType.String, 50),
        new JdeField("GZFB02", "GZFB02", JdeDataType.String, 50),
        new JdeField("GZFB03", "GZFB03", JdeDataType.String, 50),
        new JdeField("GZFB04", "GZFB04", JdeDataType.String, 50),
        new JdeField("GZFB05", "GZFB05", JdeDataType.String, 50),
        new JdeField("GZFB06", "GZFB06", JdeDataType.String, 50),
        new JdeField("GZFB07", "GZFB07", JdeDataType.String, 50),
        new JdeField("GZFB08", "GZFB08", JdeDataType.String, 50),
        new JdeField("GZFB09", "GZFB09", JdeDataType.String, 50),
        new JdeField("GZFB10", "GZFB10", JdeDataType.String, 50),
        new JdeField("GZFB11", "GZFB11", JdeDataType.String, 50),
        new JdeField("GZFB12", "GZFB12", JdeDataType.String, 50),
        new JdeField("GZFB13", "GZFB13", JdeDataType.String, 50),
        new JdeField("GZFB14", "GZFB14", JdeDataType.String, 50),
        new JdeField("GZFB15", "GZFB15", JdeDataType.String, 50),
        new JdeField("GZFB16", "GZFB16", JdeDataType.String, 50)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1216_0", "Primary Key on GZNUMB, GZPGNM", new[] { "GZNUMB", "GZPGNM" }, isUnique: true, isPrimaryKey: true)
    };
}
