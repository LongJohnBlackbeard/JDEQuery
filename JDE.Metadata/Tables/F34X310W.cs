using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34X310W - .
/// </summary>
public class F34X310W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDUKID.
        /// </summary>
        public const string PDUKID = "PDUKID";

        /// <summary>
        /// PDJOBS.
        /// </summary>
        public const string PDJOBS = "PDJOBS";

        /// <summary>
        /// PD34XPITM.
        /// </summary>
        public const string PD34XPITM = "PD34XPITM";

        /// <summary>
        /// PDMCU0.
        /// </summary>
        public const string PDMCU0 = "PDMCU0";

        /// <summary>
        /// PDLBOM.
        /// </summary>
        public const string PDLBOM = "PDLBOM";

        /// <summary>
        /// PD34XLBOMI.
        /// </summary>
        public const string PD34XLBOMI = "PD34XLBOMI";

        /// <summary>
        /// PDITM.
        /// </summary>
        public const string PDITM = "PDITM";

        /// <summary>
        /// PDLITM.
        /// </summary>
        public const string PDLITM = "PDLITM";

        /// <summary>
        /// PDAITM.
        /// </summary>
        public const string PDAITM = "PDAITM";

        /// <summary>
        /// PDOTBM.
        /// </summary>
        public const string PDOTBM = "PDOTBM";

        /// <summary>
        /// PD#BQT.
        /// </summary>
        public const string PD_BQT = "PD#BQT";

        /// <summary>
        /// PDKIT.
        /// </summary>
        public const string PDKIT = "PDKIT";

        /// <summary>
        /// PDTBM.
        /// </summary>
        public const string PDTBM = "PDTBM";

        /// <summary>
        /// PDCPNB.
        /// </summary>
        public const string PDCPNB = "PDCPNB";

        /// <summary>
        /// PDMMCU.
        /// </summary>
        public const string PDMMCU = "PDMMCU";

        /// <summary>
        /// PDCMCU.
        /// </summary>
        public const string PDCMCU = "PDCMCU";

        /// <summary>
        /// PD34XBQTY.
        /// </summary>
        public const string PD34XBQTY = "PD34XBQTY";

        /// <summary>
        /// PD34XBQTE.
        /// </summary>
        public const string PD34XBQTE = "PD34XBQTE";

        /// <summary>
        /// PD34XBQTEA.
        /// </summary>
        public const string PD34XBQTEA = "PD34XBQTEA";

        /// <summary>
        /// PDUM.
        /// </summary>
        public const string PDUM = "PDUM";

        /// <summary>
        /// PDSTKT.
        /// </summary>
        public const string PDSTKT = "PDSTKT";

        /// <summary>
        /// PDLNTY.
        /// </summary>
        public const string PDLNTY = "PDLNTY";

        /// <summary>
        /// PDSCRP.
        /// </summary>
        public const string PDSCRP = "PDSCRP";

        /// <summary>
        /// PDSRNK.
        /// </summary>
        public const string PDSRNK = "PDSRNK";

        /// <summary>
        /// PDSRKF.
        /// </summary>
        public const string PDSRKF = "PDSRKF";

        /// <summary>
        /// PDBRVN.
        /// </summary>
        public const string PDBRVN = "PDBRVN";

        /// <summary>
        /// PDOPSQ.
        /// </summary>
        public const string PDOPSQ = "PDOPSQ";

        /// <summary>
        /// PDOPSC.
        /// </summary>
        public const string PDOPSC = "PDOPSC";

        /// <summary>
        /// PDTYCOMP.
        /// </summary>
        public const string PDTYCOMP = "PDTYCOMP";

        /// <summary>
        /// PDSBNT.
        /// </summary>
        public const string PDSBNT = "PDSBNT";

        /// <summary>
        /// PDEFFF.
        /// </summary>
        public const string PDEFFF = "PDEFFF";

        /// <summary>
        /// PDEFFT.
        /// </summary>
        public const string PDEFFT = "PDEFFT";

        /// <summary>
        /// PDFSER.
        /// </summary>
        public const string PDFSER = "PDFSER";

        /// <summary>
        /// PDTSER.
        /// </summary>
        public const string PDTSER = "PDTSER";

        /// <summary>
        /// PDFORQ.
        /// </summary>
        public const string PDFORQ = "PDFORQ";

        /// <summary>
        /// PDDSC1.
        /// </summary>
        public const string PDDSC1 = "PDDSC1";

        /// <summary>
        /// PDSUBAF.
        /// </summary>
        public const string PDSUBAF = "PDSUBAF";

        /// <summary>
        /// PDBREV.
        /// </summary>
        public const string PDBREV = "PDBREV";

        /// <summary>
        /// PDANPL.
        /// </summary>
        public const string PDANPL = "PDANPL";

        /// <summary>
        /// PDCMRV.
        /// </summary>
        public const string PDCMRV = "PDCMRV";

        /// <summary>
        /// PDRVNO.
        /// </summary>
        public const string PDRVNO = "PDRVNO";

        /// <summary>
        /// PDSELCB.
        /// </summary>
        public const string PDSELCB = "PDSELCB";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F34X310W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDUKID", "PDUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDJOBS", "PDJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("PD34XPITM", "PD34XPITM", JdeDataType.Numeric),
        new JdeField("PDMCU0", "PDMCU0", JdeDataType.String, 24),
        new JdeField("PDLBOM", "PDLBOM", JdeDataType.Numeric),
        new JdeField("PD34XLBOMI", "PD34XLBOMI", JdeDataType.String, 100),
        new JdeField("PDITM", "PDITM", JdeDataType.Numeric),
        new JdeField("PDLITM", "PDLITM", JdeDataType.String, 50),
        new JdeField("PDAITM", "PDAITM", JdeDataType.String, 50),
        new JdeField("PDOTBM", "PDOTBM", JdeDataType.String, 6),
        new JdeField("PD#BQT", "PD#BQT", JdeDataType.Numeric),
        new JdeField("PDKIT", "PDKIT", JdeDataType.Numeric),
        new JdeField("PDTBM", "PDTBM", JdeDataType.String, 6),
        new JdeField("PDCPNB", "PDCPNB", JdeDataType.Numeric),
        new JdeField("PDMMCU", "PDMMCU", JdeDataType.String, 24),
        new JdeField("PDCMCU", "PDCMCU", JdeDataType.String, 24),
        new JdeField("PD34XBQTY", "PD34XBQTY", JdeDataType.Numeric),
        new JdeField("PD34XBQTE", "PD34XBQTE", JdeDataType.Numeric),
        new JdeField("PD34XBQTEA", "PD34XBQTEA", JdeDataType.Numeric),
        new JdeField("PDUM", "PDUM", JdeDataType.String, 4),
        new JdeField("PDSTKT", "PDSTKT", JdeDataType.String, 2),
        new JdeField("PDLNTY", "PDLNTY", JdeDataType.String, 4),
        new JdeField("PDSCRP", "PDSCRP", JdeDataType.Numeric),
        new JdeField("PDSRNK", "PDSRNK", JdeDataType.Numeric),
        new JdeField("PDSRKF", "PDSRKF", JdeDataType.String, 2),
        new JdeField("PDBRVN", "PDBRVN", JdeDataType.Numeric),
        new JdeField("PDOPSQ", "PDOPSQ", JdeDataType.Numeric),
        new JdeField("PDOPSC", "PDOPSC", JdeDataType.String, 4),
        new JdeField("PDTYCOMP", "PDTYCOMP", JdeDataType.String, 4),
        new JdeField("PDSBNT", "PDSBNT", JdeDataType.Numeric),
        new JdeField("PDEFFF", "PDEFFF", JdeDataType.Numeric),
        new JdeField("PDEFFT", "PDEFFT", JdeDataType.Numeric),
        new JdeField("PDFSER", "PDFSER", JdeDataType.String, 50),
        new JdeField("PDTSER", "PDTSER", JdeDataType.String, 50),
        new JdeField("PDFORQ", "PDFORQ", JdeDataType.String, 2),
        new JdeField("PDDSC1", "PDDSC1", JdeDataType.String, 60),
        new JdeField("PDSUBAF", "PDSUBAF", JdeDataType.String, 2),
        new JdeField("PDBREV", "PDBREV", JdeDataType.String, 6),
        new JdeField("PDANPL", "PDANPL", JdeDataType.Numeric),
        new JdeField("PDCMRV", "PDCMRV", JdeDataType.String, 6),
        new JdeField("PDRVNO", "PDRVNO", JdeDataType.String, 4),
        new JdeField("PDSELCB", "PDSELCB", JdeDataType.String, 2),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34X310W_0", "Primary Key on PDJOBS, PDUKID", new[] { "PDJOBS", "PDUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34X310W_2", "Index on PDJOBS, PDKIT, PDTBM, PDMMCU, PDITM, PDOPSQ", new[] { "PDJOBS", "PDKIT", "PDTBM", "PDMMCU", "PDITM", "PDOPSQ" }),
        new JdeIndex("F34X310W_3", "Index on PDJOBS, PDKIT, PDMMCU, PDBRVN, PDLBOM", new[] { "PDJOBS", "PDKIT", "PDMMCU", "PDBRVN", "PDLBOM" }),
        new JdeIndex("F34X310W_4", "Index on PDJOBS, PD34XPITM, PDMCU0, PDOTBM, PD#BQT", new[] { "PDJOBS", "PD34XPITM", "PDMCU0", "PDOTBM", "PD#BQT" }),
        new JdeIndex("F34X310W_5", "Index on PDJOBS, PD34XPITM, PDMCU0, PDOTBM, PD#BQT, PDKIT, PDMMCU, PDTBM, PDUM", new[] { "PDJOBS", "PD34XPITM", "PDMCU0", "PDOTBM", "PD#BQT", "PDKIT", "PDMMCU", "PDTBM", "PDUM" }),
        new JdeIndex("F34X310W_7", "Index on PDJOBS, PDUSER, PDITM, PDCMCU", new[] { "PDJOBS", "PDUSER", "PDITM", "PDCMCU" }),
        new JdeIndex("F34X310W_8", "Index on PDJOBS, PDUSER, PDUPMJ", new[] { "PDJOBS", "PDUSER", "PDUPMJ" })
    };
}
