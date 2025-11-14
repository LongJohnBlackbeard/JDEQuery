using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI90 - .
/// </summary>
public class F75IUI90 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RWDOCO.
        /// </summary>
        public const string RWDOCO = "RWDOCO";

        /// <summary>
        /// RWDCTO.
        /// </summary>
        public const string RWDCTO = "RWDCTO";

        /// <summary>
        /// RWKCOO.
        /// </summary>
        public const string RWKCOO = "RWKCOO";

        /// <summary>
        /// RWJOBS.
        /// </summary>
        public const string RWJOBS = "RWJOBS";

        /// <summary>
        /// RWTCID.
        /// </summary>
        public const string RWTCID = "RWTCID";

        /// <summary>
        /// RWPEID.
        /// </summary>
        public const string RWPEID = "RWPEID";

        /// <summary>
        /// RWLNID.
        /// </summary>
        public const string RWLNID = "RWLNID";

        /// <summary>
        /// RWI75TTYP.
        /// </summary>
        public const string RWI75TTYP = "RWI75TTYP";

        /// <summary>
        /// RWAST.
        /// </summary>
        public const string RWAST = "RWAST";

        /// <summary>
        /// RWASN.
        /// </summary>
        public const string RWASN = "RWASN";

        /// <summary>
        /// RWI75TXRL.
        /// </summary>
        public const string RWI75TXRL = "RWI75TXRL";

        /// <summary>
        /// RWI75TXRG.
        /// </summary>
        public const string RWI75TXRG = "RWI75TXRG";

        /// <summary>
        /// RWI75GSTR.
        /// </summary>
        public const string RWI75GSTR = "RWI75GSTR";

        /// <summary>
        /// RWCRR.
        /// </summary>
        public const string RWCRR = "RWCRR";

        /// <summary>
        /// RWI75PSP.
        /// </summary>
        public const string RWI75PSP = "RWI75PSP";

        /// <summary>
        /// RWI75PSR.
        /// </summary>
        public const string RWI75PSR = "RWI75PSR";

        /// <summary>
        /// RWI75FRC.
        /// </summary>
        public const string RWI75FRC = "RWI75FRC";

        /// <summary>
        /// RWCRCD.
        /// </summary>
        public const string RWCRCD = "RWCRCD";

        /// <summary>
        /// RWUOM.
        /// </summary>
        public const string RWUOM = "RWUOM";

        /// <summary>
        /// RWUSER.
        /// </summary>
        public const string RWUSER = "RWUSER";

        /// <summary>
        /// RWPID.
        /// </summary>
        public const string RWPID = "RWPID";

        /// <summary>
        /// RWUPMJ.
        /// </summary>
        public const string RWUPMJ = "RWUPMJ";

        /// <summary>
        /// RWUPMT.
        /// </summary>
        public const string RWUPMT = "RWUPMT";

        /// <summary>
        /// RWJOBN.
        /// </summary>
        public const string RWJOBN = "RWJOBN";

        /// <summary>
        /// RWAKID.
        /// </summary>
        public const string RWAKID = "RWAKID";

        /// <summary>
        /// RWSRCFD.
        /// </summary>
        public const string RWSRCFD = "RWSRCFD";

        /// <summary>
        /// RWOSEQ.
        /// </summary>
        public const string RWOSEQ = "RWOSEQ";

        /// <summary>
        /// RWSUBSEQ.
        /// </summary>
        public const string RWSUBSEQ = "RWSUBSEQ";

        /// <summary>
        /// RWTIER.
        /// </summary>
        public const string RWTIER = "RWTIER";

        /// <summary>
        /// RWPA04.
        /// </summary>
        public const string RWPA04 = "RWPA04";

        /// <summary>
        /// RWYFUTDT1.
        /// </summary>
        public const string RWYFUTDT1 = "RWYFUTDT1";

        /// <summary>
        /// RWFUT6.
        /// </summary>
        public const string RWFUT6 = "RWFUT6";

        /// <summary>
        /// RWYT04.
        /// </summary>
        public const string RWYT04 = "RWYT04";

        /// <summary>
        /// RWYFLAG.
        /// </summary>
        public const string RWYFLAG = "RWYFLAG";

        /// <summary>
        /// RWYNUM1.
        /// </summary>
        public const string RWYNUM1 = "RWYNUM1";

        /// <summary>
        /// RWSTAM4.
        /// </summary>
        public const string RWSTAM4 = "RWSTAM4";

        /// <summary>
        /// RWI75PRVL4.
        /// </summary>
        public const string RWI75PRVL4 = "RWI75PRVL4";

        /// <summary>
        /// RWI75REVL4.
        /// </summary>
        public const string RWI75REVL4 = "RWI75REVL4";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI90";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RWDOCO", "RWDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RWDCTO", "RWDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RWKCOO", "RWKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RWJOBS", "RWJOBS", JdeDataType.Numeric),
        new JdeField("RWTCID", "RWTCID", JdeDataType.Numeric, null, true, true),
        new JdeField("RWPEID", "RWPEID", JdeDataType.Numeric, null, true, true),
        new JdeField("RWLNID", "RWLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RWI75TTYP", "RWI75TTYP", JdeDataType.String, 10),
        new JdeField("RWAST", "RWAST", JdeDataType.String, 16, true, true),
        new JdeField("RWASN", "RWASN", JdeDataType.String, 16, true, true),
        new JdeField("RWI75TXRL", "RWI75TXRL", JdeDataType.String, 12),
        new JdeField("RWI75TXRG", "RWI75TXRG", JdeDataType.String, 10),
        new JdeField("RWI75GSTR", "RWI75GSTR", JdeDataType.Numeric),
        new JdeField("RWCRR", "RWCRR", JdeDataType.Numeric),
        new JdeField("RWI75PSP", "RWI75PSP", JdeDataType.Numeric),
        new JdeField("RWI75PSR", "RWI75PSR", JdeDataType.Numeric),
        new JdeField("RWI75FRC", "RWI75FRC", JdeDataType.String, 2),
        new JdeField("RWCRCD", "RWCRCD", JdeDataType.String, 6),
        new JdeField("RWUOM", "RWUOM", JdeDataType.String, 4),
        new JdeField("RWUSER", "RWUSER", JdeDataType.String, 20),
        new JdeField("RWPID", "RWPID", JdeDataType.String, 20),
        new JdeField("RWUPMJ", "RWUPMJ", JdeDataType.Numeric),
        new JdeField("RWUPMT", "RWUPMT", JdeDataType.Numeric),
        new JdeField("RWJOBN", "RWJOBN", JdeDataType.String, 20),
        new JdeField("RWAKID", "RWAKID", JdeDataType.Numeric, null, true, true),
        new JdeField("RWSRCFD", "RWSRCFD", JdeDataType.String, 4, true, true),
        new JdeField("RWOSEQ", "RWOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RWSUBSEQ", "RWSUBSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RWTIER", "RWTIER", JdeDataType.Numeric, null, true, true),
        new JdeField("RWPA04", "RWPA04", JdeDataType.String, 2, true, true),
        new JdeField("RWYFUTDT1", "RWYFUTDT1", JdeDataType.Numeric),
        new JdeField("RWFUT6", "RWFUT6", JdeDataType.String, 60),
        new JdeField("RWYT04", "RWYT04", JdeDataType.String, 2),
        new JdeField("RWYFLAG", "RWYFLAG", JdeDataType.String, 2),
        new JdeField("RWYNUM1", "RWYNUM1", JdeDataType.Numeric),
        new JdeField("RWSTAM4", "RWSTAM4", JdeDataType.Numeric),
        new JdeField("RWI75PRVL4", "RWI75PRVL4", JdeDataType.Numeric),
        new JdeField("RWI75REVL4", "RWI75REVL4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI90_0", "Primary Key on RWDOCO, RWDCTO, RWKCOO, RWTCID, RWPEID, RWLNID, RWASN, RWAST, RWAKID, RWSRCFD, RWOSEQ, RWSUBSEQ, RWTIER, RWPA04", new[] { "RWDOCO", "RWDCTO", "RWKCOO", "RWTCID", "RWPEID", "RWLNID", "RWASN", "RWAST", "RWAKID", "RWSRCFD", "RWOSEQ", "RWSUBSEQ", "RWTIER", "RWPA04" }, isUnique: true, isPrimaryKey: true)
    };
}
