using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I825 - .
/// </summary>
public class F75I825 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MTDCT.
        /// </summary>
        public const string MTDCT = "MTDCT";

        /// <summary>
        /// MTDOC.
        /// </summary>
        public const string MTDOC = "MTDOC";

        /// <summary>
        /// MTKCO.
        /// </summary>
        public const string MTKCO = "MTKCO";

        /// <summary>
        /// MTDCTO.
        /// </summary>
        public const string MTDCTO = "MTDCTO";

        /// <summary>
        /// MTDOCO.
        /// </summary>
        public const string MTDOCO = "MTDOCO";

        /// <summary>
        /// MTKCOO.
        /// </summary>
        public const string MTKCOO = "MTKCOO";

        /// <summary>
        /// MTAN8.
        /// </summary>
        public const string MTAN8 = "MTAN8";

        /// <summary>
        /// MTI75INVNO.
        /// </summary>
        public const string MTI75INVNO = "MTI75INVNO";

        /// <summary>
        /// MTYINVDT.
        /// </summary>
        public const string MTYINVDT = "MTYINVDT";

        /// <summary>
        /// MTUSER.
        /// </summary>
        public const string MTUSER = "MTUSER";

        /// <summary>
        /// MTPID.
        /// </summary>
        public const string MTPID = "MTPID";

        /// <summary>
        /// MTJOBN.
        /// </summary>
        public const string MTJOBN = "MTJOBN";

        /// <summary>
        /// MTUPMJ.
        /// </summary>
        public const string MTUPMJ = "MTUPMJ";

        /// <summary>
        /// MTUPMT.
        /// </summary>
        public const string MTUPMT = "MTUPMT";

        /// <summary>
        /// MTYFUTDT1.
        /// </summary>
        public const string MTYFUTDT1 = "MTYFUTDT1";

        /// <summary>
        /// MTFUT6.
        /// </summary>
        public const string MTFUT6 = "MTFUT6";

        /// <summary>
        /// MTYT04.
        /// </summary>
        public const string MTYT04 = "MTYT04";

        /// <summary>
        /// MTYFLAG.
        /// </summary>
        public const string MTYFLAG = "MTYFLAG";

        /// <summary>
        /// MTYNUM1.
        /// </summary>
        public const string MTYNUM1 = "MTYNUM1";

        /// <summary>
        /// MTOKCO.
        /// </summary>
        public const string MTOKCO = "MTOKCO";

        /// <summary>
        /// MTODCT.
        /// </summary>
        public const string MTODCT = "MTODCT";

        /// <summary>
        /// MTODOC.
        /// </summary>
        public const string MTODOC = "MTODOC";

        /// <summary>
        /// MTI75RSMT.
        /// </summary>
        public const string MTI75RSMT = "MTI75RSMT";
    }

    /// <inheritdoc />
    public override string TableName => "F75I825";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MTDCT", "MTDCT", JdeDataType.String, 4, true, true),
        new JdeField("MTDOC", "MTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("MTKCO", "MTKCO", JdeDataType.String, 10, true, true),
        new JdeField("MTDCTO", "MTDCTO", JdeDataType.String, 4),
        new JdeField("MTDOCO", "MTDOCO", JdeDataType.Numeric),
        new JdeField("MTKCOO", "MTKCOO", JdeDataType.String, 10),
        new JdeField("MTAN8", "MTAN8", JdeDataType.Numeric),
        new JdeField("MTI75INVNO", "MTI75INVNO", JdeDataType.String, 50),
        new JdeField("MTYINVDT", "MTYINVDT", JdeDataType.Numeric),
        new JdeField("MTUSER", "MTUSER", JdeDataType.String, 20),
        new JdeField("MTPID", "MTPID", JdeDataType.String, 20),
        new JdeField("MTJOBN", "MTJOBN", JdeDataType.String, 20),
        new JdeField("MTUPMJ", "MTUPMJ", JdeDataType.Numeric),
        new JdeField("MTUPMT", "MTUPMT", JdeDataType.Numeric),
        new JdeField("MTYFUTDT1", "MTYFUTDT1", JdeDataType.Numeric),
        new JdeField("MTFUT6", "MTFUT6", JdeDataType.String, 60),
        new JdeField("MTYT04", "MTYT04", JdeDataType.String, 2),
        new JdeField("MTYFLAG", "MTYFLAG", JdeDataType.String, 2),
        new JdeField("MTYNUM1", "MTYNUM1", JdeDataType.Numeric),
        new JdeField("MTOKCO", "MTOKCO", JdeDataType.String, 10),
        new JdeField("MTODCT", "MTODCT", JdeDataType.String, 4),
        new JdeField("MTODOC", "MTODOC", JdeDataType.Numeric),
        new JdeField("MTI75RSMT", "MTI75RSMT", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I825_0", "Primary Key on MTDCT, MTDOC, MTKCO", new[] { "MTDCT", "MTDOC", "MTKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
