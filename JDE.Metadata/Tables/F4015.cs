using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4015 - .
/// </summary>
public class F4015 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OTORTP.
        /// </summary>
        public const string OTORTP = "OTORTP";

        /// <summary>
        /// OTAN8.
        /// </summary>
        public const string OTAN8 = "OTAN8";

        /// <summary>
        /// OTOSEQ.
        /// </summary>
        public const string OTOSEQ = "OTOSEQ";

        /// <summary>
        /// OTITM.
        /// </summary>
        public const string OTITM = "OTITM";

        /// <summary>
        /// OTLITM.
        /// </summary>
        public const string OTLITM = "OTLITM";

        /// <summary>
        /// OTAITM.
        /// </summary>
        public const string OTAITM = "OTAITM";

        /// <summary>
        /// OTQTYU.
        /// </summary>
        public const string OTQTYU = "OTQTYU";

        /// <summary>
        /// OTUOM.
        /// </summary>
        public const string OTUOM = "OTUOM";

        /// <summary>
        /// OTLNTY.
        /// </summary>
        public const string OTLNTY = "OTLNTY";

        /// <summary>
        /// OTVEND.
        /// </summary>
        public const string OTVEND = "OTVEND";

        /// <summary>
        /// OTEFTJ.
        /// </summary>
        public const string OTEFTJ = "OTEFTJ";

        /// <summary>
        /// OTEXDJ.
        /// </summary>
        public const string OTEXDJ = "OTEXDJ";

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
    }

    /// <inheritdoc />
    public override string TableName => "F4015";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OTORTP", "OTORTP", JdeDataType.String, 16, true, true),
        new JdeField("OTAN8", "OTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("OTOSEQ", "OTOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("OTITM", "OTITM", JdeDataType.Numeric),
        new JdeField("OTLITM", "OTLITM", JdeDataType.String, 50),
        new JdeField("OTAITM", "OTAITM", JdeDataType.String, 50),
        new JdeField("OTQTYU", "OTQTYU", JdeDataType.Numeric),
        new JdeField("OTUOM", "OTUOM", JdeDataType.String, 4),
        new JdeField("OTLNTY", "OTLNTY", JdeDataType.String, 4),
        new JdeField("OTVEND", "OTVEND", JdeDataType.Numeric),
        new JdeField("OTEFTJ", "OTEFTJ", JdeDataType.Numeric),
        new JdeField("OTEXDJ", "OTEXDJ", JdeDataType.Numeric),
        new JdeField("OTURCD", "OTURCD", JdeDataType.String, 4),
        new JdeField("OTURDT", "OTURDT", JdeDataType.Numeric),
        new JdeField("OTURAT", "OTURAT", JdeDataType.Numeric),
        new JdeField("OTURAB", "OTURAB", JdeDataType.Numeric),
        new JdeField("OTURRF", "OTURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4015_0", "Primary Key on OTORTP, OTAN8, OTOSEQ", new[] { "OTORTP", "OTAN8", "OTOSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4015_2", "Index on OTAN8", new[] { "OTAN8" }),
        new JdeIndex("F4015_3", "Index on OTAN8, OTITM", new[] { "OTAN8", "OTITM" }),
        new JdeIndex("F4015_4", "Index on OTORTP, OTAN8, OTITM", new[] { "OTORTP", "OTAN8", "OTITM" })
    };
}
