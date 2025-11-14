using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4101 - .
/// </summary>
public class F76B4101 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IMITM.
        /// </summary>
        public const string IMITM = "IMITM";

        /// <summary>
        /// IMB76CI.
        /// </summary>
        public const string IMB76CI = "IMB76CI";

        /// <summary>
        /// IMB76FCI.
        /// </summary>
        public const string IMB76FCI = "IMB76FCI";

        /// <summary>
        /// IMB76VPA.
        /// </summary>
        public const string IMB76VPA = "IMB76VPA";

        /// <summary>
        /// IMB76TVIO.
        /// </summary>
        public const string IMB76TVIO = "IMB76TVIO";

        /// <summary>
        /// IMB76TIPI.
        /// </summary>
        public const string IMB76TIPI = "IMB76TIPI";

        /// <summary>
        /// IMCRCD.
        /// </summary>
        public const string IMCRCD = "IMCRCD";

        /// <summary>
        /// IMB76NUM.
        /// </summary>
        public const string IMB76NUM = "IMB76NUM";

        /// <summary>
        /// IMB76AA.
        /// </summary>
        public const string IMB76AA = "IMB76AA";

        /// <summary>
        /// IMB76REF.
        /// </summary>
        public const string IMB76REF = "IMB76REF";

        /// <summary>
        /// IMB76COD.
        /// </summary>
        public const string IMB76COD = "IMB76COD";

        /// <summary>
        /// IMB76DATE.
        /// </summary>
        public const string IMB76DATE = "IMB76DATE";

        /// <summary>
        /// IMUSER.
        /// </summary>
        public const string IMUSER = "IMUSER";

        /// <summary>
        /// IMPID.
        /// </summary>
        public const string IMPID = "IMPID";

        /// <summary>
        /// IMUPMJ.
        /// </summary>
        public const string IMUPMJ = "IMUPMJ";

        /// <summary>
        /// IMUPMT.
        /// </summary>
        public const string IMUPMT = "IMUPMT";

        /// <summary>
        /// IMJOBN.
        /// </summary>
        public const string IMJOBN = "IMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76B4101";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IMITM", "IMITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IMB76CI", "IMB76CI", JdeDataType.Numeric),
        new JdeField("IMB76FCI", "IMB76FCI", JdeDataType.String, 100),
        new JdeField("IMB76VPA", "IMB76VPA", JdeDataType.Numeric),
        new JdeField("IMB76TVIO", "IMB76TVIO", JdeDataType.Numeric),
        new JdeField("IMB76TIPI", "IMB76TIPI", JdeDataType.String, 6),
        new JdeField("IMCRCD", "IMCRCD", JdeDataType.String, 6),
        new JdeField("IMB76NUM", "IMB76NUM", JdeDataType.Numeric),
        new JdeField("IMB76AA", "IMB76AA", JdeDataType.Numeric),
        new JdeField("IMB76REF", "IMB76REF", JdeDataType.String, 30),
        new JdeField("IMB76COD", "IMB76COD", JdeDataType.String, 4),
        new JdeField("IMB76DATE", "IMB76DATE", JdeDataType.Numeric),
        new JdeField("IMUSER", "IMUSER", JdeDataType.String, 20),
        new JdeField("IMPID", "IMPID", JdeDataType.String, 20),
        new JdeField("IMUPMJ", "IMUPMJ", JdeDataType.Numeric),
        new JdeField("IMUPMT", "IMUPMT", JdeDataType.Numeric),
        new JdeField("IMJOBN", "IMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4101_0", "Primary Key on IMITM", new[] { "IMITM" }, isUnique: true, isPrimaryKey: true)
    };
}
