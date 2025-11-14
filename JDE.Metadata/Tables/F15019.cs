using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15019 - .
/// </summary>
public class F15019 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NLBLFC.
        /// </summary>
        public const string NLBLFC = "NLBLFC";

        /// <summary>
        /// NLDL01.
        /// </summary>
        public const string NLDL01 = "NLDL01";

        /// <summary>
        /// NLBF01.
        /// </summary>
        public const string NLBF01 = "NLBF01";

        /// <summary>
        /// NLBF02.
        /// </summary>
        public const string NLBF02 = "NLBF02";

        /// <summary>
        /// NLBF03.
        /// </summary>
        public const string NLBF03 = "NLBF03";

        /// <summary>
        /// NLBF04.
        /// </summary>
        public const string NLBF04 = "NLBF04";

        /// <summary>
        /// NLBF05.
        /// </summary>
        public const string NLBF05 = "NLBF05";

        /// <summary>
        /// NLBF06.
        /// </summary>
        public const string NLBF06 = "NLBF06";

        /// <summary>
        /// NLBF07.
        /// </summary>
        public const string NLBF07 = "NLBF07";

        /// <summary>
        /// NLBF08.
        /// </summary>
        public const string NLBF08 = "NLBF08";

        /// <summary>
        /// NLBF09.
        /// </summary>
        public const string NLBF09 = "NLBF09";

        /// <summary>
        /// NLBF10.
        /// </summary>
        public const string NLBF10 = "NLBF10";

        /// <summary>
        /// NLBF11.
        /// </summary>
        public const string NLBF11 = "NLBF11";

        /// <summary>
        /// NLBF12.
        /// </summary>
        public const string NLBF12 = "NLBF12";

        /// <summary>
        /// NLBF13.
        /// </summary>
        public const string NLBF13 = "NLBF13";

        /// <summary>
        /// NLBF14.
        /// </summary>
        public const string NLBF14 = "NLBF14";

        /// <summary>
        /// NLDTPN.
        /// </summary>
        public const string NLDTPN = "NLDTPN";

        /// <summary>
        /// NLFDYS.
        /// </summary>
        public const string NLFDYS = "NLFDYS";

        /// <summary>
        /// NLNBR0.
        /// </summary>
        public const string NLNBR0 = "NLNBR0";

        /// <summary>
        /// NLURCD.
        /// </summary>
        public const string NLURCD = "NLURCD";

        /// <summary>
        /// NLURDT.
        /// </summary>
        public const string NLURDT = "NLURDT";

        /// <summary>
        /// NLURAT.
        /// </summary>
        public const string NLURAT = "NLURAT";

        /// <summary>
        /// NLURAB.
        /// </summary>
        public const string NLURAB = "NLURAB";

        /// <summary>
        /// NLURRF.
        /// </summary>
        public const string NLURRF = "NLURRF";

        /// <summary>
        /// NLUSER.
        /// </summary>
        public const string NLUSER = "NLUSER";

        /// <summary>
        /// NLPID.
        /// </summary>
        public const string NLPID = "NLPID";

        /// <summary>
        /// NLUPMJ.
        /// </summary>
        public const string NLUPMJ = "NLUPMJ";

        /// <summary>
        /// NLUPMT.
        /// </summary>
        public const string NLUPMT = "NLUPMT";

        /// <summary>
        /// NLJOBN.
        /// </summary>
        public const string NLJOBN = "NLJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F15019";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NLBLFC", "NLBLFC", JdeDataType.String, 2, true, true),
        new JdeField("NLDL01", "NLDL01", JdeDataType.String, 60),
        new JdeField("NLBF01", "NLBF01", JdeDataType.String, 2),
        new JdeField("NLBF02", "NLBF02", JdeDataType.String, 2),
        new JdeField("NLBF03", "NLBF03", JdeDataType.String, 2),
        new JdeField("NLBF04", "NLBF04", JdeDataType.String, 2),
        new JdeField("NLBF05", "NLBF05", JdeDataType.String, 2),
        new JdeField("NLBF06", "NLBF06", JdeDataType.String, 2),
        new JdeField("NLBF07", "NLBF07", JdeDataType.String, 2),
        new JdeField("NLBF08", "NLBF08", JdeDataType.String, 2),
        new JdeField("NLBF09", "NLBF09", JdeDataType.String, 2),
        new JdeField("NLBF10", "NLBF10", JdeDataType.String, 2),
        new JdeField("NLBF11", "NLBF11", JdeDataType.String, 2),
        new JdeField("NLBF12", "NLBF12", JdeDataType.String, 2),
        new JdeField("NLBF13", "NLBF13", JdeDataType.String, 2),
        new JdeField("NLBF14", "NLBF14", JdeDataType.String, 2),
        new JdeField("NLDTPN", "NLDTPN", JdeDataType.String, 2),
        new JdeField("NLFDYS", "NLFDYS", JdeDataType.Numeric),
        new JdeField("NLNBR0", "NLNBR0", JdeDataType.Numeric),
        new JdeField("NLURCD", "NLURCD", JdeDataType.String, 4),
        new JdeField("NLURDT", "NLURDT", JdeDataType.Numeric),
        new JdeField("NLURAT", "NLURAT", JdeDataType.Numeric),
        new JdeField("NLURAB", "NLURAB", JdeDataType.Numeric),
        new JdeField("NLURRF", "NLURRF", JdeDataType.String, 30),
        new JdeField("NLUSER", "NLUSER", JdeDataType.String, 20),
        new JdeField("NLPID", "NLPID", JdeDataType.String, 20),
        new JdeField("NLUPMJ", "NLUPMJ", JdeDataType.Numeric),
        new JdeField("NLUPMT", "NLUPMT", JdeDataType.Numeric),
        new JdeField("NLJOBN", "NLJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15019_0", "Primary Key on NLBLFC", new[] { "NLBLFC" }, isUnique: true, isPrimaryKey: true)
    };
}
