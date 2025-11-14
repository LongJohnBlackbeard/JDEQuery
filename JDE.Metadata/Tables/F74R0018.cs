using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R0018 - .
/// </summary>
public class F74R0018 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TDY74RID.
        /// </summary>
        public const string TDY74RID = "TDY74RID";

        /// <summary>
        /// TDY74RID2.
        /// </summary>
        public const string TDY74RID2 = "TDY74RID2";

        /// <summary>
        /// TDY74RARAP.
        /// </summary>
        public const string TDY74RARAP = "TDY74RARAP";

        /// <summary>
        /// TDY74RATTN.
        /// </summary>
        public const string TDY74RATTN = "TDY74RATTN";

        /// <summary>
        /// TDKCO.
        /// </summary>
        public const string TDKCO = "TDKCO";

        /// <summary>
        /// TDDOC.
        /// </summary>
        public const string TDDOC = "TDDOC";

        /// <summary>
        /// TDDCT.
        /// </summary>
        public const string TDDCT = "TDDCT";

        /// <summary>
        /// TDSFX.
        /// </summary>
        public const string TDSFX = "TDSFX";

        /// <summary>
        /// TDSFXE.
        /// </summary>
        public const string TDSFXE = "TDSFXE";

        /// <summary>
        /// TDDCTA.
        /// </summary>
        public const string TDDCTA = "TDDCTA";

        /// <summary>
        /// TDVINV.
        /// </summary>
        public const string TDVINV = "TDVINV";

        /// <summary>
        /// TDDIVJ.
        /// </summary>
        public const string TDDIVJ = "TDDIVJ";

        /// <summary>
        /// TDDSVJ.
        /// </summary>
        public const string TDDSVJ = "TDDSVJ";

        /// <summary>
        /// TDDGJ.
        /// </summary>
        public const string TDDGJ = "TDDGJ";

        /// <summary>
        /// TDAG.
        /// </summary>
        public const string TDAG = "TDAG";

        /// <summary>
        /// TDATXA.
        /// </summary>
        public const string TDATXA = "TDATXA";

        /// <summary>
        /// TDATXN.
        /// </summary>
        public const string TDATXN = "TDATXN";

        /// <summary>
        /// TDSTAM.
        /// </summary>
        public const string TDSTAM = "TDSTAM";

        /// <summary>
        /// TDACR.
        /// </summary>
        public const string TDACR = "TDACR";

        /// <summary>
        /// TDEXR1.
        /// </summary>
        public const string TDEXR1 = "TDEXR1";

        /// <summary>
        /// TDIRDE.
        /// </summary>
        public const string TDIRDE = "TDIRDE";

        /// <summary>
        /// TDITM.
        /// </summary>
        public const string TDITM = "TDITM";

        /// <summary>
        /// TDTXA1.
        /// </summary>
        public const string TDTXA1 = "TDTXA1";

        /// <summary>
        /// TDTXR1.
        /// </summary>
        public const string TDTXR1 = "TDTXR1";

        /// <summary>
        /// TDTXR2.
        /// </summary>
        public const string TDTXR2 = "TDTXR2";

        /// <summary>
        /// TDTXR3.
        /// </summary>
        public const string TDTXR3 = "TDTXR3";

        /// <summary>
        /// TDTXR4.
        /// </summary>
        public const string TDTXR4 = "TDTXR4";

        /// <summary>
        /// TDTXR5.
        /// </summary>
        public const string TDTXR5 = "TDTXR5";

        /// <summary>
        /// TDTA1.
        /// </summary>
        public const string TDTA1 = "TDTA1";

        /// <summary>
        /// TDTA2.
        /// </summary>
        public const string TDTA2 = "TDTA2";

        /// <summary>
        /// TDTA3.
        /// </summary>
        public const string TDTA3 = "TDTA3";

        /// <summary>
        /// TDTA4.
        /// </summary>
        public const string TDTA4 = "TDTA4";

        /// <summary>
        /// TDTA5.
        /// </summary>
        public const string TDTA5 = "TDTA5";

        /// <summary>
        /// TDSTA1.
        /// </summary>
        public const string TDSTA1 = "TDSTA1";

        /// <summary>
        /// TDSTA2.
        /// </summary>
        public const string TDSTA2 = "TDSTA2";

        /// <summary>
        /// TDSTA3.
        /// </summary>
        public const string TDSTA3 = "TDSTA3";

        /// <summary>
        /// TDSTA4.
        /// </summary>
        public const string TDSTA4 = "TDSTA4";

        /// <summary>
        /// TDSTA5.
        /// </summary>
        public const string TDSTA5 = "TDSTA5";

        /// <summary>
        /// TDAID.
        /// </summary>
        public const string TDAID = "TDAID";

        /// <summary>
        /// TDCO.
        /// </summary>
        public const string TDCO = "TDCO";

        /// <summary>
        /// TDAN8.
        /// </summary>
        public const string TDAN8 = "TDAN8";

        /// <summary>
        /// TDPYE.
        /// </summary>
        public const string TDPYE = "TDPYE";

        /// <summary>
        /// TDCRCD.
        /// </summary>
        public const string TDCRCD = "TDCRCD";

        /// <summary>
        /// TDCRRM.
        /// </summary>
        public const string TDCRRM = "TDCRRM";

        /// <summary>
        /// TDHCRR.
        /// </summary>
        public const string TDHCRR = "TDHCRR";

        /// <summary>
        /// TDCRR.
        /// </summary>
        public const string TDCRR = "TDCRR";

        /// <summary>
        /// TDY74RDPAY.
        /// </summary>
        public const string TDY74RDPAY = "TDY74RDPAY";

        /// <summary>
        /// TDRPD.
        /// </summary>
        public const string TDRPD = "TDRPD";

        /// <summary>
        /// TDY74RDREP.
        /// </summary>
        public const string TDY74RDREP = "TDY74RDREP";

        /// <summary>
        /// TDTNDI.
        /// </summary>
        public const string TDTNDI = "TDTNDI";

        /// <summary>
        /// TDY74RRA01.
        /// </summary>
        public const string TDY74RRA01 = "TDY74RRA01";

        /// <summary>
        /// TDY74RRA02.
        /// </summary>
        public const string TDY74RRA02 = "TDY74RRA02";

        /// <summary>
        /// TDY74RRA03.
        /// </summary>
        public const string TDY74RRA03 = "TDY74RRA03";

        /// <summary>
        /// TDY74RRA04.
        /// </summary>
        public const string TDY74RRA04 = "TDY74RRA04";

        /// <summary>
        /// TDY74RRA05.
        /// </summary>
        public const string TDY74RRA05 = "TDY74RRA05";

        /// <summary>
        /// TDEXR.
        /// </summary>
        public const string TDEXR = "TDEXR";

        /// <summary>
        /// TDCTR.
        /// </summary>
        public const string TDCTR = "TDCTR";

        /// <summary>
        /// TDY74RGTD.
        /// </summary>
        public const string TDY74RGTD = "TDY74RGTD";

        /// <summary>
        /// TDY74RDA01.
        /// </summary>
        public const string TDY74RDA01 = "TDY74RDA01";

        /// <summary>
        /// TDY74RDA02.
        /// </summary>
        public const string TDY74RDA02 = "TDY74RDA02";

        /// <summary>
        /// TDTXAM.
        /// </summary>
        public const string TDTXAM = "TDTXAM";

        /// <summary>
        /// TDY74RDA03.
        /// </summary>
        public const string TDY74RDA03 = "TDY74RDA03";

        /// <summary>
        /// TDY74RDA04.
        /// </summary>
        public const string TDY74RDA04 = "TDY74RDA04";

        /// <summary>
        /// TDY74RDA05.
        /// </summary>
        public const string TDY74RDA05 = "TDY74RDA05";

        /// <summary>
        /// TDPYID.
        /// </summary>
        public const string TDPYID = "TDPYID";

        /// <summary>
        /// TDRC5.
        /// </summary>
        public const string TDRC5 = "TDRC5";

        /// <summary>
        /// TDDMTJ.
        /// </summary>
        public const string TDDMTJ = "TDDMTJ";

        /// <summary>
        /// TDPFAP.
        /// </summary>
        public const string TDPFAP = "TDPFAP";

        /// <summary>
        /// TDY74RTXAR.
        /// </summary>
        public const string TDY74RTXAR = "TDY74RTXAR";

        /// <summary>
        /// TDY74RDALC.
        /// </summary>
        public const string TDY74RDALC = "TDY74RDALC";

        /// <summary>
        /// TDLT.
        /// </summary>
        public const string TDLT = "TDLT";

        /// <summary>
        /// TDJELN.
        /// </summary>
        public const string TDJELN = "TDJELN";

        /// <summary>
        /// TDEXTL.
        /// </summary>
        public const string TDEXTL = "TDEXTL";

        /// <summary>
        /// TDY74RPSRR.
        /// </summary>
        public const string TDY74RPSRR = "TDY74RPSRR";

        /// <summary>
        /// TDY74RPPRR.
        /// </summary>
        public const string TDY74RPPRR = "TDY74RPPRR";

        /// <summary>
        /// TDUSER.
        /// </summary>
        public const string TDUSER = "TDUSER";

        /// <summary>
        /// TDPID.
        /// </summary>
        public const string TDPID = "TDPID";

        /// <summary>
        /// TDJOBN.
        /// </summary>
        public const string TDJOBN = "TDJOBN";

        /// <summary>
        /// TDUPMJ.
        /// </summary>
        public const string TDUPMJ = "TDUPMJ";

        /// <summary>
        /// TDUPMT.
        /// </summary>
        public const string TDUPMT = "TDUPMT";

        /// <summary>
        /// TDPOST.
        /// </summary>
        public const string TDPOST = "TDPOST";
    }

    /// <inheritdoc />
    public override string TableName => "F74R0018";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TDY74RID", "TDY74RID", JdeDataType.Numeric, null, true, true),
        new JdeField("TDY74RID2", "TDY74RID2", JdeDataType.Numeric, null, true, true),
        new JdeField("TDY74RARAP", "TDY74RARAP", JdeDataType.String, 2),
        new JdeField("TDY74RATTN", "TDY74RATTN", JdeDataType.String, 2),
        new JdeField("TDKCO", "TDKCO", JdeDataType.String, 10),
        new JdeField("TDDOC", "TDDOC", JdeDataType.Numeric),
        new JdeField("TDDCT", "TDDCT", JdeDataType.String, 4),
        new JdeField("TDSFX", "TDSFX", JdeDataType.String, 6),
        new JdeField("TDSFXE", "TDSFXE", JdeDataType.Numeric),
        new JdeField("TDDCTA", "TDDCTA", JdeDataType.String, 4),
        new JdeField("TDVINV", "TDVINV", JdeDataType.String, 50),
        new JdeField("TDDIVJ", "TDDIVJ", JdeDataType.Numeric),
        new JdeField("TDDSVJ", "TDDSVJ", JdeDataType.Numeric),
        new JdeField("TDDGJ", "TDDGJ", JdeDataType.Numeric),
        new JdeField("TDAG", "TDAG", JdeDataType.Numeric),
        new JdeField("TDATXA", "TDATXA", JdeDataType.Numeric),
        new JdeField("TDATXN", "TDATXN", JdeDataType.Numeric),
        new JdeField("TDSTAM", "TDSTAM", JdeDataType.Numeric),
        new JdeField("TDACR", "TDACR", JdeDataType.Numeric),
        new JdeField("TDEXR1", "TDEXR1", JdeDataType.String, 4),
        new JdeField("TDIRDE", "TDIRDE", JdeDataType.String, 100),
        new JdeField("TDITM", "TDITM", JdeDataType.Numeric),
        new JdeField("TDTXA1", "TDTXA1", JdeDataType.String, 20),
        new JdeField("TDTXR1", "TDTXR1", JdeDataType.Numeric),
        new JdeField("TDTXR2", "TDTXR2", JdeDataType.Numeric),
        new JdeField("TDTXR3", "TDTXR3", JdeDataType.Numeric),
        new JdeField("TDTXR4", "TDTXR4", JdeDataType.Numeric),
        new JdeField("TDTXR5", "TDTXR5", JdeDataType.Numeric),
        new JdeField("TDTA1", "TDTA1", JdeDataType.Numeric),
        new JdeField("TDTA2", "TDTA2", JdeDataType.Numeric),
        new JdeField("TDTA3", "TDTA3", JdeDataType.Numeric),
        new JdeField("TDTA4", "TDTA4", JdeDataType.Numeric),
        new JdeField("TDTA5", "TDTA5", JdeDataType.Numeric),
        new JdeField("TDSTA1", "TDSTA1", JdeDataType.Numeric),
        new JdeField("TDSTA2", "TDSTA2", JdeDataType.Numeric),
        new JdeField("TDSTA3", "TDSTA3", JdeDataType.Numeric),
        new JdeField("TDSTA4", "TDSTA4", JdeDataType.Numeric),
        new JdeField("TDSTA5", "TDSTA5", JdeDataType.Numeric),
        new JdeField("TDAID", "TDAID", JdeDataType.String, 16),
        new JdeField("TDCO", "TDCO", JdeDataType.String, 10),
        new JdeField("TDAN8", "TDAN8", JdeDataType.Numeric),
        new JdeField("TDPYE", "TDPYE", JdeDataType.Numeric),
        new JdeField("TDCRCD", "TDCRCD", JdeDataType.String, 6),
        new JdeField("TDCRRM", "TDCRRM", JdeDataType.String, 2),
        new JdeField("TDHCRR", "TDHCRR", JdeDataType.Numeric),
        new JdeField("TDCRR", "TDCRR", JdeDataType.Numeric),
        new JdeField("TDY74RDPAY", "TDY74RDPAY", JdeDataType.Numeric),
        new JdeField("TDRPD", "TDRPD", JdeDataType.Numeric),
        new JdeField("TDY74RDREP", "TDY74RDREP", JdeDataType.Numeric),
        new JdeField("TDTNDI", "TDTNDI", JdeDataType.Numeric),
        new JdeField("TDY74RRA01", "TDY74RRA01", JdeDataType.String, 2),
        new JdeField("TDY74RRA02", "TDY74RRA02", JdeDataType.String, 2),
        new JdeField("TDY74RRA03", "TDY74RRA03", JdeDataType.String, 2),
        new JdeField("TDY74RRA04", "TDY74RRA04", JdeDataType.String, 2),
        new JdeField("TDY74RRA05", "TDY74RRA05", JdeDataType.String, 2),
        new JdeField("TDEXR", "TDEXR", JdeDataType.String, 60),
        new JdeField("TDCTR", "TDCTR", JdeDataType.String, 6),
        new JdeField("TDY74RGTD", "TDY74RGTD", JdeDataType.String, 60),
        new JdeField("TDY74RDA01", "TDY74RDA01", JdeDataType.Numeric),
        new JdeField("TDY74RDA02", "TDY74RDA02", JdeDataType.Numeric),
        new JdeField("TDTXAM", "TDTXAM", JdeDataType.Numeric),
        new JdeField("TDY74RDA03", "TDY74RDA03", JdeDataType.Numeric),
        new JdeField("TDY74RDA04", "TDY74RDA04", JdeDataType.Numeric),
        new JdeField("TDY74RDA05", "TDY74RDA05", JdeDataType.Numeric),
        new JdeField("TDPYID", "TDPYID", JdeDataType.Numeric),
        new JdeField("TDRC5", "TDRC5", JdeDataType.Numeric),
        new JdeField("TDDMTJ", "TDDMTJ", JdeDataType.Numeric),
        new JdeField("TDPFAP", "TDPFAP", JdeDataType.Numeric),
        new JdeField("TDY74RTXAR", "TDY74RTXAR", JdeDataType.Numeric),
        new JdeField("TDY74RDALC", "TDY74RDALC", JdeDataType.Numeric),
        new JdeField("TDLT", "TDLT", JdeDataType.String, 4),
        new JdeField("TDJELN", "TDJELN", JdeDataType.Numeric),
        new JdeField("TDEXTL", "TDEXTL", JdeDataType.String, 4),
        new JdeField("TDY74RPSRR", "TDY74RPSRR", JdeDataType.String, 2),
        new JdeField("TDY74RPPRR", "TDY74RPPRR", JdeDataType.String, 2),
        new JdeField("TDUSER", "TDUSER", JdeDataType.String, 20),
        new JdeField("TDPID", "TDPID", JdeDataType.String, 20),
        new JdeField("TDJOBN", "TDJOBN", JdeDataType.String, 20),
        new JdeField("TDUPMJ", "TDUPMJ", JdeDataType.Numeric),
        new JdeField("TDUPMT", "TDUPMT", JdeDataType.Numeric),
        new JdeField("TDPOST", "TDPOST", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R0018_0", "Primary Key on TDY74RID, TDY74RID2", new[] { "TDY74RID", "TDY74RID2" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R0018_10", "Index on TDDMTJ", new[] { "TDDMTJ" }),
        new JdeIndex("F74R0018_11", "Index on TDKCO, TDDOC, TDDCT, TDY74RATTN, TDEXR1, TDITM, TDTXA1", new[] { "TDKCO", "TDDOC", "TDDCT", "TDY74RATTN", "TDEXR1", "TDITM", "TDTXA1" }),
        new JdeIndex("F74R0018_12", "Index on TDKCO, TDDOC, TDDCT, TDSFX, TDSFXE, SYS_NC00082$, SYS_NC00083$", new[] { "TDKCO", "TDDOC", "TDDCT", "TDSFX", "TDSFXE", "SYS_NC00082$", "SYS_NC00083$" }),
        new JdeIndex("F74R0018_13", "Index on TDDCT, TDDOC, TDKCO, SYS_NC00084$, TDJELN, TDLT, TDEXTL", new[] { "TDDCT", "TDDOC", "TDKCO", "SYS_NC00084$", "TDJELN", "TDLT", "TDEXTL" }),
        new JdeIndex("F74R0018_14", "Index on TDKCO, TDDOC, TDDCT, TDSFX, TDSFXE, TDY74RDALC, SYS_NC00085$, TDY74RID, TDY74RID2", new[] { "TDKCO", "TDDOC", "TDDCT", "TDSFX", "TDSFXE", "TDY74RDALC", "SYS_NC00085$", "TDY74RID", "TDY74RID2" }),
        new JdeIndex("F74R0018_15", "Index on TDKCO, TDDOC, TDDCT, TDSFX, TDRPD, SYS_NC00086$, TDY74RID, TDY74RID2", new[] { "TDKCO", "TDDOC", "TDDCT", "TDSFX", "TDRPD", "SYS_NC00086$", "TDY74RID", "TDY74RID2" }),
        new JdeIndex("F74R0018_16", "Index on TDKCO, TDDOC, TDDCT, TDSFX, SYS_NC00087$, TDY74RDPAY, TDY74RID, TDY74RID2", new[] { "TDKCO", "TDDOC", "TDDCT", "TDSFX", "SYS_NC00087$", "TDY74RDPAY", "TDY74RID", "TDY74RID2" }),
        new JdeIndex("F74R0018_17", "Index on TDY74RARAP, TDTNDI", new[] { "TDY74RARAP", "TDTNDI" }),
        new JdeIndex("F74R0018_6", "Index on TDKCO, TDDOC, TDDCT, TDSFX, TDSFXE", new[] { "TDKCO", "TDDOC", "TDDCT", "TDSFX", "TDSFXE" }),
        new JdeIndex("F74R0018_7", "Index on TDY74RARAP, TDPYID, TDRC5", new[] { "TDY74RARAP", "TDPYID", "TDRC5" }),
        new JdeIndex("F74R0018_8", "Index on TDY74RDALC", new[] { "TDY74RDALC" })
    };
}
