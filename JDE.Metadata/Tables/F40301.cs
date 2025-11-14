using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40301 - .
/// </summary>
public class F40301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PTAN8.
        /// </summary>
        public const string PTAN8 = "PTAN8";

        /// <summary>
        /// PTCS01.
        /// </summary>
        public const string PTCS01 = "PTCS01";

        /// <summary>
        /// PTITM.
        /// </summary>
        public const string PTITM = "PTITM";

        /// <summary>
        /// PTIT01.
        /// </summary>
        public const string PTIT01 = "PTIT01";

        /// <summary>
        /// PTEFTJ.
        /// </summary>
        public const string PTEFTJ = "PTEFTJ";

        /// <summary>
        /// PTEXDJ.
        /// </summary>
        public const string PTEXDJ = "PTEXDJ";

        /// <summary>
        /// PTMNQ.
        /// </summary>
        public const string PTMNQ = "PTMNQ";

        /// <summary>
        /// PTMXQ.
        /// </summary>
        public const string PTMXQ = "PTMXQ";

        /// <summary>
        /// PTUOM.
        /// </summary>
        public const string PTUOM = "PTUOM";

        /// <summary>
        /// PTTXID.
        /// </summary>
        public const string PTTXID = "PTTXID";

        /// <summary>
        /// PTSTPR.
        /// </summary>
        public const string PTSTPR = "PTSTPR";

        /// <summary>
        /// PTPTC.
        /// </summary>
        public const string PTPTC = "PTPTC";

        /// <summary>
        /// PTRYIN.
        /// </summary>
        public const string PTRYIN = "PTRYIN";

        /// <summary>
        /// PTDTBS.
        /// </summary>
        public const string PTDTBS = "PTDTBS";

        /// <summary>
        /// PTURCD.
        /// </summary>
        public const string PTURCD = "PTURCD";

        /// <summary>
        /// PTURDT.
        /// </summary>
        public const string PTURDT = "PTURDT";

        /// <summary>
        /// PTURAT.
        /// </summary>
        public const string PTURAT = "PTURAT";

        /// <summary>
        /// PTURAB.
        /// </summary>
        public const string PTURAB = "PTURAB";

        /// <summary>
        /// PTURRF.
        /// </summary>
        public const string PTURRF = "PTURRF";

        /// <summary>
        /// PTUSER.
        /// </summary>
        public const string PTUSER = "PTUSER";

        /// <summary>
        /// PTPID.
        /// </summary>
        public const string PTPID = "PTPID";

        /// <summary>
        /// PTJOBN.
        /// </summary>
        public const string PTJOBN = "PTJOBN";

        /// <summary>
        /// PTUPMJ.
        /// </summary>
        public const string PTUPMJ = "PTUPMJ";

        /// <summary>
        /// PTTDAY.
        /// </summary>
        public const string PTTDAY = "PTTDAY";

        /// <summary>
        /// PTOSEQ.
        /// </summary>
        public const string PTOSEQ = "PTOSEQ";

        /// <summary>
        /// PTMCU.
        /// </summary>
        public const string PTMCU = "PTMCU";
    }

    /// <inheritdoc />
    public override string TableName => "F40301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PTAN8", "PTAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PTCS01", "PTCS01", JdeDataType.String, 16, true, true),
        new JdeField("PTITM", "PTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PTIT01", "PTIT01", JdeDataType.String, 16, true, true),
        new JdeField("PTEFTJ", "PTEFTJ", JdeDataType.Numeric),
        new JdeField("PTEXDJ", "PTEXDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PTMNQ", "PTMNQ", JdeDataType.Numeric),
        new JdeField("PTMXQ", "PTMXQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PTUOM", "PTUOM", JdeDataType.String, 4, true, true),
        new JdeField("PTTXID", "PTTXID", JdeDataType.Numeric),
        new JdeField("PTSTPR", "PTSTPR", JdeDataType.String, 2),
        new JdeField("PTPTC", "PTPTC", JdeDataType.String, 6),
        new JdeField("PTRYIN", "PTRYIN", JdeDataType.String, 2),
        new JdeField("PTDTBS", "PTDTBS", JdeDataType.String, 2),
        new JdeField("PTURCD", "PTURCD", JdeDataType.String, 4),
        new JdeField("PTURDT", "PTURDT", JdeDataType.Numeric),
        new JdeField("PTURAT", "PTURAT", JdeDataType.Numeric),
        new JdeField("PTURAB", "PTURAB", JdeDataType.Numeric),
        new JdeField("PTURRF", "PTURRF", JdeDataType.String, 30),
        new JdeField("PTUSER", "PTUSER", JdeDataType.String, 20),
        new JdeField("PTPID", "PTPID", JdeDataType.String, 20),
        new JdeField("PTJOBN", "PTJOBN", JdeDataType.String, 20),
        new JdeField("PTUPMJ", "PTUPMJ", JdeDataType.Numeric),
        new JdeField("PTTDAY", "PTTDAY", JdeDataType.Numeric),
        new JdeField("PTOSEQ", "PTOSEQ", JdeDataType.Numeric),
        new JdeField("PTMCU", "PTMCU", JdeDataType.String, 24)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40301_0", "Primary Key on PTAN8, PTCS01, PTITM, PTIT01, PTEXDJ, PTUOM, PTMXQ", new[] { "PTAN8", "PTCS01", "PTITM", "PTIT01", "PTEXDJ", "PTUOM", "PTMXQ" }, isUnique: true, isPrimaryKey: true)
    };
}
