using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0401 - .
/// </summary>
public class F76B0401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTBRTAX.
        /// </summary>
        public const string CTBRTAX = "CTBRTAX";

        /// <summary>
        /// CTBRTXTP.
        /// </summary>
        public const string CTBRTXTP = "CTBRTXTP";

        /// <summary>
        /// CTDL01.
        /// </summary>
        public const string CTDL01 = "CTDL01";

        /// <summary>
        /// CTDL02.
        /// </summary>
        public const string CTDL02 = "CTDL02";

        /// <summary>
        /// CTDL03.
        /// </summary>
        public const string CTDL03 = "CTDL03";

        /// <summary>
        /// CTBRALQ.
        /// </summary>
        public const string CTBRALQ = "CTBRALQ";

        /// <summary>
        /// CTAN8J.
        /// </summary>
        public const string CTAN8J = "CTAN8J";

        /// <summary>
        /// CTBRRCT.
        /// </summary>
        public const string CTBRRCT = "CTBRRCT";

        /// <summary>
        /// CTGLC.
        /// </summary>
        public const string CTGLC = "CTGLC";

        /// <summary>
        /// CTBRRTA.
        /// </summary>
        public const string CTBRRTA = "CTBRRTA";

        /// <summary>
        /// CTBRRD.
        /// </summary>
        public const string CTBRRD = "CTBRRD";

        /// <summary>
        /// CTBRQDP.
        /// </summary>
        public const string CTBRQDP = "CTBRQDP";

        /// <summary>
        /// CTBRAP.
        /// </summary>
        public const string CTBRAP = "CTBRAP";

        /// <summary>
        /// CTBRTPR.
        /// </summary>
        public const string CTBRTPR = "CTBRTPR";

        /// <summary>
        /// CTBRISS.
        /// </summary>
        public const string CTBRISS = "CTBRISS";

        /// <summary>
        /// CTBRINSS.
        /// </summary>
        public const string CTBRINSS = "CTBRINSS";

        /// <summary>
        /// CTBRCOOP.
        /// </summary>
        public const string CTBRCOOP = "CTBRCOOP";

        /// <summary>
        /// CTPTC.
        /// </summary>
        public const string CTPTC = "CTPTC";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTUPMJ.
        /// </summary>
        public const string CTUPMJ = "CTUPMJ";

        /// <summary>
        /// CTUPMT.
        /// </summary>
        public const string CTUPMT = "CTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTBRTAX", "CTBRTAX", JdeDataType.String, 16, true, true),
        new JdeField("CTBRTXTP", "CTBRTXTP", JdeDataType.String, 4, true, true),
        new JdeField("CTDL01", "CTDL01", JdeDataType.String, 60),
        new JdeField("CTDL02", "CTDL02", JdeDataType.String, 60),
        new JdeField("CTDL03", "CTDL03", JdeDataType.String, 60),
        new JdeField("CTBRALQ", "CTBRALQ", JdeDataType.Numeric),
        new JdeField("CTAN8J", "CTAN8J", JdeDataType.Numeric),
        new JdeField("CTBRRCT", "CTBRRCT", JdeDataType.Numeric),
        new JdeField("CTGLC", "CTGLC", JdeDataType.String, 8),
        new JdeField("CTBRRTA", "CTBRRTA", JdeDataType.String, 2),
        new JdeField("CTBRRD", "CTBRRD", JdeDataType.Numeric),
        new JdeField("CTBRQDP", "CTBRQDP", JdeDataType.Numeric),
        new JdeField("CTBRAP", "CTBRAP", JdeDataType.String, 2),
        new JdeField("CTBRTPR", "CTBRTPR", JdeDataType.String, 2),
        new JdeField("CTBRISS", "CTBRISS", JdeDataType.Numeric),
        new JdeField("CTBRINSS", "CTBRINSS", JdeDataType.Numeric),
        new JdeField("CTBRCOOP", "CTBRCOOP", JdeDataType.String, 2),
        new JdeField("CTPTC", "CTPTC", JdeDataType.String, 6),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0401_0", "Primary Key on CTBRTAX, CTBRTXTP", new[] { "CTBRTAX", "CTBRTXTP" }, isUnique: true, isPrimaryKey: true)
    };
}
