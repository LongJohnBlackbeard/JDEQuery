using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B014 - .
/// </summary>
public class F76B014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMBNNF.
        /// </summary>
        public const string IMBNNF = "IMBNNF";

        /// <summary>
        /// IMBSER.
        /// </summary>
        public const string IMBSER = "IMBSER";

        /// <summary>
        /// IMN001.
        /// </summary>
        public const string IMN001 = "IMN001";

        /// <summary>
        /// IMDCT.
        /// </summary>
        public const string IMDCT = "IMDCT";

        /// <summary>
        /// IMUKID.
        /// </summary>
        public const string IMUKID = "IMUKID";

        /// <summary>
        /// IMB76ICCA.
        /// </summary>
        public const string IMB76ICCA = "IMB76ICCA";

        /// <summary>
        /// IMB76IFTA.
        /// </summary>
        public const string IMB76IFTA = "IMB76IFTA";

        /// <summary>
        /// IMUSER.
        /// </summary>
        public const string IMUSER = "IMUSER";

        /// <summary>
        /// IMPID.
        /// </summary>
        public const string IMPID = "IMPID";

        /// <summary>
        /// IMJOBN.
        /// </summary>
        public const string IMJOBN = "IMJOBN";

        /// <summary>
        /// IMUPMJ.
        /// </summary>
        public const string IMUPMJ = "IMUPMJ";

        /// <summary>
        /// IMUPMT.
        /// </summary>
        public const string IMUPMT = "IMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMBNNF", "IMBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("IMBSER", "IMBSER", JdeDataType.String, 4, true, true),
        new JdeField("IMN001", "IMN001", JdeDataType.Numeric, null, true, true),
        new JdeField("IMDCT", "IMDCT", JdeDataType.String, 4, true, true),
        new JdeField("IMUKID", "IMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IMB76ICCA", "IMB76ICCA", JdeDataType.Numeric),
        new JdeField("IMB76IFTA", "IMB76IFTA", JdeDataType.Numeric),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMUPMT", "IMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B014_0", "Primary Key on IMBNNF, IMBSER, IMN001, IMDCT, IMUKID", new[] { "IMBNNF", "IMBSER", "IMN001", "IMDCT", "IMUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
