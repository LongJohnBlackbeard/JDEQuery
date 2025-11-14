using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B4016 - .
/// </summary>
public class F76B4016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AABRG.
        /// </summary>
        public const string AABRG = "AABRG";

        /// <summary>
        /// AAB76ACTT.
        /// </summary>
        public const string AAB76ACTT = "AAB76ACTT";

        /// <summary>
        /// AACENTYR.
        /// </summary>
        public const string AACENTYR = "AACENTYR";

        /// <summary>
        /// AAMNTH.
        /// </summary>
        public const string AAMNTH = "AAMNTH";

        /// <summary>
        /// AAAG.
        /// </summary>
        public const string AAAG = "AAAG";

        /// <summary>
        /// AABY01.
        /// </summary>
        public const string AABY01 = "AABY01";

        /// <summary>
        /// AABY02.
        /// </summary>
        public const string AABY02 = "AABY02";

        /// <summary>
        /// AAB76INSS.
        /// </summary>
        public const string AAB76INSS = "AAB76INSS";

        /// <summary>
        /// AAB76MXMN.
        /// </summary>
        public const string AAB76MXMN = "AAB76MXMN";

        /// <summary>
        /// AAUSER.
        /// </summary>
        public const string AAUSER = "AAUSER";

        /// <summary>
        /// AAPID.
        /// </summary>
        public const string AAPID = "AAPID";

        /// <summary>
        /// AAJOBN.
        /// </summary>
        public const string AAJOBN = "AAJOBN";

        /// <summary>
        /// AAUPMJ.
        /// </summary>
        public const string AAUPMJ = "AAUPMJ";

        /// <summary>
        /// AAUPMT.
        /// </summary>
        public const string AAUPMT = "AAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B4016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AABRG", "AABRG", JdeDataType.String, 18, true, true),
        new JdeField("AAB76ACTT", "AAB76ACTT", JdeDataType.String, 6, true, true),
        new JdeField("AACENTYR", "AACENTYR", JdeDataType.Numeric, null, true, true),
        new JdeField("AAMNTH", "AAMNTH", JdeDataType.Numeric, null, true, true),
        new JdeField("AAAG", "AAAG", JdeDataType.Numeric),
        new JdeField("AABY01", "AABY01", JdeDataType.Numeric),
        new JdeField("AABY02", "AABY02", JdeDataType.Numeric),
        new JdeField("AAB76INSS", "AAB76INSS", JdeDataType.String, 2),
        new JdeField("AAB76MXMN", "AAB76MXMN", JdeDataType.Numeric),
        new JdeField("AAUSER", "AAUSER", JdeDataType.String, 20),
        new JdeField("AAPID", "AAPID", JdeDataType.String, 20),
        new JdeField("AAJOBN", "AAJOBN", JdeDataType.String, 20),
        new JdeField("AAUPMJ", "AAUPMJ", JdeDataType.Numeric),
        new JdeField("AAUPMT", "AAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B4016_0", "Primary Key on AABRG, AAB76ACTT, AACENTYR, AAMNTH", new[] { "AABRG", "AAB76ACTT", "AACENTYR", "AAMNTH" }, isUnique: true, isPrimaryKey: true)
    };
}
