using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI80 - .
/// </summary>
public class F75IUI80 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RWJOBS.
        /// </summary>
        public const string RWJOBS = "RWJOBS";

        /// <summary>
        /// RWAN8.
        /// </summary>
        public const string RWAN8 = "RWAN8";

        /// <summary>
        /// RWKCOO.
        /// </summary>
        public const string RWKCOO = "RWKCOO";

        /// <summary>
        /// RWDCTO.
        /// </summary>
        public const string RWDCTO = "RWDCTO";

        /// <summary>
        /// RWDOCO.
        /// </summary>
        public const string RWDOCO = "RWDOCO";

        /// <summary>
        /// RWLNID.
        /// </summary>
        public const string RWLNID = "RWLNID";

        /// <summary>
        /// RWSFXO.
        /// </summary>
        public const string RWSFXO = "RWSFXO";

        /// <summary>
        /// RWKCO.
        /// </summary>
        public const string RWKCO = "RWKCO";

        /// <summary>
        /// RWDCT.
        /// </summary>
        public const string RWDCT = "RWDCT";

        /// <summary>
        /// RWDOC.
        /// </summary>
        public const string RWDOC = "RWDOC";

        /// <summary>
        /// RWSFX.
        /// </summary>
        public const string RWSFX = "RWSFX";

        /// <summary>
        /// RWPYID.
        /// </summary>
        public const string RWPYID = "RWPYID";

        /// <summary>
        /// RWI75CATTY.
        /// </summary>
        public const string RWI75CATTY = "RWI75CATTY";

        /// <summary>
        /// RWI75CATVL.
        /// </summary>
        public const string RWI75CATVL = "RWI75CATVL";

        /// <summary>
        /// RWI75CATCO.
        /// </summary>
        public const string RWI75CATCO = "RWI75CATCO";

        /// <summary>
        /// RWUSER.
        /// </summary>
        public const string RWUSER = "RWUSER";

        /// <summary>
        /// RWPID.
        /// </summary>
        public const string RWPID = "RWPID";

        /// <summary>
        /// RWJOBN.
        /// </summary>
        public const string RWJOBN = "RWJOBN";

        /// <summary>
        /// RWUPMJ.
        /// </summary>
        public const string RWUPMJ = "RWUPMJ";

        /// <summary>
        /// RWUPMT.
        /// </summary>
        public const string RWUPMT = "RWUPMT";

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
        /// RWI75CGSTA.
        /// </summary>
        public const string RWI75CGSTA = "RWI75CGSTA";

        /// <summary>
        /// RWI75SGSTA.
        /// </summary>
        public const string RWI75SGSTA = "RWI75SGSTA";

        /// <summary>
        /// RWI75IGSTA.
        /// </summary>
        public const string RWI75IGSTA = "RWI75IGSTA";

        /// <summary>
        /// RWI75CESSA.
        /// </summary>
        public const string RWI75CESSA = "RWI75CESSA";

        /// <summary>
        /// RWI75ATX1A.
        /// </summary>
        public const string RWI75ATX1A = "RWI75ATX1A";

        /// <summary>
        /// RWI75ATX2A.
        /// </summary>
        public const string RWI75ATX2A = "RWI75ATX2A";

        /// <summary>
        /// RWI75ATX3A.
        /// </summary>
        public const string RWI75ATX3A = "RWI75ATX3A";

        /// <summary>
        /// RWI75AT4A.
        /// </summary>
        public const string RWI75AT4A = "RWI75AT4A";

        /// <summary>
        /// RWDE.
        /// </summary>
        public const string RWDE = "RWDE";

        /// <summary>
        /// RWI75GSTRA.
        /// </summary>
        public const string RWI75GSTRA = "RWI75GSTRA";

        /// <summary>
        /// RWI75IPOS.
        /// </summary>
        public const string RWI75IPOS = "RWI75IPOS";

        /// <summary>
        /// RWDGL.
        /// </summary>
        public const string RWDGL = "RWDGL";

        /// <summary>
        /// RWDMTJ.
        /// </summary>
        public const string RWDMTJ = "RWDMTJ";

        /// <summary>
        /// RWI75REVBN.
        /// </summary>
        public const string RWI75REVBN = "RWI75REVBN";

        /// <summary>
        /// RWICUT.
        /// </summary>
        public const string RWICUT = "RWICUT";

        /// <summary>
        /// RWI75PSP.
        /// </summary>
        public const string RWI75PSP = "RWI75PSP";

        /// <summary>
        /// RWI75PSR.
        /// </summary>
        public const string RWI75PSR = "RWI75PSR";

        /// <summary>
        /// RWI75RECU.
        /// </summary>
        public const string RWI75RECU = "RWI75RECU";

        /// <summary>
        /// RWFFU4.
        /// </summary>
        public const string RWFFU4 = "RWFFU4";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI80";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RWJOBS", "RWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("RWAN8", "RWAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RWKCOO", "RWKCOO", JdeDataType.String, 10),
        new JdeField("RWDCTO", "RWDCTO", JdeDataType.String, 4),
        new JdeField("RWDOCO", "RWDOCO", JdeDataType.Numeric),
        new JdeField("RWLNID", "RWLNID", JdeDataType.Numeric),
        new JdeField("RWSFXO", "RWSFXO", JdeDataType.String, 6),
        new JdeField("RWKCO", "RWKCO", JdeDataType.String, 10, true, true),
        new JdeField("RWDCT", "RWDCT", JdeDataType.String, 4, true, true),
        new JdeField("RWDOC", "RWDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RWSFX", "RWSFX", JdeDataType.String, 6, true, true),
        new JdeField("RWPYID", "RWPYID", JdeDataType.Numeric, null, true, true),
        new JdeField("RWI75CATTY", "RWI75CATTY", JdeDataType.String, 6, true, true),
        new JdeField("RWI75CATVL", "RWI75CATVL", JdeDataType.String, 40, true, true),
        new JdeField("RWI75CATCO", "RWI75CATCO", JdeDataType.Numeric),
        new JdeField("RWUSER", "RWUSER", JdeDataType.String, 20, true, true),
        new JdeField("RWPID", "RWPID", JdeDataType.String, 20),
        new JdeField("RWJOBN", "RWJOBN", JdeDataType.String, 20),
        new JdeField("RWUPMJ", "RWUPMJ", JdeDataType.Numeric),
        new JdeField("RWUPMT", "RWUPMT", JdeDataType.Numeric),
        new JdeField("RWYFUTDT1", "RWYFUTDT1", JdeDataType.Numeric),
        new JdeField("RWFUT6", "RWFUT6", JdeDataType.String, 60),
        new JdeField("RWYT04", "RWYT04", JdeDataType.String, 2),
        new JdeField("RWYFLAG", "RWYFLAG", JdeDataType.String, 2),
        new JdeField("RWYNUM1", "RWYNUM1", JdeDataType.Numeric),
        new JdeField("RWI75CGSTA", "RWI75CGSTA", JdeDataType.Numeric),
        new JdeField("RWI75SGSTA", "RWI75SGSTA", JdeDataType.Numeric),
        new JdeField("RWI75IGSTA", "RWI75IGSTA", JdeDataType.Numeric),
        new JdeField("RWI75CESSA", "RWI75CESSA", JdeDataType.Numeric),
        new JdeField("RWI75ATX1A", "RWI75ATX1A", JdeDataType.Numeric),
        new JdeField("RWI75ATX2A", "RWI75ATX2A", JdeDataType.Numeric),
        new JdeField("RWI75ATX3A", "RWI75ATX3A", JdeDataType.Numeric),
        new JdeField("RWI75AT4A", "RWI75AT4A", JdeDataType.Numeric),
        new JdeField("RWDE", "RWDE", JdeDataType.Numeric),
        new JdeField("RWI75GSTRA", "RWI75GSTRA", JdeDataType.String, 4),
        new JdeField("RWI75IPOS", "RWI75IPOS", JdeDataType.String, 4),
        new JdeField("RWDGL", "RWDGL", JdeDataType.Numeric),
        new JdeField("RWDMTJ", "RWDMTJ", JdeDataType.Numeric),
        new JdeField("RWI75REVBN", "RWI75REVBN", JdeDataType.Numeric),
        new JdeField("RWICUT", "RWICUT", JdeDataType.String, 4),
        new JdeField("RWI75PSP", "RWI75PSP", JdeDataType.Numeric),
        new JdeField("RWI75PSR", "RWI75PSR", JdeDataType.Numeric),
        new JdeField("RWI75RECU", "RWI75RECU", JdeDataType.String, 2),
        new JdeField("RWFFU4", "RWFFU4", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI80_0", "Primary Key on RWJOBS, RWAN8, RWKCO, RWDCT, RWDOC, RWSFX, RWPYID, RWI75CATTY, RWI75CATVL, RWUSER", new[] { "RWJOBS", "RWAN8", "RWKCO", "RWDCT", "RWDOC", "RWSFX", "RWPYID", "RWI75CATTY", "RWI75CATVL", "RWUSER" }, isUnique: true, isPrimaryKey: true)
    };
}
