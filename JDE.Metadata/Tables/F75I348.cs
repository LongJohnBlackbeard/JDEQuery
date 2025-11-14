using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I348 - .
/// </summary>
public class F75I348 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTAN8.
        /// </summary>
        public const string CTAN8 = "CTAN8";

        /// <summary>
        /// CTLITM.
        /// </summary>
        public const string CTLITM = "CTLITM";

        /// <summary>
        /// CTEXPUN.
        /// </summary>
        public const string CTEXPUN = "CTEXPUN";

        /// <summary>
        /// CTYEU3.
        /// </summary>
        public const string CTYEU3 = "CTYEU3";

        /// <summary>
        /// CTYC3D.
        /// </summary>
        public const string CTYC3D = "CTYC3D";

        /// <summary>
        /// CTAEXD.
        /// </summary>
        public const string CTAEXD = "CTAEXD";

        /// <summary>
        /// CTUORG.
        /// </summary>
        public const string CTUORG = "CTUORG";

        /// <summary>
        /// CTEV01.
        /// </summary>
        public const string CTEV01 = "CTEV01";

        /// <summary>
        /// CTQAVAL.
        /// </summary>
        public const string CTQAVAL = "CTQAVAL";

        /// <summary>
        /// CTUSER.
        /// </summary>
        public const string CTUSER = "CTUSER";

        /// <summary>
        /// CTPID.
        /// </summary>
        public const string CTPID = "CTPID";

        /// <summary>
        /// CTJOBN.
        /// </summary>
        public const string CTJOBN = "CTJOBN";

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
    public override string TableName => "F75I348";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTAN8", "CTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CTLITM", "CTLITM", JdeDataType.String, 50, true, true),
        new JdeField("CTEXPUN", "CTEXPUN", JdeDataType.String, 20, true, true),
        new JdeField("CTYEU3", "CTYEU3", JdeDataType.Numeric),
        new JdeField("CTYC3D", "CTYC3D", JdeDataType.Numeric),
        new JdeField("CTAEXD", "CTAEXD", JdeDataType.Numeric),
        new JdeField("CTUORG", "CTUORG", JdeDataType.Numeric),
        new JdeField("CTEV01", "CTEV01", JdeDataType.String, 2, true, true),
        new JdeField("CTQAVAL", "CTQAVAL", JdeDataType.Numeric),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I348_0", "Primary Key on CTAN8, CTLITM, CTEXPUN, CTEV01", new[] { "CTAN8", "CTLITM", "CTEXPUN", "CTEV01" }, isUnique: true, isPrimaryKey: true)
    };
}
