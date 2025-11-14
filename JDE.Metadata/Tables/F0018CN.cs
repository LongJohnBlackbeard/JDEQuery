using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0018CN - .
/// </summary>
public class F0018CN : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CTKCOO.
        /// </summary>
        public const string CTKCOO = "CTKCOO";

        /// <summary>
        /// CTDCTO.
        /// </summary>
        public const string CTDCTO = "CTDCTO";

        /// <summary>
        /// CTDOCO.
        /// </summary>
        public const string CTDOCO = "CTDOCO";

        /// <summary>
        /// CTSFXO.
        /// </summary>
        public const string CTSFXO = "CTSFXO";

        /// <summary>
        /// CTLNID.
        /// </summary>
        public const string CTLNID = "CTLNID";

        /// <summary>
        /// CTDTE.
        /// </summary>
        public const string CTDTE = "CTDTE";

        /// <summary>
        /// CTTME0.
        /// </summary>
        public const string CTTME0 = "CTTME0";

        /// <summary>
        /// CTVINV.
        /// </summary>
        public const string CTVINV = "CTVINV";

        /// <summary>
        /// CTAN8.
        /// </summary>
        public const string CTAN8 = "CTAN8";

        /// <summary>
        /// CTCNPF.
        /// </summary>
        public const string CTCNPF = "CTCNPF";

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
    public override string TableName => "F0018CN";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CTKCOO", "CTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CTDCTO", "CTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CTDOCO", "CTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CTSFXO", "CTSFXO", JdeDataType.String, 6, true, true),
        new JdeField("CTLNID", "CTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CTDTE", "CTDTE", JdeDataType.Numeric, null, true, true),
        new JdeField("CTTME0", "CTTME0", JdeDataType.Numeric, null, true, true),
        new JdeField("CTVINV", "CTVINV", JdeDataType.String, 50),
        new JdeField("CTAN8", "CTAN8", JdeDataType.Numeric),
        new JdeField("CTCNPF", "CTCNPF", JdeDataType.String, 2),
        new JdeField("CTUSER", "CTUSER", JdeDataType.String, 20),
        new JdeField("CTPID", "CTPID", JdeDataType.String, 20),
        new JdeField("CTJOBN", "CTJOBN", JdeDataType.String, 20),
        new JdeField("CTUPMJ", "CTUPMJ", JdeDataType.Numeric),
        new JdeField("CTUPMT", "CTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0018CN_0", "Primary Key on CTKCOO, CTDCTO, CTDOCO, CTSFXO, CTLNID, CTDTE, CTTME0", new[] { "CTKCOO", "CTDCTO", "CTDOCO", "CTSFXO", "CTLNID", "CTDTE", "CTTME0" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F0018CN_2", "Index on CTAN8, CTVINV", new[] { "CTAN8", "CTVINV" })
    };
}
