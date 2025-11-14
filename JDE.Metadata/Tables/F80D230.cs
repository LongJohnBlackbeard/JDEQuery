using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D230 - .
/// </summary>
public class F80D230 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OTDRQJ.
        /// </summary>
        public const string OTDRQJ = "OTDRQJ";

        /// <summary>
        /// OTITM.
        /// </summary>
        public const string OTITM = "OTITM";

        /// <summary>
        /// OTMCU.
        /// </summary>
        public const string OTMCU = "OTMCU";

        /// <summary>
        /// OTLWOC.
        /// </summary>
        public const string OTLWOC = "OTLWOC";

        /// <summary>
        /// OTEWOC.
        /// </summary>
        public const string OTEWOC = "OTEWOC";

        /// <summary>
        /// OTOTWOC.
        /// </summary>
        public const string OTOTWOC = "OTOTWOC";

        /// <summary>
        /// OTURCD.
        /// </summary>
        public const string OTURCD = "OTURCD";

        /// <summary>
        /// OTURDT.
        /// </summary>
        public const string OTURDT = "OTURDT";

        /// <summary>
        /// OTURAT.
        /// </summary>
        public const string OTURAT = "OTURAT";

        /// <summary>
        /// OTURAB.
        /// </summary>
        public const string OTURAB = "OTURAB";

        /// <summary>
        /// OTURRF.
        /// </summary>
        public const string OTURRF = "OTURRF";

        /// <summary>
        /// OTMKEY.
        /// </summary>
        public const string OTMKEY = "OTMKEY";

        /// <summary>
        /// OTUSER.
        /// </summary>
        public const string OTUSER = "OTUSER";

        /// <summary>
        /// OTPID.
        /// </summary>
        public const string OTPID = "OTPID";

        /// <summary>
        /// OTUPMJ.
        /// </summary>
        public const string OTUPMJ = "OTUPMJ";

        /// <summary>
        /// OTTDAY.
        /// </summary>
        public const string OTTDAY = "OTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F80D230";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OTDRQJ", "OTDRQJ", JdeDataType.Numeric, null, true, true),
        new JdeField("OTITM", "OTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("OTMCU", "OTMCU", JdeDataType.String, 24, true, true),
        new JdeField("OTLWOC", "OTLWOC", JdeDataType.Numeric),
        new JdeField("OTEWOC", "OTEWOC", JdeDataType.Numeric),
        new JdeField("OTOTWOC", "OTOTWOC", JdeDataType.Numeric),
        new JdeField("OTURCD", "OTURCD", JdeDataType.String, 4),
        new JdeField("OTURDT", "OTURDT", JdeDataType.Numeric),
        new JdeField("OTURAT", "OTURAT", JdeDataType.Numeric),
        new JdeField("OTURAB", "OTURAB", JdeDataType.Numeric),
        new JdeField("OTURRF", "OTURRF", JdeDataType.String, 30),
        new JdeField("OTMKEY", "OTMKEY", JdeDataType.String, 30),
        new JdeField("OTUSER", "OTUSER", JdeDataType.String, 20),
        new JdeField("OTPID", "OTPID", JdeDataType.String, 20),
        new JdeField("OTUPMJ", "OTUPMJ", JdeDataType.Numeric),
        new JdeField("OTTDAY", "OTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D230_0", "Primary Key on OTDRQJ, OTMCU, OTITM", new[] { "OTDRQJ", "OTMCU", "OTITM" }, isUnique: true, isPrimaryKey: true)
    };
}
