using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI77 - .
/// </summary>
public class F75IUI77 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CWDOCO.
        /// </summary>
        public const string CWDOCO = "CWDOCO";

        /// <summary>
        /// CWDCTO.
        /// </summary>
        public const string CWDCTO = "CWDCTO";

        /// <summary>
        /// CWKCOO.
        /// </summary>
        public const string CWKCOO = "CWKCOO";

        /// <summary>
        /// CWLNID.
        /// </summary>
        public const string CWLNID = "CWLNID";

        /// <summary>
        /// CWLNIX.
        /// </summary>
        public const string CWLNIX = "CWLNIX";

        /// <summary>
        /// CWORDKEY.
        /// </summary>
        public const string CWORDKEY = "CWORDKEY";

        /// <summary>
        /// CWOCTO.
        /// </summary>
        public const string CWOCTO = "CWOCTO";

        /// <summary>
        /// CWOKCO.
        /// </summary>
        public const string CWOKCO = "CWOKCO";

        /// <summary>
        /// CWLINN.
        /// </summary>
        public const string CWLINN = "CWLINN";

        /// <summary>
        /// CWI75INVNO.
        /// </summary>
        public const string CWI75INVNO = "CWI75INVNO";

        /// <summary>
        /// CWJOBS.
        /// </summary>
        public const string CWJOBS = "CWJOBS";

        /// <summary>
        /// CWUSER.
        /// </summary>
        public const string CWUSER = "CWUSER";

        /// <summary>
        /// CWJOBN.
        /// </summary>
        public const string CWJOBN = "CWJOBN";

        /// <summary>
        /// CWPID.
        /// </summary>
        public const string CWPID = "CWPID";

        /// <summary>
        /// CWUPMJ.
        /// </summary>
        public const string CWUPMJ = "CWUPMJ";

        /// <summary>
        /// CWUPMT.
        /// </summary>
        public const string CWUPMT = "CWUPMT";

        /// <summary>
        /// CWYFUTDT1.
        /// </summary>
        public const string CWYFUTDT1 = "CWYFUTDT1";

        /// <summary>
        /// CWFUT6.
        /// </summary>
        public const string CWFUT6 = "CWFUT6";

        /// <summary>
        /// CWYT04.
        /// </summary>
        public const string CWYT04 = "CWYT04";

        /// <summary>
        /// CWYFLAG.
        /// </summary>
        public const string CWYFLAG = "CWYFLAG";

        /// <summary>
        /// CWYNUM1.
        /// </summary>
        public const string CWYNUM1 = "CWYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI77";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CWDOCO", "CWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CWDCTO", "CWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CWKCOO", "CWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CWLNID", "CWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CWLNIX", "CWLNIX", JdeDataType.Numeric),
        new JdeField("CWORDKEY", "CWORDKEY", JdeDataType.String, 34),
        new JdeField("CWOCTO", "CWOCTO", JdeDataType.String, 4),
        new JdeField("CWOKCO", "CWOKCO", JdeDataType.String, 10),
        new JdeField("CWLINN", "CWLINN", JdeDataType.Numeric),
        new JdeField("CWI75INVNO", "CWI75INVNO", JdeDataType.String, 50),
        new JdeField("CWJOBS", "CWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("CWUSER", "CWUSER", JdeDataType.String, 20, true, true),
        new JdeField("CWJOBN", "CWJOBN", JdeDataType.String, 20),
        new JdeField("CWPID", "CWPID", JdeDataType.String, 20),
        new JdeField("CWUPMJ", "CWUPMJ", JdeDataType.Numeric),
        new JdeField("CWUPMT", "CWUPMT", JdeDataType.Numeric),
        new JdeField("CWYFUTDT1", "CWYFUTDT1", JdeDataType.Numeric),
        new JdeField("CWFUT6", "CWFUT6", JdeDataType.String, 60),
        new JdeField("CWYT04", "CWYT04", JdeDataType.String, 2),
        new JdeField("CWYFLAG", "CWYFLAG", JdeDataType.String, 2),
        new JdeField("CWYNUM1", "CWYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI77_0", "Primary Key on CWDOCO, CWDCTO, CWKCOO, CWLNID, CWJOBS, CWUSER", new[] { "CWDOCO", "CWDCTO", "CWKCOO", "CWLNID", "CWJOBS", "CWUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
